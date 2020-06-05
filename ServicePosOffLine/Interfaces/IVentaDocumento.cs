﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServicePosOffLine.Interfaces
{

    public interface IVentaDocumento
    {

        DtoLib.ResultadoId VentaDocumento_Agregar(DtoLibPosOffLine.VentaDocumento.Agregar ficha);
        DtoLib.ResultadoLista<DtoLibPosOffLine.VentaDocumento.Lista.Resumen> VentaDocumento_Lista(DtoLibPosOffLine.VentaDocumento.Lista.Filtro filtro);
        DtoLib.Resultado VentaDocumento_Anular(int idDocumento);
        DtoLib.ResultadoEntidad<DtoLibPosOffLine.VentaDocumento.Cargar.Ficha> VentaDocumento_Cargar(int idDocumento);

    }

}