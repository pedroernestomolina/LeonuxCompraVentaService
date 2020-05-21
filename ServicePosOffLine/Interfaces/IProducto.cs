using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServicePosOffLine.Interfaces
{

    public interface IProducto
    {

        DtoLib.ResultadoLista<DtoLibPosOffLine.Producto.Resumen> Producto_Lista(string filtro);
        DtoLib.ResultadoEntidad<string> Producto_BuscarPorCodigoBarraPlu(string aBuscar);
        DtoLib.ResultadoEntidad<DtoLibPosOffLine.Producto.Ficha> Producto(string aBuscar);
        DtoLib.ResultadoLista<DtoLibPosOffLine.Producto.Resumen> ProductoListaPlu();
        DtoLib.ResultadoLista<DtoLibPosOffLine.Producto.Resumen> ProductoListaOferta();

    }

}