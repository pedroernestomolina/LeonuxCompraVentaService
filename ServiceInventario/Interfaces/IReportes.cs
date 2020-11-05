﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceInventario.Interfaces
{
    
    public interface IReportes
    {

        DtoLib.ResultadoLista<DtoLibInventario.Reportes.MaestroProducto.Ficha> Reportes_MaestroProducto(DtoLibInventario.Reportes.MaestroProducto.Filtro filtro);
        DtoLib.ResultadoLista<DtoLibInventario.Reportes.MaestroInventario.Ficha> Reportes_MaestroInventario(DtoLibInventario.Reportes.MaestroInventario.Filtro filtro);
        DtoLib.ResultadoLista<DtoLibInventario.Reportes.MaestroExistencia.Ficha> Reportes_MaestroExistencia(DtoLibInventario.Reportes.MaestroExistencia.Filtro filtro);
        DtoLib.ResultadoLista<DtoLibInventario.Reportes.MaestroPrecio.Ficha> Reportes_MaestroPrecio(DtoLibInventario.Reportes.MaestroPrecio.Filtro filtro);
        DtoLib.ResultadoLista<DtoLibInventario.Reportes.Kardex.Ficha> Reportes_Kardex(DtoLibInventario.Reportes.Kardex.Filtro filtro);

        DtoLib.ResultadoLista<DtoLibInventario.Reportes.Top20.Ficha> Reportes_Top20(DtoLibInventario.Reportes.Top20.Filtro filtro);

    }

}