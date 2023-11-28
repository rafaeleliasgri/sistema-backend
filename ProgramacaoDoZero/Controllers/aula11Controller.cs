using Controllers.Models;
using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers;

[ApiController]
[Route("api/aula11Controller")]
public class aula11Controller : ControllerBase
{
    [Route("obterVeiculo")]
    [HttpGet]
    public Veiculo obterVeiculo()
    {
        var meuVeiculo = new Veiculo();

        meuVeiculo.Cor = "Amarelo";
        meuVeiculo.Placa = "CPIBA85";
        meuVeiculo.Marca = "Toyota";
        meuVeiculo.Modelo = "Yaris";

        meuVeiculo.Acelerar();
        meuVeiculo.Acelerar();
        meuVeiculo.Acelerar();

        return meuVeiculo;
    }

    [Route("obterCarro")]
    [HttpGet]
    public Carro obterCarro()
    {
        var meuCarro = new Carro();

        meuCarro.Marca = "Honda";
        meuCarro.Modelo = "HRV";
        meuCarro.Placa = "EXE7I89";
        meuCarro.Cor = "Prata";

        meuCarro.Acelerar();

        return meuCarro;
    }

    [Route("obterMoto")]
    [HttpGet]
    public Moto obterMoto()
    {
        var minhaMoto = new Moto();

        minhaMoto.Marca = "Yamaha";
        minhaMoto.Modelo = "Fazer";
        minhaMoto.Placa = "AXH6A76";
        minhaMoto.Cor = "Amarela";

        minhaMoto.Acelerar();

        return minhaMoto;
    }

}
