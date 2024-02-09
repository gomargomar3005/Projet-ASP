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
    public class DiffusionService : IDiffusionRepository<Diffusion>
    {
        private readonly IDiffusionRepository<DAL.Diffusion> _repository;
        public DiffusionService(IDiffusionRepository<DAL.Diffusion> repository)
        {
            _repository = repository;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<Diffusion> Get()
        {
            return _repository.Get().Select(d => d.ToBLL());
        }

        public Diffusion Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }

        public int Insert(Diffusion data)
        {
            return _repository.Insert(data.ToDAL());
        }

        public void Update(Diffusion data)
        {
            _repository.Update(data.ToDAL());
        }
    }
}
