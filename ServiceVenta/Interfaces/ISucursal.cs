using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceVenta.Interfaces
{

    public interface ISucursal
    {

        DtoLib.ResultadoLista<DtoLibVenta.Sucursal.Resumen> SucursalLista();

    }

}