namespace HomeTask.Dtos
{
    public class PostDto
    {
        public string Title { get; set; } = string.Empty;
        public string Subtitle { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Desc { get; set; } = string.Empty;
        public int BlogId { get; set; }
    }
}
