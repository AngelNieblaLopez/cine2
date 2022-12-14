using System.Configuration;
using System.Data.SqlClient;

namespace Infrastructure.DataAccess.Repositories
{
    public abstract class Repository
    {
        private readonly string connectionString;

        public Repository()
        {
            //Puedes Cambiar esta cadena de conexion en el archivo de congiguracion de la aplicacion(App.Config - Capa UI)
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionToSql"].ToString(); 
            //o Puedes activar la linea de abajo si deseas tener la cedena de conexion en esta clase
            //connectionString = "Server=RJCODEADVANCE;DataBase= MyCompanyTest; integrated security= true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
