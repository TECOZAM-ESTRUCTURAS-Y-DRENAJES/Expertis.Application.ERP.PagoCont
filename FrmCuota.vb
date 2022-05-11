Imports Solmicro.Expertis.Business.General

Public Class FrmCuota
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
    Friend WithEvents BtnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents LblCuota As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TxtInfo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents NtbCuota As Solmicro.Expertis.Engine.UI.NumericTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.LblCuota = New Solmicro.Expertis.Engine.UI.Label
        Me.BtnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.TxtInfo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.NtbCuota = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.SuspendLayout()
        '
        'LblCuota
        '
        Me.LblCuota.Location = New System.Drawing.Point(96, 88)
        Me.LblCuota.Name = "LblCuota"
        Me.LblCuota.Size = New System.Drawing.Size(48, 23)
        Me.LblCuota.TabIndex = 1
        Me.LblCuota.Text = "Cuota"
        Me.LblCuota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(64, 120)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(88, 32)
        Me.BtnAceptar.TabIndex = 1
        Me.BtnAceptar.Text = "&Aceptar"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(160, 120)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(88, 32)
        Me.BtnCancelar.TabIndex = 2
        Me.BtnCancelar.Text = "&Cancelar"
        '
        'TxtInfo
        '
        Me.TxtInfo.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.TxtInfo.Enabled = False
        Me.TxtInfo.Location = New System.Drawing.Point(8, 8)
        Me.TxtInfo.Multiline = True
        Me.TxtInfo.Name = "TxtInfo"
        Me.TxtInfo.ReadOnly = True
        Me.TxtInfo.Size = New System.Drawing.Size(304, 72)
        Me.TxtInfo.TabIndex = 0
        Me.TxtInfo.TabStop = False
        Me.TxtInfo.Text = "Este valor es el correspondiente al cálculo de la nueva cuota con las nuevas cond" & _
        "iciones del leasing. Si no se ajusta al que aparece en el contrato, modifique es" & _
        "te valor con el correcto."
        Me.TxtInfo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'NtbCuota
        '
        Me.NtbCuota.DecimalDigits = 0
        Me.NtbCuota.Location = New System.Drawing.Point(152, 88)
        Me.NtbCuota.Name = "NtbCuota"
        Me.NtbCuota.Size = New System.Drawing.Size(75, 21)
        Me.NtbCuota.TabIndex = 0
        '
        'FrmCuota
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(322, 159)
        Me.Controls.Add(Me.NtbCuota)
        Me.Controls.Add(Me.TxtInfo)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.LblCuota)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCuota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCuota"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Variables / Propiedades Públicas"

    Private MDblCuota As Double

    Public Property Cuota() As Double
        Get
            Return MDblCuota
        End Get
        Set(ByVal Value As Double)
            MDblCuota = Value
        End Set
    End Property

#End Region

#Region "Funciones / Procesos "

    Public Function LoadFunction() As DialogResult
        Dim ClsMoneda As New Moneda
        Dim LngNDecimalesImp As Long
        Dim DtMonedaA As DataTable = ExpertisApp.ExecuteTask(Of Object, DataTable)(AddressOf Moneda.ObtenerMonedaA, New Object)
        If Not DtMonedaA Is Nothing AndAlso DtMonedaA.Rows.Count > 0 Then
            LngNDecimalesImp = DtMonedaA.Rows(0)("NDecimalesImp")
        End If
        NtbCuota.Value = xRound(MDblCuota, LngNDecimalesImp)
        Return Me.ShowDialog()
    End Function

#End Region

#Region "Eventos FrmCuota"

    Private Sub BtnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If length(NtbCuota.Value) > 0 Then
            MDblCuota = NtbCuota.Value
            Me.DialogResult = DialogResult.OK
        Else
            ExpertisApp.GenerateMessage("El campo | es obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Information, NtbCuota.Text)
            NtbCuota.Focus()
        End If
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        NtbCuota.Value = DBNull.Value
        Me.DialogResult = DialogResult.Cancel
    End Sub

#End Region

End Class