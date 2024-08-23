<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="Denuncia.aspx.cs" Inherits="denunciasWeb.Denuncia" %>

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





    


















    <%--    <div class="form-group">
                <asp:Label ID="Label9" for="TextBox7" Font-Bold="True" runat="server" Text="DNI"></asp:Label>
                <asp:TextBox ID="TextBox8" class="form-control" runat="server"></asp:TextBox>
            </div>--%>

    <div class="page-header">
        <h1>DENUNCIAS EN LÍNEA &nbsp &nbsp &nbsp 
            <asp:Label ID="lblDenCodigo" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="lblPersonaNaturalCodigo" runat="server" Text="Label"></asp:Label>
            <asp:RadioButton ID="rbAnonimo" runat="server" />
            <br />
            <br />
            <small>Nota: La persona que no proporciona sus datos personales completos y correctos, no podra solicitar detalles o resultados con relación a su denuncia </small></h1>

    </div>

    <%--</div>--%>


    <div class="panel panel-default">
        <div class="panel-heading">
            <%--    <br />--%>
            <h4><b> Registro de Datos del Denunciante </b></h4>

            <%-- <br />--%>
        </div>

        <div class="panel-body">


            <script type="text/javascript">
                function showhide(ddl) {
                    var div11 = document.getElementById('div11');
                    var div12 = document.getElementById('div12');
                    var div13 = document.getElementById('div13');

                     //var e = document.getElementById("nameSelect");
                    var dspText = ddl.options[ddl.selectedIndex].text;


                    if (dspText == "Anónimo") {
                        div11.className = "hideDiv";
                        div12.className = "hideDiv";
                        div13.className = "hideDiv";
                    }
                    else if (dspText == "Persona Natural") {
                        div11.className = "showDiv";
                        div12.className = "hideDiv";
                        div13.className = "showDiv";
                    }
                    else if (dspText == "Empresa / Institución") {
                        div11.className = "hideDiv";
                        div12.className = "showDiv";
                        div13.className = "showDiv";
                    }
                }





                //  <script type="text/javascript">
                //function showhide(ddl) {
                //    var div11 = document.getElementById('div11');
                //    var div12 = document.getElementById('div12');
                //    var div13 = document.getElementById('div13');
                //    if (ddl.value == "1") {
                //        div11.className = "hideDiv";
                //        div12.className = "hideDiv";
                //        div13.className = "hideDiv";
                //    }
                //    else if (ddl.value == "2") {
                //        div11.className = "showDiv";
                //        div12.className = "hideDiv";
                //        div13.className = "showDiv";
                //    }
                //    else if (ddl.value == "3") {
                //        div11.className = "hideDiv";
                //        div12.className = "showDiv";
                //        div13.className = "showDiv";
                //    }
                //}






               // var Text = ddlReport.options[ddlReport.selectedIndex].text;
            </script>





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
          <div class="form-check">
    <input type="checkbox" class="form-check-input" id="exampleCheck1">
    <label class="form-check-label" for="exampleCheck1">El denunciante no brinda información de sus datos No podrá tener información de las acciones realizadas en atención a su denuncia</label>
  </div>
    </div>
  </div>
  <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title">
        <a data-toggle="collapse" data-parent="#accordion" href="#collapse2">
        Persona Natural</a>
      </h4>
    </div>
    <div id="collapse2" class="panel-collapse collapse '<%= state %>'">
      <div class="panel-body">

          
          <div class="datosPersonaNatural" style="display: flex; justify-content: space-between; flex-direction:column;  width: 100%;">
                        <div class="form-group" style="margin-right: 10px;">
                            <asp:Label ID="Label30" For="txtNombreApellidos" Font-Bold="True" runat="server" Text="Nombres y Apellidos"></asp:Label>
                            <asp:TextBox ID="TextBox1" class="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label31" For="txtDNI" Font-Bold="True" runat="server" Text="DNI"></asp:Label>
                            <asp:TextBox ID="TextBox2" class="form-control" runat="server"></asp:TextBox>
                        </div>
                        <br />  
                         <div class="form-group">
                            <asp:Label ID="Label32" For="txtDireccion" Font-Bold="True" runat="server" Text="Dirección"></asp:Label>
                            <asp:TextBox ID="TextBox3" class="form-control" runat="server"></asp:TextBox>
                        </div>
                         <div class="form-group">
                            <asp:Label ID="Label33" For="txtUrbanizacion" Font-Bold="True" runat="server" Text="Urbanización"></asp:Label>
                            <asp:TextBox ID="TextBox4" class="form-control" runat="server"></asp:TextBox>
                        </div>

                         <div class="form-group">
                            <asp:Label ID="Label34" For="txtNumero" Font-Bold="True" runat="server" Text="Número"></asp:Label>
                            <asp:TextBox ID="TextBox5" class="form-control" runat="server"></asp:TextBox>


                        </div>
                         <div class="form-group">
                            <asp:Label ID="Label35" For="txtInterior" Font-Bold="True" runat="server" Text="Interior"></asp:Label>
                            <asp:TextBox ID="TextBox6" class="form-control" runat="server"></asp:TextBox>
                        </div>


         </div>
          <div>

            <table style="width: 100%; height: 86px;">
                <tr>
                    <td class="style1">
                        <div class="form-group">
                            <asp:Label ID="Label27" Font-Bold="True" for="ddlDepartamentoPN" runat="server" Text="Departamento :"></asp:Label>
                            <asp:DropDownList ID="ddlDepartamentoPN" Style="width: 280px;" class="form-control" runat="server"  AutoPostBack="True"
                                DataTextField="dptdescrip" DataValueField="dptcodigo" AppendDataBoundItems="true"
                                OnSelectedIndexChanged="ddlDepartamentoPN_SelectedIndexChanged">
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
                            <asp:Label ID="Label28" Font-Bold="True" runat="server" for="ddlProvinciaPN" Text="Provincia :"></asp:Label>
                            <asp:DropDownList ID="ddlProvinciaPN" Style="width: 280px;" runat="server" class="form-control" AppendDataBoundItems="true" DataTextField="prvdescrip"
                                DataValueField="prvcodigo" AutoPostBack="True"
                                OnSelectedIndexChanged="ddlProvinciaPN_SelectedIndexChanged">
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
                            <asp:Label ID="Label29" Font-Bold="True" runat="server" for="ddlDistritoPN" Text="Distrito :"></asp:Label>
                            <asp:DropDownList ID="ddlDistritoPN" Style="width: 280px;" class="form-control" runat="server" AppendDataBoundItems="true" DataTextField="disdescrip"
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


      </div>
    </div>
  </div>
  <div class="panel panel-default">
    <div class="panel-heading">
      <h4 class="panel-title">
        <a data-toggle="collapse" data-parent="#accordion" href="#collapse3">
       Empresa / Institución</a>
      </h4>
    </div>
    <div id="collapse3" class="panel-collapse collapse">
      <div class="panel-body">Lorem ipsum dolor sit amet, consectetur adipisicing elit,
      sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad
      minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea
      commodo consequat.</div>
    </div>
  </div>
