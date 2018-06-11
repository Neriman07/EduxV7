using System;
using System.Collections.Generic;
using System.Text;

namespace EduxV7.Data
{
    public class Product : BaseEntity// baseEntity miras (alıyoruz ordaki alanları) 
    {// entity
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}