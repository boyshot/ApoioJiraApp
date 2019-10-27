using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApoioJiraApp.Models
{
  public abstract class ModelBase
  {
    public int Id { get; set; }

    public DateTime DataCadastro { get; set; }
  }
}
