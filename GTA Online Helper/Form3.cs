using System;
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
            radioButton1.Checked = true;
            radioButton2.Enabled = false;
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
                int totalBoxCount = 0;
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
                int box16 = 240000;
                int box19 = 285000;
                int box20 = 310000;
                int box24 = 341000;
                int box25 = 400000;
                int box29 = 464000;
                int box30 = 495000;
                int box34 = 561000;
                int box35 = 595000;
                int box39 = 663000;
                int box40 = 700000;
                int box42 = 735000;
                int box44 = 770000;
                int box45 = 798000;
                int box49 = 869700;
                int box50 = 900000;
                int box59 = 1062000;
                int box60 = 1095000;
                int box69 = 1259250;
                int box70 = 1295000;
                int box79 = 1461500;
                int box80 = 1500000;
                int box89 = 1668750;
                int box90 = 1710000;
                int box99 = 1881000;
                int box100 = 1950000;
                int box110 = 2145000;
                int box111 = 2222000;

                if (totalBoxCount == 1)
                {
                	int box = box1;
                }
                else if (totalBoxCount == 2)
                {
                	int box = box2;
                }
                else if (totalBoxCount == 3)
                {
                	int box = box3;
                }
                else if (totalBoxCount == 4)
                {
                	int box = box4;
                }
                else if (totalBoxCount == 5)
                {
                	int box = box5;
                }
                else if (totalBoxCount == 6)
                {
                	int box = box6;
                }
                else if (totalBoxCount == 7)
                {
                	int box = box7;
                }
                else if (totalBoxCount == 8)
                {
                	int box = box8;
                }
                else if (totalBoxCount == 9)
                {
                	int box = box9;
                }
                else if (totalBoxCount >= 10 && totalBoxCount <= 14)
                {
					//code
                	if (totalBoxCount == 10)
                	{
                	int box = box10;
                	}
                	else if (totalBoxCount == 11)
                	{
                		int box11 = 159500;
                		int box = box11;
                		radioButton1.Text = "Приблизительно";
                	}
                	else if (totalBoxCount == 12)
                	{
                		int box12 = 174000;
                		int box = box12;
                		radioButton1.Text = "Приблизительно";
                	}
                	else if (totalBoxCount == 13)
                	{
                		int box13 = 188500;
                        int box = box13;
                		radioButton1.Text = "Приблизительно";
                	}
                	else if (totalBoxCount == 14)
                	{
                		int box = box14;
                	}
                	//end code

				}
                else if (totalBoxCount == 15)
                {
                	int box = box15;
                }
                else if (totalBoxCount >= 16 && totalBoxCount <= 19)
                {
					//code

					//end code
				}
                else if (totalBoxCount >= 20 && totalBoxCount <= 24)
                {
					//code

					//end code
				}
                else if (totalBoxCount >= 25 && totalBoxCount <= 29)
                {
					//code

					//end code
				}
                else if (totalBoxCount >= 30 && totalBoxCount <= 34)
                {
					//code

					//end code
				}
				else if (totalBoxCount >= 35 && totalBoxCount <= 39)
				{
					//code

					//end code
				}
				else if (totalBoxCount >= 40 && totalBoxCount <= 42)
				{
					//code

					//end code
				}
				else if (totalBoxCount == 44)
				{
                	int box = box44;
                }
				else if (totalBoxCount >= 45 && totalBoxCount <= 49)
				{
					//code

					//end code
				}
				else if (totalBoxCount >= 50 && totalBoxCount <= 59)
				{
					//code

					//end code
				}
				else if (totalBoxCount >= 60 && totalBoxCount <= 69)
				{
					//code

					//end code
				}
				else if (totalBoxCount >= 70 && totalBoxCount <= 79)
				{
					//code

					//end code
				}
				else if (totalBoxCount >= 80 && totalBoxCount <= 89)
				{
					//code

					//end code
				}
				else if (totalBoxCount >= 90 && totalBoxCount <= 99)
				{
					//code

					//end code
				}
				else if (totalBoxCount == 100)
				{
                	int box = box100;
                }
				else if (totalBoxCount == 110)
				{
                	int box = box110;
                }
				else if (totalBoxCount == 111)
				{
                	int box = box111;
                }
                
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
