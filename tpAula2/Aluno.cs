using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpAula2
{
    class Aluno
    {
        public string P1 { get; set; }
        public string P2 { get; set; }
        public string P3 { get; set; }
        public string P4 { get; set; }


        public string getMedia()
        {
            return ((float.Parse(P1) + float.Parse(P2) + float.Parse(P3) + float.Parse(P4))/ 4).ToString();
        }

    }
}

