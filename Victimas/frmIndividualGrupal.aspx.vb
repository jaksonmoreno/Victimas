Imports System.Data
Imports Telerik.Web.UI

Partial Class Victimas_frmIndividualGrupal
    Inherits System.Web.UI.Page

    Private oIndividualGrup As New clsIndividualGrupal
    Public oRutinas As New ClsRutinas
    Private Sub ObtenerDatos()

        If IsPostBack Then      '<JPaez 05-04-2011>
            Exit Sub
        End If

    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If IsPostBack Then
            Exit Sub
        End If

        CargarLocalidadesPCO()
        'CargarOrientacionTem()
        CargarPuntoAtencion()
        CargarAseguradoras()
        CargarPuntoVivienda()
        CargarRemitidoPor()

        If IsPostBack Then Exit Sub

    End Sub
    Protected Sub Page_LoadComplete(sender As Object, e As EventArgs) Handles Me.LoadComplete

        If IsPostBack Then Exit Sub

        Dim mode As String = Request.QueryString("opcion")

        Select Case mode
            Case "new"
                Me.Title = "Crear Nuevo Registro Individual Grupal"
            Case "edit"
                Me.Title = "Editar IndividualGrupal"
                Dim oIndiGrupal As New clsIndividualGrupal()
                oIndiGrupal.Load(Request.QueryString("Id_IndividualGrupal"))

                Me.txtGrupo.Value = oIndiGrupal.Grupo
                Me.cboPuntoAten.SelectedValue = oIndiGrupal.PuntoAtencion
                Me.dtpFechaApert.Value = oIndiGrupal.FechaApert
                Me.cboTipoDoc.Value = oIndiGrupal.TipoDoc
                Me.txtNumDoc.Value = oIndiGrupal.NumDoc
                Me.txtPrimerNombre.Value = oIndiGrupal.PrimerNombre
                Me.txtSegundoNombre.Value = oIndiGrupal.SegundoNombre
                Me.txtPrimerApellido.Value = oIndiGrupal.PrimerApellido
                Me.txtSegundoApellido.Value = oIndiGrupal.SegundoApellido
                Me.txtTelefono.Value = oIndiGrupal.Telefono
                Me.cboGenero.Value = oIndiGrupal.Genero
                Me.cboCicloVit.Value = oIndiGrupal.CicloVit
                Me.cboPertEtnica.Value = oIndiGrupal.PertEtnica
                Me.cboSituaCon.Value = oIndiGrupal.SituaCon
                Me.chkAreaRural.Checked = oIndiGrupal.AreaRural
                Me.txtDireccionPCO.Text = oIndiGrupal.DireccionPCO
                Me.rcbLocalidadPCO.SelectedValue = oIndiGrupal.LocalidadPCO
                Me.rcbBarrio.SelectedValue = oIndiGrupal.Barrio
                CargarBarriosLocalidad(oIndiGrupal.LocalidadPCO)
                Me.rcbNombreUpz.SelectedValue = oIndiGrupal.NombreUpz
                BindUpz()
                Me.cboTerrorista.Value = oIndiGrupal.Terrorista
                Me.cboAmenaza.Value = oIndiGrupal.Amenaza
                Me.cboDelitos.Value = oIndiGrupal.Delitos
                Me.cboDesaparicion.Value = oIndiGrupal.Desaparicion
                Me.cboDesplazamiento.Value = oIndiGrupal.Desplazamiento
                Me.cboHomicidio.Value = oIndiGrupal.Homicidio
                Me.cboMasacre.Value = oIndiGrupal.Masacre
                Me.cboMinas.Value = oIndiGrupal.Minas
                Me.cboSecuestro.Value = oIndiGrupal.Secuestro
                Me.cboTortura.Value = oIndiGrupal.Tortura
                Me.cboVinculacion.Value = oIndiGrupal.Vinculación
                Me.cboAbandono.Value = oIndiGrupal.Abandono
                Me.txtProfesional.Value = oIndiGrupal.Profesional
                Me.txtOrientacionTemat.Value = oIndiGrupal.OrientacionTemat
                Dim EditAcercamiento = oIndiGrupal.Acercamiento
                If EditAcercamiento = "01/01/1900" Then
                    Me.dtpAcercamiento.Value = ""
                Else
                    Me.dtpAcercamiento.Value = EditAcercamiento
                End If
                Dim EditSeguimiento2 = oIndiGrupal.Seguimiento2
                If EditSeguimiento2 = "01/01/1900" Then
                    Me.dtpSeguimiento2.Value = ""
                Else
                    Me.dtpSeguimiento2.Value = EditSeguimiento2
                End If
                Dim EditSeguimiento3 = oIndiGrupal.Seguimiento3
                If EditSeguimiento3 = "01/01/1900" Then
                    Me.dtpSeguimiento3.Value = ""
                Else
                    Me.dtpSeguimiento3.Value = EditSeguimiento3
                End If
                Dim EditSeguimiento4 = oIndiGrupal.Seguimiento4
                If EditSeguimiento4 = "01/01/1900" Then
                    Me.dtpSeguimiento4.Value = ""
                Else
                    Me.dtpSeguimiento4.Value = EditSeguimiento4
                End If
                Dim EditSeguimiento5 = oIndiGrupal.Seguimiento5
                If EditSeguimiento5 = "01/01/1900" Then
                    Me.dtpSeguimiento5.Value = ""
                Else
                    Me.dtpSeguimiento5.Value = EditSeguimiento5
                End If
                Dim EditSeguimiento6 = oIndiGrupal.Seguimiento6
                If EditSeguimiento6 = "01/01/1900" Then
                    Me.dtpSeguimiento6.Value = ""
                Else
                    Me.dtpSeguimiento6.Value = EditSeguimiento6
                End If

                Dim EditSeguimiento7 = oIndiGrupal.Seguimiento7
                If EditSeguimiento7 = "01/01/1900" Then
                    Me.dtpSeguimiento7.Value = ""
                Else
                    Me.dtpSeguimiento7.Value = EditSeguimiento7
                End If
                Dim EditSeguimiento8 = oIndiGrupal.Seguimiento8
                If EditSeguimiento8 = "01/01/1900" Then
                    Me.dtpSeguimiento8.Value = ""
                Else
                    Me.dtpSeguimiento8.Value = EditSeguimiento8
                End If
                Dim EditCierre = oIndiGrupal.Cierre
                If EditCierre = "01/01/1900" Then
                    Me.dtpCierre.Value = ""
                Else
                    Me.dtpCierre.Value = EditCierre
                End If
                Me.cboAseguramiento.Value = oIndiGrupal.Aseguramiento
                Me.cboEAPB.SelectedValue = oIndiGrupal.EAPB
                Me.cboProyectoViv.SelectedValue = oIndiGrupal.ProyectoViv
                Me.cboRemitidoP.SelectedValue = oIndiGrupal.RemitidoP
                Me.txtObservaciones.Value = oIndiGrupal.Observaciones

            Case "view"
                Me.Title = "ProcesarVisualizar"

                Dim oIndiGrupal As New clsIndividualGrupal()
                oIndiGrupal.Load(Request.QueryString("Id_IndividualGrupal"))

                Me.txtGrupo.Value = oIndiGrupal.Grupo
                Me.cboPuntoAten.SelectedValue = oIndiGrupal.PuntoAtencion
                Me.dtpFechaApert.Value = oIndiGrupal.FechaApert
                Me.cboTipoDoc.Value = oIndiGrupal.TipoDoc
                Me.txtNumDoc.Value = oIndiGrupal.NumDoc
                Me.txtPrimerNombre.Value = oIndiGrupal.PrimerNombre
                Me.txtSegundoNombre.Value = oIndiGrupal.SegundoNombre
                Me.txtPrimerApellido.Value = oIndiGrupal.PrimerApellido
                Me.txtSegundoApellido.Value = oIndiGrupal.SegundoApellido
                Me.txtTelefono.Value = oIndiGrupal.Telefono
                Me.cboGenero.Value = oIndiGrupal.Genero
                Me.cboCicloVit.Value = oIndiGrupal.CicloVit
                Me.cboPertEtnica.Value = oIndiGrupal.PertEtnica
                Me.cboSituaCon.Value = oIndiGrupal.SituaCon
                Me.chkAreaRural.Checked = oIndiGrupal.AreaRural
                Me.txtDireccionPCO.Text = oIndiGrupal.DireccionPCO
                Me.rcbLocalidadPCO.SelectedValue = oIndiGrupal.LocalidadPCO
                Me.rcbBarrio.SelectedValue = oIndiGrupal.Barrio
                CargarBarriosLocalidad(oIndiGrupal.LocalidadPCO)
                Me.rcbNombreUpz.SelectedValue = oIndiGrupal.NombreUpz
                BindUpz()
                Me.cboTerrorista.Value = oIndiGrupal.Terrorista
                Me.cboAmenaza.Value = oIndiGrupal.Amenaza
                Me.cboDelitos.Value = oIndiGrupal.Delitos
                Me.cboDesaparicion.Value = oIndiGrupal.Desaparicion
                Me.cboDesplazamiento.Value = oIndiGrupal.Desplazamiento
                Me.cboHomicidio.Value = oIndiGrupal.Homicidio
                Me.cboMasacre.Value = oIndiGrupal.Masacre
                Me.cboMinas.Value = oIndiGrupal.Minas
                Me.cboSecuestro.Value = oIndiGrupal.Secuestro
                Me.cboTortura.Value = oIndiGrupal.Tortura
                Me.cboVinculacion.Value = oIndiGrupal.Vinculación
                Me.cboAbandono.Value = oIndiGrupal.Abandono
                Me.txtProfesional.Value = oIndiGrupal.Profesional
                Me.txtOrientacionTemat.Value = oIndiGrupal.OrientacionTemat
                Dim ViewAcercamiento = oIndiGrupal.Acercamiento
                If ViewAcercamiento = "01/01/1900" Then
                    Me.dtpAcercamiento.Value = ""
                Else
                    Me.dtpAcercamiento.Value = ViewAcercamiento
                End If
                Dim ViewSeguimiento2 = oIndiGrupal.Seguimiento2
                If ViewSeguimiento2 = "01/01/1900" Then
                    Me.dtpSeguimiento2.Value = ""
                Else
                    Me.dtpSeguimiento2.Value = ViewSeguimiento2
                End If
                Dim ViewSeguimiento3 = oIndiGrupal.Seguimiento3
                If ViewSeguimiento3 = "01/01/1900" Then
                    Me.dtpSeguimiento3.Value = ""
                Else
                    Me.dtpSeguimiento3.Value = ViewSeguimiento3
                End If
                Dim ViewSeguimiento4 = oIndiGrupal.Seguimiento4
                If ViewSeguimiento4 = "01/01/1900" Then
                    Me.dtpSeguimiento4.Value = ""
                Else
                    Me.dtpSeguimiento4.Value = ViewSeguimiento4
                End If
                Dim ViewSeguimiento5 = oIndiGrupal.Seguimiento5
                If ViewSeguimiento5 = "01/01/1900" Then
                    Me.dtpSeguimiento5.Value = ""
                Else
                    Me.dtpSeguimiento5.Value = ViewSeguimiento5
                End If
                Dim ViewSeguimiento6 = oIndiGrupal.Seguimiento6
                If ViewSeguimiento6 = "01/01/1900" Then
                    Me.dtpSeguimiento6.Value = ""
                Else
                    Me.dtpSeguimiento6.Value = ViewSeguimiento6
                End If
                Dim ViewSeguimiento7 = oIndiGrupal.Seguimiento7
                If ViewSeguimiento7 = "01/01/1900" Then
                    Me.dtpSeguimiento7.Value = ""
                Else
                    Me.dtpSeguimiento7.Value = ViewSeguimiento7
                End If
                Dim ViewSeguimiento8 = oIndiGrupal.Seguimiento8
                If ViewSeguimiento8 = "01/01/1900" Then
                    Me.dtpSeguimiento8.Value = ""
                Else
                    Me.dtpSeguimiento8.Value = ViewSeguimiento8
                End If
                Dim ViewCierre = oIndiGrupal.Cierre
                If ViewCierre = "01/01/1900" Then
                    Me.dtpCierre.Value = ""
                Else
                    Me.dtpCierre.Value = ViewCierre
                End If
                Me.cboAseguramiento.Value = oIndiGrupal.Aseguramiento
                Me.cboEAPB.SelectedValue = oIndiGrupal.EAPB
                Me.cboProyectoViv.SelectedValue = oIndiGrupal.ProyectoViv
                Me.cboRemitidoP.SelectedValue = oIndiGrupal.RemitidoP
                Me.txtObservaciones.Value = oIndiGrupal.Observaciones
                ProcesarVisualizar()

        End Select

        Dim FechaHoy As Date = TraerFechaServidor()             '<JPaez 15-09-2010>

    End Sub
    Protected Sub btnInsertar_ServerClick(sender As Object, e As EventArgs) Handles btnInsertar.ServerClick

        Dim mode As String = Request.QueryString("opcion")
        Dim sIndGr As Boolean = False
        If Validar() Then
            Select Case mode
                Case "new"
                    sIndGr = ProcesarNuevo()
                Case "edit"
                    sIndGr = ProcesarEditar()
            End Select
        End If
    End Sub
    Private Function Validar() As Boolean
        If Me.txtGrupo.Value = "" Then
            RadAjaxManager1.Alert("Ingrese el consecutivo del grupo")
            Return False
        End If

        If Me.cboPuntoAten.SelectedValue = "" Then
            RadAjaxManager1.Alert("Seleccione el punto de atención")
            Return False
        End If

        If Me.dtpFechaApert.Value = "" Then
            RadAjaxManager1.Alert("Ingrese la fecha de apertura")
            Return False
        End If

        If Me.cboTipoDoc.Value = "-1" Then
            RadAjaxManager1.Alert("Seleccione Tipo de Documento")
            Return False
        End If

        'If Me.txtNumDoc.Value = String.Empty Then
        '    RadAjaxManager1.Alert("Ingrese el número de documento")
        '    Return False
        'End If

        If Me.txtPrimerNombre.Value = String.Empty Then
            RadAjaxManager1.Alert("Ingrese el primer nombre")
            Return False
        End If

        If Me.txtPrimerApellido.Value = String.Empty Then
            RadAjaxManager1.Alert("Ingrese el primer apellido")
            Return False
        End If

        If Me.txtTelefono.Value = String.Empty Then
            RadAjaxManager1.Alert("Ingrese el número de teléfono")
            Return False
        End If

        If Me.cboGenero.Value = "-1" Then
            RadAjaxManager1.Alert("Seleccione el género")
            Return False
        End If

        If Me.cboCicloVit.Value = "-1" Then
            RadAjaxManager1.Alert("Seleccione el ciclo vital")
            Return False
        End If

        If Me.cboPertEtnica.Value = "-1" Then
            RadAjaxManager1.Alert("Seleccione la pertenencia étnica")
            Return False
        End If

        If Me.cboSituaCon.Value = "-1" Then
            RadAjaxManager1.Alert("Seleccione la Situación / Condición")
            Return False
        End If

        If Me.rcbLocalidadPCO.Text = "Seleccione..." Then
            RadAjaxManager1.Alert("Debe seleccionar la LocalidadPCO")
            Return False
        End If

        If Me.rcbBarrio.Text = "Seleccione..." Then
            RadAjaxManager1.Alert("Debe seleccionar el barrio")
            Return False
        End If

        If Me.rcbNombreUpz.Text = "Seleccione..." Then
            RadAjaxManager1.Alert("Debe seleccionar la upz")
            Return False
        End If

        Return True
    End Function
    Private Function ProcesarNuevo() As Boolean

        Dim sIndGr As Boolean = False
        Dim oIndiGrupal As New clsIndividualGrupal
        With oIndiGrupal
            .Grupo = Me.txtGrupo.Value
            If cboPuntoAten.SelectedValue <> "Seleccione..." Then
                .PuntoAtencion = cboPuntoAten.SelectedValue
            End If
            .FechaApert = Me.dtpFechaApert.Value
            .TipoDoc = Me.cboTipoDoc.Value
            .NumDoc = Me.txtNumDoc.Value
            .PrimerNombre = Me.txtPrimerNombre.Value
            .SegundoNombre = Me.txtSegundoNombre.Value
            .PrimerApellido = Me.txtPrimerApellido.Value
            .SegundoApellido = Me.txtSegundoApellido.Value
            .Telefono = Me.txtTelefono.Value
            .Genero = Me.cboGenero.Value
            .CicloVit = Me.cboCicloVit.Value
            .PertEtnica = Me.cboPertEtnica.Value
            .SituaCon = Me.cboSituaCon.Value
            .AreaRural = Me.chkAreaRural.Checked
            .DireccionPCO = Me.txtDireccionPCO.Text
            .LocalidadPCO = Me.rcbLocalidadPCO.SelectedValue
            .Barrio = Me.rcbBarrio.SelectedValue
            .NombreUpz = Me.rcbNombreUpz.SelectedValue
            .Terrorista = Me.cboTerrorista.Value
            .Amenaza = Me.cboAmenaza.Value
            .Delitos = Me.cboDelitos.Value
            .Desaparicion = Me.cboDesaparicion.Value
            .Desplazamiento = Me.cboDesplazamiento.Value
            .Homicidio = Me.cboHomicidio.Value
            .Masacre = Me.cboMasacre.Value
            .Minas = Me.cboMinas.Value
            .Secuestro = Me.cboSecuestro.Value
            .Tortura = Me.cboTortura.Value
            .Vinculación = Me.cboVinculacion.Value
            .Abandono = Me.cboAbandono.Value
            .Profesional = Me.txtProfesional.Value
            .OrientacionTemat = Me.txtOrientacionTemat.Value


            'If cboOrientacionTemat.SelectedValue <> "Seleccione..." Then
            '    .OrientacionTemat = cboOrientacionTemat.SelectedValue
            'End If
            Dim Acercamiento = Me.dtpAcercamiento.Value
            If Acercamiento <> Nothing Then
                .Acercamiento = Me.dtpAcercamiento.Value
            Else
                .Acercamiento = "01/01/1900"
            End If
            Dim Seguimiento2 = Me.dtpSeguimiento2.Value
            If Seguimiento2 <> Nothing Then
                .Seguimiento2 = dtpSeguimiento2.Value
            Else
                .Seguimiento2 = "01/01/1900"
            End If
            Dim Seguimiento3 = dtpSeguimiento3.Value
            If Seguimiento3 <> Nothing Then
                .Seguimiento3 = dtpSeguimiento3.Value
            Else
                .Seguimiento3 = "01/01/1900"
            End If
            Dim Seguimiento4 = dtpSeguimiento4.Value
            If Seguimiento4 <> Nothing Then
                .Seguimiento4 = dtpSeguimiento4.Value
            Else
                .Seguimiento4 = "01/01/1900"
            End If
            Dim Seguimiento5 = dtpSeguimiento5.Value
            If Seguimiento5 <> Nothing Then
                .Seguimiento5 = dtpSeguimiento5.Value
            Else
                .Seguimiento5 = "01/01/1900"
            End If
            Dim Seguimiento6 = dtpSeguimiento6.Value
            If Seguimiento6 <> Nothing Then
                .Seguimiento6 = dtpSeguimiento6.Value
            Else
                .Seguimiento6 = "01/01/1900"
            End If
            Dim Seguimiento7 = dtpSeguimiento7.Value
            If Seguimiento7 <> Nothing Then
                .Seguimiento7 = dtpSeguimiento7.Value
            Else
                .Seguimiento7 = "01/01/1900"
            End If
            Dim Seguimiento8 = dtpSeguimiento8.Value
            If Seguimiento8 <> Nothing Then
                .Seguimiento8 = dtpSeguimiento8.Value
            Else
                .Seguimiento8 = "01/01/1900"
            End If
            Dim Cierre = dtpCierre.Value
            If Cierre <> Nothing Then
                .Cierre = dtpCierre.Value
            Else
                .Cierre = "01/01/1900"
            End If
            .Aseguramiento = Me.cboAseguramiento.Value
            If cboEAPB.SelectedValue <> "Seleccione..." Then
                .EAPB = cboEAPB.SelectedValue
            End If
            If cboProyectoViv.SelectedValue <> "Seleccione..." Then
                .ProyectoViv = cboProyectoViv.SelectedValue
            End If
            If cboProyectoViv.SelectedValue <> "Seleccione..." Then
                .RemitidoP = cboRemitidoP.SelectedValue
            End If
            .Observaciones = Me.txtObservaciones.Value

        End With
        Try
            Dim sIndGrup As Integer = oIndiGrupal.Insertar()
            If sIndGrup <= 0 Then
                sIndGr = False
                Me.RadAjaxManager1.Alert("Error: ")
            Else
                sIndGr = True
                RadAjaxManager1.ResponseScripts.Add("CloseAndRebindInsert(1);")
            End If
        Catch ex As Exception
            Me.RadAjaxManager1.Alert("Error: " & ex.Message)
            sIndGr = False
        End Try

        Return sIndGr

    End Function
    Private Function ProcesarEditar() As Boolean

        Dim sIndGr As Boolean = False
        Dim oIndiGrupal As New clsIndividualGrupal
        oIndiGrupal.Load(Request.QueryString("Id_IndividualGrupal"))
        With oIndiGrupal
            .Grupo = Me.txtGrupo.Value
            If cboPuntoAten.SelectedValue <> "Seleccione..." Then
                .PuntoAtencion = cboPuntoAten.SelectedValue
            End If
            .FechaApert = Me.dtpFechaApert.Value
            .TipoDoc = Me.cboTipoDoc.Value
            .NumDoc = Me.txtNumDoc.Value
            .PrimerNombre = Me.txtPrimerNombre.Value
            .SegundoNombre = Me.txtSegundoNombre.Value
            .PrimerApellido = Me.txtPrimerApellido.Value
            .SegundoApellido = Me.txtSegundoApellido.Value
            .Telefono = Me.txtTelefono.Value
            .Genero = Me.cboGenero.Value
            .CicloVit = Me.cboCicloVit.Value
            .PertEtnica = Me.cboPertEtnica.Value
            .SituaCon = Me.cboSituaCon.Value
            .AreaRural = Me.chkAreaRural.Checked
            .DireccionPCO = Me.txtDireccionPCO.Text
            .LocalidadPCO = Me.rcbLocalidadPCO.SelectedValue
            .Barrio = Me.rcbBarrio.SelectedValue
            .NombreUpz = Me.rcbNombreUpz.SelectedValue
            .Terrorista = Me.cboTerrorista.Value
            .Amenaza = Me.cboAmenaza.Value
            .Delitos = Me.cboDelitos.Value
            .Desaparicion = cboDesaparicion.Value
            .Desplazamiento = Me.cboDesplazamiento.Value
            .Homicidio = Me.cboHomicidio.Value
            .Masacre = Me.cboMasacre.Value
            .Minas = Me.cboMinas.Value
            .Secuestro = Me.cboSecuestro.Value
            .Tortura = Me.cboTortura.Value
            .Vinculación = Me.cboVinculacion.Value
            .Abandono = Me.cboAbandono.Value
            .Profesional = Me.txtProfesional.Value
            .OrientacionTemat = Me.txtOrientacionTemat.Value

            'If cboOrientacionTemat.SelectedValue <> "Seleccione..." Then
            '    .OrientacionTemat = cboOrientacionTemat.SelectedValue
            'End If
            Dim Acercamiento = Me.dtpAcercamiento.Value
            If Acercamiento <> Nothing Then
                .Acercamiento = Me.dtpAcercamiento.Value
            Else
                .Acercamiento = "01/01/1900"
            End If
            Dim Seguimiento2 = Me.dtpSeguimiento2.Value
            If Seguimiento2 <> Nothing Then
                .Seguimiento2 = dtpSeguimiento2.Value
            Else
                .Seguimiento2 = "01/01/1900"
            End If
            Dim Seguimiento3 = dtpSeguimiento3.Value
            If Seguimiento3 <> Nothing Then
                .Seguimiento3 = dtpSeguimiento3.Value
            Else
                .Seguimiento3 = "01/01/1900"
            End If
            Dim Seguimiento4 = dtpSeguimiento4.Value
            If Seguimiento4 <> Nothing Then
                .Seguimiento4 = dtpSeguimiento4.Value
            Else
                .Seguimiento4 = "01/01/1900"
            End If
            Dim Seguimiento5 = dtpSeguimiento5.Value
            If Seguimiento5 <> Nothing Then
                .Seguimiento5 = dtpSeguimiento5.Value
            Else
                .Seguimiento5 = "01/01/1900"
            End If
            Dim Seguimiento6 = dtpSeguimiento6.Value
            If Seguimiento6 <> Nothing Then
                .Seguimiento6 = dtpSeguimiento6.Value
            Else
                .Seguimiento6 = "01/01/1900"
            End If
            Dim Seguimiento7 = dtpSeguimiento7.Value
            If Seguimiento7 <> Nothing Then
                .Seguimiento7 = dtpSeguimiento7.Value
            Else
                .Seguimiento7 = "01/01/1900"
            End If
            Dim Seguimiento8 = dtpSeguimiento8.Value
            If Seguimiento8 <> Nothing Then
                .Seguimiento8 = dtpSeguimiento8.Value
            Else
                .Seguimiento8 = "01/01/1900"
            End If
            Dim Cierre = dtpCierre.Value
            If Cierre <> Nothing Then
                .Cierre = dtpCierre.Value
            Else
                .Cierre = "01/01/1900"
            End If
            .Aseguramiento = Me.cboAseguramiento.Value
            If cboEAPB.SelectedValue <> "Seleccione..." Then
                .EAPB = cboEAPB.SelectedValue
            End If
            If cboProyectoViv.SelectedValue <> "Seleccione..." Then
                .ProyectoViv = cboProyectoViv.SelectedValue
            End If
            If cboRemitidoP.SelectedValue <> "Seleccione..." Then
                .RemitidoP = cboRemitidoP.SelectedValue
            End If
            .Observaciones = Me.txtObservaciones.Value

        End With
        Try
            Dim sIndGrup As Integer = oIndiGrupal.Actualizar
            If sIndGrup <> 0 Then
                Me.RadAjaxManager1.Alert("Error: ")
                sIndGr = False
            Else
                sIndGr = True
                RadAjaxManager1.ResponseScripts.Add("CloseAndRebindInsert(0);")
            End If
        Catch ex As Exception
            Me.RadAjaxManager1.Alert("Error: " & ex.Message)
            sIndGr = False
        End Try

        Return sIndGr

    End Function
    '''' <summary>
    '''' InhabilitarControles
    '''' </summary>
    '''' <autor>Julio Paez</autor>
    '''' <autor> En Violencias Individuales Grupales usado por Jakson Moreno R 21 -05 -2021</autor>
    '''' <remarks>Procedimiento que inhabilita todos los controles para no permitir la modificación de datos
    '''' usuarios no autorizados</remarks>
    '''' 'Jmoreno 18/12/2020
    Private Sub ProcesarVisualizar()

        Try

            Me.txtGrupo.Disabled = True
            Me.cboPuntoAten.Enabled = False
            Me.dtpFechaApert.Disabled = True
            Me.cboTipoDoc.Disabled = True
            Me.txtNumDoc.Disabled = True
            Me.txtPrimerNombre.Disabled = True
            Me.txtSegundoNombre.Disabled = True
            Me.txtPrimerApellido.Disabled = True
            Me.txtSegundoApellido.Disabled = True
            Me.txtTelefono.Disabled = True
            Me.cboGenero.Disabled = True
            Me.cboCicloVit.Disabled = True
            Me.cboPertEtnica.Disabled = True
            Me.cboSituaCon.Disabled = True
            Me.chkAreaRural.Disabled = True
            Me.txtDireccionPCO.Enabled = False
            Me.rcbLocalidadPCO.Enabled = False
            Me.rcbBarrio.Enabled = False
            Me.rcbNombreUpz.Enabled = False
            Me.cboTerrorista.Disabled = True
            Me.cboAmenaza.Disabled = True
            Me.cboDelitos.Disabled = True
            Me.cboDesaparicion.Disabled = True
            Me.cboDesplazamiento.Disabled = True
            Me.cboHomicidio.Disabled = True
            Me.cboMasacre.Disabled = True
            Me.cboMinas.Disabled = True
            Me.cboSecuestro.Disabled = True
            Me.cboTortura.Disabled = True
            Me.cboVinculacion.Disabled = True
            Me.cboAbandono.Disabled = True
            Me.txtProfesional.Disabled = True
            Me.txtOrientacionTemat.Disabled = True
            'Me.cboOrientacionTemat.Enabled = False
            Me.dtpAcercamiento.Disabled = True
            Me.dtpSeguimiento2.Disabled = True
            Me.dtpSeguimiento3.Disabled = True
            Me.dtpSeguimiento4.Disabled = True
            Me.dtpSeguimiento5.Disabled = True
            Me.dtpSeguimiento6.Disabled = True
            Me.dtpSeguimiento7.Disabled = True
            Me.dtpSeguimiento8.Disabled = True
            Me.dtpCierre.Disabled = True
            Me.cboAseguramiento.Disabled = True
            Me.cboEAPB.Enabled = False
            Me.cboProyectoViv.Enabled = False
            Me.cboRemitidoP.Enabled = False
            Me.txtObservaciones.Disabled = True
            Me.btnInsertar.Visible = False
        Catch
        End Try

    End Sub
    Private Function CargarDatos() As DataRow

        Dim Id_IndividualGrupal As Integer = Request.QueryString("Id_IndividualGrupal")
        Dim dr As Data.DataRow = Nothing
        Dim ds As New DataSet
        Dim coleccionParametros As New Collection
        Dim parametro As New CmdParametro("@Id_IndividualGrupal", Id_IndividualGrupal, SqlDbType.Int, True)
        coleccionParametros.Add(parametro)
        ds = clsBitacora.GetSelect("spViolenciaIndividualGrupalById", coleccionParametros, Session, 35, False)
        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
            End If
        End If
        Return dr

    End Function
    Private Function GetRol(ByVal Col As clsListadoRoles) As Integer
        If Me.Session("UserRoles") Is Nothing Then
            Response.Redirect("../Administrador/Seguridad/Paginasinprivilegios.htm", True)
        Else
            Return CType(Me.Session("UserRoles"), clsListadoRoles).IdRol
        End If
        Return ""
    End Function
    Private Sub CargarLocalidadesPCO()
        Dim coleccionParametros As New Collection
        Dim dt As DataTable = clsBitacora.GetSelect("spGetTblLocalidades", coleccionParametros, Session, 422, False).Tables(0)

        dt = numerarOpciones(dt)

        Me.rcbLocalidadPCO.DataValueField = "IdTblLocalidades"
        Me.rcbLocalidadPCO.DataTextField = "NombreLocalidad"
        Me.rcbLocalidadPCO.DataSource = dt
        Me.rcbLocalidadPCO.DataBind()
        Me.rcbLocalidadPCO.Items.Insert(0, "Seleccione...")
    End Sub
    Function getBarrio(ByVal pIdLocalidad As Integer) As DataTable

        Dim dt As New DataTable
        Dim prmtIdBarrio As New CmdParametro("@IdTblLocalidad", pIdLocalidad, Data.SqlDbType.Int, False)
        Dim coleccionParametros As New Collection
        coleccionParametros.Add(prmtIdBarrio)
        dt = clsBitacora.GetSelect("SpComunitariaBarrioPorLocalidad", coleccionParametros, Session, 96, False).Tables(0)
        Return dt
    End Function
    '''' <summary>
    '''' Obtener lista de Barrios por una Localidad
    '''' </summary>
    '''' <param name="pIdLocalidad">Identificador único de Upz</param>
    '''' <remarks></remarks>
    Private Sub CargarBarriosLocalidad(pIdLocalidad As Integer)

        Dim dt As New DataTable
        Dim prmtIdbarrio As New CmdParametro("@IdTblLocalidad", pIdLocalidad, Data.SqlDbType.Int, False)
        Dim coleccionParametros As New Collection
        coleccionParametros.Add(prmtIdbarrio)
        dt = clsBitacora.GetSelect("spGetBarriosLocalidades", coleccionParametros, Session, 96, False).Tables(0)
        Dim Dr As DataRow
        Dr = dt.NewRow
        Dr("idTblBarrios") = "9998"
        Dr("NombreBarrio") = "Otro barrio no estandar"
        dt.Rows.Add(Dr)

        Me.rcbBarrio.DataSource = dt
        Me.rcbBarrio.DataBind()
        Me.rcbBarrio.Items.Insert(0, "Seleccione...")
    End Sub
    Protected Sub txtDireccionPCO_TextChanged(sender As Object, e As EventArgs)
        If Me.txtDireccionPCO.Text.Trim = "" Then Exit Sub

        Dim oDir As New clsDireccion(Me.txtDireccionPCO.Text.Trim)

        If oDir.CodError = 0 Then
            Me.rcbLocalidadPCO.SelectedValue = oDir.IdLocalidad
            CargarBarriosLocalidad(oDir.IdLocalidad)
            BindBarrio()
            Me.rcbBarrio.SelectedValue = oDir.IdBarrio
            BindUpz()
            Me.rcbNombreUpz.SelectedValue = oDir.IdUpz
        End If
    End Sub
    Sub BindUpz()
        Dim listaUpz As New Data.DataTable
        If Me.rcbLocalidadPCO.SelectedValue <> "" Then
            listaUpz = getUPZ(Me.rcbLocalidadPCO.SelectedValue)
            Me.rcbNombreUpz.DataValueField = "IdTblUpz"
            Me.rcbNombreUpz.DataTextField = "NombreUPZ"
            Me.rcbNombreUpz.DataSource = numerarOpciones(listaUpz)
            Me.rcbNombreUpz.DataBind()
            Me.rcbNombreUpz.Items.Insert(0, "Seleccione...")
        End If
    End Sub
    Sub BindBarrio()
        Dim listaBarrio As New Data.DataTable
        If Me.rcbLocalidadPCO.SelectedValue <> "" Then
            listaBarrio = getBarrio(Me.rcbLocalidadPCO.SelectedValue)
            Me.rcbBarrio.DataValueField = "IdTblBarrios"
            Me.rcbBarrio.DataTextField = "NombreBarrio"
            Me.rcbBarrio.DataBind()
            Me.rcbBarrio.Items.Insert(0, "Seleccione...")
        End If
    End Sub
    Protected Sub agregarItemPorDefecto(ByRef combo As Telerik.Web.UI.RadComboBox, Optional ByVal TextoItem As String = "Seleccione...")
        Dim itemDefault As New Telerik.Web.UI.RadComboBoxItem
        With itemDefault
            .Text = TextoItem
            .Value = "9999"
            .ToolTip = TextoItem
            .Selected = True
        End With
        combo.Items.Insert(0, itemDefault)
    End Sub
    Protected Function numerarOpciones(ByVal tablaANumerar As Data.DataTable) As Data.DataTable
        Dim i As Integer = 0
        Dim fila As Data.DataRow
        For Each fila In tablaANumerar.Rows
            i += 1
            fila.Item(1) = i & "-" & fila.Item(1).Trim
        Next
        Return tablaANumerar
    End Function
    Function getUPZ(ByVal pIdLocalidad As Integer) As DataTable

        Dim dt As New DataTable
        Dim prmtIdupz As New CmdParametro("@IdTblLocalidad", pIdLocalidad, Data.SqlDbType.Int, False)
        Dim coleccionParametros As New Collection
        coleccionParametros.Add(prmtIdupz)
        dt = clsBitacora.GetSelect("SpComunitariaUpzPorLocalidad", coleccionParametros, Session, 96, False).Tables(0)
        Return dt
    End Function
    Private Function TraerFechaServidor() As Date
        Dim Datos As New DataSet
        Dim objparametros As New Collection
        Dim Fecha As Date = clsBitacora.GetSelect("app.spGetFechaServidor", objparametros, Session, 281, False).Tables(0).Rows(0).Item(0)
        Return Fecha
    End Function
    'Private Sub CargarOrientacionTem(Optional ByVal Id_Orientacion As Integer = 0)

    '    Dim prmtId_Orientacion As New CmdParametro("@Id_Orientacion", Id_Orientacion, Data.SqlDbType.Int, False)
    '    Dim coleccionParametros As New Collection
    '    If Id_Orientacion > 0 Then
    '        coleccionParametros.Add(Id_Orientacion)
    '    End If

    '    Dim dt As DataTable = clsBitacora.GetSelect("app.spgetOrientacionTem", coleccionParametros, Session, 422, False).Tables(0)

    '    dt = numerarOpciones(dt)

    '    Me.cboOrientacionTemat.DataValueField = "Id_Orientacion"
    '    Me.cboOrientacionTemat.DataTextField = "NombreOrientacion"
    '    Me.cboOrientacionTemat.DataSource = dt
    '    Me.cboOrientacionTemat.DataBind()
    '    Me.cboOrientacionTemat.Items.Insert(0, "Seleccione...")
    'End Sub
    Private Sub CargarPuntoAtencion(Optional ByVal Id_PuntoAten As Integer = 0)

        Dim prmtId_PuntoAten As New CmdParametro("@Id_PuntoAten", Id_PuntoAten, Data.SqlDbType.Int, False)
        Dim coleccionParametros As New Collection
        If Id_PuntoAten > 0 Then
            coleccionParametros.Add(Id_PuntoAten)
        End If

        Dim dt As DataTable = clsBitacora.GetSelect("app.spgetPuntoAtenViolencia", coleccionParametros, Session, 422, False).Tables(0)

        dt = numerarOpciones(dt)

        Me.cboPuntoAten.DataValueField = "Id_PuntoAten"
        Me.cboPuntoAten.DataTextField = "NombrePunto"
        Me.cboPuntoAten.DataSource = dt
        Me.cboPuntoAten.DataBind()
        Me.cboPuntoAten.Items.Insert(0, "Seleccione...")
    End Sub
    Private Sub CargarAseguradoras(Optional ByVal Id_Aseguradora As Integer = 0)

        Dim prmtId_Aseguradora As New CmdParametro("@Id_Aseguradora", Id_Aseguradora, Data.SqlDbType.Int, False)
        Dim coleccionParametros As New Collection
        If Id_Aseguradora > 0 Then
            coleccionParametros.Add(Id_Aseguradora)
        End If

        Dim dt As DataTable = clsBitacora.GetSelect("app.spgetAseguradorasViolencia", coleccionParametros, Session, 422, False).Tables(0)

        dt = numerarOpciones(dt)

        Me.cboEAPB.DataValueField = "Id_Aseguradora"
        Me.cboEAPB.DataTextField = "NombreAseguradora"
        Me.cboEAPB.DataSource = dt
        Me.cboEAPB.DataBind()
        Me.cboEAPB.Items.Insert(0, "Seleccione...")
    End Sub
    Private Sub CargarPuntoVivienda(Optional ByVal Id_PuntoViv As Integer = 0)

        Dim prmtId_PuntoViv As New CmdParametro("@Id_PuntoViv", Id_PuntoViv, Data.SqlDbType.Int, False)
        Dim coleccionParametros As New Collection
        If Id_PuntoViv > 0 Then
            coleccionParametros.Add(Id_PuntoViv)
        End If

        Dim dt As DataTable = clsBitacora.GetSelect("app.spgetPuntoVivienda", coleccionParametros, Session, 422, False).Tables(0)

        dt = numerarOpciones(dt)

        Me.cboProyectoViv.DataValueField = "Id_PuntoViv"
        Me.cboProyectoViv.DataTextField = "NombrePuntoViv"
        Me.cboProyectoViv.DataSource = dt
        Me.cboProyectoViv.DataBind()
        Me.cboProyectoViv.Items.Insert(0, "Seleccione...")
    End Sub
    Private Sub CargarRemitidoPor(Optional ByVal Id_Remitido As Integer = 0)

        Dim prmtId_Remitido As New CmdParametro("@Id_Remitido", Id_Remitido, Data.SqlDbType.Int, False)
        Dim coleccionParametros As New Collection
        If Id_Remitido > 0 Then
            coleccionParametros.Add(Id_Remitido)
        End If

        Dim dt As DataTable = clsBitacora.GetSelect("app.spgetRemitidoPor", coleccionParametros, Session, 422, False).Tables(0)

        dt = numerarOpciones(dt)

        Me.cboRemitidoP.DataValueField = "Id_Remitido"
        Me.cboRemitidoP.DataTextField = "NombreEntidad"
        Me.cboRemitidoP.DataSource = dt
        Me.cboRemitidoP.DataBind()
        Me.cboRemitidoP.Items.Insert(0, "Seleccione...")
    End Sub
    Protected Sub rcbLocalidadPCO_SelectedIndexChanged(sender As Object, e As EventArgs)
        CargarBarriosLocalidad(sender.SelectedValue)
        BindUpz()
    End Sub
    Protected Sub btnCancelar_ServerClick(sender As Object, e As EventArgs)
        Session.Remove("dtEmp")
        Me.RadAjaxManager1.ResponseScripts.Add("cerrar();")
    End Sub

End Class
