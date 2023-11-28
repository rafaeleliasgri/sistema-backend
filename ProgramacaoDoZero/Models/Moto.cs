namespace Controllers.Models
{
    public class Moto : Veiculo
    {
        public Moto()
        {
            QuantidadeRodas = 2;

            TanqueCombustivel = 15;
        }

        public int QuantidadeRodas { get; set; }

        public override void Acelerar()
        {
            InjetarCombustivel(3);
        }

        private void InjetarCombustivel(int quantidadeCombustivel)
        {
            base.TanqueCombustivel = base.TanqueCombustivel - quantidadeCombustivel;
        }


    }
}