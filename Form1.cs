using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ТреугольныеМассивы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            int[][] a; // Описываем a как двумерный массив;
            a = new int[6][];
            for (int i = 0; i < 6; i++)
            {
                a[i] = new int[i + 1];
            }

            a[0][0] = 309;
            a[1][0] = 106;
            a[1][1] = 257;
            a[2][0] = 142;
            a[2][1] = 283;
            a[2][2] = 40;
            a[3][0] = 130;
            a[3][1] = 439;
            a[3][2] = 137;
            a[3][3] = 167;
            a[4][0] = 136;
            a[4][1] = 222;
            a[4][2] = 204;
            a[4][3] = 240;
            a[4][4] = 281;
            a[5][0] = 330;
            a[5][1] = 440;
            a[5][2] = 246;
            a[5][3] = 199;
            a[5][4] = 362;
            a[5][5] = 430;

            String[] column0 = { "Челябинск", "Магнитогорск" , "Миасс","Златоуст","Снежинск", "Троицк","Аша" };
            for (int i = 0; i < column0.Length; i++)
            {
                dataGridView1.Rows.Add(column0[i]);
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    dataGridView1.Rows[i + 1].Cells[j + 1].Value = a[i][j];

                    if (i == j)
                    {
                        dataGridView1.Rows[i].Cells[j + 1].Value = "-";
                    }
                }
            }

            dataGridView1.Rows[6].Cells[7].Value = "-";

            int[][] b; 
            b = new int[6][];
            for (int i = 0; i < 6; i++)
            {
                b[i] = new int[6-i];
            }

            b[5][0] = 430;
            b[4][0] = 281;
            b[4][1] = 362;
            b[3][0] = 167;
            b[3][1] = 240;
            b[3][2] = 199;
            b[2][0] = 40;
            b[2][1] = 137;
            b[2][2] = 204;
            b[2][3] = 246;
            b[1][0] = 257;
            b[1][1] = 283;
            b[1][2] = 439;
            b[1][3] = 222;
            b[1][4] = 440;
            b[0][0] = 309;
            b[0][1] = 106;
            b[0][2] = 142;
            b[0][3] = 130;
            b[0][4] = 136;
            b[0][5] = 330;
            int counter = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6-i; j++)
                {
                    dataGridView1.Rows[i].Cells[j+counter + 2].Value = b[i][j];
                }
                counter++;
            }
        }
    }
}

