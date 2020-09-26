using ServiceInventario.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceInventario.MyService
{

    public partial class Service: IService
    {

        public DtoLib.ResultadoLista<DtoLibInventario.Movimiento.Traslado.Consultar.ProductoPorDebajoNivelMinimo> Producto_Movimiento_Traslado_Consultar_ProductosPorDebajoNivelMinimo(DtoLibInventario.Movimiento.Traslado.Consultar.Filtro filtro)
        {
            return ServiceProv.Producto_Movimiento_Traslado_Consultar_ProductosPorDebajoNivelMinimo(filtro);
        }

        public DtoLib.ResultadoAuto Producto_Movimiento_Traslado_Insertar(DtoLibInventario.Movimiento.Traslado.Insertar.Ficha ficha)
        {
            var lista = new List<DtoLibInventario.Movimiento.Verificar.ExistenciaDisponible.Ficha>();
            foreach (var rg in ficha.prdDeposito)
            {
                lista.Add(new DtoLibInventario.Movimiento.Verificar.ExistenciaDisponible.Ficha()
                {
                    autoProducto = rg.autoProducto,
                    autoDeposito = rg.autoDepositoOrigen,
                    cantidadUnd = rg.cantidadUnd,
                });
            }
            var rt = ServiceProv.Producto_Movimiento_Verificar_ExistenciaDisponible(lista);
            if (rt.Result == DtoLib.Enumerados.EnumResult.isError || rt.Entidad == false)
            {
                var rte = new DtoLib.ResultadoAuto()
                {
                    Auto = "",
                    Mensaje = rt.Mensaje,
                    Result = DtoLib.Enumerados.EnumResult.isError,
                };
                return rte;
            }
            return ServiceProv.Producto_Movimiento_Traslado_Insertar(ficha);
        }

        public DtoLib.ResultadoEntidad<DtoLibInventario.Movimiento.Ver.Ficha> Producto_Movimiento_GetFicha(string autoDoc)
        {
            return ServiceProv.Producto_Movimiento_GetFicha(autoDoc);
        }

        public DtoLib.ResultadoAuto Producto_Movimiento_Cargo_Insertar(DtoLibInventario.Movimiento.Cargo.Insertar.Ficha ficha)
        {
            return ServiceProv.Producto_Movimiento_Cargo_Insertar(ficha);
        }

        public DtoLib.ResultadoAuto Producto_Movimiento_DesCargo_Insertar(DtoLibInventario.Movimiento.DesCargo.Insertar.Ficha ficha)
        {
            var lista = new List<DtoLibInventario.Movimiento.Verificar.ExistenciaDisponible.Ficha>();
            foreach (var rg in ficha.prdDeposito) 
            {
                lista.Add(new DtoLibInventario.Movimiento.Verificar.ExistenciaDisponible.Ficha()
                {
                    autoProducto = rg.autoProducto,
                    autoDeposito = rg.autoDeposito,
                    cantidadUnd = rg.cantidadUnd,
                });
            }
            var rt =ServiceProv.Producto_Movimiento_Verificar_ExistenciaDisponible(lista);
            if (rt.Result == DtoLib.Enumerados.EnumResult.isError || rt.Entidad== false) 
            {
                var rte = new DtoLib.ResultadoAuto()
                {
                    Auto = "",
                    Mensaje = rt.Mensaje,
                    Result = DtoLib.Enumerados.EnumResult.isError,
                };
                return rte;
            }
            return ServiceProv.Producto_Movimiento_DesCargo_Insertar(ficha);
        }

        public DtoLib.ResultadoAuto Producto_Movimiento_Ajuste_Insertar(DtoLibInventario.Movimiento.Ajuste.Insertar.Ficha ficha)
        {
            var lista = new List<DtoLibInventario.Movimiento.Verificar.ExistenciaDisponible.Ficha>();
            foreach (var rg in ficha.prdDeposito.Where(w=>w.cantidadUnd<0).ToList())
            {
                lista.Add(new DtoLibInventario.Movimiento.Verificar.ExistenciaDisponible.Ficha()
                {
                    autoProducto = rg.autoProducto,
                    autoDeposito = rg.autoDeposito,
                    cantidadUnd = Math.Abs(rg.cantidadUnd),
                });
            }
            var rt = ServiceProv.Producto_Movimiento_Verificar_ExistenciaDisponible(lista);
            if (rt.Result == DtoLib.Enumerados.EnumResult.isError || rt.Entidad == false)
            {
                var rte = new DtoLib.ResultadoAuto()
                {
                    Auto = "",
                    Mensaje = rt.Mensaje,
                    Result = DtoLib.Enumerados.EnumResult.isError,
                };
                return rte;
            }
            return ServiceProv.Producto_Movimiento_Ajuste_Insertar(ficha);
        }

    }

}