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

        public DtoLib.ResultadoId Jornada_Abrir(DtoLibPosOffLine.Jornada.Abrir.Ficha ficha)
        {
            var result = new DtoLib.ResultadoId();

            var r01=ServiceProv.Jornada_Abrir_VerificaIsOk();
            if (r01.Entidad)
            {
                return ServiceProv.Jornada_Abrir(ficha);
            }
            else 
            {
                result.Mensaje = r01.Mensaje;
                result.Result = DtoLib.Enumerados.EnumResult.isError;
                result.Id = -1;
                return result;
            }
        }

        public DtoLib.Resultado Jornada_Cerrar(DtoLibPosOffLine.Jornada.Cerrar.Ficha ficha)
        {
            return ServiceProv.Jornada_Cerrar(ficha);
        }

        public DtoLib.ResultadoEntidad<DtoLibPosOffLine.Jornada.Cargar.Ficha> Jornada_Cargar(int idJornada)
        {
            return ServiceProv.Jornada_Cargar(idJornada);
        }

        public DtoLib.ResultadoEntidad<int> Jornada_Activa()
        {
            return ServiceProv.Jornada_Activa();
        }

    }

}