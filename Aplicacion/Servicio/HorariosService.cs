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
    public class HorariosService : BaseService<tb_horarios>
    {
        private readonly IHorariosRepository repository;

        public HorariosService() : base()
        {
            repository = new HorariosRepository();
        }

        
    }
}
