using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApoioJiraApp.Models
{
  public class Artefato : ModelBase
  {
    public int TarefaId { get; set; }

    public string Nome { get; set; }

    public byte[] ObjetoArtefato { get; set; }
  }
}
