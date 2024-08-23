<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DenunciaA.aspx.cs" Inherits="denunciasWeb.DenunciaA" %>
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
            <small>Nota: La persona que no proporciona sus datos personales completos y correctos, no podra solicitar detalles o resultados con relación a su denuncia </small></h1>

    </div>

  <nav class="navbar navbar-default">
  <div class="container-fluid">
  <div class="container-fluid">
    <div class="navbar-header">
      <a class="navbar-brand" href="#"><strong>Elija el Tipo de Denuncia</strong></a>
    </div>
    <ul class="nav navbar-nav">
      
      <li class="active"><a href="DenunciaA">Anónima</a></li>
      <li><a href="DenunciaP">Persona Natural</a></li>
      <li><a href="DenunciaE">Empresa Institución</a></li>
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
                <p>
                    Las modalidades del comercio ilegal de los productos farmacéuticos, dispositivos médicos y productos sanitarios
        (check list, se puede seleccionar 1 o más de 1)



                    <script>

                                function ValidateModuleList(source, args) {

                            var chkListModules = document.getElementById('<%= CheckBoxListStates.ClientID %>');

                            var chkListinputs = chkListModules.getElementsByTagName("input");

                            for (var i = 0; i < chkListinputs.length; i++) {

                                if (chkListinputs[i].checked) {

                                   args.IsValid = true;

                                      return;

                                                        }
                                                     }
                                                     args.IsValid = false;
                                                }
                    </script>


                     <div style="display: flex;">
                  <asp:CheckBoxList class="form-group" ID="CheckBoxListStates" runat="server" ClientIDMode="Static">

                       
                           <asp:ListItem ID="chkFalsificados1" class="form-check" Text="Falsificados" style="margin-right: 80px" Value="prelim_construction" />
                      
                           <asp:ListItem ID="chkVencidos1" Text="Vencidos" Value="final_construction" />
                           <asp:ListItem ID="chkProcDesconocida1" Text="Procedencia Desconocida" Value="construction_alteration" /> 
                           <asp:ListItem ID="chkRotAdulterado1" Text="Rotulado Adulterado Borrado" Value="remodel" />
                           <asp:ListItem ID="chksinRS1" Text="Sin Registro Sanitario" Value="remodel" />
                           <asp:ListItem ID="chkProdPublico1" Text="Producto de Institución Pública" Value="remodel" /> 
                           <asp:ListItem ID="chkMuestraMedica1" Text="Muestra Médica" Value="remodel" />
                         <asp:ListItem ID="chkMalEstado1" Text="Mal estado de Conservación" Value="remodel" />
                      

                          
                    </asp:CheckBoxList>
                     </div>
                <asp:CustomValidator runat="server" ID="cvmodulelist" ClientValidationFunction="ValidateModuleList"  ForeColor="#f4a827"  style =" font-weight: bold; " ErrorMessage="Por Favor seleccione una modalidad de Comercio Ilegal">
                </asp:CustomValidator>
                </p>

                  <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
                <script>

        //            function deRequireCb(acb) {
        //    el=document.getElementsByClassName(acb);

        //    var atLeastOneChecked=false;//at least one cb is checked
        //    for (i=0; i<el.length; i++) {
        //        if (el[i].checked === true) {
        //            atLeastOneChecked=true;
        //        }
        //    }

        //    if (atLeastOneChecked === true) {
        //        for (i=0; i<el.length; i++) {
        //            el[i].required = false;
        //        }
        //    } else {
        //        for (i=0; i<el.length; i++) {
        //            el[i].required = true;
        //        }
        //    }
        //}
 




                </script>

                <div style="display: flex;">
                    <%--<div class="form-check  " style="margin-right: 10px">
                        <asp:CheckBox class="form-check-input" ID="chkFalsificados" runat="server" Text="Falsificados" />
                    </div>--%>
                   <%-- <div class="form-check" style="margin-right: 10px">
                        <asp:CheckBox ID="chkVencidos" runat="server" Text="Vencidos" />
                    </div>

                    <div class="form-check" style="margin-right: 10px">
                        <asp:CheckBox ID="chkProcDesconocida" runat="server" Text="Procedencia Desconocida" />
                    </div>
                    <div class="form-check" style="margin-right: 10px">
                        <asp:CheckBox ID="chkRotAdulterado" runat="server" Text="Rotulado Adulterado Borrado" />
                    </div>--%>

                   
                   
                </div>


           <%--     <div style="display: flex;">
                    

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
                <b> 
