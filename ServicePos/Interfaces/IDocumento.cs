﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServicePos.Interfaces
{
    
    public interface IDocumento
    {

        DtoLib.ResultadoAuto Documento_Agregar_Factura(DtoLibPos.Documento.Agregar.Factura.Ficha ficha);

    }

}