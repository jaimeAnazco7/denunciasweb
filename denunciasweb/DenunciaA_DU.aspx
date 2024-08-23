<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DenunciaA_DU.aspx.cs" Inherits="denunciasWeb.DenunciaA_DU" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <!-- #region script permite recordr el estado de un panel colapsado o expandido -->
                     

    <script> 

        function getCookie(cname) {
  var name = cname + "=";
  var ca = document.cookie.split(';');
  for (var i = 0; i < ca.length; i++) {
    var c = ca[i];
    while (c.charAt(0) == ' ') c = c.substring(1);
    if (c.indexOf(name) != -1) {
      return c.substring(name.length, c.length);
    }
  }
  return "";
}

function setCookie(sectionName) {
  var lastState = getCookie(sectionName);
  if (lastState == "" || lastState == "off") {
    document.cookie = sectionName + "=on";
  }
  else {
    document.cookie = sectionName + "=off";
  }
}

function setState() {
  if (getCookie("collapse2") == "" || getCookie("collapse2") == "off") {
    document.getElementById("collapse2").className = "collapse";
  }
  else {
    document.getElementById("collapse2").className = "collapse in";
  }

  //if (getCookie("Panel2") == "" || getCookie("Panel2") == "off") {
  //  document.getElementById("Panel2").className = "collapse";
  //}
  //else {
  //  document.getElementById("Panel2").className = "collapse in";
  //}
}








    </script>





    <!-- #endregion -->


  <div class="page-header">
        <h1>DENUNCIAS EN LÍNEA &nbsp &nbsp &nbsp 
            <asp:Label ID="lblDenCodigo" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="lblPersonaNaturalCodigo" runat="server" Text="Label"></asp:Label>
            <asp:RadioButton ID="rbAnonimo" runat="server" />
            <br />
            <br />
            <h4 style="box-sizing: border-box; font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-weight: 500; line-height: 1.1; color: rgb(51, 51, 51); margin-top: 10px; margin-bottom: 10px; font-size: 18px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial;">DENUNCIA A BOTICA, FARMACIA O FARMACIA DE ESTABLECIMIENTO DE SALUD PRIVADO POR NO CONTAR CON MEDICAMENTOS ESENCIALES GENÉRICOS CONTENIDOS EN EL LISTADO DE LA R.M. N° 220-2024/MINSA EN EL MARCO DE LA LEY N° 32033, DISPONIBLES A LA VENTA.</h4>
            <h4>&nbsp;</h4></h1>

    </div>

  <nav class="navbar navbar-default">
  <div class="container-fluid">
  <div class="container-fluid">
    <div class="navbar-header">
      <a class="navbar-brand" href="#"><strong>Elija el Tipo de Denuncia</strong></a>
    </div>
    <ul class="nav navbar-nav">
      
      <li class="active"><a href="DenunciaA_DU">Anónima</a></li>
      <li><a href="DenunciaP_DU">Persona Natural</a></li>
      <%--<li><a href="DenunciaE">Empresa Institución</a></li>--%>
    </ul>
  </div>
</nav>
    
    <div class="panel panel-default">
        <div class="panel-heading">
            <%--    <br />--%>
            <h4><b> Registro de Datos del Denunciante </b></h4>

            <%-- <br />--%>
        </div>



        <div class="panel-body">


        





            <div class="form-group">
                <asp:Label ID="Label1" for="txtFechaRegistro" runat="server" Text="Fecha de Registro" Font-Bold="True"></asp:Label>
                 <asp:TextBox ID="txtFechaRegistro" class="form-control" runat="server"></asp:TextBox>
            </div>



            
            








<div class="panel-group" id="accordion">
  <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title">
        <a data-toggle="collapse" data-parent="#accordion" href="#collapse1">
        Anónimo</a>
      </h4>
    </div>
    <div id="collapse1" class="panel-collapse collapse in">
      <div class="panel-body">
         
   
    <label > <strong>El denunciante no brinda información de sus datos No podrá tener información de las acciones realizadas en atención a su denuncia</strong></label>
 
    </div>
  </div>



