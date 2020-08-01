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

        public DtoLib.ResultadoEntidad<DtoLibSistema.Usuario.Ficha> Usuario_Principal()
        {
            return ServiceProv.Usuario_Principal();
        }

        public DtoLib.ResultadoLista<DtoLibSistema.Usuario.Resumen> Usuario_GetLista()
        {
            return ServiceProv.Usuario_GetLista ();
        }

        public DtoLib.ResultadoEntidad<DtoLibSistema.Usuario.Ficha> Usuario_GetFicha(string autoUsu)
        {
            return ServiceProv.Usuario_GetFicha(autoUsu);
        }

        public DtoLib.ResultadoAuto Usuario_Agregar(DtoLibSistema.Usuario.Agregar ficha)
        {
            return ServiceProv.Usuario_Agregar(ficha);
        }

        public DtoLib.Resultado Usuario_Editar(DtoLibSistema.Usuario.Editar ficha)
        {
            return ServiceProv.Usuario_Editar(ficha);
        }

        public DtoLib.Resultado Usuario_Activar(DtoLibSistema.Usuario.Activar ficha)
        {
            return ServiceProv.Usuario_Activar(ficha);
        }

        public DtoLib.Resultado Usuario_Inactivar(DtoLibSistema.Usuario.Inactivar ficha)
        {
            return ServiceProv.Usuario_Inactivar(ficha);
        }

    }

}