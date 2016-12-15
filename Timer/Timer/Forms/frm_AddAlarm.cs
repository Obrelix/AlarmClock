using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class frm_AddAlarm : Form
    {

        OpenFileDialog AmediaPath = new OpenFileDialog();
        public frm_AddAlarm()
        {
            InitializeComponent();

            frm_Main.CbxObj.Add(new ListId(0, "Weeks"));
            frm_Main.CbxObj.Add(new ListId(1, "Days"));
            frm_Main.CbxObj.Add(new ListId(2, "Hours"));
            frm_Main.CbxObj.Add(new ListId(3, "Minutes"));
            frm_Main.CbxObj.Add(new ListId(4, "Seconds"));
            cbx_Mode.DataSource = frm_Main.CbxObj;
            cbx_Mode.DisplayMember = "Descr";
            cbx_Mode.ValueMember = "Mode";
            cbx_Mode.SelectedIndex = 3;

        }

        

        private void btn_AddAlarm_Click(object sender, EventArgs e)
        {
            SaveForm();
        }
        private void SaveForm()
        {
            try
            {
                //καταχώρησε σε μεταβλητή τύπου DateTime την τιμή απο το DateTime Picker Control του UI
                //Κάνουμε αυτό το βήμα γιατί το Control DayTimePicker δεν έχει ιδιότητες για να εξάγουμε από αυτό λεπτά, ώρες και δευτερόλεπτα
                DateTime dtpicker = new DateTime();
                dtpicker = dt_Picker.Value;
                // φτιάξε ένα καινούριο ξυπνητήρι και καταχώριησέ το στη λίστα 
                if (frm_Main.EditAlarm_G)
                {
                    frm_Main.AlarmObj[frm_Main.EditIndex_G].Info = txtb_Info.Text;
                    frm_Main.AlarmObj[frm_Main.EditIndex_G].Date = new DateTime(dtpicker.Year, dtpicker.Month, dtpicker.Day, (int)nmr_Hours.Value, (int)nmr_Minutes.Value, (int)nmr_Seconds.Value);
                    frm_Main.AlarmObj[frm_Main.EditIndex_G].Mode = cbx_Mode.SelectedIndex;
                    frm_Main.AlarmObj[frm_Main.EditIndex_G].ModeValue = (int)nmr_Repeat.Value;
                    frm_Main.AlarmObj[frm_Main.EditIndex_G].VideoPath = AmediaPath.FileName;
                    frm_Main.btnEditFlag_G = true;
                    frm_Main.EditAlarm_G = false;
                    frm_Main.AddformClose_G = true;


                }
                else
                {

                    frm_Main.AlarmObj.Add(new Alarms(txtb_Info.Text,
                    (new DateTime(dtpicker.Year, dtpicker.Month, dtpicker.Day, (int)nmr_Hours.Value, (int)nmr_Minutes.Value, (int)nmr_Seconds.Value)),
                    AmediaPath.FileName, frm_Main.CbxObj[cbx_Mode.SelectedIndex].Mode,
                    frm_Main.CbxObj[cbx_Mode.SelectedIndex].Descr,
                    (int)nmr_Repeat.Value));

                    frm_Main.btnAddFlag_G = true;
                    frm_Main.AddformClose_G = true;
                }


                //διαφορετικά όρισε για Path to αρχικό ξυπνητήρι


            }
            catch (Exception exception)
            {
                MessageBox.Show("Error " + exception.Message);
            }
        }
        //Event που ενεργοποιείται κατα το πάτημα του κουμπιού Select Video
        private void btn_SelectVideo_Click(object sender, EventArgs e)
        {
            AmediaPath.InitialDirectory = Application.StartupPath;
            //Πέρνα στο πρακάτω αντικείμενο που είναι του τύπου OpenFileDialog να φιλτράρει τα αρχεία και να εμφανίζει μόνο τα Mp4 kai mp3
            AmediaPath.Filter = "Media Files|*.mp3;*.mp4;*.wav;*.avi;*.wma;*.mkv;*.flv;*.wmv;*.flac|All files (*.*)|*.*";
            //Εμφάνισε το OpenFileDialog
            AmediaPath.ShowDialog();
        }

        private void frm_AddAlarm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            ////Πέρασε τα Numeric τισ τιμές της τρέχοντος ώρας
            //this.BackColor = SystemColors.ActiveCaption;
            //this.TransparencyKey = SystemColors.ActiveCaption;
        }

        

        private void frm_AddAlarm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.WindowState = FormWindowState.Normal;
            frm_Main.AddformClose_G = true;
        }
        

        private void frm_AddAlarm_Activated(object sender, EventArgs e)
        {
            if (frm_Main.EditAlarm_G && frm_Main.EditIndex_G != -1)
            {
                try
                {
                    btn_AddAlarm.Text = "Save Changes";
                    txtb_Info.Text = frm_Main.AlarmObj[frm_Main.EditIndex_G].Info;
                    dt_Picker.Value = frm_Main.AlarmObj[frm_Main.EditIndex_G].Date;
                    nmr_Hours.Value = frm_Main.AlarmObj[frm_Main.EditIndex_G].Hours;
                    nmr_Minutes.Value = frm_Main.AlarmObj[frm_Main.EditIndex_G].Minutes;
                    nmr_Seconds.Value = frm_Main.AlarmObj[frm_Main.EditIndex_G].Seconds;
                    cbx_Mode.SelectedIndex = frm_Main.AlarmObj[frm_Main.EditIndex_G].Mode;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error " + exception.Message);
                }
            }
            else if (frm_Main.AddBtn_G)
            {
                btn_AddAlarm.Text = "Save Alarm";
                nmr_Seconds.Value = DateTime.Now.Second;
                nmr_Minutes.Value = DateTime.Now.Minute;
                nmr_Hours.Value = DateTime.Now.Hour;
                dt_Picker.Value = DateTime.Now;
            }
        }

        private void nmr_Hours_ValueChanged(object sender, EventArgs e)
        {
            if (nmr_Hours.Value >= nmr_Hours.Maximum)
            {
                nmr_Hours.Value = nmr_Hours.Minimum;
            }
            if (nmr_Minutes.Value >= nmr_Minutes.Maximum)
            {
                nmr_Minutes.Value = nmr_Minutes.Minimum;
                nmr_Hours.Value++;
            }
            if(nmr_Seconds.Value >= nmr_Seconds.Maximum)
            {
                nmr_Seconds.Value = nmr_Seconds.Minimum;
                nmr_Minutes.Value++;
            }
        }

        private void frm_AddAlarm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Return  || 
                e.KeyData == (Keys.Control | Keys.S))
            {
                SaveForm();
            }
        }
    }
}
