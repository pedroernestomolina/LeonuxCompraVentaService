﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServicePos.Interfaces
{
    
    public interface IPermiso
    {

        DtoLib.ResultadoEntidad<DtoLibPos.Permiso.Entidad.Ficha> Permiso_IngresarPos(string idGrupoUsu);
        DtoLib.ResultadoEntidad<DtoLibPos.Permiso.Entidad.Ficha> Permiso_Pos(string idGrupoUsu, string codFuncion);

        //

        DtoLib.ResultadoEntidad<string> Permiso_PedirClaveAcceso_NivelMaximo();
        DtoLib.ResultadoEntidad<string> Permiso_PedirClaveAcceso_NivelMedio();
        DtoLib.ResultadoEntidad<string> Permiso_PedirClaveAcceso_NivelMinimo();

        //

        DtoLib.ResultadoEntidad<DtoLibPos.Permiso.Entidad.Ficha> Permiso_VentaAdm_Reportes(string idGrupoUsu);

    }

}