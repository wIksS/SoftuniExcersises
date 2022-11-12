using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Document : BaseDocument, I3DPrintable, IPrintable, IDisposable
    {
        public int ZSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Size { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Print(int x, object y = null)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int PaperSize { get; set; }
    }
}
