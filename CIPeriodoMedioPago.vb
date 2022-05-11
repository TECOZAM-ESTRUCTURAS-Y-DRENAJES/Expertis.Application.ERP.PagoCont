Public Class CIPeriodoMedioPago

    Protected mFechaDesde As Date
    Protected mFechaHasta As Date


#Region " Carga del formulario "

    Protected Overridable Sub CIPeriodoMedioPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadEnums()
            LoadGridActions()
            CargarComboAnios()
        End If
    End Sub

    Protected Overridable Sub LoadEnums()
        EnumData.PopulateValueList("enumPagoSituacion", Grid.Columns("Situacion"))
    End Sub

    Protected Overridable Sub LoadGridActions()
        Me.Grid.Actions.Add("Abrir Proveedor", AddressOf AccionAbrirProveedor, ExpertisApp.GetIcon("xProveedores.ico"))
        Me.Grid.Actions.Add("Abrir Factura", AddressOf AccionAbrirFactura, ExpertisApp.GetIcon("xFacturaCompra.ico"))
    End Sub

    Protected Overridable Sub CargarComboAnios()
        Dim anyoActual As String = Today.Date.Year
        Dim dt As New DataTable
        dt.Columns.Add("Año")

        For i As Integer = 0 To 4
            Dim dr As DataRow = dt.NewRow()
            dr("Año") = anyoActual - i
            dt.Rows.Add(dr)
        Next
        cboAnio.DataSource = dt
        cboAnio.ValueMember = "Año"
    End Sub

#End Region

#Region " Acciones del grid "

    Protected Overridable Sub AccionAbrirProveedor()
        If Length(Me.Grid.GetValue("IDProveedor")) > 0 Then
            Dim strAlias As String = "MPROV"
            If ExpertisApp.IsFormOpen(strAlias) Then ExpertisApp.CloseForm(strAlias)
            ExpertisApp.OpenForm(strAlias, New FilterItem("IDProveedor", FilterOperator.Equal, Me.Grid.GetValue("IDProveedor")))
        End If
    End Sub

    Protected Overridable Sub AccionAbrirFactura()
        If Nz(Me.Grid.GetValue("IDFactura"), 0) <> 0 Then
            Dim strAlias As String = "MFACC"
            If ExpertisApp.IsFormOpen(strAlias) Then ExpertisApp.CloseForm(strAlias)
            ExpertisApp.OpenForm(strAlias, New FilterItem("IDFactura", FilterOperator.Equal, Me.Grid.GetValue("IDFactura")))
        End If
    End Sub

#End Region


