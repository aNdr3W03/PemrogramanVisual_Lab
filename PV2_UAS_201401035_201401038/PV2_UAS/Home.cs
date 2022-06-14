/*
 * Created by SharpDevelop.
 * User: Andrew
 * Date: Sab, 11 Jun 2022
 * Time: 10.00.05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PV2_UAS
{
	/// <summary>
	/// Description of Home.
	/// </summary>
	public partial class Home : Form
	{
		public Home()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		FormUsers   users;
		FormExplore explore;
		FormTicket  ticket;
		FormHistory history;
		FormAbout   about;
		
		// Method Event when the window is closed (red cross)
		void HomeFormClosed(object sender, FormClosedEventArgs e)
		{
			// All Form include MainForm (SplashScreen) Close/Exit
			System.Windows.Forms.Application.Exit();
		}
		
		// File >> Exit
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
		
		// File >> Open >> Users
		void UsersToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (users == null || users.IsDisposed)
			{
				users = new FormUsers();
				users.MdiParent = this;
				users.Show();
			}
		}
		
		// File >> Open >> Explore
		void ExploreToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (explore == null || explore.IsDisposed)
			{
				explore = new FormExplore();
				explore.MdiParent = this;
				explore.Show();
			}
		}
		
		// File >> Open >> Ticket
		void TicketToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (ticket == null || ticket.IsDisposed)
			{
				ticket = new FormTicket();
				ticket.MdiParent = this;
				ticket.Show();
			}
		}
		
		// File >> Open >> History
		void HistoryToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (history == null || history.IsDisposed)
			{
				history = new FormHistory();
				history.MdiParent = this;
				history.Show();
			}
		}
		
		// Window >> Cascade
		void CascadeToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.Cascade);
		}
		
		// Window >> Horizontal
		void HorizontalToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileHorizontal);
		}
		
		// Window Vertical
		void VerticalToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileVertical);
		}
		
		// Help >> About
		void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (about == null || about.IsDisposed)
			{
				about = new FormAbout();
				about.MdiParent = this;
				about.StartPosition = FormStartPosition.CenterScreen;
				about.Show();
			}
		}
	}
}
