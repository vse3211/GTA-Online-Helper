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
				if (totalBoxCount == 1)
                {
                	int box = box1;
                	radioButton1.Enabled = true;
                	radioButton1.Checked = true;
					radioButton2.Enabled = false;
                }
                else if (totalBoxCount == 2)
                {
                	int box = box2;
                	radioButton1.Enabled = true;
                	radioButton1.Checked = true;
					radioButton2.Enabled = false;
                }
                else if (totalBoxCount == 3)
                {
                	int box = box3;
                	radioButton1.Enabled = true;
                	radioButton1.Checked = true;
					radioButton2.Enabled = false;
                }
                else if (totalBoxCount == 4)
                {
                	int box = box4;
                	radioButton1.Enabled = true;
                	radioButton1.Checked = true;
					radioButton2.Enabled = false;
                }
                else if (totalBoxCount == 5)
                {
                	int box = box5;
                	radioButton1.Enabled = true;
                	radioButton1.Checked = true;
					radioButton2.Enabled = false;
                }
                else if (totalBoxCount == 6)
                {
                	int box = box6;
                	radioButton1.Enabled = true;
                	radioButton1.Checked = true;
					radioButton2.Enabled = false;
                }
                else if (totalBoxCount == 7)
                {
                	int box = box7;
                	radioButton1.Enabled = true;
                	radioButton1.Checked = true;
					radioButton2.Enabled = false;
                }
                else if (totalBoxCount == 8)
                {
                	int box = box8;
                	radioButton1.Enabled = true;
                	radioButton1.Checked = true;
					radioButton2.Enabled = false;
                }
                else if (totalBoxCount == 9)
                {
                	int box = box9;
                	radioButton1.Enabled = true;
                	radioButton1.Checked = true;
					radioButton2.Enabled = false;
                }
                else if (totalBoxCount >= 10 && totalBoxCount <= 14)
                {
					//code
                	if (totalBoxCount == 10)
                	{
                		int box = box10;
                		radioButton1.Enabled = true;
                		radioButton1.Checked = true;
						radioButton2.Enabled = false;
                	}
                	else if (totalBoxCount == 11)
                	{
                		int box11 = 159500;
                		int box = box11;
                		radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                	}
                	else if (totalBoxCount == 12)
                	{
                		int box12 = 174000;
                		int box = box12;
                		radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                	}
                	else if (totalBoxCount == 13)
                	{
                		int box13 = 188500;
                        int box = box13;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                	}
                	else if (totalBoxCount == 14)
                	{
                		int box = box14;
                		radioButton1.Enabled = true;
                		radioButton1.Checked = true;
						radioButton2.Enabled = false;
                	}
                	//end code

				}
                else if (totalBoxCount == 15)
                {
                	int box = box15;
                	radioButton1.Enabled = true;
                	radioButton1.Checked = true;
					radioButton2.Enabled = false;
                }
                else if (totalBoxCount >= 16 && totalBoxCount <= 19)
                {
					//code
                	if (totalBoxCount == 16)
                	{
                		int box = box16;
                		radioButton1.Enabled = true;
                		radioButton1.Checked = true;
						radioButton2.Enabled = false;
                	}
                	else if (totalBoxCount == 17)
                	{
                		int box17 = 255000;
                		int box = box17;
                		radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                	}
                	else if (totalBoxCount == 18)
                	{
                		int box18 = 270000;
                		int box = box15;
                		radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                	}
                	else if (totalBoxCount == 19)
                	{
                        int box = box19;
                        radioButton1.Enabled = true;
						radioButton1.Checked = true;
						radioButton2.Enabled = false;
                	}

					//end code
				}
                else if (totalBoxCount >= 20 && totalBoxCount <= 24)
                {
					//code
                	if (totalBoxCount == 20)
					{
						int box = box20;
						radioButton1.Enabled = true;
						radioButton1.Checked = true;
						radioButton2.Enabled = false;
					}
					else if (totalBoxCount == 21)
					{
						int box21=317750;
						int box = box21;
						radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
					}
					else if (totalBoxCount == 22)
					{
						int box22=325500;
						int box = box22;
						radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
					}
					else if (totalBoxCount == 23)
					{
						int box23=333250;
						int box = box23;
						radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
					}
					else if (totalBoxCount == 24)
					{
						int box = box24;
						radioButton1.Enabled = true;
						radioButton1.Checked = true;
						radioButton2.Enabled = false;
					}
					//end code
				}
                else if (totalBoxCount >= 25 && totalBoxCount <= 29)
                {
					//code
					if (totalBoxCount == 25)
					{
						int box = box25;
						radioButton1.Enabled = true;
						radioButton1.Checked = true;
						radioButton2.Enabled = false;
					}
					else if (totalBoxCount == 26)
					{
						int box26=416000;
						int box = box26;
						radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
					}
					else if (totalBoxCount == 27)
					{
						int box27=432000;
						int box = box27;
						radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
					}
					else if (totalBoxCount == 28)
					{
						int box28=448000;
						int box = box28;
						radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
					}
					else if (totalBoxCount == 29)
					{
						int box = box29;
						radioButton1.Enabled = true;
						radioButton1.Checked = true;
						radioButton2.Enabled = false;
					}
					//end code
				}
                else if (totalBoxCount >= 30 && totalBoxCount <= 34)
                {
					//code
                    if (totalBoxCount == 30)
                    {
                        int box = box30;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
                    else if (totalBoxCount == 31)
                    {
                        int box31=484500;
                        int box = box31;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 32)
                    {
                        int box32=510000;
                        int box = box32;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 33)
                    {
                        int box33=535500;
                        int box = box33;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 34)
                    {
                        int box = box34;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
					//end code
				}
				else if (totalBoxCount >= 35 && totalBoxCount <= 39)
				{
					//code
                    if (totalBoxCount == 35)
                    {
                        int box = box35;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
                    else if (totalBoxCount == 36)
                    {
                        int box36=612000;
                        int box = box36;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 37)
                    {
                        int box37=629000;
                        int box = box37;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 38)
                    {
                        int box38=646000;
                        int box = box38;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 39)
                    {
                        int box = box39;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
					//end code
				}
				else if (totalBoxCount >= 40 && totalBoxCount <= 42)
				{
					//code
                    if (totalBoxCount == 40)
                    {
                        int box = box40;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
                    else if (totalBoxCount == 41)
                    {
                        int box41=717500;
                        int box = box41;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 42)
                    {
                        int box = box42;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
					//end code
				}
				else if (totalBoxCount == 44)
				{
                	int box = box44;
                	radioButton1.Enabled = true;
                	radioButton1.Checked = true;
					radioButton2.Enabled = false;
                }
				else if (totalBoxCount >= 45 && totalBoxCount <= 49)
				{
					//code
                    if (totalBoxCount == 45)
                    {
                        int box = box45;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
                    else if (totalBoxCount == 46)
                    {
                        int box46=815925;
                        int box = box46;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 47)
                    {
                        int box47=833850;
                        int box = box47;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 48)
                    {
                        int box48=851775;
                        int box = box48;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 49)
                    {
                        int box = box49;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
					//end code
				}
				else if (totalBoxCount >= 50 && totalBoxCount <= 59)
				{
					//code
                    if (totalBoxCount == 50)
                    {
                        int box = box50;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
                    else if (totalBoxCount == 51)
                    {
                        int box51=918000;
                        int box = box51;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 52)
                    {
                        int box52=936000;
                        int box = box52;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 53)
                    {
                        int box53=954000;
                        int box = box53;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 54)
                    {
                        int box54=972000;
                        int box = box54;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 55)
                    {
                        int box55=990000;
                        int box = box55;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 56)
                    {
                        int box56=1008000;
                        int box = box56;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 57)
                    {
                        int box57=1026000;
                        int box = box57;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 58)
                    {
                        int box58=1044000;
                        int box = box58;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 59)
                    {
                        int box = box59;
                        radioButton1.Enabled = true;
                		radioButton1.Checked = true;
						radioButton2.Enabled = false;
                    }
					//end code
				}
				else if (totalBoxCount >= 60 && totalBoxCount <= 69)
				{
					//code
                    if (totalBoxCount == 60)
                    {
                        int box = box60;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
                    else if (totalBoxCount == 61)
                    {
                        int box61=1113250;
                        int box = box61;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 62)
                    {
                        int box62=1131500;
                        int box = box62;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 63)
                    {
                        int box63=1149750;
                        int box = box63;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 64)
                    {
                        int box64=1168000;
                        int box = box64;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 65)
                    {
                        int box65=1186250;
                        int box = box65;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 66)
                    {
                        int box66=1204500;
                        int box = box66;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 67)
                    {
                        int box67=1222750;
                        int box = box67;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 68)
                    {
                        int box68=1241000;
                        int box = box68;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 69)
                    {
                        int box = box69;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
					//end code
				}
				else if (totalBoxCount >= 70 && totalBoxCount <= 79)
				{
					//code
                    if (totalBoxCount == 70)
                    {
                        int box = box70;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
                    else if (totalBoxCount == 71)
                    {
                        int box71=1281500;
                        int box = box71;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 72)
                    {
                        int box72=1304000;
                        int box = box72;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 73)
                    {
                        int box73=1326500;
                        int box = box73;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 74)
                    {
                        int box74=1349000;
                        int box = box74;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 75)
                    {
                        int box75=1371500;
                        int box = box75;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 76)
                    {
                        int box76=1394000;
                        int box = box76;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 77)
                    {
                        int box77=1416500;
                        int box = box77;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 78)
                    {
                        int box78=1439000;
                        int box = box78;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 79)
                    {
                        int box = box79;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
					//end code
				}
				else if (totalBoxCount >= 80 && totalBoxCount <= 89)
				{
					//code
                    if (totalBoxCount == 80)
                    {
                        int box = box80;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
                    else if (totalBoxCount == 81)
                    {
                        int box81=1518750;
                        int box = box81;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 82)
                    {
                        int box82=1537500;
                        int box = box82;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 83)
                    {
                        int box83=1556250;
                        int box = box83;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 84)
                    {
                        int box84=1575000;
                        int box = box84;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 85)
                    {
                        int box85=1593750;
                        int box = box85;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 86)
                    {
                        int box86=1612500;
                        int box = box86;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 87)
                    {
                        int box87=1631250;
                        int box = box87;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 88)
                    {
                        int box88=1650000;
                        int box = box88;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 89)
                    {
                        int box = box89;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
					//end code
				}
				else if (totalBoxCount >= 90 && totalBoxCount <= 99)
				{
					//code
                    if (totalBoxCount == 90)
                    {
                        int box = box90;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
                    else if (totalBoxCount == 91)
                    {
                        int box91=1729000;
                        int box = box91;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 92)
                    {
                        int box92=1748000;
                        int box = box92;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 93)
                    {
                        int box93=1767000;
                        int box = box93;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 94)
                    {
                        int box94=1786000;
                        int box = box94;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 95)
                    {
                        int box95=1805000;
                        int box = box95;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 96)
                    {
                        int box96=1824000;
                        int box = box96;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 97)
                    {
                        int box97=1843000;
                        int box = box97;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 98)
                    {
                        int box98=1862000;
                        int box = box98;
                        radioButton2.Enabled = true;
                		radioButton2.Checked = true;
						radioButton1.Enabled = false;
                    }
                    else if (totalBoxCount == 99)
                    {
                        int box = box99;
                        radioButton1.Enabled = true;
                        radioButton1.Checked = true;
                        radioButton2.Enabled = false;
                    }
					//end code
				}
				else if (totalBoxCount == 100)
				{
                	int box = box100;
                	radioButton1.Enabled = true;
                	radioButton1.Checked = true;
					radioButton2.Enabled = false;
                }
				else if (totalBoxCount == 110)
				{
                	int box = box110;
                	radioButton1.Enabled = true;
                	radioButton1.Checked = true;
					radioButton2.Enabled = false;
                }
				else if (totalBoxCount == 111)
				{
                	int box = box111;
                	radioButton1.Enabled = true;
                	radioButton1.Checked = true;
					radioButton2.Enabled = false;
                }



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
