﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XmlrpcAPI.Models
{
    public class Customer
    {
        public string UUID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Timestamp { get; set; }
        public int Version { get; set; }
        public bool Active { get; set; }
        public bool Banned { get; set; }
    }
}
