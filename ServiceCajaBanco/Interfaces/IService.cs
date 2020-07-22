using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceCajaBanco.Interfaces
{
 
    public interface IService: ISucursal, IUsuario, IReporteMovimiento
    {

        DtoLib.ResultadoEntidad<DateTime> FechaServidor();

    }

}