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

        public DtoLib.ResultadoLista<DtoLibCompra.Proveedor.Lista.Resumen> Proveedor_GetLista(DtoLibCompra.Proveedor.Lista.Filtro filtro)
        {
            return ServiceProv.Proveedor_GetLista(filtro);
        }

        DtoLib.ResultadoEntidad<DtoLibCompra.Proveedor.Data.Ficha> IProveedor.Proveedor_GetFicha(string autoPrv)
        {
            return ServiceProv.Proveedor_GetFicha(autoPrv);
        }

    }

}