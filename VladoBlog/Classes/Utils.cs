using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VladoBlog.Classes
{
    public class Utils
    {
        public static string CutText(string text, int maxLenght = 150)
        {
            if (text==null || text.Length<=maxLenght)
            {
                return text;
            }
            else
            {
                var shortText = text.Substring(0, maxLenght)+".....";
                return shortText;
            }
        }
    }
}