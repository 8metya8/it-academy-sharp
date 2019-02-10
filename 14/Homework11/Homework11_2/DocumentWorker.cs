using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11_2
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Document open.");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("PRO-version provides EDIT-functionality.");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("PRO-version provides SAVE-functionality.");
        }
    }
}
