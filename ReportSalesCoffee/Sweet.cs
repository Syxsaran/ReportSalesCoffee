using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportSalesCoffee
{
    public partial class Sweet : Form
    {
        public Sweet()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);
                string readAllText = File.ReadAllText(openFileDialog.FileName);

                for (int i = 0; i < readAllLine.Length; i++)
                {
                    string classsweetRAW = readAllLine[i];
                    string[] classsweetSplited = classsweetRAW.Split(',');
                    ClassSweet classSweet = new ClassSweet(classsweetSplited[0], classsweetSplited[1], classsweetSplited[2], classsweetSplited[3]);
                    addDataToGridView("01", "name", "15", "13/12/2022");
                }
            }
        }
        void addDataToGridView(string num, string name, string pirce, string date)
        {
            this.dataGridView1.Rows.Add(new string[] { num, name, pirce, date });
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filepath = string.Empty;
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV(*.csv)|*.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string columnNames = "";
                            string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCSV[0] += columnNames;
                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCSV[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            File.WriteAllLines(sfd.FileName, outputCSV, Encoding.UTF8);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = textBoxNum.Text;
            dataGridView1.Rows[n].Cells[1].Value = textBoxName.Text;
            dataGridView1.Rows[n].Cells[2].Value = textBoxPirce.Text;
            dataGridView1.Rows[n].Cells[3].Value = comboBoxDay.Text +"/"+ comboBoxMount.Text +"/"+ comboBoxYears.Text;
            textBoxNum.Text = "";
            textBoxName.Text = "";
            textBoxPirce.Text = "";
            
        }
    }
}
