using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using System.Text.RegularExpressions;
using System.Configuration;

namespace PreparacionDroga
{
    public partial class FrmImprime : Form
    {
        ReporteParam Reporte;
        PrinterSettings Impresora;
        PageSettings Pagina;
        //PrintOptions Opciones;
        IWin32Window Formulario;
        ReportDocument reporte; 
        int Pordonde;

        public FrmImprime(ReporteParam ReporteActivo)
        {
            InitializeComponent();
            //this.Reporte = Rpt;
            //this.Pref = V_Variable;
            Reporte = ReporteActivo;
            Pordonde = 1;
            CargaRpt();
        }

        public FrmImprime(ReporteParam ReporteActivo, IWin32Window Form)
        {
            InitializeComponent();
            //this.Reporte = Rpt;
            //this.Pref = V_Variable;
            Reporte = ReporteActivo;
            Formulario = Form;
            Pordonde = 2;
            CargaRpt();
        }

        public FrmImprime(ReporteParam ReporteActivo,string NombreImpresora,IWin32Window Form)
        {
            InitializeComponent();
            //this.Reporte = Rpt;
            //this.Pref = V_Variable;
            Reporte = ReporteActivo;
            if (NombreImpresora != null)
            {
                Impresora = new PrinterSettings();
                Impresora.PrinterName = NombreImpresora;
                // Opciones = new PrintOptions();
                // Opciones.PrinterName = NombreImpresora; 

                Pagina = new PageSettings();
                Pagina.PrinterSettings = Impresora;
                Formulario = Form;
                Pordonde = 2;
            }
            CargaRpt();
        }

        private void CargaRpt()
        {
            
            reporte = new ReportDocument();
            try
            {
               // ReportDocument reporte = new ReportDocument();
                //reporte.Close();
                //reporte.
                string RutaRpt = Reporte.Ruta_Reporte;// "C:/Reportes/" + Reporte;
                reporte.Load(RutaRpt);

                ConnectionInfo CnnReport = new ConnectionInfo();
                Tables MyTablas = reporte.Database.Tables;

                CnnReport.ServerName = Reporte.Base_de_Datos;
                CnnReport.UserID = Reporte.User_de_Datos;
                CnnReport.Password = Reporte.Pass_de_Datos;


                foreach (CrystalDecisions.CrystalReports.Engine.Table MyTabla in MyTablas)
                {
                    TableLogOnInfo Tbl_LoginInfo = MyTabla.LogOnInfo;
                    Tbl_LoginInfo.ConnectionInfo = CnnReport;
                    MyTabla.ApplyLogOnInfo(Tbl_LoginInfo);
                }

                ParameterDiscreteValue NewParamVal = new CrystalDecisions.Shared.ParameterDiscreteValue();
                ParameterValues CurrParamVal;

                //Busca automaticamente tdos los parametros de entrada includo los parametros de los subreportes
                for (int intI = 0; (intI <= reporte.DataDefinition.ParameterFields.Count - 1); intI++)
                {
                    if (reporte.ParameterFields[intI].ReportParameterType != ParameterType.ReportParameter)
                    {
                        string nombre = reporte.DataDefinition.ParameterFields[intI].Name;
                        string X = reporte.DataDefinition.ParameterFields[intI].ValueType.ToString();
                        NewParamVal.Value = Reporte.Rpt_RetornaValorParam(nombre);
                        NewParamVal.Description = nombre;
                        CurrParamVal = reporte.DataDefinition.ParameterFields[intI].CurrentValues;
                        CurrParamVal.Clear();
                        CurrParamVal.Add(NewParamVal);
                        reporte.DataDefinition.ParameterFields[intI].ApplyCurrentValues(CurrParamVal);
                    }
                }

                if (Pordonde == 1)
                {
                    CRV.ReportSource = reporte;  // Asigno los resultados del reporte al Visor de Crystal Report
                }
                else
                {
                    if (Formulario == null)
                    {
                        if (Impresora == null) 
                        {
                            reporte.PrintToPrinter(1, false, 0, 0); //copies, collated, startpage, endpage
                         }
                        else
                            reporte.PrintToPrinter(Impresora, Pagina, false);
                        return;
                    }
                    else
                    {
                        CRV.ReportSource = reporte;
                        this.Show(Formulario);
                    }
                }
                //reporte.Close();
            }
            catch(Exception er)
            {
                reporte = null; 
                Reporte = null;
                MessageBox.Show("Error: " + er.Message);
                return;
            }

        }

        private void CRV_Load(object sender, EventArgs e)
        {

        }

        private void FrmImprime_Load(object sender, EventArgs e)
        {

        }

        private void FrmImprime_FormClosed(object sender, FormClosedEventArgs e)
        
        {
            reporte.Close();
            reporte.Dispose();
            //CRV.Dispose();
        }

    }

    public partial class ReporteParam
    { 
        public ReporteParam()
        {
        
        }

        System.Collections.Generic.List<ParamReporte> Datos = new List<ParamReporte>();

        string v_Base_de_Datos;

        public string Base_de_Datos
        {
            get { return v_Base_de_Datos; }
            set { v_Base_de_Datos = value; }
        }
        string v_User_de_Datos;

        public string User_de_Datos
        {
            get { return v_User_de_Datos; }
            set { v_User_de_Datos = value; }
        }
        string v_Pass_de_Datos;

        public string Pass_de_Datos
        {
            get { return v_Pass_de_Datos; }
            set { v_Pass_de_Datos = value; }
        }

        string v_Ruta_Reporte;
        /// <summary>
        /// Se debe Indicar la Ruta completa del Reporte (Source Ej: C:\miaplicacion\reporte\ejemplo.rpt)
        /// </summary>
        public string Ruta_Reporte
        {
            get { return v_Ruta_Reporte; }
            set { v_Ruta_Reporte = value; }
        }
        /// <summary>
        /// Procedimiento que crea los parametros para ser usados en el Reporte
        /// </summary>
        /// <param name="Nombre">Este nombre debe ser el mismo que se utiliza como parametro de ingreso a la BD.</param>
        /// <param name="Valor">Valor que adquiere el parametro</param>
        public void GenerarParametro(string Nombre, object Valor)
        {
            ParamReporte Param = new ParamReporte(Nombre, Valor);
            ExisteParam(Nombre, Valor);
            Datos.Add(Param);
            
        }

        private bool ExisteParam(string Nombre, object Valor)
        {
            foreach (ParamReporte PR in Datos)
            {
                if (PR.NombreParam.ToUpper() == Nombre.ToUpper())
                {
                     Datos.Remove(PR);
                     return true;
                }
            }
            return false;
        }

        public object Rpt_RetornaValorParam(string Nombre)
        {

            foreach (ParamReporte PR in Datos)
            {
                if (PR.NombreParam.ToUpper() == Nombre.ToUpper())
                {
                    return PR.ValorParam;
                }
            }
            return null;
        }

        private class ParamReporte
        { 
            public ParamReporte(string Nombre,object Valor)
            {
                v_NombreParam = Nombre;
                v_ValorParam = Valor;
            }

            string v_NombreParam;

            public string NombreParam
            {
                get { return v_NombreParam; }
            }
            object v_ValorParam;

            public object ValorParam
            {
                get { return v_ValorParam; }                
            }
        }
    }

   /* public partial class ImpresoraUtilizada
    {
        private PrinterSettings impresora;



        public PrinterSettings Impresora
        {
            get { return impresora; }
            set { impresora = value; }
        }

        private void AsignaParametros()
        {
            impresora.PrinterName = "";
        }

    }*/
}
