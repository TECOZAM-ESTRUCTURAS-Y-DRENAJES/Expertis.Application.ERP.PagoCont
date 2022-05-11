Imports Solmicro.Expertis.Business.General
Imports Solmicro.Expertis.Business.Negocio

Public Class frmDesglosarPagos
    Inherits Solmicro.Expertis.Engine.UI.FormBase

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.Grid.RelationMode = RelationMode.NoRelation
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
    Friend WithEvents lblFwiImporteTotal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Panel2 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents ulDescFPago As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ulDescBanco As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents lblFwiIdFormaPago As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFwiIdFactura As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFwiImporteVto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents lblProveedor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblBanco As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaVto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblImporteVtoA As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtImporteTotal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtAbreviatura As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtIDProveedor As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtBanco As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtFechaVto As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtFactura As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtIdFormaPago As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtImporteVtoA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImporteVto As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtTitulo As Solmicro.Expertis.Engine.UI.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDesglosarPagos))
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblFwiImporteTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.txtImporteTotal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Panel2 = New Solmicro.Expertis.Engine.UI.Panel
        Me.ulDescFPago = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulDescBanco = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblFwiIdFormaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFwiIdFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.lblProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.lblBanco = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaVto = New Solmicro.Expertis.Engine.UI.Label
        Me.lblImporteVtoA = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFwiImporteVto = New Solmicro.Expertis.Engine.UI.Label
        Me.txtAbreviatura = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtIDProveedor = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtBanco = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtFechaVto = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtFactura = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtIdFormaPago = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtImporteVtoA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImporteVto = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtTitulo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel1.suspendlayout()
        Me.Panel2.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblFwiImporteTotal)
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Controls.Add(Me.txtImporteTotal)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 277)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(640, 40)
        Me.Panel1.TabIndex = 20
        '
        'lblFwiImporteTotal
        '
        Me.lblFwiImporteTotal.Location = New System.Drawing.Point(7, 10)
        Me.lblFwiImporteTotal.Name = "lblFwiImporteTotal"
        Me.lblFwiImporteTotal.Size = New System.Drawing.Size(112, 13)
        Me.lblFwiImporteTotal.TabIndex = 16
        Me.lblFwiImporteTotal.Tag = "IdRec=9445;"
        Me.lblFwiImporteTotal.Text = "Total Importe Vto."
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(459, 6)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(85, 28)
        Me.cmbAceptar.TabIndex = 13
        Me.cmbAceptar.Text = "Aceptar"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Location = New System.Drawing.Point(549, 6)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(85, 28)
        Me.cmbCancelar.TabIndex = 14
        Me.cmbCancelar.Text = "Cancelar"
        '
        'txtImporteTotal
        '
        Me.txtImporteTotal.DisabledBackColor = System.Drawing.Color.White
        Me.txtImporteTotal.Enabled = False
        Me.txtImporteTotal.Location = New System.Drawing.Point(143, 10)
        Me.txtImporteTotal.Name = "txtImporteTotal"
        Me.txtImporteTotal.Size = New System.Drawing.Size(114, 21)
        Me.txtImporteTotal.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ulDescFPago)
        Me.Panel2.Controls.Add(Me.ulDescBanco)
        Me.Panel2.Controls.Add(Me.lblFwiIdFormaPago)
        Me.Panel2.Controls.Add(Me.lblFwiIdFactura)
        Me.Panel2.Controls.Add(Me.lblProveedor)
        Me.Panel2.Controls.Add(Me.lblBanco)
        Me.Panel2.Controls.Add(Me.lblFechaVto)
        Me.Panel2.Controls.Add(Me.lblImporteVtoA)
        Me.Panel2.Controls.Add(Me.lblFwiImporteVto)
        Me.Panel2.Controls.Add(Me.txtAbreviatura)
        Me.Panel2.Controls.Add(Me.txtIDProveedor)
        Me.Panel2.Controls.Add(Me.txtBanco)
        Me.Panel2.Controls.Add(Me.txtFechaVto)
        Me.Panel2.Controls.Add(Me.txtFactura)
        Me.Panel2.Controls.Add(Me.txtIdFormaPago)
        Me.Panel2.Controls.Add(Me.txtImporteVtoA)
        Me.Panel2.Controls.Add(Me.txtImporteVto)
        Me.Panel2.Controls.Add(Me.txtTitulo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(640, 80)
        Me.Panel2.TabIndex = 21
        '
        'ulDescFPago
        '
        Me.ulDescFPago.Location = New System.Drawing.Point(536, 30)
        Me.ulDescFPago.Name = "ulDescFPago"
        Me.ulDescFPago.Size = New System.Drawing.Size(96, 21)
        Me.ulDescFPago.TabIndex = 37
        '
        'ulDescBanco
        '
        Me.ulDescBanco.Location = New System.Drawing.Point(160, 30)
        Me.ulDescBanco.Name = "ulDescBanco"
        Me.ulDescBanco.Size = New System.Drawing.Size(222, 21)
        Me.ulDescBanco.TabIndex = 36
        '
        'lblFwiIdFormaPago
        '
        Me.lblFwiIdFormaPago.Location = New System.Drawing.Point(400, 30)
        Me.lblFwiIdFormaPago.Name = "lblFwiIdFormaPago"
        Me.lblFwiIdFormaPago.Size = New System.Drawing.Size(75, 13)
        Me.lblFwiIdFormaPago.TabIndex = 35
        Me.lblFwiIdFormaPago.Text = "Forma Pago"
        '
        'lblFwiIdFactura
        '
        Me.lblFwiIdFactura.Location = New System.Drawing.Point(400, 6)
        Me.lblFwiIdFactura.Name = "lblFwiIdFactura"
        Me.lblFwiIdFactura.Size = New System.Drawing.Size(49, 13)
        Me.lblFwiIdFactura.TabIndex = 34
        Me.lblFwiIdFactura.Text = "Factura"
        '
        'lblProveedor
        '
        Me.lblProveedor.Location = New System.Drawing.Point(4, 6)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(66, 13)
        Me.lblProveedor.TabIndex = 21
        Me.lblProveedor.Tag = "IdRec=4352;"
        Me.lblProveedor.Text = "Proveedor"
        '
        'lblBanco
        '
        Me.lblBanco.Location = New System.Drawing.Point(4, 30)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(42, 13)
        Me.lblBanco.TabIndex = 23
        Me.lblBanco.Tag = "IdRec=4607;"
        Me.lblBanco.Text = "Banco"
        '
        'lblFechaVto
        '
        Me.lblFechaVto.Location = New System.Drawing.Point(4, 54)
        Me.lblFechaVto.Name = "lblFechaVto"
        Me.lblFechaVto.Size = New System.Drawing.Size(67, 13)
        Me.lblFechaVto.TabIndex = 26
        Me.lblFechaVto.Tag = ""
        Me.lblFechaVto.Text = "Fecha Vto."
        '
        'lblImporteVtoA
        '
        Me.lblImporteVtoA.Location = New System.Drawing.Point(198, 54)
        Me.lblImporteVtoA.Name = "lblImporteVtoA"
        Me.lblImporteVtoA.Size = New System.Drawing.Size(92, 13)
        Me.lblImporteVtoA.TabIndex = 30
        Me.lblImporteVtoA.Tag = ""
        Me.lblImporteVtoA.Text = "Importe Vto. A"
        '
        'lblFwiImporteVto
        '
        Me.lblFwiImporteVto.Location = New System.Drawing.Point(400, 54)
        Me.lblFwiImporteVto.Name = "lblFwiImporteVto"
        Me.lblFwiImporteVto.Size = New System.Drawing.Size(80, 13)
        Me.lblFwiImporteVto.TabIndex = 32
        Me.lblFwiImporteVto.Tag = ""
        Me.lblFwiImporteVto.Text = "Importe Vto."
        '
        'txtAbreviatura
        '
        Me.txtAbreviatura.DisabledBackColor = System.Drawing.Color.White
        Me.txtAbreviatura.Enabled = False
        Me.txtAbreviatura.Location = New System.Drawing.Point(573, 54)
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(25, 21)
        Me.txtAbreviatura.TabIndex = 20
        '
        'txtIDProveedor
        '
        Me.txtIDProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDProveedor.Enabled = False
        Me.txtIDProveedor.Location = New System.Drawing.Point(68, 6)
        Me.txtIDProveedor.Name = "txtIDProveedor"
        Me.txtIDProveedor.Size = New System.Drawing.Size(90, 21)
        Me.txtIDProveedor.TabIndex = 22
        '
        'txtBanco
        '
        Me.txtBanco.DisabledBackColor = System.Drawing.Color.White
        Me.txtBanco.Enabled = False
        Me.txtBanco.Location = New System.Drawing.Point(68, 30)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(90, 21)
        Me.txtBanco.TabIndex = 24
        '
        'txtFechaVto
        '
        Me.txtFechaVto.DisabledBackColor = System.Drawing.Color.White
        Me.txtFechaVto.Enabled = False
        Me.txtFechaVto.Location = New System.Drawing.Point(68, 54)
        Me.txtFechaVto.Name = "txtFechaVto"
        Me.txtFechaVto.Size = New System.Drawing.Size(90, 21)
        Me.txtFechaVto.TabIndex = 25
        '
        'txtFactura
        '
        Me.txtFactura.DisabledBackColor = System.Drawing.Color.White
        Me.txtFactura.Enabled = False
        Me.txtFactura.Location = New System.Drawing.Point(480, 6)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(120, 21)
        Me.txtFactura.TabIndex = 27
        '
        'txtIdFormaPago
        '
        Me.txtIdFormaPago.DisabledBackColor = System.Drawing.Color.White
        Me.txtIdFormaPago.Enabled = False
        Me.txtIdFormaPago.Location = New System.Drawing.Point(480, 30)
        Me.txtIdFormaPago.Name = "txtIdFormaPago"
        Me.txtIdFormaPago.Size = New System.Drawing.Size(53, 21)
        Me.txtIdFormaPago.TabIndex = 28
        '
        'txtImporteVtoA
        '
        Me.txtImporteVtoA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImporteVtoA.Enabled = False
        Me.txtImporteVtoA.Location = New System.Drawing.Point(288, 54)
        Me.txtImporteVtoA.Name = "txtImporteVtoA"
        Me.txtImporteVtoA.Size = New System.Drawing.Size(94, 21)
        Me.txtImporteVtoA.TabIndex = 29
        '
        'txtImporteVto
        '
        Me.txtImporteVto.DisabledBackColor = System.Drawing.Color.White
        Me.txtImporteVto.Enabled = False
        Me.txtImporteVto.Location = New System.Drawing.Point(480, 54)
        Me.txtImporteVto.Name = "txtImporteVto"
        Me.txtImporteVto.Size = New System.Drawing.Size(90, 21)
        Me.txtImporteVto.TabIndex = 31
        '
        'txtTitulo
        '
        Me.txtTitulo.DisabledBackColor = System.Drawing.Color.White
        Me.txtTitulo.Enabled = False
        Me.txtTitulo.Location = New System.Drawing.Point(160, 6)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(222, 21)
        Me.txtTitulo.TabIndex = 33
        '
        'Grid
        '
        Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDFormaPago", "FormaPago", "IDFormaPago", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescFormaPago", "DescFormaPago")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDBancoPropio", "BancoPropio", "IDBancoPropio")})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid.EntityName = Nothing
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.Location = New System.Drawing.Point(0, 80)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.SecondaryDataFields = Nothing
        Me.Grid.Size = New System.Drawing.Size(640, 197)
        Me.Grid.TabIndex = 22
        Me.Grid.Tag = "IdRec=4712:4394:4755:4713:4756:;"
        Me.Grid.ViewName = Nothing
        '
        'frmDesglosarPagos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(640, 317)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmDesglosarPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desglosar Pago"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Protected MonInfo As MonedaInfo
    Protected MonInfoA As MonedaInfo
    Protected MonInfoB As MonedaInfo

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.AllRecords
        End Get
    End Property

    Private mintIDPago As Integer

    Public Function AbrirDesglosePago(ByVal dtPago As DataTable, ByVal OwnerForm As FormBase) As DialogResult
        With Grid
            .EntityName = "Pago"
            .ViewName = "frmDesglosarPago"
            Dim f As New Filter

            f.Add(New IsNullFilterItem("IDPago"))

            .Filter = f

            mintIDPago = dtPago.Rows(0)("IDPago")

            txtIDProveedor.Text = dtPago.Rows(0)("IDProveedor") & String.Empty
            txtTitulo.Text = dtPago.Rows(0)("Titulo") & String.Empty
            txtBanco.Text = dtPago.Rows(0)("IDBancoPropio") & String.Empty
            ulDescBanco.Text = dtPago.Rows(0)("DescBancoPropio") & String.Empty
            txtFechaVto.Text = dtPago.Rows(0)("FechaVencimiento")
            txtImporteVtoA.Text = dtPago.Rows(0)("ImpVencimientoA")
            txtImporteVto.Text = dtPago.Rows(0)("ImpVencimiento")
            txtFactura.Text = dtPago.Rows(0)("NFactura") & String.Empty
            txtIdFormaPago.Text = dtPago.Rows(0)("IdFormaPago") & String.Empty
            ulDescFPago.Text = dtPago.Rows(0)("DescFormaPago") & String.Empty
            txtAbreviatura.Text = dtPago.Rows(0)("AbrvMoneda") & String.Empty



            Dim FechaVencimiento As Date = txtFechaVto.Text
            Dim datMon As New Moneda.DatosObtenerMoneda
            datMon.IDMoneda = dtPago.Rows(0)("IDMoneda")
            datMon.Fecha = FechaVencimiento

            MonInfo = ExpertisApp.ExecuteTask(Of Moneda.DatosObtenerMoneda, MonedaInfo)(AddressOf Moneda.ObtenerMoneda, datMon)
            MonInfoA = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaA, FechaVencimiento)
            MonInfoB = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaB, FechaVencimiento)

            .Columns("IDFactura").DefaultValue = dtPago.Rows(0)("IDFactura")
            .Columns("NFactura").DefaultValue = dtPago.Rows(0)("NFactura")
            .Columns("CContable").DefaultValue = dtPago.Rows(0)("CContable")
            .Columns("IDProveedor").DefaultValue = dtPago.Rows(0)("IDProveedor")
            .Columns("Titulo").DefaultValue = dtPago.Rows(0)("Titulo")
            .Columns("FechaVencimiento").DefaultValue = dtPago.Rows(0)("FechaVencimiento")
            .Columns("IdFormaPago").DefaultValue = dtPago.Rows(0)("IdFormaPago")
            .Columns("DescFormaPago").DefaultValue = dtPago.Rows(0)("DescFormaPago")
            .Columns("IDBancoPropio").DefaultValue = dtPago.Rows(0)("IDBancoPropio")
            .Columns("Situacion").DefaultValue = dtPago.Rows(0)("Situacion")
            .Columns("Contabilizado").DefaultValue = dtPago.Rows(0)("Contabilizado")
            .Columns("IDMoneda").DefaultValue = dtPago.Rows(0)("IDMoneda")
            .Columns("CambioA").DefaultValue = dtPago.Rows(0)("CambioA")
            .Columns("CambioB").DefaultValue = dtPago.Rows(0)("CambioB")
            .Columns("IdProveedorBanco").DefaultValue = dtPago.Rows(0)("IdProveedorBanco")
            .Columns("IDTipoPago").DefaultValue = dtPago.Rows(0)("IDTipoPago")
            .Columns("IDDireccion").DefaultValue = dtPago.Rows(0)("IDdireccion")

            .Columns("ImpVencimiento").DefaultValue = Nz(txtImporteVto.Text, 0) - Nz(txtImporteTotal.Text, 0)
            .Columns("ImpVencimientoA").DefaultValue = .Columns("ImpVencimiento").DefaultValue * .Columns("CambioA").DefaultValue
            .Columns("ImpVencimientoB").DefaultValue = .Columns("ImpVencimiento").DefaultValue * .Columns("CambioB").DefaultValue

            .Columns("Texto").DefaultValue = dtPago.Rows(0)("Texto")
        End With

        Me.ShowDialog(OwnerForm)

        Return Me.DialogResult
    End Function

    Private Sub frmDesglosarPagos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtImporteTotal.Text = Grid.GetTotal(Grid.Columns("ImpVencimiento"), Janus.Windows.GridEX.AggregateFunction.Sum)
    End Sub

    Private Sub Grid_Added_Deleted_Updated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.RecordAdded, Grid.RecordUpdated, Grid.RecordsDeleted
        txtImporteTotal.Text = Grid.GetTotal(Grid.Columns("ImpVencimiento"), Janus.Windows.GridEX.AggregateFunction.Sum)
        With Grid
            Dim ImpRestante As Double = xRound(Nz(txtImporteVto.Text, 0) - Nz(txtImporteTotal.Text, 0), MonInfo.NDecimalesImporte)
            If ImpRestante <> 0 Then
                Dim drNew As DataRow = CType(Grid.DataSource, DataTable).NewRow
                For Each col As DataColumn In CType(Grid.DataSource, DataTable).Columns
                    If Grid.Columns.Contains(col.ColumnName) Then
                        drNew(col.ColumnName) = Grid.Columns(col.ColumnName).DefaultValue
                    End If
                Next
                drNew("ImpVencimiento") = ImpRestante
                drNew("ImpVencimientoA") = xRound(drNew("ImpVencimiento") * drNew("CambioA"), MonInfoA.NDecimalesImporte)
                drNew("ImpVencimientoB") = xRound(drNew("ImpVencimiento") * drNew("CambioB"), MonInfoB.NDecimalesImporte)

                CType(Grid.DataSource, DataTable).Rows.Add(drNew)
                Grid_Added_Deleted_Updated(sender, e)
            Else
                Grid.Columns("ImpVencimiento").DefaultValue = ImpRestante
                Grid.Columns("ImpVencimientoA").DefaultValue = 0
                Grid.Columns("ImpVencimientoB").DefaultValue = 0
            End If
        End With
    End Sub

    Private Function LineasCorrectas() As Boolean
        Dim blnOK As Boolean = True
        Dim dt As DataTable = Grid.DataSource

        For Each dr As DataRow In dt.Select
            If Length(dr("FechaVencimiento")) = 0 Or Length(dr("IdFormaPago")) = 0 Or Engine.Length(dr("ImpVencimiento")) = 0 Or Engine.Length(dr("ImpVencimientoA")) = 0 Then
                blnOK = False
                Exit For
            End If
        Next

        Return blnOK
    End Function

    Private Sub cmbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        If Grid.RecordCount > 0 Then
            'Se van a desglosar los Pagos seleccionados. ¿Desea continuar.?
            If ExpertisApp.GenerateMessage("Se van a desglosar los Pagos seleccionados. ¿Desea continuar.?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                If LineasCorrectas() Then
                    Dim blnOk As Boolean = True
                    If txtImporteVto.Text <> txtImporteTotal.Text Then
                        If ExpertisApp.GenerateMessage("El Importe del Pago Inicial no coincide con la suma de los Pagos que se crearán. ¿Desea continuar de todas formas?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No Then  'El Importe del Pago Inicial no coincide con la suma de los Pagos que se crearan. ¿Desea continuar de todas formas?
                            blnOk = False
                        End If
                    End If
                    If blnOk Then
                        Dim datos As New Pago.DataDesglosarPagos
                        datos.IDPagoDesglosar = mintIDPago
                        datos.NuevosPagos = Grid.DataSource
                        ExpertisApp.ExecuteTask(Of Pago.DataDesglosarPagos)(AddressOf Pago.DesglosarPagos, datos)
                        Me.Close()
                    End If
                Else
                    ExpertisApp.GenerateMessage("La Fecha Vencimiento, Forma Pago e Importe Vencimiento son obligatorios.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End If
    End Sub

    Private Sub cmbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.Close()
    End Sub
End Class
