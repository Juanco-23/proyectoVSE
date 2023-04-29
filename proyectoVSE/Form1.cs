using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.SqlClient;

namespace proyectoVSE
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SqlConnection conexion = new SqlConnection("server=DESKTOP-TUJS2GR; database=proyectoVSE; integrated security= true");
			conexion.Open();
			MessageBox.Show("Se abrio la conexion con el servidor SQL Server y se seleccione la BD");
			conexion.Close();
			MessageBox.Show("Se cerro la conexion");
		}
	}
}