using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Aggregation_and_Containment
{
    internal class Extra
    {
        string _psu;
        string _gpu;
        string _case;

        public Extra(string psu, string gpu, string caseType)
        {
            _psu = psu;
            _gpu = gpu;
            _case = caseType;
        }

        public string Psu
        {
            get { return _psu; }
            set { _psu = value; }
        }

        public string Gpu
        {
            get { return _gpu; }
            set { _gpu = value; }
        }

        public string Case
        {
            get { return _case; }
            set { _case = value; }
        }

        public override string ToString()
        {
            return $"PSU: {_psu} - GPU: {_gpu} - Case: {_case}";
        }

    }
}
