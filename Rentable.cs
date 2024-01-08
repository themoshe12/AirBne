using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Xml.Serialization;

namespace OOP_Project
{
    [Serializable()]
    public abstract class Rentable : ISerializable
    {
        private static int idCounter = 0;
        private int id;
        private string address;
        private string description;
        private int zipCode;
        private double price;
        private int residents;
        private bool pets;
        private bool occupied;
        private bool pool;
        private bool wifi;
        private User user;

        public virtual string toString()
        {
            return "Rentable Information ::"+"\n"+"########################"+"\n"+"ID: " + id +"\nOccupied: "+ occupied+"\nOwner: "+user.Name + "\nAddress: " + address + "\n" + "Zip Code: " + zipCode + "\n" + "Price: " + price + "\n" + "Residents:" + residents + "\n" + "Pets: " + pets + "\n" + "Pool: " + pool + "\n" + "Wifi: " + wifi + "\n" + "Description: " + description + "\n"+"###########"+"\n";
        }
        public string getText()
        {
            if (this.occupied )
            {
                return Address + "\n" + price + "\n" + "Not Available";
            }
            return Address + "\n" + Price;
        }

        public Rentable(SerializationInfo info, StreamingContext context)
        {
            idCounter = (int)info.GetValue("IdCounter", typeof(int));
            id = (int)info.GetValue("Id",typeof(int));
            address=(string)info.GetValue("Address",typeof(string));
            description=(string)info.GetValue("Description",typeof(string));
            zipCode = (int)info.GetValue("ZipCode",typeof(int));
            price=(double)info.GetValue("Price",typeof(double));
            residents=(int)info.GetValue("Residents",typeof(int));
            pets=(bool)info.GetValue("Pets",typeof(bool));
            occupied = (bool)info.GetValue("Occupied", typeof(bool));
            wifi = (bool)info.GetValue("Wifi", typeof(bool));
            user = (User)info.GetValue("User", typeof(User));
        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("IdCounter", idCounter);
            info.AddValue("Id", Id);
            info.AddValue("Address", Address);
            info.AddValue("Description", Description);
            info.AddValue("ZipCode", ZipCode);
            info.AddValue("Price",Price);
            info.AddValue("Residents", Residents);
            info.AddValue("Pets", Pets);
            info.AddValue("Occupied", Occupied);
            info.AddValue("Pool", Pool);
            info.AddValue("Wifi", Wifi);
            info.AddValue("User", user);
        }

        public Rentable()
        {
            this.id = idCounter++;
            this.address = "";
            this.description = "";
            this.price = 0;
            this.zipCode = 0;
            this.residents = 0;
            this.pets = false;
            this.pool = false;
            this.wifi = false;
            this.occupied = false;
            this.user = null;
        }
        public Rentable(string address,string description,int zipCode,double price, int residents, bool pets, bool pool,bool wifi,User user)
        {
            this.id = idCounter++;
            this.address = address;
            this.description = description;
            this.zipCode = zipCode;
            this.price = price;
            this.residents = residents;
            this.pets = pets;
            this.pool = pool;
            this.wifi = wifi;
            this.occupied = false;
            this.user = user;
        }

        public bool Occupied
        {
            get { return occupied; }
            set { occupied = value; }
        }
        public int Id
        {
            get { return id; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int ZipCode 
        { 
            get { return zipCode; }
            set { zipCode = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public bool Pets
        {
            get { return pets; }
            set { pets = value; }
        }
        public int Residents
        {
            get { return residents; }
            set { residents = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public bool Pool
        {
            get { return pool; }
            set { pool = value; }
        }

        public bool Wifi
        {
            get { return wifi; }
            set { wifi = value; }
        }

        public User User
        {
            get { return user; }
            set { user = value; }
        }

    }
}