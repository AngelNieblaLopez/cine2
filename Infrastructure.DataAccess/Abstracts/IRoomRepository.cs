using Infrastructure.DataAccess.DTO;
using Infrastructure.DataAccess.Entities;
using System;
using System.Collections.Generic;

namespace Infrastructure.DataAccess.Abstracts
{
    public interface IRoomRepository : IGenericRepository<Seat>
    {
        IEnumerable<Seat> getAllAvailableSeatsByFunction(int functionId);
    }
}
