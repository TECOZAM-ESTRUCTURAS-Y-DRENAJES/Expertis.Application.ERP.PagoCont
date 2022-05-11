Public Class FrmAno
    Inherits Solmicro.Expertis.Engine.UI.FormBase

#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de Windows Forms. 
    'No lo modifique con el editor de c�digo.
    Friend WithEvents LblA�o As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents BtnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents TxtInfo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents NtbA�o As Solmicro.Expertis.Engine.UI.NumericTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.LblA�o = New Solmicro.Expertis.Engine.UI.Label
        Me.BtnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.TxtInfo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.NtbA�o = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.SuspendLayout()
        '
        'LblA�o
        '
        Me.LblA�o.Location = New System.Drawing.Point(121, 40)
        Me.LblA�o.Name = "LblA�o"
        Me.LblA�o.Size = New System.Drawing.Size(26, 17)
        Me.LblA�o.TabIndex = 1
        Me.LblA�o.Text = "A�o"
        Me.LblA�o.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.TxtInfo.Text = "Introduzca el A�o para el que quiero obtener el informe."
        Me.TxtInfo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'NtbA�o
        '
        Me.NtbA�o.DecimalDigits = 0
        Me.NtbA�o.Location = New System.Drawing.Point(160, 40)
        Me.NtbA�o.MaxLength = 4
        Me.NtbA�o.Name = "NtbA�o"
        Me.NtbA�o.Size = New System.Drawing.Size(104, 21)
        Me.NtbA�o.TabIndex = 0
        '
        'FrmA�o
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(394, 119)
        Me.Controls.Add(Me.NtbA�o)
        Me.Controls.Add(Me.TxtInfo)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.LblA�o)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "A�o"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Variables / Propiedades P�blicas / Privadas"
    Private MIntA�o As Integer

    Public Property A�o() As Integer
        Get
            Return MIntA�o
        End Get
        Set(ByVal Value As Integer)
            MIntA�o = Value
        End Set
    End Property

#End Region

#Region "Funciones / Procesos"

    Public Function LoadFunction() As DialogResult
        Return Me.ShowDialog()
    End Function

#End Region

#Region "Eventos FrmA�o"

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If Length(NtbA�o.Value) > 0 Then
            MIntA�o = NtbA�o.Value
            Me.DialogResult = DialogResult.OK
        Else
            ExpertisApp.GenerateMessage("El A�o es un dato obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            NtbA�o.Focus()
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        NtbA�o.Value = DBNull.Value
        Me.DialogResult = DialogResult.Cancel
    End Sub

#End Region

End Class