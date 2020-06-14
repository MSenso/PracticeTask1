using System;
using System.Collections.Generic;

using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Drawing;

namespace PracticeTask1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x, m, Length, v; // Входные данные
        string result; // Выходные данные
        Random random = new Random();
        Label input_from_file, output;
        TextBox user_input;
        bool Try_Parse(string data, ref int value) // Проверка на корректность ввода значения
        {
            bool is_correct;
            is_correct = int.TryParse(data, out value);
            return is_correct;
        }
        bool Is_Correct_Data_From_File() // Проверка на корректность данных файла
        {
            string text = File.ReadAllText("INPUT.TXT");
            return Check_Data(text);
        }
        bool Check_Data(string input)  // Проверка на корректность значений в файле
        {
            string[] data = input.Split(' '); // Разбиение на подстроки
            if (data.Length == 4) // Должно быть 4 подстроки, т.к. вводится 4 числа
            {
                bool is_correct_input = Try_Parse(data[0], ref x);
                if (is_correct_input && x >= 5 && x <= 100) // Ограничение на х по условию задачи
                {
                    is_correct_input = Try_Parse(data[1], ref m);
                    if (is_correct_input && m >= 1 && m <= 256) // Ограничение на m по условию задачи
                    {
                        is_correct_input = Try_Parse(data[2], ref Length);
                        if (is_correct_input && Length >= 10 && Length <= 100) // Ограничение на L по условию задачи
                        {
                            is_correct_input = Try_Parse(data[3], ref v);
                            if (is_correct_input && v >= 0 && v <= m - 1) return true; // Ограничение на v по условию задачи
                            else return false;
                        }
                        else return false;
                    }
                    else return false;
                }
                else return false;
            }
            else return false;
        }
        void Make_Input_From_File_Label() // Вывод входных данных из файла на экран
        {
            input_from_file = new Label()
            {
                Name = "Input_From_File",
                Text = x + " " + m + " " + Length + " " + v,
                AutoSize = true,
                Location = new Point(Input_Label.Location.X + Input_Label.Width + 10, Input_Label.Location.Y),
                Font = Input_Label.Font,
                ForeColor = Color.Black,
                BackColor = Color.Transparent
            };
            Controls.Add(input_from_file);
        }
        void Make_Box() // Текстбокс для ввода данных пользователем вручную
        {
            user_input = new TextBox()
            {
                Name = "User_Input",
                Size = new Size(200, 41),
                Location = new Point(Input_Label.Location.X + Input_Label.Width + 10, Input_Label.Location.Y),
                Font = Input_Label.Font,
                ForeColor = Color.Black,
                BackColor = Color.FromArgb(255, 245, 248)
            };
            user_input.KeyDown += User_Input_KeyDown; // Подписка на событие нажатия клавиши
            Controls.Add(user_input);
            user_input.Focus();
        }
        void User_Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Нажат Enter
            {
                if (Check_Data((sender as TextBox).Text)) // Проверка на корректный ввод
                {
                    Run(); // Выполнить программу
                }
                else MessageBox.Show("Некорректные входные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ввестиИзФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Input_Label.Visible = true;
            if (Is_Correct_Data_From_File())
            {
                if (user_input != null) // Очистка формы
                {
                    Controls.Remove(user_input);
                    user_input = null;
                }
                if (input_from_file == null) // Заполнение формы
                {
                    Make_Input_From_File_Label();
                    Run(); // Выполнить программы
                }
            }
        }

        private void ввестиВручнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Input_Label.Visible = true;
            if (input_from_file != null) // Очистка формы
            {
                Controls.Remove(input_from_file);
                input_from_file = null;
            }
            if (user_input == null) Make_Box(); // Заполнение формы
        }

        void Calculate_Sequence() // Нахождение последовательности
        {
            int[] coeffs_array = new int[Length]; // Массив из цифр последовательности
            double polynome_sum = 0;
            for(int i = 0; polynome_sum % m != v && coeffs_array[0] != 10; i++) // Пока не найдено подходящее число и первое не стало 10
            {
                polynome_sum = 0;
                coeffs_array[0]++; // Увеличение первой цифры на 1
                Move_Digits(ref coeffs_array); // Сдвиг разрядов
                for (int j = 0; j < Length; j++)
                {
                    polynome_sum += coeffs_array[j] * (int)Math.Pow(x, j); // Вычисление текущей полномиальной суммы
                }
            }
            if (polynome_sum % m != v) // Число не нашлось
                result = "NO SOLUTION";
            else
            {
                for (int i = 0; i < Length; i++)
                {
                    result += coeffs_array[i].ToString(); // Вывод числа
                }
            }
            File.WriteAllText("OUTPUT.TXT", result);
        }
        void Move_Digits(ref int[] coeffs_array) // Сдвиг разрядов
        {
            for(int i = 0; i < Length; i++)
            {
                if (coeffs_array[i] == 10) // Текущий разряд равен 10
                {
                    coeffs_array[i] = 0; // Обнуление
                    if (i == Length - 1) ++coeffs_array[0]; // Увеличение первой цифры
                    else ++coeffs_array[i + 1]; // Увеличение следующей цифры
                }
                else break; // Выход из цикла
            }
        }
        void Run() // Основной алгоритм
        {
            result = string.Empty;
            if (m != 1) // m не равно 1
            {
                Calculate_Sequence(); // Найти подходящее число
            }
            else
            {
                int[] coeffs = new int[Length];
                for (int i = 0; i < Length; i++)
                {
                    coeffs[i] = random.Next(10); // Вывод случайного числа длины L
                    result += coeffs[i].ToString();
                    File.WriteAllText("OUTPUT.TXT", result);
                }
            }

            if (output == null)
            {
                output = new Label() // Создание метки для вывода
                {
                    Name = "Output",
                    AutoSize = true,
                    Location = new Point(Input_Label.Location.X, Input_Label.Location.Y + Input_Label.Height + 20),
                    Font = Input_Label.Font,
                    BackColor = Color.Transparent,
                    ForeColor = Color.Black
                };
                Controls.Add(output);
            }
            if (result == "NO SOLUTION") output.Text = result;
            else output.Text = "Возможная хеш-функция: " + result;
        }
    }
}
