<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CIPeriodoMedioPago
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cboAnio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIPeriodoMedioPago))
        Me.lblAnio = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDTipoProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblTipoProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalPagosRealizados = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtTotalPagosPendientes = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtRatioOperacionesPagadas = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtRatioOperacionesPendientes = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtPeriodoMedioPago = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label3 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label4 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label5 = New Solmicro.Expertis.Engine.UI.Label
        Me.cboAnio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.cboAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.cboAnio)
        Me.FilterPanel.Controls.Add(Me.Label5)
        Me.FilterPanel.Controls.Add(Me.Label4)
        Me.FilterPanel.Controls.Add(Me.Label3)
        Me.FilterPanel.Controls.Add(Me.Label2)
        Me.FilterPanel.Controls.Add(Me.Label1)
        Me.FilterPanel.Controls.Add(Me.txtPeriodoMedioPago)
        Me.FilterPanel.Controls.Add(Me.txtRatioOperacionesPendientes)
        Me.FilterPanel.Controls.Add(Me.txtRatioOperacionesPagadas)
        Me.FilterPanel.Controls.Add(Me.txtTotalPagosPendientes)
        Me.FilterPanel.Controls.Add(Me.txtTotalPagosRealizados)
        Me.FilterPanel.Controls.Add(Me.advIDTipoProveedor)
        Me.FilterPanel.Controls.Add(Me.lblTipoProveedor)
        Me.FilterPanel.Controls.Add(Me.lblAnio)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 247)
        Me.FilterPanel.Size = New System.Drawing.Size(935, 189)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(935, 247)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "Pago"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.KeyField = "IDPago"
        Me.Grid.Size = New System.Drawing.Size(935, 247)
        Me.Grid.ViewName = "vfrmCIPeriodoMedioPago"
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
        Me.MainPanel.Size = New System.Drawing.Size(935, 436)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(935, 436)
        '
        'lblAnio
        '
        Me.lblAnio.Location = New System.Drawing.Point(8, 30)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.Size = New System.Drawing.Size(29, 13)
        Me.lblAnio.TabIndex = 42
        Me.lblAnio.Text = "Año"
        '
        'advIDTipoProveedor
        '
        Me.advIDTipoProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.advIDTipoProveedor.DisplayField = "DescTipoProveedor"
        Me.advIDTipoProveedor.EntityName = "TipoProveedor"
        Me.advIDTipoProveedor.Location = New System.Drawing.Point(113, 52)
        Me.advIDTipoProveedor.Name = "advIDTipoProveedor"
        Me.advIDTipoProveedor.SecondaryDataFields = "IDTipoProveedor"
        Me.advIDTipoProveedor.Size = New System.Drawing.Size(121, 23)
        Me.advIDTipoProveedor.TabIndex = 1
        Me.advIDTipoProveedor.ViewName = "tbMaestroTipoProveedor"
        '
        'lblTipoProveedor
        '
        Me.lblTipoProveedor.Location = New System.Drawing.Point(8, 56)
        Me.lblTipoProveedor.Name = "lblTipoProveedor"
        Me.lblTipoProveedor.Size = New System.Drawing.Size(94, 13)
        Me.lblTipoProveedor.TabIndex = 46
        Me.lblTipoProveedor.Text = "Tipo Proveedor"
        '
        'txtTotalPagosRealizados
        '
        Me.txtTotalPagosRealizados.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalPagosRealizados.Enabled = False
        Me.txtTotalPagosRealizados.Location = New System.Drawing.Point(827, 18)
        Me.txtTotalPagosRealizados.Name = "txtTotalPagosRealizados"
        Me.txtTotalPagosRealizados.Size = New System.Drawing.Size(100, 21)
        Me.txtTotalPagosRealizados.TabIndex = 47
        '
        'txtTotalPagosPendientes
        '
        Me.txtTotalPagosPendientes.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalPagosPendientes.Enabled = False
        Me.txtTotalPagosPendientes.Location = New System.Drawing.Point(827, 45)
        Me.txtTotalPagosPendientes.Name = "txtTotalPagosPendientes"
        Me.txtTotalPagosPendientes.Size = New System.Drawing.Size(100, 21)
        Me.txtTotalPagosPendientes.TabIndex = 48
        '
        'txtRatioOperacionesPagadas
        '
        Me.txtRatioOperacionesPagadas.DisabledBackColor = System.Drawing.Color.White
        Me.txtRatioOperacionesPagadas.Enabled = False
        Me.txtRatioOperacionesPagadas.Location = New System.Drawing.Point(827, 73)
        Me.txtRatioOperacionesPagadas.Name = "txtRatioOperacionesPagadas"
        Me.txtRatioOperacionesPagadas.Size = New System.Drawing.Size(100, 21)
        Me.txtRatioOperacionesPagadas.TabIndex = 49
        '
        'txtRatioOperacionesPendientes
        '
        Me.txtRatioOperacionesPendientes.DisabledBackColor = System.Drawing.Color.White
        Me.txtRatioOperacionesPendientes.Enabled = False
        Me.txtRatioOperacionesPendientes.Location = New System.Drawing.Point(827, 100)
        Me.txtRatioOperacionesPendientes.Name = "txtRatioOperacionesPendientes"
        Me.txtRatioOperacionesPendientes.Size = New System.Drawing.Size(100, 21)
        Me.txtRatioOperacionesPendientes.TabIndex = 50
        '
        'txtPeriodoMedioPago
        '
        Me.txtPeriodoMedioPago.DisabledBackColor = System.Drawing.Color.White
        Me.txtPeriodoMedioPago.Enabled = False
        Me.txtPeriodoMedioPago.Location = New System.Drawing.Point(827, 156)
        Me.txtPeriodoMedioPago.Name = "txtPeriodoMedioPago"
        Me.txtPeriodoMedioPago.Size = New System.Drawing.Size(100, 21)
        Me.txtPeriodoMedioPago.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(637, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 18)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Total Pagos Realizados"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(637, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 18)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Total Pagos Pendientes"
        Me.Label2.UseCompatibleTextRendering = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(637, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 18)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Ratio Operaciones Pagadas"
        Me.Label3.UseCompatibleTextRendering = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(637, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 18)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Ratio Operaciones Pendientes"
        Me.Label4.UseCompatibleTextRendering = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(637, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 18)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Periodo Medio Pago"
        Me.Label5.UseCompatibleTextRendering = True
        '
        'cboAnio
        '
        cboAnio_DesignTimeLayout.LayoutString = resources.GetString("cboAnio_DesignTimeLayout.LayoutString")
        Me.cboAnio.DesignTimeLayout = cboAnio_DesignTimeLayout
        Me.cboAnio.DisabledBackColor = System.Drawing.Color.White
        Me.cboAnio.Location = New System.Drawing.Point(113, 26)
        Me.cboAnio.Name = "cboAnio"
        Me.cboAnio.SelectedIndex = -1
        Me.cboAnio.SelectedItem = Nothing
        Me.cboAnio.Size = New System.Drawing.Size(121, 21)
        Me.cboAnio.TabIndex = 0
        '
        'CIPeriodoMedioPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 524)
        Me.EntityName = "Pago"
        Me.KeyField = "IDPago"
        Me.Name = "CIPeriodoMedioPago"
        Me.Text = "Cálculo del Periodo Medio de Pago"
        Me.ViewName = "vfrmCIPeriodoMedioPago"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.cboAnio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents lblAnio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents advIDTipoProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblTipoProveedor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents Label5 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents Label4 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents Label3 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtPeriodoMedioPago As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtRatioOperacionesPendientes As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtRatioOperacionesPagadas As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtTotalPagosPendientes As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtTotalPagosRealizados As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents cboAnio As Solmicro.Expertis.Engine.UI.ComboBox
End Class
