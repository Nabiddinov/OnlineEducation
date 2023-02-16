﻿using OnlineEducation.Models;

namespace OnlineEducation.Interfaces
{
    internal interface IPerson
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Account Account { get; set; }
    }
}
