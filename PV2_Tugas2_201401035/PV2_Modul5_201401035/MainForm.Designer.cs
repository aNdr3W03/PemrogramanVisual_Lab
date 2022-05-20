/*
 * Created by SharpDevelop.
 * User: HP
 * Date: Rab, 18 Mei 2022
 * Time: 00.52.05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PV2_Modul5_201401035
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
			this.labelUpload = new System.Windows.Forms.Label();
			this.btnUpOpenFile = new System.Windows.Forms.Button();
			this.btnUpSaveFile = new System.Windows.Forms.Button();
			this.btnDwOpenFile = new System.Windows.Forms.Button();
			this.btnDwSaveFile = new System.Windows.Forms.Button();
			this.labelDownload = new System.Windows.Forms.Label();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.labelIdGambar = new System.Windows.Forms.Label();
			this.labelTitleTable = new System.Windows.Forms.Label();
			this.pictureBoxUpload = new System.Windows.Forms.PictureBox();
			this.pictureBoxDownload = new System.Windows.Forms.PictureBox();
			this.comboBoxId = new System.Windows.Forms.ComboBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpload)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownload)).BeginInit();
			this.SuspendLayout();
			// 
			// labelUpload
			// 
			this.labelUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.labelUpload.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelUpload.Location = new System.Drawing.Point(25, 25);
			this.labelUpload.Name = "labelUpload";
			this.labelUpload.Size = new System.Drawing.Size(220, 25);
			this.labelUpload.TabIndex = 0;
			this.labelUpload.Text = "Upload File";
			this.labelUpload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnUpOpenFile
			// 
			this.btnUpOpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUpOpenFile.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpOpenFile.Location = new System.Drawing.Point(25, 235);
			this.btnUpOpenFile.Name = "btnUpOpenFile";
			this.btnUpOpenFile.Size = new System.Drawing.Size(100, 25);
			this.btnUpOpenFile.TabIndex = 3;
			this.btnUpOpenFile.Text = "Open File";
			this.btnUpOpenFile.UseVisualStyleBackColor = true;
			this.btnUpOpenFile.Click += new System.EventHandler(this.BtnUpOpenFileClick);
			// 
			// btnUpSaveFile
			// 
			this.btnUpSaveFile.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUpSaveFile.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpSaveFile.Location = new System.Drawing.Point(145, 235);
			this.btnUpSaveFile.Name = "btnUpSaveFile";
			this.btnUpSaveFile.Size = new System.Drawing.Size(100, 25);
			this.btnUpSaveFile.TabIndex = 4;
			this.btnUpSaveFile.Text = "Upload File";
			this.btnUpSaveFile.UseVisualStyleBackColor = true;
			this.btnUpSaveFile.Click += new System.EventHandler(this.BtnUpSaveFileClick);
			// 
			// btnDwOpenFile
			// 
			this.btnDwOpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDwOpenFile.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDwOpenFile.Location = new System.Drawing.Point(285, 235);
			this.btnDwOpenFile.Name = "btnDwOpenFile";
			this.btnDwOpenFile.Size = new System.Drawing.Size(100, 25);
			this.btnDwOpenFile.TabIndex = 5;
			this.btnDwOpenFile.Text = "Open File";
			this.btnDwOpenFile.UseVisualStyleBackColor = true;
			this.btnDwOpenFile.Click += new System.EventHandler(this.BtnDwOpenFileClick);
			// 
			// btnDwSaveFile
			// 
			this.btnDwSaveFile.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDwSaveFile.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDwSaveFile.Location = new System.Drawing.Point(405, 235);
			this.btnDwSaveFile.Name = "btnDwSaveFile";
			this.btnDwSaveFile.Size = new System.Drawing.Size(100, 25);
			this.btnDwSaveFile.TabIndex = 6;
			this.btnDwSaveFile.Text = "Download";
			this.btnDwSaveFile.UseVisualStyleBackColor = true;
			this.btnDwSaveFile.Click += new System.EventHandler(this.BtnDwSaveFileClick);
			// 
			// labelDownload
			// 
			this.labelDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.labelDownload.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDownload.Location = new System.Drawing.Point(285, 25);
			this.labelDownload.Name = "labelDownload";
			this.labelDownload.Size = new System.Drawing.Size(220, 25);
			this.labelDownload.TabIndex = 7;
			this.labelDownload.Text = "Download File";
			this.labelDownload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridView
			// 
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
			this.dataGridView.ColumnHeadersHeight = 25;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridView.Location = new System.Drawing.Point(25, 310);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowHeadersWidth = 25;
			this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(480, 160);
			this.dataGridView.TabIndex = 8;
			// 
			// labelIdGambar
			// 
			this.labelIdGambar.BackColor = System.Drawing.Color.Teal;
			this.labelIdGambar.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelIdGambar.ForeColor = System.Drawing.Color.White;
			this.labelIdGambar.Location = new System.Drawing.Point(285, 200);
			this.labelIdGambar.Name = "labelIdGambar";
			this.labelIdGambar.Size = new System.Drawing.Size(100, 20);
			this.labelIdGambar.TabIndex = 9;
			this.labelIdGambar.Text = "ID Gambar";
			this.labelIdGambar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelTitleTable
			// 
			this.labelTitleTable.BackColor = System.Drawing.Color.Gray;
			this.labelTitleTable.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitleTable.ForeColor = System.Drawing.Color.White;
			this.labelTitleTable.Location = new System.Drawing.Point(25, 285);
			this.labelTitleTable.Name = "labelTitleTable";
			this.labelTitleTable.Size = new System.Drawing.Size(480, 25);
			this.labelTitleTable.TabIndex = 10;
			this.labelTitleTable.Text = "Database: pvfile; Table: filegambar";
			this.labelTitleTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBoxUpload
			// 
			this.pictureBoxUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.pictureBoxUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBoxUpload.Location = new System.Drawing.Point(25, 50);
			this.pictureBoxUpload.Name = "pictureBoxUpload";
			this.pictureBoxUpload.Size = new System.Drawing.Size(220, 170);
			this.pictureBoxUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxUpload.TabIndex = 11;
			this.pictureBoxUpload.TabStop = false;
			// 
			// pictureBoxDownload
			// 
			this.pictureBoxDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.pictureBoxDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBoxDownload.Location = new System.Drawing.Point(285, 50);
			this.pictureBoxDownload.Name = "pictureBoxDownload";
			this.pictureBoxDownload.Size = new System.Drawing.Size(220, 170);
			this.pictureBoxDownload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxDownload.TabIndex = 12;
			this.pictureBoxDownload.TabStop = false;
			// 
			// comboBoxId
			// 
			this.comboBoxId.Cursor = System.Windows.Forms.Cursors.Hand;
			this.comboBoxId.Font = new System.Drawing.Font("Consolas", 7.5F);
			this.comboBoxId.FormattingEnabled = true;
			this.comboBoxId.Location = new System.Drawing.Point(385, 200);
			this.comboBoxId.Name = "comboBoxId";
			this.comboBoxId.Size = new System.Drawing.Size(120, 20);
			this.comboBoxId.TabIndex = 13;
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(534, 491);
			this.Controls.Add(this.comboBoxId);
			this.Controls.Add(this.pictureBoxUpload);
			this.Controls.Add(this.labelTitleTable);
			this.Controls.Add(this.labelIdGambar);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.labelDownload);
			this.Controls.Add(this.btnDwSaveFile);
			this.Controls.Add(this.btnDwOpenFile);
			this.Controls.Add(this.btnUpSaveFile);
			this.Controls.Add(this.btnUpOpenFile);
			this.Controls.Add(this.labelUpload);
			this.Controls.Add(this.pictureBoxDownload);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PV2_Modul5_201401035";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpload)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownload)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.ComboBox comboBoxId;
		private System.Windows.Forms.PictureBox pictureBoxDownload;
		private System.Windows.Forms.PictureBox pictureBoxUpload;
		private System.Windows.Forms.Label labelTitleTable;
		private System.Windows.Forms.Label labelIdGambar;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button btnDwSaveFile;
		private System.Windows.Forms.Button btnDwOpenFile;
		private System.Windows.Forms.Button btnUpSaveFile;
		private System.Windows.Forms.Button btnUpOpenFile;
		private System.Windows.Forms.Label labelDownload;
		private System.Windows.Forms.Label labelUpload;
	}
}
