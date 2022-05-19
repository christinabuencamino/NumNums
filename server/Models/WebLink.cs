using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace server.Models
{
    [Table("Link")]
	
    public class WebLink
    {
        public WebLink()
        {
        }
		
        [Column("link_id")]
        public string WebLinkId { get; set; }
        [Column("link")]
        public string? WebsiteLink{ get; set; }
    }
}