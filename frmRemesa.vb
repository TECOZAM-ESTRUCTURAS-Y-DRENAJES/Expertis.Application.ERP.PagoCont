Public Class frmRemesa
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
    Friend WithEvents BtnCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents AdvRemesa As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblRemesa As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BtnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.AdvRemesa = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblRemesa = New Solmicro.Expertis.Engine.UI.Label
        Me.SuspendLayout()
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(112, 48)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(90, 27)
        Me.BtnCancelar.TabIndex = 2
        Me.BtnCancelar.Text = "&Cancelar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(8, 48)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(90, 27)
        Me.BtnAceptar.TabIndex = 1
        Me.BtnAceptar.Text = "&Aceptar"
        '
        'AdvRemesa
        '
        Me.AdvRemesa.EntityName = "RemesaPago"
        Me.AdvRemesa.Location = New System.Drawing.Point(80, 16)
        Me.AdvRemesa.Name = "AdvRemesa"
        Me.AdvRemesa.SecondaryDataFields = "IDRemesa"
        Me.AdvRemesa.Size = New System.Drawing.Size(120, 21)
        Me.AdvRemesa.TabIndex = 0
        Me.AdvRemesa.ViewName = "tbRemesaPago"
        '
        'LblRemesa
        '
        Me.LblRemesa.Location = New System.Drawing.Point(16, 16)
        Me.LblRemesa.Name = "LblRemesa"
        Me.LblRemesa.Size = New System.Drawing.Size(49, 17)
        Me.LblRemesa.TabIndex = 3
        Me.LblRemesa.Text = "Remesa"
        '
        'frmRemesa
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(210, 87)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.LblRemesa)
        Me.Controls.Add(Me.AdvRemesa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRemesa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elige la Remesa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Propiedades Públicas"

    Private MIntIDRemesa As Integer

    Public ReadOnly Property IDRemesa() As Integer
        Get
            Return MIntIDRemesa
        End Get
    End Property

#End Region

#Region "Eventos FrmRemesa"

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If Length(AdvRemesa.Value) > 0 Then
            MIntIDRemesa = AdvRemesa.Value
            Me.DialogResult = DialogResult.OK
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar un número de remesa.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

#End Region

End Class