</div>



            <div class="form-group">
                <asp:Label ID="Label21" for="ddltipoPersona" runat="server" Text="Tipo de Persona" Font-Bold="True"></asp:Label>
                <asp:DropDownList ID="ddltipoPersona" Style="width: 280px;" class="form-control" runat="server"   DataTextField="descrip_tipoPersona" DataValueField="id_tipoPersona" OnSelectedIndexChanged="ddltipoPersona_SelectedIndexChanged">
                    <asp:ListItem Value="PN">Anónimo</asp:ListItem>
                    <asp:ListItem Value="PQ">Persona Natural</asp:ListItem>
                    <asp:ListItem Value="PJ">Empresa / Institución</asp:ListItem>
                    <asp:ListItem Value="EN">Entidad</asp:ListItem>
                </asp:DropDownList>
            </div>



<%--               <div class="form-group">
                <asp:Label ID="Label22" for="ddltipoPersona" runat="server" Text="Tipo de Persona" Font-Bold="True"></asp:Label>
                <asp:DropDownList ID="DropDownList1" Style="width: 280px;" class="form-control" runat="server" DataTextField="descrip_tipoPersona" DataValueField="id_tipoPersona" OnSelectedIndexChanged="ddltipoPersona_SelectedIndexChanged">
                    <asp:ListItem Value="PN">Anónimo</asp:ListItem>
                    <asp:ListItem Value="PN">Persona Natural</asp:ListItem>
                    <asp:ListItem Value="PJ">Empresa / Institución</asp:ListItem>
                    <asp:ListItem Value="EN">Entidad</asp:ListItem>
                </asp:DropDownList>
            </div>--%>








            <style>
                .showDiv {
                    display: block;
                }

                .hideDiv {
                    display: none;
                }
            </style>



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

                <div id="div12" class="hideDiv">
                    <div class="datosPersonaJuridica" style="display: flex; justify-content: space-between; width: 40%;">
                        <div class="form-group">
                            <asp:Label ID="Label4" For="txtRazonSocial" Font-Bold="True" runat="server" Text="Razón Social "></asp:Label>
                            <asp:TextBox ID="txtRazonSocial" class="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label5" For="txtRUC" Font-Bold="True" runat="server" Text="RUC"></asp:Label>
                            <asp:TextBox ID="txtRUC" class="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>


                <div id="div13" class="hideDiv">
                    <div class="datosCorreoTelefono" style="display: flex; justify-content: space-between; flex-direction:column;  width: 40%;">
                        <div class="form-group">
                            <asp:Label ID="Label6" For="txtEmail" Font-Bold="True" runat="server" Text="Correo Electrónico"></asp:Label>
                            <asp:TextBox ID="txtEmail" class="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label7" For="txtTelefono" Font-Bold="True" runat="server" Text="Nro Celular"></asp:Label>
                            <asp:TextBox ID="txtTelefono" class="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label26" For="txtFijo" Font-Bold="True" runat="server" Text="Teléfono Fijo"></asp:Label>
                            <asp:TextBox ID="txtFijo" class="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>


                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT * FROM [tb_tipoPersona]"></asp:SqlDataSource>

            </div>

        </div>






            <!-- #region pruebas  multiiew -->
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem Value="0">Anónimo</asp:ListItem>
                <asp:ListItem Value="1">Persona Natural</asp:ListItem>
                <asp:ListItem Value="2">Empresa/Institución</asp:ListItem>
            </asp:DropDownList>

            <br />
            <br />
            <asp:MultiView ID="MultiView1" runat="server">





                <asp:View ID="View1" runat="server">


                    vista anonimo

                </asp:View>
                <asp:View ID="View2" runat="server">


                    vista persona natural

