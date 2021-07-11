using System.Data.SqlClient;



namespace CapaDatos
{
    public abstract class Conexion
    {
        private readonly string connectionString;
        public Conexion()
        {
            connectionString = "Server=DESKTOP-VHFU59K\\SQLEXPRESS ;DataBase= PanaderiaDB; integrated security= true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
