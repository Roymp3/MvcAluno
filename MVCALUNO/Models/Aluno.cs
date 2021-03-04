using System;
using System.ComponentModel.DataAnnotations;
namespace MVCALUNO.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public String Email { get; set; }
        public string Rg { get; set; }
    }
}