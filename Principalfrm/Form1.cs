using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Principalfrm
{
    public partial class Sistemafrm : Form
    {
        public Sistemafrm()
        {
            InitializeComponent();
        }

        

        

        private void LlenarDataGrid()
        {
            try
            {
                SqlConnection conexion = ConexionBD.ObtenerConexion();
                ConexionBD.AbrirConexion();

                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Datos", conexion))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    // Asegurarse de que las columnas se generen automáticamente
                    tablaListarDtGv.AutoGenerateColumns = true;

                    // Llenar el DataGridView con los nuevos datos
                    tablaListarDtGv.DataSource = dt;
                }

                ConexionBD.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        


        private void agregarBtn_Click(object sender, EventArgs e)
        {
            AgregarMascfrm form2 = new AgregarMascfrm();
            form2.Show();
        }

        private void tablaListarDtGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Sistemafrm_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mascotasDataSet.Datos' Puede moverla o quitarla según sea necesario.
            this.datosTableAdapter.Fill(this.mascotasDataSet.Datos);

        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
