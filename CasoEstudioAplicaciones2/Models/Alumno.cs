using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CasoEstudioAplicaciones2.Models
{
    public partial class Alumno 
    {
        public int Id { get; set; }
        [Required]
        public string? NombreAlumno { get; set; }
        [Required]
        [Range(0,5)]
        public float Nota1 { get; set; }
        [Required]
        public float Nota2 { get; set; }
        [Required]
        public float Nota3 { get; set; }
        [Required]
        public double Promedio
        {
            get
            {
                return ((float)((Nota1 * (15 / 100)) + (Nota2 * (30 / 100)) + (Nota3 * (50 / 100))) / 3);
            }
        }
    }
   
}
