Public Class frmPagoManual
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
    Friend WithEvents cmdCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim Grid_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.ButtonImage")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPagoManual))
        Dim Grid_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.ButtonImage")
        Dim Grid_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column6.ButtonImage")
        Dim Grid_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column7.ButtonImage")
        Dim Grid_DesignTimeLayout_Reference_4 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column13.ButtonImage")
        Dim Grid_DesignTimeLayout_Reference_5 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column14.ButtonImage")
        Dim Grid_DesignTimeLayout_Reference_6 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column15.ButtonImage")
        Dim Grid_DesignTimeLayout_Reference_7 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column17.ButtonImage")
        Dim Grid_DesignTimeLayout_Reference_8 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column20.ButtonImage")
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel1.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdCancelar)
        Me.Panel1.Controls.Add(Me.cmdAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 253)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(768, 48)
        Me.Panel1.TabIndex = 4
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(388, 11)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(100, 26)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(280, 11)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(100, 26)
        Me.cmdAceptar.TabIndex = 4
        Me.cmdAceptar.Text = "Aceptar"
        '
        'Grid
        '
        Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("NFactura", "FacturaCompraCabecera", "NFactura"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IdTipoPago", "TipoPago", "IdTipoPago"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDProveedor", "Proveedor", "IDProveedor"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDDireccion", "ProveedorDireccion", "IDDireccion"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCContable", "PlanContable", "IDCContable"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDFormaPago", "FormaPago", "IDFormaPago", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescFormaPago", "DescFormaPago")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDMoneda", "Moneda", "IDMoneda"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("Situacion", "EstadoPago", "IDEstado"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDBancoPropio", "BancoPropio", "IDBancoPropio"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDProveedorBanco", "ProveedorBanco", "IDProveedorBanco")})
        Grid_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_0.Instance"), Object)
        Grid_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_1.Instance"), Object)
        Grid_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_2.Instance"), Object)
        Grid_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_3.Instance"), Object)
        Grid_DesignTimeLayout_Reference_4.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_4.Instance"), Object)
        Grid_DesignTimeLayout_Reference_5.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_5.Instance"), Object)
        Grid_DesignTimeLayout_Reference_6.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_6.Instance"), Object)
        Grid_DesignTimeLayout_Reference_7.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_7.Instance"), Object)
        Grid_DesignTimeLayout_Reference_8.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_8.Instance"), Object)
        Grid_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {Grid_DesignTimeLayout_Reference_0, Grid_DesignTimeLayout_Reference_1, Grid_DesignTimeLayout_Reference_2, Grid_DesignTimeLayout_Reference_3, Grid_DesignTimeLayout_Reference_4, Grid_DesignTimeLayout_Reference_5, Grid_DesignTimeLayout_Reference_6, Grid_DesignTimeLayout_Reference_7, Grid_DesignTimeLayout_Reference_8})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid.EntityName = ""
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.SecondaryDataFields = Nothing
        Me.Grid.Size = New System.Drawing.Size(768, 253)
        Me.Grid.TabIndex = 5
        Me.Grid.Tag = ""
        Me.Grid.ViewName = ""
        '
        'frmPagoManual
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(768, 301)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPagoManual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pago manual"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.AllRecords
        End Get
    End Property

    Public Function AbrirPagosManual(ByVal OwnerForm As FormBase) As DialogResult

        Grid.EntityName = "Pago"
        Grid.ViewName = "frmNuevoPagoManual"
        Dim f As New Filter

        f.Add(New IsNullFilterItem("IDPago"))

        Grid.Filter = f
        Grid.Columns("Situacion").DefaultValue = enumPagoSituacion.NoPagado

        Me.ShowDialog(OwnerForm)

        Return Me.DialogResult
    End Function

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Grid.RecordCount > 0 Then
            Try
                Me.UpdateData()
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Catch ex As Exception
                ExpertisApp.GenerateMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub

    Private Sub Grid_AdvSearchNotInList(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchNotInListEventArgs) Handles Grid.AdvSearchNotInList
        Select Case e.Key
            Case "NFactura"
                e.Cancel = False
        End Select
    End Sub

    Private Sub Grid_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles Grid.AdvSearchSetPredefinedFilter
        With Grid
            If length(.Value("IDProveedor")) > 0 Then
                Select Case e.Key
                    Case "IDFactura", "NFactura", "IDProveedorBanco", "IDDireccion"
                        e.Filter.Add("IDProveedor", FilterOperator.Equal, .Value("IDProveedor"))
                        If e.Key = "IDDireccion" Then
                            e.Filter.Add("Giro", FilterOperator.Equal, True)
                        End If
                End Select
            End If
        End With
    End Sub
End Class
