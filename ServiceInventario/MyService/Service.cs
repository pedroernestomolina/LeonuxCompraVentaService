﻿using ServiceInventario.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceInventario.MyService
{

    public partial class Service : IService
    {

        public static ILibInventario.IProvider ServiceProv;


        public Service(string instancia, string bd)
        {
            ServiceProv = new ProvLibInventario.Provider(instancia, bd);
        }


        public DtoLib.ResultadoEntidad<DateTime> FechaServidor()
        {
            return ServiceProv.FechaServidor();
        }

        //public DtoLib.ResultadoEntidad<DtoLibPosOffLine.Sistema.InformacionBD.Ficha> InformacionBD()
        //{
        //    throw new NotImplementedException();
        //    //return ServiceProv.InformacionBD();
        //}

    }

}