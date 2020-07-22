using ServiceCajaBanco.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceCajaBanco.MyService
{

    public partial class Service : IService
    {

        public DtoLib.ResultadoLista<DtoLibCajaBanco.Reporte.Movimiento.ArqueoCajaPos.Ficha> CajaBanco_ArqueoCajaPos(DtoLibCajaBanco.Reporte.Movimiento.Filtro filtro)
        {
            return ServiceProv.CajaBanco_ArqueoCajaPos(filtro);
        }

    }

}