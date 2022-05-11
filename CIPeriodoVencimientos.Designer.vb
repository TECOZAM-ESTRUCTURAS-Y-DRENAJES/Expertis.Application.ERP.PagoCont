<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CIPeriodoVencimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIPeriodoVencimientos))
        Me.clbFechaFacturaD = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.clbFechaFacturaH = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaFactura1 = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbDiasVencimiento = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblDiasVencimiento = New Solmicro.Expertis.Engine.UI.Label
        Me.ClbFechaPagoHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.LblFechaPagoHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.ClbFechaPagoDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.LblFechaPagoDesde = New Solmicro.Expertis.Engine.UI.Label
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
        Me.FilterPanel.Controls.Add(Me.ClbFechaPagoHasta)
        Me.FilterPanel.Controls.Add(Me.LblFechaPagoHasta)
        Me.FilterPanel.Controls.Add(Me.ClbFechaPagoDesde)
        Me.FilterPanel.Controls.Add(Me.LblFechaPagoDesde)
        Me.FilterPanel.Controls.Add(Me.ntbDiasVencimiento)
        Me.FilterPanel.Controls.Add(Me.lblDiasVencimiento)
        Me.FilterPanel.Controls.Add(Me.advIDProveedor)
        Me.FilterPanel.Controls.Add(Me.lblIDProveedor)
        Me.FilterPanel.Controls.Add(Me.clbFechaFacturaH)
        Me.FilterPanel.Controls.Add(Me.lblFechaFactura1)
        Me.FilterPanel.Controls.Add(Me.clbFechaFacturaD)
        Me.FilterPanel.Controls.Add(Me.lblFechaFactura)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 321)
        Me.FilterPanel.Size = New System.Drawing.Size(840, 89)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(840, 321)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "Pago"
        Me.Grid.Size = New System.Drawing.Size(840, 321)
        Me.Grid.ViewName = "frmPeriodoVencimientoPagos"
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
        Me.MainPanel.Size = New System.Drawing.Size(840, 410)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(840, 410)
        '
        'clbFechaFacturaD
        '
        Me.TryDataBinding(clbFechaFacturaD, New System.Windows.Forms.Binding("BindableValue", Me, "FechaFactura", True))
        Me.clbFechaFacturaD.DisabledBackColor = System.Drawing.Color.White
        Me.clbFechaFacturaD.Location = New System.Drawing.Point(95, 22)
        Me.clbFechaFacturaD.Name = "clbFechaFacturaD"
        Me.clbFechaFacturaD.Size = New System.Drawing.Size(121, 21)
        Me.clbFechaFacturaD.TabIndex = 0
        '
        'lblFechaFactura
        '
        Me.lblFechaFactura.Location = New System.Drawing.Point(8, 26)
        Me.lblFechaFactura.Name = "lblFechaFactura"
        Me.lblFechaFactura.Size = New System.Drawing.Size(86, 13)
        Me.lblFechaFactura.TabIndex = 1
        Me.lblFechaFactura.Text = "Fecha Factura"
        '
        'clbFechaFacturaH
        '
        Me.clbFechaFacturaH.DisabledBackColor = System.Drawing.Color.White
        Me.clbFechaFacturaH.Location = New System.Drawing.Point(240, 22)
        Me.clbFechaFacturaH.Name = "clbFechaFacturaH"
        Me.clbFechaFacturaH.Size = New System.Drawing.Size(121, 21)
        Me.clbFechaFacturaH.TabIndex = 1
        '
        'lblFechaFactura1
        '
        Me.lblFechaFactura1.Location = New System.Drawing.Point(222, 26)
        Me.lblFechaFactura1.Name = "lblFechaFactura1"
        Me.lblFechaFactura1.Size = New System.Drawing.Size(12, 13)
        Me.lblFechaFactura1.TabIndex = 3
        Me.lblFechaFactura1.Text = "-"
        '
        'advIDProveedor
        '
        Me.TryDataBinding(advIDProveedor, New System.Windows.Forms.Binding("Text", Me, "IDProveedor", True))
        Me.advIDProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.advIDProveedor.EntityName = "Proveedor"
        Me.advIDProveedor.Location = New System.Drawing.Point(712, 21)
        Me.advIDProveedor.Name = "advIDProveedor"
        Me.advIDProveedor.PrimaryDataFields = "IDProveedor"
        Me.advIDProveedor.SecondaryDataFields = "IDProveedor"
        Me.advIDProveedor.Size = New System.Drawing.Size(121, 23)
        Me.advIDProveedor.TabIndex = 4
        '
        'lblIDProveedor
        '
        Me.lblIDProveedor.Location = New System.Drawing.Point(636, 26)
        Me.lblIDProveedor.Name = "lblIDProveedor"
        Me.lblIDProveedor.Size = New System.Drawing.Size(66, 13)
        Me.lblIDProveedor.TabIndex = 5
        Me.lblIDProveedor.Text = "Proveedor"
        '
        'ntbDiasVencimiento
        '
        Me.ntbDiasVencimiento.DisabledBackColor = System.Drawing.Color.White
        Me.ntbDiasVencimiento.Location = New System.Drawing.Point(712, 55)
        Me.ntbDiasVencimiento.Name = "ntbDiasVencimiento"
        Me.ntbDiasVencimiento.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.ntbDiasVencimiento.Size = New System.Drawing.Size(121, 21)
        Me.ntbDiasVencimiento.TabIndex = 5
        '
        'lblDiasVencimiento
        '
        Me.lblDiasVencimiento.Location = New System.Drawing.Point(636, 59)
        Me.lblDiasVencimiento.Name = "lblDiasVencimiento"
        Me.lblDiasVencimiento.Size = New System.Drawing.Size(70, 13)
        Me.lblDiasVencimiento.TabIndex = 8
        Me.lblDiasVencimiento.Text = "Nº días >="
        '
        'ClbFechaPagoHasta
        '
        Me.ClbFechaPagoHasta.DisabledBackColor = System.Drawing.Color.White
        Me.ClbFechaPagoHasta.Location = New System.Drawing.Point(240, 55)
        Me.ClbFechaPagoHasta.Name = "ClbFechaPagoHasta"
        Me.ClbFechaPagoHasta.Size = New System.Drawing.Size(121, 21)
        Me.ClbFechaPagoHasta.TabIndex = 3
        '
        'LblFechaPagoHasta
        '
        Me.LblFechaPagoHasta.Location = New System.Drawing.Point(222, 59)
        Me.LblFechaPagoHasta.Name = "LblFechaPagoHasta"
        Me.LblFechaPagoHasta.Size = New System.Drawing.Size(12, 13)
        Me.LblFechaPagoHasta.TabIndex = 12
        Me.LblFechaPagoHasta.Text = "-"
        '
        'ClbFechaPagoDesde
        '
        Me.ClbFechaPagoDesde.DisabledBackColor = System.Drawing.Color.White
        Me.ClbFechaPagoDesde.Location = New System.Drawing.Point(95, 55)
        Me.ClbFechaPagoDesde.Name = "ClbFechaPagoDesde"
        Me.ClbFechaPagoDesde.Size = New System.Drawing.Size(121, 21)
        Me.ClbFechaPagoDesde.TabIndex = 2
        '
        'LblFechaPagoDesde
        '
        Me.LblFechaPagoDesde.Location = New System.Drawing.Point(8, 59)
        Me.LblFechaPagoDesde.Name = "LblFechaPagoDesde"
        Me.LblFechaPagoDesde.Size = New System.Drawing.Size(72, 13)
        Me.LblFechaPagoDesde.TabIndex = 10
        Me.LblFechaPagoDesde.Text = "Fecha Pago"
        '
        'CIPeriodoVencimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 498)
        Me.EntityName = "Pago"
        Me.Name = "CIPeriodoVencimientos"
        Me.Text = "Consulta Vencimientos Excedidos de Período"
        Me.ViewName = "frmPeriodoVencimientoPagos"
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
    Friend WithEvents clbFechaFacturaH As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaFactura1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents clbFechaFacturaD As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaFactura As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblIDProveedor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbDiasVencimiento As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblDiasVencimiento As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ClbFechaPagoHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents LblFechaPagoHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ClbFechaPagoDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents LblFechaPagoDesde As Solmicro.Expertis.Engine.UI.Label
End Class
