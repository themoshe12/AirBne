using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace OOP_Project
{
    [Serializable()]
    public abstract class Home:Rentable
    {
        private int roomCount;

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("RoomCount", RoomCount);
        }

        public Home(SerializationInfo info, StreamingContext context):base(info, context)
        {
            roomCount = (int)info.GetValue("RoomCount", typeof(int));
        }
        public Home() : base()
        {
            roomCount = 0;
        }

        public Home(string address, string description, int zipCode, double price, int residents, bool pets, bool pool, bool wifi,User user, int roomCount) : base(address, description, zipCode, price, residents, pets, pool, wifi, user)
        {
            this.roomCount = roomCount;
        }
        public int RoomCount
        {
            get { return roomCount; }
            set { roomCount = value; }
        }

        public override string toString()
        {
            return base.toString()+"Home Information ::"+"\n"+"###################"+"\n"+"Room Count: "+roomCount+"\n"+"###########"+"\n";
        }
    }
}