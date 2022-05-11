Public Class CIImpuestosDiferidos
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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
    Friend WithEvents FwIMarcados As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblFwIMarcados As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwIContabilizadoD As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblFwIContabilizadoD As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwIContabilizadoH As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblFwIContabilizadoH As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwIBancoPropio As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFwIBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwIDescInmovilizado As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblFwIDescInmovilizado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwIInmovilizado As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFwIInmovilizado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiIDPagoPeriodico As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblfwiIDPagoPeriodico As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim FwIMarcados_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIImpuestosDiferidos))
        Dim FwIContabilizadoD_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim FwIContabilizadoH_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.FwIMarcados = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblFwIMarcados = New Solmicro.Expertis.Engine.UI.Label
        Me.FwIContabilizadoD = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblFwIContabilizadoD = New Solmicro.Expertis.Engine.UI.Label
        Me.FwIContabilizadoH = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblFwIContabilizadoH = New Solmicro.Expertis.Engine.UI.Label
        Me.FwIBancoPropio = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFwIBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.FwIDescInmovilizado = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFwIDescInmovilizado = New Solmicro.Expertis.Engine.UI.Label
        Me.FwIInmovilizado = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFwIInmovilizado = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiIDPagoPeriodico = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiIDPagoPeriodico = New Solmicro.Expertis.Engine.UI.Label
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.FwIMarcados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FwIContabilizadoD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FwIContabilizadoH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.lblFwIMarcados)
        Me.FilterPanel.Controls.Add(Me.FwIMarcados)
        Me.FilterPanel.Controls.Add(Me.lblFwIContabilizadoD)
        Me.FilterPanel.Controls.Add(Me.FwIContabilizadoD)
        Me.FilterPanel.Controls.Add(Me.lblFwIContabilizadoH)
        Me.FilterPanel.Controls.Add(Me.FwIContabilizadoH)
        Me.FilterPanel.Controls.Add(Me.lblFwIBancoPropio)
        Me.FilterPanel.Controls.Add(Me.FwIBancoPropio)
        Me.FilterPanel.Controls.Add(Me.lblFwIDescInmovilizado)
        Me.FilterPanel.Controls.Add(Me.FwIDescInmovilizado)
        Me.FilterPanel.Controls.Add(Me.lblFwIInmovilizado)
        Me.FilterPanel.Controls.Add(Me.FwIInmovilizado)
        Me.FilterPanel.Controls.Add(Me.lblfwiIDPagoPeriodico)
        Me.FilterPanel.Controls.Add(Me.fwiIDPagoPeriodico)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 270)
        Me.FilterPanel.Size = New System.Drawing.Size(690, 101)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(690, 270)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "PagoPeriodico"
        Me.Grid.KeyField = "Id"
        Me.Grid.Size = New System.Drawing.Size(690, 270)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "VCtlCiImpuestosDiferidos"
        '
        'CheckAll
        '
        Me.CheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.CheckAll.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'UncheckAll
        '
        Me.UncheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.UncheckAll.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.ShowAllCheckedItems.Visible = Janus.Windows.UI.InheritableBoolean.[True]
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
        Me.Toolbar.Size = New System.Drawing.Size(320, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(690, 371)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(690, 371)
        '
        'FwIMarcados
        '
        FwIMarcados_DesignTimeLayout.LayoutString = resources.GetString("FwIMarcados_DesignTimeLayout.LayoutString")
        Me.FwIMarcados.DesignTimeLayout = FwIMarcados_DesignTimeLayout
        Me.FwIMarcados.DisabledBackColor = System.Drawing.Color.White
        Me.FwIMarcados.Location = New System.Drawing.Point(624, 72)
        Me.FwIMarcados.Name = "FwIMarcados"
        Me.FwIMarcados.SelectedIndex = -1
        Me.FwIMarcados.SelectedItem = Nothing
        Me.FwIMarcados.Size = New System.Drawing.Size(60, 21)
        Me.FwIMarcados.TabIndex = 8
        '
        'lblFwIMarcados
        '
        Me.lblFwIMarcados.Location = New System.Drawing.Point(468, 72)
        Me.lblFwIMarcados.Name = "lblFwIMarcados"
        Me.lblFwIMarcados.Size = New System.Drawing.Size(118, 13)
        Me.lblFwIMarcados.TabIndex = 0
        Me.lblFwIMarcados.Text = "Registros Marcados"
        '
        'FwIContabilizadoD
        '
        FwIContabilizadoD_DesignTimeLayout.LayoutString = resources.GetString("FwIContabilizadoD_DesignTimeLayout.LayoutString")
        Me.FwIContabilizadoD.DesignTimeLayout = FwIContabilizadoD_DesignTimeLayout
        Me.FwIContabilizadoD.DisabledBackColor = System.Drawing.Color.White
        Me.FwIContabilizadoD.Location = New System.Drawing.Point(624, 21)
        Me.FwIContabilizadoD.Name = "FwIContabilizadoD"
        Me.FwIContabilizadoD.SelectedIndex = -1
        Me.FwIContabilizadoD.SelectedItem = Nothing
        Me.FwIContabilizadoD.Size = New System.Drawing.Size(60, 21)
        Me.FwIContabilizadoD.TabIndex = 6
        '
        'lblFwIContabilizadoD
        '
        Me.lblFwIContabilizadoD.Location = New System.Drawing.Point(468, 21)
        Me.lblFwIContabilizadoD.Name = "lblFwIContabilizadoD"
        Me.lblFwIContabilizadoD.Size = New System.Drawing.Size(150, 13)
        Me.lblFwIContabilizadoD.TabIndex = 9
        Me.lblFwIContabilizadoD.Text = "Año Contabilizado Desde"
        '
        'FwIContabilizadoH
        '
        FwIContabilizadoH_DesignTimeLayout.LayoutString = resources.GetString("FwIContabilizadoH_DesignTimeLayout.LayoutString")
        Me.FwIContabilizadoH.DesignTimeLayout = FwIContabilizadoH_DesignTimeLayout
        Me.FwIContabilizadoH.DisabledBackColor = System.Drawing.Color.White
        Me.FwIContabilizadoH.Location = New System.Drawing.Point(624, 47)
        Me.FwIContabilizadoH.Name = "FwIContabilizadoH"
        Me.FwIContabilizadoH.SelectedIndex = -1
        Me.FwIContabilizadoH.SelectedItem = Nothing
        Me.FwIContabilizadoH.Size = New System.Drawing.Size(60, 21)
        Me.FwIContabilizadoH.TabIndex = 5
        '
        'lblFwIContabilizadoH
        '
        Me.lblFwIContabilizadoH.Location = New System.Drawing.Point(468, 47)
        Me.lblFwIContabilizadoH.Name = "lblFwIContabilizadoH"
        Me.lblFwIContabilizadoH.Size = New System.Drawing.Size(146, 13)
        Me.lblFwIContabilizadoH.TabIndex = 10
        Me.lblFwIContabilizadoH.Text = "Año Contabilizado Hasta"
        '
        'FwIBancoPropio
        '
        Me.FwIBancoPropio.DisabledBackColor = System.Drawing.Color.White
        Me.FwIBancoPropio.EntityName = "BancoPropio"
        Me.FwIBancoPropio.Location = New System.Drawing.Point(98, 71)
        Me.FwIBancoPropio.Name = "FwIBancoPropio"
        Me.FwIBancoPropio.SecondaryDataFields = "IDBancoPropio"
        Me.FwIBancoPropio.Size = New System.Drawing.Size(77, 23)
        Me.FwIBancoPropio.TabIndex = 4
        Me.FwIBancoPropio.ViewName = "tbMaestroBancoPropio"
        '
        'lblFwIBancoPropio
        '
        Me.lblFwIBancoPropio.Location = New System.Drawing.Point(11, 71)
        Me.lblFwIBancoPropio.Name = "lblFwIBancoPropio"
        Me.lblFwIBancoPropio.Size = New System.Drawing.Size(82, 13)
        Me.lblFwIBancoPropio.TabIndex = 11
        Me.lblFwIBancoPropio.Text = "Banco Propio"
        '
        'FwIDescInmovilizado
        '
        Me.FwIDescInmovilizado.DisabledBackColor = System.Drawing.Color.White
        Me.FwIDescInmovilizado.Location = New System.Drawing.Point(178, 45)
        Me.FwIDescInmovilizado.Name = "FwIDescInmovilizado"
        Me.FwIDescInmovilizado.Size = New System.Drawing.Size(284, 21)
        Me.FwIDescInmovilizado.TabIndex = 3
        '
        'lblFwIDescInmovilizado
        '
        Me.lblFwIDescInmovilizado.Location = New System.Drawing.Point(175, 41)
        Me.lblFwIDescInmovilizado.Name = "lblFwIDescInmovilizado"
        Me.lblFwIDescInmovilizado.Size = New System.Drawing.Size(0, 13)
        Me.lblFwIDescInmovilizado.TabIndex = 13
        '
        'FwIInmovilizado
        '
        Me.FwIInmovilizado.DisabledBackColor = System.Drawing.Color.White
        Me.FwIInmovilizado.EntityName = "PagoPeriodico"
        Me.FwIInmovilizado.Location = New System.Drawing.Point(98, 45)
        Me.FwIInmovilizado.Name = "FwIInmovilizado"
        Me.FwIInmovilizado.SecondaryDataFields = "Id"
        Me.FwIInmovilizado.Size = New System.Drawing.Size(77, 23)
        Me.FwIInmovilizado.TabIndex = 2
        Me.FwIInmovilizado.ViewName = "tbPagoPeriodico"
        '
        'lblFwIInmovilizado
        '
        Me.lblFwIInmovilizado.Location = New System.Drawing.Point(11, 45)
        Me.lblFwIInmovilizado.Name = "lblFwIInmovilizado"
        Me.lblFwIInmovilizado.Size = New System.Drawing.Size(80, 13)
        Me.lblFwIInmovilizado.TabIndex = 14
        Me.lblFwIInmovilizado.Text = "Inmovilizado"
        '
        'fwiIDPagoPeriodico
        '
        Me.fwiIDPagoPeriodico.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIDPagoPeriodico.EntityName = "PagoPeriodico"
        Me.fwiIDPagoPeriodico.Location = New System.Drawing.Point(99, 19)
        Me.fwiIDPagoPeriodico.Name = "fwiIDPagoPeriodico"
        Me.fwiIDPagoPeriodico.SecondaryDataFields = "Id"
        Me.fwiIDPagoPeriodico.Size = New System.Drawing.Size(77, 23)
        Me.fwiIDPagoPeriodico.TabIndex = 1
        Me.fwiIDPagoPeriodico.ViewName = "tbPagoPeriodico"
        '
        'lblfwiIDPagoPeriodico
        '
        Me.lblfwiIDPagoPeriodico.Location = New System.Drawing.Point(11, 19)
        Me.lblfwiIDPagoPeriodico.Name = "lblfwiIDPagoPeriodico"
        Me.lblfwiIDPagoPeriodico.Size = New System.Drawing.Size(35, 13)
        Me.lblfwiIDPagoPeriodico.TabIndex = 16
        Me.lblfwiIDPagoPeriodico.Text = "Pago"
        '
        'CIImpuestosDiferidos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(698, 459)
        Me.EntityName = "PagoPeriodico"
        Me.KeyField = "Id"
        Me.Name = "CIImpuestosDiferidos"
        Me.UseCheck = True
        Me.ViewName = "VCtlCiImpuestosDiferidos"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.FwIMarcados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FwIContabilizadoD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FwIContabilizadoH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mintAño As Integer

#Region "Eventos del Formulario"

    Protected Overrides Sub OnFilterClearing(ByVal e As System.EventArgs)
        MyBase.OnFilterClearing(e)

        FwIMarcados.Value = enumBoolean.Todos

    End Sub

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        FwIMarcados.DataSource = New EnumData("EnumBoolean")
        AddYearToList()

        FwIMarcados.Value = enumBoolean.Todos
    End Sub

    Private Sub CIImpuestosDiferidos_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("Id", FilterOperator.Equal, fwiIDPagoPeriodico.Value, FilterType.Numeric)
        e.Filter.Add("IDInmovilizado", FilterOperator.Equal, FwIInmovilizado.Text, FilterType.String)
        e.Filter.Add("IDBancoPropio", FilterOperator.Equal, FwIBancoPropio.Text, FilterType.String)
        e.Filter.Add("DescInmovilizado", FilterOperator.Equal, FwIDescInmovilizado.Text, FilterType.String)
        e.Filter.Add("añoContabilizado", FilterOperator.GreaterThanOrEqual, FwIContabilizadoD.Value, FilterType.Numeric)
        e.Filter.Add("añoContabilizado", FilterOperator.LessThanOrEqual, FwIContabilizadoH.Value, FilterType.Numeric)
        If FwIMarcados.Value <> enumBoolean.Todos Then
            e.Filter.Add(New IsNullFilterItem("Marca", CBool(FwIMarcados.Value)))
        End If
    End Sub

    Private Sub CIImpuestosDiferidos_SetReportDesignObjects(ByVal sender As Object, ByVal e As Engine.UI.ReportDesignObjectsEventArgs) Handles MyBase.SetReportDesignObjects
        Dim frmAñoInforme As FrmAno
        If e.Alias = "DIMAAN" Then
            frmAñoInforme = New FrmAno
            If frmAñoInforme.LoadFunction() = DialogResult.OK Then
                mintAño = frmAñoInforme.Año
                e.Formulas.Item("Año").Text = mintAño
            Else
                e.Cancel = True
            End If
            frmAñoInforme = Nothing
        End If

    End Sub


    Private Sub CIImpuestosDiferidos_SetReportDataSource(ByVal sender As Object, ByVal e As Engine.UI.ReportDataSourceEventArgs) Handles MyBase.SetReportDataSource
        Dim dtFinal As DataTable
        Dim dt As DataTable

        If e.Alias = "DIMAAN" Then
            Dim ap As New BE.DataEngine
            dt = ap.Filter("vrptDiferidosMaquinaAño", "", "1=1")
            If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
                dtFinal = CalculoAcumulados(dt)
                Dim dv As DataView = dt.DefaultView
                Dim Filtro As New Filter
                Filtro.Add("AñoContabilizado", FilterOperator.Equal, mintAño)
                dv.RowFilter = Filtro.Compose(New AdoFilterComposer)
                
                e.DataSource = dv

            Else : e.Cancel = True
            End If
        End If
    End Sub

    Private Sub CIImpuestosDiferidos_SetReportSelectionCriteria(ByVal sender As Object, ByVal e As Engine.UI.ReportSelectionCriteriaEventArgs) Handles MyBase.SetReportSelectionCriteria
        Select Case e.Alias
            Case "IDMA"
                Dim frm As New frmAnoDesdeHasta
                If frm.ShowDialog = DialogResult.OK Then
                    e.Filter.Add("AñoContabilizado", FilterOperator.GreaterThanOrEqual, frm.AñoDesde, FilterType.Numeric)
                    e.Filter.Add("AñoContabilizado", FilterOperator.LessThanOrEqual, frm.AñoHasta, FilterType.Numeric)
                Else
                    e.Cancel = True
                End If
        End Select
    End Sub

#End Region

#Region "Funciones Privadas"
    Private Sub AddYearToList()
        Dim dtApp As DataTable
        Dim lngfirstYear, lngFinalYear As Long
        Dim i As Integer

        Dim nvapp As New DataEngine
        dtApp = nvapp.Filter("VCtlCiImpuestosDiferidos", "Max (AñoContabilizado) As AñoMax,Min (añocontabilizado) as AñoMin", "")
        If Not IsNothing(dtApp) AndAlso dtApp.Rows.Count > 0 Then

            lngfirstYear = IIf(IsDBNull(dtApp.Rows(0)("AñoMin")), 0, dtApp.Rows(0)("AñoMin"))
            lngFinalYear = IIf(IsDBNull(dtApp.Rows(0)("AñoMax")), 0, dtApp.Rows(0)("AñoMax"))
        End If

        If lngfirstYear > 1 And lngFinalYear > 1 Then
            Dim dtAños As New DataTable
            Dim dc As New DataColumn("Año")
            dtAños.Columns.Add(dc)
            For i = lngfirstYear To lngFinalYear
                Dim dr As DataRow = dtAños.NewRow
                dr("Año") = i
                dtAños.Rows.Add(dr)
            Next i
            FwIContabilizadoD.DataSource = dtAños
            FwIContabilizadoH.DataSource = dtAños
        End If
    End Sub

    Private Function CalculoAcumulados(ByVal dtDataSource As DataTable) As DataTable
        Dim strID As String
        Dim strElemento As String
        Dim dblAcumulado As Double

        strElemento = dtDataSource.Rows(0)("IDElemento")
        strID = dtDataSource.Rows(0)("IdPagoPeriodico")
        For Each dr As DataRow In dtDataSource.Select
            If dr("IdPagoPeriodico") <> strID OrElse dr("IDElemento") = strElemento Then
                dblAcumulado = 0
            End If
            dblAcumulado = dblAcumulado + dr("Impuesto")
            dr("ImpuestoAcumulado") = dblAcumulado
            strElemento = dr("IDElemento")
            strID = dr("IdPagoPeriodico")
        Next
        CalculoAcumulados = dtDataSource
    End Function

#End Region

#Region "Grid y Controles"

    Private Sub clsGrid_AplicarFiltro()
        Me.Execute()
    End Sub

    Private Sub FwIContabilizadoD_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles FwIContabilizadoD.Validated
        FwIContabilizadoH.Value = FwIContabilizadoD.Value
    End Sub
#End Region

End Class
