using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Modelo.Abstracciones
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Modify(TEntity entity);
        void Delete(int id);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
    }
}
