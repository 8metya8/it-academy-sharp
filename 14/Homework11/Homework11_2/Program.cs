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
        private static DocumentWorker document;

        static void Main(string[] args)
        {
            Console.WriteLine("Do you have PRO or EXP key? Yes/No");

            if (Console.ReadLine().ToString().ToUpper().Equals("YES"))
            {
                Console.WriteLine("Enter your key (PRO or EXP)");

                Key = Console.ReadLine().ToString().ToUpper();

                switch (Key)
                {
                    case "PROKEY":
                        {
                            document = new ProDocumentWorker();
                            WorkWithDocument(document);
                            break;
                        }
                    case "EXPKEY":
                        {
                            document = new ExpertDocumentWorker();
                            WorkWithDocument(document);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid key. You use base version.");

                            document = new DocumentWorker();
                            WorkWithDocument(document);
                            break;
                        }
                }
            }
            else
            {
                document = new DocumentWorker();
                WorkWithDocument(document);
            }

            Console.ReadKey();
        }

        public static void WorkWithDocument(DocumentWorker document)
        {
            document.OpenDocument();
            document.EditDocument();
            document.SaveDocument();
        }
    }
}
