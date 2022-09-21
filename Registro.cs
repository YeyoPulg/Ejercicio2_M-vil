using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Ejercicio2_Móvil
{
    public partial class pnlRegistro : Form
    {
        public pnlRegistro()
        {
            InitializeComponent();
        }

        private void pnlRegistro_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /*public struct dataRegistrada
        {
            public string nomUser;
            public string password;
            public string usuario;
            public string email;
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            pnlLogin newlogin = new pnlLogin();
            string nomUser = txtRegistrarNomUser.Text;
            string password = txtPass.Text;
            string usuario = txtUser.Text;
            string email = txtRegistrarEmail.Text;

            try
            {
                if (nomUser.Length.Equals(0) || password.Length.Equals(0) || usuario.Length.Equals(0) || email.Length.Equals(0))
                {
                    if (MessageBox.Show("Lo sentimos, algo salio mal en el Registro. ¿Desea registrar de nuevo?", "MENSAJE ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes))
                    {
                        limpiaregistro();
                    }
                    else
                    {
                        Close();
                        newlogin.Show();
                    }
                }
                else
                {
                    TextWriter registrarme = new StreamWriter(@"C:\U_WorkShop\C#\Desarrollo Móvil\Ejercicio2_Móvil\bin\Debug\" + txtUser.Text + ".txt", true);
                    registrarme.WriteLine(txtPass.Text);
                    registrarme.Close();

                    MessageBox.Show("Felicidades. Usuario Registrado!", "ESTADO DE REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    newlogin.Show();
                    this.Hide();
                }

            }catch(Exception x)
            {
                MessageBox.Show("Error al guardar información "+x," Error!");
            }

        }

        private void limpiaregistro()
        {
            txtRegistrarNomUser.Text = "";
            txtPass.Text = "";
            txtUser.Text = "";
            txtRegistrarEmail.Text = "";
        }
    }
}
