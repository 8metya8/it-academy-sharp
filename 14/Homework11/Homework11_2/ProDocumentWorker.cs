using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11_2
{
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Document has been edited.");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Document has been saved using old format, additional formats are available in EXPERT-version.");
        }
    }
}
