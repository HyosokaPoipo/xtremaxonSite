using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTremax
{
    /// <summary>
    /// 
    /// In this section you need to implement GetSummary method in class ContentExtension.
    /// This method will return a summary of HTML content block.
    /// Summary is the text of the first paragraph.
    /// Summary may only contains 150 character, so if the first paragraph contains more than 150 characters, you need to truncate the text.
    /// For Example:
    ///    You can wing it and risk ... (Correct)
    ///    You can wing it and ri...    (Wrong)
    ///    
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            String contentValue = File.ReadAllText("../../ContentValue.txt");
            Console.WriteLine(contentValue.GetSummary());
            Console.ReadLine();
        }
    }

    static class ContentExtension
    {
        /// <summary>
        /// Return summary of HTML content block.
        /// Summary is the text of the first paragraph
        /// </summary>
        /// <param name="contentText"></param>
        /// <returns></returns>
        public static string GetSummary(this String contentText)
        {
            //bool rem = contentText.Contains("<");
            //Console.WriteLine(contentText.IndexOf(">"));
            //String temp0 = contentText;
            //while (rem)
            //{
            //    if (temp0.Contains(">")) temp0 = temp0.Substring(temp0.IndexOf(">"),temp0.Length-(1+temp0.IndexOf(">"))); 
            //    rem = temp0.Contains("<");
            //}

            String test = contentText.Replace("<", ""); //contentText.Replace("<section><p>&nbsp;</p><p>", "");
            test = test.Replace(">","");
            test = test.Replace("section", "");
            test = test.Replace("p&nbsp;/p", "");
            test = test.Replace("\r\n\r\np\r\n\r\n", "");
            //Console.WriteLine("Length String : "+contentText.Length);
            if (test.Length > 150)
            {
                int index = test.IndexOf(" ", 150);
                //Console.WriteLine("Index : "+index);
                String temp = test.Substring(0, index);
                Console.WriteLine("temp : " + temp);
                return temp +" ...";
            }
            return test;
        }
    }
}
