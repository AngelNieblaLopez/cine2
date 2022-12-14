using Infrastructure.Common.Cache;
using Infrastructure.DataAccess.Abstracts;
using Infrastructure.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Infrastructure.DataAccess.Repositories
{
    public class UserRepository : MasterRepository, IUserRepository
    {
        public int add(User entity)//agregar nuevo usuario
        {
            //Crear parametros y agregar valor
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@userName", entity.userName));
            parameters.Add(new SqlParameter("@password", entity.password));
            parameters.Add(new SqlParameter("@firstName", entity.firstName));
            parameters.Add(new SqlParameter("@lastName", entity.lastName));
            parameters.Add(new SqlParameter("@position", entity.position));
            parameters.Add(new SqlParameter("@email", entity.email));
            parameters.Add(new SqlParameter("@profile", entity.profile));
            //EJECUTAR PROCEDIMIENTO ALMACENADO (o COMANDO DE TEXTO SQL en caso que modificaste el metodo principal- ver punto (M-T) de la clase MasterRepository)
            //Y Enviar parámetros
            return ExecuteNonQuery("addUser", parameters);
            //return ExecuteNonQuery("insert into Users values(@userName, @password, @firstName, @lastName, @position, @email, @profile)", parameters);

            //(E-C-M)
            //EJECUTAR UN COMANDO MIXTO (PROCEDIMIENTO o TEXTO)
            //return ExecuteNonQuery(
            //    "insert into Users values(@userName, @password, @firstName, @lastName, @position, @email, @profile)",
            //    parameters,
            //    CommandType.Text);
            //or
            // return ExecuteNonQuery("addUser", parameters, CommandType.StoredProcedure);
        }

        public int edit(User entity)//editar usuario
        {

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@userName", entity.userName));
            parameters.Add(new SqlParameter("@password", entity.password));
            parameters.Add(new SqlParameter("@firstName", entity.firstName));
            parameters.Add(new SqlParameter("@lastName", entity.lastName));
            parameters.Add(new SqlParameter("@position", entity.position));
            parameters.Add(new SqlParameter("@email", entity.email));
            parameters.Add(new SqlParameter("@profile", entity.profile));
            parameters.Add(new SqlParameter("@id", entity.id));
            return ExecuteNonQuery("editUser", parameters);
        }

        //obtener todos los datos de usuarios
        public IEnumerable<User> All
        {
            get
            {
                var result = ExecuteReader("selectAllUsers");
                var listUser = new List<User>();
                foreach (DataRow item in result.Rows)
                {
                    var userEntity = new User();//crear objeto usuario
                    userEntity.id = Convert.ToInt32(item[0]);
                    userEntity.userName = item[1].ToString();
                    userEntity.password = item[2].ToString();
                    userEntity.firstName = item[3].ToString();
                    userEntity.lastName = item[4].ToString();
                    userEntity.position = item[5].ToString();
                    userEntity.email = item[6].ToString();
                    //cargamos la foto de perfil siempre en cuando que no sea nulo
                    if (item[7] != DBNull.Value) userEntity.profile = (byte[])item[7];

                    //agregar usuario a la lista
                    listUser.Add(userEntity);
                }
                return listUser;
            }
        }

        public IEnumerable<User> getByValue(string value)//buscar por valor (buscar por nombre o email del usuario)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@findValue", value));
            var result = ExecuteReader("selectUser", parameters);
            var listUser = new List<User>();
            foreach (DataRow item in result.Rows)
            {
                var userEntity = new User();//crear objeto usuario
                userEntity.id = Convert.ToInt32(item[0]);
                userEntity.userName = item[1].ToString();
                userEntity.password = item[2].ToString();
                userEntity.firstName = item[3].ToString();
                userEntity.lastName = item[4].ToString();
                userEntity.position = item[5].ToString();
                userEntity.email = item[6].ToString();
                //cargamos la foto de perfil siempre en cuando que no sea nulo
                if (item[7] != DBNull.Value) userEntity.profile = (byte[])item[7];

                //agregar usuario a la lista
                listUser.Add(userEntity);
            }
            return listUser;
        }

        public bool login(string user, string pass)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@user", user));
            parameters.Add(new SqlParameter("@password", pass));

            var result = ExecuteReader("loginUser", parameters);

            if (result.Rows.Count > 0)
            {
                foreach (DataRow item in result.Rows) //Cargar datos del usuario activo en el cache / Capa comun
                {
                    ActiveUser.c_id = Convert.ToInt32(item[0]);
                    ActiveUser.c_userName = item[1].ToString();
                    ActiveUser.c_password = item[2].ToString();
                    ActiveUser.c_firstName = item[3].ToString();
                    ActiveUser.c_lastName = item[4].ToString();
                    ActiveUser.c_position = item[5].ToString();
                    ActiveUser.c_email = item[6].ToString();
                    //cargamos la foto de perfil siempre en cuando que no sea nulo
                    if (item[7] != DBNull.Value) ActiveUser.c_profile = (byte[])item[7];
                }                
                return true;
            }
            else
                return false;
        }

        public int remove(int id)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", id));
            return ExecuteNonQuery("removeUser", parameters);
        }
    }
}
