using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

using Microsoft.Win32;

using System.Web.Script.Serialization;

namespace Timer
{

    public partial class frm_Main : Form
    {
        // The path to the key where Windows looks for startup applications
        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        
        frm_AddAlarm addform = new frm_AddAlarm();
        string jsonPath = Application.StartupPath + "\\Alarms.json";
        
        //Μετρητης για την παρακολούθηση του πλήθους των ξυπνητηριών
        int alarmsCount;
        
        

        //Global Variables

        //Μεταβλητή που ελέγχει αν έχει κλείσει η φόρμα AddAlarm
        public static bool AddformClose_G;
        //Μεταβλητή για τον  ελέγχο της περίπτωσης που ο χρήστης εισαγάγει νέο ξυπνητήρι απο την φόρμα AddAlarm
        public static bool btnAddFlag_G = false;
        public static bool btnEditFlag_G = false;
        //Μεταβλητή που στέλνει το index του ξυπνητηριού που ενεργοποιήθηκε στην φόρμα AlarmVideoPlayer
        public static int AlarmIndex_G;
        //Λίστα απο την κλάση Alarms που κρατάει τα ενεργά ξυπνητήρια
        public static List<Alarms> AlarmObj = new List<Alarms>();
        //Λίστα απο την κλάση ListId που ορίζει το Mode των ξυπνητηριών και δένεται με το
        //combobox από την φόρμα AddAlarms που είναι υπεύθυνο για την επιλογή Mode 
        public static List<ListId> CbxObj = new List<ListId>();
        public static bool AddBtn_G = false;
        public static bool EditAlarm_G = false;
        public static int EditIndex_G = -1;


        public frm_Main()
        {
            InitializeComponent();



            // Check to see the current state (running at startup or not)
            if (rkApp.GetValue("MyApp") == null)
            {
                // The value doesn't exist, the application is not set to run at startup
                mnu_StartWithWindows.Checked = false;
            }
            else
            {
                // The value exists, the application is set to run at startup
                mnu_StartWithWindows.Checked = true;
            }

        }

        //Event Που ενεργοποιείται κατά το κλείσιμο της φόρμας
        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Ακύρωσε την κληση για κλείσιμο της φόρμας
            e.Cancel = true;
            //Κάνε minimize την φόρμα
            this.WindowState = FormWindowState.Minimized;
            //Σώσε τα τρέχοντα ξυπνητήρια στο αρχείο Json
            SaveAlarm(jsonPath);
        }

        //Event Που ενεργοποιείται κατα το άνοιγμα της φόρμας
        private void frmMain_Load(object sender, EventArgs e)
        {
            //Αρχικοποίηση του Timer
            tmr_Clock.Interval = 100;
            tmr_Clock.Enabled = true;
            tmr_Clock.Start();
            lbl_CurrentTime.BackColor = Color.FromArgb(0, 0, 0);
            //Φόρτωσε τα ξυπνητήρια που έχουν σωθεί στο Json στην λίστα ξυπνητηριών του προγράμματος
            LoadAlarm(jsonPath);

        }


        //Μέθοδο που ελέγχει την ενεργοποίηση των ξυπνητηριών
        private void CheckForAlarm()
        {
            try
            {
                //Έλεγξε  τον χρόνο που απομένει για κάθε Ξυπνητήρι και περασέ τον στην λιστα
                for (int x = 0; x < alarmsCount; x++)
                {
                    AlarmObj[x].TmSp = AlarmObj[x].Date - DateTime.Now;
                    //Aν κάποιο ξυπνητήρι ενεργοποιηθεί και το checkbox είναι πατημένο
                    if ((AlarmObj[x].TSTotalSeconds <= 0 && AlarmObj[x].TSTotalSeconds > -0.200) && mnu_EnableAlarms.Checked)
                    {
                        //Κράτα το Index απο το Ξυπνητήρι που ενεργοποιήθηκε
                        AlarmIndex_G = x;

                        Alarms.AddExtraTime(AlarmObj[x]);
                        ListBoxRefresh();
                        // ανοιξε μια καινούρια φορμα Video Player
                        frm_AlarmVideoPlayer form = new frm_AlarmVideoPlayer();
                        form.Show();
                    }

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message + "  timespanerror");
            }
            if (frm_AlarmVideoPlayer.frm_AlarmVideoPLayer_Open)
            {
                ClockMove();
                lbl_CurrentTime.BackColor = ClockTools.ColorMode(5);
            }
            else
            {
                lbl_CurrentTime.BackColor = Color.Black;
            }
        }
      

