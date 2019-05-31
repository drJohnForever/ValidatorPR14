using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Validator
{
    public partial class Form1 : Form
    {
        TextBox[] TBs;
        PictureBox[] PBs;
        String[] Regs;
        String[] PlatSystem = new string[10] {"Unknown", "Мир", "American Express", "Visa", "MasterCard", "Maestro", "УЭК", "Unknown", "Unknown", "Unknown" };
        String[] Banks = new string[5] { "Сбербанк", "ВТБ", "ГазпромБанк", "Тинькофф", "Альфа-банк" };
        enum atr
        {
            Name, Num, Mail, Pass, PassReply
        }

        public Form1()
        {
            InitializeComponent();
            TBPass.UseSystemPasswordChar = TBPassReply.UseSystemPasswordChar = true;
            TBs = new TextBox[4] { TBName, TBNum, TBMail, TBPass };
            PBs = new PictureBox[4] { PBName, PBNum, PBMail, PBPass };
            Regs = new string[4] { patName, patNum, patMail, patPass };
        }

        string patName = @"^[a-zA-Z][a-zA-Z0-9-_\.]{1,20}$";
        string patCard = @"[0-9]{16}";
        string patMail = @"^[-\w.]+@([A-z0-9][-A-z0-9]+\.)+[A-z]{2,4}$";
        string patPass = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";
        string patNum = @"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$";
        string CardSystem = "Платежная система: {0}, Банк: {1}";


        private void button1_Click(object sender, EventArgs e)
        {
            PBPass.Visible = PBName.Visible = PBMail.Visible = PBCard.Visible = PBNum.Visible = true;
            label8.Visible = TBPass.Text != TBPassReply.Text && TBPassReply.Text != string.Empty;
            for (byte i = 0; i < PBs.Length; i++)
                PBs[i].Image = Regex.IsMatch(TBs[i].Text, Regs[i], RegexOptions.IgnoreCase) &&
                    TBs[i].Text != String.Empty ? Properties.Resources._true : Properties.Resources._false;
            PBCard.Image = Regex.IsMatch(MTBCard.Text.Replace(" ", ""), patCard, RegexOptions.IgnoreCase)
                && MTBCard.Text != string.Empty ? Properties.Resources._true : Properties.Resources._false;
            string temp = "Unknown";
            switch((new Regex(@"\d{4}$").Match(MTBCard.Text)).ToString())
            {
                case "2022": temp = Banks[0]; break;
                case "5438": temp = Banks[1]; break;
                case "7645": temp = Banks[2]; break;
                case "5369": temp = Banks[3]; break;
                case "5217": temp = Banks[4]; break;
            }
            if (Regex.IsMatch(MTBCard.Text.Replace(" ", ""), patCard, RegexOptions.IgnoreCase) && MTBCard.Text != string.Empty)
                label9.Text = string.Format(CardSystem, PlatSystem[Convert.ToInt32(new Regex(@"\d").Match(MTBCard.Text).ToString())], temp);
            else label9.Text = string.Empty;
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            TBPass.UseSystemPasswordChar = TBPassReply.UseSystemPasswordChar = false;
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            TBPass.UseSystemPasswordChar = TBPassReply.UseSystemPasswordChar = true;           
        }

        private void TBNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '(') && (e.KeyChar != ')') && (e.KeyChar != '+') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}
