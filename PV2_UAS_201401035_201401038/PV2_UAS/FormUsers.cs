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
using System.Security.Cryptography;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace PV2_UAS
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
			password.Text     = Decrypt(dataGridViewUsers.Rows[e.RowIndex].Cells[5].Value.ToString());
		}
		
		
		
		// MD5 Encryption for User Password
//		public static string GetMD5Hash(string str)
//        {
//	        MD5 md5 = MD5.Create();
//	        byte[] bytes = Encoding.Default.GetBytes(str);
//	        byte[] result = md5.ComputeHash(bytes);
//	        
//	        StringBuilder sb = new StringBuilder();
//	        
//	        for (int i=0; i<result.Length; i++)
//	        {
//	        	sb.Append(result[i].ToString("x2"));
//	        }
//	        
//	        return sb.ToString();
//		}
		
		public static string Encrypt(string decrypted)
        {
	        string hash = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
	        byte[] data = UTF8Encoding.UTF8.GetBytes(decrypted);
	        
	        MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
	        TripleDESCryptoServiceProvider tripDES = new TripleDESCryptoServiceProvider();
	        
	        tripDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
	        tripDES.Mode = CipherMode.ECB;
	        
	        ICryptoTransform transform = tripDES.CreateEncryptor();
	        byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
	        
	        return Convert.ToBase64String(result);
		}
		
		public static string Decrypt(string encrypted)
        {
	        string hash = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
	        byte[] data = Convert.FromBase64String(encrypted);
	        
	        MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
	        TripleDESCryptoServiceProvider tripDES = new TripleDESCryptoServiceProvider();
	        
	        tripDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
	        tripDES.Mode = CipherMode.ECB;
	        
	        ICryptoTransform transform = tripDES.CreateDecryptor();
	        byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
	        
	        return UTF8Encoding.UTF8.GetString(result);
		}
		
		
		
		// CRUD Function Users
		void insertDataUsers()
		{
			if (user_id.Text.Trim()   == "" ||
			    full_name.Text.Trim() == "" ||
			    email.Text.Trim()     == "" ||
			    username.Text.Trim()  == "" ||
			    password.Text.Trim()  == "")
			{
				MessageBox.Show("Data belum diisi dengan lengkap","Data Tidak Lengkap",MessageBoxButtons.OK,MessageBoxIcon.Stop);
			}
			else
			{
				try
				{
					co.Open();
					mycommand.CommandText   = "INSERT INTO users (user_id,full_name,email,username,password) VALUES('" + user_id.Text + "','" + full_name.Text + "','" + email.Text + "','" + username.Text + "','" + Encrypt(password.Text) + "')";
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
		}
		
		void updateDataUsers()
		{
			if (user_id.Text.Trim()   == "" ||
			    full_name.Text.Trim() == "" ||
			    email.Text.Trim()     == "" ||
			    username.Text.Trim()  == "" ||
			    password.Text.Trim()  == "")
			{
				MessageBox.Show("Data belum diisi dengan lengkap","Data Tidak Lengkap",MessageBoxButtons.OK,MessageBoxIcon.Stop);
			}
			else
			{
				try
				{
					co.Open();
					mycommand.CommandText   = "UPDATE users SET user_id='" + user_id.Text + "', full_name ='" + full_name.Text + "', email='" + email.Text + "', username ='" + username.Text + "', password ='" + Encrypt(password.Text) + "' WHERE user_id='" + user_id.Text + "'";
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
			user_id.Text   = Convert.ToString(incrementValueId());
			full_name.Text = "";
			email.Text     = "";
			username.Text  = "";
			password.Text  = "";
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
		
		
		
		// Increment ID Check Max(ID) from Database
		int incrementValueId()
		{
			try
			{
				co.Open();
				mycommand.CommandText = "SELECT MAX(user_id) FROM users";
				MySqlDataReader dr    = mycommand.ExecuteReader();
				
				while (dr.Read())
				{
					if (!dr.IsDBNull(0))
					{
						return Convert.ToInt32(dr.GetString(0)) + 1;
					}
				}
				
				co.Close();
				return 0;
			}
			catch (MySqlException error)
			{
				MessageBox.Show(error.ToString());
				return 0;
			}
			finally
			{
				co.Close();
			}
		}
	}
}
