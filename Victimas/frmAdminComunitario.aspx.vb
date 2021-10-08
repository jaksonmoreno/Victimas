Imports Telerik.Web.UI
Imports System.Data
Partial Class Victimas_frmAdminComunitario
    Inherits System.Web.UI.Page

    Private _PrimeraPag As Boolean = False
    Private _SiguientePag As Boolean = False
    Private _PreviaPag As Boolean = False
    Private _UltimaPag As Boolean = False
    Private _IrPag As Boolean = False
    Private _MsgError As String
    Private oComunitario As New clsComunitario

    Private oRutinas As New ClsRutinas
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Verificar si la sessión se cerro
        If Session("IdUsuario") = 0 Then
            Response.Redirect("../Administrador/Seguridad/frmExpiroSession.aspx", True)
            Exit Sub
        End If 'sdf

        '    ''''***************************************************************************************
        '    'redirecciona a una pagina de error si el usuario no tiene los privilegios
        If Not IsPostBack Then
            If clsSeguridad.ValidarPermisos(Session, "Comunitario") = False Then
                Response.Redirect("../Administrador/Seguridad/Paginasinprivilegios.htm", True)
            End If

            clsSeguridad.FiltrarGrilla(Session, "Comunitario", rgComunitario)
            Dim Datos As New DataSet
            Dim objparametros As New Collection
            Dim ObjItems As New CmdParametro("@NombreFormulario", "Comunitario", SqlDbType.Char, False, 100)
            objparametros.Add(ObjItems)
            Dim idRol As Integer = GetRol(Session("UserRoles"))
            ObjItems = New CmdParametro("@idTblRoles", idRol, SqlDbType.Int, False)
            objparametros.Add(ObjItems)
            Datos = clsBitacora.GetSelect("spGetTblFormulariosByRolUsuario2", objparametros, Session, 1, False)
            If Datos.Tables(0).Rows.Count > 0 Then
                Session("Activar") = Datos.Tables(0).Rows(0).Item("IndActivar")
            End If
        End If

        Me.txtAnioEpide.Text = Now.Year.ToString

        '    'Obtener el role del usuario 
        Dim RolUser As Integer = GetRol(Session("UserRoles"))

        FilterEspanish()
    End Sub
    '''' <summary>
    '''' Obtener la fecha del servidor
    '''' </summary>
    '''' <author>JPaez 15-09-2010</author>
    '''' <returns>Date</returns>
    '''' <remarks>Retorna la fecha del servidor para usarse como fecha hoy valida</remarks>
    Private Function TraerFechaServidor() As Date
        Dim Datos As New DataSet
        Dim objparametros As New Collection
        Dim Fecha As Date = clsBitacora.GetSelect("app.spGetFechaServidor", objparametros, Session, 281, False).Tables(0).Rows(0).Item(0)
        Return Fecha
    End Function
    ''' <summary>
    ''' Obtener el valor de un parámetro en forma de cadena
    ''' </summary>
    ''' <author>JPaez</author>
    ''' <datewritten>07-12-2010</datewritten>
    ''' <param name="pParametro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function TraerParametro(ByVal pParametro As String) As String

        Dim Datos As New DataSet
        Dim objparametros As New Collection
        Dim ObjItems As New CmdParametro("@NombreParametro", pParametro, SqlDbType.Char, False, 50)
        objparametros.Add(ObjItems)
        Dim dt As DataTable = clsBitacora.GetSelect("app.spGetTblParametrosByName", objparametros, Session, 281, False).Tables(0)
        If dt.Rows.Count <= 0 Then
            Return ""
        End If

        Dim sValRet As String = ""

        Dim dr As DataRow = dt.Rows(0)
        Select Case UCase(dr("Tipo"))
            Case "C"
                sValRet = Trim(dr("ValorCadena"))
            Case "E"
                sValRet = dr("ValorEntero").ToString
            Case "D"
                sValRet = dr("ValorDecimal").ToString
            Case "F"
                sValRet = dr("ValorFecha").ToString
        End Select

        Return sValRet

    End Function
    ''' <summary>
    ''' Obtener el código de tipo de entidad para la entidad de un usuario dado
    ''' </summary>
    ''' <author>JPaez</author>
    ''' <datewritten>09-12-2010</datewritten>
    ''' <param name="pUsuarioId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function TraerTipoEntidad(ByVal pUsuarioId As Integer) As Integer

        Dim Datos As New DataSet
        Dim objparametros As New Collection
        Dim ObjItems As New CmdParametro("@idTblUsuarios", pUsuarioId, SqlDbType.Int, False)
        objparametros.Add(ObjItems)
        Dim dt As DataTable = clsBitacora.GetSelect("[app].[spGetUsuarioById]", objparametros, Session, 113, False).Tables(0)
        If dt.Rows.Count <= 0 Then
            Return 0
        End If

        Return dt.Rows(0).Item("Id_TipoEntidad")

    End Function
    ''' <summary>
    ''' GetRol
    ''' </summary>
    ''' <param name="Col"></param>
    ''' <returns>Integer con el identificador del rol actual</returns>
    ''' <remarks>
    ''' Obtiene el rol actual de la lista de roles asignados a un usuario determinado
    ''' </remarks>
    Private Function GetRol(ByVal Col As clsListadoRoles) As Integer
        If Me.Session("UserRoles") Is Nothing Then
            Response.Redirect("../Administrador/Seguridad/Paginasinprivilegios.htm", True)
        Else
            Return CType(Me.Session("UserRoles"), clsListadoRoles).IdRol
        End If
    End Function
    ''' <summary>
    ''' ObtenerDatos
    ''' </summary>
    ''' <value></value>
    ''' <returns>DataSet</returns>
    ''' <Author>Favio Hernandez</Author>
    ''' <remarks>
    ''' Obtiene los eventos a los que tiene permiso un usuario especifico dependiendo de su rol y del subsistema
    ''' </remarks>
    '''Public ReadOnly Property ObtenerDatos(ByVal pIdEvento As Integer, ByVal pDocumento As String, ByVal pNombre As String, ByVal pSeguimiento As String) As DataSet
    Public ReadOnly Property ObtenerDatos() As DataSet

        'Propiedad de la página que devuelve el dataset
        'Lo busca primero en Session para retornarlo
        'Si no lo encuentra lo toma de la Base de Datos
        Get
            Dim Datos As New DataSet
            Try
                Dim objparametros As New Collection
                Dim prmt As New CmdParametro("@IdRol", GetRol(Session("UserRoles")), SqlDbType.Int, False)
                objparametros.Add(prmt)
                prmt = New CmdParametro("@IdSubred", Session("IdSubred"), SqlDbType.Int, False)
                objparametros.Add(prmt)
                Datos = clsBitacora.GetSelect("app.SpGetComunitarios", objparametros, Session, 126, False)   '<JPaez 09-12-2010>

                If Datos.Tables.Count > 0 Then
                    Datos.Tables(0).TableName = "Datos"
                End If
                _MsgError = ""
                Return Datos
            Catch ex As Exception
                _MsgError = ex.Message
                Return Datos
            End Try
        End Get

    End Property
    ''' <summary>
    ''' RadGrid1_DeleteCommand
    ''' </summary>
    ''' <param name="source"></param>
    ''' <param name="e"></param>
    ''' <remarks>
    ''' Elimina un registro de la tabla tblComunitario al eliminarlo de la grilla.
    ''' </remarks>
    Protected Sub RadGrid1_DeleteCommand(ByVal source As Object, ByVal e As Telerik.Web.UI.GridCommandEventArgs) Handles rgComunitario.DeleteCommand
        Dim editedItem As GridEditableItem = CType(e.Item, GridEditableItem)

        Dim Indice As String = e.Item.OwnerTableView.DataKeyValues(e.Item.ItemIndex)("Id_Comunitario")
        Dim Objparametros As New Collection
        Dim ObjItems As New CmdParametro("@Id_Comunitario", Indice, SqlDbType.Int, True)
        Objparametros.Add(ObjItems)
        Dim update As String = clsBitacora.Update("spDeletetblViolenciaComunitario", Objparametros, Session, 280, True)
        If update <> "0" Then
            rgComunitario.Controls.Add(New LiteralControl("Hubo un Error en el Servidor de BD Id Error: " & update))
        End If
    End Sub
    ''' <summary>
    ''' RadGrid1_ItemCreated
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>
    ''' Asigna a cada botón de la grilla la función y los parámetros para abrir el formulario en modo Edición ó Visualización
    ''' </remarks>
    Protected Sub rgComunitario_ItemCreated(ByVal sender As Object, ByVal e As Telerik.Web.UI.GridItemEventArgs) Handles rgComunitario.ItemCreated

        If TypeOf e.Item Is GridDataItem Then
            '<JPaez 07-12-2010 Obtener la fecha del servidor como fecha hoy>
            Dim FechaHoy As Date = TraerFechaServidor()     '<JPaez 07-12-2010>

            'Código que agraga el evento onclick para direccionar la pagina al dar click en imgEditar
            Dim AbrirArchivo As Image = e.Item.FindControl("imgEditar")
            AbrirArchivo.Attributes("onClick") = String.Format("return ShowEditForm('{0}','{1}');", e.Item.OwnerTableView.DataKeyValues(e.Item.ItemIndex)("Id_Comunitario"), e.Item.ItemIndex)
            AbrirArchivo.Style.Add("cursor", "hand")
            AbrirArchivo.ToolTip = "Haga click aqui para editar violencia comunitario"


            Dim AbrirArchivoVer As Image = e.Item.FindControl("VerComunitario")
            AbrirArchivoVer.Attributes("onClick") = String.Format("return ShowForm('{0}','{1}');", e.Item.OwnerTableView.DataKeyValues(e.Item.ItemIndex)("Id_Comunitario"), e.Item.ItemIndex)
            AbrirArchivoVer.Style.Add("cursor", "hand")
            AbrirArchivoVer.ToolTip = "Haga click aqui para ver violencia comunitario"

        End If

    End Sub
    ''' <summary>
    ''' RaisePostBackEvent
    ''' </summary>
    ''' <param name="sourceControl"></param>
    ''' <param name="eventArgument"></param>
    ''' <remarks>
    ''' Actualiza la grilla luego que se han realizado cambios tanto en el  formulario de inserción como
    ''' en el de edición.
    ''' </remarks>
    Protected Overrides Sub RaisePostBackEvent(ByVal sourceControl As IPostBackEventHandler, ByVal eventArgument As String)

        Try
            MyBase.RaisePostBackEvent(sourceControl, eventArgument)

            If TypeOf sourceControl Is RadGrid Then
                Select Case eventArgument
                    Case "Rebind"
                        rgComunitario.MasterTableView.SortExpressions.Clear()
                        rgComunitario.MasterTableView.GroupByExpressions.Clear()
                        rgComunitario.Rebind()
                    Case "RebindAndNavigate"
                        rgComunitario.MasterTableView.SortExpressions.Clear()
                        rgComunitario.MasterTableView.GroupByExpressions.Clear()
                        rgComunitario.MasterTableView.CurrentPageIndex = rgComunitario.MasterTableView.PageCount - 1
                        rgComunitario.Rebind()
                End Select
            End If
        Catch ex As Exception
        End Try

    End Sub
    ''' <summary>
    ''' RadGrid1_NeedDataSource
    ''' </summary>
    ''' <param name="source"></param>
    ''' <param name="e"></param>
    ''' <remarks>
    ''' Invoca la función para recuperar datos ObtenerDatos() en el momento que la grilla lo solicite
    ''' </remarks>
    Protected Sub rgComunitario_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles rgComunitario.NeedDataSource

        'Me.RadGrid1.DataSource = ObtenerDatos(0, "", "", "").Tables("Datos")
        Me.rgComunitario.DataSource = ObtenerDatos().Tables("Datos")

    End Sub
    ''' <summary>
    ''' FilterEspanish
    ''' </summary>
    ''' <remarks>
    ''' Traduce las etiquetas de las opciones de filtro de la grilla.
    ''' </remarks>
    Private Sub FilterEspanish()
        Dim Menu As GridFilterMenu = Me.rgComunitario.FilterMenu
        Dim item As RadMenuItem
        For Each item In Menu.Items
            If item.Text = "NoFilter" Then
                item.Text = "No Filtrar"
            End If
            If item.Text = "Contains" Then
                item.Text = "Contiene"
            End If
            If item.Text = "DoesNotContain" Then
                item.Text = "No contiene"
            End If
            If item.Text = "StartsWith" Then
                item.Text = "Empieza Por"
            End If
            If item.Text = "EndsWith" Then
                item.Text = "Termina En"
            End If
            If item.Text = "EqualTo" Then
                item.Text = "Igual a"
            End If
            If item.Text = "NotEqualTo" Then
                item.Text = "Diferente de"
            End If
            If item.Text = "GreaterThan" Then
                item.Text = "Mayor"
            End If
            If item.Text = "LessThan" Then
                item.Text = "Menor"
            End If
            If item.Text = "GreaterThanOrEqualTo" Then
                item.Text = "Mayor o Igual a"
            End If
            If item.Text = "LessThanOrEqualTo" Then
                item.Text = "Menor o Igual a"
            End If
            If item.Text = "Between" Then
                item.Text = "Entre"
            End If
            If item.Text = "NotBetween" Then
                item.Text = "No Entre"
            End If
            If item.Text = "IsEmpty" Then
                item.Text = "Vacio"
            End If
            If item.Text = "NotIsEmpty" Then
                item.Text = "No vacio"
            End If
            If item.Text = "IsNull" Then
                item.Text = "Nulo"
            End If
            If item.Text = "NotIsNull" Then
                item.Text = "No Nulo"
            End If
        Next
    End Sub
    Protected Sub btnFiltrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Me.rgComunitario.DataSource = ObtenerDatos
        Me.rgComunitario.DataBind()

    End Sub
    Protected Sub btnNoFiltrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoFiltrar.Click

        For Each column As GridColumn In rgComunitario.MasterTableView.Columns
            column.CurrentFilterFunction = GridKnownFunction.NoFilter
            column.CurrentFilterValue = String.Empty
        Next

        rgComunitario.MasterTableView.FilterExpression = String.Empty
        rgComunitario.MasterTableView.Rebind()

    End Sub
End Class
