using ModelAppGestor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelAppGestor
{
    class StaticData2
    {
        List<PROGRAMA> programas = new List<PROGRAMA>
        {
            new PROGRAMA
            {
                CODIGO = 7,
                CODIGOCAT = 2,
                NOMBRE = "Open Office",
                PLATAFORMA = "Windows",
                VERSION = "12345",
                DESCARGAS = 34523,
                HOST = "https://netcologne.dl.sourceforge.net/project/openofficeorg.mirror/4.1.3/binaries/es/Apache_OpenOffice_4.1.3_Win_x86_install_es.exe",
                INSTALADO = false,
            },
             new PROGRAMA
            {
                CODIGO = 8,
                CODIGOCAT = 2,
                NOMBRE = "Kingston Office",
                PLATAFORMA = "Windows",
                VERSION = "12345",
                DESCARGAS = 34523,
                HOST = "http://www.kingsoftstore.com/download/setup_wps_office_2016.exe",
                INSTALADO = false,
            },
              new PROGRAMA
            {
                CODIGO = 9,
                CODIGOCAT = 2,
                NOMBRE = "Polaris Office",
                PLATAFORMA = "Windows",
                VERSION = "12345",
                DESCARGAS = 34523,
                HOST = "http://install.polarisoffice.com/pcoffice/PolarisOfficeInstaller.exe",
                INSTALADO = false,
            },
               new PROGRAMA
            {
                CODIGO = 10,
                CODIGOCAT = 4,
                NOMBRE = "NetBeans",
                PLATAFORMA = "Windows",
                VERSION = "12345",
                DESCARGAS = 34523,
                HOST = "http://download.netbeans.org/netbeans/8.2/final/bundles/netbeans-8.2-windows.exe",
                INSTALADO = false,
            },
                  new PROGRAMA
            {
                CODIGO = 11,
                CODIGOCAT = 4,
                NOMBRE = "SublimeText",
                PLATAFORMA = "Windows",
                VERSION = "12345",
                DESCARGAS = 34523,
                HOST = "https://download.sublimetext.com/Sublime%20Text%20Build%203126%20x64%20Setup.exe",
                INSTALADO = false,
            },
        };

    }
}
