/*
 * Created by SharpDevelop.
 * User: Andrew
 * Date: 17 Des 2021
 * Time: 14.52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PV2_UAS
{
	partial class FormTicket
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTicket));
			this.btnUbahTicket = new System.Windows.Forms.Button();
			this.btnHapusTicket = new System.Windows.Forms.Button();
			this.btnTambahTicket = new System.Windows.Forms.Button();
			this.dataGridViewTicket = new System.Windows.Forms.DataGridView();
			this.labelTitle = new System.Windows.Forms.Label();
			this.labeluser_id = new System.Windows.Forms.Label();
			this.label_boarding = new System.Windows.Forms.Label();
			this.labelticket_id = new System.Windows.Forms.Label();
			this.labeldate = new System.Windows.Forms.Label();
			this.labeldestination_star = new System.Windows.Forms.Label();
			this.labelfrom_star = new System.Windows.Forms.Label();
			this.label_spacecraft = new System.Windows.Forms.Label();
			this.launch_gate = new System.Windows.Forms.TextBox();
			this.labellaunch_gate = new System.Windows.Forms.Label();
			this.seat = new System.Windows.Forms.TextBox();
			this.labelseat = new System.Windows.Forms.Label();
			this.ticket_class = new System.Windows.Forms.ComboBox();
			this.date = new System.Windows.Forms.DateTimePicker();
			this.boarding = new System.Windows.Forms.DateTimePicker();
			this.user_id = new System.Windows.Forms.ComboBox();
			this.from_id = new System.Windows.Forms.ComboBox();
			this.to_id = new System.Windows.Forms.ComboBox();
			this.labelprice = new System.Windows.Forms.Label();
			this.price = new System.Windows.Forms.Label();
			this.btnRefreshUsers = new System.Windows.Forms.Button();
			this.ticket_id = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicket)).BeginInit();
			this.SuspendLayout();
			// 
			// btnUbahTicket
			// 
			this.btnUbahTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btnUbahTicket.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUbahTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUbahTicket.Location = new System.Drawing.Point(700, 437);
			this.btnUbahTicket.Name = "btnUbahTicket";
			this.btnUbahTicket.Size = new System.Drawing.Size(130, 40);
			this.btnUbahTicket.TabIndex = 34;
			this.btnUbahTicket.Text = "Ubah";
			this.btnUbahTicket.UseVisualStyleBackColor = false;
			this.btnUbahTicket.Click += new System.EventHandler(this.BtnUbahTicketClick);
			// 
			// btnHapusTicket
			// 
			this.btnHapusTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnHapusTicket.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnHapusTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHapusTicket.Location = new System.Drawing.Point(700, 500);
			this.btnHapusTicket.Name = "btnHapusTicket";
			this.btnHapusTicket.Size = new System.Drawing.Size(130, 40);
			this.btnHapusTicket.TabIndex = 33;
			this.btnHapusTicket.Text = "Hapus";
			this.btnHapusTicket.UseVisualStyleBackColor = false;
			this.btnHapusTicket.Click += new System.EventHandler(this.BtnHapusTicketClick);
			// 
			// btnTambahTicket
			// 
			this.btnTambahTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnTambahTicket.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTambahTicket.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnTambahTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTambahTicket.Location = new System.Drawing.Point(700, 375);
			this.btnTambahTicket.Name = "btnTambahTicket";
			this.btnTambahTicket.Size = new System.Drawing.Size(130, 40);
			this.btnTambahTicket.TabIndex = 32;
			this.btnTambahTicket.Text = "Tambah";
			this.btnTambahTicket.UseVisualStyleBackColor = false;
			this.btnTambahTicket.Click += new System.EventHandler(this.BtnTambahTicketClick);
			// 
			// dataGridViewTicket
			// 
			this.dataGridViewTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
			this.dataGridViewTicket.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewTicket.BackgroundColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 10F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTicket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTicket.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 10F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTicket.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewTicket.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridViewTicket.Location = new System.Drawing.Point(15, 60);
			this.dataGridViewTicket.Name = "dataGridViewTicket";
			this.dataGridViewTicket.ReadOnly = true;
			this.dataGridViewTicket.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dataGridViewTicket.RowHeadersWidth = 25;
			this.dataGridViewTicket.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridViewTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewTicket.Size = new System.Drawing.Size(850, 300);
			this.dataGridViewTicket.TabIndex = 31;
			this.dataGridViewTicket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTicketCellContentClick);
			// 
			// labelTitle
			// 
			this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.Location = new System.Drawing.Point(15, 15);
			this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(740, 30);
			this.labelTitle.TabIndex = 30;
			this.labelTitle.Text = "Halaman CRUD Tabel Ticket";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labeluser_id
			// 
			this.labeluser_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labeluser_id.Location = new System.Drawing.Point(50, 410);
			this.labeluser_id.Name = "labeluser_id";
			this.labeluser_id.Size = new System.Drawing.Size(90, 25);
			this.labeluser_id.TabIndex = 71;
			this.labeluser_id.Text = "User ID";
			this.labeluser_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label_boarding
			// 
			this.label_boarding.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_boarding.Location = new System.Drawing.Point(380, 515);
			this.label_boarding.Name = "label_boarding";
			this.label_boarding.Size = new System.Drawing.Size(90, 25);
			this.label_boarding.TabIndex = 69;
			this.label_boarding.Text = "Boarding";
			this.label_boarding.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelticket_id
			// 
			this.labelticket_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelticket_id.Location = new System.Drawing.Point(50, 375);
			this.labelticket_id.Name = "labelticket_id";
			this.labelticket_id.Size = new System.Drawing.Size(90, 25);
			this.labelticket_id.TabIndex = 63;
			this.labelticket_id.Text = "Ticket ID";
			this.labelticket_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labeldate
			// 
			this.labeldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labeldate.Location = new System.Drawing.Point(50, 515);
			this.labeldate.Name = "labeldate";
			this.labeldate.Size = new System.Drawing.Size(90, 25);
			this.labeldate.TabIndex = 57;
			this.labeldate.Text = "Date";
			this.labeldate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labeldestination_star
			// 
			this.labeldestination_star.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labeldestination_star.Location = new System.Drawing.Point(50, 480);
			this.labeldestination_star.Name = "labeldestination_star";
			this.labeldestination_star.Size = new System.Drawing.Size(90, 25);
			this.labeldestination_star.TabIndex = 56;
			this.labeldestination_star.Text = "Destination";
			this.labeldestination_star.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelfrom_star
			// 
			this.labelfrom_star.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelfrom_star.Location = new System.Drawing.Point(50, 445);
			this.labelfrom_star.Name = "labelfrom_star";
			this.labelfrom_star.Size = new System.Drawing.Size(90, 25);
			this.labelfrom_star.TabIndex = 55;
			this.labelfrom_star.Text = "From Star";
			this.labelfrom_star.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label_spacecraft
			// 
			this.label_spacecraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_spacecraft.Location = new System.Drawing.Point(50, 550);
			this.label_spacecraft.Name = "label_spacecraft";
			this.label_spacecraft.Size = new System.Drawing.Size(90, 25);
			this.label_spacecraft.TabIndex = 73;
			this.label_spacecraft.Text = "Class";
			this.label_spacecraft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// launch_gate
			// 
			this.launch_gate.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.launch_gate.Location = new System.Drawing.Point(480, 550);
			this.launch_gate.Name = "launch_gate";
			this.launch_gate.Size = new System.Drawing.Size(150, 25);
			this.launch_gate.TabIndex = 76;
			this.launch_gate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Launch_gateKeyPress);
			// 
			// labellaunch_gate
			// 
			this.labellaunch_gate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labellaunch_gate.Location = new System.Drawing.Point(380, 550);
			this.labellaunch_gate.Name = "labellaunch_gate";
			this.labellaunch_gate.Size = new System.Drawing.Size(90, 25);
			this.labellaunch_gate.TabIndex = 75;
			this.labellaunch_gate.Text = "Launch Gate";
			this.labellaunch_gate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// seat
			// 
			this.seat.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.seat.Location = new System.Drawing.Point(150, 585);
			this.seat.Name = "seat";
			this.seat.Size = new System.Drawing.Size(150, 25);
			this.seat.TabIndex = 78;
			this.seat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SeatKeyPress);
			// 
			// labelseat
			// 
			this.labelseat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelseat.Location = new System.Drawing.Point(50, 585);
			this.labelseat.Name = "labelseat";
			this.labelseat.Size = new System.Drawing.Size(90, 25);
			this.labelseat.TabIndex = 77;
			this.labelseat.Text = "Seat";
			this.labelseat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ticket_class
			// 
			this.ticket_class.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ticket_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ticket_class.Font = new System.Drawing.Font("Consolas", 10.75F);
			this.ticket_class.FormattingEnabled = true;
			this.ticket_class.Items.AddRange(new object[] {
									"--Pilih--",
									"X",
									"S",
									"A",
									"B",
									"C"});
			this.ticket_class.Location = new System.Drawing.Point(150, 550);
			this.ticket_class.Name = "ticket_class";
			this.ticket_class.Size = new System.Drawing.Size(150, 25);
			this.ticket_class.TabIndex = 79;
			// 
			// date
			// 
			this.date.Cursor = System.Windows.Forms.Cursors.Hand;
			this.date.CustomFormat = "dd MMM yyyy";
			this.date.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.date.Location = new System.Drawing.Point(150, 515);
			this.date.Name = "date";
			this.date.Size = new System.Drawing.Size(150, 25);
			this.date.TabIndex = 80;
			this.date.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
			// 
			// boarding
			// 
			this.boarding.Cursor = System.Windows.Forms.Cursors.Hand;
			this.boarding.CustomFormat = "HH:mm:ss";
			this.boarding.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.boarding.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.boarding.Location = new System.Drawing.Point(480, 515);
			this.boarding.Name = "boarding";
			this.boarding.ShowUpDown = true;
			this.boarding.Size = new System.Drawing.Size(150, 25);
			this.boarding.TabIndex = 81;
			this.boarding.Value = new System.DateTime(2022, 6, 8, 0, 0, 0, 0);
			// 
			// user_id
			// 
			this.user_id.Cursor = System.Windows.Forms.Cursors.Hand;
			this.user_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.user_id.Font = new System.Drawing.Font("Consolas", 10.75F);
			this.user_id.FormattingEnabled = true;
			this.user_id.Items.AddRange(new object[] {
									"--Pilih--"});
			this.user_id.Location = new System.Drawing.Point(150, 410);
			this.user_id.Name = "user_id";
			this.user_id.Size = new System.Drawing.Size(480, 25);
			this.user_id.TabIndex = 82;
			// 
			// from_id
			// 
			this.from_id.Cursor = System.Windows.Forms.Cursors.Hand;
			this.from_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.from_id.Font = new System.Drawing.Font("Consolas", 10.75F);
			this.from_id.FormattingEnabled = true;
			this.from_id.Items.AddRange(new object[] {
									"--Pilih--"});
			this.from_id.Location = new System.Drawing.Point(150, 445);
			this.from_id.Name = "from_id";
			this.from_id.Size = new System.Drawing.Size(480, 25);
			this.from_id.TabIndex = 83;
			// 
			// to_id
			// 
			this.to_id.Cursor = System.Windows.Forms.Cursors.Hand;
			this.to_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.to_id.Font = new System.Drawing.Font("Consolas", 10.75F);
			this.to_id.FormattingEnabled = true;
			this.to_id.Items.AddRange(new object[] {
									"--Pilih--"});
			this.to_id.Location = new System.Drawing.Point(150, 480);
			this.to_id.Name = "to_id";
			this.to_id.Size = new System.Drawing.Size(480, 25);
			this.to_id.TabIndex = 84;
			this.to_id.SelectionChangeCommitted += new System.EventHandler(this.To_idSelectionChangeCommitted);
			// 
			// labelprice
			// 
			this.labelprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelprice.Location = new System.Drawing.Point(380, 585);
			this.labelprice.Name = "labelprice";
			this.labelprice.Size = new System.Drawing.Size(90, 25);
			this.labelprice.TabIndex = 86;
			this.labelprice.Text = "Price";
			this.labelprice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// price
			// 
			this.price.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.price.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.price.Location = new System.Drawing.Point(480, 585);
			this.price.Name = "price";
			this.price.Size = new System.Drawing.Size(150, 25);
			this.price.TabIndex = 87;
			this.price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnRefreshUsers
			// 
			this.btnRefreshUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
			this.btnRefreshUsers.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRefreshUsers.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnRefreshUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRefreshUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRefreshUsers.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnRefreshUsers.Location = new System.Drawing.Point(550, 375);
			this.btnRefreshUsers.Name = "btnRefreshUsers";
			this.btnRefreshUsers.Size = new System.Drawing.Size(80, 25);
			this.btnRefreshUsers.TabIndex = 88;
			this.btnRefreshUsers.Text = "Refresh";
			this.btnRefreshUsers.UseVisualStyleBackColor = false;
			this.btnRefreshUsers.Click += new System.EventHandler(this.BtnRefreshUsersClick);
			// 
			// ticket_id
			// 
			this.ticket_id.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ticket_id.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ticket_id.Location = new System.Drawing.Point(150, 375);
			this.ticket_id.Name = "ticket_id";
			this.ticket_id.Size = new System.Drawing.Size(385, 25);
			this.ticket_id.TabIndex = 89;
			this.ticket_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormTicket
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(879, 628);
			this.Controls.Add(this.ticket_id);
			this.Controls.Add(this.btnRefreshUsers);
			this.Controls.Add(this.price);
			this.Controls.Add(this.labelprice);
			this.Controls.Add(this.to_id);
			this.Controls.Add(this.from_id);
			this.Controls.Add(this.user_id);
			this.Controls.Add(this.boarding);
			this.Controls.Add(this.date);
			this.Controls.Add(this.ticket_class);
			this.Controls.Add(this.seat);
			this.Controls.Add(this.labelseat);
			this.Controls.Add(this.launch_gate);
			this.Controls.Add(this.labellaunch_gate);
			this.Controls.Add(this.label_spacecraft);
			this.Controls.Add(this.labeluser_id);
			this.Controls.Add(this.label_boarding);
			this.Controls.Add(this.labelticket_id);
			this.Controls.Add(this.labeldate);
			this.Controls.Add(this.labeldestination_star);
			this.Controls.Add(this.labelfrom_star);
			this.Controls.Add(this.btnUbahTicket);
			this.Controls.Add(this.btnHapusTicket);
			this.Controls.Add(this.btnTambahTicket);
			this.Controls.Add(this.dataGridViewTicket);
			this.Controls.Add(this.labelTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormTicket";
			this.Text = "interXtellar || CRUD Ticket";
			this.Load += new System.EventHandler(this.FormTicketLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicket)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label ticket_id;
		private System.Windows.Forms.Button btnRefreshUsers;
		private System.Windows.Forms.Label price;
		private System.Windows.Forms.Label labelprice;
		private System.Windows.Forms.ComboBox to_id;
		private System.Windows.Forms.ComboBox from_id;
		private System.Windows.Forms.ComboBox user_id;
		private System.Windows.Forms.DateTimePicker boarding;
		private System.Windows.Forms.DateTimePicker date;
		private System.Windows.Forms.ComboBox ticket_class;
		private System.Windows.Forms.Label labelseat;
		private System.Windows.Forms.TextBox seat;
		private System.Windows.Forms.Label labellaunch_gate;
		private System.Windows.Forms.TextBox launch_gate;
		private System.Windows.Forms.Label label_spacecraft;
		private System.Windows.Forms.Label labelfrom_star;
		private System.Windows.Forms.Label labeldestination_star;
		private System.Windows.Forms.Label labeldate;
		private System.Windows.Forms.Label labelticket_id;
		private System.Windows.Forms.Label label_boarding;
		private System.Windows.Forms.Label labeluser_id;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.DataGridView dataGridViewTicket;
		private System.Windows.Forms.Button btnTambahTicket;
		private System.Windows.Forms.Button btnHapusTicket;
		private System.Windows.Forms.Button btnUbahTicket;
	}
}
