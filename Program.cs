using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "João", sobrenome: "da Silva");
Pessoa p2 = new Pessoa(nome: "Maria", sobrenome: "da Silva");
Pessoa p3 = new Pessoa(nome: "Pedro", sobrenome: "da Silva");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 4, valorDiaria: 350);

Reserva reserva = new Reserva(diasReservados: 12);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Quantidade de Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Hóspedes Registrados: \n {p1.NomeCompleto} \n {p2.NomeCompleto} \n {p3.NomeCompleto}");
Console.WriteLine($"Valor a pagar: {reserva.CalcularValorDiaria().ToString("n2")}");