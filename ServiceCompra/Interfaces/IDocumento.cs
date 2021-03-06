﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceCompra.Interfaces
{
    
    public interface IDocumento
    {

        DtoLib.ResultadoAuto Compra_DocumentoAgregarFactura(DtoLibCompra.Documento.Agregar.Factura.Ficha docFac);
        DtoLib.ResultadoAuto Compra_DocumentoAgregarNC (DtoLibCompra.Documento.Agregar.NotaCredito.Ficha docNC);
        DtoLib.ResultadoEntidad<DtoLibCompra.Documento.Cargar.Ficha> Compra_DocumentoGetFicha(string auto);
        DtoLib.ResultadoEntidad<DtoLibCompra.Documento.Visualizar.Ficha> Compra_DocumentoVisualizar(string auto);
        DtoLib.ResultadoLista<DtoLibCompra.Documento.Lista.Resumen> Compra_DocumentoGetLista(DtoLibCompra.Documento.Lista.Filtro filtro);
        DtoLib.ResultadoLista<DtoLibCompra.Documento.ListaRemision.Ficha> Compra_DocumentoGetListaRemision(DtoLibCompra.Documento.ListaRemision.Filtro filtro);
        DtoLib.Resultado Compra_DocumentoAnularFactura(DtoLibCompra.Documento.Anular.Factura.Ficha ficha);
        DtoLib.Resultado Compra_DocumentoAnularNotaCredito(DtoLibCompra.Documento.Anular.NotaCredito.Ficha ficha);
        DtoLib.Resultado Compra_DocumentoCorrectorFactura(DtoLibCompra.Documento.Corrector.Factura.Ficha docFac);

    }

}