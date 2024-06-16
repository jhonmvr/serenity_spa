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
    public class CitasService : BaseService<tb_citas>
    {
        private readonly ICitasRepository repository;

        public CitasService() : base()
        {
            repository = new CitasRepository();
        }

        
    }
}
