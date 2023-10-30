using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    public class Customer
    {
        int _Custid;
        bool _Status;
        string _Cname, _State;
        double _Balence;
        Cities _City;

        public Customer(int Custid, bool Status, string Cname, double Balence, Cities City, string State)
        {
            _Custid = Custid;
            _Status = Status;
            _Cname = Cname;
            _Balence = Balence;
            _City = City;
            _State = State;
            //this.Country = Country;
        }
       public int Custid
        {
            get { return _Custid; }
            //set { _Custid = value; }
        }
        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public string Cname
        {
            get { return _Cname; }
            set {
                if(_Status == true)
                _Cname = value; }
        }
        public double Balence
        {
            get { return _Balence; }
            set
            {
                if (Status == true)
                {
                    if (value >= 500)
                        _Balence = value;
                }
            }
        }
        public Cities City
        {
            get { return _City; }
            set
            {
                if (_Status == true)
                    _City = value;
            }
        }
        public string State
        {
            get { return _State; }
           protected set
            {
                if (_Status == true)
                    _State = value;
            }
        }
        //Auto-Implemented or Automatic propety(3.0 version in C#)
        //Auto Property initializer (6.0 version in C#)
        public string Country {get;} = "India";
    }
}
