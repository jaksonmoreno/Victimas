Imports Microsoft.VisualBasic
Imports System.Data

Public Class clsIndividual

    Private _Id_Individual As Integer
    Private _PuntoAtencion As Integer
    Private _FechaApert As DateTime
    Private _TipoDoc As Integer
    Private _NumDoc As String
    Private _PrimerNombre As String
    Private _SegundoNombre As String
    Private _PrimerApellido As String
    Private _SegundoApellido As String
    Private _Telefono As String
    Private _Genero As Integer
    Private _CicloVit As Integer
    Private _PertEtnica As Integer
    Private _AreaRural As Boolean
    Private _DireccionPCO As String
    Private _LocalidadPCO As Integer
    Private _Barrio As Integer
    Private _NombreUpz As Integer
    Private _Terrorista As Integer
    Private _Amenaza As Integer
    Private _Delitos As Integer
    Private _Desaparicion As Integer
    Private _Desplazamiento As Integer
    Private _Homicidio As Integer
    Private _Masacre As Integer
    Private _Minas As Integer
    Private _Secuestro As Integer
    Private _Tortura As Integer
    Private _Vinculación As Integer
    Private _Abandono As Integer
    Private _Profesional As String
    Private _Nivel As Integer
    Private _OrientacionTemat As Integer
    Private _Acercamiento As DateTime
    Private _Seguimiento2 As DateTime
    Private _Seguimiento3 As DateTime
    Private _Seguimiento4 As DateTime
    Private _Seguimiento5 As DateTime
    Private _Seguimiento6 As DateTime
    Private _Seguimiento7 As DateTime
    Private _Seguimiento8 As DateTime
    Private _Cierre As DateTime
    Private _SF_Seguimiento1 As DateTime
    Private _SF_Seguimiento2 As DateTime
    Private _SF_Seguimiento3 As DateTime
    Private _SF_Seguimiento4 As DateTime
    Private _SF_Seguimiento5 As DateTime
    Private _Gestion1 As DateTime
    Private _Gestion2 As DateTime
    Private _Gestion3 As DateTime
    Private _Gestion4 As DateTime
    Private _Gestion5 As DateTime
    Private _Gestion6 As DateTime
    Private _Gestion7 As DateTime
    Private _Gestion8 As DateTime
    Private _Gestion9 As DateTime
    Private _Gestion10 As DateTime
    Private _Derivacion1 As DateTime
    Private _Derivacion2 As DateTime
    Private _Derivacion3 As DateTime
    Private _Derivacion4 As DateTime
    Private _NivEfec As Integer
    Private _MotivoCier As Integer
    Private _Aseguramiento As Integer
    Private _EAPB As Integer
    Private _ProyectoViv As Integer
    Private _RemitidoP As Integer
    Private _Calificacion As Integer
    Private _IRH As Integer
    Private _Observaciones As String
    Private _Aplicativo As Integer
    Private _Escaner As Integer

    Public Property Id_Individual As Integer
        Get
            Return _Id_Individual
        End Get
        Set(ByVal value As Integer)
            _Id_Individual = value
        End Set
    End Property
    Public Property PuntoAtencion() As Integer
        Get
            Return _PuntoAtencion
        End Get
        Set(ByVal value As Integer)
            _PuntoAtencion = value
        End Set
    End Property
    Public Property FechaApert() As DateTime
        Get
            Return _FechaApert
        End Get
        Set(ByVal value As DateTime)
            _FechaApert = value
        End Set
    End Property
    Public Property TipoDoc() As Integer
        Get
            Return _TipoDoc
        End Get
        Set(ByVal value As Integer)
            _TipoDoc = value
        End Set
    End Property
    Public Property NumDoc() As String
        Get
            Return _NumDoc
        End Get
        Set(ByVal value As String)
            _NumDoc = value
        End Set
    End Property
    Public Property PrimerNombre() As String
        Get
            Return _PrimerNombre
        End Get
        Set(ByVal value As String)
            _PrimerNombre = value
        End Set
    End Property
    Public Property SegundoNombre() As String
        Get
            Return _SegundoNombre
        End Get
        Set(ByVal value As String)
            _SegundoNombre = value
        End Set
    End Property
    Public Property PrimerApellido() As String
        Get
            Return _PrimerApellido
        End Get
        Set(ByVal value As String)
            _PrimerApellido = value
        End Set
    End Property
    Public Property SegundoApellido() As String
        Get
            Return _SegundoApellido
        End Get
        Set(ByVal value As String)
            _SegundoApellido = value
        End Set
    End Property
    Public Property Telefono() As String
        Get
            Return _Telefono
        End Get
        Set(ByVal value As String)
            _Telefono = value
        End Set
    End Property
    Public Property Genero() As Integer
        Get
            Return _Genero
        End Get
        Set(ByVal value As Integer)
            _Genero = value
        End Set
    End Property
    Public Property CicloVit() As Integer
        Get
            Return _CicloVit
        End Get
        Set(ByVal value As Integer)
            _CicloVit = value
        End Set
    End Property
    Public Property PertEtnica() As Integer
        Get
            Return _PertEtnica
        End Get
        Set(ByVal value As Integer)
            _PertEtnica = value
        End Set
    End Property
    Public Property AreaRural() As Boolean
        Get
            Return _AreaRural
        End Get
        Set(ByVal value As Boolean)
            Try
                _AreaRural = value
            Catch ex As Exception
                _AreaRural = False
            End Try
        End Set
    End Property
    Public Property DireccionPCO() As String
        Get
            Return _DireccionPCO
        End Get
        Set(ByVal value As String)
            _DireccionPCO = value
        End Set
    End Property
    Public Property LocalidadPCO() As Integer
        Get
            Return _LocalidadPCO
        End Get
        Set(value As Integer)
            _LocalidadPCO = value
        End Set
    End Property
    Public Property Barrio() As Integer
        Get
            Return _Barrio
        End Get
        Set(ByVal value As Integer)
            _Barrio = value
        End Set
    End Property
    Public Property NombreUpz() As Integer
        Get
            Return _NombreUpz
        End Get
        Set(ByVal value As Integer)
            _NombreUpz = value
        End Set
    End Property
    Public Property Terrorista() As Integer
        Get
            Return _Terrorista
        End Get
        Set(ByVal value As Integer)
            _Terrorista = value
        End Set
    End Property
    Public Property Amenaza() As Integer
        Get
            Return _Amenaza
        End Get
        Set(ByVal value As Integer)
            _Amenaza = value
        End Set
    End Property
    Public Property Delitos() As Integer
        Get
            Return _Delitos
        End Get
        Set(ByVal value As Integer)
            _Delitos = value
        End Set
    End Property
    Public Property Desaparicion() As Integer
        Get
            Return _Desaparicion
        End Get
        Set(ByVal value As Integer)
            _Desaparicion = value
        End Set
    End Property
    Public Property Desplazamiento() As Integer
        Get
            Return _Desplazamiento
        End Get
        Set(ByVal value As Integer)
            _Desplazamiento = value
        End Set
    End Property
    Public Property Homicidio() As Integer
        Get
            Return _Homicidio
        End Get
        Set(ByVal value As Integer)
            _Homicidio = value
        End Set
    End Property
    Public Property Masacre() As Integer
        Get
            Return _Masacre
        End Get
        Set(ByVal value As Integer)
            _Masacre = value
        End Set
    End Property
    Public Property Minas() As Integer
        Get
            Return _Minas
        End Get
        Set(ByVal value As Integer)
            _Minas = value
        End Set
    End Property
    Public Property Secuestro() As Integer
        Get
            Return _Secuestro
        End Get
        Set(ByVal value As Integer)
            _Secuestro = value
        End Set
    End Property
    Public Property Tortura() As Integer
        Get
            Return _Tortura
        End Get
        Set(ByVal value As Integer)
            _Tortura = value
        End Set
    End Property
    Public Property Vinculación() As Integer
        Get
            Return _Vinculación
        End Get
        Set(ByVal value As Integer)
            _Vinculación = value
        End Set
    End Property
    Public Property Abandono() As Integer
        Get
            Return _Abandono
        End Get
        Set(ByVal value As Integer)
            _Abandono = value
        End Set
    End Property
    Public Property Profesional() As String
        Get
            Return _Profesional
        End Get
        Set(ByVal value As String)
            _Profesional = value
        End Set
    End Property
    Public Property Nivel() As Integer
        Get
            Return _Nivel
        End Get
        Set(ByVal value As Integer)
            _Nivel = value
        End Set
    End Property
    Public Property OrientacionTemat() As Integer
        Get
            Return _OrientacionTemat
        End Get
        Set(ByVal value As Integer)
            _OrientacionTemat = value
        End Set
    End Property
    Public Property Acercamiento() As DateTime
        Get
            Return _Acercamiento
        End Get
        Set(ByVal value As DateTime)
            _Acercamiento = value
        End Set
    End Property
    Public Property Seguimiento2() As DateTime
        Get
            Return _Seguimiento2
        End Get
        Set(ByVal value As DateTime)
            _Seguimiento2 = value
        End Set
    End Property
    Public Property Seguimiento3() As DateTime
        Get
            Return _Seguimiento3
        End Get
        Set(ByVal value As DateTime)
            _Seguimiento3 = value
        End Set
    End Property
    Public Property Seguimiento4() As DateTime
        Get
            Return _Seguimiento4
        End Get
        Set(ByVal value As DateTime)
            _Seguimiento4 = value
        End Set
    End Property
    Public Property Seguimiento5() As DateTime
        Get
            Return _Seguimiento5
        End Get
        Set(ByVal value As DateTime)
            _Seguimiento5 = value
        End Set
    End Property
    Public Property Seguimiento6() As DateTime
        Get
            Return _Seguimiento6
        End Get
        Set(ByVal value As DateTime)
            _Seguimiento6 = value
        End Set
    End Property
    Public Property Seguimiento7() As DateTime
        Get
            Return _Seguimiento7
        End Get
        Set(ByVal value As DateTime)
            _Seguimiento7 = value
        End Set
    End Property
    Public Property Seguimiento8() As DateTime
        Get
            Return _Seguimiento8
        End Get
        Set(ByVal value As DateTime)
            _Seguimiento8 = value
        End Set
    End Property
    Public Property Cierre() As DateTime
        Get
            Return _Cierre
        End Get
        Set(ByVal value As DateTime)
            _Cierre = value
        End Set
    End Property
    Public Property SF_Seguimiento1() As DateTime
        Get
            Return _SF_Seguimiento1
        End Get
        Set(ByVal value As DateTime)
            _SF_Seguimiento1 = value
        End Set
    End Property
    Public Property SF_Seguimiento2() As DateTime
        Get
            Return _SF_Seguimiento2
        End Get
        Set(ByVal value As DateTime)
            _SF_Seguimiento2 = value
        End Set
    End Property
    Public Property SF_Seguimiento3() As DateTime
        Get
            Return _SF_Seguimiento3
        End Get
        Set(ByVal value As DateTime)
            _SF_Seguimiento3 = value
        End Set
    End Property
    Public Property SF_Seguimiento4() As DateTime
        Get
            Return _SF_Seguimiento4
        End Get
        Set(ByVal value As DateTime)
            _SF_Seguimiento4 = value
        End Set
    End Property
    Public Property SF_Seguimiento5() As DateTime
        Get
            Return _SF_Seguimiento5
        End Get
        Set(ByVal value As DateTime)
            _SF_Seguimiento5 = value
        End Set
    End Property
    Public Property Gestion1() As DateTime
        Get
            Return _Gestion1
        End Get
        Set(ByVal value As DateTime)
            _Gestion1 = value
        End Set
    End Property
    Public Property Gestion2() As DateTime
        Get
            Return _Gestion2
        End Get
        Set(ByVal value As DateTime)
            _Gestion2 = value
        End Set
    End Property
    Public Property Gestion3() As DateTime
        Get
            Return _Gestion3
        End Get
        Set(ByVal value As DateTime)
            _Gestion3 = value
        End Set
    End Property
    Public Property Gestion4() As DateTime
        Get
            Return _Gestion4
        End Get
        Set(ByVal value As DateTime)
            _Gestion4 = value
        End Set
    End Property
    Public Property Gestion5() As DateTime
        Get
            Return _Gestion5
        End Get
        Set(ByVal value As DateTime)
            _Gestion5 = value
        End Set
    End Property
    Public Property Gestion6() As DateTime
        Get
            Return _Gestion6
        End Get
        Set(ByVal value As DateTime)
            _Gestion6 = value
        End Set
    End Property
    Public Property Gestion7() As DateTime
        Get
            Return _Gestion7
        End Get
        Set(ByVal value As DateTime)
            _Gestion7 = value
        End Set
    End Property
    Public Property Gestion8() As DateTime
        Get
            Return _Gestion8
        End Get
        Set(ByVal value As DateTime)
            _Gestion8 = value
        End Set
    End Property
    Public Property Gestion9() As DateTime
        Get
            Return _Gestion9
        End Get
        Set(ByVal value As DateTime)
            _Gestion9 = value
        End Set
    End Property
    Public Property Gestion10() As DateTime
        Get
            Return _Gestion10
        End Get
        Set(ByVal value As DateTime)
            _Gestion10 = value
        End Set
    End Property
    Public Property Derivacion1() As DateTime
        Get
            Return _Derivacion1
        End Get
        Set(ByVal value As DateTime)
            _Derivacion1 = value
        End Set
    End Property
    Public Property Derivacion2() As DateTime
        Get
            Return _Derivacion2
        End Get
        Set(ByVal value As DateTime)
            _Derivacion2 = value
        End Set
    End Property
    Public Property Derivacion3() As DateTime
        Get
            Return _Derivacion3
        End Get
        Set(ByVal value As DateTime)
            _Derivacion3 = value
        End Set
    End Property
    Public Property Derivacion4() As DateTime
        Get
            Return _Derivacion4
        End Get
        Set(ByVal value As DateTime)
            _Derivacion4 = value
        End Set
    End Property
    Public Property NivEfec() As Integer
        Get
            Return _NivEfec
        End Get
        Set(ByVal value As Integer)
            _NivEfec = value
        End Set
    End Property
    Public Property MotivoCier() As Integer
        Get
            Return _MotivoCier
        End Get
        Set(ByVal value As Integer)
            _MotivoCier = value
        End Set
    End Property
    Public Property Aseguramiento() As Integer
        Get
            Return _Aseguramiento
        End Get
        Set(ByVal value As Integer)
            _Aseguramiento = value
        End Set
    End Property
    Public Property EAPB() As Integer
        Get
            Return _EAPB
        End Get
        Set(ByVal value As Integer)
            _EAPB = value
        End Set
    End Property
    Public Property ProyectoViv() As Integer
        Get
            Return _ProyectoViv
        End Get
        Set(ByVal value As Integer)
            _ProyectoViv = value
        End Set
    End Property
    Public Property RemitidoP() As Integer
        Get
            Return _RemitidoP
        End Get
        Set(ByVal value As Integer)
            _RemitidoP = value
        End Set
    End Property
    Public Property Calificacion() As Integer
        Get
            Return _Calificacion
        End Get
        Set(ByVal value As Integer)
            _Calificacion = value
        End Set
    End Property
    Public Property IRH() As Integer
        Get
            Return _IRH
        End Get
        Set(ByVal value As Integer)
            _IRH = value
        End Set
    End Property
    Public Property Observaciones() As String
        Get
            Return _Observaciones
        End Get
        Set(ByVal value As String)
            _Observaciones = value
        End Set
    End Property
    Public Property Aplicativo() As Integer
        Get
            Return _Aplicativo
        End Get
        Set(ByVal value As Integer)
            _Aplicativo = value
        End Set
    End Property
    Public Property Escaner() As Integer
        Get
            Return _Escaner
        End Get
        Set(ByVal value As Integer)
            _Escaner = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub Load(pId As Integer)

        Dim ds As New DataSet
        Dim Dr As DataRow = Nothing
        Try
            Dim objParametros As New Collection
            Dim ObjItems As New CmdParametro("@Id_Individual", pId, SqlDbType.Int, True)
            objParametros.Add(ObjItems)


            ds = clsBitacora.GetSelect("app.spViolenciaIndividualById", objParametros, HttpContext.Current.Session, 2488, False)
            If Not ds Is Nothing Then
                If ds.Tables.Count > 0 Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        Dr = ds.Tables(0).Rows(0)
                        _Id_Individual = Dr("Id_Individual")
                        _PuntoAtencion = Dr("PuntoAtencion").ToString
                        _FechaApert = Dr("FechaApert").ToString
                        _TipoDoc = Dr("TipoDoc").ToString
                        _NumDoc = Dr("NumDoc").ToString
                        _PrimerNombre = Dr("PrimerNombre").ToString
                        _SegundoNombre = Dr("SegundoNombre").ToString
                        _PrimerApellido = Dr("PrimerApellido").ToString
                        _SegundoApellido = Dr("SegundoApellido").ToString
                        _Telefono = Dr("Telefono").ToString
                        _Genero = Dr("Genero").ToString
                        _CicloVit = Dr("CicloVit").ToString
                        _PertEtnica = Dr("PertEtnica").ToString
                        _AreaRural = Dr("AreaRural").ToString
                        _DireccionPCO = Dr("DireccionPCO").ToString
                        _LocalidadPCO = Dr("LocalidadPCO").ToString
                        _Barrio = Dr("Barrio").ToString
                        _NombreUpz = Dr("NombreUpz").ToString
                        _Terrorista = Dr("Terrorista").ToString
                        _Amenaza = Dr("Amenaza").ToString
                        _Delitos = Dr("Delitos").ToString
                        _Desaparicion = Dr("Desaparicion").ToString
                        _Desplazamiento = Dr("Desplazamiento").ToString
                        _Homicidio = Dr("Homicidio").ToString
                        _Masacre = Dr("Masacre").ToString
                        _Minas = Dr("Minas").ToString
                        _Secuestro = Dr("Secuestro").ToString
                        _Tortura = Dr("Tortura").ToString
                        _Vinculación = Dr("Vinculación").ToString
                        _Abandono = Dr("Abandono").ToString
                        _Profesional = Dr("Profesional").ToString
                        _Nivel = Dr("Nivel").ToString
                        _OrientacionTemat = Dr("OrientacionTemat").ToString
                        _Acercamiento = Dr("Acercamiento").ToString
                        _Seguimiento2 = Dr("Seguimiento2").ToString
                        _Seguimiento3 = Dr("Seguimiento3").ToString
                        _Seguimiento4 = Dr("Seguimiento4").ToString
                        _Seguimiento5 = Dr("Seguimiento5").ToString
                        _Seguimiento6 = Dr("Seguimiento6").ToString
                        _Seguimiento7 = Dr("Seguimiento7").ToString
                        _Seguimiento8 = Dr("Seguimiento8").ToString
                        _Cierre = Dr("Cierre").ToString
                        _SF_Seguimiento1 = Dr("SF_Seguimiento1").ToString
                        _SF_Seguimiento2 = Dr("SF_Seguimiento2").ToString
                        _SF_Seguimiento3 = Dr("SF_Seguimiento3").ToString
                        _SF_Seguimiento4 = Dr("SF_Seguimiento4").ToString
                        _SF_Seguimiento5 = Dr("SF_Seguimiento5").ToString
                        _Gestion1 = Dr("Gestion1").ToString
                        _Gestion2 = Dr("Gestion2").ToString
                        _Gestion3 = Dr("Gestion3").ToString
                        _Gestion4 = Dr("Gestion4").ToString
                        _Gestion5 = Dr("Gestion5").ToString
                        _Gestion6 = Dr("Gestion6").ToString
                        _Gestion7 = Dr("Gestion7").ToString
                        _Gestion8 = Dr("Gestion8").ToString
                        _Gestion9 = Dr("Gestion9").ToString
                        _Gestion10 = Dr("Gestion10").ToString
                        _Derivacion1 = Dr("Derivacion1").ToString
                        _Derivacion2 = Dr("Derivacion2").ToString
                        _Derivacion3 = Dr("Derivacion3").ToString
                        _Derivacion4 = Dr("Derivacion4").ToString
                        _NivEfec = Dr("NivEfec").ToString
                        _MotivoCier = Dr("MotivoCier").ToString
                        _Aseguramiento = Dr("Aseguramiento").ToString
                        _EAPB = Dr("EAPB").ToString
                        _ProyectoViv = Dr("ProyectoViv").ToString
                        _RemitidoP = Dr("RemitidoP").ToString
                        _Calificacion = Dr("Calificacion").ToString
                        _IRH = Dr("IRH").ToString
                        _Observaciones = Dr("Observaciones").ToString
                        _Aplicativo = Dr("Aplicativo").ToString
                        _Escaner = Dr("Escaner").ToString
                    End If
                End If
            End If
            If Dr Is Nothing Then
                Throw (New Exception("Registro Individual no existe"))
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message & " Obteniendo Registro Individual")
        End Try
    End Sub
    Public Function BuscarIndividualById(ByVal Id_Individual As Integer) As DataTable

        Dim bResp As Boolean = False
        Dim Datos As New DataSet
        Dim objparametros As New Collection
        Dim ObjItems As New CmdParametro("@Id_Individual", Id_Individual, SqlDbType.Int, False)
        objparametros.Add(ObjItems)

        Datos = clsBitacora.GetSelect("app.spViolenciaIndividualById", objparametros, HttpContext.Current.Session, 281, False)
        Return Datos.Tables(0)
    End Function

