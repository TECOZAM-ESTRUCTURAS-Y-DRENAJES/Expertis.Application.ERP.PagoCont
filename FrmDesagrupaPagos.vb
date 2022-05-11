Imports Solmicro.Expertis.Business.Negocio

Public Class FrmDesagrupaPagos
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
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents frmCloseForm As Solmicro.Expertis.Engine.UI.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDesagrupaPagos))
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.frmCloseForm = New Solmicro.Expertis.Engine.UI.Button
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel1.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Location = New System.Drawing.Point(359, 8)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(85, 28)
        Me.cmbCancelar.TabIndex = 1
        Me.cmbCancelar.Text = "Cancelar"
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(267, 8)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(85, 28)
        Me.cmbAceptar.TabIndex = 0
        Me.cmbAceptar.Text = "Aceptar"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Controls.Add(Me.frmCloseForm)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 220)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(674, 43)
        Me.Panel1.TabIndex = 3
        '
        'frmCloseForm
        '
        Me.frmCloseForm.Location = New System.Drawing.Point(312, 8)
        Me.frmCloseForm.Name = "frmCloseForm"
        Me.frmCloseForm.Size = New System.Drawing.Size(85, 28)
        Me.frmCloseForm.TabIndex = 2
        Me.frmCloseForm.Text = "Aceptar"
        '
        'Grid
        '
        Me.Grid.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
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
        Me.Grid.Size = New System.Drawing.Size(674, 220)
        Me.Grid.TabIndex = 5
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = ""
        '
        'FrmDesagrupaPagos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(674, 263)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Panel1)
        Me.EntityName = "Pago"
        Me.Name = "FrmDesagrupaPagos"
        Me.Text = "Desagrupación de Pagos"
        Me.ViewName = "frmDesagrupaPagos"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mdtPagosAgrupados As DataTable
    Private mblnConsulta As Boolean

    Public Sub AbrirFormulario(ByVal dtPagos As DataTable, _
                               Optional ByVal blnConsulta As Boolean = False)

        If blnConsulta Then Me.Text = "Pagos Agrupados"

        cmbAceptar.Visible = Not blnConsulta
        cmbCancelar.Visible = Not blnConsulta
        frmCloseForm.Visible = blnConsulta
        mdtPagosAgrupados = dtPagos

        If dtPagos.Rows.Count > 0 Then
            Dim f As New Filter
            f.UnionOperator = FilterUnionOperator.Or

            For Each dr As DataRow In dtPagos.Select
                f.Add("IdPagoAgrupado", FilterOperator.Equal, dr("IDPago"), FilterType.Numeric)
            Next
            Me.FilterCriteria = f
        Else
            cmbAceptar.Enabled = False
        End If

        Me.ShowDialog()
    End Sub

    Private Sub FrmDesagrupaPagos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Grid.DataSource = Me.CurrentData
    End Sub

    Private Sub cmbCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        If ExpertisApp.GenerateMessage("Se van a desagrupar los Pagos seleccionados. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then 'Se va a desagrupar.¿Continuar?
            Dim dt As DataTable = Me.CurrentData
            Dim elimPagoAgrup As New Pago.DataDesagruparPagos
            elimPagoAgrup.PagosAgrupados = mdtPagosAgrupados
            elimPagoAgrup.PagosDesagrupados = dt
            ExpertisApp.ExecuteTask(Of Pago.DataDesagruparPagos)(AddressOf Pago.EliminarPagoAgrupado, elimPagoAgrup)
            ExpertisApp.GenerateMessage("Los pagos se han desagrupado correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub frmCloseForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmCloseForm.Click
        Me.Close()
    End Sub

End Class
