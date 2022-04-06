﻿using System;

namespace TestAPI.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int[] Ratings { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
