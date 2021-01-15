using ServiceCompra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceCompra.MyService
{
    
    public partial class Service: IService
    {

        public DtoLib.ResultadoEntidad<string> Permiso_PedirClaveAcceso_NivelMaximo()
        {
            return ServiceProv.Permiso_PedirClaveAcceso_NivelMaximo();
        }

        public DtoLib.ResultadoEntidad<string> Permiso_PedirClaveAcceso_NivelMedio()
        {
            return ServiceProv.Permiso_PedirClaveAcceso_NivelMedio();
        }

        public DtoLib.ResultadoEntidad<string> Permiso_PedirClaveAcceso_NivelMinimo()
        {
            return ServiceProv.Permiso_PedirClaveAcceso_NivelMinimo();
        }

        public DtoLib.ResultadoEntidad<DtoLibCompra.Permiso.Ficha> Permiso_ToolCompra(string autoGrupoUsuario)
        {
            return ServiceProv.Permiso_ToolCompra(autoGrupoUsuario);
        }


        public DtoLib.ResultadoEntidad<DtoLibCompra.Permiso.Ficha> Permiso_Registrar_Factura(string autoGrupoUsuario)
        {
            return ServiceProv.Permiso_Registrar_Factura(autoGrupoUsuario);
        }

        public DtoLib.ResultadoEntidad<DtoLibCompra.Permiso.Ficha> Permiso_Registrar_Nc(string autoGrupoUsuario)
        {
            return ServiceProv.Permiso_Registrar_Nc(autoGrupoUsuario);
        }


        public DtoLib.ResultadoEntidad<DtoLibCompra.Permiso.Ficha> Permiso_AdmDoc(string autoGrupoUsuario)
        {
            return ServiceProv.Permiso_AdmDoc(autoGrupoUsuario);
        }

        public DtoLib.ResultadoEntidad<DtoLibCompra.Permiso.Ficha> Permiso_AdmDoc_Anular(string autoGrupoUsuario)
        {
            return ServiceProv.Permiso_AdmDoc_Anular(autoGrupoUsuario);
        }

        public DtoLib.ResultadoEntidad<DtoLibCompra.Permiso.Ficha> Permiso_AdmDoc_Visualizar(string autoGrupoUsuario)
        {
            return ServiceProv.Permiso_AdmDoc_Visualizar(autoGrupoUsuario);
        }

        public DtoLib.ResultadoEntidad<DtoLibCompra.Permiso.Ficha> Permiso_AdmDoc_Reporte(string autoGrupoUsuario)
        {
            return ServiceProv.Permiso_AdmDoc_Reporte(autoGrupoUsuario);
        }

        public DtoLib.ResultadoEntidad<DtoLibCompra.Permiso.Ficha> Permiso_Reportes(string autoGrupoUsuario)
        {
            return ServiceProv.Permiso_Reportes(autoGrupoUsuario);
        }

    }

}