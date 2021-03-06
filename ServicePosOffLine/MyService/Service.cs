﻿using ServicePosOffLine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServicePosOffLine.MyService
{
    
    public partial class Service: IService
    {

        public static IPosOffLine.IProvider ServiceProv;


        public Service(string pathDB)
        {
            ServiceProv = new ProvSqLitePosOffLine.Provider(pathDB);
        }

        public void setServidorRemoto(string instancia, string baseDatos)
        {
            ServiceProv.setServidorRemoto(instancia, baseDatos);
        }

        public DtoLib.ResultadoEntidad<DateTime> FechaServidor()
        {
            return ServiceProv.FechaServidor();
        }

        public DtoLib.ResultadoEntidad<DtoLibPosOffLine.Sistema.InformacionBD.Ficha> InformacionBD()
        {
            return ServiceProv.InformacionBD();
        }

        public DtoLib.Resultado Inicializar_BdLocal()
        {
            return ServiceProv.Inicializar_BdLocal();
        }

        public DtoLib.ResultadoEntidad<DtoLibPosOffLine.Empresa.Ficha> Empresa_Datos()
        {
            return ServiceProv.Empresa_Datos ();
        }

        public DtoLib.ResultadoEntidad<DateTime?> FechaUltimaActualizaion()
        {
            return ServiceProv.FechaUltimaActualizaion();
        }

        public DtoLib.ResultadoEntidad<string> CodigoSucursal()
        {
            return ServiceProv.CodigoSucursal();
        }

    }

}