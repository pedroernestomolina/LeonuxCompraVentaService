﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceInventario.Interfaces
{
    
    public interface IConfiguracion
    {

        DtoLib.ResultadoEntidad<DtoLibInventario.Configuracion.Enumerados.EnumPreferenciaBusqueda> Configuracion_PreferenciaBusqueda();
        DtoLib.ResultadoEntidad<DtoLibInventario.Configuracion.Enumerados.EnumMetodoCalculoUtilidad> Configuracion_MetodoCalculoUtilidad();
        DtoLib.ResultadoEntidad<string> Configuracion_TasaCambioActual();
        DtoLib.ResultadoEntidad<DtoLibInventario.Configuracion.Enumerados.EnumForzarRedondeoPrecioVenta> Configuracion_ForzarRedondeoPrecioVenta();
        DtoLib.ResultadoEntidad<DtoLibInventario.Configuracion.Enumerados.EnumPreferenciaRegistroPrecio> Configuracion_PreferenciaRegistroPrecio();
        DtoLib.ResultadoEntidad<int> Configuracion_CostoEdadProducto();

        DtoLib.Resultado Configuracion_SetCostoEdadProducto(DtoLibInventario.Configuracion.CostoEdad.Editar.Ficha ficha);
        DtoLib.Resultado Configuracion_SetRedondeoPrecioVenta(DtoLibInventario.Configuracion.RedondeoPrecio.Editar.Ficha ficha);
        DtoLib.Resultado Configuracion_SetPreferenciaRegistroPrecio(DtoLibInventario.Configuracion.PreferenciaPrecio.Editar.Ficha ficha);
        DtoLib.Resultado Configuracion_SetMetodoCalculoUtilidad(DtoLibInventario.Configuracion.MetodoCalculoUtilidad.Editar.Ficha ficha);
        DtoLib.Resultado Configuracion_SetBusquedaPredeterminada(DtoLibInventario.Configuracion.BusquedaPredeterminada.Editar.Ficha ficha);

        DtoLib.ResultadoLista<DtoLibInventario.Configuracion.MetodoCalculoUtilidad.CapturarData.Ficha> Configuracion_MetodoCalculoUtilidad_CapturarData();

        DtoLib.ResultadoEntidad<string> Configuracion_HabilitarPrecio_5_ParaVentaMayorPos();

    }

}