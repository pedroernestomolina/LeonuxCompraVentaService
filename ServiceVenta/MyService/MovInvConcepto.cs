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

        public DtoLib.ResultadoEntidad<DtoLibVenta.MovInventario.Concepto.Ficha> MovInventario_Concepto(string auto)
        {
            return ServiceProv.MovInventario_Concepto(auto);
        }

    }

}