</div>



           









           


            <div class="form-group">











                <%--     <script type="text/javascript">
            function changetextbox() {
                if (document.getElementById("DropDownList1").value === "Anónimo") {
                    document.getElementById("TextBox1").disable = 'true';
                } else {
                    document.getElementById("TextBox1").disable = 'false';
                }
            }
        </script>--%>



                <%-- <asp:Label ID="Label1" runat="server" Text="Tipo de Persona"></asp:Label>

    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="descrip_tipoPersona" DataValueField="id_tipoPersona">
    </asp:DropDownList>--%>
                <%-- </div>--%>

                <div id="div11" class="hideDiv">

                    <%--<div class="datosPersonaNatural" style="display: flex; justify-content: space-between; flex-direction:column;  width: 100%;">
                        <div class="form-group" style="margin-right: 10px;">
                            <asp:Label ID="Label2" For="txtNombreApellidos" Font-Bold="True" runat="server" Text="Nombres y Apellidos"></asp:Label>
                            <asp:TextBox ID="txtNombreApellidos" class="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label3" For="txtDNI" Font-Bold="True" runat="server" Text="DNI"></asp:Label>
                            <asp:TextBox ID="txtDNI" class="form-control" runat="server"></asp:TextBox>
                        </div>
                        <br />  
                         <div class="form-group">
                            <asp:Label ID="Label22" For="txtDireccion" Font-Bold="True" runat="server" Text="Dirección"></asp:Label>
                            <asp:TextBox ID="txtDireccion" class="form-control" runat="server"></asp:TextBox>
                        </div>
                         <div class="form-group">
                            <asp:Label ID="Label23" For="txtUrbanizacion" Font-Bold="True" runat="server" Text="Urbanización"></asp:Label>
                            <asp:TextBox ID="txtUrbanizacion" class="form-control" runat="server"></asp:TextBox>
                        </div>

                         <div class="form-group">
                            <asp:Label ID="Label24" For="txtNumero" Font-Bold="True" runat="server" Text="Número"></asp:Label>
                            <asp:TextBox ID="txtNumero" class="form-control" runat="server"></asp:TextBox>


                        </div>
                         <div class="form-group">
                            <asp:Label ID="Label25" For="txtInterior" Font-Bold="True" runat="server" Text="Interior"></asp:Label>
                            <asp:TextBox ID="txtInterior" class="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>--%>






                    




































                </div>

           

           


                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT * FROM [tb_tipoPersona]"></asp:SqlDataSource>

            </div>

        </div>





























        <hr>

        <div class="panel panel-default">

            <div class="panel-heading">
                <h4><b> Registro de Datos del Medicamento </b></h4>
            </div>
            <div class="panel-body">
               <%-- <p>
                    Las modalidades del comercio ilegal de los productos farmacéuticos, dispositivos médicos y productos sanitarios
        (check list, se puede seleccionar 1 o más de 1)
                </p>--%>


                <%--<div style="display: flex;">
                    <div class="form-check  " style="margin-right: 10px">
                        <asp:CheckBox class="form-check-input" ID="chkFalsificados" runat="server" Text="Falsificados" />
                    </div>
                    <div class="form-check" style="margin-right: 10px">
                        <asp:CheckBox ID="chkVencidos" runat="server" Text="Vencidos" />
                    </div>

                    <div class="form-check" style="margin-right: 10px">
                        <asp:CheckBox ID="chkProcDesconocida" runat="server" Text="Procedencia Desconocida" />
                    </div>
                    <div class="form-check" style="margin-right: 10px">
                        <asp:CheckBox ID="chkRotAdulterado" runat="server" Text="Rotulado Adulterado Borrado" />
                    </div>

                   
                   
                </div>--%>


             <%--   <div style="display: flex;">
                    

                     <div class="form-check" style="margin-right: 10px">
                        <asp:CheckBox ID="chksinRS" runat="server" Text="Sin Registro Sanitario" />
                    </div>

                     <div class="form-check" style="margin-right: 10px">
                        <asp:CheckBox ID="chkProdPublico" runat="server" Text="Producto de Institución Pública" />

                    </div>
                    
                    <div class="form-check" style="margin-right: 10px">
                        <asp:CheckBox ID="chkMuestraMedica" runat="server" Text="Muestra Médica" />
                    </div>
                   

                     <div class="form-check" style="margin-right: 10px">
                        <asp:CheckBox ID="chkMalEstado" runat="server" Text="Mal estado de Conservación" />
                    </div>
                </div>--%>
                <br />



                                  
                      <%--<div class="form-row">
                        <div class="form-group col-md-6">
                          <label for="inputEmail4">Email</label>
                          <input type="email" class="form-control" id="inputEmail4" placeholder="Email">
                        </div>
                        <div class="form-group col-md-6">
                          <label for="inputPassword4">Password</label>
                          <input type="password" class="form-control" id="inputPassword4" placeholder="Password">
                        </div>
                      </div>--%>
                   
                     
                      <div class="form-row">
                            <div class="form-group col-md-1">
                          <label>1.</label>
                          
                        </div>
                        <div class="form-group col-md-6">
                          <label for="inputNombre1">Nombre del Producto</label>
                             <asp:TextBox ID="inputNombre1" class="form-control" runat="server"></asp:TextBox>
                           <%--<input type="text" class="form-control" id="inputNombre1">--%>
                        </div>
                        <div class="form-group col-md-3">
                           <label for="inputConcentracion1">Concentracion</label>
                             <asp:TextBox ID="inputConcentracion1" class="form-control" runat="server"></asp:TextBox>
                          <%--<input type="text" class="form-control" id="inputConcentracion1">--%>
                        </div>
                        <div class="form-group col-md-2">
                          <label for="inputFF1">Form. Farm.</label>
                             <asp:TextBox ID="inputFF1" class="form-control" runat="server"></asp:TextBox>
                          <%--<input type="text" class="form-control" id="inputFF1">--%>
                        </div>
                      </div>
                     
                      
                  <div class="form-row">
                      <div class="form-group col-md-1">
                          <label>2.</label>
                          </div>    
                        <div class="form-group col-md-6">
                          <label for="inputNombre2">Nombre del Producto</label>
                            <asp:TextBox ID="inputNombre2" class="form-control" runat="server"></asp:TextBox>
                          <%--<input type="text" class="form-control" id="inputNombre2">--%>
                        </div>
                        <div class="form-group col-md-3">
                           <label for="inputConcentracion2">Concentracion</label>
                            <asp:TextBox ID="inputConcentracion2" class="form-control" runat="server"></asp:TextBox>
                          <%--<input type="text" class="form-control" id="inputConcentracion2">--%>
                        </div>
                        <div class="form-group col-md-2">
                          <label for="inputFF2">Form. Farm.</label>
                            <asp:TextBox ID="inputFF2" class="form-control" runat="server"></asp:TextBox>
                          <%--<input type="text" class="form-control" id="inputFF2">--%>
                        </div>
                      </div>
                     
                  

                 <div class="form-row">
                     <div class="form-group col-md-1">
                          <label>3.</label> 

                     </div>

                        <div class="form-group col-md-6">
                          <label for="inputNombre3">Nombre del Producto</label>
                            <asp:TextBox ID="inputNombre3" class="form-control" runat="server"></asp:TextBox>
                          <%--<input type="text" class="form-control" id="inputNombre3">--%>
                        </div>
                        <div class="form-group col-md-3">
                           <label for="inputConcentracion3">Concentracion</label>
                            <asp:TextBox ID="inputConcentracion3" class="form-control" runat="server"></asp:TextBox>
                          <%--<input type="text" class="form-control" id="inputConcentracion3">--%>
                        </div>
                        <div class="form-group col-md-2">
                          <label for="inputFF3">Form. Farm.</label>
                            <asp:TextBox ID="inputFF3" class="form-control" runat="server"></asp:TextBox>
                          <%--<input type="text" class="form-control" id="inputFF3">--%>
                        </div>
                      </div>


                    <div class="form-group">
                    <asp:Label ID="Label14" for="txtMotivo" Font-Bold="True" runat="server" Text="Motivo de Denuncia"></asp:Label>
                    <asp:TextBox ID="txtMotivo" class="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
                </div>














              <%--  <div class="datosMedicamento">
                    <div class="form-group">

                        <asp:Label ID="Label8" for="txtNombreProducto" Font-Bold="True" runat="server" Text="Nombres del Producto"></asp:Label>
                        <asp:TextBox ID="txtNombreProducto" class="form-control" runat="server"></asp:TextBox>

                         <asp:Label ID="Label2" for="txtNombreProducto" Font-Bold="True" runat="server" Text="Nombres del Producto"></asp:Label>
                        <asp:TextBox ID="TextBox1" class="form-control" runat="server"></asp:TextBox>
                    </div>
                  <div class="form-group">
                <asp:Label ID="Label9" for="TextBox7" Font-Bold="True" runat="server" Text="DNI"></asp:Label>
                <asp:TextBox ID="TextBox8" class="form-control" runat="server"></asp:TextBox>
            </div>

                    <div class="form-group">
                        <asp:Label ID="Label10" for="ddlTipoProducto" Font-Bold="True" runat="server" Text="Tipo de Producto"></asp:Label>

                        <asp:DropDownList ID="ddlTipoProducto" Style="width: 425px;" class="form-control" runat="server" DataSourceID="SqlDataSource2" DataTextField="descrip_tipoProducto" DataValueField="id_tipoProducto">
                        </asp:DropDownList>
                    </div>

                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT * FROM [tb_tipoProducto]"></asp:SqlDataSource>
                </div>--%>

             <%--   <div class="form-group">
                    <asp:Label ID="Label11" for="txtNroSerieLote" Font-Bold="True" runat="server" Text="Nro de serie / Lote"></asp:Label>
                    <asp:TextBox ID="txtNroSerieLote" class="form-control" runat="server"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="Label12" for="txtFecVencimiento" runat="server" Font-Bold="True" Text="Fecha de Vencimiento"></asp:Label>
                    <asp:TextBox ID="txtFecVencimiento" Style="width: 280px;" class="form-control" runat="server" TextMode="Date"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="Label13" for="txtRegSan" Font-Bold="True" runat="server" Text="Registro Sanitario"></asp:Label>
                    <asp:TextBox ID="txtRegSan" class="form-control" runat="server"></asp:TextBox>
                </div>


                --%>
            </div>
        </div>

        <hr>



        <div class="panel panel-default"></div>
        <div class="panel-heading">
            <h4><b> Registro de Datos del Establecimiento </b></h4>
        </div>

        <div class="panel-body">
        <div class="datosEstablecimiento">

            <div class="form-group">
                <asp:Label ID="Label17" for="ddlTipoEstablecimiento" Font-Bold="True" runat="server" Text="Tipo de Establecimiento"></asp:Label>

                <asp:DropDownList ID="ddlTipoEstablecimiento" Style="width: 280px;" class="form-control" runat="server" DataSourceID="SqlDataSource4" DataTextField="descrip_tipoEstablecimiento" DataValueField="valor_abreviado">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT * FROM [tb_tipoEstablecimiento]" OnSelecting="SqlDataSource4_Selecting"></asp:SqlDataSource>
            </div>


            <div class="form-group">
                <asp:Label ID="Label15" for="txtNombreestablecimiento" Font-Bold="True" runat="server" Text="Nombre del Establecimiento"></asp:Label>
                <asp:TextBox ID="txtNombreestablecimiento" class="form-control" runat="server"></asp:TextBox>
            </div>

             <div class="form-group">
                <asp:Label ID="Label9" for="txtDireccionestablecimiento" Font-Bold="True" runat="server" Text="Dirección del Establecimiento"></asp:Label>
                <asp:TextBox ID="txtDireccionestablecimiento" class="form-control" runat="server"></asp:TextBox>
            </div>

        </div>

        <div>

            <table style="width: 100%; height: 86px;">
                <tr>
                    <td class="style1">
                        <div class="form-group">
                            <asp:Label ID="Label16" Font-Bold="True" for="ddlDepartamento" runat="server" Text="Departamento :"></asp:Label>
                            <asp:DropDownList ID="ddlDepartamento" Style="width: 280px;" class="form-control" runat="server" AutoPostBack="True"
                                DataTextField="dptdescrip" DataValueField="dptcodigo" AppendDataBoundItems="true"
                                OnSelectedIndexChanged="ddlDepartamento_SelectedIndexChanged">
                                <asp:ListItem Value="0">--Seleccione el departamento--</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td class="style1">
                        <div class="form-group">
                            <asp:Label ID="Label18" Font-Bold="True" runat="server" for="ddlProvincia" Text="Provincia :"></asp:Label>
                            <asp:DropDownList ID="ddlProvincia" Style="width: 280px;" runat="server" class="form-control" AppendDataBoundItems="true" DataTextField="prvdescrip"
                                DataValueField="prvcodigo" AutoPostBack="True"
                                OnSelectedIndexChanged="ddlProvincia_SelectedIndexChanged">
                                <asp:ListItem Value="0">-- Seleccione provincia--</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td class="style1">
                        <div class="form-group">
                            <asp:Label ID="Label19" Font-Bold="True" runat="server" for="ddlDistrito" Text="Distrito :"></asp:Label>
                            <asp:DropDownList ID="ddlDistrito" Style="width: 280px;" class="form-control" runat="server" AppendDataBoundItems="true" DataTextField="disdescrip"
                                DataValueField="discodigo">
                                <asp:ListItem Value="0">-- Seleccione Distrito--</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </td>
                    <td></td>
                    <td></td>
                </tr>
            </table>

        </div>
              <div class="form-group"  style="display:none">
            <asp:Label ID="Label20" Font-Bold="True" for="FileUpload1" runat="server" Text="Adjuntar Información :"></asp:Label>
            <asp:FileUpload class="form-control" ID="fupSubirArchivo" runat="server" />
        </div>
      </div>

        </div>


        <%--este es--%>
    </div>
      

        <asp:Button ID="btnEnviarDenuncia" class="btn btn-primary btn-lg" runat="server" Text="Enviar Denuncia" OnClick="btnEnviarDenuncia_Click" />
    <%--</div>--%>
    <asp:Label ID="lblestado" runat="server"></asp:Label>


















</asp:Content>
