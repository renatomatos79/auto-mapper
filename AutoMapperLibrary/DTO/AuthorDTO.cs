using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperLibrary.DTO
{
    public class AuthorDTO
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
        public string Contact
        {
            get; set;
        }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
