/*
 * Created by SharpDevelop.
 * User: Andrew
 * Date: Min, 12 Jun 2022
 * Time: 06.28.04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PV2_UAS
{
	partial class FormAbout
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.labelTitle = new System.Windows.Forms.Label();
			this.labelVersion = new System.Windows.Forms.Label();
			this.labelCopyright = new System.Windows.Forms.Label();
			this.labelBuild = new System.Windows.Forms.Label();
			this.groupBox = new System.Windows.Forms.GroupBox();
			this.linkLabelFasilkomTI = new System.Windows.Forms.LinkLabel();
			this.labelUSU = new System.Windows.Forms.Label();
			this.linkLabelIKLC = new System.Windows.Forms.LinkLabel();
			this.labelIKLC = new System.Windows.Forms.Label();
			this.labelLine2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.labelGitHub2 = new System.Windows.Forms.Label();
			this.labelLinkedin2 = new System.Windows.Forms.Label();
			this.labelEmail2 = new System.Windows.Forms.Label();
			this.labelGitHub1 = new System.Windows.Forms.Label();
			this.labelLinkedin1 = new System.Windows.Forms.Label();
			this.labelEmail1 = new System.Windows.Forms.Label();
			this.linkLabelDevGitHub2 = new System.Windows.Forms.LinkLabel();
			this.linkLabelDevLinkedin2 = new System.Windows.Forms.LinkLabel();
			this.linkLabelDevEmail2 = new System.Windows.Forms.LinkLabel();
			this.linkLabelDevGitHub1 = new System.Windows.Forms.LinkLabel();
			this.linkLabelDevLinkedin1 = new System.Windows.Forms.LinkLabel();
			this.linkLabelDevEmail1 = new System.Windows.Forms.LinkLabel();
			this.labelDevName2 = new System.Windows.Forms.Label();
			this.labelDevName1 = new System.Windows.Forms.Label();
			this.labelLine1 = new System.Windows.Forms.Label();
			this.labelDevTeam = new System.Windows.Forms.Label();
			this.labelAslab = new System.Windows.Forms.Label();
			this.linkLabelRepo = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.groupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox
			// 
			this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
			this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox.Location = new System.Drawing.Point(15, 15);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(105, 105);
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			// 
			// labelTitle
			// 
			this.labelTitle.Font = new System.Drawing.Font("Montserrat SemiBold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.Location = new System.Drawing.Point(140, 15);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(227, 30);
			this.labelTitle.TabIndex = 1;
			this.labelTitle.Text = "interXtellar";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelVersion
			// 
			this.labelVersion.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelVersion.Location = new System.Drawing.Point(140, 50);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(130, 20);
			this.labelVersion.TabIndex = 2;
			this.labelVersion.Text = "Version 3.0";
			this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelCopyright
			// 
			this.labelCopyright.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCopyright.Location = new System.Drawing.Point(140, 100);
			this.labelCopyright.Name = "labelCopyright";
			this.labelCopyright.Size = new System.Drawing.Size(200, 20);
			this.labelCopyright.TabIndex = 3;
			this.labelCopyright.Text = "Copyright © LMAO Project";
			this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelBuild
			// 
			this.labelBuild.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelBuild.Location = new System.Drawing.Point(140, 75);
			this.labelBuild.Name = "labelBuild";
			this.labelBuild.Size = new System.Drawing.Size(130, 20);
			this.labelBuild.TabIndex = 4;
			this.labelBuild.Text = "Build: June 12 2022";
			this.labelBuild.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox
			// 
			this.groupBox.Controls.Add(this.linkLabelFasilkomTI);
			this.groupBox.Controls.Add(this.labelUSU);
			this.groupBox.Controls.Add(this.linkLabelIKLC);
			this.groupBox.Controls.Add(this.labelIKLC);
			this.groupBox.Controls.Add(this.labelLine2);
			this.groupBox.Controls.Add(this.label1);
			this.groupBox.Controls.Add(this.labelGitHub2);
			this.groupBox.Controls.Add(this.labelLinkedin2);
			this.groupBox.Controls.Add(this.labelEmail2);
			this.groupBox.Controls.Add(this.labelGitHub1);
			this.groupBox.Controls.Add(this.labelLinkedin1);
			this.groupBox.Controls.Add(this.labelEmail1);
			this.groupBox.Controls.Add(this.linkLabelDevGitHub2);
			this.groupBox.Controls.Add(this.linkLabelDevLinkedin2);
			this.groupBox.Controls.Add(this.linkLabelDevEmail2);
			this.groupBox.Controls.Add(this.linkLabelDevGitHub1);
			this.groupBox.Controls.Add(this.linkLabelDevLinkedin1);
			this.groupBox.Controls.Add(this.linkLabelDevEmail1);
			this.groupBox.Controls.Add(this.labelDevName2);
			this.groupBox.Controls.Add(this.labelDevName1);
			this.groupBox.Controls.Add(this.labelLine1);
			this.groupBox.Controls.Add(this.labelDevTeam);
			this.groupBox.Controls.Add(this.labelAslab);
			this.groupBox.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox.Location = new System.Drawing.Point(15, 137);
			this.groupBox.Name = "groupBox";
			this.groupBox.Size = new System.Drawing.Size(355, 315);
			this.groupBox.TabIndex = 5;
			this.groupBox.TabStop = false;
			this.groupBox.Text = "Contact Information";
			// 
			// linkLabelFasilkomTI
			// 
			this.linkLabelFasilkomTI.Font = new System.Drawing.Font("Montserrat", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabelFasilkomTI.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.linkLabelFasilkomTI.Location = new System.Drawing.Point(210, 285);
			this.linkLabelFasilkomTI.Name = "linkLabelFasilkomTI";
			this.linkLabelFasilkomTI.Size = new System.Drawing.Size(115, 15);
			this.linkLabelFasilkomTI.TabIndex = 25;
			this.linkLabelFasilkomTI.TabStop = true;
			this.linkLabelFasilkomTI.Text = "fasilkom-ti.usu.ac.id";
			this.linkLabelFasilkomTI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.linkLabelFasilkomTI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelFasilkomTILinkClicked);
			// 
			// labelUSU
			// 
			this.labelUSU.Font = new System.Drawing.Font("Montserrat", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelUSU.Location = new System.Drawing.Point(15, 285);
			this.labelUSU.Name = "labelUSU";
			this.labelUSU.Size = new System.Drawing.Size(180, 15);
			this.labelUSU.TabIndex = 24;
			this.labelUSU.Text = "Universitas Sumatera Utara";
			this.labelUSU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// linkLabelIKLC
			// 
			this.linkLabelIKLC.Font = new System.Drawing.Font("Montserrat", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabelIKLC.Location = new System.Drawing.Point(210, 270);
			this.linkLabelIKLC.Name = "linkLabelIKLC";
			this.linkLabelIKLC.Size = new System.Drawing.Size(115, 15);
			this.linkLabelIKLC.TabIndex = 22;
			this.linkLabelIKLC.TabStop = true;
			this.linkLabelIKLC.Text = "@iklcusu";
			this.linkLabelIKLC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.linkLabelIKLC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelIKLCLinkClicked);
			// 
			// labelIKLC
			// 
			this.labelIKLC.Font = new System.Drawing.Font("Montserrat", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelIKLC.Location = new System.Drawing.Point(15, 270);
			this.labelIKLC.Name = "labelIKLC";
			this.labelIKLC.Size = new System.Drawing.Size(180, 15);
			this.labelIKLC.TabIndex = 20;
			this.labelIKLC.Text = "Ilmu Komputer Laboratory Center";
			this.labelIKLC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelLine2
			// 
			this.labelLine2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelLine2.Location = new System.Drawing.Point(15, 260);
			this.labelLine2.Name = "labelLine2";
			this.labelLine2.Size = new System.Drawing.Size(320, 2);
			this.labelLine2.TabIndex = 19;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(125, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(180, 20);
			this.label1.TabIndex = 18;
			this.label1.Text = "Ilma Sakinah Parinduri (ISP)";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelGitHub2
			// 
			this.labelGitHub2.Location = new System.Drawing.Point(30, 230);
			this.labelGitHub2.Name = "labelGitHub2";
			this.labelGitHub2.Size = new System.Drawing.Size(80, 20);
			this.labelGitHub2.TabIndex = 17;
			this.labelGitHub2.Text = "GitHub";
			this.labelGitHub2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelLinkedin2
			// 
			this.labelLinkedin2.Location = new System.Drawing.Point(30, 210);
			this.labelLinkedin2.Name = "labelLinkedin2";
			this.labelLinkedin2.Size = new System.Drawing.Size(80, 20);
			this.labelLinkedin2.TabIndex = 16;
			this.labelLinkedin2.Text = "Linkedin";
			this.labelLinkedin2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelEmail2
			// 
			this.labelEmail2.Location = new System.Drawing.Point(30, 190);
			this.labelEmail2.Name = "labelEmail2";
			this.labelEmail2.Size = new System.Drawing.Size(80, 20);
			this.labelEmail2.TabIndex = 15;
			this.labelEmail2.Text = "E-mail";
			this.labelEmail2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelGitHub1
			// 
			this.labelGitHub1.Location = new System.Drawing.Point(30, 145);
			this.labelGitHub1.Name = "labelGitHub1";
			this.labelGitHub1.Size = new System.Drawing.Size(80, 20);
			this.labelGitHub1.TabIndex = 14;
			this.labelGitHub1.Text = "GitHub";
			this.labelGitHub1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelLinkedin1
			// 
			this.labelLinkedin1.Location = new System.Drawing.Point(30, 125);
			this.labelLinkedin1.Name = "labelLinkedin1";
			this.labelLinkedin1.Size = new System.Drawing.Size(80, 20);
			this.labelLinkedin1.TabIndex = 13;
			this.labelLinkedin1.Text = "Linkedin";
			this.labelLinkedin1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelEmail1
			// 
			this.labelEmail1.Location = new System.Drawing.Point(30, 105);
			this.labelEmail1.Name = "labelEmail1";
			this.labelEmail1.Size = new System.Drawing.Size(80, 20);
			this.labelEmail1.TabIndex = 12;
			this.labelEmail1.Text = "E-mail";
			this.labelEmail1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// linkLabelDevGitHub2
			// 
			this.linkLabelDevGitHub2.Location = new System.Drawing.Point(120, 230);
			this.linkLabelDevGitHub2.Name = "linkLabelDevGitHub2";
			this.linkLabelDevGitHub2.Size = new System.Drawing.Size(200, 20);
			this.linkLabelDevGitHub2.TabIndex = 11;
			this.linkLabelDevGitHub2.TabStop = true;
			this.linkLabelDevGitHub2.Text = "arielmatius";
			this.linkLabelDevGitHub2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkLabelDevGitHub2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelDevGitHub2LinkClicked);
			// 
			// linkLabelDevLinkedin2
			// 
			this.linkLabelDevLinkedin2.Location = new System.Drawing.Point(120, 210);
			this.linkLabelDevLinkedin2.Name = "linkLabelDevLinkedin2";
			this.linkLabelDevLinkedin2.Size = new System.Drawing.Size(200, 20);
			this.linkLabelDevLinkedin2.TabIndex = 10;
			this.linkLabelDevLinkedin2.TabStop = true;
			this.linkLabelDevLinkedin2.Text = "Arielm Matius Surbakti";
			this.linkLabelDevLinkedin2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkLabelDevLinkedin2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelDevLinkedin2LinkClicked);
			// 
			// linkLabelDevEmail2
			// 
			this.linkLabelDevEmail2.Location = new System.Drawing.Point(120, 190);
			this.linkLabelDevEmail2.Name = "linkLabelDevEmail2";
			this.linkLabelDevEmail2.Size = new System.Drawing.Size(200, 20);
			this.linkLabelDevEmail2.TabIndex = 9;
			this.linkLabelDevEmail2.TabStop = true;
			this.linkLabelDevEmail2.Text = "arielmatius21@gmail.com";
			this.linkLabelDevEmail2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkLabelDevEmail2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelDevEmail2LinkClicked);
			// 
			// linkLabelDevGitHub1
			// 
			this.linkLabelDevGitHub1.Location = new System.Drawing.Point(120, 145);
			this.linkLabelDevGitHub1.Name = "linkLabelDevGitHub1";
			this.linkLabelDevGitHub1.Size = new System.Drawing.Size(200, 20);
			this.linkLabelDevGitHub1.TabIndex = 8;
			this.linkLabelDevGitHub1.TabStop = true;
			this.linkLabelDevGitHub1.Text = "aNdr3W03";
			this.linkLabelDevGitHub1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkLabelDevGitHub1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelDevGitHub1LinkClicked);
			// 
			// linkLabelDevLinkedin1
			// 
			this.linkLabelDevLinkedin1.Location = new System.Drawing.Point(120, 125);
			this.linkLabelDevLinkedin1.Name = "linkLabelDevLinkedin1";
			this.linkLabelDevLinkedin1.Size = new System.Drawing.Size(200, 20);
			this.linkLabelDevLinkedin1.TabIndex = 7;
			this.linkLabelDevLinkedin1.TabStop = true;
			this.linkLabelDevLinkedin1.Text = "Andrew Benedictus Jamesie";
			this.linkLabelDevLinkedin1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkLabelDevLinkedin1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelDevLinkedin1LinkClicked);
			// 
			// linkLabelDevEmail1
			// 
			this.linkLabelDevEmail1.Location = new System.Drawing.Point(120, 105);
			this.linkLabelDevEmail1.Name = "linkLabelDevEmail1";
			this.linkLabelDevEmail1.Size = new System.Drawing.Size(200, 20);
			this.linkLabelDevEmail1.TabIndex = 6;
			this.linkLabelDevEmail1.TabStop = true;
			this.linkLabelDevEmail1.Text = "andrewbjamesie@yahoo.com";
			this.linkLabelDevEmail1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkLabelDevEmail1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelDevEmail1LinkClicked);
			// 
			// labelDevName2
			// 
			this.labelDevName2.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDevName2.Location = new System.Drawing.Point(15, 170);
			this.labelDevName2.Name = "labelDevName2";
			this.labelDevName2.Size = new System.Drawing.Size(180, 20);
			this.labelDevName2.TabIndex = 5;
			this.labelDevName2.Text = "Ariel Matius Surbakti";
			this.labelDevName2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelDevName1
			// 
			this.labelDevName1.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDevName1.Location = new System.Drawing.Point(15, 85);
			this.labelDevName1.Name = "labelDevName1";
			this.labelDevName1.Size = new System.Drawing.Size(180, 20);
			this.labelDevName1.TabIndex = 4;
			this.labelDevName1.Text = "Andrew Benedictus Jamesie";
			this.labelDevName1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelLine1
			// 
			this.labelLine1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelLine1.Location = new System.Drawing.Point(15, 55);
			this.labelLine1.Name = "labelLine1";
			this.labelLine1.Size = new System.Drawing.Size(320, 2);
			this.labelLine1.TabIndex = 3;
			// 
			// labelDevTeam
			// 
			this.labelDevTeam.Location = new System.Drawing.Point(15, 65);
			this.labelDevTeam.Name = "labelDevTeam";
			this.labelDevTeam.Size = new System.Drawing.Size(180, 20);
			this.labelDevTeam.TabIndex = 1;
			this.labelDevTeam.Text = "Developer Team";
			this.labelDevTeam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelAslab
			// 
			this.labelAslab.Location = new System.Drawing.Point(15, 25);
			this.labelAslab.Name = "labelAslab";
			this.labelAslab.Size = new System.Drawing.Size(95, 20);
			this.labelAslab.TabIndex = 0;
			this.labelAslab.Text = "Lab Assistant";
			this.labelAslab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// linkLabelRepo
			// 
			this.linkLabelRepo.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabelRepo.Location = new System.Drawing.Point(312, 50);
			this.linkLabelRepo.Name = "linkLabelRepo";
			this.linkLabelRepo.Size = new System.Drawing.Size(55, 20);
			this.linkLabelRepo.TabIndex = 2;
			this.linkLabelRepo.TabStop = true;
			this.linkLabelRepo.Text = "GitHub";
			this.linkLabelRepo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.linkLabelRepo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelRepoLinkClicked);
			// 
			// FormAbout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 466);
			this.Controls.Add(this.groupBox);
			this.Controls.Add(this.labelBuild);
			this.Controls.Add(this.labelCopyright);
			this.Controls.Add(this.labelVersion);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.linkLabelRepo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormAbout";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About interXtellar :D";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.groupBox.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label labelUSU;
		private System.Windows.Forms.LinkLabel linkLabelFasilkomTI;
		private System.Windows.Forms.LinkLabel linkLabelIKLC;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelLine2;
		private System.Windows.Forms.Label labelIKLC;
		private System.Windows.Forms.Label labelLine1;
		private System.Windows.Forms.Label labelDevName1;
		private System.Windows.Forms.Label labelDevName2;
		private System.Windows.Forms.LinkLabel linkLabelDevEmail1;
		private System.Windows.Forms.LinkLabel linkLabelDevLinkedin1;
		private System.Windows.Forms.LinkLabel linkLabelDevGitHub1;
		private System.Windows.Forms.LinkLabel linkLabelDevEmail2;
		private System.Windows.Forms.LinkLabel linkLabelDevLinkedin2;
		private System.Windows.Forms.LinkLabel linkLabelDevGitHub2;
		private System.Windows.Forms.Label labelEmail1;
		private System.Windows.Forms.Label labelLinkedin1;
		private System.Windows.Forms.Label labelGitHub1;
		private System.Windows.Forms.Label labelEmail2;
		private System.Windows.Forms.Label labelLinkedin2;
		private System.Windows.Forms.Label labelGitHub2;
		private System.Windows.Forms.Label labelAslab;
		private System.Windows.Forms.Label labelDevTeam;
		private System.Windows.Forms.LinkLabel linkLabelRepo;
		private System.Windows.Forms.GroupBox groupBox;
		private System.Windows.Forms.Label labelBuild;
		private System.Windows.Forms.Label labelCopyright;
		private System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.PictureBox pictureBox;
	}
}
