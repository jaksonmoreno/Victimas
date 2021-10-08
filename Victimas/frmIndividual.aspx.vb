Imports System.Data
Imports Telerik.Web.UI

Partial Class Victimas_frmIndividual
    Inherits System.Web.UI.Page

    Private oIndividual As New clsIndividual
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
                Me.Title = "Crear Nuevo Registro Individual"
            Case "edit"
                Me.Title = "Editar Individual"
                Dim oIndividual As New clsIndividual()
                oIndividual.Load(Request.QueryString("Id_Individual"))

                Me.cboPuntoAten.SelectedValue = oIndividual.PuntoAtencion
                Me.dtpFechaApert.Value = oIndividual.FechaApert
                Me.cboTipoDoc.Value = oIndividual.TipoDoc
                Me.txtNumDoc.Value = oIndividual.NumDoc
                Me.txtPrimerNombre.Value = oIndividual.PrimerNombre
                Me.txtSegundoNombre.Value = oIndividual.SegundoNombre
                Me.txtPrimerApellido.Value = oIndividual.PrimerApellido
                Me.txtSegundoApellido.Value = oIndividual.SegundoApellido
                Me.txtTelefono.Value = oIndividual.Telefono
                Me.cboGenero.Value = oIndividual.Genero
                Me.cboCicloVit.Value = oIndividual.CicloVit
                Me.cboPertEtnica.Value = oIndividual.PertEtnica
                Me.chkAreaRural.Checked = oIndividual.AreaRural
                Me.txtDireccionPCO.Text = oIndividual.DireccionPCO
                Me.rcbLocalidadPCO.SelectedValue = oIndividual.LocalidadPCO
                Me.rcbBarrio.SelectedValue = oIndividual.Barrio
                CargarBarriosLocalidad(oIndividual.LocalidadPCO)
                Me.rcbNombreUpz.SelectedValue = oIndividual.NombreUpz
                BindUpz()
                Me.cboTerrorista.Value = oIndividual.Terrorista
                Me.cboAmenaza.Value = oIndividual.Amenaza
                Me.cboDelitos.Value = oIndividual.Delitos
                Me.cboDesaparicion.Value = oIndividual.Desaparicion
                Me.cboDesplazamiento.Value = oIndividual.Desplazamiento
                Me.cboHomicidio.Value = oIndividual.Homicidio
                Me.cboMasacre.Value = oIndividual.Masacre
                Me.cboMinas.Value = oIndividual.Minas
                Me.cboSecuestro.Value = oIndividual.Secuestro
                Me.cboTortura.Value = oIndividual.Tortura
                Me.cboVinculacion.Value = oIndividual.Vinculación
                Me.cboAbandono.Value = oIndividual.Abandono
                Me.txtProfesional.Value = oIndividual.Profesional
                Me.cboNivel.Value = oIndividual.Nivel
                Me.cboOrientacionTemat.SelectedValue = oIndividual.OrientacionTemat
                Dim EditAcercamiento = oIndividual.Acercamiento
                If EditAcercamiento = "01/01/1900" Then
                    Me.dtpAcercamiento.Value = ""
                Else
                    Me.dtpAcercamiento.Value = EditAcercamiento
                End If
                Dim EditSeguimiento2 = oIndividual.Seguimiento2
                If EditSeguimiento2 = "01/01/1900" Then
                    Me.dtpSeguimiento2.Value = ""
                Else
                    Me.dtpSeguimiento2.Value = EditSeguimiento2
                End If
                Dim EditSeguimiento3 = oIndividual.Seguimiento3
                If EditSeguimiento3 = "01/01/1900" Then
                    Me.dtpSeguimiento3.Value = ""
                Else
                    Me.dtpSeguimiento3.Value = EditSeguimiento3
                End If
                Dim EditSeguimiento4 = oIndividual.Seguimiento4
                If EditSeguimiento4 = "01/01/1900" Then
                    Me.dtpSeguimiento4.Value = ""
                Else
                    Me.dtpSeguimiento4.Value = EditSeguimiento4
                End If
                Dim EditSeguimiento5 = oIndividual.Seguimiento5
                If EditSeguimiento5 = "01/01/1900" Then
                    Me.dtpSeguimiento5.Value = ""
                Else
                    Me.dtpSeguimiento5.Value = EditSeguimiento5
                End If
                Dim EditSeguimiento6 = oIndividual.Seguimiento6
                If EditSeguimiento6 = "01/01/1900" Then
                    Me.dtpSeguimiento6.Value = ""
                Else
                    Me.dtpSeguimiento6.Value = EditSeguimiento6
                End If

                Dim EditSeguimiento7 = oIndividual.Seguimiento7
                If EditSeguimiento7 = "01/01/1900" Then
                    Me.dtpSeguimiento7.Value = ""
                Else
                    Me.dtpSeguimiento7.Value = EditSeguimiento7
                End If
                Dim EditSeguimiento8 = oIndividual.Seguimiento8
                If EditSeguimiento8 = "01/01/1900" Then
                    Me.dtpSeguimiento8.Value = ""
                Else
                    Me.dtpSeguimiento8.Value = EditSeguimiento8
                End If
                Dim EditCierre = oIndividual.Cierre
                If EditCierre = "01/01/1900" Then
                    Me.dtpCierre.Value = ""
                Else
                    Me.dtpCierre.Value = EditCierre
                End If
                Dim EditSF_Seguimiento1 = oIndividual.SF_Seguimiento1
                If EditSF_Seguimiento1 = "01/01/1900" Then
                    Me.dtpSF_Seguimiento1.Value = ""
                Else
                    Me.dtpSF_Seguimiento1.Value = EditSF_Seguimiento1
                End If

                Dim EditSF_Seguimiento2 = oIndividual.SF_Seguimiento2
                If EditSF_Seguimiento2 = "01/01/1900" Then
                    Me.dtpSF_Seguimiento2.Value = ""
                Else
                    Me.dtpSF_Seguimiento2.Value = EditSF_Seguimiento2
                End If

                Dim EditSF_Seguimiento3 = oIndividual.SF_Seguimiento3
                If EditSF_Seguimiento3 = "01/01/1900" Then
                    Me.dtpSF_Seguimiento3.Value = ""
                Else
                    Me.dtpSF_Seguimiento3.Value = EditSF_Seguimiento3
                End If

                Dim EditSF_Seguimiento4 = oIndividual.SF_Seguimiento4
                If EditSF_Seguimiento4 = "01/01/1900" Then
                    Me.dtpSF_Seguimiento4.Value = ""
                Else
                    Me.dtpSF_Seguimiento4.Value = EditSF_Seguimiento4
                End If

                Dim EditSF_Seguimiento5 = oIndividual.SF_Seguimiento5
                If EditSF_Seguimiento5 = "01/01/1900" Then
                    Me.dtpSF_Seguimiento5.Value = ""
                Else
                    Me.dtpSF_Seguimiento5.Value = EditSF_Seguimiento5
                End If
                Dim EditGestion1 = oIndividual.Gestion1
                If EditGestion1 = "01/01/1900" Then
                    Me.dtpGestion1.Value = ""
                Else
                    Me.dtpGestion1.Value = EditGestion1
                End If
                Dim EditGestion2 = oIndividual.Gestion2
                If EditGestion2 = "01/01/1900" Then
                    Me.dtpGestion2.Value = ""
                Else
                    Me.dtpGestion2.Value = EditGestion2
                End If
                Dim EditGestion3 = oIndividual.Gestion3
                If EditGestion3 = "01/01/1900" Then
                    Me.dtpGestion3.Value = ""
                Else
                    Me.dtpGestion3.Value = EditGestion3
                End If
                Dim EditGestion4 = oIndividual.Gestion4
                If EditGestion4 = "01/01/1900" Then
                    Me.dtpGestion4.Value = ""
                Else
                    Me.dtpGestion4.Value = EditGestion4
                End If
                Dim EditGestion5 = oIndividual.Gestion5
                If EditGestion5 = "01/01/1900" Then
                    Me.dtpGestion5.Value = ""
                Else
                    Me.dtpGestion5.Value = EditGestion5
                End If
                Dim EditGestion6 = oIndividual.Gestion6
                If EditGestion6 = "01/01/1900" Then
                    Me.dtpGestion6.Value = ""
                Else
                    Me.dtpGestion6.Value = EditGestion6
                End If
                Dim EditGestion7 = oIndividual.Gestion7
                If EditGestion7 = "01/01/1900" Then
                    Me.dtpGestion7.Value = ""
                Else
                    Me.dtpGestion7.Value = EditGestion7
                End If
                Dim EditGestion8 = oIndividual.Gestion8
                If EditGestion8 = "01/01/1900" Then
                    Me.dtpGestion8.Value = ""
                Else
                    Me.dtpGestion8.Value = EditGestion8
                End If
                Dim EditGestion9 = oIndividual.Gestion9
                If EditGestion9 = "01/01/1900" Then
                    Me.dtpGestion9.Value = ""
                Else
                    Me.dtpGestion9.Value = EditGestion9
                End If
                Dim EditGestion10 = oIndividual.Gestion10
                If EditGestion10 = "01/01/1900" Then
                    Me.dtpGestion10.Value = ""
                Else
                    Me.dtpGestion10.Value = EditGestion10
                End If
                Dim EditDerivacion1 = oIndividual.Derivacion1
                If EditDerivacion1 = "01/01/1900" Then
                    Me.dtpDerivacion1.Value = ""
                Else
                    Me.dtpDerivacion1.Value = EditDerivacion1
                End If
                Dim EditDerivacion2 = oIndividual.Derivacion2
                If EditDerivacion2 = "01/01/1900" Then
                    Me.dtpDerivacion2.Value = ""
                Else
                    Me.dtpDerivacion2.Value = EditDerivacion2
                End If
                Dim EditDerivacion3 = oIndividual.Derivacion3
                If EditDerivacion3 = "01/01/1900" Then
                    Me.dtpDerivacion3.Value = ""
                Else
                    Me.dtpDerivacion3.Value = EditDerivacion3
                End If
                Dim EditDerivacion4 = oIndividual.Derivacion4
                If EditDerivacion4 = "01/01/1900" Then
                    Me.dtpDerivacion4.Value = ""
                Else
                    Me.dtpDerivacion4.Value = EditDerivacion4
                End If
                Me.cboNivEfec.Value = oIndividual.NivEfec
                Me.cboMotivoCier.Value = oIndividual.MotivoCier
                Me.cboAseguramiento.Value = oIndividual.Aseguramiento
                Me.cboEAPB.SelectedValue = oIndividual.EAPB
                Me.cboProyectoViv.SelectedValue = oIndividual.ProyectoViv
                Me.cboRemitidoP.SelectedValue = oIndividual.RemitidoP
                Me.txtCalificacion.Value = oIndividual.Calificacion
                Me.txtIRH.Value = oIndividual.IRH
                Me.txtObservaciones.Value = oIndividual.Observaciones
                Me.cboAplicativo.Value = oIndividual.Aplicativo
                Me.cboEscaner.Value = oIndividual.Escaner

            Case "view"
                Me.Title = "ProcesarVisualizar"

                Dim oIndividual As New clsIndividual()
                oIndividual.Load(Request.QueryString("Id_Individual"))

                Me.cboPuntoAten.SelectedValue = oIndividual.PuntoAtencion
                Me.dtpFechaApert.Value = oIndividual.FechaApert
                Me.cboTipoDoc.Value = oIndividual.TipoDoc
                Me.txtNumDoc.Value = oIndividual.NumDoc
                Me.txtPrimerNombre.Value = oIndividual.PrimerNombre
                Me.txtSegundoNombre.Value = oIndividual.SegundoNombre
                Me.txtPrimerApellido.Value = oIndividual.PrimerApellido
                Me.txtSegundoApellido.Value = oIndividual.SegundoApellido
                Me.txtTelefono.Value = oIndividual.Telefono
                Me.cboGenero.Value = oIndividual.Genero
                Me.cboCicloVit.Value = oIndividual.CicloVit
                Me.cboPertEtnica.Value = oIndividual.PertEtnica
                Me.chkAreaRural.Checked = oIndividual.AreaRural
                Me.txtDireccionPCO.Text = oIndividual.DireccionPCO
                Me.rcbLocalidadPCO.SelectedValue = oIndividual.LocalidadPCO
                Me.rcbBarrio.SelectedValue = oIndividual.Barrio
                CargarBarriosLocalidad(oIndividual.LocalidadPCO)
                Me.rcbNombreUpz.SelectedValue = oIndividual.NombreUpz
                BindUpz()
                Me.cboTerrorista.Value = oIndividual.Terrorista
                Me.cboAmenaza.Value = oIndividual.Amenaza
                Me.cboDelitos.Value = oIndividual.Delitos
                Me.cboDesaparicion.Value = oIndividual.Desaparicion
                Me.cboDesplazamiento.Value = oIndividual.Desplazamiento
                Me.cboHomicidio.Value = oIndividual.Homicidio
                Me.cboMasacre.Value = oIndividual.Masacre
                Me.cboMinas.Value = oIndividual.Minas
                Me.cboSecuestro.Value = oIndividual.Secuestro
                Me.cboTortura.Value = oIndividual.Tortura
                Me.cboVinculacion.Value = oIndividual.Vinculación
                Me.cboAbandono.Value = oIndividual.Abandono
                Me.txtProfesional.Value = oIndividual.Profesional
                Me.cboNivel.Value = oIndividual.Nivel
                Me.cboOrientacionTemat.SelectedValue = oIndividual.OrientacionTemat
                Dim ViewAcercamiento = oIndividual.Acercamiento
                If ViewAcercamiento = "01/01/1900" Then
                    Me.dtpAcercamiento.Value = ""
                Else
                    Me.dtpAcercamiento.Value = ViewAcercamiento
                End If
                Dim ViewSeguimiento2 = oIndividual.Seguimiento2
                If ViewSeguimiento2 = "01/01/1900" Then
                    Me.dtpSeguimiento2.Value = ""
                Else
                    Me.dtpSeguimiento2.Value = ViewSeguimiento2
                End If
                Dim ViewSeguimiento3 = oIndividual.Seguimiento3
                If ViewSeguimiento3 = "01/01/1900" Then
                    Me.dtpSeguimiento3.Value = ""
                Else
                    Me.dtpSeguimiento3.Value = ViewSeguimiento3
                End If
                Dim ViewSeguimiento4 = oIndividual.Seguimiento4
                If ViewSeguimiento4 = "01/01/1900" Then
                    Me.dtpSeguimiento4.Value = ""
                Else
                    Me.dtpSeguimiento4.Value = ViewSeguimiento4
                End If
                Dim ViewSeguimiento5 = oIndividual.Seguimiento5
                If ViewSeguimiento5 = "01/01/1900" Then
                    Me.dtpSeguimiento5.Value = ""
                Else
                    Me.dtpSeguimiento5.Value = ViewSeguimiento5
                End If
                Dim ViewSeguimiento6 = oIndividual.Seguimiento6
                If ViewSeguimiento6 = "01/01/1900" Then
                    Me.dtpSeguimiento6.Value = ""
                Else
                    Me.dtpSeguimiento6.Value = ViewSeguimiento6
                End If
                Dim ViewSeguimiento7 = oIndividual.Seguimiento7
                If ViewSeguimiento7 = "01/01/1900" Then
                    Me.dtpSeguimiento7.Value = ""
                Else
                    Me.dtpSeguimiento7.Value = ViewSeguimiento7
                End If
                Dim ViewSeguimiento8 = oIndividual.Seguimiento8
                If ViewSeguimiento8 = "01/01/1900" Then
                    Me.dtpSeguimiento8.Value = ""
                Else
                    Me.dtpSeguimiento8.Value = ViewSeguimiento8
                End If
                Dim ViewCierre = oIndividual.Cierre
                If ViewCierre = "01/01/1900" Then
                    Me.dtpCierre.Value = ""
                Else
                    Me.dtpCierre.Value = ViewCierre
                End If
                Dim ViewSF_Seguimiento1 = oIndividual.SF_Seguimiento1
                If ViewSF_Seguimiento1 = "01/01/1900" Then
                    Me.dtpSF_Seguimiento1.Value = ""
                Else
                    Me.dtpSF_Seguimiento1.Value = ViewSF_Seguimiento1
                End If
                Dim ViewSF_Seguimiento2 = oIndividual.SF_Seguimiento2
                If ViewSF_Seguimiento2 = "01/01/1900" Then
                    Me.dtpSF_Seguimiento2.Value = ""
                Else
                    Me.dtpSF_Seguimiento2.Value = ViewSF_Seguimiento2
                End If
                Dim ViewSF_Seguimiento3 = oIndividual.SF_Seguimiento3
                If ViewSF_Seguimiento3 = "01/01/1900" Then
                    Me.dtpSF_Seguimiento3.Value = ""
                Else
                    Me.dtpSF_Seguimiento3.Value = ViewSF_Seguimiento3
                End If
                Dim ViewSF_Seguimiento4 = oIndividual.SF_Seguimiento4
                If ViewSF_Seguimiento4 = "01/01/1900" Then
                    Me.dtpSF_Seguimiento4.Value = ""
                Else
                    Me.dtpSF_Seguimiento4.Value = ViewSF_Seguimiento4
                End If
                Dim ViewSF_Seguimiento5 = oIndividual.SF_Seguimiento5
                If ViewSF_Seguimiento5 = "01/01/1900" Then
                    Me.dtpSF_Seguimiento5.Value = ""
                Else
                    Me.dtpSF_Seguimiento5.Value = ViewSF_Seguimiento5
                End If
                Dim ViewGestion1 = oIndividual.Gestion1
                If ViewGestion1 = "01/01/1900" Then
                    Me.dtpGestion1.Value = ""
                Else
                    Me.dtpGestion1.Value = ViewGestion1
                End If
                Dim ViewGestion2 = oIndividual.Gestion2
                If ViewGestion2 = "01/01/1900" Then
                    Me.dtpGestion2.Value = ""
                Else
                    Me.dtpGestion2.Value = ViewGestion2
                End If

                Dim ViewGestion3 = oIndividual.Gestion3
                If ViewGestion3 = "01/01/1900" Then
                    Me.dtpGestion3.Value = ""
                Else
                    Me.dtpGestion3.Value = ViewGestion3
                End If
                Dim ViewGestion4 = oIndividual.Gestion4
                If ViewGestion4 = "01/01/1900" Then
                    Me.dtpGestion4.Value = ""
                Else
                    Me.dtpGestion4.Value = ViewGestion4
                End If
                Dim ViewGestion5 = oIndividual.Gestion5
                If ViewGestion5 = "01/01/1900" Then
                    Me.dtpGestion5.Value = ""
                Else
                    Me.dtpGestion5.Value = ViewGestion5
                End If
                Dim ViewGestion6 = oIndividual.Gestion6
                If ViewGestion6 = "01/01/1900" Then
                    Me.dtpGestion6.Value = ""
                Else
                    Me.dtpGestion6.Value = ViewGestion6
                End If
                Dim ViewGestion7 = oIndividual.Gestion7
                If ViewGestion7 = "01/01/1900" Then
                    Me.dtpGestion7.Value = ""
                Else
                    Me.dtpGestion7.Value = ViewGestion7
                End If
                Dim ViewGestion8 = oIndividual.Gestion8
                If ViewGestion8 = "01/01/1900" Then
                    Me.dtpGestion8.Value = ""
                Else
                    Me.dtpGestion8.Value = ViewGestion8
                End If
                Dim ViewGestion9 = oIndividual.Gestion9
                If ViewGestion9 = "01/01/1900" Then
                    Me.dtpGestion9.Value = ""
                Else
                    Me.dtpGestion9.Value = ViewGestion9
                End If
                Dim ViewGestion10 = oIndividual.Gestion10
                If ViewGestion10 = "01/01/1900" Then
                    Me.dtpGestion10.Value = ""
                Else
                    Me.dtpGestion10.Value = ViewGestion10
                End If
                Dim ViewDerivacion1 = oIndividual.Derivacion1
                If ViewDerivacion1 = "01/01/1900" Then
                    Me.dtpDerivacion1.Value = ""
                Else
                    Me.dtpDerivacion1.Value = ViewDerivacion1
                End If
                Dim ViewDerivacion2 = oIndividual.Derivacion2
                If ViewDerivacion2 = "01/01/1900" Then
                    Me.dtpDerivacion2.Value = ""
                Else
                    Me.dtpDerivacion2.Value = ViewDerivacion2
                End If
                Dim ViewDerivacion3 = oIndividual.Derivacion3
                If ViewDerivacion3 = "01/01/1900" Then
                    Me.dtpDerivacion3.Value = ""
                Else
                    Me.dtpDerivacion3.Value = ViewDerivacion3
                End If
                Dim ViewDerivacion4 = oIndividual.Derivacion4
                If ViewDerivacion4 = "01/01/1900" Then
                    Me.dtpDerivacion4.Value = ""
                Else
                    Me.dtpDerivacion4.Value = ViewDerivacion4
                End If
                Me.cboNivEfec.Value = oIndividual.NivEfec
                Me.cboMotivoCier.Value = oIndividual.MotivoCier
                Me.cboAseguramiento.Value = oIndividual.Aseguramiento
                Me.cboEAPB.SelectedValue = oIndividual.EAPB
                Me.cboProyectoViv.SelectedValue = oIndividual.ProyectoViv
                Me.cboRemitidoP.SelectedValue = oIndividual.RemitidoP
                Me.txtCalificacion.Value = oIndividual.Calificacion
                Me.txtIRH.Value = oIndividual.IRH
                Me.txtObservaciones.Value = oIndividual.Observaciones
                Me.cboAplicativo.Value = oIndividual.Aplicativo
                Me.cboEscaner.Value = oIndividual.Escaner
                ProcesarVisualizar()

        End Select

        Dim FechaHoy As Date = TraerFechaServidor()             '<JPaez 15-09-2010>

    End Sub
    Protected Sub btnInsertar_ServerClick(sender As Object, e As EventArgs) Handles btnInsertar.ServerClick

        Dim mode As String = Request.QueryString("opcion")
        Dim sInd As Boolean = False
        If Validar() Then
            Select Case mode
                Case "new"
                    sInd = ProcesarNuevo()
                Case "edit"
                    sInd = ProcesarEditar()
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

        Dim sInd As Boolean = False
        Dim oIndividual As New clsIndividual
        With oIndividual
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
            .Nivel = Me.cboNivel.Value
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
            Dim sIndi As Integer = oIndividual.Insertar()
            If sIndi <= 0 Then
                sInd = False
                Me.RadAjaxManager1.Alert("Error: ")
            Else
                sInd = True
                RadAjaxManager1.ResponseScripts.Add("CloseAndRebindInsert(1);")
            End If
        Catch ex As Exception
            Me.RadAjaxManager1.Alert("Error: " & ex.Message)
            sInd = False
        End Try

        Return sInd

    End Function
    Private Function ProcesarEditar() As Boolean

        Dim sInd As Boolean = False
        Dim oIndividual As New clsIndividual
        oIndividual.Load(Request.QueryString("Id_Individual"))
        With oIndividual
            .Id_Individual = Request.QueryString("Id_Individual")
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
            .Nivel = Me.cboNivel.Value
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
            Dim Seguimiento3 = Me.dtpSeguimiento3.Value
            If Seguimiento3 <> Nothing Then
                .Seguimiento3 = dtpSeguimiento3.Value
            Else
                .Seguimiento3 = "01/01/1900"
            End If
            Dim Seguimiento4 = Me.dtpSeguimiento4.Value
            If Seguimiento4 <> Nothing Then
                .Seguimiento4 = dtpSeguimiento4.Value
            Else
                .Seguimiento4 = "01/01/1900"
            End If
            Dim Seguimiento5 = Me.dtpSeguimiento5.Value
            If Seguimiento5 <> Nothing Then
                .Seguimiento5 = dtpSeguimiento5.Value
            Else
                .Seguimiento5 = "01/01/1900"
            End If
            Dim Seguimiento6 = Me.dtpSeguimiento6.Value
            If Seguimiento6 <> Nothing Then
                .Seguimiento6 = dtpSeguimiento6.Value
            Else
                .Seguimiento6 = "01/01/1900"
            End If
            Dim Seguimiento7 = Me.dtpSeguimiento7.Value
            If Seguimiento7 <> Nothing Then
                .Seguimiento7 = dtpSeguimiento7.Value
            Else
                .Seguimiento7 = "01/01/1900"
            End If
            Dim Seguimiento8 = Me.dtpSeguimiento8.Value
            If Seguimiento8 <> Nothing Then
                .Seguimiento8 = dtpSeguimiento8.Value
            Else
                .Seguimiento8 = "01/01/1900"
            End If
            Dim Cierre = Me.dtpCierre.Value
            If Cierre <> Nothing Then
                .Cierre = dtpCierre.Value
            Else
                .Cierre = "01/01/1900"
            End If
            Dim SF_Seguimiento1 = Me.dtpSF_Seguimiento1.Value
            If SF_Seguimiento1 <> Nothing Then
                .SF_Seguimiento1 = dtpSF_Seguimiento1.Value
            Else
                .SF_Seguimiento1 = "01/01/1900"
            End If
            Dim SF_Seguimiento2 = Me.dtpSF_Seguimiento2.Value
            If SF_Seguimiento2 <> Nothing Then
                .SF_Seguimiento2 = dtpSF_Seguimiento2.Value
            Else
                .SF_Seguimiento2 = "01/01/1900"
            End If
            Dim SF_Seguimiento3 = Me.dtpSF_Seguimiento3.Value
            If SF_Seguimiento3 <> Nothing Then
                .SF_Seguimiento3 = dtpSF_Seguimiento3.Value
            Else
                .SF_Seguimiento3 = "01/01/1900"
            End If
            Dim SF_Seguimiento4 = Me.dtpSF_Seguimiento4.Value
            If SF_Seguimiento4 <> Nothing Then
                .SF_Seguimiento4 = dtpSF_Seguimiento4.Value
            Else
                .SF_Seguimiento4 = "01/01/1900"
            End If
            Dim SF_Seguimiento5 = Me.dtpSF_Seguimiento5.Value
            If SF_Seguimiento5 <> Nothing Then
                .SF_Seguimiento5 = dtpSF_Seguimiento5.Value
            Else
                .SF_Seguimiento5 = "01/01/1900"
            End If
            Dim Gestion1 = Me.dtpGestion1.Value
            If Gestion1 <> Nothing Then
                .Gestion1 = dtpGestion1.Value
            Else
                .Gestion1 = "01/01/1900"
            End If
            Dim Gestion2 = Me.dtpGestion2.Value
            If Gestion2 <> Nothing Then
                .Gestion2 = dtpGestion2.Value
            Else
                .Gestion2 = "01/01/1900"
            End If
            Dim Gestion3 = Me.dtpGestion3.Value
            If Gestion3 <> Nothing Then
                .Gestion3 = dtpGestion3.Value
            Else
                .Gestion3 = "01/01/1900"
            End If
            Dim Gestion4 = Me.dtpGestion4.Value
            If Gestion4 <> Nothing Then
                .Gestion4 = dtpGestion4.Value
            Else
                .Gestion4 = "01/01/1900"
            End If
            Dim Gestion5 = Me.dtpGestion5.Value
            If Gestion5 <> Nothing Then
                .Gestion5 = dtpGestion5.Value
            Else
                .Gestion5 = "01/01/1900"
            End If
            Dim Gestion6 = Me.dtpGestion6.Value
            If Gestion6 <> Nothing Then
                .Gestion6 = dtpGestion6.Value
            Else
                .Gestion6 = "01/01/1900"
            End If
            Dim Gestion7 = Me.dtpGestion7.Value
            If Gestion7 <> Nothing Then
                .Gestion7 = dtpGestion7.Value
            Else
                .Gestion7 = "01/01/1900"
            End If
            Dim Gestion8 = Me.dtpGestion8.Value
            If Gestion8 <> Nothing Then
                .Gestion8 = dtpGestion8.Value
            Else
                .Gestion8 = "01/01/1900"
            End If
            Dim Gestion9 = Me.dtpGestion9.Value
            If Gestion9 <> Nothing Then
                Gestion9 = dtpGestion9.Value
            Else
                .Gestion9 = "01/01/1900"
            End If
            Dim Gestion10 = Me.dtpGestion10.Value
            If Gestion10 <> Nothing Then
                .Gestion10 = dtpGestion10.Value
            Else
                .Gestion10 = "01/01/1900"
            End If
            Dim Derivacion1 = Me.dtpDerivacion1.Value
            If Derivacion1 <> Nothing Then
                .Derivacion1 = dtpDerivacion1.Value
            Else
                .Derivacion1 = "01/01/1900"
            End If
            Dim Derivacion2 = Me.dtpDerivacion2.Value
            If Derivacion2 <> Nothing Then
                .Derivacion2 = dtpDerivacion2.Value
            Else
                .Derivacion2 = "01/01/1900"
            End If
            Dim Derivacion3 = Me.dtpDerivacion3.Value
            If Derivacion3 <> Nothing Then
                .Derivacion3 = dtpDerivacion3.Value
            Else
                .Derivacion3 = "01/01/1900"
            End If
            Dim Derivacion4 = Me.dtpDerivacion4.Value
            If Derivacion4 <> Nothing Then
                .Derivacion4 = dtpDerivacion4.Value
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
            Dim sIndiv As Integer = oIndividual.Actualizar
            If sInd <> 0 Then
                Me.RadAjaxManager1.Alert("Error: ")
                sInd = False
            Else
                sInd = True
                RadAjaxManager1.ResponseScripts.Add("CloseAndRebindInsert(0);")
            End If
        Catch ex As Exception
            Me.RadAjaxManager1.Alert("Error: " & ex.Message)
            sInd = False
        End Try

        Return sInd

    End Function

    '''' <summary>
    '''' InhabilitarControles
    '''' </summary>
    '''' <autor>Julio Paez</autor>
    '''' <autor> En Violencias Individuales usado por Jakson Moreno R 11 -03 -2021</autor>
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
            Me.txtTelefono.Disabled = True
            Me.cboGenero.Disabled = True
            Me.cboCicloVit.Disabled = True
            Me.cboPertEtnica.Disabled = True
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

        Dim Id_Individual As Integer = Request.QueryString("Id_Individual")
        Dim dr As Data.DataRow = Nothing
        Dim ds As New DataSet
        Dim coleccionParametros As New Collection
        Dim parametro As New CmdParametro("@Id_Individual", Id_Individual, SqlDbType.Int, True)
        coleccionParametros.Add(parametro)
        ds = clsBitacora.GetSelect("spViolenciaIndividualById", coleccionParametros, Session, 35, False)
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

        Dim dt As DataTable = clsBitacora.GetSelect("app.spgetOrientacionTem", coleccionParametros, Session, 422, False).Tables(0)

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
