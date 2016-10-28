using _0001_DemonstracaoMVC.Validators;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace _0001_DemonstracaoMVC.Models
{
    public class Pessoa
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Nome é Obrigatório")]
        //[DataType(DataType.MultilineText)]
        public string Nome { get; set; }

        [DisplayName("E-mail")]
        public string Email { get; set; }

        [DisplayName("Data de Nascimento")]
        public DateTime? DataNascimento { get; set; }

        [Range(18,60,ErrorMessage="A idade deve estar entre 18 e 60")]
        [ValidarPar(ErrorMessage="O Numero deve ser par")]
        public int Idade { get; set; }

        public IEnumerable<Pessoa> List()
        {
            yield return new Pessoa { Id = 1, Nome = "Paulo", Idade = 40, Email = "paulo@pilao.com", DataNascimento = new DateTime(1975, 12, 12) };
            yield return new Pessoa { Id = 2, Nome = "Thales", Idade = 20, Email = "thales@pilao.com", DataNascimento = new DateTime(1996, 1, 12) };
            yield return new Pessoa { Id = 3, Nome = "Agnes", Idade = 12, Email = "agnes@pilao.com", DataNascimento = new DateTime(2004, 10, 20) };
        }
        public Pessoa Get(int id)
        {
            switch (id)
            {
                case 1:
                    return new Pessoa { Id = 1, Nome = "Paulo", Idade = 40, Email = "paulo@pilao.com", DataNascimento = new DateTime(1975, 12, 12) };
                case 2:
                    return new Pessoa { Id = 2, Nome = "Thales", Idade = 20, Email = "thales@pilao.com", DataNascimento = new DateTime(1996, 1, 12) };
                case 3:
                    return new Pessoa { Id = 3, Nome = "Agnes", Idade = 12, Email = "agnes@pilao.com", DataNascimento = new DateTime(2004, 10, 20) };
                default:
                    return null;
            }
        }
    }
}