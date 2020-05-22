using ServicePosOffLine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServicePosOffLine.MyService
{

    public partial class Service: IService
    {

        public DtoLib.ResultadoEntidad<decimal> Configuracion_FactorCambio()
        {
            return ServiceProv.Configuracion_FactorCambio();
        }

        public DtoLib.ResultadoEntidad<DtoLibPosOffLine.Configuracion.ModoPos.Ficha> Configuracion_ModoPos()
        {
            return ServiceProv.Configuracion_ModoPos();
        }

        public DtoLib.ResultadoEntidad<DtoLibPosOffLine.Configuracion.Repesaje.Ficha> Configuracion_Repesaje()
        {
            return ServiceProv.Configuracion_Repesaje();
        }

        public DtoLib.ResultadoEntidad<DtoLibPosOffLine.Configuracion.Serie.Ficha> Configuracion_Serie()
        {
            return ServiceProv.Configuracion_Serie();
        }

        public DtoLib.ResultadoEntidad<DtoLibPosOffLine.Configuracion.Sucursal.Ficha> Configuracion_Sucursal()
        {
            return ServiceProv.Configuracion_Sucursal();
        }

        public DtoLib.ResultadoEntidad<DtoLibPosOffLine.Configuracion.Vendedor.Ficha> Configuracion_Vendedor()
        {
            return ServiceProv.Configuracion_Vendedor();
        }

        public DtoLib.ResultadoEntidad<DtoLibPosOffLine.Configuracion.Deposito.Ficha> Configuracion_Deposito()
        {
            return ServiceProv.Configuracion_Deposito();
        }

        public DtoLib.ResultadoEntidad<bool> Configuracion_ActivarBusquedaPorDescripcion()
        {
            return ServiceProv.Configuracion_ActivarBusquedaPorDescripcion();
        }

        public DtoLib.ResultadoEntidad<DtoLibPosOffLine.Configuracion.Cobrador.Ficha> Configuracion_Cobrador()
        {
            return ServiceProv.Configuracion_Cobrador();
        }

        public DtoLib.ResultadoEntidad<DtoLibPosOffLine.Configuracion.Transporte.Ficha> Configuracion_Transporte()
        {
            return ServiceProv.Configuracion_Transporte();
        }

        public DtoLib.ResultadoEntidad<DtoLibPosOffLine.Configuracion.MedioCobro.Ficha> Configuracion_MedioCobro()
        {
            return ServiceProv.Configuracion_MedioCobro();
        }

        public DtoLib.ResultadoEntidad<DtoLibPosOffLine.Configuracion.ClaveAcceso.Ficha> Configuracion_ClavePos()
        {
            return ServiceProv.Configuracion_ClavePos();
        }

        public DtoLib.Resultado Configuracion_Actualizar(DtoLibPosOffLine.Configuracion.Guardar.Ficha ficha)
        {
            return ServiceProv.Configuracion_Actualizar(ficha);
        }

    }

}