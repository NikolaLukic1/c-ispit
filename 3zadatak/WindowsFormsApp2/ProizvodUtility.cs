using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class ProizvodUtility
    {

        public string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            string final;
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            final = builder.ToString().ToLower();
            return final.First().ToString().ToUpper() + final.Substring(1);
        }

        public string RandomSentence(int Size)
        {
            return RandomString(Size) + ".";
        }

        public KategorijaEnum randomKategorija()
        {
            Array values = Enum.GetValues(typeof(KategorijaEnum));
            Random random = new Random();
            KategorijaEnum randomBar = (KategorijaEnum)values.GetValue(random.Next(values.Length));
            return randomBar;
        }

        public int randomNumber() {
            Random random = new Random();
            return random.Next(50, 10000);
        }

    }
}
