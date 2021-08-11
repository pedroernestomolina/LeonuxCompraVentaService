using ServiceSistema.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceSistema.MyService
{
    
    public partial class Service : IService
    {

        public DtoLib.ResultadoLista<DtoLibSistema.Vendedor.Lista.Ficha> Vendedor_GetLista(DtoLibSistema.Vendedor.Lista.Filtro filtro)
        {
            return ServiceProv.Vendedor_GetLista(filtro);
        }

        public DtoLib.ResultadoEntidad<DtoLibSistema.Vendedor.Entidad.Ficha> Vendedor_GetFicha_ById(string id)
        {
            return ServiceProv.Vendedor_GetFicha_ById(id);
        }

        public DtoLib.ResultadoAuto Vendedor_AgregarFicha(DtoLibSistema.Vendedor.Agregar.Ficha ficha)
        {
            return ServiceProv.Vendedor_AgregarFicha(ficha);
        }

        public DtoLib.Resultado Vendedor_EditarFicha(DtoLibSistema.Vendedor.Editar.Ficha ficha)
        {
            return ServiceProv.Vendedor_EditarFicha(ficha);
        }

    }

}