using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibrary;
using LogicaForm;

namespace FormsSweet
{
    public partial class Form1 : Form
    {
        Logica a = new Logica();

        public Form1()
        {
            a = new Logica();
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(ref a);
            form2.ShowDialog();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void button4_Click(object sender, EventArgs e)
        {
            Calculator t = new Calculator();
            int sum = t.CalculatorDiv(a);
            label2.Text = Convert.ToString(sum) + "г";

            Print p = new Print();
            p.Printer(a, this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string list = listBox1.SelectedItem.ToString();
            a.Delete(list);
            Calculator t = new Calculator();
            int sum = t.CalculatorDiv(a);
            label2.Text = Convert.ToString(sum) + "г";
            Print p = new Print();
            p.Printer(a, this);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(ref a);
            form3.ShowDialog();
        }


    }
}
