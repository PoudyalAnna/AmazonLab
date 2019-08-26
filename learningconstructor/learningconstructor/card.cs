using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningconstructor
{
    class card
    {
        string rank;
        string strick;
        int val;

        public card(string rank, string strick, int val)
        {
            this.Rank = rank;
            this.Strick = strick;
            this.Val = val;
        }


        public string Rank { get => rank; set => rank = value; }
        public string Strick { get => strick; set => strick = value; }
        public int Val { get => val; set => val = value; }
    }
    
   



}
