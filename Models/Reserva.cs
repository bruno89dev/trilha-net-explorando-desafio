namespace DesafioProjetoHospedagem.Models;

public class Reserva
{
    public List<Pessoa> Hospedes { get; set; }
    public Reserva(Suite suite, int diasReservados) {
        this.Suite = suite;
        this.DiasReservados = diasReservados;     
    }

    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva() { }

    public Reserva(int diasReservados) {
        DiasReservados = diasReservados;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes) {
        
        if (hospedes.Count <= Suite.Capacidade) {
            Hospedes = hospedes;
        } else {
            Console.WriteLine("A capacidade da suíte é menor que a quantidade de hóspedes!");
        }
    }

    public void CadastrarSuite(Suite suite) {
        Suite = suite;
    }

    public int ObterQuantidadeHospedes() {
        int contagemHospedes = Hospedes.Count;
        return contagemHospedes;
    }

    public decimal CalcularValorDiaria() {

        decimal valor = DiasReservados * Suite.ValorDiaria;

        if (DiasReservados > 10) {
            valor = (valor - valor/10);
        }
        
        return valor;
    }
}