using ServiceVenta.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceVenta.MyService
{

    public partial class Service: IService
    {

        public DtoLib.ResultadoEntidad<DtoLibVenta.Permiso.Ficha> PermisoVenta_DarDescuento_Item(string autoGrupoUsuario)
        {
            return ServiceProv.Venta_DarDescuento_Item(autoGrupoUsuario);
        }

        public DtoLib.ResultadoEntidad<DtoLibVenta.Permiso.Ficha> PermisoVenta_Eliminar_Item(string autoGrupoUsuario)
        {
            return ServiceProv.Venta_Eliminar_Item(autoGrupoUsuario);
        }

        public DtoLib.ResultadoEntidad<DtoLibVenta.Permiso.Ficha> PermisoVenta_PrecioLibre_Item(string autoGrupoUsuario)
        {
            return ServiceProv.Venta_PrecioLibre_Item(autoGrupoUsuario);
        }

        public DtoLib.ResultadoEntidad<DtoLibVenta.Permiso.Ficha> PermisoVenta_DescuentoGlobal(string autoGrupoUsuario)
        {
            return ServiceProv.Venta_DescuentoGlobal(autoGrupoUsuario);
        }

    }

}