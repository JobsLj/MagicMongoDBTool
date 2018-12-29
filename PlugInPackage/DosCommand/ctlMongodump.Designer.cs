﻿using System.ComponentModel;
using System.Windows.Forms;
using ResourceLib.UI;

namespace PlugInPackage.DosCommand
{
    partial class CtlMongodump
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctllogLvT = new PlugInPackage.DosCommand.CtllogLv();
            this.ctlFilePickerOutput = new ResourceLib.UI.CtlFilePicker();
            this.lblHostAddr = new System.Windows.Forms.Label();
            this.txtHostAddr = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.lblDBName = new System.Windows.Forms.Label();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.lblCollectionName = new System.Windows.Forms.Label();
            this.txtCollectionName = new System.Windows.Forms.TextBox();
            this.chkGZip = new System.Windows.Forms.CheckBox();
            this.chkArchive = new System.Windows.Forms.CheckBox();
            this.txtArchive = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.SuspendLayout();
            // 
            // ctllogLvT
            // 
            this.ctllogLvT.BackColor = System.Drawing.Color.Transparent;
            this.ctllogLvT.Location = new System.Drawing.Point(43, 161);
            this.ctllogLvT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctllogLvT.Name = "ctllogLvT";
            this.ctllogLvT.Size = new System.Drawing.Size(237, 23);
            this.ctllogLvT.TabIndex = 0;
            // 
            // ctlFilePickerOutput
            // 
            this.ctlFilePickerOutput.AutoSize = true;
            this.ctlFilePickerOutput.BackColor = System.Drawing.Color.Transparent;
            this.ctlFilePickerOutput.Browse = "Browse...";
            this.ctlFilePickerOutput.Clear = "Clear";
            this.ctlFilePickerOutput.FileFilter = "";
            this.ctlFilePickerOutput.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctlFilePickerOutput.InitFileName = "";
            this.ctlFilePickerOutput.Location = new System.Drawing.Point(29, 116);
            this.ctlFilePickerOutput.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.ctlFilePickerOutput.Name = "ctlFilePickerOutput";
            this.ctlFilePickerOutput.PickerType = ResourceLib.UI.CtlFilePicker.DialogType.Directory;
            this.ctlFilePickerOutput.SelectedPathOrFileName = "";
            this.ctlFilePickerOutput.Size = new System.Drawing.Size(862, 35);
            this.ctlFilePickerOutput.TabIndex = 1;
            this.ctlFilePickerOutput.Title = "BackUpPath";
            // 
            // lblHostAddr
            // 
            this.lblHostAddr.AutoSize = true;
            this.lblHostAddr.Location = new System.Drawing.Point(43, 37);
            this.lblHostAddr.Name = "lblHostAddr";
            this.lblHostAddr.Size = new System.Drawing.Size(35, 17);
            this.lblHostAddr.TabIndex = 2;
            this.lblHostAddr.Text = "Host";
            // 
            // txtHostAddr
            // 
            this.txtHostAddr.Location = new System.Drawing.Point(153, 33);
            this.txtHostAddr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHostAddr.Name = "txtHostAddr";
            this.txtHostAddr.Size = new System.Drawing.Size(187, 23);
            this.txtHostAddr.TabIndex = 3;
            this.txtHostAddr.TextChanged += new System.EventHandler(this.txtHostAddr_TextChanged);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(355, 37);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(32, 17);
            this.lblPort.TabIndex = 4;
            this.lblPort.Text = "Port";
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(457, 34);
            this.numPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPort.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(78, 23);
            this.numPort.TabIndex = 9;
            this.numPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPort.Value = new decimal(new int[] {
            27017,
            0,
            0,
            0});
            this.numPort.ValueChanged += new System.EventHandler(this.numPort_ValueChanged);
            // 
            // lblDBName
            // 
            this.lblDBName.AutoSize = true;
            this.lblDBName.Location = new System.Drawing.Point(43, 79);
            this.lblDBName.Name = "lblDBName";
            this.lblDBName.Size = new System.Drawing.Size(98, 17);
            this.lblDBName.TabIndex = 10;
            this.lblDBName.Text = "DatabaseName";
            // 
            // txtDBName
            // 
            this.txtDBName.Location = new System.Drawing.Point(153, 71);
            this.txtDBName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(187, 23);
            this.txtDBName.TabIndex = 11;
            this.txtDBName.TextChanged += new System.EventHandler(this.txtDBName_TextChanged);
            // 
            // lblCollectionName
            // 
            this.lblCollectionName.AutoSize = true;
            this.lblCollectionName.Location = new System.Drawing.Point(355, 75);
            this.lblCollectionName.Name = "lblCollectionName";
            this.lblCollectionName.Size = new System.Drawing.Size(100, 17);
            this.lblCollectionName.TabIndex = 12;
            this.lblCollectionName.Text = "CollectionName";
            // 
            // txtCollectionName
            // 
            this.txtCollectionName.Location = new System.Drawing.Point(457, 71);
            this.txtCollectionName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCollectionName.Name = "txtCollectionName";
            this.txtCollectionName.Size = new System.Drawing.Size(201, 23);
            this.txtCollectionName.TabIndex = 13;
            this.txtCollectionName.TextChanged += new System.EventHandler(this.txtCollectionName_TextChanged);
            // 
            // chkGZip
            // 
            this.chkGZip.AutoSize = true;
            this.chkGZip.Location = new System.Drawing.Point(357, 161);
            this.chkGZip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkGZip.Name = "chkGZip";
            this.chkGZip.Size = new System.Drawing.Size(54, 21);
            this.chkGZip.TabIndex = 14;
            this.chkGZip.Text = "GZIP";
            this.chkGZip.UseVisualStyleBackColor = true;
            this.chkGZip.CheckedChanged += new System.EventHandler(this.chkGZip_CheckedChanged);
            // 
            // chkArchive
            // 
            this.chkArchive.AutoSize = true;
            this.chkArchive.Location = new System.Drawing.Point(444, 161);
            this.chkArchive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkArchive.Name = "chkArchive";
            this.chkArchive.Size = new System.Drawing.Size(69, 21);
            this.chkArchive.TabIndex = 15;
            this.chkArchive.Text = "Archive";
            this.chkArchive.UseVisualStyleBackColor = true;
            this.chkArchive.CheckedChanged += new System.EventHandler(this.chkArchive_CheckedChanged);
            // 
            // txtArchive
            // 
            this.txtArchive.Location = new System.Drawing.Point(551, 161);
            this.txtArchive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtArchive.Name = "txtArchive";
            this.txtArchive.Size = new System.Drawing.Size(116, 23);
            this.txtArchive.TabIndex = 16;
            this.txtArchive.TextChanged += new System.EventHandler(this.txtArchive_TextChanged);
            // 
            // CtlMongodump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtArchive);
            this.Controls.Add(this.chkArchive);
            this.Controls.Add(this.chkGZip);
            this.Controls.Add(this.txtCollectionName);
            this.Controls.Add(this.lblCollectionName);
            this.Controls.Add(this.txtDBName);
            this.Controls.Add(this.lblDBName);
            this.Controls.Add(this.numPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.txtHostAddr);
            this.Controls.Add(this.lblHostAddr);
            this.Controls.Add(this.ctlFilePickerOutput);
            this.Controls.Add(this.ctllogLvT);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CtlMongodump";
            this.Size = new System.Drawing.Size(933, 262);
            this.Load += new System.EventHandler(this.ctlMongodump_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CtllogLv ctllogLvT;
        private CtlFilePicker ctlFilePickerOutput;
        private Label lblHostAddr;
        private TextBox txtHostAddr;
        private Label lblPort;
        private NumericUpDown numPort;
        private Label lblDBName;
        private TextBox txtDBName;
        private Label lblCollectionName;
        private TextBox txtCollectionName;
        private CheckBox chkGZip;
        private CheckBox chkArchive;
        private TextBox txtArchive;
    }
}
