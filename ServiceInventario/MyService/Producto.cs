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

        public DtoLib.ResultadoLista<DtoLibInventario.Producto.Resumen> Producto_GetLista(DtoLibInventario.Producto.Filtro filtro)
        {
            return ServiceProv.Producto_GetLista(filtro);
        }

        public DtoLib.ResultadoEntidad<DtoLibInventario.Producto.VerData.Ficha> Producto_GetFicha(string autoPrd)
        {
            return ServiceProv.Producto_GetFicha(autoPrd);
        }

        public DtoLib.ResultadoLista<DtoLibInventario.Producto.Estatus.Resumen> Producto_Estatus_Lista()
        {
            return ServiceProv.Producto_Estatus_Lista();
        }

        public DtoLib.ResultadoLista<DtoLibInventario.Producto.Origen.Resumen> Producto_Origen_Lista()
        {
            return ServiceProv.Producto_Origen_Lista();
        }

        public DtoLib.ResultadoLista<DtoLibInventario.Producto.Categoria.Resumen> Producto_Categoria_Lista()
        {
            return ServiceProv.Producto_Categoria_Lista();
        }

        public DtoLib.ResultadoLista<DtoLibInventario.Producto.AdmDivisa.Resumen> Producto_AdmDivisa_Lista()
        {
            return ServiceProv.Producto_AdmDivisa_Lista();
        }

        public DtoLib.ResultadoLista<DtoLibInventario.Producto.Pesado.Resumen> Producto_Pesado_Lista()
        {
            return ServiceProv.Producto_Pesado_Lista();
        }

        public DtoLib.ResultadoLista<DtoLibInventario.Producto.Oferta.Resumen> Producto_Oferta_Lista()
        {
            return ServiceProv.Producto_Oferta_Lista();
        }

        public DtoLib.ResultadoEntidad<DtoLibInventario.Producto.VerData.Existencia> Producto_GetExistencia(string autoPrd)
        {
            return ServiceProv.Producto_GetExistencia(autoPrd);
        }

        public DtoLib.ResultadoEntidad<DtoLibInventario.Producto.VerData.Precio> Producto_GetPrecio(string autoPrd)
        {
            return ServiceProv.Producto_GetPrecio(autoPrd);
        }

        public DtoLib.ResultadoEntidad<DtoLibInventario.Producto.VerData.Costo> Producto_GetCosto(string autoPrd)
        {
            return ServiceProv.Producto_GetCosto(autoPrd);
        }

        public DtoLib.ResultadoEntidad<DtoLibInventario.Producto.Depositos.Ficha> Producto_GetDepositos(string autoPrd)
        {
            return ServiceProv.Producto_GetDepositos(autoPrd);
        }

        public DtoLib.Resultado Producto_AsignarDepositos(DtoLibInventario.Producto.Depositos.Asignar.Ficha ficha)
        {
            var rs = new DtoLib.Resultado();

            var rt = ServiceProv.Producto_Verificar_EsBienServicio(ficha.autoProducto);
            if (rt.Result == DtoLib.Enumerados.EnumResult.isError)
            {
                rs.Mensaje = rt.Mensaje;
                rs.Result = DtoLib.Enumerados.EnumResult.isError;
                return rs;
            }

            if (rt.Entidad == true) 
            {
                rs.Mensaje = "PROBLEMA AL ASIGNAR DEPOSITOS" + Environment.NewLine + "CATEGORIA DEL PRODUCTO NO PERMITE TENER DEPOSITOS";
                rs.Result = DtoLib.Enumerados.EnumResult.isError;
                return rs;
            }

            return ServiceProv.Producto_AsignarDepositos(ficha);
        }

        public DtoLib.ResultadoLista<DtoLibInventario.Producto.Clasificacion.Resumen> Producto_Clasificacion_Lista()
        {
            return ServiceProv.Producto_Clasificacion_Lista();
        }

        public DtoLib.ResultadoEntidad<DtoLibInventario.Producto.Editar.Obtener.Ficha> Producto_Editar_GetFicha(string autoPrd)
        {
            return ServiceProv.Producto_Editar_GetFicha(autoPrd);
        }

        public DtoLib.Resultado Producto_Editar_Actualizar(DtoLibInventario.Producto.Editar.Actualizar.Ficha ficha)
        {
            var rs = new DtoLib.Resultado();

            var r1 = ServiceProv.Producto_Verificar_CodigoProductoYaRegistrado(ficha.codigo, ficha.auto);
            if (r1.Result == DtoLib.Enumerados.EnumResult.isError)
            {
                rs.Mensaje = r1.Mensaje;
                rs.Result = DtoLib.Enumerados.EnumResult.isError;
                return rs;
            }

            if (r1.Entidad == true)
            {
                rs.Mensaje = "CODIGO DEL PRODUCTO YA REGISTRADO, VERIFIQUE POR FAVOR";
                rs.Result = DtoLib.Enumerados.EnumResult.isError;
                return rs;
            }

            if (ficha.categoria.Trim().ToUpper() == "BIEN DE SERVICIO") 
            {
                var rt= ServiceProv.Producto_Verificar_HayDepositosAsignado(ficha.auto);
                if (rt.Result == DtoLib.Enumerados.EnumResult.isError) 
                {
                    rs.Mensaje = rt.Mensaje;
                    rs.Result = DtoLib.Enumerados.EnumResult.isError;
                    return rs;
                }

                if (rt.Entidad == true) 
                {
                    rs.Mensaje = "PROBLEMA AL ACTUALIZAR FICHA"+Environment.NewLine+"CATEGORIA SELECCIONADA NO PUEDE TENER DEPOSITOS";
                    rs.Result = DtoLib.Enumerados.EnumResult.isError;
                    return rs;
                }
            }

            return ServiceProv.Producto_Editar_Actualizar(ficha);
        }

        public DtoLib.ResultadoAuto Producto_Nuevo_Agregar(DtoLibInventario.Producto.Agregar.Ficha ficha)
        {
            var rt = new DtoLib.ResultadoAuto();

            var r1 = ServiceProv.Producto_Verificar_CodigoProductoYaRegistrado(ficha.codigo, "");
            if (r1.Result == DtoLib.Enumerados.EnumResult.isError)
            {
                rt.Mensaje = r1.Mensaje;
                rt.Result = DtoLib.Enumerados.EnumResult.isError;
                return rt;
            }

            if (r1.Entidad == true) 
            {
                rt.Mensaje = "CODIGO DEL PRODUCTO YA REGISTRADO, VERIFIQUE POR FAVOR";
                rt.Result = DtoLib.Enumerados.EnumResult.isError;
                return rt;
            }

            return ServiceProv.Producto_Nuevo_Agregar (ficha);
        }

    }

}