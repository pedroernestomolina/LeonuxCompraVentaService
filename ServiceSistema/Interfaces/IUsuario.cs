using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceSistema.Interfaces
{
    
    public interface IUsuario
    {

        DtoLib.ResultadoEntidad<DtoLibSistema.Usuario.Ficha> Usuario_Principal();

    }

}