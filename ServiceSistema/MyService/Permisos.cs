﻿using ServiceSistema.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceSistema.MyService
{
    
    public partial class Service : IService
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


        public DtoLib.ResultadoEntidad<DtoLibSistema.Permiso.Ficha> Permiso_ToolSistema(string autoGrupoUsuario)
        {
            return ServiceProv.Permiso_ToolSistema (autoGrupoUsuario);
        }

        public DtoLib.ResultadoEntidad<DtoLibSistema.Permiso.Ficha> Permiso_InicializarBD(string autoGrupoUsuario)
        {
            return ServiceProv.Permiso_InicializarBD (autoGrupoUsuario);
        }

        public DtoLib.ResultadoEntidad<DtoLibSistema.Permiso.Ficha> Permiso_InicializarBD_Sucursal(string autoGrupoUsuario)
        {
            return ServiceProv.Permiso_InicializarBD_Sucursal (autoGrupoUsuario);
        }

        public DtoLib.ResultadoEntidad<DtoLibSistema.Permiso.Ficha> Permiso_AjustarTasaDivisa(string autoGrupoUsuario)
        {
            return ServiceProv.Permiso_AjustarTasaDivisa(autoGrupoUsuario);
        }

        public DtoLib.ResultadoEntidad<DtoLibSistema.Permiso.Ficha> Permiso_AjustarTasaDivisaRecepcionPos(string autoGrupoUsuario)
        {
            return ServiceProv.Permiso_AjustarTasaDivisaRecepcionPos(autoGrupoUsuario);
        }

        public DtoLib.ResultadoEntidad<DtoLibSistema.Permiso.Ficha> Permiso_EtiquetaParaPrecios(string autoGrupoUsuario)
        {
            return ServiceProv.Permiso_EtiquetaParaPrecios(autoGrupoUsuario);
        }

        public DtoLib.ResultadoEntidad<DtoLibSistema.Permiso.Ficha> Permiso_AsignarDepositoSucursal(string autoGrupoUsuario)
        {
            return ServiceProv.Permiso_AsignarDepositoSucursal(autoGrupoUsuario);
        }

        public DtoLib.ResultadoEntidad<DtoLibSistema.Permiso.Ficha> Permiso_AsignarDepositoSucursal_EliminarAsignacion(string autoGrupoUsuario)
        {
            return ServiceProv.Permiso_AsignarDepositoSucursal_EliminarAsignacion(autoGrupoUsuario);
        }

        public DtoLib.ResultadoEntidad<DtoLibSistema.Permiso.Ficha> Permiso_AsignarDepositoSucursal_EditarAsignacion(string autoGrupoUsuario)
        {
            return ServiceProv.Permiso_AsignarDepositoSucursal_EditarAsignacion(autoGrupoUsuario);
        }
        
        public DtoLib.ResultadoEntidad<DtoLibSistema.Permiso.Ficha> Permiso_ControlSucursalGrupo(string autoGrupoUsuario)
        {
            return ServiceProv.Permiso_ControlSucursalGrupo(autoGrupoUsuario);
        }

        public DtoLib.ResultadoEntidad<DtoLibSistema.Permiso.Ficha> Permiso_ControlSucursalGrupo_Agregar(string autoGrupoUsuario)
        {
            return ServiceProv.Permiso_ControlSucursalGrupo_Agregar(autoGrupoUsuario);
        }

        public DtoLib.ResultadoEntidad<DtoLibSistema.Permiso.Ficha> Permiso_ControlSucursalGrupo_Editar(string autoGrupoUsuario)
        {
            return ServiceProv.Permiso_ControlSucursalGrupo_Editar(autoGrupoUsuario);
        }

        public DtoLib.ResultadoEntidad<DtoLibSistema.Permiso.Ficha> Permiso_ControlSucursal(string autoGrupoUsuario)
        {
            return ServiceProv.Permiso_ControlSucursal(autoGrupoUsuario);
        }

        public DtoLib.ResultadoEntidad<DtoLibSistema.Permiso.Ficha> Permiso_ControlSucursal_Agregar(string autoGrupoUsuario)
        {
            return ServiceProv.Permiso_ControlSucursal_Agregar(autoGrupoUsuario);
        }

        public DtoLib.ResultadoEntidad<DtoLibSistema.Permiso.Ficha> Permiso_ControlSucursal_Editar(string autoGrupoUsuario)
        {
            return ServiceProv.Permiso_ControlSucursal_Editar(autoGrupoUsuario);
        }

        public DtoLib.ResultadoEntidad<DtoLibSistema.Permiso.Ficha> Permiso_ControlDeposito(string autoGrupoUsuario)
        {
            return ServiceProv.Permiso_ControlDeposito(autoGrupoUsuario);
        }

        public DtoLib.ResultadoEntidad<DtoLibSistema.Permiso.Ficha> Permiso_ControlDeposito_Agregar(string autoGrupoUsuario)
        {
            return ServiceProv.Permiso_ControlDeposito_Agregar(autoGrupoUsuario);
        }

        public DtoLib.ResultadoEntidad<DtoLibSistema.Permiso.Ficha> Permiso_ControlDeposito_Editar(string autoGrupoUsuario)
        {
            return ServiceProv.Permiso_ControlDeposito_Editar(autoGrupoUsuario);
        }

    }

}