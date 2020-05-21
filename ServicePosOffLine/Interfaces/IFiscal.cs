using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServicePosOffLine.Interfaces
{
    
    public interface IFiscal
    {

        DtoLib.ResultadoEntidad<DtoLibPosOffLine.Fiscal.Ficha> Fiscal_Tasas();

    }

}