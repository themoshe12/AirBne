using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace OOP_Project
{
    [Serializable]
    public class House:Home
    {
        private int floors;
        private bool yard;

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Floors", Floors);
            info.AddValue("Yard", Yard);
        }

        public House(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            floors = (int)info.GetValue("Floors", typeof(int));
            yard = (bool)info.GetValue("Yard", typeof(bool));
        }

        public override string toString()
        {
            return base.toString() + "House Information ::"+"\n"+"##################"+"\n"+"Floors: " + floors + "\nYard: " + yard;
        }

        public House() : base()
        {
            base.Address = "House";
            floors = 0;
            yard = false;
        }

        public House(string address, string description, int zipCode, double price, int residents, bool pets, bool pool, bool wifi,User user, int floors, bool yard, int roomCount):base(address, description, zipCode, price, residents, pets, pool, wifi,user, roomCount)
        {
            this.floors = floors;
            this.yard = yard;
        }

        public int Floors
        {
            get { return floors; }
            set { floors = value; }
        }

        public bool Yard
        {
            get { return yard; }
            set { yard = value; }
        }
    }
}