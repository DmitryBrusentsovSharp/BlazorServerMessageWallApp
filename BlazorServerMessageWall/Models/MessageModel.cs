using System.ComponentModel.DataAnnotations;

namespace BlazorServerMessageWall.Models
{
    public class MessageModel
    {
        [Required]
        [StringLength(20, MinimumLength = 4)]
        public string FirstName { get; set; }
		[Required]
		[StringLength(20, MinimumLength = 6)]
		public string LastName { get; set; }
	}
}
