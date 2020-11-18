﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceCompra.Interfaces
{
    
    public interface IService: IDeposito, ISucursal, IProveedor, IProducto, IUsuario, IEmpresa,
        IPermiso, IConfiguracion
    {

        DtoLib.ResultadoEntidad<DateTime> FechaServidor();

    }

}