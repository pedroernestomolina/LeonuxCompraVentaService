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

        public DtoLib.Resultado Pendiente_DejarCtaEnPendiente(DtoLibPosOffLine.Pendiente.DejarEnPendiente.Agregar ficha)
        {
            return ServiceProv.Pendiente_DejarCtaEnPendiente(ficha);
        }

        public DtoLib.ResultadoLista<DtoLibPosOffLine.Pendiente.Listar.Resumen> Pendiente_Lista()
        {
            return ServiceProv.Pendiente_Lista();
        }

        public DtoLib.Resultado Pendiente_EliminarCtaEnPendiente(int id)
        {
            return ServiceProv.Pendiente_EliminarCtaEnPendiente(id);
        }

        DtoLib.ResultadoEntidad<DtoLibPosOffLine.Pendiente.CtaAbrir.Ficha> IPendiente.Pendiente_AbrirCtaEnPendiente(int id)
        {
            return ServiceProv.Pendiente_AbrirCtaEnPendiente(id);
        }

    }

}