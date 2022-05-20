/*
 * Created by SharpDevelop.
 * User: HP
 * Date: Rab, 18 Mei 2022
 * Time: 00.52.05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;

namespace PV2_Modul5_201401035
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string connectionSQL = "Server = localhost; Database = pvfile; Uid = root; password =;";
		Bitmap img;
		
		string pathImg;
//		string SourceFilePath;
//		string inputId;
//		string intInputId;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			readData();
			dataGridViewColumnWidth();
			comboBoxIdList();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void readData()
		{
			MySqlConnection koneksi = new MySqlConnection(connectionSQL);
			koneksi.Open();
			DataTable        dt = new DataTable();
			MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM filegambar", koneksi);
			da.Fill(dt);
			dataGridView.DataSource = dt.DefaultView;
			
			koneksi.Close();
		}
		
		void dataGridViewColumnWidth()
		{
			dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}
		
		// List ID from DB to ComboBox
		void comboBoxIdList()
		{
			try
			{
				MySqlConnection koneksi = new MySqlConnection(connectionSQL);
				koneksi.Open();
				MySqlCommand    cmd     = new MySqlCommand("SELECT * from filegambar", koneksi);
				MySqlDataReader dr      = cmd.ExecuteReader();
				
				while (dr.Read())
				{
					comboBoxId.Items.Add(dr.GetString("id"));
				}
				
				koneksi.Close();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		void BtnUpOpenFileClick(object sender, EventArgs e)
		{
			if (DialogResult.OK == openFileDialog.ShowDialog())
			{
				img                    = new Bitmap(openFileDialog.FileName);
				pictureBoxUpload.Image = img;
				pathImg                = openFileDialog.FileName.ToString();
			}
		}
		
		void BtnUpSaveFileClick(object sender, EventArgs e)
		{
			File2SQLBlob(pathImg);
			readData();
		}
		
		private void File2SQLBlob(string SourceFilePath)
		{
			try
			{
				MySqlConnection      koneksi = new MySqlConnection(connectionSQL);
				MySqlCommand         cmd     = new MySqlCommand("INSERT INTO filegambar (id, dataFile) values (" + incrementValueId() + ", ?Picture)", koneksi);
				System.IO.FileStream fs      = new System.IO.FileStream(SourceFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
				Byte[]               b       = new Byte[fs.Length];
				
				fs.Read(b, 0, b.Length);
				fs.Close();
				
				MySqlParameter P = new MySqlParameter("?Picture", MySqlDbType.LongBlob, b.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, b);
				cmd.Parameters.Add(P);
				koneksi.Open();
				
				if (cmd.ExecuteNonQuery() == 1)
					MessageBox.Show("Gambar Berhasil Disimpan ke Database");
				
				koneksi.Close();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			readData();
		}
		
		void BtnDwOpenFileClick(object sender, EventArgs e)
		{
			try
			{
				MySqlConnection  koneksi = new MySqlConnection(connectionSQL);
				koneksi.Open();
				MySqlDataAdapter da      = new MySqlDataAdapter(new MySqlCommand("SELECT dataFile FROM filegambar WHERE id = " + comboBoxId.Text, koneksi));
				DataSet          ds      = new DataSet();
				da.Fill(ds);
				
				if (ds.Tables[0].Rows.Count == 1)
				{
					Byte[]       data    = new Byte[0];
					data = (Byte[])(ds.Tables[0].Rows[0]["dataFile"]);
					
					MemoryStream mem     = new MemoryStream(data);
					pictureBoxDownload.Image = Image.FromStream(mem);
				}
				
				koneksi.Close();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		
		void BtnDwSaveFileClick(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Image|.png;.bmp;.jpg";
			ImageFormat format = ImageFormat.Png;
			
			if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				string ext = System.IO.Path.GetExtension(sfd.FileName);
				
				switch (ext)
				{
					case ".jpg":
						format = ImageFormat.Jpeg;
						break;
					case ".bmp":
						format = ImageFormat.Bmp;
						break;
				}
				
				pictureBoxDownload.Image.Save(sfd.FileName, format);
			}
		}
		
		private int incrementValueId() // Untuk menambahkan index id
		{
			try
			{
				MySqlConnection db    = new MySqlConnection(connectionSQL);
				db.Open();
				MySqlCommand    dbcmd = db.CreateCommand();
				
				string          sql   = "SELECT MAX(id) from filegambar";
				dbcmd.CommandText     = sql;
				MySqlDataReader dr    = dbcmd.ExecuteReader();
				
				while (dr.Read())
				{
					if (!dr.IsDBNull(0))
					{
						return Convert.ToInt16(dr.GetString(0)) + 1;
					}
				}
				
				return 0;
			}
			catch (MySqlException error)
			{
				MessageBox.Show(error.ToString());
				return 0;
			}
		}
	}
}
