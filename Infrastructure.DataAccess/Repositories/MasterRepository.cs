using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Infrastructure.DataAccess.Repositories
{
    public abstract class MasterRepository : Repository
    {
        //Ejecutar procedimientos para Insertar, Editar y Eliminar-> POR DEFECTO PARA PROCEDIMIENTO ALMACENADO
        protected int ExecuteNonQuery(string sqlCommand, List<SqlParameter> parameters)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = sqlCommand;
                    command.CommandType = CommandType.StoredProcedure;//(M-T)Puedes MODIFICAR a TEXT si deseas ejecutar por defecto solamente Comandos de texto sql (insert into, update...)->command.CommandType = CommandType.Text;
                    foreach (SqlParameter item in parameters)
                        command.Parameters.Add(item);
                    var result = command.ExecuteNonQuery();
                    parameters.Clear();
                    return result;
                }
            }
        }

        //EJECUTAR COMANDOS MIXTO
        //EJECUTAR COMANDOS Insertar, Editar y Eliminar MIXTO (PROCEDIMIENTO, TEXTO O TABLA DIRECTA)
        //EN CASO QUE DESEES ESPECIFICAR EL TIPO DE COMANDO DESDE LOS REPOSITORIO DE ENTIDADES,POR EJEMPLO:
        //->EJECUTAR UN COMANDO DE TEXTO DE SQL
        //-> return ExecuteNonQuery("insert into tabla values (@param1, @param2)", parameters,CommandType.Text);
        //Puedes ver el codigo de implemtacion en el punto (E-C-M) en la clase UserRepository.   
        //ESTE METODO ES OPCIONAL, SI SOLAMENTE UTILIZARÁS PROCEDIMIENTOS ALMACENADOS 
        //(O TEXTO en caso que modifiques el metodo de arriba como indiqué), PUEDES BORRAR ESTE METODO.    
        protected int ExecuteNonQuery(string sqlCommand, List<SqlParameter> parameters, CommandType cmdType)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = sqlCommand;
                    command.CommandType = cmdType;//Tipo de comando especificado desde los repositorios de entidades
                    foreach (SqlParameter item in parameters)
                        command.Parameters.Add(item);
                    var result = command.ExecuteNonQuery();
                    parameters.Clear();
                    return result;
                }
            }
        }

        // Ejecutar comandos de consultas sin parametros/Seleccionar todo' -> POR DEFECTO PARA PROCEDIMIENTO
        protected DataTable ExecuteReader(string sqlCommand)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = sqlCommand;
                    command.CommandType = CommandType.StoredProcedure;//Tipo de comando procedimiento almacenado
                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();
                    return table;
                }
            }
        }

        // Ejecutar comandos de consultas con parametros/Busqueda o filtrar'-> POR DEFECTO PARA PROCEDIMIENTO
        protected DataTable ExecuteReader(string sqlCommand, List<SqlParameter> parameters)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = sqlCommand;
                    foreach (SqlParameter item in parameters)
                    {
                        command.Parameters.Add(item);
                    }
                    command.CommandType = CommandType.StoredProcedure;//Tipo de comando procedimiento almacenado
                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();
                    return table;
                }
            }
        }
        //EJECUTAR COMANDOS MIXTO PARA CONSULTA
        //OPCIONAL
        //PUEDES SOBRECARGAR ESTOS 2 ULTIMOS METODOS DE LA MISMA MANERA COMO SE HIZO CON EL METODO ExecuteNonQuery() 
        //PARA QUE EN CASO DESEES ESPECIFICAR EL TIPO DE COMANDO DESDE LOS REPOSITORIOS DE ENTIDADES
        //EJEMPLO- > 
        //protected DataTable ExecuteReader(string sqlCommand, List<SqlParameter> parameters,CommandType cmdType)
        //protected DataTable ExecuteReader(string sqlCommand, CommandType cmdType)

    }
}
