namespace Pinguin.Domain;

public interface IEntity
{
    int Id { get; set; }
}
public class EntityBase : IEntity
{
    public int Id { get; set; }
}
