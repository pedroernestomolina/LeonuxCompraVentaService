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

        public DtoLib.ResultadoEntidad<DtoLibPos.Sistema.TipoDocumento.Entidad.Ficha> Sistema_TipoDocumento_GetFichaById(string id)
        {
            return ServiceProv.Sistema_TipoDocumento_GetFichaById(id);
        }

        public DtoLib.ResultadoEntidad<DtoLibPos.Sistema.Serie.Entidad.Ficha> Sistema_Serie_GetFichaById(string id)
        {
            return ServiceProv.Sistema_Serie_GetFichaById(id);
        }

    }

}