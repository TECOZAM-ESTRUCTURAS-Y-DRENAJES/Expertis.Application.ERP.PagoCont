<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagoTransferenciaExcel
    Inherits Solmicro.Expertis.Engine.UI.FormBase

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPagoTransferenciaExcel))
        Me.Button1 = New Solmicro.Expertis.Engine.UI.Button
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.TextBox1 = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Button2 = New Solmicro.Expertis.Engine.UI.Button
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvSearch1 = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Button3 = New Solmicro.Expertis.Engine.UI.Button
        Me.Button4 = New Solmicro.Expertis.Engine.UI.Button
        Me.TextBox2 = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label4 = New Solmicro.Expertis.Engine.UI.Label
        Me.Button5 = New Solmicro.Expertis.Engine.UI.Button
        Me.Grid1 = New Solmicro.Expertis.Engine.UI.Grid
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(66, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 34)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Importar Excel"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(63, 460)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "RUTA FICHERO GENERADO:"
        '
        'TextBox1
        '
        Me.TextBox1.DisabledBackColor = System.Drawing.Color.White
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(279, 456)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(395, 21)
        Me.TextBox1.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(867, 438)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 39)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Buscar ruta"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(63, 551)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "SELECCIONAR BANCO PROPIO:"
        '
        'AdvSearch1
        '
        Me.AdvSearch1.DisabledBackColor = System.Drawing.Color.White
        Me.AdvSearch1.DisplayField = "IDBancoPropio"
        Me.AdvSearch1.EntityName = "BancoPropio"
        Me.AdvSearch1.Location = New System.Drawing.Point(279, 546)
        Me.AdvSearch1.Name = "AdvSearch1"
        Me.AdvSearch1.Size = New System.Drawing.Size(238, 23)
        Me.AdvSearch1.TabIndex = 6
        Me.AdvSearch1.ViewName = "tbMaestroBancoPropio"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(728, 533)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 36)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Aceptar"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(867, 533)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(116, 35)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Cancelar"
        '
        'TextBox2
        '
        Me.TextBox2.DisabledBackColor = System.Drawing.Color.White
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(552, 58)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(347, 21)
        Me.TextBox2.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(408, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "RUTA DEL EXCEL:"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(66, 48)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(182, 35)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Seleccionar Excel"
        '
        'Grid1
        '
        Me.Grid1.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid1.AllowColumnDrag = False
        Me.Grid1.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid1.ColumnAutoResize = True
        Grid1_DesignTimeLayout.LayoutString = resources.GetString("Grid1_DesignTimeLayout.LayoutString")
        Me.Grid1.DesignTimeLayout = Grid1_DesignTimeLayout
        Me.Grid1.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid1.EntityName = "PagoTransferencia"
        Me.Grid1.KeyField = "IDTransferencia"
        Me.Grid1.Location = New System.Drawing.Point(66, 193)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.PrimaryDataFields = Nothing
        Me.Grid1.SecondaryDataFields = Nothing
        Me.Grid1.Size = New System.Drawing.Size(917, 217)
        Me.Grid1.TabIndex = 15
        Me.Grid1.ViewName = "tbPagoTransferencia"
        '
        'frmPagoTransferenciaExcel
        '
        Me.ClientSize = New System.Drawing.Size(1047, 656)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.AdvSearch1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.EntityName = "PagoTransferencia"
        Me.Name = "frmPagoTransferenciaExcel"
        Me.NavigationFields = "IDTransferencia"
        Me.ViewName = "tbPagoTransferencia"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TextBox1 As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Button2 As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvSearch1 As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents Button3 As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Button4 As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents dtg As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox2 As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Label4 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Button5 As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Grid1 As Solmicro.Expertis.Engine.UI.Grid

End Class
