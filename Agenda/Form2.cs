using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadena = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\\users\\centro13\\documents\\visual studio 2017\\Projects\\Agenda\\Agenda\\Agenda.mdb";
            OleDbConnection conexion = new OleDbConnection(cadena);
            try
            {
                conexion.Open();
                MessageBox.Show("Conexion a bd con exito");
                conexion.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se puede conectar");
            }
        }
    }
}
