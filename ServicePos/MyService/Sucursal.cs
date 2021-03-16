﻿using ServicePos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServicePos.MyService
{

    public partial class Service : IService
    {

        public DtoLib.ResultadoLista<DtoLibPos.Sucursal.Lista.Ficha> Sucursal_GetLista(DtoLibPos.Sucursal.Lista.Filtro filtro)
        {
            return Sucursal_GetLista(filtro);
        }

        public DtoLib.ResultadoEntidad<DtoLibPos.Sucursal.Entidad.Ficha> Sucursal_GetFichaById(string id)
        {
            return Sucursal_GetFichaById(id);
        }

    }

}