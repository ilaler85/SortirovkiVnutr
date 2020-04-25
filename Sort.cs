using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
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
            if (i <=2)
            {
                this.ColvoMass_Click(sender, e);   
            }
            massiv.RowCount = 1;
            massiv.ColumnCount= i;
            for (int j = 0; j <i; j++)
            {
                massiv.Columns[j].Width = 20;
                massiv.Rows[0].Cells[j].Value =R.Next(0, 100);
            }
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
            if (int.TryParse(tmp, out i)&&(i>=2))
            {
                labVvod.Visible = false;
                vvod.Visible = false;
                butVvod.Visible = false;
                Randoom_Click(sender, e);
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
            while (OK && (j<i))
            {
                int tmp;
                if(!int.TryParse(massiv.Rows[0].Cells[j].Value.ToString(), out tmp))
                {
                    OK = false;
                    massiv.Rows[0].Cells[j].Style.BackColor = Color.Red;
                }
                j++;
            }
            return OK;
        }

        private void ProstSort_Click(object sender, EventArgs e)
        {
            for (int j = 1; j < i; j++)
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
                    massiv.Rows[0].Cells[j].Style.BackColor = Color.Green;
                    timer.Enabled = true;
                    for (int k = j; k > 0 && (int.Parse(massiv.Rows[0].Cells[k - 1].Value.ToString()) > int.Parse(massiv.Rows[0].Cells[k].Value.ToString())); k--)
                    {
                        massiv.Rows[0].Cells[j].Style.BackColor = Color.Green;
                        string tmp = massiv.Rows[0].Cells[k - 1].Value.ToString();
                        massiv.Rows[0].Cells[k - 1].Value = massiv.Rows[0].Cells[k].Value;
                        massiv.Rows[0].Cells[k].Value = tmp;
                        timer.Enabled = true;
                    }
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;  
        }

        private void BiSort_Click(object sender, EventArgs e)
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
            if (proverka(sender, e)) {
                for (int j = 1; j < i; j++)
                {
                    if (int.Parse(massiv.Rows[0].Cells[j - 1].Value.ToString()) > int.Parse(massiv.Rows[0].Cells[j].Value.ToString()))
                    {
                        int key = int.Parse(massiv.Rows[0].Cells[j].Value.ToString());
                        int lo = 0, hi = j - 1;
                        while (lo < hi)
                        {
                            int mid = lo + ((hi - lo) / 2);
                            if (key < int.Parse(massiv.Rows[0].Cells[mid].Value.ToString()))
                            {
                                hi = mid;
                            }
                            else
                            {
                                lo = mid + 1;
                            }
                            timer.Enabled = true;
                            
                        }
                        massiv.Rows[0].Cells[j].Style.BackColor = Color.Green;
                        for (int jj = j; jj > lo; jj--)
                        {
                            massiv.Rows[0].Cells[jj].Value = massiv.Rows[0].Cells[jj - 1].Value.ToString();
                            timer.Enabled = true;
                        }
                        massiv.Rows[0].Cells[lo].Value = key;

                    }
                }
            }
        }
    }
}
