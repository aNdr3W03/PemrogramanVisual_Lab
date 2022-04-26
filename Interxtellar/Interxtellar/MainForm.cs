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
		
		void readData()
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
		
		// DataGridView Users
		void DataGridViewUsersCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
//			user_id.Text      = dataGridViewUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
//			full_name.Text    = dataGridViewUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
//			email.Text        = dataGridViewUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
//			username.Text     = dataGridViewUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
//			password.Text     = dataGridViewUsers.Rows[e.RowIndex].Cells[5].Value.ToString();
		}
		
		// DataGridView Explore
		void DataGridViewExploreCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
//			explore_id.Text   = dataGridViewExplore.Rows[e.RowIndex].Cells[1].Value.ToString();
//			star.Text         = dataGridViewExplore.Rows[e.RowIndex].Cells[2].Value.ToString();
//			object_id.Text    = dataGridViewExplore.Rows[e.RowIndex].Cells[3].Value.ToString();
//			mass.Text         = dataGridViewExplore.Rows[e.RowIndex].Cells[4].Value.ToString();
//			radius.Text       = dataGridViewExplore.Rows[e.RowIndex].Cells[5].Value.ToString();
//			period.Text       = dataGridViewExplore.Rows[e.RowIndex].Cells[6].Value.ToString();
//			distance.Text     = dataGridViewExplore.Rows[e.RowIndex].Cells[7].Value.ToString();
//			travel_time.Text  = dataGridViewExplore.Rows[e.RowIndex].Cells[8].Value.ToString();
//			price.Text        = dataGridViewExplore.Rows[e.RowIndex].Cells[9].Value.ToString();
		}
		
		// DataGridView Ticket Booking
		void DataGridViewTicketCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
//			ticket_id.Text    = dataGridViewTicket.Rows[e.RowIndex].Cells[1].Value.ToString();
//			user_id.Text      = dataGridViewTicket.Rows[e.RowIndex].Cells[2].Value.ToString();
//			from_id.Text      = dataGridViewTicket.Rows[e.RowIndex].Cells[3].Value.ToString();
//			to_id.Text        = dataGridViewTicket.Rows[e.RowIndex].Cells[4].Value.ToString();
//			date.Text         = dataGridViewTicket.Rows[e.RowIndex].Cells[5].Value.ToString();
//			boarding.Text     = dataGridViewTicket.Rows[e.RowIndex].Cells[6].Value.ToString();
//			ticket_class.Text = dataGridViewTicket.Rows[e.RowIndex].Cells[7].Value.ToString();
//			launch_gate.Text  = dataGridViewTicket.Rows[e.RowIndex].Cells[8].Value.ToString();
//			seat.Text         = dataGridViewTicket.Rows[e.RowIndex].Cells[9].Value.ToString();
		}
		
		
		
