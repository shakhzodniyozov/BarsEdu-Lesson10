public class Entity
{
    public Dictionary<int, List<Entity>> GetGroupedEntities(List<Entity> entities)
    {
        return entities.GroupBy(x => x.ParentId)
                        .ToDictionary(x => x.Key, x => x.ToList());
    }

    public int Id { get; set; }
    public int ParentId { get; set; }
    public string? Name { get; set; }
}