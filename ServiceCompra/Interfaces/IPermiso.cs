﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceCompra.Interfaces
{

    public interface IPermiso
    {

        DtoLib.ResultadoEntidad<string> Permiso_PedirClaveAcceso_NivelMaximo();
        DtoLib.ResultadoEntidad<string> Permiso_PedirClaveAcceso_NivelMedio();
        DtoLib.ResultadoEntidad<string> Permiso_PedirClaveAcceso_NivelMinimo();

        DtoLib.ResultadoEntidad<DtoLibCompra.Permiso.Ficha> Permiso_ToolCompra(string autoGrupoUsuario);

    }

}