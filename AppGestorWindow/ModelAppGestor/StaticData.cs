using ModelAppGestor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelAppGestor
{
    public class StaticData
    {
        public List<PROGRAMA> Programas = new List<PROGRAMA>
        {
            new PROGRAMA
            {
                CODIGO = 1,
                CODIGOCAT = 1,
                NOMBRE = "Google Chrome",
                PLATAFORMA = "Windows",
                VERSION = "123",
                DESCARGAS = 51694,
                HOST = "https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7B715541E4-C4ED-0051-7499-4650426ACE55%7D%26lang%3Des%26browser%3D4%26usagestats%3D0%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers%26ap%3Dx64-stable-statsdef_1%26installdataindex%3Ddefaultbrowser/update2/installers/ChromeSetup.exe",
                INSTALADO = true
            },
            new PROGRAMA
            {
                CODIGO = 2,
                CODIGOCAT = 1,
                NOMBRE = "Mozilla Firefox",
                PLATAFORMA = "Windows",
                VERSION = "35",
                DESCARGAS = 8515,
                HOST = "https://stubdownloader.cdn.mozilla.net/builds/firefox-stub/es-ES/win/1a0ea6e1034ded05fc3a0948f826574e58bbc474a69ba2e07b662a6b7b316e18/Firefox%20Setup%20Stub%2051.0.1.exe",
                INSTALADO = true
            },
            new PROGRAMA
            {
                CODIGO = 3,
                CODIGOCAT = 1,
                NOMBRE = "Opera",
                PLATAFORMA = "Windows",
                VERSION = "94",
                DESCARGAS = 794,
                HOST = "http://net.geo.opera.com/opera/stable/windows?http_referrer=https://www.google.es/&utm_source=google_via_opera_com&utm_medium=ose&utm_campaign=google_ose_via_opera_com",
                INSTALADO = false
            },
            new PROGRAMA
            {
                CODIGO = 4,
                CODIGOCAT = 2,
                NOMBRE = "Avira",
                PLATAFORMA = "Windows",
                VERSION = "56",
                DESCARGAS = 2814,
                HOST = "https://package.avira.com/package/oeavira/win/int/avira_es_fass0_58b856bd9ac86__ws.exe",
                INSTALADO = false
            },
            new PROGRAMA
            {
                CODIGO = 5,
                CODIGOCAT = 2,
                NOMBRE = "AVG",
                PLATAFORMA = "Windows",
                VERSION = "84",
                DESCARGAS = 12546,
                HOST = "http://files-download.avg.com/inst/mp/AVG_Protection_Free_698.exe",
                INSTALADO = false
            },
            new PROGRAMA
            {
                CODIGO = 6,
                CODIGOCAT = 2,
                NOMBRE = "Avast",
                PLATAFORMA = "Windows",
                VERSION = "126",
                DESCARGAS = 954842,
                HOST = "http://files.avast.com/iavs9x/avast_free_antivirus_setup_online.exe",
                INSTALADO = true
            },
            new PROGRAMA
            {
                CODIGO = 7,
                CODIGOCAT = 3,
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
                CODIGOCAT = 3,
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
                CODIGOCAT = 3,
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
            }
        };

        public List<CATEGORIA> Categorias = new List<CATEGORIA>
        {
            new CATEGORIA
            {
                CODCATEGORIA = 1,
                NOMCATEGORIA = "Internet"
            },
            new CATEGORIA
            {
                CODCATEGORIA = 2,
                NOMCATEGORIA = "Antivirus"
            },
            new CATEGORIA
            {
                CODCATEGORIA = 3,
                NOMCATEGORIA = "Ofimatica"
            },
            new CATEGORIA
            {
                CODCATEGORIA = 4,
                NOMCATEGORIA = "Programacion"
            },
            new CATEGORIA
            {
                CODCATEGORIA = 5,
                NOMCATEGORIA = "Juegos"
            }
        };
    }
}
