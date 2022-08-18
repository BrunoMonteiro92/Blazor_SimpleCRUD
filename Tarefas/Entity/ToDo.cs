namespace Tarefas.Entity
{
    public class ToDo
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public bool Finished { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}