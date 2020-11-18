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

        public DtoLib.ResultadoLista<DtoLibCompra.Producto.Lista.Resumen> Producto_GetLista(DtoLibCompra.Producto.Lista.Filtro filtro)
        {
            return ServiceProv.Producto_GetLista (filtro);
        }

        public DtoLib.ResultadoEntidad<DtoLibCompra.Producto.Data.Ficha> Producto_GetFicha(string autoPrd)
        {
            return ServiceProv.Producto_GetFicha(autoPrd);
        }

        public DtoLib.ResultadoEntidad<string> Producto_GetCodigoRefProveedor(DtoLibCompra.Producto.CodigoRefProveedor.Filtro filtro)
        {
            return ServiceProv.Producto_GetCodigoRefProveedor(filtro);
        }

    }

}