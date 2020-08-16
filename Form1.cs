using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SineTable_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButt_Click(object sender, EventArgs e)
        {
            if (maxPeak.Value - minPeak.Value < 0)
            {
                MessageBox.Show("Max Peak MUST be greater than min Peak.");
                return;
            }

            else if (minPeak.Value == 0 && tableCount.Value > 1)
            {
                MessageBox.Show("Set Min Peak Value!!");
                return;
            }

            else
            {
                GenerateC();
            } 
        }

        private void GenerateC()
        {
            String name = "sineVal";
            cArray.Clear();
            try
            {
                int mid = Convert.ToInt32(valCount.Value / 2 + 1);
                cArray.AppendText("#ifndef SINETABLE_H\n");
                cArray.AppendText("#define SINETABLE_H\n");
                cArray.AppendText("\n//---- sineTable.h ----\n\n");
                if (sameArray.Checked && !halfTable.Checked) 
                    cArray.AppendText($"const int {name}[][{valCount.Value}] = {{");
                if (sameArray.Checked && halfTable.Checked)
                    cArray.AppendText($"const int {name}[][{mid}] = {{");

                int peak;
                int peakDef = (int)((maxPeak.Value - minPeak.Value) / (tableCount.Value > 1 ? tableCount.Value - 1 : tableCount.Value));
                if (minPeak.Value == 0) peak = (int)maxPeak.Value;
                else peak = (int)minPeak.Value;

                for (int j = 0; j < tableCount.Value; j++)
                {
                    cArray.AppendText($"\n// Peak Value = {peak}\n");
                    if (!sameArray.Checked) cArray.AppendText($"const int {name}_{j}[] = {{");
                    if (sameArray.Checked) cArray.AppendText("{");

                    for (int i = 0; i < valCount.Value; i++)
                    {
                        if (i == 0)
                        {
                            cArray.AppendText("0,");
                            continue;
                        }
                        if (halfTable.Checked && i == mid) break;
                        double x = 180 / Convert.ToDouble(valCount.Value) * i;
                        double sin = Math.Sin(x * (Math.PI / 180));
                        double val = sin * Convert.ToDouble(peak);
                        cArray.AppendText($"{Convert.ToInt32(val)}");
                        if (i != valCount.Value - 1) cArray.AppendText(",");
                    }

                    if (!halfTable.Checked) cArray.AppendText(",");
                    if (sameArray.Checked) cArray.AppendText("},");
                    if (!sameArray.Checked) cArray.AppendText($"}};\n");
                    peak += peakDef;
                }
                if (sameArray.Checked) cArray.AppendText("\n};\n");
                cArray.AppendText("\n\n#endif");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://helloAntor.blogspot.com");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sameArray.CheckState = CheckState.Checked;
        }

        private void SaveC_Click(object sender, EventArgs e)
        {
            if(cArray.Text == "")
            {
                MessageBox.Show("Please generate a table first!!");
                return;
            }
            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "header File|*.h",
                Title = "Save a Header File",
                FileName = "sineTable"
            };
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                File.WriteAllText(Path.GetFullPath(saveFileDialog1.FileName), cArray.Text);
            };
        }
    }
}
