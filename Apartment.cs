using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace OOP_Project
{
    [Serializable()]
    public class Apartment:Home
    {
        private int floor;
        private bool porch;
        private bool elevator;

        public override string toString()
        {
            return base.toString()+"Apertment Information :: "+"\n"+"##################"+"\n"+"Floor: "+floor+"\nPorch: "+porch+"\nElevator: "+elevator;
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Floor", Floor);
            info.AddValue("Porch", Porch);
            info.AddValue("Elevator", Elevator);
        }

        public Apartment(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            floor = (int)info.GetValue("Floor", typeof(int));
            porch = (bool)info.GetValue("Porch", typeof(bool));
            elevator = (bool)info.GetValue("Elevator", typeof(bool));
        }

        public Apartment():base()
        {
            base.Address = "Apartment";
            floor = 0;
            porch = false;
            elevator = false;
        }
        public Apartment(string address, string description, int zipCode, double price, int residents, bool pets, bool pool, bool wifi, User user, int roomCount, int floor, bool porch, bool elevator) : base(address, description, zipCode, price, residents, pets, pool, wifi, user, roomCount)
        {
            this.Address = address;
            this.Description = description;
            this.Price = price;
            this.Residents = residents;
            this.Pets = pets;
            this.Pool = pool;
            this.Wifi = wifi;
            this.RoomCount = roomCount;
            this.Floor = floor;
            this.porch = porch;
            this.elevator = elevator;
        }
        public int Floor
        {
            get { return floor; }
            set { floor = value; }
        }
        public bool Porch
        {
            get { return porch; }
            set { porch = value; }
        }
        public bool Elevator
        {
            get { return elevator; }
            set { elevator = value; }
        }

    }
}