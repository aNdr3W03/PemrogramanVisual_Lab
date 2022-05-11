/*
 * Created by SharpDevelop.
 * User: HP
 * Date: Rab, 11 Mei 2022
 * Time: 11.30.50
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
	/// Description of FormHistory.
	/// </summary>
	public partial class FormHistory : Form
	{
		MySqlConnection co         = new MySqlConnection("Server = localhost; Database = interstellar; Uid = root");
		MySqlCommand mycommand     = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		public FormHistory()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FormHistoryLoad(object sender, EventArgs e)
		{
			readDataTicket();
			comboBoxUserIDList();
			dataGridViewColumnWidth();
		}
		
		void readDataTicket()
		{
			// Read Tabel Ticket
			try
			{
				mycommand.Connection    = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText   = "SELECT * FROM ticket_booking ";
				
				DataSet tiket = new DataSet();
				if (myadapter.Fill(tiket,"dftpesan") > 0)
				{
					dataGridViewHistory.DataSource = tiket;
					dataGridViewHistory.DataMember = "dftpesan";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		void readDataCari()
		{
			// Read Tabel Ticket
			try
			{
				mycommand.Connection    = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText   = "SELECT * FROM ticket_booking WHERE user_id = '" + user_id.Text + "'";
				
				DataSet tiket = new DataSet();
				if (myadapter.Fill(tiket,"dftpesan") > 0)
				{
					dataGridViewHistory.DataSource = tiket;
					dataGridViewHistory.DataMember = "dftpesan";
				}
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
					user_id.Items.Add(reader.GetString("user_id"));
				}
				
				co.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		void BtnCariClick(object sender, EventArgs e)
		{
			readDataCari();
			hitungTotal();
			
			try
			{
				mycommand.Connection    = co;
				string CommandText      = "SELECT * FROM users WHERE user_id = '" + user_id.Text + "'";
				
				co.Open();
				
				MySqlCommand command    = new MySqlCommand(CommandText, co);
				MySqlDataReader reader  = command.ExecuteReader();
				
				while(reader.Read())
				{
					full_name.Text = reader.GetString("full_name");
					email.Text     = reader.GetString("email");
				}
				
				co.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		void hitungTotal()
		{
			int total = 0;
			
			for (int i=0; i<=dataGridViewHistory.Rows.Count-1; i++)
			{
				total += int.Parse(dataGridViewHistory.Rows[i].Cells[10].Value.ToString());
			}
			
			labelViewTotal.Text = total.ToString();
		}
		
		// DataGridView Column Width Config
		void dataGridViewColumnWidth()
		{
			dataGridViewHistory.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		    dataGridViewHistory.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		    dataGridViewHistory.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			dataGridViewHistory.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			dataGridViewHistory.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			dataGridViewHistory.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
          	dataGridViewHistory.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
          	dataGridViewHistory.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
          	dataGridViewHistory.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
          	dataGridViewHistory.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
          	dataGridViewHistory.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
		}
	}
}
