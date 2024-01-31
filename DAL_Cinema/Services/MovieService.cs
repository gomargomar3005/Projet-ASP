using DAL_Cinema.Entities;
using Shared_Cinema.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Cinema.Services
{
    internal class MovieService :
        IMovieRepository<Movie>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> Get()
        {
            throw new NotImplementedException();
        }

        public Movie Get(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Movie data)
        {
            throw new NotImplementedException();
        }

        public void Update(Movie data)
        {
            throw new NotImplementedException();
        }
    }
}
