using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApoioJiraApp.Models
{
  public class Tarefa : ModelBase
  {
    public int UsuarioId { get; set; }
    public string Resumo { get; set; }

    public string LinkJira { get; set; }

    public DateTime DataInicio { get; set; }

    public DateTime? DataFim { get; set; }

    public string Observacao { get; set; }

    public List<Artefato> ListaArtefato { get; set; }
  }
}
