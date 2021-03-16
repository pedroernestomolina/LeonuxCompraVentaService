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

        public DtoLib.ResultadoLista<DtoLibPos.Producto.Lista.Ficha> Producto_GetLista(DtoLibPos.Producto.Lista.Filtro filtro)
        {
            return ServiceProv.Producto_GetLista(filtro);
        }

    }

}