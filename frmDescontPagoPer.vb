Imports Solmicro.Expertis.Business.General

Public Class frmDescontPagoPer
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
    Friend WithEvents GridDiario As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents cmdCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents pnlBottom As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents FraAptesDescontabilizar As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridDiario_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDescontPagoPer))
        Me.GridDiario = New Solmicro.Expertis.Engine.UI.Grid
        Me.cmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.pnlBottom = New Solmicro.Expertis.Engine.UI.Panel
        Me.FraAptesDescontabilizar = New Solmicro.Expertis.Engine.UI.Frame
        CType(Me.GridDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottom.suspendlayout()
        Me.FraAptesDescontabilizar.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridDiario
        '
        Me.GridDiario.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridDiario.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridDiario.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridDiario_DesignTimeLayout.LayoutString = resources.GetString("GridDiario_DesignTimeLayout.LayoutString")
        Me.GridDiario.DesignTimeLayout = GridDiario_DesignTimeLayout
        Me.GridDiario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDiario.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridDiario.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridDiario.EntityName = "DiarioContable"
        Me.GridDiario.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridDiario.FrozenColumns = 2
        Me.GridDiario.Location = New System.Drawing.Point(3, 17)
        Me.GridDiario.Name = "GridDiario"
        Me.GridDiario.PrimaryDataFields = Nothing
        Me.GridDiario.RequeryManually = True
        Me.GridDiario.SecondaryDataFields = Nothing
        Me.GridDiario.Size = New System.Drawing.Size(679, 289)
        Me.GridDiario.TabIndex = 7
        Me.GridDiario.Tag = "IdRec=4595:4734:4596:4735:4736:4737:4738:4739:;"
        Me.GridDiario.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridDiario.ViewName = "tbDiarioContable"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.Location = New System.Drawing.Point(570, 11)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(94, 28)
        Me.cmdCancelar.TabIndex = 13
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAceptar.Location = New System.Drawing.Point(464, 11)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(95, 28)
        Me.cmdAceptar.TabIndex = 12
        Me.cmdAceptar.Text = "Aceptar"
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.cmdAceptar)
        Me.pnlBottom.Controls.Add(Me.cmdCancelar)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 309)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(685, 51)
        Me.pnlBottom.TabIndex = 14
        '
        'FraAptesDescontabilizar
        '
        Me.FraAptesDescontabilizar.Controls.Add(Me.GridDiario)
        Me.FraAptesDescontabilizar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FraAptesDescontabilizar.Location = New System.Drawing.Point(0, 0)
        Me.FraAptesDescontabilizar.Name = "FraAptesDescontabilizar"
        Me.FraAptesDescontabilizar.Size = New System.Drawing.Size(685, 309)
        Me.FraAptesDescontabilizar.TabIndex = 15
        Me.FraAptesDescontabilizar.TabStop = False
        Me.FraAptesDescontabilizar.Text = "Apuntes a Descontabilizar"
        '
        'frmDescontPagoPer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(685, 360)
        Me.Controls.Add(Me.FraAptesDescontabilizar)
        Me.Controls.Add(Me.pnlBottom)
        Me.Name = "frmDescontPagoPer"
        Me.Text = "Descontabilización"
        CType(Me.GridDiario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottom.ResumeLayout(False)
        Me.FraAptesDescontabilizar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private lngIDPagoPeriodico As Long
    Private strIDEjercicio As String
    Private mblnContabilidadMultiple As Boolean

    Public WriteOnly Property PagoPeriodico() As Long
        Set(ByVal Value As Long)
            lngIDPagoPeriodico = Value
        End Set
    End Property

    Public WriteOnly Property IDEjercicio() As String
        Set(ByVal Value As String)
            strIDEjercicio = Value
        End Set
    End Property

    Private Sub frmDescontabilizar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadERPData()
            FiltrarGrid()
        End If
    End Sub

    Private Sub LoadERPData()
        mblnContabilidadMultiple = New Parametro().ContabilidadMultiple
    End Sub

    Private Sub FiltrarGrid()
        'Inicializar Grid 
        Dim f As New Filter
        Dim fEjercicio As New Filter(FilterUnionOperator.Or)
        fEjercicio.Add(New StringFilterItem("IDEjercicio", strIDEjercicio))
        If mblnContabilidadMultiple Then
            Dim dtEjercicio As DataTable = New EjercicioContable().SelOnPrimaryKey(strIDEjercicio)
            Dim IDEjercicioTributario As String
            If dtEjercicio.Rows.Count > 0 Then
                IDEjercicioTributario = dtEjercicio.Rows(0)("IDEjercicioTributario")
            End If
            If Length(IDEjercicioTributario) > 0 Then fEjercicio.Add(New StringFilterItem("IDEjercicio", IDEjercicioTributario))
        End If
        f.Add(fEjercicio)
        f.Add("IDTipoApunte", FilterOperator.Equal, enumDiarioTipoApunte.PagoConcesion)
        f.Add("IDDocumento", FilterOperator.Equal, lngIDPagoPeriodico)

        GridDiario.Filter = f
        GridDiario.ReQuery()
    End Sub


    Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Dim objFilter As New Filter
        objFilter.Add(New IsNullFilterItem("MesCierre", False))
        Dim dvApuntesPago As DataView = New DataView(GridDiario.DataSource, objFilter.Compose(New AdoFilterComposer), Nothing, DataViewRowState.CurrentRows)
        If Not IsNothing(dvApuntesPago) AndAlso dvApuntesPago.Count > 0 Then
            ExpertisApp.GenerateMessage("Algun pago está contabilizado en un periodo cerrado. Debe deshacer el cierre de ese periodo para descontabilizar el pago.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Me.DialogResult = DialogResult.OK

        Dim datDescont As New DataDescontabilizacionPagoConcesion(lngIDPagoPeriodico, strIDEjercicio)
        ExpertisApp.ExecuteTask(Of DataDescontabilizacionPagoConcesion)(AddressOf ContabilizacionPagoConcesion.Descontabilizar, datDescont)

        Me.Close()
    End Sub

End Class
