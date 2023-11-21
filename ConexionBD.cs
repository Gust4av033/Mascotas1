using System;

public class ConexionBD
{
    private static SqlConnection conexion;

    public static SqlConnection ObtenerConexion()
    {
        if (conexion == null)
        {
            conexion = new SqlConnection("Data Source=LDB-NITRO5\\MSSQLSERVER02;Initial Catalog=Mascotas;Integrated Security=True");
        }
        return conexion;
    }

    public static void AbrirConexion()
    {
        if (conexion != null && conexion.State != ConnectionState.Open)
        {
            conexion.Open();
        }
    }

    public static void CerrarConexion()
    {
        if (conexion != null && conexion.State != ConnectionState.Closed)
        {
            conexion.Close();
        }
    }
}