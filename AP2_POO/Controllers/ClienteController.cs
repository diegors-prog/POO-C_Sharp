using System;
using AP2_POO.Interfaces;
using AP2_POO.Models;
using AP2_POO.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AP2_POO.Controllers
{
  [ApiController]
  [Route("v1")]
  public class ClienteController
  {
    private readonly IClienteRepository clientes;

    public ClienteController(IClienteRepository clienteRepository)
    {
      this.clientes = clienteRepository;
    }

    [HttpGet]
    [Route("cliente")]
    public IActionResult GetList()
    {
      var listClientes = clientes.GetAll();
      if (listClientes.Count == 0) return NotFound();
      return Ok(listClientes);
    }

    [HttpGet]
    [Route("cliente/{id}")]
    public IActionResult Get(int id)
    {
      var cliente = clientes.GetById(id);
      if (cliente == null) return NotFound();
      return Ok(cliente);
    }

    [HttpPost]
    [Route("cliente")]
    public IActionResult Post([FromBody] ClienteCreateViewModel model)
    {
      if (!ModelState.IsValid) return BadRequest();

      var newCliente = new Cliente
      {
        Email = model.Email,
        Nome = model.Nome,
        Fone = model.Fone,
        DataNasc = model.DataNasc
      };

      clientes.Save(newCliente);
      return Ok(new
      {
        message = "Cliente " + model.Nome + " foi adicionado com sucesso!"
      });
    }

    [HttpDelete]
    [Route("cliente/{id}")]
    public IActionResult Delete(int id)
    {
      var cliente = clientes.GetById(id);
      if (cliente == null) return NotFound();

      clientes.Delete(cliente);
      return Ok(new
      {
        message = "Cliente deletado com sucesso!"
      });
    }

    [HttpPut]
    [Route("cliente/{id}")]
    public IActionResult Put(int id, [FromBody] ClienteUpdateViewModel model)
    {
      var cliente = clientes.GetById(id);
      if (cliente == null) return NotFound();

      cliente.Email = model.Email;
      cliente.Fone = model.Fone;

      clientes.Update(cliente);
      return Ok(new
      {
        message = "Cliente atualizado com sucesso!",
        id = id
      });
    }
  }
}