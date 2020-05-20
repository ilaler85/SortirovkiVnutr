using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Randoom_Click(object sender, EventArgs e)
        {
            //рандомное заполнение массива

            Random R = new Random();
            if (i <= 2)
            {
                this.ColvoMass_Click(sender, e);
            }
            massiv.RowCount = 1;
            massiv.ColumnCount = i;
            for (int j = 0; j < i; j++)
            {
                massiv.Columns[j].Width = 20;
                massiv.Rows[0].Cells[j].Value = R.Next(0, 100);
            }
            for (int j = 1; j < i; j++)
            {
                massiv.Rows[0].Cells[j].Style.BackColor = Color.White;
            }
            chi1.Text = "";
            chi2.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ColvoMass_Click(object sender, EventArgs e)
        {
            labVvod.Visible = true;
            vvod.Visible = true;
            butVvod.Visible = true;

        }

        private void butVvod_Click(object sender, EventArgs e)
        {
            string tmp = vvod.Text;
            if (int.TryParse(tmp, out i) && (i >= 2))
            {
                labVvod.Visible = false;
                vvod.Visible = false;
                butVvod.Visible = false;
                Randoom_Click(sender, e);
                chi1.Visible = true;
                chi2.Visible = true;
                sravnenie.Visible = true;
            }
            else
            {
                MessageBox.Show("Ошибка ввода");
            }
        }
        public bool proverka(object sender, EventArgs e)
        {
            bool OK = true;
            int j = 0;
            while (OK && (j < i))
            {
                int tmp;
                if (!int.TryParse(massiv.Rows[0].Cells[j].Value.ToString(), out tmp))
                {
                    OK = false;
                    massiv.Rows[0].Cells[j].Style.BackColor = Color.Red;
                    MessageBox.Show("Ошибка ввода");
                }
                j++;
            }
            return OK;
        }

        private async void ProstSort_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < i; j++)
            {
                massiv.Rows[0].Cells[j].Style.BackColor = Color.White;
            }
            //сортировка вставками
            if (i < 2)
            {
                this.ColvoMass_Click(sender, e);
            }
            if (proverka(sender, e))
            {
                for (int j = 1; j < i; j++)
                {
                    chi1.Text = massiv.Rows[0].Cells[j - 1].Value.ToString();
                    chi2.Text = massiv.Rows[0].Cells[j].Value.ToString();
                    sravnenie.Text = "Сравнение";
                    await Task.Delay(1000);
                    for (int k = j; k > 0 && (int.Parse(massiv.Rows[0].Cells[k - 1].Value.ToString()) > int.Parse(massiv.Rows[0].Cells[k].Value.ToString())); k--)
                    {
                        sravnenie.Text = "Сравнение";
                        chi1.Text = massiv.Rows[0].Cells[k - 1].Value.ToString();
                        chi2.Text = massiv.Rows[0].Cells[k].Value.ToString();
                        await Task.Delay(1000);
                        sravnenie.Text = ">";
                        await Task.Delay(1000);
                        sravnenie.Text = "замена";
                        //chi1.Text = massiv.Rows[0].Cells[k - 1].Value.ToString();
                        //chi2.Text = massiv.Rows[0].Cells[k].Value.ToString();
                        massiv.Rows[0].Cells[j].Style.BackColor = Color.Green;
                        string tmpp = massiv.Rows[0].Cells[k - 1].Value.ToString();
                        massiv.Rows[0].Cells[k - 1].Value = massiv.Rows[0].Cells[k].Value;
                        massiv.Rows[0].Cells[k].Value = tmpp;
                        await Task.Delay(1000);
                    }
                    sravnenie.Text = "<";
                    await Task.Delay(1000);
                    massiv.Rows[0].Cells[j - 1].Style.BackColor = Color.Green;
                }
                sravnenie.Text = "Конец";
                massiv.Rows[0].Cells[i - 1].Style.BackColor = Color.Green;
            }
        }

        private async void BiSort_Click(object sender, EventArgs e)
        {
            if (i < 2)
            {
                this.ColvoMass_Click(sender, e);
            }
            for (int j = 1; j < i; j++)
            {
                massiv.Rows[0].Cells[j].Style.BackColor = Color.White;
            }

            //сортировка бинарным поиском
            if (proverka(sender, e))
            {
                for (int j = 1; j < i; j++)
                {
                    massiv.Rows[0].Cells[j].Style.BackColor = Color.Yellow;
                    if (int.Parse(massiv.Rows[0].Cells[j - 1].Value.ToString()) > int.Parse(massiv.Rows[0].Cells[j].Value.ToString()))
                    {
                        int key = int.Parse(massiv.Rows[0].Cells[j].Value.ToString());
                        chi2.Text = massiv.Rows[0].Cells[j].Value.ToString();
                        int lo = 0, hi = j - 1;
                        while (lo < hi)
                        {
                            sravnenie.Text = "Сравниваем";
                            int mid = lo + ((hi - lo) / 2);
                            massiv.Rows[0].Cells[mid].Style.BackColor = Color.Yellow;
                            chi1.Text = massiv.Rows[0].Cells[mid].Value.ToString();
                            Thread.Sleep(1000);
                            if (key < int.Parse(massiv.Rows[0].Cells[mid].Value.ToString()))
                            {
                                sravnenie.Text = ">";
                                hi = mid;
                            }
                            else
                            {
                                sravnenie.Text = "<";
                                lo = mid + 1;
                            }
                            await Task.Delay(1000);
                            massiv.Rows[0].Cells[mid].Style.BackColor = Color.Green;
                        }
                        chi1.Text = "";
                        chi2.Text = "";
                        sravnenie.Text = "смещаем";
                        for (int jj = j; jj > lo; jj--)
                        {
                            massiv.Rows[0].Cells[jj].Value = massiv.Rows[0].Cells[jj - 1].Value.ToString();
                            chi1.Text = massiv.Rows[0].Cells[jj - 1].Value.ToString();
                            await Task.Delay(500);
                        }
                        massiv.Rows[0].Cells[lo].Value = key;
                        // massiv.Rows[0].Cells[lo].Style.BackColor = Color.Green;

                    }
                    massiv.Rows[0].Cells[j].Style.BackColor = Color.Green;
                    chi1.Text = "";
                }
                sravnenie.Text = "Конец";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
