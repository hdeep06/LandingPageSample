using System.ComponentModel.DataAnnotations;

//Table 'Subscribers' Model
namespace SampleDAL
{
    public class Subscribers
    {
        [Key] public int Id { get; set; }
        [Required] public string Name { get; set; }
        [Required] [EmailAddress] public string Email { get; set; }
    }
}
