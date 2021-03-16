﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServicePos.Interfaces
{
    
    public interface ISucursal
    {

        DtoLib.ResultadoLista<DtoLibPos.Sucursal.Lista.Ficha> Sucursal_GetLista(DtoLibPos.Sucursal.Lista.Filtro filtro);
        DtoLib.ResultadoEntidad<DtoLibPos.Sucursal.Entidad.Ficha> Sucursal_GetFichaById(string id);

    }

}