
using System.ComponentModel.DataAnnotations;
namespace final_assignment_template.Models;

public class GenAI
{
    [Required]
    public int Id { get; set; }

    [Required]
    public string GenAIName  { get; set; }

    [Required]

    public string Summary { get; set; }

    [Required]
    public string ImageFilename { get; set; }
    
    [Required]
    public string AnchorLink { get; set; }

    [Required]
    public int Like { get; set; }
}


