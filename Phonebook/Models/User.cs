using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Phonebook.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Last { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
    }
}