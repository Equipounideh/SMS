using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Proyectos_profesionales.Models;

namespace Proyectos_profesionales.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Proyectos_profesionales.Models.Formulario> Formulario { get; set; }
        public DbSet<Proyectos_profesionales.Models.Reporte> Reporte { get; set; }
        public DbSet<Proyectos_profesionales.Models.Historial> Historial { get; set; }
        public DbSet<Proyectos_profesionales.Models.Empleado> Empleado { get; set; }
    }
}
