Imports Solmicro.Expertis.Business.Negocio

Public Class frmRemesaPago
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
    Friend WithEvents FraOpciones As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblfwiFechaRemesaPago As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiNRemesa As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents rbtGenerarConfirming As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtGenerarFichero68 As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents cbxBancoPropio As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents txtRemesa As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents cbxFechaRemesa As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents ulDescBancoRemesa As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents rbtGenerarFichero3414 As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents FraFicherosObsoletos As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents rbtGenerarFichero341 As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtGenerarFichero34 As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents CmbTipoFicheroSEPA As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblTipoFicheroTransf As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents chkImprimir As Solmicro.Expertis.Engine.UI.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim cbxBancoPropio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim CmbTipoFicheroSEPA_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRemesaPago))
        Me.FraOpciones = New Solmicro.Expertis.Engine.UI.Frame
        Me.rbtGenerarFichero3414 = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.chkImprimir = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.ulDescBancoRemesa = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.cbxBancoPropio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.rbtGenerarConfirming = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtGenerarFichero68 = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.lblfwiFechaRemesaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaRemesa = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblfwiBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.txtRemesa = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiNRemesa = New Solmicro.Expertis.Engine.UI.Label
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.FraFicherosObsoletos = New Solmicro.Expertis.Engine.UI.Frame
        Me.rbtGenerarFichero341 = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtGenerarFichero34 = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.CmbTipoFicheroSEPA = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblTipoFicheroTransf = New Solmicro.Expertis.Engine.UI.Label
        Me.FraOpciones.SuspendLayout()
        CType(Me.cbxBancoPropio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.suspendlayout()
        Me.FraFicherosObsoletos.SuspendLayout()
        CType(Me.CmbTipoFicheroSEPA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FraOpciones
        '
        Me.FraOpciones.Controls.Add(Me.CmbTipoFicheroSEPA)
        Me.FraOpciones.Controls.Add(Me.lblTipoFicheroTransf)
        Me.FraOpciones.Controls.Add(Me.rbtGenerarFichero3414)
        Me.FraOpciones.Controls.Add(Me.chkImprimir)
        Me.FraOpciones.Controls.Add(Me.ulDescBancoRemesa)
        Me.FraOpciones.Controls.Add(Me.cbxBancoPropio)
        Me.FraOpciones.Controls.Add(Me.rbtGenerarConfirming)
        Me.FraOpciones.Controls.Add(Me.rbtGenerarFichero68)
        Me.FraOpciones.Controls.Add(Me.lblfwiFechaRemesaPago)
        Me.FraOpciones.Controls.Add(Me.cbxFechaRemesa)
        Me.FraOpciones.Controls.Add(Me.lblfwiBancoPropio)
        Me.FraOpciones.Location = New System.Drawing.Point(4, 35)
        Me.FraOpciones.Name = "FraOpciones"
        Me.FraOpciones.Size = New System.Drawing.Size(348, 181)
        Me.FraOpciones.TabIndex = 7
        Me.FraOpciones.TabStop = False
        Me.FraOpciones.Text = "Opciones"
        '
        'rbtGenerarFichero3414
        '
        Me.rbtGenerarFichero3414.Location = New System.Drawing.Point(7, 51)
        Me.rbtGenerarFichero3414.Name = "rbtGenerarFichero3414"
        Me.rbtGenerarFichero3414.Size = New System.Drawing.Size(288, 16)
        Me.rbtGenerarFichero3414.TabIndex = 55
        Me.rbtGenerarFichero3414.Text = "Generar Fichero C.S.B. norma 34.14"
        '
        'chkImprimir
        '
        Me.chkImprimir.Location = New System.Drawing.Point(7, 155)
        Me.chkImprimir.Name = "chkImprimir"
        Me.chkImprimir.Size = New System.Drawing.Size(84, 21)
        Me.chkImprimir.TabIndex = 54
        Me.chkImprimir.Text = "Imprimir"
        Me.chkImprimir.Visible = False
        '
        'ulDescBancoRemesa
        '
        Me.TryDataBinding(ulDescBancoRemesa, New System.Windows.Forms.Binding("Text", Me.cbxBancoPropio, "DescBancoPropio", True))
        Me.ulDescBancoRemesa.Location = New System.Drawing.Point(176, 127)
        Me.ulDescBancoRemesa.Name = "ulDescBancoRemesa"
        Me.ulDescBancoRemesa.Size = New System.Drawing.Size(164, 21)
        Me.ulDescBancoRemesa.TabIndex = 53
        '
        'cbxBancoPropio
        '
        cbxBancoPropio_DesignTimeLayout.LayoutString = resources.GetString("cbxBancoPropio_DesignTimeLayout.LayoutString")
        Me.cbxBancoPropio.DesignTimeLayout = cbxBancoPropio_DesignTimeLayout
        Me.cbxBancoPropio.DisabledBackColor = System.Drawing.Color.White
        Me.cbxBancoPropio.DisplayMember = "IDBancoPropio"
        Me.cbxBancoPropio.EntityName = "BancoPropio"
        Me.cbxBancoPropio.Location = New System.Drawing.Point(100, 127)
        Me.cbxBancoPropio.Name = "cbxBancoPropio"
        Me.cbxBancoPropio.PrimaryDataFields = "IDBancoPropio"
        Me.cbxBancoPropio.SecondaryDataFields = "IDBancoPropio"
        Me.cbxBancoPropio.SelectedIndex = -1
        Me.cbxBancoPropio.SelectedItem = Nothing
        Me.cbxBancoPropio.Size = New System.Drawing.Size(72, 21)
        Me.cbxBancoPropio.TabIndex = 52
        Me.cbxBancoPropio.ValueMember = "IDBancoPropio"
        Me.cbxBancoPropio.ViewName = "tbMaestroBancoPropio"
        '
        'rbtGenerarConfirming
        '
        Me.rbtGenerarConfirming.Location = New System.Drawing.Point(7, 99)
        Me.rbtGenerarConfirming.Name = "rbtGenerarConfirming"
        Me.rbtGenerarConfirming.Size = New System.Drawing.Size(288, 16)
        Me.rbtGenerarConfirming.TabIndex = 46
        Me.rbtGenerarConfirming.Text = "Generar Confirming"
        '
        'rbtGenerarFichero68
        '
        Me.rbtGenerarFichero68.Location = New System.Drawing.Point(7, 75)
        Me.rbtGenerarFichero68.Name = "rbtGenerarFichero68"
        Me.rbtGenerarFichero68.Size = New System.Drawing.Size(288, 16)
        Me.rbtGenerarFichero68.TabIndex = 45
        Me.rbtGenerarFichero68.Text = "Generar Fichero C.S.B. norma 68"
        '
        'lblfwiFechaRemesaPago
        '
        Me.lblfwiFechaRemesaPago.Location = New System.Drawing.Point(4, 24)
        Me.lblfwiFechaRemesaPago.Name = "lblfwiFechaRemesaPago"
        Me.lblfwiFechaRemesaPago.Size = New System.Drawing.Size(40, 13)
        Me.lblfwiFechaRemesaPago.TabIndex = 10
        Me.lblfwiFechaRemesaPago.Text = "Fecha"
        '
        'cbxFechaRemesa
        '
        Me.TryDataBinding(cbxFechaRemesa, New System.Windows.Forms.Binding("BindableValue", Me, "FechaRemesa", True))
        Me.cbxFechaRemesa.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaRemesa.Location = New System.Drawing.Point(54, 24)
        Me.cbxFechaRemesa.Name = "cbxFechaRemesa"
        Me.cbxFechaRemesa.Size = New System.Drawing.Size(104, 21)
        Me.cbxFechaRemesa.TabIndex = 0
        '
        'lblfwiBancoPropio
        '
        Me.lblfwiBancoPropio.Location = New System.Drawing.Point(7, 131)
        Me.lblfwiBancoPropio.Name = "lblfwiBancoPropio"
        Me.lblfwiBancoPropio.Size = New System.Drawing.Size(92, 13)
        Me.lblfwiBancoPropio.TabIndex = 11
        Me.lblfwiBancoPropio.Tag = "IdRec=6588;"
        Me.lblfwiBancoPropio.Text = "Banco Remesa"
        '
        'txtRemesa
        '
        Me.TryDataBinding(txtRemesa, New System.Windows.Forms.Binding("Text", Me, "IDRemesa", True))
        Me.txtRemesa.DisabledBackColor = System.Drawing.Color.White
        Me.txtRemesa.Enabled = False
        Me.txtRemesa.Location = New System.Drawing.Point(140, 8)
        Me.txtRemesa.Name = "txtRemesa"
        Me.txtRemesa.Size = New System.Drawing.Size(93, 21)
        Me.txtRemesa.TabIndex = 6
        Me.txtRemesa.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblfwiNRemesa
        '
        Me.lblfwiNRemesa.Location = New System.Drawing.Point(60, 8)
        Me.lblfwiNRemesa.Name = "lblfwiNRemesa"
        Me.lblfwiNRemesa.Size = New System.Drawing.Size(76, 13)
        Me.lblfwiNRemesa.TabIndex = 8
        Me.lblfwiNRemesa.Tag = "IdRec=4792;"
        Me.lblfwiNRemesa.Text = "Nº Remesa:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 300)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(354, 48)
        Me.Panel1.TabIndex = 9
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(184, 7)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(89, 30)
        Me.cmbCancelar.TabIndex = 13
        Me.cmbCancelar.Text = "Cancelar"
        '
        'cmbAceptar
        '
        Me.cmbAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmbAceptar.Location = New System.Drawing.Point(81, 7)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(89, 30)
        Me.cmbAceptar.TabIndex = 12
        Me.cmbAceptar.Text = "Aceptar"
        '
        'FraFicherosObsoletos
        '
        Me.FraFicherosObsoletos.Controls.Add(Me.rbtGenerarFichero341)
        Me.FraFicherosObsoletos.Controls.Add(Me.rbtGenerarFichero34)
        Me.FraFicherosObsoletos.Location = New System.Drawing.Point(4, 218)
        Me.FraFicherosObsoletos.Name = "FraFicherosObsoletos"
        Me.FraFicherosObsoletos.Size = New System.Drawing.Size(348, 77)
        Me.FraFicherosObsoletos.TabIndex = 11
        Me.FraFicherosObsoletos.TabStop = False
        '
        'rbtGenerarFichero341
        '
        Me.rbtGenerarFichero341.Location = New System.Drawing.Point(7, 41)
        Me.rbtGenerarFichero341.Name = "rbtGenerarFichero341"
        Me.rbtGenerarFichero341.Size = New System.Drawing.Size(288, 21)
        Me.rbtGenerarFichero341.TabIndex = 46
        Me.rbtGenerarFichero341.Text = "Generar Fichero C.S.B. norma 34.1"
        '
        'rbtGenerarFichero34
        '
        Me.rbtGenerarFichero34.Location = New System.Drawing.Point(7, 17)
        Me.rbtGenerarFichero34.Name = "rbtGenerarFichero34"
        Me.rbtGenerarFichero34.Size = New System.Drawing.Size(288, 21)
        Me.rbtGenerarFichero34.TabIndex = 45
        Me.rbtGenerarFichero34.Text = "Generar Fichero C.S.B. norma 34"
        '
        'CmbTipoFicheroSEPA
        '
        CmbTipoFicheroSEPA_DesignTimeLayout.LayoutString = resources.GetString("CmbTipoFicheroSEPA_DesignTimeLayout.LayoutString")
        Me.CmbTipoFicheroSEPA.DesignTimeLayout = CmbTipoFicheroSEPA_DesignTimeLayout
        Me.CmbTipoFicheroSEPA.DisabledBackColor = System.Drawing.Color.White
        Me.CmbTipoFicheroSEPA.Location = New System.Drawing.Point(242, 49)
        Me.CmbTipoFicheroSEPA.Name = "CmbTipoFicheroSEPA"
        Me.CmbTipoFicheroSEPA.SelectedIndex = -1
        Me.CmbTipoFicheroSEPA.SelectedItem = Nothing
        Me.CmbTipoFicheroSEPA.Size = New System.Drawing.Size(100, 21)
        Me.CmbTipoFicheroSEPA.TabIndex = 56
        '
        'lblTipoFicheroTransf
        '
        Me.lblTipoFicheroTransf.Location = New System.Drawing.Point(239, 32)
        Me.lblTipoFicheroTransf.Name = "lblTipoFicheroTransf"
        Me.lblTipoFicheroTransf.Size = New System.Drawing.Size(76, 13)
        Me.lblTipoFicheroTransf.TabIndex = 57
        Me.lblTipoFicheroTransf.Tag = ""
        Me.lblTipoFicheroTransf.Text = "Tipo Fichero"
        '
        'frmRemesaPago
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(354, 348)
        Me.Controls.Add(Me.FraFicherosObsoletos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FraOpciones)
        Me.Controls.Add(Me.lblfwiNRemesa)
        Me.Controls.Add(Me.txtRemesa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRemesaPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos para la Remesa"
        Me.FraOpciones.ResumeLayout(False)
        Me.FraOpciones.PerformLayout()
        CType(Me.cbxBancoPropio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.FraFicherosObsoletos.ResumeLayout(False)
        CType(Me.CmbTipoFicheroSEPA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private mintIdRemesa As Integer
    Protected mdtPagos As DataTable
    Public mstrRuta As String
    Private mblnUpdate, mblnCancel As Boolean

    Public ReadOnly Property IDRemesa() As Integer
        Get
            Return Nz(Me.txtRemesa.Text, -1)
        End Get
    End Property

    Public ReadOnly Property IDBancoPropio() As String
        Get
            Return Me.cbxBancoPropio.Value & String.Empty
        End Get
    End Property

    Public Function AbrirRemesa(ByVal OwnerForm As FormBase, Optional ByVal intIdRemesa As Integer = -1) As DialogResult
        Me.EntityName = "RemesaPago"
        Me.ViewName = "tbRemesaPago"

        cbxFechaRemesa.Value = Date.Today
        If intIdRemesa > 0 Then
            mintIdRemesa = intIdRemesa
            mblnUpdate = True
            Dim f As New Filter
            f.Add(New NumberFilterItem("IDRemesa", intIdRemesa))
            Me.FilterCriteria = f
            mdtPagos = New BE.DataEngine().Filter("frmPagos", f)
        End If

        Me.ShowDialog(OwnerForm)

        Return Me.DialogResult
    End Function

    Private Sub frmRemesaPago_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then

            If mblnUpdate Then
                txtRemesa.Text = mintIdRemesa
            Else
                Me.AddNew()
            End If
            LoadEnums()
        End If
    End Sub

    Protected Overridable Sub LoadEnums()
        CmbTipoFicheroSEPA.DataSource = New EnumData("enumFormatoFicheroSEPA")
        CmbTipoFicheroSEPA.Value = enumFormatoFicheroSEPA.XML
    End Sub

#Region " Aceptar/Cancelar "

    Private Function ValidarOpciones() As Boolean
        Dim blnCancel As Boolean
        If length(cbxFechaRemesa.Value) = 0 Then
            blnCancel = True
            ExpertisApp.GenerateMessage("Debe introducir una fecha para la remesa.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf (rbtGenerarConfirming.Checked Or rbtGenerarFichero34.Checked Or rbtGenerarFichero341.Checked Or rbtGenerarFichero68.Checked) And Len(cbxBancoPropio.Value) = 0 Then
            blnCancel = True
            ExpertisApp.GenerateMessage("El Banco Propio es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf (rbtGenerarConfirming.Checked Or rbtGenerarFichero34.Checked Or rbtGenerarFichero341.Checked Or rbtGenerarFichero68.Checked) And Len(cbxBancoPropio.Value) > 0 Then
            Dim bp As New BancoPropio
            Dim dtBancoPropio As DataTable = bp.SelOnPrimaryKey(cbxBancoPropio.Value)
            If Not IsNothing(dtBancoPropio) AndAlso dtBancoPropio.Rows.Count > 0 Then
                If Not dtBancoPropio.Rows(0)("Confirming") AndAlso rbtGenerarConfirming.Checked Then
                    blnCancel = True
                    ExpertisApp.GenerateMessage("Este banco  no admite Confirming", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                blnCancel = True
                ExpertisApp.GenerateMessage("El Banco Propio no existe.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        Return blnCancel
    End Function

    Private Sub cmbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        If Not ValidarOpciones() Then
            Me.DialogResult = DialogResult.OK
            mblnCancel = False

            Dim intTipoFichero As Integer = -1

            If rbtGenerarFichero34.Checked Then
                intTipoFichero = enumFichRemesaPago.CSB34
            ElseIf rbtGenerarFichero341.Checked Then
                intTipoFichero = enumFichRemesaPago.CSB341
            ElseIf rbtGenerarFichero3414.Checked Then
                intTipoFichero = Business.SEPA.BusinessEnum.enumFichRemesaPago.CSB3414
            ElseIf rbtGenerarFichero68.Checked Then
                intTipoFichero = enumFichRemesaPago.CSB68
            ElseIf rbtGenerarConfirming.Checked Then
                intTipoFichero = enumFichRemesaPago.Confirming
            End If

            If intTipoFichero <> -1 Then GenerarFicheroTransferencia(intTipoFichero, cbxBancoPropio.Value, mstrRuta, cbxFechaRemesa.Value, Nz(Me.CmbTipoFicheroSEPA.Value, enumFormatoFicheroSEPA.XML))

            Me.CurrentData.Rows(0)("FechaRemesa") = cbxFechaRemesa.Value
            Me.CurrentData.Rows(0)("TipoFichero") = intTipoFichero
            Me.CurrentData.Rows(0)("Ruta") = mstrRuta

            Me.UpdateData()
            CambioBancoPropio()
            If chkImprimir.Checked Then
                'Dim oRpt As New Report("REMDEFPA")
                'oRpt.Filter.Add(New NumberFilterItem("IDRemesa", txtRemesa.Text))
            End If
        Else
            mblnCancel = True
        End If

    End Sub

    Private Sub CambioBancoPropio()
        If Length(cbxBancoPropio.Value) > 0 AndAlso Length(Me.txtRemesa.Text) > 0 Then
            Dim datosCambio As New Pago.DataCambioBancoPropio
            datosCambio.IDRemesa = Me.txtRemesa.Text
            datosCambio.NuevoBancoPropio = cbxBancoPropio.Value
            ExpertisApp.ExecuteTask(Of Pago.DataCambioBancoPropio)(AddressOf Pago.CambioBancoPropio, datosCambio)
        End If
    End Sub

    Private Sub cmbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
#End Region

#Region "Opciones Generar Fichero "
    Private Sub rbtGenerarFichero34_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtGenerarFichero34.CheckedChanged
        If rbtGenerarFichero34.Checked Then
            'If PagosImporteNegativo(MDtPagos) Then
            '    sender.Checked = False
            '    Exit Sub
            'End If
            SaveFileDialog1.Filter = String.Empty
            SaveFileDialog1.ShowDialog()
            mstrRuta = SaveFileDialog1.FileName
            If Length(mstrRuta) = 0 Then rbtGenerarFichero34.Checked = 0
            cmbAceptar.Enabled = True
        Else
            mstrRuta = String.Empty
        End If
    End Sub

    Private Sub rbtGenerarFichero341_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtGenerarFichero341.CheckedChanged
        If rbtGenerarFichero341.Checked Then
            'If PagosImporteNegativo(MDtPagos) Then
            '    sender.Checked = False
            '    Exit Sub
            'End If
            SaveFileDialog1.Filter = String.Empty
            SaveFileDialog1.ShowDialog()
            mstrRuta = SaveFileDialog1.FileName
            If Length(mstrRuta) = 0 Then rbtGenerarFichero341.Checked = False
            cmbAceptar.Enabled = True
        Else
            mstrRuta = String.Empty
        End If
    End Sub

    Private Sub rbtGenerarFichero3414_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtGenerarFichero3414.CheckedChanged
        If rbtGenerarFichero3414.Checked Then
            'If PagosImporteNegativo(MDtPagos) Then
            '    sender.Checked = False
            '    Exit Sub
            'End If
            Dim cnEXT_FICHERO As String
            If Me.CmbTipoFicheroSEPA.Value = enumFormatoFicheroSEPA.XML Then
                cnEXT_FICHERO = ".xml"
                SaveFileDialog1.Filter = "Fichero XML |*" & cnEXT_FICHERO & ""
            Else
                cnEXT_FICHERO = ".txt"
                SaveFileDialog1.Filter = "Fichero TXT |*" & cnEXT_FICHERO & ""
            End If
            SaveFileDialog1.ShowDialog()
            mstrRuta = SaveFileDialog1.FileName
            If Length(mstrRuta) = 0 Then rbtGenerarFichero3414.Checked = False
            cmbAceptar.Enabled = True
        Else
            mstrRuta = String.Empty
        End If
    End Sub

    Private Sub rbtGenerarFichero68_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtGenerarFichero68.CheckedChanged
        If rbtGenerarFichero68.Checked Then
            'If PagosImporteNegativo(MDtPagos) Then
            '    sender.Checked = False
            '    Exit Sub
            'End If
            SaveFileDialog1.Filter = String.Empty
            SaveFileDialog1.ShowDialog()
            mstrRuta = SaveFileDialog1.FileName
            If Length(mstrRuta) = 0 Then rbtGenerarFichero68.Checked = 0
            cmbAceptar.Enabled = True
        Else
            mstrRuta = String.Empty
        End If
    End Sub

    Private Sub rbtGenerarConfirming_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtGenerarConfirming.CheckedChanged
        If rbtGenerarConfirming.Checked Then
            'If PagosImporteNegativo(MDtPagos) Then
            '    sender.Checked = False
            '    Exit Sub
            'End If
            SaveFileDialog1.Filter = String.Empty
            SaveFileDialog1.ShowDialog()
            mstrRuta = SaveFileDialog1.FileName
            If Length(mstrRuta) = 0 Then rbtGenerarConfirming.Checked = 0
            cmbAceptar.Enabled = True
        Else
            mstrRuta = String.Empty
        End If
    End Sub
#End Region

    Private Sub frmRemesaPago_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = mblnCancel
    End Sub

End Class
