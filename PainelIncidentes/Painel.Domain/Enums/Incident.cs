using Painel.Domain.Enums;

namespace Painel.Domain.Entities;

public class Incident
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Description { get; set; } = string.Empty;
    public Severity Severity { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string Source { get; set; } = "System";
    public bool IsResolved { get; set; }
}