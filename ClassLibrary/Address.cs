using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Address
    {   
        /// <summary>
        /// Ejemplo
        /// </summary>

        string _street;
        string _number;
        string _town;        
        string _state;
        string _country;
        string _postAd;

        public string Street { get { return _street; } set { _street = value; } }
        public string Number { get { return _number; } set { _number = value; } }
        public string Town { get { return _town; } set { _town = value; } }
        public string State { get { return _state; } set { _state = value; } }
        public string Country { get { return _country; } set { _country = value; } }
        public string PostAd { get { return _postAd; } set { _postAd = value; } }

        public Address(string street, string number, string town, string state, string country, string postAd)
        {
            _street = street;
            _number = number;
            _town = town;
            _state = state;
            _country = country;
            _postAd = postAd;
        }

        public void Clear()
        {
            _street = "";
            _number = "";
            _town = "";
            _state = "";
            _country = "";
            _postAd = "";
        }
    }
}
