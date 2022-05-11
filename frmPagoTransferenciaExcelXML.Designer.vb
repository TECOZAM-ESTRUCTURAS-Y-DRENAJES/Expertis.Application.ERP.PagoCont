<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagoTransferenciaExcelXML
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
        Me.Button1 = New Solmicro.Expertis.Engine.UI.Button
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.Grid1 = New Solmicro.Expertis.Engine.UI.Grid
        Me.Button2 = New Solmicro.Expertis.Engine.UI.Button
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.TextBox3 = New Solmicro.Expertis.Engine.UI.TextBox
        Me.TextBox4 = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label3 = New Solmicro.Expertis.Engine.UI.Label
        Me.Button3 = New Solmicro.Expertis.Engine.UI.Button
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(514, 415)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 39)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Generar Fichero XML"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(511, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Generar Fichero XML"
        '
        'Grid1
        '
        Me.Grid1.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid1.AllowCardSizing = False
        Me.Grid1.AllowColumnDrag = False
        Me.Grid1.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid1.ColumnAutoResize = True
        Me.Grid1.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid1.EntityName = Nothing
        Me.Grid1.Location = New System.Drawing.Point(47, 149)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.PrimaryDataFields = Nothing
        Me.Grid1.SecondaryDataFields = Nothing
        Me.Grid1.Size = New System.Drawing.Size(1017, 230)
        Me.Grid1.TabIndex = 2
        Me.Grid1.ViewName = Nothing
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(47, 415)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(152, 39)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Volver"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(44, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre Empresa:"
        '
        'TextBox3
        '
        Me.TextBox3.DisabledBackColor = System.Drawing.Color.White
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(161, 75)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(364, 21)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.DisabledBackColor = System.Drawing.Color.White
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(912, 75)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(152, 21)
        Me.TextBox4.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(734, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Fecha y hora actual:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(912, 415)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(152, 39)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Generar Informe"
        '
        'frmPagoTransferenciaExcelXML
        '
        Me.ClientSize = New System.Drawing.Size(1098, 492)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmPagoTransferenciaExcelXML"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Grid1 As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents Button2 As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TextBox3 As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents TextBox4 As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Label3 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Button3 As Solmicro.Expertis.Engine.UI.Button

End Class
