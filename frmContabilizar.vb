Imports Solmicro.Expertis.Business.General
Imports Solmicro.Expertis.Business.Negocio

Public Class frmContabilizar
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
    Protected WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Protected WithEvents lblDocumento As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents lblFechaValor As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents lblDescApunte As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents lblCContable As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents lblFechaApunte As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents lblEjercicio As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents lblBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents lblSituacion As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents ulDescEjercicio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Protected WithEvents FraRemesa As Solmicro.Expertis.Engine.UI.Frame
    Protected WithEvents FraContabilizacion As Solmicro.Expertis.Engine.UI.Frame
    Protected WithEvents cbxFechaApunte As Solmicro.Expertis.Engine.UI.CalendarBox
    Protected WithEvents cbxIDEjercicio As Solmicro.Expertis.Engine.UI.ComboBox
    Protected WithEvents cbxBancoPropio As Solmicro.Expertis.Engine.UI.ComboBox
    Protected WithEvents txtCContable As Solmicro.Expertis.Engine.UI.TextBox
    Protected WithEvents txtDescApunte As Solmicro.Expertis.Engine.UI.TextBox
    Protected WithEvents cbxFechaValor As Solmicro.Expertis.Engine.UI.CalendarBox
    Protected WithEvents txtNDocumento As Solmicro.Expertis.Engine.UI.TextBox
    Protected WithEvents chkGeneraRemesa As Solmicro.Expertis.Engine.UI.CheckBox
    Protected WithEvents chkGenerarAsiento As Solmicro.Expertis.Engine.UI.CheckBox
    Protected WithEvents chkAgruparBanco As Solmicro.Expertis.Engine.UI.CheckBox
    Protected WithEvents ulDescEstado As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Protected WithEvents ulDescBancoPropio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Protected WithEvents cbxSituacion As Solmicro.Expertis.Engine.UI.ComboBox
    Protected WithEvents chkGenerarAsientoEfectos As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents chkImprimir As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents cbxTipoInforme As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblTipoApunte As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents Frame5 As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents lblComisiones As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblImporteBanco As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FraChequePagare As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents FraComisiones As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents txtComision As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents txtImporteBanco As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents chkGenerarAsientoTalon As Solmicro.Expertis.Engine.UI.CheckBox
    Protected WithEvents rbtGenerarFichero341 As Solmicro.Expertis.Engine.UI.RadioButton
    Protected WithEvents FraGeneracionFicheros As Solmicro.Expertis.Engine.UI.Frame
    Protected WithEvents FraOtrosFicheros As Solmicro.Expertis.Engine.UI.Frame
    Protected WithEvents ClbFechaEmision As Solmicro.Expertis.Engine.UI.CalendarBox
    Protected WithEvents rbtGenerarConfirming As Solmicro.Expertis.Engine.UI.RadioButton
    Protected WithEvents rbtGenerarFichero68 As Solmicro.Expertis.Engine.UI.RadioButton
    Protected WithEvents LblFechaEmision As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents FraSEPA As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents CmbTipoFicheroSEPA As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblTipoFicheroTransf As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents rbtGenerarFichero3414 As Solmicro.Expertis.Engine.UI.RadioButton
    Protected WithEvents pnlFechaEmision As Solmicro.Expertis.Engine.UI.Panel
    Protected WithEvents pnlFicherosObsoletos As Solmicro.Expertis.Engine.UI.Panel
    Protected WithEvents ulblIDDivisa As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Protected WithEvents chkGenerarDifCambio As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents lblNota As System.Windows.Forms.Label
    Protected WithEvents rbtGenerarFichero34 As Solmicro.Expertis.Engine.UI.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim cbxTipoInforme_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContabilizar))
        Dim cbxIDEjercicio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxBancoPropio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxSituacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim CmbTipoFicheroSEPA_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.FraChequePagare = New Solmicro.Expertis.Engine.UI.Frame
        Me.chkGenerarAsientoTalon = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.FraRemesa = New Solmicro.Expertis.Engine.UI.Frame
        Me.chkGenerarAsientoEfectos = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkGeneraRemesa = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.Frame5 = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblTipoApunte = New Solmicro.Expertis.Engine.UI.Label
        Me.chkImprimir = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.cbxTipoInforme = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.FraContabilizacion = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblDocumento = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaValor = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNDocumento = New Solmicro.Expertis.Engine.UI.TextBox
        Me.cbxFechaValor = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.chkGenerarAsiento = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblDescApunte = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCContable = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaApunte = New Solmicro.Expertis.Engine.UI.Label
        Me.lblEjercicio = New Solmicro.Expertis.Engine.UI.Label
        Me.lblBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.lblSituacion = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDescApunte = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtCContable = New Solmicro.Expertis.Engine.UI.TextBox
        Me.cbxFechaApunte = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.ulDescEjercicio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.cbxIDEjercicio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.chkAgruparBanco = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.ulDescBancoPropio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.cbxBancoPropio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.ulDescEstado = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.cbxSituacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.FraComisiones = New Solmicro.Expertis.Engine.UI.Frame
        Me.chkGenerarDifCambio = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.ulblIDDivisa = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.txtComision = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImporteBanco = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblComisiones = New Solmicro.Expertis.Engine.UI.Label
        Me.lblImporteBanco = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.rbtGenerarFichero341 = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtGenerarFichero34 = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.FraGeneracionFicheros = New Solmicro.Expertis.Engine.UI.Frame
        Me.FraOtrosFicheros = New Solmicro.Expertis.Engine.UI.Frame
        Me.rbtGenerarConfirming = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtGenerarFichero68 = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.FraSEPA = New Solmicro.Expertis.Engine.UI.Frame
        Me.CmbTipoFicheroSEPA = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblTipoFicheroTransf = New Solmicro.Expertis.Engine.UI.Label
        Me.rbtGenerarFichero3414 = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.pnlFechaEmision = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblNota = New System.Windows.Forms.Label
        Me.ClbFechaEmision = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.LblFechaEmision = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlFicherosObsoletos = New Solmicro.Expertis.Engine.UI.Panel
        Me.FraChequePagare.SuspendLayout()
        Me.FraRemesa.SuspendLayout()
        Me.Frame5.SuspendLayout()
        CType(Me.cbxTipoInforme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraContabilizacion.SuspendLayout()
        CType(Me.cbxIDEjercicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxBancoPropio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxSituacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraComisiones.SuspendLayout()
        Me.Panel1.suspendlayout()
        Me.FraGeneracionFicheros.SuspendLayout()
        Me.FraOtrosFicheros.SuspendLayout()
        Me.FraSEPA.SuspendLayout()
        CType(Me.CmbTipoFicheroSEPA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFechaEmision.suspendlayout()
        Me.pnlFicherosObsoletos.suspendlayout()
        Me.SuspendLayout()
        '
        'FraChequePagare
        '
        Me.FraChequePagare.Controls.Add(Me.chkGenerarAsientoTalon)
        Me.FraChequePagare.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraChequePagare.Location = New System.Drawing.Point(0, 425)
        Me.FraChequePagare.Name = "FraChequePagare"
        Me.FraChequePagare.Size = New System.Drawing.Size(530, 36)
        Me.FraChequePagare.TabIndex = 4
        Me.FraChequePagare.TabStop = False
        '
        'chkGenerarAsientoTalon
        '
        Me.chkGenerarAsientoTalon.Location = New System.Drawing.Point(20, 14)
        Me.chkGenerarAsientoTalon.Name = "chkGenerarAsientoTalon"
        Me.chkGenerarAsientoTalon.Size = New System.Drawing.Size(260, 16)
        Me.chkGenerarAsientoTalon.TabIndex = 17
        Me.chkGenerarAsientoTalon.Text = "Generar Asiento Cheque/Pagaré Emitido"
        '
        'FraRemesa
        '
        Me.FraRemesa.Controls.Add(Me.chkGenerarAsientoEfectos)
        Me.FraRemesa.Controls.Add(Me.chkGeneraRemesa)
        Me.FraRemesa.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraRemesa.Location = New System.Drawing.Point(0, 353)
        Me.FraRemesa.Name = "FraRemesa"
        Me.FraRemesa.Size = New System.Drawing.Size(530, 32)
        Me.FraRemesa.TabIndex = 2
        Me.FraRemesa.TabStop = False
        '
        'chkGenerarAsientoEfectos
        '
        Me.chkGenerarAsientoEfectos.Location = New System.Drawing.Point(223, 9)
        Me.chkGenerarAsientoEfectos.Name = "chkGenerarAsientoEfectos"
        Me.chkGenerarAsientoEfectos.Size = New System.Drawing.Size(184, 17)
        Me.chkGenerarAsientoEfectos.TabIndex = 18
        Me.chkGenerarAsientoEfectos.Text = "Generar Asiento Efectos"
        '
        'chkGeneraRemesa
        '
        Me.chkGeneraRemesa.Location = New System.Drawing.Point(20, 8)
        Me.chkGeneraRemesa.Name = "chkGeneraRemesa"
        Me.chkGeneraRemesa.Size = New System.Drawing.Size(151, 21)
        Me.chkGeneraRemesa.TabIndex = 14
        Me.chkGeneraRemesa.Text = "Generar Remesa"
        '
        'Frame5
        '
        Me.Frame5.Controls.Add(Me.lblTipoApunte)
        Me.Frame5.Controls.Add(Me.chkImprimir)
        Me.Frame5.Controls.Add(Me.cbxTipoInforme)
        Me.Frame5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Frame5.Location = New System.Drawing.Point(0, 385)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.Size = New System.Drawing.Size(530, 40)
        Me.Frame5.TabIndex = 3
        Me.Frame5.TabStop = False
        '
        'lblTipoApunte
        '
        Me.lblTipoApunte.Location = New System.Drawing.Point(164, 16)
        Me.lblTipoApunte.Name = "lblTipoApunte"
        Me.lblTipoApunte.Size = New System.Drawing.Size(81, 13)
        Me.lblTipoApunte.TabIndex = 44
        Me.lblTipoApunte.Tag = ""
        Me.lblTipoApunte.Text = "Tipo Informe"
        '
        'chkImprimir
        '
        Me.chkImprimir.Location = New System.Drawing.Point(20, 12)
        Me.chkImprimir.Name = "chkImprimir"
        Me.chkImprimir.Size = New System.Drawing.Size(84, 21)
        Me.chkImprimir.TabIndex = 15
        Me.chkImprimir.Text = "Imprimir"
        '
        'cbxTipoInforme
        '
        cbxTipoInforme_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoInforme_DesignTimeLayout.LayoutString")
        Me.cbxTipoInforme.DesignTimeLayout = cbxTipoInforme_DesignTimeLayout
        Me.cbxTipoInforme.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoInforme.Enabled = False
        Me.cbxTipoInforme.Location = New System.Drawing.Point(249, 12)
        Me.cbxTipoInforme.Name = "cbxTipoInforme"
        Me.cbxTipoInforme.SelectedIndex = -1
        Me.cbxTipoInforme.SelectedItem = Nothing
        Me.cbxTipoInforme.Size = New System.Drawing.Size(221, 21)
        Me.cbxTipoInforme.TabIndex = 16
        '
        'FraContabilizacion
        '
        Me.FraContabilizacion.Controls.Add(Me.lblDocumento)
        Me.FraContabilizacion.Controls.Add(Me.lblFechaValor)
        Me.FraContabilizacion.Controls.Add(Me.txtNDocumento)
        Me.FraContabilizacion.Controls.Add(Me.cbxFechaValor)
        Me.FraContabilizacion.Controls.Add(Me.chkGenerarAsiento)
        Me.FraContabilizacion.Controls.Add(Me.lblDescApunte)
        Me.FraContabilizacion.Controls.Add(Me.lblCContable)
        Me.FraContabilizacion.Controls.Add(Me.lblFechaApunte)
        Me.FraContabilizacion.Controls.Add(Me.lblEjercicio)
        Me.FraContabilizacion.Controls.Add(Me.lblBancoPropio)
        Me.FraContabilizacion.Controls.Add(Me.lblSituacion)
        Me.FraContabilizacion.Controls.Add(Me.txtDescApunte)
        Me.FraContabilizacion.Controls.Add(Me.txtCContable)
        Me.FraContabilizacion.Controls.Add(Me.cbxFechaApunte)
        Me.FraContabilizacion.Controls.Add(Me.ulDescEjercicio)
        Me.FraContabilizacion.Controls.Add(Me.cbxIDEjercicio)
        Me.FraContabilizacion.Controls.Add(Me.chkAgruparBanco)
        Me.FraContabilizacion.Controls.Add(Me.ulDescBancoPropio)
        Me.FraContabilizacion.Controls.Add(Me.cbxBancoPropio)
        Me.FraContabilizacion.Controls.Add(Me.ulDescEstado)
        Me.FraContabilizacion.Controls.Add(Me.cbxSituacion)
        Me.FraContabilizacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraContabilizacion.Location = New System.Drawing.Point(0, 0)
        Me.FraContabilizacion.Name = "FraContabilizacion"
        Me.FraContabilizacion.Size = New System.Drawing.Size(530, 207)
        Me.FraContabilizacion.TabIndex = 0
        Me.FraContabilizacion.TabStop = False
        '
        'lblDocumento
        '
        Me.lblDocumento.Location = New System.Drawing.Point(316, 184)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(72, 13)
        Me.lblDocumento.TabIndex = 54
        Me.lblDocumento.Tag = "IdRec=4739;"
        Me.lblDocumento.Text = "Documento"
        '
        'lblFechaValor
        '
        Me.lblFechaValor.Location = New System.Drawing.Point(316, 160)
        Me.lblFechaValor.Name = "lblFechaValor"
        Me.lblFechaValor.Size = New System.Drawing.Size(73, 13)
        Me.lblFechaValor.TabIndex = 55
        Me.lblFechaValor.Tag = "IdRec=5024;"
        Me.lblFechaValor.Text = "Fecha Valor"
        '
        'txtNDocumento
        '
        Me.txtNDocumento.DisabledBackColor = System.Drawing.Color.White
        Me.txtNDocumento.Location = New System.Drawing.Point(412, 180)
        Me.txtNDocumento.Name = "txtNDocumento"
        Me.txtNDocumento.Size = New System.Drawing.Size(104, 21)
        Me.txtNDocumento.TabIndex = 9
        '
        'cbxFechaValor
        '
        Me.cbxFechaValor.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaValor.Location = New System.Drawing.Point(412, 156)
        Me.cbxFechaValor.Name = "cbxFechaValor"
        Me.cbxFechaValor.Size = New System.Drawing.Size(104, 21)
        Me.cbxFechaValor.TabIndex = 8
        '
        'chkGenerarAsiento
        '
        Me.chkGenerarAsiento.Location = New System.Drawing.Point(20, 180)
        Me.chkGenerarAsiento.Name = "chkGenerarAsiento"
        Me.chkGenerarAsiento.Size = New System.Drawing.Size(157, 21)
        Me.chkGenerarAsiento.TabIndex = 7
        Me.chkGenerarAsiento.Text = "Generar Asiento"
        '
        'lblDescApunte
        '
        Me.lblDescApunte.Location = New System.Drawing.Point(20, 136)
        Me.lblDescApunte.Name = "lblDescApunte"
        Me.lblDescApunte.Size = New System.Drawing.Size(83, 13)
        Me.lblDescApunte.TabIndex = 43
        Me.lblDescApunte.Tag = ""
        Me.lblDescApunte.Text = "Desc. Apunte"
        '
        'lblCContable
        '
        Me.lblCContable.Location = New System.Drawing.Point(20, 88)
        Me.lblCContable.Name = "lblCContable"
        Me.lblCContable.Size = New System.Drawing.Size(75, 13)
        Me.lblCContable.TabIndex = 44
        Me.lblCContable.Tag = ""
        Me.lblCContable.Text = "C. Contable"
        '
        'lblFechaApunte
        '
        Me.lblFechaApunte.Location = New System.Drawing.Point(20, 16)
        Me.lblFechaApunte.Name = "lblFechaApunte"
        Me.lblFechaApunte.Size = New System.Drawing.Size(84, 13)
        Me.lblFechaApunte.TabIndex = 45
        Me.lblFechaApunte.Tag = "IdRec=4771;"
        Me.lblFechaApunte.Text = "Fecha Apunte"
        '
        'lblEjercicio
        '
        Me.lblEjercicio.Location = New System.Drawing.Point(20, 40)
        Me.lblEjercicio.Name = "lblEjercicio"
        Me.lblEjercicio.Size = New System.Drawing.Size(55, 13)
        Me.lblEjercicio.TabIndex = 46
        Me.lblEjercicio.Tag = "IdRec=6583;"
        Me.lblEjercicio.Text = "Ejercicio"
        '
        'lblBancoPropio
        '
        Me.lblBancoPropio.Location = New System.Drawing.Point(20, 64)
        Me.lblBancoPropio.Name = "lblBancoPropio"
        Me.lblBancoPropio.Size = New System.Drawing.Size(82, 13)
        Me.lblBancoPropio.TabIndex = 48
        Me.lblBancoPropio.Tag = "IdRec=4613;"
        Me.lblBancoPropio.Text = "Banco Propio"
        '
        'lblSituacion
        '
        Me.lblSituacion.Location = New System.Drawing.Point(20, 112)
        Me.lblSituacion.Name = "lblSituacion"
        Me.lblSituacion.Size = New System.Drawing.Size(79, 13)
        Me.lblSituacion.TabIndex = 50
        Me.lblSituacion.Tag = "IdRec=4742;"
        Me.lblSituacion.Text = "Cambiar a..."
        '
        'txtDescApunte
        '
        Me.txtDescApunte.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescApunte.Location = New System.Drawing.Point(108, 132)
        Me.txtDescApunte.Name = "txtDescApunte"
        Me.txtDescApunte.Size = New System.Drawing.Size(410, 21)
        Me.txtDescApunte.TabIndex = 5
        '
        'txtCContable
        '
        Me.TryDataBinding(txtCContable, New System.Windows.Forms.Binding("Text", Me.cbxBancoPropio, "CContable", True))
        Me.txtCContable.DisabledBackColor = System.Drawing.Color.White
        Me.txtCContable.Enabled = False
        Me.txtCContable.Location = New System.Drawing.Point(108, 84)
        Me.txtCContable.Name = "txtCContable"
        Me.txtCContable.Size = New System.Drawing.Size(104, 21)
        Me.txtCContable.TabIndex = 3
        '
        'cbxFechaApunte
        '
        Me.cbxFechaApunte.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaApunte.Location = New System.Drawing.Point(108, 12)
        Me.cbxFechaApunte.Name = "cbxFechaApunte"
        Me.cbxFechaApunte.Size = New System.Drawing.Size(104, 21)
        Me.cbxFechaApunte.TabIndex = 0
        '
        'ulDescEjercicio
        '
        Me.TryDataBinding(ulDescEjercicio, New System.Windows.Forms.Binding("Text", Me.cbxIDEjercicio, "DescEjercicio", True))
        Me.ulDescEjercicio.Location = New System.Drawing.Point(216, 36)
        Me.ulDescEjercicio.Name = "ulDescEjercicio"
        Me.ulDescEjercicio.Size = New System.Drawing.Size(297, 21)
        Me.ulDescEjercicio.TabIndex = 47
        '
        'cbxIDEjercicio
        '
        cbxIDEjercicio_DesignTimeLayout.LayoutString = resources.GetString("cbxIDEjercicio_DesignTimeLayout.LayoutString")
        Me.cbxIDEjercicio.DesignTimeLayout = cbxIDEjercicio_DesignTimeLayout
        Me.cbxIDEjercicio.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDEjercicio.DisplayMember = "IDEjercicio"
        Me.cbxIDEjercicio.EntityName = "EjercicioContable"
        Me.cbxIDEjercicio.Location = New System.Drawing.Point(108, 36)
        Me.cbxIDEjercicio.Name = "cbxIDEjercicio"
        Me.cbxIDEjercicio.SecondaryDataFields = "IDEjercicio"
        Me.cbxIDEjercicio.SelectedIndex = -1
        Me.cbxIDEjercicio.SelectedItem = Nothing
        Me.cbxIDEjercicio.Size = New System.Drawing.Size(104, 21)
        Me.cbxIDEjercicio.TabIndex = 1
        Me.cbxIDEjercicio.ValueMember = "IDEjercicio"
        Me.cbxIDEjercicio.ViewName = "tbMaestroEjercicio"
        '
        'chkAgruparBanco
        '
        Me.chkAgruparBanco.Location = New System.Drawing.Point(20, 156)
        Me.chkAgruparBanco.Name = "chkAgruparBanco"
        Me.chkAgruparBanco.Size = New System.Drawing.Size(181, 21)
        Me.chkAgruparBanco.TabIndex = 6
        Me.chkAgruparBanco.Text = "Agrupar apunte de Banco"
        '
        'ulDescBancoPropio
        '
        Me.TryDataBinding(ulDescBancoPropio, New System.Windows.Forms.Binding("Text", Me.cbxBancoPropio, "DescBancoPropio", True))
        Me.ulDescBancoPropio.Location = New System.Drawing.Point(216, 60)
        Me.ulDescBancoPropio.Name = "ulDescBancoPropio"
        Me.ulDescBancoPropio.Size = New System.Drawing.Size(297, 21)
        Me.ulDescBancoPropio.TabIndex = 49
        '
        'cbxBancoPropio
        '
        cbxBancoPropio_DesignTimeLayout.LayoutString = resources.GetString("cbxBancoPropio_DesignTimeLayout.LayoutString")
        Me.cbxBancoPropio.DesignTimeLayout = cbxBancoPropio_DesignTimeLayout
        Me.cbxBancoPropio.DisabledBackColor = System.Drawing.Color.White
        Me.cbxBancoPropio.DisplayMember = "IDBancoPropio"
        Me.cbxBancoPropio.EntityName = "BancoPropio"
        Me.cbxBancoPropio.Location = New System.Drawing.Point(108, 60)
        Me.cbxBancoPropio.Name = "cbxBancoPropio"
        Me.cbxBancoPropio.PrimaryDataFields = "IDBancoPropio"
        Me.cbxBancoPropio.SecondaryDataFields = "IDBancoPropio"
        Me.cbxBancoPropio.SelectedIndex = -1
        Me.cbxBancoPropio.SelectedItem = Nothing
        Me.cbxBancoPropio.Size = New System.Drawing.Size(104, 21)
        Me.cbxBancoPropio.TabIndex = 2
        Me.cbxBancoPropio.ValueMember = "IDBancoPropio"
        Me.cbxBancoPropio.ViewName = "tbMaestroBancoPropio"
        '
        'ulDescEstado
        '
        Me.TryDataBinding(ulDescEstado, New System.Windows.Forms.Binding("Text", Me.cbxSituacion, "DescEstado", True))
        Me.ulDescEstado.Location = New System.Drawing.Point(216, 108)
        Me.ulDescEstado.Name = "ulDescEstado"
        Me.ulDescEstado.Size = New System.Drawing.Size(297, 21)
        Me.ulDescEstado.TabIndex = 51
        '
        'cbxSituacion
        '
        cbxSituacion_DesignTimeLayout.LayoutString = resources.GetString("cbxSituacion_DesignTimeLayout.LayoutString")
        Me.cbxSituacion.DesignTimeLayout = cbxSituacion_DesignTimeLayout
        Me.cbxSituacion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxSituacion.DisplayMember = "IDEstado"
        Me.cbxSituacion.EntityName = "EstadoPago"
        Me.cbxSituacion.Location = New System.Drawing.Point(108, 108)
        Me.cbxSituacion.Name = "cbxSituacion"
        Me.cbxSituacion.PrimaryDataFields = "IDEstado"
        Me.cbxSituacion.SecondaryDataFields = "IDEstado"
        Me.cbxSituacion.SelectedIndex = -1
        Me.cbxSituacion.SelectedItem = Nothing
        Me.cbxSituacion.Size = New System.Drawing.Size(104, 21)
        Me.cbxSituacion.TabIndex = 4
        Me.cbxSituacion.ValueMember = "IDEstado"
        Me.cbxSituacion.ViewName = "tbMaestroEstadoPago"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.RestoreDirectory = True
        '
        'FraComisiones
        '
        Me.FraComisiones.Controls.Add(Me.chkGenerarDifCambio)
        Me.FraComisiones.Controls.Add(Me.ulblIDDivisa)
        Me.FraComisiones.Controls.Add(Me.txtComision)
        Me.FraComisiones.Controls.Add(Me.txtImporteBanco)
        Me.FraComisiones.Controls.Add(Me.lblComisiones)
        Me.FraComisiones.Controls.Add(Me.lblImporteBanco)
        Me.FraComisiones.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraComisiones.Location = New System.Drawing.Point(0, 461)
        Me.FraComisiones.Name = "FraComisiones"
        Me.FraComisiones.Size = New System.Drawing.Size(530, 70)
        Me.FraComisiones.TabIndex = 5
        Me.FraComisiones.TabStop = False
        Me.FraComisiones.Tag = "47474"
        Me.FraComisiones.Text = "Diferencias de importe y comisiones"
        '
        'chkGenerarDifCambio
        '
        Me.chkGenerarDifCambio.Enabled = False
        Me.chkGenerarDifCambio.Location = New System.Drawing.Point(20, 45)
        Me.chkGenerarDifCambio.Name = "chkGenerarDifCambio"
        Me.chkGenerarDifCambio.Size = New System.Drawing.Size(196, 16)
        Me.chkGenerarDifCambio.TabIndex = 2
        Me.chkGenerarDifCambio.Text = "Generar Diferencia Cambio"
        '
        'ulblIDDivisa
        '
        Me.ulblIDDivisa.Location = New System.Drawing.Point(409, 19)
        Me.ulblIDDivisa.Name = "ulblIDDivisa"
        Me.ulblIDDivisa.Size = New System.Drawing.Size(32, 19)
        Me.ulblIDDivisa.TabIndex = 28
        '
        'txtComision
        '
        Me.txtComision.DisabledBackColor = System.Drawing.Color.White
        Me.txtComision.Location = New System.Drawing.Point(317, 18)
        Me.txtComision.Name = "txtComision"
        Me.txtComision.Size = New System.Drawing.Size(88, 21)
        Me.txtComision.TabIndex = 1
        '
        'txtImporteBanco
        '
        Me.txtImporteBanco.DisabledBackColor = System.Drawing.Color.White
        Me.txtImporteBanco.Location = New System.Drawing.Point(117, 18)
        Me.txtImporteBanco.Name = "txtImporteBanco"
        Me.txtImporteBanco.Size = New System.Drawing.Size(88, 21)
        Me.txtImporteBanco.TabIndex = 0
        '
        'lblComisiones
        '
        Me.lblComisiones.Location = New System.Drawing.Point(241, 22)
        Me.lblComisiones.Name = "lblComisiones"
        Me.lblComisiones.Size = New System.Drawing.Size(73, 13)
        Me.lblComisiones.TabIndex = 27
        Me.lblComisiones.Tag = "IdRec=47476;"
        Me.lblComisiones.Text = "Comisiones"
        '
        'lblImporteBanco
        '
        Me.lblImporteBanco.Location = New System.Drawing.Point(20, 22)
        Me.lblImporteBanco.Name = "lblImporteBanco"
        Me.lblImporteBanco.Size = New System.Drawing.Size(92, 13)
        Me.lblImporteBanco.TabIndex = 26
        Me.lblImporteBanco.Tag = "IdRec=47475;"
        Me.lblImporteBanco.Text = "Importe Banco"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 588)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(530, 47)
        Me.Panel1.TabIndex = 7
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(170, 9)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(89, 30)
        Me.cmbAceptar.TabIndex = 20
        Me.cmbAceptar.Text = "Aceptar"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Location = New System.Drawing.Point(273, 9)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(89, 30)
        Me.cmbCancelar.TabIndex = 21
        Me.cmbCancelar.Text = "Cancelar"
        '
        'rbtGenerarFichero341
        '
        Me.rbtGenerarFichero341.Location = New System.Drawing.Point(20, 34)
        Me.rbtGenerarFichero341.Name = "rbtGenerarFichero341"
        Me.rbtGenerarFichero341.Size = New System.Drawing.Size(288, 16)
        Me.rbtGenerarFichero341.TabIndex = 38
        Me.rbtGenerarFichero341.Text = "Generar Fichero C.S.B. norma 34.1"
        '
        'rbtGenerarFichero34
        '
        Me.rbtGenerarFichero34.Location = New System.Drawing.Point(20, 10)
        Me.rbtGenerarFichero34.Name = "rbtGenerarFichero34"
        Me.rbtGenerarFichero34.Size = New System.Drawing.Size(288, 16)
        Me.rbtGenerarFichero34.TabIndex = 37
        Me.rbtGenerarFichero34.Text = "Generar Fichero C.S.B. norma 34"
        '
        'FraGeneracionFicheros
        '
        Me.FraGeneracionFicheros.Controls.Add(Me.FraOtrosFicheros)
        Me.FraGeneracionFicheros.Controls.Add(Me.FraSEPA)
        Me.FraGeneracionFicheros.Controls.Add(Me.pnlFechaEmision)
        Me.FraGeneracionFicheros.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraGeneracionFicheros.Location = New System.Drawing.Point(0, 207)
        Me.FraGeneracionFicheros.Name = "FraGeneracionFicheros"
        Me.FraGeneracionFicheros.Size = New System.Drawing.Size(530, 146)
        Me.FraGeneracionFicheros.TabIndex = 1
        Me.FraGeneracionFicheros.TabStop = False
        Me.FraGeneracionFicheros.Text = "Generación de Ficheros"
        '
        'FraOtrosFicheros
        '
        Me.FraOtrosFicheros.Controls.Add(Me.rbtGenerarConfirming)
        Me.FraOtrosFicheros.Controls.Add(Me.rbtGenerarFichero68)
        Me.FraOtrosFicheros.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraOtrosFicheros.Location = New System.Drawing.Point(3, 104)
        Me.FraOtrosFicheros.Name = "FraOtrosFicheros"
        Me.FraOtrosFicheros.Size = New System.Drawing.Size(524, 40)
        Me.FraOtrosFicheros.TabIndex = 2
        Me.FraOtrosFicheros.TabStop = False
        '
        'rbtGenerarConfirming
        '
        Me.rbtGenerarConfirming.Location = New System.Drawing.Point(223, 16)
        Me.rbtGenerarConfirming.Name = "rbtGenerarConfirming"
        Me.rbtGenerarConfirming.Size = New System.Drawing.Size(148, 16)
        Me.rbtGenerarConfirming.TabIndex = 38
        Me.rbtGenerarConfirming.Text = "Confirming"
        '
        'rbtGenerarFichero68
        '
        Me.rbtGenerarFichero68.Location = New System.Drawing.Point(20, 16)
        Me.rbtGenerarFichero68.Name = "rbtGenerarFichero68"
        Me.rbtGenerarFichero68.Size = New System.Drawing.Size(150, 16)
        Me.rbtGenerarFichero68.TabIndex = 37
        Me.rbtGenerarFichero68.Text = "C.S.B. norma 68"
        '
        'FraSEPA
        '
        Me.FraSEPA.Controls.Add(Me.CmbTipoFicheroSEPA)
        Me.FraSEPA.Controls.Add(Me.lblTipoFicheroTransf)
        Me.FraSEPA.Controls.Add(Me.rbtGenerarFichero3414)
        Me.FraSEPA.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraSEPA.Location = New System.Drawing.Point(3, 61)
        Me.FraSEPA.Name = "FraSEPA"
        Me.FraSEPA.Size = New System.Drawing.Size(524, 43)
        Me.FraSEPA.TabIndex = 1
        Me.FraSEPA.TabStop = False
        Me.FraSEPA.Text = "SEPA"
        '
        'CmbTipoFicheroSEPA
        '
        CmbTipoFicheroSEPA_DesignTimeLayout.LayoutString = resources.GetString("CmbTipoFicheroSEPA_DesignTimeLayout.LayoutString")
        Me.CmbTipoFicheroSEPA.DesignTimeLayout = CmbTipoFicheroSEPA_DesignTimeLayout
        Me.CmbTipoFicheroSEPA.DisabledBackColor = System.Drawing.Color.White
        Me.CmbTipoFicheroSEPA.Location = New System.Drawing.Point(324, 15)
        Me.CmbTipoFicheroSEPA.Name = "CmbTipoFicheroSEPA"
        Me.CmbTipoFicheroSEPA.SelectedIndex = -1
        Me.CmbTipoFicheroSEPA.SelectedItem = Nothing
        Me.CmbTipoFicheroSEPA.Size = New System.Drawing.Size(112, 21)
        Me.CmbTipoFicheroSEPA.TabIndex = 45
        '
        'lblTipoFicheroTransf
        '
        Me.lblTipoFicheroTransf.Location = New System.Drawing.Point(223, 19)
        Me.lblTipoFicheroTransf.Name = "lblTipoFicheroTransf"
        Me.lblTipoFicheroTransf.Size = New System.Drawing.Size(76, 13)
        Me.lblTipoFicheroTransf.TabIndex = 46
        Me.lblTipoFicheroTransf.Tag = ""
        Me.lblTipoFicheroTransf.Text = "Tipo Fichero"
        '
        'rbtGenerarFichero3414
        '
        Me.rbtGenerarFichero3414.Location = New System.Drawing.Point(20, 20)
        Me.rbtGenerarFichero3414.Name = "rbtGenerarFichero3414"
        Me.rbtGenerarFichero3414.Size = New System.Drawing.Size(150, 16)
        Me.rbtGenerarFichero3414.TabIndex = 43
        Me.rbtGenerarFichero3414.Text = "C.S.B. norma 34.14"
        '
        'pnlFechaEmision
        '
        Me.pnlFechaEmision.Controls.Add(Me.lblNota)
        Me.pnlFechaEmision.Controls.Add(Me.ClbFechaEmision)
        Me.pnlFechaEmision.Controls.Add(Me.LblFechaEmision)
        Me.pnlFechaEmision.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFechaEmision.Location = New System.Drawing.Point(3, 17)
        Me.pnlFechaEmision.Name = "pnlFechaEmision"
        Me.pnlFechaEmision.Size = New System.Drawing.Size(524, 44)
        Me.pnlFechaEmision.TabIndex = 0
        '
        'lblNota
        '
        Me.lblNota.AutoSize = True
        Me.lblNota.Font = New System.Drawing.Font("Verdana", 7.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNota.ForeColor = System.Drawing.Color.Red
        Me.lblNota.Location = New System.Drawing.Point(3, 31)
        Me.lblNota.Name = "lblNota"
        Me.lblNota.Size = New System.Drawing.Size(518, 12)
        Me.lblNota.TabIndex = 43
        Me.lblNota.Text = "* Si no se indica una Fecha de Emisión, los Pagos se efectuarán en la Fecha del  " & _
            "Vencimiento"
        '
        'ClbFechaEmision
        '
        Me.ClbFechaEmision.DisabledBackColor = System.Drawing.Color.White
        Me.ClbFechaEmision.Location = New System.Drawing.Point(402, 7)
        Me.ClbFechaEmision.Name = "ClbFechaEmision"
        Me.ClbFechaEmision.Size = New System.Drawing.Size(112, 21)
        Me.ClbFechaEmision.TabIndex = 42
        '
        'LblFechaEmision
        '
        Me.LblFechaEmision.Location = New System.Drawing.Point(306, 11)
        Me.LblFechaEmision.Name = "LblFechaEmision"
        Me.LblFechaEmision.Size = New System.Drawing.Size(88, 13)
        Me.LblFechaEmision.TabIndex = 41
        Me.LblFechaEmision.Text = "Fecha Emisión"
        '
        'pnlFicherosObsoletos
        '
        Me.pnlFicherosObsoletos.Controls.Add(Me.rbtGenerarFichero34)
        Me.pnlFicherosObsoletos.Controls.Add(Me.rbtGenerarFichero341)
        Me.pnlFicherosObsoletos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFicherosObsoletos.Location = New System.Drawing.Point(0, 531)
        Me.pnlFicherosObsoletos.Name = "pnlFicherosObsoletos"
        Me.pnlFicherosObsoletos.Size = New System.Drawing.Size(530, 54)
        Me.pnlFicherosObsoletos.TabIndex = 6
        '
        'frmContabilizar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(530, 635)
        Me.Controls.Add(Me.pnlFicherosObsoletos)
        Me.Controls.Add(Me.FraComisiones)
        Me.Controls.Add(Me.FraChequePagare)
        Me.Controls.Add(Me.Frame5)
        Me.Controls.Add(Me.FraRemesa)
        Me.Controls.Add(Me.FraGeneracionFicheros)
        Me.Controls.Add(Me.FraContabilizacion)
        Me.Controls.Add(Me.Panel1)
        Me.EntityName = "EjercicioContable"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmContabilizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contabilización"
        Me.ViewName = "tbMaestroEjercicio"
        Me.FraChequePagare.ResumeLayout(False)
        Me.FraRemesa.ResumeLayout(False)
        Me.Frame5.ResumeLayout(False)
        Me.Frame5.PerformLayout()
        CType(Me.cbxTipoInforme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraContabilizacion.ResumeLayout(False)
        Me.FraContabilizacion.PerformLayout()
        CType(Me.cbxIDEjercicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxBancoPropio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxSituacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraComisiones.ResumeLayout(False)
        Me.FraComisiones.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.FraGeneracionFicheros.ResumeLayout(False)
        Me.FraOtrosFicheros.ResumeLayout(False)
        Me.FraSEPA.ResumeLayout(False)
        Me.FraSEPA.PerformLayout()
        CType(Me.CmbTipoFicheroSEPA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFechaEmision.ResumeLayout(False)
        Me.pnlFechaEmision.PerformLayout()
        Me.pnlFicherosObsoletos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public mdtPagos As DataTable
    Protected mstrRuta As String
    Protected mstrRutaFicheroSEPA As String
    Protected mstrIdBPropio As String
    Protected mblnConfirming, mblnTransferencia, mblnCambioSituacionManual, mblnCancel As Boolean
    Protected mintTipoFichero As Integer = -1
    Protected mblnGenerarAsiento As Boolean
    Protected mblnEspecial As Boolean
    Protected mblnRemesaGenerada As Boolean
    Protected mSituacionPagare As enumPagoSituacion
    Protected mSituacionContaInit As enumPagoSituacion
    Protected mSituacionSinContaDefault As enumPagoSituacion
    ' Protected mblnPagoImpreso As Boolean

    Public WriteOnly Property GenerarAsiento() As Boolean
        Set(ByVal Value As Boolean)
            mblnGenerarAsiento = Value
        End Set
    End Property

    Public ReadOnly Property RemesaGenerada() As Boolean
        Get
            Return mblnRemesaGenerada
        End Get
    End Property

    'Public ReadOnly Property PagoImpreso() As Boolean
    '    Get
    '        Return mblnPagoImpreso
    '    End Get
    'End Property

    Public ReadOnly Property GenerarDiferenciaCambio() As Boolean
        Get
            Return Me.chkGenerarDifCambio.Checked
        End Get
    End Property

#Region " Load "

    Public Function AbrirContabilizacion(ByRef blnGenerarAsientoPago As Boolean, _
                                         ByRef blnGenerarAsientoTalon As Boolean, _
                                         ByRef blnGenerarAsientoEfectos As Boolean, _
                                         ByRef strNDocumento As String, ByRef dtFechaApunte As Date, _
                                         ByRef dtFechaValor As Date, ByRef strIdBPropio As String, _
                                         ByRef intNuevaSituacion As Integer, ByRef strEjercicio As String, _
                                         ByRef blnAgruparBanco As Boolean, ByRef strDescApunte As String, _
                                         ByRef dblImporte As Double, ByRef dblComision As Double, _
                                         Optional ByVal blnCambioSituacionManual As Boolean = False, _
                                         Optional ByVal dtPagos As DataTable = Nothing, _
                                         Optional ByVal blnEspecial As Boolean = False) As DialogResult

        mdtPagos = dtPagos
        mstrIdBPropio = strIdBPropio
        mblnCambioSituacionManual = blnCambioSituacionManual
        mblnEspecial = blnEspecial
        Dim p As New Parametro
        mSituacionPagare = p.DescontabilizarPagaresEnviados  '//Sirve para contabilizar/descontabilizar
        mSituacionSinContaDefault = p.SituacionPagoSinContaDefecto
        If Not blnCambioSituacionManual Then
            cbxSituacion.Value = p.PagoContSituacion
        Else
            'Si blnCambioSituacionManual=True implica una contabilizacion por cambio de
            'situacion a "pagado" sin estar contabilizado
            cbxSituacion.Enabled = False
            cbxSituacion.Value = enumPagoSituacion.Pagado
        End If
        mSituacionContaInit = cbxSituacion.Value

        Me.ShowDialog()

        strNDocumento = txtNDocumento.Text
        blnGenerarAsientoPago = chkGenerarAsiento.Checked
        blnGenerarAsientoTalon = chkGenerarAsientoTalon.Checked
        blnGenerarAsientoEfectos = chkGenerarAsientoEfectos.Checked
        If Length(cbxFechaValor.Value) > 0 Then dtFechaValor = cbxFechaValor.Value
        dtFechaApunte = cbxFechaApunte.Value
        strIdBPropio = cbxBancoPropio.Value
        strEjercicio = cbxIDEjercicio.Value
        blnAgruparBanco = chkAgruparBanco.Checked

        intNuevaSituacion = cbxSituacion.Value
        strDescApunte = txtDescApunte.Text
        dblImporte = txtImporteBanco.Value
        dblComision = txtComision.Value
        Return Me.DialogResult
    End Function

    Private Sub frmContabilizar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            'LoadERPSettings()
            LoadEnums()
            LoadDefaultValues()
        End If
    End Sub

    'Private Sub LoadERPSettings()
    '    Dim ej As New EjercicioContable
    '    'cbxIDEjercicio.Value = ej.Predeterminado(Date.Today)
    '    Dim dtFechaApunte As Date = Date.Today
    '    If mblnEspecial Then
    '        cbxIDEjercicio.Value = ej.PredeterminadoB(dtFechaApunte)
    '    Else
    '        cbxIDEjercicio.Value = ej.Predeterminado(dtFechaApunte)
    '    End If

    'End Sub

    Private Sub LoadEnums()
        cbxTipoInforme.DataSource = New EnumData("EnumTipoImpresoPago")
        CmbTipoFicheroSEPA.DataSource = New EnumData("enumFormatoFicheroSEPA")
    End Sub

    Private Sub LoadDefaultValues()
        chkGenerarAsiento.Checked = mblnGenerarAsiento

        Dim dtFechaApunte As Date = Date.Today
        cbxFechaApunte.Value = dtFechaApunte
        cbxFechaApunte_Validated(cbxFechaApunte, New EventArgs)
        Dim oFilter As New Filter
        oFilter.Add(New BooleanFilterItem("EjercicioCerrado", FilterOperator.Equal, False))
        oFilter.Add(New BooleanFilterItem("AIva", FilterOperator.Equal, Not mblnEspecial))
        cbxIDEjercicio.Filter = oFilter

        If mstrIdBPropio <> String.Empty Then cbxBancoPropio.Value = mstrIdBPropio

        chkGenerarAsientoTalon.Enabled = False
        chkGenerarAsientoTalon.Checked = False

        If Not mblnCambioSituacionManual Then
            Dim p As New Parametro
            cbxSituacion.Value = p.PagoContSituacion
        Else
            'Si blnCambioSituacionManual=True implica una contabilizacion por cambio de situacion a "Pagado" sin estar contabilizado
            cbxSituacion.Enabled = False
            cbxSituacion.Value = CInt(enumPagoSituacion.Pagado)
        End If
        CmbTipoFicheroSEPA.Value = enumFormatoFicheroSEPA.XML
    End Sub

#End Region

#Region " Aceptar / Cancelar "

    Protected Overridable Function ValidarOpciones() As Boolean
        Dim blnCancel As Boolean
        If (chkGenerarAsiento.Checked Or chkGenerarAsientoTalon.Checked) And Length(cbxIDEjercicio.Value) = 0 Then
            blnCancel = True
            ExpertisApp.GenerateMessage("Debe introducir un Ejercicio Contable.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf (chkGenerarAsiento.Checked Or chkGenerarAsientoTalon.Checked) And Length(Me.cbxFechaApunte.Value) = 0 Then
            blnCancel = True
            ExpertisApp.GenerateMessage("Debe introducir una Fecha de Apunte.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf (rbtGenerarConfirming.Checked Or rbtGenerarFichero68.Checked Or rbtGenerarFichero341.Checked Or chkGenerarAsiento.Checked Or rbtGenerarFichero34.Checked Or chkImprimir.Checked Or chkGenerarAsientoTalon.Checked) And Length(cbxBancoPropio.Value) = 0 Then
            blnCancel = True
            ExpertisApp.GenerateMessage("El Banco Propio es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf chkGenerarAsiento.Checked Or chkGenerarAsientoTalon.Checked Then

        End If

        If Me.txtImporteBanco.Value > 0 AndAlso Not Me.chkAgruparBanco.Checked Then
            If Not mdtPagos Is Nothing AndAlso mdtPagos.Rows.Count > 1 Then
                ExpertisApp.GenerateMessage("Si introduce Importe de Banco, debe agrupar los apuntes por banco.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.chkAgruparBanco.Focus()
                blnCancel = True
            End If
        End If


        Dim dtDesde As Date
        Dim dtHasta As Date

        Dim objNegEjercicio As New EjercicioContable
        Dim dtEjercicio As DataTable = objNegEjercicio.SelOnPrimaryKey(cbxIDEjercicio.Value)
        objNegEjercicio = Nothing

        If Not IsNothing(dtEjercicio) AndAlso dtEjercicio.Rows.Count > 0 Then
            dtDesde = dtEjercicio.Rows(0)("FechaDesde")
            dtHasta = dtEjercicio.Rows(0)("FechaHasta")
            If cbxFechaApunte.Value < dtDesde Or cbxFechaApunte.Value > dtHasta Then
                ExpertisApp.GenerateMessage("La fecha introducida no pertenece al Ejercicio Seleccionado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                blnCancel = True
            End If
        Else
            ExpertisApp.GenerateMessage("Debe introducir un Ejercicio Contable correcto.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cbxIDEjercicio.Focus()
            blnCancel = True
        End If

        ComprobarContabilidaEnVto(blnCancel)

        ComprobarPagosRemesados(blnCancel)

        If Not blnCancel AndAlso chkImprimir.Checked AndAlso Length(cbxTipoInforme.Value) = 0 Then
            If ExpertisApp.GenerateMessage("Debe introducir un tipo de Informe. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Ok Then
                blnCancel = True
            End If
        End If

        Return blnCancel
    End Function

    Protected Overridable Sub ComprobarContabilidaEnVto(ByRef blnCancel As Boolean)
        'blnCancel = False
        If chkAgruparBanco.Checked Then
            '//Debemos comprobar que la forma de pago de los distintos pagos seleccionados no tengan la marca de Contabilidad en Vto.  activada, ya que 
            '//en este caso no podemos agrupar por Banco, salvo que tengan el mismo ejercicio entre ellos y/o el mismo que el que ha introducido el usuario.
            Dim objFilterOR As New Filter(FilterUnionOperator.Or)
            Dim objFilter As New Filter
            objFilter.Add(New BooleanFilterItem("ContabilidadEnVto", True))
            For Each drPagosVto As DataRow In mdtPagos.Select(objFilter.Compose(New AdoFilterComposer))
                objFilterOR.Add(New NumberFilterItem("IDPago", drPagosVto("IDPago")))
            Next

            '//Miramos el ejercicio de los Pagos con Contabilidad en Vto.
            Dim dt As DataTable = New BE.DataEngine().Filter("vPagosContabilidadEnVto", objFilterOR)
            If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
                Dim strIDEjercicioCont As String = String.Empty
                Dim strIDEjercicioAnt As String = String.Empty
                Dim dFechaVto, dFechaAnt As Date
                Dim adr() As DataRow
                For Each drPagosSel As DataRow In mdtPagos.Select(Nothing, "FechaVencimiento")
                    If Nz(drPagosSel("ContabilidadEnVto"), False) Then
                        objFilter.Clear()
                        objFilter.Add(New NumberFilterItem("IDPago", drPagosSel("IDPago")))
                        adr = dt.Select(objFilter.Compose(New AdoFilterComposer))
                        If Not IsNothing(adr) AndAlso adr.Length > 0 Then
                            strIDEjercicioCont = adr(0)("IDEjercicio") & String.Empty
                        Else
                            strIDEjercicioCont = cbxIDEjercicio.Value
                        End If
                        dFechaVto = Format(drPagosSel("FechaVencimiento"), "dd/MM/yyyy")
                    Else
                        strIDEjercicioCont = cbxIDEjercicio.Value
                        dFechaVto = Format(cbxFechaApunte.Value, "dd/MM/yyyy")
                    End If

                    If Length(strIDEjercicioAnt) = 0 Then strIDEjercicioAnt = strIDEjercicioCont
                    If dFechaAnt = cnMinDate Then dFechaAnt = dFechaVto
                    If strIDEjercicioCont <> strIDEjercicioAnt OrElse dFechaVto <> dFechaAnt Then
                        blnCancel = True
                        ExpertisApp.GenerateMessage("Los pagos seleccionados no se pueden contabilizar agrupando por Banco. Compruebe su Forma de Pago.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit For
                    End If
                    strIDEjercicioAnt = strIDEjercicioCont
                    dFechaAnt = dFechaVto
                Next
            End If
        End If
    End Sub

    Protected Overridable Sub ComprobarPagosRemesados(ByRef blnCancel As Boolean)
        If blnCancel Then Exit Sub

        If chkGeneraRemesa.Checked Then
            Dim f As New Filter
            f.Add(New IsNullFilterItem("IdRemesa", False))
            Dim WhereRemesados As String = f.Compose(New AdoFilterComposer)
            Dim adr() As DataRow = mdtPagos.Select(WhereRemesados)
            If Not adr Is Nothing AndAlso adr.Length > 0 Then
                ExpertisApp.GenerateMessage("Revise los Pagos seleccionados. No se pueden remesar Pagos ya remesados.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                blnCancel = True
            End If
        End If
    End Sub

    Private Sub GenerarFichero()
        Dim TipoFichero As enumFormatoFicheroSEPA = enumFormatoFicheroSEPA.XML
        If rbtGenerarFichero34.Checked Then
            mintTipoFichero = enumFichRemesaPago.CSB34
        ElseIf rbtGenerarFichero341.Checked Then
            mintTipoFichero = enumFichRemesaPago.CSB341
        ElseIf rbtGenerarFichero3414.Checked Then
            mintTipoFichero = Business.SEPA.BusinessEnum.enumFichRemesaPago.CSB3414
            TipoFichero = Me.CmbTipoFicheroSEPA.Value
            ' GenerarFicheroTransferencia(mintTipoFichero, cbxBancoPropio.Value & String.Empty, mstrRutaFicheroSEPA, Nz(Me.ClbFechaEmision.Value, Date.Today), TipoFichero)
            Dim FechaEmision As Date
            If TipoFichero = enumFormatoFicheroSEPA.XML Then
                FechaEmision = Nz(Me.ClbFechaEmision.Value, cnMinDate)
            Else
                FechaEmision = Nz(Me.ClbFechaEmision.Value, Today)
            End If
            GenerarFicheroTransferencia(mintTipoFichero, cbxBancoPropio.Value & String.Empty, mstrRutaFicheroSEPA, FechaEmision, TipoFichero)

            Exit Sub
        ElseIf rbtGenerarFichero68.Checked Then
            mintTipoFichero = enumFichRemesaPago.CSB68
        ElseIf rbtGenerarConfirming.Checked Then
            mintTipoFichero = enumFichRemesaPago.Confirming
        End If

        If mintTipoFichero <> -1 Then GenerarFicheroTransferencia(mintTipoFichero, cbxBancoPropio.Value & String.Empty, mstrRuta, Nz(Me.ClbFechaEmision.Value, Date.Today))
    End Sub

    Private Sub GenerarRemesa()
        If chkGeneraRemesa.Checked Then GeneraRemesa()
    End Sub

    Private Sub GeneraRemesa()
        mblnRemesaGenerada = False
        If Length(cbxFechaApunte.Value) > 0 Then
            If (rbtGenerarConfirming.Checked Or rbtGenerarFichero34.Checked Or rbtGenerarFichero341.Checked Or rbtGenerarFichero68.Checked) And Len(cbxBancoPropio.Value) = 0 Then
                ExpertisApp.GenerateMessage("El Banco Propio es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim data As New Hashtable
                data("IdProcess") = mIDProcess
                data("FechaRemesa") = cbxFechaApunte.Value
                data("TipoFichero") = mintTipoFichero
                data("IDBancoPropio") = cbxBancoPropio.Value
                data("Ruta") = mstrRuta
                data("NuevaSituacion") = cbxSituacion.Value
                ExpertisApp.GenerateMessage("Los Pagos que estén remesados no entrarán en el proceso.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ExpertisApp.ExecuteTask(Of Hashtable)(AddressOf RemesaPago.AddRemesa, data)
                mblnRemesaGenerada = True
            End If
        Else
            ExpertisApp.GenerateMessage("Debe introducir una fecha para la remesa.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'Private Sub CambioSituacion()
    '    If Not Me.mblnCambioSituacionManual Then
    '        Dim fwnPago As New Pago
    '        fwnPago.CambioSituacion(mdtPagos, Nz(cbxSituacion.Value, -1))
    '    End If
    'End Sub

    Protected Overridable Sub Imprimir()
        If chkImprimir.Checked Then
            If Length(cbxTipoInforme.Value) > 0 Then
                Dim NuevaSituacion As Integer = enumPagoSituacion.EnviadoTalonPagare

                Dim StrNameReport As String = String.Empty
                Select Case CInt(cbxTipoInforme.Value)
                    Case enumTipoImpresoPago.tipDomiciliacion
                        StrNameReport = "LPAGODOM" '"PagoDomiciliado.rpt"
                        NuevaSituacion = Nz(Me.cbxSituacion.Value, -1)
                    Case enumTipoImpresoPago.tipChequePorBanco
                        StrNameReport = "LPAGOCHEQ" '"PagoChequeBanco.rpt"
                    Case enumTipoImpresoPago.tipCheque
                        StrNameReport = "LPAGOCHEQS" '"PagoCheques.rpt"
                    Case enumTipoImpresoPago.tipPagare
                        StrNameReport = "LPAGOPAGA" '"PagoPagare.rpt"
                End Select
                Dim oRpt As New Report(StrNameReport)
                Dim blnImprimir As Boolean = True
                Dim dv As DataView = mdtPagos.DefaultView
                dv.RowFilter = "Impreso=1"
                If dv.Count > 0 Then
                    If ExpertisApp.GenerateMessage("Hay Pagos seleccionados que ya están impresos. ¿Desea Continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.No Then
                        blnImprimir = False
                    End If
                End If
                If blnImprimir Then
                    oRpt.Filter.UnionOperator = FilterUnionOperator.Or
                    Dim IDPagos(-1) As Object
                    For Each dr As DataRow In mdtPagos.Select
                        oRpt.Filter.Add(New NumberFilterItem("IDPago", dr("IDPago")))

                        ReDim Preserve IDPagos(IDPagos.Length)
                        IDPagos(IDPagos.Length - 1) = dr("IDPago")
                    Next
                    Dim IDBancoPropio As String = String.Empty
                    If Not chkGeneraRemesa.Checked Then
                        IDBancoPropio = cbxBancoPropio.Value & String.Empty
                    End If
                    Dim datActPagos As New Pago.DataImpresionPagos(IDPagos, IDBancoPropio, cbxTipoInforme.Value = CInt(enumTipoImpresoPago.tipPagare), NuevaSituacion)
                    ExpertisApp.ExecuteTask(Of Pago.DataImpresionPagos)(AddressOf Pago.ImpresionPagos, datActPagos)
                    'If Not chkGeneraRemesa.Checked Then
                    '    Dim ClsPago As New Pago
                    '    ClsPago.Update(mdtPagos)
                    'End If
                    'Dim BEDataEngine As New BE.DataEngine
                    'If cbxTipoInforme.Value = CInt(enumTipoImpresoPago.tipPagare) Then
                    '    ' oRpt.DataSource = mdtPagos
                    '    Dim p As New Pago
                    '    p.Update(mdtPagos)
                    'End If
                    'mblnPagoImpreso = True
                    ExpertisApp.OpenReport(oRpt)
                End If
            End If
        End If
    End Sub

    Private Sub cmbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        mblnTransferencia = False
        mblnConfirming = False
        'mblnPagoImpreso = False
        If Not ValidarOpciones() Then
            Me.DialogResult = DialogResult.OK
            mblnCancel = False

            GenerarFichero()
            GenerarRemesa()
            'CambioSituacion()
            'If Not Me.chkGenerarAsiento.Checked AndAlso Not Me.chkGenerarAsientoEfectos.Checked Then
            CambioBancoPropio()
            'End If
            Imprimir()

            Me.Close()
        Else
            mblnCancel = True
        End If
    End Sub

    Private Sub CambioBancoPropio()
        If Length(cbxBancoPropio.Value) > 0 Then
            Dim datosCambio As New Pago.DataCambioBancoPropio
            datosCambio.Pagos = mdtPagos
            datosCambio.NuevoBancoPropio = cbxBancoPropio.Value
            ExpertisApp.ExecuteTask(Of Pago.DataCambioBancoPropio)(AddressOf Pago.CambioBancoPropio, datosCambio)
        End If
    End Sub

    Private Sub cmbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

#End Region

#Region " Opciones Generar Fichero "

    Private Sub rbtGenerarFichero34_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtGenerarFichero34.CheckedChanged
        If rbtGenerarFichero34.Checked Then
            'If PagosImporteNegativo(mdtPagos) Then
            '    sender.Checked = False
            '    Exit Sub
            'End If
            SaveFileDialog1.Filter = String.Empty
            SaveFileDialog1.ShowDialog()
            mstrRuta = SaveFileDialog1.FileName
            If Length(mstrRuta) = 0 Then rbtGenerarFichero34.Checked = 0
            cmbAceptar.Enabled = True
            rbtGenerarFichero3414.Checked = False
            rbtGenerarFichero68.Checked = False
            rbtGenerarConfirming.Checked = False
        Else
            mstrRuta = String.Empty
        End If
    End Sub

    Private Sub rbtGenerarFichero341_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtGenerarFichero341.CheckedChanged
        If rbtGenerarFichero341.Checked Then
            'If PagosImporteNegativo(mdtPagos) Then
            '    sender.Checked = False
            '    Exit Sub
            'End If
            SaveFileDialog1.Filter = String.Empty
            SaveFileDialog1.ShowDialog()
            mstrRuta = SaveFileDialog1.FileName
            If Length(mstrRuta) = 0 Then rbtGenerarFichero341.Checked = False
            cmbAceptar.Enabled = True
            rbtGenerarFichero3414.Checked = False
            rbtGenerarFichero68.Checked = False
            rbtGenerarConfirming.Checked = False
        Else
            mstrRuta = String.Empty
        End If
    End Sub

    Private Sub rbtGenerarFichero3414_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtGenerarFichero3414.CheckedChanged
        If rbtGenerarFichero3414.Checked Then
            'If PagosImporteNegativo(mdtPagos) Then
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
            mstrRutaFicheroSEPA = SaveFileDialog1.FileName
            If Length(mstrRutaFicheroSEPA) = 0 Then rbtGenerarFichero3414.Checked = False
            cmbAceptar.Enabled = True

            rbtGenerarFichero68.Checked = False
            rbtGenerarConfirming.Checked = False
            rbtGenerarFichero34.Checked = False
            rbtGenerarFichero341.Checked = False
        Else
            mstrRutaFicheroSEPA = String.Empty
        End If
    End Sub

    Private Sub rbtGenerarFichero68_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtGenerarFichero68.CheckedChanged
        If rbtGenerarFichero68.Checked Then
            'If PagosImporteNegativo(mdtPagos) Then
            '    sender.Checked = False
            '    Exit Sub
            'End If
            SaveFileDialog1.Filter = String.Empty
            SaveFileDialog1.ShowDialog()
            mstrRuta = SaveFileDialog1.FileName
            If Length(mstrRuta) = 0 Then rbtGenerarFichero68.Checked = False
            cmbAceptar.Enabled = True

            rbtGenerarFichero3414.Checked = False
            'rbtGenerarConfirming.Checked = False
            rbtGenerarFichero34.Checked = False
            rbtGenerarFichero341.Checked = False
        Else
            mstrRuta = String.Empty
        End If

    End Sub

    Private Sub rbtGenerarConfirming_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtGenerarConfirming.CheckedChanged
        If rbtGenerarConfirming.Checked Then
            'If PagosImporteNegativo(mdtPagos) Then
            '    sender.Checked = False
            '    Exit Sub
            'End If
            SaveFileDialog1.Filter = String.Empty
            SaveFileDialog1.ShowDialog()
            mstrRuta = SaveFileDialog1.FileName
            If Length(mstrRuta) = 0 Then rbtGenerarConfirming.Checked = False
            cmbAceptar.Enabled = True
            rbtGenerarFichero3414.Checked = False
            rbtGenerarFichero34.Checked = False
            rbtGenerarFichero341.Checked = False
        Else
            mstrRuta = String.Empty
        End If
    End Sub

#End Region


    Private Sub cbxFechaApunte_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxFechaApunte.Validated
        If Engine.Length(cbxFechaApunte.Value) > 0 Then
            Dim dtFechaApunte As Date = cbxFechaApunte.Value
            If mblnEspecial Then
                cbxIDEjercicio.Value = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.PredeterminadoB, dtFechaApunte)
            Else
                cbxIDEjercicio.Value = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, dtFechaApunte)
            End If
        Else
            cbxIDEjercicio.Value = System.DBNull.Value
        End If
    End Sub

    Private Sub chkGenerarAsiento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGenerarAsiento.CheckedChanged
        If Length(cbxTipoInforme.Value) > 0 AndAlso (cbxTipoInforme.Value = enumTipoImpresoPago.tipCheque OrElse cbxTipoInforme.Value = enumTipoImpresoPago.tipPagare) Then
            chkGenerarAsientoTalon.Checked = Not chkGenerarAsiento.Checked
            chkGenerarAsientoTalon.Enabled = Not chkGenerarAsiento.Checked
        End If
        If chkGenerarAsiento.Checked Then
            chkGenerarAsientoEfectos.Checked = False
        End If
        If chkGenerarAsiento.Checked Then cmbAceptar.Enabled = True
        SetNuevaSituacion()
    End Sub

    Protected Sub SetNuevaSituacion()
        If Not cbxSituacion.Enabled Then Exit Sub

        If chkGenerarAsiento.Checked Then
            cbxSituacion.Value = mSituacionContaInit
        ElseIf chkGenerarAsientoTalon.Checked OrElse _
              (chkImprimir.Checked AndAlso Nz(cbxTipoInforme.Value, enumTipoImpresoPago.tipDomiciliacion) <> enumTipoImpresoPago.tipDomiciliacion) Then
            cbxSituacion.Value = mSituacionPagare
        Else
            cbxSituacion.Value = mSituacionSinContaDefault
        End If
    End Sub

    Private Sub chkGeneraRemesa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGeneraRemesa.CheckedChanged
        If chkGeneraRemesa.Checked Then cmbAceptar.Enabled = True
    End Sub

    Private Sub chkImprimir_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkImprimir.CheckedChanged
        If chkImprimir.Checked Then
            cmbAceptar.Enabled = True
            cbxTipoInforme.Enabled = True
        Else
            cbxTipoInforme.Value = String.Empty
            cbxTipoInforme.Enabled = False
            chkGenerarAsientoTalon.Checked = False
        End If
        SetNuevaSituacion()
    End Sub

    Private Sub cbxTipoInforme_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxTipoInforme.Validated
        Dim blnChecked As Boolean = ((cbxTipoInforme.Value = enumTipoImpresoPago.tipCheque Or cbxTipoInforme.Value = enumTipoImpresoPago.tipPagare))
        If chkGenerarAsiento.Checked Then
            chkGenerarAsiento.Checked = False
        End If
        chkGenerarAsientoTalon.Enabled = blnChecked
        chkGenerarAsientoTalon.Checked = False
        chkGenerarAsientoEfectos.Checked = False

        SetNuevaSituacion()
    End Sub

    Private Sub frmContabilizar_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = mblnCancel
        mblnCancel = False
    End Sub

    Private Sub chkGenerarAsientoEfectos_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkGenerarAsientoEfectos.CheckedChanged
        If chkGenerarAsientoEfectos.Checked Then
            chkGenerarAsientoTalon.Checked = False
            chkGenerarAsiento.Checked = False
        End If
        SetNuevaSituacion()
    End Sub

    Private Sub chkGenerarAsientoTalon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGenerarAsientoTalon.CheckedChanged
        If chkGenerarAsientoTalon.Checked Then
            chkGenerarAsientoEfectos.Checked = False
            chkGenerarAsiento.Checked = False
        End If
        SetNuevaSituacion()
    End Sub

    Private Sub txtCContable_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCContable.TextChanged
        GetMonedaDivisa()
    End Sub

    Protected Overridable Sub GetMonedaDivisa()
        If Length(Me.txtCContable.Text) > 0 AndAlso Length(Me.cbxIDEjercicio.Value) > 0 Then
            Dim datDivisa As New FinancieroGeneral.DataGetDivisaCuenta(Me.cbxIDEjercicio.Value, Me.txtCContable.Text)
            Me.ulblIDDivisa.Text = ExpertisApp.ExecuteTask(Of FinancieroGeneral.DataGetDivisaCuenta, String)(AddressOf FinancieroGeneral.GetDivisaCuenta, datDivisa)
        End If
    End Sub

    Private Sub cbxIDEjercicio_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxIDEjercicio.ValueChanged
        GetMonedaDivisa()
    End Sub

    Private Sub ulblIDDivisa_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ulblIDDivisa.TextChanged
        txtImporteBanco.Enabled = (Length(ulblIDDivisa.Text) = 0)
        chkGenerarDifCambio.Enabled = (Length(ulblIDDivisa.Text) > 0)
        If Not txtImporteBanco.Enabled Then Me.txtImporteBanco.Text = 0
        If Not chkGenerarDifCambio.Enabled Then chkGenerarDifCambio.Checked = False
    End Sub


    Private Sub txtComision_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtComision.Validated
        If Nz(txtComision.Value, 0) <> 0 Then
            Me.chkAgruparBanco.Checked = True
        End If
    End Sub

    Protected Overridable Sub CmbTipoFicheroSEPA_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbTipoFicheroSEPA.ValueChanged
        lblNota.Visible = (CmbTipoFicheroSEPA.Value = enumFormatoFicheroSEPA.XML)
    End Sub

End Class
