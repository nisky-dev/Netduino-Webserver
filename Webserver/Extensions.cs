using System;
using Microsoft.SPOT;
using System.Text;

namespace Webserver
{
    public static class Extensions
    {
        /// <summary>
        /// returns # of "words", aka strings seperated by space or linebreaks
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string[] Words(this String str)
        {
            return str.Split(new char[] { ' ', '\n' });
        }
        public static string Replace(this String str, String oldValue, String newValue)
        {
            StringBuilder stringbuilder = new StringBuilder(str);
            stringbuilder.Replace(oldValue, newValue);
            return stringbuilder.ToString();
        }
        public static string Replace(this String str, Char oldChar, Char newChar)
        {
            StringBuilder stringbuilder = new StringBuilder(str);
            stringbuilder.Replace(oldChar, newChar);
            return stringbuilder.ToString();
        }
    } 
}
