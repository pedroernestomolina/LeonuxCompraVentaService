﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServicePosOffLine.Interfaces
{
    
    public interface ICliente
    {

        DtoLib.ResultadoEntidad<DtoLibPosOffLine.Cliente.Ficha> Cliente(int id);
        DtoLib.ResultadoEntidad<DtoLibPosOffLine.Cliente.Ficha> Cliente_BuscarPorCiRif(string ciRif);
        DtoLib.ResultadoId Cliente_Agregar(DtoLibPosOffLine.Cliente.Agregar ficha);
        DtoLib.ResultadoLista<DtoLibPosOffLine.Cliente.Resumen> Cliente_Lista(string filtro);

    }

}