        private void CheckForNewAlarm()
        {
            // Αν πατηθεί το κουμπί εισαγωγής καινούριου Ξυπνητηριού από την φόρμα AddAlarm
            if (btnAddFlag_G)
            {
                try
                {
                    //προσθεσε στο ListBox το καινουριο ξυπνητήρι
                    lstb_CurrentAlarms.Items.Add(AlarmObj[alarmsCount]);
                    //Ορισε το μετρητή ίσο με το μέγεθος της λίστας
                    alarmsCount = AlarmObj.Count;
                    //κατέβασε τη σημαία του κουμπιού εισαγωγής
                    btnAddFlag_G = false;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error " + exception.Message);
                }

            }
            else if (btnEditFlag_G)
            {
                ListBoxRefresh();
                btnEditFlag_G = false;
            }
            if (AddformClose_G)
            {
                chkb_AddAlarm.Checked = false;
               
            }
        }

        private int map(
            int originalStart, int originalEnd, // original range
            int newStart, int newEnd, // desired range
            int value) // value to convert
        {
            double scale = (double)(newEnd - newStart) / (originalEnd - originalStart);
            return (int)(newStart + ((value - originalStart) * scale));
        }

        private void ClockMove()
        {
            if (DateTime.Now.Millisecond <= 250 )
            {
                lbl_CurrentTime.Location = new Point((map(0, 250, 90, (this.ClientRectangle.Width - lbl_CurrentTime.Width - 90), DateTime.Now.Millisecond)), 24);
            }
            else if(DateTime.Now.Millisecond > 250 && DateTime.Now.Millisecond <= 500)
            {
                lbl_CurrentTime.Location = new Point((map(500, 250, 90, (this.ClientRectangle.Width - lbl_CurrentTime.Width - 90), DateTime.Now.Millisecond)), 24);

            }
            else if (DateTime.Now.Millisecond > 500 && DateTime.Now.Millisecond <= 750)
            {
                lbl_CurrentTime.Location = new Point((map(500, 750, 90, (this.ClientRectangle.Width - lbl_CurrentTime.Width - 90), DateTime.Now.Millisecond)), 24);
            }
            else
            {
                lbl_CurrentTime.Location = new Point((map(750, 1000, 90, (this.ClientRectangle.Width - lbl_CurrentTime.Width - 90), DateTime.Now.Millisecond)), 24);

            }
        }
        

        //Εvent του Timer

        private void tmr_Clock_Tick(object sender, EventArgs e)
        {
            lbl_Seconds.Text = DateTime.Now.Second.ToString();
            
                //Ανανέωνε το Label με την τρέχουσα Ώρα
                lbl_CurrentTime.Text = DateTime.Now.ToShortDateString() + "\n" + DateTime.Now.ToLongTimeString();
                lbl_CurrentTime.Location = new Point((int)((this.ClientRectangle.Width - lbl_CurrentTime.Width)/2), 24);
               
            CheckForAlarm();
            CheckForNewAlarm();

        }

        //Event που ενεργοποιείται κατα το πάτημα του Checkbox
        private void chkb_AddAlarm_CheckedChanged(object sender, EventArgs e)
        {

            //Αν το CheckBox Είναι πατημένο
            if (chkb_AddAlarm.Checked)
            {
                //Εμφάνισε την φόρμα Add Form και πέρασε στην static μεταβλητη την τιμή false
                addform.Show();
                AddformClose_G = false;
            }
            else
            {
                addform.Hide();
                AddformClose_G = true;
            }
        }



