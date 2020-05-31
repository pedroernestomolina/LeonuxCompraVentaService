using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServicePosOffLine.Interfaces
{
    
    public interface IPendiente
    {

        DtoLib.Resultado Pendiente_DejarCtaEnPendiente(DtoLibPosOffLine.Pendiente.DejarEnPendiente.Agregar ficha);
        DtoLib.ResultadoLista<DtoLibPosOffLine.Pendiente.Listar.Resumen> Pendiente_Lista();
        DtoLib.ResultadoEntidad<DtoLibPosOffLine.Pendiente.CtaAbrir.Ficha> Pendiente_AbrirCtaEnPendiente(int id);
        DtoLib.Resultado Pendiente_EliminarCtaEnPendiente(int id);

    }

}