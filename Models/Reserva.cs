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
            //Implementado!!
            if (Suite.Capacidade >= hospedes.Count())
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Capacidade insuficiente para acomodar todos os hospedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }
        //IMPLEMENTADO!!!
        public int ObterQuantidadeHospedes()
        {
            int quantidadedeHospedes = Hospedes.Count();
            
            return quantidadedeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            
            decimal valor = DiasReservados * Suite.ValorDiaria;
            

            //iMPLEMENTADO!!!
            if (DiasReservados >= 10)
            {
                valor *= 0.9m; 
            }
            return valor;
        }
    }
}