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
    public class EspecialidadesService : BaseService<tb_especialidades>
    {
        private readonly IEspecialidadesRepository repository;

        public EspecialidadesService() : base()
        {
            repository = new EspecialidadesRepository();
        }

        
    }
}
