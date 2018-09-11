using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PreparacionDroga;
using System.Configuration;

namespace Vales_Colacion
{
    public partial class Frm_Resumen_General_Ingesta : Form
    {
        int cod_pedido = 0;
        ConectarFalp CnnFalp;
        Configuration Config;
        string User = string.Empty;
        string[] Conexion = { "", "", "" };
        string PCK = "PCK_NUT001I";
        string PCK1 = "PCK_NUT001M";
        public Frm_Resumen_General_Ingesta()
        {
            InitializeComponent();
        }

        private void Frm_Resumen_General_Ingesta_Load(object sender, EventArgs e)
        {

        }


        #region Cargar Conexion

        void conectar()
        {

            if (!(CnnFalp != null))
            {

                ExeConfigurationFileMap FileMap = new ExeConfigurationFileMap();
                FileMap.ExeConfigFilename = Application.StartupPath + @"\..\WF.config";
                Config = ConfigurationManager.OpenMappedExeConfiguration(FileMap, ConfigurationUserLevel.None);

                CnnFalp = new ConectarFalp(Config.AppSettings.Settings["dbServer"].Value,//ConfigurationManager.AppSettings["dbServer"],
                                           Config.AppSettings.Settings["dbUser"].Value,//ConfigurationManager.AppSettings["dbUser"],
                                           Config.AppSettings.Settings["dbPass"].Value,//ConfigurationManager.AppSettings["dbPass"],
                                           ConectarFalp.TipoBase.Oracle);

                if (CnnFalp.Estado == ConnectionState.Closed) CnnFalp.Abrir(); // abre la conexion

                Conexion[0] = Config.AppSettings.Settings["dbServer"].Value;
                Conexion[1] = Config.AppSettings.Settings["dbUser"].Value;
                Conexion[2] = Config.AppSettings.Settings["dbPass"].Value;
            }



            // this.Text = this.Text + " [Versión: " + Application.ProductVersion + "] [Conectado: " + Conexion[0] + "]";
            //User = ValidaMenu.LeeUsuarioMenu();
      
        }

        #endregion


        public void Inicializa_general(int cod_ped, string nom_paciente,string fecha)
        {
            conectar();
            txtpac.Text = nom_paciente;
            txtfec.Text = fecha;
            cod_pedido = cod_ped;

        }

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            ReporteParam Reporte = new ReporteParam();
            Reporte.Base_de_Datos = Conexion[0];
            Reporte.User_de_Datos = Conexion[1];
            Reporte.Pass_de_Datos = Conexion[2];


            Reporte.Ruta_Reporte = System.Windows.Forms.Application.StartupPath + @"/../Reportes/NUT001/Resumen_General_Paciente.rpt";

            Reporte.GenerarParametro("PIN_COD_PEDIDO", Convert.ToInt32(cod_pedido));
            FrmImprime Frm = new FrmImprime(Reporte);
            Frm.Show(this);
        }

   
    }
}
