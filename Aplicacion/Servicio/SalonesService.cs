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
    public class SalonesService : BaseService<tb_salones>
    {
        private readonly ISalonesRepository repository;

        public SalonesService() : base()
        {
            repository = new SalonesRepository();
        }

        
    }
}