<%--                <asp:CustomValidator ID="vldCheckboxes" runat="server" onservervalidate="vldCheckboxes_ServerValidate" Text="*" ErrorMessage="Debe Seleccionar al menos uno"></asp:CustomValidator>--%>
                </b>
                <br />
                <div class="datosMedicamento">
                    <div class="form-group">
                        <asp:Label ID="Label8" for="txtNombreProducto" Font-Bold="True" runat="server" Text="Nombres del Producto"></asp:Label>
                        <asp:TextBox ID="txtNombreProducto" class="form-control" runat="server" required></asp:TextBox>
                    </div>
                    <%--    <div class="form-group">
                <asp:Label ID="Label9" for="TextBox7" Font-Bold="True" runat="server" Text="DNI"></asp:Label>
                <asp:TextBox ID="TextBox8" class="form-control" runat="server"></asp:TextBox>
            </div>--%>

                    <%--<div class="form-group">
                        <asp:Label ID="Label10" for="ddlTipoProducto" Font-Bold="True" runat="server" Text="Tipo de Producto"></asp:Label>

                        <asp:DropDownList ID="ddlTipoProducto" Style="width: 425px;" class="form-control" runat="server" DataSourceID="SqlDataSource2" DataTextField="descrip_tipoProducto" DataValueField="id_tipoProducto">
                        <asp:ListItem Value="0">--Seleccione el tipo de producto--</asp:ListItem>
                        </asp:DropDownList>
                    </div>

                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT * FROM [tb_tipoProducto]"></asp:SqlDataSource>--%>
             
                    
                     <div class="form-group">
                        <asp:Label ID="Label2" for="ddlTipoProducto1" Font-Bold="True" runat="server" Text="Tipo de Producto"></asp:Label>

                        <asp:DropDownList ID="ddlTipoProducto1" Style="width: 425px;" class="form-control" runat="server" DataTextField="descrip_tipoProducto" DataValueField="id_tipoProducto"
                            AppendDataBoundItems="true"
                               required >
                        <asp:ListItem Value="">--Seleccione el tipo de producto--</asp:ListItem>
                            <asp:ListItem Value="0">Producto Farmacéutico</asp:ListItem>
                            <asp:ListItem Value="1">Producto Sanitario</asp:ListItem>
                            <asp:ListItem Value="2">Dispositivo Médico</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    
                    
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlTipoProducto1"
                ErrorMessage="Value Required!" InitialValue="--Seleccione el tipo de producto--"></asp:RequiredFieldValidator>
           


                   





        </div>
                    </div>

                <div class="form-group">
                    <asp:Label ID="Label11" for="txtNroSerieLote" Font-Bold="True" runat="server" Text="Nro de serie / Lote"></asp:Label>
                    <asp:TextBox ID="txtNroSerieLote" class="form-control" runat="server" required></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="Label12" for="txtFecVencimiento" runat="server" Font-Bold="True" Text="Fecha de Vencimiento"></asp:Label>
                    <asp:TextBox ID="txtFecVencimiento" Style="width: 280px;" class="form-control" runat="server" TextMode="Date" required></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="Label4" for="txtRegSan" Font-Bold="True" runat="server" Text="Registro Sanitario"    ></asp:Label>
                    <asp:Label ID="Label13" for="txtRegSan" Font-Bold="True" ForeColor="Gray" runat="server" Text="Si no cuenta con Registro Sanitario ingrese SIN RS"    ></asp:Label>
                    <asp:TextBox ID="txtRegSan" class="form-control" style="text-transform:uppercase"  runat="server"   required></asp:TextBox>
                </div>


                <div class="form-group">
                    <asp:Label ID="Label14" for="txtMotivo" Font-Bold="True" runat="server" Text="Motivo de Denuncia"></asp:Label>
                    <asp:TextBox ID="txtMotivo" class="form-control" runat="server" TextMode="MultiLine" required MaxLength="160"></asp:TextBox>
                    <span id="charCount" class="text-muted">Caracteres restantes: 160</span>
                </div>

            <div class="form-group">
                <asp:FileUpload ID="fileUploadA" runat="server" />
                

            </div>


            


            </div>
        </div>





        <script type="text/javascript">
    var maxChars = 160; // Cambia esto al número máximo de caracteres permitidos

    function updateCharCount() {
        var textBox = document.getElementById('<%= txtMotivo.ClientID %>');
        var charCountSpan = document.getElementById('charCount');
        
        var remainingChars = maxChars - textBox.value.length;
        charCountSpan.textContent = 'Caracteres restantes: ' + remainingChars;
    }

    // Actualiza el contador cuando se carga la página y cuando el usuario escribe
    window.onload = function () {
        updateCharCount();
        document.getElementById('<%= txtMotivo.ClientID %>').addEventListener('input', updateCharCount);
    };