#Region "CRUD"

    Public Function Insertar() As Integer

        Dim Ds As New DataSet
        Dim Dr As DataRow = Nothing
        Dim coleccionParametros As New Collection

        Dim parametro = New CmdParametro("@PuntoAtencion", PuntoAtencion, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@FechaApert", FechaApert, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@TipoDoc", TipoDoc, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@NumDoc", NumDoc, SqlDbType.VarChar, False, 16)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@PrimerNombre", PrimerNombre, SqlDbType.VarChar, False, 60)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@SegundoNombre", SegundoNombre, SqlDbType.VarChar, False, 60)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@PrimerApellido", PrimerApellido, SqlDbType.VarChar, False, 60)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@SegundoApellido", SegundoApellido, SqlDbType.VarChar, False, 60)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Telefono", Telefono, SqlDbType.VarChar, False, 16)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Genero", Genero, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@CicloVit", CicloVit, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@PertEtnica", PertEtnica, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@AreaRural", AreaRural, SqlDbType.Bit, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@DireccionPCO", DireccionPCO, SqlDbType.VarChar, False, 60)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@LocalidadPCO", LocalidadPCO, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Barrio", Barrio, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@NombreUpz", NombreUpz, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Terrorista", Terrorista, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Amenaza", Amenaza, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Delitos", Delitos, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Desaparicion", Desaparicion, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Desplazamiento", Desplazamiento, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Homicidio", Homicidio, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Masacre", Masacre, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Minas", Minas, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Secuestro", Secuestro, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Tortura", Tortura, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Vinculación", Vinculación, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Abandono", Abandono, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Profesional", Profesional, SqlDbType.VarChar, False, 60)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Nivel", Nivel, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("OrientacionTemat", OrientacionTemat, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Acercamiento", Acercamiento, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Seguimiento2", Seguimiento2, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Seguimiento3", Seguimiento3, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Seguimiento4", Seguimiento4, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Seguimiento5", Seguimiento5, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Seguimiento6", Seguimiento6, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Seguimiento7", Seguimiento7, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Seguimiento8", Seguimiento8, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Cierre", Cierre, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@SF_Seguimiento1", SF_Seguimiento1, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@SF_Seguimiento2", SF_Seguimiento2, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@SF_Seguimiento3", SF_Seguimiento3, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@SF_Seguimiento4", SF_Seguimiento4, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@SF_Seguimiento5", SF_Seguimiento5, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Gestion1", Gestion1, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Gestion2", Gestion2, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Gestion3", Gestion3, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Gestion4", Gestion4, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Gestion5", Gestion5, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Gestion6", Gestion6, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Gestion7", Gestion7, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Gestion8", Gestion8, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Gestion9", Gestion9, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Gestion10", Gestion10, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Derivacion1", Derivacion1, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Derivacion2", Derivacion2, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Derivacion3", Derivacion3, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Derivacion4", Derivacion4, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@NivEfec", NivEfec, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@MotivoCier", MotivoCier, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Aseguramiento", Aseguramiento, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@EAPB", EAPB, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@ProyectoViv", ProyectoViv, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@RemitidoP", RemitidoP, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Calificacion", Calificacion, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@IRH", IRH, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Observaciones", Observaciones, SqlDbType.VarChar, False, 300)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Aplicativo", Aplicativo, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Escaner", Escaner, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)

        Dim Id_Indiv As Integer = clsBitacora.Insert("dbo.spInsertViolenciaIndividual", coleccionParametros, HttpContext.Current.Session, 2005377, True)

        If Id_Indiv <= 0 Then
            Throw New Exception(clsBitacora.MsgError & " Insertando Violencia Individual")
        Else
            _Id_Individual = Id_Indiv
        End If
        Return Id_Indiv
    End Function
    Public Function Actualizar() As Integer

        Dim Ds As New DataSet
        Dim Dr As DataRow = Nothing
        Dim coleccionParametros As New Collection
        Dim parametro As New CmdParametro("@Id_Individual", Id_Individual, SqlDbType.Int, True)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@PuntoAtencion", PuntoAtencion, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@FechaApert", FechaApert, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@TipoDoc", TipoDoc, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@NumDoc", NumDoc, SqlDbType.VarChar, False, 16)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@PrimerNombre", PrimerNombre, SqlDbType.VarChar, False, 60)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@SegundoNombre", SegundoNombre, SqlDbType.VarChar, False, 60)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@PrimerApellido", PrimerApellido, SqlDbType.VarChar, False, 60)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@SegundoApellido", SegundoApellido, SqlDbType.VarChar, False, 60)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Telefono", Telefono, SqlDbType.VarChar, False, 16)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Genero", Genero, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@CicloVit", CicloVit, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@PertEtnica", PertEtnica, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@AreaRural", AreaRural, SqlDbType.Bit, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@DireccionPCO", DireccionPCO, SqlDbType.VarChar, False, 60)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@LocalidadPCO", LocalidadPCO, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Barrio", Barrio, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@NombreUpz", NombreUpz, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Terrorista", Terrorista, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Amenaza", Amenaza, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Delitos", Delitos, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Desaparicion", Desaparicion, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Desplazamiento", Desplazamiento, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Homicidio", Homicidio, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Masacre", Masacre, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Minas", Minas, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Secuestro", Secuestro, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Tortura", Tortura, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Vinculación", Vinculación, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Abandono", Abandono, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Profesional", Profesional, SqlDbType.VarChar, False, 60)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Nivel", Nivel, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("OrientacionTemat", OrientacionTemat, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Acercamiento", Acercamiento, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Seguimiento2", Seguimiento2, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Seguimiento3", Seguimiento3, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Seguimiento4", Seguimiento4, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Seguimiento5", Seguimiento5, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Seguimiento6", Seguimiento6, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Seguimiento7", Seguimiento7, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Seguimiento8", Seguimiento8, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Cierre", Cierre, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@SF_Seguimiento1", SF_Seguimiento1, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@SF_Seguimiento2", SF_Seguimiento2, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@SF_Seguimiento3", SF_Seguimiento3, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@SF_Seguimiento4", SF_Seguimiento4, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@SF_Seguimiento5", SF_Seguimiento5, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Gestion1", Gestion1, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Gestion2", Gestion2, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Gestion3", Gestion3, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Gestion4", Gestion4, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Gestion5", Gestion5, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Gestion6", Gestion6, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Gestion7", Gestion7, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Gestion8", Gestion8, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Gestion9", Gestion9, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Gestion10", Gestion10, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Derivacion1", Derivacion1, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Derivacion2", Derivacion2, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Derivacion3", Derivacion3, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Derivacion4", Derivacion4, SqlDbType.DateTime, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@NivEfec", NivEfec, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@MotivoCier", MotivoCier, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Aseguramiento", Aseguramiento, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@EAPB", EAPB, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@ProyectoViv", ProyectoViv, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@RemitidoP", RemitidoP, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Calificacion", Calificacion, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@IRH", IRH, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Observaciones", Observaciones, SqlDbType.VarChar, False, 300)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Aplicativo", Aplicativo, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)
        parametro = New CmdParametro("@Escaner", Escaner, SqlDbType.Int, False)
        coleccionParametros.Add(parametro)

        Dim Id_Indiv As Integer = clsBitacora.Update("[app].[spViolenciaIndividualUpdate]", coleccionParametros, HttpContext.Current.Session, 2490, True)
        If Id_Indiv <> 0 Then
            Throw New Exception(clsBitacora.MsgError & " Actualizando Violencia Individual")
        End If
        Return Id_Indiv
    End Function
#End Region
End Class