using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Зчитування комплексних чисел з текстових полів
                double a1 = double.Parse(textBox2.Text);
                double b1 = double.Parse(textBox1.Text);
                double a2 = double.Parse(textBox4.Text);
                double b2 = double.Parse(textBox3.Text);

                // Створення об'єктів комплексних чисел
                ComplexNumber num1 = new ComplexNumber(a1, b1);
                ComplexNumber num2 = new ComplexNumber(a2, b2);

                // Виконання розподілу
                ComplexNumber result = num1.Divide(num2);

                // Відображення результату
                textBox5.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Хибний формат змінних!", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
