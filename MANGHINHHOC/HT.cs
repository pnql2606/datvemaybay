using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANGHINHHOC
{
    class HT:hinhhoc
        private float Bk;
        private const float PI = 3,14F;
        public float bk
    { 
            get { return bk;}
            set { bk = value;}
    } 
    {public hinhtron(float stBK)
    { 
        bk = stBK;
    }
        public override float DT()
{
 	return base.DT + bk * bk * 3.14F
}
    }
}