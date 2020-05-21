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

        public DtoLib.ResultadoAuto VentaAgregar(DtoLibVenta.Venta.Agregar ficha)
        {
            return ServiceProv.VentaAgregar(ficha);
        }

    }

}