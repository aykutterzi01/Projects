﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Database_Application.Classes
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
