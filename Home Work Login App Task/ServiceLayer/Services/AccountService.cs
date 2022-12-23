using ServiceLayer.Helpers.Constans;
using ServiceLayer.Helpers.Enums;
using ServiceLayer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ServiceLayer.Services
{
    public class AccountService:IAccountService
    {
       

        public void Login(string email, string password)
        {

            Console.WriteLine("Enter a number");          
           Number1: string IdStr = Console.ReadLine();
            int roleId;
            bool IsParseId = int.TryParse(IdStr, out roleId);
            if (!IsParseId)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter a valid number,please");
                Console.ResetColor();   
                goto Number1;
            }

            Console.WriteLine("Enter Email");
            Mail: string mail = Console.ReadLine();
            if (!mail.Contains("test@code.edu.az"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a valid email address");
                Console.ResetColor();
                goto Mail ;
            }

            if (email != "test@code.edu.az")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Errors.EmailNotFound);
                Console.ResetColor();
                return;
            }

            Console.WriteLine("Enter Password");
            Pass: string pass = Console.ReadLine();
            if (!pass.Contains("test12345"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter a valid password");
                Console.ResetColor();
                goto Pass;
            }

            else if (password != "test12345")
            {
                Console.WriteLine(Errors.PassNotFound);
                return;
                
            }

            if (roleId == (int)Roles.SuperAdmin)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Welcome SuperAdmin");
                Console.ResetColor();
                
            }
           
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Welcome User");
                Console.ResetColor();
            }
           

        }

    }
}

