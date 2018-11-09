﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTA_Online_Helper
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3.ActiveForm.Hide();
            Form1 MyForm1 = new Form1();
            MyForm1.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show(
                "Внимание!\nОбнаружены пустые поля!\nВведите данные и попробуйте снова.\nВ крайнем случае оставьте в поле 0",
                "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                int small;
                int medium;
                int large;
                int oneBoxPrice;
                int twoBoxPrice;
                int thirdBoxPrice;
                int totalBoxPrice;
                int oneBoxCount;
                int twoBoxCount;
                int thirdBoxCount;
                int totalBoxCount;
                int storageCount;
                int boxCount;
                int runs;
                int overbox;
                int income;
                int clearIncome;

                int box1 = 10000;
                int box2 = 22000;
                int box3 = 36000;
                int box4 = 52000;
                int box5 = 65000;
                int box6 = 81000;
                int box7 = 94500;
                int box8 = 112000;
                int box9 = 126000;
                int box10 = 145000;
                int box14 = 203000;
                int box15 = 225000;
                int box19 = 285000;
                int box20 = 310000;
                int box24 = 341000;
                int box25;
                int box29;
                int box30;
                int box34;
                int box35;
                int box39;
                int box40;
                int box44;
                int box45;
                int box49;
                int box50;
                int box59;
                int box60;
                int box69;
                int box70;
                int box79;
                int box80;
                int box89;
                int box90;
                int box99;
                int box100;
                int box110
                int box111;
                
                small = 16;
                medium = 42;
                large = 110;
                oneBoxPrice = Int32.Parse(textBox4.Text) * 2000;
                twoBoxPrice = Int32.Parse(textBox5.Text) * 8000;
                thirdBoxPrice = Int32.Parse(textBox6.Text) * 18000;
                storageCount = Int32.Parse(textBox1.Text) + Int32.Parse(textBox2.Text) + Int32.Parse(textBox3.Text);
                boxCount = (Int32.Parse(textBox1.Text) * small) + (Int32.Parse(textBox2.Text) * medium) + (Int32.Parse(textBox3.Text) * large);
                runs = Int32.Parse(textBox4.Text) + Int32.Parse(textBox5.Text) + Int32.Parse(textBox6.Text);
                oneBoxCount = Int32.Parse(textBox4.Text) * 1;
                twoBoxCount = Int32.Parse(textBox5.Text) * 2;
                thirdBoxCount = Int32.Parse(textBox6.Text) * 3;
                totalBoxCount = oneBoxCount + twoBoxCount + thirdBoxCount;
                totalBoxPrice = oneBoxPrice + twoBoxPrice + thirdBoxPrice;

                // Расчет надбавки


                    // Проверка на кол-во склавов
                    if (storageCount > 5)
                    {
                        MessageBox.Show(
                        "У одного персонажа может быть не более 5ти складов одновременно!",
                        "Внимание!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    }
                    // Проверка на избыток ящиков
                    else if (totalBoxCount > boxCount)
                    {
                        overbox = totalBoxCount - boxCount;
                        MessageBox.Show(
                        "Вы столько не вместите!\nЛишних ящиков: " + overbox.ToString(),
                        "Внимание!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    }
                    // Вывод на Экран
                    else
                    {
                        label14.Text = storageCount.ToString() + "/" + boxCount.ToString();
                        label15.Text = runs.ToString() + "/" + totalBoxCount.ToString();
                        label16.Text = totalBoxPrice.ToString() + "$";
                    }
                // Расчет прибыли
               
                
            }
        }
    }
}
