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
    public partial class frm_AlarmVideoPlayer : Form
    {
        public static bool frm_AlarmVideoPLayer_Open;
        public frm_AlarmVideoPlayer()
        {
            InitializeComponent();
        }
        
        private void frm_AlarmVideoPlayer_Load(object sender, EventArgs e)
        {

            //player.playlist.add(Properties.Resources.Alarm.ToString(), null, null);
            //πρόσθεσε στην Playlist του media player το path του Media
            player.playlist.add("file:///" + frm_Main.AlarmObj[frm_Main.AlarmIndex_G].VideoPath, null, null);
            //Παιξε την παραπάνω Playlist
            player.playlist.play();
            
        }

        private void frm_AlarmVideoPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {

            MessageBox.Show("Allarm Message: "+frm_Main.AlarmObj[frm_Main.AlarmIndex_G].Info);
            frm_AlarmVideoPLayer_Open = false;
        }

        private void frm_AlarmVideoPlayer_Shown(object sender, EventArgs e)
        {
            frm_AlarmVideoPLayer_Open = true;
        }
    }
}
