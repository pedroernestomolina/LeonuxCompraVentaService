using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceSistema.Interfaces
{

    public interface IService: ISucursal, IDeposito, ISucursalGrupo, IUsuario, IPrecio
    {

        DtoLib.ResultadoEntidad<DateTime> FechaServidor();

    }

}
