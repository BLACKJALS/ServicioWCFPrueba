using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioTutorial.Servicios {
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioPrueba" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioPrueba {
        [OperationContract]
        void cargaPruebaExcel(FileStream file);

        [OperationContract]
        string enviarCorreo(string correo);
    }
}
