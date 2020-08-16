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

        public DtoLib.ResultadoLista<DtoLibPosOffLine.Reporte.Pago.Detalle.Ficha> Reporte_Pago_Detalle(DtoLibPosOffLine.Reporte.Pago.Filtro filtro)
        {
            return ServiceProv.Reporte_Pago_Detalle(filtro);
        }

        public DtoLib.ResultadoLista<DtoLibPosOffLine.Reporte.NCredito.Ficha> Reporte_NCredito(DtoLibPosOffLine.Reporte.NCredito.Filtro filtro)
        {
            return ServiceProv.Reporte_NCredito(filtro);
        }

        public DtoLib.ResultadoEntidad<DtoLibPosOffLine.Reporte.Pago.Resumen.Ficha> Reporte_Pago_Resumen(DtoLibPosOffLine.Reporte.Pago.Filtro filtro)
        {
            return ServiceProv.Reporte_Pago_Resumen(filtro);
        }

    }

}