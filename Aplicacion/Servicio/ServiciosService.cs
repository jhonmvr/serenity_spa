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
    public class ServiciosService : BaseService<tb_servicios>
    {
        private readonly IServiciosRepository repository;

        public ServiciosService() : base()
        {
            repository = new ServiciosRepository();
        }

        
    }
}
