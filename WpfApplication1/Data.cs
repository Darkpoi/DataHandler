using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandler
{
    public class Data
    {
        private readonly double[] _val;

        public int Num { get; set; }
        public double Delta { get; set; }
        public double Xi { get; set; }
        public double Ave { get; set; }
        public double Sigma { get; set; }
        public double Ua { get; set; }


        public Data(int num, double[] tmpDoubles, double delta, double xi)
        {
            _val = tmpDoubles;
            Num = num;
            Delta = delta;
            Xi = xi;
            Ave = this._Ave();
            Sigma = this._Sigma();
            Ua = this._Ua();
        }

        private double _Ave()
        {
            double tmp = 0;
            foreach (var val in _val)
            {
                tmp += val;
            }
            return tmp/Num;
        }

        private double _Sigma()
        {
            double tmp = 0;
            for (int i = 0; i < Num; i++)
            {
                tmp += (_val[i] - Ave) * (_val[i] - Ave);
            }
            tmp /= Num - 1;
            return Math.Sqrt(tmp);
            //return tmp;
        }

        private double _Ua()
        {
            return Sigma/Math.Sqrt(Num);
        }

        public double _GetFunc()
        {
            double tmp = 1.0 / (Math.Sqrt(Math.PI * 2) * Xi) * Math.Exp(-Delta * Delta / (2 * Xi * Xi));
            return tmp;
        }
    }
}
