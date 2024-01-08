using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.Serialization;
using System.Text;

namespace OOP_Project
{
    [Serializable]
    public class HotelRoom : Rentable
    {
        private string hotelName;
        private bool gym;
        private int roomNumber;
        private string pension;
        private byte hotelGrade;

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("HotelName", HotelName);
            info.AddValue("Gym", Gym);
            info.AddValue("RoomNumber", RoomNumber);
            info.AddValue("Pension", Pension);
            info.AddValue("HotelGrade", HotelGrade);
        }

        public HotelRoom(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            hotelName = (string)info.GetValue("HotelName", typeof(string));
            gym = (bool)info.GetValue("Gym", typeof(bool));
            roomNumber = (int)info.GetValue("RoomNumber", typeof(int));
            pension = (string)info.GetValue("Pension", typeof(string));
            hotelGrade = (byte)info.GetValue("HotelGrade", typeof(byte));
        }

        public override string toString()
        {
            return base.toString()+"Hotel Information ::"+"\n"+"####################"+"\n"+"Hotel Name: "+hotelName+"\nGym: " +gym + "\nRoom Number: " + roomNumber + "\nPension: " + pension + "\nHotel Grade: " + hotelGrade;
        }
        public HotelRoom() : base()
        {
            base.Address = "Hotel Room";
            hotelName = "";
            gym = false;
            roomNumber = 0;
            pension = "";
            hotelGrade = 0;
        }
        public HotelRoom(string hotelName, string address, string description, int zipCode, double price, int residents, bool pets, bool pool, bool wifi,User user,bool gym, int roomNumber,string pension,byte hotelGrade) : base(address, description, zipCode, price, residents, pets, pool, wifi,user)
        {
            this.hotelName = hotelName;
            this.gym = gym;
            this.roomNumber = roomNumber;
            this.pension = pension;
            this.hotelGrade = hotelGrade;
        }

        public string HotelName
        {
            get { return hotelName; }
            set { hotelName = value; }
        }
        public bool Gym
        {
            get { return gym; }
            set { gym = value; }
        }
        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }
        public string Pension
        {
            get { return pension; }
            set { pension = value; }
        }
        public byte HotelGrade
        {
            get { return hotelGrade; }
            set { hotelGrade = value; }
        }
    }
}