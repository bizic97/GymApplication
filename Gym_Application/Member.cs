using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Application
{
    public class Member
    {
    
        public string MemberName { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int Amount { get; set; }
        public string Timing { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{MemberName} {PhoneNumber} {Gender} {Age} {Amount} {Timing}";
            }
        }


    }
   
}