        //Event που ενεργοποιείται κατα το πάτημα μέσα το ListBox
        private void lstb_CurrentAlarms_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Ενεργοποιησε το κουμπί Remove
            btn_Remove.Enabled = true;
            btn_Edit.Enabled = true;
            //Αν δεν έχει επιλεγεί τιποτα από το Listbox
            if (lstb_CurrentAlarms.SelectedIndex == -1)
            {
                //Απενεργοποίησε το κουμπί Remove
                btn_Remove.Enabled = false;
                btn_Edit.Enabled = false;
            }
        }

        //Event που ενεργοποιείται κατα το πάτημα του κουμπιού Remove
        private void btn_Remove_Click(object sender, EventArgs e)
        {

            try
            {
                //Φτιαξε μια νεα μεταβλητή τύπου ListBox.SelectedObjectCollection που θα κρατάει τα στοιχεία που έχει επιλέξει
                //ο χρήστης απο το ListBox
                ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(lstb_CurrentAlarms);
                selectedItems = lstb_CurrentAlarms.SelectedItems;
                //Αν έχει επιλεγεί στοιχεία από το Listbox
                if (lstb_CurrentAlarms.SelectedIndex != -1)
                {
                    //αφαίρεσε τα στοιχεία απο το ListBox και απο την λίστα ξυπνητιριών
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                    {
                        lstb_CurrentAlarms.Items.Remove(selectedItems[i]);
                        AlarmObj.Remove(AlarmObj[i]);
                        //Ορισε την τιμή του μετρητή ίση με αυτή του πλήθους των στοιχείων της λίστας
                        alarmsCount = AlarmObj.Count;
                    }
                }

                else
                {
                    MessageBox.Show("fail");
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show( exception.Message);
            }

        }
        //Μέθοδος για το φόρτωμα των ξυπνητηριων στην λίστα απο το αρχείο Json
        private void LoadAlarm(string path)
        {
            
            try
            {
                AlarmObj.Clear();
                AlarmObj = JsonConvert.DeserializeObject<List<Alarms>>(System.IO.File.ReadAllText(path));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ListBoxRefresh();
        }
        private void ListBoxRefresh()
        {
            lstb_CurrentAlarms.Items.Clear();
            foreach (var obj in AlarmObj)
            {
                lstb_CurrentAlarms.Items.Add(obj);
            }
            // Όρισε το δείκτη ίσο με τον μέγεθος της λίστας
            alarmsCount = AlarmObj.Count;
        }

        //Μέθοδος για το σώσιμο της λίστας στο αρχείο Json
        private void SaveAlarm(string path)
        {

            try
            {
                //Καταχώρησε στην μεταβλητή contentsToWriteToFile τα στοιχεία της λίστας ξυπνητηριών
                string contentsToWriteToFile = Newtonsoft.Json.JsonConvert.SerializeObject(AlarmObj.ToArray(), Newtonsoft.Json.Formatting.Indented);

                //Πέρασε στο Json την παραπάνω μεταβλητή
                System.IO.File.WriteAllText(path, contentsToWriteToFile);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Event για το notufy icon
        private void notifyIcon_Main_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        //Event για το resize της φόρμας 
        //βγάζει την φόρμα απο το status bar και εμφανίζει μήνυμα στο system tray
        private void TrayMinimizerForm_Resize(object sender, EventArgs e)
        {
            notifyIcon_Main.BalloonTipTitle = "Minimize to Tray App";
            notifyIcon_Main.BalloonTipText = "Double Click to show again.";

            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon_Main.Visible = true;
                notifyIcon_Main.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon_Main.Visible = false;
            }
        }

        private void notifyIcon_Main_Click(object sender, EventArgs e)
        {

        }

        private void mnu_EnableAlarms_Click(object sender, EventArgs e)
        {
            mnu_EnableAlarms.Checked = !mnu_EnableAlarms.Checked;
            ntfMnu_EnableAlarms.Checked = !ntfMnu_EnableAlarms.Checked;

        }

        private void mnu_StartWithWindows_Click(object sender, EventArgs e)
        {
            mnu_StartWithWindows.Checked = !mnu_StartWithWindows.Checked;
            ntfMnu_RunWithWindows.Checked = !ntfMnu_RunWithWindows.Checked;
            if (mnu_StartWithWindows.Checked)
            {
                // Add the value in the registry so that the application runs at startup
                rkApp.SetValue("MyApp", Application.ExecutablePath);
            }
            else
            {
                // Remove the value from the registry so that the application doesn't start
                rkApp.DeleteValue("MyApp", false);
            }
        }

        private void mnu_About_Click(object sender, EventArgs e)
        {
            frm_About form = new frm_About();
            form.Show();
        }

        private void mnu_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            //Πέρνα στο πρακάτω αντικείμενο που είναι του τύπου SaveFileDialog να φιλτράρει τα αρχεία και να εμφανίζει μόνο τα json
            saveFile.Filter = "Json file (*.json)|*.json";
            //Εμφάνισε το saveFileDialog
            saveFile.ShowDialog();
            if (saveFile.FileName != string.Empty)
            {
                SaveAlarm(saveFile.FileName);
                notifyIcon_Main.BalloonTipTitle = "Save";
                notifyIcon_Main.BalloonTipText = "Save succesfully to file : " + saveFile.FileName;
                notifyIcon_Main.ShowBalloonTip(500);
            }



        }

        private void mnu_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog AmediaPath = new OpenFileDialog();
            //Πέρνα στο πρακάτω αντικείμενο που είναι του τύπου OpenFileDialog να φιλτράρει τα αρχεία και να εμφανίζει μόνο τα Mp4 kai mp3
            AmediaPath.Filter = "Json Files(*.json)|*.json|All files (*.*)|*.*";
            //Εμφάνισε το OpenFileDialog
            AmediaPath.ShowDialog();
            if (AmediaPath.FileName != string.Empty)
            {
                LoadAlarm(AmediaPath.FileName);
                notifyIcon_Main.BalloonTipTitle = "Load";
                notifyIcon_Main.BalloonTipText = "Load succesfully from file : " + AmediaPath.FileName;
                notifyIcon_Main.ShowBalloonTip(500);
            }
            ListBoxRefresh();
        }

        //Event - KeyDown - Τι θα κάνει όταν πατάμε τα κουμπιά
        private void frmEvents_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == (Keys.F11 | Keys.Control | Keys.Alt) ||
                e.KeyData == (Keys.Alt | Keys.Escape) ||
                e.KeyData == (Keys.Control | Keys.Pause) ||
                e.KeyData == (Keys.Shift | Keys.Scroll)) //Ψυφιακό OR ( | ) 
            {
                mnu_EnableAlarms.Checked = !mnu_EnableAlarms.Checked;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAlarm(jsonPath);
            Environment.Exit(1);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            //addform.dt_Picker
            EditIndex_G = lstb_CurrentAlarms.SelectedIndex;
            EditAlarm_G = true;
            if (chkb_AddAlarm.Checked)
            {
                chkb_AddAlarm.Checked = !chkb_AddAlarm.Checked;
                chkb_AddAlarm.Checked = !chkb_AddAlarm.Checked;
            }
            else
            {
                chkb_AddAlarm.Checked = !chkb_AddAlarm.Checked;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddBtn_G = true;
            EditAlarm_G = false;
            if (chkb_AddAlarm.Checked)
            {
                chkb_AddAlarm.Checked = !chkb_AddAlarm.Checked;
                chkb_AddAlarm.Checked = !chkb_AddAlarm.Checked;
            }
            else
            {
                chkb_AddAlarm.Checked = true;
            }
            
        }

        private void mnuInt_Minimize_Click(object sender, EventArgs e)
        {
            //Κάνε minimize την φόρμα
            this.WindowState = FormWindowState.Minimized;
            //Σώσε τα τρέχοντα ξυπνητήρια στο αρχείο Json
            SaveAlarm(jsonPath);
        }

        private void mnu_AnalogClock_Click(object sender, EventArgs e)
        {
            ClockTools.ClockStart();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnu_Mode1_Click(object sender, EventArgs e)
        {
            ClockTools.ClockStart(1);
        }

        private void mnu_Mode2_Click(object sender, EventArgs e)
        {
            ClockTools.ClockStart(2);
        }

        private void mnu_Mode3_Click(object sender, EventArgs e)
        {
            ClockTools.ClockStart(3);
        }

        private void mnu_Mode4_Click(object sender, EventArgs e)
        {
            ClockTools.ClockStart(4);
        }

        private void frm_Main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
