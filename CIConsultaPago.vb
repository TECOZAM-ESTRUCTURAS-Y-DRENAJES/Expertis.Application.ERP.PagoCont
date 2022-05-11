Imports Solmicro.Expertis.Business.General

Public Class CIConsultaPago
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
    Friend WithEvents fwiFechaPagoHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblfwiFechaPagoHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiFechaPagoDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblfwiFechaPagoDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiBancoPropio As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblfwiBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiImpHasta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblfwiImpHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiFechaVtoHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblfwiFechaVtoHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiImpDesde As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblfwiImpDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiFechaVtoDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblfwiFechaVtoDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiFormaPago As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblfwiFormaPago As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiFacturaDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblfwiFacturaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiFacturaHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblfwiFacturaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiSituacion As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblfwiSituacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiIDProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblfwiIDProveedor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FraTotal As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents CmbEmpresas As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents LblEmpresa As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ChkMultiEmpresa As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents LblTotalImpVtoA As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents NtbTotalImpVtoA As Solmicro.Expertis.Engine.UI.NumericTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim fwiBancoPropio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim fwiFormaPago_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim fwiSituacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim CmbEmpresas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIConsultaPago))
        Me.fwiFechaPagoHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblfwiFechaPagoHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFechaPagoDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblfwiFechaPagoDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiBancoPropio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblfwiBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpHasta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiImpHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFechaVtoHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblfwiFechaVtoHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImpDesde = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiImpDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFechaVtoDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblfwiFechaVtoDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFormaPago = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblfwiFormaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFacturaDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiFacturaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFacturaHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiFacturaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiSituacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblfwiSituacion = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiIDProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiIDProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.FraTotal = New Solmicro.Expertis.Engine.UI.Frame
        Me.LblTotalImpVtoA = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbTotalImpVtoA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.CmbEmpresas = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.LblEmpresa = New Solmicro.Expertis.Engine.UI.Label
        Me.ChkMultiEmpresa = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.fwiBancoPropio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fwiFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fwiSituacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraTotal.SuspendLayout()
        CType(Me.CmbEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.CmbEmpresas)
        Me.FilterPanel.Controls.Add(Me.LblEmpresa)
        Me.FilterPanel.Controls.Add(Me.ChkMultiEmpresa)
        Me.FilterPanel.Controls.Add(Me.lblfwiFechaPagoHasta)
        Me.FilterPanel.Controls.Add(Me.fwiFechaPagoHasta)
        Me.FilterPanel.Controls.Add(Me.lblfwiFechaPagoDesde)
        Me.FilterPanel.Controls.Add(Me.fwiFechaPagoDesde)
        Me.FilterPanel.Controls.Add(Me.lblfwiBancoPropio)
        Me.FilterPanel.Controls.Add(Me.fwiBancoPropio)
        Me.FilterPanel.Controls.Add(Me.lblfwiImpHasta)
        Me.FilterPanel.Controls.Add(Me.fwiImpHasta)
        Me.FilterPanel.Controls.Add(Me.lblfwiFechaVtoHasta)
        Me.FilterPanel.Controls.Add(Me.fwiFechaVtoHasta)
        Me.FilterPanel.Controls.Add(Me.lblfwiImpDesde)
        Me.FilterPanel.Controls.Add(Me.fwiImpDesde)
        Me.FilterPanel.Controls.Add(Me.lblfwiFechaVtoDesde)
        Me.FilterPanel.Controls.Add(Me.fwiFechaVtoDesde)
        Me.FilterPanel.Controls.Add(Me.lblfwiFormaPago)
        Me.FilterPanel.Controls.Add(Me.fwiFormaPago)
        Me.FilterPanel.Controls.Add(Me.lblfwiFacturaDesde)
        Me.FilterPanel.Controls.Add(Me.fwiFacturaDesde)
        Me.FilterPanel.Controls.Add(Me.lblfwiFacturaHasta)
        Me.FilterPanel.Controls.Add(Me.fwiFacturaHasta)
        Me.FilterPanel.Controls.Add(Me.lblfwiSituacion)
        Me.FilterPanel.Controls.Add(Me.fwiSituacion)
        Me.FilterPanel.Controls.Add(Me.lblfwiIDProveedor)
        Me.FilterPanel.Controls.Add(Me.fwiIDProveedor)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 301)
        Me.FilterPanel.Size = New System.Drawing.Size(688, 120)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.FraTotal)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(688, 301)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.FraTotal, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EntityName = "Pago"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.KeyField = "IDPago"
        Me.Grid.Size = New System.Drawing.Size(688, 259)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "vctlCIPagoContConsultaPago"
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
        'fwiFechaPagoHasta
        '
        Me.fwiFechaPagoHasta.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFechaPagoHasta.Location = New System.Drawing.Point(207, 44)
        Me.fwiFechaPagoHasta.Name = "fwiFechaPagoHasta"
        Me.fwiFechaPagoHasta.Size = New System.Drawing.Size(84, 21)
        Me.fwiFechaPagoHasta.TabIndex = 3
        '
        'lblfwiFechaPagoHasta
        '
        Me.lblfwiFechaPagoHasta.Location = New System.Drawing.Point(185, 48)
        Me.lblfwiFechaPagoHasta.Name = "lblfwiFechaPagoHasta"
        Me.lblfwiFechaPagoHasta.Size = New System.Drawing.Size(16, 13)
        Me.lblfwiFechaPagoHasta.TabIndex = 16
        Me.lblfwiFechaPagoHasta.Tag = "IdRec=4817;"
        Me.lblfwiFechaPagoHasta.Text = "<"
        '
        'fwiFechaPagoDesde
        '
        Me.fwiFechaPagoDesde.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFechaPagoDesde.Location = New System.Drawing.Point(95, 44)
        Me.fwiFechaPagoDesde.Name = "fwiFechaPagoDesde"
        Me.fwiFechaPagoDesde.Size = New System.Drawing.Size(84, 21)
        Me.fwiFechaPagoDesde.TabIndex = 2
        '
        'lblfwiFechaPagoDesde
        '
        Me.lblfwiFechaPagoDesde.Location = New System.Drawing.Point(10, 48)
        Me.lblfwiFechaPagoDesde.Name = "lblfwiFechaPagoDesde"
        Me.lblfwiFechaPagoDesde.Size = New System.Drawing.Size(65, 13)
        Me.lblfwiFechaPagoDesde.TabIndex = 17
        Me.lblfwiFechaPagoDesde.Tag = "IdRec=5658;"
        Me.lblfwiFechaPagoDesde.Text = "F.Pago >="
        '
        'fwiBancoPropio
        '
        fwiBancoPropio_DesignTimeLayout.LayoutString = resources.GetString("fwiBancoPropio_DesignTimeLayout.LayoutString")
        Me.fwiBancoPropio.DesignTimeLayout = fwiBancoPropio_DesignTimeLayout
        Me.fwiBancoPropio.DisabledBackColor = System.Drawing.Color.White
        Me.fwiBancoPropio.DisplayMember = "IDBancoPropio"
        Me.fwiBancoPropio.EntityName = "BancoPropio"
        Me.fwiBancoPropio.Location = New System.Drawing.Point(405, 92)
        Me.fwiBancoPropio.Name = "fwiBancoPropio"
        Me.fwiBancoPropio.PrimaryDataFields = "IDBancoPropio"
        Me.fwiBancoPropio.SecondaryDataFields = "IDBancoPropio"
        Me.fwiBancoPropio.SelectedIndex = -1
        Me.fwiBancoPropio.SelectedItem = Nothing
        Me.fwiBancoPropio.Size = New System.Drawing.Size(97, 21)
        Me.fwiBancoPropio.TabIndex = 11
        Me.fwiBancoPropio.ValueMember = "IDBancoPropio"
        Me.fwiBancoPropio.ViewName = "tbMaestroBancoPropio"
        '
        'lblfwiBancoPropio
        '
        Me.lblfwiBancoPropio.Location = New System.Drawing.Point(317, 96)
        Me.lblfwiBancoPropio.Name = "lblfwiBancoPropio"
        Me.lblfwiBancoPropio.Size = New System.Drawing.Size(82, 13)
        Me.lblfwiBancoPropio.TabIndex = 18
        Me.lblfwiBancoPropio.Tag = "IdRec=4602;"
        Me.lblfwiBancoPropio.Text = "Banco Propio"
        '
        'fwiImpHasta
        '
        Me.fwiImpHasta.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpHasta.Location = New System.Drawing.Point(207, 92)
        Me.fwiImpHasta.Name = "fwiImpHasta"
        Me.fwiImpHasta.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.fwiImpHasta.Size = New System.Drawing.Size(84, 21)
        Me.fwiImpHasta.TabIndex = 7
        '
        'lblfwiImpHasta
        '
        Me.lblfwiImpHasta.Location = New System.Drawing.Point(185, 96)
        Me.lblfwiImpHasta.Name = "lblfwiImpHasta"
        Me.lblfwiImpHasta.Size = New System.Drawing.Size(16, 13)
        Me.lblfwiImpHasta.TabIndex = 19
        Me.lblfwiImpHasta.Tag = "IdRec=4817;"
        Me.lblfwiImpHasta.Text = "<"
        '
        'fwiFechaVtoHasta
        '
        Me.fwiFechaVtoHasta.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFechaVtoHasta.Location = New System.Drawing.Point(207, 20)
        Me.fwiFechaVtoHasta.Name = "fwiFechaVtoHasta"
        Me.fwiFechaVtoHasta.Size = New System.Drawing.Size(84, 21)
        Me.fwiFechaVtoHasta.TabIndex = 1
        '
        'lblfwiFechaVtoHasta
        '
        Me.lblfwiFechaVtoHasta.Location = New System.Drawing.Point(185, 25)
        Me.lblfwiFechaVtoHasta.Name = "lblfwiFechaVtoHasta"
        Me.lblfwiFechaVtoHasta.Size = New System.Drawing.Size(16, 13)
        Me.lblfwiFechaVtoHasta.TabIndex = 20
        Me.lblfwiFechaVtoHasta.Tag = "IdRec=4817;"
        Me.lblfwiFechaVtoHasta.Text = "<"
        '
        'fwiImpDesde
        '
        Me.fwiImpDesde.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImpDesde.Location = New System.Drawing.Point(95, 92)
        Me.fwiImpDesde.Name = "fwiImpDesde"
        Me.fwiImpDesde.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.fwiImpDesde.Size = New System.Drawing.Size(84, 21)
        Me.fwiImpDesde.TabIndex = 6
        '
        'lblfwiImpDesde
        '
        Me.lblfwiImpDesde.Location = New System.Drawing.Point(10, 96)
        Me.lblfwiImpDesde.Name = "lblfwiImpDesde"
        Me.lblfwiImpDesde.Size = New System.Drawing.Size(79, 13)
        Me.lblfwiImpDesde.TabIndex = 21
        Me.lblfwiImpDesde.Tag = "IdRec=5655;"
        Me.lblfwiImpDesde.Text = "Imp. Vto >="
        '
        'fwiFechaVtoDesde
        '
        Me.fwiFechaVtoDesde.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFechaVtoDesde.Location = New System.Drawing.Point(95, 20)
        Me.fwiFechaVtoDesde.Name = "fwiFechaVtoDesde"
        Me.fwiFechaVtoDesde.Size = New System.Drawing.Size(84, 21)
        Me.fwiFechaVtoDesde.TabIndex = 0
        '
        'lblfwiFechaVtoDesde
        '
        Me.lblfwiFechaVtoDesde.Location = New System.Drawing.Point(10, 25)
        Me.lblfwiFechaVtoDesde.Name = "lblfwiFechaVtoDesde"
        Me.lblfwiFechaVtoDesde.Size = New System.Drawing.Size(60, 13)
        Me.lblfwiFechaVtoDesde.TabIndex = 22
        Me.lblfwiFechaVtoDesde.Tag = "IdRec=5656;"
        Me.lblfwiFechaVtoDesde.Text = "F. Vto >="
        '
        'fwiFormaPago
        '
        fwiFormaPago_DesignTimeLayout.LayoutString = resources.GetString("fwiFormaPago_DesignTimeLayout.LayoutString")
        Me.fwiFormaPago.DesignTimeLayout = fwiFormaPago_DesignTimeLayout
        Me.fwiFormaPago.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFormaPago.DisplayMember = "IDFormaPago"
        Me.fwiFormaPago.EntityName = "FormaPago"
        Me.fwiFormaPago.Location = New System.Drawing.Point(405, 68)
        Me.fwiFormaPago.Name = "fwiFormaPago"
        Me.fwiFormaPago.PrimaryDataFields = "IDFormaPago"
        Me.fwiFormaPago.SecondaryDataFields = "IDFormaPago"
        Me.fwiFormaPago.SelectedIndex = -1
        Me.fwiFormaPago.SelectedItem = Nothing
        Me.fwiFormaPago.Size = New System.Drawing.Size(97, 21)
        Me.fwiFormaPago.TabIndex = 10
        Me.fwiFormaPago.ValueMember = "IDFormaPago"
        Me.fwiFormaPago.ViewName = "tbMaestroFormaPago"
        '
        'lblfwiFormaPago
        '
        Me.lblfwiFormaPago.Location = New System.Drawing.Point(317, 72)
        Me.lblfwiFormaPago.Name = "lblfwiFormaPago"
        Me.lblfwiFormaPago.Size = New System.Drawing.Size(75, 13)
        Me.lblfwiFormaPago.TabIndex = 23
        Me.lblfwiFormaPago.Tag = "IdRec=4758;"
        Me.lblfwiFormaPago.Text = "Forma Pago"
        '
        'fwiFacturaDesde
        '
        Me.fwiFacturaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFacturaDesde.EntityName = "FacturaCompraCabecera"
        Me.fwiFacturaDesde.Location = New System.Drawing.Point(95, 67)
        Me.fwiFacturaDesde.Name = "fwiFacturaDesde"
        Me.fwiFacturaDesde.PrimaryDataFields = "NFactura"
        Me.fwiFacturaDesde.SecondaryDataFields = "NFactura"
        Me.fwiFacturaDesde.Size = New System.Drawing.Size(84, 23)
        Me.fwiFacturaDesde.TabIndex = 4
        Me.fwiFacturaDesde.ViewName = "tbFacturaCompraCabecera"
        '
        'lblfwiFacturaDesde
        '
        Me.lblfwiFacturaDesde.Location = New System.Drawing.Point(10, 72)
        Me.lblfwiFacturaDesde.Name = "lblfwiFacturaDesde"
        Me.lblfwiFacturaDesde.Size = New System.Drawing.Size(70, 13)
        Me.lblfwiFacturaDesde.TabIndex = 24
        Me.lblfwiFacturaDesde.Tag = "IdRec=4776;"
        Me.lblfwiFacturaDesde.Text = "Factura >="
        '
        'fwiFacturaHasta
        '
        Me.fwiFacturaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFacturaHasta.EntityName = "FacturaCompraCabecera"
        Me.fwiFacturaHasta.Location = New System.Drawing.Point(207, 67)
        Me.fwiFacturaHasta.Name = "fwiFacturaHasta"
        Me.fwiFacturaHasta.PrimaryDataFields = "NFactura"
        Me.fwiFacturaHasta.SecondaryDataFields = "NFactura"
        Me.fwiFacturaHasta.Size = New System.Drawing.Size(84, 23)
        Me.fwiFacturaHasta.TabIndex = 5
        Me.fwiFacturaHasta.ViewName = "tbFacturaCompraCabecera"
        '
        'lblfwiFacturaHasta
        '
        Me.lblfwiFacturaHasta.Location = New System.Drawing.Point(185, 72)
        Me.lblfwiFacturaHasta.Name = "lblfwiFacturaHasta"
        Me.lblfwiFacturaHasta.Size = New System.Drawing.Size(16, 13)
        Me.lblfwiFacturaHasta.TabIndex = 26
        Me.lblfwiFacturaHasta.Tag = "IdRec=4817;"
        Me.lblfwiFacturaHasta.Text = "<"
        '
        'fwiSituacion
        '
        fwiSituacion_DesignTimeLayout.LayoutString = resources.GetString("fwiSituacion_DesignTimeLayout.LayoutString")
        Me.fwiSituacion.DesignTimeLayout = fwiSituacion_DesignTimeLayout
        Me.fwiSituacion.DisabledBackColor = System.Drawing.Color.White
        Me.fwiSituacion.DisplayMember = "IDEstado"
        Me.fwiSituacion.EntityName = "EstadoPago"
        Me.fwiSituacion.Location = New System.Drawing.Point(405, 44)
        Me.fwiSituacion.Name = "fwiSituacion"
        Me.fwiSituacion.PrimaryDataFields = "IDEstado"
        Me.fwiSituacion.SecondaryDataFields = "IDEstado"
        Me.fwiSituacion.SelectedIndex = -1
        Me.fwiSituacion.SelectedItem = Nothing
        Me.fwiSituacion.Size = New System.Drawing.Size(97, 21)
        Me.fwiSituacion.TabIndex = 9
        Me.fwiSituacion.ValueMember = "IDEstado"
        Me.fwiSituacion.ViewName = "tbMaestroEstadoPago"
        '
        'lblfwiSituacion
        '
        Me.lblfwiSituacion.Location = New System.Drawing.Point(317, 48)
        Me.lblfwiSituacion.Name = "lblfwiSituacion"
        Me.lblfwiSituacion.Size = New System.Drawing.Size(59, 13)
        Me.lblfwiSituacion.TabIndex = 28
        Me.lblfwiSituacion.Tag = "IdRec=5653;"
        Me.lblfwiSituacion.Text = "Situacion"
        '
        'fwiIDProveedor
        '
        Me.fwiIDProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIDProveedor.EntityName = "Proveedor"
        Me.fwiIDProveedor.Location = New System.Drawing.Point(405, 20)
        Me.fwiIDProveedor.Name = "fwiIDProveedor"
        Me.fwiIDProveedor.PrimaryDataFields = "IDProveedor"
        Me.fwiIDProveedor.SecondaryDataFields = "IDProveedor"
        Me.fwiIDProveedor.Size = New System.Drawing.Size(97, 23)
        Me.fwiIDProveedor.TabIndex = 8
        Me.fwiIDProveedor.ViewName = "tbMaestroProveedor"
        '
        'lblfwiIDProveedor
        '
        Me.lblfwiIDProveedor.Location = New System.Drawing.Point(317, 25)
        Me.lblfwiIDProveedor.Name = "lblfwiIDProveedor"
        Me.lblfwiIDProveedor.Size = New System.Drawing.Size(66, 13)
        Me.lblfwiIDProveedor.TabIndex = 30
        Me.lblfwiIDProveedor.Tag = "IdRec=4352;"
        Me.lblfwiIDProveedor.Text = "Proveedor"
        '
        'FraTotal
        '
        Me.FraTotal.Controls.Add(Me.LblTotalImpVtoA)
        Me.FraTotal.Controls.Add(Me.NtbTotalImpVtoA)
        Me.FraTotal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraTotal.Location = New System.Drawing.Point(0, 259)
        Me.FraTotal.Name = "FraTotal"
        Me.FraTotal.Size = New System.Drawing.Size(688, 42)
        Me.FraTotal.TabIndex = 31
        Me.FraTotal.TabStop = False
        '
        'LblTotalImpVtoA
        '
        Me.LblTotalImpVtoA.Location = New System.Drawing.Point(437, 18)
        Me.LblTotalImpVtoA.Name = "LblTotalImpVtoA"
        Me.LblTotalImpVtoA.Size = New System.Drawing.Size(123, 13)
        Me.LblTotalImpVtoA.TabIndex = 17
        Me.LblTotalImpVtoA.Text = "Total Importe Vto. A"
        '
        'NtbTotalImpVtoA
        '
        Me.NtbTotalImpVtoA.DisabledBackColor = System.Drawing.Color.White
        Me.NtbTotalImpVtoA.Enabled = False
        Me.NtbTotalImpVtoA.Location = New System.Drawing.Point(566, 14)
        Me.NtbTotalImpVtoA.Name = "NtbTotalImpVtoA"
        Me.NtbTotalImpVtoA.Size = New System.Drawing.Size(114, 21)
        Me.NtbTotalImpVtoA.TabIndex = 16
        '
        'CmbEmpresas
        '
        CmbEmpresas_DesignTimeLayout.LayoutString = resources.GetString("CmbEmpresas_DesignTimeLayout.LayoutString")
        Me.CmbEmpresas.DesignTimeLayout = CmbEmpresas_DesignTimeLayout
        Me.CmbEmpresas.DisabledBackColor = System.Drawing.Color.White
        Me.CmbEmpresas.DisplayMember = "DescBaseDatos"
        Me.CmbEmpresas.Location = New System.Drawing.Point(579, 44)
        Me.CmbEmpresas.Name = "CmbEmpresas"
        Me.CmbEmpresas.SelectedIndex = -1
        Me.CmbEmpresas.SelectedItem = Nothing
        Me.CmbEmpresas.Size = New System.Drawing.Size(99, 21)
        Me.CmbEmpresas.TabIndex = 38
        Me.CmbEmpresas.ValueMember = "IDBaseDatos"
        Me.CmbEmpresas.Visible = False
        '
        'LblEmpresa
        '
        Me.LblEmpresa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblEmpresa.Location = New System.Drawing.Point(516, 48)
        Me.LblEmpresa.Name = "LblEmpresa"
        Me.LblEmpresa.Size = New System.Drawing.Size(57, 13)
        Me.LblEmpresa.TabIndex = 39
        Me.LblEmpresa.Text = "Empresa"
        Me.LblEmpresa.Visible = False
        '
        'ChkMultiEmpresa
        '
        Me.ChkMultiEmpresa.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkMultiEmpresa.Location = New System.Drawing.Point(519, 15)
        Me.ChkMultiEmpresa.Name = "ChkMultiEmpresa"
        Me.ChkMultiEmpresa.Size = New System.Drawing.Size(159, 23)
        Me.ChkMultiEmpresa.TabIndex = 37
        Me.ChkMultiEmpresa.Text = "Multi-Empresa"
        '
        'CIConsultaPago
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(696, 509)
        Me.EntityName = "Pago"
        Me.KeyField = "IDPago"
        Me.Name = "CIConsultaPago"
        Me.ViewName = "vctlCIPagoContConsultaPago"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.fwiBancoPropio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fwiFormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fwiSituacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraTotal.ResumeLayout(False)
        Me.FraTotal.PerformLayout()
        CType(Me.CmbEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected mMonedaA As MonedaInfo
    Protected Const cnVerProveedor As String = "Ver Proveedor"
    Protected Const cnVerFacturaCompra As String = "Ver Factura Compra"
    Protected Const cnALIAS_MNTO_PROVEEDOR As String = "MPROV"
    Protected Const cnALIAS_MNTO_FACTURA_COMPRA As String = "MFACC"

#Region "Funciones Privadas"

    Protected Overridable Sub LoadGridActions()
        Me.Grid.Actions.Add(cnVerProveedor, AddressOf AccionAbrirProveedor, ExpertisApp.GetIcon("xProveedores.ico"))
        Me.Grid.Actions.Add(cnVerFacturaCompra, AddressOf AccionAbrirFactura, ExpertisApp.GetIcon("xFacturaCompra.ico"))
    End Sub

    Protected Overridable Sub AccionAbrirProveedor()
        If ExpertisApp.IsFormOpen(cnALIAS_MNTO_PROVEEDOR) Then ExpertisApp.CloseForm(cnALIAS_MNTO_PROVEEDOR)
        ExpertisApp.OpenForm(cnALIAS_MNTO_PROVEEDOR, New FilterItem("IDProveedor", FilterOperator.Equal, Me.Grid.GetValue("IDProveedor")))
    End Sub

    Protected Overridable Sub AccionAbrirFactura()
        If ExpertisApp.IsFormOpen(cnALIAS_MNTO_FACTURA_COMPRA) Then ExpertisApp.CloseForm(cnALIAS_MNTO_FACTURA_COMPRA)
        ExpertisApp.OpenForm(cnALIAS_MNTO_FACTURA_COMPRA, New FilterItem("IDFactura", FilterOperator.Equal, Me.Grid.GetValue("IDFactura")))
    End Sub

    Protected Overridable Sub LoadInitFilterCriteria()
        Me.fwiImpDesde.Value = Nothing
        Me.fwiImpHasta.Value = Nothing
    End Sub

    Protected Overridable Sub LoadParams()
        mMonedaA = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaA, cnMinDate)
        If Not Me.Params Is Nothing AndAlso TypeOf Me.Params Is Hashtable Then
            Dim htParams As Hashtable = Me.Params
            If htParams.ContainsKey("IDProveedor") Then
                fwiIDProveedor.Value = htParams("IDProveedor")
                fwiIDProveedor.Text = htParams("IDProveedor")
                Me.Execute()
            End If
        End If
    End Sub

    Protected Overridable Sub AplicarFiltros(ByRef e As Engine.UI.QueryExecutingEventArgs)
        e.Filter.Add("IDProveedor", FilterOperator.Equal, fwiIDProveedor.Text, FilterType.String)
        e.Filter.Add("NFactura", FilterOperator.GreaterThanOrEqual, fwiFacturaDesde.Text, FilterType.String)
        e.Filter.Add("NFactura", FilterOperator.LessThanOrEqual, fwiFacturaHasta.Text, FilterType.String)
        e.Filter.Add("ImpVencimientoA", FilterOperator.GreaterThanOrEqual, fwiImpDesde.Value, FilterType.Numeric)
        e.Filter.Add("ImpVencimientoA", FilterOperator.LessThanOrEqual, fwiImpHasta.Value, FilterType.Numeric)
        e.Filter.Add("FechaVencimiento", FilterOperator.GreaterThanOrEqual, fwiFechaVtoDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaVencimiento", FilterOperator.LessThanOrEqual, fwiFechaVtoHasta.Value, FilterType.DateTime)
        e.Filter.Add("FechaPago", FilterOperator.GreaterThanOrEqual, fwiFechaPagoDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaPago", FilterOperator.LessThanOrEqual, fwiFechaPagoHasta.Value, FilterType.DateTime)
        e.Filter.Add("IDFormaPago", FilterOperator.Equal, fwiFormaPago.Text, FilterType.String)
        e.Filter.Add("IDBancoPropio", FilterOperator.Equal, fwiBancoPropio.Text, FilterType.String)
        e.Filter.Add("Situacion", FilterOperator.Equal, fwiSituacion.Value, FilterType.Numeric)
    End Sub

    Protected Overridable Sub CalcularTotales()
        NtbTotalImpVtoA.Value = xRound(Grid.GetTotal(Grid.Columns("ImpVencimientoA"), Janus.Windows.GridEX.AggregateFunction.Sum), mMonedaA.NDecimalesImporte)
    End Sub

    Protected Overridable Sub LoadEmpresas()
        Me.CmbEmpresas.DataSource = ExpertisApp.ExecuteTask(Of Object, DataTable)(AddressOf Comunes.GetUserDataBases, Nothing)
    End Sub

#End Region

#Region "Eventos CIConsultaCobro"

#Region "Eventos Formulario"

    Protected Overridable Sub CIConsultaPago_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadGridActions()
            LoadEmpresas()
            LoadInitFilterCriteria()
            LoadParams()
        End If
    End Sub

    Protected Overridable Sub CIConsultaPago_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        AplicarFiltros(e)
        If Me.ChkMultiEmpresa.Checked Then
            Dim fEmpresasOrigen As New Filter
            If Length(Me.CmbEmpresas.Value) > 0 Then fEmpresasOrigen.Add(New GuidFilterItem("IDBaseDatos", Me.CmbEmpresas.Value))

            Dim data As New BEGetQueryMultipleDB.DataGetQueryMultipleDB(Me.ViewName, e.Filter.InnerFilter, fEmpresasOrigen, Me.ChkMultiEmpresa.Checked)
            Dim QueryMultipleDB As New GetQueryMultipleDB
            Dim DtGrid As DataTable = QueryMultipleDB.Execute(data)

            Me.Grid.DataSource = Nothing
            If Me.Grid.RootTable.Groups.Count = 0 Then
                Me.Grid.Columns("Empresa").Visible = True
                Me.Grid.RootTable.Groups.Clear()
                Dim GrpEmpresa As New Janus.Windows.GridEX.GridEXGroup
                GrpEmpresa.Column = Me.Grid.Columns("Empresa")
                GrpEmpresa.GroupPrefix = "Empresa:"
                GrpEmpresa.HeaderCaption = "Empresa"
                GrpEmpresa.SortOrder = Janus.Windows.GridEX.SortOrder.Ascending
                Me.Grid.RootTable.Groups.Add(GrpEmpresa)
            End If

            Me.BindEditEvents(DtGrid)
            Me.Grid.DataSource = DtGrid
            e.Cancel = True
        Else
            If Me.Grid.RootTable.Groups.Count > 0 Then Me.Grid.RootTable.Groups.Clear()
            Me.Grid.Columns("Empresa").Visible = False
        End If
    End Sub

    Protected Overridable Sub CIConsultaPago_QueryExecuted(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutedEventArgs) Handles MyBase.QueryExecuted
        CalcularTotales()
    End Sub

    Protected Overridable Sub CIConsultaPago_FilterCleared(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterCleared
        LoadInitFilterCriteria()
    End Sub

#End Region

#Region "Eventos Controles"

    Private Sub Grid_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If Length(Me.Grid.GetValue("IDFactura")) = 0 Then
                Me.Grid.UiCommandManager1.Commands(cnVerFacturaCompra).Visible = Janus.Windows.UI.InheritableBoolean.False
            Else
                Me.Grid.UiCommandManager1.Commands(cnVerFacturaCompra).Visible = Janus.Windows.UI.InheritableBoolean.True
            End If
        End If
    End Sub

    Protected Overridable Sub fwiImpDesde_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiImpDesde.Validated
        fwiImpHasta.Value = fwiImpDesde.Value
    End Sub

    Protected Overridable Sub fwiFechaVtoDesde_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiFechaVtoDesde.Validated
        fwiFechaVtoHasta.Value = fwiFechaVtoDesde.Value
    End Sub

    Protected Overridable Sub fwiFechaPagoDesde_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiFechaPagoDesde.Validated
        fwiFechaPagoHasta.Value = fwiFechaPagoDesde.Value
    End Sub

    Protected Overridable Sub fwiFacturaDesde_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiFacturaDesde.Validated
        fwiFacturaHasta.Text = fwiFacturaDesde.Text
    End Sub

    Protected Overridable Sub ChkMultiEmpresa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkMultiEmpresa.CheckedChanged
        Me.LblEmpresa.Visible = Me.ChkMultiEmpresa.Checked
        Me.CmbEmpresas.Visible = Me.ChkMultiEmpresa.Checked
        If Not Me.ChkMultiEmpresa.Checked Then
            Me.CmbEmpresas.Text = String.Empty
            Me.CmbEmpresas.Value = String.Empty
        End If
    End Sub

#End Region

#End Region

End Class