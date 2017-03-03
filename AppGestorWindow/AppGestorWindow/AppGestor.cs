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
        private BindingList<ProgramaDTO> programasInternet;
        private BindingList<ProgramaDTO> programasAntivirus;
        private BindingList<ProgramaDTO> programasOfimatica;
        private BindingList<ProgramaDTO> programasProgramacion;
        private BindingList<ProgramaDTO> programasJuegos;

        public AppGestor()
        {
            InitializeComponent();
            
        }

        private void AppGestor_Load(object sender, EventArgs e)
        {
            programasInstalados = ctlrPrograma.GetProgramsInstalled(true);
            programasInternet = ctlrPrograma.GetProgramsByCategory(1);
            programasAntivirus = ctlrPrograma.GetProgramsByCategory(2);
            programasOfimatica = ctlrPrograma.GetProgramsByCategory(3);
            programasProgramacion = ctlrPrograma.GetProgramsByCategory(4);
            programasJuegos = ctlrPrograma.GetProgramsByCategory(5);

            dgvAppInstalled.DataSource = programasInstalados;
            dgvAppInternet.DataSource = programasInternet;
            dgvAppAntivirus.DataSource = programasAntivirus;
            dgvAppOfimatica.DataSource = programasOfimatica;
            dgvAppProgramacion.DataSource = programasProgramacion;
            dgvAppJuegos.DataSource = programasJuegos;

            ColumnsAppsInstalled();
            ColumnsAppsNotInstalled(dgvAppInternet);
            ColumnsAppsNotInstalled(dgvAppAntivirus);
            ColumnsAppsNotInstalled(dgvAppOfimatica);
            ColumnsAppsNotInstalled(dgvAppProgramacion);
            ColumnsAppsNotInstalled(dgvAppJuegos);
        }

        private void ColumnsAppsInstalled()
        {
            string[] columnas = new string[] { "NOMBRE", "VERSION" };
            foreach (DataGridViewColumn item in dgvAppInstalled.Columns)
            {
                FormatDataGridViewColumns(item, columnas, 150);
            }
        }

        private void ColumnsAppsNotInstalled(DataGridView dgvApps)
        {
            string[] columnas = new string[] { "NOMBRE", "VERSION", "DESCARGAS", "PLATAFORMA"};
            foreach (DataGridViewColumn item in dgvApps.Columns)
            {
                FormatDataGridViewColumns(item, columnas, 230);
            }
        }

        private void FormatDataGridViewColumns(DataGridViewColumn item, string[] columns, int width)
        {
            if (columns.Contains(item.Name))
            {
                item.Visible = true;
                item.ReadOnly = true;
                item.Width = width;
            }
            else
            {
                item.Visible = false;
            }
        }

        private void EventCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ProgramaDTO prog = new ProgramaDTO();
                prog.CODIGO = (int)dgvAppInstalled.Rows[e.RowIndex].Cells["CODIGO"].Value;
                prog.CODIGOCAT = (int)dgvAppInstalled.Rows[e.RowIndex].Cells["CODIGOCAT"].Value;
                prog.DESCARGAS = (int)dgvAppInstalled.Rows[e.RowIndex].Cells["DESCARGAS"].Value;
                prog.HOST = dgvAppInstalled.Rows[e.RowIndex].Cells["HOST"].Value.ToString();
                prog.NOMBRE = dgvAppInstalled.Rows[e.RowIndex].Cells["NOMBRE"].Value.ToString();
                prog.PLATAFORMA = dgvAppInstalled.Rows[e.RowIndex].Cells["PLATAFORMA"].Value.ToString();
                prog.VERSION = dgvAppInstalled.Rows[e.RowIndex].Cells["VERSION"].Value.ToString();
                prog.INSTALADO = Boolean.Parse(dgvAppInstalled.Rows[e.RowIndex].Cells["INSTALADO"].Value.ToString());
                DownloadWindow form = new DownloadWindow(prog);
                form.ShowDialog();
            }
        }
        
    }
}

