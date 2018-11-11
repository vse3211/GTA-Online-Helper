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
            	// Объявляем значения
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
                int income = 0;
                int clearIncome = 0;
                int boxOnCargo = 0;

                int box = 0;
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

                // Расчет количества ящиков на склады
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

                if (totalBoxCount > 110)
                {
                	boxOnCargo = totalBoxCount / storageCount;
                }
                else if (totalBoxCount <= 110)
                {
                	boxOnCargo = totalBoxCount;
                }

                // Debug message
                if (boxOnCargo > 110)
                {
                	MessageBox.Show(
					boxOnCargo.ToString(),
					"boxOnCargo Debug",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning,
					MessageBoxDefaultButton.Button1,
					MessageBoxOptions.DefaultDesktopOnly);
                }
				

                // Проверка стоимостей
				if (boxOnCargo == 1)
                {
                	box = box1;
                	radioButton1.Enabled = true;
                	radioButton1.Checked = true;
					radioButton2.Enabled = false;
                }
                else if (boxOnCargo == 2)
                {
                	box = box2;
                	radioButton1.Enabled = true;
                	radioButton1.Checked = true;
					radioButton2.Enabled = false;
                }
                else if (boxOnCargo == 3)
                {
                	box = box3;
                	radioButton1.Enabled = true;
                	radioButton1.Checked = true;
					radioButton2.Enabled = false;
                }
                else if (boxOnCargo == 4)
                {
                	box = box4;
                	radioButton1.Enabled = true;
                	radioButton1.Checked = true;
					radioButton2.Enabled = false;
                }
                else if (boxOnCargo == 5)
                {
                	box = box5;
                	radioButton1.Enabled = true;
                	radioButton1.Checked = true;
					radioButton2.Enabled = false;
                }
                else if (boxOnCargo == 6)
                {
                	box = box6;
                	radioButton1.Enabled = true;
                	radioButton1.Checked = true;
					radioButton2.Enabled = false;
                }
                else if (boxOnCargo == 7)
                {
                	box = box7;
                	radioButton1.Enabled = true;
                	radioButton1.Checked = true;
					radioButton2.Enabled = false;
                }
                else if (boxOnCargo == 8)
                {
                	box = box8;
                	radioButton1.Enabled = true;
                	radioButton1.Checked = true;
					radioButton2.Enabled = false;
                }
                else if (boxOnCargo == 9)
                {
                	box = box9;
                	radioButton1.Enabled = true;
                	radioButton1.Checked = true;
					radioButton2.Enabled = false;
                }
                else if (boxOnCargo >= 10 && boxOnCargo <= 14)
                {
					//code
                	if (boxOnCargo == 10)
                	{
                		box = box10;
                		radioButton1.Enabled = true;
                		radioButton1.Checked = true;
						radioButton2.Enabled = false;
                	}
                	else if (boxOnCargo == 11)
                	{
                		int box11 = 159500;
                		box = box11;
                		radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                	}
                	else if (boxOnCargo == 12)
                	{
                		int box12 = 174000;
                		box = box12;
                		radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                	}
                	else if (boxOnCargo == 13)
                	{
                		int box13 = 188500;
                        box = box13;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                	}
                	else if (boxOnCargo == 14)
                	{
                		box = box14;
                		radioButton1.Enabled = true;
                		radioButton1.Checked = true;
						radioButton2.Enabled = false;
                	}
                	//end code

				}
                else if (boxOnCargo == 15)
                {
                	box = box15;
                	radioButton1.Enabled = true;
                	radioButton1.Checked = true;
					radioButton2.Enabled = false;
                }
                else if (boxOnCargo >= 16 && boxOnCargo <= 19)
                {
					//code
                	if (boxOnCargo == 16)
                	{
                		box = box16;
                		radioButton1.Enabled = true;
                		radioButton1.Checked = true;
						radioButton2.Enabled = false;
                	}
                	else if (boxOnCargo == 17)
                	{
                		int box17 = 255000;
                		box = box17;
                		radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                	}
                	else if (boxOnCargo == 18)
                	{
                		int box18 = 270000;
                		box = box18;
                		radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                	}
                	else if (boxOnCargo == 19)
                	{
                        box = box19;
                        radioButton1.Enabled = true;
						radioButton1.Checked = true;
						radioButton2.Enabled = false;
                	}

					//end code
				}
                else if (boxOnCargo >= 20 && boxOnCargo <= 24)
                {
					//code
                	if (boxOnCargo == 20)
					{
						box = box20;
						radioButton1.Enabled = true;
						radioButton1.Checked = true;
						radioButton2.Enabled = false;
					}
					else if (boxOnCargo == 21)
					{
						int box21=317750;
						box = box21;
						radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
					}
					else if (boxOnCargo == 22)
					{
						int box22=325500;
						box = box22;
						radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
					}
					else if (boxOnCargo == 23)
					{
						int box23=333250;
						box = box23;
						radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
					}
					else if (boxOnCargo == 24)
					{
						box = box24;
						radioButton1.Enabled = true;
						radioButton1.Checked = true;
						radioButton2.Enabled = false;
					}
					//end code
				}
                else if (boxOnCargo >= 25 && boxOnCargo <= 29)
                {
					//code
					if (boxOnCargo == 25)
					{
						box = box25;
						radioButton1.Enabled = true;
						radioButton1.Checked = true;
						radioButton2.Enabled = false;
					}
					else if (boxOnCargo == 26)
					{
						int box26=416000;
						box = box26;
						radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
					}
					else if (boxOnCargo == 27)
					{
						int box27=432000;
						box = box27;
						radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
					}
					else if (boxOnCargo == 28)
					{
						int box28=448000;
						box = box28;
						radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
					}
					else if (boxOnCargo == 29)
					{
						box = box29;
						radioButton1.Enabled = true;
						radioButton1.Checked = true;
						radioButton2.Enabled = false;
					}
					//end code
				}
                else if (boxOnCargo >= 30 && boxOnCargo <= 34)
                {
					//code
                    if (boxOnCargo == 30)
                    {
                        box = box30;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
                    else if (boxOnCargo == 31)
                    {
                        int box31=484500;
                        box = box31;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 32)
                    {
                        int box32=510000;
                        box = box32;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 33)
                    {
                        int box33=535500;
                        box = box33;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 34)
                    {
                        box = box34;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
					//end code
				}
				else if (boxOnCargo >= 35 && boxOnCargo <= 39)
				{
					//code
                    if (boxOnCargo == 35)
                    {
                        box = box35;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
                    else if (boxOnCargo == 36)
                    {
                        int box36=612000;
                        box = box36;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 37)
                    {
                        int box37=629000;
                        box = box37;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 38)
                    {
                        int box38=646000;
                        box = box38;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 39)
                    {
                        box = box39;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
					//end code
				}
				else if (boxOnCargo >= 40 && boxOnCargo <= 42)
				{
					//code
                    if (boxOnCargo == 40)
                    {
                        box = box40;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
                    else if (boxOnCargo == 41)
                    {
                        int box41=717500;
                        box = box41;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 42)
                    {
                        box = box42;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
					//end code
				}
				else if (boxOnCargo == 44)
				{
                	box = box44;
                	radioButton1.Enabled = true;
                	radioButton1.Checked = true;
					radioButton2.Enabled = false;
                }
				else if (boxOnCargo >= 45 && boxOnCargo <= 49)
				{
					//code
                    if (boxOnCargo == 45)
                    {
                        box = box45;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
                    else if (boxOnCargo == 46)
                    {
                        int box46=815925;
                        box = box46;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 47)
                    {
                        int box47=833850;
                        box = box47;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 48)
                    {
                        int box48=851775;
                        box = box48;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 49)
                    {
                        box = box49;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
					//end code
				}
				else if (boxOnCargo >= 50 && boxOnCargo <= 59)
				{
					//code
                    if (boxOnCargo == 50)
                    {
                        box = box50;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
                    else if (boxOnCargo == 51)
                    {
                        int box51=918000;
                        box = box51;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 52)
                    {
                        int box52=936000;
                        box = box52;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 53)
                    {
                        int box53=954000;
                        box = box53;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 54)
                    {
                        int box54=972000;
                        box = box54;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 55)
                    {
                        int box55=990000;
                        box = box55;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 56)
                    {
                        int box56=1008000;
                        box = box56;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 57)
                    {
                        int box57=1026000;
                        box = box57;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 58)
                    {
                        int box58=1044000;
                        box = box58;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 59)
                    {
                        box = box59;
                        radioButton1.Enabled = true;
                		radioButton1.Checked = true;
						radioButton2.Enabled = false;
                    }
					//end code
				}
				else if (boxOnCargo >= 60 && boxOnCargo <= 69)
				{
					//code
                    if (boxOnCargo == 60)
                    {
                        box = box60;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
                    else if (boxOnCargo == 61)
                    {
                        int box61=1113250;
                        box = box61;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 62)
                    {
                        int box62=1131500;
                        box = box62;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 63)
                    {
                        int box63=1149750;
                        box = box63;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 64)
                    {
                        int box64=1168000;
                        box = box64;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 65)
                    {
                        int box65=1186250;
                        box = box65;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 66)
                    {
                        int box66=1204500;
                        box = box66;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 67)
                    {
                        int box67=1222750;
                        box = box67;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 68)
                    {
                        int box68=1241000;
                        box = box68;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 69)
                    {
                        box = box69;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
					//end code
				}
				else if (boxOnCargo >= 70 && boxOnCargo <= 79)
				{
					//code
                    if (boxOnCargo == 70)
                    {
                        box = box70;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
                    else if (boxOnCargo == 71)
                    {
                        int box71=1281500;
                        box = box71;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 72)
                    {
                        int box72=1304000;
                        box = box72;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 73)
                    {
                        int box73=1326500;
                        box = box73;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 74)
                    {
                        int box74=1349000;
                        box = box74;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 75)
                    {
                        int box75=1371500;
                        box = box75;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 76)
                    {
                        int box76=1394000;
                        box = box76;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 77)
                    {
                        int box77=1416500;
                        box = box77;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 78)
                    {
                        int box78=1439000;
                        box = box78;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 79)
                    {
                        box = box79;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
					//end code
				}
				else if (boxOnCargo >= 80 && boxOnCargo <= 89)
				{
					//code
                    if (boxOnCargo == 80)
                    {
                        box = box80;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
                    else if (boxOnCargo == 81)
                    {
                        int box81=1518750;
                        box = box81;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 82)
                    {
                        int box82=1537500;
                        box = box82;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 83)
                    {
                        int box83=1556250;
                        box = box83;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 84)
                    {
                        int box84=1575000;
                        box = box84;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 85)
                    {
                        int box85=1593750;
                        box = box85;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 86)
                    {
                        int box86=1612500;
                        box = box86;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 87)
                    {
                        int box87=1631250;
                        box = box87;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 88)
                    {
                        int box88=1650000;
                        box = box88;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 89)
                    {
                        box = box89;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
					//end code
				}
				else if (boxOnCargo >= 90 && boxOnCargo <= 99)
				{
					//code
                    if (boxOnCargo == 90)
                    {
                        box = box90;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
                    else if (boxOnCargo == 91)
                    {
                        int box91=1729000;
                        box = box91;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 92)
                    {
                        int box92=1748000;
                        box = box92;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 93)
                    {
                        int box93=1767000;
                        box = box93;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 94)
                    {
                        int box94=1786000;
                        box = box94;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 95)
                    {
                        int box95=1805000;
                        box = box95;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 96)
                    {
                        int box96=1824000;
                        box = box96;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 97)
                    {
                        int box97=1843000;
                        box = box97;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 98)
                    {
                        int box98=1862000;
                        box = box98;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (boxOnCargo == 99)
                    {
                        box = box99;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
					//end code
				}
				else if (boxOnCargo == 100)
				{
                	box = box100;
                	radioButton1.Enabled = true;
                	radioButton1.Checked = true;
					radioButton2.Enabled = false;
                }
				else if (boxOnCargo == 110)
				{
                	box = box110;
                	radioButton1.Enabled = true;
                	radioButton1.Checked = true;
					radioButton2.Enabled = false;
                }
				else if (boxOnCargo == 111)
				{
                	box = box111;
                	radioButton1.Enabled = true;
                	radioButton1.Checked = true;
					radioButton2.Enabled = false;
                }

                if (totalBoxCount > 110)
                {
                	income = box * storageCount;
                }
                else if (totalBoxCount <= 110)
                {
                    income = box;
                }

                // Расчет прибыли
                clearIncome = income - totalBoxPrice;

                // Вывод на экран
                label14.Text = storageCount.ToString() + "/" + boxCount.ToString();
                label15.Text = runs.ToString() + "/" + totalBoxCount.ToString();
                label16.Text = totalBoxPrice.ToString() + "$";
                label17.Text = income.ToString() + "$";
                label18.Text = clearIncome.ToString() + "$";
            }
        }
    }
}
