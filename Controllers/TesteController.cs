using LaboratorioEstudos.API.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class TesteController : ControllerBase
{
    [HttpPost("criar-pessoa")]
    public IActionResult CriarPessoa([FromBody] PessoaClasse pessoa)
    {
        return Ok($"Pessoa criada: {pessoa.Nome}, {pessoa.Idade}");
    }

    [HttpGet("comparar")]
    public IActionResult CompararStructClass()
    {
        var a = new PessoaStruct { Nome = "Ana", Idade = 25 };
        var b = a;
        b.Nome = "Maria";

        var x = new PessoaClasse { Nome = "João", Idade = 30 };
        var y = x;
        y.Nome = "Carlos";

        return Ok(new
        {
            StructOriginal = a.Nome,
            StructCopia = b.Nome,
            ClasseOriginal = x.Nome,
            ClasseReferencia = y.Nome
        });
    }

    [HttpGet("tarefa")]
    public async Task<IActionResult> ExecutarAsync()
    {
        await Task.Delay(1000); // simula algo demorado
        return Ok("Tarefa finalizada com async/await");
    }

    [HttpGet("erro")]
    public IActionResult GerarErro()
    {
        try
        {
            int zero = 0;
            int resultado = 10 / zero;
            return Ok(resultado);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro: {ex.Message}");
        }
    }
}
