using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceVenta.Interfaces
{

    public interface IProducto
    {

        DtoLib.ResultadoLista<DtoLibVenta.Inventario.Producto.Resumen> ProductoLista(DtoLibVenta.Inventario.Producto.Filtro filtro);
        DtoLib.ResultadoEntidad<DtoLibVenta.Inventario.Producto.Ficha> Producto(string autoProducto);
        DtoLib.ResultadoEntidad<DtoLibVenta.Inventario.Producto.DetalleResumen> ProductoDetalle(string autoProducto);
        DtoLib.ResultadoLista<DtoLibVenta.Inventario.Existencia.Resumen> ProductoExistencia(string auto);
        DtoLib.ResultadoLista<DtoLibVenta.Inventario.Precio.Resumen> ProductoPrecios(string auto);

    }

}