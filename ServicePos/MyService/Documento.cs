using ServicePos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServicePos.MyService
{
    
    public partial class Service : IService
    {

        public DtoLib.ResultadoAuto Documento_Agregar_Factura(DtoLibPos.Documento.Agregar.Factura.Ficha ficha)
        {
            return ServiceProv.Documento_Agregar_Factura(ficha);
        }

    }

}