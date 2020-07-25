﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceInventario.Interfaces
{
    
    public interface IService: IDeposito, IConcepto, ISucursal, IMovimiento, IUsuario, 
        IReporteMovimientos, IReporteDocumentos, ITool
    {

        DtoLib.ResultadoEntidad<DateTime> FechaServidor();
        //DtoLib.ResultadoEntidad<DtoLibPosOffLine.Sistema.InformacionBD.Ficha> InformacionBD();

    }

}