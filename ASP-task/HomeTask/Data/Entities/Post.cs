namespace HomeTask.Data.Entities
{
    public class Post : BaseEntity<int>
    {
        public string Title { get; set; } = string.Empty;
        public string Subtitle { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Desc { get; set; } = string.Empty;
        public int BlogId { get; set; }

    }
}
