/*
 * Created by SharpDevelop.
 * User: Jonatan Orozco
 * Date: 06/11/2017
 * Time: 03:19 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace FolderSyncer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		bool syncInitialized;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			fileMonitor.EnableRaisingEvents = false;
			fileMonitor.IncludeSubdirectories = true;
			applicationNotifyIcon.Icon = new Icon(Icon, 40, 40);
			syncInitialized = false;
			syncButton.Enabled = false;
		}
		void MainFormResize(object sender, EventArgs e)
		{
			hideApp();
		}
		void SyncButtonClick(object sender, EventArgs e)
		{
			if (syncInitialized) {
				syncButton.Text = "Sync";
				fileMonitor.EnableRaisingEvents = false;
				syncInitialized = false;
			} else {
				syncButton.Text = "Stop sync";
				fileMonitor.Path = toSeeFolderPathTextBox.Text;
				fileMonitor.EnableRaisingEvents = true;
				syncInitialized = true;
			}
		}
		void ToSeeFolderPathTextBoxTextChanged(object sender, EventArgs e)
		{
			if (toSeeFolderPathTextBox.Text != toSyncFolderPathTextBox.Text) {
				if (Directory.Exists(toSeeFolderPathTextBox.Text) && Directory.Exists(toSyncFolderPathTextBox.Text)) {
					syncButton.Enabled = true;
				} else {
					syncButton.Enabled = false;
				}
			}			
		}
		void ToSyncFolderPathTextBoxTextChanged(object sender, EventArgs e)
		{
			if (toSeeFolderPathTextBox.Text != toSyncFolderPathTextBox.Text) {
				if (Directory.Exists(toSeeFolderPathTextBox.Text) && Directory.Exists(toSyncFolderPathTextBox.Text)) {
					syncButton.Enabled = true;
				} else {
					syncButton.Enabled = false;
				}
			}
		}
		void FindToSeeFolderButtonClick(object sender, EventArgs e)
		{
			if (findFolderDialog.ShowDialog() == DialogResult.OK) {
				toSeeFolderPathTextBox.Text = findFolderDialog.SelectedPath;
			}
		}
		void FindToSyncFolderButtonClick(object sender, EventArgs e)
		{
			if (findFolderDialog.ShowDialog() == DialogResult.OK) {
				toSyncFolderPathTextBox.Text = findFolderDialog.SelectedPath;
			}
		}
		void FileMonitorChanged(object sender, FileSystemEventArgs e)
		{
			string rest_path = e.FullPath.Replace(toSeeFolderPathTextBox.Text, "");
			if (Directory.Exists(e.FullPath)) {
				MessageBox.Show(e.FullPath);
			} else if (File.Exists(e.FullPath)) {
				File.Copy(e.FullPath, toSyncFolderPathTextBox.Text + rest_path, true);
			}			
		}
		void FileMonitorDeleted(object sender, FileSystemEventArgs e)
		{
			string rest_path = e.FullPath.Replace(toSeeFolderPathTextBox.Text, "");
			File.Delete(toSyncFolderPathTextBox.Text + rest_path);
		}
		void OpenToolStripMenuItemClick(object sender, EventArgs e)
		{
			showApp();
		}
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			closeApp();
		}
		void FileMonitorCreated(object sender, FileSystemEventArgs e)
		{
			string rest_path = e.FullPath.Replace(toSeeFolderPathTextBox.Text, "");
			if (Directory.Exists(e.FullPath)) {
				Directory.CreateDirectory(toSyncFolderPathTextBox.Text + rest_path);
			} else if (File.Exists(e.FullPath)) {
				File.Copy(e.FullPath, toSyncFolderPathTextBox.Text + rest_path, true);
			}
		}
		void FileMonitorRenamed(object sender, RenamedEventArgs e)
		{
			string rest_path_old = e.OldFullPath.Replace(toSeeFolderPathTextBox.Text, "");
			string rest_path = e.FullPath.Replace(toSeeFolderPathTextBox.Text, "");
			
			if (Directory.Exists(toSyncFolderPathTextBox.Text + rest_path_old)) {
				Directory.Move(toSyncFolderPathTextBox.Text + rest_path_old, toSyncFolderPathTextBox.Text + rest_path);
			} else if (File.Exists(toSyncFolderPathTextBox.Text + rest_path_old)) {
				File.Move(toSyncFolderPathTextBox.Text + rest_path_old, toSyncFolderPathTextBox.Text + rest_path);
			}
		}
		void ApplicationNotifyIconDoubleClick(object sender, EventArgs e)
		{
			showApp();
		}
		
		void showApp() {
			applicationNotifyIcon.Visible = false;
			WindowState = FormWindowState.Normal;
			ShowInTaskbar = true;
			
		}
		
		void hideApp() {
			if (WindowState == FormWindowState.Minimized) {
				ShowInTaskbar = false;
				applicationNotifyIcon.BalloonTipText = "The program is running in background";
				applicationNotifyIcon.BalloonTipTitle = "FolderSyncer";
				applicationNotifyIcon.Visible = true;
				applicationNotifyIcon.ShowBalloonTip(3000);
			}
		}
		
		void closeApp() {
			fileMonitor.EnableRaisingEvents = false;
			fileMonitor.Dispose();
			Close();
		}
	}
}
