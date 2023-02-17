using ConsoleAppLegacy.Model;
using Microsoft.Xrm.Tooling.Connector;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLegacy.Controller
{
    public class ContaController
    {

        public CrmServiceClient ServiceClient { get; set; }
        public Conta Conta { get; set; }

        public ContaController(CrmServiceClient crmServiceCliente)
        {
            ServiceClient = crmServiceCliente;
            this.Conta = new Conta(ServiceClient);
        }

        public void CreateNewAccount(string nameAccount, string cnpjAccount, int numberOfEmployees, int accountcategorycode, double jurosAccount)
        {
           Conta.CreateNewAccount(nameAccount, cnpjAccount, numberOfEmployees, accountcategorycode, jurosAccount);
        }
    }
}
