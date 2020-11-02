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

    }

}