using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceVenta.Interfaces
{
    
    public interface ITransporte
    {

        DtoLib.ResultadoLista<DtoLibVenta.Transporte.Resumen> TransporteLista();

    }

}
