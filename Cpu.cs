using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Aggregation_and_Containment
{
    internal class Cpu
    {
        bool _isAmd;
        string _name;
        int _numCores;

        public Cpu(bool isAmd, string name, int numCores)
        {
            _isAmd = isAmd;
            _name = name;
            _numCores = numCores;
        }

        public bool IsAmd
        {
            get { return _isAmd; }
            set { _isAmd = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int NumCores
        {
            get { return _numCores; }
            set { _numCores = value; }
        }

        public override string ToString()
        {
            return $"{_name} ({(_isAmd ? "AMD" : "Intel")}) - {_numCores} cores";
        }
    }
}
