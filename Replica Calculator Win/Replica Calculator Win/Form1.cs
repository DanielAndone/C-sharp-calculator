using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float valoare;
        bool operatorApasat;
        string semnOperator;


        private void buton_click(object sender, EventArgs e)
        {
            if (rezultat.Text == "0" || (operatorApasat))
            {
                rezultat.Clear();
            }


            operatorApasat = false;
            Button b = (Button)sender;
            if (b.Text == ",")
            {
                if (!rezultat.Text.Contains(','))
                    rezultat.Text = rezultat.Text + b.Text;
            }
            else
                rezultat.Text = rezultat.Text + b.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if(valoare == 0)
            {
                semnOperator = b.Text;
                operatorApasat = true;
                valoare = float.Parse(rezultat.Text);
                ecuatie.Text = valoare + " " + semnOperator;
            }
            else
            {
                egalBtn.PerformClick();
                semnOperator = b.Text;
                operatorApasat = true;
                ecuatie.Text = valoare + " " + semnOperator;
                    
            }
        }

        private void egalBtn_Click(object sender, EventArgs e)
        {
            switch (semnOperator)
            {
                case "+":
                    rezultat.Text = (valoare + float.Parse(rezultat.Text)).ToString();
                    break;
                case "-":
                    rezultat.Text = (valoare - float.Parse(rezultat.Text)).ToString();
                    break;
                case "x":
                    rezultat.Text = (valoare * float.Parse(rezultat.Text)).ToString();
                    break;
                case "/":
                    rezultat.Text = (valoare / float.Parse(rezultat.Text)).ToString();
                    break;
                case "%":
                    rezultat.Text = (valoare % float.Parse(rezultat.Text)).ToString();
                    break;
                case "x^2":
                    valoare = float.Parse(rezultat.Text);
                    rezultat.Text = (valoare * valoare).ToString();
                    break;
                case "x/2":
                    valoare = float.Parse(rezultat.Text);
                    rezultat.Text = (valoare / 2).ToString();
                    break;
                case "√":
                    valoare = float.Parse(rezultat.Text);
                    rezultat.Text = (Math.Sqrt(valoare).ToString());
                    break;
                case "n!":

                    valoare = float.Parse(rezultat.Text);
                    int numar = 1;

                    if (valoare == 0 || valoare == 1)
                        rezultat.Text = numar.ToString();
                    else
                    { 
                        for (int i = 1; i <= valoare; i++)
                        {
                            numar *= i;
                        }
                        rezultat.Text = numar.ToString();
                    }
                    break;

                default:
                    break;
            }

            ecuatie.Text = "";
            valoare = float.Parse(rezultat.Text);
            semnOperator = "";

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            rezultat.Clear();
            ecuatie.Text = "";
            rezultat.Text = "0";
        }

        private void stergeBtn_Click(object sender, EventArgs e)
        {
            int taie = Int32.Parse(rezultat.Text) / 10;
            rezultat.Text = taie.ToString();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "1":
                    unu.PerformClick();
                    break;
                case "2":
                    doi.PerformClick();
                    break;
                case "3":
                    trei.PerformClick();
                    break;
                case "4":
                    patru.PerformClick();
                    break;
                case "5":
                    cinci.PerformClick();
                    break;
                case "6":
                    sase.PerformClick();
                    break;
                case "7":
                    sapte.PerformClick();
                    break;
                case "8":
                    opt.PerformClick();
                    break;
                case "9":
                    noua.PerformClick();
                    break;
                case "0":
                    zero.PerformClick();
                    break;
                case "+":
                    plus.PerformClick();
                    break;
                case "-":
                    minus.PerformClick();
                    break;
                case "x":
                    inmultire.PerformClick();
                    break;
                case "/":
                    impartire.PerformClick();
                    break;
                case "%":
                    procent.PerformClick();
                    break;
                case ",":
                    virgula.PerformClick();
                    break;
                case "BACKSPACE":
                    stergeBtn.PerformClick();
                    break;
                case "ENTER":
                    egalBtn.PerformClick();
                    break;
                default:
                    break;
            }
        }
        protected override bool ShowFocusCues
        {
            get
            {
                return false;
            }
        }
    }
}
