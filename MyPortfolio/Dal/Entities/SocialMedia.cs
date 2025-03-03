using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Dal.Entities
{
    public class SocialMedia
    {
        [Key]
        public int SocialMediaId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
    }
}
