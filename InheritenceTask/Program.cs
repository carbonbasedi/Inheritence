using System;
using System.Net;
using System.Reflection.Metadata;

namespace InheritenceTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            Check: Console.WriteLine("Enter user access level");
            var user = Console.ReadLine();

            if (user == "basic")
            {
                var basic = new DocumentProgram();
                basic.level = "Basic";
                basic.OpenDocument();
                basic.EditDocument();
                basic.SaveDocument();

            }
            else if (user == "pro")
            {
                var pro = new ProDocumentProgram();
                pro.level = "Pro";
                pro.OpenDocument();
                pro.EditDocument();
                pro.SaveDocument();
            }
            else if (user == "expert")
            {
                var expert = new ExpertDocumentProgram();
                expert.level = "Expert";
                expert.OpenDocument();
                expert.EditDocument();
                expert.SaveDocument();
            }
            else
            {
                Console.WriteLine("Invalid Access Level");
                goto Check;                
            }

        }
    }
}