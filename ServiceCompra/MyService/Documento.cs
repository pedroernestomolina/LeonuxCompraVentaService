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

        public DtoLib.ResultadoEntidad<DtoLibCompra.Documento.Visualizar.Ficha> Compra_DocumentoVisualizar(string auto)
        {
            return ServiceProv.Compra_DocumentoVisualizar(auto);
        }

        public DtoLib.ResultadoLista<DtoLibCompra.Documento.Lista.Resumen> Compra_DocumentoGetLista(DtoLibCompra.Documento.Lista.Filtro filtro)
        {
            return ServiceProv.Compra_DocumentoGetLista(filtro);
        }

        public DtoLib.Resultado Compra_DocumentoAnularFactura(DtoLibCompra.Documento.Anular.Factura.Ficha ficha)
        {
            var r01 = ServiceProv.Compra_DocumentoAnular_Verificar(ficha.autoDocumento);
            if (r01.Result == DtoLib.Enumerados.EnumResult.isError)
                return r01;
            return ServiceProv.Compra_DocumentoAnularFactura(ficha);
        }

        public DtoLib.ResultadoAuto Compra_DocumentoAgregarFactura(DtoLibCompra.Documento.Agregar.Factura.Ficha docFac)
        {
            return ServiceProv.Compra_DocumentoAgregarFactura(docFac);
        }

        public DtoLib.ResultadoLista<DtoLibCompra.Documento.ListaRemision.Ficha> Compra_DocumentoGetListaRemision(DtoLibCompra.Documento.ListaRemision.Filtro filtro)
        {
            return ServiceProv.Compra_DocumentoGetListaRemision(filtro);
        }

        public DtoLib.ResultadoEntidad<DtoLibCompra.Documento.Cargar.Ficha> Compra_DocumentoGetFicha(string auto)
        {
            return ServiceProv.Compra_DocumentoGetFicha(auto);
        }

    }

}