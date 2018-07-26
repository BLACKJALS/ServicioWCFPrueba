using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioTutorial.Servicios {
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioPrueba" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioPrueba.svc o ServicioPrueba.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioPrueba : IServicioPrueba {
        public void cargaPruebaExcel(FileStream file) {
            var prueba = file;
        }

        public string enviarCorreo(string correo) {
            return correo;
        }
    }
}
