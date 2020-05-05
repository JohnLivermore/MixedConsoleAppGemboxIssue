using GemBox.Document;
using GemBox.Document.MailMerging;
using System;
using System.IO;
using System.Linq;


namespace Library
{
    public class GeneratedDocumentManager
    {
        public void Merge(DocumentModel word, object model)
        {
            word.MailMerge.Execute(model);
        }
    }
}
