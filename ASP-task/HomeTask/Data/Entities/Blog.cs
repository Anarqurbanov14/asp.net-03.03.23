namespace HomeTask.Data.Entities
{
    public class Blog : BaseEntity<int>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int PostsCount { get; set; }

        /*Navigation*/
        public ICollection<Post>? Posts { get; set; }
    }
}
