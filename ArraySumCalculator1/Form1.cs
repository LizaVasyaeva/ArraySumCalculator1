using System;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ArraySumCalculator
{
    public partial class Form1 : Form
    {
        // Конструктор
        public Form1()
        {
            InitializeComponent();
        }

        // Обработчик кнопки
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Создаем массив для 10 чисел
                int[] numbers = new int[10];

                // Читаем числа из всех TextBox'ов
                numbers[0] = int.Parse(textBox1.Text);
                numbers[1] = int.Parse(textBox2.Text);
                numbers[2] = int.Parse(textBox3.Text);
                numbers[3] = int.Parse(textBox4.Text);
                numbers[4] = int.Parse(textBox5.Text);
                numbers[5] = int.Parse(textBox6.Text);
                numbers[6] = int.Parse(textBox7.Text);
                numbers[7] = int.Parse(textBox8.Text);
                numbers[8] = int.Parse(textBox9.Text);
                numbers[9] = int.Parse(textBox10.Text);

                // Вычисляем сумму
                int sum = 0;
                for (int i = 0; i < 10; i++)
                {
                    sum = sum + numbers[i];
                }

                // Выводим результат
                label12.Text = sum.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка! Во всех полях должны быть целые числа.",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}