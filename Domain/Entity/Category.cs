using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Category
    {
        public Guid Id { get; set; }
        [Required(ErrorMessageResourceType =typeof(Resource.ResourceData),ErrorMessageResourceName ="CategoryName")]
        [MaxLength(20, ErrorMessageResourceType =typeof(Resource.ResourceData),ErrorMessageResourceName ="MaxLength")]
        [MinLength(3, ErrorMessageResourceType = typeof(Resource.ResourceData),ErrorMessageResourceName = "MinLength")]
        public string Name { get; set; }
        public string Description { get; set; }
    
        public string CurrentStatus { get; set; }
        // public Book Book { get; set; }

        public Guid SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
        public List<Book> Book { get; set; }
    }
}
