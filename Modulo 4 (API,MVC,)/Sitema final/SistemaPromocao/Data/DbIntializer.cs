using SistemaPromocaoMVC.Models;
using System;
using System.Collections.Generic;
public static class DbInitializer
{
    public static void Initialize(AppDbContext context)
    {
        context.Database.EnsureCreated();

        if (context.Escritores.Any())
        {
            return;
        }

        var escritores = new Escritor[]
        {
            new Escritor { Nome = "James", Sobrenome = "Bond", Biografia = "Meu nome é Bond, James Bond.", Tipo = "Livro" },
            new Escritor { Nome = "Cabo", Sobrenome = "Loso", Biografia = "Meu nome é Loso, Cabo Loso.", Tipo = "Blog" }
        };
        context.Escritores.AddRange(escritores);

        var promotores = new Promotor[]
        {
            new ClubeITA { Nome = "Ardiloso", Sobrenome = "Cortes", Telefone = "(31) 9 9999-6070", CartaoVisita = "Ardiloso Cortes: (31) 9 9999-6070.", Local = "ITA" },
            new ClubeSESC { Nome = "Valquíria", Sobrenome = "Cain", Telefone = "(31) 9 9999-7070", CartaoVisita = "Valquíria Cain: (31) 9 9999-7070.", Local = "SESC" }
        };
        context.Promotores.AddRange(promotores);

        var bodybuilders = new Bodybuilder[]
        {
            new Bodybuilder { Nome = "Arnold", Sobrenome = "Schwarzenegger" },
            new Bodybuilder { Nome = "Ronnie", Sobrenome = "Coleman" }
        };
        context.Bodybuilders.AddRange(bodybuilders);

        var vloggers = new Vlogger[]
        {
            new Vlogger { Nome = "Casey", Sobrenome = "Neistat" },
            new Vlogger { Nome = "PewDiePie", Sobrenome = "Kjellberg" }
        };
        context.Vloggers.AddRange(vloggers);

        context.SaveChanges();
    }
}