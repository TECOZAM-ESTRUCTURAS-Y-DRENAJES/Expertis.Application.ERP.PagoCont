Imports Solmicro.Expertis.Business.General

Public Class FrmAgrupaPagos
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
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents chkFechaVto As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkCambioA As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkCambioB As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkFPago As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkBancoProveedor As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkMoneda As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkProveedor As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.chkFechaVto = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkCambioA = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkCambioB = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkFPago = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkBancoProveedor = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkMoneda = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkProveedor = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.Panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'chkFechaVto
        '
        Me.chkFechaVto.Location = New System.Drawing.Point(22, 28)
        Me.chkFechaVto.Name = "chkFechaVto"
        Me.chkFechaVto.Size = New System.Drawing.Size(98, 20)
        Me.chkFechaVto.TabIndex = 2
        Me.chkFechaVto.Text = "Fecha Vto."
        '
        'chkCambioA
        '
        Me.chkCambioA.Location = New System.Drawing.Point(22, 67)
        Me.chkCambioA.Name = "chkCambioA"
        Me.chkCambioA.Size = New System.Drawing.Size(98, 20)
        Me.chkCambioA.TabIndex = 4
        Me.chkCambioA.Text = "Cambio A"
        '
        'chkCambioB
        '
        Me.chkCambioB.Location = New System.Drawing.Point(126, 9)
        Me.chkCambioB.Name = "chkCambioB"
        Me.chkCambioB.Size = New System.Drawing.Size(98, 20)
        Me.chkCambioB.TabIndex = 5
        Me.chkCambioB.Text = "Cambio B"
        '
        'chkFPago
        '
        Me.chkFPago.Location = New System.Drawing.Point(126, 28)
        Me.chkFPago.Name = "chkFPago"
        Me.chkFPago.Size = New System.Drawing.Size(98, 20)
        Me.chkFPago.TabIndex = 6
        Me.chkFPago.Text = "Forma Pago"
        '
        'chkBancoProveedor
        '
        Me.chkBancoProveedor.Location = New System.Drawing.Point(126, 48)
        Me.chkBancoProveedor.Name = "chkBancoProveedor"
        Me.chkBancoProveedor.Size = New System.Drawing.Size(130, 20)
        Me.chkBancoProveedor.TabIndex = 7
        Me.chkBancoProveedor.Text = "Banco Proveedor"
        '
        'chkMoneda
        '
        Me.chkMoneda.Location = New System.Drawing.Point(22, 48)
        Me.chkMoneda.Name = "chkMoneda"
        Me.chkMoneda.Size = New System.Drawing.Size(98, 20)
        Me.chkMoneda.TabIndex = 3
        Me.chkMoneda.Text = "Moneda"
        '
        'chkProveedor
        '
        Me.chkProveedor.Enabled = False
        Me.chkProveedor.Location = New System.Drawing.Point(22, 9)
        Me.chkProveedor.Name = "chkProveedor"
        Me.chkProveedor.Size = New System.Drawing.Size(98, 20)
        Me.chkProveedor.TabIndex = 1
        Me.chkProveedor.Text = "Proveedor"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 93)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(256, 40)
        Me.Panel1.TabIndex = 10
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(38, 6)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(85, 28)
        Me.cmbAceptar.TabIndex = 10
        Me.cmbAceptar.Text = "Aceptar"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Location = New System.Drawing.Point(134, 6)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(85, 28)
        Me.cmbCancelar.TabIndex = 9
        Me.cmbCancelar.Text = "Cancelar"
        '
        'FrmAgrupaPagos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(256, 133)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.chkFechaVto)
        Me.Controls.Add(Me.chkCambioA)
        Me.Controls.Add(Me.chkCambioB)
        Me.Controls.Add(Me.chkFPago)
        Me.Controls.Add(Me.chkBancoProveedor)
        Me.Controls.Add(Me.chkMoneda)
        Me.Controls.Add(Me.chkProveedor)
        Me.Name = "FrmAgrupaPagos"
        Me.Text = "Selección de la agrupación"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Const cntPagosBancoProv As String = "PA_GR_BPRO"
    Public Const cntPagosCambioA As String = "PA_GR_CAMA"
    Public Const cntPagosCambioB As String = "PA_GR_CAMB"
    Public Const cntPagosProveedor As String = "PA_GR_PROV"
    Public Const cntPagosFPago As String = "PA_GR_FP"
    Public Const cntPagosFechaV As String = "PA_GR_FVTO"
    Public Const cntPagosMoneda As String = "PA_GR_MONE"
    Private dtParametro As DataTable
    Private p As Parametro
    Private mblnGrabar As Boolean

    Private Sub CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFechaVto.CheckedChanged, chkCambioA.CheckedChanged, chkCambioB.CheckedChanged, chkFPago.CheckedChanged, chkBancoProveedor.CheckedChanged, chkMoneda.CheckedChanged, chkProveedor.CheckedChanged
        mblnGrabar = True
    End Sub

    Private Sub FrmAgrupaCobros_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        p = New Parametro
        dtParametro = p.ConfiguracionAgrupacionPagos

        For Each dr As DataRow In dtParametro.Rows
            If dr("IdParametro") = cntPagosProveedor Then
                chkProveedor.Checked = dr("Valor")
            ElseIf dr("IdParametro") = cntPagosFechaV Then
                chkFechaVto.Checked = dr("Valor")
            ElseIf dr("IdParametro") = cntPagosMoneda Then
                chkMoneda.Checked = dr("Valor")
            ElseIf dr("IdParametro") = cntPagosCambioA Then
                chkCambioA.Checked = dr("Valor")
            ElseIf dr("IdParametro") = cntPagosCambioB Then
                chkCambioB.Checked = dr("Valor")
            ElseIf dr("IdParametro") = cntPagosFPago Then
                chkFPago.Checked = dr("Valor")
            ElseIf dr("IdParametro") = cntPagosBancoProv Then
                chkBancoProveedor.Checked = dr("Valor")
            End If
        Next

    End Sub

    Private Sub cmbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        If mblnGrabar Then
            For Each dr As DataRow In dtParametro.Rows
                If dr("IdParametro") = cntPagosProveedor Then
                    dr("Valor") = CInt(chkProveedor.Checked)
                ElseIf dr("IdParametro") = cntPagosFechaV Then
                    dr("Valor") = CInt(chkFechaVto.Checked)
                ElseIf dr("IdParametro") = cntPagosMoneda Then
                    dr("Valor") = CInt(chkMoneda.Checked)
                ElseIf dr("IdParametro") = cntPagosCambioA Then
                    dr("Valor") = CInt(chkCambioA.Checked)
                ElseIf dr("IdParametro") = cntPagosCambioB Then
                    dr("Valor") = CInt(chkCambioB.Checked)
                ElseIf dr("IdParametro") = cntPagosFPago Then
                    dr("Valor") = CInt(chkFPago.Checked)
                ElseIf dr("IdParametro") = cntPagosBancoProv Then
                    dr("Valor") = CInt(chkBancoProveedor.Checked)
                End If
            Next

            p.Update(dtParametro)
        End If
        Me.Close()
    End Sub
End Class
