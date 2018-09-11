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
    public partial class Frm_Listado_Pacientes : Form
    {
        #region variables 
        ConectarFalp CnnFalp;
        Configuration Config;
        string User = string.Empty;
        string[] Conexion = { "", "", "" };
        string PCK = "PCK_NUT001I";
        string PCK1 = "PCK_NUT001M";

        static string cod_paciente = "0";
        static string cod_tipo_comida ="0";
        static string cod_estado = "0";
        static string cod_servicio = "0";
        static DateTime Hoy;
        static string fecha_actual = "";
        #endregion 

        #region variables Datatable
        DataTable dt_pacientes = new DataTable();
        DataTable dt_tipo_comida = new DataTable();
        DataTable dt_estado = new DataTable();
        DataTable dt_servicio = new DataTable();
        DataTable dt_pedido_paciente = new DataTable();

        #endregion
       


        public Frm_Listado_Pacientes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            conectar();
            txtnombre.Focus();
       //     Cargar_dt_tipo_comida();

             Hoy = DateTime.Today;
             fecha_actual = Hoy.ToString("dd-MM-yyyy");
             
          
        }

        #region Cargar


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
            User = "SICI";
            LblUsuario.Text = "Usuario: " + User;
            //LblUsuario.Text = "Usuario: " + User;
            txtnombre.Focus();
        }

        #endregion

        #region Cargar Grilla

        #region Listar Grilla

        void Cargar_grilla_menu()
        {
            if (CnnFalp.Estado == ConnectionState.Closed) CnnFalp.Abrir();
            dt_pedido_paciente.Clear();
            CnnFalp.CrearCommand(CommandType.StoredProcedure, PCK + ".LISTADO_IMPRIMIR_VALE");
            CnnFalp.ParametroBD("PIN_COD_TIPO_MENU", cod_tipo_comida, DbType.Int32, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_NOMBRE", txtnombre.Text, DbType.String, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_COD_ESTADO", cod_estado, DbType.Int32, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_COD_SERVICIOS", cod_servicio, DbType.Int32, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_FECHA", txtfecha.Text, DbType.String, ParameterDirection.Input);


            dt_pedido_paciente.Load(CnnFalp.ExecuteReader());

            if (dt_pedido_paciente.Rows.Count > 0)
            {
                grilla_pedidos.AutoGenerateColumns = false;
                grilla_pedidos.DataSource = dt_pedido_paciente;
                ocultar_grilla_pedidos();

            }
            else
            {

            }

            CnnFalp.Cerrar();
         //   agrupar_celdas_menu();
            //ocultar_grilla_menu();
        }

        #endregion

        #region Agregar Imagen

        #endregion

        #region Agrupar Celdas

        void agrupar_celdas_menu()
        {
            int cont1 = 0;
            int cont2 = 0;
            int cont3 = 0;
            int cont4 = 0;
            int cont5 = 0;
            int cont6 = 0;     

          }

        #endregion


        #region Ocultar Columnas

        void ocultar_grilla_pedidos()
        {
            grilla_pedidos.AutoResizeColumns();

            grilla_pedidos.Columns["CORRELATIVO"].Visible = false;
            grilla_pedidos.Columns["COD_PEDIDO"].Visible = false;
            //grilla_menu.Columns["ELIMINAR"].Visible = false;
        }
        #endregion

        #region Ordenar Columnas

        #endregion

        #region Pintar Grilla

        private void grilla_pedidos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                e.PaintBackground(e.ClipBounds, false);
                Font drawFont = new Font("Trebuchet MS", 8, FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.White);
                StringFormat StrFormat = new StringFormat();
                StrFormat.Alignment = StringAlignment.Center;
                StrFormat.LineAlignment = StringAlignment.Center;

                e.Graphics.DrawImage(Properties.Resources.HeaderGV, e.CellBounds);
                e.Graphics.DrawString(grilla_pedidos.Columns[e.ColumnIndex].HeaderText, drawFont, drawBrush, e.CellBounds, StrFormat);

                e.Handled = true;
                drawBrush.Dispose();
            }
        }



        #endregion

        #region  Extraer grilla

        private void grilla_pedidos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0)
            {
                int cod_pedido = Convert.ToInt32(grilla_pedidos.Rows[e.RowIndex].Cells["COD_PEDIDO"].Value.ToString());
                string paciente = grilla_pedidos.Rows[e.RowIndex].Cells["NOM_PACIENTE"].Value.ToString();
                string fec = grilla_pedidos.Rows[e.RowIndex].Cells["FECHA_PEDIDO"].Value.ToString();
                if (e.ColumnIndex == 0)
                {
                    DialogResult opc = MessageBox.Show("Estimado usuario, Esta seguro de imprimir este vale", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (opc == DialogResult.Yes)
                    {

                        cod_paciente = grilla_pedidos.Rows[e.RowIndex].Cells["CORRELATIVO"].Value.ToString();
                      

                      /*  if (Convert.ToDateTime(fecha_actual) == Convert.ToDateTime(fec))
                        {*/

                            generar_informe(cod_paciente);
                            Guardar_paciente(cod_pedido);
                       /* }
                        else
                        {
                            MessageBox.Show("Estimado usuario, La Fecha no corresponde al pedido de Hoy", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }*/
                    }
                }

                else
                {
                    if (e.ColumnIndex == 1)
                    {

                        generar_informe_ingesta(cod_pedido);
                    }
                    else
                    {
                        if (e.ColumnIndex == 2)
                        {
                            Frm_Resumen_General_Ingesta f1 = new Frm_Resumen_General_Ingesta();
                            f1.Inicializa_general(cod_pedido,paciente,fec);
                            f1.Show();
                        }
                    }

                }

            }
            Cargar_grilla_menu();
        }

        #endregion 

        #endregion



        #endregion


        #region Botones

        private void Btn_tipo_comida_Click(object sender, EventArgs e)
        {
            txttipo_comida.Text = "";
            cod_tipo_comida ="0";
            Cargar_tipo_comida_lupa();
            if(txtnombre.Text!="" && cod_tipo_comida !="0")
            {
                txttipo_comida.Focus();
            }
            else{
                txtnombre.Focus();
            }
        }

        private void btn_estado_Click(object sender, EventArgs e)
        {
            txtestado.Text = "";
            cod_estado = "0";
            Cargar_estado_lupa();
            if (txtnombre.Text != "" && cod_tipo_comida != "0")
            {
                txtservicios.Focus();
            }
            else
            {
                txtestado.Focus();
            }
        }

        private void btn_servicio_Click(object sender, EventArgs e)
        {
            txtservicios.Text = "";
            cod_servicio = "0";
            Cargar_servicio_lupa();
            if (txtservicios.Text != "" && cod_servicio != "0")
            {
                btn_buscar.Focus();
            }
            else
            {
                txtservicios.Focus();
            }
        }

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            int co = 0;
            if (Validar_Campos())
            {

                if (dt_pedido_paciente.Rows.Count > 0)
                {
                    string f = fecha_actual;
                    ReporteParam Reporte = new ReporteParam();
                    Reporte.Base_de_Datos = Conexion[0];
                    Reporte.User_de_Datos = Conexion[1];
                    Reporte.Pass_de_Datos = Conexion[2];


                    Reporte.Ruta_Reporte = System.Windows.Forms.Application.StartupPath + @"/../Reportes/NUT001/Vale_general.rpt";
                    Reporte.GenerarParametro("PIN_COD_COMIDA", cod_tipo_comida);
                    Reporte.GenerarParametro("PIN_COD_PACIENTE", 0);
                    Reporte.GenerarParametro("PIN_FECHA", txtfecha.Text);
                    FrmImprime frmImpresion = new FrmImprime(Reporte);
                    frmImpresion.Show(this);

                    Guardar_paciente();
                    Cargar_grilla_menu();

                }
                else
                {

                    MessageBox.Show("Estimado usuario, No existen Paciente para la fecha Seleccionada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                      
                
            }
          
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (Validar_Campos())
            {
                Cargar_grilla_menu();
            }
        }

      
        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        #endregion

        #region Metodos

        #region Cargar tipo comida

        protected void Cargar_tipo_comida_lupa()
      {
          Cargar_datos_tipo_comida(ref Ayuda);

          if (!Ayuda.EOF())
          {
          
              cod_tipo_comida = Ayuda.Fields(0);
              txttipo_comida.Text = Ayuda.Fields(1);
          }


          Cargar_grilla_menu();
      }

        protected  void Cargar_datos_tipo_comida(ref AyudaSpreadNet.AyudaSprNet Ayuda)
      {
          string[] NomCol = { "Código", "Descripción" };
          int[] AnchoCol = { 80, 350 };
          Ayuda.Nombre_BD_Datos = Conexion[0];
          Ayuda.Pass = Conexion[1];
          Ayuda.User = Conexion[2];
          Ayuda.TipoBase = 1;
          Ayuda.NombreColumnas = NomCol;
          Ayuda.AnchoColumnas = AnchoCol;
          Ayuda.TituloConsulta = "Ingresar el Tipo Comida del Menú";
          Ayuda.Package = PCK;
          Ayuda.Procedimiento = "P_CARGAR_TIPO_COMIDA_VALE";
          Ayuda.Generar_ParametroBD("PIN_DESCRIPCION", txttipo_comida.Text, DbType.String, ParameterDirection.Input);
          Ayuda.EjecutarSql();

      }

        #endregion

        #region Cargar Estado

  
        protected void Cargar_estado_lupa()
        {
            Cargar_datos_estado(ref Ayuda);

            if (!Ayuda.EOF())
            {
                cod_estado = Ayuda.Fields(0);
                txtestado.Text = Ayuda.Fields(1);
            }


      
        }

        protected void Cargar_datos_estado(ref AyudaSpreadNet.AyudaSprNet Ayuda)
        {
            string[] NomCol = { "Código", "Descripción" };
            int[] AnchoCol = { 80, 350 };
            Ayuda.Nombre_BD_Datos = Conexion[0];
            Ayuda.Pass = Conexion[1];
            Ayuda.User = Conexion[2];
            Ayuda.TipoBase = 1;
            Ayuda.NombreColumnas = NomCol;
            Ayuda.AnchoColumnas = AnchoCol;
            Ayuda.TituloConsulta = "Ingresar el Estado";
            Ayuda.Package = PCK;
            Ayuda.Procedimiento = "P_CARGAR_TIPO_ESTADO";
            Ayuda.Generar_ParametroBD("PIN_DESCRIPCION", txtestado.Text, DbType.String, ParameterDirection.Input);
            Ayuda.EjecutarSql();

        }

        #endregion

        #region Cargar Servicio

  

        protected void Cargar_servicio_lupa()
        {
            Cargar_datos_servicio(ref Ayuda);

            if (!Ayuda.EOF())
            {
                cod_servicio = Ayuda.Fields(0);
                txtservicios.Text = Ayuda.Fields(1);
            }


        
        }

        protected void Cargar_datos_servicio(ref AyudaSpreadNet.AyudaSprNet Ayuda)
        {
            string[] NomCol = { "Código", "Descripción" };
            int[] AnchoCol = { 80, 350 };
            Ayuda.Nombre_BD_Datos = Conexion[0];
            Ayuda.Pass = Conexion[1];
            Ayuda.User = Conexion[2];
            Ayuda.TipoBase = 1;
            Ayuda.NombreColumnas = NomCol;
            Ayuda.AnchoColumnas = AnchoCol;
            Ayuda.TituloConsulta = "Ingresar el Servicio";
            Ayuda.Package = PCK;
            Ayuda.Procedimiento = "P_CARGAR_TIPO_SERVICIOS";
            Ayuda.Generar_ParametroBD("PIN_DESCRIPCION", txtservicios.Text, DbType.String, ParameterDirection.Input);
            Ayuda.EjecutarSql();

        }

        #endregion

        protected void generar_informe(string cod_paciente)
        {
            if (Validar_Campos())
            {

                ReporteParam Reporte = new ReporteParam();
                Reporte.Base_de_Datos = Conexion[0];
                Reporte.User_de_Datos = Conexion[1];
                Reporte.Pass_de_Datos = Conexion[2];


                Reporte.Ruta_Reporte = System.Windows.Forms.Application.StartupPath + @"/../Reportes/NUT001/Vale_general.rpt";
                Reporte.GenerarParametro("PIN_COD_COMIDA", cod_tipo_comida);
                Reporte.GenerarParametro("PIN_COD_PACIENTE", Convert.ToInt32(cod_paciente));
                Reporte.GenerarParametro("PIN_FECHA", txtfecha.Text);
                FrmImprime Frm = new FrmImprime(Reporte);
                Frm.Show(this);

            }
            Cargar_grilla_menu();
        }


        protected void generar_informe_ingesta(int cod_paciente)
        {
            if (Validar_Campos())
            {
                 

                ReporteParam Reporte = new ReporteParam();
                Reporte.Base_de_Datos = Conexion[0];
                Reporte.User_de_Datos = Conexion[1];
                Reporte.Pass_de_Datos = Conexion[2];


                Reporte.Ruta_Reporte = System.Windows.Forms.Application.StartupPath + @"/../Reportes/NUT001/Ingesta_general.rpt";

                Reporte.GenerarParametro("PIN_COD_PEDIDO", Convert.ToInt32(cod_paciente));
                Reporte.GenerarParametro("PIN_FECHA", txtfecha.Text);
                FrmImprime Frm = new FrmImprime(Reporte);
                Frm.Show(this);

            }
            Cargar_grilla_menu();
        }

        protected void Guardar_paciente(int cod_pedido)
        {

            
            if (CnnFalp.Estado == ConnectionState.Closed) CnnFalp.Abrir();

            CnnFalp.CrearCommand(CommandType.StoredProcedure, PCK1 + ".P_MODIFICAR_VALE_COLACION");
            CnnFalp.ParametroBD("PIN_TIPO", cod_tipo_comida, DbType.Int64, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_COD_PEDIDO", cod_pedido, DbType.Int64, ParameterDirection.Input);



            int registro = CnnFalp.ExecuteNonQuery();

            CnnFalp.Cerrar();

            if (registro > -2)
            {
                MessageBox.Show("Estimado usuario, El registro sea Modificado Correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Estimado usuario, Error el registro  no  sea Modificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        protected void Guardar_paciente()
        {

            string registro = "";

            if (dt_pedido_paciente.Rows.Count > 0)
            {
                if (CnnFalp.Estado == ConnectionState.Closed) CnnFalp.Abrir();

                foreach (DataRow miRow in dt_pedido_paciente.Rows)
                {

                    string cod_pedido = miRow["COD_PEDIDO"].ToString();

                    CnnFalp.CrearCommand(CommandType.StoredProcedure, PCK1 + ".P_MODIFICAR_VALE_COLACION");
                    CnnFalp.ParametroBD("PIN_TIPO", cod_tipo_comida, DbType.Int64, ParameterDirection.Input);
                    CnnFalp.ParametroBD("PIN_COD_PEDIDO", cod_pedido, DbType.Int64, ParameterDirection.Input);


                    registro = CnnFalp.ExecuteNonQuery().ToString();
                }


                CnnFalp.Cerrar();
                if (Convert.ToInt32(registro) > -2)
                {
                    MessageBox.Show("Estimado usuario, El registro sea Modificado Correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Estimado usuario, Error el registro  no  sea Modificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Estimado usuario, No existen Pacientes ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }


        #region Limpiar

        protected void Limpiar()
        {
            txtnombre.Text = "";
            cod_tipo_comida = "0";
            txttipo_comida.Text = "";
            txtestado.Text = "";
            cod_estado = "0";
            txtservicios.Text = "";
            cod_servicio = "0";
            dt_pedido_paciente.Clear();
            txtnombre.Focus();

        }

        private void CambiarBlanco_TextLeave(object sender, EventArgs e)
        {
            TextBox GB = (TextBox)sender;
            GB.BackColor = Color.White;

        }

        private void CambiarColor_TextEnter(object sender, EventArgs e)
        {
            TextBox GB = (TextBox)sender;
            GB.BackColor = Color.FromArgb(255, 224, 192);
        }


        #endregion 

     

        #endregion

      #region Validaciones

        protected Boolean Validar_Campos()
        {
            Boolean var = false;

            if (txtnombre.Text == "" && cod_tipo_comida == "0")
            {
                MessageBox.Show("Estimado usuario, El Campo Tipo Comida se encuentra vacio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var = true;
            }

            return var;
        }

        private void txttipo_comida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                e.Handled = true;
                return;
            }
            else
            {
               
                if (e.KeyChar == (char)13)
                {
                    Cargar_tipo_comida_lupa();
                    if (txtnombre.Text != "" && cod_tipo_comida!="0")
                    {

                        txttipo_comida.Focus();
                    
                    }
                    else
                    {
                        txtnombre.Focus();
                    }
                }
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtestado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                e.Handled = true;
                return;
            }
            else
            {
             
                if (e.KeyChar == (char)13)
                {
                    Cargar_estado_lupa();
                    if (txtestado.Text != "" && cod_estado != "0")
                    {
                       
                        txtservicios.Focus();
                    }
                    else
                    {
                        txtestado.Focus();
                    }
                }
            }
        }

        private void txtservicios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                e.Handled = true;
                return;
            }
            else
            {
          
                if (e.KeyChar == (char)13)
                {
                    Cargar_servicio_lupa();
                    if (txtservicios.Text != "" && cod_servicio != "0")
                    {                     
                        btn_buscar.Focus();
                    }
                    else
                    {
                        txtservicios.Text = "";

                    }
                }
            }
        }


      #endregion

     

      














      
      
   

     
     

      
    }
}