#Region " Consulta "

    Protected Overridable Sub CIPeriodoMedioPago_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles Me.QueryExecuting
        CrearFiltroBusqueda(e)
        ValidarFechasVacias(e)
    End Sub

    Protected Overridable Sub CIPeriodoMedioPago_QueryExecuted(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutedEventArgs) Handles Me.QueryExecuted
        Dim sumImpVencimientoARealizados As Double
        Dim sumImpVencimientoAPendientes1 As Double
        Dim sumImpVencimientoAPendientes2 As Double
        Dim sumImpPonderado As Double
        Dim sumImpPonderado1 As Double
        Dim sumImpPonderado2 As Double
        Dim totalPagosRealizados As Double

        Dim totalPagosPendientes1 As Double
        Dim totalPagosPendientes2 As Double


        Dim dtResultadoConsulta As DataTable = Me.Grid.DataSource
        If Not dtResultadoConsulta Is Nothing AndAlso dtResultadoConsulta.Rows.Count > 0 Then
            For Each drProveedor As DataRow In dtResultadoConsulta.Rows
                If Not drProveedor("FechaPago") Is DBNull.Value Then
                    totalPagosRealizados = totalPagosRealizados + 1
                    If drProveedor("FechaPago") <= mFechaHasta Then       'FECHAPAGO <= FECHAHASTA => FECHAPAGO - FECHAFACTURA
                        'Plazo
                        Dim plazoDias As Integer = DateDiff(DateInterval.Day, drProveedor("FechaFactura"), drProveedor("FechaPago"))
                        drProveedor("Plazo") = plazoDias
                        'Importe ponderado
                        Dim impPonderado As Double = drProveedor("ImpVencimientoA") * drProveedor("Plazo")
                        drProveedor("ImportePonderado") = impPonderado
                        'Total Pagos Realizados
                        sumImpVencimientoARealizados = sumImpVencimientoARealizados + drProveedor("ImpVencimientoA")
                        sumImpPonderado = sumImpPonderado + drProveedor("ImportePonderado")
                    ElseIf drProveedor("FechaPago") > mFechaHasta Then   'FECHAPAGO > FECHAHASTA => FECHAHASTA - FECHAFACTURA
                        totalPagosPendientes1 = totalPagosPendientes1 + 1
                        Dim plazoDias As Integer = DateDiff(DateInterval.Day, drProveedor("FechaFactura"), mFechaHasta)
                        drProveedor("Plazo") = plazoDias
                        'drProveedor("FechaPago") = mFechaHasta
                        'Importe ponderado
                        Dim impPonderado As Double = drProveedor("ImpVencimientoA") * drProveedor("Plazo")
                        drProveedor("ImportePonderado") = impPonderado
                        'Total Pagos Pendientes
                        sumImpVencimientoAPendientes1 = sumImpVencimientoAPendientes1 + drProveedor("ImpVencimientoA")
                        If Not drProveedor("ImportePonderado") Is DBNull.Value Then
                            sumImpPonderado1 = sumImpPonderado1 + drProveedor("ImportePonderado")
                        End If
                    End If
                Else                                                                    'FECHAPAGO IS NULL => FECHAHASTA - FECHAFACTURA
                    totalPagosPendientes2 = totalPagosPendientes2 + 1
                    Dim intDias As Integer = DateDiff(DateInterval.Day, drProveedor("FechaFactura"), mFechaHasta)
                    drProveedor("Plazo") = intDias
                    'drProveedor("FechaPago") = mFechaHasta
                    'Importe ponderado
                    Dim impPonderado As Double = drProveedor("ImpVencimientoA") * drProveedor("Plazo")
                    drProveedor("ImportePonderado") = impPonderado
                    'Total Pagos Pendientes => SUM DE IMPORTEVENCIMIENTOA
                    sumImpVencimientoAPendientes2 = sumImpVencimientoAPendientes2 + drProveedor("ImpVencimientoA")
                    If Not drProveedor("ImportePonderado") Is DBNull.Value Then
                        sumImpPonderado2 = sumImpPonderado2 + drProveedor("ImportePonderado")
                    End If
                End If
            Next drProveedor

            'Total de Pagos Realizados
            txtTotalPagosRealizados.Text = sumImpVencimientoARealizados

            'Total de Pagos Pendientes
            Dim totalSumImpVencimientoAPendientes As Double = sumImpVencimientoAPendientes1 + sumImpVencimientoAPendientes2
            txtTotalPagosPendientes.Text = totalSumImpVencimientoAPendientes

            'Ratio de Operaciones Pagadas
            Dim ratioOperacionesPagadas As Double = 0
            If sumImpVencimientoARealizados <> 0 Then
                ratioOperacionesPagadas = sumImpPonderado / sumImpVencimientoARealizados
                txtRatioOperacionesPagadas.Text = ratioOperacionesPagadas
            End If

            'Ratio de Operaciones Pendientes
            Dim ratioOperacionesPendientes As Double = 0
            If totalSumImpVencimientoAPendientes <> 0 Then
                Dim totalSumImpPonderado As Double = sumImpPonderado1 + sumImpPonderado2
                ratioOperacionesPendientes = totalSumImpPonderado / totalSumImpVencimientoAPendientes
                txtRatioOperacionesPendientes.Text = ratioOperacionesPendientes
            End If

            'Periodo Medio de Pago
            Dim productoRatios As Double = (ratioOperacionesPagadas * sumImpVencimientoARealizados) + (ratioOperacionesPendientes * totalSumImpVencimientoAPendientes)
            Dim sumaVencimientos As Double = sumImpVencimientoARealizados + totalSumImpVencimientoAPendientes
            Dim periodoMedioPago As Double = 0
            If sumaVencimientos <> 0 Then
                periodoMedioPago = productoRatios / sumaVencimientos
            End If
            txtPeriodoMedioPago.Text = periodoMedioPago
        End If
    End Sub

    Protected Overridable Sub CrearFiltroBusqueda(ByRef e As Engine.UI.QueryExecutingEventArgs)
        e.Filter.Add("FechaFactura", FilterOperator.GreaterThanOrEqual, mFechaDesde)
        e.Filter.Add("FechaFactura", FilterOperator.LessThanOrEqual, mFechaHasta)
        e.Filter.Add("IDTipoProveedor", FilterOperator.Equal, advIDTipoProveedor.Value)
    End Sub

    Protected Overridable Sub ValidarFechasVacias(ByRef e As Engine.UI.QueryExecutingEventArgs)
        If mFechaDesde = cnMinDate OrElse mFechaHasta = cnMinDate Then
            e.Cancel = True
            ExpertisApp.GenerateMessage("Debe introducir el Año a filtrar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

#End Region


#Region " Otros controles "

    Private Sub cboAnio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnio.ValueChanged
        If Length(cboAnio.Value) > 0 Then
            Dim anyo As String = cboAnio.Value
            mFechaDesde = New Date(anyo, 1, 1)
            mFechaHasta = New Date(anyo, 12, 31)
        Else
            mFechaDesde = cnMinDate
            mFechaHasta = cnMinDate
        End If
    End Sub

#End Region

End Class