//		// Users Source Code
//		public void insertDataUsers()
//		{
//			try
//			{
//				co.Open();
//				mycommand.Connection    = co;
//				mycommand.CommandText   = "INSERT INTO users (user_id,full_name,email,username,password) VALUES('" + user_id.Text + "','" + full_name.Text + "','" + email.Text + "','" + username.Text + "','" + password.Text + "')";
//				myadapter.SelectCommand = mycommand;
//				if (mycommand.ExecuteNonQuery() == 1)
//				{
//					MessageBox.Show("Data berhasil dimasukkan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
//					readData();
//				}
//				co.Close();
//			}
//			catch (Exception ex)
//			{
//				MessageBox.Show(ex.ToString());
//			}
//		}
//		
//		void updateDataUsers()
//		{
//			try
//			{
//				co.Open();
//				mycommand.CommandText   = "UPDATE users SET user_id='"+user_id.Text+"', full_name ='"+full_name.Text+"', email='"+email.Text+"', username ='"+username.Text+"', password ='"+password.Text+"' WHERE user_id='"+user_id.Text+"'";
//				myadapter.SelectCommand = mycommand;
//				if (mycommand.ExecuteNonQuery() == 1)
//				{
//					MessageBox.Show("Data berhasil diupdate","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
//					readData();
//				}
//				co.Close();
//			}
//			catch (Exception ex)
//			{
//				MessageBox.Show(ex.ToString());
//			}
//		}
//		
//		void deleteDataUsers()
//		{
//			try
//			{
//				co.Open();
//				mycommand.CommandText   = "DELETE FROM users WHERE user_id ='" + user_id.Text + "'";
//				myadapter.SelectCommand = mycommand;
//				if (mycommand.ExecuteNonQuery() == 1)
//				{
//					MessageBox.Show("Data berhasil dihapus","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
//					readData();
//				}
//				co.Close();
//			}
//			catch (Exception ex)
//			{
//				MessageBox.Show(ex.ToString());
//			}
//		}
//		
//		void BtnTambahUsersClick(object sender, EventArgs e)
//		{
//			insertDataUsers();
//		}
//		
//		void BtnUbahUsersClick(object sender, EventArgs e)
//		{
//			updateDataUsers();
//		}
//		
//		void BtnHapusUsersClick(object sender, EventArgs e)
//		{
//			deleteDataUsers();
//		}
//		
//		
//		
//		// Explore Source Code
//		public void insertDataExplore()
//		{
//			try
//			{
//				co.Open();
//				mycommand.CommandText   = "INSERT INTO explore (explore_id,star,object,mass,radius,period,distance,travel_time,price) VALUES('" + explore_id.Text + "','" + star.Text + "','" + object_id.Text + "','" + mass.Text + "','" + radius.Text + "','" + period.Text + "','" + distance.Text + "','" + travel_time.Text + "','" + price.Text + "')";
//				myadapter.SelectCommand = mycommand;
//				if (mycommand.ExecuteNonQuery() == 1)
//				{
//					MessageBox.Show("Data berhasil dimasukkan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
//					readData();
//				}
//				co.Close();
//			}
//			catch (Exception ex)
//			{
//				MessageBox.Show(ex.ToString());
//			}
//		}
//		
//		void updateDataExplore()
//		{
//			try
//			{
//				co.Open();
//				mycommand.CommandText   = "UPDATE explore SET explore_id='"+explore_id.Text+"', star ='"+star.Text+"', object='"+object_id.Text+"', mass ='"+mass.Text+"', radius ='"+radius.Text+"', period ='"+period.Text+"', distance ='"+distance.Text+"', travel_time ='"+travel_time.Text+"', price ='"+price.Text+"' WHERE explore_id='"+explore_id.Text+"'";
//				myadapter.SelectCommand = mycommand;
//				if (mycommand.ExecuteNonQuery() == 1)
//				{
//					MessageBox.Show("Data berhasil diupdate","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
//					readData();
//				}
//				co.Close();
//			}
//			catch (Exception ex)
//			{
//				MessageBox.Show(ex.ToString());
//			}
//		}
//		
//		void deleteDataExplore()
//		{
//			try
//			{
//				co.Open();
//				mycommand.CommandText   = "DELETE FROM explore WHERE explore_id ='" + explore_id.Text + "'";
//				myadapter.SelectCommand = mycommand;
//				if (mycommand.ExecuteNonQuery() == 1)
//				{
//					MessageBox.Show("Data berhasil dihapus","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
//					readData();
//				}
//				co.Close();
//			}
//			catch (Exception ex)
//			{
//				MessageBox.Show(ex.ToString());
//			}
//		}
//		
//		void BtnTambahExploreClick(object sender, EventArgs e)
//		{
//			insertDataExplore();
//		}
//		
//		void BtnUbahExploreClick(object sender, EventArgs e)
//		{
//			updateDataExplore();
//		}
//		
//		void BtnHapusExploreClick(object sender, EventArgs e)
//		{
//			deleteDataExplore();
//		}
		
		
		
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
		
		
		
//		// Refresh GridDataView
//		public void RefreshGrid()
//		{
//			readData();
//		}
		
		void BtnRefreshClick(object sender, EventArgs e)
		{
			readData();
		}
	}
}
