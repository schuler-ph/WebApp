using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class User
    {
        private double _height;

        // automatische Properties
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Password2 { get; set; }

        public DateTime Birthdate { get; set; }

        // normales Property

        public double Height
        {
            get
            {
                return this._height;
            }

            set
            {
                // Value entspricht dem Parameter der set-Methode
                if(value >= 0.0)
                {
                    this._height = value;
                }
            }
        }

        // ctors

        public User() : this("","","", DateTime.MinValue, 0.0) {}

        public User(string firstname, string lastname, string mail, DateTime birthdate, double height)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Email = mail;
            this.Birthdate = birthdate;
            this.Height = height;
            this.Password = "";
            this.Password2 = "";
        }
    }
}