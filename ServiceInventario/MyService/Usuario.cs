using ServiceInventario.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceInventario.MyService
{

    public partial class Service: IService
    {

        public DtoLib.ResultadoEntidad<DtoLibInventario.Usuario.Ficha> Usuario_Principal()
        {
            return ServiceProv.Usuario_Principal();
        }

        public DtoLib.ResultadoEntidad<DtoLibInventario.Usuario.Ficha> Usuario_Buscar(DtoLibInventario.Usuario.Buscar.Ficha ficha)
        {
            return ServiceProv.Usuario_Buscar(ficha);
        }

    }

}