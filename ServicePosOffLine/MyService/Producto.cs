using ServicePosOffLine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServicePosOffLine.MyService
{

    public partial class Service: IService
    {

        public DtoLib.ResultadoLista<DtoLibPosOffLine.Producto.Resumen> Producto_Lista(string filtro)
        {
            return ServiceProv.ProductoLista(filtro);
        }

        public DtoLib.ResultadoEntidad<string> Producto_BuscarPorCodigoBarraPlu(string aBuscar)
        {
            return ServiceProv.ProductoBuscarPorCodigoBarraPlu(aBuscar);
        }

        public DtoLib.ResultadoEntidad<DtoLibPosOffLine.Producto.Ficha> Producto(string aBuscar)
        {
            return ServiceProv.Producto(aBuscar);
        }

        public DtoLib.ResultadoLista<DtoLibPosOffLine.Producto.Resumen> ProductoListaPlu()
        {
            return ServiceProv.ProductoListaPlu();
        }

        public DtoLib.ResultadoLista<DtoLibPosOffLine.Producto.Resumen> ProductoListaOferta()
        {
            return ServiceProv.ProductoListaOferta();
        }

    }

}