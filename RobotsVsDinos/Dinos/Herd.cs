﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    class Herd
    {
        //member Variables 
        public List<Dino> herd;
        


        public Dino dino1 = new Dino("Dr. Raptor     ");
        public Dino dino2 = new Dino("T-Rob          ");
        public Dino dino3 = new Dino("Sloth-A-Saurs  ");

        //Constructor
        public Herd()
        {
            herd = new List<Dino>();
            herd.Add(dino1);
            herd.Add(dino2);
            herd.Add(dino3);
        }

        //member methods
        
    }
}
