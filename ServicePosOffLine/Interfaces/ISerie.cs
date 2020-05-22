using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServicePosOffLine.Interfaces
{
    
    public interface ISerie
    {

        DtoLib.ResultadoLista<DtoLibPosOffLine.Serie.Ficha> Serie_Lista();

    }

}