using System;
using System.Collections.Generic;

#nullable disable

namespace ShopOnline_ASM_NET104_CONGNCPH14366.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CatId { get; set; }
        public string CatName { get; set; }
        public string Descripstion { get; set; }
        public int? ParentId { get; set; }
        public int? Levels { get; set; }
        public int? Orderring { get; set; }
        public bool? Publicshed { get; set; }
        public string Img { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public string MetaDesc { get; set; }
        public string MetaKey { get; set; }
        public string SchemaMarup { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
