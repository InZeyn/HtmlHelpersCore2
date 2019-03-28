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
        public int Telefono { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public Genero UserGenero { get; set; }
        public EstadoCivil UserEstadoCivil { get; set; }
    }

    public enum Genero
    {
        Masculino,
        Femenino
    }

    public enum EstadoCivil
    {
        Casado,
        Soltero,
        Viduo,
        UnionLibre
    }
}
