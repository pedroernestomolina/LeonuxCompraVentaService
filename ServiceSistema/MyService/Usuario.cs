using ServiceSistema.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceSistema.MyService
{

    public partial class Service : IService
    {

        public DtoLib.ResultadoEntidad<DtoLibSistema.Usuario.Ficha> Usuario_Principal()
        {
            return ServiceProv.Usuario_Principal();
        }

    }

}