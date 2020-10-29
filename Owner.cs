using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MarketStore
{
    public class Owner
    {
        private string name;
        private string town;
        private int age;
        public Owner()
        {
            name = null;
            town = null;
            age = 0;
        }
        public string Name
        {
            set { name = value;}
            get { return name;}
        }
        public string Town
        {
            set { town = value;}
            get { return town;}
        }
        public int Age
        {
            set { age = value;}
            get { return age;}
        }
        public override string ToString()
        {
            return "Name:" + " " + name + " " + "Town:" + " " + town + " " + "Age:" + " " + age;
        }
    }
}
