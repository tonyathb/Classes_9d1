using DogMeeting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackOfDogs
{
    public class Pack
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<Dog> Members { get; set; }
        public int CountMembers
        {
            get
            {
                return Members.Count;
            }
            //NO set => readONLY 
        }
    }
}
