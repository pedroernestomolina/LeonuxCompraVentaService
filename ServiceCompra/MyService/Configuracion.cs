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

        public DtoLib.ResultadoEntidad<DtoLibCompra.Configuracion.Enumerados.EnumPreferenciaBusquedaProveedor> Configuracion_PreferenciaBusquedaProveedor()
        {
            return ServiceProv.Configuracion_PreferenciaBusquedaProveedor();
        }

        public DtoLib.ResultadoEntidad<decimal> Configuracion_TasaCambioActual()
        {
            return ServiceProv.Configuracion_TasaCambioActual();
        }

    }

}