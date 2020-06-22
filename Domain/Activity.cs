using System;

namespace Domain
{
    public class Activity
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public DateTime Data { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }
    }
}