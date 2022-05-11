Public Class frmFechaPago
    Inherits Solmicro.Expertis.Engine.UI.FormBase

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
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents fwiFecha As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblfwiFecha As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.fwiFecha = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblfwiFecha = New Solmicro.Expertis.Engine.UI.Label
        Me.SuspendLayout()
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Location = New System.Drawing.Point(130, 55)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(89, 25)
        Me.cmbCancelar.TabIndex = 2
        Me.cmbCancelar.Text = "Cancelar"
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(34, 55)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(89, 25)
        Me.cmbAceptar.TabIndex = 1
        Me.cmbAceptar.Text = "Aceptar"
        '
        'fwiFecha
        '
        Me.fwiFecha.Location = New System.Drawing.Point(90, 17)
        Me.fwiFecha.Name = "fwiFecha"
        Me.fwiFecha.Size = New System.Drawing.Size(118, 21)
        Me.fwiFecha.TabIndex = 0
        '
        'lblfwiFecha
        '
        Me.lblfwiFecha.Location = New System.Drawing.Point(30, 17)
        Me.lblfwiFecha.Name = "lblfwiFecha"
        Me.lblfwiFecha.Size = New System.Drawing.Size(37, 17)
        Me.lblfwiFecha.TabIndex = 3
        Me.lblfwiFecha.Text = "Fecha"
        '
        'frmFechaPago
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(256, 85)
        Me.Controls.Add(Me.cmbCancelar)
        Me.Controls.Add(Me.cmbAceptar)
        Me.Controls.Add(Me.lblfwiFecha)
        Me.Controls.Add(Me.fwiFecha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFechaPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva Fecha "
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public dtFecha As Date

    Private Sub cmbCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Me.DialogResult = DialogResult.OK
        If length(fwiFecha.Value) = 0 Then
            Me.DialogResult = DialogResult.Cancel
            ExpertisApp.GenerateMessage("Debe introducir la nueva fecha.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            dtFecha = fwiFecha.Value
            Me.Close()
        End If
    End Sub

End Class
