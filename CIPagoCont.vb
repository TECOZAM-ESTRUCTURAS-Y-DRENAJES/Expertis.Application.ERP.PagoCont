Imports Janus.Windows.GridEX
Imports Solmicro.Expertis.Business.General
Imports Solmicro.Expertis.Engine.BE.BusinessHelper
Imports Solmicro.Expertis.Engine.DAL
Imports Solmicro.Expertis.Business.Negocio

Public Class CIPagoCont
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        If Not Me.DesignMode Then
            txtImporteDesde.Value = DBNull.Value
            txtImporteHasta.Value = DBNull.Value
        End If
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
    Friend WithEvents lblfwiTotalMarcado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvIDPagoPeriodico As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblPagoPeriodico As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvIDContador As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblContador As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxManual As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblManual As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFechaFacturaH As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblFechaFacturaH As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxEmpresa As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblEmpresa As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxRemesado As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblRemesado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFechaFacturaD As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblFechaFacturaD As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvIDRemesa As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblRemesa As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxRiesgo As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblRiesgo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxTipo As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblTipo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtSaldoCContable As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiSaldoCContable As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtCContable As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblProveedor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvFacturaDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblFacturaDesde As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvFacturaHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblFacturaHasta As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxVtoDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblVtoDesde As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxVtoHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblVtoHasta As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImporteDesde As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImporteHasta As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFormaPago As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblFormaPago As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxBancoPropio As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxIDEjercicio As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblEjercicio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxSituacion As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblSituacion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxContabilizado As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblContabilizado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvIDProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents PicTotal As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents lblTotalMarcado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblTotal As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTotalMarcado As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtTotal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblObra As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvIDObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents txtTitulo As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblTitulo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblEmpresaGrupo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxEmpresaGrupo As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblfwiCContable As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtEstado As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiEstado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxAsignadoNPagare As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblAsigNPagare As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxEspecial As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents txtImporteHasta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImporteDesde As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblFrasAgrup As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtFrasAgrup As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents clbFechaPago As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaPago1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents clbFechaPagoDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaPago As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblEspecial As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim Grid_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim cbxManual_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxEmpresa_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxRemesado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxRiesgo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxTipo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxFormaPago_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxBancoPropio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxIDEjercicio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxSituacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxContabilizado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxEmpresaGrupo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxAsignadoNPagare_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxEspecial_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIPagoCont))
        Me.AdvIDPagoPeriodico = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblPagoPeriodico = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDContador = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblContador = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxManual = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblManual = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaFacturaH = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaFacturaH = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxEmpresa = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblEmpresa = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxRemesado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblRemesado = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaFacturaD = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaFacturaD = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDRemesa = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblRemesa = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxRiesgo = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblRiesgo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxTipo = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblTipo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtSaldoCContable = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiSaldoCContable = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCContable = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiCContable = New Solmicro.Expertis.Engine.UI.Label
        Me.lblProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvFacturaDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFacturaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvFacturaHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFacturaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxVtoDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblVtoDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxVtoHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblVtoHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.lblImporteDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblImporteHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFormaPago = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblFormaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxBancoPropio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxIDEjercicio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblEjercicio = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxSituacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblSituacion = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxContabilizado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblContabilizado = New Solmicro.Expertis.Engine.UI.Label
        Me.txtEstado = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.PicTotal = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblTotalMarcado = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalMarcado = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtTotal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblObra = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.txtTitulo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTitulo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblEmpresaGrupo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxEmpresaGrupo = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.cbxAsignadoNPagare = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblAsigNPagare = New Solmicro.Expertis.Engine.UI.Label
        Me.lblEspecial = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxEspecial = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.txtImporteDesde = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImporteHasta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblFrasAgrup = New Solmicro.Expertis.Engine.UI.Label
        Me.txtFrasAgrup = New Solmicro.Expertis.Engine.UI.TextBox
        Me.clbFechaPagoDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.clbFechaPago = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaPago1 = New Solmicro.Expertis.Engine.UI.Label
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.cbxManual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxRemesado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxRiesgo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxBancoPropio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxIDEjercicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxSituacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxContabilizado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PicTotal.suspendlayout()
        CType(Me.cbxEmpresaGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxAsignadoNPagare, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxEspecial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.clbFechaPago)
        Me.FilterPanel.Controls.Add(Me.lblFechaPago1)
        Me.FilterPanel.Controls.Add(Me.clbFechaPagoDesde)
        Me.FilterPanel.Controls.Add(Me.lblFechaPago)
        Me.FilterPanel.Controls.Add(Me.lblFrasAgrup)
        Me.FilterPanel.Controls.Add(Me.txtFrasAgrup)
        Me.FilterPanel.Controls.Add(Me.txtImporteHasta)
        Me.FilterPanel.Controls.Add(Me.txtImporteDesde)
        Me.FilterPanel.Controls.Add(Me.lblEspecial)
        Me.FilterPanel.Controls.Add(Me.cbxEspecial)
        Me.FilterPanel.Controls.Add(Me.lblAsigNPagare)
        Me.FilterPanel.Controls.Add(Me.lblEmpresaGrupo)
        Me.FilterPanel.Controls.Add(Me.lblTitulo)
        Me.FilterPanel.Controls.Add(Me.lblObra)
        Me.FilterPanel.Controls.Add(Me.lblPagoPeriodico)
        Me.FilterPanel.Controls.Add(Me.lblContador)
        Me.FilterPanel.Controls.Add(Me.lblManual)
        Me.FilterPanel.Controls.Add(Me.lblFechaFacturaH)
        Me.FilterPanel.Controls.Add(Me.lblEmpresa)
        Me.FilterPanel.Controls.Add(Me.lblRemesado)
        Me.FilterPanel.Controls.Add(Me.lblFechaFacturaD)
        Me.FilterPanel.Controls.Add(Me.lblRemesa)
        Me.FilterPanel.Controls.Add(Me.lblRiesgo)
        Me.FilterPanel.Controls.Add(Me.lblTipo)
        Me.FilterPanel.Controls.Add(Me.lblProveedor)
        Me.FilterPanel.Controls.Add(Me.lblFacturaDesde)
        Me.FilterPanel.Controls.Add(Me.lblFacturaHasta)
        Me.FilterPanel.Controls.Add(Me.lblVtoDesde)
        Me.FilterPanel.Controls.Add(Me.lblVtoHasta)
        Me.FilterPanel.Controls.Add(Me.lblImporteDesde)
        Me.FilterPanel.Controls.Add(Me.lblImporteHasta)
        Me.FilterPanel.Controls.Add(Me.lblFormaPago)
        Me.FilterPanel.Controls.Add(Me.lblBancoPropio)
        Me.FilterPanel.Controls.Add(Me.lblEjercicio)
        Me.FilterPanel.Controls.Add(Me.lblSituacion)
        Me.FilterPanel.Controls.Add(Me.lblContabilizado)
        Me.FilterPanel.Controls.Add(Me.lblfwiEstado)
        Me.FilterPanel.Controls.Add(Me.cbxAsignadoNPagare)
        Me.FilterPanel.Controls.Add(Me.cbxEmpresaGrupo)
        Me.FilterPanel.Controls.Add(Me.txtTitulo)
        Me.FilterPanel.Controls.Add(Me.AdvIDObra)
        Me.FilterPanel.Controls.Add(Me.AdvIDPagoPeriodico)
        Me.FilterPanel.Controls.Add(Me.AdvIDContador)
        Me.FilterPanel.Controls.Add(Me.cbxManual)
        Me.FilterPanel.Controls.Add(Me.cbxFechaFacturaH)
        Me.FilterPanel.Controls.Add(Me.cbxEmpresa)
        Me.FilterPanel.Controls.Add(Me.cbxRemesado)
        Me.FilterPanel.Controls.Add(Me.cbxFechaFacturaD)
        Me.FilterPanel.Controls.Add(Me.AdvIDRemesa)
        Me.FilterPanel.Controls.Add(Me.cbxRiesgo)
        Me.FilterPanel.Controls.Add(Me.cbxTipo)
        Me.FilterPanel.Controls.Add(Me.lblfwiSaldoCContable)
        Me.FilterPanel.Controls.Add(Me.txtSaldoCContable)
        Me.FilterPanel.Controls.Add(Me.lblfwiCContable)
        Me.FilterPanel.Controls.Add(Me.txtCContable)
        Me.FilterPanel.Controls.Add(Me.AdvIDProveedor)
        Me.FilterPanel.Controls.Add(Me.AdvFacturaDesde)
        Me.FilterPanel.Controls.Add(Me.AdvFacturaHasta)
        Me.FilterPanel.Controls.Add(Me.cbxVtoDesde)
        Me.FilterPanel.Controls.Add(Me.cbxVtoHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFormaPago)
        Me.FilterPanel.Controls.Add(Me.cbxBancoPropio)
        Me.FilterPanel.Controls.Add(Me.cbxIDEjercicio)
        Me.FilterPanel.Controls.Add(Me.cbxSituacion)
        Me.FilterPanel.Controls.Add(Me.cbxContabilizado)
        Me.FilterPanel.Controls.Add(Me.txtEstado)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 258)
        Me.FilterPanel.Size = New System.Drawing.Size(782, 191)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.PicTotal)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(782, 258)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.PicTotal, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'Grid
        '
        Grid_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_0.Instance"), Object)
        Grid_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {Grid_DesignTimeLayout_Reference_0})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EntityName = "Pago"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.ImageSource = Janus.Windows.GridEX.ImageSource.InternalImageList
        Me.Grid.KeyField = "IDPago"
        Me.Grid.Size = New System.Drawing.Size(782, 226)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "frmPagos"
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
        Me.MainPanel.Size = New System.Drawing.Size(782, 449)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(782, 449)
        '
        'AdvIDPagoPeriodico
        '
        Me.AdvIDPagoPeriodico.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDPagoPeriodico.DisplayField = "DescPago"
        Me.AdvIDPagoPeriodico.EntityName = "PagoPeriodico"
        Me.AdvIDPagoPeriodico.Location = New System.Drawing.Point(264, 114)
        Me.AdvIDPagoPeriodico.Name = "AdvIDPagoPeriodico"
        Me.AdvIDPagoPeriodico.SecondaryDataFields = "Id"
        Me.AdvIDPagoPeriodico.Size = New System.Drawing.Size(88, 23)
        Me.AdvIDPagoPeriodico.TabIndex = 12
        Me.AdvIDPagoPeriodico.ViewName = "tbPagoPeriodico"
        '
        'lblPagoPeriodico
        '
        Me.lblPagoPeriodico.Location = New System.Drawing.Point(184, 119)
        Me.lblPagoPeriodico.Name = "lblPagoPeriodico"
        Me.lblPagoPeriodico.Size = New System.Drawing.Size(72, 13)
        Me.lblPagoPeriodico.TabIndex = 0
        Me.lblPagoPeriodico.Text = "P. Periódico"
        '
        'AdvIDContador
        '
        Me.AdvIDContador.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDContador.EntityName = "EntidadContador"
        Me.AdvIDContador.Location = New System.Drawing.Point(264, 89)
        Me.AdvIDContador.Name = "AdvIDContador"
        Me.AdvIDContador.SecondaryDataFields = "IDContador"
        Me.AdvIDContador.Size = New System.Drawing.Size(88, 23)
        Me.AdvIDContador.TabIndex = 11
        Me.AdvIDContador.ViewName = "tbEntidadContador"
        '
        'lblContador
        '
        Me.lblContador.Location = New System.Drawing.Point(184, 94)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(60, 13)
        Me.lblContador.TabIndex = 13
        Me.lblContador.Text = "Contador"
        '
        'cbxManual
        '
        cbxManual_DesignTimeLayout.LayoutString = resources.GetString("cbxManual_DesignTimeLayout.LayoutString")
        Me.cbxManual.DesignTimeLayout = cbxManual_DesignTimeLayout
        Me.cbxManual.DisabledBackColor = System.Drawing.Color.White
        Me.cbxManual.Location = New System.Drawing.Point(440, 140)
        Me.cbxManual.Name = "cbxManual"
        Me.cbxManual.SelectedIndex = -1
        Me.cbxManual.SelectedItem = Nothing
        Me.cbxManual.Size = New System.Drawing.Size(83, 21)
        Me.cbxManual.TabIndex = 20
        '
        'lblManual
        '
        Me.lblManual.Location = New System.Drawing.Point(355, 143)
        Me.lblManual.Name = "lblManual"
        Me.lblManual.Size = New System.Drawing.Size(75, 13)
        Me.lblManual.TabIndex = 33
        Me.lblManual.Text = "Tipo Manual"
        '
        'cbxFechaFacturaH
        '
        Me.cbxFechaFacturaH.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaFacturaH.Location = New System.Drawing.Point(109, 140)
        Me.cbxFechaFacturaH.Name = "cbxFechaFacturaH"
        Me.cbxFechaFacturaH.Size = New System.Drawing.Size(73, 21)
        Me.cbxFechaFacturaH.TabIndex = 6
        '
        'lblFechaFacturaH
        '
        Me.lblFechaFacturaH.Location = New System.Drawing.Point(4, 141)
        Me.lblFechaFacturaH.Name = "lblFechaFacturaH"
        Me.lblFechaFacturaH.Size = New System.Drawing.Size(82, 13)
        Me.lblFechaFacturaH.TabIndex = 34
        Me.lblFechaFacturaH.Text = "F. Factura <="
        '
        'cbxEmpresa
        '
        cbxEmpresa_DesignTimeLayout.LayoutString = resources.GetString("cbxEmpresa_DesignTimeLayout.LayoutString")
        Me.cbxEmpresa.DesignTimeLayout = cbxEmpresa_DesignTimeLayout
        Me.cbxEmpresa.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEmpresa.Location = New System.Drawing.Point(606, 165)
        Me.cbxEmpresa.Name = "cbxEmpresa"
        Me.cbxEmpresa.SelectedIndex = -1
        Me.cbxEmpresa.SelectedItem = Nothing
        Me.cbxEmpresa.Size = New System.Drawing.Size(173, 21)
        Me.cbxEmpresa.TabIndex = 28
        '
        'lblEmpresa
        '
        Me.lblEmpresa.Location = New System.Drawing.Point(524, 169)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(72, 13)
        Me.lblEmpresa.TabIndex = 36
        Me.lblEmpresa.Text = "Base Datos"
        '
        'cbxRemesado
        '
        cbxRemesado_DesignTimeLayout.LayoutString = resources.GetString("cbxRemesado_DesignTimeLayout.LayoutString")
        Me.cbxRemesado.DesignTimeLayout = cbxRemesado_DesignTimeLayout
        Me.cbxRemesado.DisabledBackColor = System.Drawing.Color.White
        Me.cbxRemesado.Location = New System.Drawing.Point(440, 115)
        Me.cbxRemesado.Name = "cbxRemesado"
        Me.cbxRemesado.SelectedIndex = -1
        Me.cbxRemesado.SelectedItem = Nothing
        Me.cbxRemesado.Size = New System.Drawing.Size(83, 21)
        Me.cbxRemesado.TabIndex = 19
        '
        'lblRemesado
        '
        Me.lblRemesado.Location = New System.Drawing.Point(355, 118)
        Me.lblRemesado.Name = "lblRemesado"
        Me.lblRemesado.Size = New System.Drawing.Size(67, 13)
        Me.lblRemesado.TabIndex = 37
        Me.lblRemesado.Text = "Remesado"
        '
        'cbxFechaFacturaD
        '
        Me.cbxFechaFacturaD.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaFacturaD.Location = New System.Drawing.Point(109, 115)
        Me.cbxFechaFacturaD.Name = "cbxFechaFacturaD"
        Me.cbxFechaFacturaD.Size = New System.Drawing.Size(73, 21)
        Me.cbxFechaFacturaD.TabIndex = 5
        '
        'lblFechaFacturaD
        '
        Me.lblFechaFacturaD.Location = New System.Drawing.Point(4, 115)
        Me.lblFechaFacturaD.Name = "lblFechaFacturaD"
        Me.lblFechaFacturaD.Size = New System.Drawing.Size(82, 13)
        Me.lblFechaFacturaD.TabIndex = 38
        Me.lblFechaFacturaD.Text = "F. Factura >="
        '
        'AdvIDRemesa
        '
        Me.AdvIDRemesa.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDRemesa.EntityName = "RemesaPago"
        Me.AdvIDRemesa.Location = New System.Drawing.Point(606, 15)
        Me.AdvIDRemesa.Name = "AdvIDRemesa"
        Me.AdvIDRemesa.SecondaryDataFields = "IDRemesa"
        Me.AdvIDRemesa.Size = New System.Drawing.Size(88, 23)
        Me.AdvIDRemesa.TabIndex = 22
        Me.AdvIDRemesa.ViewName = "tbRemesaPago"
        '
        'lblRemesa
        '
        Me.lblRemesa.Location = New System.Drawing.Point(524, 20)
        Me.lblRemesa.Name = "lblRemesa"
        Me.lblRemesa.Size = New System.Drawing.Size(53, 13)
        Me.lblRemesa.TabIndex = 39
        Me.lblRemesa.Tag = "IdRec=4782;"
        Me.lblRemesa.Text = "Remesa"
        '
        'cbxRiesgo
        '
        cbxRiesgo_DesignTimeLayout.LayoutString = resources.GetString("cbxRiesgo_DesignTimeLayout.LayoutString")
        Me.cbxRiesgo.DesignTimeLayout = cbxRiesgo_DesignTimeLayout
        Me.cbxRiesgo.DisabledBackColor = System.Drawing.Color.White
        Me.cbxRiesgo.Location = New System.Drawing.Point(440, 90)
        Me.cbxRiesgo.Name = "cbxRiesgo"
        Me.cbxRiesgo.SelectedIndex = -1
        Me.cbxRiesgo.SelectedItem = Nothing
        Me.cbxRiesgo.Size = New System.Drawing.Size(83, 21)
        Me.cbxRiesgo.TabIndex = 18
        '
        'lblRiesgo
        '
        Me.lblRiesgo.Location = New System.Drawing.Point(355, 92)
        Me.lblRiesgo.Name = "lblRiesgo"
        Me.lblRiesgo.Size = New System.Drawing.Size(45, 13)
        Me.lblRiesgo.TabIndex = 41
        Me.lblRiesgo.Text = "Riesgo"
        '
        'cbxTipo
        '
        cbxTipo_DesignTimeLayout.LayoutString = resources.GetString("cbxTipo_DesignTimeLayout.LayoutString")
        Me.cbxTipo.DesignTimeLayout = cbxTipo_DesignTimeLayout
        Me.cbxTipo.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipo.DisplayMember = "DescTipo"
        Me.cbxTipo.EntityName = "TipoPago"
        Me.cbxTipo.Location = New System.Drawing.Point(606, 115)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.PrimaryDataFields = "IdTipoPago"
        Me.cbxTipo.SecondaryDataFields = "IdTipoPago"
        Me.cbxTipo.SelectedIndex = -1
        Me.cbxTipo.SelectedItem = Nothing
        Me.cbxTipo.Size = New System.Drawing.Size(173, 21)
        Me.cbxTipo.TabIndex = 26
        Me.cbxTipo.ValueMember = "IdTipoPago"
        Me.cbxTipo.ViewName = "tbMaestroTipoPago"
        '
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(524, 119)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(31, 13)
        Me.lblTipo.TabIndex = 42
        Me.lblTipo.Text = "Tipo"
        '
        'txtSaldoCContable
        '
        Me.txtSaldoCContable.DisabledBackColor = System.Drawing.Color.White
        Me.txtSaldoCContable.Enabled = False
        Me.txtSaldoCContable.Location = New System.Drawing.Point(98, 40)
        Me.txtSaldoCContable.Name = "txtSaldoCContable"
        Me.txtSaldoCContable.Size = New System.Drawing.Size(84, 21)
        Me.txtSaldoCContable.TabIndex = 2
        Me.txtSaldoCContable.TabStop = False
        '
        'lblfwiSaldoCContable
        '
        Me.lblfwiSaldoCContable.Location = New System.Drawing.Point(80, 40)
        Me.lblfwiSaldoCContable.Name = "lblfwiSaldoCContable"
        Me.lblfwiSaldoCContable.Size = New System.Drawing.Size(0, 13)
        Me.lblfwiSaldoCContable.TabIndex = 45
        Me.lblfwiSaldoCContable.Tag = "IdRec=0;"
        '
        'txtCContable
        '
        Me.txtCContable.DisabledBackColor = System.Drawing.Color.White
        Me.txtCContable.Enabled = False
        Me.txtCContable.Location = New System.Drawing.Point(13, 40)
        Me.txtCContable.Name = "txtCContable"
        Me.txtCContable.Size = New System.Drawing.Size(83, 21)
        Me.txtCContable.TabIndex = 1
        Me.txtCContable.TabStop = False
        '
        'lblfwiCContable
        '
        Me.lblfwiCContable.Location = New System.Drawing.Point(5, 35)
        Me.lblfwiCContable.Name = "lblfwiCContable"
        Me.lblfwiCContable.Size = New System.Drawing.Size(0, 13)
        Me.lblfwiCContable.TabIndex = 1
        Me.lblfwiCContable.Tag = "IdRec=0;"
        '
        'lblProveedor
        '
        Me.lblProveedor.Location = New System.Drawing.Point(4, 15)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(66, 13)
        Me.lblProveedor.TabIndex = 47
        Me.lblProveedor.Tag = "IdRec=4352;"
        Me.lblProveedor.Text = "Proveedor"
        '
        'AdvFacturaDesde
        '
        Me.AdvFacturaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFacturaDesde.EntityName = "FacturaCompraCabecera"
        Me.AdvFacturaDesde.Location = New System.Drawing.Point(264, 15)
        Me.AdvFacturaDesde.Name = "AdvFacturaDesde"
        Me.AdvFacturaDesde.SecondaryDataFields = "NFactura"
        Me.AdvFacturaDesde.Size = New System.Drawing.Size(88, 23)
        Me.AdvFacturaDesde.TabIndex = 8
        Me.AdvFacturaDesde.ViewName = "tbFacturaCompraCabecera"
        '
        'lblFacturaDesde
        '
        Me.lblFacturaDesde.Location = New System.Drawing.Point(184, 20)
        Me.lblFacturaDesde.Name = "lblFacturaDesde"
        Me.lblFacturaDesde.Size = New System.Drawing.Size(70, 13)
        Me.lblFacturaDesde.TabIndex = 49
        Me.lblFacturaDesde.Tag = "IdRec=4776;"
        Me.lblFacturaDesde.Text = "Factura >="
        '
        'AdvFacturaHasta
        '
        Me.AdvFacturaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFacturaHasta.EntityName = "FacturaCompraCabecera"
        Me.AdvFacturaHasta.Location = New System.Drawing.Point(264, 40)
        Me.AdvFacturaHasta.Name = "AdvFacturaHasta"
        Me.AdvFacturaHasta.SecondaryDataFields = "NFactura"
        Me.AdvFacturaHasta.Size = New System.Drawing.Size(88, 23)
        Me.AdvFacturaHasta.TabIndex = 9
        Me.AdvFacturaHasta.ViewName = "tbFacturaCompraCabecera"
        '
        'lblFacturaHasta
        '
        Me.lblFacturaHasta.Location = New System.Drawing.Point(184, 45)
        Me.lblFacturaHasta.Name = "lblFacturaHasta"
        Me.lblFacturaHasta.Size = New System.Drawing.Size(70, 13)
        Me.lblFacturaHasta.TabIndex = 51
        Me.lblFacturaHasta.Tag = "IdRec=4775;"
        Me.lblFacturaHasta.Text = "Factura <="
        '
        'cbxVtoDesde
        '
        Me.cbxVtoDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxVtoDesde.Location = New System.Drawing.Point(109, 65)
        Me.cbxVtoDesde.Name = "cbxVtoDesde"
        Me.cbxVtoDesde.Size = New System.Drawing.Size(73, 21)
        Me.cbxVtoDesde.TabIndex = 3
        '
        'lblVtoDesde
        '
        Me.lblVtoDesde.Location = New System.Drawing.Point(4, 64)
        Me.lblVtoDesde.Name = "lblVtoDesde"
        Me.lblVtoDesde.Size = New System.Drawing.Size(98, 13)
        Me.lblVtoDesde.TabIndex = 53
        Me.lblVtoDesde.Tag = "IdRec=4777;"
        Me.lblVtoDesde.Text = "Vencimiento >="
        '
        'cbxVtoHasta
        '
        Me.cbxVtoHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxVtoHasta.Location = New System.Drawing.Point(109, 90)
        Me.cbxVtoHasta.Name = "cbxVtoHasta"
        Me.cbxVtoHasta.Size = New System.Drawing.Size(73, 21)
        Me.cbxVtoHasta.TabIndex = 4
        '
        'lblVtoHasta
        '
        Me.lblVtoHasta.Location = New System.Drawing.Point(4, 90)
        Me.lblVtoHasta.Name = "lblVtoHasta"
        Me.lblVtoHasta.Size = New System.Drawing.Size(98, 13)
        Me.lblVtoHasta.TabIndex = 54
        Me.lblVtoHasta.Tag = "IdRec=4779;"
        Me.lblVtoHasta.Text = "Vencimiento <="
        '
        'lblImporteDesde
        '
        Me.lblImporteDesde.Location = New System.Drawing.Point(184, 143)
        Me.lblImporteDesde.Name = "lblImporteDesde"
        Me.lblImporteDesde.Size = New System.Drawing.Size(75, 13)
        Me.lblImporteDesde.TabIndex = 55
        Me.lblImporteDesde.Tag = "IdRec=4778;"
        Me.lblImporteDesde.Text = "Importe >="
        '
        'lblImporteHasta
        '
        Me.lblImporteHasta.Location = New System.Drawing.Point(184, 168)
        Me.lblImporteHasta.Name = "lblImporteHasta"
        Me.lblImporteHasta.Size = New System.Drawing.Size(75, 13)
        Me.lblImporteHasta.TabIndex = 56
        Me.lblImporteHasta.Tag = "IdRec=4780;"
        Me.lblImporteHasta.Text = "Importe <="
        '
        'cbxFormaPago
        '
        cbxFormaPago_DesignTimeLayout.LayoutString = resources.GetString("cbxFormaPago_DesignTimeLayout.LayoutString")
        Me.cbxFormaPago.DesignTimeLayout = cbxFormaPago_DesignTimeLayout
        Me.cbxFormaPago.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFormaPago.DisplayMember = "IDFormaPago"
        Me.cbxFormaPago.EntityName = "FormaPago"
        Me.cbxFormaPago.Location = New System.Drawing.Point(440, 40)
        Me.cbxFormaPago.Name = "cbxFormaPago"
        Me.cbxFormaPago.PrimaryDataFields = "IDFormaPago"
        Me.cbxFormaPago.SecondaryDataFields = "IDFormaPago"
        Me.cbxFormaPago.SelectedIndex = -1
        Me.cbxFormaPago.SelectedItem = Nothing
        Me.cbxFormaPago.Size = New System.Drawing.Size(83, 21)
        Me.cbxFormaPago.TabIndex = 16
        Me.cbxFormaPago.ValueMember = "IDFormaPago"
        Me.cbxFormaPago.ViewName = "tbMaestroFormaPago"
        '
        'lblFormaPago
        '
        Me.lblFormaPago.Location = New System.Drawing.Point(355, 40)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.Size = New System.Drawing.Size(75, 13)
        Me.lblFormaPago.TabIndex = 57
        Me.lblFormaPago.Tag = "IdRec=4758;"
        Me.lblFormaPago.Text = "Forma Pago"
        '
        'cbxBancoPropio
        '
        cbxBancoPropio_DesignTimeLayout.LayoutString = resources.GetString("cbxBancoPropio_DesignTimeLayout.LayoutString")
        Me.cbxBancoPropio.DesignTimeLayout = cbxBancoPropio_DesignTimeLayout
        Me.cbxBancoPropio.DisabledBackColor = System.Drawing.Color.White
        Me.cbxBancoPropio.DisplayMember = "IDBancoPropio"
        Me.cbxBancoPropio.EntityName = "BancoPropio"
        Me.cbxBancoPropio.Location = New System.Drawing.Point(440, 15)
        Me.cbxBancoPropio.Name = "cbxBancoPropio"
        Me.cbxBancoPropio.PrimaryDataFields = "IDBancoPropio"
        Me.cbxBancoPropio.SecondaryDataFields = "IDBancoPropio"
        Me.cbxBancoPropio.SelectedIndex = -1
        Me.cbxBancoPropio.SelectedItem = Nothing
        Me.cbxBancoPropio.Size = New System.Drawing.Size(83, 21)
        Me.cbxBancoPropio.TabIndex = 15
        Me.cbxBancoPropio.ValueMember = "IDBancoPropio"
        Me.cbxBancoPropio.ViewName = "tbMaestroBancoPropio"
        '
        'lblBancoPropio
        '
        Me.lblBancoPropio.Location = New System.Drawing.Point(355, 15)
        Me.lblBancoPropio.Name = "lblBancoPropio"
        Me.lblBancoPropio.Size = New System.Drawing.Size(82, 13)
        Me.lblBancoPropio.TabIndex = 59
        Me.lblBancoPropio.Tag = "IdRec=4613;"
        Me.lblBancoPropio.Text = "Banco Propio"
        '
        'cbxIDEjercicio
        '
        cbxIDEjercicio_DesignTimeLayout.LayoutString = resources.GetString("cbxIDEjercicio_DesignTimeLayout.LayoutString")
        Me.cbxIDEjercicio.DesignTimeLayout = cbxIDEjercicio_DesignTimeLayout
        Me.cbxIDEjercicio.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDEjercicio.DisplayMember = "IDEjercicio"
        Me.cbxIDEjercicio.EntityName = "EjercicioContable"
        Me.cbxIDEjercicio.Location = New System.Drawing.Point(606, 40)
        Me.cbxIDEjercicio.Name = "cbxIDEjercicio"
        Me.cbxIDEjercicio.PrimaryDataFields = "IDEjercicio"
        Me.cbxIDEjercicio.SecondaryDataFields = "IDEjercicio"
        Me.cbxIDEjercicio.SelectedIndex = -1
        Me.cbxIDEjercicio.SelectedItem = Nothing
        Me.cbxIDEjercicio.Size = New System.Drawing.Size(88, 21)
        Me.cbxIDEjercicio.TabIndex = 23
        Me.cbxIDEjercicio.ValueMember = "IDEjercicio"
        Me.cbxIDEjercicio.ViewName = "tbMaestroEjercicio"
        '
        'lblEjercicio
        '
        Me.lblEjercicio.Location = New System.Drawing.Point(524, 44)
        Me.lblEjercicio.Name = "lblEjercicio"
        Me.lblEjercicio.Size = New System.Drawing.Size(55, 13)
        Me.lblEjercicio.TabIndex = 61
        Me.lblEjercicio.Tag = "IdRec=4467;"
        Me.lblEjercicio.Text = "Ejercicio"
        '
        'cbxSituacion
        '
        cbxSituacion_DesignTimeLayout.LayoutString = resources.GetString("cbxSituacion_DesignTimeLayout.LayoutString")
        Me.cbxSituacion.DesignTimeLayout = cbxSituacion_DesignTimeLayout
        Me.cbxSituacion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxSituacion.DisplayMember = "DescEstado"
        Me.cbxSituacion.EntityName = "EstadoPago"
        Me.cbxSituacion.Location = New System.Drawing.Point(606, 140)
        Me.cbxSituacion.Name = "cbxSituacion"
        Me.cbxSituacion.PrimaryDataFields = "IDEstado"
        Me.cbxSituacion.SecondaryDataFields = "IDEstado"
        Me.cbxSituacion.SelectedIndex = -1
        Me.cbxSituacion.SelectedItem = Nothing
        Me.cbxSituacion.Size = New System.Drawing.Size(173, 21)
        Me.cbxSituacion.TabIndex = 27
        Me.cbxSituacion.ValueMember = "IDEstado"
        Me.cbxSituacion.ViewName = "tbMaestroEstadoPago"
        '
        'lblSituacion
        '
        Me.lblSituacion.Location = New System.Drawing.Point(524, 144)
        Me.lblSituacion.Name = "lblSituacion"
        Me.lblSituacion.Size = New System.Drawing.Size(59, 13)
        Me.lblSituacion.TabIndex = 62
        Me.lblSituacion.Tag = "IdRec=4781;"
        Me.lblSituacion.Text = "Situación"
        '
        'cbxContabilizado
        '
        cbxContabilizado_DesignTimeLayout.LayoutString = resources.GetString("cbxContabilizado_DesignTimeLayout.LayoutString")
        Me.cbxContabilizado.DesignTimeLayout = cbxContabilizado_DesignTimeLayout
        Me.cbxContabilizado.DisabledBackColor = System.Drawing.Color.White
        Me.cbxContabilizado.Location = New System.Drawing.Point(440, 65)
        Me.cbxContabilizado.Name = "cbxContabilizado"
        Me.cbxContabilizado.SelectedIndex = -1
        Me.cbxContabilizado.SelectedItem = Nothing
        Me.cbxContabilizado.Size = New System.Drawing.Size(83, 21)
        Me.cbxContabilizado.TabIndex = 17
        '
        'lblContabilizado
        '
        Me.lblContabilizado.Location = New System.Drawing.Point(355, 68)
        Me.lblContabilizado.Name = "lblContabilizado"
        Me.lblContabilizado.Size = New System.Drawing.Size(84, 13)
        Me.lblContabilizado.TabIndex = 64
        Me.lblContabilizado.Tag = "IdRec=4725;"
        Me.lblContabilizado.Text = "Contabilizado"
        '
        'txtEstado
        '
        Me.txtEstado.DisabledBackColor = System.Drawing.Color.White
        Me.txtEstado.Location = New System.Drawing.Point(567, 348)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(26, 21)
        Me.txtEstado.TabIndex = 26
        Me.txtEstado.Visible = False
        '
        'lblfwiEstado
        '
        Me.lblfwiEstado.Location = New System.Drawing.Point(496, 348)
        Me.lblfwiEstado.Name = "lblfwiEstado"
        Me.lblfwiEstado.Size = New System.Drawing.Size(45, 13)
        Me.lblfwiEstado.TabIndex = 65
        Me.lblfwiEstado.Tag = "IdRec=4405;"
        Me.lblfwiEstado.Text = "Estado"
        '
        'AdvIDProveedor
        '
        Me.AdvIDProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDProveedor.EntityName = "Proveedor"
        Me.AdvIDProveedor.Location = New System.Drawing.Point(74, 15)
        Me.AdvIDProveedor.Name = "AdvIDProveedor"
        Me.AdvIDProveedor.SecondaryDataFields = "IDProveedor"
        Me.AdvIDProveedor.Size = New System.Drawing.Size(108, 23)
        Me.AdvIDProveedor.TabIndex = 0
        Me.AdvIDProveedor.ViewName = "tbMaestroProveedor"
        '
        'PicTotal
        '
        Me.PicTotal.Controls.Add(Me.lblTotalMarcado)
        Me.PicTotal.Controls.Add(Me.lblTotal)
        Me.PicTotal.Controls.Add(Me.txtTotalMarcado)
        Me.PicTotal.Controls.Add(Me.txtTotal)
        Me.PicTotal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PicTotal.Location = New System.Drawing.Point(0, 226)
        Me.PicTotal.Name = "PicTotal"
        Me.PicTotal.Size = New System.Drawing.Size(782, 32)
        Me.PicTotal.TabIndex = 6
        '
        'lblTotalMarcado
        '
        Me.lblTotalMarcado.Location = New System.Drawing.Point(333, 9)
        Me.lblTotalMarcado.Name = "lblTotalMarcado"
        Me.lblTotalMarcado.Size = New System.Drawing.Size(125, 13)
        Me.lblTotalMarcado.TabIndex = 71
        Me.lblTotalMarcado.Text = "Total A Seleccionado"
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(597, 9)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(55, 13)
        Me.lblTotal.TabIndex = 70
        Me.lblTotal.Tag = "IdRec=6574;"
        Me.lblTotal.Text = "TOTAL A"
        '
        'txtTotalMarcado
        '
        Me.txtTotalMarcado.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalMarcado.Enabled = False
        Me.txtTotalMarcado.Location = New System.Drawing.Point(461, 9)
        Me.txtTotalMarcado.Name = "txtTotalMarcado"
        Me.txtTotalMarcado.Size = New System.Drawing.Size(122, 21)
        Me.txtTotalMarcado.TabIndex = 69
        '
        'txtTotal
        '
        Me.txtTotal.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(653, 9)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(122, 21)
        Me.txtTotal.TabIndex = 68
        '
        'lblObra
        '
        Me.lblObra.Location = New System.Drawing.Point(700, 19)
        Me.lblObra.Name = "lblObra"
        Me.lblObra.Size = New System.Drawing.Size(35, 13)
        Me.lblObra.TabIndex = 67
        Me.lblObra.Tag = "IdRec=5301;"
        Me.lblObra.Text = "Obra"
        '
        'AdvIDObra
        '
        Me.AdvIDObra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDObra.DisplayField = "NObra"
        Me.AdvIDObra.EntityName = "ObraCabecera"
        Me.AdvIDObra.Location = New System.Drawing.Point(700, 38)
        Me.AdvIDObra.Name = "AdvIDObra"
        Me.AdvIDObra.SecondaryDataFields = "IDObra"
        Me.AdvIDObra.Size = New System.Drawing.Size(78, 23)
        Me.AdvIDObra.TabIndex = 29
        Me.AdvIDObra.ViewName = "tbObraCabecera"
        '
        'txtTitulo
        '
        Me.txtTitulo.DisabledBackColor = System.Drawing.Color.White
        Me.txtTitulo.Location = New System.Drawing.Point(50, 165)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(132, 21)
        Me.txtTitulo.TabIndex = 7
        '
        'lblTitulo
        '
        Me.lblTitulo.Location = New System.Drawing.Point(4, 166)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(38, 13)
        Me.lblTitulo.TabIndex = 69
        Me.lblTitulo.Text = "Título"
        '
        'lblEmpresaGrupo
        '
        Me.lblEmpresaGrupo.Location = New System.Drawing.Point(524, 94)
        Me.lblEmpresaGrupo.Name = "lblEmpresaGrupo"
        Me.lblEmpresaGrupo.Size = New System.Drawing.Size(75, 13)
        Me.lblEmpresaGrupo.TabIndex = 70
        Me.lblEmpresaGrupo.Text = "Emp. Grupo"
        Me.lblEmpresaGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbxEmpresaGrupo
        '
        cbxEmpresaGrupo_DesignTimeLayout.LayoutString = resources.GetString("cbxEmpresaGrupo_DesignTimeLayout.LayoutString")
        Me.cbxEmpresaGrupo.DesignTimeLayout = cbxEmpresaGrupo_DesignTimeLayout
        Me.cbxEmpresaGrupo.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEmpresaGrupo.Location = New System.Drawing.Point(606, 90)
        Me.cbxEmpresaGrupo.Name = "cbxEmpresaGrupo"
        Me.cbxEmpresaGrupo.SelectedIndex = -1
        Me.cbxEmpresaGrupo.SelectedItem = Nothing
        Me.cbxEmpresaGrupo.Size = New System.Drawing.Size(54, 21)
        Me.cbxEmpresaGrupo.TabIndex = 25
        '
        'cbxAsignadoNPagare
        '
        cbxAsignadoNPagare_DesignTimeLayout.LayoutString = resources.GetString("cbxAsignadoNPagare_DesignTimeLayout.LayoutString")
        Me.cbxAsignadoNPagare.DesignTimeLayout = cbxAsignadoNPagare_DesignTimeLayout
        Me.cbxAsignadoNPagare.DisabledBackColor = System.Drawing.Color.White
        Me.cbxAsignadoNPagare.Location = New System.Drawing.Point(606, 65)
        Me.cbxAsignadoNPagare.Name = "cbxAsignadoNPagare"
        Me.cbxAsignadoNPagare.SelectedIndex = -1
        Me.cbxAsignadoNPagare.SelectedItem = Nothing
        Me.cbxAsignadoNPagare.Size = New System.Drawing.Size(54, 21)
        Me.cbxAsignadoNPagare.TabIndex = 24
        '
        'lblAsigNPagare
        '
        Me.lblAsigNPagare.Location = New System.Drawing.Point(524, 69)
        Me.lblAsigNPagare.Name = "lblAsigNPagare"
        Me.lblAsigNPagare.Size = New System.Drawing.Size(86, 13)
        Me.lblAsigNPagare.TabIndex = 73
        Me.lblAsigNPagare.Text = "Asig. Nº. Pag."
        '
        'lblEspecial
        '
        Me.lblEspecial.Location = New System.Drawing.Point(355, 167)
        Me.lblEspecial.Name = "lblEspecial"
        Me.lblEspecial.Size = New System.Drawing.Size(53, 13)
        Me.lblEspecial.TabIndex = 75
        Me.lblEspecial.Text = "Especial"
        '
        'cbxEspecial
        '
        cbxEspecial_DesignTimeLayout.LayoutString = resources.GetString("cbxEspecial_DesignTimeLayout.LayoutString")
        Me.cbxEspecial.DesignTimeLayout = cbxEspecial_DesignTimeLayout
        Me.cbxEspecial.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEspecial.Location = New System.Drawing.Point(440, 165)
        Me.cbxEspecial.Name = "cbxEspecial"
        Me.cbxEspecial.SelectedIndex = -1
        Me.cbxEspecial.SelectedItem = Nothing
        Me.cbxEspecial.Size = New System.Drawing.Size(83, 21)
        Me.cbxEspecial.TabIndex = 21
        '
        'txtImporteDesde
        '
        Me.txtImporteDesde.DisabledBackColor = System.Drawing.Color.White
        Me.txtImporteDesde.Location = New System.Drawing.Point(264, 139)
        Me.txtImporteDesde.Name = "txtImporteDesde"
        Me.txtImporteDesde.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtImporteDesde.Size = New System.Drawing.Size(88, 21)
        Me.txtImporteDesde.TabIndex = 13
        '
        'txtImporteHasta
        '
        Me.txtImporteHasta.DisabledBackColor = System.Drawing.Color.White
        Me.txtImporteHasta.Location = New System.Drawing.Point(264, 164)
        Me.txtImporteHasta.Name = "txtImporteHasta"
        Me.txtImporteHasta.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtImporteHasta.Size = New System.Drawing.Size(88, 21)
        Me.txtImporteHasta.TabIndex = 14
        '
        'lblFrasAgrup
        '
        Me.lblFrasAgrup.Location = New System.Drawing.Point(184, 69)
        Me.lblFrasAgrup.Name = "lblFrasAgrup"
        Me.lblFrasAgrup.Size = New System.Drawing.Size(75, 13)
        Me.lblFrasAgrup.TabIndex = 200
        Me.lblFrasAgrup.Text = "Fact. Agrup."
        '
        'txtFrasAgrup
        '
        Me.txtFrasAgrup.DisabledBackColor = System.Drawing.Color.White
        Me.txtFrasAgrup.Location = New System.Drawing.Point(264, 65)
        Me.txtFrasAgrup.Name = "txtFrasAgrup"
        Me.txtFrasAgrup.Size = New System.Drawing.Size(88, 21)
        Me.txtFrasAgrup.TabIndex = 10
        '
        'clbFechaPagoDesde
        '
        Me.TryDataBinding(clbFechaPagoDesde, New System.Windows.Forms.Binding("BindableValue", Me, "FechaPago", True))
        Me.clbFechaPagoDesde.DisabledBackColor = System.Drawing.Color.White
        Me.clbFechaPagoDesde.Location = New System.Drawing.Point(708, 68)
        Me.clbFechaPagoDesde.Name = "clbFechaPagoDesde"
        Me.clbFechaPagoDesde.Size = New System.Drawing.Size(71, 21)
        Me.clbFechaPagoDesde.TabIndex = 201
        '
        'lblFechaPago
        '
        Me.lblFechaPago.Location = New System.Drawing.Point(666, 73)
        Me.lblFechaPago.Name = "lblFechaPago"
        Me.lblFechaPago.Size = New System.Drawing.Size(94, 13)
        Me.lblFechaPago.TabIndex = 202
        Me.lblFechaPago.Text = "Fecha Pago >="
        '
        'clbFechaPago
        '
        Me.TryDataBinding(clbFechaPago, New System.Windows.Forms.Binding("BindableValue", Me, "FechaPago", True))
        Me.clbFechaPago.DisabledBackColor = System.Drawing.Color.White
        Me.clbFechaPago.Location = New System.Drawing.Point(708, 90)
        Me.clbFechaPago.Name = "clbFechaPago"
        Me.clbFechaPago.Size = New System.Drawing.Size(71, 21)
        Me.clbFechaPago.TabIndex = 203
        '
        'lblFechaPago1
        '
        Me.lblFechaPago1.Location = New System.Drawing.Point(666, 94)
        Me.lblFechaPago1.Name = "lblFechaPago1"
        Me.lblFechaPago1.Size = New System.Drawing.Size(94, 13)
        Me.lblFechaPago1.TabIndex = 204
        Me.lblFechaPago1.Text = "Fecha Pago <="
        '
        'CIPagoCont
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(790, 537)
        Me.EntityName = "Pago"
        Me.KeyField = "IDPago"
        Me.Name = "CIPagoCont"
        Me.UseCheck = True
        Me.ViewName = "frmPagos"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.cbxManual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxRemesado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxRiesgo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxFormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxBancoPropio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxIDEjercicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxSituacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxContabilizado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PicTotal.ResumeLayout(False)
        Me.PicTotal.PerformLayout()
        CType(Me.cbxEmpresaGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxAsignadoNPagare, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxEspecial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected mblnMarcaGenerarAsiento As Boolean
    Protected MIntTipoPago As Integer
    Protected mstrEjercicio As String
    Protected mblnSAAS As Boolean
    Protected mblnContabilidad As Boolean
    Protected mblnContabilidadMultiple As Boolean

    Protected mIDPagos(-1) As Object
    Protected mSituacion As enumPagoSituacion?

    Protected mNuevaSituacion As enumPagoSituacion
    Protected mCambiarSituacion As Boolean
    Protected mContabilizar As Boolean
    'Private mPagoImpreso2 As Boolean
    Private dblTotalMarcado As Double

    Private Enum IconIndex
        NoContabilizado = 0
        Contabilizado = 1
    End Enum

    Private Const cnABRIRPROV As String = "Ver Proveedor"
    Private Const cnEntidad As String = "FacturaCompraCabecera"
    Private Const cnABRIRFACTURACOMPRA As String = "Abrir Factura Compra"
    Private Const cnABRIROBRA As String = "Abrir Obra"
    Private Const cnABRIRREMESA As String = "Abrir Remesa"


    Private Sub CIPagoCont_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.RecordsState = RecordsState.Saved
        '//Al volver del informe de Cartas a Proveedores, hay que eliminar las marcas del servidor.
        If mblnDesmarcar AndAlso Not IsNothing(mobjGuid) Then
            DesmarcarRegistro(mobjGuid, FilterType.Numeric)
            mblnDesmarcar = False
        End If
    End Sub

#Region " Load "

    Protected Overridable Sub CIPagoCont_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadERPData()
            LoadEnums()
            LoadToolBarActions()
            LoadGridActions()
            InitFilterCriteria()
            LoadParams()
            If Not mIDPagos Is Nothing AndAlso mIDPagos.Length > 0 Then Me.Execute()
        End If
    End Sub

    Protected Overridable Sub LoadERPData()
        Dim p As New Parametro
        mblnContabilidadMultiple = p.ContabilidadMultiple
        mblnMarcaGenerarAsiento = p.GenerarAsientoPago
        MIntTipoPago = p.CTipoPagoFC
        mblnSAAS = p.ExpertisSAAS
        mblnContabilidad = p.Contabilidad
        If mblnContabilidad Then
            mstrEjercicio = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, Today)
        Else
            Me.AdvIDObra.Visible = False : Me.lblObra.Visible = False
            Me.AdvIDPagoPeriodico.Visible = False : Me.lblPagoPeriodico.Visible = False
            Me.cbxContabilizado.Visible = False : Me.lblContabilizado.Visible = False
            Me.cbxIDEjercicio.Visible = False : Me.lblEjercicio.Visible = False
        End If
        cbxEmpresa.DataSource = New Comunes().GetUserDataBase
        cbxEmpresa.DisplayMember = "BaseDatos"
        cbxEmpresa.ValueMember = "IDBaseDatos"
        cbxEspecial.Value = enumBoolean.No
        cbxEmpresa.Visible = Not mblnSAAS
        lblEmpresa.Visible = Not mblnSAAS


        If TypeOf Me.Params Is Hashtable Then
            If CType(Me.Params, Hashtable).ContainsKey("IDPagos") Then
                Dim IDPagos() As Integer = CType(Me.Params, Hashtable)("IDPagos")
                If IDPagos.Length > 0 Then
                    ReDim mIDPagos(IDPagos.Length)
                    IDPagos.CopyTo(mIDPagos, 0)
                End If
            End If
            If CType(Me.Params, Hashtable).ContainsKey("Situacion") Then
                mSituacion = CType(CType(Me.Params, Hashtable)("Situacion"), enumPagoSituacion)
            End If
        End If
    End Sub

    Protected Overridable Sub LoadEnums()
        cbxContabilizado.DataSource = New EnumData("enumContabilizadoTodos")
        If Not mblnContabilidadMultiple Then
            CType(cbxContabilizado.DataSource, DataView).RowFilter = "Name = 'enumContabilizadoTodos' AND Value <> " & enumContabilizado.ContabilizadoNIIF & " AND Value <> " & enumContabilizado.ContabilizadoTributario
        End If
        cbxManual.DataSource = New EnumData("enumBoolean")
        'cbxGrupo.DataSource = New EnumData("enumBoolean")
        'cbxImpreso.DataSource = New EnumData("enumBoolean")
        cbxRiesgo.DataSource = New EnumData("enumBoolean")
        cbxRemesado.DataSource = New EnumData("enumBoolean")
        cbxEmpresaGrupo.DataSource = New EnumData("enumBoolean")
        cbxAsignadoNPagare.DataSource = New EnumData("enumBoolean")
        cbxEspecial.DataSource = New EnumData("enumBoolean")
    End Sub

    Protected Overridable Sub LoadToolBarActions()
        If mblnContabilidad Then
            Me.FormActions.Add("Contabilización y Remesas", AddressOf AccionContabilizar)
            Me.FormActions.Add("Descontabilización", AddressOf AccionDescontabilizar)
            Me.FormActions.Add("Descontabilización Asiento Efectos", AddressOf AccionDescontabilizarEfectos)
        Else
            Me.FormActions.Add("Remesas / Ficheros / Documentos", AddressOf AccionContabilizarRemesa)
        End If
        Me.AddSeparator()
        Me.FormActions.Add("Añadir Pagos a Remesa", AddressOf AccionAñadirRemesa)
        Me.FormActions.Add("Retirar Pagos de Remesa", AddressOf AccionRetirarRemesa)
        Me.AddSeparator()
        Me.FormActions.Add("Agrupación de Pagos", AddressOf AccionAgrupacionPagos)
        Me.FormActions.Add("Desagrupación de Pagos", AddressOf AccionDesagrupacionPagos)
        Me.FormActions.Add("Ver Agrupación de Pagos", AddressOf AccionConsultaPagosAgrupados)
        Me.FormActions.Add("Desglose de Pago", AddressOf AccionDesglosarPagos)
        Me.AddSeparator()
        Me.FormActions.Add("Cambio de situación", AddressOf AccionCambioSituacion)
        Me.AddSeparator()
        Me.FormActions.Add("Modificación de Pagos", AddressOf AccionModificacion)
        Me.AddSeparator()
        Me.FormActions.Add("Pago Manual", AddressOf AccionPagoManual)
        Me.FormActions.Add("Eliminar Pagos", AddressOf AccionEliminarPagos)
        Me.AddSeparator()
        Me.FormActions.Add("Numeración de Pagarés", AddressOf AccionNumeracionPagares)
        Me.AddSeparator()
        Me.FormActions.Add("Generación de Pagos por Transferencia", AddressOf AccionPagosPorTransferencia)
        If New Parametro().Contabilidad Then
            Me.FormActions.Add("Descontabilización de Cheques/Pagarés Enviados", AddressOf AccionDescontabilizarEnviados)
        End If
        'If mblnContabilidad Then
        '    Me.AddSeparator()
        '    Me.FormActions.Add("Comparacion de Saldos Contables", AddressOf AccionComparacionSaldos)
        'End If
        If Not mblnSAAS Then
            'Me.FormActions.Add("Comparacion de Saldos Contables a Fecha", AddressOf AccionComparacionSaldosFecha)
            'Me.FormActions.Add("Comparacion de Saldos Contables a Fecha Desglosado", AddressOf AccionComparacionSaldosFechaDesglose)
            Me.AddSeparator()
            Me.FormActions.Add("Generar Cobros desde Pagos", AddressOf AccionAñadirCobro)
            Me.AddSeparator()
            Me.FormActions.Add("Contabilización Leasing", AddressOf AccionContabilizarLeasing)
            Me.FormActions.Add("Descontabilización Leasing", AddressOf AccionDescontabilizarLeasing)
        End If

    End Sub

    Protected Overridable Sub LoadGridActions()
        Grid.AddSeparator()
        Grid.Actions.Add(cnABRIRPROV, AddressOf Abrirproveedor, ExpertisApp.GetIcon("xProveedores.ico"))
        Grid.Actions.Add(cnABRIRREMESA, AddressOf AbrirRemesa)
        Grid.Actions.Add(cnABRIRFACTURACOMPRA, AddressOf AbrirFacturaCompra, ExpertisApp.GetIcon("xFacturaCompra.ico"))
        Grid.Actions.Add(cnABRIROBRA, AddressOf AbrirObra, ExpertisApp.GetIcon("xProyectos.ico"))
        'Grid.Actions.Add("Eliminar Pago Manual", AddressOf AccionEliminarPagos)
    End Sub

    Public Overridable Sub InitFilterCriteria()
        cbxTipo.Value = 0
        cbxTipo.Text = ""
        'txtTotalMarcado.Value = 0
        cbxContabilizado.Value = enumContabilizadoTodos.Todos
        cbxManual.Value = enumBoolean.Todos
        'cbxGrupo.Value = enumBoolean.Todos
        cbxRiesgo.Value = enumBoolean.Si
        'cbxImpreso.Value = enumBoolean.Todos
        If Not mSituacion Is Nothing Then
            cbxSituacion.Value = mSituacion
        Else
            cbxSituacion.Value = enumPagoSituacion.NoPagado
        End If
        cbxSituacion.Text = ""
        cbxRemesado.Value = enumBoolean.Todos
        cbxEmpresaGrupo.Value = enumBoolean.Todos
        cbxAsignadoNPagare.Value = enumBoolean.Todos
        cbxEspecial.Value = enumBoolean.No
    End Sub

    Protected Overridable Sub LoadParams()
        If Not Me.Params Is Nothing Then
            Dim HtParams As Hashtable = Me.Params
            If HtParams.ContainsKey("IDProveedor") Then
                Me.AdvIDProveedor.Value = HtParams("IDProveedor")
                Me.Execute()
            End If
        End If
    End Sub

