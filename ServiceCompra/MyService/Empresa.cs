using ServiceCompra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceCompra.MyService
{
    
    public partial class Service: IService
    {

        public DtoLib.ResultadoEntidad<DtoLibCompra.Empresa.Data.Ficha> Empresa_Datos()
        {
            return ServiceProv.Empresa_Datos();
        }

    }

}