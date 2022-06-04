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
    public partial class Form2 : Form
    {
        Logica a = new Logica();
        public Form2(ref Logica b)
        {
            InitializeComponent();
            a = b;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            if (comboBox1.Text == "Конфета")
            {
                
                label3.Text = "Цвет";
                label4.Text = "Вкус";
                label5.Text = "Покрытие";
                label6.Text = "Тип";
            }
            if (comboBox1.Text == "Шоколад")
            {
                label3.Text = "Цвет";
                label4.Text = "Вкус";
                label5.Text = "Тип шоколада";
                label6.Text = "Пористость";
            }
            if (comboBox1.Text == "Печенье")
            {
                label3.Text = "Тесто";
                label4.Text = "Мука";
                label5.Text = "Форма";
                label6.Text = "Начинка";
            }
            if (comboBox1.Text == "Кекс")
            {
                label3.Text = "Тесто";
                label4.Text = "Мука";
                label5.Text = "Количество слоев";
                label6.Text = "Крем";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Конфета")
            {
                a.AddBonbon(textBox6.Text, Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            }
            if (comboBox1.Text == "Шоколад")
            {
                a.AddChocolate(textBox6.Text, Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            }
            if (comboBox1.Text == "Печенье")
            {
                a.AddCookies(textBox6.Text, Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            }
            if (comboBox1.Text == "Кекс")
            {
                a.AddCake(textBox6.Text, Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text,Convert.ToInt32(textBox4.Text), textBox5.Text);
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
