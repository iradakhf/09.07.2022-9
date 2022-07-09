using System;
namespace ConsoleApp17
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] BasicExpertPro = { "basic", "expert", "pro" };
            string word = "pro";
            int i = 0;

            ProDocumentProgram pro = new ProDocumentProgram();//pro sozune uygun muvafiq obyekt pro
            ExpertDocumentProgram expert = new ExpertDocumentProgram();
            DocumentProgram basic = new DocumentProgram();
            
            
            while (i <= BasicExpertPro.Length)
            {
                if (word=="pro")
                {
                    pro.OpenDocument();
                    pro.EditDocument();
                    pro.SaveDocument();
                    break;
                }
                else if (word=="basic")
                {
                    basic.OpenDocument();
                    basic.EditDocument();
                    basic.SaveDocument();
                    break;
                }
                else
                {
                    basic.OpenDocument();
                    basic.EditDocument();
                    basic.SaveDocument();
                    break;
                }
                i++;
            }



        }
    }
}
