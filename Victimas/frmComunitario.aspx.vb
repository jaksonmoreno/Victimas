Imports System.Data
Imports Telerik.Web.UI

Partial Class Victimas_frmComunitario
    Inherits System.Web.UI.Page

    Private oComunitario As New clsComunitario
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
        CargarAseguradoras()
        CargarPuntoAtencion()
        CargarPuntoVivienda()
        CargarRemitidoPor()
        CargarOrientacionTem()

        If IsPostBack Then Exit Sub

    End Sub
    Protected Sub Page_LoadComplete(sender As Object, e As EventArgs) Handles Me.LoadComplete

        If IsPostBack Then Exit Sub

        Dim mode As String = Request.QueryString("opcion")

        Select Case mode
            Case "new"
                Me.Title = "Crear Nuevo Registro Comunitario"
            Case "edit"
                Me.Title = "Editar Comunitario"
                Dim oComunitario As New clsComunitario
                oComunitario.Load(Request.QueryString("Id_Comunitario"))

                Me.cboPuntoAten.SelectedValue = oComunitario.PuntoAtencion
                Me.dtpFechaApert.Value = oComunitario.FechaApert
                Me.cboTipoDoc.Value = oComunitario.TipoDoc
                Me.txtNumDoc.Value = oComunitario.NumDoc
                Me.txtPrimerNombre.Value = oComunitario.PrimerNombre
                Me.txtSegundoNombre.Value = oComunitario.SegundoNombre
                Me.txtPrimerApellido.Value = oComunitario.PrimerApellido
                Me.txtSegundoApellido.Value = oComunitario.SegundoApellido
                Me.txtNombreOrganizacion.Value = oComunitario.NombreOrganizacion
                Me.txtTelefono.Value = oComunitario.Telefono
                Me.cboGenero.Value = oComunitario.Genero
                Me.cboCicloVit.Value = oComunitario.CicloVit
                Me.cboPertEtnica.Value = oComunitario.PertEtnica
                Me.cboSituaCon.Value = oComunitario.SituaCon
                Me.chkAreaRural.Checked = oComunitario.AreaRural
                Me.txtDireccionPCO.Text = oComunitario.DireccionPCO
                Me.rcbLocalidadPCO.SelectedValue = oComunitario.LocalidadPCO
                Me.rcbBarrio.SelectedValue = oComunitario.Barrio
                CargarBarriosLocalidad(oComunitario.LocalidadPCO)
                Me.rcbNombreUpz.SelectedValue = oComunitario.NombreUpz
                BindUpz()
                Me.cboTerrorista.Value = oComunitario.Terrorista
                Me.cboAmenaza.Value = oComunitario.Amenaza
                Me.cboDelitos.Value = oComunitario.Delitos
                Me.cboDesaparicion.Value = oComunitario.Desaparicion
                Me.cboDesplazamiento.Value = oComunitario.Desplazamiento
                Me.cboHomicidio.Value = oComunitario.Homicidio
                Me.cboMasacre.Value = oComunitario.Masacre
                Me.cboMinas.Value = oComunitario.Minas
                Me.cboSecuestro.Value = oComunitario.Secuestro
                Me.cboTortura.Value = oComunitario.Tortura
                Me.cboVinculacion.Value = oComunitario.Vinculacion
                Me.cboAbandono.Value = oComunitario.Abandono
                Me.txtProfesional.Value = oComunitario.Profesional
                Me.cboNivel.Value = oComunitario.Nivel
                Me.cboOrientacionTemat.SelectedValue = oComunitario.OrientacionTemat
                Dim EditAcercamiento = oComunitario.Acercamiento
                If EditAcercamiento = "01/01/1900" Then
                    Me.dtpAcercamiento.Value = ""
                Else
                    Me.dtpAcercamiento.Value = EditAcercamiento
                End If
                Dim EditSeguimiento2 = oComunitario.Seguimiento2
                If EditSeguimiento2 = "01/01/1900" Then
                    Me.dtpSeguimiento2.Value = ""
                Else
                    Me.dtpSeguimiento2.Value = EditSeguimiento2
                End If
                Dim EditSeguimiento3 = oComunitario.Seguimiento3
                If EditSeguimiento3 = "01/01/1900" Then
                    Me.dtpSeguimiento3.Value = ""
                Else
                    Me.dtpSeguimiento3.Value = EditSeguimiento3
                End If
                Dim EditSeguimiento4 = oComunitario.Seguimiento4
                If EditSeguimiento4 = "01/01/1900" Then
                    Me.dtpSeguimiento4.Value = ""
                Else
                    Me.dtpSeguimiento4.Value = EditSeguimiento4
                End If
                Dim EditSeguimiento5 = oComunitario.Seguimiento5
                If EditSeguimiento5 = "01/01/1900" Then
                    Me.dtpSeguimiento5.Value = ""
                Else
                    Me.dtpSeguimiento5.Value = EditSeguimiento5
                End If
                Dim EditSeguimiento6 = oComunitario.Seguimiento6
                If EditSeguimiento6 = "01/01/1900" Then
                    Me.dtpSeguimiento6.Value = ""
                Else
                    Me.dtpSeguimiento6.Value = EditSeguimiento6
                End If
                Dim EditSeguimiento7 = oComunitario.Seguimiento7
                If EditSeguimiento7 = "01/01/1900" Then
                    Me.dtpSeguimiento7.Value = ""
                Else
                    Me.dtpSeguimiento7.Value = EditSeguimiento7
                End If
                Dim EditSeguimiento8 = oComunitario.Seguimiento8
                If EditSeguimiento8 = "01/01/1900" Then
                    Me.dtpSeguimiento8.Value = ""
                Else
                    Me.dtpSeguimiento8.Value = EditSeguimiento8
                End If
                Dim EditCierre = oComunitario.Cierre
                If EditCierre = "01/01/1900" Then
                    Me.dtpCierre.Value = ""
                Else
                    Me.dtpCierre.Value = EditCierre
                End If
                Dim EditSF_Seguimiento1 = oComunitario.SF_Seguimiento1
                If EditSF_Seguimiento1 = "01/01/1900" Then
                    Me.dtpSF_Seguimiento1.Value = ""
                Else
                    Me.dtpSF_Seguimiento1.Value = EditSF_Seguimiento1
                End If
                Dim EditSF_Seguimiento2 = oComunitario.SF_Seguimiento2
                If EditSF_Seguimiento2 = "01/01/1900" Then
                    Me.dtpSF_Seguimiento2.Value = ""
                Else
                    Me.dtpSF_Seguimiento2.Value = EditSF_Seguimiento2
                End If
                Dim EditSF_Seguimiento3 = oComunitario.SF_Seguimiento3
                If EditSF_Seguimiento3 = "01/01/1900" Then
                    Me.dtpSF_Seguimiento3.Value = ""
                Else
                    Me.dtpSF_Seguimiento3.Value = EditSF_Seguimiento3
                End If
                Dim EditSF_Seguimiento4 = oComunitario.SF_Seguimiento4
                If EditSF_Seguimiento4 = "01/01/1900" Then
                    Me.dtpSF_Seguimiento4.Value = ""
                Else
                    Me.dtpSF_Seguimiento4.Value = EditSF_Seguimiento4
                End If
                Dim EditSF_Seguimiento5 = oComunitario.SF_Seguimiento5
                If EditSF_Seguimiento5 = "01/01/1900" Then
                    Me.dtpSF_Seguimiento5.Value = ""
                Else
                    Me.dtpSF_Seguimiento5.Value = EditSF_Seguimiento5
                End If
                Dim EditGestion1 = oComunitario.Gestion1
                If EditGestion1 = "01/01/1900" Then
                    Me.dtpGestion1.Value = ""
                Else
                    Me.dtpGestion1.Value = EditGestion1
                End If
                Dim EditGestion2 = oComunitario.Gestion2
                If EditGestion2 = "01/01/1900" Then
                    Me.dtpGestion2.Value = ""
                Else
                    Me.dtpGestion2.Value = EditGestion2
                End If
                Dim EditGestion3 = oComunitario.Gestion3
                If EditGestion3 = "01/01/1900" Then
                    Me.dtpGestion3.Value = ""
                Else
                    Me.dtpGestion3.Value = EditGestion3
                End If
                Dim EditGestion4 = oComunitario.Gestion4
                If EditGestion4 = "01/01/1900" Then
                    Me.dtpGestion4.Value = ""
                Else
                    Me.dtpGestion4.Value = EditGestion4
                End If
                Dim EditGestion5 = oComunitario.Gestion5
                If EditGestion5 = "01/01/1900" Then
                    Me.dtpGestion5.Value = ""
                Else
                    Me.dtpGestion5.Value = EditGestion5
                End If
                Dim EditGestion6 = oComunitario.Gestion6
                If EditGestion6 = "01/01/1900" Then
                    Me.dtpGestion6.Value = ""
                Else
                    Me.dtpGestion6.Value = EditGestion6
                End If
                Dim EditGestion7 = oComunitario.Gestion7
                If EditGestion7 = "01/01/1900" Then
                    Me.dtpGestion7.Value = ""
                Else
                    Me.dtpGestion7.Value = EditGestion7
                End If
                Dim EditGestion8 = oComunitario.Gestion8
                If EditGestion8 = "01/01/1900" Then
                    Me.dtpGestion8.Value = ""
                Else
                    Me.dtpGestion8.Value = EditGestion8
                End If
                Dim EditGestion9 = oComunitario.Gestion9
                If EditGestion9 = "01/01/1900" Then
                    Me.dtpGestion9.Value = ""
                Else
                    Me.dtpGestion9.Value = EditGestion9
                End If
                Dim EditGestion10 = oComunitario.Gestion10
                If EditGestion10 = "01/01/1900" Then
                    Me.dtpGestion10.Value = ""
                Else
                    Me.dtpGestion10.Value = EditGestion10
                End If
                Dim EditDerivacion1 = oComunitario.Derivacion1
                If EditDerivacion1 = "01/01/1900" Then
                    Me.dtpDerivacion1.Value = ""
                Else
                    Me.dtpDerivacion1.Value = EditDerivacion1
                End If
                Dim EditDerivacion2 = oComunitario.Derivacion2
                If EditDerivacion2 = "01/01/1900" Then
                    Me.dtpDerivacion2.Value = ""
                Else
                    Me.dtpDerivacion2.Value = EditDerivacion2
                End If
                Dim EditDerivacion3 = oComunitario.Derivacion3
                If EditDerivacion3 = "01/01/1900" Then
                    Me.dtpDerivacion3.Value = ""
                Else
                    Me.dtpDerivacion3.Value = EditDerivacion3
                End If
                Dim EditDerivacion4 = oComunitario.Derivacion4
                If EditDerivacion4 = "01/01/1900" Then
                    Me.dtpDerivacion4.Value = ""
                Else
                    Me.dtpDerivacion4.Value = EditDerivacion4
                End If
                Me.cboNivEfec.Value = oComunitario.NivEfec
                Me.cboMotivoCier.Value = oComunitario.MotivoCier
                Me.cboAseguramiento.Value = oComunitario.Aseguramiento
                Me.cboEAPB.SelectedValue = oComunitario.EAPB
                Me.cboProyectoViv.SelectedValue = oComunitario.ProyectoViv
                Me.cboRemitidoP.SelectedValue = oComunitario.RemitidoP
                Me.txtCalificacion.Value = oComunitario.Calificacion
                Me.txtIRH.Value = oComunitario.IRH
                Me.txtObservaciones.Value = oComunitario.Observaciones
                Me.cboAplicativo.Value = oComunitario.Aplicativo
                Me.cboEscaner.Value = oComunitario.Escaner

            Case "view"
                Me.Title = "ProcesarVisualizar"

                Dim oComunitario As New clsComunitario()
                oComunitario.Load(Request.QueryString("Id_Comunitario"))

                Me.cboPuntoAten.SelectedValue = oComunitario.PuntoAtencion
                Me.dtpFechaApert.Value = oComunitario.FechaApert
                Me.cboTipoDoc.Value = oComunitario.TipoDoc
                Me.txtNumDoc.Value = oComunitario.NumDoc
                Me.txtPrimerNombre.Value = oComunitario.PrimerNombre
                Me.txtSegundoNombre.Value = oComunitario.SegundoNombre
                Me.txtPrimerApellido.Value = oComunitario.PrimerApellido
                Me.txtSegundoApellido.Value = oComunitario.SegundoApellido
                Me.txtNombreOrganizacion.Value = oComunitario.NombreOrganizacion
                Me.txtTelefono.Value = oComunitario.Telefono
                Me.cboGenero.Value = oComunitario.Genero
                Me.cboCicloVit.Value = oComunitario.CicloVit
                Me.cboPertEtnica.Value = oComunitario.PertEtnica
                Me.cboSituaCon.Value = oComunitario.SituaCon
                Me.chkAreaRural.Checked = oComunitario.AreaRural
                Me.txtDireccionPCO.Text = oComunitario.DireccionPCO
                Me.rcbLocalidadPCO.SelectedValue = oComunitario.LocalidadPCO
                Me.rcbBarrio.SelectedValue = oComunitario.Barrio
                CargarBarriosLocalidad(oComunitario.LocalidadPCO)
                Me.rcbNombreUpz.SelectedValue = oComunitario.NombreUpz
                BindUpz()
                Me.cboTerrorista.Value = oComunitario.Terrorista
                Me.cboAmenaza.Value = oComunitario.Amenaza
                Me.cboDelitos.Value = oComunitario.Delitos
                Me.cboDesaparicion.Value = oComunitario.Desaparicion
                Me.cboDesplazamiento.Value = oComunitario.Desplazamiento
                Me.cboHomicidio.Value = oComunitario.Homicidio
                Me.cboMasacre.Value = oComunitario.Masacre
                Me.cboMinas.Value = oComunitario.Minas
                Me.cboSecuestro.Value = oComunitario.Secuestro
                Me.cboTortura.Value = oComunitario.Tortura
                Me.cboVinculacion.Value = oComunitario.Vinculacion
                Me.cboAbandono.Value = oComunitario.Abandono
                Me.txtProfesional.Value = oComunitario.Profesional
                Me.cboNivel.Value = oComunitario.Nivel
                Me.cboOrientacionTemat.SelectedValue = oComunitario.OrientacionTemat
                Dim ViewAcercamiento = oComunitario.Acercamiento
                If ViewAcercamiento = "01/01/1900" Then
                    Me.dtpAcercamiento.Value = ""
                Else
                    Me.dtpAcercamiento.Value = ViewAcercamiento
                End If
                Dim ViewSeguimiento2 = oComunitario.Seguimiento2
                If ViewSeguimiento2 = "01/01/1900" Then
                    Me.dtpSeguimiento2.Value = ""
                Else
                    Me.dtpSeguimiento2.Value = ViewSeguimiento2
                End If
                Dim ViewSeguimiento3 = oComunitario.Seguimiento3
                If ViewSeguimiento3 = "01/01/1900" Then
                    Me.dtpSeguimiento3.Value = ""
                Else
                    Me.dtpSeguimiento3.Value = ViewSeguimiento3
                End If
                Dim ViewSeguimiento4 = oComunitario.Seguimiento4
                If ViewSeguimiento4 = "01/01/1900" Then
                    Me.dtpSeguimiento4.Value = ""
                Else
                    Me.dtpSeguimiento4.Value = ViewSeguimiento4
                End If
                Dim ViewSeguimiento5 = oComunitario.Seguimiento5
                If ViewSeguimiento5 = "01/01/1900" Then
                    Me.dtpSeguimiento5.Value = ""
                Else
                    Me.dtpSeguimiento5.Value = ViewSeguimiento5
                End If
                Dim ViewSeguimiento6 = oComunitario.Seguimiento6
                If ViewSeguimiento6 = "01/01/1900" Then
                    Me.dtpSeguimiento6.Value = ""
                Else
                    Me.dtpSeguimiento6.Value = ViewSeguimiento6
                End If
                Dim ViewSeguimiento7 = oComunitario.Seguimiento7
                If ViewSeguimiento7 = "01/01/1900" Then
                    Me.dtpSeguimiento7.Value = ""
                Else
                    Me.dtpSeguimiento7.Value = ViewSeguimiento7
                End If
                Dim ViewSeguimiento8 = oComunitario.Seguimiento8
                If ViewSeguimiento8 = "01/01/1900" Then
                    Me.dtpSeguimiento8.Value = ""
                Else
                    Me.dtpSeguimiento8.Value = ViewSeguimiento8
                End If
                Dim ViewCierre = oComunitario.Cierre
                If ViewCierre = "01/01/1900" Then
                    Me.dtpCierre.Value = ""
                Else
                    Me.dtpCierre.Value = ViewCierre
                End If
                Dim ViewSF_Seguimiento1 = oComunitario.SF_Seguimiento1
                If ViewSF_Seguimiento1 = "01/01/1900" Then
                    Me.dtpSF_Seguimiento1.Value = ""
                Else
                    Me.dtpSF_Seguimiento1.Value = ViewSF_Seguimiento1
                End If
                Dim ViewSF_Seguimiento2 = oComunitario.SF_Seguimiento2
                If ViewSF_Seguimiento2 = "01/01/1900" Then
                    Me.dtpSF_Seguimiento2.Value = ""
                Else
                    Me.dtpSF_Seguimiento2.Value = ViewSF_Seguimiento2
                End If
                Dim ViewSF_Seguimiento3 = oComunitario.SF_Seguimiento3
                If ViewSF_Seguimiento3 = "01/01/1900" Then
                    Me.dtpSF_Seguimiento3.Value = ""
                Else
                    Me.dtpSF_Seguimiento3.Value = ViewSF_Seguimiento3
                End If
                Dim ViewSF_Seguimiento4 = oComunitario.SF_Seguimiento4
                If ViewSF_Seguimiento4 = "01/01/1900" Then
                    Me.dtpSF_Seguimiento4.Value = ""
                Else
                    Me.dtpSF_Seguimiento4.Value = ViewSF_Seguimiento4
                End If
                Dim ViewSF_Seguimiento5 = oComunitario.SF_Seguimiento5
                If ViewSF_Seguimiento5 = "01/01/1900" Then
                    Me.dtpSF_Seguimiento5.Value = ""
                Else
                    Me.dtpSF_Seguimiento5.Value = ViewSF_Seguimiento5
                End If
                Dim ViewGestion1 = oComunitario.Gestion1
                If ViewGestion1 = "01/01/1900" Then
                    Me.dtpGestion1.Value = ""
                Else
                    Me.dtpGestion1.Value = ViewGestion1
                End If
                Dim ViewGestion2 = oComunitario.Gestion2
                If ViewGestion2 = "01/01/1900" Then
                    Me.dtpGestion2.Value = ""
                Else
                    Me.dtpGestion2.Value = ViewGestion2
                End If
                Dim ViewGestion3 = oComunitario.Gestion3
                If ViewGestion3 = "01/01/1900" Then
                    Me.dtpGestion3.Value = ""
                Else
                    Me.dtpGestion3.Value = ViewGestion3
                End If
                Dim ViewGestion4 = oComunitario.Gestion4
                If ViewGestion4 = "01/01/1900" Then
                    Me.dtpGestion4.Value = ""
                Else
                    Me.dtpGestion4.Value = ViewGestion4
                End If
                Dim ViewGestion5 = oComunitario.Gestion5
                If ViewGestion5 = "01/01/1900" Then
                    Me.dtpGestion5.Value = ""
                Else
                    Me.dtpGestion5.Value = ViewGestion5
                End If
                Dim ViewGestion6 = oComunitario.Gestion6
                If ViewGestion6 = "01/01/1900" Then
                    Me.dtpGestion6.Value = ""
                Else
                    Me.dtpGestion6.Value = ViewGestion6
                End If
                Dim ViewGestion7 = oComunitario.Gestion7
                If ViewGestion7 = "01/01/1900" Then
                    Me.dtpGestion7.Value = ""
                Else
                    Me.dtpGestion7.Value = ViewGestion7
                End If
                Dim ViewGestion8 = oComunitario.Gestion8
                If ViewGestion8 = "01/01/1900" Then
                    Me.dtpGestion8.Value = ""
                Else
                    Me.dtpGestion8.Value = ViewGestion8
                End If
                Dim ViewGestion9 = oComunitario.Gestion9
                If ViewGestion9 = "01/01/1900" Then
                    Me.dtpGestion9.Value = ""
                Else
                    Me.dtpGestion9.Value = ViewGestion9
                End If
                Dim ViewGestion10 = oComunitario.Gestion10
                If ViewGestion10 = "01/01/1900" Then
                    Me.dtpGestion10.Value = ""
                Else
                    Me.dtpGestion10.Value = ViewGestion10
                End If
                Dim ViewDerivacion1 = oComunitario.Derivacion1
                If ViewDerivacion1 = "01/01/1900" Then
                    Me.dtpDerivacion1.Value = ""
                Else
                    Me.dtpDerivacion1.Value = ViewDerivacion1
                End If
                Dim ViewDerivacion2 = oComunitario.Derivacion2
                If ViewDerivacion2 = "01/01/1900" Then
                    Me.dtpDerivacion2.Value = ""
                Else
                    Me.dtpDerivacion2.Value = ViewDerivacion2
                End If
                Dim ViewDerivacion3 = oComunitario.Derivacion3
                If ViewDerivacion3 = "01/01/1900" Then
                    Me.dtpDerivacion3.Value = ""
                Else
                    Me.dtpDerivacion3.Value = ViewDerivacion3
                End If
                Dim ViewDerivacion4 = oComunitario.Derivacion4
                If ViewDerivacion4 = "01/01/1900" Then
                    Me.dtpDerivacion4.Value = ""
                Else
                    Me.dtpDerivacion4.Value = ViewDerivacion4
                End If
                Me.cboNivEfec.Value = oComunitario.NivEfec
                Me.cboMotivoCier.Value = oComunitario.MotivoCier
                Me.cboAseguramiento.Value = oComunitario.Aseguramiento
                Me.cboEAPB.SelectedValue = oComunitario.EAPB
                Me.cboProyectoViv.SelectedValue = oComunitario.ProyectoViv
                Me.cboRemitidoP.SelectedValue = oComunitario.RemitidoP
                Me.txtCalificacion.Value = oComunitario.Calificacion
                Me.txtIRH.Value = oComunitario.IRH
                Me.txtObservaciones.Value = oComunitario.Observaciones
                Me.cboAplicativo.Value = oComunitario.Aplicativo
                Me.cboEscaner.Value = oComunitario.Escaner
                ProcesarVisualizar()

        End Select

        Dim FechaHoy As Date = TraerFechaServidor()             '<JPaez 15-09-2010>

    End Sub
    Protected Sub btnInsertar_ServerClick(sender As Object, e As EventArgs) Handles btnInsertar.ServerClick

        Dim mode As String = Request.QueryString("opcion")
        Dim sCom As Boolean = False
        If Validar() Then
            Select Case mode
                Case "new"
                    sCom = ProcesarNuevo()
                Case "edit"
                    sCom = Procesareditar()
            End Select
        End If
    End Sub
    Private Function Validar() As Boolean
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

        Dim sCom As Boolean = False
        Dim oComunitario As New clsComunitario
        With oComunitario
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
            .NombreOrganizacion = Me.txtNombreOrganizacion.Value
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
            .Minas = cboMinas.Value
            .Secuestro = cboSecuestro.Value
            .Tortura = cboTortura.Value
            .Vinculacion = cboVinculacion.Value
            .Abandono = cboAbandono.Value
            .Profesional = txtProfesional.Value
            .Nivel = cboNivel.Value
            If cboOrientacionTemat.SelectedValue <> "Seleccione..." Then
                .OrientacionTemat = cboOrientacionTemat.SelectedValue
            End If
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
            Dim SF_Seguimiento1 = Me.dtpSF_Seguimiento1.Value
            If SF_Seguimiento1 <> Nothing Then
                .SF_Seguimiento1 = Me.dtpSF_Seguimiento1.Value
            Else
                .SF_Seguimiento1 = "01/01/1900"
            End If
            Dim SF_Seguimiento2 = Me.dtpSF_Seguimiento2.Value
            If SF_Seguimiento2 <> Nothing Then
                .SF_Seguimiento2 = Me.dtpSF_Seguimiento2.Value
            Else
                .SF_Seguimiento2 = "01/01/1900"
            End If
            Dim SF_Seguimiento3 = Me.dtpSF_Seguimiento3.Value
            If SF_Seguimiento3 <> Nothing Then
                .SF_Seguimiento3 = Me.dtpSF_Seguimiento3.Value
            Else
                .SF_Seguimiento3 = "01/01/1900"
            End If
            Dim SF_Seguimiento4 = Me.dtpSF_Seguimiento4.Value
            If SF_Seguimiento4 <> Nothing Then
                .SF_Seguimiento4 = Me.dtpSF_Seguimiento2.Value
            Else
                .SF_Seguimiento4 = "01/01/1900"
            End If
            Dim SF_Seguimiento5 = Me.dtpSF_Seguimiento5.Value
            If SF_Seguimiento5 <> Nothing Then
                .SF_Seguimiento5 = Me.dtpSF_Seguimiento5.Value
            Else
                .SF_Seguimiento5 = "01/01/1900"
            End If
            Dim Gestion1 = Me.dtpGestion1.Value
            If Gestion1 <> Nothing Then
                .Gestion1 = Me.dtpGestion1.Value
            Else
                .Gestion1 = "01/01/1900"
            End If
            Dim Gestion2 = Me.dtpGestion2.Value
            If Gestion2 <> Nothing Then
                .Gestion2 = Me.dtpGestion2.Value
            Else
                .Gestion2 = "01/01/1900"
            End If
            Dim Gestion3 = Me.dtpGestion3.Value
            If Gestion3 <> Nothing Then
                .Gestion3 = Me.dtpGestion3.Value
            Else
                .Gestion3 = "01/01/1900"
            End If
            Dim Gestion4 = Me.dtpGestion4.Value
            If Gestion4 <> Nothing Then
                .Gestion4 = Me.dtpGestion4.Value
            Else
                .Gestion4 = "01/01/1900"
            End If
            Dim Gestion5 = Me.dtpGestion5.Value
            If Gestion5 <> Nothing Then
                .Gestion5 = Me.dtpGestion5.Value
            Else
                .Gestion5 = "01/01/1900"
            End If
            Dim Gestion6 = Me.dtpGestion6.Value
            If Gestion6 <> Nothing Then
                .Gestion6 = Me.dtpGestion6.Value
            Else
                .Gestion6 = "01/01/1900"
            End If
            Dim Gestion7 = Me.dtpGestion7.Value
            If Gestion7 <> Nothing Then
                .Gestion7 = Me.dtpGestion7.Value
            Else
                .Gestion7 = "01/01/1900"
            End If
            Dim Gestion8 = Me.dtpGestion8.Value
            If Gestion8 <> Nothing Then
                .Gestion8 = Me.dtpGestion8.Value
            Else
                .Gestion8 = "01/01/1900"
            End If
            Dim Gestion9 = Me.dtpGestion9.Value
            If Gestion9 <> Nothing Then
                .Gestion9 = Me.dtpGestion9.Value
            Else
                .Gestion9 = "01/01/1900"
            End If
            Dim Gestion10 = Me.dtpGestion10.Value
            If Gestion10 <> Nothing Then
                .Gestion10 = Me.dtpGestion10.Value
            Else
                .Gestion10 = "01/01/1900"
            End If
            Dim Derivacion1 = Me.dtpDerivacion1.Value
            If Derivacion1 <> Nothing Then
                .Derivacion1 = Me.dtpDerivacion1.Value
            Else
                .Derivacion1 = "01/01/1900"
            End If
            Dim Derivacion2 = Me.dtpDerivacion2.Value
            If Derivacion2 <> Nothing Then
                .Derivacion2 = Me.dtpDerivacion2.Value
            Else
                .Derivacion2 = "01/01/1900"
            End If
            Dim Derivacion3 = Me.dtpDerivacion3.Value
            If Derivacion3 <> Nothing Then
                .Derivacion3 = Me.dtpDerivacion3.Value
            Else
                .Derivacion3 = "01/01/1900"
            End If
            Dim Derivacion4 = Me.dtpDerivacion4.Value
            If Derivacion4 <> Nothing Then
                .Derivacion4 = Me.dtpDerivacion4.Value
            Else
                .Derivacion4 = "01/01/1900"
            End If
            .NivEfec = Me.cboNivEfec.Value
            .MotivoCier = Me.cboMotivoCier.Value
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
            If txtCalificacion.Value <> "" Then
                .Calificacion = txtCalificacion.Value
            Else
                txtCalificacion.Value = ""
            End If
            If txtIRH.Value <> "" Then
                .IRH = txtIRH.Value
            Else
                txtIRH.Value = ""
            End If
            .Observaciones = Me.txtObservaciones.Value
            .Aplicativo = Me.cboAplicativo.Value
            .Escaner = Me.cboEscaner.Value

        End With
        Try
            Dim sComu As Integer = oComunitario.Insertar()
            If sComu <= 0 Then
                sCom = False
                Me.RadAjaxManager1.Alert("Error: ")
            Else
                sCom = True
                RadAjaxManager1.ResponseScripts.Add("CloseAndRebindInsert(1);")
            End If
        Catch ex As Exception
            Me.RadAjaxManager1.Alert("Error: " & ex.Message)
            sCom = False
        End Try

        Return sCom

    End Function
    Private Function Procesareditar() As Boolean

        Dim sCom As Boolean = False
        Dim oComunitario As New clsComunitario
        oComunitario.Load(Request.QueryString("Id_Comunitario"))
        With oComunitario
            .Id_Comunitario = Request.QueryString("Id_Comunitario")
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
            .NombreOrganizacion = Me.txtNombreOrganizacion.Value
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
            .Minas = cboMinas.Value
            .Secuestro = cboSecuestro.Value
            .Tortura = cboTortura.Value
            .Vinculacion = cboVinculacion.Value
            .Abandono = cboAbandono.Value
            .Profesional = txtProfesional.Value
            .Nivel = cboNivel.Value
            If cboOrientacionTemat.SelectedValue <> "Seleccione..." Then
                .OrientacionTemat = cboOrientacionTemat.SelectedValue
            End If
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
            Dim SF_Seguimiento1 = Me.dtpSF_Seguimiento1.Value
            If SF_Seguimiento1 <> Nothing Then
                .SF_Seguimiento1 = Me.dtpSF_Seguimiento1.Value
            Else
                .SF_Seguimiento1 = "01/01/1900"
            End If
            Dim SF_Seguimiento2 = Me.dtpSF_Seguimiento2.Value
            If SF_Seguimiento2 <> Nothing Then
                .SF_Seguimiento2 = Me.dtpSF_Seguimiento2.Value
            Else
                .SF_Seguimiento2 = "01/01/1900"
            End If
            Dim SF_Seguimiento3 = Me.dtpSF_Seguimiento3.Value
            If SF_Seguimiento3 <> Nothing Then
                .SF_Seguimiento3 = Me.dtpSF_Seguimiento3.Value
            Else
                .SF_Seguimiento3 = "01/01/1900"
            End If
            Dim SF_Seguimiento4 = Me.dtpSF_Seguimiento4.Value
            If SF_Seguimiento4 <> Nothing Then
                .SF_Seguimiento4 = Me.dtpSF_Seguimiento2.Value
            Else
                .SF_Seguimiento4 = "01/01/1900"
            End If
            Dim SF_Seguimiento5 = Me.dtpSF_Seguimiento5.Value
            If SF_Seguimiento5 <> Nothing Then
                .SF_Seguimiento5 = Me.dtpSF_Seguimiento5.Value
            Else
                .SF_Seguimiento5 = "01/01/1900"
            End If
            Dim Gestion1 = Me.dtpGestion1.Value
            If Gestion1 <> Nothing Then
                .Gestion1 = Me.dtpGestion1.Value
            Else
                .Gestion1 = "01/01/1900"
            End If
            Dim Gestion2 = Me.dtpGestion2.Value
            If Gestion2 <> Nothing Then
                .Gestion2 = Me.dtpGestion2.Value
            Else
                .Gestion2 = "01/01/1900"
            End If
            Dim Gestion3 = Me.dtpGestion3.Value
            If Gestion3 <> Nothing Then
                .Gestion3 = Me.dtpGestion3.Value
            Else
                .Gestion3 = "01/01/1900"
            End If
            Dim Gestion4 = Me.dtpGestion4.Value
            If Gestion4 <> Nothing Then
                .Gestion4 = Me.dtpGestion4.Value
            Else
                .Gestion4 = "01/01/1900"
            End If
            Dim Gestion5 = Me.dtpGestion5.Value
            If Gestion5 <> Nothing Then
                .Gestion5 = Me.dtpGestion5.Value
            Else
                .Gestion5 = "01/01/1900"
            End If
            Dim Gestion6 = Me.dtpGestion6.Value
            If Gestion6 <> Nothing Then
                .Gestion6 = Me.dtpGestion6.Value
            Else
                .Gestion6 = "01/01/1900"
            End If
            Dim Gestion7 = Me.dtpGestion7.Value
            If Gestion7 <> Nothing Then
                .Gestion7 = Me.dtpGestion7.Value
            Else
                .Gestion7 = "01/01/1900"
            End If
            Dim Gestion8 = Me.dtpGestion8.Value
            If Gestion8 <> Nothing Then
                .Gestion8 = Me.dtpGestion8.Value
            Else
                .Gestion8 = "01/01/1900"
            End If
            Dim Gestion9 = Me.dtpGestion9.Value
            If Gestion9 <> Nothing Then
                .Gestion9 = Me.dtpGestion9.Value
            Else
                .Gestion9 = "01/01/1900"
            End If
            Dim Gestion10 = Me.dtpGestion10.Value
            If Gestion10 <> Nothing Then
                .Gestion10 = Me.dtpGestion10.Value
            Else
                .Gestion10 = "01/01/1900"
            End If
            Dim Derivacion1 = Me.dtpDerivacion1.Value
            If Derivacion1 <> Nothing Then
                .Derivacion1 = Me.dtpDerivacion1.Value
            Else
                .Derivacion1 = "01/01/1900"
            End If
            Dim Derivacion2 = Me.dtpDerivacion2.Value
            If Derivacion2 <> Nothing Then
                .Derivacion2 = Me.dtpDerivacion2.Value
            Else
                .Derivacion2 = "01/01/1900"
            End If
            Dim Derivacion3 = Me.dtpDerivacion3.Value
            If Derivacion3 <> Nothing Then
                .Derivacion3 = Me.dtpDerivacion3.Value
            Else
                .Derivacion3 = "01/01/1900"
            End If
            Dim Derivacion4 = Me.dtpDerivacion4.Value
            If Derivacion4 <> Nothing Then
                .Derivacion4 = Me.dtpDerivacion4.Value
            Else
                .Derivacion4 = "01/01/1900"
            End If
            .NivEfec = Me.cboNivEfec.Value
            .MotivoCier = Me.cboMotivoCier.Value
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
            If txtCalificacion.Value <> "" Then
                .Calificacion = txtCalificacion.Value
            Else
                txtCalificacion.Value = ""
            End If
            If txtIRH.Value <> "" Then
                .IRH = txtIRH.Value
            Else
                txtIRH.Value = ""
            End If
            .Observaciones = Me.txtObservaciones.Value
            .Aplicativo = Me.cboAplicativo.Value
            .Escaner = Me.cboEscaner.Value

        End With
        Try
            Dim sComu As Integer = oComunitario.Actualizar
            If sComu <> 0 Then
                Me.RadAjaxManager1.Alert("Error: ")
                sCom = False
            Else
                sCom = True
                RadAjaxManager1.ResponseScripts.Add("CloseAndRebindInsert(1);")
            End If
        Catch ex As Exception
            Me.RadAjaxManager1.Alert("Error: " & ex.Message)
            sCom = False
        End Try

        Return sCom

    End Function

    '''' <summary>
    '''' InhabilitarControles
    '''' </summary>
    '''' <autor>Julio Paez</autor>
    '''' <autor> En Violencias Comunitarias usado por Jakson Moreno R 12 -05 -2021</autor>
    '''' <remarks>Procedimiento que inhabilita todos los controles para no permitir la modificación de datos
    '''' usuarios no autorizados</remarks>
    '''' 'Jmoreno 18/12/2020
    Private Sub ProcesarVisualizar()

        Try

            Me.cboPuntoAten.Enabled = False
            Me.dtpFechaApert.Disabled = True
            Me.cboTipoDoc.Disabled = True
            Me.txtNumDoc.Disabled = True
            Me.txtPrimerNombre.Disabled = True
            Me.txtSegundoNombre.Disabled = True
            Me.txtPrimerApellido.Disabled = True
            Me.txtSegundoApellido.Disabled = True
            Me.txtNombreOrganizacion.Disabled = True
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
            Me.cboNivel.Disabled = True
            Me.cboOrientacionTemat.Enabled = False
            Me.dtpAcercamiento.Disabled = True
            Me.dtpSeguimiento2.Disabled = True
            Me.dtpSeguimiento3.Disabled = True
            Me.dtpSeguimiento4.Disabled = True
            Me.dtpSeguimiento5.Disabled = True
            Me.dtpSeguimiento6.Disabled = True
            Me.dtpSeguimiento7.Disabled = True
            Me.dtpSeguimiento8.Disabled = True
            Me.dtpCierre.Disabled = True
            Me.dtpSF_Seguimiento1.Disabled = True
            Me.dtpSF_Seguimiento2.Disabled = True
            Me.dtpSF_Seguimiento3.Disabled = True
            Me.dtpSF_Seguimiento4.Disabled = True
            Me.dtpSF_Seguimiento5.Disabled = True
            Me.dtpGestion1.Disabled = True
            Me.dtpGestion2.Disabled = True
            Me.dtpGestion3.Disabled = True
            Me.dtpGestion4.Disabled = True
            Me.dtpGestion5.Disabled = True
            Me.dtpGestion6.Disabled = True
            Me.dtpGestion7.Disabled = True
            Me.dtpGestion8.Disabled = True
            Me.dtpGestion9.Disabled = True
            Me.dtpGestion10.Disabled = True
            Me.dtpDerivacion1.Disabled = True
            Me.dtpDerivacion2.Disabled = True
            Me.dtpDerivacion3.Disabled = True
            Me.dtpDerivacion4.Disabled = True
            Me.cboNivEfec.Disabled = True
            Me.cboMotivoCier.Disabled = True
            Me.cboAseguramiento.Disabled = True
            Me.cboEAPB.Enabled = False
            Me.cboProyectoViv.Enabled = False
            Me.cboRemitidoP.Enabled = False
            Me.txtCalificacion.Disabled = True
            Me.txtIRH.Disabled = True
            Me.txtObservaciones.Disabled = True
            Me.cboAplicativo.Disabled = True
            Me.cboEscaner.Disabled = True
            Me.btnInsertar.Visible = False
        Catch
        End Try

    End Sub
    Private Function CargarDatos() As DataRow

        Dim Id_Comunitario As Integer = Request.QueryString("Id_Comunitario")
        Dim dr As Data.DataRow = Nothing
        Dim ds As New DataSet
        Dim coleccionParametros As New Collection
        Dim parametro As New CmdParametro("@Id_Comunitario", Id_Comunitario, SqlDbType.Int, True)
        coleccionParametros.Add(parametro)
        ds = clsBitacora.GetSelect("spViolenciaComunitarioById", coleccionParametros, Session, 35, False)
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
    Private Sub CargarOrientacionTem(Optional ByVal Id_Orientacion As Integer = 0)

        Dim prmtId_Orientacion As New CmdParametro("@Id_Orientacion", Id_Orientacion, Data.SqlDbType.Int, False)
        Dim coleccionParametros As New Collection
        If Id_Orientacion > 0 Then
            coleccionParametros.Add(Id_Orientacion)
        End If

        Dim dt As DataTable = clsBitacora.GetSelect("app.spgetOrientacionTemCom", coleccionParametros, Session, 422, False).Tables(0)

        dt = numerarOpciones(dt)

        Me.cboOrientacionTemat.DataValueField = "Id_Orientacion"
        Me.cboOrientacionTemat.DataTextField = "NombreOrientacion"
        Me.cboOrientacionTemat.DataSource = dt
        Me.cboOrientacionTemat.DataBind()
        Me.cboOrientacionTemat.Items.Insert(0, "Seleccione...")
    End Sub
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
