using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServicePos.Interfaces
{
    
    public interface IJornada
    {

        DtoLib.ResultadoId Jornada_Abrir(DtoLibPos.Pos.Abrir.Ficha ficha);
        DtoLib.Resultado Jornada_Cerrar(DtoLibPos.Pos.Cerrar.Ficha ficha);
        DtoLib.ResultadoEntidad<DtoLibPos.Pos.EnUso.Ficha> Jornada_EnUso_GetByIdEquipo(string idEquipo);
        DtoLib.ResultadoEntidad<DtoLibPos.Pos.EnUso.Ficha> Jornada_EnUso_GetById(int id);

    }

}