Public Class frmAnoDesdeHastaFC
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
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents NtbAñoHasta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents NtbAñoDesde As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents LblAño As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents BtnCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label3 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiFechaInforme As Solmicro.Expertis.Engine.UI.CalendarBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbAñoHasta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbAñoDesde = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.LblAño = New Solmicro.Expertis.Engine.UI.Label
        Me.BtnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label3 = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiFechaInforme = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(251, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Año Hasta"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NtbAñoHasta
        '
        Me.NtbAñoHasta.DecimalDigits = 0
        Me.NtbAñoHasta.Location = New System.Drawing.Point(331, 50)
        Me.NtbAñoHasta.MaxLength = 4
        Me.NtbAñoHasta.Name = "NtbAñoHasta"
        Me.NtbAñoHasta.Size = New System.Drawing.Size(104, 21)
        Me.NtbAñoHasta.TabIndex = 14
        '
        'NtbAñoDesde
        '
        Me.NtbAñoDesde.DecimalDigits = 0
        Me.NtbAñoDesde.Location = New System.Drawing.Point(100, 50)
        Me.NtbAñoDesde.MaxLength = 4
        Me.NtbAñoDesde.Name = "NtbAñoDesde"
        Me.NtbAñoDesde.Size = New System.Drawing.Size(104, 21)
        Me.NtbAñoDesde.TabIndex = 12
        '
        'LblAño
        '
        Me.LblAño.Location = New System.Drawing.Point(21, 50)
        Me.LblAño.Name = "LblAño"
        Me.LblAño.Size = New System.Drawing.Size(65, 17)
        Me.LblAño.TabIndex = 13
        Me.LblAño.Text = "Año Desde"
        Me.LblAño.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(260, 125)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(88, 32)
        Me.BtnCancelar.TabIndex = 11
        Me.BtnCancelar.Text = "&Cancelar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(120, 125)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(88, 32)
        Me.BtnAceptar.TabIndex = 10
        Me.BtnAceptar.Text = "&Aceptar"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(394, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Introduzca desde que Año hasta que Año  desea obtener el informe."
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(104, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Fecha del Informe"
        '
        'FwiFechaInforme
        '
        Me.FwiFechaInforme.Location = New System.Drawing.Point(232, 88)
        Me.FwiFechaInforme.Name = "FwiFechaInforme"
        Me.FwiFechaInforme.Size = New System.Drawing.Size(112, 21)
        Me.FwiFechaInforme.TabIndex = 17
        '
        'frmAñoDesdeHastaFC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(496, 165)
        Me.Controls.Add(Me.FwiFechaInforme)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NtbAñoHasta)
        Me.Controls.Add(Me.NtbAñoDesde)
        Me.Controls.Add(Me.LblAño)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAnoDesdeHastaFC"
        Me.Text = "Intervalo de Años"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables / Propiedades Públicas / Privadas"
    Private MIntAñoDesde As Integer
    Private MIntAñoHasta As Integer
    Private dtFechaInforme As Date

    Public Property AñoDesde() As Integer
        Get
            Return MIntAñoDesde
        End Get
        Set(ByVal Value As Integer)
            MIntAñoDesde = Value
        End Set
    End Property

    Public Property AñoHasta() As Integer
        Get
            Return MIntAñoHasta
        End Get
        Set(ByVal Value As Integer)
            MIntAñoHasta = Value
        End Set
    End Property

    Public Property FechaInforme() As Date
        Get
            Return dtFechaInforme
        End Get
        Set(ByVal Value As Date)
            dtFechaInforme = Value
        End Set
    End Property

#End Region

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If Length(FwiFechaInforme.Value) > 0 Then
            If IsDate(FwiFechaInforme.Value) Then
                If Length(NtbAñoDesde.Value) > 0 And Length(NtbAñoHasta.Value) > 0 Then
                    If IsNumeric(NtbAñoDesde.Value) And IsNumeric(NtbAñoHasta.Value) Then
                        MIntAñoDesde = NtbAñoDesde.Value
                        MIntAñoHasta = NtbAñoHasta.Value
                        dtFechaInforme = FwiFechaInforme.Value
                        Me.DialogResult = DialogResult.OK
                    Else
                        ExpertisApp.GenerateMessage("Campo no numérico.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    ExpertisApp.GenerateMessage("El Año es un dato obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                ExpertisApp.GenerateMessage("No es una fecha.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            ExpertisApp.GenerateMessage("Antes de continuar seleccione una fecha.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        NtbAñoDesde.Value = DBNull.Value
        NtbAñoHasta.Value = DBNull.Value
        FwiFechaInforme.Value = DBNull.Value
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class
