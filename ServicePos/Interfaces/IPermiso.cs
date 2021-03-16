using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServicePos.Interfaces
{
    
    public interface IPermiso
    {

        DtoLib.ResultadoEntidad<DtoLibPos.Permiso.Entidad.Ficha> Permiso_IngresarPos(string idGrupoUsu);

    }

}