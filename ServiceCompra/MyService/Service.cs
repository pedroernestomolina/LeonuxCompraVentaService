using ServiceCompra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceCompra.MyService
{
    
    public partial class Service : IService
    {

        public static ILibCompras.IProvider ServiceProv;


        public Service(string instancia, string bd)
        {
            ServiceProv = new ProvLibCompra.Provider(instancia, bd);
        }

    }

}