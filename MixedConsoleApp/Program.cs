using GemBox.Document;
using Library;
using System.IO;

namespace MixedConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = new DocumentModel();

            var gdmgr = new GeneratedDocumentManager();
            gdmgr.Merge(word, null);
        }
    }
}
