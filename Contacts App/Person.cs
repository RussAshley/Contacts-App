using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_App
{
    class Person
    {
        private String name;
        private String relation;
        private String profession;
        private String maritalStatus;
        private uint phoneNo;
        private String address;
        private String gender;

        public Person(string name, string relation, string profession, string maritalStatus, uint phoneNo, string address, string gender)
        {
            this.Name = name;
            this.Relation = relation;
            this.Profession = profession;
            this.MaritalStatus = maritalStatus;
            this.PhoneNo = phoneNo;
            this.Address = address;
            this.Gender = gender;
        }

        public string Name { get => name; set => name = value; }
        public string Relation { get => relation; set => relation = value; }
        public string Profession { get => profession; set => profession = value; }
        public string MaritalStatus { get => maritalStatus; set => maritalStatus = value; }
        public uint PhoneNo { get => phoneNo; set => phoneNo = value; }
        public string Address { get => address; set => address = value; }
        public string Gender { get => gender; set => gender = value; }
    }
}
