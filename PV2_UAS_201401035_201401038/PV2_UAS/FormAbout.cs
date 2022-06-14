/*
 * Created by SharpDevelop.
 * User: Andrew
 * Date: Min, 12 Jun 2022
 * Time: 06.28.04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PV2_UAS
{
	/// <summary>
	/// Description of FormAbout.
	/// </summary>
	public partial class FormAbout : Form
	{
		public FormAbout()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void LinkLabelRepoLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://github.com/aNdr3W03/PemrogramanVisual_Lab/tree/main/PV2_UAS_201401035_201401038");
		}
		
		void LinkLabelDevEmail1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("mailto:andrewbjamesie@yahoo.com");
		}
		
		void LinkLabelDevLinkedin1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://www.linkedin.com/in/andrew-benedictus-jamesie-07658a1b3");
		}
		
		void LinkLabelDevGitHub1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://github.com/aNdr3W03");
		}
		
		void LinkLabelDevEmail2LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("mailto:arielmatius21@gmail.com");
		}
		
		void LinkLabelDevLinkedin2LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://www.linkedin.com/in/ariel-matius-surbakti-a96a18227");
		}
		
		void LinkLabelDevGitHub2LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://github.com/arielmatius");
		}
		
		void LinkLabelIKLCLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://www.instagram.com/iklcusu");
		}
		
		void LinkLabelFasilkomTILinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://fasilkom-ti.usu.ac.id");
		}
	}
}
