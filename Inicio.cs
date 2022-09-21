using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio2_Móvil
{

    public partial class pnlLogin : Form
    {  
        public pnlLogin()
        {
            InitializeComponent();
            //txtPass.Text = info.usuario ;
            //txtUser.Text =;
        }

        private void pnlLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //string predeterminadoUser = "yeyo";
            //string predeterminadoPass = "1234";
            //pnlRegistro rgs = new pnlRegistro();

            pnlPyR pyg = new pnlPyR();

            try
            {
                TextReader iniciar = new StreamReader(txtUser.Text + ".txt");

                //if ((txtUser.Text == predeterminadoUser) && (txtPass.Text == predeterminadoPass))
                //{
                //    MessageBox.Show("Sesión iniciada correctamente!!");
                //    limpiar();
                //    pyg.Show();
                //    this.Hide();

                //}
                //else
                if (/*(iniciar.ReadLine() == txtUser.Text) && */(iniciar.ReadLine() == txtPass.Text))
                {
                    MessageBox.Show("Sesión iniciada correctamente!!");
                    limpiar();
                    pyg.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No se pudo iniciar sesión :(");
                    limpiar();
                }
            }
            catch (Exception z)
            {
                MessageBox.Show("Hubo un Error." +
                    " Siempre Registrarse" + z, "Error!");
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea continuar con el registro?");
            pnlRegistro registrar = new pnlRegistro();
            registrar.Show();
            this.Hide();
            //Close();
        }
        private void limpiar()
        {
            txtUser.Text = "";
            txtPass.Text = "";
        }
    }
}
