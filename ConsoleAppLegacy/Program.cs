using ConsoleAppLegacy.Controller;
using Microsoft.Rest;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Workflow.Activities;

namespace ConsoleAppLegacy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateAccount();
            //CreateContact();
        }

        private static void CreateAccount()
        {
            CrmServiceClient serviceClient = Singleton.GetService();

            ContaController contaController = new ContaController(serviceClient);
            Console.Clear();

            Console.WriteLine("Informe o nome da conta:");
            var nameAccount = Console.ReadLine();

            Console.WriteLine("Informe o CNPJ:");
            var cnpjAccount = Console.ReadLine();

            Console.WriteLine("Informe a categoria da conta:");
            Console.WriteLine("(1 - Cliente Preferencial | 2 - Cliente Padrão)");
            var accountCategoryCode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o número de funcionários:");
            var numberOfEmployees = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o percentual de juros:");
            var jurosAccount = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("Gostaria de criar sua conta? (S/N)");
            var res = Console.ReadLine();

            if (res.ToUpper() == "S")
            {
                Console.WriteLine("Aguarde enquanto a nova Conta é criada");

                contaController.CreateNewAccount(nameAccount, cnpjAccount, numberOfEmployees, accountCategoryCode, jurosAccount);

                Console.WriteLine("Conta criada com sucesso!");

                ChoiceContact();
            }
            else
            {
                Console.WriteLine("Aperte enter para finalizar");
            }

            Console.ReadKey();
        }

        private static void CreateContact()
        {

            CrmServiceClient serviceClient = Singleton.GetService();

            ContatoController contatoController = new ContatoController(serviceClient);
            Console.Clear();

            Console.WriteLine("Informe o nome completo:");
            var fullName = Console.ReadLine();

            Console.WriteLine("Informe o CPF:");
            var dcp_cpf = Console.ReadLine();

            Console.WriteLine("Cargo:");
            var jobTitle = Console.ReadLine();

            Console.WriteLine("Telefone Comercial:");
            var telephone1 = Console.ReadLine();

            Console.WriteLine("Email:");
            var emailAddress1 = Console.ReadLine();

            contatoController.CreateNewContact(fullName, dcp_cpf, jobTitle, telephone1, emailAddress1);

        }

        private static void ChoiceContact()
        {
            Console.WriteLine("Gostaria de criar um contato para a sua conta? (S/N)");
            var resContact = Console.ReadLine();

            if (resContact.ToUpper() == "S")
            {
                CreateContact();
            }
            else
            {
                Console.WriteLine("Aperte enter para finalizar");
            }
        }
    }
}
