using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicaForm;
using ClassLibrary;
namespace FormsSweet
{
    public partial class Form3 : Form
    {
        int n = 0;
        Logica a = new Logica();
        public Form3(ref Logica b)
        {
            InitializeComponent();
            a = b;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;

            for (int i = 0; i < 20; i++)
            {
                if (a.arr1[i]._name != "null_1")
                {
                    comboBox1.Items.Add(a.arr1[i]._name);
                }
                if (a.arr2[i]._name != "null_1")
                {
                    comboBox1.Items.Add(a.arr2[i]._name);
                }
                if (a.arr3[i]._name != "null_1")
                {
                    comboBox1.Items.Add(a.arr3[i]._name);
                }
                if (a.arr4[i]._name != "null_1")
                {
                    comboBox1.Items.Add(a.arr4[i]._name);
                }

            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox1.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            button1.Visible = true;
            
            for (int i = 0; i < 20; i++)
            {
                if (a.arr1[i]._name == comboBox1.Text)
                {
                    n = 1;
                    label3.Text = "Цвет";
                    label4.Text = "Вкус";
                    label5.Text = "Покрытие";
                    label6.Text = "Тип";
                    textBox1.Text = Convert.ToString(a.arr1[i]._weight);
                    textBox2.Text = a.arr1[i]._color;
                    textBox3.Text = a.arr1[i]._taste;
                    textBox4.Text = a.arr1[i]._sprinkling;
                    textBox5.Text = a.arr1[i]._type;
                    break;
                }
                if (a.arr2[i]._name == comboBox1.Text)
                {
                    n = 2;
                    label3.Text = "Цвет";
                    label4.Text = "Вкус";
                    label5.Text = "Тип шоколада";
                    label6.Text = "Пористость";
                    textBox1.Text = Convert.ToString(a.arr2[i]._weight);
                    textBox2.Text = a.arr2[i]._color;
                    textBox3.Text = a.arr2[i]._taste;
                    textBox4.Text = a.arr2[i]._typeChocolate;
                    textBox5.Text = a.arr2[i]._porosity;
                    break;
                }
                if (a.arr3[i]._name == comboBox1.Text)
                {
                    n = 3;
                    label3.Text = "Тесто";
                    label4.Text = "Мука";
                    label5.Text = "Форма";
                    label6.Text = "Начинка";
                    textBox1.Text = Convert.ToString(a.arr3[i]._weight);
                    textBox2.Text = a.arr3[i]._dough;
                    textBox3.Text = a.arr3[i]._flour;
                    textBox4.Text = a.arr3[i]._shape;
                    textBox5.Text = a.arr3[i]._filling;
                    break;
                }
                if (a.arr4[i]._name == comboBox1.Text)
                {
                    n = 4;
                    label3.Text = "Тесто";
                    label4.Text = "Мука";
                    label5.Text = "Количество слоев";
                    label6.Text = "Крем";
                    textBox1.Text = Convert.ToString(a.arr4[i]._weight);
                    textBox2.Text = a.arr4[i]._dough;
                    textBox3.Text = a.arr4[i]._flour;
                    textBox4.Text = Convert.ToString(a.arr4[i]._layers);
                    textBox5.Text = a.arr4[i]._cream;
                    break;
                }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (n == 1)
            {
                for (int i = 0; i < 20; i++)
                {
                    if (a.arr1[i]._name == comboBox1.Text)
                    {
                        a.arr1[i]._weight = Convert.ToInt32(textBox1.Text);
                        a.arr1[i]._color = textBox2.Text;
                        a.arr1[i]._taste = textBox3.Text;
                        a.arr1[i]._sprinkling = textBox4.Text;
                        a.arr1[i]._type = textBox5.Text;
                        break;
                    }
                }
                
            }
            if (n == 2)
            {
                for (int i = 0; i < 20; i++)
                {
                    if (a.arr2[i]._name == comboBox1.Text)
                    {
                    a.arr2[i]._weight = Convert.ToInt32(textBox1.Text);
                    a.arr2[i]._color = textBox2.Text;
                    a.arr2[i]._taste = textBox3.Text;
                    a.arr2[i]._typeChocolate = textBox4.Text;
                    a.arr2[i]._porosity = textBox5.Text;
                    break;
                    }
                }

            }
            if (n == 3)
            {
                for (int i = 0; i < 20; i++)
                {
                    if (a.arr3[i]._name == comboBox1.Text)
                    {
                    a.arr3[i]._weight =Convert.ToInt32(textBox1.Text);
                    a.arr3[i]._dough = textBox2.Text;
                    a.arr3[i]._flour = textBox3.Text;
                    a.arr3[i]._shape = textBox4.Text;
                    a.arr3[i]._filling = textBox5.Text;
                    break;
                    }
                }

            }
            if (n == 4)
            {
                for (int i = 0; i < 20; i++)
                {
                    if (a.arr4[i]._name == comboBox1.Text)
                    {
                        a.arr4[i]._weight = Convert.ToInt32(textBox1.Text);
                        a.arr4[i]._dough = textBox2.Text;
                        a.arr4[i]._flour = textBox3.Text;
                        a.arr4[i]._layers =Convert.ToInt32(textBox4.Text);
                        a.arr4[i]._cream = textBox5.Text;
                        break;
                    }
                }

            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
