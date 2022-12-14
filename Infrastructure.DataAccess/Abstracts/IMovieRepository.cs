using Infrastructure.DataAccess.DTO;
using Infrastructure.DataAccess.Entities;
using System;
using System.Collections.Generic;

namespace Infrastructure.DataAccess.Abstracts
{
    public interface IMovieRepository : IGenericRepository<Movie>
    {
        IEnumerable<MovieDTO> getAllAvailable();
        IEnumerable<Function> getSchedule(int pMovieId);
        string getNameRoomByFunctionId(int pFuntionId);
    }
}
