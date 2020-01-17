using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_mvc_webapp.Models
{
public class Product
{   
    [Key] //indicates key
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //autogenerated by database and shows identity unique
    public int IdProduct {get; set;} //get is from, set is to

    [Display(Name = "Enter Product Code")]
    [StringLength(20)] //limits characters
    [Required(ErrorMessage = ("{0} Is required"))] //Manadator Field with error message
    public string ProductCode{get; set;}
    
    [Display(Name = "Enter Product Type")]
    [StringLength(50)]
    [Required(ErrorMessage = ("{0} Is required"))]
    public string ProductType{get; set;}

    [Display(Name = "Enter Product Description")]
    [StringLength(150)]
    public string Description{get; set;}

    [Display(Name = "Unit Price")]
    [DisplayFormat(DataFormatString = "{0:C}")]
    [Required(ErrorMessage = ("{0} Is required"))]
    public decimal UnitPrice{get; set;}

    [Display(Name = "Quantity in Stock")]
    [Required(ErrorMessage = ("{0} Is required"))]
    public int QtyInStock{get; set;}

}
//dotnet ef migrations add InitialCreate --context MvcWebAppDbContext
//
}