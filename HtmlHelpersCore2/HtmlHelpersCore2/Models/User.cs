using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HtmlHelpersCore2.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }

    public class User
    {
        [Required]
        [Key]
        public int Cedula { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Range(15,double.MaxValue,ErrorMessage = "Debe ser mayor de 15 años")]
        public int Edad { get; set; }
        [Phone]
        public string Telefono { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public Genero UserGenero { get; set; }
        public string UserEstadoCivil { get; set; }
        public bool isProgramar { get; set; }
        public bool isNetflix { get; set; }
        public bool isMusica { get; set; }
        public bool isDormir { get; set; }
    }

    public enum Genero
    {
        Masculino,
        Femenino
    }

}
