using System;
using System.Collections.Generic;

namespace SistemaPromocao.Models
{
    public class SistemaViewModel
    {
        public List<Promotor> Promotores { get; set; }
        public List<Escritor> Escritores { get; set; }
        public List<Bodybuilder> Bodybuilders { get; set; }
        public List<Vlogger> Vloggers { get; set; }
    }
}

