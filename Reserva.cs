namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
           
            if (Suite.Capacidade>=hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Quantidade superior a capacidade da Suíte");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
           
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
           
            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;

            if (true)
            {
                valor -= valor  * 10 / 100;
            }

            return valor;
        }
    }
}