using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public enum KategorijaEnum { Odeca, Obuca, RacunarskaOprema, MobilniTelefoni }

    public class Proizvod
    {

        private static int _counter;
        private int _id;
        private int _price;
        /*Properties*/

        public int ID
        {
            get
            {
                return _id;
            }
        }

        public string naziv { get; set; }
        public string opisProizvoda { get; set; }
        public KategorijaEnum kategorijaProizvoda { get; set; }


        public Proizvod()
        {
            _counter++;
            _id = _counter;
        }

        public int CenaProizvoda
        {
            get { return _price; }
        }

        public void SetCenaProizvoda(int price)
        {
            if (price >= 10 && price <= 10000)
            {
                _price = price;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(price));
            }
        }

        ~Proizvod()
        {
        }


        public override String ToString() {
            Type objType = this.GetType();
            PropertyInfo[] propertyInfoList = objType.GetProperties();
            StringBuilder result = new StringBuilder();
            foreach (PropertyInfo propertyInfo in propertyInfoList)
                result.AppendFormat("{0}={1} ", propertyInfo.Name, propertyInfo.GetValue(this) + "\n");

            return result.ToString();
        }

    }
}
