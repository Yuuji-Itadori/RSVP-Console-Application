using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class Guest
    {
        public string name;
        public string lifechoice;
        public string rsvp;

        public Guest(Guest temp)
        {

            name = temp.name;
            lifechoice = temp.lifechoice;
            rsvp = temp.rsvp;

        }
        public Guest(string name, string lifechoice, string rsvp)
        {
            this.name = name;
            this.lifechoice = lifechoice;
            this.rsvp = rsvp;
        }

    }

