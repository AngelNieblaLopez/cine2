using Infrastructure.DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.DataAccess.Repositories;
using Infrastructure.DataAccess.DTO;
using Infrastructure.DataAccess.Entities;

namespace Domain.Models
{
    public class TaquilaModel
    {
        private IMovieRepository movieRepository;
        private RoomRepository roomRepository;

        public TaquilaModel()
        {
            movieRepository = new MovieRepository();
            roomRepository = new RoomRepository();

        }

        public IEnumerable<MovieDTO> getAllAvailableMovies()
        {
            return movieRepository.getAllAvailable();
        }

        public IEnumerable<Function> getScheduleOfMovie(int pMovieId)
        {
            return movieRepository.getSchedule(pMovieId);
        }

        public string getNameRoomByFunctionId(int pFuntionId)
        {
            return movieRepository.getNameRoomByFunctionId(pFuntionId);
        }

        public IEnumerable<Seat> GetAllAvailableSeatsByFunction(int pFunctinId)
        {
            return roomRepository.getAllAvailableSeatsByFunction(pFunctinId);
        }
    }
}
