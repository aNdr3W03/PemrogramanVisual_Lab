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
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		MySqlConnection co         = new MySqlConnection("Server = localhost; Database = interstellar; Uid= root");
		MySqlCommand mycommand     = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public bool dbOpen()
		{
			try
			{
				co.Open();
			}
			catch
			{
				MessageBox.Show("Tidak Terhubung");
				return false;
			}
			return true;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (dbOpen())
			{
				MessageBox.Show("Terhubung");
				co.Close();
			}
		}
	}
}
