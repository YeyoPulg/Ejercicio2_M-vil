using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2_Móvil
{
    public partial class pnlPyR : Form
    {
        int resultado = 0;
        int seleccion = 1;

        public pnlPyR()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Iniciar()
        {
            if (MessageBox.Show("Bienvenido al juego de Preguntas y Respuestas", "QUIEN QUIERE SER MILLONARIO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.txtPregunta.Text = "¿Si te dictan el siguiente número como lo interpretarias? -dos cuatro dos cero-.";
                this.txtRespuesta1.Text = "2420";
                this.txtRespuesta2.Text = "2400";
                this.txtRespuesta3.Text = "4400";
                this.txtRespuesta4.Text = "4420";
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pregunta2()
        {
            this.txtPregunta.Text = "¿Que es una cebra?";
            this.txtRespuesta1.Text = "Un caballo blanco con lineas negras";
            this.txtRespuesta2.Text = "Un caballo negro con lineas blancas";
            this.txtRespuesta3.Text = "Un camino de lineas que indica el cruce de peatones";
            this.txtRespuesta4.Text = "Todas las anteriores";
            seleccion++;
        }
        private void pregunta3()
        {
            this.txtPregunta.Text = "¿Que significa la palabra PERICO en COLOMBIA?";
            this.txtRespuesta1.Text = "Una arepa con huevo con cebolla y tomate";
            this.txtRespuesta2.Text = "Una droga, que mata el alma y la envenena";
            this.txtRespuesta3.Text = "Un pajaro de colores";
            this.txtRespuesta4.Text = "Un café con leche";
            seleccion++;
        }
        private void pregunta4()
        {
            this.txtPregunta.Text = "¿Palabra con la que más mienten las mujeres?";
            this.txtRespuesta1.Text = "Te amo";
            this.txtRespuesta2.Text = "Eres el único para mí";
            this.txtRespuesta3.Text = "Es solo un amigo gay";
            this.txtRespuesta4.Text = "Todos los hombres son iguales";
            seleccion++;
        }
        private void pregunta5()
        {
            this.txtPregunta.Text = "¿Poque la pizza es redonda, la caja cuadrada y las porciones triangulares?";
            this.txtRespuesta1.Text = "Todo queda calculado";
            this.txtRespuesta2.Text = "Para aparentar tamaño";
            this.txtRespuesta3.Text = "La belleza de las Matematicas y Trigonometria";
            this.txtRespuesta4.Text = "Eso no importa, la cuestion es de hambre";
            seleccion++;
        }


        private void Limpiar()
        {
            this.Opcion1.Checked = true;
        }

        private void button4_Click(object sender, EventArgs e) //BOTON SIGUIENTE
        {
            switch (seleccion)
            {
                case 1:
                    if (this.Opcion1.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta2();
                    Limpiar();
                    break;

                case 2:
                    if (this.Opcion4.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta3();
                    Limpiar();
                    break;

                case 3:
                    if (this.Opcion3.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta4();
                    Limpiar();
                    break;

                case 4:
                    if (this.Opcion2.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta5();
                    Limpiar();
                    break;

                case 5:
                    if (this.Opcion3.Checked == true)
                    {
                        resultado++;
                    }

                    if (resultado >= 3)
                    {
                        MessageBox.Show("Tu Resultado: "+resultado.ToString(), "FELICITACIONES!! Buen Resultado ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("DEBES SER MAS AVISPADO... Tu Resultado: "+resultado.ToString(), "ESTUVO CERCA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
