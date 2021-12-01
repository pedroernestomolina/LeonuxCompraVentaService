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

        public DtoLib.ResultadoId VentaAdm_Temporal_Encabezado_Registrar(DtoLibPos.VentaAdm.Temporal.Encabezado.Registrar.Ficha ficha)
        {
            return ServiceProv.VentaAdm_Temporal_Encabezado_Registrar(ficha);
        }

        public DtoLib.Resultado VentaAdm_Temporal_Encabezado_Eliminar(int idEncabezado)
        {
            return ServiceProv.VentaAdm_Temporal_Encabezado_Eliminar(idEncabezado);
        }

        public DtoLib.Resultado VentaAdm_Temporal_Encabezado_Editar(DtoLibPos.VentaAdm.Temporal.Encabezado.Editar.Ficha ficha)
        {
            return ServiceProv.VentaAdm_Temporal_Encabezado_Editar(ficha);
        }

        public DtoLib.ResultadoId VentaAdm_Temporal_Item_Registrar(DtoLibPos.VentaAdm.Temporal.Item.Registrar.Ficha ficha)
        {
            return ServiceProv.VentaAdm_Temporal_Item_Registrar(ficha);
        }

        public DtoLib.ResultadoEntidad<DtoLibPos.VentaAdm.Temporal.Item.Entidad.Ficha> VentaAdm_Temporal_Item_GetFichaById(int idItem)
        {
            return ServiceProv.VentaAdm_Temporal_Item_GetFichaById(idItem);
        }

        public DtoLib.Resultado VentaAdm_Temporal_Anular(DtoLibPos.VentaAdm.Temporal.Anular.Ficha ficha)
        {
            return ServiceProv.VentaAdm_Temporal_Anular(ficha);
        }

        public DtoLib.Resultado VentaAdm_Temporal_Item_Eliminar(DtoLibPos.VentaAdm.Temporal.Item.Eliminar.Ficha ficha)
        {
            return ServiceProv.VentaAdm_Temporal_Item_Eliminar(ficha);
        }

        public DtoLib.Resultado VentaAdm_Temporal_Item_Limpiar(DtoLibPos.VentaAdm.Temporal.Item.Limpiar.Ficha ficha)
        {
            return ServiceProv.VentaAdm_Temporal_Item_Limpiar(ficha);
        }

    }

}