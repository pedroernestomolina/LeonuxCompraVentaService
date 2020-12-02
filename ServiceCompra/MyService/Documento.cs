using ServiceCompra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceCompra.MyService
{
    
    public partial class Service: IService
    {

        public DtoLib.ResultadoAuto Compra_DocumentoAgregarFactura(DtoLibCompra.Documento.Cargar.Factura.Ficha docFac)
        {
            return ServiceProv.Compra_DocumentoAgregarFactura(docFac);
        }

        public DtoLib.ResultadoEntidad<DtoLibCompra.Documento.Visualizar.Ficha> Compra_DocumentoVisualizar(string auto)
        {
            return ServiceProv.Compra_DocumentoVisualizar(auto);
        }

    }

}