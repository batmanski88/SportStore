using System;
using System.Collections.Generic;
using System.Text;

namespace SportStore.Repository.Models
{
    public class Product
    {
        public Guid ProductId { get; protected set; }
        public Guid CategoryId { get; protected set; }
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }
        public int Count { get; protected set; }
        public string Description { get; protected set; }
        public string FileName { get; protected set; }
        public bool Available { get; protected set; }
        public virtual Category Category { get; protected set; }

        public Product(Guid productId, Guid categoryId, string name, decimal price, int count, bool available)
        {
            ProductId = productId;
            SetCategoryId(categoryId);
            SetName(name);
            SetPrice(price);
            SetCount(count);
            SetAvailable(available);
        }

        public void SetCategoryId(Guid categoryId)
        {
            CategoryId = categoryId;
        }

        public void SetName(string name)
        {
            if(Name == name)
            {
                return;
            }
            Name = name;
        }

        public void SetPrice(decimal price)
        {
            if(Price == price)
            {
                return;
            }
            Price = price;
        }

        public void SetCount(int count)
        {
            if(Count == count)
            {
                return;
            }
            Count = count;
        }

        public void SetDescription(string description)
        {
            if(Description == description)
            {
                return;
            }
            Description = description;
        }

        public void SetFileName(string fileName)
        {
            if(FileName == fileName)
            {
                return;
            }
            FileName = fileName;
        }

        public void SetAvailable(bool available)
        {
            if(Available == available)
            {
                return;
            }

            Available = available;
        }
    }
}
