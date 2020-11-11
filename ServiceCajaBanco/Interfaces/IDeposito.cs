﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceCajaBanco.Interfaces
{
    
    public interface IDeposito
    {

        DtoLib.ResultadoLista<DtoLibCajaBanco.Deposito.Resumen> Deposito_GetLista();
        DtoLib.ResultadoEntidad<DtoLibCajaBanco.Deposito.Ficha> Deposito_GetPrincipal();

    }

}