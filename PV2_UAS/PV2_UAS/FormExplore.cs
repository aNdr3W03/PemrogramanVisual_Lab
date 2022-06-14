/*
 * Created by SharpDevelop.
 * User: Andrew
 * Date: 17 Des 2021
 * Time: 14.52
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

namespace PV2_UAS
{
	/// <summary>
	/// Description of FormExplore.
	/// </summary>
	public partial class FormExplore : Form
	{
		MySqlConnection co         = new MySqlConnection("Server = localhost; Database = interstellar; Uid = root");
		MySqlCommand mycommand     = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		public FormExplore()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FormExploreLoad(object sender, EventArgs e)
		{
			readDataExplore();
			dataGridViewColumnWidth();
		}
		
		void readDataExplore()
		{
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
		}
		
		void DataGridViewExploreCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			explore_id.Text   = dataGridViewExplore.Rows[e.RowIndex].Cells[1].Value.ToString();
			star.Text         = dataGridViewExplore.Rows[e.RowIndex].Cells[2].Value.ToString();
			object_id.Text    = dataGridViewExplore.Rows[e.RowIndex].Cells[3].Value.ToString();
			mass.Text         = dataGridViewExplore.Rows[e.RowIndex].Cells[4].Value.ToString();
			radius.Text       = dataGridViewExplore.Rows[e.RowIndex].Cells[5].Value.ToString();
			period.Text       = dataGridViewExplore.Rows[e.RowIndex].Cells[6].Value.ToString();
			distance.Text     = dataGridViewExplore.Rows[e.RowIndex].Cells[7].Value.ToString();
			travel_time.Text  = dataGridViewExplore.Rows[e.RowIndex].Cells[8].Value.ToString();
			price.Text        = dataGridViewExplore.Rows[e.RowIndex].Cells[9].Value.ToString();
		}
		
		
		
		// CRUD Function Explore
		void insertDataExplore()
		{
			if (explore_id.Text.Trim()  == "" ||
				star.Text.Trim()        == "" ||
				object_id.Text.Trim()   == "" ||
				mass.Text.Trim()        == "" ||
				radius.Text.Trim()      == "" ||
				period.Text.Trim()      == "" ||
				distance.Text.Trim()    == "" ||
				travel_time.Text.Trim() == "" ||
				price.Text.Trim()       == "")
			{
				MessageBox.Show("Data belum diisi dengan lengkap","Data Tidak Lengkap",MessageBoxButtons.OK,MessageBoxIcon.Stop);
			}
			else
			{
				try
				{
					co.Open();
					mycommand.CommandText   = "INSERT INTO explore (explore_id,star,object,mass,radius,period,distance,travel_time,price) VALUES('" + explore_id.Text + "','" + star.Text + "','" + object_id.Text + "','" + mass.Text + "','" + radius.Text + "','" + period.Text + "','" + distance.Text + "','" + travel_time.Text + "','" + price.Text + "')";
					myadapter.SelectCommand = mycommand;
					if (mycommand.ExecuteNonQuery() == 1)
					{
						MessageBox.Show("Data berhasil dimasukkan","Tambah Data",MessageBoxButtons.OK,MessageBoxIcon.Information);
						readDataExplore();
					}
					co.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}
		
		void updateDataExplore()
		{
			if (explore_id.Text.Trim()  == "" ||
				star.Text.Trim()        == "" ||
				object_id.Text.Trim()   == "" ||
				mass.Text.Trim()        == "" ||
				radius.Text.Trim()      == "" ||
				period.Text.Trim()      == "" ||
				distance.Text.Trim()    == "" ||
				travel_time.Text.Trim() == "" ||
				price.Text.Trim()       == "")
			{
				MessageBox.Show("Data belum diisi dengan lengkap","Data Tidak Lengkap",MessageBoxButtons.OK,MessageBoxIcon.Stop);
			}
			else
			{
				try
				{
					co.Open();
					mycommand.CommandText   = "UPDATE explore SET explore_id ='" + explore_id.Text + "', star ='" + star.Text + "', object ='" + object_id.Text + "', mass ='" + mass.Text + "', radius ='" + radius.Text + "', period ='" + period.Text + "', distance ='" + distance.Text + "', travel_time ='" + travel_time.Text + "', price ='" + price.Text + "' WHERE explore_id ='" + explore_id.Text + "'";
					myadapter.SelectCommand = mycommand;
					if (mycommand.ExecuteNonQuery() == 1)
					{
						MessageBox.Show("Data berhasil diupdate","Ubah Data",MessageBoxButtons.OK,MessageBoxIcon.Information);
						readDataExplore();
					}
					co.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}
		
		void deleteDataExplore()
		{
			if (MessageBox.Show(object_id.Text + ", yakin ingin dihapus?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				try
				{
					co.Open();
					mycommand.CommandText   = "DELETE FROM explore WHERE explore_id ='" + explore_id.Text + "'";
					myadapter.SelectCommand = mycommand;
					if (mycommand.ExecuteNonQuery() == 1)
					{
						MessageBox.Show("Data berhasil dihapus","Hapus Data",MessageBoxButtons.OK,MessageBoxIcon.Information);
						readDataExplore();
					}
					co.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}
		
		
		
		// CRUD Button Explore
		void BtnTambahExploreClick(object sender, EventArgs e)
		{
			insertDataExplore();
		}
		
		void BtnUbahExploreClick(object sender, EventArgs e)
		{
			updateDataExplore();
		}
		
		void BtnHapusExploreClick(object sender, EventArgs e)
		{
			deleteDataExplore();
		}
		
		
		
		// IsDigit   = Int
		// e.KeyChar = Custom char
		// Keys.Back = Backspace
		
		void MassKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back;
		}
		
		void RadiusKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back;
		}
		
		void PeriodKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back;
		}
		
		void DistanceKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back;
		}
		
		void Travel_timeKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back;
		}
		
		void PriceKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
		}
		
		
		
		// DataGridView Column Width Config
		void dataGridViewColumnWidth()
		{
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
		}
	}
}
