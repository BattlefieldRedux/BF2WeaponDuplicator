using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using IronPython;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace BF2WeaponDuplicator
{
	public partial class Form1 : Form
	{

		bool isOpened = false;
		string sourcename;
		System.IO.DirectoryInfo folder;
		System.IO.FileInfo fileInfo;
		string onlyName;

		ScriptRuntime py = Python.CreateRuntime();
		dynamic duplicator;
		dynamic copasCon;
		dynamic copasTweak;
		IronPython.Runtime.List daftarEditable = new IronPython.Runtime.List();

		System.IO.DirectoryInfo pInfo;
		string parent;

		public Form1()
		{
			InitializeComponent();
		}

		public void print(string kalimat)
		{
			Console.WriteLine(kalimat);
		}

		void resetBagian()
		{
			bagianBox.Items.Clear();

			foreach (IronPython.Runtime.List editable in daftarEditable)
			{
				string[] temp = editable[0].ToString().Split('.');
				if(bagianBox.Items.Contains(temp[1]) == false)
				bagianBox.Items.Add(temp[1]);
			}

			if (bagianBox.Items.Count > 0)
			{
				bagianBox.Text = bagianBox.Items[0].ToString();
			}

			resetStatus();
		}

		void resetStatus()
		{
			statusBox.Items.Clear();


			foreach (IronPython.Runtime.List editable in daftarEditable)
			{
				string[] temp = editable[0].ToString().Split('.');
				if (temp[1] == bagianBox.Text)
				{
					if (temp.Length == 3)
					{
						if (statusBox.Items.Contains(temp[2]) == false)
							statusBox.Items.Add(temp[2]);
					}
				}
			}

			if (statusBox.Items.Count > 0)
			{
				statusBox.Text = statusBox.Items[0].ToString();
			}
			else
			{
				if (bagianBox.Text != "")
					nilaiBox.Text = copasTweak.getValue(bagianBox.Text);
			}
		}

		void resetTweakForm()
		{
			daftarEditable = copasTweak.getEditAbleObject();
			resetBagian();
		}

		void applyData()
		{
			if (bagianBox.Text != "" && nilaiBox.Text != "")
			{
				copasTweak.setValue(bagianBox.Text, statusBox.Text, nilaiBox.Text);
			}
			else
			{
				MessageBox.Show("ada yang salah");
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			duplicateButton.Visible = false;

			duplicator = py.UseFile("duplicate.py");
		}

		private void outputBox_TextChanged(object sender, EventArgs e)
		{
			if (isOpened == true)
			{
				if (outputBox.Text != "")
				{
					duplicateButton.Visible = true;
				}
				else
				{
					duplicateButton.Visible = false;
				}

				parent = pInfo.FullName + "\\" + outputBox.Text;
				copasCon.output = parent + "\\" + outputBox.Text + ".con";
				copasTweak.output = parent + "\\" + outputBox.Text + ".tweak";

			}
		}

		private void bukaButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog pembuka = new OpenFileDialog();
			pembuka.Filter = "Bf2 Konfigurasi (*.con)|*.con|BF2 Tweak File (*.tweak)|*.tweak|All Files (*.*)|*.*";
			if (pembuka.ShowDialog() == DialogResult.OK)
			{
				isOpened = true;
				sourcename = pembuka.FileName;
				fileInfo = new System.IO.FileInfo(sourcename);
				folder = fileInfo.Directory;

				string sumber = fileInfo.Name;
				onlyName = sumber.Replace(fileInfo.Extension, "");

				copasCon = duplicator.copas(folder.FullName + "\\" + onlyName + ".con");
				copasTweak = duplicator.copas(folder.FullName + "\\" + onlyName + ".tweak");

				pInfo = folder.Parent;

				resetTweakForm();

				Console.WriteLine(onlyName + " is loaded");
			}
		}

		private void duplicateButton_Click(object sender, EventArgs e)
		{
			//string temp = folder.FullName + "\\" + onlyName + ".con";

			
			

			if (System.IO.Directory.Exists(parent) == false)
			{
				//System.IO.Directory.CreateDirectory(pInfo.FullName);
				pInfo.CreateSubdirectory(outputBox.Text);
				Console.WriteLine("creating a directory");
			}

			//if (System.IO.File.Exists(temp))
			//{
			//	//duplicator.duplikasi(temp, parent + "\\" + outputBox.Text + ".con", onlyName, outputBox.Text);
			//	duplicator.duplikasi(onlyName, outputBox.Text);
			//}
			//temp = folder.FullName + "\\" + onlyName + ".tweak";
			//if (System.IO.File.Exists(temp))
			//{
			//	//duplicator.duplikasi(temp, parent + "\\" + outputBox.Text + ".tweak", onlyName, outputBox.Text);
			//	duplicator.duplikasi(onlyName, outputBox.Text);
			//}

			copasCon.duplikasi(onlyName, outputBox.Text);
			copasTweak.duplikasi(onlyName, outputBox.Text);

			Process.Start("explorer.exe", parent);

			print("selesai mengduplikasi");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			applyData();
		}

		private void bagianBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			resetStatus();
		}

		private void statusBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (bagianBox.Text != "")
			nilaiBox.Text = copasTweak.getValue(bagianBox.Text, statusBox.Text);
		}

		private void nilaiBox_TextChanged(object sender, EventArgs e)
		{
			applyData();
		}
	}
}
