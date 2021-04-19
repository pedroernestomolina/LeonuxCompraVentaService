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

        public DtoLib.ResultadoEntidad<DtoLibPos.Permiso.Entidad.Ficha> Permiso_IngresarPos(string idGrupoUsu)
        {
            return ServiceProv.Permiso_IngresarPos(idGrupoUsu);
        }

        public DtoLib.ResultadoEntidad<DtoLibPos.Permiso.Entidad.Ficha> Permiso_Pos(string idGrupoUsu, string codFuncion)
        {
            return ServiceProv.Permiso_Pos(idGrupoUsu, codFuncion);
        }

    }

}