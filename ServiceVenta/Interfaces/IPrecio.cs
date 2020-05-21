using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceVenta.Interfaces
{
    
    public interface IPrecio
    {

        DtoLib.ResultadoEntidad<DtoLibVenta.Inventario.Precio.Resumen> Precio(string autoProducto, string idPrecio);

    }

}