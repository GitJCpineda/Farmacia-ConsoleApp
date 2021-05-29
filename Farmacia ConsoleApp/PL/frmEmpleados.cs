using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Referencia a carpeta BLL
using Farmacia_ConsoleApp.BLL;
using Farmacia_ConsoleApp.DAL;


namespace Farmacia_ConsoleApp.PL
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Instrucciones GUI (update Info PL)
            RecuperarInformacion();
            conexionDAL conexion = new conexionDAL();//instancia objeto
            //return bool
            MessageBox.Show("Conectado..." + conexion.PruebaConectar());

        }

        private void RecuperarInformacion()//metodo para instancia (para dispocision de elementos)
        {
            //instancia objeto empleado
            EmpleadosBLL oEmpleados = new EmpleadosBLL();

            int ID = 0; int.TryParse(txtID.Text, out ID);

            oEmpleados.ID = ID;

            oEmpleados.Nombre = txtNombre.Text;

            //metodo para verificar que regresan valores

            MessageBox.Show(oEmpleados.ID.ToString());
            MessageBox.Show(oEmpleados.Nombre);


        }
    }
}
