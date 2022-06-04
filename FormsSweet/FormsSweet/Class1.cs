using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogicaForm;
using ClassLibrary;

namespace FormsSweet
{
    public class Print
    {
        public void Printer(Logica c, Form1 f)
        {
            f.listBox1.Items.Clear();
            int b = 1;
            for (int i = 0; i < 20; i++)
            {
                if (c.arr1[i]._name != "null_1")
                {
                    f.listBox1.Items.Add(Convert.ToString(b) + ") " + c.arr1[i]._name + "  " + c.arr1[i]._weight + "г");
                    b++;
                }
                if (c.arr2[i]._name != "null_1")
                {
                    f.listBox1.Items.Add(Convert.ToString(b) + ") " + c.arr2[i]._name + "  " + c.arr2[i]._weight + "г");
                    b++;
                }
                if (c.arr3[i]._name != "null_1")
                {
                    f.listBox1.Items.Add(Convert.ToString(b) + ") " + c.arr3[i]._name + "  " + c.arr3[i]._weight + "г");
                    b++;
                }
                if (c.arr4[i]._name != "null_1")
                {
                    f.listBox1.Items.Add(Convert.ToString(b) + ") " + c.arr4[i]._name + "  " + c.arr4[i]._weight + "г");
                    b++;
                }

            }
        }
    }
}
