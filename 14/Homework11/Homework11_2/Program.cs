using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11_2
{
    class Program
    {
        private static string Key { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Do you have PRO or EXP key? Yes/No");

            if(Console.ReadLine().ToString().ToUpper().Equals("YES"))
            {
                Console.WriteLine("Enter your key (PRO or EXP)");

                Key = Console.ReadLine().ToString().ToUpper();

                switch(Key)
                {
                    case "PROKEY":
                        {
                            WorkWithProDocument();
                            break;
                        }
                    case "EXPKEY":
                        {
                            WorkWithExpDocument();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid key.");
                            WorkWithBaseDocument();
                            break;
                        }
                }
            }
            else
            {
                WorkWithBaseDocument();
            }

            Console.ReadKey();
        }

        public static void WorkWithBaseDocument()
        {
            Console.WriteLine("You use Base verion.");

            DocumentWorker document = new DocumentWorker();
            document.OpenDocument();
            document.EditDocument();
            document.SaveDocument();
        }

        public static void WorkWithProDocument()
        {
            Console.WriteLine("You use Pro verion.");

            DocumentWorker document = new ProDocumentWorker();
            document.OpenDocument();
            document.EditDocument();
            document.SaveDocument();
        }

        public static void WorkWithExpDocument()
        {
            Console.WriteLine("You use Exp verion.");

            DocumentWorker document = new ExpertDocumentWorker();
            document.OpenDocument();
            document.EditDocument();
            document.SaveDocument();
        }
    }
}
