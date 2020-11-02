﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceCompra.Interfaces
{
    
    public interface IUsuario
    {

        DtoLib.ResultadoEntidad<DtoLibCompra.Usuario.Data.Ficha> Usuario_Principal();
        DtoLib.ResultadoEntidad<DtoLibCompra.Usuario.Data.Ficha> Usuario_Buscar(DtoLibCompra.Usuario.Buscar.Ficha ficha);

    }

}