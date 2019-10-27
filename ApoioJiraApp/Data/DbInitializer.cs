using ApoioJiraApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApoioJiraApp.Data
{
  public static class DbInitializer
  {
    public static void Initialize(ApoioTarefasContext context)
    {
      context.Database.EnsureCreated();

      if (context.Usuarios.Any())
        return;

      var usuarios = new Usuario[] {
          new Usuario{ DataCadastro = DateTime.Now, Email = "pauloandredarocha@gmail.com", Nome="Paulo", senha="paulo123"},
          new Usuario{ DataCadastro = DateTime.Now, Email = "paulo.rocha@gmail.com", Nome="Paulo", senha="paulo321" }
      };

      foreach (var usu in usuarios)
        context.Usuarios.Add(usu);

      context.SaveChanges();

      var tarefas = new Tarefa[]
      {
        new Tarefa{  UsuarioId = 1, DataCadastro = DateTime.Now, DataInicio = DateTime.Now, LinkJira = "http:\\teste123.com.br" },
        new Tarefa{  UsuarioId = 1, DataCadastro = DateTime.Now, DataInicio = DateTime.Now, LinkJira = "http:\\teste321.com.br" },
        new Tarefa{  UsuarioId = 2, DataCadastro = DateTime.Now, DataInicio = DateTime.Now, LinkJira = "http:\\teste456.com.br" }
      };

      foreach (var tar in tarefas)
        context.Tarefas.Add(tar);

      context.SaveChanges();

      var artefatos = new Artefato[]
      {
        new Artefato{  TarefaId = 1, DataCadastro = DateTime.Now, Nome = "artefato1.doc"},
        new Artefato{  TarefaId = 1, DataCadastro = DateTime.Now, Nome = "artefato2.doc"},
        new Artefato{ TarefaId = 2, DataCadastro = DateTime.Now, Nome = "artefato3.doc"}
      };

      foreach (var art in artefatos)
        context.Artefatos.Add(art);

      context.SaveChanges();
    }
  }
}
