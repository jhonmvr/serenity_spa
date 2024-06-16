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
    public class ReservasService : BaseService<tb_reservas>
    {
        private readonly IReservasRepository repository;

        public ReservasService() : base()
        {
            repository = new ReservasRepository();
        }

        
    }
}
