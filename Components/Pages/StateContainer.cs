using ProjetoKatuak.Models;
using ProjetoKatuak.Data;

namespace ProjetoKatuak.Components.Pages
{
    public class StateContainer
    {
        public List<Exercicio> Exercicios { get; set; } = new List<Exercicio>();
        public Exercicio EditExercicio { get; set; }
        public event Action OnChange;

        public void NotifyStateChanged() => OnChange?.Invoke();
    }
}
