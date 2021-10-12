using CrudContasBancarias.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudContasBancarias.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ContaCorrenteController : ControllerBase
  {
    public ContaCorrenteController() { }
    private ContaCorrenteRepository _repository = new ContaCorrenteRepository(0.2, 50, "102030", "2029");


    [HttpGet("{Conta, Senha}")]
    public IActionResult Get(string conta, string senha)
    {
      double saldo = _repository.getSaldo();
      return Ok(new
      {
        saldo = saldo
      });
    }

    [HttpPost]

    public IActionResult Post([FromBody] Deposito deposito)
    {
      _repository.depositar(deposito.Valor);
      double saldo = _repository.getSaldo();
      return Ok(new
      {
        message = "Deposito realizado com sucesso!",
        codeHttp = 201,
        saldo = saldo
      });
    }

    [HttpPost]

    public IActionResult Post([FromBody] Saque saque)
    {
      double saldo = _repository.getSaldo();
      double saldoAtual = saldo - (saque.Valor + _repository.Tarifa);

      if (saldo == 0 || saldo < saque.Valor)
      {
        return Ok(new
        {
          message = "Saldo insuficiente!"
        });
      }

      _repository.sacar(saque.Valor);
      return Ok(new
      {
        message = "Saque realizado com sucesso!",
        codeHttp = 200,
        saldo = saldoAtual
      });
    }
  }
}