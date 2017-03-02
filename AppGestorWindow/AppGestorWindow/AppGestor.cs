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
            initializeGrid();
        }

        private void initializeGrid()
        {
            
            foreach (DataGridViewColumn item in dgvAppInstalled.Columns)
            {
                switch (item.Name)
                {

                    case "NOMBRE":
                        item.Visible = true;
                        break;
                    case "DESCARGAS":
                        item.Visible = true;
                        item.ReadOnly = true;
                        break;

                    default:
                        item.Visible = false;
                        break;

                }
            }
        }

        private void metroGrid1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0)
            {
                ProgramaDTO pog = new ProgramaDTO();
                pog.CODIGO = (int)dgvAppInstalled.Rows[e.RowIndex].Cells["CODIGO"].Value;
                pog.CODIGOCAT = (int)dgvAppInstalled.Rows[e.RowIndex].Cells["CODIGOCAT"].Value;
                pog.DESCARGAS = (int)dgvAppInstalled.Rows[e.RowIndex].Cells["DESCARGAS"].Value;
                pog.HOST = dgvAppInstalled.Rows[e.RowIndex].Cells["HOST"].Value.ToString();
                pog.NOMBRE = dgvAppInstalled.Rows[e.RowIndex].Cells["NOMBRE"].Value.ToString();
                pog.PLATAFORMA = dgvAppInstalled.Rows[e.RowIndex].Cells["PLATAFORMA"].Value.ToString();
                pog.VERSION = dgvAppInstalled.Rows[e.RowIndex].Cells["VERSION"].Value.ToString();
                pog.INSTALADO = Boolean.Parse(dgvAppInstalled.Rows[e.RowIndex].Cells["INSTALADO"].Value.ToString());
                DownloadWindow form = new DownloadWindow(pog);
                form.ShowDialog();




               
            }
           
        }
    }
}

