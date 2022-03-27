using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSalesCoffee
{
    internal class ClassSweet
    {
        private string _num;
        private string _name;
        private string _pirce;
        private string _date;
        

        public ClassSweet(string num, string name, string pirce, string date)
        {
            this._num = num;
            this._name = name;
            this._pirce = pirce;
            this._date = date;
        }

        public string getNum()
        {
            return _num;
        }
        public string getName()
        {
            return _name;
        }
        public string getPirce()
        {
            return _pirce;
        }
        public string getDate()
        {
            return _date;
        }
    }
}
