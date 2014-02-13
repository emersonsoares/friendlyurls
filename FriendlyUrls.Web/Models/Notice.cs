namespace FriendlyUrls.Web.Models
{
    public class Notice
    {
        private Notice() { }

        public static Notice New(string slug, string title, string content)
        {
            return new Notice
            {
                Slug = slug.Trim().Replace(" ", "-"),
                Title = title,
                Content = content
            };
        }

        public int Id { get; set; }

        public string Slug { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }
    }
}