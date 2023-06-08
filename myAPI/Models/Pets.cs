using System.ComponentModel.DataAnnotations.Schema;

namespace myAPI.Models
{
    public class Pets
    {
        [System.ComponentModel.DataAnnotations.Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int Id { get; }
        
        [System.ComponentModel.DataAnnotations.Required]
        string Name { set; get; }

        int Paws { set; get; }

    }
        
        
            
}
