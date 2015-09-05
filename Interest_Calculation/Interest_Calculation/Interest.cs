using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterestCalculator
{
    class Interest
    {
        double _principal;
        double _time;
        double _rate;

        //controller
        public Interest(double principal, double time, double rate)
        {
            this._principal = principal;
            this._time = time;
            this._rate = rate;
        }

        public double Principal
        {
            get { return this._principal;}
            set { this._principal = value; }
        }

        public double Time
        {
            get { return this._time; }
            set { this._time = value; }
        }

        public double Rate
        {
            get { return this._rate; }
            set { this._rate = value; }
        }
        //method
        public double getInterest()
        {
            return (this._principal * this._time * this._rate) / 100;
        }
    }
}
