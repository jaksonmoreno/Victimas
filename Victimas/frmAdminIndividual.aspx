<%@ Page Language="VB" AutoEventWireup="false" CodeFile="frmAdminIndividual.aspx.vb" Inherits="Victimas_frmAdminIndividual" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link rel="stylesheet" href="../css/Num.css" type="text/css" />
    <style type="text/css">
        .FilterMenuClass td
        {
            cursor: hand;
            background-color: #E0E0E0;
            color: Black;
            font-size: 11px;
            font-family: tahoma;
        }

        .style1
        {
            font-family: Verdana;
            font-size: X-Small;
            font-style: normal;
            font-weight: bold;
            color: #254A70;
            height: 26px;
        }

        .style2
        {
            height: 26px;
        }

        .style3
        {
            font-family: Verdana;
            font-size: x-small;
            font-style: normal;
            color: #254A70;
        }
    </style>
    <title>Modalidad Individual</title>
</head>
    <body onkeydown="doSomething(event);">
    <script language="javascript" type="text/javascript">
        function doSomething(e) {
            var evt = e ? e : event;
            var tlc = (window.Event) ? evt.which : evt.keyCode;
            if (tlc == 13) {
                document.getElementById("botonFalsaBandera").focus();
            }
        }

        function GetRadWindow() {
            var oWindow = null;
            if (window.radWindow) oWindow = window.radWindow; //Will work in Moz in all cases, including clasic dialog
            else if (window.frameElement.radWindow) oWindow = window.frameElement.radWindow; //IE (and Moz az well)
            return oWindow;
        }

        function cerrar() {
            GetRadWindow().Close();
        }

        function ShowForm(Id_Individual, rowIndex) {
            var grid = window["<%= rgIndividual.ClientID%>"];
            var ventana1 = window.radopen("frmIndividual.aspx?opcion=view&Id_Individual=" + Id_Individual + "&n=" + (Math.random()), "UserListDialog");
            ventana1.Restore();
            ventana1.maximize();
            return false;
        }

        function ShowEditForm(Id_Individual, rowIndex) {
            var grid = window["<%= rgIndividual.ClientID%>"];
            var ventana4 = window.radopen("frmIndividual.aspx?opcion=edit&Id_Individual=" + Id_Individual + "&n=" + (Math.random()), "UserListDialog");
            ventana4.Restore();
            ventana4.maximize();
            return false;
        }

        function ShowInsertForm() {
            var ventana5 = window.radopen("frmIndividual.aspx?opcion=new" + "&n=" + (Math.random()), "UserListDialog");
            ventana5.Restore();
            ventana5.maximize();
            return false;
        }

        function refreshGrid(arg) {
            if (!arg) {
                var masterTable = $find("<%= rgIndividual.ClientID%>").get_masterTableView();
                masterTable.rebind();
            }
            else {
                var masterTable = $find("<%= rgIndividual.ClientID%>").get_masterTableView();
                masterTable.rebind();
                masterTable.page("Last");
            }
        }

    </script>
    <form id="form1" runat="server">
        <input id="botonFalsaBandera" type="button" value="button" style="width: 0px; height: 0px; background-color: transparent; font-size: xx-small;" />
        <div>
            <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
            </telerik:RadScriptManager>
            <table style="border: 2px solid #C0CFEF; background-color: Ivory; border-spacing: 2px; width: 100%;">
                <tr>
                    <td class="style1" style="width: 20%; vertical-align: middle;">Año epidemiológico:
                    <asp:TextBox ID="txtAnioEpide" runat="server" Width="30" CssClass="style3">
                    </asp:TextBox>
                    </td>
                    <td class="style2" style="width: 20%">
                        <asp:Button ID="btnFiltrar" runat="server" BackColor="#DFEFFF" Text="Filtrar" Width="50%" />
                    </td>
                    <td style="width: 20%">
                        <asp:Button ID="btnNoFiltrar" runat="server" BackColor="#DFEFFF" Text="No filtrar"
                            Width="50%" />
                    </td>
                    <td colspan="2"></td>
                </tr>
                <tr>
                    <td colspan="5"></td>
                </tr>
            </table>
            <telerik:RadGrid ID="rgIndividual" runat="server" AutoGenerateColumns="False" EnableAJAX="True"
                GridLines="None" EnableLinqExpressions="false" Skin="Default" AllowFilteringByColumn="True"
                AllowPaging="True" PageSize="10" CellSpacing="0" Culture="Spanish (Spain)" AllowSorting="True"
                ShowGroupPanel="False">
                <MasterTableView AllowFilteringByColumn="True" CommandItemDisplay="Top" DataKeyNames="Id_Individual, Id_Individual" NoMasterRecordsText="No hay eventos para mostrar.">
                    <Columns>
                        <telerik:GridTemplateColumn UniqueName="editar" AllowFiltering="False">
                            <ItemTemplate>
                                <asp:Image ID="imgEditar" runat="server" ImageUrl="~/Imagenes/Grid/Edit.gif" />
                            </ItemTemplate>
                            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridTemplateColumn>
                        <telerik:GridBoundColumn DataField="Id_Individual" HeaderText="Ficha" UniqueName="Id_Individual"
                            FilterImageToolTip="Filtrar" AllowFiltering="True">
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="left" Wrap="True" />
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="FechaApert" DataFormatString="{0:d}" HeaderText="Fecha de Apertura"
                            FilterImageToolTip="Filtrar" UniqueName="FechaApert">
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="PuntoAtencion" HeaderText="Nombre Punto de Atencion"
                            UniqueName="PuntoAtencion">
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridBoundColumn>
                        <telerik:GridTemplateColumn UniqueName="ver" AllowFiltering="False">
                            <ItemTemplate>
                                <asp:Image ID="VerIndividual" runat="server" ImageUrl="~/Imagenes/ver.gif" />
                            </ItemTemplate>
                            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridTemplateColumn>
                        
                        <telerik:GridTemplateColumn UniqueName="TemplateColumn123" HeaderText="Eliminar"
                            AllowFiltering="False">
                            <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                            <ItemTemplate>
                                <asp:ImageButton ID="ImageButton1" runat="server" AlternateText="Eliminar" OnClientClick="return radconfirm('Esta seguro que desea eliminar el registro?', event, 300,150,'','Eliminar');"
                                    CommandName="Delete" ImageUrl="~/Imagenes/Grid/Delete.gif" />
                            </ItemTemplate>
                            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                Font-Underline="False" HorizontalAlign="Center" Wrap="True" />
                        </telerik:GridTemplateColumn>
                    </Columns>
                    <ExpandCollapseColumn Visible="False" Resizable="False">
                        <HeaderStyle Width="20px" />
                    </ExpandCollapseColumn>
                    <RowIndicatorColumn Visible="False">
                        <HeaderStyle Width="20px" />
                    </RowIndicatorColumn>
                    <CommandItemSettings AddNewRecordText="Agregar Violencia Modalidad Individual" RefreshText="Actualizar" />
                    <CommandItemTemplate>
                        <asp:Image ID="AddRecord1" runat="server" ImageUrl="~/Imagenes/Grid/AddRecord.gif"
                            AlternateText="Agregar Violencia" />
                        <a href="#" onclick="return ShowInsertForm();">Agregar Registro</a>
                    </CommandItemTemplate>
                </MasterTableView>
                <AlternatingItemStyle BackColor="#B7DBFF" />
                <PagerStyle ForeColor="White" Mode="NextPrevNumericAndAdvanced" NextPagesToolTip="Siguientes"
                    NextPageToolTip="Siguiente" PagerTextFormat="Cambiar P&#225;gina: {4} &amp;nbsp;|&amp;nbsp; Mostrando p&#225;gina {0} de {1}, filas {2} a {3} de {5}."
                    PrevPagesToolTip="Anteriores" PrevPageToolTip="Anterior" />
                <ExportSettings>
                    <Pdf PageBottomMargin="" PageFooterMargin="" PageHeaderMargin="" PageHeight="11in"
                        PageLeftMargin="" PageRightMargin="" PageTopMargin="" PageWidth="8.5in" />
                </ExportSettings>
                <SortingSettings SortedAscToolTip="Ordenado asc" SortedDescToolTip="Ordenado desc"
                    SortToolTip="Click aqui para ordenar" />
                <ValidationSettings CommandsToValidate="PerformInsert,Update,Delete" />
                <FilterMenu CssClass="FilterMenuClass"> 
                </FilterMenu>
                <ClientSettings AllowDragToGroup="True">
                </ClientSettings>
                <GroupPanel Text="Arrastre el titulo de una columna aqui para agrupar">
                </GroupPanel>
                <GroupingSettings CaseSensitive="False" CollapseTooltip="Reducir grupo" ExpandTooltip="Expandir grupo"
                    GroupContinuedFormatString="... continuando grupo de la p&#225;gina anterior. "
                    GroupContinuesFormatString="El grupo contin&#250;a en la p&#225;gina siguiente."
                    GroupSplitDisplayFormat="Mostrando {0} de {1} filas." UnGroupTooltip="Arrastre fuera de la barra para desagrupar" />
            </telerik:RadGrid>
        </div>
        <table>
            <tr>
                <td>
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Imagenes/cerrar.gif"
                        OnClientClick="cerrar()" /><br />
                </td>
                <td>
                    <div id="ZonaMinimizar">
                        &nbsp;
                    </div>
                </td>
            </tr>
        </table>
        <telerik:RadWindowManager ID="RadWindowManager1" runat="server" Skin="Office2007"
            MinimizeZoneID="ZonaMinimizar" MinimizeMode="MinimizeZone">
            <Windows>
                <telerik:RadWindow ID="UserListDialog" runat="server" Title="" Height="560px" Width="1020px"
                    Left="150px" Top="50px" Modal="True" Skin="Office2007" NavigateUrl="" />
                <telerik:RadWindow ID="WindowBrotes" runat="server" Title="" Height="560px" Behaviors="Move,Maximize,Minimize"
                    Width="1020px" Left="150px" Top="50px" Modal="True" Skin="Office2007" NavigateUrl="" />
            </Windows>
        </telerik:RadWindowManager>
        <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server" EnableAJAX="true" DefaultLoadingPanelID="RadAjaxLoadingPanel1">
            <AjaxSettings>
            </AjaxSettings>
        </telerik:RadAjaxManager>
        <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" Height="15px"
            Skin="Office2010Silver" Width="15px">
        </telerik:RadAjaxLoadingPanel>
        <script language="javascript" src="../Js/VentanaConfirmar.js" type="text/javascript"></script>
    </form>
</body>
</html>
