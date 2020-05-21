﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceVenta.Interfaces
{
    
    public interface IExistencia
    {

        DtoLib.ResultadoEntidad<DtoLibVenta.Inventario.Existencia.Resumen> Existencia(string autoProducto, string autoDeposito);

    }

}