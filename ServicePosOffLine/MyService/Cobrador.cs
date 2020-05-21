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

        public DtoLib.ResultadoLista<DtoLibPosOffLine.Cobrador.Ficha> Cobrador_Lista()
        {
            return ServiceProv.Cobrador_Lista();
        }

    }

}