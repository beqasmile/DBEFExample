using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCommon
{
    public class Driver
    {
        private int id;
        private string driverName;
        private int age;
        private string address;
        private int driversLessonType;

        public int Id { get => id; set => id = value; }
        public string DriverName { get => driverName; set => driverName = value; }
        public int Age { get => age; set => age = value; }
        public string Address { get => address; set => address = value; }
        public int DriversLessonType { get => driversLessonType; set => driversLessonType = value; }


        public Driver(int _Id, string _DriverName, int _Age, string _Address, int _DriversLessonType)
        {
            this.id = _Id;
            this.driverName = _DriverName;
            this.age = _Age;
            this.address = _Address;
            this.driversLessonType = _DriversLessonType;
        }

    }
}
