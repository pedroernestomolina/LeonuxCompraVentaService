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

        public DtoLib.ResultadoEntidad<DtoLibPosOffLine.Permiso.Pos.Ficha> Permiso_ManejoPos()
        {
            return ServiceProv.Permiso_ManejoPos();
        }

    }

}