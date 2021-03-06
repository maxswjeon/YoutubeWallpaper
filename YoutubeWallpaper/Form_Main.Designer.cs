﻿namespace YoutubeWallpaper
{
    partial class Form_Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_shuffle = new System.Windows.Forms.CheckBox();
            this.radioButton_type_list = new System.Windows.Forms.RadioButton();
            this.radioButton_type_one = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_apply = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.menuStrip_top = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_startup = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_hideController = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.wallpaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_toggleWallpaper = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_mute = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_nextScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_stopWallpaper = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_openBlog = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon_tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip_tray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_openController = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_stopWallpaperInTray = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_toggleWallpaperInTray = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_muteInTray = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_exitInTray = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.trackBar_volume = new System.Windows.Forms.TrackBar();
            this.toolTip_help = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton_toggleWhenOverlayed = new System.Windows.Forms.RadioButton();
            this.radioButton_muteWhenOverlayed = new System.Windows.Forms.RadioButton();
            this.radioButton_nothingWhenOverlayed = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip_top.SuspendLayout();
            this.contextMenuStrip_tray.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_shuffle);
            this.groupBox1.Controls.Add(this.radioButton_type_list);
            this.groupBox1.Controls.Add(this.radioButton_type_one);
            this.groupBox1.Location = new System.Drawing.Point(11, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(311, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            this.toolTip_help.SetToolTip(this.groupBox1, "ID 종류.");
            // 
            // checkBox_shuffle
            // 
            this.checkBox_shuffle.AutoSize = true;
            this.checkBox_shuffle.Location = new System.Drawing.Point(190, 24);
            this.checkBox_shuffle.Name = "checkBox_shuffle";
            this.checkBox_shuffle.Size = new System.Drawing.Size(83, 19);
            this.checkBox_shuffle.TabIndex = 2;
            this.checkBox_shuffle.Text = "Random";
            this.toolTip_help.SetToolTip(this.checkBox_shuffle, "재생 목록의 영상 순서를 랜덤하게 섞습니다.");
            this.checkBox_shuffle.UseVisualStyleBackColor = true;
            this.checkBox_shuffle.CheckedChanged += new System.EventHandler(this.checkBox_shuffle_CheckedChanged);
            // 
            // radioButton_type_list
            // 
            this.radioButton_type_list.AutoSize = true;
            this.radioButton_type_list.Location = new System.Drawing.Point(109, 24);
            this.radioButton_type_list.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_type_list.Name = "radioButton_type_list";
            this.radioButton_type_list.Size = new System.Drawing.Size(75, 19);
            this.radioButton_type_list.TabIndex = 1;
            this.radioButton_type_list.TabStop = true;
            this.radioButton_type_list.Text = "Playlist";
            this.toolTip_help.SetToolTip(this.radioButton_type_list, "하나 이상의 영상을 가지는 재생목록.");
            this.radioButton_type_list.UseVisualStyleBackColor = true;
            this.radioButton_type_list.CheckedChanged += new System.EventHandler(this.radioButton_type_list_CheckedChanged);
            // 
            // radioButton_type_one
            // 
            this.radioButton_type_one.AutoSize = true;
            this.radioButton_type_one.Location = new System.Drawing.Point(6, 24);
            this.radioButton_type_one.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_type_one.Name = "radioButton_type_one";
            this.radioButton_type_one.Size = new System.Drawing.Size(97, 19);
            this.radioButton_type_one.TabIndex = 0;
            this.radioButton_type_one.TabStop = true;
            this.radioButton_type_one.Text = "One video";
            this.toolTip_help.SetToolTip(this.radioButton_type_one, "재생목록이 아닌 하나의 영상.");
            this.radioButton_type_one.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_id);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(11, 102);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(311, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(32, 24);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(273, 25);
            this.textBox_id.TabIndex = 1;
            this.toolTip_help.SetToolTip(this.textBox_id, "동영상이나 재생목록의 아이디.");
            this.textBox_id.TextChanged += new System.EventHandler(this.textBox_id_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(10, 324);
            this.button_apply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(149, 38);
            this.button_apply.TabIndex = 4;
            this.button_apply.Text = "Start";
            this.toolTip_help.SetToolTip(this.button_apply, "설정을 저장하고 플레이어를 실행시킵니다.");
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(174, 324);
            this.button_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(149, 38);
            this.button_save.TabIndex = 5;
            this.button_save.Text = "Save";
            this.toolTip_help.SetToolTip(this.button_save, "옵션을 저장하기 전으로 되돌립니다.");
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // menuStrip_top
            // 
            this.menuStrip_top.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.wallpaperToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip_top.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_top.Name = "menuStrip_top";
            this.menuStrip_top.Size = new System.Drawing.Size(335, 28);
            this.menuStrip_top.TabIndex = 5;
            this.menuStrip_top.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_startup,
            this.ToolStripMenuItem_hideController,
            this.ToolStripMenuItem_exit});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // ToolStripMenuItem_startup
            // 
            this.ToolStripMenuItem_startup.CheckOnClick = true;
            this.ToolStripMenuItem_startup.Name = "ToolStripMenuItem_startup";
            this.ToolStripMenuItem_startup.Size = new System.Drawing.Size(261, 26);
            this.ToolStripMenuItem_startup.Text = "Start when windows starts";
            this.ToolStripMenuItem_startup.Click += new System.EventHandler(this.ToolStripMenuItem_startup_Click);
            // 
            // ToolStripMenuItem_hideController
            // 
            this.ToolStripMenuItem_hideController.Name = "ToolStripMenuItem_hideController";
            this.ToolStripMenuItem_hideController.Size = new System.Drawing.Size(261, 26);
            this.ToolStripMenuItem_hideController.Text = "Hide";
            this.ToolStripMenuItem_hideController.Click += new System.EventHandler(this.ToolStripMenuItem_hideController_Click);
            // 
            // ToolStripMenuItem_exit
            // 
            this.ToolStripMenuItem_exit.Name = "ToolStripMenuItem_exit";
            this.ToolStripMenuItem_exit.Size = new System.Drawing.Size(261, 26);
            this.ToolStripMenuItem_exit.Text = "Exit";
            this.ToolStripMenuItem_exit.Click += new System.EventHandler(this.ToolStripMenuItem_exit_Click);
            // 
            // wallpaperToolStripMenuItem
            // 
            this.wallpaperToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_toggleWallpaper,
            this.ToolStripMenuItem_mute,
            this.ToolStripMenuItem_nextScreen,
            this.ToolStripMenuItem_stopWallpaper});
            this.wallpaperToolStripMenuItem.Name = "wallpaperToolStripMenuItem";
            this.wallpaperToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.wallpaperToolStripMenuItem.Text = "Wallpaper";
            // 
            // ToolStripMenuItem_toggleWallpaper
            // 
            this.ToolStripMenuItem_toggleWallpaper.Name = "ToolStripMenuItem_toggleWallpaper";
            this.ToolStripMenuItem_toggleWallpaper.Size = new System.Drawing.Size(236, 26);
            this.ToolStripMenuItem_toggleWallpaper.Text = "Toggle";
            this.ToolStripMenuItem_toggleWallpaper.Click += new System.EventHandler(this.ToolStripMenuItem_toggleWallpaper_Click);
            // 
            // ToolStripMenuItem_mute
            // 
            this.ToolStripMenuItem_mute.Name = "ToolStripMenuItem_mute";
            this.ToolStripMenuItem_mute.Size = new System.Drawing.Size(236, 26);
            this.ToolStripMenuItem_mute.Text = "Mute";
            this.ToolStripMenuItem_mute.Click += new System.EventHandler(this.ToolStripMenuItem_mute_Click);
            // 
            // ToolStripMenuItem_nextScreen
            // 
            this.ToolStripMenuItem_nextScreen.Name = "ToolStripMenuItem_nextScreen";
            this.ToolStripMenuItem_nextScreen.Size = new System.Drawing.Size(236, 26);
            this.ToolStripMenuItem_nextScreen.Text = "Place on next monitor";
            this.ToolStripMenuItem_nextScreen.Click += new System.EventHandler(this.ToolStripMenuItem_nextScreen_Click);
            // 
            // ToolStripMenuItem_stopWallpaper
            // 
            this.ToolStripMenuItem_stopWallpaper.Name = "ToolStripMenuItem_stopWallpaper";
            this.ToolStripMenuItem_stopWallpaper.Size = new System.Drawing.Size(236, 26);
            this.ToolStripMenuItem_stopWallpaper.Text = "Close";
            this.ToolStripMenuItem_stopWallpaper.Click += new System.EventHandler(this.ToolStripMenuItem_stopWallpaper_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_openBlog});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // ToolStripMenuItem_openBlog
            // 
            this.ToolStripMenuItem_openBlog.Name = "ToolStripMenuItem_openBlog";
            this.ToolStripMenuItem_openBlog.Size = new System.Drawing.Size(115, 26);
            this.ToolStripMenuItem_openBlog.Text = "Blog";
            this.ToolStripMenuItem_openBlog.Click += new System.EventHandler(this.ToolStripMenuItem_openBlog_Click);
            // 
            // notifyIcon_tray
            // 
            this.notifyIcon_tray.ContextMenuStrip = this.contextMenuStrip_tray;
            this.notifyIcon_tray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_tray.Icon")));
            this.notifyIcon_tray.Text = "Youtube Wallpaper";
            this.notifyIcon_tray.BalloonTipClicked += new System.EventHandler(this.notifyIcon_tray_BalloonTipClicked);
            this.notifyIcon_tray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_tray_MouseDoubleClick);
            // 
            // contextMenuStrip_tray
            // 
            this.contextMenuStrip_tray.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_tray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_openController,
            this.ToolStripMenuItem_stopWallpaperInTray,
            this.ToolStripMenuItem_toggleWallpaperInTray,
            this.ToolStripMenuItem_muteInTray,
            this.ToolStripMenuItem_exitInTray});
            this.contextMenuStrip_tray.Name = "contextMenuStrip_tray";
            this.contextMenuStrip_tray.Size = new System.Drawing.Size(126, 124);
            // 
            // ToolStripMenuItem_openController
            // 
            this.ToolStripMenuItem_openController.Name = "ToolStripMenuItem_openController";
            this.ToolStripMenuItem_openController.Size = new System.Drawing.Size(125, 24);
            this.ToolStripMenuItem_openController.Text = "Open";
            this.ToolStripMenuItem_openController.Click += new System.EventHandler(this.ToolStripMenuItem_openController_Click);
            // 
            // ToolStripMenuItem_stopWallpaperInTray
            // 
            this.ToolStripMenuItem_stopWallpaperInTray.Name = "ToolStripMenuItem_stopWallpaperInTray";
            this.ToolStripMenuItem_stopWallpaperInTray.Size = new System.Drawing.Size(125, 24);
            this.ToolStripMenuItem_stopWallpaperInTray.Text = "Close";
            this.ToolStripMenuItem_stopWallpaperInTray.Click += new System.EventHandler(this.ToolStripMenuItem_stopWallpaperInTray_Click);
            // 
            // ToolStripMenuItem_toggleWallpaperInTray
            // 
            this.ToolStripMenuItem_toggleWallpaperInTray.Name = "ToolStripMenuItem_toggleWallpaperInTray";
            this.ToolStripMenuItem_toggleWallpaperInTray.Size = new System.Drawing.Size(125, 24);
            this.ToolStripMenuItem_toggleWallpaperInTray.Text = "Toggle";
            this.ToolStripMenuItem_toggleWallpaperInTray.Click += new System.EventHandler(this.ToolStripMenuItem_toggleWallpaperInTray_Click);
            // 
            // ToolStripMenuItem_muteInTray
            // 
            this.ToolStripMenuItem_muteInTray.Name = "ToolStripMenuItem_muteInTray";
            this.ToolStripMenuItem_muteInTray.Size = new System.Drawing.Size(125, 24);
            this.ToolStripMenuItem_muteInTray.Text = "Mute";
            this.ToolStripMenuItem_muteInTray.Click += new System.EventHandler(this.ToolStripMenuItem_muteInTray_Click);
            // 
            // ToolStripMenuItem_exitInTray
            // 
            this.ToolStripMenuItem_exitInTray.Name = "ToolStripMenuItem_exitInTray";
            this.ToolStripMenuItem_exitInTray.Size = new System.Drawing.Size(125, 24);
            this.ToolStripMenuItem_exitInTray.Text = "Exit";
            this.ToolStripMenuItem_exitInTray.Click += new System.EventHandler(this.ToolStripMenuItem_exitInTray_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.trackBar_volume);
            this.groupBox4.Location = new System.Drawing.Point(11, 172);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(311, 86);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Audio";
            // 
            // trackBar_volume
            // 
            this.trackBar_volume.LargeChange = 2;
            this.trackBar_volume.Location = new System.Drawing.Point(6, 24);
            this.trackBar_volume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar_volume.Maximum = 100;
            this.trackBar_volume.Name = "trackBar_volume";
            this.trackBar_volume.Size = new System.Drawing.Size(299, 56);
            this.trackBar_volume.TabIndex = 0;
            this.toolTip_help.SetToolTip(this.trackBar_volume, "오디오 볼륨 조절.");
            this.trackBar_volume.Scroll += new System.EventHandler(this.trackBar_volume_Scroll);
            // 
            // toolTip_help
            // 
            this.toolTip_help.AutoPopDelay = 8000;
            this.toolTip_help.InitialDelay = 500;
            this.toolTip_help.ReshowDelay = 100;
            this.toolTip_help.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_help.ToolTipTitle = "Help";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton_toggleWhenOverlayed);
            this.groupBox5.Controls.Add(this.radioButton_muteWhenOverlayed);
            this.groupBox5.Controls.Add(this.radioButton_nothingWhenOverlayed);
            this.groupBox5.Location = new System.Drawing.Point(11, 261);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(311, 55);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "When overlayed";
            this.toolTip_help.SetToolTip(this.groupBox5, "배경이 다른 전체화면 프로그램에 가려진 경우 수행할 작업.");
            // 
            // radioButton_toggleWhenOverlayed
            // 
            this.radioButton_toggleWhenOverlayed.AutoSize = true;
            this.radioButton_toggleWhenOverlayed.Location = new System.Drawing.Point(194, 24);
            this.radioButton_toggleWhenOverlayed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_toggleWhenOverlayed.Name = "radioButton_toggleWhenOverlayed";
            this.radioButton_toggleWhenOverlayed.Size = new System.Drawing.Size(72, 19);
            this.radioButton_toggleWhenOverlayed.TabIndex = 2;
            this.radioButton_toggleWhenOverlayed.Text = "Toggle";
            this.toolTip_help.SetToolTip(this.radioButton_toggleWhenOverlayed, "일시정지/재생 합니다.");
            this.radioButton_toggleWhenOverlayed.UseVisualStyleBackColor = true;
            this.radioButton_toggleWhenOverlayed.CheckedChanged += new System.EventHandler(this.radioButton_toggleWhenOverlayed_CheckedChanged);
            // 
            // radioButton_muteWhenOverlayed
            // 
            this.radioButton_muteWhenOverlayed.AutoSize = true;
            this.radioButton_muteWhenOverlayed.Location = new System.Drawing.Point(109, 24);
            this.radioButton_muteWhenOverlayed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_muteWhenOverlayed.Name = "radioButton_muteWhenOverlayed";
            this.radioButton_muteWhenOverlayed.Size = new System.Drawing.Size(60, 19);
            this.radioButton_muteWhenOverlayed.TabIndex = 1;
            this.radioButton_muteWhenOverlayed.Text = "Mute";
            this.toolTip_help.SetToolTip(this.radioButton_muteWhenOverlayed, "음소거 합니다.");
            this.radioButton_muteWhenOverlayed.UseVisualStyleBackColor = true;
            this.radioButton_muteWhenOverlayed.CheckedChanged += new System.EventHandler(this.radioButton_muteWhenOverlayed_CheckedChanged);
            // 
            // radioButton_nothingWhenOverlayed
            // 
            this.radioButton_nothingWhenOverlayed.AutoSize = true;
            this.radioButton_nothingWhenOverlayed.Location = new System.Drawing.Point(6, 24);
            this.radioButton_nothingWhenOverlayed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_nothingWhenOverlayed.Name = "radioButton_nothingWhenOverlayed";
            this.radioButton_nothingWhenOverlayed.Size = new System.Drawing.Size(77, 19);
            this.radioButton_nothingWhenOverlayed.TabIndex = 0;
            this.radioButton_nothingWhenOverlayed.Text = "Nothing";
            this.toolTip_help.SetToolTip(this.radioButton_nothingWhenOverlayed, "아무 작업도 하지 않습니다.");
            this.radioButton_nothingWhenOverlayed.UseVisualStyleBackColor = true;
            this.radioButton_nothingWhenOverlayed.CheckedChanged += new System.EventHandler(this.radioButton_nothingWhenOverlayed_CheckedChanged);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 375);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_top;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wallpaper controller";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_FormClosed);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip_top.ResumeLayout(false);
            this.menuStrip_top.PerformLayout();
            this.contextMenuStrip_tray.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_type_list;
        private System.Windows.Forms.RadioButton radioButton_type_one;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.MenuStrip menuStrip_top;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_hideController;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_exit;
        private System.Windows.Forms.ToolStripMenuItem wallpaperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_stopWallpaper;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_openBlog;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_startup;
        private System.Windows.Forms.NotifyIcon notifyIcon_tray;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_tray;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_openController;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_stopWallpaperInTray;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_exitInTray;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar trackBar_volume;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_mute;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_muteInTray;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_nextScreen;
        private System.Windows.Forms.ToolTip toolTip_help;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton_toggleWhenOverlayed;
        private System.Windows.Forms.RadioButton radioButton_muteWhenOverlayed;
        private System.Windows.Forms.RadioButton radioButton_nothingWhenOverlayed;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_toggleWallpaper;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_toggleWallpaperInTray;
        private System.Windows.Forms.CheckBox checkBox_shuffle;
    }
}

