using System;
using System.Collections.Generic;
using System.Text;

namespace SportStore.Repository.Models
{
    public class Category
    {
        public Guid CategoryId { get; protected set; }
        public string Name { get; protected set; }
        public string IconFileName { get; protected set; }
        public virtual ICollection<Product> Products { get; protected set; }

        public Category(Guid categoryId, string name)
        {
            CategoryId = categoryId;
            SetName(name);
        }

        public void SetName(string name)
        {
            if(Name == name)
            {
                return;
            }
            Name = name;
        }

        public void SetIconFileName(string iconFileName)
        {
            IconFileName = iconFileName;
        }
    }
}
