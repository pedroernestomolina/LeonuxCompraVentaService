using ServiceSistema.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceSistema.MyService
{

    public partial class Service : IService
    {

        public DtoLib.ResultadoLista<DtoLibSistema.GrupoUsuario.Resumen> GrupoUsuario_GetLista()
        {
            return ServiceProv.GrupoUsuario_GetLista();
        }

        public DtoLib.ResultadoEntidad<DtoLibSistema.GrupoUsuario.Ficha> GrupoUsuario_GetFicha(string auto)
        {
            return ServiceProv.GrupoUsuario_GetFicha(auto);
        }

        public DtoLib.ResultadoAuto GrupoUsuario_Agregar(DtoLibSistema.GrupoUsuario.Agregar ficha)
        {
            return ServiceProv.GrupoUsuario_Agregar(ficha);
        }

        public DtoLib.Resultado GrupoUsuario_Editar(DtoLibSistema.GrupoUsuario.Editar ficha)
        {
            return ServiceProv.GrupoUsuario_Editar(ficha);
        }

    }

}