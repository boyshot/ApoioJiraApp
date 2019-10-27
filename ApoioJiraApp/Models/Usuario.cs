using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApoioJiraApp.Models
{
  public class Usuario : ModelBase
  {
    public string Nome { get; set; }

    public string Email { get; set; }

    public string senha { get; set; }

    public List<Tarefa> ListaTarefas { get; set; }
  }
}
