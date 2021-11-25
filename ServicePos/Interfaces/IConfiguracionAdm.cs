using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServicePos.Interfaces
{

    public interface IConfiguracionAdm
    {

        DtoLib.ResultadoEntidad<DtoLibPos.Configuracion.BusquedaCliente.Entidad.Ficha> Configuracion_BusquedaCliente();
        DtoLib.ResultadoEntidad<DtoLibPos.Configuracion.BusquedaProducto.Enumerados.EnumPreferenciaBusqueda> Configuracion_PreferenciaBusquedaProducto();

    }

}