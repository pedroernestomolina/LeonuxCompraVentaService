using ServiceVenta.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceVenta.MyService
{
    
    public partial class Service: IService
    {

        public DtoLib.ResultadoLista<DtoLibVenta.Cliente.Resumen> ClienteLista(DtoLibVenta.Cliente.Filtro filtro)
        {
            return ServiceProv.ClienteLista(filtro);
        }

        public DtoLib.ResultadoEntidad<DtoLibVenta.Cliente.DetalleResumen> ClienteDetalleResumen(string auto)
        {
            return ServiceProv.ClienteDetalleResumen(auto);
        }

        public DtoLib.ResultadoLista<DtoLibVenta.Cliente.PendientePorCobrar> ClienteDocPendientePorCobrar(string auto)
        {
            return ServiceProv.ClienteDocPendientePorCobrar(auto);
        }

        public DtoLib.ResultadoAuto ClienteAgregarEventual(DtoLibVenta.Cliente.AgregarEventual ficha)
        {
            return ServiceProv.ClienteAgregarEventual(ficha);
        }

    }

}