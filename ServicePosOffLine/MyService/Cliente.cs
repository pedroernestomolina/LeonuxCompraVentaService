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

        public DtoLib.ResultadoEntidad<DtoLibPosOffLine.Cliente.Ficha> Cliente(int id)
        {
            return ServiceProv.Cliente(id);
        }

        public DtoLib.ResultadoEntidad<DtoLibPosOffLine.Cliente.Ficha> Cliente_BuscarPorCiRif(string ciRif)
        {
            return ServiceProv.Cliente_BuscarPorCiRif(ciRif);
        }

        public DtoLib.ResultadoId Cliente_Agregar(DtoLibPosOffLine.Cliente.Agregar ficha)
        {
            return ServiceProv.Cliente_Agregar(ficha);
        }

        public DtoLib.ResultadoLista<DtoLibPosOffLine.Cliente.Resumen> Cliente_Lista(string filtro)
        {
            return ServiceProv.Cliente_Lista(filtro);
        }

        public DtoLib.ResultadoLista<DtoLibPosOffLine.Cliente.ExportarData.Ficha> Cliente_ExportarData(DtoLibPosOffLine.Cliente.ExportarData.Filtro filtro)
        {
            return ServiceProv.Cliente_ExportarData(filtro);
        }

        public DtoLib.Resultado Cliente_Editar(DtoLibPosOffLine.Cliente.Editar.Ficha ficha)
        {
            return ServiceProv.Cliente_Editar(ficha);
        }

    }

}