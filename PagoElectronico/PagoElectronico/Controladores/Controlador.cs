using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Controladores
{
    class Controlador
    {
        public interface Listener
        {
            void onCreateFinished(int code, String msg);
            void onCreateError(int code, String msg);
        }

    }
}
