Imports Janus.Windows.GridEX
Public Class frmModifPagos
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
    Friend WithEvents lblFwIFPagoNew As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFwIDBancoNew As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFwiFechaVtoNew As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiTitulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmdCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents FwIFPagoNew As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents FwIDBancoNew As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents FwiFechaVtoNew As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents fwiNFactura As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents fwiTitulo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblNFactura As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTexto As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModifPagos))
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTexto = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFwIFPagoNew = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFwIDBancoNew = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFwiFechaVtoNew = New Solmicro.Expertis.Engine.UI.Label
        Me.lblNFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiTitulo = New Solmicro.Expertis.Engine.UI.Label
        Me.cmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.FwIFPagoNew = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FwIDBancoNew = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FwiFechaVtoNew = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.fwiNFactura = New Solmicro.Expertis.Engine.UI.TextBox
        Me.fwiTitulo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel1.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtTexto)
        Me.Panel1.Controls.Add(Me.lblFwIFPagoNew)
        Me.Panel1.Controls.Add(Me.lblFwIDBancoNew)
        Me.Panel1.Controls.Add(Me.lblFwiFechaVtoNew)
        Me.Panel1.Controls.Add(Me.lblNFactura)
        Me.Panel1.Controls.Add(Me.lblfwiTitulo)
        Me.Panel1.Controls.Add(Me.cmdCancelar)
        Me.Panel1.Controls.Add(Me.cmdAceptar)
        Me.Panel1.Controls.Add(Me.FwIFPagoNew)
        Me.Panel1.Controls.Add(Me.FwIDBancoNew)
        Me.Panel1.Controls.Add(Me.FwiFechaVtoNew)
        Me.Panel1.Controls.Add(Me.fwiNFactura)
        Me.Panel1.Controls.Add(Me.fwiTitulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 213)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(648, 104)
        Me.Panel1.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(376, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Nuevo Texto"
        '
        'txtTexto
        '
        Me.txtTexto.DisabledBackColor = System.Drawing.Color.White
        Me.txtTexto.Location = New System.Drawing.Point(536, 81)
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(104, 21)
        Me.txtTexto.TabIndex = 32
        '
        'lblFwIFPagoNew
        '
        Me.lblFwIFPagoNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFwIFPagoNew.Location = New System.Drawing.Point(376, 55)
        Me.lblFwIFPagoNew.Name = "lblFwIFPagoNew"
        Me.lblFwIFPagoNew.Size = New System.Drawing.Size(133, 13)
        Me.lblFwIFPagoNew.TabIndex = 27
        Me.lblFwIFPagoNew.Text = "Nueva Forma de Pago"
        '
        'lblFwIDBancoNew
        '
        Me.lblFwIDBancoNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFwIDBancoNew.Location = New System.Drawing.Point(376, 31)
        Me.lblFwIDBancoNew.Name = "lblFwIDBancoNew"
        Me.lblFwIDBancoNew.Size = New System.Drawing.Size(122, 13)
        Me.lblFwIDBancoNew.TabIndex = 28
        Me.lblFwIDBancoNew.Text = "Nuevo Banco Propio"
        '
        'lblFwiFechaVtoNew
        '
        Me.lblFwiFechaVtoNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFwiFechaVtoNew.Location = New System.Drawing.Point(376, 7)
        Me.lblFwiFechaVtoNew.Name = "lblFwiFechaVtoNew"
        Me.lblFwiFechaVtoNew.Size = New System.Drawing.Size(153, 13)
        Me.lblFwiFechaVtoNew.TabIndex = 29
        Me.lblFwiFechaVtoNew.Text = "Nueva Fecha Vencimiento"
        '
        'lblNFactura
        '
        Me.lblNFactura.Location = New System.Drawing.Point(7, 11)
        Me.lblNFactura.Name = "lblNFactura"
        Me.lblNFactura.Size = New System.Drawing.Size(70, 13)
        Me.lblNFactura.TabIndex = 30
        Me.lblNFactura.Tag = ""
        Me.lblNFactura.Text = "Nº. Factura"
        '
        'lblfwiTitulo
        '
        Me.lblfwiTitulo.Location = New System.Drawing.Point(7, 36)
        Me.lblfwiTitulo.Name = "lblfwiTitulo"
        Me.lblfwiTitulo.Size = New System.Drawing.Size(38, 13)
        Me.lblfwiTitulo.TabIndex = 31
        Me.lblfwiTitulo.Tag = "IdRec=4711;"
        Me.lblfwiTitulo.Text = "Titulo"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.Location = New System.Drawing.Point(192, 64)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(104, 27)
        Me.cmdCancelar.TabIndex = 23
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAceptar.Location = New System.Drawing.Point(80, 64)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(104, 27)
        Me.cmdAceptar.TabIndex = 22
        Me.cmdAceptar.Text = "Aceptar"
        '
        'FwIFPagoNew
        '
        Me.FwIFPagoNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FwIFPagoNew.DisabledBackColor = System.Drawing.Color.White
        Me.FwIFPagoNew.EntityName = "FormaPago"
        Me.FwIFPagoNew.Location = New System.Drawing.Point(536, 55)
        Me.FwIFPagoNew.Name = "FwIFPagoNew"
        Me.FwIFPagoNew.SecondaryDataFields = "IDFormaPago"
        Me.FwIFPagoNew.Size = New System.Drawing.Size(104, 23)
        Me.FwIFPagoNew.TabIndex = 26
        Me.FwIFPagoNew.ViewName = "tbMaestroFormaPago"
        '
        'FwIDBancoNew
        '
        Me.FwIDBancoNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FwIDBancoNew.DisabledBackColor = System.Drawing.Color.White
        Me.FwIDBancoNew.EntityName = "BancoPropio"
        Me.FwIDBancoNew.Location = New System.Drawing.Point(536, 31)
        Me.FwIDBancoNew.Name = "FwIDBancoNew"
        Me.FwIDBancoNew.SecondaryDataFields = "IDBancoPropio"
        Me.FwIDBancoNew.Size = New System.Drawing.Size(104, 23)
        Me.FwIDBancoNew.TabIndex = 21
        Me.FwIDBancoNew.ViewName = "tbMaestroBancoPropio"
        '
        'FwiFechaVtoNew
        '
        Me.FwiFechaVtoNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FwiFechaVtoNew.DisabledBackColor = System.Drawing.Color.White
        Me.FwiFechaVtoNew.Location = New System.Drawing.Point(536, 7)
        Me.FwiFechaVtoNew.Name = "FwiFechaVtoNew"
        Me.FwiFechaVtoNew.Size = New System.Drawing.Size(104, 21)
        Me.FwiFechaVtoNew.TabIndex = 20
        '
        'fwiNFactura
        '
        Me.fwiNFactura.DisabledBackColor = System.Drawing.Color.White
        Me.fwiNFactura.Enabled = False
        Me.fwiNFactura.Location = New System.Drawing.Point(88, 11)
        Me.fwiNFactura.Name = "fwiNFactura"
        Me.fwiNFactura.Size = New System.Drawing.Size(89, 21)
        Me.fwiNFactura.TabIndex = 24
        '
        'fwiTitulo
        '
        Me.fwiTitulo.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTitulo.Enabled = False
        Me.fwiTitulo.Location = New System.Drawing.Point(88, 36)
        Me.fwiTitulo.Name = "fwiTitulo"
        Me.fwiTitulo.Size = New System.Drawing.Size(272, 21)
        Me.fwiTitulo.TabIndex = 25
        '
        'Grid
        '
        Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDFormaPago", "FormaPago", "IDFormaPago", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescFormaPago", "DescFormaPago")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDMoneda", "Moneda", "IDMoneda"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDBancoPropio", "BancoPropio", "IDBancoPropio"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CContable", "PlanContable", "IDCContable"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDProveedorBanco", "ProveedorBanco", "IDProveedorBanco"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDDireccion", "ProveedorDireccion", "IDDireccion"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDPartidaEstadistica", "PartidaEstadistica", "IDPartidaEstadistica"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("NFactura", "FacturaCompraCabecera", "NFactura", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDFactura", "IDFactura")}))})
        Me.Grid.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid.EntityName = Nothing
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.SecondaryDataFields = Nothing
        Me.Grid.Size = New System.Drawing.Size(648, 213)
        Me.Grid.TabIndex = 21
        Me.Grid.Tag = "IdRec=5029:4394:4712:4713:4429:4715:4756:5071:4602:5257:4719:4711:4361:4362:5433:" & _
            "4399:4357:4725:10533:;"
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = Nothing
        '
        'frmModifPagos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(648, 317)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmModifPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificación de Pagos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.AllRecords
        End Get
    End Property

    Public Function AbrirModificacionPagos(ByVal strIDProcess As String, ByVal OwnerForm As FormBase) As DialogResult

        With Grid
            .EntityName = "Pago"
            .ViewName = "frmPagosNeg"

            Dim f As New Filter
            f.Add(New StringFilterItem("IdProcess", FilterOperator.Equal, strIDProcess))
            'f.Add(New NumberFilterItem("Contabilizado", enumContabilizado.NoContabilizado))
            .Filter = f

            Me.ShowDialog(OwnerForm)

            Return Me.DialogResult
        End With
    End Function

    Private Sub ActualizaNuevaFechaVencimiento()

        Dim dt As DataTable = Grid.DataSource
        If Not dt Is Nothing Then
            For Each dr As DataRow In dt.Rows
                If Length(FwiFechaVtoNew.Value) > 0 Then dr("FechaVencimiento") = FwiFechaVtoNew.Value
                If Length(FwIDBancoNew.Text) > 0 Then dr("IdBancopropio") = FwIDBancoNew.Text
                If Length(FwIFPagoNew.Text) > 0 Then dr("IdFormaPago") = FwIFPagoNew.Text
                ' If Length(FwiFechaPagonew.Value) > 0 Then dr("FechaPago") = FwiFechaPagonew.Value
                If Length(txtTexto.Text) > 0 Then dr("Texto") = txtTexto.Text
            Next

            Grid.DataSource = dt
        End If

    End Sub

    Private Sub CmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Grid.RecordCount > 0 Then
            If Length(FwiFechaVtoNew.Value) > 0 Or Length(FwIDBancoNew.Text) > 0 Or Length(FwIFPagoNew.Text) > 0 Or Length(txtTexto.Text) > 0 Then
                ActualizaNuevaFechaVencimiento()
            End If
            Me.DialogResult = DialogResult.OK
            Me.UpdateData()
        End If
        Me.Close()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub GridPagos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.SelectionChanged
        fwiNFactura.Text = Grid.Value("NFactura") & String.Empty
        fwiTitulo.Text = Grid.Value("Titulo") & String.Empty
    End Sub

    Private Sub GridPagos_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles Grid.AdvSearchSetPredefinedFilter
        With Grid
            Select Case e.Key
                Case "IdProveedorBanco"
                    If Length(Grid.GetValue("IDProveedor")) > 0 Then
                        e.Filter.Add("IDProveedor", FilterOperator.Equal, .Value("IdProveedor"), FilterType.String)
                    Else
                        ExpertisApp.GenerateMessage("El Pago seleccionado no tiene un Proveedor configurado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        e.Filter.Add(New IsNullFilterItem("IDProveedor"))
                    End If
                Case "IDDireccion"
                    If Length(Grid.GetValue("IDProveedor")) > 0 Then
                        e.Filter.Add("IDProveedor", FilterOperator.Equal, .Value("IdProveedor"), FilterType.String)
                        e.Filter.Add("Giro", FilterOperator.Equal, True, FilterType.Boolean)
                    Else
                        ExpertisApp.GenerateMessage("El Pago seleccionado no tiene un Proveedor configurado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        e.Filter.Add(New IsNullFilterItem("IDProveedor"))
                    End If
            End Select
        End With
    End Sub

    Private Sub Grid_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        'Dim blnNoEditar As Boolean = (Nz(Grid.Value("Contabilizado"), enumContabilizado.NoContabilizado) <> enumContabilizado.NoContabilizado) OrElse _
        '                            Nz(Grid.Value("Situacion"), enumPagoSituacion.NoPagado) <> enumPagoSituacion.NoPagado OrElse _
        '                            Length(Grid.Value("IDRemesa")) > 0

        ' SERGIO BLANCO 26/01/2022
        Dim blnNoEditar As Boolean = (Nz(Grid.Value("Contabilizado"), enumContabilizado.NoContabilizado) <> enumContabilizado.NoContabilizado) 'OrElse _
        'Length(Grid.Value("IDRemesa")) > 0

        Select Case e.Column.Key
            Case "IdMoneda", "IDFormaPago", "IDDireccion", "IDBancoPropio", "IDProveedorBanco", "NFactura", "IdPartidaEstadistica"
                If blnNoEditar Then
                    e.Cancel = True
                    e.Column.ButtonStyle = ButtonStyle.NoButton
                Else
                    e.Column.ButtonStyle = ButtonStyle.Image
                End If
            Case "CContable"
                'If blnNoEditar OrElse Length(Grid.GetValue("NFactura")) > 0 Then
                If blnNoEditar Then
                    e.Cancel = True
                    e.Column.ButtonStyle = ButtonStyle.NoButton
                Else
                    e.Column.ButtonStyle = ButtonStyle.Image
                End If
            Case "ImpVencimiento", "ImpVencimientoA", "ImpVencimientoB", "ARepercutir", "ImporteRemesaAnticipo", "Titulo", "CambioA", "CambioB", "Situacion"
                If blnNoEditar Then
                    e.Cancel = True
                End If
            Case "Situacion"
                If blnNoEditar Then
                    e.Cancel = True
                End If
            Case "FechaVencimiento", "FechaPago"
                If blnNoEditar Then
                    e.Cancel = True
                End If
        End Select
    End Sub


    Protected Overridable Sub HabilitarControlesCambios()
        Dim blnEnabled As Boolean = True

        If Not Grid.DataSource Is Nothing Then
            'Dim VtosNoModificables As List(Of DataRow) = (From c In CType(Grid.DataSource, DataTable) _
            '                                              Where (Not c.IsNull("Contabilizado") AndAlso Nz(Grid.Value("Contabilizado"), enumContabilizado.NoContabilizado) <> enumContabilizado.NoContabilizado) OrElse _
            '                                                    (Not c.IsNull("Situacion") AndAlso Nz(Grid.Value("Situacion"), enumPagoSituacion.NoPagado) <> enumPagoSituacion.NoPagado) OrElse _
            '                                                    (Not c.IsNull("IDRemesa")) _
            '                                                    Select c).ToList
            'SERGIO BLANCO 26/01/2022
            Dim VtosNoModificables As List(Of DataRow) = (From c In CType(Grid.DataSource, DataTable) _
                                                        Where (Not c.IsNull("Contabilizado") AndAlso Nz(Grid.Value("Contabilizado"), enumContabilizado.NoContabilizado) <> enumContabilizado.NoContabilizado) Or _
                                                       (Not c.IsNull("IDRemesa")) _
                                                              Select c).ToList
            blnEnabled = Not (Not VtosNoModificables Is Nothing AndAlso VtosNoModificables.Count > 0)
        End If

        'fwiNFactura.Enabled = blnEnabled
        'fwiTitulo.Enabled = blnEnabled
        FwiFechaVtoNew.Enabled = True
        FwIDBancoNew.Enabled = True
        FwIFPagoNew.Enabled = True
        'FwiFechaPagonew.Enabled = blnEnabled
        txtTexto.Enabled = True

    End Sub

    Protected Overridable Sub frmModifPagos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.DesignMode Then
            HabilitarControlesCambios()
        End If
    End Sub

End Class
