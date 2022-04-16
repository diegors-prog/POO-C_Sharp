using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Aula06_camadasElistas.Domain
{
  public class Cobranca
  {
    public Cobranca(int id, DateTime creationdate, DateTime duedate, double value, Client cliente)
    {
      Id = id;
      Creationdate = creationdate;
      Duedate = duedate;
      Value = value;
      Payday = null;
      Cliente = cliente;
      Status = false;
    }

    public int Id { get; set; }
    public DateTime Creationdate { get; set; }
    public DateTime Duedate { get; set; }
    public double Value { get; set; }
    public DateTime? Payday { get; set; }
    public bool Status { get; set; }
    public Client Cliente { get; set; }
  }
}