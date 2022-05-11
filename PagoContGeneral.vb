Imports Solmicro.Expertis.Business.Negocio

Public Module PagoContGeneral

    Public Enum IconIndex
        NoContabilizado = 0
        Contabilizado = 1
    End Enum

    Public mIDProcess As System.Guid

    Public Sub GenerarFicheroTransferencia(ByVal intTipoFichero As enumFichRemesaPago, _
                                               ByVal strIDBancoPropio As String, ByVal strRuta As String, _
                                               Optional ByVal DteFechaEmision As Date = cnMinDate, Optional ByVal TipoFichero As enumFormatoFicheroSEPA = enumFormatoFicheroSEPA.XML)
        Dim DtFichero As New DataTable

        Dim data As New GenerarFicheros.DataFicheros
        data.IDProcess = mIDProcess
        data.IDBancoPropio = strIDBancoPropio
        data.TipoFichero = enumTipoFicheroTrans.tftPago


        Select Case intTipoFichero
            Case enumFichRemesaPago.CSB34, enumFichRemesaPago.Confirming
                Dim srtTipoTrans As String = String.Empty
                Dim blnConfirming As Boolean

                Dim bp As New BancoPropio
                Dim dtBP As DataTable = bp.SelOnPrimaryKey(strIDBancoPropio)
                If Not IsNothing(dtBP) AndAlso dtBP.Rows.Count > 0 Then
                    If Length(dtBP.Rows(0)("TipoTrans")) > 0 Then
                        srtTipoTrans = dtBP.Rows(0)("TipoTrans")
                        srtTipoTrans = srtTipoTrans.ToUpper
                    End If
                    blnConfirming = dtBP.Rows(0)("Confirming")
                End If
                ' If cboTipoFicheroTransf.Value = enumFormatoFicheroSEPA.Plano Then

                If intTipoFichero = enumFichRemesaPago.CSB34 Then

                    If srtTipoTrans = "A" Then
                        data.FechaEmision = DteFechaEmision
                        DtFichero = ExpertisApp.ExecuteTask(Of GenerarFicheros.DataFicheros, DataTable)(AddressOf GenerarFicheros.GenerarFicheroTransferenciaA, data)
                    ElseIf srtTipoTrans = "B" Then
                        data.Fichero = strRuta
                        DtFichero = ExpertisApp.ExecuteTask(Of GenerarFicheros.DataFicheros, DataTable)(AddressOf GenerarFicheros.GenerarFicheroTransferenciaB, data)
                    ElseIf srtTipoTrans = "C" Then
                        data.FechaEmision = DteFechaEmision
                        DtFichero = ExpertisApp.ExecuteTask(Of GenerarFicheros.DataFicheros, DataTable)(AddressOf GenerarFicheros.GenerarFicheroTransferenciaC, data)
                    Else
                        data.FechaEmision = DteFechaEmision
                        DtFichero = ExpertisApp.ExecuteTask(Of GenerarFicheros.DataFicheros, DataTable)(AddressOf GenerarFicheros.GenerarFicheroTransferencia, data)
                    End If
                ElseIf intTipoFichero = enumFichRemesaPago.Confirming Then
                    If Not blnConfirming Then
                        ExpertisApp.GenerateMessage("Este banco  no admite Confirming", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        DtFichero = ExpertisApp.ExecuteTask(Of GenerarFicheros.DataFicheros, DataTable)(AddressOf GenerarFicheros.GenerarFicheroConfirming, data)
                    End If
                End If
            Case enumFichRemesaPago.CSB341
                data.FechaEmision = DteFechaEmision
                DtFichero = ExpertisApp.ExecuteTask(Of GenerarFicheros.DataFicheros, DataTable)(AddressOf GenerarFicheros.GenerarFichero341, data)
            Case enumFichRemesaPago.CSB68
                DtFichero = ExpertisApp.ExecuteTask(Of GenerarFicheros.DataFicheros, DataTable)(AddressOf GenerarFicheros.GenerarFichero68, data)
            Case Business.SEPA.BusinessEnum.enumFichRemesaPago.CSB3414
                If TipoFichero = enumFormatoFicheroSEPA.Plano Then
                    DtFichero.Columns.Add("Linea", GetType(String))
                    Dim datFich As New DataGenerarFichero
                    datFich.IDProcess = mIDProcess
                    datFich.IDBancoPropio = strIDBancoPropio
                    datFich.FechaEmision = DteFechaEmision
                    Dim lstRegsFich As List(Of String) = ExpertisApp.ExecuteTask(Of DataGenerarFichero, List(Of String))(AddressOf FicheroCSB34_14.GenerarFichero, datFich)
                    For Each Registro As String In lstRegsFich
                        Dim drNew As DataRow = DtFichero.NewRow
                        drNew("Linea") = Registro
                        DtFichero.Rows.Add(drNew)
                    Next
                Else
                    Dim datFich As New DataGenerarFichero
                    datFich.IDProcess = mIDProcess
                    datFich.IDBancoPropio = strIDBancoPropio
                    datFich.FechaEmision = DteFechaEmision

                    Dim lstRegsFich As Byte()
                    lstRegsFich = ExpertisApp.ExecuteTask(Of DataGenerarFichero, Byte())(AddressOf Fichero_PAIN_001_001_03.GenerarFichero, datFich)


                    If Not lstRegsFich Is Nothing AndAlso lstRegsFich.Length > 0 AndAlso General.GuardarFicheroXML(lstRegsFich, strRuta, -1, datFich.FechaCargo, True) Then
                        ExpertisApp.GenerateMessage("Fichero generado.", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
                        Exit Sub
                    End If

                End If
        End Select

        If Not IsNothing(DtFichero) Then
            If GuardarFichero(strRuta, DtFichero) Then
                If intTipoFichero = enumFichRemesaPago.CSB68 Then
                    ExpertisApp.GenerateMessage("Generado con exito el fichero de Pagos Certificados.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ExpertisApp.GenerateMessage("Generado con éxito el fichero de Transferencias.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Public Function GuardarFichero(ByVal StrRuta As String, ByVal DtFichero As DataTable) As Boolean
        If Len(StrRuta) > 0 Then
            Dim IntPos As Integer = 1
            Dim IntPosPar As Integer = Strings.InStr(IntPos, StrRuta, "\")
            While IntPosPar <> 0
                IntPos = IntPosPar + 1
                IntPosPar = InStr(IntPos, StrRuta, "\")
            End While
            Dim StrRutaFinal As String = Strings.Left(StrRuta, IntPos - 2)
            If IO.Directory.Exists(StrRutaFinal) Then
                If IO.File.Exists(StrRuta) Then IO.File.Delete(StrRuta)
                Dim FichDest As New IO.StreamWriter(StrRuta, False)
                For Each Dr As DataRow In DtFichero.Select
                    FichDest.WriteLine(Dr("Linea"))
                Next
                FichDest.Close()
                Return True
            Else
                ExpertisApp.GenerateMessage("La ruta | no existe. Debe crear la ruta para generar el fichero.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, StrRuta)
            End If
        Else
            ExpertisApp.GenerateMessage("La ruta | no existe. Debe crear la ruta para generar el fichero.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, StrRuta)
        End If
    End Function


    Public Function ValidarRiesgoProveedor(ByVal dtPagos As DataTable) As Boolean
        ValidarRiesgoProveedor = True
        Dim Proveedores As List(Of Object) = (From c In dtPagos Where Length(c("IDProveedor")) > 0 Select c("IDProveedor") Distinct).ToList
        If Not Proveedores Is Nothing AndAlso Proveedores.Count > 0 Then
            Dim IDProvRiesgo(-1) As String
            Dim BEDataEngine As New BE.DataEngine
            For Each IDProveedor As String In Proveedores
                Dim dtEnRiesgo As DataTable = BEDataEngine.Filter("vProveedorCobrosEnRiesgo", New StringFilterItem("IDProveedorAsociado", IDProveedor))
                If dtEnRiesgo.Rows.Count > 0 Then
                    ReDim Preserve IDProvRiesgo(IDProvRiesgo.Length)
                    IDProvRiesgo(IDProvRiesgo.Length - 1) = IDProveedor
                End If
            Next

            If IDProvRiesgo.Length > 0 Then
                Dim strProveedores As String = Strings.Join(IDProvRiesgo, ",")
                ValidarRiesgoProveedor = (ExpertisApp.GenerateMessage("Algunos proveedores seleccionados tienen cobros pendientes: {0}{1}{2}¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, vbNewLine, strProveedores, vbNewLine) = Windows.Forms.DialogResult.Yes)
            End If
        End If
    End Function


    'Public Function PagosImporteNegativo(ByVal dtPagos As DataTable) As Boolean
    '    If Not dtPagos Is Nothing Then
    '        Dim VtosNegativos As List(Of DataRow) = (From v In dtPagos Where v("ImpVencimientoA") < 0 Select v).ToList
    '        If Not VtosNegativos Is Nothing AndAlso VtosNegativos.Count > 0 Then
    '            ExpertisApp.GenerateMessage("No se puede crear el fichero. Ha seleccionado vencimientos con importes negativos.", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Return True
    '        End If
    '    End If
    'End Function

End Module
