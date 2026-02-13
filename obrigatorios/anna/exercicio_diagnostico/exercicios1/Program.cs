//a)	Implemente a classe Veiculo, que deve representar as seguintes características:
//Quantidade de ocupantes;•	Quantidade de rodas;
//•	Capacidade Máxima do Tanque de Combustível (em litros);
//•	O nível atual do tanque de combustível em percentual;
//•	O consumo médio (em km/litro) de combustível do veículo;
//•	A quilometragem atual do veículo;
//•	Autonomia do veículo, que identifica a quantidade de Km que ele ainda pode percorrer sem abastecer.
// b)	Crie os métodos de acesso (get/set) para:
//•	Acessar e alterar a quilometragem do veículo;
//•	Acessar e alterar o consumo médio do veículo;
//c)	Implemente a classe Carro, que deve ser derivada da classe Veiculo e deve representar as seguintes características:
//•	Modelo do carro;
//•	Quantidade de portas.
//d)	Crie dois construtores para a classe Carro, um default (construtor padrão) e outro
//completo, compreendendo todos os atributos da classe;
//e)	Crie o método float Percorrer(float qtdQuilometros), que atualiza a quilometragem atual
//do carro, com a quantidade de quilômetros informada como parâmetro do método.
//O método deve retornar ao final do processo a quilometragem atual do carro.

class Veiculo
{
    public int QuantidadeOcupantes;
    public double NivelAtualTanque;
    public double ConsumoMedio { get; set; }
    public float QuilometragemAtual { get; set; }
    public double AutonomiaVeiculo;


}

class Carro : Veiculo
{
    public string ModeloCarro;
    public int QuantidadePortas;

    public Carro()
    {
        ModeloCarro = "bmw";
        QuantidadePortas = 4;
    }

    public Carro(string modeloCarro, int quantidadePortas)
    {
        ModeloCarro = modeloCarro;
        QuantidadePortas = quantidadePortas;
    }

    public float Percorrer(float qntdQuilometros)
    {
        QuilometragemAtual = QuilometragemAtual + qntdQuilometros;
        return QuilometragemAtual;
    }
}