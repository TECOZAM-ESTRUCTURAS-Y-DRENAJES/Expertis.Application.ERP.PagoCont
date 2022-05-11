Imports Solmicro.Expertis.Business.General
Imports Solmicro.Expertis.Business.Negocio

Public Class CIRemesaPago
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.ExecuteActions.Visible = Janus.Windows.UI.InheritableBoolean.False

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents fwiFRemesaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblfwiFRemesaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiRemesaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiFRemesaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblfwiFRemesaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiRemesaHasta As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblfwiRemesaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiRemesaDesde As Solmicro.Expertis.Engine.UI.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIRemesaPago))
        Me.fwiFRemesaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblfwiFRemesaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiRemesaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFRemesaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblfwiFRemesaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiRemesaHasta = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiRemesaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiRemesaDesde = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.fwiRemesaDesde)
        Me.FilterPanel.Controls.Add(Me.lblfwiFRemesaDesde)
        Me.FilterPanel.Controls.Add(Me.lblfwiRemesaDesde)
        Me.FilterPanel.Controls.Add(Me.lblfwiFRemesaHasta)
        Me.FilterPanel.Controls.Add(Me.lblfwiRemesaHasta)
        Me.FilterPanel.Controls.Add(Me.fwiFRemesaDesde)
        Me.FilterPanel.Controls.Add(Me.fwiFRemesaHasta)
        Me.FilterPanel.Controls.Add(Me.fwiRemesaHasta)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 349)
        Me.FilterPanel.Size = New System.Drawing.Size(688, 72)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(688, 349)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "Pago"
        Me.Grid.Hierarchical = True
        Me.Grid.KeyField = "IDRemesa"
        Me.Grid.Size = New System.Drawing.Size(688, 349)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "vCIRemesaPago"
        '
        'CheckAll
        '
        Me.CheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'UncheckAll
        '
        Me.UncheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'ClearFilter
        '
        Me.ClearFilter.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Export
        '
        Me.Export.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(245, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(688, 421)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(688, 421)
        '
        'fwiFRemesaDesde
        '
        Me.fwiFRemesaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFRemesaDesde.Location = New System.Drawing.Point(573, 21)
        Me.fwiFRemesaDesde.Name = "fwiFRemesaDesde"
        Me.fwiFRemesaDesde.Size = New System.Drawing.Size(85, 21)
        Me.fwiFRemesaDesde.TabIndex = 2
        '
        'lblfwiFRemesaDesde
        '
        Me.lblfwiFRemesaDesde.Location = New System.Drawing.Point(466, 21)
        Me.lblfwiFRemesaDesde.Name = "lblfwiFRemesaDesde"
        Me.lblfwiFRemesaDesde.Size = New System.Drawing.Size(103, 13)
        Me.lblfwiFRemesaDesde.TabIndex = 0
        Me.lblfwiFRemesaDesde.Tag = "IdRec=8153;"
        Me.lblfwiFRemesaDesde.Text = "Fecha Remesa >"
        '
        'lblfwiRemesaDesde
        '
        Me.lblfwiRemesaDesde.Location = New System.Drawing.Point(19, 21)
        Me.lblfwiRemesaDesde.Name = "lblfwiRemesaDesde"
        Me.lblfwiRemesaDesde.Size = New System.Drawing.Size(75, 13)
        Me.lblfwiRemesaDesde.TabIndex = 3
        Me.lblfwiRemesaDesde.Tag = "IdRec=4746;"
        Me.lblfwiRemesaDesde.Text = "Remesa >="
        '
        'fwiFRemesaHasta
        '
        Me.fwiFRemesaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFRemesaHasta.Location = New System.Drawing.Point(573, 46)
        Me.fwiFRemesaHasta.Name = "fwiFRemesaHasta"
        Me.fwiFRemesaHasta.Size = New System.Drawing.Size(85, 21)
        Me.fwiFRemesaHasta.TabIndex = 3
        '
        'lblfwiFRemesaHasta
        '
        Me.lblfwiFRemesaHasta.Location = New System.Drawing.Point(466, 46)
        Me.lblfwiFRemesaHasta.Name = "lblfwiFRemesaHasta"
        Me.lblfwiFRemesaHasta.Size = New System.Drawing.Size(103, 13)
        Me.lblfwiFRemesaHasta.TabIndex = 4
        Me.lblfwiFRemesaHasta.Tag = "IdRec=4747;"
        Me.lblfwiFRemesaHasta.Text = "Fecha Remesa <"
        '
        'fwiRemesaHasta
        '
        Me.fwiRemesaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.fwiRemesaHasta.Location = New System.Drawing.Point(96, 46)
        Me.fwiRemesaHasta.Name = "fwiRemesaHasta"
        Me.fwiRemesaHasta.Size = New System.Drawing.Size(87, 21)
        Me.fwiRemesaHasta.TabIndex = 1
        '
        'lblfwiRemesaHasta
        '
        Me.lblfwiRemesaHasta.Location = New System.Drawing.Point(19, 46)
        Me.lblfwiRemesaHasta.Name = "lblfwiRemesaHasta"
        Me.lblfwiRemesaHasta.Size = New System.Drawing.Size(75, 13)
        Me.lblfwiRemesaHasta.TabIndex = 5
        Me.lblfwiRemesaHasta.Tag = "IdRec=5594;"
        Me.lblfwiRemesaHasta.Text = "Remesa <="
        '
        'fwiRemesaDesde
        '
        Me.fwiRemesaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.fwiRemesaDesde.Location = New System.Drawing.Point(96, 21)
        Me.fwiRemesaDesde.Name = "fwiRemesaDesde"
        Me.fwiRemesaDesde.Size = New System.Drawing.Size(87, 21)
        Me.fwiRemesaDesde.TabIndex = 6
        '
        'CIRemesaPago
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(696, 509)
        Me.EntityName = "Pago"
        Me.KeyField = "IDRemesa"
        Me.Name = "CIRemesaPago"
        Me.ViewName = "vCIRemesaPago"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Load "

    Private mblnContabilidadMultiple As Boolean


    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadERPData()
            LoadEnums()
            LoadGridActions()
            LoadParams()
        End If
    End Sub

    Private Sub LoadParams()
        If Not Me.Params Is Nothing Then
            Dim IDRemesa As Integer = Me.Params
            Me.fwiRemesaDesde.Text = IDRemesa
            Me.fwiRemesaHasta.Text = IDRemesa
            Me.Execute()
        End If
    End Sub

    Private Sub LoadERPData()
        mblnContabilidadMultiple = New Parametro().ContabilidadMultiple
    End Sub

    Private Sub LoadEnums()
        EnumData.PopulateValueList("enumFichRemesaPago", Grid.Columns("TipoFichero"))
    End Sub

    Private Sub LoadGridActions()
        With Grid
            '.Actions.Add("-", Nothing)
            .Actions.Add("Ver Remesa", AddressOf AccionVerRemesa)
            '.Actions.Add("-", Nothing)
            .Actions.Add("Borrar Remesa", AddressOf AccionDeleteRemesa)
            '.Actions.Add("-", Nothing)
            .Actions.Add("Modificar Remesa", AddressOf AccionUpdateRemesa)
            Dim blnContabilidad As Boolean = New Parametro().Contabilidad
            If blnContabilidad Then
                .Actions.Add("Ver Asiento Remesa", AddressOf AccionGridCargarAsientoEfectos)
                .Actions.Add("Eliminar Asiento de Remesa", AddressOf AccionGridEliminarAsientoEfectos)
            End If
        End With
    End Sub

#End Region

#Region " Acciones del Grid "

    Private Sub AccionVerRemesa()
        Dim frm As New frmVerRemesaPago
        frm.VerRemesa(Grid.Value("IDRemesa"), Grid.Value("FechaRemesa"), Me)
    End Sub

    Protected Overridable Sub AccionDeleteRemesa()
        If ExpertisApp.GenerateMessage("Va a eliminar la remesa de pago número {0}.¿Desea continuar?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, Grid.Value("IdRemesa")) = DialogResult.OK Then
            Dim rp As New RemesaPago
            Dim dtRemesa As DataTable = rp.SelOnPrimaryKey(Grid.Value("IdRemesa"))
            rp.Delete(dtRemesa)
            Me.Execute()
        End If
    End Sub

    Private Sub AccionUpdateRemesa()
        Dim dtPagos As DataTable = New Pago().Filter(New NumberFilterItem("IdRemesa", Grid.Value("IdRemesa")))

        Dim i As Integer = 0
        Dim htIDEnlace As New Hashtable
        For Each drPagos As DataRow In dtPagos.Rows
            htIDEnlace("IDEnlace" & i) = drPagos("IdPago")
            i = i + 1
        Next
        mIDProcess = MarcarRegistro(htIDEnlace, FilterType.Numeric)

        If Not ValidarRiesgoProveedor(dtPagos) Then Exit Sub

        Dim frm As New frmRemesaPago
        frm.AbrirRemesa(Me, Grid.Value("IdRemesa"))

        DesmarcarRegistro(mIDProcess, FilterType.Numeric)
        Me.Execute()
    End Sub


#End Region

    Private Sub fwiRemesaDesde_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiRemesaDesde.Validated
        fwiRemesaHasta.Text = fwiRemesaDesde.Text
    End Sub

    Private Sub fwiFRemesaDesde_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiFRemesaDesde.Validated
        fwiFRemesaHasta.Value = fwiFRemesaDesde.Value
    End Sub

    Private Sub CIRemesaPago_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDRemesa", FilterOperator.GreaterThanOrEqual, fwiRemesaDesde.Text, FilterType.Numeric)
        e.Filter.Add("IDRemesa", FilterOperator.LessThanOrEqual, fwiRemesaHasta.Text, FilterType.Numeric)
        e.Filter.Add("FechaRemesa", FilterOperator.GreaterThanOrEqual, fwiFRemesaDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaRemesa", FilterOperator.LessThanOrEqual, fwiFRemesaHasta.Value, FilterType.DateTime)
    End Sub
    Private Sub ComprobarAsientos(ByVal dtPagos As DataTable, _
                            ByVal pTipoAsiento As enumDiarioTipoApunte, _
                            ByRef outDT_NAsientos As DataTable, _
                            ByRef outDT_Asientos As DataTable)

        Dim IDEjercicioTributario As String
        Dim dteFecha As Date = Nz(Grid.Value("FechaRemesa"), Today)
        Dim strEjercicio As String = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, dteFecha)
        If mblnContabilidadMultiple AndAlso Length(strEjercicio) > 0 Then
            Dim dtEjercicio As DataTable = New EjercicioContable().SelOnPrimaryKey(strEjercicio)
            If dtEjercicio.Rows.Count > 0 Then
                IDEjercicioTributario = dtEjercicio.Rows(0)("IDEjercicioTributario")
            End If
        End If
        If Not IsNothing(dtPagos) AndAlso dtPagos.Rows.Count > 0 Then
            Dim fEjercicio As New Filter(FilterUnionOperator.Or)
            If Length(strEjercicio) > 0 Then fEjercicio.Add(New StringFilterItem("IDEjercicio", strEjercicio))
            If Length(IDEjercicioTributario) > 0 Then fEjercicio.Add(New StringFilterItem("IDEjercicio", IDEjercicioTributario))

            Dim BEDataEngine As DataEngine = New DataEngine

            Dim objFilter As New Filter
            objFilter.Add(New NumberFilterItem("IDTipoApunte", pTipoAsiento))
            objFilter.Add(New StringFilterItem("NDocumento", dtPagos.Rows(0)("IDRemesa")))
            If fEjercicio.Count > 0 Then objFilter.Add(fEjercicio)

            If pTipoAsiento = enumDiarioTipoApunte.Remesa AndAlso Length(dtPagos.Rows(0)("IDPago")) > 0 Then
                objFilter.Add(New NumberFilterItem("IDDocumento", dtPagos.Rows(0)("IDPago")))
            End If
            Dim strWhere As String = objFilter.Compose(New AdoFilterComposer) & " Group By NAsiento, IdEjercicio"
            outDT_NAsientos = BEDataEngine.Filter("tbDiarioContable", "NAsiento, IdEjercicio", strWhere)


            Dim strListaPago(outDT_NAsientos.Rows.Count - 1) As String
            For i As Integer = 0 To outDT_NAsientos.Rows.Count - 1
                strListaPago(i) = outDT_NAsientos.Rows(i)("NAsiento")
            Next i

            If strListaPago.Length > 0 Then
                Dim f As New Filter
                f.Add(New InListFilterItem("NAsiento", strListaPago, FilterType.Numeric))
                f.Add(New NumberFilterItem("IdTipoApunte", pTipoAsiento))
                'f.Add(New StringFilterItem("IDEjercicio", strEjercicio))
                If fEjercicio.Count > 0 Then f.Add(fEjercicio)

                outDT_Asientos = BEDataEngine.Filter("tbDiarioContable", f)
            End If
        End If
    End Sub
    Private Sub AccionGridCargarAsientoEfectos()
        Dim objNegPago As New Pago
        Dim objFilter As New Filter
        Dim dtAsientos As New DataTable
        Dim dtNAsientos As New DataTable

        objFilter.Add(New FilterItem("IDRemesa", FilterOperator.Equal, Grid.Value("IDRemesa")))
        Dim dtPago As DataTable = objNegPago.Filter(objFilter)
        objNegPago = Nothing

        ComprobarAsientos(dtPago, enumDiarioTipoApunte.RemesaPago, dtNAsientos, dtAsientos)

        Dim objfrmConsAsientoRemesa As New frmConsultaAsientoRemesa
        objfrmConsAsientoRemesa.IDRemesa = Grid.Value("IDRemesa")
        objfrmConsAsientoRemesa.TipoAsiento = enumDiarioTipoApunte.RemesaPago
        objfrmConsAsientoRemesa.Accion = frmConsultaAsientoRemesa.enumTipoAccion.Consulta
        objfrmConsAsientoRemesa.Asientos = dtAsientos
        objfrmConsAsientoRemesa.NAsientos = dtNAsientos
        objfrmConsAsientoRemesa.ShowDialog()
        objfrmConsAsientoRemesa = Nothing
    End Sub
    Private Sub AccionGridEliminarAsientoEfectos()
        Dim objNegPago As New Pago
        Dim dtPago As New DataTable
        Dim objFilter As New Filter
        Dim dtAsientos As New DataTable
        Dim dtNAsientos As New DataTable
        objFilter.Add(New NumberFilterItem("GeneradoAsientoRemesa", FilterOperator.NotEqual, enumContabilizado.NoContabilizado))
        objFilter.Add(New FilterItem("IDRemesa", FilterOperator.Equal, Grid.Value("IDRemesa")))
        dtPago = objNegPago.Filter(objFilter)
        Dim adrContabilizados() As DataRow = dtPago.Select("Contabilizado <> " & enumContabilizado.NoContabilizado)
        If Not adrContabilizados Is Nothing AndAlso adrContabilizados.Length > 0 Then
            ExpertisApp.GenerateMessage("No se puede descontabilizar el asiento de la remesa. Los pagos están contabilizados.")
            Exit Sub
        End If
        ComprobarAsientos(dtPago, enumDiarioTipoApunte.RemesaPago, dtNAsientos, dtAsientos)

        If Not IsNothing(dtNAsientos) AndAlso dtNAsientos.Rows.Count > 0 Then
            Dim objfrmConsAsientoRemesa As New frmConsultaAsientoRemesa
            objfrmConsAsientoRemesa.IDRemesa = Grid.Value(Grid.Columns("IDRemesa").Index)
            objfrmConsAsientoRemesa.TipoAsiento = enumDiarioTipoApunte.RemesaPago
            objfrmConsAsientoRemesa.Accion = frmConsultaAsientoRemesa.enumTipoAccion.Eliminacion
            objfrmConsAsientoRemesa.Asientos = dtAsientos
            objfrmConsAsientoRemesa.NAsientos = dtNAsientos
            objfrmConsAsientoRemesa.ShowDialog(Me)
            objfrmConsAsientoRemesa = Nothing
        End If
    End Sub

    Private Sub Grid_GetChildList(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.GetChildListEventArgs) Handles Grid.GetChildList
        If Length(e.ParentRow.Cells("IDRemesa").Value) > 0 Then
            Dim f As New Filter
            f.Add(New NumberFilterItem("IDRemesa", e.ParentRow.Cells("IDRemesa").Value))
            e.ChildList = New BE.DataEngine().Filter("frmPagos", f)
        Else
            e.ChildList = Nothing
        End If
    End Sub


    Private Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        If e.Row.RowType = Janus.Windows.GridEX.RowType.Record AndAlso Not e.Row.Parent Is Nothing Then
            If e.Row.Parent.GridEX.Name = "Grid" Then
                If e.Row.Cells("Contabilizado").Value <> enumContabilizado.NoContabilizado Then
                    e.Row.RowStyle = Grid.FormatStyles("ContabilizadoFormatStyle")
                    'e.Row.Cells("Contabilizado").ImageIndex = IconIndex.Contabilizado
                Else
                    'e.Row.Cells("Contabilizado").ImageIndex = IconIndex.NoContabilizado
                End If
            End If

        End If
    End Sub

End Class
