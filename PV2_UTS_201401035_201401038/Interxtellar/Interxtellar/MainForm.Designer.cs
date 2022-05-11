/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 5 Des 2021
 * Time: 07.47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Interxtellar
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
			this.btnKoneksi = new System.Windows.Forms.Button();
			this.dataGridViewExplore = new System.Windows.Forms.DataGridView();
			this.btnUsers = new System.Windows.Forms.Button();
			this.labelTitle = new System.Windows.Forms.Label();
			this.dataGridViewTicket = new System.Windows.Forms.DataGridView();
			this.btnExplore = new System.Windows.Forms.Button();
			this.btnTiket = new System.Windows.Forms.Button();
			this.labelTabelUsers = new System.Windows.Forms.Label();
			this.panelUsers = new System.Windows.Forms.Panel();
			this.panelExplore = new System.Windows.Forms.Panel();
			this.labelTabelExplore = new System.Windows.Forms.Label();
			this.panelTiket = new System.Windows.Forms.Panel();
			this.labelTabelTiket = new System.Windows.Forms.Label();
			this.btnRefresh = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewExplore)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicket)).BeginInit();
			this.panelUsers.SuspendLayout();
			this.panelExplore.SuspendLayout();
			this.panelTiket.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridViewUsers
			// 
			this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
			this.dataGridViewUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 10F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewUsers.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 10F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewUsers.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridViewUsers.Location = new System.Drawing.Point(5, 5);
			this.dataGridViewUsers.Name = "dataGridViewUsers";
			this.dataGridViewUsers.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 10F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewUsers.RowHeadersWidth = 25;
			this.dataGridViewUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewUsers.Size = new System.Drawing.Size(850, 250);
			this.dataGridViewUsers.TabIndex = 0;
			// 
			// btnKoneksi
			// 
			this.btnKoneksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnKoneksi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnKoneksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnKoneksi.Location = new System.Drawing.Point(880, 15);
			this.btnKoneksi.Name = "btnKoneksi";
			this.btnKoneksi.Size = new System.Drawing.Size(120, 40);
			this.btnKoneksi.TabIndex = 14;
			this.btnKoneksi.Text = "Cek Koneksi";
			this.btnKoneksi.UseVisualStyleBackColor = false;
			this.btnKoneksi.Click += new System.EventHandler(this.BtnKoneksiClick);
			// 
			// dataGridViewExplore
			// 
			this.dataGridViewExplore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
			this.dataGridViewExplore.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewExplore.BackgroundColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 10F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewExplore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewExplore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExplore.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 10F);
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewExplore.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewExplore.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridViewExplore.Location = new System.Drawing.Point(5, 5);
			this.dataGridViewExplore.Name = "dataGridViewExplore";
			this.dataGridViewExplore.ReadOnly = true;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Narrow", 10F);
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewExplore.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridViewExplore.RowHeadersWidth = 25;
			this.dataGridViewExplore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridViewExplore.RowTemplate.Height = 24;
			this.dataGridViewExplore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExplore.Size = new System.Drawing.Size(850, 250);
			this.dataGridViewExplore.TabIndex = 0;
			// 
			// btnUsers
			// 
			this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUsers.Location = new System.Drawing.Point(870, 130);
			this.btnUsers.Margin = new System.Windows.Forms.Padding(2);
			this.btnUsers.Name = "btnUsers";
			this.btnUsers.Size = new System.Drawing.Size(110, 40);
			this.btnUsers.TabIndex = 55;
			this.btnUsers.Text = "Users";
			this.btnUsers.UseVisualStyleBackColor = false;
			this.btnUsers.Click += new System.EventHandler(this.BtnUsersClick);
			// 
			// labelTitle
			// 
			this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.Location = new System.Drawing.Point(15, 15);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(850, 40);
			this.labelTitle.TabIndex = 56;
			this.labelTitle.Text = "CRUD Database Interxtellar";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridViewTicket
			// 
			this.dataGridViewTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
			this.dataGridViewTicket.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewTicket.BackgroundColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 10F);
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTicket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridViewTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTicket.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Narrow", 10F);
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTicket.DefaultCellStyle = dataGridViewCellStyle8;
			this.dataGridViewTicket.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridViewTicket.Location = new System.Drawing.Point(5, 5);
			this.dataGridViewTicket.Name = "dataGridViewTicket";
			this.dataGridViewTicket.ReadOnly = true;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial Narrow", 10F);
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTicket.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dataGridViewTicket.RowHeadersWidth = 25;
			this.dataGridViewTicket.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridViewTicket.RowTemplate.Height = 24;
			this.dataGridViewTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewTicket.Size = new System.Drawing.Size(850, 250);
			this.dataGridViewTicket.TabIndex = 57;
			// 
			// btnExplore
			// 
			this.btnExplore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnExplore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExplore.Location = new System.Drawing.Point(870, 130);
			this.btnExplore.Margin = new System.Windows.Forms.Padding(2);
			this.btnExplore.Name = "btnExplore";
			this.btnExplore.Size = new System.Drawing.Size(110, 40);
			this.btnExplore.TabIndex = 58;
			this.btnExplore.Text = "Explore";
			this.btnExplore.UseVisualStyleBackColor = false;
			this.btnExplore.Click += new System.EventHandler(this.BtnExploreClick);
			// 
			// btnTiket
			// 
			this.btnTiket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnTiket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTiket.Location = new System.Drawing.Point(870, 130);
			this.btnTiket.Margin = new System.Windows.Forms.Padding(2);
			this.btnTiket.Name = "btnTiket";
			this.btnTiket.Size = new System.Drawing.Size(110, 40);
			this.btnTiket.TabIndex = 59;
			this.btnTiket.Text = "Tiket";
			this.btnTiket.UseVisualStyleBackColor = false;
			this.btnTiket.Click += new System.EventHandler(this.BtnTiketClick);
			// 
			// labelTabelUsers
			// 
			this.labelTabelUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTabelUsers.Location = new System.Drawing.Point(860, 5);
			this.labelTabelUsers.Name = "labelTabelUsers";
			this.labelTabelUsers.Size = new System.Drawing.Size(130, 40);
			this.labelTabelUsers.TabIndex = 60;
			this.labelTabelUsers.Text = "Tabel Users";
			this.labelTabelUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelUsers
			// 
			this.panelUsers.BackColor = System.Drawing.Color.Gainsboro;
			this.panelUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelUsers.Controls.Add(this.dataGridViewUsers);
			this.panelUsers.Controls.Add(this.labelTabelUsers);
			this.panelUsers.Controls.Add(this.btnUsers);
			this.panelUsers.Location = new System.Drawing.Point(10, 65);
			this.panelUsers.Name = "panelUsers";
			this.panelUsers.Size = new System.Drawing.Size(995, 262);
			this.panelUsers.TabIndex = 61;
			// 
			// panelExplore
			// 
			this.panelExplore.BackColor = System.Drawing.Color.Gainsboro;
			this.panelExplore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelExplore.Controls.Add(this.labelTabelExplore);
			this.panelExplore.Controls.Add(this.dataGridViewExplore);
			this.panelExplore.Controls.Add(this.btnExplore);
			this.panelExplore.Location = new System.Drawing.Point(10, 332);
			this.panelExplore.Name = "panelExplore";
			this.panelExplore.Size = new System.Drawing.Size(995, 262);
			this.panelExplore.TabIndex = 62;
			// 
			// labelTabelExplore
			// 
			this.labelTabelExplore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTabelExplore.Location = new System.Drawing.Point(860, 5);
			this.labelTabelExplore.Name = "labelTabelExplore";
			this.labelTabelExplore.Size = new System.Drawing.Size(130, 40);
			this.labelTabelExplore.TabIndex = 65;
			this.labelTabelExplore.Text = "Tabel Explore";
			this.labelTabelExplore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelTiket
			// 
			this.panelTiket.BackColor = System.Drawing.Color.Gainsboro;
			this.panelTiket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelTiket.Controls.Add(this.labelTabelTiket);
			this.panelTiket.Controls.Add(this.dataGridViewTicket);
			this.panelTiket.Controls.Add(this.btnTiket);
			this.panelTiket.Location = new System.Drawing.Point(10, 600);
			this.panelTiket.Name = "panelTiket";
			this.panelTiket.Size = new System.Drawing.Size(995, 262);
			this.panelTiket.TabIndex = 63;
			// 
			// labelTabelTiket
			// 
			this.labelTabelTiket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTabelTiket.Location = new System.Drawing.Point(860, 5);
			this.labelTabelTiket.Name = "labelTabelTiket";
			this.labelTabelTiket.Size = new System.Drawing.Size(130, 40);
			this.labelTabelTiket.TabIndex = 66;
			this.labelTabelTiket.Text = "Tabel Tiket";
			this.labelTabelTiket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnRefresh
			// 
			this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRefresh.Location = new System.Drawing.Point(740, 15);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(130, 40);
			this.btnRefresh.TabIndex = 64;
			this.btnRefresh.Text = "Refresh Tabel";
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.btnRefresh.Click += new System.EventHandler(this.BtnRefreshClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1019, 871);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.panelTiket);
			this.Controls.Add(this.panelExplore);
			this.Controls.Add(this.panelUsers);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.btnKoneksi);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Interxtellar";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewExplore)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicket)).EndInit();
			this.panelUsers.ResumeLayout(false);
			this.panelExplore.ResumeLayout(false);
			this.panelTiket.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Panel panelTiket;
		private System.Windows.Forms.Label labelTabelExplore;
		private System.Windows.Forms.Panel panelExplore;
		private System.Windows.Forms.Label labelTabelTiket;
		private System.Windows.Forms.Panel panelUsers;
		private System.Windows.Forms.Label labelTabelUsers;
		private System.Windows.Forms.Button btnTiket;
		private System.Windows.Forms.Button btnExplore;
		private System.Windows.Forms.DataGridView dataGridViewTicket;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Button btnUsers;
		private System.Windows.Forms.DataGridView dataGridViewExplore;
		private System.Windows.Forms.Button btnKoneksi;
		private System.Windows.Forms.DataGridView dataGridViewUsers;
		
	}
}
