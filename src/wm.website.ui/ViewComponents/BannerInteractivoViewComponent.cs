using Microsoft.AspNet.Mvc;
using System.Collections.Generic;
using System.Linq;
using wm.website.ui.Models;

namespace wm.website.ui.ViewComponents
{
    public class BannerInteractivoViewComponent : ViewComponent
    {
        List<Noticia> noticias = new List<Noticia>();
        NoticiasAppContext db;

        public BannerInteractivoViewComponent(NoticiasAppContext _context)
        {
            db = _context;
        }
        public IViewComponentResult Invoke()
        {
            
            // Limpiemos la base de datos
            if (db.Noticias.Count() > 0)
                db.Noticias.RemoveRange(db.Noticias);
            db.SaveChanges();

            // Recreemos los 3 archivos
            db.Noticias.AddRange(new List<Noticia>() {
                new Noticia() { Id=1, Titulo="Costa Rica en el puesto #13 de FIFA", Descripcion="Est porta ac magna lundium? Amet eros. Lorem cum ut auctor vel integer mus tortor, adipiscing platea penatibus, in placerat, lectus adipiscing! Ultrices scelerisque adipiscing parturient!" },
                new Noticia() { Id=1, Titulo="Nuevo ASP.NET 5", Descripcion="Est porta ac magna lundium? Amet eros. Lorem cum ut auctor vel integer mus tortor, adipiscing platea penatibus, in placerat, lectus adipiscing! Ultrices scelerisque adipiscing parturient!" },
                new Noticia() { Id=1, Titulo="¡Hololens está aquí!", Descripcion="Est porta ac magna lundium? Amet eros. Lorem cum ut auctor vel integer mus tortor, adipiscing platea penatibus, in placerat, lectus adipiscing! Ultrices scelerisque adipiscing parturient!" }
            });
            db.SaveChanges();

            return View(db.Noticias.ToList());
        }
    }


}
