using ConsoleAppLegacy.Model;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLegacy.Controller
{
    public class ContatoController
    {
        public CrmServiceClient ServiceClient { get; set; }
        public Contato Contato { get; set; }

        public ContatoController(CrmServiceClient crmServiceCliente)
        {
            ServiceClient = crmServiceCliente;
            this.Contato = new Contato(ServiceClient);
        }

        public void CreateNewContact(string fullName, string dcp_cpf, string jobTitle, string telephone1, string emailAddress1)
        {
            Contato.CreateNewContact(fullName, dcp_cpf, jobTitle, telephone1, emailAddress1);
        }
    }
}
