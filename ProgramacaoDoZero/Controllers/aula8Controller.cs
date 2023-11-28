using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers;

[ApiController]
[Route("api/aula8Controller")]
public class aula8Controller : ControllerBase
{

    [HttpGet]
    [Route("olaMundo")]
    public string olaMundo()
    {

        var mensagem = "Olá! Eu sou uma API!";
        
        return mensagem;
    }

    [HttpGet]
    [Route("olaMundoPersonalizado")]
    public string olaMundoPersonalizado(string nome)
    {
        var mensagem = nome + " Olá Mundo via API!";

        return mensagem;
    }

    [HttpGet]
    [Route("somar")]
    public string somar(int valor1, int valor2)
    {
        var soma = valor1 + valor2;

        var mensagem = "A soma é " + soma;

        return mensagem;
    }

    [HttpGet]
    [Route("media")]
    public string media(decimal numero1, decimal numero2)
    {
        var media = (numero1 + numero2) / 2;

        var mensagem = "A média é " + media;

        return mensagem;
    }

    [HttpGet]
    [Route("valorTerreno")]
    public string valorTerreno(decimal comprimento, decimal largura, decimal valorMetroQuadrado)
    {
        var mQuad = comprimento * largura;

        var msg1 = "A área do terreno é " + mQuad + " metros quadrados.";

        var valTerreno = comprimento * largura * valorMetroQuadrado;

        var msg2 = "O valor do terreno é R$ " + valTerreno;

        return msg1 + " " + msg2;

    }

    [HttpGet]
    [Route("troco")]
    public string troco(decimal qtdProduto, decimal precoProduto, decimal valorDadoCliente)
    {
        var troco = valorDadoCliente - (qtdProduto * precoProduto);

        var msg1 = "O troco a ser devolvido ao cliente é R$ " + troco;

        return msg1;
    }

    [HttpGet]
    [Route("pagtoFuncionario")]
    public string pagtoFuncionario(string nomeFuncionario, decimal qtdHorasTrab, decimal valorHoraTrab)
    {
        var salario = qtdHorasTrab * valorHoraTrab;

        var msg1 = "O pagamento do funcionário " + nomeFuncionario + " deverá ser de R$ " + salario;

        return msg1;
    }

    [HttpGet]
    [Route("rendCarro")]
    public string rendCarro(string marcaVeiculo, decimal distPercorrida, decimal qtdLitros)
    {
        var rendimento = distPercorrida / qtdLitros;

        var msg1 = "O veiculo marca " + marcaVeiculo + " percorre em média " + rendimento + " km/L.";

        return msg1;
    }

}

