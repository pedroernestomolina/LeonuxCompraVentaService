﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServicePosOffLine.Interfaces
{
    
    public interface IService: IProducto, ICliente, IServidor, IItem, IVentaDocumento, IFiscal, IConfiguracion,
        IPendiente, IPermiso, IDeposito, ICobrador,IVendedor,ITransporte,IMedioCobro, ISerie, IJornada, IOperador,
        IUsuario, IMovConceptoInv, IReporte
    {

        void setServidorRemoto(string instancia, string baseDatos);
        DtoLib.ResultadoEntidad<DateTime> FechaServidor();
        DtoLib.ResultadoEntidad<DtoLibPosOffLine.Sistema.InformacionBD.Ficha> InformacionBD();
        DtoLib.Resultado Inicializar_BdLocal();
        DtoLib.ResultadoEntidad<DtoLibPosOffLine.Empresa.Ficha> Empresa_Datos();
        DtoLib.ResultadoEntidad<DateTime?> FechaUltimaActualizaion();
        DtoLib.ResultadoEntidad<string> CodigoSucursal();

    }

}