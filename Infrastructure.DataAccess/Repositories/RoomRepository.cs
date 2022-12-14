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
    public class RoomRepository : MasterRepository
    {

        public IEnumerable<Seat> getAllAvailableSeatsByFunction(int pFunctionId)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@functionId", pFunctionId));


            var result = ExecuteReader("SP_GetAllAvaliableSeatsByFunction", parameters);

            var listSeat = new List<Seat>();
            foreach (DataRow item in result.Rows)
            {
                var seatEntity = new Seat
                {
                    id = Convert.ToInt32(item[0]),
                    row = Convert.ToInt32(item[1]),
                    column = Convert.ToInt32(item[2]),
                    roomId = Convert.ToInt32(item[3]),
                    isAvaliable = Convert.ToInt32(item[4])
                };


                listSeat.Add(seatEntity);
            }

            return listSeat;
        }

        #region default functions
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

        public IEnumerable<Movie> getAll()
        {
            return Enumerable.Empty<Movie>();
        }

        public IEnumerable<Movie> getByValue(string valor)
        {
            return Enumerable.Empty<Movie>();
        }

        public IEnumerable<MovieDTO> getAllAvailable()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Function> getSchedule(int pMovieId)
        {
            throw new NotImplementedException();
        }

        public string getNameRoomByFunctionId(int pFuntionId)
        {
            throw new NotImplementedException();
        }

        

        #endregion
    }
}
