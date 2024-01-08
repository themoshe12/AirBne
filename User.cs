using System;
using System.Collections.Generic;
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
    public class User
    {
        private static int idCounter = 0;
        private int id;
        private string username;
        private string password;
        private string name;
        private Rentable item;

        public User()
        {
            id = idCounter++;
            username = "";
            password = "";
            name = "";
            item = null;
        }

        public User(SerializationInfo info, StreamingContext context)
        {
            idCounter = (int)info.GetValue("IdCounter", typeof(int));
            id = (int)info.GetValue("Id", typeof(int));
            username = (string)info.GetValue("Username", typeof(string));
            password = (string)info.GetValue("Password", typeof(string));
            name = (string)info.GetValue("Name", typeof(string));
            item = (Rentable)info.GetValue("Item", typeof(Rentable));
        }

        public User(string username, string password, string name)
        {
            this.id = idCounter++;
            this.username = username;
            this.password = password;
            this.name = name;
            item = null;
        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("IdCounter", idCounter);
            info.AddValue("Id", Id);
            info.AddValue("Username", username);
            info.AddValue("Name", name);
            info.AddValue("Password", password);
            info.AddValue("Item", item);
        }

        public int Id { get { return id; } }
        public string UserName { 
            get { return username; }
            set { username = value; }
        }
        public string Password { 
            get { return password; }
            set { password = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Rentable Item
        {
            get { return item; }
            set { item = value; }
        }

        public string toString()
        {
            return id+"\n"+username + "\n" +password + "\n" +name + "\n";
        }

    }
}