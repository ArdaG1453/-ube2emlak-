using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace şube2emlakçı
{
    internal class Bilgisayar
    {


        public string marka;
        public string model;
        public int ram;
        public int ssd;

        public string PcBilgileri()
        {
            return $"marka: {this.marka}\n model: {this.model}\n ram: {this.ram}\n ssd: {this.ssd}";
        }

    }

}

