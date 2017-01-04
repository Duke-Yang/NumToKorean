using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumToKorean
{
    public partial class Form1 : Form
    {
        int Num;
        String Korean;
        Functions func = new Functions();
        public Form1()
        {
            InitializeComponent();
        }

        private void TranslateButton_Click(object sender, EventArgs e)
        {
            if ((Num = func.NumCheck(textBox1.Text)) == -1)
            {
                ResultBox.Text = "Please Input Number";
            }
            else
            {
                if (Num < 1000)
                {
                    Korean = func.Translate(Num);
                    ResultBox.Text = Korean;
                }
                else
                {
                    ResultBox.Text = "Please Input under 1000";
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                TranslateButton_Click(sender, e);
            }
        }
    }

    public class Functions
    {
        public int NumCheck(string text)
        {
            int Num;
            bool IsNum = int.TryParse(text, out Num);
            if (IsNum)
                return Num;
            else
                return -1;
        }

        public String Translate(int Num)
        {
            String result = ".";
            String[] KoreanNum = {"영","일","이","삼","사","오","육","칠","팔","구","십","백"};
            int hundred, ten, one;

            hundred = Num / 100;
            ten = (Num % 100) / 10;
            one = (Num % 10) / 1;

            #region Matching
            if (hundred == 0)
            {
                if(ten == 0)
                {
                    result = KoreanNum[one];
                }
                else
                {
                    if (ten == 1)
                    {
                        result = KoreanNum[10];
                    }
                    else
                    {
                        result = KoreanNum[ten] + KoreanNum[10];
                    }
                    if (one != 0)
                    {
                        result = result + KoreanNum[one];
                    }
                }
            }
            else
            {
                if (hundred == 1)
                {
                    result = KoreanNum[11];
                }
                else
                {
                    result = KoreanNum[hundred] + KoreanNum[11];
                }

                if (ten == 0)
                {
                    if (one != 0)
                    {
                        result = result + KoreanNum[one];
                    }
                }
                else
                {
                    if (ten == 1)
                    {
                        result = result + KoreanNum[10];
                    }
                    else
                    {
                        result = result + KoreanNum[ten] + KoreanNum[10];
                    }
                    if (one != 0)
                    {
                        result = result + KoreanNum[one];
                    }
                }
            }
            #endregion
            return result;
        }
    }
}
