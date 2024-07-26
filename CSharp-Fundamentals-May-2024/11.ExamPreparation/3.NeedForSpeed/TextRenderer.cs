//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _3.NeedForSpeed
//{
//    public class TextRenderer : IRenderer
//    {
//        string path = "../../../output.txt";

//        public TextRenderer()
//        {
//            File.Delete(path);
//        }

//        public void Write(string message)
//        {
//            using (StreamWriter writer = new StreamWriter(path, true))
//            {
//                writer.Write(message);
//            }
//        }

//        public void WriteLine(string message)
//        {
//            using (StreamWriter writer = new StreamWriter(path, true))
//            {
//                writer.WriteLine(message);
//            }
//        }
//    }
//}
