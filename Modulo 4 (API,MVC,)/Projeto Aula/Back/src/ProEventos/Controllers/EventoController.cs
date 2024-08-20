using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;
namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class EventoController : Controller
    {
        public IEnumerable<Evento> _evento = new Evento[] {

            new Evento(){
                 EventoId = 1,
                Local = "Australia",
                DataEvento = DateTime.Now.AddDays(10).ToString(),
                Tema = "Curso de Full Stack",
                QtdPessoas = 100,
                Lote = "1 Lote",
                ImagemURL = "imagem1.jpg",
            },

             new Evento(){
                 EventoId = 2,
                Local = "Afeganistão",
                DataEvento = DateTime.Now.AddDays(10).ToString(),
                Tema = "Curso de Terrorismo",
                QtdPessoas = 200,
                Lote = "2 Lote",
                ImagemURL = "imagem2.jpg",
            }
        };
        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Evento com Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return "Evento com Put com id =" + id;
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "Evento com Delete com id = " + id;
        }
    }
}