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

        public DtoLib.ResultadoLista<DtoLibVenta.Inventario.Producto.Resumen> ProductoLista(DtoLibVenta.Inventario.Producto.Filtro filtro)
        {
            return ServiceProv.ProductoLista(filtro);
        }

        public DtoLib.ResultadoEntidad<DtoLibVenta.Inventario.Producto.DetalleResumen> ProductoDetalle(string autoProducto)
        {
            return ServiceProv.ProductoDetalleResumen(autoProducto);
        }

        public DtoLib.ResultadoLista<DtoLibVenta.Inventario.Existencia.Resumen> ProductoExistencia(string auto)
        {
            return ServiceProv.ProductoExistencia(auto);
        }

        public DtoLib.ResultadoLista<DtoLibVenta.Inventario.Precio.Resumen> ProductoPrecios(string auto)
        {
            return ServiceProv.ProductoPrecios(auto);
        }

        public DtoLib.ResultadoEntidad<DtoLibVenta.Inventario.Producto.Ficha> Producto(string autoProducto)
        {
            return ServiceProv.Producto(autoProducto);
        }

    }

}