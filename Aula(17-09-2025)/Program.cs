

try
{
    Carro carro1 = new Carro("10203040906070090");
    Console.WriteLine($"O chassi informado foi: {carro1._chassi}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

//espera uma tecla ser precionada para incerrar
Console.ReadKey();

////trata do metodo contrutor pedindo todos os parametros
//Carro carro2 = new Carro(1, "VW", "Gol", "102030", "20304050", "12345678910111213");
