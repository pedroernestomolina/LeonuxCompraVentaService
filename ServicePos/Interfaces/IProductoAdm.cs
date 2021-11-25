﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServicePos.Interfaces
{
    
    public interface IProductoAdm
    {

        DtoLib.ResultadoLista<DtoLibPos.ProductoAdm.Lista.Ficha> ProductoAdm_GetLista(DtoLibPos.ProductoAdm.Lista.Filtro filtro);
        DtoLib.ResultadoEntidad<DtoLibPos.ProductoAdm.Entidad.Ficha> ProductoAdm_GetFichaById(string id);

    }

}