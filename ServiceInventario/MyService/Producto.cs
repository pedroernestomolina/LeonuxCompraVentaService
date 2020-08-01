using ServiceInventario.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceInventario.MyService
{

    public partial class Service: IService
    {

        public DtoLib.ResultadoLista<DtoLibInventario.Producto.Resumen> Producto_GetLista(DtoLibInventario.Producto.Filtro filtro)
        {
            return ServiceProv.Producto_GetLista(filtro);
        }

        public DtoLib.ResultadoEntidad<DtoLibInventario.Producto.VerData.Ficha> Producto_GetFicha(string autoPrd)
        {
            return ServiceProv.Producto_GetFicha(autoPrd);
        }

        public DtoLib.ResultadoLista<DtoLibInventario.Producto.Estatus.Resumen> Producto_Estatus_Lista()
        {
            return ServiceProv.Producto_Estatus_Lista();
        }

        public DtoLib.ResultadoLista<DtoLibInventario.Producto.Origen.Resumen> Producto_Origen_Lista()
        {
            return ServiceProv.Producto_Origen_Lista();
        }

        public DtoLib.ResultadoLista<DtoLibInventario.Producto.Categoria.Resumen> Producto_Categoria_Lista()
        {
            return ServiceProv.Producto_Categoria_Lista();
        }

        public DtoLib.ResultadoLista<DtoLibInventario.Producto.AdmDivisa.Resumen> Producto_AdmDivisa_Lista()
        {
            return ServiceProv.Producto_AdmDivisa_Lista();
        }

        public DtoLib.ResultadoLista<DtoLibInventario.Producto.Pesado.Resumen> Producto_Pesado_Lista()
        {
            return ServiceProv.Producto_Pesado_Lista();
        }

        public DtoLib.ResultadoLista<DtoLibInventario.Producto.Oferta.Resumen> Producto_Oferta_Lista()
        {
            return ServiceProv.Producto_Oferta_Lista();
        }

    }

}