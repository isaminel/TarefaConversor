using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarefaConversor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            boxDecimal.Text = "";
            boxHexa.Text = "";
            boxOctal.Text = "";
            boxBinario.Text = "";
            textNr.Text = "";   
        }

        private void botaoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        

        private void radioBinario_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioDecimal_CheckedChanged(object sender, EventArgs e)
        {            
        }

        private void radioOctal_CheckedChanged(object sender, EventArgs e)
        {            
        }

        private void radioHexa_CheckedChanged(object sender, EventArgs e)
        {           
        }

        private void botaoConverter_Click(object sender, EventArgs e)
        {
            
            if (radioDecimal.Checked)
            {
                int nr = (Convert.ToInt32(textNr.Text));
                
                if (nr == 0)

                boxDecimal.Text = textNr.Text;
                boxBinario.Text = DecimalBinario(nr);
                boxOctal.Text = DecimalOctal(nr);
                boxHexa.Text = DecimalHexa(nr);

            } else if (radioHexa.Checked)            {
                
                boxHexa.Text = textNr.Text;
                boxDecimal.Text = HexaDecimal(textNr.Text);
                boxOctal.Text = DecimalOctal(Convert.ToInt32(HexaDecimal(textNr.Text)));
                boxBinario.Text = DecimalBinario(Convert.ToInt32(HexaDecimal(textNr.Text)));

            } else if (radioOctal.Checked)
            {
                int nr = (Convert.ToInt32(textNr.Text));

                boxOctal.Text = textNr.Text;
                boxDecimal.Text = OctalDecimal(nr).ToString();
                boxBinario.Text = DecimalBinario(OctalDecimal(nr));
                boxHexa.Text = DecimalHexa(OctalDecimal(nr));

            } else if (radioBinario.Checked)
            {
                int nr = (Convert.ToInt32(textNr.Text));

                /*if (!textNr.Text.Contains('1') || textNr.Text.Contains('0'))
                { } */
                    boxBinario.Text = textNr.Text;
                    boxDecimal.Text = BinarioDecimal(nr).ToString();
                    boxOctal.Text = DecimalOctal(BinarioDecimal(nr));
                    boxHexa.Text = DecimalHexa(BinarioDecimal(nr));
                 
            }
        }

        public string DecimalBinario(int nr)
        {
            decimal dividendo = nr;
            decimal resto = decimal.MaxValue;
            int quociente = int.MaxValue;
            int divisor = 2;
            string result = string.Empty;

            List<int> listaValorBinario = new List<int>();

            while (dividendo > 2)
            {
                resto = dividendo % divisor;
                quociente = (int)dividendo / divisor;
                dividendo = quociente;
                listaValorBinario.Add(Convert.ToInt32(resto));
            }

            if (dividendo == 2)
            {
                listaValorBinario.Add(0);
                listaValorBinario.Add(1);
            } else if (dividendo == 0)
            {
                listaValorBinario.Add(0);
            } else
            {
                listaValorBinario.Add(1);
            }

            listaValorBinario.Reverse();
            foreach (int valor in listaValorBinario)
            {
                result = result + "" + valor;
            }

            return result;
        }


        public static string InverterString(string str) // usar no BinarioDecimal
        {

            int tamanho = str.Length;
            char[] caracteres = new char[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                caracteres[i] = str[tamanho - 1 - i];

            }
            return new string(caracteres);

        }




        public int BinarioDecimal(int nr)        {

            int expoente = 0;
            int numero;
            int soma =  0;

            string numeroInvertido = InverterString(textNr.Text);

            for (int i = 0; i < numeroInvertido.Length; i++)
            {

                numero = Convert.ToInt32(numeroInvertido.Substring(i, 1));
                soma += numero * (int)Math.Pow(2, expoente);
                expoente++;

            }

            return soma;

        }


        public string DecimalOctal(int nr)
        {

            int dividendo = nr;
            int resto = int.MaxValue;
            int quociente = int.MaxValue;
            int divisor = 8;
            string result = string.Empty;

            List<int> listaValorOctal = new List<int>();

            while (dividendo > 8)
            {
                resto = dividendo % divisor;
                quociente = (int)dividendo / divisor;
                dividendo = quociente;
                listaValorOctal.Add(resto);
            }

            if (dividendo == 8)
            {
                listaValorOctal.Add(0);
                listaValorOctal.Add(1);
            }
            else
            {
                listaValorOctal.Add(dividendo);
            }

            listaValorOctal.Reverse();
            foreach (int valor in listaValorOctal)
            {
                result = result + "" + valor;
            }

            return result;

        }

        public int OctalDecimal(int nr)
        {

            int expoente = 0;
            int numero;
            int soma = 0;


            string numeroInvertido = InverterString(textNr.Text);

            for (int i = 0; i < numeroInvertido.Length; i++)
            {

                numero = Convert.ToInt32(numeroInvertido.Substring(i, 1));
                soma += numero * (int)Math.Pow(8, expoente);
                expoente++;

            }

            return soma;

        }

        public string DecimalHexa(int nr)
        {

            int dividendo = nr;
            int divisor = 16;
            string result = string.Empty;

            List<int> listaValorConvertido = new List<int>();

            while (dividendo >= divisor)
            {
                int resto = dividendo % divisor;
                dividendo = (int)dividendo / divisor;

                listaValorConvertido.Add(Convert.ToInt32(resto));

            }

            listaValorConvertido.Add((int)Math.Floor((double)dividendo));


            List<string> listaHexa = new List<string>();

            foreach (int valor in listaValorConvertido)
            {
                if (valor == 10)
                {
                    listaHexa.Add("A");
                }
                else if (valor == 11)
                {
                    listaHexa.Add("B");
                }
                else if (valor == 12)
                {
                    listaHexa.Add("C");
                }
                else if (valor == 13)
                {
                    listaHexa.Add("D");
                }
                else if (valor == 14)
                {
                    listaHexa.Add("E");
                }
                else if (valor == 15)
                {
                    listaHexa.Add("F");
                }
                else
                {
                    listaHexa.Add(valor + string.Empty);
                }

            }

            listaHexa.Reverse();
            foreach (string valor in listaHexa)
            {
                result = result + "" + valor;
            }
            return result;
        }

        public string HexaDecimal(string nr)
        {            
            string result = string.Empty;
            nr = nr.ToUpper();
            nr = InverterString(nr);
            double valorDecimal = 0;

            for (int i = 0; i < nr.Length; i++)
            {
                if (nr.Substring(i, 1).Equals("A"))
                {
                    valorDecimal = valorDecimal + Convert.ToInt32(10 * Math.Pow(16, i));
                }
                else if (nr.Substring(i, 1).Equals("B"))
                {
                    valorDecimal = valorDecimal + Convert.ToInt32(11 * Math.Pow(16, i));
                }
                else if (nr.Substring(i, 1).Equals("C"))
                {
                    valorDecimal = valorDecimal + Convert.ToInt32(12 * Math.Pow(16, i));
                }
                else if (nr.Substring(i, 1).Equals("D"))
                {
                    valorDecimal = valorDecimal + Convert.ToInt32(13 * Math.Pow(16, i));
                }
                else if (nr.Substring(i, 1).Equals("E"))
                {
                    valorDecimal = valorDecimal + Convert.ToInt32(14 * Math.Pow(16, i));
                }
                else if (nr.Substring(i, 1).Equals("F"))
                {
                    valorDecimal = valorDecimal + Convert.ToInt32(15 * Math.Pow(16, i));
                }
                else
                {
                    double a = Convert.ToInt32(nr.Substring(i, 1));
                    valorDecimal = valorDecimal + Convert.ToInt32(a * Math.Pow(16, i));
                }
            }

            return valorDecimal + string.Empty;
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void textNr_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxBinario_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void boxDecimal_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxHexa_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxOctal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
