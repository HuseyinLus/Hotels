﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class EntityDersler
    {
        private string dersad;
        private int max;
        private int min;
        private int id;

        public string Dersad { get => dersad; set => dersad = value; }
        public int Max { get => max; set => max = value; }
        public int Min { get => min; set => min = value; }
        public int Id { get => id; set => id = value; }
    }
}