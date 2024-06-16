using AccesoDatos.Repository.imp;
using Modelo.Abstraciones;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Servicio
{
    public class TerapeutasService : BaseService<tb_terapeutas>
    {
        private readonly ITerapeutasRepository repository;

        public TerapeutasService() : base()
        {
            repository = new TerapeutasRepository();
        }

        
    }
}
