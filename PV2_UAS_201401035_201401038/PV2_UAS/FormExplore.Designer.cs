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
	partial class FormExplore
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExplore));
			this.btnUbahExplore = new System.Windows.Forms.Button();
			this.btnHapusExplore = new System.Windows.Forms.Button();
			this.btnTambahExplore = new System.Windows.Forms.Button();
			this.dataGridViewExplore = new System.Windows.Forms.DataGridView();
			this.labelTitle = new System.Windows.Forms.Label();
			this.object_id = new System.Windows.Forms.TextBox();
			this.labelobject = new System.Windows.Forms.Label();
			this.price = new System.Windows.Forms.TextBox();
			this.label_price = new System.Windows.Forms.Label();
			this.travel_time = new System.Windows.Forms.TextBox();
			this.labeltraveltime = new System.Windows.Forms.Label();
			this.distance = new System.Windows.Forms.TextBox();
			this.labeldistance = new System.Windows.Forms.Label();
			this.explore_id = new System.Windows.Forms.TextBox();
			this.labelexplore_id = new System.Windows.Forms.Label();
			this.period = new System.Windows.Forms.TextBox();
			this.radius = new System.Windows.Forms.TextBox();
			this.mass = new System.Windows.Forms.TextBox();
			this.star = new System.Windows.Forms.TextBox();
			this.labelperiod = new System.Windows.Forms.Label();
			this.labelradius = new System.Windows.Forms.Label();
			this.labelmass = new System.Windows.Forms.Label();
			this.labelstar = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewExplore)).BeginInit();
			this.SuspendLayout();
			// 
			// btnUbahExplore
			// 
			this.btnUbahExplore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btnUbahExplore.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUbahExplore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUbahExplore.Location = new System.Drawing.Point(700, 437);
			this.btnUbahExplore.Name = "btnUbahExplore";
			this.btnUbahExplore.Size = new System.Drawing.Size(130, 40);
			this.btnUbahExplore.TabIndex = 34;
			this.btnUbahExplore.Text = "Ubah";
			this.btnUbahExplore.UseVisualStyleBackColor = false;
			this.btnUbahExplore.Click += new System.EventHandler(this.BtnUbahExploreClick);
			// 
			// btnHapusExplore
			// 
			this.btnHapusExplore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnHapusExplore.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnHapusExplore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHapusExplore.Location = new System.Drawing.Point(700, 500);
			this.btnHapusExplore.Name = "btnHapusExplore";
			this.btnHapusExplore.Size = new System.Drawing.Size(130, 40);
			this.btnHapusExplore.TabIndex = 33;
			this.btnHapusExplore.Text = "Hapus";
			this.btnHapusExplore.UseVisualStyleBackColor = false;
			this.btnHapusExplore.Click += new System.EventHandler(this.BtnHapusExploreClick);
			// 
			// btnTambahExplore
			// 
			this.btnTambahExplore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnTambahExplore.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTambahExplore.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnTambahExplore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTambahExplore.Location = new System.Drawing.Point(700, 375);
			this.btnTambahExplore.Name = "btnTambahExplore";
			this.btnTambahExplore.Size = new System.Drawing.Size(130, 40);
			this.btnTambahExplore.TabIndex = 32;
			this.btnTambahExplore.Text = "Tambah";
			this.btnTambahExplore.UseVisualStyleBackColor = false;
			this.btnTambahExplore.Click += new System.EventHandler(this.BtnTambahExploreClick);
			// 
			// dataGridViewExplore
			// 
			this.dataGridViewExplore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
			this.dataGridViewExplore.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewExplore.BackgroundColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 10F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewExplore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewExplore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExplore.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 10F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewExplore.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewExplore.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridViewExplore.Location = new System.Drawing.Point(15, 60);
			this.dataGridViewExplore.Name = "dataGridViewExplore";
			this.dataGridViewExplore.ReadOnly = true;
			this.dataGridViewExplore.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dataGridViewExplore.RowHeadersWidth = 25;
			this.dataGridViewExplore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridViewExplore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExplore.Size = new System.Drawing.Size(850, 300);
			this.dataGridViewExplore.TabIndex = 31;
			this.dataGridViewExplore.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewExploreCellContentClick);
			// 
			// labelTitle
			// 
			this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.Location = new System.Drawing.Point(15, 15);
			this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(740, 30);
			this.labelTitle.TabIndex = 30;
			this.labelTitle.Text = "Halaman CRUD Tabel Explore";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// object_id
			// 
			this.object_id.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.object_id.Location = new System.Drawing.Point(150, 410);
			this.object_id.Name = "object_id";
			this.object_id.Size = new System.Drawing.Size(150, 25);
			this.object_id.TabIndex = 72;
			// 
			// labelobject
			// 
			this.labelobject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelobject.Location = new System.Drawing.Point(50, 410);
			this.labelobject.Name = "labelobject";
			this.labelobject.Size = new System.Drawing.Size(90, 25);
			this.labelobject.TabIndex = 71;
			this.labelobject.Text = "Object";
			this.labelobject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// price
			// 
			this.price.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.price.Location = new System.Drawing.Point(480, 515);
			this.price.Name = "price";
			this.price.Size = new System.Drawing.Size(150, 25);
			this.price.TabIndex = 70;
			this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceKeyPress);
			// 
			// label_price
			// 
			this.label_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_price.Location = new System.Drawing.Point(380, 515);
			this.label_price.Name = "label_price";
			this.label_price.Size = new System.Drawing.Size(90, 25);
			this.label_price.TabIndex = 69;
			this.label_price.Text = "Price";
			this.label_price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// travel_time
			// 
			this.travel_time.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.travel_time.Location = new System.Drawing.Point(480, 480);
			this.travel_time.Name = "travel_time";
			this.travel_time.Size = new System.Drawing.Size(150, 25);
			this.travel_time.TabIndex = 68;
			this.travel_time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Travel_timeKeyPress);
			// 
			// labeltraveltime
			// 
			this.labeltraveltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labeltraveltime.Location = new System.Drawing.Point(380, 480);
			this.labeltraveltime.Name = "labeltraveltime";
			this.labeltraveltime.Size = new System.Drawing.Size(90, 25);
			this.labeltraveltime.TabIndex = 67;
			this.labeltraveltime.Text = "Travel Time";
			this.labeltraveltime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// distance
			// 
			this.distance.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.distance.Location = new System.Drawing.Point(480, 445);
			this.distance.Name = "distance";
			this.distance.Size = new System.Drawing.Size(150, 25);
			this.distance.TabIndex = 66;
			this.distance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DistanceKeyPress);
			// 
			// labeldistance
			// 
			this.labeldistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labeldistance.Location = new System.Drawing.Point(380, 445);
			this.labeldistance.Name = "labeldistance";
			this.labeldistance.Size = new System.Drawing.Size(90, 25);
			this.labeldistance.TabIndex = 65;
			this.labeldistance.Text = "Distance";
			this.labeldistance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// explore_id
			// 
			this.explore_id.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.explore_id.Location = new System.Drawing.Point(150, 375);
			this.explore_id.Name = "explore_id";
			this.explore_id.Size = new System.Drawing.Size(480, 25);
			this.explore_id.TabIndex = 64;
			// 
			// labelexplore_id
			// 
			this.labelexplore_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelexplore_id.Location = new System.Drawing.Point(50, 375);
			this.labelexplore_id.Name = "labelexplore_id";
			this.labelexplore_id.Size = new System.Drawing.Size(90, 25);
			this.labelexplore_id.TabIndex = 63;
			this.labelexplore_id.Text = "Explore ID";
			this.labelexplore_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// period
			// 
			this.period.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.period.Location = new System.Drawing.Point(480, 410);
			this.period.Name = "period";
			this.period.Size = new System.Drawing.Size(150, 25);
			this.period.TabIndex = 62;
			this.period.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PeriodKeyPress);
			// 
			// radius
			// 
			this.radius.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radius.Location = new System.Drawing.Point(150, 515);
			this.radius.Name = "radius";
			this.radius.Size = new System.Drawing.Size(150, 25);
			this.radius.TabIndex = 61;
			this.radius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RadiusKeyPress);
			// 
			// mass
			// 
			this.mass.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mass.Location = new System.Drawing.Point(150, 480);
			this.mass.Name = "mass";
			this.mass.Size = new System.Drawing.Size(150, 25);
			this.mass.TabIndex = 60;
			this.mass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MassKeyPress);
			// 
			// star
			// 
			this.star.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.star.Location = new System.Drawing.Point(150, 445);
			this.star.Name = "star";
			this.star.Size = new System.Drawing.Size(150, 25);
			this.star.TabIndex = 59;
			// 
			// labelperiod
			// 
			this.labelperiod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelperiod.Location = new System.Drawing.Point(380, 410);
			this.labelperiod.Name = "labelperiod";
			this.labelperiod.Size = new System.Drawing.Size(90, 25);
			this.labelperiod.TabIndex = 58;
			this.labelperiod.Text = "Period";
			this.labelperiod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelradius
			// 
			this.labelradius.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelradius.Location = new System.Drawing.Point(50, 515);
			this.labelradius.Name = "labelradius";
			this.labelradius.Size = new System.Drawing.Size(90, 25);
			this.labelradius.TabIndex = 57;
			this.labelradius.Text = "Radius";
			this.labelradius.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelmass
			// 
			this.labelmass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelmass.Location = new System.Drawing.Point(50, 480);
			this.labelmass.Name = "labelmass";
			this.labelmass.Size = new System.Drawing.Size(90, 25);
			this.labelmass.TabIndex = 56;
			this.labelmass.Text = "Mass";
			this.labelmass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelstar
			// 
			this.labelstar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelstar.Location = new System.Drawing.Point(50, 445);
			this.labelstar.Name = "labelstar";
			this.labelstar.Size = new System.Drawing.Size(90, 25);
			this.labelstar.TabIndex = 55;
			this.labelstar.Text = "Star";
			this.labelstar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormExplore
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(879, 561);
			this.Controls.Add(this.object_id);
			this.Controls.Add(this.labelobject);
			this.Controls.Add(this.price);
			this.Controls.Add(this.label_price);
			this.Controls.Add(this.travel_time);
			this.Controls.Add(this.labeltraveltime);
			this.Controls.Add(this.distance);
			this.Controls.Add(this.labeldistance);
			this.Controls.Add(this.explore_id);
			this.Controls.Add(this.labelexplore_id);
			this.Controls.Add(this.period);
			this.Controls.Add(this.radius);
			this.Controls.Add(this.mass);
			this.Controls.Add(this.star);
			this.Controls.Add(this.labelperiod);
			this.Controls.Add(this.labelradius);
			this.Controls.Add(this.labelmass);
			this.Controls.Add(this.labelstar);
			this.Controls.Add(this.btnUbahExplore);
			this.Controls.Add(this.btnHapusExplore);
			this.Controls.Add(this.btnTambahExplore);
			this.Controls.Add(this.dataGridViewExplore);
			this.Controls.Add(this.labelTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormExplore";
			this.Text = "interXtellar || Explore";
			this.Load += new System.EventHandler(this.FormExploreLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewExplore)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label labelstar;
		private System.Windows.Forms.Label labelmass;
		private System.Windows.Forms.Label labelradius;
		private System.Windows.Forms.Label labelperiod;
		private System.Windows.Forms.TextBox star;
		private System.Windows.Forms.TextBox mass;
		private System.Windows.Forms.TextBox radius;
		private System.Windows.Forms.TextBox period;
		private System.Windows.Forms.Label labelexplore_id;
		private System.Windows.Forms.TextBox explore_id;
		private System.Windows.Forms.Label labeldistance;
		private System.Windows.Forms.TextBox distance;
		private System.Windows.Forms.Label labeltraveltime;
		private System.Windows.Forms.TextBox travel_time;
		private System.Windows.Forms.Label label_price;
		private System.Windows.Forms.TextBox price;
		private System.Windows.Forms.Label labelobject;
		private System.Windows.Forms.TextBox object_id;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.DataGridView dataGridViewExplore;
		private System.Windows.Forms.Button btnTambahExplore;
		private System.Windows.Forms.Button btnHapusExplore;
		private System.Windows.Forms.Button btnUbahExplore;
	}
}
