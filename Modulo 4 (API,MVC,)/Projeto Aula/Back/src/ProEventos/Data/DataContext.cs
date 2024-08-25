using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEventos.Models;

namespace ProEventos.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DataContextOptions<DataContext> options) : base(options)
        {

        }

        public Dbset<Evento> Eventos { get; set; }
    }
}