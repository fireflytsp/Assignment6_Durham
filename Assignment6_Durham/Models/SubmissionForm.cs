using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment6_Durham.Models;

public class SubmissionForm
{
    [Key]
    public int MovieId { get; set; }

    [ForeignKey("CategoryId")]
    public int? CategoryId { get; set; }
    public Category? Category { get; set; }

    [Required(ErrorMessage = "You must enter a title")]
    public string Title { get; set; }

    [Required(ErrorMessage = "You must enter a year")]
    [Range(1888, int.MaxValue, ErrorMessage = "Year cannot be less than 1888.")]
    public string Year { get; set; }

    public string? Director { get; set; }
    public string? Rating { get; set; }

    [Required(ErrorMessage = "You must enter an Edited Status")]
    public bool Edited { get; set; }

    public string? LentTo { get; set; }

    [Required(ErrorMessage = "You must enter a Copied to Plex Status")]
    public string CopiedToPlex { get; set; }

    public string? Notes { get; set; }
}