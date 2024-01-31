using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Cinema.Repositories
{
    public interface IMovieRepository<TEntity> :
        ICRUDRepository<TEntity, int> where TEntity : class
    { 
    }
}
