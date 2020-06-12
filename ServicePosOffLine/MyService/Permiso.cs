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
     
        public DtoLib.ResultadoEntidad<DtoLibPosOffLine.Permiso.AdmDocumento.Ficha> Permiso_AdmDocumento()
        {
            return ServiceProv.Permiso_AdmDocumento();
        }

        public DtoLib.ResultadoEntidad<DtoLibPosOffLine.Permiso.Actual.Ficha> Permiso_ActualCargar()
        {
            return ServiceProv.Permiso_ActualCargar();
        }

        public DtoLib.Resultado Permiso_Actualizar(DtoLibPosOffLine.Permiso.Actualizar.Ficha ficha)
        {
            return ServiceProv.Permiso_Actualizar(ficha);
        }

    }

}