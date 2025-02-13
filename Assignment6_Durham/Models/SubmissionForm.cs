using System.ComponentModel.DataAnnotations;

namespace Assignment6_Durham.Models;

public class SubmissionForm
{
    [Key]
    public int MusicFormId {get; set;}
    
    public string Category {get; set;}
    
    public string Title {get; set;}
    
    public string Year {get; set;}
    
    public string Director {get; set;}
    
    public string Rating {get; set;}
    
    public bool? Edited {get; set;}
    
    public string? LentTo {get; set;}
    
    public string? Notes {get; set;}
}