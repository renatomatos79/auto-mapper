﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperLibrary.Model
{
    public class AuthorModel
    {
        public int Id
        {
            get; set;
        }
        public string FirstName
        {
            get; set;
        }
        public string LastName
        {
            get; set;
        }
        public string ContactDetails
        {
            get; set;
        }
        public Address Address
        {
            get; set;
        }
    }

}
