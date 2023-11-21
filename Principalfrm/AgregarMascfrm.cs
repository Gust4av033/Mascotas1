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

namespace Principalfrm
{
    public partial class AgregarMascfrm : Form
    {
        public AgregarMascfrm()
        {
            InitializeComponent();
        }


        private void AgregarMascfrm_Load(object sender, EventArgs e)
        {
            guardarBtn.Click += new EventHandler(guardarBtn_Click);
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = ConexionBD.ObtenerConexion();
            ConexionBD.AbrirConexion();

            using (SqlCommand cmd = new SqlCommand("INSERT INTO Datos VALUES (@Nombre, @Apellido, @Raza, @FechaNacimiento, @Contacto)", con))
            {
                cmd.Parameters.AddWithValue("@Nombre", nombreTxt.Text);
                cmd.Parameters.AddWithValue("@Apellido", apellidoTxt.Text);
                cmd.Parameters.AddWithValue("@Raza", razaTxt.Text);
                cmd.Parameters.AddWithValue("@FechaNacimiento", fechaDte.Value);
                cmd.Parameters.AddWithValue("@Contacto", contactoTxt.Text);
                cmd.ExecuteNonQuery();
            }

            ConexionBD.CerrarConexion();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void salirBtnAM_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
