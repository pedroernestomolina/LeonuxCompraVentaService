using ServiceVenta.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceVenta.MyService
{

    public partial class Service: IService
    {

        public DtoLib.ResultadoEntidad<decimal> FactorCambioDivisa()
        {
            return ServiceProv.FactorCambioDivisa();
        }

        public DtoLib.ResultadoEntidad<decimal> FactorCambioDivisaParaRecibir()
        {
            return ServiceProv.FactorCambioDivisaParaRecibir();
        }

        public DtoLib.ResultadoEntidad<DtoLibVenta.Sistema.Enumerados.enumPreferenciaBusquedaProducto> PreferenciaBusquedaProducto()
        {
            return ServiceProv.PreferenciaBusquedaProducto();
        }

        public DtoLib.ResultadoEntidad<DtoLibVenta.Sistema.Enumerados.enumPreferenciaBusquedaCliente> PreferenciaBusquedaCliente()
        {
            return ServiceProv.PreferenciaBusquedaCliente();
        }

        public DtoLib.ResultadoEntidad<DtoLibVenta.Sistema.Enumerados.enumMetodoCalculoUtilidad> MetodoCalculoUtilidad()
        {
            return ServiceProv.MetodoCalculoUtilidad();
        }

        public DtoLib.ResultadoEntidad<bool> HabilitarRupturaPorExistencia()
        {
            return ServiceProv.HabilitarRupturaPorExistencia();
        }

        public DtoLib.ResultadoEntidad<bool> HabilitarAlertaPorExistenciaEnNegativa()
        {
            return ServiceProv.HabilitarAlertaPorExistenciaEnNegativa();
        }

        public DtoLib.ResultadoEntidad<string> Clave_NivelMinimo()
        {
            return ServiceProv.Clave_NivelMinimo ();
        }

        public DtoLib.ResultadoEntidad<string> Clave_NivelMedio()
        {
            return ServiceProv.Clave_NivelMedio();
        }

        public DtoLib.ResultadoEntidad<string> Clave_NivelMaximo()
        {
            return ServiceProv.Clave_NivelMaximo();
        }

    }

}
