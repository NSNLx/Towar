using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Towar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            oplacone.Checked = true;
            data.Value = DateTime.Now;
        }

        private void dostarczono_Click(object sender, EventArgs e)
        {
            if (wyslane.Checked)
            {
                dostarczone.Checked = true;
                data.Value = DateTime.Now;
            }
        }

        private void saveToCSV_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV Files|*.csv|All Files|*.*";
                sfd.Title = "Zapisz dane do CSV";
                sfd.FileName = "dane.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {

                        using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName, false, Encoding.UTF8))
                        {

                            sw.WriteLine("nazwa;ilosc;wartosc;marka;oplacone;wyslane;dostarczone;opis");

                            string nazwaVal = nazwa.Text;
                            int iloscVal = (int)iloscSztuk.Value;
                            string wartoscVal = wartosc.Text;


                            string markaVal = comboBox1.SelectedItem?.ToString() ?? "";

                            string oplaconeVal = oplacone.Checked ? "True" : "False";
                            string wyslaneVal = wyslane.Checked ? "True" : "False";
                            string dostarczoneVal = dostarczone.Checked ? "True" : "False";

                            string opisVal = Opis.Text.Replace("\"", "\"\"");
                            opisVal = "\"" + opisVal + "\"";
                            string linia = $"{nazwaVal};{iloscVal};{wartoscVal};{markaVal};" +
                                           $"{oplaconeVal};{wyslaneVal};{dostarczoneVal};{opisVal}";

                            sw.WriteLine(linia);
                        }

                        MessageBox.Show("Dane zostały zapisane do CSV.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Błąd zapisu: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void iloscSztuk_ValueChanged(object sender, EventArgs e)
        {
            wartosc.Text = (iloscSztuk.Value * cena.Value).ToString();
        }

        private void cena_ValueChanged(object sender, EventArgs e)
        {
            wartosc.Text = (iloscSztuk.Value * cena.Value).ToString();
        }


        private void loadCSV_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "CSV Files|*.csv|All Files|*.*";
                ofd.Title = "Wczytaj plik CSV";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var lines = System.IO.File.ReadAllLines(ofd.FileName);

                        if (lines.Length > 1)
                        {
                            string dataLine = lines[1];

                            string[] parts = dataLine.Split(';');

                            nazwa.Text = parts[0];
                            iloscSztuk.Value = decimal.Parse(parts[1]);
                            wartosc.Text = parts[2];
                            comboBox1.SelectedItem = parts[3];
                            oplacone.Checked = (parts[4] == "True");
                            wyslane.Checked = (parts[5] == "True");
                            dostarczone.Checked = (parts[6] == "True");
                            string opisLine = parts[7].Trim('"');
                            opisLine = opisLine.Replace("\"\"", "\"");
                            Opis.Text = opisLine;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Błąd odczytu: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void wyslij_Click(object sender, EventArgs e)
        {
            if (oplacone.Checked)
            {
                wyslane.Checked=true;
                data.Value = DateTime.Now;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno wyczyścić formularz?", "Pytanie",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                nazwa.Text = "";
                iloscSztuk.Value = 0;
                cena.Value = 0;
                wartosc.Text = "";
                comboBox1.SelectedIndex = -1;
                oplacone.Checked = false;
                wyslane.Checked = false;
                dostarczone.Checked = false;
                Opis.Text = "";
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
