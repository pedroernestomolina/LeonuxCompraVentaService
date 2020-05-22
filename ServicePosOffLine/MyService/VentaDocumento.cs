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

        public DtoLib.ResultadoId VentaDocumento_Agregar(DtoLibPosOffLine.VentaDocumento.Agregar ficha)
        {
            if (ficha.TipoDocumento == 1) 
            {
                if (ficha.Items == null) 
                {
                    return new DtoLib.ResultadoId() { Id = -1, Mensaje = "ITEMS NO DEFINIDO", Result = DtoLib.Enumerados.EnumResult.isError };
                }
                if (ficha.Items.Count==0)
                {
                    return new DtoLib.ResultadoId() { Id = -1, Mensaje = "NO HAY ITEMS QUE REGISTRAR", Result = DtoLib.Enumerados.EnumResult.isError };
                }
                if (ficha.ItemsLimpiar == null)
                {
                    return new DtoLib.ResultadoId() { Id = -1, Mensaje = "ITEMS A ELIMINAR NO DEFINIDO", Result = DtoLib.Enumerados.EnumResult.isError };
                }
                if (ficha.ItemsLimpiar.Count==0)
                {
                    return new DtoLib.ResultadoId() { Id = -1, Mensaje = "NO HAY ITEMS QUE ELIMINAR", Result = DtoLib.Enumerados.EnumResult.isError };
                }
                if (ficha.IsCredito == "N")
                {
                    if (ficha.MetodosPago == null)
                    {
                        return new DtoLib.ResultadoId() { Id = -1, Mensaje = "METODOS DE PAGO NO DEFINIDO", Result = DtoLib.Enumerados.EnumResult.isError };
                    }
                    if (ficha.MetodosPago.Count == 0)
                    {
                        return new DtoLib.ResultadoId() { Id = -1, Mensaje = "NO HAY METODOS DE PAGO QUE REGISTRAR", Result = DtoLib.Enumerados.EnumResult.isError };
                    }
                }
            }
            return ServiceProv.VentaDocumento_Agregar(ficha);
        }

        public DtoLib.ResultadoLista<DtoLibPosOffLine.VentaDocumento.Lista.Resumen> VentaDocumento_Lista(DtoLibPosOffLine.VentaDocumento.Lista.Filtro filtro)
        {
            return ServiceProv.VentaDocumento_Lista(filtro);
        }

    }

}