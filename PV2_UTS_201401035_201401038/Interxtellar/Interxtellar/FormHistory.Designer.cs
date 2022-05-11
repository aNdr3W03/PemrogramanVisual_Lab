/*
 * Created by SharpDevelop.
 * User: HP
 * Date: Rab, 11 Mei 2022
 * Time: 11.30.50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Interxtellar
{
	partial class FormHistory
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
			this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
			this.user_id = new System.Windows.Forms.ComboBox();
			this.btnCari = new System.Windows.Forms.Button();
			this.labeltotal = new System.Windows.Forms.Label();
			this.labelViewTotal = new System.Windows.Forms.Label();
			this.full_name = new System.Windows.Forms.Label();
			this.labeluser_id = new System.Windows.Forms.Label();
			this.labelemail = new System.Windows.Forms.Label();
			this.labelfull_name = new System.Windows.Forms.Label();
			this.email = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
			this.labelTitle.Location = new System.Drawing.Point(15, 15);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(740, 30);
			this.labelTitle.TabIndex = 1;
			this.labelTitle.Text = "History Pembelian";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataGridViewHistory
			// 
			this.dataGridViewHistory.AllowUserToAddRows = false;
			this.dataGridViewHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
			this.dataGridViewHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewHistory.BackgroundColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 10F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewHistory.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 10F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewHistory.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewHistory.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridViewHistory.Location = new System.Drawing.Point(15, 170);
			this.dataGridViewHistory.Name = "dataGridViewHistory";
			this.dataGridViewHistory.ReadOnly = true;
			this.dataGridViewHistory.RowHeadersWidth = 25;
			this.dataGridViewHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridViewHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewHistory.Size = new System.Drawing.Size(850, 400);
			this.dataGridViewHistory.TabIndex = 11;
			// 
			// user_id
			// 
			this.user_id.Cursor = System.Windows.Forms.Cursors.Hand;
			this.user_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.user_id.Font = new System.Drawing.Font("Consolas", 10.75F);
			this.user_id.FormattingEnabled = true;
			this.user_id.Location = new System.Drawing.Point(115, 60);
			this.user_id.Name = "user_id";
			this.user_id.Size = new System.Drawing.Size(400, 25);
			this.user_id.TabIndex = 3;
			// 
			// btnCari
			// 
			this.btnCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnCari.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnCari.Location = new System.Drawing.Point(550, 52);
			this.btnCari.Name = "btnCari";
			this.btnCari.Size = new System.Drawing.Size(130, 40);
			this.btnCari.TabIndex = 4;
			this.btnCari.Text = "Cari";
			this.btnCari.UseVisualStyleBackColor = false;
			this.btnCari.Click += new System.EventHandler(this.BtnCariClick);
			// 
			// labeltotal
			// 
			this.labeltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labeltotal.Location = new System.Drawing.Point(520, 590);
			this.labeltotal.Name = "labeltotal";
			this.labeltotal.Size = new System.Drawing.Size(90, 25);
			this.labeltotal.TabIndex = 64;
			this.labeltotal.Text = "Harga Total";
			this.labeltotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelViewTotal
			// 
			this.labelViewTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelViewTotal.Font = new System.Drawing.Font("Consolas", 11.25F);
			this.labelViewTotal.Location = new System.Drawing.Point(635, 590);
			this.labelViewTotal.Name = "labelViewTotal";
			this.labelViewTotal.Size = new System.Drawing.Size(230, 25);
			this.labelViewTotal.TabIndex = 6;
			this.labelViewTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// full_name
			// 
			this.full_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.full_name.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.full_name.Location = new System.Drawing.Point(115, 95);
			this.full_name.Name = "full_name";
			this.full_name.Size = new System.Drawing.Size(400, 25);
			this.full_name.TabIndex = 69;
			this.full_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labeluser_id
			// 
			this.labeluser_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labeluser_id.Location = new System.Drawing.Point(15, 60);
			this.labeluser_id.Name = "labeluser_id";
			this.labeluser_id.Size = new System.Drawing.Size(90, 25);
			this.labeluser_id.TabIndex = 68;
			this.labeluser_id.Text = "User ID";
			this.labeluser_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelemail
			// 
			this.labelemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelemail.Location = new System.Drawing.Point(15, 130);
			this.labelemail.Name = "labelemail";
			this.labelemail.Size = new System.Drawing.Size(90, 25);
			this.labelemail.TabIndex = 67;
			this.labelemail.Text = "Email";
			this.labelemail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelfull_name
			// 
			this.labelfull_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelfull_name.Location = new System.Drawing.Point(15, 95);
			this.labelfull_name.Name = "labelfull_name";
			this.labelfull_name.Size = new System.Drawing.Size(90, 25);
			this.labelfull_name.TabIndex = 66;
			this.labelfull_name.Text = "Full Name";
			this.labelfull_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// email
			// 
			this.email.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.email.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.email.Location = new System.Drawing.Point(115, 130);
			this.email.Name = "email";
			this.email.Size = new System.Drawing.Size(400, 25);
			this.email.TabIndex = 70;
			this.email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormHistory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(879, 628);
			this.Controls.Add(this.email);
			this.Controls.Add(this.full_name);
			this.Controls.Add(this.labeluser_id);
			this.Controls.Add(this.labelemail);
			this.Controls.Add(this.labelfull_name);
			this.Controls.Add(this.labelViewTotal);
			this.Controls.Add(this.labeltotal);
			this.Controls.Add(this.btnCari);
			this.Controls.Add(this.user_id);
			this.Controls.Add(this.dataGridViewHistory);
			this.Controls.Add(this.labelTitle);
			this.Name = "FormHistory";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormHistory";
			this.Load += new System.EventHandler(this.FormHistoryLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label labelfull_name;
		private System.Windows.Forms.Label labelemail;
		private System.Windows.Forms.Label labeluser_id;
		private System.Windows.Forms.Label full_name;
		private System.Windows.Forms.Label email;
		private System.Windows.Forms.Label labelViewTotal;
		private System.Windows.Forms.Label labeltotal;
		private System.Windows.Forms.Button btnCari;
		private System.Windows.Forms.ComboBox user_id;
		private System.Windows.Forms.DataGridView dataGridViewHistory;
		private System.Windows.Forms.Label labelTitle;
	}
}
