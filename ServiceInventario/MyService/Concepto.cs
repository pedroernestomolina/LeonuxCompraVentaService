﻿using ServiceInventario.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceInventario.MyService
{

    public partial class Service: IService
    {

        public DtoLib.ResultadoLista<DtoLibInventario.Concepto.Resumen> Concepto_GetLista()
        {
            return ServiceProv.Concepto_GetLista();
        }

        public DtoLib.ResultadoEntidad<DtoLibInventario.Concepto.Ficha> Concepto_GetFicha(string auto)
        {
            return ServiceProv.Concepto_GetFicha (auto);
        }

        public DtoLib.ResultadoEntidad<DtoLibInventario.Concepto.Ficha> Concepto_PorTraslado()
        {
            return ServiceProv.Concepto_PorTraslado();
        }

    }

}