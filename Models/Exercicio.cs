namespace ProjetoKatuak.Models
{
    public class Exercicio
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string Solucao { get; set; } = string.Empty;
        public Exercicio Clone()
        {
            return new Exercicio
            {
                Id = this.Id,
                Titulo = this.Titulo,
                Descricao = this.Descricao,
                Solucao = this.Solucao
            };
        }
    }
}
