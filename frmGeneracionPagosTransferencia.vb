Imports Janus.Windows.GridEX
Imports Solmicro.Expertis.Engine.DAL
Imports Solmicro.Expertis.Business.Negocio
Imports Solmicro.Expertis.Business.General

Public Class frmGeneracionPagosTransferencia
    Inherits Solmicro.Expertis.Engine.UI.FormBase

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.activeControl.RelationMode = RelationMode.NoRelation
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
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents fwiTitulo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents FwIDBancoNew As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents FwIFPagoNew As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents Button3 As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents TextBox1 As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advBanco As Solmicro.Expertis.Engine.UI.AdvSearch

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents activeControl As Solmicro.Expertis.Engine.UI.Grid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim activeControl_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGeneracionPagosTransferencia))
        Me.activeControl = New Solmicro.Expertis.Engine.UI.Grid
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.advBanco = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Button3 = New Solmicro.Expertis.Engine.UI.Button
        Me.TextBox1 = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiTitulo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FwIDBancoNew = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FwIFPagoNew = New Solmicro.Expertis.Engine.UI.AdvSearch
        CType(Me.activeControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'activeControl
        '
        Me.activeControl.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDFormaPago", "FormaPago", "IDFormaPago", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescFormaPago", "DescFormaPago")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDMoneda", "Moneda", "IDMoneda"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDBancoPropio", "BancoPropio", "IDBancoPropio"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CContable", "PlanContable", "IDCContable"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDProveedorBanco", "ProveedorBanco", "IDProveedorBanco"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDDireccion", "ProveedorDireccion", "IDDireccion"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDPartidaEstadistica", "PartidaEstadistica", "IDPartidaEstadistica"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("NFactura", "FacturaCompraCabecera", "NFactura", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDFactura", "IDFactura")}))})
        Me.activeControl.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.activeControl.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        activeControl_DesignTimeLayout.LayoutString = resources.GetString("activeControl_DesignTimeLayout.LayoutString")
        Me.activeControl.DesignTimeLayout = activeControl_DesignTimeLayout
        Me.activeControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.activeControl.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.activeControl.EntityName = Nothing
        Me.activeControl.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.activeControl.Location = New System.Drawing.Point(0, 0)
        Me.activeControl.Name = "activeControl"
        Me.activeControl.PrimaryDataFields = Nothing
        Me.activeControl.SecondaryDataFields = Nothing
        Me.activeControl.Size = New System.Drawing.Size(648, 200)
        Me.activeControl.TabIndex = 21
        Me.activeControl.Tag = "IdRec=5029:4394:4712:4713:4429:4715:4756:5071:4602:5257:4719:4711:4361:4362:5433:" & _
            "4399:4357:4725:10533:;"
        Me.activeControl.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.activeControl.ViewName = Nothing
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAceptar.Location = New System.Drawing.Point(422, 64)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(104, 27)
        Me.cmdAceptar.TabIndex = 22
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.Location = New System.Drawing.Point(532, 64)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(104, 27)
        Me.cmdCancelar.TabIndex = 23
        Me.cmdCancelar.Text = "Cancelar"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.advBanco)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmdCancelar)
        Me.Panel1.Controls.Add(Me.cmdAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 200)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(648, 104)
        Me.Panel1.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Seleccionar Banco Propio"
        '
        'advBanco
        '
        Me.advBanco.DisabledBackColor = System.Drawing.Color.White
        Me.advBanco.DisplayField = "IDBancoPropio"
        Me.advBanco.EntityName = "BancoPropio"
        Me.advBanco.Location = New System.Drawing.Point(172, 68)
        Me.advBanco.Name = "advBanco"
        Me.advBanco.SecondaryDataFields = "IDBancoPropio"
        Me.advBanco.Size = New System.Drawing.Size(227, 23)
        Me.advBanco.TabIndex = 27
        Me.advBanco.ViewName = "tbMaestroBancoPropio"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(561, 22)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 21)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Buscar ruta"
        '
        'TextBox1
        '
        Me.TextBox1.DisabledBackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(64, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(491, 21)
        Me.TextBox1.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(14, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Ruta"
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
        'frmGeneracionPagosTransferencia
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(648, 304)
        Me.Controls.Add(Me.activeControl)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmGeneracionPagosTransferencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificación de Pagos"
        CType(Me.activeControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.AllRecords
        End Get
    End Property

    'Este metodo carga los datos 
    Public Function AbrirGeneracionPagosTransferencia(ByVal strIDProcess As String, ByVal OwnerForm As FormBase) As DialogResult

        With activeControl
            .EntityName = "Pago"
            .ViewName = "frmPagosNeg"

            Dim f As New Filter
            f.Add(New StringFilterItem("IdProcess", FilterOperator.Equal, strIDProcess))
            f.Add(New NumberFilterItem("Contabilizado", enumContabilizado.NoContabilizado)) 'No contabilizado es 0
            f.Add(New NumberFilterItem("IDFormaPago", FilterOperator.Equal, "2")) ' 2 es Transferencia
            .Filter = f

            'Me abre esta ventana con los datos cargados. OwnerForm se le pasa por parametro
            Me.ShowDialog(OwnerForm)

            Return Me.DialogResult
        End With
    End Function

    'Boton Cancelar
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub


    Protected Overridable Sub HabilitarControlesCambios()
        Dim blnEnabled As Boolean = True

        If Not activeControl.DataSource Is Nothing Then
            Dim VtosNoModificables As List(Of DataRow) = (From c In CType(activeControl.DataSource, DataTable) _
                                                          Where (Not c.IsNull("Contabilizado") AndAlso Nz(activeControl.Value("Contabilizado"), enumContabilizado.NoContabilizado) <> enumContabilizado.NoContabilizado) OrElse _
                                                                (Not c.IsNull("Situacion") AndAlso Nz(activeControl.Value("Situacion"), enumPagoSituacion.NoPagado) <> enumPagoSituacion.NoPagado) OrElse _
                                                                (Not c.IsNull("IDRemesa")) _
                                                                Select c).ToList
            blnEnabled = Not (Not VtosNoModificables Is Nothing AndAlso VtosNoModificables.Count > 0)
        End If



    End Sub

    Protected Overridable Sub frmModifPagos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.DesignMode Then
            HabilitarControlesCambios()
        End If
    End Sub

    'Buscar Ruta y te la guarda.
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim openFD As New SaveFileDialog()
        With openFD
            .Title = "Seleccionar Ruta ..."
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            .Filter = "XML files(.xml)|*.xml|all Files(*.*)|*.*"
            .FileName = "FicheroSEPA.xml"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                TextBox1.Text = openFD.FileName
            End If
        End With

    End Sub

    'Boton aceptar
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        'Grid.DeleteServerChecks()

        Dim banco As String = advBanco.Value
        Dim ruta As String = TextBox1.Text 'Donde se guarda el fichero que se genera
        Dim dtPago As DataTable = Me.activeControl.DataSource 'Tabla de los pagos que se van a realizar
        Dim dtSEPA As DataTable
        Dim frm As New GeneracionPagosTransferencia() '- No deberia estar comentado

        dtSEPA = frm.filtroSEPA(dtPago) '- No deberia estar comentado
        'banco= advBanco.Value

        'ApplicationService.GenerateError("Introduzca un banco" & banco)
        If banco.Length = 0 Then
            MessageBox.Show("Introduzca un banco")
        Else
            If ruta = Nothing Then
                MessageBox.Show("Introduzca una ruta para guardar el fichero")
            Else
                frm.GenerarFicheroTransferencia(banco, ruta, dtSEPA) '- No deberia estar comentado
            End If
        End If

        Close()
    End Sub
End Class
