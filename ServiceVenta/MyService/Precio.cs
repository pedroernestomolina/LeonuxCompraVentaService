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

        public DtoLib.ResultadoEntidad<DtoLibVenta.Inventario.Precio.Resumen> Precio(string autoProducto, string idPrecio)
        {
            return ServiceProv.Precio(autoProducto, idPrecio);
        }

    }

}