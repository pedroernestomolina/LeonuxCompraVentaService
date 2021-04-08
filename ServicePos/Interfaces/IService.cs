using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServicePos.Interfaces
{

    public interface IService : IProducto, ICliente, ISucursal, IDeposito,
        ICobrador, IVendedor, IMedioPago, IConcepto, ITransporte, ISistema,
        IFiscal, IUsuario, IPermiso, IConfiguracion, IJornada, IDocumento,
        IVenta
    {

        DtoLib.ResultadoEntidad<DateTime> FechaServidor();
        //DtoLib.ResultadoEntidad<DtoLibInventario.Empresa.Data.Ficha> Empresa_Datos();
        //DtoLib.ResultadoEntidad<DtoLibPosOffLine.Sistema.InformacionBD.Ficha> InformacionBD();

    }

}