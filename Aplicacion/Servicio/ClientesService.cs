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
    public class ClienteService : BaseService<tb_clientes>
    {
        private readonly IClientesRepository repository;

        public ClienteService() : base()
        {
            repository = new ClienteRepository();
        }

        
    }
}
