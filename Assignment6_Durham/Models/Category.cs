using System.ComponentModel.DataAnnotations;

namespace Assignment6_Durham.Models;

public class Category
{
    [Key]
    [Required] 
    public int CategoryId { get; set; }
    
    [Required]
    public string CategoryName { get; set; }
    
    
}