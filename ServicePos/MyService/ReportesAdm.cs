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

    }

}