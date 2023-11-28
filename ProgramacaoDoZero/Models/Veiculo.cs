namespace Controllers.Models
{
    public class Veiculo
    {
        //Este abaixo é o construtor
        public Veiculo()
        {
            TanqueCombustivel = 40;
        }
        //Estes abaixo são os atributos ou propriedades
        public string? Cor { get; set; }

        public string? Marca { get; set; }

        public string? Placa { get; set; }

        public string? Modelo { get; set; }

        public int TanqueCombustivel { get; set; }

        //Estes abaixo são os Métodos
        public virtual void Acelerar()
        {
            InjetarCombustivel(1);
        }

        public void Frear()
        {

        }

        private void InjetarCombustivel(int quantidadeCombustivel)
        {
            TanqueCombustivel = TanqueCombustivel - quantidadeCombustivel;
        }
    }
}