using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace denunciasWeb
{
    public partial class DenunciaE : System.Web.UI.Page
    {
        public string state = "collapse";

        string denCodigo;
        string pesonaNaturalCodigo;
        int anonimo = 0;

        int contador = 1;
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

          // SqlConnection cnx_1 = new SqlConnection();
            SqlCommand cmd_1 = new SqlCommand();

           // cnx_1.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=jañazco;Password=J09679933";

          //  cnx_1.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=usrAppdenuncia;Password=Ykn42Ks3Wf";


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
                //SqlConnection con = new SqlConnection(@"Data Source=192.168.78.27\MSSQLSERVER2018;Initial Catalog=db_denunciasWeb;Persist Security Info=True;User ID=sa;Password=J@m09679933");

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
           // ddlProvincia.Items.Clear();
            ddlProvincia.ClearSelection();
            ddlProvincia.Items.FindByValue("0").Selected = true;

            //ddlProvincia.Items.Add("Seleccione Provincia");
            //DropDownList5.Items.Clear();
            //DropDownList5.Items.Add("Seleccione Provincia");

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

           // SqlConnection con = new SqlConnection(@"Data Source=192.168.78.27\MSSQLSERVER2018;Initial Catalog=db_denunciasWeb;Persist Security Info=True;User ID=sa;Password=J@m09679933");
          //  SqlConnection con = new SqlConnection(@"Data Source=Digemid556\MSSQLSERVER2018;Initial Catalog=db_denunciasWeb;Persist Security Info=True;User ID=sa;Password=J@m09679933");
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
           //ddlProvinciaPN.Items.Clear();
            ddlProvinciaPN.ClearSelection();
            ddlProvinciaPN.Items.FindByValue("0").Selected = true;
          //  ddlProvinciaPN.Items.Add("Seleccione Provincia");
            //DropDownList5.Items.Clear();
            //DropDownList5.Items.Add("Seleccione Provincia");

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

           // SqlConnection con = new SqlConnection(@"Data Source=192.168.78.27\MSSQLSERVER2018;Initial Catalog=db_denunciasWeb;Persist Security Info=True;User ID=sa;Password=J@m09679933");
            //SqlConnection con = new SqlConnection(@"Data Source=Digemid556\MSSQLSERVER2018;Initial Catalog=db_denunciasWeb;Persist Security Info=True;User ID=sa;Password=J@m09679933");
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
            // ddlDistrito.Items.Clear();
            ddlDistrito.ClearSelection();
            ddlDistrito.Items.FindByValue("0").Selected = true;
            // ddlDistrito.Items.Add("Seleccione Distrito");

            //DropDownList6.Items.Clear();
            //DropDownList6.Items.Add("Seleccione Distrito");


            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
           // SqlConnection con = new SqlConnection(@"Data Source=192.168.78.27\MSSQLSERVER2018;Initial Catalog=db_denunciasWeb;Persist Security Info=True;User ID=sa;Password=J@m09679933");
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
            //ddlDistritoPN.Items.Clear();
            ddlDistritoPN.ClearSelection();
            ddlDistritoPN.Items.FindByValue("0").Selected = true;
          //  ddlDistritoPN.Items.Add("Seleccione Distrito");

            //DropDownList6.Items.Clear();
            //DropDownList6.Items.Add("Seleccione Distrito");

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            //SqlConnection con = new SqlConnection(@"Data Source=192.168.78.27\MSSQLSERVER2018;Initial Catalog=db_denunciasWeb;Persist Security Info=True;User ID=sa;Password=J@m09679933");

           //SqlConnection con = new SqlConnection(@"Data Source=Digemid556\MSSQLSERVER2018;Initial Catalog=db_denunciasWeb;Persist Security Info=True;User ID=sa;Password=J@m09679933");
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



            if (ddlDepartamento.SelectedValue == "0")
            {
                lblError1.Text = "Por favor seleccione un Departamento";
                return;
            }
            else
            {
                lblError1.Text = "";

            }



            if (ddlProvincia.SelectedValue == "0")
            {
                lblError2.Text = "Por favor seleccione una Provincia";
                return;
            }
            else
            {
                lblError2.Text = "";

            }



            if (ddlDistrito.SelectedValue == "0")
            {
                lblError3.Text = "Por favor seleccione un Distrito";
                return;
            }
            else
            {
                lblError3.Text = "";

            }



            if (ddlDepartamentoPN.SelectedValue == "0")
            {
                lblError4.Text = "Por favor seleccione un Departamento";
                return;
            }
            else
            {
                lblError4.Text = "";

            }



            if (ddlProvinciaPN.SelectedValue == "0")
            {
                lblError5.Text = "Por favor seleccione una Provincia";
                return;
            }
            else
            {
                lblError5.Text = "";

            }



            if (ddlDistritoPN.SelectedValue == "0")
            {
                lblError6.Text = "Por favor seleccione un Distrito";
                return;
            }
            else
            {
                lblError6.Text = "";

            }







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




            #region INSERTO DATOS PERSONA NATURAL

            SqlConnection cnx_12 = new SqlConnection(ConfigurationManager.ConnectionStrings["BDDigemidConnection"].ConnectionString);

           // SqlConnection cnx_12 = new SqlConnection();
            SqlCommand cmd_12 = new SqlCommand();

            // cnx_12.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid  ; Persist Security Info=True;User ID=jañazco;Password=J09679933";
           // cnx_12.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=usrAppdenuncia;Password=Ykn42Ks3Wf";



            cnx_12.Open();
            cmd_12.Connection = cnx_12;
            cmd_12.CommandType = CommandType.StoredProcedure;
            cmd_12.CommandText = "dbo.SP_ET_INSERT_ETMESTABLECNOREG_1";







            cmd_12.Parameters.Add("@ESTNUMEINS_1", SqlDbType.VarChar).Value = pesonaNaturalCodigo;
            cmd_12.Parameters.Add("@ESTLUGAREG_2", SqlDbType.VarChar).Value = 1;
            cmd_12.Parameters.Add("@DSACODIGO_3", SqlDbType.VarChar).Value = "000";
            cmd_12.Parameters.Add("@CATCODIGO_4", SqlDbType.VarChar).Value = "";
            cmd_12.Parameters.Add("@TPRCODIGO_5", SqlDbType.VarChar).Value = "J";
            cmd_12.Parameters.Add("@TIDCODIGO_6", SqlDbType.VarChar).Value = "01";
            cmd_12.Parameters.Add("@ESTNUMEDOCID_7", SqlDbType.VarChar).Value = this.txtRUC.Text;
            cmd_12.Parameters.Add("@ESTNOMBCOM_8", SqlDbType.VarChar).Value = this.txtNombreComercial.Text;
            cmd_12.Parameters.Add("@ESTRAZONSOC_9", SqlDbType.VarChar).Value = this.txtRazonSocial.Text;
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



































































            ///////////// agregao procdeimeintos 120619
            SqlConnection cnx_2 = new SqlConnection(ConfigurationManager.ConnectionStrings["BDDigemidConnection"].ConnectionString);

          //  SqlConnection cnx_2 = new SqlConnection();
            SqlCommand cmd_2 = new SqlCommand();

            //cnx_2.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=jañazco;Password=J09679933";

         //   cnx_2.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=usrAppdenuncia;Password=Ykn42Ks3Wf";


            cnx_2.Open();
            cmd_2.Connection = cnx_2;
            cmd_2.CommandType = CommandType.StoredProcedure;
            cmd_2.CommandText = "dbo.SP_VG_INSERT_VGMDENUNCIA";



            cmd_2.Parameters.Add("@DSACODIGO_1", SqlDbType.VarChar).Value = "000";
            cmd_2.Parameters.Add("@DENCODIGO_2", SqlDbType.VarChar).Value = this.lblDenCodigo.Text;
            cmd_2.Parameters.Add("@DENFECHDEN_3", SqlDbType.DateTime).Value = Convert.ToDateTime(this.txtFechaRegistro.Text);
            cmd_2.Parameters.Add("@DENMEDICOM_4", SqlDbType.VarChar).Value = "06";
            cmd_2.Parameters.Add("@PERCODIGO_5", SqlDbType.VarChar).Value = "00566";
            cmd_2.Parameters.Add("@EXPCODIGO_6", SqlDbType.VarChar).Value = "";
            cmd_2.Parameters.Add("@EXPFECHREG_7", SqlDbType.DateTime).Value = Convert.ToDateTime(this.txtFechaRegistro.Text);
            cmd_2.Parameters.Add("@EXPNUMESEC_8", SqlDbType.Int).Value = 0;
            cmd_2.Parameters.Add("@DENTIPODEN1_9", SqlDbType.VarChar).Value = this.ddlTipoEstablecimiento1.Text;
            cmd_2.Parameters.Add("@ESTNUMEINS1_10", SqlDbType.VarChar).Value = "0000000";
            cmd_2.Parameters.Add("@DENNUMERUC1_11", SqlDbType.VarChar).Value = "";
            cmd_2.Parameters.Add("@CATCODIGO1_12", SqlDbType.VarChar).Value = "";
            cmd_2.Parameters.Add("@DENNOMBCOM1_13", SqlDbType.VarChar).Value = this.txtNombreestablecimiento.Text;
            cmd_2.Parameters.Add("@DENRAZONSOC1_14", SqlDbType.VarChar).Value = this.txtNombreestablecimiento.Text;
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
            cmd_2.Parameters.Add("@DENTIPODEN2_23", SqlDbType.VarChar).Value = "PJ" ;
            cmd_2.Parameters.Add("@DENINDIANON2_24", SqlDbType.Int).Value = anonimo;
            cmd_2.Parameters.Add("@ESTNUMEINS2_25", SqlDbType.VarChar).Value = pesonaNaturalCodigo;
            cmd_2.Parameters.Add("@DENNUMERUC2_26", SqlDbType.VarChar).Value = this.txtRUC.Text;
            cmd_2.Parameters.Add("@TIDCODIGO2_27", SqlDbType.VarChar).Value = "";
            cmd_2.Parameters.Add("@DENNUMEDOCID2_28", SqlDbType.VarChar).Value = "";
            cmd_2.Parameters.Add("@CATCODIGO2_29", SqlDbType.VarChar).Value = "";
            cmd_2.Parameters.Add("@DENNOMBCOM2_30", SqlDbType.VarChar).Value = this.txtNombreComercial.Text;
            cmd_2.Parameters.Add("@DENRAZONSOC2_31", SqlDbType.VarChar).Value = this.txtRazonSocial.Text;
            cmd_2.Parameters.Add("@DENNOMBCOMP2_32", SqlDbType.VarChar).Value = "";
            cmd_2.Parameters.Add("@DENDIRECCION2_33", SqlDbType.VarChar).Value = this.txtDireccion.Text;
            cmd_2.Parameters.Add("@DENURBANIZ2_34", SqlDbType.VarChar).Value = this.txtUrbanizacion.Text;
            cmd_2.Parameters.Add("@DENDIRENUME2_35", SqlDbType.VarChar).Value = this.txtNumero.Text;
            cmd_2.Parameters.Add("@DENINTERIOR2_36", SqlDbType.VarChar).Value = this.txtInterior.Text;
            cmd_2.Parameters.Add("@UBICODIGO2_37", SqlDbType.VarChar).Value = ubigPN;
            cmd_2.Parameters.Add("@DENNUMETLF2_38", SqlDbType.VarChar).Value = this.txtTelefono.Text;
            cmd_2.Parameters.Add("@DENFAX2_39", SqlDbType.VarChar).Value = "";
            cmd_2.Parameters.Add("@DENEMAIL2_40", SqlDbType.VarChar).Value = this.txtEmail.Text;
            cmd_2.Parameters.Add("@DENCOMENT_41", SqlDbType.VarChar).Value = this.txtMotivo.Text + " --Producto:   " + this.txtNombreProducto.Text;
            cmd_2.Parameters.Add("@DENINDIPROCEDE_42", SqlDbType.VarChar).Value = "S";
            cmd_2.Parameters.Add("@DENFECHREG_43", SqlDbType.DateTime).Value = Convert.ToDateTime(this.txtFechaRegistro.Text);
            cmd_2.Parameters.Add("@DENFECHULT_44", SqlDbType.DateTime).Value = Convert.ToDateTime(this.txtFechaRegistro.Text);
            cmd_2.Parameters.Add("@USRCODIGO_45", SqlDbType.VarChar).Value = "0521";
            cmd_2.Parameters.Add("@USRCODIGOULT_46", SqlDbType.VarChar).Value = "0521";





            cmd_2.ExecuteScalar();



            #region Correo


            var nroDenuncia = this.lblDenCodigo.Text;

            string body =
                "<body>" +
                "  <h1>  Se generó la denuncia número " + nroDenuncia + " </h1>   " +
                "</body>";




            SmtpClient smtp = new SmtpClient("10.10.3.208", 25);

            smtp.Credentials = new NetworkCredential("ahorromed@minsa.gob.pe", "Ahorromed3dminsa2023");
            //smtp.Credentials = new NetworkCredential("denunciaswebdigemid@gmail.com", "Digemid2020");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = false;
            // smtp.UseDefaultCredentials = false;
            MailMessage mail = new MailMessage();
            // mail.From = new MailAddress("denunciaswebdigemid@gmail.com", "Denuncia Web");
            mail.From = new MailAddress("ahorromed@minsa.gob.pe", "Denuncia Web");

            var correo = txtEmail.Text;
            mail.To.Add(new MailAddress(correo));

           // mail.To.Add(new MailAddress("ja1me_7@hotmail.com"));
            mail.Subject = "Se denuncia se generó correctamente";
            mail.IsBodyHtml = true;
            mail.Body = body;
            smtp.Send(mail);





            //     < add key = "SMTP_SERVER" value = "10.10.3.208" />

            //< add key = "PORT_SERVER" value = "25" />

            //   < add key = "EMAIL_GESTOR" value = "ahorromed@minsa.gob.pe" />

            //      < add key = "PASS_GESTOR" value = "D1gemid2018" />


            //                     < add key = "SSL" value = "false" />








            //var smtpSection = (SmtpSection)ConfigurationManager.GetSection("system.net/mailSettings/smtp");
            //string strHost = smtpSection.Network.Host;
            //int port = smtpSection.Network.Port;
            //string strUserName = smtpSection.Network.UserName;
            //string strFromPass = smtpSection.Network.Password;

            //SmtpClient smtp = new SmtpClient(strHost, port);
            //smtp.UseDefaultCredentials = true;

            //NetworkCredential cert = new NetworkCredential(strUserName, strFromPass);
            //smtp.Credentials = cert;
            //smtp.EnableSsl = false;


            //var Email = "ja1me_7@hotmail.com";

            //MailMessage msg = new MailMessage(smtpSection.From, Email);
            //msg.Subject = "Este es el asunto";
            //msg.IsBodyHtml = true;
            //msg.Body += "Texto 1 del cuerpo del correo";
            //msg.Body += "Texto 2 del cuerpo del correo";
            //msg.Body += "Texto 3 del cuerpo del correo";
            //smtp.Send(msg);
            #endregion


            #region llenarTablaMotivoDenuncia





            //      @MOTCODIGO_4  INTEGER, 
            //@MOTCODIGODET_5 INTEGER,
            //      @DENPUNTAJE_6 INTEGER

            if (chkFalsificados1.Selected)
            {



                uno = 1;
                dos = 0;
                tres = 0;
                cuatro = 0;
                cinco = 0;
                seis = 0;
                siete = 0;
                ocho = 0;












                SqlConnection cnx_3 = new SqlConnection(ConfigurationManager.ConnectionStrings["BDDigemidConnection"].ConnectionString);

              //  SqlConnection cnx_3 = new SqlConnection();
                SqlCommand cmd_3 = new SqlCommand();

               // cnx_3.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=jañazco;Password=J09679933";
              // cnx_3.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=usrAppdenuncia;Password=Ykn42Ks3Wf";

                cnx_3.Open();
                cmd_3.Connection = cnx_2;
                cmd_3.CommandType = CommandType.StoredProcedure;
                cmd_3.CommandText = "dbo.SP_VG_INSERT_VGMDENUNMOT";



                cmd_3.Parameters.Add("@DSACODIGO_1", SqlDbType.VarChar).Value = "000";
                cmd_3.Parameters.Add("@DENCODIGO_2", SqlDbType.VarChar).Value = this.lblDenCodigo.Text;
                cmd_3.Parameters.Add("@DENNUMESEC_3", SqlDbType.Int).Value = contador;

                cmd_3.Parameters.Add("@MOTCODIGO_4", SqlDbType.Int).Value = 1;
                cmd_3.Parameters.Add("@MOTCODIGODET_5", SqlDbType.Int).Value = 1;
                cmd_3.Parameters.Add("@DENPUNTAJE_6", SqlDbType.Int).Value = 5;


                cmd_3.ExecuteScalar();

                cnx_3.Close();
                contador++;
            }







            if (chkVencidos1.Selected)
            {



                if (chkFalsificados1.Selected)
                {
                    
                    dos = 2;
                }
                else
                {
                    dos = 1;
                }






                SqlConnection cnx_3 = new SqlConnection(ConfigurationManager.ConnectionStrings["BDDigemidConnection"].ConnectionString);
               // SqlConnection cnx_3 = new SqlConnection();
                SqlCommand cmd_3 = new SqlCommand();

               // cnx_3.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=jañazco;Password=J09679933";

              //  cnx_3.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=usrAppdenuncia;Password=Ykn42Ks3Wf";


                cnx_3.Open();
                cmd_3.Connection = cnx_2;
                cmd_3.CommandType = CommandType.StoredProcedure;
                cmd_3.CommandText = "dbo.SP_VG_INSERT_VGMDENUNMOT";



                cmd_3.Parameters.Add("@DSACODIGO_1", SqlDbType.VarChar).Value = "000";
                cmd_3.Parameters.Add("@DENCODIGO_2", SqlDbType.VarChar).Value = this.lblDenCodigo.Text;
                cmd_3.Parameters.Add("@DENNUMESEC_3", SqlDbType.Int).Value = contador;

                cmd_3.Parameters.Add("@MOTCODIGO_4", SqlDbType.Int).Value = 1;
                cmd_3.Parameters.Add("@MOTCODIGODET_5", SqlDbType.Int).Value = 2;
                cmd_3.Parameters.Add("@DENPUNTAJE_6", SqlDbType.Int).Value = 5;


                cmd_3.ExecuteScalar();

                cnx_3.Close();
                contador++;
            }





            if (chkProcDesconocida1.Selected)
            {



                if ((chkFalsificados1.Selected) && (chkVencidos1.Selected))
                {

                    tres = 3;
                }
                else if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = false))
                {
                    tres = 1;
                }
                else if ((chkFalsificados1.Selected = true) && (chkVencidos1.Selected = false))
                {
                    tres = 2;
                }
                else if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = true))
                {
                    tres = 2;
                }














                SqlConnection cnx_3 = new SqlConnection(ConfigurationManager.ConnectionStrings["BDDigemidConnection"].ConnectionString);
               // SqlConnection cnx_3 = new SqlConnection();
                SqlCommand cmd_3 = new SqlCommand();

                //cnx_3.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=jañazco;Password=J09679933";

               // cnx_3.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=usrAppdenuncia;Password=Ykn42Ks3Wf";

                cnx_3.Open();
                cmd_3.Connection = cnx_2;
                cmd_3.CommandType = CommandType.StoredProcedure;
                cmd_3.CommandText = "dbo.SP_VG_INSERT_VGMDENUNMOT";



                cmd_3.Parameters.Add("@DSACODIGO_1", SqlDbType.VarChar).Value = "000";
                cmd_3.Parameters.Add("@DENCODIGO_2", SqlDbType.VarChar).Value = this.lblDenCodigo.Text;
                cmd_3.Parameters.Add("@DENNUMESEC_3", SqlDbType.Int).Value = contador;

                cmd_3.Parameters.Add("@MOTCODIGO_4", SqlDbType.Int).Value = 1;
                cmd_3.Parameters.Add("@MOTCODIGODET_5", SqlDbType.Int).Value = 3;
                cmd_3.Parameters.Add("@DENPUNTAJE_6", SqlDbType.Int).Value = 4;


                cmd_3.ExecuteScalar();

                cnx_3.Close();
                contador++;
            }




            if (chkRotAdulterado1.Selected)
            {



                if ((chkFalsificados1.Selected) && (chkVencidos1.Selected) && (chkProcDesconocida1.Selected))
                {

                    cuatro = 4;
                }
                else if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = false))
                {
                    cuatro = 1;
                }
                else if ((chkFalsificados1.Selected = true) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = false))
                {
                    cuatro = 2;
                }
                else if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = true) && (chkProcDesconocida1.Selected = false))
                {
                    cuatro = 2;
                }
                else if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = true))
                {
                    cuatro = 2;
                }
                else if ((chkFalsificados1.Selected = true) && (chkVencidos1.Selected = true) && (chkProcDesconocida1.Selected = false))
                {
                    cuatro = 3;
                }
                else if ((chkFalsificados1.Selected = true) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = true))
                {
                    cuatro = 3;
                }
                else if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = true) && (chkProcDesconocida1.Selected = true))
                {
                    cuatro = 3;
                }
















                SqlConnection cnx_3 = new SqlConnection(ConfigurationManager.ConnectionStrings["BDDigemidConnection"].ConnectionString);
                //SqlConnection cnx_3 = new SqlConnection();
                SqlCommand cmd_3 = new SqlCommand();

                //cnx_3.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=jañazco;Password=J09679933";

              //  cnx_3.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=usrAppdenuncia;Password=Ykn42Ks3Wf";



                cnx_3.Open();
                cmd_3.Connection = cnx_2;
                cmd_3.CommandType = CommandType.StoredProcedure;
                cmd_3.CommandText = "dbo.SP_VG_INSERT_VGMDENUNMOT";



                cmd_3.Parameters.Add("@DSACODIGO_1", SqlDbType.VarChar).Value = "000";
                cmd_3.Parameters.Add("@DENCODIGO_2", SqlDbType.VarChar).Value = this.lblDenCodigo.Text;
                cmd_3.Parameters.Add("@DENNUMESEC_3", SqlDbType.Int).Value = contador;

                cmd_3.Parameters.Add("@MOTCODIGO_4", SqlDbType.Int).Value = 1;
                cmd_3.Parameters.Add("@MOTCODIGODET_5", SqlDbType.Int).Value = 4;
                cmd_3.Parameters.Add("@DENPUNTAJE_6", SqlDbType.Int).Value = 4;


                cmd_3.ExecuteScalar();

                cnx_3.Close();
                contador++;
            }



            if (chksinRS1.Selected)
            {





                if ((chkFalsificados1.Selected) && (chkVencidos1.Selected) && (chkProcDesconocida1.Selected) && (chkRotAdulterado1.Selected))
                {

                    cinco = 5;
                }
                else if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = false) && (chkRotAdulterado1.Selected = false))
                {
                    cinco = 1;
                }
                else if ((chkFalsificados1.Selected = true) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = false) && (chkRotAdulterado1.Selected = false))
                {
                    cinco = 2;
                }
                else if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = true) && (chkProcDesconocida1.Selected = false) && (chkRotAdulterado1.Selected = false))
                {
                    cinco = 2;
                }
                else if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = true) && (chkRotAdulterado1.Selected = false))
                {
                    cinco = 2;
                }
                else if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = false) && (chkRotAdulterado1.Selected = true))
                {
                    cinco = 2;
                }
                else if ((chkFalsificados1.Selected = true) && (chkVencidos1.Selected = true) && (chkProcDesconocida1.Selected = false) && (chkRotAdulterado1.Selected = false))
                {
                    cinco = 3;
                }
                else if ((chkFalsificados1.Selected = true) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = true) && (chkRotAdulterado1.Selected = false))
                {
                    cinco = 3;
                }
                else if ((chkFalsificados1.Selected = true) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = false) && (chkRotAdulterado1.Selected = true))
                {
                    cinco = 3;
                }
                else if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = true) && (chkProcDesconocida1.Selected = true) && (chkRotAdulterado1.Selected = false))
                {
                    cinco = 3;
                }
                else if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = true) && (chkProcDesconocida1.Selected = false) && (chkRotAdulterado1.Selected = true))
                {
                    cinco = 3;
                }
                else if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = true) && (chkRotAdulterado1.Selected = true))
                {
                    cinco = 3;
                }
                else if ((chkFalsificados1.Selected = true) && (chkVencidos1.Selected = true) && (chkProcDesconocida1.Selected = true) && (chkRotAdulterado1.Selected = false))
                {
                    cinco = 4;
                }
                else if ((chkFalsificados1.Selected = true) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = true) && (chkRotAdulterado1.Selected = true))
                {
                    cinco = 4;
                }
                else if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = true) && (chkProcDesconocida1.Selected = true) && (chkRotAdulterado1.Selected = true))
                {
                    cinco = 4;
                }
                else if ((chkFalsificados1.Selected = true) && (chkVencidos1.Selected = true) && (chkProcDesconocida1.Selected = false) && (chkRotAdulterado1.Selected = true))
                {
                    cinco = 4;
                }





















                SqlConnection cnx_3 = new SqlConnection(ConfigurationManager.ConnectionStrings["BDDigemidConnection"].ConnectionString);

              // SqlConnection cnx_3 = new SqlConnection();
                SqlCommand cmd_3 = new SqlCommand();

                //cnx_3.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=jañazco;Password=J09679933";

              //  cnx_3.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=usrAppdenuncia;Password=Ykn42Ks3Wf";



                cnx_3.Open();
                cmd_3.Connection = cnx_2;
                cmd_3.CommandType = CommandType.StoredProcedure;
                cmd_3.CommandText = "dbo.SP_VG_INSERT_VGMDENUNMOT";



                cmd_3.Parameters.Add("@DSACODIGO_1", SqlDbType.VarChar).Value = "000";
                cmd_3.Parameters.Add("@DENCODIGO_2", SqlDbType.VarChar).Value = this.lblDenCodigo.Text;
                cmd_3.Parameters.Add("@DENNUMESEC_3", SqlDbType.Int).Value = contador;

                cmd_3.Parameters.Add("@MOTCODIGO_4", SqlDbType.Int).Value = 1;
                cmd_3.Parameters.Add("@MOTCODIGODET_5", SqlDbType.Int).Value = 5;
                cmd_3.Parameters.Add("@DENPUNTAJE_6", SqlDbType.Int).Value = 3;


                cmd_3.ExecuteScalar();

                cnx_3.Close();
                contador++;
            }



            if (chkProdPublico1.Selected)
            {


                if ((chkFalsificados1.Selected) && (chkVencidos1.Selected) && (chkProcDesconocida1.Selected) && (chkRotAdulterado1.Selected) && (chksinRS1.Selected))
                {

                    seis = 6;
                }
                else if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = false) && (chkRotAdulterado1.Selected = false)
                     && (chksinRS1.Selected = false))
                {
                    seis = 1;
                }
                else if ((chkFalsificados1.Selected = true) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = false) && (chkRotAdulterado1.Selected = false)
                    && (chksinRS1.Selected = false))
                {
                    seis = 2;
                }
                else if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = true) && (chkProcDesconocida1.Selected = false) && (chkRotAdulterado1.Selected = false)
                    && (chksinRS1.Selected = false))
                {
                    seis = 2;
                }
                else if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = true) && (chkRotAdulterado1.Selected = false)
                    && (chksinRS1.Selected = false))
                {
                    seis = 2;
                }
                else if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = false) && (chkRotAdulterado1.Selected = true)
                    && (chksinRS1.Selected = false))
                {
                    seis = 2;
                }
                else if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = false) && (chkRotAdulterado1.Selected = false)
                    && (chksinRS1.Selected = true))
                {
                    seis = 2;
                }
                else if ((chkFalsificados1.Selected = true) && (chkVencidos1.Selected = true) && (chkProcDesconocida1.Selected = false) && (chkRotAdulterado1.Selected = false)
                    && (chksinRS1.Selected = false))
                {
                    seis = 3;
                }
                else if ((chkFalsificados1.Selected = true) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = true) && (chkRotAdulterado1.Selected = false)
                    && (chksinRS1.Selected = false))
                {
                    seis = 3;
                }
                else if ((chkFalsificados1.Selected = true) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = false) && (chkRotAdulterado1.Selected = true)
                    && (chksinRS1.Selected = false))
                {
                    seis = 3;
                }
                else if ((chkFalsificados1.Selected = true) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = false) && (chkRotAdulterado1.Selected = false)
                    && (chksinRS1.Selected = true))
                {
                    seis = 3;
                }
                else if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = true) && (chkProcDesconocida1.Selected = true) && (chkRotAdulterado1.Selected = false)
                    && (chksinRS1.Selected = false))
                {
                    seis = 3;
                }
                else if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = true) && (chkProcDesconocida1.Selected = false) && (chkRotAdulterado1.Selected = true)
                   && (chksinRS1.Selected = false))
                {
                    seis = 3;
                }
                else if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = true) && (chkProcDesconocida1.Selected = false) && (chkRotAdulterado1.Selected = false)
                   && (chksinRS1.Selected = true))
                {
                    seis = 3;
                }
                else if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = true) && (chkRotAdulterado1.Selected = true)
                   && (chksinRS1.Selected = false))
                {
                    seis = 3;
                }
                else if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = true) && (chkRotAdulterado1.Selected = false)
                  && (chksinRS1.Selected = true))
                {
                    seis = 3;
                }
                else if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = false) && (chkRotAdulterado1.Selected = true)
                 && (chksinRS1.Selected = true))
                {
                    seis = 3;
                }
                else if ((chkFalsificados1.Selected = true) && (chkVencidos1.Selected = true) && (chkProcDesconocida1.Selected = true) && (chkRotAdulterado1.Selected = false)
                && (chksinRS1.Selected = false))
                {
                    seis = 4;
                }
                else if ((chkFalsificados1.Selected = true) && (chkVencidos1.Selected = true) && (chkProcDesconocida1.Selected = false) && (chkRotAdulterado1.Selected = true)
               && (chksinRS1.Selected = false))
                {
                    seis = 4;
                }
                else if ((chkFalsificados1.Selected = true) && (chkVencidos1.Selected = true) && (chkProcDesconocida1.Selected = false) && (chkRotAdulterado1.Selected = false)
               && (chksinRS1.Selected = true))
                {
                    seis = 4;
                }
                else if ((chkFalsificados1.Selected = true) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = true) && (chkRotAdulterado1.Selected = true)
               && (chksinRS1.Selected = false))
                {
                    seis = 4;
                }
                else if ((chkFalsificados1.Selected = true) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = true) && (chkRotAdulterado1.Selected = false)
              && (chksinRS1.Selected = true))
                {
                    seis = 4;
                }
                else if ((chkFalsificados1.Selected = true) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = false) && (chkRotAdulterado1.Selected = true)
              && (chksinRS1.Selected = true))
                {
                    seis = 4;
                }
                else if ((chkFalsificados1.Selected = true) && (chkVencidos1.Selected = true) && (chkProcDesconocida1.Selected = true) && (chkRotAdulterado1.Selected = true)
             && (chksinRS1.Selected = false))
                {
                    seis = 5;
                }
                else if ((chkFalsificados1.Selected = true) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = true) && (chkRotAdulterado1.Selected = true)
            && (chksinRS1.Selected = true))
                {
                    seis = 5;
                }
                else if ((chkFalsificados1.Selected = true) && (chkVencidos1.Selected = true) && (chkProcDesconocida1.Selected = false) && (chkRotAdulterado1.Selected = true)
          && (chksinRS1.Selected = true))
                {
                    seis = 5;
                }
                else if ((chkFalsificados1.Selected = true) && (chkVencidos1.Selected = true) && (chkProcDesconocida1.Selected = true) && (chkRotAdulterado1.Selected = false)
          && (chksinRS1.Selected = true))
                {
                    seis = 5;
                }
                else if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = true) && (chkProcDesconocida1.Selected = true) && (chkRotAdulterado1.Selected = true)
        && (chksinRS1.Selected = true))
                {
                    seis = 5;
                }

















                SqlConnection cnx_3 = new SqlConnection(ConfigurationManager.ConnectionStrings["BDDigemidConnection"].ConnectionString);
               // SqlConnection cnx_3 = new SqlConnection();
                SqlCommand cmd_3 = new SqlCommand();

               // cnx_3.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=jañazco;Password=J09679933";

               // cnx_3.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=usrAppdenuncia;Password=Ykn42Ks3Wf";

                cnx_3.Open();
                cmd_3.Connection = cnx_2;
                cmd_3.CommandType = CommandType.StoredProcedure;
                cmd_3.CommandText = "dbo.SP_VG_INSERT_VGMDENUNMOT";



                cmd_3.Parameters.Add("@DSACODIGO_1", SqlDbType.VarChar).Value = "000";
                cmd_3.Parameters.Add("@DENCODIGO_2", SqlDbType.VarChar).Value = this.lblDenCodigo.Text;
                cmd_3.Parameters.Add("@DENNUMESEC_3", SqlDbType.Int).Value = contador;

                cmd_3.Parameters.Add("@MOTCODIGO_4", SqlDbType.Int).Value = 1;
                cmd_3.Parameters.Add("@MOTCODIGODET_5", SqlDbType.Int).Value = 6;
                cmd_3.Parameters.Add("@DENPUNTAJE_6", SqlDbType.Int).Value = 2;


                cmd_3.ExecuteScalar();

                cnx_3.Close();
                contador++;
            }



            if (chkMuestraMedica1.Selected)
            {






                if ((chkFalsificados1.Selected) && (chkVencidos1.Selected) && (chkProcDesconocida1.Selected) && (chkRotAdulterado1.Selected) && (chksinRS1.Selected)
                   && (chkProdPublico1.Selected))
                {

                    siete = 7;
                }

                if ((chkFalsificados1.Selected = true) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = false) && (chkRotAdulterado1.Selected = false)
                    && (chksinRS1.Selected = false) && (chkProdPublico1.Selected = false))
                {

                    siete = 1;
                }
                if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = true) && (chkProcDesconocida1.Selected = false) && (chkRotAdulterado1.Selected = false)
                   && (chksinRS1.Selected = false) && (chkProdPublico1.Selected = false))
                {

                    siete = 1;
                }
                if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = true) && (chkRotAdulterado1.Selected = false)
                  && (chksinRS1.Selected = false) && (chkProdPublico1.Selected = false))
                {

                    siete = 1;
                }
                if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = false) && (chkRotAdulterado1.Selected = true)
                  && (chksinRS1.Selected = false) && (chkProdPublico1.Selected = false))
                {

                    siete = 1;
                }
                if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = false) && (chkRotAdulterado1.Selected = false)
                  && (chksinRS1.Selected = true) && (chkProdPublico1.Selected = false))
                {

                    siete = 1;
                }
                if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = false) && (chkRotAdulterado1.Selected = false)
                  && (chksinRS1.Selected = false) && (chkProdPublico1.Selected = true))
                {

                    siete = 1;
                }
                if ((chkFalsificados1.Selected = false) && (chkVencidos1.Selected = false) && (chkProcDesconocida1.Selected = false) && (chkRotAdulterado1.Selected = false)
                  && (chksinRS1.Selected = false) && (chkProdPublico1.Selected = true))
                {

                    siete = 1;
                }







                SqlConnection cnx_3 = new SqlConnection(ConfigurationManager.ConnectionStrings["BDDigemidConnection"].ConnectionString);

              // SqlConnection cnx_3 = new SqlConnection();
                SqlCommand cmd_3 = new SqlCommand();

               // cnx_3.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=jañazco;Password=J09679933";

               // cnx_3.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=usrAppdenuncia;Password=Ykn42Ks3Wf";



                cnx_3.Open();
                cmd_3.Connection = cnx_2;
                cmd_3.CommandType = CommandType.StoredProcedure;
                cmd_3.CommandText = "dbo.SP_VG_INSERT_VGMDENUNMOT";



                cmd_3.Parameters.Add("@DSACODIGO_1", SqlDbType.VarChar).Value = "000";
                cmd_3.Parameters.Add("@DENCODIGO_2", SqlDbType.VarChar).Value = this.lblDenCodigo.Text;
                cmd_3.Parameters.Add("@DENNUMESEC_3", SqlDbType.Int).Value = contador;

                cmd_3.Parameters.Add("@MOTCODIGO_4", SqlDbType.Int).Value = 1;
                cmd_3.Parameters.Add("@MOTCODIGODET_5", SqlDbType.Int).Value = 7;
                cmd_3.Parameters.Add("@DENPUNTAJE_6", SqlDbType.Int).Value = 2;


                cmd_3.ExecuteScalar();

                cnx_3.Close();
                contador++;
            }


            if (chkMalEstado1.Selected)
            {

                SqlConnection cnx_3 = new SqlConnection(ConfigurationManager.ConnectionStrings["BDDigemidConnection"].ConnectionString);
                //SqlConnection cnx_3 = new SqlConnection();
                SqlCommand cmd_3 = new SqlCommand();

              //  cnx_3.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=jañazco;Password=J09679933";

              //  cnx_3.ConnectionString = "Data Source=serverprod;Initial Catalog=BDDigemid;Persist Security Info=True;User ID=usrAppdenuncia;Password=Ykn42Ks3Wf";



                cnx_3.Open();
                cmd_3.Connection = cnx_2;
                cmd_3.CommandType = CommandType.StoredProcedure;
                cmd_3.CommandText = "dbo.SP_VG_INSERT_VGMDENUNMOT";



                cmd_3.Parameters.Add("@DSACODIGO_1", SqlDbType.VarChar).Value = "000";
                cmd_3.Parameters.Add("@DENCODIGO_2", SqlDbType.VarChar).Value = this.lblDenCodigo.Text;
                cmd_3.Parameters.Add("@DENNUMESEC_3", SqlDbType.Int).Value = contador;

                cmd_3.Parameters.Add("@MOTCODIGO_4", SqlDbType.Int).Value = 1;
                cmd_3.Parameters.Add("@MOTCODIGODET_5", SqlDbType.Int).Value = 8;
                cmd_3.Parameters.Add("@DENPUNTAJE_6", SqlDbType.Int).Value = 1;


                cmd_3.ExecuteScalar();

                cnx_3.Close();
                contador++;
            }


            #endregion













            lblestado.Text = "Registrado correctamente";

            MessageBox.Show(Page, "Su denuncia se generó correctamente , revise la bandeja del correo ingresado para mayor información");

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
            //cmd.Parameters.Add("@aFalsificado", SqlDbType.Bit).Value = this.chkFalsificados1.Selected;
            //cmd.Parameters.Add("@aVencido", SqlDbType.Bit).Value = this.chkVencidos1.Selected;
            //cmd.Parameters.Add("@aMalEstado", SqlDbType.Bit).Value = this.chkMalEstado1.Selected;
            //cmd.Parameters.Add("@aSinRS", SqlDbType.Bit).Value = this.chksinRS1.Selected;
            //cmd.Parameters.Add("@aProcDesconocida", SqlDbType.Bit).Value = this.chkProcDesconocida1.Selected;
            //cmd.Parameters.Add("@aRotuladoAdBo", SqlDbType.Bit).Value = this.chkRotAdulterado1.Selected;
            //cmd.Parameters.Add("@aMuestraMedica", SqlDbType.Bit).Value = this.chkMuestraMedica1.Selected;
            //cmd.Parameters.Add("@aProductoPublico", SqlDbType.Bit).Value = this.chkProdPublico1.Selected;
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