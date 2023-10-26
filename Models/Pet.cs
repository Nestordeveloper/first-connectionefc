#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace practice_first_connection.Models
{
    public class Pet
    {
        [Key]
        public int PetId { get; set; }

        [Required(ErrorMessage = "El nombre de la mascota es requerido.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El tipo de mascota es requerido.")]
        public string PetType { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "La edad debe ser un número positivo.")]
        public int Age { get; set; }

        public bool HasHair { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
