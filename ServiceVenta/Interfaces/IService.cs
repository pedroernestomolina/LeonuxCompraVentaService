using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceVenta.Interfaces
{
    
    public interface IService: ICliente, IDeposito, ISucursal, ICobrador, IVendedor, ITransporte, 
        IProducto, IConfiguracion, IExistencia, IPrecio, IPermiso, IVenta, IMovInvConcepto,
        ISeries, IFiscal
    {

        DtoLib.ResultadoEntidad<DateTime> FechaServidor();

    }

}