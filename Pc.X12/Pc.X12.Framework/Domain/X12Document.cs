using System;
using System.IO;

namespace Pc.X12.Framework.Domain
{
    public class X12Document
    {
        private readonly string _documentText;

        public X12Document(string documentText)
        {
            if (string.IsNullOrEmpty(documentText))
                throw new ArgumentNullException(nameof(documentText));

            _documentText = documentText;
        }

        public static X12Document FromFilePath(string filePath)
        {
            var text = File.ReadAllText(filePath);
            return new X12Document(text);
        }
    }
}