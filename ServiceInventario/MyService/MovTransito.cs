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

        public DtoLib.ResultadoId Transito_Movimiento_Agregar(DtoLibInventario.Transito.Movimiento.Agregar.Ficha ficha)
        {
            return ServiceProv.Transito_Movimiento_Agregar(ficha);
        }

    }

}