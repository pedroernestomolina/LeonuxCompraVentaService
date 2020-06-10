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

        public DtoLib.Resultado Servidor_EnviarData(DtoLibPosOffLine.Servidor.EnviarData.Ficha ficha)
        {
            return ServiceProv.Servidor_EnviarData(ficha);
        }

        public DtoLib.ResultadoEntidad<DtoLibPosOffLine.Servidor.RecogerDataEnviar.Ficha> Servidor_RecogerDataEnviar()
        {
            return ServiceProv.Servidor_RecogerDataEnviar();
        }

    }

}