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

        public DtoLib.ResultadoLista<DtoLibPos.Cliente.Lista.Ficha> Cliente_GetLista(DtoLibPos.Cliente.Lista.Filtro filtro)
        {
            return ServiceProv.Cliente_GetLista(filtro);
        }

        public DtoLib.ResultadoEntidad<DtoLibPos.Cliente.Entidad.Ficha> Cliente_GetFichaById(string id)
        {
            return ServiceProv.Cliente_GetFichaById(id);
        }

        public DtoLib.ResultadoEntidad<DtoLibPos.Cliente.Entidad.Ficha> Cliente_GetFichaByCiRif(string ciRif)
        {
            return ServiceProv.Cliente_GetFichaByCiRif(ciRif);
        }

        public DtoLib.ResultadoAuto Cliente_Agregar(DtoLibPos.Cliente.Agregar.Ficha ficha)
        {
            return ServiceProv.Cliente_Agregar(ficha);
        }

    }

}