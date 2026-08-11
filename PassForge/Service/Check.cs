using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using PassForge;

namespace PassForge.Service
{
    public class Check
    {
        public bool hasLoWer;
        public bool hasUpper;
        public bool hasNumber;
        public bool hasSymbol;
        public bool length;
        public bool length2;
        public bool isCommon;
        public bool isEmpty;
        public bool hasSpace;

        private HashSet<string> commonPasswords;
        public Check() {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Data", "common-passwords.txt");

            if (File.Exists(filePath)) {
                commonPasswords = new HashSet<string>
                    (
                    File.ReadLines(filePath)
                    .Where(x => !string.IsNullOrWhiteSpace(x))
                    .Select(x => x.Trim()),
                    StringComparer.OrdinalIgnoreCase
                    );
            }
            else
            {
                commonPasswords = new HashSet<string>(
                    StringComparer.OrdinalIgnoreCase
                );
            }
        }
        

        public void checkPass(string pass)
        {

            hasLoWer = pass.Any(Char.IsLower);
            hasUpper = pass.Any(Char.IsUpper);
            hasNumber = pass.Any(Char.IsNumber);
            hasSymbol = pass.Any(c => !char.IsLetterOrDigit(c));
            length = 12 <= pass.Length;
            length2 = 8 <= pass.Length;
            isEmpty= pass.Length == 0;
            hasSpace = pass.Any(Char.IsWhiteSpace);
            isCommon = commonPasswords.Contains(pass);
            

            
        }
    }
}
