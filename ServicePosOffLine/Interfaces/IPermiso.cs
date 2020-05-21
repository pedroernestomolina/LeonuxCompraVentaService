using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServicePosOffLine.Interfaces
{
    
    public interface IPermiso
    {

        DtoLib.ResultadoEntidad<DtoLibPosOffLine.Permiso.Pos.Ficha> Permiso_ManejoPos();

    }

}