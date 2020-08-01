﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceSistema.Interfaces
{
    
    public interface IUsuario
    {

        DtoLib.ResultadoEntidad<DtoLibSistema.Usuario.Ficha> Usuario_Principal();
        DtoLib.ResultadoLista<DtoLibSistema.Usuario.Resumen> Usuario_GetLista();
        DtoLib.ResultadoEntidad<DtoLibSistema.Usuario.Ficha> Usuario_GetFicha(string autoUsu);
        DtoLib.ResultadoAuto Usuario_Agregar(DtoLibSistema.Usuario.Agregar ficha);
        DtoLib.Resultado Usuario_Editar(DtoLibSistema.Usuario.Editar ficha);
        DtoLib.Resultado Usuario_Activar(DtoLibSistema.Usuario.Activar ficha);
        DtoLib.Resultado Usuario_Inactivar(DtoLibSistema.Usuario.Inactivar ficha);

    }

}