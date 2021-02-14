using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleSort3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnasc_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text.Trim();
            string[] arr0 = str.Split(',');

            int[] arr = new int[arr0.Length];
            for (int i = 0; i < arr0.Length; i++)
            {
                arr[i] = int.Parse(arr0[i]);
            }
            //the above is data sorting then below execute bubble sort
            //claim a new int[] below

            int[] target0 = arr;
            int temp = 0;
            for (int i = 0; i < target0.Length - 1; i++)
            {
                for (int j = 0; j < target0.Length - 1 - i; j++)
                {
                    if (target0[j] > target0[j + 1])
                    {
                        temp = target0[j];
                        target0[j] = target0[j + 1];
                        target0[j + 1] = temp;
                    }
                }
            }
            foreach (var a in target0)
            {
                textBox2.Text += a + ",";
            }
        }

        private void Btndesc_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text.Trim();
            string[] arr0 = str.Split(',');

            int[] arr = new int[arr0.Length];
            for (int i = 0; i < arr0.Length; i++)
            {
                arr[i] = int.Parse(arr0[i]);
            }
            int[] target0 = arr;
            int temp = 0;
            //DESC
            for (int i = 0; i < target0.Length - 1; i++)
            {
                for (int j = 0; j < target0.Length - 1 - i; j++)
                {
                    if (target0[j] < target0[j + 1])
                    {
                        temp = target0[j];
                        target0[j] = target0[j + 1];
                        target0[j + 1] = temp;
                    }
                }
            }
            foreach (var a in target0)
            {
                textBox2.Text += a + ",";
            }
        }

        private void Btnclear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
