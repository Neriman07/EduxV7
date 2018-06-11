using System;
using System.Collections.Generic;
using System.Text;

namespace EduxV7.Data
{
   public class BaseEntity// ortak alanları koyuyoruz.(Temel Clasımız)
    {
        public string Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdatedBy { get; set; }
        public string IPAddress { get; set; }
    }
}