<%--
                    <div class="datosPersonaNatural" style="display: flex; justify-content: space-between; flex-direction:column;  width: 100%;">
                        <div class="form-group" style="margin-right: 10px;">
                            <asp:Label ID="Label30" For="txtNombreApellidos" Font-Bold="True" runat="server" Text="Nombres y Apellidos"></asp:Label>
                            <asp:TextBox ID="TextBox1" class="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label31" For="txtDNI" Font-Bold="True" runat="server" Text="DNI"></asp:Label>
                            <asp:TextBox ID="TextBox2" class="form-control" runat="server"></asp:TextBox>
                        </div>
                        <br />  
                         <div class="form-group">
                            <asp:Label ID="Label32" For="txtDireccion" Font-Bold="True" runat="server" Text="Dirección"></asp:Label>
                            <asp:TextBox ID="TextBox3" class="form-control" runat="server"></asp:TextBox>
                        </div>
                         <div class="form-group">
                            <asp:Label ID="Label33" For="txtUrbanizacion" Font-Bold="True" runat="server" Text="Urbanización"></asp:Label>
                            <asp:TextBox ID="TextBox4" class="form-control" runat="server"></asp:TextBox>
                        </div>

                         <div class="form-group">
                            <asp:Label ID="Label34" For="txtNumero" Font-Bold="True" runat="server" Text="Número"></asp:Label>
                            <asp:TextBox ID="TextBox5" class="form-control" runat="server"></asp:TextBox>


                        </div>
                         <div class="form-group">
                            <asp:Label ID="Label35" For="txtInterior" Font-Bold="True" runat="server" Text="Interior"></asp:Label>
                            <asp:TextBox ID="TextBox6" class="form-control" runat="server"></asp:TextBox>
                        </div>


         </div>
          <div>

            <table style="width: 100%; height: 86px;">
                <tr>
                    <td class="style1">
                        <div class="form-group">
                            <asp:Label ID="Label27" Font-Bold="True" for="ddlDepartamentoPN" runat="server" Text="Departamento :"></asp:Label>
                            <asp:DropDownList ID="ddlDepartamentoPN" Style="width: 280px;" class="form-control" runat="server"  AutoPostBack="True"
                                DataTextField="dptdescrip" DataValueField="dptcodigo" AppendDataBoundItems="true"
                                OnSelectedIndexChanged="ddlDepartamentoPN_SelectedIndexChanged">
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
                            <asp:Label ID="Label28" Font-Bold="True" runat="server" for="ddlProvinciaPN" Text="Provincia :"></asp:Label>
                            <asp:DropDownList ID="ddlProvinciaPN" Style="width: 280px;" runat="server" class="form-control" AppendDataBoundItems="true" DataTextField="prvdescrip"
                                DataValueField="prvcodigo" AutoPostBack="True"
                                OnSelectedIndexChanged="ddlProvinciaPN_SelectedIndexChanged">
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
                            <asp:Label ID="Label29" Font-Bold="True" runat="server" for="ddlDistritoPN" Text="Distrito :"></asp:Label>
                            <asp:DropDownList ID="ddlDistritoPN" Style="width: 280px;" class="form-control" runat="server" AppendDataBoundItems="true" DataTextField="disdescrip"
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

