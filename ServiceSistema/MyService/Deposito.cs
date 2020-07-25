﻿using ServiceSistema.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceSistema.MyService
{

    public partial class Service : IService
    {

        public DtoLib.ResultadoLista<DtoLibSistema.Deposito.Resumen> Deposito_GetLista()
        {
            return ServiceProv.Deposito_GetLista();
        }

        public DtoLib.ResultadoEntidad<DtoLibSistema.Deposito.Ficha> Deposito_GetFicha(string auto)
        {
            return ServiceProv.Deposito_GetFicha(auto);
        }

        public DtoLib.ResultadoAuto Deposito_Agregar(DtoLibSistema.Deposito.Agregar ficha)
        {
            return ServiceProv.Deposito_Agregar(ficha);
        }

        public DtoLib.Resultado Deposito_Editar(DtoLibSistema.Deposito.Editar ficha)
        {
            return ServiceProv.Deposito_Editar(ficha);
        }

    }

}