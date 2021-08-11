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

    }

}