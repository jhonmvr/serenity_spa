using CM.AccesoDatos.Repositorios.imp;
using CM.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Servicio
{
    public class BaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _repository;

        public BaseService()
        {
            _repository = new BaseRepository<TEntity>();
        }

        public void Add(TEntity entity)
        {
            try
            {
                _repository.Add(entity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo agregar el registro.", ex);
            }
        }

        public void Modify(TEntity entity)
        {
            try
            {
                _repository.Modify(entity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo modificar el registro.", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                _repository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo eliminar el registro.", ex);
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                return _repository.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudieron obtener los registros.", ex);
            }
        }

        public TEntity GetById(int id)
        {
            try
            {
                return _repository.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo obtener el registro.", ex);
            }
        }
    }
}
