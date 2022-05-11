Imports Solmicro.Expertis.Business.General
Imports Solmicro.Expertis.Business.Negocio

Public Class frmContabilizarRemesa
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
    Friend WithEvents lblBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulDescBancoPropio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents cbxBancoPropio As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents FrmDatos As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblSituacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulDescEstado As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents cbxSituacion As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents FrmFicheros As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents FrmDocumentos As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents rbtGenerarConfirming As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtGenerarFichero341 As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtGenerarFichero34 As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtGenerarFichero68 As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents lblTipoApunte As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents chkImprimir As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents cbxTipoInforme As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents chkGeneraRemesa As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents rbtGenerarFichero3414 As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents FraFicherosObsoletos As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents CmbTipoFicheroSEPA As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblTipoFicheroTransf As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim cbxSituacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContabilizarRemesa))
        Dim cbxBancoPropio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxTipoInforme_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim CmbTipoFicheroSEPA_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.FrmDatos = New Solmicro.Expertis.Engine.UI.Frame
        Me.chkGeneraRemesa = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblSituacion = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescEstado = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.cbxSituacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescBancoPropio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.cbxBancoPropio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.FrmFicheros = New Solmicro.Expertis.Engine.UI.Frame
        Me.rbtGenerarFichero3414 = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtGenerarConfirming = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtGenerarFichero68 = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtGenerarFichero341 = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtGenerarFichero34 = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.FrmDocumentos = New Solmicro.Expertis.Engine.UI.Frame
        Me.chkImprimir = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.cbxTipoInforme = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblTipoApunte = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.FraFicherosObsoletos = New Solmicro.Expertis.Engine.UI.Frame
        Me.CmbTipoFicheroSEPA = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblTipoFicheroTransf = New Solmicro.Expertis.Engine.UI.Label
        Me.FrmDatos.SuspendLayout()
        CType(Me.cbxSituacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxBancoPropio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrmFicheros.SuspendLayout()
        Me.FrmDocumentos.SuspendLayout()
        CType(Me.cbxTipoInforme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.suspendlayout()
        Me.FraFicherosObsoletos.SuspendLayout()
        CType(Me.CmbTipoFicheroSEPA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FrmDatos
        '
        Me.FrmDatos.Controls.Add(Me.chkGeneraRemesa)
        Me.FrmDatos.Controls.Add(Me.lblSituacion)
        Me.FrmDatos.Controls.Add(Me.ulDescEstado)
        Me.FrmDatos.Controls.Add(Me.cbxSituacion)
        Me.FrmDatos.Controls.Add(Me.lblBancoPropio)
        Me.FrmDatos.Controls.Add(Me.ulDescBancoPropio)
        Me.FrmDatos.Controls.Add(Me.cbxBancoPropio)
        Me.FrmDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.FrmDatos.Location = New System.Drawing.Point(0, 0)
        Me.FrmDatos.Name = "FrmDatos"
        Me.FrmDatos.Size = New System.Drawing.Size(441, 112)
        Me.FrmDatos.TabIndex = 0
        Me.FrmDatos.TabStop = False
        Me.FrmDatos.Text = "Datos"
        '
        'chkGeneraRemesa
        '
        Me.chkGeneraRemesa.Checked = True
        Me.chkGeneraRemesa.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGeneraRemesa.Location = New System.Drawing.Point(14, 80)
        Me.chkGeneraRemesa.Name = "chkGeneraRemesa"
        Me.chkGeneraRemesa.Size = New System.Drawing.Size(181, 21)
        Me.chkGeneraRemesa.TabIndex = 3
        Me.chkGeneraRemesa.Text = "Generar Remesa"
        '
        'lblSituacion
        '
        Me.lblSituacion.Location = New System.Drawing.Point(14, 48)
        Me.lblSituacion.Name = "lblSituacion"
        Me.lblSituacion.Size = New System.Drawing.Size(79, 13)
        Me.lblSituacion.TabIndex = 54
        Me.lblSituacion.Tag = "IdRec=4742;"
        Me.lblSituacion.Text = "Cambiar a..."
        '
        'ulDescEstado
        '
        Me.TryDataBinding(ulDescEstado, New System.Windows.Forms.Binding("Text", Me.cbxSituacion, "DescEstado", True))
        Me.ulDescEstado.Location = New System.Drawing.Point(206, 48)
        Me.ulDescEstado.Name = "ulDescEstado"
        Me.ulDescEstado.Size = New System.Drawing.Size(224, 21)
        Me.ulDescEstado.TabIndex = 55
        '
        'cbxSituacion
        '
        cbxSituacion_DesignTimeLayout.LayoutString = resources.GetString("cbxSituacion_DesignTimeLayout.LayoutString")
        Me.cbxSituacion.DesignTimeLayout = cbxSituacion_DesignTimeLayout
        Me.cbxSituacion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxSituacion.DisplayMember = "IDEstado"
        Me.cbxSituacion.EntityName = "EstadoPago"
        Me.cbxSituacion.Location = New System.Drawing.Point(102, 48)
        Me.cbxSituacion.Name = "cbxSituacion"
        Me.cbxSituacion.PrimaryDataFields = "IDEstado"
        Me.cbxSituacion.SecondaryDataFields = "IDEstado"
        Me.cbxSituacion.SelectedIndex = -1
        Me.cbxSituacion.SelectedItem = Nothing
        Me.cbxSituacion.Size = New System.Drawing.Size(104, 21)
        Me.cbxSituacion.TabIndex = 2
        Me.cbxSituacion.ValueMember = "IDEstado"
        Me.cbxSituacion.ViewName = "tbMaestroEstadoPago"
        '
        'lblBancoPropio
        '
        Me.lblBancoPropio.Location = New System.Drawing.Point(14, 24)
        Me.lblBancoPropio.Name = "lblBancoPropio"
        Me.lblBancoPropio.Size = New System.Drawing.Size(82, 13)
        Me.lblBancoPropio.TabIndex = 51
        Me.lblBancoPropio.Tag = "IdRec=4613;"
        Me.lblBancoPropio.Text = "Banco Propio"
        '
        'ulDescBancoPropio
        '
        Me.TryDataBinding(ulDescBancoPropio, New System.Windows.Forms.Binding("Text", Me.cbxBancoPropio, "DescBancoPropio", True))
        Me.ulDescBancoPropio.Location = New System.Drawing.Point(206, 24)
        Me.ulDescBancoPropio.Name = "ulDescBancoPropio"
        Me.ulDescBancoPropio.Size = New System.Drawing.Size(224, 21)
        Me.ulDescBancoPropio.TabIndex = 52
        '
        'cbxBancoPropio
        '
        cbxBancoPropio_DesignTimeLayout.LayoutString = resources.GetString("cbxBancoPropio_DesignTimeLayout.LayoutString")
        Me.cbxBancoPropio.DesignTimeLayout = cbxBancoPropio_DesignTimeLayout
        Me.cbxBancoPropio.DisabledBackColor = System.Drawing.Color.White
        Me.cbxBancoPropio.DisplayMember = "IDBancoPropio"
        Me.cbxBancoPropio.EntityName = "BancoPropio"
        Me.cbxBancoPropio.Location = New System.Drawing.Point(102, 24)
        Me.cbxBancoPropio.Name = "cbxBancoPropio"
        Me.cbxBancoPropio.PrimaryDataFields = "IDBancoPropio"
        Me.cbxBancoPropio.SecondaryDataFields = "IDBancoPropio"
        Me.cbxBancoPropio.SelectedIndex = -1
        Me.cbxBancoPropio.SelectedItem = Nothing
        Me.cbxBancoPropio.Size = New System.Drawing.Size(104, 21)
        Me.cbxBancoPropio.TabIndex = 1
        Me.cbxBancoPropio.ValueMember = "IDBancoPropio"
        Me.cbxBancoPropio.ViewName = "tbMaestroBancoPropio"
        '
        'FrmFicheros
        '
        Me.FrmFicheros.Controls.Add(Me.CmbTipoFicheroSEPA)
        Me.FrmFicheros.Controls.Add(Me.lblTipoFicheroTransf)
        Me.FrmFicheros.Controls.Add(Me.rbtGenerarFichero3414)
        Me.FrmFicheros.Controls.Add(Me.rbtGenerarConfirming)
        Me.FrmFicheros.Controls.Add(Me.rbtGenerarFichero68)
        Me.FrmFicheros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmFicheros.Location = New System.Drawing.Point(0, 112)
        Me.FrmFicheros.Name = "FrmFicheros"
        Me.FrmFicheros.Size = New System.Drawing.Size(441, 105)
        Me.FrmFicheros.TabIndex = 4
        Me.FrmFicheros.TabStop = False
        Me.FrmFicheros.Text = "Ficheros"
        '
        'rbtGenerarFichero3414
        '
        Me.rbtGenerarFichero3414.Location = New System.Drawing.Point(18, 28)
        Me.rbtGenerarFichero3414.Name = "rbtGenerarFichero3414"
        Me.rbtGenerarFichero3414.Size = New System.Drawing.Size(227, 16)
        Me.rbtGenerarFichero3414.TabIndex = 9
        Me.rbtGenerarFichero3414.Text = "Generar Fichero C.S.B. norma 34.14"
        '
        'rbtGenerarConfirming
        '
        Me.rbtGenerarConfirming.Location = New System.Drawing.Point(18, 77)
        Me.rbtGenerarConfirming.Name = "rbtGenerarConfirming"
        Me.rbtGenerarConfirming.Size = New System.Drawing.Size(288, 16)
        Me.rbtGenerarConfirming.TabIndex = 8
        Me.rbtGenerarConfirming.Text = "Generar Confirming"
        '
        'rbtGenerarFichero68
        '
        Me.rbtGenerarFichero68.Location = New System.Drawing.Point(18, 53)
        Me.rbtGenerarFichero68.Name = "rbtGenerarFichero68"
        Me.rbtGenerarFichero68.Size = New System.Drawing.Size(288, 16)
        Me.rbtGenerarFichero68.TabIndex = 7
        Me.rbtGenerarFichero68.Text = "Generar Fichero C.S.B. norma 68"
        '
        'rbtGenerarFichero341
        '
        Me.rbtGenerarFichero341.Location = New System.Drawing.Point(18, 44)
        Me.rbtGenerarFichero341.Name = "rbtGenerarFichero341"
        Me.rbtGenerarFichero341.Size = New System.Drawing.Size(288, 16)
        Me.rbtGenerarFichero341.TabIndex = 6
        Me.rbtGenerarFichero341.Text = "Generar Fichero C.S.B. norma 34.1"
        '
        'rbtGenerarFichero34
        '
        Me.rbtGenerarFichero34.Location = New System.Drawing.Point(18, 20)
        Me.rbtGenerarFichero34.Name = "rbtGenerarFichero34"
        Me.rbtGenerarFichero34.Size = New System.Drawing.Size(288, 16)
        Me.rbtGenerarFichero34.TabIndex = 5
        Me.rbtGenerarFichero34.Text = "Generar Fichero C.S.B. norma 34"
        '
        'FrmDocumentos
        '
        Me.FrmDocumentos.Controls.Add(Me.chkImprimir)
        Me.FrmDocumentos.Controls.Add(Me.cbxTipoInforme)
        Me.FrmDocumentos.Controls.Add(Me.lblTipoApunte)
        Me.FrmDocumentos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FrmDocumentos.Location = New System.Drawing.Point(0, 217)
        Me.FrmDocumentos.Name = "FrmDocumentos"
        Me.FrmDocumentos.Size = New System.Drawing.Size(441, 56)
        Me.FrmDocumentos.TabIndex = 9
        Me.FrmDocumentos.TabStop = False
        Me.FrmDocumentos.Text = "Documentos"
        '
        'chkImprimir
        '
        Me.chkImprimir.Location = New System.Drawing.Point(19, 24)
        Me.chkImprimir.Name = "chkImprimir"
        Me.chkImprimir.Size = New System.Drawing.Size(84, 21)
        Me.chkImprimir.TabIndex = 10
        Me.chkImprimir.Text = "Imprimir"
        '
        'cbxTipoInforme
        '
        cbxTipoInforme_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoInforme_DesignTimeLayout.LayoutString")
        Me.cbxTipoInforme.DesignTimeLayout = cbxTipoInforme_DesignTimeLayout
        Me.cbxTipoInforme.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoInforme.Enabled = False
        Me.cbxTipoInforme.Location = New System.Drawing.Point(208, 24)
        Me.cbxTipoInforme.Name = "cbxTipoInforme"
        Me.cbxTipoInforme.SelectedIndex = -1
        Me.cbxTipoInforme.SelectedItem = Nothing
        Me.cbxTipoInforme.Size = New System.Drawing.Size(131, 21)
        Me.cbxTipoInforme.TabIndex = 11
        '
        'lblTipoApunte
        '
        Me.lblTipoApunte.Location = New System.Drawing.Point(128, 24)
        Me.lblTipoApunte.Name = "lblTipoApunte"
        Me.lblTipoApunte.Size = New System.Drawing.Size(81, 13)
        Me.lblTipoApunte.TabIndex = 47
        Me.lblTipoApunte.Tag = ""
        Me.lblTipoApunte.Text = "Tipo Informe"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 346)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(441, 40)
        Me.Panel1.TabIndex = 12
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(125, 8)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(89, 25)
        Me.cmbAceptar.TabIndex = 13
        Me.cmbAceptar.Text = "Aceptar"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Location = New System.Drawing.Point(221, 8)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(89, 25)
        Me.cmbCancelar.TabIndex = 14
        Me.cmbCancelar.Text = "Cancelar"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.RestoreDirectory = True
        '
        'FraFicherosObsoletos
        '
        Me.FraFicherosObsoletos.Controls.Add(Me.rbtGenerarFichero34)
        Me.FraFicherosObsoletos.Controls.Add(Me.rbtGenerarFichero341)
        Me.FraFicherosObsoletos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraFicherosObsoletos.Location = New System.Drawing.Point(0, 273)
        Me.FraFicherosObsoletos.Name = "FraFicherosObsoletos"
        Me.FraFicherosObsoletos.Size = New System.Drawing.Size(441, 73)
        Me.FraFicherosObsoletos.TabIndex = 13
        Me.FraFicherosObsoletos.TabStop = False
        '
        'CmbTipoFicheroSEPA
        '
        CmbTipoFicheroSEPA_DesignTimeLayout.LayoutString = resources.GetString("CmbTipoFicheroSEPA_DesignTimeLayout.LayoutString")
        Me.CmbTipoFicheroSEPA.DesignTimeLayout = CmbTipoFicheroSEPA_DesignTimeLayout
        Me.CmbTipoFicheroSEPA.DisabledBackColor = System.Drawing.Color.White
        Me.CmbTipoFicheroSEPA.Location = New System.Drawing.Point(336, 26)
        Me.CmbTipoFicheroSEPA.Name = "CmbTipoFicheroSEPA"
        Me.CmbTipoFicheroSEPA.SelectedIndex = -1
        Me.CmbTipoFicheroSEPA.SelectedItem = Nothing
        Me.CmbTipoFicheroSEPA.Size = New System.Drawing.Size(100, 21)
        Me.CmbTipoFicheroSEPA.TabIndex = 47
        '
        'lblTipoFicheroTransf
        '
        Me.lblTipoFicheroTransf.Location = New System.Drawing.Point(257, 30)
        Me.lblTipoFicheroTransf.Name = "lblTipoFicheroTransf"
        Me.lblTipoFicheroTransf.Size = New System.Drawing.Size(76, 13)
        Me.lblTipoFicheroTransf.TabIndex = 48
        Me.lblTipoFicheroTransf.Tag = ""
        Me.lblTipoFicheroTransf.Text = "Tipo Fichero"
        '
        'frmContabilizarRemesa
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(441, 386)
        Me.Controls.Add(Me.FrmFicheros)
        Me.Controls.Add(Me.FrmDocumentos)
        Me.Controls.Add(Me.FraFicherosObsoletos)
        Me.Controls.Add(Me.FrmDatos)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmContabilizarRemesa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remesas / Ficheros / Documentos"
        Me.FrmDatos.ResumeLayout(False)
        Me.FrmDatos.PerformLayout()
        CType(Me.cbxSituacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxBancoPropio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrmFicheros.ResumeLayout(False)
        Me.FrmFicheros.PerformLayout()
        Me.FrmDocumentos.ResumeLayout(False)
        Me.FrmDocumentos.PerformLayout()
        CType(Me.cbxTipoInforme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.FraFicherosObsoletos.ResumeLayout(False)
        CType(Me.CmbTipoFicheroSEPA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Variables Privadas"

    Private MDtPagos As DataTable
    Private MStrRuta, MStrIdBPropio As String
    Private MBlnEspecial As Boolean
    Private MIntTipoFichero As Integer = -1

#End Region

#Region "Funciones Privadas"

    Public Function AbrirContabilizacion(ByVal StrIdBPropio As String, _
                                         ByVal DtPagos As DataTable, _
                                         ByVal BlnEspecial As Boolean) As DialogResult
        MDtPagos = DtPagos
        MStrIdBPropio = StrIdBPropio
        MBlnEspecial = BlnEspecial
        cbxSituacion.Value = CInt(enumPagoSituacion.Pagado)
        Return Me.ShowDialog()
    End Function

    Private Function ValidarOpciones() As Boolean

        If chkImprimir.Checked And Length(cbxTipoInforme.Value) = 0 Then
            If ExpertisApp.GenerateMessage("Debe introducir un tipo de Informe. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.OK Then
                Return True
            End If
        End If
        Return False
    End Function

    Private Sub GenerarFichero()
        If rbtGenerarFichero34.Checked Then
            MIntTipoFichero = enumFichRemesaPago.CSB34
        ElseIf rbtGenerarFichero341.Checked Then
            MIntTipoFichero = enumFichRemesaPago.CSB341
        ElseIf rbtGenerarFichero3414.Checked Then
            MIntTipoFichero = Business.SEPA.BusinessEnum.enumFichRemesaPago.CSB3414
            Dim TipoFichero As enumFormatoFicheroSEPA = Me.CmbTipoFicheroSEPA.Value
            GenerarFicheroTransferencia(MIntTipoFichero, cbxBancoPropio.Value & String.Empty, MStrRuta, Date.Today, TipoFichero)
            Exit Sub
        ElseIf rbtGenerarFichero68.Checked Then
            MIntTipoFichero = enumFichRemesaPago.CSB68
        ElseIf rbtGenerarConfirming.Checked Then
            MIntTipoFichero = enumFichRemesaPago.Confirming
        End If
        If MIntTipoFichero <> -1 Then GenerarFicheroTransferencia(MIntTipoFichero, cbxBancoPropio.Value & String.Empty, MStrRuta)
    End Sub

    Private Sub GenerarRemesa()
        If chkGeneraRemesa.Checked Then GeneraRemesa()
    End Sub

    Private Sub GeneraRemesa()
        If (rbtGenerarConfirming.Checked Or rbtGenerarFichero34.Checked Or rbtGenerarFichero341.Checked Or rbtGenerarFichero68.Checked) And Len(cbxBancoPropio.Value) = 0 Then
            ExpertisApp.GenerateMessage("El Banco Propio es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim data As New Hashtable
            data("IdProcess") = mIDProcess
            data("FechaRemesa") = Today.Date
            data("TipoFichero") = MIntTipoFichero
            data("IdBancoPropio") = cbxBancoPropio.Value
            data("Ruta") = MStrRuta
            ExpertisApp.GenerateMessage("Los Pagos que estén remesados no entrarán en el proceso.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ExpertisApp.ExecuteTask(Of Hashtable)(AddressOf RemesaPago.AddRemesa, data)
        End If
    End Sub

    Private Sub CambioSituacion()
        Dim datosCambio As New Pago.DataCambioSituacionManual
        datosCambio.Pagos = MDtPagos
        If Length(cbxSituacion.Value) > 0 Then datosCambio.NuevaSituacion = CInt(cbxSituacion.Value)
        Dim err As ClassErrors() = ExpertisApp.ExecuteTask(Of Pago.DataCambioSituacionManual, ClassErrors())(AddressOf Pago.CambioSituacionManual, datosCambio)
        If Not err Is Nothing AndAlso err.Length > 0 Then
            ExpertisApp.GenerateMessage("Ha ocurrido un problema durante el cambio de situación. Revise sus datos.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CambioBancoPropio()
        If Length(cbxBancoPropio.Value) > 0 Then
            Dim datosCambio As New Pago.DataCambioBancoPropio
            datosCambio.Pagos = MDtPagos
            datosCambio.NuevoBancoPropio = CInt(cbxBancoPropio.Value)
            ExpertisApp.ExecuteTask(Of Pago.DataCambioBancoPropio)(AddressOf Pago.CambioBancoPropio, datosCambio)
        End If
    End Sub

    Protected Overridable Sub Imprimir()
        If chkImprimir.Checked Then
            If Length(cbxTipoInforme.Value) > 0 Then
                Dim oRpt As Report
                Select Case CType(cbxTipoInforme.Value, enumTipoImpresoPago)
                    Case enumTipoImpresoPago.tipDomiciliacion
                        oRpt = New Report("LPAGODOM") '"PagoDomiciliado.rpt"
                    Case enumTipoImpresoPago.tipChequePorBanco
                        oRpt = New Report("LPAGOCHEQ") '"PagoChequeBanco.rpt"
                    Case enumTipoImpresoPago.tipCheque
                        oRpt = New Report("LPAGOCHEQS") '"PagoCheques.rpt"
                    Case enumTipoImpresoPago.tipPagare
                        oRpt = New Report("LPAGOPAGA") '"PagoPagare.rpt"
                End Select

                Dim blnImprimir As Boolean = True
                Dim dv As DataView = MDtPagos.DefaultView
                dv.RowFilter = "Impreso=1"
                If dv.Count > 0 Then
                    If ExpertisApp.GenerateMessage("Hay Pagos seleccionados que ya están impresos. ¿Desea Continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.No Then
                        blnImprimir = False
                    End If
                End If
                If blnImprimir Then
                    oRpt.Filter.UnionOperator = FilterUnionOperator.Or
                    For Each dr As DataRow In MDtPagos.Select
                        oRpt.Filter.Add(New NumberFilterItem("IDPago", dr("IDPago")))
                        dr("IDBancoPropio") = cbxBancoPropio.Value
                    Next
                    Dim ClsPago As New Pago
                    ClsPago.Update(MDtPagos)
                    ExpertisApp.OpenReport(oRpt)
                End If
            End If
        End If
    End Sub

#End Region

#Region "Eventos FrmContabilizarRemesa"

#Region "Eventos Formulario"

    Private Sub frmContabilizarRemesa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadEnums()
        End If
    End Sub

    Protected Overridable Sub LoadEnums()
        cbxTipoInforme.DataSource = New EnumData("EnumTipoImpresoPago")
        CmbTipoFicheroSEPA.DataSource = New EnumData("enumFormatoFicheroSEPA")
        CmbTipoFicheroSEPA.Value = enumFormatoFicheroSEPA.XML
    End Sub

#End Region

#Region "Eventos Check/Radio"

    Private Sub chkImprimir_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkImprimir.CheckedChanged
        If chkImprimir.Checked Then
            cmbAceptar.Enabled = True
            cbxTipoInforme.Enabled = True
        Else
            cbxTipoInforme.Value = String.Empty
            cbxTipoInforme.Enabled = False
        End If
    End Sub

    Private Sub chkGeneraRemesa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGeneraRemesa.CheckedChanged
        If chkGeneraRemesa.Checked Then cmbAceptar.Enabled = True
    End Sub

    Private Sub rbtGenerarFichero34_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtGenerarFichero34.CheckedChanged
        If rbtGenerarFichero34.Checked Then
            'If PagosImporteNegativo(MDtPagos) Then
            '    sender.Checked = False
            '    Exit Sub
            'End If
            SaveFileDialog1.Filter = String.Empty
            SaveFileDialog1.ShowDialog()
            MStrRuta = SaveFileDialog1.FileName
            If Length(MStrRuta) = 0 Then rbtGenerarFichero34.Checked = 0
            cmbAceptar.Enabled = True
        Else
            MStrRuta = String.Empty
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
            MStrRuta = SaveFileDialog1.FileName
            If Length(MStrRuta) = 0 Then rbtGenerarFichero341.Checked = False
            cmbAceptar.Enabled = True
        Else
            MStrRuta = String.Empty
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
            MStrRuta = SaveFileDialog1.FileName
            If Length(MStrRuta) = 0 Then rbtGenerarFichero3414.Checked = False
            cmbAceptar.Enabled = True
        Else
            MStrRuta = String.Empty
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
            MStrRuta = SaveFileDialog1.FileName
            If Length(MStrRuta) = 0 Then rbtGenerarFichero68.Checked = 0
            cmbAceptar.Enabled = True
        Else
            MStrRuta = String.Empty
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
            MStrRuta = SaveFileDialog1.FileName
            If Length(MStrRuta) = 0 Then rbtGenerarConfirming.Checked = 0
            cmbAceptar.Enabled = True
        Else
            MStrRuta = String.Empty
        End If
    End Sub

#End Region

#Region "Eventos Buttons"

    Private Sub cmbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        If Not ValidarOpciones() Then
            GenerarFichero()
            GenerarRemesa()
            CambioSituacion()
            CambioBancoPropio()
            Imprimir()
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub cmbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

#End Region

#End Region



End Class