﻿using Entities;

namespace ECommorceProje.Models
{
    public class HomePageViewModel
    {
        public List<Slide>? Slides { get; set; }
        public List<Category>? Categories { get; set; }
        public List<Product>? Products { get; set; }
    }
}
