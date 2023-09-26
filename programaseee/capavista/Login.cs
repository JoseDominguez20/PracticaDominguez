using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capacontrolador;

namespace capavista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario;
            string cont;

            usuario = textBox1.Text;
            cont = textBox2.Text;



            controlador controlador = new controlador(); //intancia
            bool botonn = controlador.acceso(usuario,cont);

            if (botonn)
            {
                Menu ir = new Menu();//llamar
                ir.Show();//MOSTRAR


            }

            else

            {
                MessageBox.Show("NO HAY ACCESO");
            }
        }

    }
}
