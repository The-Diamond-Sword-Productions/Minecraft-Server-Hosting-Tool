﻿namespace Minecraft_Server_Hosting_Tool
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bar = new System.Windows.Forms.Panel();
            this.barLbl = new System.Windows.Forms.Label();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.topLeftLogo = new System.Windows.Forms.PictureBox();
            this.sideBar = new System.Windows.Forms.Panel();
            this.serverPropertiesBtn = new System.Windows.Forms.Button();
            this.reinstallServerBtn = new System.Windows.Forms.Button();
            this.moreLbl = new System.Windows.Forms.Label();
            this.managePluginsBtn = new System.Windows.Forms.Button();
            this.pluginsLbl = new System.Windows.Forms.Label();
            this.backupsBtn = new System.Windows.Forms.Button();
            this.consoleBtn = new System.Windows.Forms.Button();
            this.worldsBtn = new System.Windows.Forms.Button();
            this.banListBtn = new System.Windows.Forms.Button();
            this.whiteListBtn = new System.Windows.Forms.Button();
            this.operatorsBtn = new System.Windows.Forms.Button();
            this.playersLbl = new System.Windows.Forms.Label();
            this.onlinePlayersBtn = new System.Windows.Forms.Button();
            this.servFilesBtn = new System.Windows.Forms.Button();
            this.createServLbl = new System.Windows.Forms.Label();
            this.installServBtn = new System.Windows.Forms.Button();
            this.editServLbl = new System.Windows.Forms.Label();
            this.selectServLbl = new System.Windows.Forms.Label();
            this.editLaunchOptBtn = new System.Windows.Forms.Button();
            this.browseServsBtn = new System.Windows.Forms.Button();
            this.openSideBarBtn = new System.Windows.Forms.Button();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.installServTab = new System.Windows.Forms.TabPage();
            this.installProgressGrouBox = new System.Windows.Forms.GroupBox();
            this.installStatusLbl = new System.Windows.Forms.Label();
            this.installProgressBar = new System.Windows.Forms.ProgressBar();
            this.noEditWhileInstallPan = new System.Windows.Forms.Panel();
            this.serverNameSetLbl = new System.Windows.Forms.Label();
            this.serverName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.autoDirectoryLbl = new System.Windows.Forms.Label();
            this.autoDirectory = new System.Windows.Forms.CheckBox();
            this.serverInstallPath = new System.Windows.Forms.TextBox();
            this.installNewServerBtn = new System.Windows.Forms.Button();
            this.installServPanLbl = new System.Windows.Forms.Label();
            this.GBradioBtn = new System.Windows.Forms.RadioButton();
            this.serverInstallPathLbl = new System.Windows.Forms.Label();
            this.MBradioBtn = new System.Windows.Forms.RadioButton();
            this.browseServerInstallPathBtn = new System.Windows.Forms.Button();
            this.allocatedRam = new System.Windows.Forms.ComboBox();
            this.serverInstallTypeLbl = new System.Windows.Forms.Label();
            this.allocatedRamLbl = new System.Windows.Forms.Label();
            this.serverInstallType = new System.Windows.Forms.ComboBox();
            this.dragDropCustomServ = new System.Windows.Forms.Label();
            this.serverInstallVersionLbl = new System.Windows.Forms.Label();
            this.dragDropCustomServer = new System.Windows.Forms.Panel();
            this.serverInstallVersion = new System.Windows.Forms.ComboBox();
            this.welcomeTab = new System.Windows.Forms.TabPage();
            this.importServerBtn = new System.Windows.Forms.Button();
            this.serversListLbl = new System.Windows.Forms.Label();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.TabPage();
            this.editServerStartOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.separatorPanServerEditStartOptions = new System.Windows.Forms.Panel();
            this.saveChangesServerStartOptionsBtn = new System.Windows.Forms.Button();
            this.startServerPropertiesBtn = new System.Windows.Forms.Button();
            this.restartServerIfCrash = new System.Windows.Forms.CheckBox();
            this.serverStartAllocatedRamLbl = new System.Windows.Forms.Label();
            this.startGBradioBtn = new System.Windows.Forms.RadioButton();
            this.serverStartAllocatedRam = new System.Windows.Forms.ComboBox();
            this.startMBradioBtn = new System.Windows.Forms.RadioButton();
            this.startServerBtn = new System.Windows.Forms.Button();
            this.StartServerLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.serverNameLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.serverRunning = new System.Windows.Forms.Label();
            this.hideBorderPan1 = new System.Windows.Forms.Panel();
            this.bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topLeftLogo)).BeginInit();
            this.sideBar.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.installServTab.SuspendLayout();
            this.installProgressGrouBox.SuspendLayout();
            this.noEditWhileInstallPan.SuspendLayout();
            this.welcomeTab.SuspendLayout();
            this.Start.SuspendLayout();
            this.editServerStartOptionsGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.DimGray;
            this.bar.Controls.Add(this.barLbl);
            this.bar.Controls.Add(this.minimizeBtn);
            this.bar.Controls.Add(this.closeBtn);
            this.bar.Location = new System.Drawing.Point(0, 0);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(800, 34);
            this.bar.TabIndex = 0;
            this.bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bar_mouseDown);
            // 
            // barLbl
            // 
            this.barLbl.AutoSize = true;
            this.barLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barLbl.ForeColor = System.Drawing.Color.White;
            this.barLbl.Location = new System.Drawing.Point(41, 7);
            this.barLbl.Name = "barLbl";
            this.barLbl.Size = new System.Drawing.Size(396, 20);
            this.barLbl.TabIndex = 3;
            this.barLbl.Text = "Minecraft Server Hosting Tool - Not any server selected";
            this.barLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bar_mouseDown);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.ForeColor = System.Drawing.Color.White;
            this.minimizeBtn.Location = new System.Drawing.Point(733, 0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(34, 34);
            this.minimizeBtn.TabIndex = 2;
            this.minimizeBtn.Text = "_";
            this.minimizeBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(766, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(34, 34);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "✕";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // topLeftLogo
            // 
            this.topLeftLogo.BackColor = System.Drawing.Color.DimGray;
            this.topLeftLogo.Image = global::Minecraft_Server_Hosting_Tool.Properties.Resources.MSHT;
            this.topLeftLogo.Location = new System.Drawing.Point(0, 1);
            this.topLeftLogo.Name = "topLeftLogo";
            this.topLeftLogo.Size = new System.Drawing.Size(35, 33);
            this.topLeftLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.topLeftLogo.TabIndex = 1;
            this.topLeftLogo.TabStop = false;
            this.topLeftLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bar_mouseDown);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.White;
            this.sideBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sideBar.Controls.Add(this.serverPropertiesBtn);
            this.sideBar.Controls.Add(this.reinstallServerBtn);
            this.sideBar.Controls.Add(this.moreLbl);
            this.sideBar.Controls.Add(this.managePluginsBtn);
            this.sideBar.Controls.Add(this.pluginsLbl);
            this.sideBar.Controls.Add(this.backupsBtn);
            this.sideBar.Controls.Add(this.consoleBtn);
            this.sideBar.Controls.Add(this.worldsBtn);
            this.sideBar.Controls.Add(this.banListBtn);
            this.sideBar.Controls.Add(this.whiteListBtn);
            this.sideBar.Controls.Add(this.operatorsBtn);
            this.sideBar.Controls.Add(this.playersLbl);
            this.sideBar.Controls.Add(this.onlinePlayersBtn);
            this.sideBar.Controls.Add(this.servFilesBtn);
            this.sideBar.Controls.Add(this.createServLbl);
            this.sideBar.Controls.Add(this.installServBtn);
            this.sideBar.Controls.Add(this.editServLbl);
            this.sideBar.Controls.Add(this.selectServLbl);
            this.sideBar.Controls.Add(this.editLaunchOptBtn);
            this.sideBar.Controls.Add(this.browseServsBtn);
            this.sideBar.Location = new System.Drawing.Point(0, 34);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(184, 562);
            this.sideBar.TabIndex = 4;
            // 
            // serverPropertiesBtn
            // 
            this.serverPropertiesBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.serverPropertiesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serverPropertiesBtn.Location = new System.Drawing.Point(-1, 213);
            this.serverPropertiesBtn.Name = "serverPropertiesBtn";
            this.serverPropertiesBtn.Size = new System.Drawing.Size(184, 23);
            this.serverPropertiesBtn.TabIndex = 24;
            this.serverPropertiesBtn.Text = "Server Properties";
            this.serverPropertiesBtn.UseVisualStyleBackColor = false;
            // 
            // reinstallServerBtn
            // 
            this.reinstallServerBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.reinstallServerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reinstallServerBtn.Location = new System.Drawing.Point(-1, 538);
            this.reinstallServerBtn.Name = "reinstallServerBtn";
            this.reinstallServerBtn.Size = new System.Drawing.Size(184, 23);
            this.reinstallServerBtn.TabIndex = 23;
            this.reinstallServerBtn.Text = "Reinstall server";
            this.reinstallServerBtn.UseVisualStyleBackColor = false;
            // 
            // moreLbl
            // 
            this.moreLbl.AutoSize = true;
            this.moreLbl.Location = new System.Drawing.Point(74, 511);
            this.moreLbl.Name = "moreLbl";
            this.moreLbl.Size = new System.Drawing.Size(37, 13);
            this.moreLbl.TabIndex = 22;
            this.moreLbl.Text = "More :";
            // 
            // managePluginsBtn
            // 
            this.managePluginsBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.managePluginsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managePluginsBtn.Location = new System.Drawing.Point(-1, 474);
            this.managePluginsBtn.Name = "managePluginsBtn";
            this.managePluginsBtn.Size = new System.Drawing.Size(184, 23);
            this.managePluginsBtn.TabIndex = 21;
            this.managePluginsBtn.Text = "Manage plugins";
            this.managePluginsBtn.UseVisualStyleBackColor = false;
            // 
            // pluginsLbl
            // 
            this.pluginsLbl.AutoSize = true;
            this.pluginsLbl.Location = new System.Drawing.Point(70, 446);
            this.pluginsLbl.Name = "pluginsLbl";
            this.pluginsLbl.Size = new System.Drawing.Size(47, 13);
            this.pluginsLbl.TabIndex = 20;
            this.pluginsLbl.Text = "Plugins :";
            // 
            // backupsBtn
            // 
            this.backupsBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.backupsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupsBtn.Location = new System.Drawing.Point(-1, 279);
            this.backupsBtn.Name = "backupsBtn";
            this.backupsBtn.Size = new System.Drawing.Size(184, 23);
            this.backupsBtn.TabIndex = 19;
            this.backupsBtn.Text = "Backups";
            this.backupsBtn.UseVisualStyleBackColor = false;
            // 
            // consoleBtn
            // 
            this.consoleBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.consoleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consoleBtn.Location = new System.Drawing.Point(-1, 235);
            this.consoleBtn.Name = "consoleBtn";
            this.consoleBtn.Size = new System.Drawing.Size(184, 23);
            this.consoleBtn.TabIndex = 18;
            this.consoleBtn.Text = "Console";
            this.consoleBtn.UseVisualStyleBackColor = false;
            // 
            // worldsBtn
            // 
            this.worldsBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.worldsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.worldsBtn.Location = new System.Drawing.Point(-1, 257);
            this.worldsBtn.Name = "worldsBtn";
            this.worldsBtn.Size = new System.Drawing.Size(184, 23);
            this.worldsBtn.TabIndex = 17;
            this.worldsBtn.Text = "Worlds";
            this.worldsBtn.UseVisualStyleBackColor = false;
            // 
            // banListBtn
            // 
            this.banListBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.banListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.banListBtn.Location = new System.Drawing.Point(-1, 410);
            this.banListBtn.Name = "banListBtn";
            this.banListBtn.Size = new System.Drawing.Size(184, 23);
            this.banListBtn.TabIndex = 16;
            this.banListBtn.Text = "Ban List";
            this.banListBtn.UseVisualStyleBackColor = false;
            // 
            // whiteListBtn
            // 
            this.whiteListBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.whiteListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.whiteListBtn.Location = new System.Drawing.Point(-1, 388);
            this.whiteListBtn.Name = "whiteListBtn";
            this.whiteListBtn.Size = new System.Drawing.Size(184, 23);
            this.whiteListBtn.TabIndex = 15;
            this.whiteListBtn.Text = "White List";
            this.whiteListBtn.UseVisualStyleBackColor = false;
            // 
            // operatorsBtn
            // 
            this.operatorsBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.operatorsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operatorsBtn.Location = new System.Drawing.Point(-1, 366);
            this.operatorsBtn.Name = "operatorsBtn";
            this.operatorsBtn.Size = new System.Drawing.Size(184, 23);
            this.operatorsBtn.TabIndex = 14;
            this.operatorsBtn.Text = "Operators";
            this.operatorsBtn.UseVisualStyleBackColor = false;
            // 
            // playersLbl
            // 
            this.playersLbl.AutoSize = true;
            this.playersLbl.Location = new System.Drawing.Point(70, 316);
            this.playersLbl.Name = "playersLbl";
            this.playersLbl.Size = new System.Drawing.Size(47, 13);
            this.playersLbl.TabIndex = 13;
            this.playersLbl.Text = "Players :";
            // 
            // onlinePlayersBtn
            // 
            this.onlinePlayersBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.onlinePlayersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onlinePlayersBtn.Location = new System.Drawing.Point(-1, 344);
            this.onlinePlayersBtn.Name = "onlinePlayersBtn";
            this.onlinePlayersBtn.Size = new System.Drawing.Size(184, 23);
            this.onlinePlayersBtn.TabIndex = 12;
            this.onlinePlayersBtn.Text = "Online";
            this.onlinePlayersBtn.UseVisualStyleBackColor = false;
            // 
            // servFilesBtn
            // 
            this.servFilesBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.servFilesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servFilesBtn.Location = new System.Drawing.Point(-1, 191);
            this.servFilesBtn.Name = "servFilesBtn";
            this.servFilesBtn.Size = new System.Drawing.Size(184, 23);
            this.servFilesBtn.TabIndex = 11;
            this.servFilesBtn.Text = "Server files";
            this.servFilesBtn.UseVisualStyleBackColor = false;
            // 
            // createServLbl
            // 
            this.createServLbl.AutoSize = true;
            this.createServLbl.Location = new System.Drawing.Point(26, 12);
            this.createServLbl.Name = "createServLbl";
            this.createServLbl.Size = new System.Drawing.Size(132, 13);
            this.createServLbl.TabIndex = 10;
            this.createServLbl.Text = "Create a new server here :";
            // 
            // installServBtn
            // 
            this.installServBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.installServBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.installServBtn.Location = new System.Drawing.Point(-1, 39);
            this.installServBtn.Name = "installServBtn";
            this.installServBtn.Size = new System.Drawing.Size(184, 23);
            this.installServBtn.TabIndex = 9;
            this.installServBtn.Text = "Install new server";
            this.installServBtn.UseVisualStyleBackColor = false;
            this.installServBtn.Click += new System.EventHandler(this.installServBtn_Click);
            // 
            // editServLbl
            // 
            this.editServLbl.AutoSize = true;
            this.editServLbl.Location = new System.Drawing.Point(37, 141);
            this.editServLbl.Name = "editServLbl";
            this.editServLbl.Size = new System.Drawing.Size(110, 13);
            this.editServLbl.TabIndex = 8;
            this.editServLbl.Text = "Edit your server here :";
            // 
            // selectServLbl
            // 
            this.selectServLbl.AutoSize = true;
            this.selectServLbl.Location = new System.Drawing.Point(39, 76);
            this.selectServLbl.Name = "selectServLbl";
            this.selectServLbl.Size = new System.Drawing.Size(108, 13);
            this.selectServLbl.TabIndex = 6;
            this.selectServLbl.Text = "Select a server here :";
            // 
            // editLaunchOptBtn
            // 
            this.editLaunchOptBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.editLaunchOptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editLaunchOptBtn.Location = new System.Drawing.Point(-1, 169);
            this.editLaunchOptBtn.Name = "editLaunchOptBtn";
            this.editLaunchOptBtn.Size = new System.Drawing.Size(184, 23);
            this.editLaunchOptBtn.TabIndex = 7;
            this.editLaunchOptBtn.Text = "Start server / edit start options";
            this.editLaunchOptBtn.UseVisualStyleBackColor = false;
            this.editLaunchOptBtn.Click += new System.EventHandler(this.editLaunchOptBtn_Click);
            // 
            // browseServsBtn
            // 
            this.browseServsBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.browseServsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseServsBtn.Location = new System.Drawing.Point(-1, 104);
            this.browseServsBtn.Name = "browseServsBtn";
            this.browseServsBtn.Size = new System.Drawing.Size(184, 23);
            this.browseServsBtn.TabIndex = 6;
            this.browseServsBtn.Text = "Browse Servers";
            this.browseServsBtn.UseVisualStyleBackColor = false;
            // 
            // openSideBarBtn
            // 
            this.openSideBarBtn.BackColor = System.Drawing.Color.White;
            this.openSideBarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openSideBarBtn.Location = new System.Drawing.Point(183, 34);
            this.openSideBarBtn.Name = "openSideBarBtn";
            this.openSideBarBtn.Size = new System.Drawing.Size(23, 23);
            this.openSideBarBtn.TabIndex = 5;
            this.openSideBarBtn.Text = "<";
            this.openSideBarBtn.UseVisualStyleBackColor = false;
            this.openSideBarBtn.Click += new System.EventHandler(this.openSideBarBtn_Click);
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.installServTab);
            this.MainTabControl.Controls.Add(this.welcomeTab);
            this.MainTabControl.Controls.Add(this.Start);
            this.MainTabControl.Location = new System.Drawing.Point(206, 25);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(600, 575);
            this.MainTabControl.TabIndex = 8;
            // 
            // installServTab
            // 
            this.installServTab.BackColor = System.Drawing.Color.Silver;
            this.installServTab.Controls.Add(this.installProgressGrouBox);
            this.installServTab.Controls.Add(this.noEditWhileInstallPan);
            this.installServTab.Location = new System.Drawing.Point(4, 22);
            this.installServTab.Name = "installServTab";
            this.installServTab.Padding = new System.Windows.Forms.Padding(3);
            this.installServTab.Size = new System.Drawing.Size(592, 549);
            this.installServTab.TabIndex = 0;
            this.installServTab.Text = "install";
            // 
            // installProgressGrouBox
            // 
            this.installProgressGrouBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.installProgressGrouBox.Controls.Add(this.installStatusLbl);
            this.installProgressGrouBox.Controls.Add(this.installProgressBar);
            this.installProgressGrouBox.Location = new System.Drawing.Point(9, 470);
            this.installProgressGrouBox.Name = "installProgressGrouBox";
            this.installProgressGrouBox.Size = new System.Drawing.Size(575, 75);
            this.installProgressGrouBox.TabIndex = 23;
            this.installProgressGrouBox.TabStop = false;
            this.installProgressGrouBox.Text = "Installation Progress";
            // 
            // installStatusLbl
            // 
            this.installStatusLbl.AutoSize = true;
            this.installStatusLbl.Location = new System.Drawing.Point(6, 52);
            this.installStatusLbl.Name = "installStatusLbl";
            this.installStatusLbl.Size = new System.Drawing.Size(62, 13);
            this.installStatusLbl.TabIndex = 1;
            this.installStatusLbl.Text = "Status : idle";
            // 
            // installProgressBar
            // 
            this.installProgressBar.Location = new System.Drawing.Point(6, 22);
            this.installProgressBar.Name = "installProgressBar";
            this.installProgressBar.Size = new System.Drawing.Size(563, 23);
            this.installProgressBar.TabIndex = 0;
            // 
            // noEditWhileInstallPan
            // 
            this.noEditWhileInstallPan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.noEditWhileInstallPan.Controls.Add(this.serverNameSetLbl);
            this.noEditWhileInstallPan.Controls.Add(this.serverName);
            this.noEditWhileInstallPan.Controls.Add(this.panel4);
            this.noEditWhileInstallPan.Controls.Add(this.panel3);
            this.noEditWhileInstallPan.Controls.Add(this.autoDirectoryLbl);
            this.noEditWhileInstallPan.Controls.Add(this.autoDirectory);
            this.noEditWhileInstallPan.Controls.Add(this.serverInstallPath);
            this.noEditWhileInstallPan.Controls.Add(this.installNewServerBtn);
            this.noEditWhileInstallPan.Controls.Add(this.installServPanLbl);
            this.noEditWhileInstallPan.Controls.Add(this.GBradioBtn);
            this.noEditWhileInstallPan.Controls.Add(this.serverInstallPathLbl);
            this.noEditWhileInstallPan.Controls.Add(this.MBradioBtn);
            this.noEditWhileInstallPan.Controls.Add(this.browseServerInstallPathBtn);
            this.noEditWhileInstallPan.Controls.Add(this.allocatedRam);
            this.noEditWhileInstallPan.Controls.Add(this.serverInstallTypeLbl);
            this.noEditWhileInstallPan.Controls.Add(this.allocatedRamLbl);
            this.noEditWhileInstallPan.Controls.Add(this.serverInstallType);
            this.noEditWhileInstallPan.Controls.Add(this.dragDropCustomServ);
            this.noEditWhileInstallPan.Controls.Add(this.serverInstallVersionLbl);
            this.noEditWhileInstallPan.Controls.Add(this.dragDropCustomServer);
            this.noEditWhileInstallPan.Controls.Add(this.serverInstallVersion);
            this.noEditWhileInstallPan.Location = new System.Drawing.Point(3, 0);
            this.noEditWhileInstallPan.Name = "noEditWhileInstallPan";
            this.noEditWhileInstallPan.Size = new System.Drawing.Size(586, 458);
            this.noEditWhileInstallPan.TabIndex = 0;
            // 
            // serverNameSetLbl
            // 
            this.serverNameSetLbl.AutoSize = true;
            this.serverNameSetLbl.Location = new System.Drawing.Point(6, 122);
            this.serverNameSetLbl.Name = "serverNameSetLbl";
            this.serverNameSetLbl.Size = new System.Drawing.Size(73, 13);
            this.serverNameSetLbl.TabIndex = 33;
            this.serverNameSetLbl.Text = "Server name :";
            // 
            // serverName
            // 
            this.serverName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.serverName.Location = new System.Drawing.Point(6, 141);
            this.serverName.Name = "serverName";
            this.serverName.Size = new System.Drawing.Size(577, 20);
            this.serverName.TabIndex = 32;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(1, 347);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(586, 2);
            this.panel4.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 179);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(586, 2);
            this.panel3.TabIndex = 30;
            // 
            // autoDirectoryLbl
            // 
            this.autoDirectoryLbl.AutoSize = true;
            this.autoDirectoryLbl.Location = new System.Drawing.Point(6, 75);
            this.autoDirectoryLbl.Name = "autoDirectoryLbl";
            this.autoDirectoryLbl.Size = new System.Drawing.Size(65, 13);
            this.autoDirectoryLbl.TabIndex = 24;
            this.autoDirectoryLbl.Text = "Or you can :";
            // 
            // autoDirectory
            // 
            this.autoDirectory.AutoSize = true;
            this.autoDirectory.Location = new System.Drawing.Point(7, 92);
            this.autoDirectory.Name = "autoDirectory";
            this.autoDirectory.Size = new System.Drawing.Size(224, 17);
            this.autoDirectory.TabIndex = 23;
            this.autoDirectory.Text = "Let us choose the directory for your server";
            this.autoDirectory.UseVisualStyleBackColor = true;
            this.autoDirectory.CheckedChanged += new System.EventHandler(this.autoDirectory_CheckedChanged);
            // 
            // serverInstallPath
            // 
            this.serverInstallPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.serverInstallPath.Location = new System.Drawing.Point(6, 52);
            this.serverInstallPath.Name = "serverInstallPath";
            this.serverInstallPath.Size = new System.Drawing.Size(497, 20);
            this.serverInstallPath.TabIndex = 11;
            // 
            // installNewServerBtn
            // 
            this.installNewServerBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.installNewServerBtn.Location = new System.Drawing.Point(208, 419);
            this.installNewServerBtn.Name = "installNewServerBtn";
            this.installNewServerBtn.Size = new System.Drawing.Size(145, 23);
            this.installNewServerBtn.TabIndex = 22;
            this.installNewServerBtn.Text = "Install new server";
            this.installNewServerBtn.UseVisualStyleBackColor = true;
            this.installNewServerBtn.Click += new System.EventHandler(this.installNewServerBtn_Click);
            // 
            // installServPanLbl
            // 
            this.installServPanLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.installServPanLbl.AutoSize = true;
            this.installServPanLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installServPanLbl.Location = new System.Drawing.Point(232, 7);
            this.installServPanLbl.Name = "installServPanLbl";
            this.installServPanLbl.Size = new System.Drawing.Size(118, 13);
            this.installServPanLbl.TabIndex = 8;
            this.installServPanLbl.Text = "Install a new server";
            // 
            // GBradioBtn
            // 
            this.GBradioBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GBradioBtn.AutoSize = true;
            this.GBradioBtn.Location = new System.Drawing.Point(406, 386);
            this.GBradioBtn.Name = "GBradioBtn";
            this.GBradioBtn.Size = new System.Drawing.Size(40, 17);
            this.GBradioBtn.TabIndex = 21;
            this.GBradioBtn.Text = "GB";
            this.GBradioBtn.UseVisualStyleBackColor = true;
            // 
            // serverInstallPathLbl
            // 
            this.serverInstallPathLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.serverInstallPathLbl.AutoSize = true;
            this.serverInstallPathLbl.Location = new System.Drawing.Point(3, 30);
            this.serverInstallPathLbl.Name = "serverInstallPathLbl";
            this.serverInstallPathLbl.Size = new System.Drawing.Size(500, 13);
            this.serverInstallPathLbl.TabIndex = 9;
            this.serverInstallPathLbl.Text = "Server installation path (where should we store your server data?, recommended to" +
    " use an empty folder) :";
            // 
            // MBradioBtn
            // 
            this.MBradioBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MBradioBtn.AutoSize = true;
            this.MBradioBtn.Checked = true;
            this.MBradioBtn.Location = new System.Drawing.Point(406, 365);
            this.MBradioBtn.Name = "MBradioBtn";
            this.MBradioBtn.Size = new System.Drawing.Size(41, 17);
            this.MBradioBtn.TabIndex = 20;
            this.MBradioBtn.TabStop = true;
            this.MBradioBtn.Text = "MB";
            this.MBradioBtn.UseVisualStyleBackColor = true;
            this.MBradioBtn.CheckedChanged += new System.EventHandler(this.MBradioBtn_CheckedChanged);
            // 
            // browseServerInstallPathBtn
            // 
            this.browseServerInstallPathBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.browseServerInstallPathBtn.BackColor = System.Drawing.Color.LightGray;
            this.browseServerInstallPathBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseServerInstallPathBtn.Location = new System.Drawing.Point(508, 51);
            this.browseServerInstallPathBtn.Name = "browseServerInstallPathBtn";
            this.browseServerInstallPathBtn.Size = new System.Drawing.Size(75, 22);
            this.browseServerInstallPathBtn.TabIndex = 10;
            this.browseServerInstallPathBtn.Text = "Browse";
            this.browseServerInstallPathBtn.UseVisualStyleBackColor = false;
            this.browseServerInstallPathBtn.Click += new System.EventHandler(this.browseServerInstallPathBtn_Click);
            // 
            // allocatedRam
            // 
            this.allocatedRam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.allocatedRam.FormattingEnabled = true;
            this.allocatedRam.Items.AddRange(new object[] {
            "512",
            "1024",
            "2048",
            "3072",
            "4096",
            "5120",
            "6144",
            "7168",
            "8192",
            "9216",
            "10240",
            "11264",
            "12288",
            "13312",
            "14336",
            "15360",
            "16384",
            "17408",
            "18432",
            "19456",
            "20480"});
            this.allocatedRam.Location = new System.Drawing.Point(279, 373);
            this.allocatedRam.Name = "allocatedRam";
            this.allocatedRam.Size = new System.Drawing.Size(121, 21);
            this.allocatedRam.TabIndex = 19;
            this.allocatedRam.Text = "2048";
            // 
            // serverInstallTypeLbl
            // 
            this.serverInstallTypeLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.serverInstallTypeLbl.AutoSize = true;
            this.serverInstallTypeLbl.Location = new System.Drawing.Point(71, 203);
            this.serverInstallTypeLbl.Name = "serverInstallTypeLbl";
            this.serverInstallTypeLbl.Size = new System.Drawing.Size(37, 13);
            this.serverInstallTypeLbl.TabIndex = 12;
            this.serverInstallTypeLbl.Text = "Type :";
            // 
            // allocatedRamLbl
            // 
            this.allocatedRamLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.allocatedRamLbl.AutoSize = true;
            this.allocatedRamLbl.Location = new System.Drawing.Point(119, 376);
            this.allocatedRamLbl.Name = "allocatedRamLbl";
            this.allocatedRamLbl.Size = new System.Drawing.Size(154, 13);
            this.allocatedRamLbl.TabIndex = 18;
            this.allocatedRamLbl.Text = "Allocated RAM for your server :";
            // 
            // serverInstallType
            // 
            this.serverInstallType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.serverInstallType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serverInstallType.FormattingEnabled = true;
            this.serverInstallType.Items.AddRange(new object[] {
            "Vanilla (normal minecraft)",
            "Spigot (for plugins)",
            "Paper (for plugins & performance)",
            "CraftBukkit (for plugins & performance)",
            "Forge (for mods)"});
            this.serverInstallType.Location = new System.Drawing.Point(113, 200);
            this.serverInstallType.Name = "serverInstallType";
            this.serverInstallType.Size = new System.Drawing.Size(208, 21);
            this.serverInstallType.TabIndex = 13;
            this.serverInstallType.SelectedIndexChanged += new System.EventHandler(this.serverInstallType_SelectedIndexChanged);
            // 
            // dragDropCustomServ
            // 
            this.dragDropCustomServ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dragDropCustomServ.AutoSize = true;
            this.dragDropCustomServ.Location = new System.Drawing.Point(12, 246);
            this.dragDropCustomServ.Name = "dragDropCustomServ";
            this.dragDropCustomServ.Size = new System.Drawing.Size(565, 13);
            this.dragDropCustomServ.TabIndex = 17;
            this.dragDropCustomServ.Text = "Or you can drag and drop a custom server client here (not recommended because lot" +
    "s of options will not be available) :";
            // 
            // serverInstallVersionLbl
            // 
            this.serverInstallVersionLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.serverInstallVersionLbl.AutoSize = true;
            this.serverInstallVersionLbl.Location = new System.Drawing.Point(327, 204);
            this.serverInstallVersionLbl.Name = "serverInstallVersionLbl";
            this.serverInstallVersionLbl.Size = new System.Drawing.Size(48, 13);
            this.serverInstallVersionLbl.TabIndex = 14;
            this.serverInstallVersionLbl.Text = "Version :";
            // 
            // dragDropCustomServer
            // 
            this.dragDropCustomServer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dragDropCustomServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dragDropCustomServer.Location = new System.Drawing.Point(5, 262);
            this.dragDropCustomServer.Name = "dragDropCustomServer";
            this.dragDropCustomServer.Size = new System.Drawing.Size(577, 62);
            this.dragDropCustomServer.TabIndex = 16;
            // 
            // serverInstallVersion
            // 
            this.serverInstallVersion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.serverInstallVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serverInstallVersion.FormattingEnabled = true;
            this.serverInstallVersion.Items.AddRange(new object[] {
            "1.16.5",
            "1.16.4",
            "1.16.3",
            "1.16.2",
            "1.16.1",
            "1.16",
            "1.15.2",
            "1.15.1",
            "1.15",
            "1.14.4",
            "1.14.3",
            "1.14.2",
            "1.14.1",
            "1.14",
            "1.13.2",
            "1.13.1",
            "1.13",
            "1.12.2",
            "1.12.1",
            "1.12",
            "1.11.2",
            "1.11.1",
            "1.11",
            "1.10.2",
            "1.10.1",
            "1.10",
            "1.9.4",
            "1.9.3",
            "1.9.2",
            "1.9.1",
            "1.9",
            "1.8.9",
            "1.8.8",
            "1.8.7",
            "1.8.6",
            "1.8.5",
            "1.8.4",
            "1.8.3",
            "1.8.2",
            "1.8.1",
            "1.8",
            "1.7.10",
            "1.7.9",
            "1.7.8",
            "1.7.7",
            "1.7.6",
            "1.7.5",
            "1.7.4",
            "1.7.3",
            "1.7.2"});
            this.serverInstallVersion.Location = new System.Drawing.Point(381, 200);
            this.serverInstallVersion.Name = "serverInstallVersion";
            this.serverInstallVersion.Size = new System.Drawing.Size(121, 21);
            this.serverInstallVersion.TabIndex = 15;
            // 
            // welcomeTab
            // 
            this.welcomeTab.BackColor = System.Drawing.Color.Silver;
            this.welcomeTab.Controls.Add(this.importServerBtn);
            this.welcomeTab.Controls.Add(this.serversListLbl);
            this.welcomeTab.Controls.Add(this.welcomeLbl);
            this.welcomeTab.Location = new System.Drawing.Point(4, 22);
            this.welcomeTab.Name = "welcomeTab";
            this.welcomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.welcomeTab.Size = new System.Drawing.Size(592, 549);
            this.welcomeTab.TabIndex = 1;
            this.welcomeTab.Text = "welcome";
            // 
            // importServerBtn
            // 
            this.importServerBtn.BackColor = System.Drawing.Color.LightGray;
            this.importServerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importServerBtn.Location = new System.Drawing.Point(138, 499);
            this.importServerBtn.Name = "importServerBtn";
            this.importServerBtn.Size = new System.Drawing.Size(329, 23);
            this.importServerBtn.TabIndex = 10;
            this.importServerBtn.Text = "Or you can import an existing server by clicking here";
            this.importServerBtn.UseVisualStyleBackColor = false;
            // 
            // serversListLbl
            // 
            this.serversListLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.serversListLbl.AutoSize = true;
            this.serversListLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serversListLbl.Location = new System.Drawing.Point(168, 72);
            this.serversListLbl.Name = "serversListLbl";
            this.serversListLbl.Size = new System.Drawing.Size(260, 16);
            this.serversListLbl.TabIndex = 9;
            this.serversListLbl.Text = "Here are all the servers you have created :";
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.Location = new System.Drawing.Point(37, 3);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(520, 29);
            this.welcomeLbl.TabIndex = 8;
            this.welcomeLbl.Text = "Welcome to Minecraft Server Hosting Tool !";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Silver;
            this.Start.Controls.Add(this.editServerStartOptionsGroupBox);
            this.Start.Controls.Add(this.startServerBtn);
            this.Start.Controls.Add(this.StartServerLbl);
            this.Start.Controls.Add(this.panel1);
            this.Start.Location = new System.Drawing.Point(4, 22);
            this.Start.Name = "Start";
            this.Start.Padding = new System.Windows.Forms.Padding(3);
            this.Start.Size = new System.Drawing.Size(592, 549);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            // 
            // editServerStartOptionsGroupBox
            // 
            this.editServerStartOptionsGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editServerStartOptionsGroupBox.Controls.Add(this.separatorPanServerEditStartOptions);
            this.editServerStartOptionsGroupBox.Controls.Add(this.saveChangesServerStartOptionsBtn);
            this.editServerStartOptionsGroupBox.Controls.Add(this.startServerPropertiesBtn);
            this.editServerStartOptionsGroupBox.Controls.Add(this.restartServerIfCrash);
            this.editServerStartOptionsGroupBox.Controls.Add(this.serverStartAllocatedRamLbl);
            this.editServerStartOptionsGroupBox.Controls.Add(this.startGBradioBtn);
            this.editServerStartOptionsGroupBox.Controls.Add(this.serverStartAllocatedRam);
            this.editServerStartOptionsGroupBox.Controls.Add(this.startMBradioBtn);
            this.editServerStartOptionsGroupBox.Location = new System.Drawing.Point(113, 348);
            this.editServerStartOptionsGroupBox.Name = "editServerStartOptionsGroupBox";
            this.editServerStartOptionsGroupBox.Size = new System.Drawing.Size(378, 164);
            this.editServerStartOptionsGroupBox.TabIndex = 26;
            this.editServerStartOptionsGroupBox.TabStop = false;
            this.editServerStartOptionsGroupBox.Text = "Edit server start options";
            // 
            // separatorPanServerEditStartOptions
            // 
            this.separatorPanServerEditStartOptions.BackColor = System.Drawing.Color.White;
            this.separatorPanServerEditStartOptions.Location = new System.Drawing.Point(0, 127);
            this.separatorPanServerEditStartOptions.Name = "separatorPanServerEditStartOptions";
            this.separatorPanServerEditStartOptions.Size = new System.Drawing.Size(378, 2);
            this.separatorPanServerEditStartOptions.TabIndex = 29;
            // 
            // saveChangesServerStartOptionsBtn
            // 
            this.saveChangesServerStartOptionsBtn.BackColor = System.Drawing.Color.LightGray;
            this.saveChangesServerStartOptionsBtn.Enabled = false;
            this.saveChangesServerStartOptionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveChangesServerStartOptionsBtn.Location = new System.Drawing.Point(133, 135);
            this.saveChangesServerStartOptionsBtn.Name = "saveChangesServerStartOptionsBtn";
            this.saveChangesServerStartOptionsBtn.Size = new System.Drawing.Size(127, 23);
            this.saveChangesServerStartOptionsBtn.TabIndex = 28;
            this.saveChangesServerStartOptionsBtn.Text = "Save changes";
            this.saveChangesServerStartOptionsBtn.UseVisualStyleBackColor = false;
            // 
            // startServerPropertiesBtn
            // 
            this.startServerPropertiesBtn.BackColor = System.Drawing.Color.LightGray;
            this.startServerPropertiesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startServerPropertiesBtn.Location = new System.Drawing.Point(108, 100);
            this.startServerPropertiesBtn.Name = "startServerPropertiesBtn";
            this.startServerPropertiesBtn.Size = new System.Drawing.Size(169, 23);
            this.startServerPropertiesBtn.TabIndex = 27;
            this.startServerPropertiesBtn.Text = "Open server properties";
            this.startServerPropertiesBtn.UseVisualStyleBackColor = false;
            // 
            // restartServerIfCrash
            // 
            this.restartServerIfCrash.AutoSize = true;
            this.restartServerIfCrash.Location = new System.Drawing.Point(103, 65);
            this.restartServerIfCrash.Name = "restartServerIfCrash";
            this.restartServerIfCrash.Size = new System.Drawing.Size(184, 17);
            this.restartServerIfCrash.TabIndex = 26;
            this.restartServerIfCrash.Text = "Auto restart my server if it crashes";
            this.restartServerIfCrash.UseVisualStyleBackColor = true;
            this.restartServerIfCrash.CheckedChanged += new System.EventHandler(this.restartServerIfCrash_CheckedChanged);
            // 
            // serverStartAllocatedRamLbl
            // 
            this.serverStartAllocatedRamLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.serverStartAllocatedRamLbl.AutoSize = true;
            this.serverStartAllocatedRamLbl.Location = new System.Drawing.Point(24, 26);
            this.serverStartAllocatedRamLbl.Name = "serverStartAllocatedRamLbl";
            this.serverStartAllocatedRamLbl.Size = new System.Drawing.Size(154, 13);
            this.serverStartAllocatedRamLbl.TabIndex = 22;
            this.serverStartAllocatedRamLbl.Text = "Allocated RAM for your server :";
            // 
            // startGBradioBtn
            // 
            this.startGBradioBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startGBradioBtn.AutoSize = true;
            this.startGBradioBtn.Location = new System.Drawing.Point(311, 36);
            this.startGBradioBtn.Name = "startGBradioBtn";
            this.startGBradioBtn.Size = new System.Drawing.Size(40, 17);
            this.startGBradioBtn.TabIndex = 25;
            this.startGBradioBtn.Text = "GB";
            this.startGBradioBtn.UseVisualStyleBackColor = true;
            // 
            // serverStartAllocatedRam
            // 
            this.serverStartAllocatedRam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.serverStartAllocatedRam.FormattingEnabled = true;
            this.serverStartAllocatedRam.Items.AddRange(new object[] {
            "512",
            "1024",
            "2048",
            "3072",
            "4096",
            "5120",
            "6144",
            "7168",
            "8192",
            "9216",
            "10240",
            "11264",
            "12288",
            "13312",
            "14336",
            "15360",
            "16384",
            "17408",
            "18432",
            "19456",
            "20480"});
            this.serverStartAllocatedRam.Location = new System.Drawing.Point(184, 23);
            this.serverStartAllocatedRam.Name = "serverStartAllocatedRam";
            this.serverStartAllocatedRam.Size = new System.Drawing.Size(121, 21);
            this.serverStartAllocatedRam.TabIndex = 23;
            this.serverStartAllocatedRam.Text = "2048";
            // 
            // startMBradioBtn
            // 
            this.startMBradioBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startMBradioBtn.AutoSize = true;
            this.startMBradioBtn.Checked = true;
            this.startMBradioBtn.Location = new System.Drawing.Point(311, 15);
            this.startMBradioBtn.Name = "startMBradioBtn";
            this.startMBradioBtn.Size = new System.Drawing.Size(41, 17);
            this.startMBradioBtn.TabIndex = 24;
            this.startMBradioBtn.TabStop = true;
            this.startMBradioBtn.Text = "MB";
            this.startMBradioBtn.UseVisualStyleBackColor = true;
            this.startMBradioBtn.CheckedChanged += new System.EventHandler(this.startMBradioBtn_CheckedChanged);
            // 
            // startServerBtn
            // 
            this.startServerBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startServerBtn.BackColor = System.Drawing.Color.Lime;
            this.startServerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startServerBtn.Location = new System.Drawing.Point(265, 237);
            this.startServerBtn.Name = "startServerBtn";
            this.startServerBtn.Size = new System.Drawing.Size(75, 23);
            this.startServerBtn.TabIndex = 3;
            this.startServerBtn.Text = "Start";
            this.startServerBtn.UseVisualStyleBackColor = false;
            // 
            // StartServerLbl
            // 
            this.StartServerLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StartServerLbl.AutoSize = true;
            this.StartServerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartServerLbl.Location = new System.Drawing.Point(209, 3);
            this.StartServerLbl.Name = "StartServerLbl";
            this.StartServerLbl.Size = new System.Drawing.Size(182, 13);
            this.StartServerLbl.TabIndex = 2;
            this.StartServerLbl.Text = "Start server / edit start options";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.serverNameLbl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(80, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 100);
            this.panel1.TabIndex = 1;
            // 
            // serverNameLbl
            // 
            this.serverNameLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.serverNameLbl.AutoSize = true;
            this.serverNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverNameLbl.ForeColor = System.Drawing.Color.White;
            this.serverNameLbl.Location = new System.Drawing.Point(165, 23);
            this.serverNameLbl.Name = "serverNameLbl";
            this.serverNameLbl.Size = new System.Drawing.Size(122, 16);
            this.serverNameLbl.TabIndex = 1;
            this.serverNameLbl.Text = "No server selected";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.serverRunning);
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 35);
            this.panel2.TabIndex = 0;
            // 
            // serverRunning
            // 
            this.serverRunning.AutoSize = true;
            this.serverRunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverRunning.Location = new System.Drawing.Point(200, 11);
            this.serverRunning.Name = "serverRunning";
            this.serverRunning.Size = new System.Drawing.Size(52, 16);
            this.serverRunning.TabIndex = 0;
            this.serverRunning.Text = "Offline";
            // 
            // hideBorderPan1
            // 
            this.hideBorderPan1.Location = new System.Drawing.Point(206, 34);
            this.hideBorderPan1.Name = "hideBorderPan1";
            this.hideBorderPan1.Size = new System.Drawing.Size(7, 562);
            this.hideBorderPan1.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.topLeftLogo);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.hideBorderPan1);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.openSideBarBtn);
            this.Controls.Add(this.sideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Minecraft Server Hosting Tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.bar.ResumeLayout(false);
            this.bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topLeftLogo)).EndInit();
            this.sideBar.ResumeLayout(false);
            this.sideBar.PerformLayout();
            this.MainTabControl.ResumeLayout(false);
            this.installServTab.ResumeLayout(false);
            this.installProgressGrouBox.ResumeLayout(false);
            this.installProgressGrouBox.PerformLayout();
            this.noEditWhileInstallPan.ResumeLayout(false);
            this.noEditWhileInstallPan.PerformLayout();
            this.welcomeTab.ResumeLayout(false);
            this.welcomeTab.PerformLayout();
            this.Start.ResumeLayout(false);
            this.Start.PerformLayout();
            this.editServerStartOptionsGroupBox.ResumeLayout(false);
            this.editServerStartOptionsGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bar;
        private System.Windows.Forms.PictureBox topLeftLogo;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label barLbl;
        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Button openSideBarBtn;
        private System.Windows.Forms.Button browseServsBtn;
        private System.Windows.Forms.Label selectServLbl;
        private System.Windows.Forms.Button editLaunchOptBtn;
        private System.Windows.Forms.Button reinstallServerBtn;
        private System.Windows.Forms.Label moreLbl;
        private System.Windows.Forms.Button managePluginsBtn;
        private System.Windows.Forms.Label pluginsLbl;
        private System.Windows.Forms.Button backupsBtn;
        private System.Windows.Forms.Button consoleBtn;
        private System.Windows.Forms.Button worldsBtn;
        private System.Windows.Forms.Button banListBtn;
        private System.Windows.Forms.Button whiteListBtn;
        private System.Windows.Forms.Button operatorsBtn;
        private System.Windows.Forms.Label playersLbl;
        private System.Windows.Forms.Button onlinePlayersBtn;
        private System.Windows.Forms.Button servFilesBtn;
        private System.Windows.Forms.Label createServLbl;
        private System.Windows.Forms.Button installServBtn;
        private System.Windows.Forms.Label editServLbl;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage installServTab;
        private System.Windows.Forms.TabPage welcomeTab;
        private System.Windows.Forms.Label serversListLbl;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Panel hideBorderPan1;
        private System.Windows.Forms.ComboBox serverInstallVersion;
        private System.Windows.Forms.Label serverInstallVersionLbl;
        private System.Windows.Forms.ComboBox serverInstallType;
        private System.Windows.Forms.Label serverInstallTypeLbl;
        private System.Windows.Forms.Button browseServerInstallPathBtn;
        private System.Windows.Forms.TextBox serverInstallPath;
        private System.Windows.Forms.Label serverInstallPathLbl;
        private System.Windows.Forms.Label installServPanLbl;
        private System.Windows.Forms.Label dragDropCustomServ;
        private System.Windows.Forms.Panel dragDropCustomServer;
        private System.Windows.Forms.Button installNewServerBtn;
        private System.Windows.Forms.RadioButton GBradioBtn;
        private System.Windows.Forms.RadioButton MBradioBtn;
        private System.Windows.Forms.ComboBox allocatedRam;
        private System.Windows.Forms.Label allocatedRamLbl;
        private System.Windows.Forms.GroupBox installProgressGrouBox;
        private System.Windows.Forms.Label installStatusLbl;
        private System.Windows.Forms.ProgressBar installProgressBar;
        private System.Windows.Forms.Panel noEditWhileInstallPan;
        private System.Windows.Forms.Button serverPropertiesBtn;
        private System.Windows.Forms.TabPage Start;
        private System.Windows.Forms.Label StartServerLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label serverRunning;
        private System.Windows.Forms.Button startServerBtn;
        private System.Windows.Forms.Label serverNameLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox editServerStartOptionsGroupBox;
        private System.Windows.Forms.CheckBox restartServerIfCrash;
        private System.Windows.Forms.Label serverStartAllocatedRamLbl;
        private System.Windows.Forms.RadioButton startGBradioBtn;
        private System.Windows.Forms.ComboBox serverStartAllocatedRam;
        private System.Windows.Forms.RadioButton startMBradioBtn;
        private System.Windows.Forms.Button startServerPropertiesBtn;
        private System.Windows.Forms.Button saveChangesServerStartOptionsBtn;
        private System.Windows.Forms.Button importServerBtn;
        private System.Windows.Forms.Panel separatorPanServerEditStartOptions;
        private System.Windows.Forms.Label autoDirectoryLbl;
        private System.Windows.Forms.CheckBox autoDirectory;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label serverNameSetLbl;
        private System.Windows.Forms.TextBox serverName;
    }
}

