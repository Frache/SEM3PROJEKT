﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Jackman.Models
{
    [DataContract]
    public class Customer : Person
    {
        [DataMember]
        public Company Company { get; set; }
    }
}
