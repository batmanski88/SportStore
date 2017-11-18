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

        public Category()
        {

        }

        public Category(Guid categoryId, string name, string iconFileName)
        {
            CategoryId = categoryId;
            SetName(name);
            SetIconFileName(iconFileName);
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