</script>



        <hr>



        <div class="panel panel-default"></div>
        <div class="panel-heading">
            <h4><b> Registro de Datos del Establecimiento </b></h4>
        </div>

        <div class="panel-body">
        <div class="datosEstablecimiento">

          <%--  <div class="form-group">
                <asp:Label ID="Label17" for="ddlTipoEstablecimiento" Font-Bold="True" runat="server" Text="Tipo de Establecimiento"></asp:Label>

                <asp:DropDownList ID="ddlTipoEstablecimiento" Style="width: 280px;" class="form-control" runat="server" DataSourceID="SqlDataSource4" DataTextField="descrip_tipoEstablecimiento" DataValueField="valor_abreviado">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT * FROM [tb_tipoEstablecimiento]" OnSelecting="SqlDataSource4_Selecting"></asp:SqlDataSource>
            </div>--%>



            <div class="form-group">
                <asp:Label ID="Label3" for="ddlTipoEstablecimiento1" Font-Bold="True" runat="server" Text="Tipo de Establecimiento"></asp:Label>

                <asp:DropDownList ID="ddlTipoEstablecimiento1" Style="width: 280px;" class="form-control" runat="server" DataTextField="descrip_tipoEstablecimiento" DataValueField="valor_abreviado"
                     AppendDataBoundItems="true" required>
                   
                      <asp:ListItem Value="">--Seleccione el tipo de Establecimiento--</asp:ListItem>
                            <asp:ListItem Value="EF">Establecimiento Farmacéutico Autorizado</asp:ListItem>
                            <asp:ListItem Value="EC">Establecimiento Clandestino</asp:ListItem>
                            <asp:ListItem Value="EI">Establecimiento Informal</asp:ListItem>
                </asp:DropDownList>
                
            </div>






            <div class="form-group">
                <asp:Label ID="Label15" for="txtNombreestablecimiento" Font-Bold="True" runat="server" Text="Nombre del Establecimiento"></asp:Label>
                <asp:TextBox ID="txtNombreestablecimiento" class="form-control" runat="server" required></asp:TextBox>
            </div>

             <div class="form-group">
                <asp:Label ID="Label9" for="txtDireccionestablecimiento" Font-Bold="True" runat="server" Text="Dirección del Establecimiento"></asp:Label>
                <asp:TextBox ID="txtDireccionestablecimiento" class="form-control" runat="server" required></asp:TextBox>
            </div>

        <%--</div>--%>

        <div>






            <table style="width: 100%; height: 86px;">
                <tr>
                    <td class="style1">
                        <div class="form-group">
                            <asp:Label ID="Label16" Font-Bold="True" for="ddlDepartamento" runat="server" Text="Departamento :"></asp:Label>
                            <asp:DropDownList ID="ddlDepartamento" Style="width: 280px;" class="form-control" runat="server"  AutoPostBack="True"
                                DataTextField="dptdescrip" DataValueField="dptcodigo" AppendDataBoundItems="true"
                                OnSelectedIndexChanged="ddlDepartamento_SelectedIndexChanged">
                                <asp:ListItem Value="0">--Seleccione el departamento--</asp:ListItem>
                            </asp:DropDownList>

                            <asp:Label ID="lblError1"  runat="server" Text="" ForeColor="#FF9900"></asp:Label>

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

                             <asp:Label ID="lblError2" runat="server"  Text="" ForeColor="#FF9900"></asp:Label>
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
                            <asp:Label ID="lblError3" runat="server"  Text="" ForeColor="#FF9900"></asp:Label>
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
      <asp:ValidationSummary ID="vldChexckboxes" runat="server" ForeColor="#f4a827"  style =" font-weight: bold; " />

        <asp:Button ID="btnEnviarDenuncia" class="btn btn-primary btn-lg" runat="server" Text="Enviar Denuncia" OnClick="btnEnviarDenuncia_Click" />
    <%--</div>--%>
    <asp:Label ID="lblestado" runat="server"></asp:Label>

  
   
    


















</asp:Content>
