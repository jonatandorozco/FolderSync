/*
 * Created by SharpDevelop.
 * User: Jonatan Orozco
 * Date: 06/11/2017
 * Time: 03:19 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FolderSyncer
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.NotifyIcon applicationNotifyIcon;
		private System.IO.FileSystemWatcher fileMonitor;
		private System.Windows.Forms.Button syncButton;
		private System.Windows.Forms.Button findToSyncFolderButton;
		private System.Windows.Forms.TextBox toSyncFolderPathTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button findToSeeFolderButton;
		private System.Windows.Forms.TextBox toSeeFolderPathTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FolderBrowserDialog findFolderDialog;
		private System.Windows.Forms.ContextMenuStrip notifyIconContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.applicationNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.notifyIconContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fileMonitor = new System.IO.FileSystemWatcher();
			this.label1 = new System.Windows.Forms.Label();
			this.toSeeFolderPathTextBox = new System.Windows.Forms.TextBox();
			this.findToSeeFolderButton = new System.Windows.Forms.Button();
			this.findToSyncFolderButton = new System.Windows.Forms.Button();
			this.toSyncFolderPathTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.syncButton = new System.Windows.Forms.Button();
			this.findFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.notifyIconContextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fileMonitor)).BeginInit();
			this.SuspendLayout();
			// 
			// applicationNotifyIcon
			// 
			this.applicationNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.applicationNotifyIcon.ContextMenuStrip = this.notifyIconContextMenuStrip;
			this.applicationNotifyIcon.Text = "FolderSyncer";
			this.applicationNotifyIcon.DoubleClick += new System.EventHandler(this.ApplicationNotifyIconDoubleClick);
			// 
			// notifyIconContextMenuStrip
			// 
			this.notifyIconContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.openToolStripMenuItem,
			this.exitToolStripMenuItem});
			this.notifyIconContextMenuStrip.Name = "notifyIconContextMenuStrip";
			this.notifyIconContextMenuStrip.Size = new System.Drawing.Size(104, 48);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// fileMonitor
			// 
			this.fileMonitor.EnableRaisingEvents = true;
			this.fileMonitor.SynchronizingObject = this;
			this.fileMonitor.Changed += new System.IO.FileSystemEventHandler(this.FileMonitorChanged);
			this.fileMonitor.Created += new System.IO.FileSystemEventHandler(this.FileMonitorCreated);
			this.fileMonitor.Deleted += new System.IO.FileSystemEventHandler(this.FileMonitorDeleted);
			this.fileMonitor.Renamed += new System.IO.RenamedEventHandler(this.FileMonitorRenamed);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Folder to see: ";
			// 
			// toSeeFolderPathTextBox
			// 
			this.toSeeFolderPathTextBox.BackColor = System.Drawing.Color.White;
			this.toSeeFolderPathTextBox.Location = new System.Drawing.Point(97, 15);
			this.toSeeFolderPathTextBox.Name = "toSeeFolderPathTextBox";
			this.toSeeFolderPathTextBox.ReadOnly = true;
			this.toSeeFolderPathTextBox.Size = new System.Drawing.Size(131, 20);
			this.toSeeFolderPathTextBox.TabIndex = 1;
			this.toSeeFolderPathTextBox.TextChanged += new System.EventHandler(this.ToSeeFolderPathTextBoxTextChanged);
			// 
			// findToSeeFolderButton
			// 
			this.findToSeeFolderButton.Location = new System.Drawing.Point(234, 12);
			this.findToSeeFolderButton.Name = "findToSeeFolderButton";
			this.findToSeeFolderButton.Size = new System.Drawing.Size(38, 23);
			this.findToSeeFolderButton.TabIndex = 2;
			this.findToSeeFolderButton.Text = "...";
			this.findToSeeFolderButton.UseVisualStyleBackColor = true;
			this.findToSeeFolderButton.Click += new System.EventHandler(this.FindToSeeFolderButtonClick);
			// 
			// findToSyncFolderButton
			// 
			this.findToSyncFolderButton.Location = new System.Drawing.Point(234, 38);
			this.findToSyncFolderButton.Name = "findToSyncFolderButton";
			this.findToSyncFolderButton.Size = new System.Drawing.Size(38, 23);
			this.findToSyncFolderButton.TabIndex = 5;
			this.findToSyncFolderButton.Text = "...";
			this.findToSyncFolderButton.UseVisualStyleBackColor = true;
			this.findToSyncFolderButton.Click += new System.EventHandler(this.FindToSyncFolderButtonClick);
			// 
			// toSyncFolderPathTextBox
			// 
			this.toSyncFolderPathTextBox.BackColor = System.Drawing.Color.White;
			this.toSyncFolderPathTextBox.Location = new System.Drawing.Point(97, 41);
			this.toSyncFolderPathTextBox.Name = "toSyncFolderPathTextBox";
			this.toSyncFolderPathTextBox.ReadOnly = true;
			this.toSyncFolderPathTextBox.Size = new System.Drawing.Size(131, 20);
			this.toSyncFolderPathTextBox.TabIndex = 4;
			this.toSyncFolderPathTextBox.TextChanged += new System.EventHandler(this.ToSyncFolderPathTextBoxTextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Folder to sync: ";
			// 
			// syncButton
			// 
			this.syncButton.Location = new System.Drawing.Point(12, 67);
			this.syncButton.Name = "syncButton";
			this.syncButton.Size = new System.Drawing.Size(260, 47);
			this.syncButton.TabIndex = 6;
			this.syncButton.Text = "Sync";
			this.syncButton.UseVisualStyleBackColor = true;
			this.syncButton.Click += new System.EventHandler(this.SyncButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 125);
			this.Controls.Add(this.syncButton);
			this.Controls.Add(this.findToSyncFolderButton);
			this.Controls.Add(this.toSyncFolderPathTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.findToSeeFolderButton);
			this.Controls.Add(this.toSeeFolderPathTextBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "FolderSyncer";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.Resize += new System.EventHandler(this.MainFormResize);
			this.notifyIconContextMenuStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fileMonitor)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
