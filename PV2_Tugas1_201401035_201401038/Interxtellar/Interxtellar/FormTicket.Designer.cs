/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 17 Des 2021
 * Time: 14.52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Interxtellar
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
			this.btnUbahTicket = new System.Windows.Forms.Button();
			this.btnHapusTicket = new System.Windows.Forms.Button();
			this.btnTambahTicket = new System.Windows.Forms.Button();
			this.dataGridViewTicket = new System.Windows.Forms.DataGridView();
			this.labelTitle = new System.Windows.Forms.Label();
			this.user_id = new System.Windows.Forms.TextBox();
			this.labeluser_id = new System.Windows.Forms.Label();
			this.boarding = new System.Windows.Forms.TextBox();
			this.label_boarding = new System.Windows.Forms.Label();
			this.ticket_id = new System.Windows.Forms.TextBox();
			this.labelticket_id = new System.Windows.Forms.Label();
			this.date = new System.Windows.Forms.TextBox();
			this.to_id = new System.Windows.Forms.TextBox();
			this.from_id = new System.Windows.Forms.TextBox();
			this.labeldate = new System.Windows.Forms.Label();
			this.labeldestination_star = new System.Windows.Forms.Label();
			this.labelfrom_star = new System.Windows.Forms.Label();
			this.ticket_class = new System.Windows.Forms.TextBox();
			this.label_spacecraft = new System.Windows.Forms.Label();
			this.launch_gate = new System.Windows.Forms.TextBox();
			this.labellaunch_gate = new System.Windows.Forms.Label();
			this.seat = new System.Windows.Forms.TextBox();
			this.labelseat = new System.Windows.Forms.Label();
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
			this.dataGridViewTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridViewTicket.BackgroundColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTicket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTicket.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			// user_id
			// 
			this.user_id.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.user_id.Location = new System.Drawing.Point(150, 410);
			this.user_id.Name = "user_id";
			this.user_id.Size = new System.Drawing.Size(480, 25);
			this.user_id.TabIndex = 72;
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
			// boarding
			// 
			this.boarding.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.boarding.Location = new System.Drawing.Point(480, 515);
			this.boarding.Name = "boarding";
			this.boarding.Size = new System.Drawing.Size(150, 25);
			this.boarding.TabIndex = 70;
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
			// ticket_id
			// 
			this.ticket_id.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ticket_id.Location = new System.Drawing.Point(150, 375);
			this.ticket_id.Name = "ticket_id";
			this.ticket_id.Size = new System.Drawing.Size(480, 25);
			this.ticket_id.TabIndex = 64;
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
			// date
			// 
			this.date.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.date.Location = new System.Drawing.Point(150, 515);
			this.date.Name = "date";
			this.date.Size = new System.Drawing.Size(150, 25);
			this.date.TabIndex = 61;
			// 
			// to_id
			// 
			this.to_id.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.to_id.Location = new System.Drawing.Point(150, 480);
			this.to_id.Name = "to_id";
			this.to_id.Size = new System.Drawing.Size(480, 25);
			this.to_id.TabIndex = 60;
			// 
			// from_id
			// 
			this.from_id.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.from_id.Location = new System.Drawing.Point(150, 445);
			this.from_id.Name = "from_id";
			this.from_id.Size = new System.Drawing.Size(480, 25);
			this.from_id.TabIndex = 59;
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
			// ticket_class
			// 
			this.ticket_class.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ticket_class.Location = new System.Drawing.Point(150, 549);
			this.ticket_class.Name = "ticket_class";
			this.ticket_class.Size = new System.Drawing.Size(150, 25);
			this.ticket_class.TabIndex = 74;
			// 
			// label_spacecraft
			// 
			this.label_spacecraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_spacecraft.Location = new System.Drawing.Point(50, 549);
			this.label_spacecraft.Name = "label_spacecraft";
			this.label_spacecraft.Size = new System.Drawing.Size(90, 25);
			this.label_spacecraft.TabIndex = 73;
			this.label_spacecraft.Text = "Class";
			this.label_spacecraft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// launch_gate
			// 
			this.launch_gate.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.launch_gate.Location = new System.Drawing.Point(480, 548);
			this.launch_gate.Name = "launch_gate";
			this.launch_gate.Size = new System.Drawing.Size(150, 25);
			this.launch_gate.TabIndex = 76;
			// 
			// labellaunch_gate
			// 
			this.labellaunch_gate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labellaunch_gate.Location = new System.Drawing.Point(380, 548);
			this.labellaunch_gate.Name = "labellaunch_gate";
			this.labellaunch_gate.Size = new System.Drawing.Size(90, 25);
			this.labellaunch_gate.TabIndex = 75;
			this.labellaunch_gate.Text = "Launch Gate";
			this.labellaunch_gate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// seat
			// 
			this.seat.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.seat.Location = new System.Drawing.Point(150, 587);
			this.seat.Name = "seat";
			this.seat.Size = new System.Drawing.Size(150, 25);
			this.seat.TabIndex = 78;
			// 
			// labelseat
			// 
			this.labelseat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelseat.Location = new System.Drawing.Point(50, 587);
			this.labelseat.Name = "labelseat";
			this.labelseat.Size = new System.Drawing.Size(90, 25);
			this.labelseat.TabIndex = 77;
			this.labelseat.Text = "Seat";
			this.labelseat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormTicket
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(879, 628);
			this.Controls.Add(this.seat);
			this.Controls.Add(this.labelseat);
			this.Controls.Add(this.launch_gate);
			this.Controls.Add(this.labellaunch_gate);
			this.Controls.Add(this.ticket_class);
			this.Controls.Add(this.label_spacecraft);
			this.Controls.Add(this.user_id);
			this.Controls.Add(this.labeluser_id);
			this.Controls.Add(this.boarding);
			this.Controls.Add(this.label_boarding);
			this.Controls.Add(this.ticket_id);
			this.Controls.Add(this.labelticket_id);
			this.Controls.Add(this.date);
			this.Controls.Add(this.to_id);
			this.Controls.Add(this.from_id);
			this.Controls.Add(this.labeldate);
			this.Controls.Add(this.labeldestination_star);
			this.Controls.Add(this.labelfrom_star);
			this.Controls.Add(this.btnUbahTicket);
			this.Controls.Add(this.btnHapusTicket);
			this.Controls.Add(this.btnTambahTicket);
			this.Controls.Add(this.dataGridViewTicket);
			this.Controls.Add(this.labelTitle);
			this.Name = "FormTicket";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CRUD Ticket";
			this.Load += new System.EventHandler(this.FormTicketLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicket)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label labelseat;
		private System.Windows.Forms.TextBox seat;
		private System.Windows.Forms.Label labellaunch_gate;
		private System.Windows.Forms.TextBox launch_gate;
		private System.Windows.Forms.Label label_spacecraft;
		private System.Windows.Forms.TextBox ticket_class;
		private System.Windows.Forms.Label labelfrom_star;
		private System.Windows.Forms.Label labeldestination_star;
		private System.Windows.Forms.Label labeldate;
		private System.Windows.Forms.TextBox from_id;
		private System.Windows.Forms.TextBox to_id;
		private System.Windows.Forms.TextBox date;
		private System.Windows.Forms.Label labelticket_id;
		private System.Windows.Forms.TextBox ticket_id;
		private System.Windows.Forms.Label label_boarding;
		private System.Windows.Forms.TextBox boarding;
		private System.Windows.Forms.Label labeluser_id;
		private System.Windows.Forms.TextBox user_id;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.DataGridView dataGridViewTicket;
		private System.Windows.Forms.Button btnTambahTicket;
		private System.Windows.Forms.Button btnHapusTicket;
		private System.Windows.Forms.Button btnUbahTicket;
	}
}
