Public Class frmAnoDesdeHastaFC
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
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents NtbA�oHasta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents NtbA�oDesde As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents LblA�o As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents BtnCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label3 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiFechaInforme As Solmicro.Expertis.Engine.UI.CalendarBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbA�oHasta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbA�oDesde = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.LblA�o = New Solmicro.Expertis.Engine.UI.Label
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
        Me.Label2.Text = "A�o Hasta"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NtbA�oHasta
        '
        Me.NtbA�oHasta.DecimalDigits = 0
        Me.NtbA�oHasta.Location = New System.Drawing.Point(331, 50)
        Me.NtbA�oHasta.MaxLength = 4
        Me.NtbA�oHasta.Name = "NtbA�oHasta"
        Me.NtbA�oHasta.Size = New System.Drawing.Size(104, 21)
        Me.NtbA�oHasta.TabIndex = 14
        '
        'NtbA�oDesde
        '
        Me.NtbA�oDesde.DecimalDigits = 0
        Me.NtbA�oDesde.Location = New System.Drawing.Point(100, 50)
        Me.NtbA�oDesde.MaxLength = 4
        Me.NtbA�oDesde.Name = "NtbA�oDesde"
        Me.NtbA�oDesde.Size = New System.Drawing.Size(104, 21)
        Me.NtbA�oDesde.TabIndex = 12
        '
        'LblA�o
        '
        Me.LblA�o.Location = New System.Drawing.Point(21, 50)
        Me.LblA�o.Name = "LblA�o"
        Me.LblA�o.Size = New System.Drawing.Size(65, 17)
        Me.LblA�o.TabIndex = 13
        Me.LblA�o.Text = "A�o Desde"
        Me.LblA�o.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Label1.Text = "Introduzca desde que A�o hasta que A�o  desea obtener el informe."
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
        'frmA�oDesdeHastaFC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(496, 165)
        Me.Controls.Add(Me.FwiFechaInforme)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NtbA�oHasta)
        Me.Controls.Add(Me.NtbA�oDesde)
        Me.Controls.Add(Me.LblA�o)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAnoDesdeHastaFC"
        Me.Text = "Intervalo de A�os"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables / Propiedades P�blicas / Privadas"
    Private MIntA�oDesde As Integer
    Private MIntA�oHasta As Integer
    Private dtFechaInforme As Date

    Public Property A�oDesde() As Integer
        Get
            Return MIntA�oDesde
        End Get
        Set(ByVal Value As Integer)
            MIntA�oDesde = Value
        End Set
    End Property

    Public Property A�oHasta() As Integer
        Get
            Return MIntA�oHasta
        End Get
        Set(ByVal Value As Integer)
            MIntA�oHasta = Value
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
                If Length(NtbA�oDesde.Value) > 0 And Length(NtbA�oHasta.Value) > 0 Then
                    If IsNumeric(NtbA�oDesde.Value) And IsNumeric(NtbA�oHasta.Value) Then
                        MIntA�oDesde = NtbA�oDesde.Value
                        MIntA�oHasta = NtbA�oHasta.Value
                        dtFechaInforme = FwiFechaInforme.Value
                        Me.DialogResult = DialogResult.OK
                    Else
                        ExpertisApp.GenerateMessage("Campo no num�rico.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    ExpertisApp.GenerateMessage("El A�o es un dato obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                ExpertisApp.GenerateMessage("No es una fecha.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            ExpertisApp.GenerateMessage("Antes de continuar seleccione una fecha.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        NtbA�oDesde.Value = DBNull.Value
        NtbA�oHasta.Value = DBNull.Value
        FwiFechaInforme.Value = DBNull.Value
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class
