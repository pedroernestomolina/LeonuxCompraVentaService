using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServicePosOffLine.Interfaces
{
    
    public interface IUsuario
    {

        DtoLib.ResultadoEntidad<DtoLibPosOffLine.Usuario.Ficha> Usuario_Cargar(DtoLibPosOffLine.Usuario.Cargar ficha);

    }

}