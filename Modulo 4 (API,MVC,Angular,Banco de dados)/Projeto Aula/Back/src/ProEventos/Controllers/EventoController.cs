using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.Models;
using ProEventos.Data;
namespace ProEventos.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class EventoController : Controller
    {
        private readonly DataContext _context;

        public EventoController(DataContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return this._context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento Get(int id)
        {
            return this._context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
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