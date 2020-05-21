using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceVenta.Interfaces
{
    
    public interface IMovInvConcepto
    {

        DtoLib.ResultadoEntidad<DtoLibVenta.MovInventario.Concepto.Ficha> MovInventario_Concepto(string auto);

    }

}