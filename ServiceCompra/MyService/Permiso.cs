﻿using ServiceCompra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceCompra.MyService
{
    
    public partial class Service: IService
    {

        public DtoLib.ResultadoEntidad<string> Permiso_PedirClaveAcceso_NivelMaximo()
        {
            return ServiceProv.Permiso_PedirClaveAcceso_NivelMaximo();
        }

        public DtoLib.ResultadoEntidad<string> Permiso_PedirClaveAcceso_NivelMedio()
        {
            return ServiceProv.Permiso_PedirClaveAcceso_NivelMedio();
        }

        public DtoLib.ResultadoEntidad<string> Permiso_PedirClaveAcceso_NivelMinimo()
        {
            return ServiceProv.Permiso_PedirClaveAcceso_NivelMinimo();
        }

        public DtoLib.ResultadoEntidad<DtoLibCompra.Permiso.Ficha> Permiso_ToolCompra(string autoGrupoUsuario)
        {
            return ServiceProv.Permiso_ToolCompra(autoGrupoUsuario);
        }

    }

}