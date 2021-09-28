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

        public DtoLib.ResultadoId Operador_Abrir(DtoLibPosOffLine.Operador.Abrir.Ficha ficha)
        {
            var result = new DtoLib.ResultadoId();

            var r01 = ServiceProv.Operador_Abrir_VerificaIsOk();
            if (r01.Entidad)
            {
                return ServiceProv.Operador_Abrir (ficha);
            }
            else
            {
                result.Mensaje = r01.Mensaje;
                result.Result = DtoLib.Enumerados.EnumResult.isError;
                result.Id = -1;
                return result;
            }
        }

        public DtoLib.Resultado Operador_Cerrar(DtoLibPosOffLine.Operador.Cerrar.Ficha ficha)
        {
            return ServiceProv.Operador_Cerrar(ficha);
        }

        public DtoLib.ResultadoEntidad<DtoLibPosOffLine.Operador.Cargar.Ficha> Operador_Cargar(int idOperador)
        {
            return ServiceProv.Operador_Cargar(idOperador);
        }

        public DtoLib.ResultadoEntidad<int> Operador_Activa()
        {
            return ServiceProv.Operador_Activa();
        }

        public DtoLib.ResultadoEntidad<DtoLibPosOffLine.Operador.Movimiento.Ficha> Operador_Movimientos(int idOperador)
        {
            return ServiceProv.Operador_Movimientos(idOperador);
        }

        public DtoLib.Resultado Operador_Jornada_Cerrar(DtoLibPosOffLine.Operador.Cerrar.Ficha ficha)
        {
            return ServiceProv.Operador_Jornada_Cerrar(ficha);
        }

    }

}