#End Region

#Region " Acciones Toolbar "

#Region " Contabilizar "

    Public Sub AccionContabilizar()
        If Length(cbxEspecial.Value) = 0 Or cbxEspecial.Value = enumBoolean.Todos Then
            ExpertisApp.GenerateMessage("Seleccione si es o no un cobro especial.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.UncheckAll.InvokeOnClick()
        Else
            Contabilizar(, cbxEspecial.Value)
        End If
    End Sub
    Private Sub AccionContabilizarRemesa()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Grid.CheckedRecords
            If Not dtMarcados Is Nothing Then
                If Me.ShowAllCheckedItems.IsChecked Then
                    Me.ShowAllCheckedItems.InvokeOnClick()
                End If
                mIDProcess = Grid.SaveServerChecks()
                Dim strIDProcess As String = mIDProcess.ToString
                Dim strIdBancoPropio As String = String.Empty
                For Each drMarcados As DataRow In dtMarcados.Select
                    If Length(drMarcados("IDBancoPropio")) <> 0 Then
                        If strIdBancoPropio <> String.Empty And strIdBancoPropio <> drMarcados("IDBancoPropio") Then
                            strIdBancoPropio = String.Empty
                            Exit For
                        ElseIf strIdBancoPropio = String.Empty Then
                            strIdBancoPropio = drMarcados("IDBancoPropio")
                        End If
                    End If
                Next

                If Not ValidarRiesgoProveedor(dtMarcados) Then Exit Sub

                Dim FrmConta As New frmContabilizarRemesa
                If FrmConta.AbrirContabilizacion(strIdBancoPropio, dtMarcados, cbxEspecial.Value) = DialogResult.OK Then
                    QuitarMarcas()
                    txtTotalMarcado.Value = 0
                Else
                    Me.Execute()
                End If
            Else
                ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub
    Protected Overridable Sub Contabilizar(Optional ByVal blnCambioSituacionManual As Boolean = False, Optional ByVal blnEspecial As Boolean = False)

        If Grid.CheckedRecordsCount > 0 Then
            'Se diferencia el caso que no se haya seleccionados filas del que se hayan marcado pero sean de leasing
            Dim dtMarcados As DataTable = Grid.CheckedRecords
            If Not dtMarcados Is Nothing Then
                Dim dv As DataView = New DataView(dtMarcados)
                dv.RowFilter = "LeasingSN=1 OR Situacion= " & enumPagoSituacion.GeneradoCobro
                If dv.Count = 0 Then
                    'If Me.ShowAllCheckedItems.IsChecked Then
                    '    Me.ShowAllCheckedItems.InvokeOnClick()
                    'End If
                    mIDProcess = Grid.SaveServerChecks()

                    'Miramos si los pagos seleccionados tienen el mismo BPropio
                    Dim strIdBancoPropio As String = String.Empty
                    Dim IDPagos(-1) As Object
                    For Each drMarcados As DataRow In dtMarcados.Select
                        If Length(drMarcados("IDBancoPropio")) <> 0 Then
                            If strIdBancoPropio <> String.Empty And strIdBancoPropio <> drMarcados("IDBancoPropio") Then
                                strIdBancoPropio = String.Empty
                                Exit For
                            ElseIf strIdBancoPropio = String.Empty Then
                                strIdBancoPropio = drMarcados("IDBancoPropio")
                            End If
                        End If
                        ReDim Preserve IDPagos(IDPagos.Length)
                        IDPagos(IDPagos.Length - 1) = drMarcados("IDPago")
                    Next

                    If Not ValidarRiesgoProveedor(dtMarcados) Then Exit Sub


                    Dim blnGenerarAsientoPago, blnGenerarAsientoTalon, blnGenerarAsientoEfectos, blnAgruparBanco As Boolean
                    Dim strDescApunte As String = String.Empty
                    Dim strNDocumento As String = String.Empty
                    Dim strEjercicio As String = String.Empty
                    Dim dtmFechaValor, dtmFechaApunte As Date
                    Dim intNuevaSituacion As Integer
                    Dim dblImporteBanco, dblComision As Double
                    Dim r As DialogResult

                    Dim frm As New frmContabilizar
                    frm.GenerarAsiento = mblnMarcaGenerarAsiento
                    r = frm.AbrirContabilizacion(blnGenerarAsientoPago, blnGenerarAsientoTalon, blnGenerarAsientoEfectos, strNDocumento, _
                                                 dtmFechaApunte, dtmFechaValor, strIdBancoPropio, intNuevaSituacion, _
                                                 strEjercicio, blnAgruparBanco, strDescApunte, _
                                                 dblImporteBanco, dblComision, blnCambioSituacionManual, dtMarcados, blnEspecial)

                    If r = DialogResult.OK Then
                        '''''''''''''''''
                        ' AVISO para las facturas seleccionadas que no se procesan
                        '''''''''''''''''
                        Dim dt As DataTable = Nothing
                        Dim f As New Filter
                        f.Add(New GuidFilterItem("IDProcess", mIDProcess))
                        If blnGenerarAsientoPago Then
                            dt = New BE.DataEngine().Filter("CtlCIPagoContValidacion", f, "IDPago")
                        ElseIf blnGenerarAsientoEfectos Then
                            dt = New BE.DataEngine().Filter("CtlCIEfectosContValidacion", f, "IDPago")
                        ElseIf blnGenerarAsientoTalon Then
                            dt = New BE.DataEngine().Filter("CtlCITalonContValidacion", f, "IDPago")
                        End If
                        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
                            ExpertisApp.GenerateMessage("Existen pagos seleccionados contabilizados que no intervendrán en el proceso.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                        'mPagoImpreso = False
                        mContabilizar = False
                        If blnGenerarAsientoPago OrElse blnGenerarAsientoEfectos OrElse blnGenerarAsientoTalon Then mContabilizar = True
                        If Not blnGenerarAsientoPago AndAlso Not blnGenerarAsientoEfectos AndAlso Not blnGenerarAsientoTalon Then 'OrElse frm.PagoImpreso Then
                            mNuevaSituacion = intNuevaSituacion
                            mCambiarSituacion = True
                            'mPagoImpreso = frm.PagoImpreso
                        End If

                        Dim SimInfo As New DataSimulacionContableInfoPago
                        SimInfo.GuidSimulacion = mIDProcess
                        SimInfo.IDEjercicio = strEjercicio
                        SimInfo.FechaApunte = dtmFechaApunte
                        SimInfo.AgruparPorBanco = blnAgruparBanco
                        'SimInfo.CambioSituacion = True
                        SimInfo.NuevaSituacionPago = intNuevaSituacion
                        SimInfo.IDBancoPropio = strIdBancoPropio
                        SimInfo.DescApunte = strDescApunte
                        SimInfo.FechaValor = dtmFechaValor
                        SimInfo.NDocumento = strNDocumento
                        SimInfo.ImporteBanco = dblImporteBanco
                        SimInfo.Comision = dblComision
                        If blnGenerarAsientoPago Then
                            SimInfo.Caption = ExpertisApp.Traslate("Simulación Contable - PAGOS -")
                            SimInfo.TipoContabilizacion = enumTipoContabilizacion.tcPago
                            SimInfo.GenerarDiferenciaCambio = frm.GenerarDiferenciaCambio
                            Dim oFrm As Form = ExpertisApp.OpenForm("CISIMUCont", , SimInfo, Me)
                            AddHandler oFrm.Closed, AddressOf FrmActionClosed
                        End If
                        If blnGenerarAsientoEfectos Then
                            SimInfo.Caption = ExpertisApp.Traslate("Simulación Contable - REMESA PAGOS -")
                            SimInfo.TipoContabilizacion = enumTipoContabilizacion.tcRemesaPago
                            Dim oFrm As Form = ExpertisApp.OpenForm("CISIMUCont", , SimInfo, Me)
                            AddHandler oFrm.Closed, AddressOf FrmActionClosed
                        End If
                        If blnGenerarAsientoTalon Then
                            SimInfo.Caption = ExpertisApp.Traslate("Simulación Contable - TALON -")
                            SimInfo.TipoContabilizacion = enumTipoContabilizacion.tcTalon
                            Dim oFrm As Form = ExpertisApp.OpenForm("CISIMUCont", , SimInfo, Me)
                            AddHandler oFrm.Closed, AddressOf FrmActionClosed
                        End If

                        If Not blnGenerarAsientoPago AndAlso Not blnGenerarAsientoEfectos AndAlso Not blnGenerarAsientoTalon Then
                            If mCambiarSituacion Then
                                Dim dtPagos As DataTable = New BE.DataEngine().Filter(Me.ViewName, New InListFilterItem("IDPago", IDPagos, FilterType.Numeric))
                                Dim datCambio As New Pago.DataCambioSituacionManual(dtPagos, mNuevaSituacion)
                                ExpertisApp.ExecuteTask(Of Pago.DataCambioSituacionManual, ClassErrors())(AddressOf Pago.CambioSituacionManual, datCambio)
                                mCambiarSituacion = False
                            End If
                            QuitarMarcas()
                            txtTotalMarcado.Value = 0
                        End If
                    ElseIf r = DialogResult.Cancel And blnCambioSituacionManual Then
                        QuitarMarcas()
                        txtTotalMarcado.Value = 0
                    End If
                Else
                    ExpertisApp.GenerateMessage("Los pagos seleccionados son pagos de leasing. Para contabilizarlos debe seleccionar la opción Contabilización Leasing.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

#End Region

#Region "Añadir/Quitar Pagos - Remesas"

    Private Sub AccionAñadirRemesa()
        If Grid.CheckedRecordsCount > 0 Then
            Dim DtGrid As DataTable = Grid.CheckedRecords
            If Not DtGrid Is Nothing AndAlso DtGrid.Rows.Count > 0 Then
                Dim DrRe() As DataRow = DtGrid.Select("IDRemesa NOT IS NULL")
                If DrRe.Length = 0 Then
                    Dim DrCont() As DataRow = DtGrid.Select("Contabilizado = " & enumPagoContabilizado.PagoContabilizado)
                    If DrCont.Length = 0 Then

                        If Not ValidarRiesgoProveedor(DtGrid) Then Exit Sub

                        Dim FrmInsertRemesa As New frmRemesa
                        If FrmInsertRemesa.ShowDialog() = DialogResult.OK Then
                            If ExpertisApp.GenerateMessage("Se añadirán los Pagos a la remesa. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                Dim datos As New Pago.DataAñadirPagosARemesa
                                datos.IDRemesa = FrmInsertRemesa.IDRemesa
                                datos.PagosAAñadir = DtGrid
                                ExpertisApp.ExecuteTask(Of Pago.DataAñadirPagosARemesa)(AddressOf Pago.AñadirPagosARemesa, datos)
                                QuitarMarcas()
                            End If
                        End If
                    Else
                        ExpertisApp.GenerateMessage("Hay pagos seleccionados que están contabilizados, descontabilice los pagos para añadirlos a una remesa.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    ExpertisApp.GenerateMessage("Hay pagos seleccionados que ya están asociados a una remesa.|Por favor, revise las selecciones de los pagos.", MessageBoxButtons.OK, MessageBoxIcon.Information, vbNewLine)
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar algún Pago.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub AccionRetirarRemesa()
        If Grid.CheckedRecordsCount > 0 Then
            Dim Msg As String = "Se van retirar los Pagos seleccionados de sus Pemesas."
            Dim p As New Parametro
            If p.Contabilidad Then
                Msg = Msg & " Sólo se tendrán en cuenta los Pagos No Contabilizados."
            End If
            Msg = Msg & "{0}¿Desea continuar? "

            If ExpertisApp.GenerateMessage(Msg, MessageBoxButtons.YesNo, MessageBoxIcon.Question, vbNewLine) = DialogResult.Yes Then
                Dim DrSel() As DataRow = Grid.CheckedRecords.Select("GeneradoAsientoRemesa = 1")
                If DrSel.Length <= 0 Then
                    Dim i As Integer
                    Dim IDPagos(-1) As String
                    Dim f As New Filter
                    f.Add(New BooleanFilterItem("Contabilizado", False))
                    For Each dr As DataRow In Grid.CheckedRecords.Select(f.Compose(New AdoFilterComposer))
                        ReDim Preserve IDPagos(i)
                        IDPagos(i) = dr("IDPago")
                        i += 1
                    Next
                    ExpertisApp.ExecuteTask(Of String())(AddressOf Pago.RetirarPagosDeRemesas, IDPagos)
                    QuitarMarcas()
                Else
                    ExpertisApp.GenerateMessage("La Remesa está contabilizada. Debe eliminar Previamente este asiento")
                    QuitarMarcas()
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar algún Pago.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

#End Region

#Region " Descontabilizar "
    Protected Overridable Sub AccionDescontabilizar()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Me.CheckedRecords
            'Comprobamos si los pagos marcados se pueden descontabilizar
            Dim dv As DataView = dtMarcados.DefaultView
            dv.RowFilter = "Contabilizado<>0 and LEASINGSN=0"
            If dv.Count = 0 Then
                ExpertisApp.GenerateMessage("No se pueden descontabilizar los pagos seleccionados.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                mIDProcess = Grid.SaveServerChecks()
                Dim frm As New frmDescontabilizar
                frm.AbrirFormulario()
            End If
            QuitarMarcas()
            txtTotalMarcado.Value = 0
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Protected Overridable Sub AccionDescontabilizarEfectos()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Me.CheckedRecords
            'Comprobamos si los pagos marcados se pueden descontabilizar

            Dim f As New Filter
            f.Add(New IsNullFilterItem("IDRemesa", False))
            f.Add(New NumberFilterItem("GeneradoAsientoRemesa", FilterOperator.NotEqual, enumContabilizado.NoContabilizado))
            Dim adr() As DataRow = dtMarcados.Select(f.Compose(New AdoFilterComposer))
            If Not adr Is Nothing AndAlso adr.Length > 0 Then
                ExpertisApp.GenerateMessage("Para descontabilizar remesas debe hacerlo desde 'Consulta de Remesas'.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                QuitarMarcas()
                txtTotalMarcado.Value = 0
                Exit Sub
            End If

            f.Clear()
            f.Add(New NumberFilterItem("GeneradoAsientoRemesa", FilterOperator.NotEqual, enumContabilizado.NoContabilizado))
            f.Add(New NumberFilterItem("Contabilizado", FilterOperator.NotEqual, enumContabilizado.Contabilizado))
            adr = dtMarcados.Select(f.Compose(New AdoFilterComposer))
            If adr Is Nothing OrElse adr.Length = 0 Then
                ExpertisApp.GenerateMessage("No se pueden descontabilizar los pagos seleccionados.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                mIDProcess = Grid.SaveServerChecks()
                Dim frm As New frmDescontabilizarEfectos
                frm.AbrirFormulario()
            End If
            QuitarMarcas()
            txtTotalMarcado.Value = 0
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    'Public Sub AccionDescontabilizarRemesa()
    '    If Grid.CheckedRecordsCount > 0 Then
    '        Dim dtMarcados As DataTable = Me.CheckedRecords
    '        'Comprobamos si los pagos marcados se pueden descontabilizar
    '        Dim dv As DataView = dtMarcados.DefaultView
    '        dv.RowFilter = "GeneradoAsientoRemesa = 1 and contabilizado = 0"
    '        If dv.Count = 0 Then
    '            ExpertisApp.GenerateMessage("No se pueden descontabilizar los pagos seleccionados.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        Else
    '            mIDProcess = Grid.SaveServerChecks()
    '            Dim frm As New frmDescontabilizarRemesa
    '            frm.AbrirFormulario()
    '        End If
    '        QuitarMarcas()
    '        txtTotalMarcado.Value = 0
    '    Else
    '        ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '    End If
    'End Sub

    Protected Overridable Sub AccionDescontabilizarEnviados()
        Me.Cursor = Cursors.Default
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Me.CheckedRecords
            Dim p As New Parametro
            Dim strValor As String = p.DescontabilizarPagaresEnviados
            Dim EP As New EstadoPago
            Dim dtEstadoPago As DataTable = EP.SelOnPrimaryKey(strValor)
            If Not IsNothing(dtEstadoPago) AndAlso dtEstadoPago.Rows.Count > 0 Then
                If ExpertisApp.GenerateMessage("Se van a seleccionar únicamente aquellos pagos que están en la situación | y que están No Contabilizados.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, dtEstadoPago.Rows(0)("DescEstado")) = DialogResult.OK Then
                    Dim dv As DataView = dtMarcados.DefaultView
                    dv.RowFilter = "Situacion=" & strValor & " AND Contabilizado<>1"
                    If dv.Count = 0 Then
                        ExpertisApp.GenerateMessage("No hay Pagos seleccionados que cumplan esas condiciones.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        mIDProcess = Grid.SaveServerChecks()
                        Dim objfrmDescont As New frmDescontabilizarEnviados
                        objfrmDescont.AbrirFormulario(strValor)
                    End If
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        Me.Cursor = Cursors.WaitCursor
        QuitarMarcas()
        txtTotalMarcado.Value = 0
        Me.Cursor = Cursors.Default
    End Sub
#End Region

#Region " Agrupaciones  "
    Public Sub AccionAgrupacionPagos()
        Dim oFrm As Form = ExpertisApp.OpenForm("CIPAAGR", , , Me)
        AddHandler oFrm.Closed, AddressOf FrmActionClosed
    End Sub

    Public Sub AccionDesagrupacionPagos()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Grid.CheckedRecords

            Dim frm As New FrmDesagrupaPagos
            frm.AbrirFormulario(dtMarcados)
            QuitarMarcas()
            txtTotalMarcado.Value = 0
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Public Sub AccionConsultaPagosAgrupados()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Grid.CheckedRecords

            Dim frm As New FrmDesagrupaPagos
            frm.AbrirFormulario(dtMarcados, True)

            QuitarMarcas()
            txtTotalMarcado.Value = 0
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)  'Debe seleccionar alguna fila.
        End If
    End Sub

#End Region

#Region " Desglose Pagos "

    Private Function PagoAgrupado(ByVal intIdPago As Integer) As Integer
        Dim intTotal As Integer
        If intIdPago > 0 Then
            Dim dtPago As DataTable = New Pago().Filter(New NumberFilterItem("IdPagoAgrupado", intIdPago))
            If Not IsNothing(dtPago) Then
                intTotal = dtPago.Rows.Count
            End If
        End If

        Return intTotal
    End Function

    Public Sub AccionDesglosarPagos()
        If Grid.CheckedRecordsCount = 1 Then
            Dim dtMarcados As DataTable = Grid.CheckedRecords
            If Not IsNothing(dtMarcados) AndAlso dtMarcados.Rows.Count > 0 Then
                'If dtMarcados.Rows(0)("Situacion") = enumPagoSituacion.NoPagado _
                If ExpertisApp.ExecuteTask(Of enumPagoSituacion, Boolean)(AddressOf Pago.EsDesagrupable, dtMarcados.Rows(0)("Situacion")) AndAlso _
                   dtMarcados.Rows(0)("Contabilizado") = enumPagoContabilizado.PagoNoContabilizado AndAlso _
                   PagoAgrupado(dtMarcados.Rows(0)("IDPago")) = 0 AndAlso Length(dtMarcados.Rows(0)("IDRemesa")) = 0 Then
                    mIDProcess = Grid.SaveServerChecks()
                    Dim frm As New frmDesglosarPagos
                    frm.AbrirDesglosePago(dtMarcados, Me)

                    QuitarMarcas()
                    txtTotalMarcado.Value = 0
                Else
                    ExpertisApp.GenerateMessage("No se pueden desglosar pagos Contabilizados, Remesados, Agrupados o aquellos cuya situación no sea Desagrupable.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)  'Debe seleccionar alguna fila.
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar solo una fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
#End Region

#Region " Cambio Situación "
    Public Sub AccionCambioSituacion()

        If Not Grid.DataSource Is Nothing AndAlso Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Grid.CheckedRecords
            If IsNothing(dtMarcados) OrElse dtMarcados.Rows.Count = 0 Then
                ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim dv As DataView = dtMarcados.DefaultView
                dv.RowFilter = "IDCobro is null"
                If dv.Count <> dtMarcados.Rows.Count Then
                    ExpertisApp.GenerateMessage("No se puede cambiar el estado de los pagos en situación de generado cobro.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Dim frm As New FrmCambioSituacion
                'Dim blnContabilizar As Boolean
                frm.AbrirCambioSituacion(dtMarcados, Me)
                If frm.BlnContabilizar Then
                    Contabilizar(True)
                Else
                    QuitarMarcas()
                    txtTotalMarcado.Value = 0
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

#End Region

#Region " Modificacion Pagos "
    Public Sub AccionModificacion()
        Dim blnContabilizado As Boolean = False
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Me.CheckedRecords
            If Not dtMarcados Is Nothing AndAlso dtMarcados.Rows.Count > 0 Then
                'For Each drMarcados As DataRow In dtMarcados.Rows
                '    If drMarcados("Contabilizado") = True Then
                '        blnContabilizado = True
                '    End If
                'Next
                'If Not blnContabilizado Then
                Dim frm As New frmModifPagos
                mIDProcess = Grid.SaveServerChecks()

                If frm.AbrirModificacionPagos(mIDProcess.ToString, Me) = DialogResult.OK Then
                    QuitarMarcas()
                End If
                'Else
                '    ExpertisApp.GenerateMessage(10964, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, ExpertisApp.Title)  'Hay algún pago contabilizado
                'End If
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#End Region

#Region " Pago manual "
    Public Sub AccionPagoManual()
        Dim frm As New frmPagoManual
        If frm.AbrirPagosManual(Me) = DialogResult.OK Then
            Me.Execute()
        End If
    End Sub

#End Region

#Region " Borrado Pagos "
    Public Sub AccionEliminarPagos()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Me.CheckedRecords
            If Not IsNothing(dtMarcados) AndAlso dtMarcados.Rows.Count > 0 Then
                If ExpertisApp.GenerateMessage("Se borrarán los pagos seleccionados que no estén Contabilizados ni Pagados y no dependan de una factura. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim IDPagos(-1) As Object
                    For Each pa As DataRow In dtMarcados.Rows
                        ReDim Preserve IDPagos(IDPagos.Length)
                        IDPagos(IDPagos.Length - 1) = pa("IDPago")
                    Next

                    ExpertisApp.ExecuteTask(Of Object())(AddressOf Pago.DeletePagoManual, IDPagos)
                    QuitarMarcas()
                    txtTotalMarcado.Value = 0
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#End Region

    '#Region " Comparacion saldos "
    '    Public Sub AccionComparacionSaldos()
    '        Dim HT As New Hashtable
    '        HT("Origen") = enumOrigenDetalle.tdPago
    '        If ExpertisApp.IsFormOpen("CONSALDO") Then ExpertisApp.CloseForm("CONSALDO")
    '        ExpertisApp.OpenForm("CONSALDO", , HT, Me)
    '        txtTotalMarcado.Value = 0
    '    End Sub

    '    Public Sub AccionComparacionSaldosFecha()
    '        Dim HT As New Hashtable
    '        HT("Origen") = enumOrigenDetalle.tdPago
    '        If ExpertisApp.IsFormOpen("CONSALDOF") Then ExpertisApp.CloseForm("CONSALDOF")
    '        ExpertisApp.OpenForm("CONSALDOF", , HT, Me)
    '        txtTotalMarcado.Value = 0
    '    End Sub

    '    Public Sub AccionComparacionSaldosFechaDesglose()
    '        Dim HT As New Hashtable
    '        HT("Origen") = enumOrigenDetalle.tdPago
    '        If ExpertisApp.IsFormOpen("CONSALDOFD") Then ExpertisApp.CloseForm("CONSALDOFD")
    '        ExpertisApp.OpenForm("CONSALDOFD", , HT, Me)
    '        txtTotalMarcado.Value = 0
    '    End Sub

    '#End Region

#Region " Añadir Cobros desde Pagos "
    Private Sub AccionAñadirCobro()
        If Grid.CheckedRecordsCount = 1 Then
            Dim dtMarcados As DataTable = Grid.CheckedRecords
            If Not IsNothing(dtMarcados) AndAlso dtMarcados.Rows.Count > 0 Then
                If dtMarcados.Rows(0)("Situacion") = enumPagoSituacion.NoPagado _
                   And dtMarcados.Rows(0)("Contabilizado") = enumPagoContabilizado.PagoNoContabilizado _
                   And PagoAgrupado(dtMarcados.Rows(0)("IDPago")) = 0 _
                   And dtMarcados.Rows(0)("ImpVencimiento") < 0 Then
                    ExpertisApp.ExecuteTask(Of Integer)(AddressOf Cobro.InsertarCobroDesdePago, dtMarcados.Rows(0)("IDPago"))
                    QuitarMarcas()
                    txtTotalMarcado.Value = 0
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar solo una fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#End Region

#Region " LEASING "

    Protected Overridable Sub AccionContabilizarLeasing()
        ContabilizarLeasing()
    End Sub

    Protected Overridable Sub ContabilizarLeasing()
        Dim dtMarcados As DataTable = Grid.CheckedRecords
        If Not dtMarcados Is Nothing OrElse dtMarcados.Rows.Count > 0 Then
            Dim dv As DataView = dtMarcados.DefaultView
            dv.RowFilter = "LeasingSN = 0 OR (LeasingSN = 1 AND Contabilizado = " & enumContabilizado.Contabilizado & ")"
            If dv.Count > 0 Then
                If mblnContabilidadMultiple Then
                    ExpertisApp.GenerateMessage("Debe seleccionar registros de Leasing y No Contabilizados o Contabilizados parcialmente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                    ExpertisApp.GenerateMessage("Debe seleccionar registros de Leasing y No Contabilizados.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("No hay registros marcados.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        mIDProcess = Grid.SaveServerChecks()
        Dim blnContabilizar As Boolean
        Dim IDPagosFacturables(-1) As Integer
        IDPagosFacturables = TratarDatosContabilizarLeasing()
        If Not IDPagosFacturables Is Nothing AndAlso IDPagosFacturables.Length > 0 Then
            Me.Cursor = Cursors.WaitCursor
            '////
            Dim datos As New DataPrcFacturacionCompraLeasing(IDPagosFacturables, AdvIDContador.Text & String.Empty)
            Dim BEDataEngine As New BE.DataEngine
            Dim Propuesta As ResultFacturacion = BEDataEngine.RunProcess(GetType(PrcFacturacionCompraLeasing), datos)
            Me.Cursor = Cursors.Default
            If Not Propuesta Is Nothing Then
                If Not Propuesta.PropuestaFacturas Is Nothing AndAlso Propuesta.PropuestaFacturas.Rows.Count > 0 Then
                    Dim frm As New FrmPagoLeasing
                    If frm.MainFunction(Propuesta.PropuestaFacturas) = Windows.Forms.DialogResult.OK Then
                        If ExpertisApp.GenerateMessage("Se va a proceder a la Facturación de las líneas seleccionadas. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, ExpertisApp.Title) = Windows.Forms.DialogResult.Yes Then
                            Dim datosAct As New DataPrcActualizarFactura(Propuesta)
                            Propuesta = BEDataEngine.RunProcess(GetType(PrcActualizarFacturaCompra), datosAct)
                            TratarLog(Propuesta.Log, enumTipoDocumentoCreado.FacturaCompra, True, False)
                            If Not Propuesta.Log.CreatedElements Is Nothing AndAlso Propuesta.Log.CreatedElements.Length > 0 Then
                                blnContabilizar = True
                            End If
                        End If
                    End If
                Else
                    TratarLog(Propuesta.Log, enumTipoDocumentoCreado.FacturaCompra, True, False)
                End If
            Else
                ExpertisApp.GenerateMessage("Revise los datos seleccionados. No hay datos a Facturar.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            txtTotalMarcado.Value = 0
        Else
            If mblnContabilidadMultiple Then
                blnContabilizar = True '//Podemos tener contabilizaciones parciales en las que se crea la factura y luego sólo contabilizamos
            Else
                ExpertisApp.GenerateMessage("Los pagos seleccionados son pagos de leasing. Para contabilizarlos debe seleccionar la opción Contabilización Leasing.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        If blnContabilizar Then
            Dim SimInfo As New DataSimulacionContableInfo(enumTipoContabilizacion.tcLeasing)
            SimInfo.GuidSimulacion = mIDProcess
            SimInfo.NuevaSituacion = enumPagoSituacion.Pagado
            SimInfo.Caption = ExpertisApp.Traslate("Simulación Contable - PAGOS PERIODICOS -")
            Dim oFrm As Form = ExpertisApp.OpenForm("CISIMUCont", , SimInfo, Me)
            AddHandler oFrm.Closed, AddressOf FrmActionClosed
        End If

        Me.Execute()
        Me.UnCheckAllRecords()
    End Sub

    'Private Function TratarDatosContabilizarLeasing(ByRef dt As DataTable) As Boolean
    '    If Grid.CheckedRecordsCount > 0 Then
    '        'Se diferencia el caso que no se haya seleccionados filas del que se hayan marcado pero sean de leasing
    '        Dim dtMarcados As DataTable = Grid.CheckedRecords
    '        If Not dtMarcados Is Nothing Then
    '            Dim dv As DataView = dtMarcados.DefaultView
    '            dv.RowFilter = "LeasingSN=1"
    '            If dv.Count > 0 Then
    '                dt = New DataTable
    '                dt.Columns.Add("IdPago", GetType(Integer))
    '                dt.Columns.Add("IdProveedor", GetType(String))
    '                dt.Columns.Add("IdFactura", GetType(Integer))
    '                dt.Columns.Add("NFactura", GetType(String))
    '                dt.Columns.Add("FechaVencimiento", GetType(Date))
    '                dt.Columns.Add("SuFechaFactura", GetType(Date))
    '                dt.Columns.Add("SuFactura", GetType(String))

    '                For Each drv As DataRowView In dv
    '                    Dim dr As DataRow = dt.NewRow
    '                    If Length(drv.Row("IDFactura")) = 0 Then
    '                        dr("IdPago") = drv.Row("IdPago")
    '                        dr("IDProveedor") = drv.Row("IDProveedor")
    '                        dr("FechaVencimiento") = drv.Row("FechaVencimiento")
    '                        dr("SuFechaFactura") = drv.Row("FechaVencimiento")
    '                    End If
    '                    dt.Rows.Add(dr)
    '                Next
    '            End If
    '        End If
    '    End If

    '    If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function

    Private Function TratarDatosContabilizarLeasing() As Integer()
        Dim IDPagos(-1) As Integer

        If Grid.CheckedRecordsCount > 0 Then
            'Se diferencia el caso que no se haya seleccionados filas del que se hayan marcado pero sean de leasing
            Dim dtMarcados As DataTable = Grid.CheckedRecords
            If Not dtMarcados Is Nothing Then
                Dim dv As DataView = dtMarcados.DefaultView
                dv.RowFilter = "LeasingSN=1"
                If dv.Count > 0 Then
                    For Each drv As DataRowView In dv
                        If Length(drv.Row("IDFactura")) = 0 Then
                            ReDim Preserve IDPagos(IDPagos.Length)
                            IDPagos(IDPagos.Length - 1) = drv.Row("IDPago")
                        End If
                    Next
                End If
            End If
        End If
        Return IDPagos
    End Function


    Protected Overridable Sub AccionDescontabilizarLeasing()
        Dim dtGrid As DataTable = Me.CheckedRecords
        If Not dtGrid Is Nothing Then
            mIDProcess = Grid.SaveServerChecks()
            If dtGrid.Rows.Count > 0 Then
                Dim dvGrid As New DataView(dtGrid)
                dvGrid.RowFilter = "LeasingSN=1 AND Contabilizado <> " & enumContabilizado.NoContabilizado
                If dvGrid.Count > 0 Then
                    'Comprobamos si los pagos marcados se pueden descontabilizar
                    Dim frm As New frmDescontabilizar
                    frm.AbrirFormulario(True)
                Else
                    ExpertisApp.GenerateMessage("No se pueden descontabilizar los pagos seleccionados.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        QuitarMarcas()
        txtTotalMarcado.Value = 0
    End Sub

    Private Sub AccionModificacionLeasing()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Me.CheckedRecords
            If Not dtMarcados Is Nothing Then
                Dim dv As DataView = dtMarcados.DefaultView
                dv.RowFilter = "LeasingSN=1"
                If dv.Count > 0 Then
                    Dim frm As New frmModificarLeasing
                    frm.MainFunction()
                End If

                QuitarMarcas()
                txtTotalMarcado.Value = 0
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        'rs = Me.CheckedRecords
        'If rs.RecordCount > 0 Then
        '    strFiltro = "LeasingSN=1"
        '    rs.Filter = strFiltro
        '    If rs.RecordCount > 0 Then
        '        frm.MainFunction()
        '    Else
        '        ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Error, ExpertisApp.Title) 'No hay filas seleccionadas.
        '    End If
        '    QuitarMarcas()
        '    fwiTotalMarcado.Value = 0
        'End If

    End Sub

#End Region

#Region " Remesa "
    Private Sub AccionRemesaPago()
        If Grid.CheckedRecordsCount > 0 Then
            Dim dtMarcados As DataTable = Me.CheckedRecords
            Dim dv As DataView = dtMarcados.DefaultView

            dv.RowFilter = "IdRemesa IS NULL"
            If dv.Count = 0 Then
                ExpertisApp.GenerateMessage("Debe seleccionar pagos que no pertenezcan a una remesa", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                mIDProcess = Grid.SaveServerChecks()
                Dim frm As New frmRemesaPago
                If frm.AbrirRemesa(Me) = DialogResult.OK Then
                    Dim datos As New Pago.DataAsociarPagoARemesa
                    datos.IDProcess = mIDProcess
                    datos.IDRemesa = frm.IDRemesa
                    datos.IDBancoPropio = frm.IDBancoPropio
                    datos.Impreso = (Length(frm.mstrRuta) > 0)
                    ExpertisApp.ExecuteTask(Of Pago.DataAsociarPagoARemesa)(AddressOf Pago.AsociarPagoARemesa, datos)
                End If
            End If
            QuitarMarcas()
            txtTotalMarcado.Value = 0
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#End Region

#Region "Generación Pagos por transferencia"

    Protected Sub AccionPagosPorTransferencia()

        Dim blnContabilizado As Boolean = False
        If Grid.CheckedRecordsCount > 0 Then 'Si tengo marcado mas de una columna check

            If Not Me.CheckedRecords Is Nothing AndAlso Me.CheckedRecords.Rows.Count > 0 Then 'Si hay filas seleccionadas

                Dim frm As New frmGeneracionPagosTransferencia 'me abres esta ventana
                mIDProcess = Grid.SaveServerChecks()

                If frm.AbrirGeneracionPagosTransferencia(mIDProcess.ToString, Me) = DialogResult.OK Then
                    QuitarMarcas()
                End If
            End If
        Else 'sino no hace nada
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

#End Region

#Region "Numeración Pagarés"

    Protected Sub AccionNumeracionPagares()
        If Grid.CheckedRecordsCount > 0 Then
            Dim IDPagos(-1) As Object
            For Each drPago As DataRow In Grid.CheckedRecords.Rows
                ReDim Preserve IDPagos(IDPagos.Length)
                IDPagos(IDPagos.Length - 1) = drPago("IDPago")
            Next
            If ExpertisApp.ExecuteTask(Of Object(), Boolean)(AddressOf Pago.NumeracionPagares, IDPagos) Then
                ExpertisApp.GenerateMessage("Numeración de Pagarés Finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.UnCheckAllRecords()
                Me.ExecuteQuery.InvokeOnClick()
                txtTotalMarcado.Value = 0
            Else
                ExpertisApp.GenerateMessage("Error en el proceso de Numeración de Pagarés", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else    'Si no hay filas en la consulta
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub
#End Region

#End Region

#Region " Acciones Grid "

    Private Sub Abrirproveedor()
        ExpertisApp.OpenForm("MPROV", New StringFilterItem("IDProveedor", FilterOperator.Equal, Grid.Value("IDProveedor")))
    End Sub

    Private Sub AbrirFacturaCompra()
        ExpertisApp.OpenForm("MFACC", New NumberFilterItem("IdFactura", FilterOperator.Equal, Grid.Value("IdFactura")))
    End Sub

    Private Sub AbrirObra()
        ExpertisApp.OpenForm("MGEO", New NumberFilterItem("IdObra", FilterOperator.Equal, Grid.Value("IdObra")))
    End Sub

    Private Sub AbrirRemesa()
        If Length(Grid.Value("IDRemesa")) > 0 Then
            Dim strAlias As String = "CIREMPAGO"
            If ExpertisApp.IsFormOpen(strAlias) Then ExpertisApp.CloseForm(strAlias)
            ExpertisApp.OpenForm(strAlias, , Grid.Value("IDRemesa"), Me)
        End If
    End Sub

#End Region

#Region " Grid "

    Private Sub Grid_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell

        With Grid
            'If .Value("Contabilizado") Or .Value("Situacion") = enumPagoSituacion.Pagado Then
            '    'e.Cancel = True
            '    .Columns(e.Column.Index).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
            'Else
            Select Case e.Column.Index
                Case .Columns("IDAgrupacion").Index
                    .Columns("IDAgrupacion").ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image
                Case .Columns("Permiso").Index
                    .Columns("Permiso").EditType = Janus.Windows.GridEX.EditType.CheckBox
            End Select
            'End If
        End With
    End Sub

    Private Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        If e.Row.RowType = RowType.Record Then
            If e.Row.Cells("Contabilizado").Value <> enumContabilizado.NoContabilizado Then
                e.Row.RowStyle = Grid.FormatStyles("ContabilizadoFormatStyle")
                e.Row.Cells("Contabilizado").ImageIndex = IconIndex.Contabilizado
            Else
                e.Row.Cells("Contabilizado").ImageIndex = IconIndex.NoContabilizado
            End If
        End If
    End Sub

    Private Sub Grid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseUp
        If e.Button = MouseButtons.Right Then
            If Not IsNothing(Grid) AndAlso Grid.RowCount > 0 Then
                Grid.UiCommandManager1.Commands(cnABRIRFACTURACOMPRA).Visible = InheritableBoolean.False
                Grid.UiCommandManager1.Commands(cnABRIROBRA).Visible = InheritableBoolean.False
                If Length(Grid.Value("IDFactura")) > 0 Then
                    Grid.UiCommandManager1.Commands(cnABRIRFACTURACOMPRA).Visible = InheritableBoolean.True
                End If
                If Length(Grid.Value("IDObra")) > 0 Then
                    Grid.UiCommandManager1.Commands(cnABRIROBRA).Visible = InheritableBoolean.True
                End If
            End If
        End If
    End Sub

#End Region

    Private Sub CIPagoCont_RecordChecked(ByVal sender As Object, ByVal e As Engine.UI.CheckedEventArgs) Handles MyBase.RecordChecked

        Dim dblTotalMarcado As Double = Nz(Me.CheckedRecords.Compute("SUM(ImpVencimientoA)", Nothing), 0)

        txtTotalMarcado.Value = dblTotalMarcado
    End Sub

#Region " Execute Query "
    Private Sub CIPagoCont_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        Dim CHAR_LIKE As String = "*"
        If Not mIDPagos Is Nothing AndAlso mIDPagos.Length > 0 Then
            e.Filter.Add(New InListFilterItem("IDPago", mIDPagos, FilterType.Numeric))
        End If
        e.Filter.Add("IDProveedor", FilterOperator.Equal, AdvIDProveedor.Text, FilterType.String)
        'e.Filter.Add("NFactura", FilterOperator.GreaterThanOrEqual, AdvFacturaDesde.Text, FilterType.String)
        'e.Filter.Add("NFactura", FilterOperator.LessThanOrEqual, AdvFacturaHasta.Text, FilterType.String)

        Dim IDFacturasAgrup As String = Trim(txtFrasAgrup.Text & String.Empty)
        If Length(IDFacturasAgrup) > 0 Then
            Dim fFras As New Filter(FilterUnionOperator.Or)
            fFras.Add(New LikeFilterItem("NFacturasAgrupadas", CHAR_LIKE & IDFacturasAgrup & CHAR_LIKE))
            fFras.Add(New FilterItem("NFactura", IDFacturasAgrup))

            Dim fFrasRango As New Filter
            If Length(AdvFacturaDesde.Text) > 0 Then fFrasRango.Add("NFactura", FilterOperator.GreaterThanOrEqual, AdvFacturaDesde.Text, FilterType.String)
            If Length(AdvFacturaHasta.Text) > 0 Then fFrasRango.Add("NFactura", FilterOperator.LessThanOrEqual, AdvFacturaHasta.Text, FilterType.String)
            If fFrasRango.Count > 0 Then fFras.Add(fFrasRango)

            e.Filter.Add(fFras)
        Else
            e.Filter.Add("NFactura", FilterOperator.GreaterThanOrEqual, AdvFacturaDesde.Text, FilterType.String)
            e.Filter.Add("NFactura", FilterOperator.LessThanOrEqual, AdvFacturaHasta.Text, FilterType.String)
        End If
        e.Filter.Add("ImpVencimientoA", FilterOperator.GreaterThanOrEqual, txtImporteDesde.Value, FilterType.Numeric)
        e.Filter.Add("ImpVencimientoA", FilterOperator.LessThanOrEqual, txtImporteHasta.Value, FilterType.Numeric)
        e.Filter.Add("FechaVencimiento", FilterOperator.GreaterThanOrEqual, cbxVtoDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaVencimiento", FilterOperator.LessThanOrEqual, cbxVtoHasta.Value, FilterType.DateTime)
        e.Filter.Add("FechaFactura", FilterOperator.GreaterThanOrEqual, cbxFechaFacturaD.Value, FilterType.DateTime)
        e.Filter.Add("FechaFactura", FilterOperator.LessThanOrEqual, cbxFechaFacturaH.Value, FilterType.DateTime)
        e.Filter.Add("IDFormaPago", FilterOperator.Equal, cbxFormaPago.Text, FilterType.String)
        e.Filter.Add("IDBancoPropio", FilterOperator.Equal, cbxBancoPropio.Text, FilterType.String)
        e.Filter.Add("Situacion", FilterOperator.Equal, cbxSituacion.Value, FilterType.Numeric)
        e.Filter.Add("IdTipoPago", FilterOperator.Equal, cbxTipo.Value, FilterType.Numeric)
        e.Filter.Add("IDRemesa", FilterOperator.Equal, AdvIDRemesa.Value, FilterType.Numeric)
        e.Filter.Add("IDPagoPeriodo", FilterOperator.Equal, AdvIDPagoPeriodico.Value, FilterType.Numeric)
        e.Filter.Add("IDObra", FilterOperator.Equal, AdvIDObra.Value, FilterType.Numeric)
        e.Filter.Add("IdEjercicio", FilterOperator.Equal, cbxIDEjercicio.Text, FilterType.String)
        e.Filter.Add("IDContador", FilterOperator.Equal, AdvIDContador.Text, FilterType.String)
        e.Filter.Add("FechaPago", FilterOperator.GreaterThanOrEqual, clbFechaPagoDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaPago", FilterOperator.LessThanOrEqual, clbFechaPago.Value, FilterType.DateTime)

        If Length(txtTitulo.Text) > 0 Then
            e.Filter.Add(New LikeFilterItem("Titulo", txtTitulo.Text))
        End If


        If cbxManual.Value = enumBoolean.Si Then
            e.Filter.Add("IdTipoPago", FilterOperator.NotEqual, MIntTipoPago)
        ElseIf cbxManual.Value = enumBoolean.No Then
            e.Filter.Add("IdTipoPago", FilterOperator.Equal, MIntTipoPago)
        End If

        'If cbxGrupo.Value = enumBoolean.Si Then
        '    e.Filter.Add(New IsNullFilterItem("BaseDatos", False))
        'ElseIf cbxGrupo.Value = enumBoolean.No Then
        '    e.Filter.Add(New IsNullFilterItem("BaseDatos", True))
        'End If
        If cbxContabilizado.Value <> enumContabilizadoTodos.Todos Then
            e.Filter.Add("Contabilizado", FilterOperator.Equal, cbxContabilizado.Value, FilterType.Numeric)
        End If

        If cbxRiesgo.Value <> enumBoolean.Todos And Len(cbxRiesgo.Value) > 0 Then
            e.Filter.Add(New BooleanFilterItem("Riesgo", FilterOperator.Equal, CBool(cbxRiesgo.Value)))
        End If
        e.Filter.Add("SyncDB", FilterOperator.Equal, cbxEmpresa.Text, FilterType.String)

        'If cbxImpreso.Value <> enumBoolean.Todos And Len(cbxImpreso.Value) > 0 Then
        '    e.Filter.Add(New BooleanFilterItem("Impreso", FilterOperator.Equal, CBool(cbxImpreso.Value)))
        'End If

        If cbxRemesado.Value = enumBoolean.Si Then
            e.Filter.Add(New IsNullFilterItem("IDRemesa", False))
        ElseIf cbxRemesado.Value = enumBoolean.No Then
            e.Filter.Add(New IsNullFilterItem("IDRemesa", True))
        End If

        If cbxEmpresaGrupo.Value = enumBoolean.Si Then
            e.Filter.Add("EmpresaGrupo", FilterOperator.Equal, 1, FilterType.Numeric)
        ElseIf cbxEmpresaGrupo.Value = enumBoolean.No Then
            e.Filter.Add("EmpresaGrupo", FilterOperator.Equal, 0, FilterType.Numeric)
        End If

        If cbxAsignadoNPagare.Value = enumBoolean.Si Then
            e.Filter.Add(New IsNullFilterItem("NPagare", False))
        ElseIf cbxAsignadoNPagare.Value = enumBoolean.No Then
            e.Filter.Add(New IsNullFilterItem("NPagare", True))
        End If

        If cbxEspecial.Value <> enumBoolean.Todos And Len(cbxEspecial.Value) > 0 Then
            e.Filter.Add(New BooleanFilterItem("Especial", FilterOperator.Equal, CBool(cbxEspecial.Value)))
        End If

    End Sub

    Private Sub CIPagoCont_QueryExecuted(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutedEventArgs) Handles MyBase.QueryExecuted
        txtTotal.Value = Grid.GetTotal(Grid.Columns("ImpVencimientoA"), AggregateFunction.Sum)
    End Sub

    Protected Overrides Sub OnFilterClearing(ByVal e As System.EventArgs)
        MyBase.OnFilterClearing(e)

        ReDim Me.mIDPagos(-1)
        mSituacion = Nothing
        InitFilterCriteria()
        cbxVtoDesde.TextBox.Clear()
        cbxVtoHasta.TextBox.Clear()
        cbxFechaFacturaD.TextBox.Clear()
        cbxFechaFacturaH.TextBox.Clear()
    End Sub

#End Region

    Private Sub AdvIDContador_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvIDContador.SetPredefinedFilter
        e.Filter.Add("Entidad", FilterOperator.Equal, cnEntidad)
    End Sub

    Private Sub cbxVtoDesde_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxVtoDesde.Validated
        If Length(cbxVtoDesde.Value) > 0 Then cbxVtoHasta.Value = cbxVtoDesde.Value
    End Sub

    Private Sub txtImporteDesde_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImporteDesde.Validated
        txtImporteHasta.Value = txtImporteDesde.Value
    End Sub

    Private Sub AdvFacturaDesde_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvFacturaDesde.Validated
        AdvFacturaHasta.Value = AdvFacturaDesde.Value
        AdvFacturaHasta.Text = AdvFacturaDesde.Text
    End Sub

    Private Sub cbxManual_DropDownHide(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ComboDropDownHideEventArgs) Handles cbxManual.DropDownHide
        If Length(cbxManual.Value) = 0 Then cbxManual.Value = enumBoolean.Todos
    End Sub

    'Private Sub cbxGrupo_DropDownHide(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ComboDropDownHideEventArgs)
    '    If Length(cbxGrupo.Value) = 0 Then cbxGrupo.Value = enumBoolean.Todos
    'End Sub

    Private Sub cbxContabilizado_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxContabilizado.Validated
        If cbxContabilizado.Value = enumContabilizadoTodos.Todos Then
            txtEstado.Text = String.Empty
        ElseIf Length(cbxContabilizado.Value) = 0 Then
            txtEstado.Text = String.Empty
            cbxContabilizado.Value = enumContabilizadoTodos.Todos
        Else
            txtEstado.Text = cbxContabilizado.Value
        End If
    End Sub

    Private Sub AdvIDProveedor_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvIDProveedor.SelectionChanged
        GetSaldoProveedor()
    End Sub

    Private Sub AdvIDProveedor_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles AdvIDProveedor.Validated
        If Length(AdvIDProveedor.Text) = 0 Then
            txtSaldoCContable.Value = DBNull.Value
            txtCContable.Text = String.Empty
            txtSaldoCContable.ForeColor = Color.Black
        End If
    End Sub

    Private Sub cbxIDEjercicio_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxIDEjercicio.Validated
        GetSaldoProveedor()
    End Sub

    Private Sub GetSaldoProveedor()
        txtSaldoCContable.Value = DBNull.Value
        txtCContable.Text = String.Empty
        txtSaldoCContable.ForeColor = Color.Black

        If Length(AdvIDProveedor.Text) > 0 Then
            Dim drProveedor As DataRow = AdvIDProveedor.SelectedRow()
            If Not drProveedor Is Nothing AndAlso Length(drProveedor("CCProveedor")) > 0 Then
                Dim datos As New DiarioContable.DataCuentaSaldo
                datos.IDEjercicio = cbxIDEjercicio.Value
                Dim f As New Filter
                f.Add(New StringFilterItem("IDCContable", drProveedor("CCProveedor")))
                datos.Filtro = f
                Dim dtSaldo As DataTable = ExpertisApp.ExecuteTask(Of DiarioContable.DataCuentaSaldo, DataTable)(AddressOf DiarioContable.CuentaSaldo, datos)

                Dim dv As DataView = dtSaldo.DefaultView
                dv.RowFilter = New StringFilterItem("Cuenta", drProveedor("CCProveedor")).Compose(New AdoFilterComposer)
                If dv.Count > 0 Then
                    If dv(0).Row("SaldoA") < 0 Then
                        txtSaldoCContable.ForeColor = Color.Red
                    End If
                    txtSaldoCContable.Value = dv(0).Row("SaldoA")
                End If
                txtCContable.Text = drProveedor("CCProveedor")
            End If
        End If
    End Sub

    Private Sub cbxTipo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxTipo.Validated
        If Length(cbxTipo.Value) <> 0 Then
            Dim DtTipoCobro As DataTable = New TipoPago().SelOnPrimaryKey(cbxTipo.Value)
            If Not DtTipoCobro Is Nothing AndAlso DtTipoCobro.Rows.Count > 0 Then
                If DtTipoCobro.Rows(0)("Especial") Then
                    cbxEspecial.Value = enumBoolean.Si
                Else : cbxEspecial.Value = enumBoolean.No
                End If
            End If
        End If
    End Sub

    Protected Sub QuitarMarcas()
        Grid.DeleteServerChecks()
        Me.UnCheckAllRecords()
        Me.Execute()
    End Sub

    Protected Sub FrmActionClosed(ByVal sender As Object, ByVal e As System.EventArgs)
        RemoveHandler CType(sender, Form).Closed, AddressOf FrmActionClosed
        If CType(sender, Form).DialogResult <> DialogResult.OK AndAlso mCambiarSituacion AndAlso Not mContabilizar Then 'AndAlso mNuevaSituacion <> enumPagoSituacion.Pagado Then
            Dim datCambio As New Pago.DataCambioSituacionManual(Grid.CheckedRecords, mNuevaSituacion)
            ExpertisApp.ExecuteTask(Of Pago.DataCambioSituacionManual, ClassErrors())(AddressOf Pago.CambioSituacionManual, datCambio)
            'ElseIf CType(sender, Form).DialogResult = DialogResult.OK AndAlso mPagoImpreso Then
            '    ExpertisApp.ExecuteTask(Of DataTable)(AddressOf Business.General.Comunes.UpdateEntityDataTable, Grid.CheckedRecords)
        End If
        mCambiarSituacion = False
        mContabilizar = False

        QuitarMarcas()
        txtTotalMarcado.Value = 0
    End Sub

#Region " Informes "

    Private Const cnDATABASEALIAS_PAGOS_POR_FORMA_PAGO As String = "LPAPORFP"
    Private Const cnDATABASEALIAS_CARTA_PROVEEDORES As String = "LCARTAP"
    Private Const cnDATABASEALIAS_PAGARE As String = "LPAGOPAGA"
    Private Const cnDATABASEALIAS_PAGARE_SCH As String = "LPAGARESCH"
    Private Const cnDATABASEALIAS_PAGARE_CAIXA As String = "PAGCAIXAA4"
    Private Const cnDATABASEALIAS_PAGARE_BBVA As String = "LPAGAREBBVA"
    Private Const cnDATABASEALIAS_PAGARE_BANCO_POPULAR As String = "PAGPOPULARA4"
    Private Const cnDATABASEALIAS_PAGARE_BANESTO As String = "PAGBANESTOA4"
    Private Const cnDATABASEALIAS_PAGARE_CASTILLA As String = "PAGCASTILLAA4"
    Private Const cnDATABASEALIAS_PAGARE_CEISS As String = "PAGCEISSA4"
    Private Const cnDATABASEALIAS_PAGARE_PASTOR As String = "PAGPASTORA4"
    Private Const cnDATABASEALIAS_PAGARE_CAJA_RURAL As String = "PAGCRURALA4"
    Private Const cnDATABASEALIAS_PAGARE_IBERCAJA As String = "PAGIBERA4"
    Private Const cnDATABASEALIAS_PAGARE_SANTANDER As String = "PAGBSCHA4"
    Private Const cnDATABASEALIAS_PAGARE_BBVAA4 As String = "PAGBBVAA4"
    Private mdFechaDesde As Date
    Public mdtCartasProveedores As DataTable

    Public mobjGuid As Guid
    Public mblnDesmarcar As Boolean        '//Variable para controlar el desmarcado en el servidor.

    Private Sub CIPagoCont_SetReportDesignObjects(ByVal sender As Object, ByVal e As Engine.UI.ReportDesignObjectsEventArgs) Handles MyBase.SetReportDesignObjects
        Select Case e.Alias
            Case cnDATABASEALIAS_PAGOS_POR_FORMA_PAGO
                Dim frmFecha As New frmIntroducirFechaVto
                If frmFecha.ShowDialog(Me) = DialogResult.OK Then
                    e.Formulas("FechaDesde").Text = frmFecha.Fecha
                    mdFechaDesde = frmFecha.Fecha
                Else
                    e.Cancel = True
                End If
                frmFecha = Nothing
            Case cnDATABASEALIAS_CARTA_PROVEEDORES
                If Grid.CheckedRecordsCount > 0 Then
                    Dim objFilter As New Filter(FilterUnionOperator.Or)
                    objFilter.Add(New IsNullFilterItem("IDBancoPropio", True))
                    objFilter.Add(New IsNullFilterItem("IDProveedor", True))
                    Dim dvChecked As DataView = New DataView(Grid.CheckedRecords, objFilter.Compose(New AdoFilterComposer), Nothing, DataViewRowState.CurrentRows)
                    If Not IsNothing(dvChecked) AndAlso dvChecked.Count > 0 Then
                        e.Cancel = True
                        ExpertisApp.GenerateMessage("Todos los pagos seleccionados deben tener un Proveedor y un Banco Propio asignado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        objFilter.Clear()
                        objFilter.Add(New IsNullFilterItem("IDFormaPago", True))
                        objFilter.Add(New BooleanFilterItem("Trasferencia", True))

                        dvChecked = New DataView(Grid.CheckedRecords, objFilter.Compose(New AdoFilterComposer), Nothing, DataViewRowState.CurrentRows)
                        If Not IsNothing(dvChecked) AndAlso dvChecked.Count > 0 Then
                            e.Cancel = True
                            ExpertisApp.GenerateMessage("Solo puede seleccionar pagos que no sean Transferencia.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            Dim frmCarta As New FrmCartaProveedor
                            frmCarta.Pagos = Grid.CheckedRecords
                            If frmCarta.ShowDialog(Me) = DialogResult.OK Then
                                e.Formulas("AbreviaturaMoneda").Text = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaA, cnMinDate).Abreviatura
                                e.Formulas("TextoMoneda").Text = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaA, cnMinDate).Texto
                                e.Formulas("DecimalesImporte").Text = Math.Pow(10, ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaA, cnMinDate).NDecimalesImporte)
                                If Not frmCarta.CartaProveedor Is Nothing Then
                                    mdtCartasProveedores = frmCarta.CartaProveedor
                                Else
                                    e.Cancel = True
                                End If
                            Else
                                e.Cancel = True
                            End If
                        End If
                    End If
                Else
                    e.Cancel = True
                    ExpertisApp.GenerateMessage("Debe seleccionar algún registro.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case cnDATABASEALIAS_PAGARE, cnDATABASEALIAS_PAGARE_SCH, _
                cnDATABASEALIAS_PAGARE_CAIXA, cnDATABASEALIAS_PAGARE_BBVA, _
                cnDATABASEALIAS_PAGARE_BANCO_POPULAR, cnDATABASEALIAS_PAGARE_BANESTO, cnDATABASEALIAS_PAGARE_CASTILLA, _
                cnDATABASEALIAS_PAGARE_CEISS, cnDATABASEALIAS_PAGARE_PASTOR, cnDATABASEALIAS_PAGARE_CAJA_RURAL, _
                cnDATABASEALIAS_PAGARE_IBERCAJA, cnDATABASEALIAS_PAGARE_SANTANDER, cnDATABASEALIAS_PAGARE_BBVAA4

                mIDProcess = Grid.SaveServerChecks()

                If Grid.CheckedRecordsCount > 0 Then
                    Dim objFilter As New Filter(FilterUnionOperator.Or)
                    objFilter.Clear()
                    objFilter.Add(New IsNullFilterItem("IDBancoPropio", True))
                    objFilter.Add(New IsNullFilterItem("IDProveedor", True))
                    Dim dvChecked As DataView = New DataView(Grid.CheckedRecords, objFilter.Compose(New AdoFilterComposer), Nothing, DataViewRowState.CurrentRows)
                    If Not IsNothing(dvChecked) AndAlso dvChecked.Count > 0 Then
                        e.Cancel = True
                        '//9118: Todos los pagos seleccionados deben tener un Proveedor y un Banco Propio asignado.
                        ExpertisApp.GenerateMessage("Todos los pagos seleccionados deben tener un Proveedor y un Banco Propio asignado.", MessageBoxButtons.OK, MessageBoxIcon.Information, ExpertisApp.Title)
                    Else
                        objFilter.Clear()
                        objFilter.Add(New IsNullFilterItem("IDFormaPago", True))
                        objFilter.Add(New BooleanFilterItem("Trasferencia", True))

                        dvChecked = Nothing
                        dvChecked = New DataView(Grid.CheckedRecords, objFilter.Compose(New AdoFilterComposer), Nothing, DataViewRowState.CurrentRows)
                        If Not IsNothing(dvChecked) AndAlso dvChecked.Count > 0 Then
                            e.Cancel = True
                            '//9119: Solo puede seleccionar pagos que no sean Transferencia.
                            ExpertisApp.GenerateMessage("Solo puede seleccionar pagos que no sean Transferencia.", MessageBoxButtons.OK, MessageBoxIcon.Information, ExpertisApp.Title)
                        Else
                            Dim frmCarta As New FrmCartaProveedor
                            frmCarta.Pagos = Grid.CheckedRecords
                            If frmCarta.ShowDialog(Me) = DialogResult.OK Then
                                Dim objNegMoneda As New Moneda
                                Dim objMonedaInfo As New MonedaInfo
                                e.Formulas("AbreviaturaMoneda").Text = objMonedaInfo.Abreviatura
                                e.Formulas("TextoMoneda").Text = objMonedaInfo.Texto
                                e.Formulas("DecimalesImporte").Text = Math.Pow(10, objMonedaInfo.NDecimalesImporte)
                                objNegMoneda = Nothing
                                mdtCartasProveedores = frmCarta.CartaProveedor
                            Else
                                e.Cancel = True
                            End If
                        End If
                    End If
                    objFilter = Nothing
                Else
                    e.Cancel = True
                    '//13191: Debe seleccionar algún registro.
                    ExpertisApp.GenerateMessage("Debe seleccionar algún registro.", MessageBoxButtons.OK, MessageBoxIcon.Information, ExpertisApp.Title)
                End If
        End Select
    End Sub

    Private Sub CIPagoCont_SetReportSelectionCriteria(ByVal sender As Object, ByVal e As Engine.UI.ReportSelectionCriteriaEventArgs) Handles MyBase.SetReportSelectionCriteria
        Select Case e.Alias
            Case cnDATABASEALIAS_PAGOS_POR_FORMA_PAGO
                '//No hay que limpiar el filtro, para que coja tb los filtros de la consulta.
                e.Filter.Add(New DateFilterItem("FechaVencimiento", FilterOperator.GreaterThan, mdFechaDesde))
        End Select
    End Sub

    Private Sub CIPagoCont_SetReportDataSource(ByVal sender As Object, ByVal e As Engine.UI.ReportDataSourceEventArgs) Handles MyBase.SetReportDataSource
        Select Case e.Alias
            Case cnDATABASEALIAS_CARTA_PROVEEDORES

                Dim htPagos As New Hashtable
                htPagos.Clear()
                '//Marcamos en el servidor los pagos
                Dim i As Integer = 0
                For Each drRowMarcados As DataRow In Grid.CheckedRecords.Rows
                    htPagos("IDEnlace" & i) = drRowMarcados("IdPago")
                    i = i + 1
                Next drRowMarcados
                mobjGuid = MarcarRegistro(htPagos, FilterType.Numeric)
                mblnDesmarcar = True
                htPagos = Nothing
                e.DataSource = mdtCartasProveedores
            Case cnDATABASEALIAS_PAGARE, cnDATABASEALIAS_PAGARE_SCH, _
                cnDATABASEALIAS_PAGARE_CAIXA, cnDATABASEALIAS_PAGARE_BBVA, _
                cnDATABASEALIAS_PAGARE_BANCO_POPULAR, cnDATABASEALIAS_PAGARE_BANESTO, cnDATABASEALIAS_PAGARE_CASTILLA, _
                cnDATABASEALIAS_PAGARE_CEISS, cnDATABASEALIAS_PAGARE_PASTOR, cnDATABASEALIAS_PAGARE_CAJA_RURAL, _
                cnDATABASEALIAS_PAGARE_IBERCAJA, cnDATABASEALIAS_PAGARE_SANTANDER, cnDATABASEALIAS_PAGARE_BBVAA4
                'Obtener los registros marcados.
                If Grid.CheckedRecords.Rows.Count > 0 Then
                    Dim IDPagos(-1) As Object
                    For Each drPago As DataRow In Grid.CheckedRecords.Rows
                        ReDim Preserve IDPagos(IDPagos.Length)
                        IDPagos(IDPagos.Length - 1) = drPago("IDPago")
                    Next
                    Dim dtRto As DataTable = ExpertisApp.ExecuteTask(Of Object(), DataTable)(AddressOf Pago.DatosPagare, IDPagos)
                    'MessageBox.Show("son " & dtRto.Rows.Count & " registros")
                    e.DataSource = mdtCartasProveedores
                    'Me.DeleteServerChecks()
                Else
                    ExpertisApp.GenerateMessage("Debe seleccionar algún registro.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
        End Select
    End Sub



    'CRF    Private Sub Me_SetReportSelectionCriteria() Handles MyBase.SetReportSelectionCriteria
    '        Dim strFiltro As String
    '        Dim rcsGrid As Recordset
    '        Dim strIDProveedor As String

    '        Select Case strReportName
    '            Case "vRptPagos"
    '                CriteriosConsultaCrystal(strFiltro, strReportName)
    '                strReportSelectionCriteria = strFiltro
    '        End Select
    '    End Sub


#End Region

    Private Sub CIPagoCont_CheckingAllRecord(ByVal sender As Object, ByVal e As Engine.UI.CheckingAllEventArgs) Handles Me.CheckingAllRecord
        If e.CheckAction = UI.CheckAction.UnChek Then
            AdvIDProveedor.Focus()
        End If
    End Sub

    Private Sub CIPagoCont_AllRecordChecked(ByVal sender As Object, ByVal e As Engine.UI.AllCheckedEventArgs) Handles Me.AllRecordChecked
        If e.CheckAction = UI.CheckAction.UnChek Then Me.txtTotalMarcado.Text = 0
    End Sub

    Private Sub CIPagoCont_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Me.UnCheckAllRecords()
        Me.DeleteServerChecks()
    End Sub

End Class