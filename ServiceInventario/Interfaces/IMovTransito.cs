using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceInventario.Interfaces
{
    
    public interface IMovTransito
    {

        DtoLib.ResultadoId Transito_Movimiento_Agregar(DtoLibInventario.Transito.Movimiento.Agregar.Ficha ficha);

    }

}