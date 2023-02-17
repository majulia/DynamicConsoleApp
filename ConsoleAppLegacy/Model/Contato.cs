using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLegacy.Model
{
    public class Contato
    {
        public CrmServiceClient ServiceClient { get; set; }
        public string LogicalName { get; set; }

        public Contato(CrmServiceClient serviceClient)
        {
            this.ServiceClient = serviceClient;
            this.LogicalName = "contact";
        }

        public void CreateNewContact(string fullName, string dcp_cpf, string jobTitle, string telephone1, string emailAddress1)
        {
            Entity conta = new Entity(LogicalName);            
            conta["fullname"] = fullName;
            conta["dcp_cpf"] = dcp_cpf;
            conta["jobtitle"] = jobTitle;
            conta["telephone1"] = telephone1;
            conta["emailaddress1"] = emailAddress1;

            Guid contactId = ServiceClient.Create(conta);
        }
    }
}
