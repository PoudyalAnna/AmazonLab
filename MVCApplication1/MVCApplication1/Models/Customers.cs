﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication1.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string FavoriteGenre{ get; set; }

        public string ImagePath { get; set; }
    }       
}

