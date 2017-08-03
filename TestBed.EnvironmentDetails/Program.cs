using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBed.EnvironmentDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Domain     :  " + Environment.UserDomainName);
            Console.WriteLine("User Name  :  " + Environment.UserName);
        }
    }
}
