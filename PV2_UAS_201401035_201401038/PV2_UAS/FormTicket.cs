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
using System.Globalization;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace PV2_UAS
{
	/// <summary>
	/// Description of FormTicket.
	/// </summary>
	public partial class FormTicket : Form
	{
		MySqlConnection co         = new MySqlConnection("Server = localhost; Database = interstellar; Uid = root");
		MySqlCommand mycommand     = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		public FormTicket()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FormTicketLoad(object sender, EventArgs e)
		{
			readDataTicket();
			comboBoxUserIDList();
			comboBoxFromIDList();
			comboBoxDestinationIDList();
			dataGridViewColumnWidth();
			comboBoxDefaultSelected();
		}
		
		void readDataTicket()
		{
			// Read Tabel Ticket
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
		
		void DataGridViewTicketCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string id        = dataGridViewTicket.Rows[e.RowIndex].Cells[2].Value.ToString();
			string full_name = "";
			
			string fromID   = dataGridViewTicket.Rows[e.RowIndex].Cells[3].Value.ToString();
			string from_name = "";
			
			string toID     = dataGridViewTicket.Rows[e.RowIndex].Cells[4].Value.ToString();
			string to_name   = "";
			
			try
			{
				mycommand.Connection    = co;
				string CommandText      = "SELECT * FROM users WHERE user_id = '" + id + "'";
				
				co.Open();
				
				MySqlCommand command    = new MySqlCommand(CommandText, co);
				MySqlDataReader reader  = command.ExecuteReader();
				
				while(reader.Read())
				{
					full_name = reader.GetString("full_name");
				}
				
				co.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
			try
			{
				mycommand.Connection    = co;
				string CommandText      = "SELECT * FROM explore WHERE explore_id = '" + fromID + "'";
				
				co.Open();
				
				MySqlCommand command    = new MySqlCommand(CommandText, co);
				MySqlDataReader reader  = command.ExecuteReader();
				
				while(reader.Read())
				{
					from_name = reader.GetString("object");
				}
				
				co.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
			try
			{
				mycommand.Connection    = co;
				string CommandText      = "SELECT * FROM explore WHERE explore_id = '" + toID + "'";
				
				co.Open();
				
				MySqlCommand command    = new MySqlCommand(CommandText, co);
				MySqlDataReader reader  = command.ExecuteReader();
				
				while(reader.Read())
				{
					to_name = reader.GetString("object");
				}
				
				co.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
			ticket_id.Text    = dataGridViewTicket.Rows[e.RowIndex].Cells[1].Value.ToString();
			user_id.Text      = dataGridViewTicket.Rows[e.RowIndex].Cells[2].Value.ToString() + " (" + full_name + ")";
			from_id.Text      = dataGridViewTicket.Rows[e.RowIndex].Cells[3].Value.ToString() + " (" + from_name + ")";
			to_id.Text        = dataGridViewTicket.Rows[e.RowIndex].Cells[4].Value.ToString() + " (" + to_name + ")";
			date.Text         = dataGridViewTicket.Rows[e.RowIndex].Cells[5].Value.ToString();
			boarding.Text     = dataGridViewTicket.Rows[e.RowIndex].Cells[6].Value.ToString();
			ticket_class.Text = dataGridViewTicket.Rows[e.RowIndex].Cells[7].Value.ToString();
			launch_gate.Text  = dataGridViewTicket.Rows[e.RowIndex].Cells[8].Value.ToString();
			seat.Text         = dataGridViewTicket.Rows[e.RowIndex].Cells[9].Value.ToString();
			price.Text        = dataGridViewTicket.Rows[e.RowIndex].Cells[10].Value.ToString();
		}
		
		
		
		// CRUD Function Ticket
		void insertDataTicket()
		{
			if (ticket_id.Text.Trim()    == "" ||
			    user_id.Text.Trim()      == "" || user_id.Text.Trim()      == "--Pilih--" ||
			    from_id.Text.Trim()      == "" || from_id.Text.Trim()      == "--Pilih--" ||
			    to_id.Text.Trim()        == "" || to_id.Text.Trim()        == "--Pilih--" ||
			    date.Text.Trim()         == "" ||
			    boarding.Text.Trim()     == "" ||
				ticket_class.Text.Trim() == "" || ticket_class.Text.Trim() == "--Pilih--" ||
				launch_gate.Text.Trim()  == "" ||
				seat.Text.Trim()         == "" ||
				price.Text.Trim()        == "")
			{
				MessageBox.Show("Data belum diisi dengan lengkap","Data Tidak Lengkap",MessageBoxButtons.OK,MessageBoxIcon.Stop);
			}
			else
			{
				try
				{
					co.Open();
					mycommand.CommandText   = "INSERT INTO ticket_booking (ticket_id,user_id,from_id,to_id,date,boarding,class,launch_gate,seat,price) VALUES('" + ticket_id.Text + "'," + user_id.Text.Substring(0, 3) + ",'" + from_id.Text.Substring(0, 10) + "','" + to_id.Text.Substring(0, 10) + "','" + date.Value.ToString("yyyy-MM-dd") + "','" + boarding.Value.ToString("HH") + ":" + boarding.Value.ToString("mm") + ":" + boarding.Value.ToString("ss") + "','" + ticket_class.Text + "','" + launch_gate.Text + "','" + seat.Text + "','" + price.Text +"')";
					myadapter.SelectCommand = mycommand;
					if (mycommand.ExecuteNonQuery() == 1)
					{
						MessageBox.Show("Data berhasil dimasukkan","Tambah Data",MessageBoxButtons.OK,MessageBoxIcon.Information);
						readDataTicket();
					}
					co.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}
		
		void updateDataTicket()
		{
			if (ticket_id.Text.Trim()    == "" ||
			    user_id.Text.Trim()      == "" || user_id.Text.Trim()      == "--Pilih--" ||
			    from_id.Text.Trim()      == "" || from_id.Text.Trim()      == "--Pilih--" ||
			    to_id.Text.Trim()        == "" || to_id.Text.Trim()        == "--Pilih--" ||
			    date.Text.Trim()         == "" ||
			    boarding.Text.Trim()     == "" ||
				ticket_class.Text.Trim() == "" || ticket_class.Text.Trim() == "--Pilih--" ||
				launch_gate.Text.Trim()  == "" ||
				seat.Text.Trim()         == "" ||
				price.Text.Trim()        == "")
			{
				MessageBox.Show("Data belum diisi dengan lengkap","Data Tidak Lengkap",MessageBoxButtons.OK,MessageBoxIcon.Stop);
			}
			else
			{
				try
				{
					co.Open();
					mycommand.CommandText   = "UPDATE ticket_booking SET ticket_id ='" + ticket_id.Text + "', user_id =" + user_id.Text.Substring(0, 3) + ", from_id ='" + from_id.Text.Substring(0, 10) + "', to_id ='" + to_id.Text.Substring(0, 10) + "', date ='" + date.Value.ToString("yyyy-MM-dd") + "', boarding ='" + boarding.Value.ToString("HH") + ":" + boarding.Value.ToString("mm") + ":" + boarding.Value.ToString("ss") + "', class ='" + ticket_class.Text + "', launch_gate ='" + launch_gate.Text + "', seat ='" + seat.Text + "', price = '" + price.Text + "' WHERE ticket_id ='" + ticket_id.Text + "'";
					myadapter.SelectCommand = mycommand;
					if (mycommand.ExecuteNonQuery() == 1)
					{
						MessageBox.Show("Data berhasil diupdate","Ubah Data",MessageBoxButtons.OK,MessageBoxIcon.Information);
						readDataTicket();
					}
					co.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}
//		
		void deleteDataTicket()
		{
			if (MessageBox.Show("Tiket " + ticket_id.Text + ", yakin ingin dihapus?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				try
				{
					co.Open();
					mycommand.CommandText   = "DELETE FROM ticket_booking WHERE ticket_id ='" + ticket_id.Text + "'";
					myadapter.SelectCommand = mycommand;
					if (mycommand.ExecuteNonQuery() == 1)
					{
						MessageBox.Show("Data berhasil dihapus","Hapus Data",MessageBoxButtons.OK,MessageBoxIcon.Information);
						readDataTicket();
					}
					co.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}
		
		
		
		// CRUD Button Ticket
		void BtnTambahTicketClick(object sender, EventArgs e)
		{
			insertDataTicket();
		}
		
		void BtnUbahTicketClick(object sender, EventArgs e)
		{
			updateDataTicket();
		}
		
		void BtnHapusTicketClick(object sender, EventArgs e)
		{
			deleteDataTicket();
		}
		
		void BtnRefreshUsersClick(object sender, EventArgs e)
		{
			long   hitung     = 0;
			string urutan     = "";
			string kodeUrutan = "";
			string tanggalMax = "";
			
			try
			{
				co.Open();
				mycommand.CommandText = "SELECT ticket_id FROM ticket_booking WHERE ticket_id IN (SELECT MAX(ticket_id) FROM ticket_booking) ORDER BY ticket_id DESC";
				MySqlDataReader dr    = mycommand.ExecuteReader();
				dr.Read();
				
				if (dr.HasRows)
				{
					tanggalMax = dr[0].ToString().Substring(dr["ticket_id"].ToString().Length - 16, 8);
					
					if (DateTime.Now.ToString("yyyyMMdd") != tanggalMax)
					{
						// Jika tanggal hari ini tidak sama dengan tanggal ticket_id MAX,
						// Data mulai dari 1 lagi (dr.HasRows = false/datarow masih kosong)
						// Ganti date-nya jadi hari ini.
						kodeUrutan = DateTime.Now.ToString("yyyyMMdd") + "00000001";
					}
					else // dr.HasNoRow
					{
						hitung     = Convert.ToInt64(dr[0].ToString().Substring(dr["ticket_id"].ToString().Length - 8, 8)) + 1;
						urutan     = "00000000" + hitung;
						kodeUrutan = DateTime.Now.ToString("yyyyMMdd") + urutan.Substring(urutan.Length - 8, 8);
					}
				}
				
				ticket_id.Text = kodeUrutan.ToString();
				co.Close();
			}
			catch (MySqlException error)
			{
				MessageBox.Show(error.ToString());
			}
			
			user_id.Text      = "--Pilih--";
			from_id.Text      = "--Pilih--";
			to_id.Text        = "--Pilih--";
			date.Text         = "";
			boarding.Text     = "";
			ticket_class.Text = "--Pilih--";
			launch_gate.Text  = "";
			seat.Text         = "";
			price.Text        = "";
		}
		
		
		
		void SeatKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsUpper(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
		}
		
		void Launch_gateKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsUpper(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
		}
		
		
		
		// Ubah Harga Jika ComboBox Destination Berubah
		void To_idSelectionChangeCommitted(object sender, EventArgs e)
		{
			try
			{
				mycommand.Connection    = co;
				string CommandText      = "SELECT * FROM explore WHERE explore_id = '" + to_id.Text.Substring(0, 10) + "'";
				
				co.Open();
				
				MySqlCommand command    = new MySqlCommand(CommandText, co);
				MySqlDataReader reader  = command.ExecuteReader();
				
				while(reader.Read())
				{
					price.Text = reader.GetString("price");
				}
				
				co.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		
		
		// List User ID from DB to ComboBox
		void comboBoxUserIDList()
		{
			try
			{
				mycommand.Connection    = co;
				string CommandText      = "SELECT * FROM users";
				
				co.Open();
				
				MySqlCommand command    = new MySqlCommand(CommandText, co);
				MySqlDataReader reader  = command.ExecuteReader();
				
				while(reader.Read())
				{
					user_id.Items.Add(reader.GetString("user_id") + " (" + reader.GetString("full_name") + ")");
				}
				
				co.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		// List Explore ID from DB to ComboBox
		void comboBoxFromIDList()
		{
			try
			{
				mycommand.Connection    = co;
				string CommandText      = "SELECT * FROM explore";
				
				co.Open();
				
				MySqlCommand command    = new MySqlCommand(CommandText, co);
				MySqlDataReader reader  = command.ExecuteReader();
				
				while(reader.Read())
				{
					from_id.Items.Add(reader.GetString("explore_id") + " (" + reader.GetString("object") + ")");
				}
				
				co.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		// List Explore ID from DB to ComboBox
		void comboBoxDestinationIDList()
		{
			try
			{
				mycommand.Connection    = co;
				string CommandText      = "SELECT * FROM explore";
				
				co.Open();
				
				MySqlCommand command    = new MySqlCommand(CommandText, co);
				MySqlDataReader reader  = command.ExecuteReader();
				
				while(reader.Read())
				{
					to_id.Items.Add(reader.GetString("explore_id") + " (" + reader.GetString("object") + ")");
				}
				
				co.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		
		
		void comboBoxDefaultSelected()
		{
			user_id.Text      = "--Pilih--";
			from_id.Text      = "--Pilih--";
			to_id.Text        = "--Pilih--";
			ticket_class.Text = "--Pilih--";
		}
		
		
		
		// DataGridView Column Width Config
		void dataGridViewColumnWidth()
		{
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
