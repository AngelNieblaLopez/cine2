using Infrastructure.DataAccess.Abstracts;
using Infrastructure.DataAccess.DTO;
using Infrastructure.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess.Repositories
{
    public class MovieRepository : MasterRepository, IMovieRepository
    {
        public IEnumerable<MovieDTO> getAllAvailable()//obtener todos los datos de usuarios
        {

            var result = ExecuteReader("SP_avaliable_billboard");

            var listMovie = new List<MovieDTO>();
            foreach (DataRow item in result.Rows)
            {
                var movieEntity = new MovieDTO();

                movieEntity.id = Convert.ToInt32(item[0]);
                movieEntity.name = item[1].ToString();


                listMovie.Add(movieEntity);
            }

            return listMovie;
        }

        public IEnumerable<Function> getSchedule(int pMovieId)
        {

            List <SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@movieId", pMovieId));

            var result = ExecuteReader("SP_Get_schedules_movie", parameters);

            var listMovieSchedule = new List<Function>();
            foreach (DataRow item in result.Rows)
            {
                var function = new Function()
                {
                    id = Convert.ToInt32(item[0]),
                    startsAt = Convert.ToDateTime(item[1])
                };

                listMovieSchedule.Add(function);
            }

            return listMovieSchedule;
        }
        
        public string getNameRoomByFunctionId(int pFuntionId)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@functionId", pFuntionId));

            var result = ExecuteReader("SP_get_name_room_by_function", parameters);

            string roomName = "";

            foreach (DataRow item in result.Rows)
            {
                roomName = item[0].ToString();
            }

            return roomName;
        }
        public int add(Movie movie)
        {
            return 1;
        }
        public int edit(Movie movie)
        {
            return 1;
        }

        public int remove(int movieId)
        {
            return 1;
        }

        public IEnumerable<Movie> All => Enumerable.Empty<Movie>();

        public IEnumerable<Movie> getByValue(string valor)
        {
            return Enumerable.Empty<Movie>();
        }
    }
}
