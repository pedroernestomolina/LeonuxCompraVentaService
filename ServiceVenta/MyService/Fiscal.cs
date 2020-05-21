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

        public DtoLib.ResultadoEntidad<DtoLibVenta.TasasFiscales.Ficha> TasasFiscales()
        {
            return ServiceProv.TasasFiscales();
        }

    }

}