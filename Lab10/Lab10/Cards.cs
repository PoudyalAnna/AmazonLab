using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Cards
    {
        string rank;
        string suits;
        int val;


       public Cards(string rank, string suits , int val)
        {
            this.Rank = rank;
            this.Suits = suits;
            this.Val = val;

        }

        public string Rank { get => rank; set => rank = value; }
        public string Suits { get => suits; set => suits = value; }
        public int Val { get => val; set => val = value; }

        public override string ToString()
        {
            return string.Format("{0,2}{1}", rank, suits);

        }
    }
   
  
    
     
}
