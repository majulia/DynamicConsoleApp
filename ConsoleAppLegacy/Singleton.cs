using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLegacy
{
    public class Singleton
    {
        public static CrmServiceClient GetService()
        {
            string url = "dynacoop23.crm2.dynamics.com";
            string clientId = "1da13ba4-4406-4329-b330-752728a0b941";
            string clientSecret = "vbM8Q~z_GM3QMZ4Rl0ae.Mp7QDvuNaeWXeyfAa9h";
            
            CrmServiceClient serviceClient = new CrmServiceClient($"AuthType=ClientSecret;Url=https://{url};AppId={clientId};ClientSecret={clientSecret};");

            if (!serviceClient.CurrentAccessToken.Equals(null))
                Console.WriteLine("Conexão Realizada com sucesso");
                
            else
                Console.WriteLine("Conexão falhou");

            return serviceClient;
        }
    }
}
