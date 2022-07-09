using System;
namespace ConsoleApp17
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] BasicExpertPro = { "basic", "expert", "pro" };
            string word = "pro";

            ProDocumentProgram pro = new ProDocumentProgram();//pro sozune uygun muvafiq obyekt pro
            int i = 0;
            
            while (i <= BasicExpertPro.Length)
            {
                if (word==BasicExpertPro[i])
                {
                    pro.OpenDocument();
                    pro.EditDocument();
                    pro.SaveDocument();
                    break;
                }
                else
                {
                    Console.WriteLine(" ");
                }
                i++;
            }



        }
    }
}
