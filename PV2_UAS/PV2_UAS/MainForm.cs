/*
 * Created by SharpDevelop.
 * User: Andrew
 * Date: Sab, 11 Jun 2022
 * Time: 09.43.06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PV2_UAS
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
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
		
		void TimerTick(object sender, EventArgs e)
		{
			if (progressBar.Value == 100)
			{
				timer.Enabled = false;
				Home homepage = new Home();
				homepage.Show();
				this.Hide();
			}
			else progressBar.Value += 2; // Lama LoadingBar
		}
	}
}
