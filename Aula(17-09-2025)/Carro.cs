

public class Carro
{
    //parametros
    public int _id;
    public string _marca;
    public string _modelo;
    public string _placa;
    public string _renavam;
    public string _chassi;

    //metodo construtor
    public Carro (string chassi)
    {
        if (ValidarChassi(chassi))
        {
            _chassi = chassi;
        }

    }

    public Carro(int id, string marca, string modelo, string placa, string renavam, string chassi)
    {
        if (ValidarChassi(chassi))
        {
            _chassi = chassi;
        }

        _id = id;
        _marca = marca;
        _modelo = modelo;
        _placa = placa;
        _renavam = renavam;
        _chassi = chassi;
    }

    public bool ValidarChassi(string chassi)
    {
        chassi = chassi.ToUpper();
        if (chassi.Length == 17 && !chassi.Contains("i") && !chassi.Contains("o") && !chassi.Contains("q"))
        {
           return true;

        }
        throw new ArgumentException("CHASSI INVALIDO!");



    }
}