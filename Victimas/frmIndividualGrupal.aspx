<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frmIndividualGrupal.aspx.vb" Inherits="Victimas_frmIndividualGrupal" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Modalidad Individual Grupal</title>
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <script src="../Scripts/libs/jquery-1.9.1.min.js"></script>
    <script src="../bootstrap-3.3.7-dist/js/bootstrap.min.js"></script>
    <script src="../bootstrap-3.3.7-dist/js/bootstrap-datepicker.js" type="text/javascript"></script>
    <script src="../bootstrap-3.3.7-dist/js/bootstrap.min.js"></script>
    <link href="../bootstrap-3.3.7-dist/css/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="../bootstrap-3.3.7-dist/css/bootstrap-datepicker.css" type="text/css" />
    <script src="Scripts/IndividualGrupal.js" type="text/javascript"></script>
</head>
<body>
    <script type="text/javascript">
        $(function () {
            $("#datetimepicker1").datepicker({
                autoclose: true,
                todayHighlight: true,
                showButtonPanel: true,
                clearBtn: true,
                orientation: 'bottom',
                endDate: '+0d',
                format: 'dd/mm/yyyy'
            });
        });

        $(function () {
            $("#datetimepicker2").datepicker({
                autoclose: true,
                todayHighlight: true,
                showButtonPanel: true,
                clearBtn: true,
                orientation: 'bottom',
                endDate: '+0d',
                format: 'dd/mm/yyyy'
            });
        });

        $(function () {
            $("#datetimepicker3").datepicker({
                autoclose: true,
                todayHighlight: true,
                showButtonPanel: true,
                clearBtn: true,
                orientation: 'bottom',
                endDate: '+0d',
                format: 'dd/mm/yyyy'
            });
        });

        $(function () {
            $("#datetimepicker4").datepicker({
                autoclose: true,
                todayHighlight: true,
                showButtonPanel: true,
                clearBtn: true,
                orientation: 'bottom',
                endDate: '+0d',
                format: 'dd/mm/yyyy'
            });
        });

        $(function () {
            $("#datetimepicker5").datepicker({
                autoclose: true,
                todayHighlight: true,
                showButtonPanel: true,
                clearBtn: true,
                orientation: 'bottom',
                endDate: '+0d',
                format: 'dd/mm/yyyy'
            });
        });

        $(function () {
            $("#datetimepicker6").datepicker({
                autoclose: true,
                todayHighlight: true,
                showButtonPanel: true,
                clearBtn: true,
                orientation: 'bottom',
                endDate: '+0d',
                format: 'dd/mm/yyyy'
            });
        });

        $(function () {
            $("#datetimepicker7").datepicker({
                autoclose: true,
                todayHighlight: true,
                showButtonPanel: true,
                clearBtn: true,
                orientation: 'bottom',
                endDate: '+0d',
                format: 'dd/mm/yyyy'
            });
        });

        $(function () {
            $("#datetimepicker8").datepicker({
                autoclose: true,
                todayHighlight: true,
                showButtonPanel: true,
                clearBtn: true,
                orientation: 'bottom',
                endDate: '+0d',
                format: 'dd/mm/yyyy'
            });
        });

        $(function () {
            $("#datetimepicker9").datepicker({
                autoclose: true,
                todayHighlight: true,
                showButtonPanel: true,
                clearBtn: true,
                orientation: 'bottom',
                endDate: '+0d',
                format: 'dd/mm/yyyy'
            });
        });

        $(function () {
            $("#datetimepicker10").datepicker({
                autoclose: true,
                todayHighlight: true,
                showButtonPanel: true,
                clearBtn: true,
                orientation: 'bottom',
                endDate: '+0d',
                format: 'dd/mm/yyyy'
            });
        });

        function GetRadWindow() {
            var oWindow = null;
            if (window.radWindow) oWindow = window.radWindow;
            else if (window.frameElement.radWindow) oWindow = window.frameElement.radWindow;
            return oWindow;
        }

        function IngresarDireccion() {
            var ventana = window.radopen("../ComponenteIvc/IngresoDireccion.aspx?n=" + (Math.random()), "IngresoDireccion");
            ventana.Restore();
            return false;
        }

        function IngresoDireccion_CallBack(radWindow, returnValue) {
            if (!returnValue._argument) {
                return;
            }
            $find("txtDireccionPCO").set_value(returnValue._argument);
        }

        function cerrar() {
            var oWindow = GetRadWindow();
            var arg = new Object();
            oWindow.Close(arg);
            return false;
        }

        //<JPaez 18-07-2011> 
        function getQueryStringValues(key) {
            var vRet;
            var DocumentQueryString = document.location.search.replace("?", "")
            var queryTickets = DocumentQueryString.split("&")
            var individualTicket = new Array()
            for (i = 0; i < queryTickets.length; i++) {
                individualTicket.push(queryTickets[i].split("="));
            }
            for (j = 0; j < individualTicket.length; j++) {
                if (individualTicket[j][0] == key) {
                    vRet = individualTicket[j][1]
                    return (vRet)
                }

            }
        }

        function AreaRuralChk() {
            if (document.getElementById("chkAreaRural").checked) {
                $find("txtDireccionPCO").enable();
                document.getElementById("btnLinkDir").style.visibility = "hidden";
            }
            else {
                $find("txtDireccionPCO").disable();
                document.getElementById("btnLinkDir").style.visibility = "visible";
                $find("txtDireccionPCO").set_value("");
            }

        }
    </script>
    <style type="text/css">
        div {
            padding-left: 5px;
            padding-right: 5px;
        }

        .style1 {
            font-style: normal;
            font-weight: normal;
            color: #045FB4;
        }

        .PosicionDireccionCE {
            left: 476px;
            top: 100px !important;
            width: 600px !important;
            height: 280px;
            visibility: visible;
            position: absolute;
            z-index: 3004;
        }

        .PosicionModalEmpleado {
            left: 476px;
            top: 100px !important;
            width: 1000px !important;
            height: 720px !important;
            visibility: visible;
            position: absolute;
            z-index: 3004;
        }

        .image {
            vertical-align: middle;
            height: 16px;
            width: 16px;
        }
    </style>
    <form id="form1" runat="server" method="post">
        <div>
            <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
            </telerik:RadScriptManager>
            <telerik:RadAjaxLoadingPanel ID="AjaxLoadingPanel1" runat="server" Skin="Office2007">
            </telerik:RadAjaxLoadingPanel>
            <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server" EnableEmbeddedScripts="True"
                EnableAJAX="true" DefaultLoadingPanelID="AjaxLoadingPanel2">
                <AjaxSettings>
                    <telerik:AjaxSetting AjaxControlID="rcbSubred">
                        <UpdatedControls>
                            <telerik:AjaxUpdatedControl ControlID="rcbLocalidad" />
                        </UpdatedControls>
                    </telerik:AjaxSetting>
                    <telerik:AjaxSetting AjaxControlID="txtDireccionPCO">
                        <UpdatedControls>
                            <telerik:AjaxUpdatedControl ControlID="rcbLocalidadPCO" />
                            <telerik:AjaxUpdatedControl ControlID="rcbBarrio" />
                            <telerik:AjaxUpdatedControl ControlID="rcbNombreUpz" />
                        </UpdatedControls>
                    </telerik:AjaxSetting>
                    <telerik:AjaxSetting AjaxControlID="rcbLocalidadPCO">
                        <UpdatedControls>
                            <telerik:AjaxUpdatedControl ControlID="rcbBarrio" />
                            <telerik:AjaxUpdatedControl ControlID="rcbNombreUpz" />
                        </UpdatedControls>
                    </telerik:AjaxSetting>
                </AjaxSettings>
            </telerik:RadAjaxManager>
            <telerik:RadWindowManager ID="RadWindowManager1" runat="server" Skin="Office2007"
                InitialBehaviors="Maximize" MinimizeZoneID="ZonaMinimizar" VisibleStatusbar="false">
                <Windows>
                    <telerik:RadWindow ID="IngresoDireccion" runat="server" Title="" CssClass="PosicionDireccionCE"
                        EnableViewState="false" Modal="True" Skin="Office2007" NavigateUrl="" Behaviors="Close,Move"
                        OnClientClose="IngresoDireccion_CallBack" />
                </Windows>
            </telerik:RadWindowManager>
        </div>
        <div class="container">
            <center>
                <div class="row">
                    <div class="col-sm-2">
                        <img src="../Imagenes/LogoAlcaldia.png" class="img-rounded" />
                    </div>
                    <div class="col-sm-8">
                        <h2>SECRETARÍA DISTRITAL DE SALUD</h2>
                        <br />
                        <h4>Programa de Atención Psicosocial y Salud Integral a Víctimas del Conflicto Armado - PAPSIVI.</h4>
                        <br />
                        <h4>Reporte de información de personas víctimas del conflicto armado con procesos de atención psicosocial en la modalidad individual – grupal.</h4>
                    </div>
                    <br />
                    <div class="col-sm-2">
                        <img src="../Imagenes/SecSalud.png" class="img-rounded" />
                    </div>
                </div>
            </center>
            <br />
            <div style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-bottom-style: solid; border-top-width: 1px; border-right-width: 1px; border-left-width: 1px; border-bottom-width: 1px; border-top-color: #99CCFF; border-right-color: #99CCFF; border-left-color: #99CCFF; border-bottom-color: #99CCFF">
                <table class="table">
                    <tr>
                        <td class="info">
                            <center><b>Atención Psicosocial Modalidad Individual - Grupal.</b></center>
                        </td>
                    </tr>
                </table>
                <table class="table">
                    <tr>
                        <td class="info">
                            <center><b>Datos Básicos</b></center>
                        </td>
                    </tr>
                </table>
                <div class="row">
                    <div class="row">
                        <div class="col-sm-2">Grupo:</div>
                        <div class="col-sm-3">
                            <input type="text" class="form-control" id="txtGrupo" maxlength="50" style="text-transform: uppercase;" value="" onkeyup="javascript:this.value=this.value.toUpperCase();" runat="server" tabindex="1" />
                        </div>
                        <div class="col-sm-7"></div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-sm-2">Punto de atención:</div>
                    <div class="col-sm-3">
                        <asp:DropDownList runat="server" ID="cboPuntoAten" CssClass="form-control" DataValueField="Id_PuntoAten" DataTextField="NombrePunto" TabIndex="2"></asp:DropDownList>
                    </div>
                    <div class="row">
                        <div class="col-sm-2">Fecha de Apertura:</div>
                        <div class="col-sm-3">
                            <div class="form-group">
                                <div class='input-group date' id='datetimepicker1' runat="server">
                                    <input type='text' class="form-control" id="dtpFechaApert" runat="server" tabindex="3" />
                                    <span class="input-group-addon">
                                        <span class="glyphicon glyphicon-calendar"></span>
                                    </span>
                                </div>
                            </div>
                        </div>
                        <div class="col-sm-7"></div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-sm-2">Tipo documento:</div>
                    <div class="col-sm-3">
                        <select class="form-control" id="cboTipoDoc" runat="server" name="cboTipoDoc" tabindex="4">
                            <option value="-1">Seleccione...</option>
                            <option value="1">RC</option>
                            <option value="2">TI</option>
                            <option value="3">CC</option>
                            <option value="4">No Suministra</option>
                        </select>
                    </div>
                    <div class="col-sm-2">Número documento:</div>
                    <div class="col-sm-3">
                        <input type="text" class="form-control" id="txtNumDoc" maxlength="12" runat="server" tabindex="5" />
                    </div>
                    <div class="col-sm-2"></div>
                </div>
                <br />
                <div class="row">
                    <div class="col-sm-2">Primer Nombre:</div>
                    <div class="col-sm-3">
                        <input type="text" class="form-control" id="txtPrimerNombre" maxlength="50" style="text-transform: uppercase;" value="" onkeyup="javascript:this.value=this.value.toUpperCase();" runat="server" tabindex="6" />
                    </div>
                    <div class="col-sm-2">Segundo Nombre:</div>
                    <div class="col-sm-3">
                        <input type="text" class="form-control" id="txtSegundoNombre" maxlength="50" style="text-transform: uppercase;" value="" onkeyup="javascript:this.value=this.value.toUpperCase();" runat="server" tabindex="7" />
                    </div>
                    <div class="col-sm-2"></div>
                </div>
                <br />
                <div class="row">
                    <div class="col-sm-2">Primer Apellido:</div>
                    <div class="col-sm-3">
                        <input type="text" class="form-control" id="txtPrimerApellido" maxlength="50" style="text-transform: uppercase;" value="" onkeyup="javascript:this.value=this.value.toUpperCase();" runat="server" tabindex="8" />
                    </div>
                    <div class="col-sm-2">Segundo Apellido:</div>
                    <div class="col-sm-3">
                        <input type="text" class="form-control" id="txtSegundoApellido" maxlength="50" style="text-transform: uppercase;" value="" onkeyup="javascript:this.value=this.value.toUpperCase();" runat="server" tabindex="9" />
                    </div>
                    <div class="col-sm-2"></div>
                </div>
                <br />
                <div class="row">
                    <div class="col-sm-2">Número Teléfono:</div>
                    <div class="col-sm-3">
                        <input type="text" class="form-control" id="txtTelefono" maxlength="16" runat="server" onkeypress='return event.charCode >= 48 && event.charCode <= 57' tabindex="10" />
                    </div>
                    <div class="col-sm-7"></div>
                </div>
                <br />
                <div class="row">
                    <div class="col-sm-2">Genero:</div>
                    <div class="col-sm-3">
                        <select class="form-control" id="cboGenero" runat="server" name="cboGenero" tabindex="11">
                            <option value="-1">Seleccione...</option>
                            <option value="1">Femenino</option>
                            <option value="2">Masculino</option>
                            <option value="3">Transgénero</option>
                        </select>
                    </div>
                    <div class="col-sm-2">Ciclo Vital:</div>
                    <div class="col-sm-3">
                        <select class="form-control" id="cboCicloVit" runat="server" name="cboCicloVit" tabindex="12">
                            <option value="-1">Seleccione...</option>
                            <option value="1">Menores a 1 Año</option>
                            <option value="2">1 a 5 Años</option>
                            <option value="3">6 a 13 Años</option>
                            <option value="4">14 a 17 Años</option>
                            <option value="5">18 a 26 Años</option>
                            <option value="6">27 a 59 Años</option>
                            <option value="7">60 y Más</option>
                        </select>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-sm-2">Pertenencia Étnica:</div>
                    <div class="col-sm-3">
                        <select class="form-control" id="cboPertEtnica" runat="server" name="cboPertEtnica" tabindex="13">
                            <option value="-1">Seleccione...</option>
                            <option value="1">Afrocolombiano</option>
                            <option value="2">Indígena</option>
                            <option value="3">Rom</option>
                            <option value="4">Raizal</option>
                            <option value="5">Sin pertenencia étnica</option>
                        </select>
                    </div>
                    <div class="col-sm-2">Situación / Condición:</div>
                    <div class="col-sm-3">
                        <select class="form-control" id="cboSituaCon" runat="server" name="cboSituaCon" tabindex="14">
                            <option value="-1">Seleccione...</option>
                            <option value="1">LGBTI</option>
                            <option value="2">Mujer Cabeza de Hogar</option>
                            <option value="3">Población en Condición de Discapacidad</option>
                            <option value="4">Población en Condición de Discapacidad - Victima del Conflicto Armado</option>
                            <option value="5">Victima del Conflicto Armado</option>
                            <option value="6">Ninguna</option>
                        </select>
                    </div>
                    <div class="col-sm-2"></div>
                </div>
                <br />
                <div class="row">
                    <div class="col-sm-2">Dirección Reportada:</div>
                    <div class="col-sm-3">
                        <label>
                            <input type="checkbox" id="chkAreaRural" runat="server" onchange="AreaRuralChk()" tabindex="15" />
                            Área rural</label>
                        <a href="#" class="btn btn-link" runat="server" id="btnLinkDir" role="button" onclick="IngresarDireccion()">Clic aquí para Ingresar la dirección</a>
                        <telerik:RadTextBox runat="server" ID="txtDireccionPCO" MaxLength="50" CssClass="form-control" Width="350" OnTextChanged="txtDireccionPCO_TextChanged" AutoPostBack="true" TabIndex="16" Enabled="false" Style="text-transform: uppercase;"></telerik:RadTextBox>
                    </div>
                    <div class="col-sm-2">Localidad:</div>
                    <div class="col-sm-3">
                        <asp:DropDownList ID="rcbLocalidadPCO" runat="server" CssClass="form-control" DataValueField="IdTblLocalidades" DataTextField="NombreLocalidad" OnSelectedIndexChanged="rcbLocalidadPCO_SelectedIndexChanged" AutoPostBack="true" TabIndex="17"></asp:DropDownList>
                    </div>
                    <div class="col-sm-2"></div>
                </div>
                <br />
                <div class="row">
                    <div class="col-sm-2">Barrio:</div>
                    <div class="col-sm-3">
                        <asp:DropDownList ID="rcbBarrio" runat="server" CssClass="form-control" DataValueField="IdTblBarrios" DataTextField="NombreBarrio" TabIndex="18"></asp:DropDownList>
                    </div>
                    <div class="col-sm-2">UPZ/UPR:</div>
                    <div class="col-sm-3">
                        <asp:DropDownList runat="server" ID="rcbNombreUpz" CssClass="form-control" DataValueField="IdTblUpz" DataTextField="NombreUPZ" TabIndex="19"></asp:DropDownList>
                    </div>
                    <div class="col-sm-2"></div>
                </div>
                <br />
                <table class="table">
                    <tr>
                        <td class="info">
                            <center><b>Hecho Victimizante</b></center>
                        </td>
                    </tr>
                </table>
                <div class="row">
                    <div class="col-sm-2">Acto terrorista, Atentados, Combates, Enfrentamientos, Hostigamientos:</div>
                    <div class="col-sm-3">
                        <select class="form-control" id="cboTerrorista" runat="server" name="cboTerrorista" tabindex="20">
                            <option value="-1">Seleccione...</option>
                            <option value="1">Si</option>
                            <option value="2">No</option>
                        </select>
                    </div>
                    <div class="row">
                        <div class="col-sm-2">Amenaza:</div>
                        <div class="col-sm-3">
                            <select class="form-control" id="cboAmenaza" runat="server" name="cboAmenaza" tabindex="21">
                                <option value="-1">Seleccione...</option>
                                <option value="1">Si</option>
                                <option value="2">No</option>
                            </select>
                        </div>
                        <div class="col-sm-2"></div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-sm-2">Delitos contra la Libertad y la Integridad sexual en desarrollo del conflicto Armado:</div>
                    <div class="col-sm-3">
                        <select class="form-control" id="cboDelitos" runat="server" name="cboDelitos" tabindex="22">
                            <option value="-1">Seleccione...</option>
                            <option value="1">Si</option>
                            <option value="2">No</option>
                        </select>
                    </div>
                    <div class="row">
                        <div class="col-sm-2">Desaparición Forzada:</div>
                        <div class="col-sm-3">
                            <select class="form-control" id="cboDesaparicion" runat="server" name="cboDesaparicion" tabindex="23">
                                <option value="-1">Seleccione...</option>
                                <option value="1">Si</option>
                                <option value="2">No</option>
                            </select>
                        </div>
                        <div class="col-sm-2"></div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-sm-2">Desplazamiento Forzado:</div>
                    <div class="col-sm-3">
                        <select class="form-control" id="cboDesplazamiento" runat="server" name="cboDesplazamiento" tabindex="24">
                            <option value="-1">Seleccione...</option>
                            <option value="1">Si</option>
                            <option value="2">No</option>
                        </select>
                    </div>
                    <div class="row">
                        <div class="col-sm-2">Homicidio:</div>
                        <div class="col-sm-3">
                            <select class="form-control" id="cboHomicidio" runat="server" name="cboHomicidio" tabindex="25">
                                <option value="-1">Seleccione...</option>
                                <option value="1">Si</option>
                                <option value="2">No</option>
                            </select>
                        </div>
                        <div class="col-sm-2"></div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-sm-2">Masacre:</div>
                    <div class="col-sm-3">
                        <select class="form-control" id="cboMasacre" runat="server" name="cboMasacre" tabindex="26">
                            <option value="-1">Seleccione...</option>
                            <option value="1">Si</option>
                            <option value="2">No</option>
                        </select>
                    </div>
                    <div class="col-sm-2">Minas Antipersonal, Munición sin Explotar y artefacto explosivo improvisado:</div>
                    <div class="col-sm-3">
                        <select class="form-control" id="cboMinas" runat="server" name="cboMinas" tabindex="27">
                            <option value="-1">Seleccione...</option>
                            <option value="1">Si</option>
                            <option value="2">No</option>
                        </select>
                    </div>
                    <div class="col-sm-2"></div>
                </div>
                <br />
                <div class="row">
                    <div class="col-sm-2">Secuestro:</div>
                    <div class="col-sm-3">
                        <select class="form-control" id="cboSecuestro" runat="server" name="cboSecuestro" tabindex="28">
                            <option value="-1">Seleccione...</option>
                            <option value="1">Si</option>
                            <option value="2">No</option>
                        </select>
                    </div>
                    <div class="row">
                        <div class="col-sm-2">Tortura:</div>
                        <div class="col-sm-3">
                            <select class="form-control" id="cboTortura" runat="server" name="cboTortura" tabindex="29">
                                <option value="-1">Seleccione...</option>
                                <option value="1">Si</option>
                                <option value="2">No</option>
                            </select>
                        </div>
                        <div class="col-sm-2"></div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-sm-2">Vinculación de Niños, Niñas y Adolescentes a actividades relacionadas con grupos armados:</div>
                    <div class="col-sm-3">
                        <select class="form-control" id="cboVinculacion" runat="server" name="cboVinculacion" tabindex="30">
                            <option value="-1">Seleccione...</option>
                            <option value="1">Si</option>
                            <option value="2">No</option>
                        </select>
                    </div>
                    <div class="row">
                        <div class="col-sm-2">Abandono o Despojo Forzado de Tierras:</div>
                        <div class="col-sm-3">
                            <select class="form-control" id="cboAbandono" runat="server" name="cboAbandono" tabindex="31">
                                <option value="-1">Seleccione...</option>
                                <option value="1">Si</option>
                                <option value="2">No</option>
                            </select>
                        </div>
                        <div class="col-sm-2"></div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-sm-2">Profesional Responsable:</div>
                    <div class="col-sm-3">
                        <input type="text" class="form-control" id="txtProfesional" maxlength="50" style="text-transform: uppercase;" value="" onkeyup="javascript:this.value=this.value.toUpperCase();" runat="server" tabindex="32" />
                    </div>
                    <div class="col-sm-7"></div>
                </div>
                <br />
                <table class="table">
                    <tr>
                        <td class="info">
                            <center><b>Seguimientos Psicosociales</b></center>
                        </td>
                    </tr>
                </table>
                <br />
                <div class="row">
                    <div class="col-sm-2">Orientación Temática:</div>
                    <div class="col-sm-3">
                        <input type="text" class="form-control" id="txtOrientacionTemat" maxlength="60" style="text-transform: uppercase;" value="" onkeyup="javascript:this.value=this.value.toUpperCase();" runat="server" tabindex="32" />
                    </div>
                    <div class="col-sm-2">Acercamiento y Reconocimiento:</div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <div class='input-group date' id='datetimepicker2' runat="server">
                                <input type='text' class="form-control" id="dtpAcercamiento" runat="server" tabindex="34" />
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-calendar"></span>
                                </span>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-2"></div>
                </div>
                <br />
                <div class="col-sm-2">Seguimiento 2:</div>
                <div class="col-sm-3">
                    <div class="form-group">
                        <div class='input-group date' id='datetimepicker3' runat="server">
                            <input type='text' class="form-control" id="dtpSeguimiento2" runat="server" tabindex="35" />
                            <span class="input-group-addon">
                                <span class="glyphicon glyphicon-calendar"></span>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-2">Seguimiento 3:</div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <div class='input-group date' id='datetimepicker4' runat="server">
                                <input type='text' class="form-control" id="dtpSeguimiento3" runat="server" tabindex="36" />
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-calendar"></span>
                                </span>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-2"></div>
                </div>
                <br />
                <div class="col-sm-2">Seguimiento 4:</div>
                <div class="col-sm-3">
                    <div class="form-group">
                        <div class='input-group date' id='datetimepicker5' runat="server">
                            <input type='text' class="form-control" id="dtpSeguimiento4" runat="server" tabindex="37" />
                            <span class="input-group-addon">
                                <span class="glyphicon glyphicon-calendar"></span>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-2">Seguimiento 5:</div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <div class='input-group date' id='datetimepicker6' runat="server">
                                <input type='text' class="form-control" id="dtpSeguimiento5" runat="server" tabindex="38" />
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-calendar"></span>
                                </span>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-2"></div>
                </div>
                <br />
                <div class="col-sm-2">Seguimiento 6:</div>
                <div class="col-sm-3">
                    <div class="form-group">
                        <div class='input-group date' id='datetimepicker7' runat="server">
                            <input type='text' class="form-control" id="dtpSeguimiento6" runat="server" tabindex="39" />
                            <span class="input-group-addon">
                                <span class="glyphicon glyphicon-calendar"></span>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-2">Seguimiento 7:</div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <div class='input-group date' id='datetimepicker8' runat="server">
                                <input type='text' class="form-control" id="dtpSeguimiento7" runat="server" tabindex="40" />
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-calendar"></span>
                                </span>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-2"></div>
                </div>
                <br />
                <div class="col-sm-2">Seguimiento 8:</div>
                <div class="col-sm-3">
                    <div class="form-group">
                        <div class='input-group date' id='datetimepicker9' runat="server">
                            <input type='text' class="form-control" id="dtpSeguimiento8" runat="server" tabindex="41" />
                            <span class="input-group-addon">
                                <span class="glyphicon glyphicon-calendar"></span>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-2">Cierre:</div>
                    <div class="col-sm-3">
                        <div class="form-group">
                            <div class='input-group date' id='datetimepicker10' runat="server">
                                <input type='text' class="form-control" id="dtpCierre" runat="server" tabindex="42" />
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-calendar"></span>
                                </span>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-2"></div>
                </div>
                <br />
                <div class="col-sm-2">Aseguramiento:</div>
                <div class="col-sm-3">
                    <select class="form-control" id="cboAseguramiento" runat="server" name="cboAseguramiento" tabindex="63">
                        <option value="-1">Seleccione...</option>
                        <option value="1">Contributivo</option>
                        <option value="2">Subsidiado</option>
                        <option value="3">Especial</option>
                        <option value="4">No Asegurado</option>
                    </select>
                </div>
                <div class="row">
                    <div class="col-sm-2">EAPB:</div>
                    <div class="col-sm-3">
                        <asp:DropDownList runat="server" ID="cboEAPB" CssClass="form-control" DataValueField="Id_Aseguradora" DataTextField="NombreAseguradora" TabIndex="43"></asp:DropDownList>
                    </div>
                    <div class="col-sm-2"></div>
                </div>
                <br />
                <div class="row">
                    <div class="col-sm-2">Proyecto de Vivienda Gratuita:</div>
                    <div class="col-sm-3">
                        <asp:DropDownList runat="server" ID="cboProyectoViv" CssClass="form-control" DataValueField="Id_PuntoViv" DataTextField="NombrePuntoViv" TabIndex="44"></asp:DropDownList>
                    </div>
                    <div class="col-sm-2">Remitido Por</div>
                    <div class="col-sm-3">
                        <asp:DropDownList runat="server" ID="cboRemitidoP" CssClass="form-control" DataValueField="Id_Remitido" DataTextField="NombrePuntoViv" TabIndex="45"></asp:DropDownList>
                    </div>
                    <div class="col-sm-2"></div>
                </div>
                <br />
                <div class="row">
                    <div class="col-sm-2">Observaciones:</div>
                    <div class="col-sm-8">
                        <textarea class="form-control" id="txtObservaciones" maxlength="300" rows="4" style="text-transform: uppercase;" value="" onkeyup="javascript:this.value=this.value.toUpperCase();" runat="server" tabindex="46"></textarea>
                    </div>
                    <div class="col-sm-2"></div>
                </div>
                <br />
                <div class="row">
                    <div class="col-sm-3"></div>
                    <div class="col-sm-3">
                        <button type="button" class="btn btn-primary" runat="server" id="btnInsertar" tabindex="47">
                            <span class="glyphicon glyphicon-floppy-save"></span>Insertar       
                   
                        </button>
                    </div>
                    <div class="col-sm-3">
                    </div>
                    <div class="col-sm-3">
                        <button type="button" class="btn btn-primary" runat="server" id="btnCancelar" onserverclick="btnCancelar_ServerClick" tabindex="48">
                            <span class="glyphicon glyphicon-log-out"></span>Cancelar     
                   
                        </button>
                    </div>
                    <div class="col-sm-2"></div>
                    <br />
                    <br />
                    <br />
                </div>
    </form>
</body>
</html>
