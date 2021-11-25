using ServicePos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServicePos.MyService
{
    
    public partial class Service : IService
    {

        public DtoLib.ResultadoEntidad<DtoLibPos.Configuracion.BusquedaCliente.Entidad.Ficha> Configuracion_BusquedaCliente()
        {
            return ServiceProv.Configuracion_BusquedaCliente();
        }

        DtoLib.ResultadoEntidad<DtoLibPos.Configuracion.BusquedaProducto.Enumerados.EnumPreferenciaBusqueda> IConfiguracionAdm.Configuracion_PreferenciaBusquedaProducto()
        {
            return ServiceProv.Configuracion_PreferenciaBusquedaProducto();
        }

    }

}