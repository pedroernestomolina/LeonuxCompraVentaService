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

        public DtoLib.Resultado Servidor_Test()
        {
            return ServiceProv.Servidor_Test();
        }

        public DtoLib.Resultado Servidor_ActualizarData()
        {
            return ServiceProv.Servidor_ActualizarData();
        }

    }

}