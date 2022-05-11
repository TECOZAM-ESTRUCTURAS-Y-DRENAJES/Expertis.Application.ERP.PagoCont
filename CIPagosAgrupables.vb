Imports Solmicro.Expertis.Business.Negocio

Public Class CIPagosAgrupables
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
    Friend WithEvents FwiFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFwiFechaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFwiFechaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiIdProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFwiIdProveedor As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIPagosAgrupables))
        Me.FwiFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFwiFechaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFwiFechaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiIdProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFwiIdProveedor = New Solmicro.Expertis.Engine.UI.Label
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
        Me.FilterPanel.Controls.Add(Me.lblFwiFechaDesde)
        Me.FilterPanel.Controls.Add(Me.lblFwiFechaHasta)
        Me.FilterPanel.Controls.Add(Me.lblFwiIdProveedor)
        Me.FilterPanel.Controls.Add(Me.FwiFechaDesde)
        Me.FilterPanel.Controls.Add(Me.FwiFechaHasta)
        Me.FilterPanel.Controls.Add(Me.FwiIdProveedor)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 373)
        Me.FilterPanel.Size = New System.Drawing.Size(688, 48)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(688, 373)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EntityName = ""
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.KeyField = "IDPago"
        Me.Grid.RequeryManually = True
        Me.Grid.SecondaryDataFields = ""
        Me.Grid.Size = New System.Drawing.Size(688, 373)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = ""
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
        'FwiFechaDesde
        '
        Me.FwiFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.FwiFechaDesde.Location = New System.Drawing.Point(384, 19)
        Me.FwiFechaDesde.Name = "FwiFechaDesde"
        Me.FwiFechaDesde.Size = New System.Drawing.Size(96, 21)
        Me.FwiFechaDesde.TabIndex = 1
        '
        'lblFwiFechaDesde
        '
        Me.lblFwiFechaDesde.Location = New System.Drawing.Point(312, 19)
        Me.lblFwiFechaDesde.Name = "lblFwiFechaDesde"
        Me.lblFwiFechaDesde.Size = New System.Drawing.Size(62, 13)
        Me.lblFwiFechaDesde.TabIndex = 0
        Me.lblFwiFechaDesde.Tag = "IdRec=4727;"
        Me.lblFwiFechaDesde.Text = "Fecha >="
        '
        'FwiFechaHasta
        '
        Me.FwiFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.FwiFechaHasta.Location = New System.Drawing.Point(576, 19)
        Me.FwiFechaHasta.Name = "FwiFechaHasta"
        Me.FwiFechaHasta.Size = New System.Drawing.Size(96, 21)
        Me.FwiFechaHasta.TabIndex = 2
        '
        'lblFwiFechaHasta
        '
        Me.lblFwiFechaHasta.Location = New System.Drawing.Point(504, 19)
        Me.lblFwiFechaHasta.Name = "lblFwiFechaHasta"
        Me.lblFwiFechaHasta.Size = New System.Drawing.Size(62, 13)
        Me.lblFwiFechaHasta.TabIndex = 3
        Me.lblFwiFechaHasta.Tag = "IdRec=4726;"
        Me.lblFwiFechaHasta.Text = "Fecha <="
        '
        'FwiIdProveedor
        '
        Me.FwiIdProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.FwiIdProveedor.EntityName = "Proveedor"
        Me.FwiIdProveedor.Location = New System.Drawing.Point(80, 19)
        Me.FwiIdProveedor.Name = "FwiIdProveedor"
        Me.FwiIdProveedor.PrimaryDataFields = "IDProveedor"
        Me.FwiIdProveedor.SecondaryDataFields = "IDProveedor"
        Me.FwiIdProveedor.Size = New System.Drawing.Size(136, 23)
        Me.FwiIdProveedor.TabIndex = 0
        Me.FwiIdProveedor.ViewName = "tbMaestroProveedor"
        '
        'lblFwiIdProveedor
        '
        Me.lblFwiIdProveedor.Location = New System.Drawing.Point(13, 19)
        Me.lblFwiIdProveedor.Name = "lblFwiIdProveedor"
        Me.lblFwiIdProveedor.Size = New System.Drawing.Size(66, 13)
        Me.lblFwiIdProveedor.TabIndex = 4
        Me.lblFwiIdProveedor.Tag = ""
        Me.lblFwiIdProveedor.Text = "Proveedor"
        '
        'CIPagosAgrupables
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(696, 509)
        Me.EntityName = ""
        Me.KeyField = "IDPago"
        Me.Name = "CIPagosAgrupables"
        Me.Text = "Selección de Pagos a agrupar"
        Me.UseCheck = True
        Me.ViewName = ""
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

    Private fCriterios As Filter
    Private mstrProveedorsSelec As String = String.Empty
    Private ProveedorRepetido As Boolean = False

    Private Sub CIPagosAgrupables_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If Me.RecordsState <> RecordsState.Initialize Then
            mstrProveedorsSelec = String.Empty
            Me.UnCheckAllRecords()
            Me.Execute()
        End If
    End Sub

    Private Sub CIPagosAgrupables_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadToolbarActions()
    End Sub

    Private Sub LoadToolbarActions()
        Me.FormActions.Add("Configurar Agrupaciones", AddressOf ConfigurarAgrupaciones)
        Me.FormActions.Add("Pagos Agrupados", AddressOf AbrirPagosAgrupados)
    End Sub

    Private Sub ConfigurarAgrupaciones()
        Dim frm As New FrmAgrupaPagos
        frm.ShowDialog()

        Me.Execute()
    End Sub

    Private Sub AbrirPagosAgrupados()
        If Not Grid.DataSource Is Nothing AndAlso Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Grid.CheckedRecords
            If Not fCriterios Is Nothing Then
                If fCriterios.Count > 0 Then fCriterios.Clear()
            Else : fCriterios = New Filter
            End If
            If Length(FwiFechaDesde.Value) > 0 Then fCriterios.Add("FechaVencimiento", FilterOperator.GreaterThanOrEqual, FwiFechaDesde.Value, FilterType.DateTime)
            If Length(FwiFechaHasta.Value) > 0 Then fCriterios.Add("FechaVencimiento", FilterOperator.LessThanOrEqual, FwiFechaHasta.Value, FilterType.DateTime)

            Dim HT As New Hashtable
            HT.Add("dtMarcados", dtMarcados)
            HT.Add("Criterios", fCriterios)

            ExpertisApp.OpenForm("CIPAAGRUPADOS", , HT, Me)
        Else
            ExpertisApp.GenerateMessage("No hay lineas seleccionadas.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CIPagosAgrupables_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDProveedor", FilterOperator.Equal, FwiIdProveedor.Text, FilterType.String)
        e.Filter.Add("FechaVencimiento", FilterOperator.GreaterThanOrEqual, FwiFechaDesde.Text, FilterType.DateTime)
        e.Filter.Add("FechaVencimiento", FilterOperator.LessThanOrEqual, FwiFechaHasta.Text, FilterType.DateTime)

        Dim dtPagos As DataTable = ExpertisApp.ExecuteTask(Of Filter, DataTable)(AddressOf Pago.PagosAgrupables, e.Filter.InnerFilter)
        Me.BindEditEvents(dtPagos)

        Grid.AddCheckColumnToDataSource(dtPagos, Nothing)
        Grid.DataSource = dtPagos
    End Sub

    Private Sub Grid_RecordChecked(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.CheckingEventArgs) Handles Grid.CheckingRecord
        If e.CheckState = CheckStates.UnChecked Then
            If Length(Grid.GetValue("IDProveedor")) > 0 Then
                If InStr(mstrProveedorsSelec, "," & Grid.Value("IDProveedor") & ",", CompareMethod.Text) = 0 Then
                    If Len(mstrProveedorsSelec) = 0 Then mstrProveedorsSelec = ","
                    mstrProveedorsSelec = mstrProveedorsSelec & Grid.GetValue("IDProveedor") & ","
                Else
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("No se pueden marcar dos líneas con el mismo Proveedor.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    ProveedorRepetido = True
                End If
            Else
                ExpertisApp.GenerateMessage("No se pueden seleccionar lineas sin Proveedor configurado.|Por favor, revise los datos.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, vbNewLine)
                e.Cancel = True
            End If
        Else
            If Length(Grid.GetValue("IDProveedor")) > 0 Then
                If ProveedorRepetido = True Then
                    ProveedorRepetido = False
                Else
                    If InStr(mstrProveedorsSelec, "," & Grid.Value("IDProveedor") & ",", CompareMethod.Text) > 0 Then
                        mstrProveedorsSelec = Replace(mstrProveedorsSelec, "," & Grid.Value("IDProveedor") & ",", ",")
                    End If
                End If
            End If
        End If
    End Sub

End Class