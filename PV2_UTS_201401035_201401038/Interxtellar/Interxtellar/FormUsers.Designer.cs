/*
 * Created by SharpDevelop.
 * User: ariel
 * Date: 17/12/2021
 * Time: 10:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Interxtellar
{
	partial class FormUsers
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
			this.labelTitle = new System.Windows.Forms.Label();
			this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
			this.btnUbahUsers = new System.Windows.Forms.Button();
			this.btnHapusUsers = new System.Windows.Forms.Button();
			this.labeluser_id = new System.Windows.Forms.Label();
			this.btnTambahUsers = new System.Windows.Forms.Button();
			this.password = new System.Windows.Forms.TextBox();
			this.username = new System.Windows.Forms.TextBox();
			this.email = new System.Windows.Forms.TextBox();
			this.full_name = new System.Windows.Forms.TextBox();
			this.labelpassword = new System.Windows.Forms.Label();
			this.labelusername = new System.Windows.Forms.Label();
			this.labelemail = new System.Windows.Forms.Label();
			this.labelfull_name = new System.Windows.Forms.Label();
			this.user_id = new System.Windows.Forms.Label();
			this.btnRefreshUsers = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.Location = new System.Drawing.Point(15, 15);
			this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(740, 30);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Halaman CRUD Tabel Users";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.dataGridViewUsers.Location = new System.Drawing.Point(15, 60);
			this.dataGridViewUsers.Name = "dataGridViewUsers";
			this.dataGridViewUsers.ReadOnly = true;
			this.dataGridViewUsers.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dataGridViewUsers.RowHeadersWidth = 25;
			this.dataGridViewUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewUsers.Size = new System.Drawing.Size(850, 300);
			this.dataGridViewUsers.TabIndex = 2;
			this.dataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewUsersCellContentClick);
			// 
			// btnUbahUsers
			// 
			this.btnUbahUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btnUbahUsers.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUbahUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUbahUsers.Location = new System.Drawing.Point(700, 437);
			this.btnUbahUsers.Name = "btnUbahUsers";
			this.btnUbahUsers.Size = new System.Drawing.Size(130, 40);
			this.btnUbahUsers.TabIndex = 28;
			this.btnUbahUsers.Text = "Ubah";
			this.btnUbahUsers.UseVisualStyleBackColor = false;
			this.btnUbahUsers.Click += new System.EventHandler(this.BtnUbahUsersClick);
			// 
			// btnHapusUsers
			// 
			this.btnHapusUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnHapusUsers.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnHapusUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHapusUsers.Location = new System.Drawing.Point(700, 500);
			this.btnHapusUsers.Name = "btnHapusUsers";
			this.btnHapusUsers.Size = new System.Drawing.Size(130, 40);
			this.btnHapusUsers.TabIndex = 27;
			this.btnHapusUsers.Text = "Hapus";
			this.btnHapusUsers.UseVisualStyleBackColor = false;
			this.btnHapusUsers.Click += new System.EventHandler(this.BtnHapusUsersClick);
			// 
			// labeluser_id
			// 
			this.labeluser_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labeluser_id.Location = new System.Drawing.Point(50, 375);
			this.labeluser_id.Name = "labeluser_id";
			this.labeluser_id.Size = new System.Drawing.Size(90, 25);
			this.labeluser_id.TabIndex = 25;
			this.labeluser_id.Text = "User ID";
			this.labeluser_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnTambahUsers
			// 
			this.btnTambahUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnTambahUsers.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTambahUsers.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnTambahUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTambahUsers.Location = new System.Drawing.Point(700, 375);
			this.btnTambahUsers.Name = "btnTambahUsers";
			this.btnTambahUsers.Size = new System.Drawing.Size(130, 40);
			this.btnTambahUsers.TabIndex = 24;
			this.btnTambahUsers.Text = "Tambah";
			this.btnTambahUsers.UseVisualStyleBackColor = false;
			this.btnTambahUsers.Click += new System.EventHandler(this.BtnTambahUsersClick);
			// 
			// password
			// 
			this.password.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password.Location = new System.Drawing.Point(150, 515);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(350, 25);
			this.password.TabIndex = 23;
			// 
			// username
			// 
			this.username.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.username.Location = new System.Drawing.Point(150, 480);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(350, 25);
			this.username.TabIndex = 22;
			// 
			// email
			// 
			this.email.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.email.Location = new System.Drawing.Point(150, 445);
			this.email.Name = "email";
			this.email.Size = new System.Drawing.Size(350, 25);
			this.email.TabIndex = 21;
			// 
			// full_name
			// 
			this.full_name.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.full_name.Location = new System.Drawing.Point(150, 410);
			this.full_name.Name = "full_name";
			this.full_name.Size = new System.Drawing.Size(350, 25);
			this.full_name.TabIndex = 20;
			// 
			// labelpassword
			// 
			this.labelpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelpassword.Location = new System.Drawing.Point(50, 515);
			this.labelpassword.Name = "labelpassword";
			this.labelpassword.Size = new System.Drawing.Size(90, 25);
			this.labelpassword.TabIndex = 19;
			this.labelpassword.Text = "Password";
			this.labelpassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelusername
			// 
			this.labelusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelusername.Location = new System.Drawing.Point(50, 480);
			this.labelusername.Name = "labelusername";
			this.labelusername.Size = new System.Drawing.Size(90, 25);
			this.labelusername.TabIndex = 18;
			this.labelusername.Text = "Username";
			this.labelusername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelemail
			// 
			this.labelemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelemail.Location = new System.Drawing.Point(50, 445);
			this.labelemail.Name = "labelemail";
			this.labelemail.Size = new System.Drawing.Size(90, 25);
			this.labelemail.TabIndex = 17;
			this.labelemail.Text = "Email";
			this.labelemail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelfull_name
			// 
			this.labelfull_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelfull_name.Location = new System.Drawing.Point(50, 410);
			this.labelfull_name.Name = "labelfull_name";
			this.labelfull_name.Size = new System.Drawing.Size(90, 25);
			this.labelfull_name.TabIndex = 16;
			this.labelfull_name.Text = "Full Name";
			this.labelfull_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// user_id
			// 
			this.user_id.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.user_id.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.user_id.Location = new System.Drawing.Point(150, 375);
			this.user_id.Name = "user_id";
			this.user_id.Size = new System.Drawing.Size(350, 25);
			this.user_id.TabIndex = 29;
			this.user_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnRefreshUsers
			// 
			this.btnRefreshUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
			this.btnRefreshUsers.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRefreshUsers.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnRefreshUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRefreshUsers.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnRefreshUsers.Location = new System.Drawing.Point(540, 375);
			this.btnRefreshUsers.Name = "btnRefreshUsers";
			this.btnRefreshUsers.Size = new System.Drawing.Size(130, 40);
			this.btnRefreshUsers.TabIndex = 31;
			this.btnRefreshUsers.Text = "Refresh";
			this.btnRefreshUsers.UseVisualStyleBackColor = false;
			this.btnRefreshUsers.Click += new System.EventHandler(this.BtnRefreshUsersClick);
			// 
			// FormUsers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(879, 561);
			this.Controls.Add(this.btnRefreshUsers);
			this.Controls.Add(this.user_id);
			this.Controls.Add(this.btnUbahUsers);
			this.Controls.Add(this.btnHapusUsers);
			this.Controls.Add(this.labeluser_id);
			this.Controls.Add(this.btnTambahUsers);
			this.Controls.Add(this.password);
			this.Controls.Add(this.username);
			this.Controls.Add(this.email);
			this.Controls.Add(this.full_name);
			this.Controls.Add(this.labelpassword);
			this.Controls.Add(this.labelusername);
			this.Controls.Add(this.labelemail);
			this.Controls.Add(this.labelfull_name);
			this.Controls.Add(this.dataGridViewUsers);
			this.Controls.Add(this.labelTitle);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormUsers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CRUD Users";
			this.Load += new System.EventHandler(this.FormUsersLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnRefreshUsers;
		private System.Windows.Forms.Label user_id;
		private System.Windows.Forms.Label labelfull_name;
		private System.Windows.Forms.Label labelemail;
		private System.Windows.Forms.Label labelusername;
		private System.Windows.Forms.Label labelpassword;
		private System.Windows.Forms.TextBox full_name;
		private System.Windows.Forms.TextBox email;
		private System.Windows.Forms.TextBox username;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.Button btnTambahUsers;
		private System.Windows.Forms.Label labeluser_id;
		private System.Windows.Forms.Button btnHapusUsers;
		private System.Windows.Forms.Button btnUbahUsers;
		private System.Windows.Forms.DataGridView dataGridViewUsers;
		private System.Windows.Forms.Label labelTitle;
	}
}
