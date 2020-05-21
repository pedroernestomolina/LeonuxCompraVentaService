using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceVenta.Interfaces
{

    public interface IPermiso
    {

        DtoLib.ResultadoEntidad<DtoLibVenta.Permiso.Ficha> PermisoVenta_DarDescuento_Item(string autoGrupoUsuario);
        DtoLib.ResultadoEntidad<DtoLibVenta.Permiso.Ficha> PermisoVenta_Eliminar_Item(string autoGrupoUsuario);
        DtoLib.ResultadoEntidad<DtoLibVenta.Permiso.Ficha> PermisoVenta_PrecioLibre_Item(string autoGrupoUsuario);
        DtoLib.ResultadoEntidad<DtoLibVenta.Permiso.Ficha> PermisoVenta_DescuentoGlobal(string autoGrupoUsuario);

    }

}