/*
 * Created by SharpDevelop.
 * User: HP
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

namespace Interxtellar
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
			ticket_id.Text    = dataGridViewTicket.Rows[e.RowIndex].Cells[1].Value.ToString();
			user_id.Text      = dataGridViewTicket.Rows[e.RowIndex].Cells[2].Value.ToString();
			from_id.Text      = dataGridViewTicket.Rows[e.RowIndex].Cells[3].Value.ToString();
			to_id.Text        = dataGridViewTicket.Rows[e.RowIndex].Cells[4].Value.ToString();
			date.Text         = dataGridViewTicket.Rows[e.RowIndex].Cells[5].Value.ToString();
			boarding.Text     = dataGridViewTicket.Rows[e.RowIndex].Cells[6].Value.ToString();
			ticket_class.Text = dataGridViewTicket.Rows[e.RowIndex].Cells[7].Value.ToString();
			launch_gate.Text  = dataGridViewTicket.Rows[e.RowIndex].Cells[8].Value.ToString();
			seat.Text         = dataGridViewTicket.Rows[e.RowIndex].Cells[9].Value.ToString();
		}
		
		
		
		// CRUD Function Ticket
		void insertDataTicket()
		{
			try
			{
				co.Open();
				mycommand.CommandText   = "INSERT INTO ticket_booking (ticket_id,user_id,from_id,to_id,date,boarding,class,launch_gate,seat) VALUES('" + ticket_id.Text + "'," + user_id.Text + ",'" + from_id.Text + "','" + to_id.Text + "','" + date.Text + "','" + boarding.Text + "','" + ticket_class.Text + "','" + launch_gate.Text + "','" + seat.Text + "')";
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
		
		void updateDataTicket()
		{
			try
			{
				co.Open();
				mycommand.CommandText   = "UPDATE ticket_booking SET ticket_id ='"+ticket_id.Text+"', user_id ="+user_id.Text+", from_id ='"+from_id.Text+"', to_id ='"+to_id.Text+"', date ='"+date.Text+"', boarding ='"+boarding.Text+"', class ='"+ticket_class.Text+"', launch_gate ='"+launch_gate.Text+"', seat ='"+seat.Text+"' WHERE ticket_id ='"+ticket_id.Text+"'";
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
//		
		void deleteDataTicket()
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
		
		
		// CRUD Button Ticket
		void BtnTambahTicketClick(object sender, EventArgs e)
		{
			insertDataTicket();
//			new MainForm().RefreshGrid();
		}
		
		void BtnUbahTicketClick(object sender, EventArgs e)
		{
			updateDataTicket();
//			new MainForm().RefreshGrid();
		}
		
		void BtnHapusTicketClick(object sender, EventArgs e)
		{
			deleteDataTicket();
//			new MainForm().RefreshGrid();
		}
		
		
		
//		// Button Tutup Window
//		void BtnTutupClick(object sender, EventArgs e)
//		{
//			this.Hide();
//		}
	}
}
