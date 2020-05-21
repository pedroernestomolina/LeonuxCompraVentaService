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

        public DtoLib.ResultadoEntidad<DtoLibPosOffLine.Item.Ficha> Item(int id)
        {
            return ServiceProv.Item(id);
        }

        public DtoLib.ResultadoId Item_Agregar(DtoLibPosOffLine.Item.Agregar ficha)
        {
            return ServiceProv.Item_Agregar(ficha);
        }

        public DtoLib.ResultadoLista<DtoLibPosOffLine.Item.Ficha> Item_Cargar()
        {
            return ServiceProv.Item_Cargar();
        }

        public DtoLib.Resultado Item_Limpiar()
        {
            return ServiceProv.Item_Limpiar();
        }

        public DtoLib.Resultado Item_Actualizar(DtoLibPosOffLine.Item.Actualizar ficha)
        {
            return ServiceProv.Item_Actualizar(ficha);
        }

        public DtoLib.Resultado Item_Eliminar(int id)
        {
            return ServiceProv.Item_Eliminar(id);
        }

    }

}