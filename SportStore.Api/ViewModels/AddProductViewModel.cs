using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportStore.Api.ViewModels
{
    public class AddProductViewModel
    {
        public Guid ProductId { get; set; }
        public Guid? CategoryId { get; set; }
        public SelectList Categories { get; set; } 
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public bool Available { get; set; }
    }
}