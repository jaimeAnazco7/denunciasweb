using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace denunciasWeb
{
    public partial class DenunciaP_DU : System.Web.UI.Page
    {
        public string state = "collapse";

        string denCodigo;
        string pesonaNaturalCodigo;
        int anonimo = 0;


        int uno = 1;
        int dos = 1;
        int tres = 1;
        int cuatro = 1;
        int cinco = 1;
        int seis = 1;
        int siete = 1;
        int ocho = 1;




        protected void Page_Load(object sender, EventArgs e)
        {


            lblDenCodigo.Visible = false;
            lblPersonaNaturalCodigo.Visible = false;
            rbAnonimo.Visible = false;





            int uno = 0;
            int dos = uno + 1;
            int tres = dos + 1;
            int cuatro = tres + 1;
            int cinco = cuatro + 1;
            int seis = cinco + 1;
            int siete = seis + 1;
            int ocho = siete + 1;

            // MultiView1.SetActiveView(View1);

            ClientScript.RegisterStartupScript(GetType(), "Javascript", "setState(); ", true);



            #region cnoexobtenerdencodigo


            SqlConnection cnx_1 = new SqlConnection(ConfigurationManager.ConnectionStrings["BDDigemidConnection"].ConnectionString);
            //SqlConnection cnx_1 = new SqlConnection();
            SqlCommand cmd_1 = new SqlCommand();

           // cnx_1.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=jañazco;Password=J09679933";

         //   cnx_1.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=usrAppdenuncia;Password=Ykn42Ks3Wf";

            cnx_1.Open();
            cmd_1.Connection = cnx_1;
            cmd_1.CommandType = CommandType.StoredProcedure;
            cmd_1.CommandText = "dbo.SP_SI_Obtiene_Numerador";



            //EXEC USP_SI_Obtiene_Numerador '000', 'VG', '09', 'R', '01', 'N'




            cmd_1.Parameters.Add("@DSACODIGO", SqlDbType.VarChar).Value = "000";
            cmd_1.Parameters.Add("@MODCODIGO", SqlDbType.VarChar).Value = "VG";
            cmd_1.Parameters.Add("@PROCODIGO", SqlDbType.VarChar).Value = "09";
            cmd_1.Parameters.Add("@CPMTIPO", SqlDbType.VarChar).Value = "R";
            cmd_1.Parameters.Add("@CPMCODIGO", SqlDbType.VarChar).Value = "01";
            cmd_1.Parameters.Add("@PRCCODIGO", SqlDbType.VarChar).Value = "N";

            cmd_1.Parameters.Add("@CNUMERADOR", SqlDbType.VarChar).Value = "000";
            cmd_1.Parameters["@CNUMERADOR"].Direction = ParameterDirection.Output;
            cmd_1.Parameters["@CNUMERADOR"].Size = 100;

            cmd_1.ExecuteScalar();


            denCodigo = cmd_1.Parameters["@CNUMERADOR"].Value.ToString();


            lblDenCodigo.Text = denCodigo;
            #endregion












            #region cnoexobtenerpersonaNAturalcodigo

            SqlConnection cnx_2 = new SqlConnection(ConfigurationManager.ConnectionStrings["BDDigemidConnection"].ConnectionString);

            //SqlConnection cnx_2 = new SqlConnection();
            SqlCommand cmd_2 = new SqlCommand();

           // cnx_2.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=jañazco;Password=J09679933";

           // cnx_2.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=usrAppdenuncia;Password=Ykn42Ks3Wf";



            cnx_2.Open();
            cmd_2.Connection = cnx_1;
            cmd_2.CommandType = CommandType.StoredProcedure;
            cmd_2.CommandText = "dbo.SP_SI_Obtiene_Numerador";



            //EXEC USP_SI_Obtiene_Numerador '000', 'ET', '13', 'R', '01', 'N'




            cmd_2.Parameters.Add("@DSACODIGO", SqlDbType.VarChar).Value = "000";
            cmd_2.Parameters.Add("@MODCODIGO", SqlDbType.VarChar).Value = "ET";
            cmd_2.Parameters.Add("@PROCODIGO", SqlDbType.VarChar).Value = "13";
            cmd_2.Parameters.Add("@CPMTIPO", SqlDbType.VarChar).Value = "R";
            cmd_2.Parameters.Add("@CPMCODIGO", SqlDbType.VarChar).Value = "01";
            cmd_2.Parameters.Add("@PRCCODIGO", SqlDbType.VarChar).Value = "N";

            cmd_2.Parameters.Add("@CNUMERADOR", SqlDbType.VarChar).Value = "000";
            cmd_2.Parameters["@CNUMERADOR"].Direction = ParameterDirection.Output;
            cmd_2.Parameters["@CNUMERADOR"].Size = 100;

            cmd_2.ExecuteScalar();


            pesonaNaturalCodigo = cmd_2.Parameters["@CNUMERADOR"].Value.ToString();


            lblPersonaNaturalCodigo.Text = pesonaNaturalCodigo;
            #endregion








            ddlDepartamentoPN.Attributes.Add("onchange", "setCookie('collapse2');");













            // ddlTest.Attributes.Add("onchange", "showhide(this);");








            txtFechaRegistro.Text = DateTime.Now.ToString();
            txtFechaRegistro.Enabled = false;

            if (!Page.IsPostBack)
            {


                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

               // SqlConnection con = new SqlConnection(@"Data Source=192.168.78.27\MSSQLSERVER2018;Initial Catalog=db_denunciasWeb;Persist Security Info=True;User ID=sa;Password=J@m09679933");


               // SqlConnection con = new SqlConnection(@"Data Source=Digemid556\MSSQLSERVER2018;Initial Catalog=db_denunciasWeb;Persist Security Info=True;User ID=sa;Password=J@m09679933");
                //SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True");
                SqlCommand cmd = new SqlCommand("select * from cmmdepart", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                ddlDepartamento.DataSource = dt;
                ddlDepartamento.DataBind();

                ddlDepartamentoPN.DataSource = dt;
                ddlDepartamentoPN.DataBind();


                

                //DropDownList4.DataSource = dt;
                //DropDownList4.DataBind();

            }


        }


        protected void ddlDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlProvincia.Items.Clear();
            ddlProvincia.Items.Add("Seleccione Provincia");
            //DropDownList5.Items.Clear();
            //DropDownList5.Items.Add("Seleccione Provincia");


            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
           // SqlConnection con = new SqlConnection(@"Data Source=192.168.78.27\MSSQLSERVER2018;Initial Catalog=db_denunciasWeb;Persist Security Info=True;User ID=sa;Password=J@m09679933");


            //SqlConnection con = new SqlConnection(@"Data Source=Digemid556\MSSQLSERVER2018;Initial Catalog=db_denunciasWeb;Persist Security Info=True;User ID=sa;Password=J@m09679933");
            SqlCommand cmd = new SqlCommand("select * from cmmprovinc where dptcodigo=" + ddlDepartamento.SelectedItem.Value, con);
            //SqlCommand cmd = new SqlCommand("select * from cmmprovinc where dptcodigo=" + DropDownList4.SelectedItem.Value, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ddlProvincia.DataSource = dt;
            ddlProvincia.DataBind();

            //DropDownList5.DataSource = dt;
            //DropDownList5.DataBind();
        }






        protected void ddlDepartamentoPN_SelectedIndexChanged(object sender, EventArgs e)
        {
            state = "expand";
            ddlProvinciaPN.Items.Clear();
            ddlProvinciaPN.Items.Add("Seleccione Provincia");
            //DropDownList5.Items.Clear();
            //DropDownList5.Items.Add("Seleccione Provincia");

           // SqlConnection con = new SqlConnection(@"Data Source=192.168.78.27\MSSQLSERVER2018;Initial Catalog=db_denunciasWeb;Persist Security Info=True;User ID=sa;Password=J@m09679933");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            // SqlConnection con = new SqlConnection(@"Data Source=Digemid556\MSSQLSERVER2018;Initial Catalog=db_denunciasWeb;Persist Security Info=True;User ID=sa;Password=J@m09679933");
            SqlCommand cmd = new SqlCommand("select * from cmmprovinc where dptcodigo=" + ddlDepartamentoPN.SelectedItem.Value, con);
            //SqlCommand cmd = new SqlCommand("select * from cmmprovinc where dptcodigo=" + DropDownList4.SelectedItem.Value, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ddlProvinciaPN.DataSource = dt;
            ddlProvinciaPN.DataBind();

            //DropDownList5.DataSource = dt;
            //DropDownList5.DataBind();
        }



























        protected void ddlProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlDistrito.Items.Clear();
            ddlDistrito.Items.Add("Seleccione Distrito");

            //DropDownList6.Items.Clear();
            //DropDownList6.Items.Add("Seleccione Distrito");

            //SqlConnection con = new SqlConnection(@"Data Source=192.168.78.27\MSSQLSERVER2018;Initial Catalog=db_denunciasWeb;Persist Security Info=True;User ID=sa;Password=J@m09679933");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            // SqlConnection con = new SqlConnection(@"Data Source=Digemid556\MSSQLSERVER2018;Initial Catalog=db_denunciasWeb;Persist Security Info=True;User ID=sa;Password=J@m09679933");
            SqlCommand cmd = new SqlCommand("select * from cmmdistrito where prvcodigo=" + ddlProvincia.SelectedItem.Value + "and dptcodigo=" + ddlDepartamento.SelectedItem.Value, con);
            //SqlCommand cmd = new SqlCommand("select * from cmmdistrito where prvcodigo=" + DropDownList5.SelectedItem.Value + "and dptcodigo=" + DropDownList4.SelectedItem.Value, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            ddlDistrito.DataSource = dt;
            ddlDistrito.DataBind();

            //DropDownList6.DataSource = dt;
            //DropDownList6.DataBind();

        }




        protected void ddlProvinciaPN_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlDistritoPN.Items.Clear();
            ddlDistritoPN.Items.Add("Seleccione Distrito");

            //DropDownList6.Items.Clear();
            //DropDownList6.Items.Add("Seleccione Distrito");

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
           // SqlConnection con = new SqlConnection(@"Data Source=192.168.78.27\MSSQLSERVER2018;Initial Catalog=db_denunciasWeb;Persist Security Info=True;User ID=sa;Password=J@m09679933");

           // SqlConnection con = new SqlConnection(@"Data Source=Digemid556\MSSQLSERVER2018;Initial Catalog=db_denunciasWeb;Persist Security Info=True;User ID=sa;Password=J@m09679933");
            SqlCommand cmd = new SqlCommand("select * from cmmdistrito where prvcodigo=" + ddlProvinciaPN.SelectedItem.Value + "and dptcodigo=" + ddlDepartamentoPN.SelectedItem.Value, con);
            //SqlCommand cmd = new SqlCommand("select * from cmmdistrito where prvcodigo=" + DropDownList5.SelectedItem.Value + "and dptcodigo=" + DropDownList4.SelectedItem.Value, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            ddlDistritoPN.DataSource = dt;
            ddlDistritoPN.DataBind();

            //DropDownList6.DataSource = dt;
            //DropDownList6.DataBind();

        }



























       
        protected void btnEnviarDenuncia_Click(object sender, EventArgs e)

        {











            /////////  lo anteriro -antiguo ////////////////


            string imgFile = "";

            #region manejo de las imagenes a base de datos



            //int tamanio = fupSubirArchivo.PostedFile.ContentLength;
            //byte[] imagenOriginal = new byte[tamanio];
            //fupSubirArchivo.PostedFile.InputStream.Read(imagenOriginal, 0, tamanio);
            //Bitmap imagenOriginalBinaria = new Bitmap(fupSubirArchivo.PostedFile.InputStream);
            //string ImagenDataURL64 = "data:image/jpg;base64," + Convert.ToBase64String(imagenOriginal);


            //if (fupSubirArchivo.PostedFile != null)
            //{
            //    imgFile = Path.GetFileName(fupSubirArchivo.PostedFile.FileName);
            //    fupSubirArchivo.SaveAs(@"D:\sys\denunciasWeb\denunciasWeb\fotos\" + imgFile);
            //}


            #endregion



            ///////////// agregao procdeimeintos 120619








            #region INSERTO DATOS PERSONA NATURAL

            SqlConnection cnx_12 = new SqlConnection(ConfigurationManager.ConnectionStrings["BDDigemidConnection"].ConnectionString);

           // SqlConnection cnx_12 = new SqlConnection();
            SqlCommand cmd_12 = new SqlCommand();

           // cnx_12.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=jañazco;Password=J09679933";

           // cnx_12.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=usrAppdenuncia;Password=Ykn42Ks3Wf";

            cnx_12.Open();
            cmd_12.Connection = cnx_12;
            cmd_12.CommandType = CommandType.StoredProcedure;
            cmd_12.CommandText = "dbo.SP_ET_INSERT_ETMESTABLECNOREG_1"; 







            cmd_12.Parameters.Add("@ESTNUMEINS_1", SqlDbType.VarChar).Value = pesonaNaturalCodigo;
       cmd_12.Parameters.Add("@ESTLUGAREG_2", SqlDbType.VarChar).Value = 1;
            cmd_12.Parameters.Add("@DSACODIGO_3", SqlDbType.VarChar).Value = "000";
            cmd_12.Parameters.Add("@CATCODIGO_4", SqlDbType.VarChar).Value = "";
            cmd_12.Parameters.Add("@TPRCODIGO_5", SqlDbType.VarChar).Value = "N";
            cmd_12.Parameters.Add("@TIDCODIGO_6", SqlDbType.VarChar).Value = "02";
     cmd_12.Parameters.Add("@ESTNUMEDOCID_7", SqlDbType.VarChar).Value = this.txtDNI.Text;
            cmd_12.Parameters.Add("@ESTNOMBCOM_8", SqlDbType.VarChar).Value = this.txtNombreApellidos.Text;
            cmd_12.Parameters.Add("@ESTRAZONSOC_9", SqlDbType.VarChar).Value = "";
            cmd_12.Parameters.Add("@ESTDIRECCION_10", SqlDbType.VarChar).Value = this.txtDireccion.Text;
            cmd_12.Parameters.Add("@ESTURBANIZ_11", SqlDbType.VarChar).Value = this.txtUrbanizacion.Text;
            cmd_12.Parameters.Add("@ESTDIRENUME_12", SqlDbType.VarChar).Value = this.txtNumero.Text;
            cmd_12.Parameters.Add("@ESTINTERIOR_13", SqlDbType.VarChar).Value = this.txtInterior.Text;
            string depaPN = this.ddlDepartamentoPN.Text;
            depaPN = depaPN.Replace(" ", "");
            string provPN = this.ddlProvinciaPN.Text;
            provPN = provPN.Replace(" ", "");
            string distPN = this.ddlDistritoPN.Text;
            distPN = distPN.Replace(" ", "");
            string ubigPN = depaPN + provPN + distPN;
            cmd_12.Parameters.Add("@UBICODIGO_14", SqlDbType.VarChar).Value = ubigPN;
            cmd_12.Parameters.Add("@ESTNUMETLF1_15", SqlDbType.VarChar).Value = this.txtFijo.Text; 
            cmd_12.Parameters.Add("@ESTNUMETLF2_16", SqlDbType.VarChar).Value = this.txtTelefono.Text;
            cmd_12.Parameters.Add("@ESTFAX_17", SqlDbType.VarChar).Value = "";
            cmd_12.Parameters.Add("@ESTEMAIL_18", SqlDbType.VarChar).Value = this.txtEmail.Text;
            cmd_12.Parameters.Add("@EDDCODIGO_19", SqlDbType.VarChar).Value = "01";
            cmd_12.Parameters.Add("@ESTINDITRAN_20", SqlDbType.VarChar).Value = "1";
     cmd_12.Parameters.Add("@ESTFECHREG_21", SqlDbType.VarChar).Value = Convert.ToDateTime(this.txtFechaRegistro.Text);
     cmd_12.Parameters.Add("@ESTFECHULT_22", SqlDbType.VarChar).Value = Convert.ToDateTime(this.txtFechaRegistro.Text);
            cmd_12.Parameters.Add("@USRCODIGO_23", SqlDbType.VarChar).Value = "0521";


            #endregion




            SqlConnection cnx_2 = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

           // SqlConnection cnx_2 = new SqlConnection();
            SqlCommand cmd_2 = new SqlCommand();

            //cnx_2.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=jañazco;Password=J09679933";
         //   cnx_2.ConnectionString = @"Data Source = 192.168.78.27\MSSQLSERVER2018; Initial Catalog = db_denunciasWeb; Persist Security Info = True; User ID = sa; Password = J@m09679933";


            cnx_2.Open();
            cmd_2.Connection = cnx_2;
            cmd_2.CommandType = CommandType.StoredProcedure;
            cmd_2.CommandText = "SP_INSERT_VGMDENUNCIA";



            cmd_2.Parameters.Add("@DSACODIGO_1", SqlDbType.VarChar).Value = "000";
          //  cmd_2.Parameters.Add("@DENCODIGO_2", SqlDbType.VarChar).Value = this.lblDenCodigo.Text;
            cmd_2.Parameters.Add("@DENFECHDEN_3", SqlDbType.DateTime).Value = Convert.ToDateTime(this.txtFechaRegistro.Text);
            cmd_2.Parameters.Add("@DENMEDICOM_4", SqlDbType.VarChar).Value = "06";
            cmd_2.Parameters.Add("@PERCODIGO_5", SqlDbType.VarChar).Value = "00566";
            cmd_2.Parameters.Add("@EXPCODIGO_6", SqlDbType.VarChar).Value = "";
            cmd_2.Parameters.Add("@EXPFECHREG_7", SqlDbType.DateTime).Value = Convert.ToDateTime(this.txtFechaRegistro.Text);
            cmd_2.Parameters.Add("@EXPNUMESEC_8", SqlDbType.Int).Value = 0;
            cmd_2.Parameters.Add("@DENTIPODEN1_9", SqlDbType.VarChar).Value = this.ddlTipoEstablecimiento.Text;
            cmd_2.Parameters.Add("@ESTNUMEINS1_10", SqlDbType.VarChar).Value = "0000000";
            cmd_2.Parameters.Add("@DENNUMERUC1_11", SqlDbType.VarChar).Value = "";
            cmd_2.Parameters.Add("@CATCODIGO1_12", SqlDbType.VarChar).Value = "";
            cmd_2.Parameters.Add("@DENNOMBCOM1_13", SqlDbType.VarChar).Value = this.txtNombreestablecimiento.Text; 
            cmd_2.Parameters.Add("@DENRAZONSOC1_14", SqlDbType.VarChar).Value = this.txtNombreestablecimiento.Text; ; ;
            cmd_2.Parameters.Add("@DENDIRECCION1_15", SqlDbType.VarChar).Value = this.txtDireccionestablecimiento.Text;
            cmd_2.Parameters.Add("@DENURBANIZ1_16", SqlDbType.VarChar).Value = "";
            cmd_2.Parameters.Add("@DENDIRENUME1_17", SqlDbType.VarChar).Value = "";
            cmd_2.Parameters.Add("@DENINTERIOR1_18", SqlDbType.VarChar).Value = "";
            string depa = this.ddlDepartamento.Text;
            depa = depa.Replace(" ", "");
            string prov = this.ddlProvincia.Text;
            prov = prov.Replace(" ", "");
            string dist = this.ddlDistrito.Text;
            dist = dist.Replace(" ", "");
            string ubig = depa + prov + dist;
            cmd_2.Parameters.Add("@UBICODIGO1_19", SqlDbType.VarChar).Value = ubig;
            cmd_2.Parameters.Add("@DENNUMETLF1_20", SqlDbType.VarChar).Value = "";
            cmd_2.Parameters.Add("@DENFAX1_21", SqlDbType.VarChar).Value = "";
            cmd_2.Parameters.Add("@DENREFEREN_22", SqlDbType.VarChar).Value = "";
            cmd_2.Parameters.Add("@DENTIPODEN2_23", SqlDbType.VarChar).Value = "PN" ;
            cmd_2.Parameters.Add("@DENINDIANON2_24", SqlDbType.Int).Value = anonimo;
            cmd_2.Parameters.Add("@ESTNUMEINS2_25", SqlDbType.VarChar).Value = pesonaNaturalCodigo;
            cmd_2.Parameters.Add("@DENNUMERUC2_26", SqlDbType.VarChar).Value = "";
            cmd_2.Parameters.Add("@TIDCODIGO2_27", SqlDbType.VarChar).Value = "02";
            cmd_2.Parameters.Add("@DENNUMEDOCID2_28", SqlDbType.VarChar).Value = this.txtDNI.Text;
            cmd_2.Parameters.Add("@CATCODIGO2_29", SqlDbType.VarChar).Value = "";
            cmd_2.Parameters.Add("@DENNOMBCOM2_30", SqlDbType.VarChar).Value = "";
            cmd_2.Parameters.Add("@DENRAZONSOC2_31", SqlDbType.VarChar).Value = "";
            cmd_2.Parameters.Add("@DENNOMBCOMP2_32", SqlDbType.VarChar).Value = this.txtNombreApellidos.Text;
            cmd_2.Parameters.Add("@DENDIRECCION2_33", SqlDbType.VarChar).Value = this.txtDireccion.Text; ;
            cmd_2.Parameters.Add("@DENURBANIZ2_34", SqlDbType.VarChar).Value = this.txtUrbanizacion.Text;
            cmd_2.Parameters.Add("@DENDIRENUME2_35", SqlDbType.VarChar).Value = this.txtNumero.Text;
            cmd_2.Parameters.Add("@DENINTERIOR2_36", SqlDbType.VarChar).Value = this.txtInterior.Text;
            cmd_2.Parameters.Add("@UBICODIGO2_37", SqlDbType.VarChar).Value = ubigPN;
            cmd_2.Parameters.Add("@DENNUMETLF2_38", SqlDbType.VarChar).Value = this.txtTelefono.Text;
            cmd_2.Parameters.Add("@DENFAX2_39", SqlDbType.VarChar).Value = "";
            cmd_2.Parameters.Add("@DENEMAIL2_40", SqlDbType.VarChar).Value = this.txtEmail.Text; 
           cmd_2.Parameters.Add("@DENCOMENT_41", SqlDbType.VarChar).Value = this.txtMotivo.Text;
            cmd_2.Parameters.Add("@DENINDIPROCEDE_42", SqlDbType.VarChar).Value = "S";
            cmd_2.Parameters.Add("@DENFECHREG_43", SqlDbType.DateTime).Value = Convert.ToDateTime(this.txtFechaRegistro.Text);
            cmd_2.Parameters.Add("@DENFECHULT_44", SqlDbType.DateTime).Value = Convert.ToDateTime(this.txtFechaRegistro.Text);
            cmd_2.Parameters.Add("@USRCODIGO_45", SqlDbType.VarChar).Value = "0521";
            cmd_2.Parameters.Add("@USRCODIGOULT_46", SqlDbType.VarChar).Value = "0521";

            cmd_2.Parameters.Add("@DENMEDICAMEN1_47", SqlDbType.VarChar).Value = this.inputNombre1.Text;
            cmd_2.Parameters.Add("@DENCONCENTRACION1_48", SqlDbType.VarChar).Value = this.inputConcentracion1.Text;
            cmd_2.Parameters.Add("@DENFORMAFARMACEUTICA1_49", SqlDbType.VarChar).Value = this.inputFF1.Text;


            cmd_2.Parameters.Add("@DENMEDICAMEN2_50", SqlDbType.VarChar).Value = this.inputNombre2.Text;
            cmd_2.Parameters.Add("@DENCONCENTRACION2_51", SqlDbType.VarChar).Value = this.inputConcentracion2.Text;
            cmd_2.Parameters.Add("@DENFORMAFARMACEUTICA2_52", SqlDbType.VarChar).Value = this.inputFF2.Text;


            cmd_2.Parameters.Add("@DENMEDICAMEN3_53", SqlDbType.VarChar).Value = this.inputNombre3.Text;
            cmd_2.Parameters.Add("@DENCONCENTRACION3_54", SqlDbType.VarChar).Value = this.inputConcentracion3.Text;
            cmd_2.Parameters.Add("@DENFORMAFARMACEUTICA3_55", SqlDbType.VarChar).Value = this.inputFF3.Text;






            cmd_2.ExecuteScalar();



            #region llenarTablaMotivoDenuncia





            //      @MOTCODIGO_4  INTEGER, 
            //@MOTCODIGODET_5 INTEGER,
            //      @DENPUNTAJE_6 INTEGER

            //if (chkFalsificados.Checked)
            //{



            //    uno = 1;
            //    dos = 0;
            //    tres = 0;
            //    cuatro = 0;
            //    cinco = 0;
            //    seis = 0;
            //    siete = 0;
            //    ocho = 0;

                


            //    SqlConnection cnx_3 = new SqlConnection();
            //    SqlCommand cmd_3 = new SqlCommand();

            //    cnx_3.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=jañazco;Password=J09679933";



            //    cnx_3.Open();
            //    cmd_3.Connection = cnx_2;
            //    cmd_3.CommandType = CommandType.StoredProcedure;
            //    cmd_3.CommandText = "dbo.SP_VG_INSERT_VGMDENUNMOT";



            //    cmd_3.Parameters.Add("@DSACODIGO_1", SqlDbType.VarChar).Value = "000";
            //    cmd_3.Parameters.Add("@DENCODIGO_2", SqlDbType.VarChar).Value = this.lblDenCodigo.Text;
            //    cmd_3.Parameters.Add("@DENNUMESEC_3", SqlDbType.Int).Value = uno;

            //    cmd_3.Parameters.Add("@MOTCODIGO_4", SqlDbType.Int).Value = 1;
            //    cmd_3.Parameters.Add("@MOTCODIGODET_5", SqlDbType.Int).Value = 1;
            //    cmd_3.Parameters.Add("@DENPUNTAJE_6", SqlDbType.Int).Value = 5;


            //    cmd_3.ExecuteScalar();

            //    cnx_3.Close();

            //}







            //if (chkVencidos.Checked)
            //{



            //    if (chkFalsificados.Checked)
            //    {

            //        dos = 2;
            //    }
            //    else
            //    {
            //        dos = 1;
            //    }



            //    SqlConnection cnx_3 = new SqlConnection();
            //    SqlCommand cmd_3 = new SqlCommand();

            //    cnx_3.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=jañazco;Password=J09679933";



            //    cnx_3.Open();
            //    cmd_3.Connection = cnx_2;
            //    cmd_3.CommandType = CommandType.StoredProcedure;
            //    cmd_3.CommandText = "dbo.SP_VG_INSERT_VGMDENUNMOT";



            //    cmd_3.Parameters.Add("@DSACODIGO_1", SqlDbType.VarChar).Value = "000";
            //    cmd_3.Parameters.Add("@DENCODIGO_2", SqlDbType.VarChar).Value = this.lblDenCodigo.Text;
            //    cmd_3.Parameters.Add("@DENNUMESEC_3", SqlDbType.Int).Value = dos;

            //    cmd_3.Parameters.Add("@MOTCODIGO_4", SqlDbType.Int).Value = 1;
            //    cmd_3.Parameters.Add("@MOTCODIGODET_5", SqlDbType.Int).Value = 2;
            //    cmd_3.Parameters.Add("@DENPUNTAJE_6", SqlDbType.Int).Value = 5;


            //    cmd_3.ExecuteScalar();

            //    cnx_3.Close();

            //}





            //if (chkProcDesconocida.Checked)
            //{



            //    if ((chkFalsificados.Checked) && (chkVencidos.Checked))
            //    {

            //        tres = 3;
            //    }
            //    else if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = false))
            //    {
            //        tres = 1;
            //    }
            //    else if ((chkFalsificados.Checked = true) && (chkVencidos.Checked = false))
            //    {
            //        tres = 2;
            //    }
            //    else if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = true))
            //    {
            //        tres = 2;
            //    }




            //    SqlConnection cnx_3 = new SqlConnection();
            //    SqlCommand cmd_3 = new SqlCommand();

            //    cnx_3.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=jañazco;Password=J09679933";



            //    cnx_3.Open();
            //    cmd_3.Connection = cnx_2;
            //    cmd_3.CommandType = CommandType.StoredProcedure;
            //    cmd_3.CommandText = "dbo.SP_VG_INSERT_VGMDENUNMOT";



            //    cmd_3.Parameters.Add("@DSACODIGO_1", SqlDbType.VarChar).Value = "000";
            //    cmd_3.Parameters.Add("@DENCODIGO_2", SqlDbType.VarChar).Value = this.lblDenCodigo.Text;
            //    cmd_3.Parameters.Add("@DENNUMESEC_3", SqlDbType.Int).Value = tres;

            //    cmd_3.Parameters.Add("@MOTCODIGO_4", SqlDbType.Int).Value = 1;
            //    cmd_3.Parameters.Add("@MOTCODIGODET_5", SqlDbType.Int).Value = 3;
            //    cmd_3.Parameters.Add("@DENPUNTAJE_6", SqlDbType.Int).Value = 4;


            //    cmd_3.ExecuteScalar();

            //    cnx_3.Close();

            //}




            //if (chkRotAdulterado.Checked)
            //{



            //    if ((chkFalsificados.Checked) && (chkVencidos.Checked) && (chkProcDesconocida.Checked))
            //    {

            //        cuatro = 4;
            //    }
            //    else if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = false))
            //    {
            //        cuatro = 1;
            //    }
            //    else if ((chkFalsificados.Checked = true) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = false))
            //    {
            //        cuatro = 2;
            //    }
            //    else if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = true) && (chkProcDesconocida.Checked = false))
            //    {
            //        cuatro = 2;
            //    }
            //    else if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = true))
            //    {
            //        cuatro = 2;
            //    }
            //    else if ((chkFalsificados.Checked = true) && (chkVencidos.Checked = true) && (chkProcDesconocida.Checked = false))
            //    {
            //        cuatro = 3;
            //    }
            //    else if ((chkFalsificados.Checked = true) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = true))
            //    {
            //        cuatro = 3;
            //    }
            //    else if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = true) && (chkProcDesconocida.Checked = true))
            //    {
            //        cuatro = 3;
            //    }

















            //    SqlConnection cnx_3 = new SqlConnection();
            //    SqlCommand cmd_3 = new SqlCommand();

            //    cnx_3.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=jañazco;Password=J09679933";



            //    cnx_3.Open();
            //    cmd_3.Connection = cnx_2;
            //    cmd_3.CommandType = CommandType.StoredProcedure;
            //    cmd_3.CommandText = "dbo.SP_VG_INSERT_VGMDENUNMOT";



            //    cmd_3.Parameters.Add("@DSACODIGO_1", SqlDbType.VarChar).Value = "000";
            //    cmd_3.Parameters.Add("@DENCODIGO_2", SqlDbType.VarChar).Value = this.lblDenCodigo.Text;
            //    cmd_3.Parameters.Add("@DENNUMESEC_3", SqlDbType.Int).Value = cuatro;

            //    cmd_3.Parameters.Add("@MOTCODIGO_4", SqlDbType.Int).Value = 1;
            //    cmd_3.Parameters.Add("@MOTCODIGODET_5", SqlDbType.Int).Value = 4;
            //    cmd_3.Parameters.Add("@DENPUNTAJE_6", SqlDbType.Int).Value = 4;


            //    cmd_3.ExecuteScalar();

            //    cnx_3.Close();

            //}



            //if (chksinRS.Checked)
            //{





            //    if ((chkFalsificados.Checked) && (chkVencidos.Checked) && (chkProcDesconocida.Checked) && (chkRotAdulterado.Checked))
            //    {

            //        cinco = 5;
            //    }
            //    else if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = false) && (chkRotAdulterado.Checked = false))
            //    {
            //        cinco = 1;
            //    }
            //    else if ((chkFalsificados.Checked = true) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = false) && (chkRotAdulterado.Checked = false))
            //    {
            //        cinco = 2;
            //    }
            //    else if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = true) && (chkProcDesconocida.Checked = false) && (chkRotAdulterado.Checked = false))
            //    {
            //        cinco = 2;
            //    }
            //    else if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = true) && (chkRotAdulterado.Checked = false))
            //    {
            //        cinco = 2;
            //    }
            //    else if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = false) && (chkRotAdulterado.Checked = true))
            //    {
            //        cinco = 2;
            //    }
            //    else if ((chkFalsificados.Checked = true) && (chkVencidos.Checked = true) && (chkProcDesconocida.Checked = false) && (chkRotAdulterado.Checked = false))
            //    {
            //        cinco = 3;
            //    }
            //    else if ((chkFalsificados.Checked = true) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = true) && (chkRotAdulterado.Checked = false))
            //    {
            //        cinco = 3;
            //    }
            //    else if ((chkFalsificados.Checked = true) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = false) && (chkRotAdulterado.Checked = true))
            //    {
            //        cinco = 3;
            //    }
            //    else if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = true) && (chkProcDesconocida.Checked = true) && (chkRotAdulterado.Checked = false))
            //    {
            //        cinco = 3;
            //    }
            //    else if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = true) && (chkProcDesconocida.Checked = false) && (chkRotAdulterado.Checked = true))
            //    {
            //        cinco = 3;
            //    }
            //    else if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = true) && (chkRotAdulterado.Checked = true))
            //    {
            //        cinco = 3;
            //    }
            //    else if ((chkFalsificados.Checked = true) && (chkVencidos.Checked = true) && (chkProcDesconocida.Checked = true) && (chkRotAdulterado.Checked = false))
            //    {
            //        cinco = 4;
            //    }
            //    else if ((chkFalsificados.Checked = true) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = true) && (chkRotAdulterado.Checked = true))
            //    {
            //        cinco = 4;
            //    }
            //    else if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = true) && (chkProcDesconocida.Checked = true) && (chkRotAdulterado.Checked = true))
            //    {
            //        cinco = 4;
            //    }
            //    else if ((chkFalsificados.Checked = true) && (chkVencidos.Checked = true) && (chkProcDesconocida.Checked = false) && (chkRotAdulterado.Checked = true))
            //    {
            //        cinco = 4;
            //    }























            //    SqlConnection cnx_3 = new SqlConnection();
            //    SqlCommand cmd_3 = new SqlCommand();

            //    cnx_3.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=jañazco;Password=J09679933";



            //    cnx_3.Open();
            //    cmd_3.Connection = cnx_2;
            //    cmd_3.CommandType = CommandType.StoredProcedure;
            //    cmd_3.CommandText = "dbo.SP_VG_INSERT_VGMDENUNMOT";



            //    cmd_3.Parameters.Add("@DSACODIGO_1", SqlDbType.VarChar).Value = "000";
            //    cmd_3.Parameters.Add("@DENCODIGO_2", SqlDbType.VarChar).Value = this.lblDenCodigo.Text;
            //    cmd_3.Parameters.Add("@DENNUMESEC_3", SqlDbType.Int).Value = cinco;

            //    cmd_3.Parameters.Add("@MOTCODIGO_4", SqlDbType.Int).Value = 1;
            //    cmd_3.Parameters.Add("@MOTCODIGODET_5", SqlDbType.Int).Value = 5;
            //    cmd_3.Parameters.Add("@DENPUNTAJE_6", SqlDbType.Int).Value = 3;


            //    cmd_3.ExecuteScalar();

            //    cnx_3.Close();

            //}



        //    if (chkProdPublico.Checked)
        //    {


        //        if ((chkFalsificados.Checked) && (chkVencidos.Checked) && (chkProcDesconocida.Checked) && (chkRotAdulterado.Checked) && (chksinRS.Checked))
        //        {

        //            seis = 6;
        //        }
        //        else if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = false) && (chkRotAdulterado.Checked = false)
        //             && (chksinRS.Checked = false))
        //        {
        //            seis = 1;
        //        }
        //        else if ((chkFalsificados.Checked = true) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = false) && (chkRotAdulterado.Checked = false)
        //            && (chksinRS.Checked = false))
        //        {
        //            seis = 2;
        //        }
        //        else if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = true) && (chkProcDesconocida.Checked = false) && (chkRotAdulterado.Checked = false)
        //            && (chksinRS.Checked = false))
        //        {
        //            seis = 2;
        //        }
        //        else if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = true) && (chkRotAdulterado.Checked = false)
        //            && (chksinRS.Checked = false))
        //        {
        //            seis = 2;
        //        }
        //        else if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = false) && (chkRotAdulterado.Checked = true)
        //            && (chksinRS.Checked = false))
        //        {
        //            seis = 2;
        //        }
        //        else if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = false) && (chkRotAdulterado.Checked = false)
        //            && (chksinRS.Checked = true))
        //        {
        //            seis = 2;
        //        }
        //        else if ((chkFalsificados.Checked = true) && (chkVencidos.Checked = true) && (chkProcDesconocida.Checked = false) && (chkRotAdulterado.Checked = false)
        //            && (chksinRS.Checked = false))
        //        {
        //            seis = 3;
        //        }
        //        else if ((chkFalsificados.Checked = true) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = true) && (chkRotAdulterado.Checked = false)
        //            && (chksinRS.Checked = false))
        //        {
        //            seis = 3;
        //        }
        //        else if ((chkFalsificados.Checked = true) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = false) && (chkRotAdulterado.Checked = true)
        //            && (chksinRS.Checked = false))
        //        {
        //            seis = 3;
        //        }
        //        else if ((chkFalsificados.Checked = true) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = false) && (chkRotAdulterado.Checked = false)
        //            && (chksinRS.Checked = true))
        //        {
        //            seis = 3;
        //        }
        //        else if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = true) && (chkProcDesconocida.Checked = true) && (chkRotAdulterado.Checked = false)
        //            && (chksinRS.Checked = false))
        //        {
        //            seis = 3;
        //        }
        //        else if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = true) && (chkProcDesconocida.Checked = false) && (chkRotAdulterado.Checked = true)
        //           && (chksinRS.Checked = false))
        //        {
        //            seis = 3;
        //        }
        //        else if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = true) && (chkProcDesconocida.Checked = false) && (chkRotAdulterado.Checked = false)
        //           && (chksinRS.Checked = true))
        //        {
        //            seis = 3;
        //        }
        //        else if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = true) && (chkRotAdulterado.Checked = true)
        //           && (chksinRS.Checked = false))
        //        {
        //            seis = 3;
        //        }
        //        else if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = true) && (chkRotAdulterado.Checked = false)
        //          && (chksinRS.Checked = true))
        //        {
        //            seis = 3;
        //        }
        //        else if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = false) && (chkRotAdulterado.Checked = true)
        //         && (chksinRS.Checked = true))
        //        {
        //            seis = 3;
        //        }
        //        else if ((chkFalsificados.Checked = true) && (chkVencidos.Checked = true) && (chkProcDesconocida.Checked = true) && (chkRotAdulterado.Checked = false)
        //        && (chksinRS.Checked = false))
        //        {
        //            seis = 4;
        //        }
        //        else if ((chkFalsificados.Checked = true) && (chkVencidos.Checked = true) && (chkProcDesconocida.Checked = false) && (chkRotAdulterado.Checked = true)
        //       && (chksinRS.Checked = false))
        //        {
        //            seis = 4;
        //        }
        //        else if ((chkFalsificados.Checked = true) && (chkVencidos.Checked = true) && (chkProcDesconocida.Checked = false) && (chkRotAdulterado.Checked = false)
        //       && (chksinRS.Checked = true))
        //        {
        //            seis = 4;
        //        }
        //        else if ((chkFalsificados.Checked = true) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = true) && (chkRotAdulterado.Checked = true)
        //       && (chksinRS.Checked = false))
        //        {
        //            seis = 4;
        //        }
        //        else if ((chkFalsificados.Checked = true) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = true) && (chkRotAdulterado.Checked = false)
        //      && (chksinRS.Checked = true))
        //        {
        //            seis = 4;
        //        }
        //        else if ((chkFalsificados.Checked = true) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = false) && (chkRotAdulterado.Checked = true)
        //      && (chksinRS.Checked = true))
        //        {
        //            seis = 4;
        //        }
        //        else if ((chkFalsificados.Checked = true) && (chkVencidos.Checked = true) && (chkProcDesconocida.Checked = true) && (chkRotAdulterado.Checked = true)
        //     && (chksinRS.Checked = false))
        //        {
        //            seis = 5;
        //        }
        //        else if ((chkFalsificados.Checked = true) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = true) && (chkRotAdulterado.Checked = true)
        //    && (chksinRS.Checked = true))
        //        {
        //            seis = 5;
        //        }
        //        else if ((chkFalsificados.Checked = true) && (chkVencidos.Checked = true) && (chkProcDesconocida.Checked = false) && (chkRotAdulterado.Checked = true)
        //  && (chksinRS.Checked = true))
        //        {
        //            seis = 5;
        //        }
        //        else if ((chkFalsificados.Checked = true) && (chkVencidos.Checked = true) && (chkProcDesconocida.Checked = true) && (chkRotAdulterado.Checked = false)
        //  && (chksinRS.Checked = true))
        //        {
        //            seis = 5;
        //        }
        //        else if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = true) && (chkProcDesconocida.Checked = true) && (chkRotAdulterado.Checked = true)
        //&& (chksinRS.Checked = true))
        //        {
        //            seis = 5;
        //        }


















        //        SqlConnection cnx_3 = new SqlConnection();
        //        SqlCommand cmd_3 = new SqlCommand();

        //        cnx_3.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=jañazco;Password=J09679933";



        //        cnx_3.Open();
        //        cmd_3.Connection = cnx_2;
        //        cmd_3.CommandType = CommandType.StoredProcedure;
        //        cmd_3.CommandText = "dbo.SP_VG_INSERT_VGMDENUNMOT";



        //        cmd_3.Parameters.Add("@DSACODIGO_1", SqlDbType.VarChar).Value = "000";
        //        cmd_3.Parameters.Add("@DENCODIGO_2", SqlDbType.VarChar).Value = this.lblDenCodigo.Text;
        //        cmd_3.Parameters.Add("@DENNUMESEC_3", SqlDbType.Int).Value = seis;

        //        cmd_3.Parameters.Add("@MOTCODIGO_4", SqlDbType.Int).Value = 1;
        //        cmd_3.Parameters.Add("@MOTCODIGODET_5", SqlDbType.Int).Value = 6;
        //        cmd_3.Parameters.Add("@DENPUNTAJE_6", SqlDbType.Int).Value = 2;


        //        cmd_3.ExecuteScalar();

        //        cnx_3.Close();

        //    }



            //if (chkMuestraMedica.Checked)
            //{






            //    if ((chkFalsificados.Checked) && (chkVencidos.Checked) && (chkProcDesconocida.Checked) && (chkRotAdulterado.Checked) && (chksinRS.Checked)
            //       && (chkProdPublico.Checked))
            //    {

            //        siete = 7;
            //    }

            //    if ((chkFalsificados.Checked = true) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = false) && (chkRotAdulterado.Checked = false)
            //        && (chksinRS.Checked = false) && (chkProdPublico.Checked = false))
            //    {

            //        siete = 1;
            //    }
            //    if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = true) && (chkProcDesconocida.Checked = false) && (chkRotAdulterado.Checked = false)
            //       && (chksinRS.Checked = false) && (chkProdPublico.Checked = false))
            //    {

            //        siete = 1;
            //    }
            //    if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = true) && (chkRotAdulterado.Checked = false)
            //      && (chksinRS.Checked = false) && (chkProdPublico.Checked = false))
            //    {

            //        siete = 1;
            //    }
            //    if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = false) && (chkRotAdulterado.Checked = true)
            //      && (chksinRS.Checked = false) && (chkProdPublico.Checked = false))
            //    {

            //        siete = 1;
            //    }
            //    if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = false) && (chkRotAdulterado.Checked = false)
            //      && (chksinRS.Checked = true) && (chkProdPublico.Checked = false))
            //    {

            //        siete = 1;
            //    }
            //    if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = false) && (chkRotAdulterado.Checked = false)
            //      && (chksinRS.Checked = false) && (chkProdPublico.Checked = true))
            //    {

            //        siete = 1;
            //    }
            //    if ((chkFalsificados.Checked = false) && (chkVencidos.Checked = false) && (chkProcDesconocida.Checked = false) && (chkRotAdulterado.Checked = false)
            //      && (chksinRS.Checked = false) && (chkProdPublico.Checked = true))
            //    {

            //        siete = 1;
            //    }









            //    SqlConnection cnx_3 = new SqlConnection();
            //    SqlCommand cmd_3 = new SqlCommand();

            //    cnx_3.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=jañazco;Password=J09679933";



            //    cnx_3.Open();
            //    cmd_3.Connection = cnx_2;
            //    cmd_3.CommandType = CommandType.StoredProcedure;
            //    cmd_3.CommandText = "dbo.SP_VG_INSERT_VGMDENUNMOT";



            //    cmd_3.Parameters.Add("@DSACODIGO_1", SqlDbType.VarChar).Value = "000";
            //    cmd_3.Parameters.Add("@DENCODIGO_2", SqlDbType.VarChar).Value = this.lblDenCodigo.Text;
            //    cmd_3.Parameters.Add("@DENNUMESEC_3", SqlDbType.Int).Value = siete;

            //    cmd_3.Parameters.Add("@MOTCODIGO_4", SqlDbType.Int).Value = 1;
            //    cmd_3.Parameters.Add("@MOTCODIGODET_5", SqlDbType.Int).Value = 7;
            //    cmd_3.Parameters.Add("@DENPUNTAJE_6", SqlDbType.Int).Value = 2;


            //    cmd_3.ExecuteScalar();

            //    cnx_3.Close();

            //}


            //if (chkMalEstado.Checked)
            //{


            //    SqlConnection cnx_3 = new SqlConnection();
            //    SqlCommand cmd_3 = new SqlCommand();

            //    cnx_3.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=jañazco;Password=J09679933";



            //    cnx_3.Open();
            //    cmd_3.Connection = cnx_2;
            //    cmd_3.CommandType = CommandType.StoredProcedure;
            //    cmd_3.CommandText = "dbo.SP_VG_INSERT_VGMDENUNMOT";



            //    cmd_3.Parameters.Add("@DSACODIGO_1", SqlDbType.VarChar).Value = "000";
            //    cmd_3.Parameters.Add("@DENCODIGO_2", SqlDbType.VarChar).Value = this.lblDenCodigo.Text;
            //    cmd_3.Parameters.Add("@DENNUMESEC_3", SqlDbType.Int).Value = 8;

            //    cmd_3.Parameters.Add("@MOTCODIGO_4", SqlDbType.Int).Value = 1;
            //    cmd_3.Parameters.Add("@MOTCODIGODET_5", SqlDbType.Int).Value = 8;
            //    cmd_3.Parameters.Add("@DENPUNTAJE_6", SqlDbType.Int).Value = 1;


            //    cmd_3.ExecuteScalar();

            //    cnx_3.Close();

            //}


            #endregion













            lblestado.Text = "Registrado correctamente";



            /////////////////////////////










            //SqlConnection cnx = new SqlConnection();
            //SqlCommand cmd = new SqlCommand();

            //cnx.ConnectionString = "Data Source=server;Initial Catalog=db_denunciasWeb;Persist Security Info=True;User ID=janazco;Password=j@n@zc0";



            //cnx.Open();
            //cmd.Connection = cnx;
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "dbo.usp_insertarDenuncia";









            //cmd.Parameters.Add("@id_tipoPersona", SqlDbType.Int).Value = this.ddltipoPersona.SelectedValue;
            //cmd.Parameters.Add("@dsacodigo", SqlDbType.VarChar).Value = "000";
            //cmd.Parameters.Add("@dencodigo", SqlDbType.VarChar).Value = denCodigo;
            //cmd.Parameters.Add("@nombreApellidos", SqlDbType.VarChar).Value = this.txtNombreApellidos.Text;
            //cmd.Parameters.Add("@dni", SqlDbType.VarChar).Value = this.txtDNI.Text;
            //cmd.Parameters.Add("@razonsocial", SqlDbType.VarChar).Value = this.txtRazonSocial.Text;
            //cmd.Parameters.Add("@RUC", SqlDbType.VarChar).Value = this.txtRUC.Text;
            //cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = this.txtEmail.Text;
            //cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = this.txtTelefono.Text;
            //cmd.Parameters.Add("@aFalsificado", SqlDbType.Bit).Value = this.chkFalsificados.Checked;
            //cmd.Parameters.Add("@aVencido", SqlDbType.Bit).Value = this.chkVencidos.Checked;
            //cmd.Parameters.Add("@aMalEstado", SqlDbType.Bit).Value = this.chkMalEstado.Checked;
            //cmd.Parameters.Add("@aSinRS", SqlDbType.Bit).Value = this.chksinRS.Checked;
            //cmd.Parameters.Add("@aProcDesconocida", SqlDbType.Bit).Value = this.chkProcDesconocida.Checked;
            //cmd.Parameters.Add("@aRotuladoAdBo", SqlDbType.Bit).Value = this.chkRotAdulterado.Checked;
            //cmd.Parameters.Add("@aMuestraMedica", SqlDbType.Bit).Value = this.chkMuestraMedica.Checked;
            //cmd.Parameters.Add("@aProductoPublico", SqlDbType.Bit).Value = this.chkProdPublico.Checked;
            //cmd.Parameters.Add("@nombreProducto", SqlDbType.VarChar).Value = this.txtNombreProducto.Text;
            //cmd.Parameters.Add("@id_tipoProducto", SqlDbType.Int).Value = this.ddlTipoProducto.Text;
            //cmd.Parameters.Add("@nroSerieLote", SqlDbType.VarChar).Value = this.txtNroSerieLote.Text;
            //cmd.Parameters.Add("@fechaVencimiento", SqlDbType.DateTime).Value = Convert.ToDateTime(this.txtFecVencimiento.Text);
            //cmd.Parameters.Add("@registroSanitario", SqlDbType.VarChar).Value = this.txtRegSan.Text;
            //cmd.Parameters.Add("@motivoDenuncia", SqlDbType.VarChar).Value = this.txtMotivo.Text;
            //cmd.Parameters.Add("@id_tipoEstablecimiento", SqlDbType.VarChar).Value = this.ddlTipoEstablecimiento.Text;
            ////cmd.Parameters.Add("@id_tipoEstablecimiento", SqlDbType.Int).Value = this.ddlTipoEstablecimiento.Text;
            //cmd.Parameters.Add("@nombreEstablecimiento", SqlDbType.VarChar).Value = this.txtNombreestablecimiento.Text;
            //cmd.Parameters.Add("@id_departamento", SqlDbType.VarChar).Value = this.ddlDepartamento.Text;
            //cmd.Parameters.Add("@id_provincia", SqlDbType.VarChar).Value = this.ddlProvincia.Text;
            //cmd.Parameters.Add("@id_distrito", SqlDbType.VarChar).Value = this.ddlDistrito.Text;
            //cmd.Parameters.Add("@imagen", SqlDbType.VarChar).Value = imgFile;
            //cmd.Parameters.Add("@imagenRuta", SqlDbType.VarChar).Value = @"D:\sys\denunciasWeb\denunciasWeb\fotos\" + imgFile;

            //cmd.ExecuteScalar();



            //lblestado.Text = "Registrado correctamente";

            /////////////////////////


            ////  cmd.Parameters.Add("@cod_evaluador", SqlDbType.Int).Value = this.ddl_Nombre.SelectedValue;
            //cmd.Parameters.Add("@cod_evaluador", SqlDbType.Int).Value = Int32.Parse(this.lblIdEvaluador.Text);

            //cmd.Parameters.Add("@nro_expediente", SqlDbType.VarChar).Value = this.lblExpediente.Text;       //this.txtExpediente.Text;
            //                                                                                                // cmd.Parameters.Add("@cod_tramite", SqlDbType.VarChar).Value = this.ddlTramite.SelectedValue;
            //                                                                                                //cmd.Parameters.Add("@cod_tupa", SqlDbType.VarChar).Value = this.ddlTupa.SelectedValue;

            //cmd.Parameters.Add("@cod_tramite", SqlDbType.VarChar).Value = this.lblTramite.Text;
            //cmd.Parameters.Add("@cod_tupa", SqlDbType.VarChar).Value = this.lblTupa.Text;



            //// cmd.Parameters.Add("@cod_tupa", SqlDbType.VarChar).Value = this.ddlTupa.SelectedItem.Text;


            ////string _param1 = "some value or null";
            ////cmd.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = !String.IsNullOrEmpty(_param1) ? _param1 : null;




            //cmd.Parameters.Add("@cod_item_1", SqlDbType.VarChar).Value = !String.IsNullOrEmpty(this.lbl_111.Text) ? this.lbl_111.Text : null;

            //cmd.Parameters.Add("@eval_1", SqlDbType.Int).Value = !String.IsNullOrEmpty(this.rb_111.SelectedValue) ? this.rb_111.SelectedValue : null;
            //cmd.Parameters.Add("@obs_1", SqlDbType.VarChar).Value = !String.IsNullOrEmpty(this.txtObs_111.Text) ? this.txtObs_111.Text : null;
            //cmd.Parameters.Add("@obslev_1", SqlDbType.Bit).Value = this.CheckBox_111.Checked;




            ////cmd.Parameters.Add("@cod_item_1", SqlDbType.VarChar).Value = this.lbl_111.Text;

            ////cmd.Parameters.Add("@eval_1", SqlDbType.Int).Value = this.rb_111.SelectedValue;
            ////cmd.Parameters.Add("@obs_1", SqlDbType.VarChar).Value = this.txtObs_111.Text;

            ////cmd.Parameters.Add("@rb_s_1", SqlDbType.Bit).Value = this.RadioButton1.Checked;
            ////cmd.Parameters.Add("@rb_n_1", SqlDbType.Bit).Value = this.RadioButton2.Checked;
            ////cmd.Parameters.Add("@rb_na_1", SqlDbType.Bit).Value = this.RadioButton3.Checked;









        }

        protected void SqlDataSource4_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch (DropDownList1.SelectedValue)
            //{
            //    case "1":
            //        MultiView1.SetActiveView(View1);
            //        break;
            //    case "2":
            //        MultiView1.SetActiveView(View2);
            //        break;
            //    case "3":
            //        MultiView1.SetActiveView(View3);
            //        break;
            //}




            //if (DropDownList1.SelectedIndex == 0)
            //    MultiView1.SetActiveView(View1);
            //else
            //    MultiView1.SetActiveView(View2);


        }
    }
}