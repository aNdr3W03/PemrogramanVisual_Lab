/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 5 Des 2021
 * Time: 07.47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace Interxtellar
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		MySqlConnection co         = new MySqlConnection("Server = localhost; Database = interstellar; Uid = root");
		MySqlCommand mycommand     = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
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
			readData();
			dataGridViewColumnWidth();
		}
		
		public bool dbOpen()
		{
			try
			{
				co.Open();
			}
			catch
			{
				MessageBox.Show("Tidak terhubung ke database","Cek Koneksi",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return false;
			}
			return true;
		}
		
		void BtnKoneksiClick(object sender, EventArgs e)
		{
			if (dbOpen())
			{
				MessageBox.Show("Terhubung ke database","Cek Koneksi",MessageBoxButtons.OK,MessageBoxIcon.Information);
				co.Close();
			}
		}
		
		public void readData()
		{
			// Read Tabel Users
			try
			{
				mycommand.Connection    = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText   = "SELECT * FROM users";
				DataSet users = new DataSet();
				if (myadapter.Fill(users,"dftpesan") > 0)
				{
					dataGridViewUsers.DataSource = users;
					dataGridViewUsers.DataMember = "dftpesan";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
			// Read Tabel Explore
			try
			{
				mycommand.Connection    = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText   = "SELECT * FROM explore";
				DataSet planet = new DataSet();
				if (myadapter.Fill(planet,"dftpesan") > 0)
				{
					dataGridViewExplore.DataSource = planet;
					dataGridViewExplore.DataMember = "dftpesan";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
			// Read Tabel Ticket Booking
			try
			{
				mycommand.Connection    = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText   = "SELECT * FROM ticket_booking";
				DataSet tiket = new DataSet();
				if (myadapter.Fill(tiket,"dftpesan") > 0)
				{
					dataGridViewTicket.DataSource = tiket;
					dataGridViewTicket.DataMember = "dftpesan";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		
		
		FormUsers   form_users   = new FormUsers();
		FormExplore form_explore = new FormExplore();
		FormTicket  form_ticket  = new FormTicket();
		
		void BtnUsersClick(object sender, EventArgs e)
		{
			if (form_users == null || form_users.IsDisposed)
				form_users = new FormUsers();
			
			form_users.Show();
		}
		
		void BtnExploreClick(object sender, EventArgs e)
		{
			if (form_explore == null || form_explore.IsDisposed)
				form_explore = new FormExplore();
			
			form_explore.Show();
		}
		
		void BtnTiketClick(object sender, EventArgs e)
		{
			if (form_ticket == null || form_ticket.IsDisposed)
				form_ticket = new FormTicket();
			
			form_ticket.Show();
		}
		
		
		
		void BtnRefreshClick(object sender, EventArgs e)
		{
			readData();
		}
		
		
		
		// DataGridView Column Width Config
		void dataGridViewColumnWidth()
		{
			dataGridViewUsers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		    dataGridViewUsers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		    dataGridViewUsers.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			dataGridViewUsers.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			dataGridViewUsers.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewUsers.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
          	dataGridViewUsers.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
          	
			dataGridViewExplore.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		    dataGridViewExplore.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		    dataGridViewExplore.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			dataGridViewExplore.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			dataGridViewExplore.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewExplore.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
          	dataGridViewExplore.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
          	dataGridViewExplore.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
          	dataGridViewExplore.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
          	dataGridViewExplore.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
          	dataGridViewExplore.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
          	
			dataGridViewTicket.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		    dataGridViewTicket.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		    dataGridViewTicket.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			dataGridViewTicket.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			dataGridViewTicket.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			dataGridViewTicket.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
          	dataGridViewTicket.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
          	dataGridViewTicket.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
          	dataGridViewTicket.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
          	dataGridViewTicket.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
          	dataGridViewTicket.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		}
	}
}
