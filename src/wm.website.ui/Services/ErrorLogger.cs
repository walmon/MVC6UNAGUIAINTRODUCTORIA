using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wm.website.ui.Services
{
    public class ErrorLogger : IErrorLogger
    {
        public bool init { get; set; } = false;
        public ErrorLogger()
        {
            // aqui puede inicializar cualquier componente interno
            init = true;
        }
        public void LogError(Exception ex)
        {
            // aqui se registrarían errores a la base de datos
        }
    }

    public interface IErrorLogger
    {
        void LogError(Exception ex);
    }
}
