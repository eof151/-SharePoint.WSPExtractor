using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.SharePoint.Administration;

namespace SharePoint2010WSPExtractor
{
    public partial class Form1 : Form
    {
        List<SPSolution> farmSpSolutions = new List<SPSolution>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void butt_Get_Click(object sender, EventArgs e)
        {
            try
            {
                if (listWSP.SelectedItems.Count != 0)
                {
                    var selected = listWSP.SelectedItems;
                    foreach (var wsp in selected)
                    {
                        SPSolution sol = farmSpSolutions.First(o => o.DisplayName == wsp.ToString());
                        if (sol != null)
                        {
                            SaveFile(sol);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You must select one or plural WSP to get!");
                }
            }
            catch (Exception excp)
            {
                LogError(excp);
            }
        }

        private void butt_Clipboard_Click(object sender, EventArgs e)
        {
            if (textBox_Mess.Text != "")
            {
                Clipboard.SetText(textBox_Mess.Text, TextDataFormat.Text);
            }
        }

        private void butt_Clear_Click(object sender, EventArgs e)
        {
            textBox_Mess.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SPSolutionCollection solutions = SPFarm.Local.Solutions;
                foreach (SPSolution solution in solutions)
                {
                    farmSpSolutions.Add(solution);
                }
                if (farmSpSolutions != null && farmSpSolutions.Count() != 0)
                {
                    butt_Get.Enabled = true;
                    foreach (var w in farmSpSolutions.OrderBy(o => o.DisplayName))
                    {
                        listWSP.Items.Add(w.DisplayName);
                    }
                }
            }
            catch (Exception excp)
            {
                LogError(excp);
            }
        }

        private void LogError(Exception excp)
        {
            textBox_Mess.Text += Environment.NewLine + "Error: " + Environment.NewLine + excp.StackTrace;
        }

        private void SaveFile(SPSolution solution)
        {
            int counter = 0;
            string orginialFileName = tbPath.Text + @"\" + solution.SolutionFile.DisplayName;
            string newFileName = orginialFileName;

            while (File.Exists(newFileName))
            {
                counter = counter + 1;
                newFileName = string.Format("{0}({1})", orginialFileName, counter.ToString());
            }

            solution.SolutionFile.SaveAs(newFileName);
            if (!string.IsNullOrEmpty(textBox_Mess.Text))
                textBox_Mess.Text += Environment.NewLine;
            textBox_Mess.Text += newFileName + " Saved";
        }

        private void btFolder_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }

        public void ChooseFolder()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = folderBrowserDialog1.SelectedPath;
                btView.Enabled = true;
                btOpenFolder.Enabled = true;
            }
        }

        public void OpenFolder()
        {
            if (!string.IsNullOrEmpty(tbPath.Text))
                System.Diagnostics.Process.Start(tbPath.Text);
        }

        private void btOpenFolder_Click(object sender, EventArgs e)
        {
            OpenFolder();
        }
    }
}
