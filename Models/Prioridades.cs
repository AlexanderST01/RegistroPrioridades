using System.ComponentModel.DataAnnotations;
public class Prioridades
{
    [Key]
    public int PrioridadId { get; set; }   
    [Required(ErrorMessage ="La descripcion es obligatoria")]
    public string? Descripcion{ get; set; }
    [Range(1, 31, ErrorMessage = "Los dias compromiso estan entre 1 y 31")]
    public int DiasCompromiso{ get; set; }


}
