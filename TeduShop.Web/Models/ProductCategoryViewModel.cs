using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Web.Models
{
    public class ProductCategoryViewModel
    {
        [Required(ErrorMessage = "Yêu cầu nhập tên danh mục")]
        public string Name { set; get; }

        [Required(ErrorMessage = "Yêu cầu nhập tiêu đề SEO")]
        public string Alias { set; get; }

        public string Description { get; set; }

        public int ParentID { get; set; }

        public int DisplayOrder { get; set; }

        public string Image { get; set; }

        public bool HomeFlag { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public string MetaKeyword { get; set; }

        public string MetaDescription { get; set; }

        public bool Status { get; set; }

        public virtual IEnumerable<ProductViewModel> Products { get; set; }
    }
}