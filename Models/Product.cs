using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiEntityFrameWork.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Max Length is 20")]
        [MinLength(6, ErrorMessage = "Min Length is 6")]
        public string ProductName { get; set; }

        [Required]
        [Range(1, 100, ErrorMessage = "Range between 0 and 100")]
        public int QntyInStock { get; set; }
        [Required]
        public string Description { get; set; }

        public Suppliers Suppiler { get; set; }
        [DataType(DataType.Date)]
        [Validation]
        public DateTime DateOfPurchase { get; set; }
    }
    public enum Suppliers
    {
        S001, S002, S003, S004
    }
}