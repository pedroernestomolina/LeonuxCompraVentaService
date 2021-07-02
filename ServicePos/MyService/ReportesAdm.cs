using ServicePos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServicePos.MyService
{
    
    public partial class Service : IService
    {

        public DtoLib.ResultadoLista<DtoLibPos.Reportes.VentaAdministrativa.GeneralDocumento.Ficha> ReportesAdm_GeneralDocumento(DtoLibPos.Reportes.VentaAdministrativa.GeneralDocumento.Filtro filtro)
        {
            return ServiceProv.ReportesAdm_GeneralDocumento(filtro);
        }

        public DtoLib.ResultadoLista<DtoLibPos.Reportes.VentaAdministrativa.GeneralPorDepartamento.Ficha> ReportesAdm_GeneralPorDepartamento(DtoLibPos.Reportes.VentaAdministrativa.GeneralPorDepartamento.Filtro filtro)
        {
            return ServiceProv.ReportesAdm_GeneralPorDepartamento(filtro);
        }

        public DtoLib.ResultadoLista<DtoLibPos.Reportes.VentaAdministrativa.GeneralPorGrupo.Ficha> ReportesAdm_GeneralPorGrupo(DtoLibPos.Reportes.VentaAdministrativa.GeneralPorGrupo.Filtro filtro)
        {
            return ServiceProv.ReportesAdm_GeneralPorGrupo(filtro);
        }

        public DtoLib.ResultadoLista<DtoLibPos.Reportes.VentaAdministrativa.Resumen.Ficha> ReportesAdm_Resumen(DtoLibPos.Reportes.VentaAdministrativa.Resumen.Filtro filtro)
        {
            return ServiceProv.ReportesAdm_Resumen(filtro);
        }

        public DtoLib.ResultadoLista<DtoLibPos.Reportes.VentaAdministrativa.VentaPorProducto.Ficha> ReportesAdm_VentaPorProducto(DtoLibPos.Reportes.VentaAdministrativa.VentaPorProducto.Filtro filtro)
        {
            return ServiceProv.ReportesAdm_VentaPorProducto(filtro);
        }

        public DtoLib.ResultadoLista<DtoLibPos.Reportes.VentaAdministrativa.GeneralDocumentoDetalle.Ficha> Reporte_GenrealDocumentoDetalle(DtoLibPos.Reportes.VentaAdministrativa.GeneralDocumentoDetalle.Filtro filtro)
        {
            return ServiceProv.Reporte_GenrealDocumentoDetalle(filtro);
        }

        public DtoLib.ResultadoLista<DtoLibPos.Reportes.VentaAdministrativa.Consolidado.Ficha> Reporte_Consolidado(DtoLibPos.Reportes.VentaAdministrativa.Consolidado.Filtro filtro)
        {
            return ServiceProv.Reporte_Consolidado(filtro);
        }

    }

}