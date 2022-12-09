using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // объявление переменных
        float num1, num2; // числа, над которыми будут проводиться математические операции
        string mathOperation; // переменная, для определения математической операции
        bool sign = true; // для ввода отрицательных чисел (соответствует кнопке +-)

        private void button0_Click(object sender, EventArgs e)
        {   //по нажатию на кнопку "0" в textBox отобразится 0 (если он до этого был пустой)
            //или 0 добавится к уже имеющемуся там тексту (например: в textBox написано 345 и нажали "0", тогда отобразится 3450)
            textBox1.Text += 0;
            // запись += является оператором сложения с присваиванием.
            // Иначе его можно было бы записать так: textBox1.Text = textBox1.Text + 0;
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text  += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            // устанавливает положительное или отрицательное число. По умолчанию sign == true.
            // Т.е. при первом нажатии на кнопку "+-" в метод передастся sign == true,
            // а, значет, в текстбокс добавится "-" перед введеннам значением. После этого  sign = false;
            // и, значит, при следующем нажатии кнопки "+-" в метод передастся  sign = false; Т.е. знак "-" заменится на "" (пустоту)
            if (sign == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                sign = false;
            }
            else if (sign == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                sign = true;
            }

        }
        // Метод для проведения математических операций.
        // По нажатию на кнопки "+", "-", "*", "/" задается параметр mathOperation
        private void calculate()
        {

            switch (mathOperation)
            {
                case "+":
                    num2 = num1 + float.Parse(textBox1.Text);
                    textBox1.Text = num2.ToString();
                    break;

                case "-":
                    num2 = num1 - float.Parse(textBox1.Text);
                    textBox1.Text = num2.ToString();
                    break;
                case "*":
                    num2 = num1 * float.Parse(textBox1.Text);
                    textBox1.Text = num2.ToString();
                    break;
                case "/":
                    num2 = num1 / float.Parse(textBox1.Text);
                    textBox1.Text = num2.ToString();
                    break;

                default:
                    break;
            }

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            mathOperation = "+";
            label1.Text = num1.ToString() + "+";
            sign = true;

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            mathOperation = "-";
            label1.Text = num1.ToString() + "-";
            sign = true;
        }

        private void buttonMultipl_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            mathOperation = "*";
            label1.Text = num1.ToString() + "*";
            sign = true;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            mathOperation = "/";
            label1.Text = num1.ToString() + "/";
            sign = true;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void buttonBackspase_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text += text[i];
            }
        }


    }
}
