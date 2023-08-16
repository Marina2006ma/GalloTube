using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GalloTube.Models;

[Table("Video")]
public class Video
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Display(Name = "Name")]
    [Required(ErrorMessage = "O Título é obrigatório")]
    [StringLength(100, ErrorMessage = "O Título deve possuir no máximo 100 caracteres")]
    public string Name { get; set; }


    [Display(Name = "Description")]
    [Required(ErrorMessage = "A Descrição é obrigatória")]
    [StringLength(8000, ErrorMessage = "A Descrição deve possuir no máximo 8000 caracteres")]
    public string Description { get; set; }

    [Display(Name = "Duração (em minutos)")]
    [Required(ErrorMessage = "A Duração é obrigatória")]
    public Int16 Duration { get; set; }

    [Column(TypeName = "UploadDate")]
    [Display(Name = "Data de publicação")]
    [Required(ErrorMessage = "A Data de publicação é obrigatório")]
    public DateTime UploadDate { get; set; }

    [StringLength(200)]
    [Display(Name = "Thumbnail")]
    public string Thumbnail { get; set; }

    [StringLength(200)]
    [Display(Name = "VideoFile")]
    public string VideoFile { get; set; }

    [NotMapped]
    [Display(Name = "Duration")]
    
    public string HourDuration { get {
        return TimeSpan.FromMinutes(Duration) .ToString(@"%h'h 'mm'min'");
    }}
    public ICollection<VideoTag> Tags { get; set; }

}