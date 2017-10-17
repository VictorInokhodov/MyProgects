using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MyString
    {
        private char[] text { get; set; }

        public MyString(string text)
        {
            this.text = text.ToArray();
        }

        public override string ToString()
        {
            return new string(text);
        }

        public static MyString operator +(MyString text1, MyString text2)
        {
            return new MyString(text1.ToString() + text2.ToString());
        }

        public static bool operator==(MyString text1, MyString text2)
        {
            return Equals(text1.ToString(), text2.ToString());
        }

        public static bool operator !=(MyString text1, MyString text2)
        {
            return !(text1.ToString() == text2.ToString());
        }

        public static MyString operator-(MyString text1, MyString text2)
        {
            return new MyString(text1.ToString().Replace(text2.ToString(), string.Empty));
        }

        private static bool Equals(MyString text1, MyString text2)
        {
            for (int i = 0; i < text1.ToString().Length; i++)
            {
                if(i == text2.ToString().Length)
                {
                    return false;
                }
                else if (text1.ToString()[i] != text2.ToString()[i])
                {
                    return false;
                }

                return true;
            }

            return false;
        }
    }
}
