using ServiceVenta.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceVenta.MyService
{
    
    public partial class Service: IService
    {

        public static ILibVentas.IProvider ServiceProv; 


        public Service() 
        {
            ServiceProv = new ProvLibVenta.Provider();
        }

        public DtoLib.ResultadoEntidad<DateTime> FechaServidor()
        {
            return ServiceProv.FechaServidor();
        }

    }

}