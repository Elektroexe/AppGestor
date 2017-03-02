using MetroFramework.Forms;
using ModelAppGestor.Business;
using ModelAppGestor.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestorWindow
{
    public partial class AppGestor : MetroForm
    {
        private cProgramas ctlrPrograma = new cProgramas();
        private BindingList<ProgramaDTO> programasInstalados;

        public AppGestor()
        {
            InitializeComponent();
            
        }

        private void AppGestor_Load(object sender, EventArgs e)
        {
            programasInstalados = ctlrPrograma.GetAllProgramas();
            dgvAppInstalled.DataSource = programasInstalados;
        }
    }
}
