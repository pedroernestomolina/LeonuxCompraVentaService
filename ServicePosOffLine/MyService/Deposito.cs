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

        public DtoLib.ResultadoLista<DtoLibPosOffLine.Deposito.Ficha> Deposito_Lista()
        {
            return ServiceProv.Deposito_Lista() ;
        }

    }

}