--%>

                        
  












                </asp:View>
                <asp:View ID="View3" runat="server">

                    vista empresa

                </asp:View>
            </asp:MultiView>

            <!-- #endregion -->



























        <hr>

        <div class="panel panel-default">

            <div class="panel-heading">
                <h4><b> Registro de Datos del Medicamento </b></h4>
            </div>
            <div class="panel-body">
                <p>
                    Las modalidades del comercio ilegal de los productos farmacéuticos, dispositivos médicos y productos sanitarios
        (check list, se puede seleccionar 1 o más de 1)
                </p>


                <div style="display: flex;">
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

                   
                   
                </div>


                <div style="display: flex;">
                    

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
                </div>
                <br />
                <div class="datosMedicamento">
                    <div class="form-group">
                        <asp:Label ID="Label8" for="txtNombreProducto" Font-Bold="True" runat="server" Text="Nombres del Producto"></asp:Label>
                        <asp:TextBox ID="txtNombreProducto" class="form-control" runat="server"></asp:TextBox>
                    </div>
                    <%--    <div class="form-group">
                <asp:Label ID="Label9" for="TextBox7" Font-Bold="True" runat="server" Text="DNI"></asp:Label>
                <asp:TextBox ID="TextBox8" class="form-control" runat="server"></asp:TextBox>
            </div>--%>

                    <div class="form-group">
                        <asp:Label ID="Label10" for="ddlTipoProducto" Font-Bold="True" runat="server" Text="Tipo de Producto"></asp:Label>

                        <asp:DropDownList ID="ddlTipoProducto" Style="width: 425px;" class="form-control" runat="server" DataSourceID="SqlDataSource2" DataTextField="descrip_tipoProducto" DataValueField="id_tipoProducto">
                        </asp:DropDownList>
                    </div>

                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT * FROM [tb_tipoProducto]"></asp:SqlDataSource>
                </div>

                <div class="form-group">
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


                <div class="form-group">
                    <asp:Label ID="Label14" for="txtMotivo" Font-Bold="True" runat="server" Text="Motivo de Denuncia"></asp:Label>
                    <asp:TextBox ID="txtMotivo" class="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
                </div>
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
              <div class="form-group">
            <asp:Label ID="Label20" Font-Bold="True" for="FileUpload1" runat="server" Text="Adjuntar Información :"></asp:Label>
            <asp:FileUpload class="form-control" ID="fupSubirArchivo" runat="server" />
        </div>
      </div>

        </div>




      

        <asp:Button ID="btnEnviarDenuncia" class="btn btn-primary btn-lg" runat="server" Text="Enviar Denuncia" OnClick="btnEnviarDenuncia_Click" />
    <%--</div>--%>
    <asp:Label ID="lblestado" runat="server"></asp:Label>
</asp:Content>

