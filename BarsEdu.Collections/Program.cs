List<Entity> entities = new()
{
    new Entity() { Id = 1, ParentId = 0, Name = "Root Entity" },
    new() { Id = 2, ParentId = 1, Name = "Child of 1 entity" },
    new() { Id = 3, ParentId = 1, Name = "Child of 1 entity" },
    new() { Id = 4, ParentId = 2, Name = "Child of 2 entity" },
    new() { Id = 5, ParentId = 4, Name = "Child of 4 entity" }
};

Entity entity = new();

var dictionary = entity.GetGroupedEntities(entities);