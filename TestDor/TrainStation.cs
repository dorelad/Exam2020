using System;

namespace TestDor
{
    class TrainStation
    {
        private double _lengthOfPlatform;
        private String _city;
        private bool _WorksOnWeekend;

        public TrainStation(double length, String city, bool worksOnWeekend)
        {
            _city = city;
            _WorksOnWeekend = worksOnWeekend;
            _lengthOfPlatform = length;
        }
    }
}
