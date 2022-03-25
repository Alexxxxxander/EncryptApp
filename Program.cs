using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EncryptApp
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormStart());            
        }
  
        public static ushort secretKey = 0x0088;    // Секретный ключ (длина - 16 bit).
        /// <summary>
        /// Шифратор Дешифратор
        /// </summary>
        /// <param name="str"> строка </param>
        /// <param name="secretKey"> ключ</param>
        /// <returns></returns>
        public static string EncodeDecrypt(string str, ushort secretKey)
        {
            var ch = str.ToArray();     
            string newStr = "";                     //переменная которая будет содержать зашифрованную строку
            foreach (var c in ch)                   
                newStr += TopSecret(c, secretKey); 
            return newStr;
        }
        /// <summary>
        /// XOR операция
        /// </summary>
        /// <param name="character"> символ </param>
        /// <param name="secretKey"> ключ </param>
        /// <returns></returns>
        public static char TopSecret(char character, ushort secretKey)
        {
            character = (char)(character ^ secretKey); 
            return character;
        }
    }
}
