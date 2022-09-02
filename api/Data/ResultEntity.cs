using System.ComponentModel.DataAnnotations;

namespace Data;

public record ResultEntity : EntityBase
{
    [Required]
    [MinLength(1)]
    public string User { get; set; }

    public Guid ResultGroup { get; set; }
}
