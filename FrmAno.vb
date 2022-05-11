Public Class FrmAno
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
    Friend WithEvents LblAño As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents BtnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents TxtInfo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents NtbAño As Solmicro.Expertis.Engine.UI.NumericTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.LblAño = New Solmicro.Expertis.Engine.UI.Label
        Me.BtnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.TxtInfo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.NtbAño = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.SuspendLayout()
        '
        'LblAño
        '
        Me.LblAño.Location = New System.Drawing.Point(121, 40)
        Me.LblAño.Name = "LblAño"
        Me.LblAño.Size = New System.Drawing.Size(26, 17)
        Me.LblAño.TabIndex = 1
        Me.LblAño.Text = "Año"
        Me.LblAño.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(104, 72)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(88, 32)
        Me.BtnAceptar.TabIndex = 1
        Me.BtnAceptar.Text = "&Aceptar"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(200, 72)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(88, 32)
        Me.BtnCancelar.TabIndex = 2
        Me.BtnCancelar.Text = "&Cancelar"
        '
        'TxtInfo
        '
        Me.TxtInfo.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.TxtInfo.Location = New System.Drawing.Point(8, 8)
        Me.TxtInfo.Multiline = True
        Me.TxtInfo.Name = "TxtInfo"
        Me.TxtInfo.Size = New System.Drawing.Size(376, 24)
        Me.TxtInfo.TabIndex = 5
        Me.TxtInfo.Text = "Introduzca el Año para el que quiero obtener el informe."
        Me.TxtInfo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'NtbAño
        '
        Me.NtbAño.DecimalDigits = 0
        Me.NtbAño.Location = New System.Drawing.Point(160, 40)
        Me.NtbAño.MaxLength = 4
        Me.NtbAño.Name = "NtbAño"
        Me.NtbAño.Size = New System.Drawing.Size(104, 21)
        Me.NtbAño.TabIndex = 0
        '
        'FrmAño
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(394, 119)
        Me.Controls.Add(Me.NtbAño)
        Me.Controls.Add(Me.TxtInfo)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.LblAño)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Año"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Variables / Propiedades Públicas / Privadas"
    Private MIntAño As Integer

    Public Property Año() As Integer
        Get
            Return MIntAño
        End Get
        Set(ByVal Value As Integer)
            MIntAño = Value
        End Set
    End Property

#End Region

#Region "Funciones / Procesos"

    Public Function LoadFunction() As DialogResult
        Return Me.ShowDialog()
    End Function

#End Region

#Region "Eventos FrmAño"

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If Length(NtbAño.Value) > 0 Then
            MIntAño = NtbAño.Value
            Me.DialogResult = DialogResult.OK
        Else
            ExpertisApp.GenerateMessage("El Año es un dato obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            NtbAño.Focus()
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        NtbAño.Value = DBNull.Value
        Me.DialogResult = DialogResult.Cancel
    End Sub

#End Region

End Class