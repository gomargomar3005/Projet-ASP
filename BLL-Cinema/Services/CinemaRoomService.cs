using BLL_Cinema.Entities;
using DAL = DAL_Cinema.Entities;
using Shared_Cinema.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_Cinema.Mappers;

namespace BLL_Cinema.Services
{
    public class CinemaRoomService : ICinemaRoomRepository<CinemaRoom>
    {
        private readonly ICinemaRoomRepository<DAL.CinemaRoom> _repository;

        public CinemaRoomService(ICinemaRoomRepository<DAL.CinemaRoom> repository)
        {
            _repository = repository;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<CinemaRoom> Get()
        {
            return _repository.Get().Select(d => d.ToBLL());
        }

        public CinemaRoom Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }

        public int Insert(CinemaRoom data)
        {
            return _repository.Insert(data.ToDAL());
        }

        public void Update(CinemaRoom data)
        {
            _repository.Update(data.ToDAL());
        }
    }
}
