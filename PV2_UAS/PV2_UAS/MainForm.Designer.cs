/*
 * Created by SharpDevelop.
 * User: HP
 * Date: Sab, 11 Jun 2022
 * Time: 09.43.06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PV2_UAS
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Tick += new System.EventHandler(this.TimerTick);
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(70, 550);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(875, 30);
			this.progressBar.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1024, 640);
			this.Controls.Add(this.progressBar);
			this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PV2_UAS";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Timer timer;
	}
}
