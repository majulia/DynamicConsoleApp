using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLegacy.Model
{
    public class Conta
    {
        public CrmServiceClient ServiceClient  { get; set; }
        public string LogicalName { get; set; }

        public Conta(CrmServiceClient serviceClient)
        {
            this.ServiceClient = serviceClient;
            this.LogicalName = "account";
        }

        public void CreateNewAccount(string nameAccount, string cnpjAccount, int numberOfEmployees, int accountcategorycode, double jurosAccount)
        {
            Entity conta = new Entity(LogicalName);
            conta["name"] = nameAccount;
            conta["dcp_cnpj"] = cnpjAccount;
            conta["accountcategorycode"] = accountcategorycode;
            conta["numberofemployees"] = numberOfEmployees;          
            conta["dcp_juros"] = jurosAccount;          

            Guid accountId = ServiceClient.Create(conta);
        }

        public void CreateNewContact()
        {

        }
    }

    
}
