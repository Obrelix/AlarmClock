namespace Timer
{
    partial class frm_Main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripMenuItem mnu_Mode1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.lstb_CurrentAlarms = new System.Windows.Forms.ListBox();
            this.lbl_CurrentTime = new System.Windows.Forms.Label();
            this.tmr_Clock = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.chkb_AddAlarm = new System.Windows.Forms.CheckBox();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Load = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_EnableAlarms = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_StartWithWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_AnalogClock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Mode2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Mode3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Mode4 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ntfMnu_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ntfMnu_EnableAlarms = new System.Windows.Forms.ToolStripMenuItem();
            this.ntfMnu_RunWithWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ntfMnu_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.ntfMnu_Load = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ntfMnu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.ntfMnu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.cntxMnu_Intreval = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuInt_Minimize = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon_Main = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnl_AnalogClock = new System.Windows.Forms.Panel();
            this.cntxAC = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cntxAC_md1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxAC_md2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxAC_md3 = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxAC_md4 = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxAC_md5 = new System.Windows.Forms.ToolStripMenuItem();
            mnu_Mode1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.ntfMnu_Menu.SuspendLayout();
            this.cntxMnu_Intreval.SuspendLayout();
            this.cntxAC.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu_Mode1
            // 
            mnu_Mode1.Name = "mnu_Mode1";
            mnu_Mode1.Size = new System.Drawing.Size(114, 22);
            mnu_Mode1.Text = "Mode 1";
            mnu_Mode1.Click += new System.EventHandler(this.mnu_Mode1_Click);
            // 
            // lstb_CurrentAlarms
            // 
            this.lstb_CurrentAlarms.AllowDrop = true;
            this.lstb_CurrentAlarms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstb_CurrentAlarms.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lstb_CurrentAlarms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstb_CurrentAlarms.FormattingEnabled = true;
            this.lstb_CurrentAlarms.HorizontalScrollbar = true;
            this.lstb_CurrentAlarms.ItemHeight = 18;
            this.lstb_CurrentAlarms.Location = new System.Drawing.Point(10, 283);
            this.lstb_CurrentAlarms.Name = "lstb_CurrentAlarms";
            this.lstb_CurrentAlarms.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstb_CurrentAlarms.Size = new System.Drawing.Size(605, 148);
            this.lstb_CurrentAlarms.TabIndex = 5;
            this.lstb_CurrentAlarms.SelectedIndexChanged += new System.EventHandler(this.lstb_CurrentAlarms_SelectedIndexChanged);
            // 
            // lbl_CurrentTime
            // 
            this.lbl_CurrentTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_CurrentTime.AutoSize = true;
            this.lbl_CurrentTime.BackColor = System.Drawing.SystemColors.MenuText;
            this.lbl_CurrentTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_CurrentTime.Font = new System.Drawing.Font("Chaparral Pro", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentTime.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_CurrentTime.Location = new System.Drawing.Point(116, 50);
            this.lbl_CurrentTime.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_CurrentTime.Name = "lbl_CurrentTime";
            this.lbl_CurrentTime.Size = new System.Drawing.Size(388, 182);
            this.lbl_CurrentTime.TabIndex = 3;
            this.lbl_CurrentTime.Text = "3/12/2016\r\n5:36:50 μμ";
            this.lbl_CurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_CurrentTime.Click += new System.EventHandler(this.btn_AnalogClock_Click);
            // 
            // tmr_Clock
            // 
            this.tmr_Clock.Tick += new System.EventHandler(this.tmr_Clock_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Location = new System.Drawing.Point(10, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Current Alarms";
            // 
            // chkb_AddAlarm
            // 
            this.chkb_AddAlarm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkb_AddAlarm.AutoSize = true;
            this.chkb_AddAlarm.Location = new System.Drawing.Point(527, 260);
            this.chkb_AddAlarm.Name = "chkb_AddAlarm";
            this.chkb_AddAlarm.Size = new System.Drawing.Size(99, 17);
            this.chkb_AddAlarm.TabIndex = 8;
            this.chkb_AddAlarm.Text = "&Add New Alarm";
            this.chkb_AddAlarm.UseVisualStyleBackColor = false;
            this.chkb_AddAlarm.Visible = false;
            this.chkb_AddAlarm.CheckedChanged += new System.EventHandler(this.chkb_AddAlarm_CheckedChanged);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Remove.Enabled = false;
            this.btn_Remove.Location = new System.Drawing.Point(121, 441);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(57, 23);
            this.btn_Remove.TabIndex = 10;
            this.btn_Remove.Text = "&Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(626, 24);
            this.menuMain.TabIndex = 11;
            this.menuMain.Text = "Menu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Save,
            this.mnu_Load,
            this.mnu_EnableAlarms,
            this.mnu_StartWithWindows,
            this.mnu_AnalogClock});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "&Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // mnu_Save
            // 
            this.mnu_Save.Name = "mnu_Save";
            this.mnu_Save.Size = new System.Drawing.Size(176, 22);
            this.mnu_Save.Text = "&Save Alarms";
            this.mnu_Save.Click += new System.EventHandler(this.mnu_Save_Click);
            // 
            // mnu_Load
            // 
            this.mnu_Load.Name = "mnu_Load";
            this.mnu_Load.Size = new System.Drawing.Size(176, 22);
            this.mnu_Load.Text = "&Load Alarms";
            this.mnu_Load.Click += new System.EventHandler(this.mnu_Load_Click);
            // 
            // mnu_EnableAlarms
            // 
            this.mnu_EnableAlarms.Checked = true;
            this.mnu_EnableAlarms.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnu_EnableAlarms.Name = "mnu_EnableAlarms";
            this.mnu_EnableAlarms.Size = new System.Drawing.Size(176, 22);
            this.mnu_EnableAlarms.Text = "Enable Alarms";
            this.mnu_EnableAlarms.Click += new System.EventHandler(this.mnu_EnableAlarms_Click);
            // 
            // mnu_StartWithWindows
            // 
            this.mnu_StartWithWindows.Checked = true;
            this.mnu_StartWithWindows.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnu_StartWithWindows.Name = "mnu_StartWithWindows";
            this.mnu_StartWithWindows.Size = new System.Drawing.Size(176, 22);
            this.mnu_StartWithWindows.Text = "Start with Windows";
            this.mnu_StartWithWindows.Click += new System.EventHandler(this.mnu_StartWithWindows_Click);
            // 
            // mnu_AnalogClock
            // 
            this.mnu_AnalogClock.Checked = true;
            this.mnu_AnalogClock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnu_AnalogClock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            mnu_Mode1,
            this.mnu_Mode2,
            this.mnu_Mode3,
            this.mnu_Mode4});
            this.mnu_AnalogClock.Name = "mnu_AnalogClock";
            this.mnu_AnalogClock.Size = new System.Drawing.Size(176, 22);
            this.mnu_AnalogClock.Text = "Analog Clock";
            this.mnu_AnalogClock.Click += new System.EventHandler(this.mnu_AnalogClock_Click);
            // 
            // mnu_Mode2
            // 
            this.mnu_Mode2.Name = "mnu_Mode2";
            this.mnu_Mode2.Size = new System.Drawing.Size(114, 22);
            this.mnu_Mode2.Text = "Mode 2";
            this.mnu_Mode2.Click += new System.EventHandler(this.mnu_Mode2_Click);
            // 
            // mnu_Mode3
            // 
            this.mnu_Mode3.Name = "mnu_Mode3";
            this.mnu_Mode3.Size = new System.Drawing.Size(114, 22);
            this.mnu_Mode3.Text = "Mode 3";
            this.mnu_Mode3.Click += new System.EventHandler(this.mnu_Mode3_Click);
            // 
            // mnu_Mode4
            // 
            this.mnu_Mode4.Name = "mnu_Mode4";
            this.mnu_Mode4.Size = new System.Drawing.Size(114, 22);
            this.mnu_Mode4.Text = "Mode 4";
            this.mnu_Mode4.Click += new System.EventHandler(this.mnu_Mode4_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_About,
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "&Help";
            // 
            // mnu_About
            // 
            this.mnu_About.Name = "mnu_About";
            this.mnu_About.Size = new System.Drawing.Size(107, 22);
            this.mnu_About.Text = "A&bout";
            this.mnu_About.Click += new System.EventHandler(this.mnu_About_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // ntfMnu_Menu
            // 
            this.ntfMnu_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ntfMnu_EnableAlarms,
            this.ntfMnu_RunWithWindows,
            this.toolStripSeparator1,
            this.ntfMnu_Save,
            this.ntfMnu_Load,
            this.toolStripSeparator2,
            this.ntfMnu_About,
            this.ntfMnu_Exit});
            this.ntfMnu_Menu.Name = "ntfMnu_Menu";
            this.ntfMnu_Menu.Size = new System.Drawing.Size(174, 148);
            // 
            // ntfMnu_EnableAlarms
            // 
            this.ntfMnu_EnableAlarms.Checked = true;
            this.ntfMnu_EnableAlarms.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ntfMnu_EnableAlarms.Name = "ntfMnu_EnableAlarms";
            this.ntfMnu_EnableAlarms.Size = new System.Drawing.Size(173, 22);
            this.ntfMnu_EnableAlarms.Text = "Enable Alarms";
            this.ntfMnu_EnableAlarms.Click += new System.EventHandler(this.mnu_EnableAlarms_Click);
            // 
            // ntfMnu_RunWithWindows
            // 
            this.ntfMnu_RunWithWindows.Checked = true;
            this.ntfMnu_RunWithWindows.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ntfMnu_RunWithWindows.Name = "ntfMnu_RunWithWindows";
            this.ntfMnu_RunWithWindows.Size = new System.Drawing.Size(173, 22);
            this.ntfMnu_RunWithWindows.Text = "Run with Windows";
            this.ntfMnu_RunWithWindows.Click += new System.EventHandler(this.mnu_StartWithWindows_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // ntfMnu_Save
            // 
            this.ntfMnu_Save.Name = "ntfMnu_Save";
            this.ntfMnu_Save.Size = new System.Drawing.Size(173, 22);
            this.ntfMnu_Save.Text = "Save";
            this.ntfMnu_Save.Click += new System.EventHandler(this.mnu_Save_Click);
            // 
            // ntfMnu_Load
            // 
            this.ntfMnu_Load.Name = "ntfMnu_Load";
            this.ntfMnu_Load.Size = new System.Drawing.Size(173, 22);
            this.ntfMnu_Load.Text = "Load";
            this.ntfMnu_Load.Click += new System.EventHandler(this.mnu_Load_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(170, 6);
            // 
            // ntfMnu_About
            // 
            this.ntfMnu_About.Name = "ntfMnu_About";
            this.ntfMnu_About.Size = new System.Drawing.Size(173, 22);
            this.ntfMnu_About.Text = "About";
            this.ntfMnu_About.Click += new System.EventHandler(this.mnu_About_Click);
            // 
            // ntfMnu_Exit
            // 
            this.ntfMnu_Exit.Name = "ntfMnu_Exit";
            this.ntfMnu_Exit.Size = new System.Drawing.Size(173, 22);
            this.ntfMnu_Exit.Text = "Exit";
            this.ntfMnu_Exit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Edit.Enabled = false;
            this.btn_Edit.Location = new System.Drawing.Point(58, 441);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(57, 23);
            this.btn_Edit.TabIndex = 12;
            this.btn_Edit.Text = "&Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.Location = new System.Drawing.Point(10, 441);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(42, 23);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "Add";
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // cntxMnu_Intreval
            // 
            this.cntxMnu_Intreval.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInt_Minimize,
            this.aboutToolStripMenuItem1});
            this.cntxMnu_Intreval.Name = "contextMenuStrip1";
            this.cntxMnu_Intreval.Size = new System.Drawing.Size(163, 48);
            this.cntxMnu_Intreval.Text = "Menu";
            // 
            // mnuInt_Minimize
            // 
            this.mnuInt_Minimize.Name = "mnuInt_Minimize";
            this.mnuInt_Minimize.Size = new System.Drawing.Size(162, 22);
            this.mnuInt_Minimize.Text = "Minimize to Tray";
            this.mnuInt_Minimize.Click += new System.EventHandler(this.mnuInt_Minimize_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.mnu_About_Click);
            // 
            // notifyIcon_Main
            // 
            this.notifyIcon_Main.ContextMenuStrip = this.ntfMnu_Menu;
            this.notifyIcon_Main.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_Main.Icon")));
            this.notifyIcon_Main.Text = "Alarms";
            this.notifyIcon_Main.Visible = true;
            this.notifyIcon_Main.Click += new System.EventHandler(this.notifyIcon_Main_Click);
            this.notifyIcon_Main.DoubleClick += new System.EventHandler(this.notifyIcon_Main_DoubleClick);
            // 
            // pnl_AnalogClock
            // 
            this.pnl_AnalogClock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl_AnalogClock.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_AnalogClock.ContextMenuStrip = this.cntxAC;
            this.pnl_AnalogClock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_AnalogClock.Location = new System.Drawing.Point(183, 12);
            this.pnl_AnalogClock.Name = "pnl_AnalogClock";
            this.pnl_AnalogClock.Size = new System.Drawing.Size(250, 250);
            this.pnl_AnalogClock.TabIndex = 15;
            this.pnl_AnalogClock.Click += new System.EventHandler(this.btn_AnalogClock_Click);
            // 
            // cntxAC
            // 
            this.cntxAC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cntxAC_md1,
            this.cntxAC_md2,
            this.cntxAC_md3,
            this.cntxAC_md4,
            this.cntxAC_md5});
            this.cntxAC.Name = "cntxAC";
            this.cntxAC.Size = new System.Drawing.Size(115, 114);
            // 
            // cntxAC_md1
            // 
            this.cntxAC_md1.Name = "cntxAC_md1";
            this.cntxAC_md1.Size = new System.Drawing.Size(114, 22);
            this.cntxAC_md1.Text = "Mode 1";
            this.cntxAC_md1.Click += new System.EventHandler(this.cntxAC_md1_Click);
            // 
            // cntxAC_md2
            // 
            this.cntxAC_md2.Name = "cntxAC_md2";
            this.cntxAC_md2.Size = new System.Drawing.Size(114, 22);
            this.cntxAC_md2.Text = "Mode 2";
            this.cntxAC_md2.Click += new System.EventHandler(this.cntxAC_md2_Click);
            // 
            // cntxAC_md3
            // 
            this.cntxAC_md3.Name = "cntxAC_md3";
            this.cntxAC_md3.Size = new System.Drawing.Size(114, 22);
            this.cntxAC_md3.Text = "Mode 3";
            this.cntxAC_md3.Click += new System.EventHandler(this.cntxAC_md3_Click);
            // 
            // cntxAC_md4
            // 
            this.cntxAC_md4.Name = "cntxAC_md4";
            this.cntxAC_md4.Size = new System.Drawing.Size(114, 22);
            this.cntxAC_md4.Text = "Mode 4";
            this.cntxAC_md4.Click += new System.EventHandler(this.cntxAC_md4_Click);
            // 
            // cntxAC_md5
            // 
            this.cntxAC_md5.Name = "cntxAC_md5";
            this.cntxAC_md5.Size = new System.Drawing.Size(114, 22);
            this.cntxAC_md5.Text = "Mode 5";
            this.cntxAC_md5.Click += new System.EventHandler(this.cntxAC_md5_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(626, 476);
            this.ContextMenuStrip = this.cntxMnu_Intreval;
            this.Controls.Add(this.pnl_AnalogClock);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.chkb_AddAlarm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstb_CurrentAlarms);
            this.Controls.Add(this.lbl_CurrentTime);
            this.Controls.Add(this.menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 515);
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarms";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frm_Main_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEvents_KeyDown);
            this.Resize += new System.EventHandler(this.TrayMinimizerForm_Resize);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ntfMnu_Menu.ResumeLayout(false);
            this.cntxMnu_Intreval.ResumeLayout(false);
            this.cntxAC.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstb_CurrentAlarms;
        private System.Windows.Forms.Label lbl_CurrentTime;
        private System.Windows.Forms.Timer tmr_Clock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkb_AddAlarm;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.NotifyIcon notifyIcon_Main;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_EnableAlarms;
        private System.Windows.Forms.ToolStripMenuItem mnu_StartWithWindows;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_About;
        private System.Windows.Forms.ToolStripMenuItem mnu_Save;
        private System.Windows.Forms.ToolStripMenuItem mnu_Load;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ntfMnu_Menu;
        private System.Windows.Forms.ToolStripMenuItem ntfMnu_Exit;
        private System.Windows.Forms.ToolStripMenuItem ntfMnu_Save;
        private System.Windows.Forms.ToolStripMenuItem ntfMnu_Load;
        private System.Windows.Forms.ToolStripMenuItem ntfMnu_EnableAlarms;
        private System.Windows.Forms.ToolStripMenuItem ntfMnu_RunWithWindows;
        private System.Windows.Forms.ToolStripMenuItem ntfMnu_About;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ContextMenuStrip cntxMnu_Intreval;
        private System.Windows.Forms.ToolStripMenuItem mnuInt_Minimize;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnu_AnalogClock;
        private System.Windows.Forms.ToolStripMenuItem mnu_Mode2;
        private System.Windows.Forms.ToolStripMenuItem mnu_Mode3;
        private System.Windows.Forms.ToolStripMenuItem mnu_Mode4;
        private System.Windows.Forms.Panel pnl_AnalogClock;
        private System.Windows.Forms.ContextMenuStrip cntxAC;
        private System.Windows.Forms.ToolStripMenuItem cntxAC_md1;
        private System.Windows.Forms.ToolStripMenuItem cntxAC_md2;
        private System.Windows.Forms.ToolStripMenuItem cntxAC_md3;
        private System.Windows.Forms.ToolStripMenuItem cntxAC_md4;
        private System.Windows.Forms.ToolStripMenuItem cntxAC_md5;
    }
}

