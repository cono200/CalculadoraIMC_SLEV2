using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraIMC_SLE3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        float imc;
        private void Button_Clicked(object sender, EventArgs e)
        {
           /* //DECLARAR VARIABLES
            var altura = float.Parse(Altura.Text);
            var peso = float.Parse(Peso.Text);
            ///REALIZAR EL CALCULO 
            var imc = peso / (altura * altura);
           */
           CalcularIMC(float.Parse(Peso.Text), float.Parse(Altura.Text));
            string resultado = "";
            if (imc < 18.5)
            {
                resultado = "Bajo peso";
            }
            else if (imc > 18.5 && imc < 24.9)
            {
                resultado = "Peso normal";
            }
            else if (imc >= 24.9 && imc <= 29.9)
            {
                resultado = "Sobre peso";
            }
            else if (imc > 29.9)
            {
                resultado = "Obesidad";
            }


            DisplayAlert("Resultado: ", resultado, "Quitar");


            //ENVIAR RESULTADO
            IMC.Text = imc.ToString();

        }

        private void CalcularIMC(float peso, float altura)
        {
            imc = (peso) / (altura * altura);
        }

        private void AlertSignalName(string v)
        {
            throw new NotImplementedException();
        }
    }
    }

