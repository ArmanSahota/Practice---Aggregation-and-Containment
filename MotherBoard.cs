using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Aggregation_and_Containment
{
    internal class MotherBoard
    {
        int _ramGb;
        string _cpuSocket;
        int _numFans;

        public MotherBoard(int ramGb, bool isAmd, int numFans) {
        _ramGb = ramGb;
        _cpuSocket = isAmd ? "AMD" : "Intel";
        _numFans = numFans;
    }

    public int RamGb {
        get { return _ramGb; }
        set { _ramGb = value; }
    }

    public string CpuSocket {
        get { return _cpuSocket; }
    }

    public int NumFans {
        get { return _numFans; }
        set { _numFans = value; }
    }

    public override string ToString() {
        return $"{_ramGb} GB RAM - {_cpuSocket} socket - {_numFans} fans";
    }
    }
}
