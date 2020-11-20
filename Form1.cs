using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodoEvento
{
    public partial class Form1 : Form
    {
        double valor1, valor2;
        string operacion = "";
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Mimetodo_Click(object sender, EventArgs e)
        {
            string textoBoton= ((Button)sender).Text;
            switch (textoBoton)
            {
                case "R":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado = Math.Sqrt(valor1);
                    lblNumeros.Text = resultado +"";
                    break;
                case "Tan":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultadoATan = Math.Tan(valor1);
                    lblNumeros.Text = resultadoATan + "";
                    break;
                    case "Sin":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultadoASin = Math.Sin(valor1);
                    lblNumeros.Text = resultadoASin + "";
                    break;
                case "Cos":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultadoACos = Math.Cos(valor1);
                    lblNumeros.Text = resultadoACos + "";
                    break;
                case "Log":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultadoL10 = Math.Log10(valor1);
                    lblNumeros.Text = resultadoL10 + "";
                    break;
                case "Abs":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultadoAbs = Math.Abs(valor1);
                    lblNumeros.Text = resultadoAbs + "";
                    break;
                case "Exp":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Exp(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Flr":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Floor(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Rnd":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Round(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Trte":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Truncate(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Ceil":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Ceiling(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "+":
                   if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoBoton;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = "";
                    break;

                    case "-":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoBoton;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = "";
                    break;
                case "X":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoBoton;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = "";
                    break;
                case "/":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoBoton;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = "";
                    break;


                case "=" :
                    if(lblNumeros.Text=="")
                    {
                        break;
                    }
                    switch (operacion )
                    {
                        case "+":
                            valor2 = double.Parse(lblNumeros.Text);
                            lblNumeros.Text = (valor1 + valor2) + "";
                            break;
                        case "-":
                            valor2 = double.Parse(lblNumeros.Text);
                            lblNumeros.Text = (valor1 - valor2) + "";
                            break;
                        case "X":
                            valor2 = double.Parse(lblNumeros.Text);
                            lblNumeros.Text = (valor1 * valor2) + "";
                            break;
                        case "/":
                            valor2 = double.Parse(lblNumeros.Text);
                            lblNumeros.Text = (valor1 / valor2) + "";
                            break;
                    }
                    break;
                case "AC":
                    lblNumeros.Text = "";
                    break;
                case ".":
                    if(lblNumeros.Text.IndexOf(".")== -1)
                    {
                        lblNumeros.Text += textoBoton;
                    }
                    break;
                default:
                    lblNumeros.Text += textoBoton;
                    break;
            }
        }

        
    }
}
