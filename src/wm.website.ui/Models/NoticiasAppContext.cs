using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wm.website.ui.Models
{
    public class NoticiasAppContext : DbContext
    {
        public DbSet<Noticia> Noticias { get; set; }   
    }
}
