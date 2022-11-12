using DependencyInjectionDrawer.Renderers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DependencyInjectionDrawer
{
    internal class HtmlRenderer : IRenderer
    {
        private StringBuilder result = new StringBuilder();
        private string path = "../../../index.html";

        public void Write(object text)
        {
            if (text.ToString() == " ")
            {
                text = "&nbsp";
            }
            result.Append(text.ToString());
            var htmlText = $"<html><head></head><body>{result}</body></html>";
            using (var writer = new StreamWriter(path, false))
            {
                writer.Write(htmlText);
            }
        }

        public void WriteAt(int y, int x)
        {
            
        }

        public void WriteLine(object text)
        {
            if (text.ToString() == " ")
            {
                text = "&nbsp";
            }
            result.Append($"<div>{text.ToString()}</div>");
            var htmlText = $"<html><head></head><body>{result}</body></html>";
            using (var writer = new StreamWriter(path, false))
            {
                writer.Write(htmlText);
            }
        }
    }
}
