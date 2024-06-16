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
    public class UsuariosService : BaseService<tb_usuarios>
    {
        private readonly IUsuariosRepository repository;

        public UsuariosService() : base()
        {
            repository = new UsuariosRepository();
        }

        
    }
}
