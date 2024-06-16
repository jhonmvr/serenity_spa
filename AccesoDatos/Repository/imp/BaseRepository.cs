using AccesoDatos;
using CM.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.AccesoDatos.Repositorios.imp
{
    public class BaseRepository<TEntity> :IDisposable, IBaseRepository<TEntity> where TEntity : class
    {
        public void Add(TEntity entity)
        {
            try
            {
                using (var context = new db_serenity_spaEntities())
                {
                    context.Set<TEntity>().Add(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo insertar el registro.", ex);
            }
        }

        public void Modify(TEntity entity)
        {
            try
            {
                using (var context = new db_serenity_spaEntities())
                {
                    context.Entry(entity).State = EntityState.Modified;
                    context.SaveChanges();
                }
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
                using (var context = new db_serenity_spaEntities())
                {
                    var entity = context.Set<TEntity>().Find(id);
                    if (entity != null)
                    {
                        context.Set<TEntity>().Remove(entity);
                        context.SaveChanges();
                    }
                }
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
                using (var context = new db_serenity_spaEntities())
                {
                    return context.Set<TEntity>().ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo obtener los registros.", ex);
            }
        }

        public TEntity GetById(int id)
        {
            try
            {
                using (var context = new db_serenity_spaEntities())
                {
                    return context.Set<TEntity>().Find(id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo obtener el registro.", ex);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
