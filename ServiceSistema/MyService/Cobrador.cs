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

        public DtoLib.ResultadoLista<DtoLibSistema.Cobrador.Lista.Ficha> Cobrador_GetLista(DtoLibSistema.Cobrador.Lista.Filtro filtro)
        {
            return ServiceProv.Cobrador_GetLista(filtro);
        }

    }

}