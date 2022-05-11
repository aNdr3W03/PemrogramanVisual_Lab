/*
 * Created by SharpDevelop.
 * User: ariel
 * Date: 17/12/2021
 * Time: 10:38
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
	/// Description of FormUsers.
	/// </summary>
	public partial class FormUsers : Form
	{
		MySqlConnection co         = new MySqlConnection("Server = localhost; Database = interstellar; Uid = root");
		MySqlCommand mycommand     = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		public FormUsers()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FormUsersLoad(object sender, EventArgs e)
		{
			readDataUsers();
			dataGridViewColumnWidth();
		}
		
		void readDataUsers()
		{
			// Read Tabel Users
			try
			{
				mycommand.Connection    = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText   = "SELECT * FROM users";
				DataSet ds = new DataSet();
				if (myadapter.Fill(ds,"dftpesan") > 0)
				{
					dataGridViewUsers.DataSource = ds;
					dataGridViewUsers.DataMember = "dftpesan";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		void DataGridViewUsersCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			user_id.Text      = dataGridViewUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
			full_name.Text    = dataGridViewUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
			email.Text        = dataGridViewUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
			username.Text     = dataGridViewUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
			password.Text     = dataGridViewUsers.Rows[e.RowIndex].Cells[5].Value.ToString();
		}
		
		
		
		// CRUD Function Users
		void insertDataUsers()
		{
			try
			{
				co.Open();
				mycommand.CommandText   = "INSERT INTO users (user_id,full_name,email,username,password) VALUES('" + user_id.Text + "','" + full_name.Text + "','" + email.Text + "','" + username.Text + "','" + password.Text + "')";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery() == 1)
				{
					MessageBox.Show("Data berhasil dimasukkan","Tambah Data",MessageBoxButtons.OK,MessageBoxIcon.Information);
					readDataUsers();
				}
				co.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		void updateDataUsers()
		{
			try
			{
				co.Open();
				mycommand.CommandText   = "UPDATE users SET user_id='" + user_id.Text + "', full_name ='" + full_name.Text + "', email='" + email.Text + "', username ='" + username.Text + "', password ='" + password.Text + "' WHERE user_id='" + user_id.Text + "'";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery() == 1)
				{
					MessageBox.Show("Data berhasil diupdate","Ubah Data",MessageBoxButtons.OK,MessageBoxIcon.Information);
					readDataUsers();
				}
				co.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		void deleteDataUsers()
		{
			if (MessageBox.Show(full_name.Text + ", yakin ingin dihapus?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				try
				{
					co.Open();
					mycommand.CommandText   = "DELETE FROM users WHERE user_id ='" + user_id.Text + "'";
					myadapter.SelectCommand = mycommand;
					if (mycommand.ExecuteNonQuery() == 1)
					{
						MessageBox.Show("Data berhasil dihapus","Hapus Data",MessageBoxButtons.OK,MessageBoxIcon.Information);
						readDataUsers();
					}
					co.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}
		
		
		
		// CRUD Button Users
		void BtnTambahUsersClick(object sender, EventArgs e)
		{
			insertDataUsers();
		}
		
		void BtnUbahUsersClick(object sender, EventArgs e)
		{
			updateDataUsers();
		}
		
		void BtnHapusUsersClick(object sender, EventArgs e)
		{
			deleteDataUsers();
		}
		
		void BtnRefreshUsersClick(object sender, EventArgs e)
		{
			// Label User ID Random
			Random r = new Random();
			int rand = r.Next(1000000000, 2147483647);
			
			user_id.Text      = rand.ToString();
			full_name.Text    = "";
			email.Text        = "";
			username.Text     = "";
			password.Text     = "";
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
		}
	}
}
