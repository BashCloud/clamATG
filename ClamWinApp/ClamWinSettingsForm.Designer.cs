// Name:        ClamWinSettingsForm.Designer.cs
// Product:     ClamWin Free Antivirus
//
// Author(s):      Garincho [garincho at users dot sourceforge dot net]
//
// Created:     2007/02/28
// Copyright:   Copyright ClamWin Pty Ltd (c) 2005-2007
// Licence:
//   This program is free software; you can redistribute it and/or modify
//   it under the terms of the GNU General Public License as published by
//   the Free Software Foundation; either version 2 of the License, or
//   (at your option) any later version.
//
//   This program is distributed in the hope that it will be useful,
//   but WITHOUT ANY WARRANTY; without even the implied warranty of
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//   GNU General Public License for more details.
//
//   You should have received a copy of the GNU General Public License
//   along with this program; if not, write to the Free Software
//   Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA

namespace ClamWinApp
{
    partial class ClamWinSettingsForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("File Anti-Virus");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Mail Anti-Virus");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Protection", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Scan My Computer");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Scan Critical Areas");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Scan", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Update");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Data Files");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Service", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            this.panelExSettings = new PanelsEx.PanelEx();
            this.treeViewSettings = new System.Windows.Forms.TreeView();
            this.panelExCurrentPanel = new PanelsEx.PanelEx();
            this.panelProtection = new System.Windows.Forms.Panel();
            this.groupBoxProtectionGeneral = new System.Windows.Forms.GroupBox();
            this.checkBoxRunAtStartup = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableProtection = new System.Windows.Forms.CheckBox();
            this.groupBoxSettingsManagment = new System.Windows.Forms.GroupBox();
            this.buttonSettingsReset = new System.Windows.Forms.Button();
            this.buttonSettingsSave = new System.Windows.Forms.Button();
            this.buttonSettingsLoad = new System.Windows.Forms.Button();
            this.panelFileAntivirus = new System.Windows.Forms.Panel();
            this.groupBoxFAAction = new System.Windows.Forms.GroupBox();
            this.radioButtonFAQuarantine = new System.Windows.Forms.RadioButton();
            this.radioButtonFADelete = new System.Windows.Forms.RadioButton();
            this.radioButtonFABlock = new System.Windows.Forms.RadioButton();
            this.radioButtonFAPrompt = new System.Windows.Forms.RadioButton();
            this.groupBoxFileAV = new System.Windows.Forms.GroupBox();
            this.checkBoxEnableFA = new System.Windows.Forms.CheckBox();
            this.panelMailAntivirus = new System.Windows.Forms.Panel();
            this.groupBoxMAGeneral = new System.Windows.Forms.GroupBox();
            this.checkBoxMAEnable = new System.Windows.Forms.CheckBox();
            this.panelScan = new System.Windows.Forms.Panel();
            this.groupBoxScanSchedule = new System.Windows.Forms.GroupBox();
            this.buttonScanScheduleChange = new System.Windows.Forms.Button();
            this.checkBoxScanSchedule = new System.Windows.Forms.CheckBox();
            this.groupBoxScanAction = new System.Windows.Forms.GroupBox();
            this.radioButtonScanDoNothing = new System.Windows.Forms.RadioButton();
            this.radioButtonScanDelete = new System.Windows.Forms.RadioButton();
            this.radioButtonScanPromptAfterScan = new System.Windows.Forms.RadioButton();
            this.radioButtonScanPromptDuringScan = new System.Windows.Forms.RadioButton();
            this.groupBoxScanFilter = new System.Windows.Forms.GroupBox();
            this.checkBoxScanUseFilter = new System.Windows.Forms.CheckBox();
            this.buttonScanEditFilter = new System.Windows.Forms.Button();
            this.panelScanMyPC = new System.Windows.Forms.Panel();
            this.groupBoxScanMyPCFilter = new System.Windows.Forms.GroupBox();
            this.checkBoxScanMyPCUseFilter = new System.Windows.Forms.CheckBox();
            this.buttonScanMyPCEditFilter = new System.Windows.Forms.Button();
            this.groupBoxScanMyPCSchedule = new System.Windows.Forms.GroupBox();
            this.buttonScanMyPCScheduleChange = new System.Windows.Forms.Button();
            this.checkBoxScanMyPCSchedule = new System.Windows.Forms.CheckBox();
            this.groupBoxScanMyPC = new System.Windows.Forms.GroupBox();
            this.radioButtonScanMyPCDoNothing = new System.Windows.Forms.RadioButton();
            this.radioButtonScanMyPCDelete = new System.Windows.Forms.RadioButton();
            this.radioButtonScanMyPCPromptAfterScan = new System.Windows.Forms.RadioButton();
            this.radioButtonScanMyPCPromptDuringScan = new System.Windows.Forms.RadioButton();
            this.panelScanCriticalAreas = new System.Windows.Forms.Panel();
            this.groupBoxScanCriticalFilter = new System.Windows.Forms.GroupBox();
            this.checkBoxScanCriticalUseFilter = new System.Windows.Forms.CheckBox();
            this.buttonScanCriticalEditFilter = new System.Windows.Forms.Button();
            this.groupBoxScanCriticalSchedule = new System.Windows.Forms.GroupBox();
            this.buttonScanCriticalScheduleChange = new System.Windows.Forms.Button();
            this.checkBoxScanCriticalSchedule = new System.Windows.Forms.CheckBox();
            this.groupBoxScanCriticalAction = new System.Windows.Forms.GroupBox();
            this.radioButtonScanCriticalDoNothing = new System.Windows.Forms.RadioButton();
            this.radioButtonScanCriticalDelete = new System.Windows.Forms.RadioButton();
            this.radioButtonScanCriticalPromptAfterScan = new System.Windows.Forms.RadioButton();
            this.radioButtonScanCriticalPromptDuringScan = new System.Windows.Forms.RadioButton();
            this.panelService = new System.Windows.Forms.Panel();
            this.groupBoxNotifications = new System.Windows.Forms.GroupBox();
            this.buttonNotificationsSettings = new System.Windows.Forms.Button();
            this.checkBoxEnableNotifications = new System.Windows.Forms.CheckBox();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.groupBoxUpdateRunMode = new System.Windows.Forms.GroupBox();
            this.buttonUpdateEveryChange = new System.Windows.Forms.Button();
            this.radioButtonUpdateManual = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdateEvery = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdateAuto = new System.Windows.Forms.RadioButton();
            this.groupBoxAfterUpdate = new System.Windows.Forms.GroupBox();
            this.checkBoxRescanQuarantine = new System.Windows.Forms.CheckBox();
            this.panelDataFiles = new System.Windows.Forms.Panel();
            this.groupBoxReports = new System.Windows.Forms.GroupBox();
            this.labelDeleteReportsDays = new System.Windows.Forms.Label();
            this.numericUpDownDeleteReportsDays = new System.Windows.Forms.NumericUpDown();
            this.checkBoxDeleteReports = new System.Windows.Forms.CheckBox();
            this.checkBoxKeepOnlyRecent = new System.Windows.Forms.CheckBox();
            this.checkBoxLogNonCritical = new System.Windows.Forms.CheckBox();
            this.groupBoxQuarantine = new System.Windows.Forms.GroupBox();
            this.labelDeleteFromQuarantineDays = new System.Windows.Forms.Label();
            this.numericUpDownDeleteFromQuarantineDays = new System.Windows.Forms.NumericUpDown();
            this.checkBoxDeleteFromQuarantine = new System.Windows.Forms.CheckBox();
            this.buttonSettingsOK = new System.Windows.Forms.Button();
            this.buttonSettingsClose = new System.Windows.Forms.Button();
            this.buttonSettingsApply = new System.Windows.Forms.Button();
            this.panelExSettings.SuspendLayout();
            this.panelProtection.SuspendLayout();
            this.groupBoxProtectionGeneral.SuspendLayout();
            this.groupBoxSettingsManagment.SuspendLayout();
            this.panelFileAntivirus.SuspendLayout();
            this.groupBoxFAAction.SuspendLayout();
            this.groupBoxFileAV.SuspendLayout();
            this.panelMailAntivirus.SuspendLayout();
            this.groupBoxMAGeneral.SuspendLayout();
            this.panelScan.SuspendLayout();
            this.groupBoxScanSchedule.SuspendLayout();
            this.groupBoxScanAction.SuspendLayout();
            this.groupBoxScanFilter.SuspendLayout();
            this.panelScanMyPC.SuspendLayout();
            this.groupBoxScanMyPCFilter.SuspendLayout();
            this.groupBoxScanMyPCSchedule.SuspendLayout();
            this.groupBoxScanMyPC.SuspendLayout();
            this.panelScanCriticalAreas.SuspendLayout();
            this.groupBoxScanCriticalFilter.SuspendLayout();
            this.groupBoxScanCriticalSchedule.SuspendLayout();
            this.groupBoxScanCriticalAction.SuspendLayout();
            this.panelService.SuspendLayout();
            this.groupBoxNotifications.SuspendLayout();
            this.panelUpdate.SuspendLayout();
            this.groupBoxUpdateRunMode.SuspendLayout();
            this.groupBoxAfterUpdate.SuspendLayout();
            this.panelDataFiles.SuspendLayout();
            this.groupBoxReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeleteReportsDays)).BeginInit();
            this.groupBoxQuarantine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeleteFromQuarantineDays)).BeginInit();
            this.SuspendLayout();
            // 
            // panelExSettings
            // 
            this.panelExSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelExSettings.BackColor = System.Drawing.Color.Transparent;
            this.panelExSettings.ChangeCursor = true;
            this.panelExSettings.Controls.Add(this.treeViewSettings);
            this.panelExSettings.DrawCollapseExpandIcons = false;
            this.panelExSettings.EndColour = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(212)))), ((int)(((byte)(247)))));
            this.panelExSettings.Image = global::ClamWinApp.Properties.Resources.dw;
            this.panelExSettings.Location = new System.Drawing.Point(18, 18);
            this.panelExSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelExSettings.MouseSensitive = false;
            this.panelExSettings.Name = "panelExSettings";
            this.panelExSettings.PanelState = PanelsEx.PanelState.Expanded;
            this.panelExSettings.Size = new System.Drawing.Size(288, 574);
            this.panelExSettings.StartColour = System.Drawing.Color.White;
            this.panelExSettings.TabIndex = 1;
            this.panelExSettings.TitleFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelExSettings.TitleFontColour = System.Drawing.Color.Navy;
            this.panelExSettings.TitleText = "Settings jio";
            // 
            // treeViewSettings
            // 
            this.treeViewSettings.BackColor = System.Drawing.SystemColors.ControlLight;
            this.treeViewSettings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeViewSettings.HideSelection = false;
            this.treeViewSettings.HotTracking = true;
            this.treeViewSettings.Location = new System.Drawing.Point(20, 69);
            this.treeViewSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeViewSettings.Name = "treeViewSettings";
            treeNode1.Name = "NodeFileAntivirus";
            treeNode1.Text = "File Anti-Virus";
            treeNode2.Name = "NodeMailAntivirus";
            treeNode2.Text = "Mail Anti-Virus";
            treeNode3.Name = "NodeProtection";
            treeNode3.Text = "Protection";
            treeNode4.Name = "NodeScanMyComputer";
            treeNode4.Text = "Scan My Computer";
            treeNode5.Name = "NodeScanCriticalAreas";
            treeNode5.Text = "Scan Critical Areas";
            treeNode6.Name = "NodeScan";
            treeNode6.Text = "Scan";
            treeNode7.Name = "NodeUpdate";
            treeNode7.Text = "Update";
            treeNode8.Name = "NodeDataFiles";
            treeNode8.Text = "Data Files";
            treeNode9.Name = "NodeService";
            treeNode9.Text = "Service";
            this.treeViewSettings.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9});
            this.treeViewSettings.Size = new System.Drawing.Size(243, 477);
            this.treeViewSettings.TabIndex = 1;
            this.treeViewSettings.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSettings_AfterSelect);
            // 
            // panelExCurrentPanel
            // 
            this.panelExCurrentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelExCurrentPanel.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panelExCurrentPanel.ChangeCursor = true;
            this.panelExCurrentPanel.DrawCollapseExpandIcons = false;
            this.panelExCurrentPanel.EndColour = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelExCurrentPanel.Image = global::ClamWinApp.Properties.Resources.dw;
            this.panelExCurrentPanel.Location = new System.Drawing.Point(332, 18);
            this.panelExCurrentPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelExCurrentPanel.MouseSensitive = false;
            this.panelExCurrentPanel.Name = "panelExCurrentPanel";
            this.panelExCurrentPanel.PanelState = PanelsEx.PanelState.Expanded;
            this.panelExCurrentPanel.Size = new System.Drawing.Size(459, 55);
            this.panelExCurrentPanel.StartColour = System.Drawing.Color.Black;
            this.panelExCurrentPanel.TabIndex = 2;
            this.panelExCurrentPanel.TitleFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelExCurrentPanel.TitleFontColour = System.Drawing.Color.White;
            this.panelExCurrentPanel.TitleText = "Current setting jio";
            // 
            // panelProtection
            // 
            this.panelProtection.Controls.Add(this.groupBoxProtectionGeneral);
            this.panelProtection.Controls.Add(this.groupBoxSettingsManagment);
            this.panelProtection.Location = new System.Drawing.Point(332, 88);
            this.panelProtection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelProtection.Name = "panelProtection";
            this.panelProtection.Size = new System.Drawing.Size(459, 438);
            this.panelProtection.TabIndex = 3;
            // 
            // groupBoxProtectionGeneral
            // 
            this.groupBoxProtectionGeneral.Controls.Add(this.checkBoxRunAtStartup);
            this.groupBoxProtectionGeneral.Controls.Add(this.checkBoxEnableProtection);
            this.groupBoxProtectionGeneral.Location = new System.Drawing.Point(0, 5);
            this.groupBoxProtectionGeneral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxProtectionGeneral.Name = "groupBoxProtectionGeneral";
            this.groupBoxProtectionGeneral.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxProtectionGeneral.Size = new System.Drawing.Size(459, 112);
            this.groupBoxProtectionGeneral.TabIndex = 0;
            this.groupBoxProtectionGeneral.TabStop = false;
            this.groupBoxProtectionGeneral.Text = "General";
            // 
            // checkBoxRunAtStartup
            // 
            this.checkBoxRunAtStartup.AutoSize = true;
            this.checkBoxRunAtStartup.Location = new System.Drawing.Point(9, 65);
            this.checkBoxRunAtStartup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxRunAtStartup.Name = "checkBoxRunAtStartup";
            this.checkBoxRunAtStartup.Size = new System.Drawing.Size(258, 24);
            this.checkBoxRunAtStartup.TabIndex = 1;
            this.checkBoxRunAtStartup.Text = "Run ClamWin at system startup";
            this.checkBoxRunAtStartup.UseVisualStyleBackColor = true;
            this.checkBoxRunAtStartup.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxEnableProtection
            // 
            this.checkBoxEnableProtection.AutoSize = true;
            this.checkBoxEnableProtection.Location = new System.Drawing.Point(9, 29);
            this.checkBoxEnableProtection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxEnableProtection.Name = "checkBoxEnableProtection";
            this.checkBoxEnableProtection.Size = new System.Drawing.Size(161, 24);
            this.checkBoxEnableProtection.TabIndex = 0;
            this.checkBoxEnableProtection.Text = "Enable Protection";
            this.checkBoxEnableProtection.UseVisualStyleBackColor = true;
            this.checkBoxEnableProtection.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // groupBoxSettingsManagment
            // 
            this.groupBoxSettingsManagment.Controls.Add(this.buttonSettingsReset);
            this.groupBoxSettingsManagment.Controls.Add(this.buttonSettingsSave);
            this.groupBoxSettingsManagment.Controls.Add(this.buttonSettingsLoad);
            this.groupBoxSettingsManagment.Location = new System.Drawing.Point(0, 122);
            this.groupBoxSettingsManagment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSettingsManagment.Name = "groupBoxSettingsManagment";
            this.groupBoxSettingsManagment.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSettingsManagment.Size = new System.Drawing.Size(459, 103);
            this.groupBoxSettingsManagment.TabIndex = 2;
            this.groupBoxSettingsManagment.TabStop = false;
            this.groupBoxSettingsManagment.Text = "Settings managment";
            // 
            // buttonSettingsReset
            // 
            this.buttonSettingsReset.Location = new System.Drawing.Point(309, 45);
            this.buttonSettingsReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSettingsReset.Name = "buttonSettingsReset";
            this.buttonSettingsReset.Size = new System.Drawing.Size(141, 35);
            this.buttonSettingsReset.TabIndex = 2;
            this.buttonSettingsReset.Text = "Reset...";
            this.buttonSettingsReset.UseVisualStyleBackColor = true;
            // 
            // buttonSettingsSave
            // 
            this.buttonSettingsSave.Location = new System.Drawing.Point(159, 45);
            this.buttonSettingsSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSettingsSave.Name = "buttonSettingsSave";
            this.buttonSettingsSave.Size = new System.Drawing.Size(141, 35);
            this.buttonSettingsSave.TabIndex = 1;
            this.buttonSettingsSave.Text = "Save...";
            this.buttonSettingsSave.UseVisualStyleBackColor = true;
            // 
            // buttonSettingsLoad
            // 
            this.buttonSettingsLoad.Location = new System.Drawing.Point(9, 45);
            this.buttonSettingsLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSettingsLoad.Name = "buttonSettingsLoad";
            this.buttonSettingsLoad.Size = new System.Drawing.Size(141, 35);
            this.buttonSettingsLoad.TabIndex = 0;
            this.buttonSettingsLoad.Text = "Load...";
            this.buttonSettingsLoad.UseVisualStyleBackColor = true;
            // 
            // panelFileAntivirus
            // 
            this.panelFileAntivirus.Controls.Add(this.groupBoxFAAction);
            this.panelFileAntivirus.Controls.Add(this.groupBoxFileAV);
            this.panelFileAntivirus.Location = new System.Drawing.Point(332, 88);
            this.panelFileAntivirus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelFileAntivirus.Name = "panelFileAntivirus";
            this.panelFileAntivirus.Size = new System.Drawing.Size(459, 438);
            this.panelFileAntivirus.TabIndex = 4;
            // 
            // groupBoxFAAction
            // 
            this.groupBoxFAAction.Controls.Add(this.radioButtonFAQuarantine);
            this.groupBoxFAAction.Controls.Add(this.radioButtonFADelete);
            this.groupBoxFAAction.Controls.Add(this.radioButtonFABlock);
            this.groupBoxFAAction.Controls.Add(this.radioButtonFAPrompt);
            this.groupBoxFAAction.Location = new System.Drawing.Point(0, 83);
            this.groupBoxFAAction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxFAAction.Name = "groupBoxFAAction";
            this.groupBoxFAAction.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxFAAction.Size = new System.Drawing.Size(459, 180);
            this.groupBoxFAAction.TabIndex = 1;
            this.groupBoxFAAction.TabStop = false;
            this.groupBoxFAAction.Text = "On Detect";
            // 
            // radioButtonFAQuarantine
            // 
            this.radioButtonFAQuarantine.AutoSize = true;
            this.radioButtonFAQuarantine.Location = new System.Drawing.Point(9, 134);
            this.radioButtonFAQuarantine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonFAQuarantine.Name = "radioButtonFAQuarantine";
            this.radioButtonFAQuarantine.Size = new System.Drawing.Size(173, 24);
            this.radioButtonFAQuarantine.TabIndex = 3;
            this.radioButtonFAQuarantine.TabStop = true;
            this.radioButtonFAQuarantine.Text = "Move to Quarantine";
            this.radioButtonFAQuarantine.UseVisualStyleBackColor = true;
            this.radioButtonFAQuarantine.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonFADelete
            // 
            this.radioButtonFADelete.AutoSize = true;
            this.radioButtonFADelete.Location = new System.Drawing.Point(9, 98);
            this.radioButtonFADelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonFADelete.Name = "radioButtonFADelete";
            this.radioButtonFADelete.Size = new System.Drawing.Size(81, 24);
            this.radioButtonFADelete.TabIndex = 2;
            this.radioButtonFADelete.TabStop = true;
            this.radioButtonFADelete.Text = "Delete";
            this.radioButtonFADelete.UseVisualStyleBackColor = true;
            this.radioButtonFADelete.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonFABlock
            // 
            this.radioButtonFABlock.AutoSize = true;
            this.radioButtonFABlock.Location = new System.Drawing.Point(9, 63);
            this.radioButtonFABlock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonFABlock.Name = "radioButtonFABlock";
            this.radioButtonFABlock.Size = new System.Drawing.Size(127, 24);
            this.radioButtonFABlock.TabIndex = 1;
            this.radioButtonFABlock.TabStop = true;
            this.radioButtonFABlock.Text = "Block access";
            this.radioButtonFABlock.UseVisualStyleBackColor = true;
            this.radioButtonFABlock.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonFAPrompt
            // 
            this.radioButtonFAPrompt.AutoSize = true;
            this.radioButtonFAPrompt.Location = new System.Drawing.Point(9, 29);
            this.radioButtonFAPrompt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonFAPrompt.Name = "radioButtonFAPrompt";
            this.radioButtonFAPrompt.Size = new System.Drawing.Size(155, 24);
            this.radioButtonFAPrompt.TabIndex = 0;
            this.radioButtonFAPrompt.TabStop = true;
            this.radioButtonFAPrompt.Text = "Prompt for action";
            this.radioButtonFAPrompt.UseVisualStyleBackColor = true;
            this.radioButtonFAPrompt.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBoxFileAV
            // 
            this.groupBoxFileAV.Controls.Add(this.checkBoxEnableFA);
            this.groupBoxFileAV.Location = new System.Drawing.Point(0, 5);
            this.groupBoxFileAV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxFileAV.Name = "groupBoxFileAV";
            this.groupBoxFileAV.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxFileAV.Size = new System.Drawing.Size(459, 69);
            this.groupBoxFileAV.TabIndex = 0;
            this.groupBoxFileAV.TabStop = false;
            this.groupBoxFileAV.Text = "General";
            // 
            // checkBoxEnableFA
            // 
            this.checkBoxEnableFA.AutoSize = true;
            this.checkBoxEnableFA.Location = new System.Drawing.Point(9, 29);
            this.checkBoxEnableFA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxEnableFA.Name = "checkBoxEnableFA";
            this.checkBoxEnableFA.Size = new System.Drawing.Size(187, 24);
            this.checkBoxEnableFA.TabIndex = 0;
            this.checkBoxEnableFA.Text = "Enable File Anti-Virus";
            this.checkBoxEnableFA.UseVisualStyleBackColor = true;
            this.checkBoxEnableFA.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // panelMailAntivirus
            // 
            this.panelMailAntivirus.Controls.Add(this.groupBoxMAGeneral);
            this.panelMailAntivirus.Location = new System.Drawing.Point(332, 88);
            this.panelMailAntivirus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMailAntivirus.Name = "panelMailAntivirus";
            this.panelMailAntivirus.Size = new System.Drawing.Size(459, 438);
            this.panelMailAntivirus.TabIndex = 4;
            // 
            // groupBoxMAGeneral
            // 
            this.groupBoxMAGeneral.Controls.Add(this.checkBoxMAEnable);
            this.groupBoxMAGeneral.Location = new System.Drawing.Point(0, 5);
            this.groupBoxMAGeneral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxMAGeneral.Name = "groupBoxMAGeneral";
            this.groupBoxMAGeneral.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxMAGeneral.Size = new System.Drawing.Size(459, 69);
            this.groupBoxMAGeneral.TabIndex = 0;
            this.groupBoxMAGeneral.TabStop = false;
            this.groupBoxMAGeneral.Text = "General";
            // 
            // checkBoxMAEnable
            // 
            this.checkBoxMAEnable.AutoSize = true;
            this.checkBoxMAEnable.Location = new System.Drawing.Point(9, 29);
            this.checkBoxMAEnable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxMAEnable.Name = "checkBoxMAEnable";
            this.checkBoxMAEnable.Size = new System.Drawing.Size(190, 24);
            this.checkBoxMAEnable.TabIndex = 0;
            this.checkBoxMAEnable.Text = "Enable Mail Anti-Virus";
            this.checkBoxMAEnable.UseVisualStyleBackColor = true;
            this.checkBoxMAEnable.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // panelScan
            // 
            this.panelScan.Controls.Add(this.groupBoxScanSchedule);
            this.panelScan.Controls.Add(this.groupBoxScanAction);
            this.panelScan.Controls.Add(this.groupBoxScanFilter);
            this.panelScan.Location = new System.Drawing.Point(332, 88);
            this.panelScan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelScan.Name = "panelScan";
            this.panelScan.Size = new System.Drawing.Size(459, 438);
            this.panelScan.TabIndex = 4;
            // 
            // groupBoxScanSchedule
            // 
            this.groupBoxScanSchedule.Controls.Add(this.buttonScanScheduleChange);
            this.groupBoxScanSchedule.Controls.Add(this.checkBoxScanSchedule);
            this.groupBoxScanSchedule.Location = new System.Drawing.Point(0, 209);
            this.groupBoxScanSchedule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxScanSchedule.Name = "groupBoxScanSchedule";
            this.groupBoxScanSchedule.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxScanSchedule.Size = new System.Drawing.Size(459, 68);
            this.groupBoxScanSchedule.TabIndex = 8;
            this.groupBoxScanSchedule.TabStop = false;
            this.groupBoxScanSchedule.Text = "Schedule";
            // 
            // buttonScanScheduleChange
            // 
            this.buttonScanScheduleChange.Location = new System.Drawing.Point(308, 23);
            this.buttonScanScheduleChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonScanScheduleChange.Name = "buttonScanScheduleChange";
            this.buttonScanScheduleChange.Size = new System.Drawing.Size(142, 35);
            this.buttonScanScheduleChange.TabIndex = 10;
            this.buttonScanScheduleChange.Text = "Change...";
            this.buttonScanScheduleChange.UseVisualStyleBackColor = true;
            this.buttonScanScheduleChange.Click += new System.EventHandler(this.buttonScanScheduleChange_Click);
            // 
            // checkBoxScanSchedule
            // 
            this.checkBoxScanSchedule.AutoSize = true;
            this.checkBoxScanSchedule.Location = new System.Drawing.Point(9, 29);
            this.checkBoxScanSchedule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxScanSchedule.Name = "checkBoxScanSchedule";
            this.checkBoxScanSchedule.Size = new System.Drawing.Size(148, 24);
            this.checkBoxScanSchedule.TabIndex = 0;
            this.checkBoxScanSchedule.Text = "Schedule scans";
            this.checkBoxScanSchedule.UseVisualStyleBackColor = true;
            this.checkBoxScanSchedule.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // groupBoxScanAction
            // 
            this.groupBoxScanAction.Controls.Add(this.radioButtonScanDoNothing);
            this.groupBoxScanAction.Controls.Add(this.radioButtonScanDelete);
            this.groupBoxScanAction.Controls.Add(this.radioButtonScanPromptAfterScan);
            this.groupBoxScanAction.Controls.Add(this.radioButtonScanPromptDuringScan);
            this.groupBoxScanAction.Location = new System.Drawing.Point(0, 11);
            this.groupBoxScanAction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxScanAction.Name = "groupBoxScanAction";
            this.groupBoxScanAction.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxScanAction.Size = new System.Drawing.Size(459, 180);
            this.groupBoxScanAction.TabIndex = 0;
            this.groupBoxScanAction.TabStop = false;
            this.groupBoxScanAction.Text = "Action";
            // 
            // radioButtonScanDoNothing
            // 
            this.radioButtonScanDoNothing.AutoSize = true;
            this.radioButtonScanDoNothing.Location = new System.Drawing.Point(9, 134);
            this.radioButtonScanDoNothing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonScanDoNothing.Name = "radioButtonScanDoNothing";
            this.radioButtonScanDoNothing.Size = new System.Drawing.Size(203, 24);
            this.radioButtonScanDoNothing.TabIndex = 3;
            this.radioButtonScanDoNothing.TabStop = true;
            this.radioButtonScanDoNothing.Text = "Detect only (do nothing)";
            this.radioButtonScanDoNothing.UseVisualStyleBackColor = true;
            this.radioButtonScanDoNothing.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonScanDelete
            // 
            this.radioButtonScanDelete.AutoSize = true;
            this.radioButtonScanDelete.Location = new System.Drawing.Point(9, 98);
            this.radioButtonScanDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonScanDelete.Name = "radioButtonScanDelete";
            this.radioButtonScanDelete.Size = new System.Drawing.Size(81, 24);
            this.radioButtonScanDelete.TabIndex = 2;
            this.radioButtonScanDelete.TabStop = true;
            this.radioButtonScanDelete.Text = "Delete";
            this.radioButtonScanDelete.UseVisualStyleBackColor = true;
            this.radioButtonScanDelete.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonScanPromptAfterScan
            // 
            this.radioButtonScanPromptAfterScan.AutoSize = true;
            this.radioButtonScanPromptAfterScan.Location = new System.Drawing.Point(9, 63);
            this.radioButtonScanPromptAfterScan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonScanPromptAfterScan.Name = "radioButtonScanPromptAfterScan";
            this.radioButtonScanPromptAfterScan.Size = new System.Drawing.Size(346, 24);
            this.radioButtonScanPromptAfterScan.TabIndex = 1;
            this.radioButtonScanPromptAfterScan.TabStop = true;
            this.radioButtonScanPromptAfterScan.Text = "Prompt for action when the scan is complete";
            this.radioButtonScanPromptAfterScan.UseVisualStyleBackColor = true;
            this.radioButtonScanPromptAfterScan.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonScanPromptDuringScan
            // 
            this.radioButtonScanPromptDuringScan.AutoSize = true;
            this.radioButtonScanPromptDuringScan.Location = new System.Drawing.Point(9, 28);
            this.radioButtonScanPromptDuringScan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonScanPromptDuringScan.Name = "radioButtonScanPromptDuringScan";
            this.radioButtonScanPromptDuringScan.Size = new System.Drawing.Size(241, 24);
            this.radioButtonScanPromptDuringScan.TabIndex = 0;
            this.radioButtonScanPromptDuringScan.TabStop = true;
            this.radioButtonScanPromptDuringScan.Text = "Prompt for action during scan";
            this.radioButtonScanPromptDuringScan.UseVisualStyleBackColor = true;
            this.radioButtonScanPromptDuringScan.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBoxScanFilter
            // 
            this.groupBoxScanFilter.Controls.Add(this.checkBoxScanUseFilter);
            this.groupBoxScanFilter.Controls.Add(this.buttonScanEditFilter);
            this.groupBoxScanFilter.Location = new System.Drawing.Point(0, 286);
            this.groupBoxScanFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxScanFilter.Name = "groupBoxScanFilter";
            this.groupBoxScanFilter.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxScanFilter.Size = new System.Drawing.Size(459, 69);
            this.groupBoxScanFilter.TabIndex = 4;
            this.groupBoxScanFilter.TabStop = false;
            this.groupBoxScanFilter.Text = "Filter";
            // 
            // checkBoxScanUseFilter
            // 
            this.checkBoxScanUseFilter.AutoSize = true;
            this.checkBoxScanUseFilter.Location = new System.Drawing.Point(9, 29);
            this.checkBoxScanUseFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxScanUseFilter.Name = "checkBoxScanUseFilter";
            this.checkBoxScanUseFilter.Size = new System.Drawing.Size(98, 24);
            this.checkBoxScanUseFilter.TabIndex = 11;
            this.checkBoxScanUseFilter.Text = "Use filter";
            this.checkBoxScanUseFilter.UseVisualStyleBackColor = true;
            this.checkBoxScanUseFilter.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // buttonScanEditFilter
            // 
            this.buttonScanEditFilter.Location = new System.Drawing.Point(308, 23);
            this.buttonScanEditFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonScanEditFilter.Name = "buttonScanEditFilter";
            this.buttonScanEditFilter.Size = new System.Drawing.Size(142, 35);
            this.buttonScanEditFilter.TabIndex = 11;
            this.buttonScanEditFilter.Text = "Edit...";
            this.buttonScanEditFilter.UseVisualStyleBackColor = true;
            this.buttonScanEditFilter.Click += new System.EventHandler(this.buttonScanEditFilter_Click);
            // 
            // panelScanMyPC
            // 
            this.panelScanMyPC.Controls.Add(this.groupBoxScanMyPCFilter);
            this.panelScanMyPC.Controls.Add(this.groupBoxScanMyPCSchedule);
            this.panelScanMyPC.Controls.Add(this.groupBoxScanMyPC);
            this.panelScanMyPC.Location = new System.Drawing.Point(332, 88);
            this.panelScanMyPC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelScanMyPC.Name = "panelScanMyPC";
            this.panelScanMyPC.Size = new System.Drawing.Size(459, 438);
            this.panelScanMyPC.TabIndex = 4;
            // 
            // groupBoxScanMyPCFilter
            // 
            this.groupBoxScanMyPCFilter.Controls.Add(this.checkBoxScanMyPCUseFilter);
            this.groupBoxScanMyPCFilter.Controls.Add(this.buttonScanMyPCEditFilter);
            this.groupBoxScanMyPCFilter.Location = new System.Drawing.Point(0, 286);
            this.groupBoxScanMyPCFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxScanMyPCFilter.Name = "groupBoxScanMyPCFilter";
            this.groupBoxScanMyPCFilter.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxScanMyPCFilter.Size = new System.Drawing.Size(459, 69);
            this.groupBoxScanMyPCFilter.TabIndex = 9;
            this.groupBoxScanMyPCFilter.TabStop = false;
            this.groupBoxScanMyPCFilter.Text = "Filter";
            // 
            // checkBoxScanMyPCUseFilter
            // 
            this.checkBoxScanMyPCUseFilter.AutoSize = true;
            this.checkBoxScanMyPCUseFilter.Location = new System.Drawing.Point(9, 29);
            this.checkBoxScanMyPCUseFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxScanMyPCUseFilter.Name = "checkBoxScanMyPCUseFilter";
            this.checkBoxScanMyPCUseFilter.Size = new System.Drawing.Size(98, 24);
            this.checkBoxScanMyPCUseFilter.TabIndex = 11;
            this.checkBoxScanMyPCUseFilter.Text = "Use filter";
            this.checkBoxScanMyPCUseFilter.UseVisualStyleBackColor = true;
            this.checkBoxScanMyPCUseFilter.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // buttonScanMyPCEditFilter
            // 
            this.buttonScanMyPCEditFilter.Location = new System.Drawing.Point(308, 23);
            this.buttonScanMyPCEditFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonScanMyPCEditFilter.Name = "buttonScanMyPCEditFilter";
            this.buttonScanMyPCEditFilter.Size = new System.Drawing.Size(142, 35);
            this.buttonScanMyPCEditFilter.TabIndex = 11;
            this.buttonScanMyPCEditFilter.Text = "Edit...";
            this.buttonScanMyPCEditFilter.UseVisualStyleBackColor = true;
            this.buttonScanMyPCEditFilter.Click += new System.EventHandler(this.buttonScanMyPCEditFilter_Click);
            // 
            // groupBoxScanMyPCSchedule
            // 
            this.groupBoxScanMyPCSchedule.Controls.Add(this.buttonScanMyPCScheduleChange);
            this.groupBoxScanMyPCSchedule.Controls.Add(this.checkBoxScanMyPCSchedule);
            this.groupBoxScanMyPCSchedule.Location = new System.Drawing.Point(0, 209);
            this.groupBoxScanMyPCSchedule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxScanMyPCSchedule.Name = "groupBoxScanMyPCSchedule";
            this.groupBoxScanMyPCSchedule.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxScanMyPCSchedule.Size = new System.Drawing.Size(459, 68);
            this.groupBoxScanMyPCSchedule.TabIndex = 8;
            this.groupBoxScanMyPCSchedule.TabStop = false;
            this.groupBoxScanMyPCSchedule.Text = "Schedule";
            // 
            // buttonScanMyPCScheduleChange
            // 
            this.buttonScanMyPCScheduleChange.Location = new System.Drawing.Point(308, 23);
            this.buttonScanMyPCScheduleChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonScanMyPCScheduleChange.Name = "buttonScanMyPCScheduleChange";
            this.buttonScanMyPCScheduleChange.Size = new System.Drawing.Size(142, 35);
            this.buttonScanMyPCScheduleChange.TabIndex = 10;
            this.buttonScanMyPCScheduleChange.Text = "Change...";
            this.buttonScanMyPCScheduleChange.UseVisualStyleBackColor = true;
            this.buttonScanMyPCScheduleChange.Click += new System.EventHandler(this.buttonScanMyPCSchedule_Click);
            // 
            // checkBoxScanMyPCSchedule
            // 
            this.checkBoxScanMyPCSchedule.AutoSize = true;
            this.checkBoxScanMyPCSchedule.Location = new System.Drawing.Point(9, 29);
            this.checkBoxScanMyPCSchedule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxScanMyPCSchedule.Name = "checkBoxScanMyPCSchedule";
            this.checkBoxScanMyPCSchedule.Size = new System.Drawing.Size(148, 24);
            this.checkBoxScanMyPCSchedule.TabIndex = 0;
            this.checkBoxScanMyPCSchedule.Text = "Schedule scans";
            this.checkBoxScanMyPCSchedule.UseVisualStyleBackColor = true;
            this.checkBoxScanMyPCSchedule.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // groupBoxScanMyPC
            // 
            this.groupBoxScanMyPC.Controls.Add(this.radioButtonScanMyPCDoNothing);
            this.groupBoxScanMyPC.Controls.Add(this.radioButtonScanMyPCDelete);
            this.groupBoxScanMyPC.Controls.Add(this.radioButtonScanMyPCPromptAfterScan);
            this.groupBoxScanMyPC.Controls.Add(this.radioButtonScanMyPCPromptDuringScan);
            this.groupBoxScanMyPC.Location = new System.Drawing.Point(0, 11);
            this.groupBoxScanMyPC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxScanMyPC.Name = "groupBoxScanMyPC";
            this.groupBoxScanMyPC.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxScanMyPC.Size = new System.Drawing.Size(459, 180);
            this.groupBoxScanMyPC.TabIndex = 1;
            this.groupBoxScanMyPC.TabStop = false;
            this.groupBoxScanMyPC.Text = "Action";
            // 
            // radioButtonScanMyPCDoNothing
            // 
            this.radioButtonScanMyPCDoNothing.AutoSize = true;
            this.radioButtonScanMyPCDoNothing.Location = new System.Drawing.Point(9, 134);
            this.radioButtonScanMyPCDoNothing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonScanMyPCDoNothing.Name = "radioButtonScanMyPCDoNothing";
            this.radioButtonScanMyPCDoNothing.Size = new System.Drawing.Size(203, 24);
            this.radioButtonScanMyPCDoNothing.TabIndex = 3;
            this.radioButtonScanMyPCDoNothing.TabStop = true;
            this.radioButtonScanMyPCDoNothing.Text = "Detect only (do nothing)";
            this.radioButtonScanMyPCDoNothing.UseVisualStyleBackColor = true;
            this.radioButtonScanMyPCDoNothing.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonScanMyPCDelete
            // 
            this.radioButtonScanMyPCDelete.AutoSize = true;
            this.radioButtonScanMyPCDelete.Location = new System.Drawing.Point(9, 98);
            this.radioButtonScanMyPCDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonScanMyPCDelete.Name = "radioButtonScanMyPCDelete";
            this.radioButtonScanMyPCDelete.Size = new System.Drawing.Size(81, 24);
            this.radioButtonScanMyPCDelete.TabIndex = 2;
            this.radioButtonScanMyPCDelete.TabStop = true;
            this.radioButtonScanMyPCDelete.Text = "Delete";
            this.radioButtonScanMyPCDelete.UseVisualStyleBackColor = true;
            this.radioButtonScanMyPCDelete.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonScanMyPCPromptAfterScan
            // 
            this.radioButtonScanMyPCPromptAfterScan.AutoSize = true;
            this.radioButtonScanMyPCPromptAfterScan.Location = new System.Drawing.Point(9, 63);
            this.radioButtonScanMyPCPromptAfterScan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonScanMyPCPromptAfterScan.Name = "radioButtonScanMyPCPromptAfterScan";
            this.radioButtonScanMyPCPromptAfterScan.Size = new System.Drawing.Size(346, 24);
            this.radioButtonScanMyPCPromptAfterScan.TabIndex = 1;
            this.radioButtonScanMyPCPromptAfterScan.TabStop = true;
            this.radioButtonScanMyPCPromptAfterScan.Text = "Prompt for action when the scan is complete";
            this.radioButtonScanMyPCPromptAfterScan.UseVisualStyleBackColor = true;
            this.radioButtonScanMyPCPromptAfterScan.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonScanMyPCPromptDuringScan
            // 
            this.radioButtonScanMyPCPromptDuringScan.AutoSize = true;
            this.radioButtonScanMyPCPromptDuringScan.Location = new System.Drawing.Point(9, 28);
            this.radioButtonScanMyPCPromptDuringScan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonScanMyPCPromptDuringScan.Name = "radioButtonScanMyPCPromptDuringScan";
            this.radioButtonScanMyPCPromptDuringScan.Size = new System.Drawing.Size(241, 24);
            this.radioButtonScanMyPCPromptDuringScan.TabIndex = 0;
            this.radioButtonScanMyPCPromptDuringScan.TabStop = true;
            this.radioButtonScanMyPCPromptDuringScan.Text = "Prompt for action during scan";
            this.radioButtonScanMyPCPromptDuringScan.UseVisualStyleBackColor = true;
            this.radioButtonScanMyPCPromptDuringScan.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // panelScanCriticalAreas
            // 
            this.panelScanCriticalAreas.Controls.Add(this.groupBoxScanCriticalFilter);
            this.panelScanCriticalAreas.Controls.Add(this.groupBoxScanCriticalSchedule);
            this.panelScanCriticalAreas.Controls.Add(this.groupBoxScanCriticalAction);
            this.panelScanCriticalAreas.Location = new System.Drawing.Point(332, 88);
            this.panelScanCriticalAreas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelScanCriticalAreas.Name = "panelScanCriticalAreas";
            this.panelScanCriticalAreas.Size = new System.Drawing.Size(459, 438);
            this.panelScanCriticalAreas.TabIndex = 4;
            // 
            // groupBoxScanCriticalFilter
            // 
            this.groupBoxScanCriticalFilter.Controls.Add(this.checkBoxScanCriticalUseFilter);
            this.groupBoxScanCriticalFilter.Controls.Add(this.buttonScanCriticalEditFilter);
            this.groupBoxScanCriticalFilter.Location = new System.Drawing.Point(0, 286);
            this.groupBoxScanCriticalFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxScanCriticalFilter.Name = "groupBoxScanCriticalFilter";
            this.groupBoxScanCriticalFilter.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxScanCriticalFilter.Size = new System.Drawing.Size(459, 69);
            this.groupBoxScanCriticalFilter.TabIndex = 8;
            this.groupBoxScanCriticalFilter.TabStop = false;
            this.groupBoxScanCriticalFilter.Text = "Filter";
            // 
            // checkBoxScanCriticalUseFilter
            // 
            this.checkBoxScanCriticalUseFilter.AutoSize = true;
            this.checkBoxScanCriticalUseFilter.Location = new System.Drawing.Point(9, 29);
            this.checkBoxScanCriticalUseFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxScanCriticalUseFilter.Name = "checkBoxScanCriticalUseFilter";
            this.checkBoxScanCriticalUseFilter.Size = new System.Drawing.Size(98, 24);
            this.checkBoxScanCriticalUseFilter.TabIndex = 11;
            this.checkBoxScanCriticalUseFilter.Text = "Use filter";
            this.checkBoxScanCriticalUseFilter.UseVisualStyleBackColor = true;
            this.checkBoxScanCriticalUseFilter.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // buttonScanCriticalEditFilter
            // 
            this.buttonScanCriticalEditFilter.Location = new System.Drawing.Point(308, 23);
            this.buttonScanCriticalEditFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonScanCriticalEditFilter.Name = "buttonScanCriticalEditFilter";
            this.buttonScanCriticalEditFilter.Size = new System.Drawing.Size(142, 35);
            this.buttonScanCriticalEditFilter.TabIndex = 11;
            this.buttonScanCriticalEditFilter.Text = "Edit...";
            this.buttonScanCriticalEditFilter.UseVisualStyleBackColor = true;
            this.buttonScanCriticalEditFilter.Click += new System.EventHandler(this.buttonScanCriticalEditFilter_Click);
            // 
            // groupBoxScanCriticalSchedule
            // 
            this.groupBoxScanCriticalSchedule.Controls.Add(this.buttonScanCriticalScheduleChange);
            this.groupBoxScanCriticalSchedule.Controls.Add(this.checkBoxScanCriticalSchedule);
            this.groupBoxScanCriticalSchedule.Location = new System.Drawing.Point(0, 209);
            this.groupBoxScanCriticalSchedule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxScanCriticalSchedule.Name = "groupBoxScanCriticalSchedule";
            this.groupBoxScanCriticalSchedule.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxScanCriticalSchedule.Size = new System.Drawing.Size(459, 68);
            this.groupBoxScanCriticalSchedule.TabIndex = 7;
            this.groupBoxScanCriticalSchedule.TabStop = false;
            this.groupBoxScanCriticalSchedule.Text = "Schedule";
            // 
            // buttonScanCriticalScheduleChange
            // 
            this.buttonScanCriticalScheduleChange.Location = new System.Drawing.Point(308, 23);
            this.buttonScanCriticalScheduleChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonScanCriticalScheduleChange.Name = "buttonScanCriticalScheduleChange";
            this.buttonScanCriticalScheduleChange.Size = new System.Drawing.Size(142, 35);
            this.buttonScanCriticalScheduleChange.TabIndex = 10;
            this.buttonScanCriticalScheduleChange.Text = "Change...";
            this.buttonScanCriticalScheduleChange.UseVisualStyleBackColor = true;
            this.buttonScanCriticalScheduleChange.Click += new System.EventHandler(this.buttonScanCriticalScheduleChange_Click);
            // 
            // checkBoxScanCriticalSchedule
            // 
            this.checkBoxScanCriticalSchedule.AutoSize = true;
            this.checkBoxScanCriticalSchedule.Location = new System.Drawing.Point(9, 29);
            this.checkBoxScanCriticalSchedule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxScanCriticalSchedule.Name = "checkBoxScanCriticalSchedule";
            this.checkBoxScanCriticalSchedule.Size = new System.Drawing.Size(148, 24);
            this.checkBoxScanCriticalSchedule.TabIndex = 0;
            this.checkBoxScanCriticalSchedule.Text = "Schedule scans";
            this.checkBoxScanCriticalSchedule.UseVisualStyleBackColor = true;
            this.checkBoxScanCriticalSchedule.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // groupBoxScanCriticalAction
            // 
            this.groupBoxScanCriticalAction.Controls.Add(this.radioButtonScanCriticalDoNothing);
            this.groupBoxScanCriticalAction.Controls.Add(this.radioButtonScanCriticalDelete);
            this.groupBoxScanCriticalAction.Controls.Add(this.radioButtonScanCriticalPromptAfterScan);
            this.groupBoxScanCriticalAction.Controls.Add(this.radioButtonScanCriticalPromptDuringScan);
            this.groupBoxScanCriticalAction.Location = new System.Drawing.Point(0, 11);
            this.groupBoxScanCriticalAction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxScanCriticalAction.Name = "groupBoxScanCriticalAction";
            this.groupBoxScanCriticalAction.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxScanCriticalAction.Size = new System.Drawing.Size(459, 180);
            this.groupBoxScanCriticalAction.TabIndex = 5;
            this.groupBoxScanCriticalAction.TabStop = false;
            this.groupBoxScanCriticalAction.Text = "Action";
            // 
            // radioButtonScanCriticalDoNothing
            // 
            this.radioButtonScanCriticalDoNothing.AutoSize = true;
            this.radioButtonScanCriticalDoNothing.Location = new System.Drawing.Point(9, 134);
            this.radioButtonScanCriticalDoNothing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonScanCriticalDoNothing.Name = "radioButtonScanCriticalDoNothing";
            this.radioButtonScanCriticalDoNothing.Size = new System.Drawing.Size(203, 24);
            this.radioButtonScanCriticalDoNothing.TabIndex = 3;
            this.radioButtonScanCriticalDoNothing.TabStop = true;
            this.radioButtonScanCriticalDoNothing.Text = "Detect only (do nothing)";
            this.radioButtonScanCriticalDoNothing.UseVisualStyleBackColor = true;
            this.radioButtonScanCriticalDoNothing.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonScanCriticalDelete
            // 
            this.radioButtonScanCriticalDelete.AutoSize = true;
            this.radioButtonScanCriticalDelete.Location = new System.Drawing.Point(9, 98);
            this.radioButtonScanCriticalDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonScanCriticalDelete.Name = "radioButtonScanCriticalDelete";
            this.radioButtonScanCriticalDelete.Size = new System.Drawing.Size(81, 24);
            this.radioButtonScanCriticalDelete.TabIndex = 2;
            this.radioButtonScanCriticalDelete.TabStop = true;
            this.radioButtonScanCriticalDelete.Text = "Delete";
            this.radioButtonScanCriticalDelete.UseVisualStyleBackColor = true;
            this.radioButtonScanCriticalDelete.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonScanCriticalPromptAfterScan
            // 
            this.radioButtonScanCriticalPromptAfterScan.AutoSize = true;
            this.radioButtonScanCriticalPromptAfterScan.Location = new System.Drawing.Point(9, 63);
            this.radioButtonScanCriticalPromptAfterScan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonScanCriticalPromptAfterScan.Name = "radioButtonScanCriticalPromptAfterScan";
            this.radioButtonScanCriticalPromptAfterScan.Size = new System.Drawing.Size(346, 24);
            this.radioButtonScanCriticalPromptAfterScan.TabIndex = 1;
            this.radioButtonScanCriticalPromptAfterScan.TabStop = true;
            this.radioButtonScanCriticalPromptAfterScan.Text = "Prompt for action when the scan is complete";
            this.radioButtonScanCriticalPromptAfterScan.UseVisualStyleBackColor = true;
            this.radioButtonScanCriticalPromptAfterScan.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonScanCriticalPromptDuringScan
            // 
            this.radioButtonScanCriticalPromptDuringScan.AutoSize = true;
            this.radioButtonScanCriticalPromptDuringScan.Location = new System.Drawing.Point(9, 28);
            this.radioButtonScanCriticalPromptDuringScan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonScanCriticalPromptDuringScan.Name = "radioButtonScanCriticalPromptDuringScan";
            this.radioButtonScanCriticalPromptDuringScan.Size = new System.Drawing.Size(241, 24);
            this.radioButtonScanCriticalPromptDuringScan.TabIndex = 0;
            this.radioButtonScanCriticalPromptDuringScan.TabStop = true;
            this.radioButtonScanCriticalPromptDuringScan.Text = "Prompt for action during scan";
            this.radioButtonScanCriticalPromptDuringScan.UseVisualStyleBackColor = true;
            this.radioButtonScanCriticalPromptDuringScan.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // panelService
            // 
            this.panelService.Controls.Add(this.groupBoxNotifications);
            this.panelService.Location = new System.Drawing.Point(332, 88);
            this.panelService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelService.Name = "panelService";
            this.panelService.Size = new System.Drawing.Size(459, 438);
            this.panelService.TabIndex = 4;
            // 
            // groupBoxNotifications
            // 
            this.groupBoxNotifications.Controls.Add(this.buttonNotificationsSettings);
            this.groupBoxNotifications.Controls.Add(this.checkBoxEnableNotifications);
            this.groupBoxNotifications.Location = new System.Drawing.Point(0, 8);
            this.groupBoxNotifications.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxNotifications.Name = "groupBoxNotifications";
            this.groupBoxNotifications.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxNotifications.Size = new System.Drawing.Size(459, 82);
            this.groupBoxNotifications.TabIndex = 0;
            this.groupBoxNotifications.TabStop = false;
            this.groupBoxNotifications.Text = "Notifications";
            // 
            // buttonNotificationsSettings
            // 
            this.buttonNotificationsSettings.Location = new System.Drawing.Point(292, 18);
            this.buttonNotificationsSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNotificationsSettings.Name = "buttonNotificationsSettings";
            this.buttonNotificationsSettings.Size = new System.Drawing.Size(144, 35);
            this.buttonNotificationsSettings.TabIndex = 1;
            this.buttonNotificationsSettings.Text = "Settings...";
            this.buttonNotificationsSettings.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnableNotifications
            // 
            this.checkBoxEnableNotifications.AutoSize = true;
            this.checkBoxEnableNotifications.Location = new System.Drawing.Point(9, 29);
            this.checkBoxEnableNotifications.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxEnableNotifications.Name = "checkBoxEnableNotifications";
            this.checkBoxEnableNotifications.Size = new System.Drawing.Size(176, 24);
            this.checkBoxEnableNotifications.TabIndex = 0;
            this.checkBoxEnableNotifications.Text = "Enable Notifications";
            this.checkBoxEnableNotifications.UseVisualStyleBackColor = true;
            this.checkBoxEnableNotifications.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // panelUpdate
            // 
            this.panelUpdate.Controls.Add(this.groupBoxUpdateRunMode);
            this.panelUpdate.Controls.Add(this.groupBoxAfterUpdate);
            this.panelUpdate.Location = new System.Drawing.Point(332, 83);
            this.panelUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(459, 438);
            this.panelUpdate.TabIndex = 5;
            // 
            // groupBoxUpdateRunMode
            // 
            this.groupBoxUpdateRunMode.Controls.Add(this.buttonUpdateEveryChange);
            this.groupBoxUpdateRunMode.Controls.Add(this.radioButtonUpdateManual);
            this.groupBoxUpdateRunMode.Controls.Add(this.radioButtonUpdateEvery);
            this.groupBoxUpdateRunMode.Controls.Add(this.radioButtonUpdateAuto);
            this.groupBoxUpdateRunMode.Location = new System.Drawing.Point(0, 11);
            this.groupBoxUpdateRunMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxUpdateRunMode.Name = "groupBoxUpdateRunMode";
            this.groupBoxUpdateRunMode.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxUpdateRunMode.Size = new System.Drawing.Size(459, 120);
            this.groupBoxUpdateRunMode.TabIndex = 0;
            this.groupBoxUpdateRunMode.TabStop = false;
            this.groupBoxUpdateRunMode.Text = "Run mode";
            // 
            // buttonUpdateEveryChange
            // 
            this.buttonUpdateEveryChange.Location = new System.Drawing.Point(338, 46);
            this.buttonUpdateEveryChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUpdateEveryChange.Name = "buttonUpdateEveryChange";
            this.buttonUpdateEveryChange.Size = new System.Drawing.Size(112, 35);
            this.buttonUpdateEveryChange.TabIndex = 3;
            this.buttonUpdateEveryChange.Text = "Change...";
            this.buttonUpdateEveryChange.UseVisualStyleBackColor = true;
            this.buttonUpdateEveryChange.Click += new System.EventHandler(this.buttonUpdateEveryChange_Click);
            // 
            // radioButtonUpdateManual
            // 
            this.radioButtonUpdateManual.AutoSize = true;
            this.radioButtonUpdateManual.Location = new System.Drawing.Point(9, 85);
            this.radioButtonUpdateManual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonUpdateManual.Name = "radioButtonUpdateManual";
            this.radioButtonUpdateManual.Size = new System.Drawing.Size(86, 24);
            this.radioButtonUpdateManual.TabIndex = 2;
            this.radioButtonUpdateManual.TabStop = true;
            this.radioButtonUpdateManual.Text = "Manual";
            this.radioButtonUpdateManual.UseVisualStyleBackColor = true;
            this.radioButtonUpdateManual.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonUpdateEvery
            // 
            this.radioButtonUpdateEvery.AutoSize = true;
            this.radioButtonUpdateEvery.Location = new System.Drawing.Point(9, 55);
            this.radioButtonUpdateEvery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonUpdateEvery.Name = "radioButtonUpdateEvery";
            this.radioButtonUpdateEvery.Size = new System.Drawing.Size(73, 24);
            this.radioButtonUpdateEvery.TabIndex = 1;
            this.radioButtonUpdateEvery.TabStop = true;
            this.radioButtonUpdateEvery.Text = "Every";
            this.radioButtonUpdateEvery.UseVisualStyleBackColor = true;
            this.radioButtonUpdateEvery.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonUpdateAuto
            // 
            this.radioButtonUpdateAuto.AutoSize = true;
            this.radioButtonUpdateAuto.Location = new System.Drawing.Point(9, 28);
            this.radioButtonUpdateAuto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonUpdateAuto.Name = "radioButtonUpdateAuto";
            this.radioButtonUpdateAuto.Size = new System.Drawing.Size(68, 24);
            this.radioButtonUpdateAuto.TabIndex = 0;
            this.radioButtonUpdateAuto.TabStop = true;
            this.radioButtonUpdateAuto.Text = "Auto";
            this.radioButtonUpdateAuto.UseVisualStyleBackColor = true;
            this.radioButtonUpdateAuto.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBoxAfterUpdate
            // 
            this.groupBoxAfterUpdate.Controls.Add(this.checkBoxRescanQuarantine);
            this.groupBoxAfterUpdate.Location = new System.Drawing.Point(0, 145);
            this.groupBoxAfterUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxAfterUpdate.Name = "groupBoxAfterUpdate";
            this.groupBoxAfterUpdate.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxAfterUpdate.Size = new System.Drawing.Size(459, 77);
            this.groupBoxAfterUpdate.TabIndex = 3;
            this.groupBoxAfterUpdate.TabStop = false;
            this.groupBoxAfterUpdate.Text = "After update";
            // 
            // checkBoxRescanQuarantine
            // 
            this.checkBoxRescanQuarantine.AutoSize = true;
            this.checkBoxRescanQuarantine.Location = new System.Drawing.Point(9, 29);
            this.checkBoxRescanQuarantine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxRescanQuarantine.Name = "checkBoxRescanQuarantine";
            this.checkBoxRescanQuarantine.Size = new System.Drawing.Size(173, 24);
            this.checkBoxRescanQuarantine.TabIndex = 0;
            this.checkBoxRescanQuarantine.Text = "Rescan Quarantine";
            this.checkBoxRescanQuarantine.UseVisualStyleBackColor = true;
            this.checkBoxRescanQuarantine.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // panelDataFiles
            // 
            this.panelDataFiles.Controls.Add(this.groupBoxReports);
            this.panelDataFiles.Controls.Add(this.groupBoxQuarantine);
            this.panelDataFiles.Location = new System.Drawing.Point(332, 88);
            this.panelDataFiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDataFiles.Name = "panelDataFiles";
            this.panelDataFiles.Size = new System.Drawing.Size(459, 438);
            this.panelDataFiles.TabIndex = 6;
            // 
            // groupBoxReports
            // 
            this.groupBoxReports.Controls.Add(this.labelDeleteReportsDays);
            this.groupBoxReports.Controls.Add(this.numericUpDownDeleteReportsDays);
            this.groupBoxReports.Controls.Add(this.checkBoxDeleteReports);
            this.groupBoxReports.Controls.Add(this.checkBoxKeepOnlyRecent);
            this.groupBoxReports.Controls.Add(this.checkBoxLogNonCritical);
            this.groupBoxReports.Location = new System.Drawing.Point(0, 8);
            this.groupBoxReports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxReports.Name = "groupBoxReports";
            this.groupBoxReports.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxReports.Size = new System.Drawing.Size(459, 128);
            this.groupBoxReports.TabIndex = 0;
            this.groupBoxReports.TabStop = false;
            this.groupBoxReports.Text = "Reports";
            // 
            // labelDeleteReportsDays
            // 
            this.labelDeleteReportsDays.AutoSize = true;
            this.labelDeleteReportsDays.Location = new System.Drawing.Point(392, 98);
            this.labelDeleteReportsDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeleteReportsDays.Name = "labelDeleteReportsDays";
            this.labelDeleteReportsDays.Size = new System.Drawing.Size(42, 20);
            this.labelDeleteReportsDays.TabIndex = 4;
            this.labelDeleteReportsDays.Text = "days";
            // 
            // numericUpDownDeleteReportsDays
            // 
            this.numericUpDownDeleteReportsDays.Location = new System.Drawing.Point(315, 94);
            this.numericUpDownDeleteReportsDays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownDeleteReportsDays.Name = "numericUpDownDeleteReportsDays";
            this.numericUpDownDeleteReportsDays.Size = new System.Drawing.Size(64, 26);
            this.numericUpDownDeleteReportsDays.TabIndex = 3;
            this.numericUpDownDeleteReportsDays.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownDeleteReportsDays.ValueChanged += new System.EventHandler(this.numericUpDownDeleteReportsDays_ValueChanged);
            // 
            // checkBoxDeleteReports
            // 
            this.checkBoxDeleteReports.AutoSize = true;
            this.checkBoxDeleteReports.Location = new System.Drawing.Point(9, 97);
            this.checkBoxDeleteReports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxDeleteReports.Name = "checkBoxDeleteReports";
            this.checkBoxDeleteReports.Size = new System.Drawing.Size(173, 24);
            this.checkBoxDeleteReports.TabIndex = 2;
            this.checkBoxDeleteReports.Text = "Delete reports after";
            this.checkBoxDeleteReports.UseVisualStyleBackColor = true;
            this.checkBoxDeleteReports.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxKeepOnlyRecent
            // 
            this.checkBoxKeepOnlyRecent.AutoSize = true;
            this.checkBoxKeepOnlyRecent.Location = new System.Drawing.Point(9, 63);
            this.checkBoxKeepOnlyRecent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxKeepOnlyRecent.Name = "checkBoxKeepOnlyRecent";
            this.checkBoxKeepOnlyRecent.Size = new System.Drawing.Size(204, 24);
            this.checkBoxKeepOnlyRecent.TabIndex = 1;
            this.checkBoxKeepOnlyRecent.Text = "Keep only recent events";
            this.checkBoxKeepOnlyRecent.UseVisualStyleBackColor = true;
            this.checkBoxKeepOnlyRecent.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxLogNonCritical
            // 
            this.checkBoxLogNonCritical.AutoSize = true;
            this.checkBoxLogNonCritical.Location = new System.Drawing.Point(9, 29);
            this.checkBoxLogNonCritical.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxLogNonCritical.Name = "checkBoxLogNonCritical";
            this.checkBoxLogNonCritical.Size = new System.Drawing.Size(193, 24);
            this.checkBoxLogNonCritical.TabIndex = 0;
            this.checkBoxLogNonCritical.Text = "Log non-critical events";
            this.checkBoxLogNonCritical.UseVisualStyleBackColor = true;
            this.checkBoxLogNonCritical.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // groupBoxQuarantine
            // 
            this.groupBoxQuarantine.Controls.Add(this.labelDeleteFromQuarantineDays);
            this.groupBoxQuarantine.Controls.Add(this.numericUpDownDeleteFromQuarantineDays);
            this.groupBoxQuarantine.Controls.Add(this.checkBoxDeleteFromQuarantine);
            this.groupBoxQuarantine.Location = new System.Drawing.Point(0, 151);
            this.groupBoxQuarantine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxQuarantine.Name = "groupBoxQuarantine";
            this.groupBoxQuarantine.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxQuarantine.Size = new System.Drawing.Size(459, 68);
            this.groupBoxQuarantine.TabIndex = 5;
            this.groupBoxQuarantine.TabStop = false;
            this.groupBoxQuarantine.Text = "Quarantine";
            // 
            // labelDeleteFromQuarantineDays
            // 
            this.labelDeleteFromQuarantineDays.AutoSize = true;
            this.labelDeleteFromQuarantineDays.Location = new System.Drawing.Point(392, 29);
            this.labelDeleteFromQuarantineDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeleteFromQuarantineDays.Name = "labelDeleteFromQuarantineDays";
            this.labelDeleteFromQuarantineDays.Size = new System.Drawing.Size(42, 20);
            this.labelDeleteFromQuarantineDays.TabIndex = 4;
            this.labelDeleteFromQuarantineDays.Text = "days";
            // 
            // numericUpDownDeleteFromQuarantineDays
            // 
            this.numericUpDownDeleteFromQuarantineDays.Location = new System.Drawing.Point(315, 25);
            this.numericUpDownDeleteFromQuarantineDays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownDeleteFromQuarantineDays.Name = "numericUpDownDeleteFromQuarantineDays";
            this.numericUpDownDeleteFromQuarantineDays.Size = new System.Drawing.Size(64, 26);
            this.numericUpDownDeleteFromQuarantineDays.TabIndex = 3;
            this.numericUpDownDeleteFromQuarantineDays.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownDeleteFromQuarantineDays.ValueChanged += new System.EventHandler(this.numericUpDownDeleteFromQuarantineDays_ValueChanged);
            // 
            // checkBoxDeleteFromQuarantine
            // 
            this.checkBoxDeleteFromQuarantine.AutoSize = true;
            this.checkBoxDeleteFromQuarantine.Location = new System.Drawing.Point(9, 28);
            this.checkBoxDeleteFromQuarantine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxDeleteFromQuarantine.Name = "checkBoxDeleteFromQuarantine";
            this.checkBoxDeleteFromQuarantine.Size = new System.Drawing.Size(277, 24);
            this.checkBoxDeleteFromQuarantine.TabIndex = 2;
            this.checkBoxDeleteFromQuarantine.Text = "Delete items from quarantine after";
            this.checkBoxDeleteFromQuarantine.UseVisualStyleBackColor = true;
            this.checkBoxDeleteFromQuarantine.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // buttonSettingsOK
            // 
            this.buttonSettingsOK.Location = new System.Drawing.Point(332, 557);
            this.buttonSettingsOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSettingsOK.Name = "buttonSettingsOK";
            this.buttonSettingsOK.Size = new System.Drawing.Size(142, 35);
            this.buttonSettingsOK.TabIndex = 7;
            this.buttonSettingsOK.Text = "Ok";
            this.buttonSettingsOK.UseVisualStyleBackColor = true;
            this.buttonSettingsOK.Click += new System.EventHandler(this.buttonSettingsOK_Click);
            // 
            // buttonSettingsClose
            // 
            this.buttonSettingsClose.Location = new System.Drawing.Point(490, 557);
            this.buttonSettingsClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSettingsClose.Name = "buttonSettingsClose";
            this.buttonSettingsClose.Size = new System.Drawing.Size(142, 35);
            this.buttonSettingsClose.TabIndex = 8;
            this.buttonSettingsClose.Text = "Close";
            this.buttonSettingsClose.UseVisualStyleBackColor = true;
            this.buttonSettingsClose.Click += new System.EventHandler(this.buttonSettingsClose_Click);
            // 
            // buttonSettingsApply
            // 
            this.buttonSettingsApply.Location = new System.Drawing.Point(648, 557);
            this.buttonSettingsApply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSettingsApply.Name = "buttonSettingsApply";
            this.buttonSettingsApply.Size = new System.Drawing.Size(142, 35);
            this.buttonSettingsApply.TabIndex = 9;
            this.buttonSettingsApply.Text = "Apply";
            this.buttonSettingsApply.UseVisualStyleBackColor = true;
            this.buttonSettingsApply.Click += new System.EventHandler(this.buttonSettingsApply_Click);
            // 
            // ClamWinSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::ClamWinApp.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(808, 618);
            this.Controls.Add(this.buttonSettingsApply);
            this.Controls.Add(this.buttonSettingsClose);
            this.Controls.Add(this.buttonSettingsOK);
            this.Controls.Add(this.panelExCurrentPanel);
            this.Controls.Add(this.panelExSettings);
            this.Controls.Add(this.panelScanMyPC);
            this.Controls.Add(this.panelScan);
            this.Controls.Add(this.panelMailAntivirus);
            this.Controls.Add(this.panelFileAntivirus);
            this.Controls.Add(this.panelProtection);
            this.Controls.Add(this.panelDataFiles);
            this.Controls.Add(this.panelUpdate);
            this.Controls.Add(this.panelService);
            this.Controls.Add(this.panelScanCriticalAreas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ClamWinSettingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.ClamWinSettingsForm_Load);
            this.panelExSettings.ResumeLayout(false);
            this.panelProtection.ResumeLayout(false);
            this.groupBoxProtectionGeneral.ResumeLayout(false);
            this.groupBoxProtectionGeneral.PerformLayout();
            this.groupBoxSettingsManagment.ResumeLayout(false);
            this.panelFileAntivirus.ResumeLayout(false);
            this.groupBoxFAAction.ResumeLayout(false);
            this.groupBoxFAAction.PerformLayout();
            this.groupBoxFileAV.ResumeLayout(false);
            this.groupBoxFileAV.PerformLayout();
            this.panelMailAntivirus.ResumeLayout(false);
            this.groupBoxMAGeneral.ResumeLayout(false);
            this.groupBoxMAGeneral.PerformLayout();
            this.panelScan.ResumeLayout(false);
            this.groupBoxScanSchedule.ResumeLayout(false);
            this.groupBoxScanSchedule.PerformLayout();
            this.groupBoxScanAction.ResumeLayout(false);
            this.groupBoxScanAction.PerformLayout();
            this.groupBoxScanFilter.ResumeLayout(false);
            this.groupBoxScanFilter.PerformLayout();
            this.panelScanMyPC.ResumeLayout(false);
            this.groupBoxScanMyPCFilter.ResumeLayout(false);
            this.groupBoxScanMyPCFilter.PerformLayout();
            this.groupBoxScanMyPCSchedule.ResumeLayout(false);
            this.groupBoxScanMyPCSchedule.PerformLayout();
            this.groupBoxScanMyPC.ResumeLayout(false);
            this.groupBoxScanMyPC.PerformLayout();
            this.panelScanCriticalAreas.ResumeLayout(false);
            this.groupBoxScanCriticalFilter.ResumeLayout(false);
            this.groupBoxScanCriticalFilter.PerformLayout();
            this.groupBoxScanCriticalSchedule.ResumeLayout(false);
            this.groupBoxScanCriticalSchedule.PerformLayout();
            this.groupBoxScanCriticalAction.ResumeLayout(false);
            this.groupBoxScanCriticalAction.PerformLayout();
            this.panelService.ResumeLayout(false);
            this.groupBoxNotifications.ResumeLayout(false);
            this.groupBoxNotifications.PerformLayout();
            this.panelUpdate.ResumeLayout(false);
            this.groupBoxUpdateRunMode.ResumeLayout(false);
            this.groupBoxUpdateRunMode.PerformLayout();
            this.groupBoxAfterUpdate.ResumeLayout(false);
            this.groupBoxAfterUpdate.PerformLayout();
            this.panelDataFiles.ResumeLayout(false);
            this.groupBoxReports.ResumeLayout(false);
            this.groupBoxReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeleteReportsDays)).EndInit();
            this.groupBoxQuarantine.ResumeLayout(false);
            this.groupBoxQuarantine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeleteFromQuarantineDays)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PanelsEx.PanelEx panelExSettings;
        private PanelsEx.PanelEx panelExCurrentPanel;
        private System.Windows.Forms.TreeView treeViewSettings;
        private System.Windows.Forms.Panel panelProtection;
        private System.Windows.Forms.Panel panelFileAntivirus;
        private System.Windows.Forms.Panel panelMailAntivirus;
        private System.Windows.Forms.Panel panelScan;
        private System.Windows.Forms.Panel panelScanMyPC;
        private System.Windows.Forms.Panel panelScanCriticalAreas;
        private System.Windows.Forms.Panel panelService;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.Panel panelDataFiles;
        private System.Windows.Forms.GroupBox groupBoxSettingsManagment;
        private System.Windows.Forms.GroupBox groupBoxProtectionGeneral;
        private System.Windows.Forms.CheckBox checkBoxRunAtStartup;
        private System.Windows.Forms.CheckBox checkBoxEnableProtection;
        private System.Windows.Forms.Button buttonSettingsReset;
        private System.Windows.Forms.Button buttonSettingsSave;
        private System.Windows.Forms.Button buttonSettingsLoad;
        private System.Windows.Forms.GroupBox groupBoxFileAV;
        private System.Windows.Forms.CheckBox checkBoxEnableFA;
        private System.Windows.Forms.GroupBox groupBoxFAAction;
        private System.Windows.Forms.RadioButton radioButtonFAQuarantine;
        private System.Windows.Forms.RadioButton radioButtonFADelete;
        private System.Windows.Forms.RadioButton radioButtonFABlock;
        private System.Windows.Forms.RadioButton radioButtonFAPrompt;
        private System.Windows.Forms.GroupBox groupBoxMAGeneral;
        private System.Windows.Forms.CheckBox checkBoxMAEnable;
        private System.Windows.Forms.GroupBox groupBoxScanAction;
        private System.Windows.Forms.RadioButton radioButtonScanDelete;
        private System.Windows.Forms.RadioButton radioButtonScanPromptAfterScan;
        private System.Windows.Forms.RadioButton radioButtonScanPromptDuringScan;
        private System.Windows.Forms.RadioButton radioButtonScanDoNothing;
        private System.Windows.Forms.GroupBox groupBoxScanFilter;
        private System.Windows.Forms.GroupBox groupBoxScanMyPC;
        private System.Windows.Forms.RadioButton radioButtonScanMyPCDoNothing;
        private System.Windows.Forms.RadioButton radioButtonScanMyPCDelete;
        private System.Windows.Forms.RadioButton radioButtonScanMyPCPromptAfterScan;
        private System.Windows.Forms.RadioButton radioButtonScanMyPCPromptDuringScan;
        private System.Windows.Forms.GroupBox groupBoxScanCriticalAction;
        private System.Windows.Forms.RadioButton radioButtonScanCriticalDoNothing;
        private System.Windows.Forms.RadioButton radioButtonScanCriticalDelete;
        private System.Windows.Forms.RadioButton radioButtonScanCriticalPromptAfterScan;
        private System.Windows.Forms.RadioButton radioButtonScanCriticalPromptDuringScan;
        private System.Windows.Forms.GroupBox groupBoxNotifications;
        private System.Windows.Forms.Button buttonNotificationsSettings;
        private System.Windows.Forms.CheckBox checkBoxEnableNotifications;
        private System.Windows.Forms.GroupBox groupBoxReports;
        private System.Windows.Forms.CheckBox checkBoxDeleteReports;
        private System.Windows.Forms.CheckBox checkBoxKeepOnlyRecent;
        private System.Windows.Forms.CheckBox checkBoxLogNonCritical;
        private System.Windows.Forms.NumericUpDown numericUpDownDeleteReportsDays;
        private System.Windows.Forms.Label labelDeleteReportsDays;
        private System.Windows.Forms.GroupBox groupBoxQuarantine;
        private System.Windows.Forms.Label labelDeleteFromQuarantineDays;
        private System.Windows.Forms.NumericUpDown numericUpDownDeleteFromQuarantineDays;
        private System.Windows.Forms.CheckBox checkBoxDeleteFromQuarantine;
        private System.Windows.Forms.GroupBox groupBoxUpdateRunMode;
        private System.Windows.Forms.Button buttonSettingsOK;
        private System.Windows.Forms.Button buttonSettingsClose;
        private System.Windows.Forms.Button buttonSettingsApply;
        private System.Windows.Forms.RadioButton radioButtonUpdateAuto;
        private System.Windows.Forms.RadioButton radioButtonUpdateManual;
        private System.Windows.Forms.RadioButton radioButtonUpdateEvery;
        private System.Windows.Forms.GroupBox groupBoxAfterUpdate;
        private System.Windows.Forms.CheckBox checkBoxRescanQuarantine;
        private System.Windows.Forms.Button buttonUpdateEveryChange;
        private System.Windows.Forms.GroupBox groupBoxScanCriticalSchedule;
        private System.Windows.Forms.Button buttonScanCriticalScheduleChange;
        private System.Windows.Forms.CheckBox checkBoxScanCriticalSchedule;
        private System.Windows.Forms.GroupBox groupBoxScanMyPCSchedule;
        private System.Windows.Forms.Button buttonScanMyPCScheduleChange;
        private System.Windows.Forms.CheckBox checkBoxScanMyPCSchedule;
        private System.Windows.Forms.GroupBox groupBoxScanSchedule;
        private System.Windows.Forms.Button buttonScanScheduleChange;
        private System.Windows.Forms.CheckBox checkBoxScanSchedule;
        private System.Windows.Forms.Button buttonScanEditFilter;
        private System.Windows.Forms.CheckBox checkBoxScanUseFilter;
        private System.Windows.Forms.GroupBox groupBoxScanCriticalFilter;
        private System.Windows.Forms.CheckBox checkBoxScanCriticalUseFilter;
        private System.Windows.Forms.Button buttonScanCriticalEditFilter;
        private System.Windows.Forms.GroupBox groupBoxScanMyPCFilter;
        private System.Windows.Forms.CheckBox checkBoxScanMyPCUseFilter;
        private System.Windows.Forms.Button buttonScanMyPCEditFilter;
    }
}