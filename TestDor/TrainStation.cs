using System;
using System.Collections.Generic;
using System.Text;

namespace TestDor
{
    class TrainStation
    {
        string _city;
        
        public TrainStation()
        {
            _city = "Tivon";
        }
        public int Distance(int x , int y)
        {
            int z = x - y;
            return z * z;
        }
    }
}
