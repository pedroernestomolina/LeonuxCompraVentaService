using ServicePosOffLine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServicePosOffLine.MyService
{

    public partial class Service: IService
    {

        public DtoLib.ResultadoEntidad<DtoLibPosOffLine.Usuario.Ficha> Usuario_Cargar(DtoLibPosOffLine.Usuario.Cargar ficha)
        {
            return ServiceProv.Usuario_Cargar(ficha);
        }

    }

}
