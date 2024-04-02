using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    public class Candidate
    {
       
            private string _ID;
            private string _Name; 
            private string gender;
            private string nationality;
            private string address;
            private string _DOB;
            private string expYears;
            private string email;
            private string phone;
            private string describe;
             private string applyposition;
              private string skill;

        public Candidate(string ID, string Name, string gender, string nationality, string address, string DOB, string ExpYears, string email, string phone, string describe,string applyPosition,string skill)
        {
            this._ID = ID;
            this._Name = Name;
            this.gender = gender;
            this.nationality = nationality; 
            this.address = address;
            this.DOB = DOB; 
            this.expYears = ExpYears;  
            this.describe = describe;
            this.applyposition = applyPosition;
            this.skill = skill;
        }

        public string ApplyPosition
        {
            get { return applyposition; }
            set { applyposition = value; }
        }
        public string Skill
        {
            get { return skill; }
            set { skill = value; }
        }
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string DOB
        {
            get { return _DOB; }
            set { _DOB = value; }
        }
        public string ExpYears
        {
            get { return expYears; }
            set { expYears = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Describe
        {
            get { return describe; }
            set { describe = value; }
        }


    }
}

    