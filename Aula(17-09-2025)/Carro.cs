

public class Carro
{
    //parametros
    public int _id;
    public string _marca;
    public string _modelo;
    public string _placa;
    public string _renavam;
    private string _chassi;


    /*
public bool ValidarChassi(string chassi)
{
    chassi = chassi.ToUpper();
    if (chassi.Length == 17 && !chassi.Contains("i") && !chassi.Contains("o") && !chassi.Contains("q"))
    {
       return true;

    }
    throw new ArgumentException("CHASSI INVALIDO!");



}

*/

    public void SetChassi(string chassi)
    {
        chassi = chassi.ToUpper();
        if (chassi.Length == 17 && !chassi.Contains("i") && !chassi.Contains("o") && !chassi.Contains("q"))
        {
            _chassi = chassi;
        }
        else
        {
            //lança uma exceção
            throw new ArgumentException("CHASSI INVALIDO!");
        }

    }

    public string GetChassi()
    {
        return _chassi;
    }


    //metodo construtor
    public Carro (string chassi)
    {
        SetChassi (chassi);
    }

    public Carro(int id, string marca, string modelo, string placa, string renavam, string chassi)
    {

        SetChassi(chassi);

        _id = id;
        _marca = marca;
        _modelo = modelo;
        _placa = placa;
        _renavam = renavam;
        _chassi = chassi;
    }



}