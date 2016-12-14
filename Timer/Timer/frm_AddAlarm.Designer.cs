namespace Timer
{
    partial class frm_AddAlarm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddAlarm));
            this.pnl_NewAlarm = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_Mode = new System.Windows.Forms.ComboBox();
            this.btn_SelectVideo = new System.Windows.Forms.Button();
            this.btn_AddAlarm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmr_Seconds = new System.Windows.Forms.NumericUpDown();
            this.nmr_Minutes = new System.Windows.Forms.NumericUpDown();
            this.txtb_Info = new System.Windows.Forms.TextBox();
            this.nmr_Hours = new System.Windows.Forms.NumericUpDown();
            this.dt_Picker = new System.Windows.Forms.DateTimePicker();
            this.nmr_Repeat = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_NewAlarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Seconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Hours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Repeat)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_NewAlarm
            // 
            this.pnl_NewAlarm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_NewAlarm.Controls.Add(this.nmr_Repeat);
            this.pnl_NewAlarm.Controls.Add(this.label7);
            this.pnl_NewAlarm.Controls.Add(this.label6);
            this.pnl_NewAlarm.Controls.Add(this.cbx_Mode);
            this.pnl_NewAlarm.Controls.Add(this.btn_SelectVideo);
            this.pnl_NewAlarm.Controls.Add(this.btn_AddAlarm);
            this.pnl_NewAlarm.Location = new System.Drawing.Point(12, 114);
            this.pnl_NewAlarm.Name = "pnl_NewAlarm";
            this.pnl_NewAlarm.Size = new System.Drawing.Size(254, 63);
            this.pnl_NewAlarm.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Add Music/Video:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Repeat Every:";
            // 
            // cbx_Mode
            // 
            this.cbx_Mode.FormattingEnabled = true;
            this.cbx_Mode.Location = new System.Drawing.Point(152, 5);
            this.cbx_Mode.Name = "cbx_Mode";
            this.cbx_Mode.Size = new System.Drawing.Size(96, 21);
            this.cbx_Mode.TabIndex = 12;
            // 
            // btn_SelectVideo
            // 
            this.btn_SelectVideo.AutoEllipsis = true;
            this.btn_SelectVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectVideo.Location = new System.Drawing.Point(101, 31);
            this.btn_SelectVideo.Name = "btn_SelectVideo";
            this.btn_SelectVideo.Size = new System.Drawing.Size(45, 23);
            this.btn_SelectVideo.TabIndex = 11;
            this.btn_SelectVideo.Text = "...";
            this.btn_SelectVideo.UseVisualStyleBackColor = true;
            this.btn_SelectVideo.Click += new System.EventHandler(this.btn_SelectVideo_Click);
            // 
            // btn_AddAlarm
            // 
            this.btn_AddAlarm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_AddAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddAlarm.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_AddAlarm.Location = new System.Drawing.Point(153, 32);
            this.btn_AddAlarm.Name = "btn_AddAlarm";
            this.btn_AddAlarm.Size = new System.Drawing.Size(95, 23);
            this.btn_AddAlarm.TabIndex = 10;
            this.btn_AddAlarm.Text = "Save Alarm";
            this.btn_AddAlarm.UseVisualStyleBackColor = false;
            this.btn_AddAlarm.Click += new System.EventHandler(this.btn_AddAlarm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Message:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Seconds:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Minutes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hours:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date:";
            // 
            // nmr_Seconds
            // 
            this.nmr_Seconds.Location = new System.Drawing.Point(203, 15);
            this.nmr_Seconds.Name = "nmr_Seconds";
            this.nmr_Seconds.Size = new System.Drawing.Size(45, 20);
            this.nmr_Seconds.TabIndex = 3;
            // 
            // nmr_Minutes
            // 
            this.nmr_Minutes.Location = new System.Drawing.Point(152, 16);
            this.nmr_Minutes.Name = "nmr_Minutes";
            this.nmr_Minutes.Size = new System.Drawing.Size(45, 20);
            this.nmr_Minutes.TabIndex = 2;
            // 
            // txtb_Info
            // 
            this.txtb_Info.Location = new System.Drawing.Point(6, 16);
            this.txtb_Info.Name = "txtb_Info";
            this.txtb_Info.Size = new System.Drawing.Size(242, 20);
            this.txtb_Info.TabIndex = 4;
            // 
            // nmr_Hours
            // 
            this.nmr_Hours.Location = new System.Drawing.Point(101, 16);
            this.nmr_Hours.Name = "nmr_Hours";
            this.nmr_Hours.Size = new System.Drawing.Size(45, 20);
            this.nmr_Hours.TabIndex = 1;
            // 
            // dt_Picker
            // 
            this.dt_Picker.AllowDrop = true;
            this.dt_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Picker.Location = new System.Drawing.Point(6, 16);
            this.dt_Picker.Name = "dt_Picker";
            this.dt_Picker.Size = new System.Drawing.Size(89, 20);
            this.dt_Picker.TabIndex = 0;
            // 
            // nmr_Repeat
            // 
            this.nmr_Repeat.Location = new System.Drawing.Point(101, 5);
            this.nmr_Repeat.Name = "nmr_Repeat";
            this.nmr_Repeat.Size = new System.Drawing.Size(45, 20);
            this.nmr_Repeat.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtb_Info);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 45);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dt_Picker);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.nmr_Seconds);
            this.panel2.Controls.Add(this.nmr_Minutes);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.nmr_Hours);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 45);
            this.panel2.TabIndex = 11;
            // 
            // frm_AddAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(281, 197);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_NewAlarm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_AddAlarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Alarm";
            this.Activated += new System.EventHandler(this.frm_AddAlarm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_AddAlarm_FormClosing);
            this.Load += new System.EventHandler(this.frm_AddAlarm_Load);
            this.pnl_NewAlarm.ResumeLayout(false);
            this.pnl_NewAlarm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Seconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Hours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_Repeat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_NewAlarm;
        private System.Windows.Forms.Button btn_SelectVideo;
        private System.Windows.Forms.Button btn_AddAlarm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmr_Seconds;
        private System.Windows.Forms.NumericUpDown nmr_Minutes;
        private System.Windows.Forms.TextBox txtb_Info;
        private System.Windows.Forms.NumericUpDown nmr_Hours;
        private System.Windows.Forms.DateTimePicker dt_Picker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_Mode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmr_Repeat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}