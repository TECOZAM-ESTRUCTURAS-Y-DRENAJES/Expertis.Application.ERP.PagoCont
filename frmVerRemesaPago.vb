Public Class frmVerRemesaPago
    Inherits Solmicro.Expertis.Engine.UI.FormBase

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.grid.RelationMode = RelationMode.NoRelation
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
    Friend WithEvents lblfwiFechaRemesa As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiTotal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiFechaRemesa As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents fwiTotal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents lblfwiTitulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiNRemesa As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVerRemesaPago))
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.lblfwiFechaRemesa = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFechaRemesa = New Solmicro.Expertis.Engine.UI.TextBox
        Me.fwiTotal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiTitulo = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiNRemesa = New Solmicro.Expertis.Engine.UI.TextBox
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid.EntityName = Nothing
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.FrozenColumns = 2
        Me.Grid.Location = New System.Drawing.Point(3, 32)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.SecondaryDataFields = Nothing
        Me.Grid.Size = New System.Drawing.Size(645, 200)
        Me.Grid.TabIndex = 2
        Me.Grid.Tag = "IdRec=4711:8125:7738:8127:5461:8313:4715:4756:8126:7023:;"
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = Nothing
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdAceptar)
        Me.Panel1.Controls.Add(Me.lblfwiFechaRemesa)
        Me.Panel1.Controls.Add(Me.lblfwiTotal)
        Me.Panel1.Controls.Add(Me.fwiFechaRemesa)
        Me.Panel1.Controls.Add(Me.fwiTotal)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 239)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(650, 56)
        Me.Panel1.TabIndex = 7
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(549, 22)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(96, 29)
        Me.cmdAceptar.TabIndex = 10
        Me.cmdAceptar.Text = "Aceptar"
        '
        'lblfwiFechaRemesa
        '
        Me.lblfwiFechaRemesa.Location = New System.Drawing.Point(8, 5)
        Me.lblfwiFechaRemesa.Name = "lblfwiFechaRemesa"
        Me.lblfwiFechaRemesa.Size = New System.Drawing.Size(90, 13)
        Me.lblfwiFechaRemesa.TabIndex = 8
        Me.lblfwiFechaRemesa.Tag = "IdRec=10716;"
        Me.lblfwiFechaRemesa.Text = "Fecha Remesa"
        '
        'lblfwiTotal
        '
        Me.lblfwiTotal.Location = New System.Drawing.Point(8, 30)
        Me.lblfwiTotal.Name = "lblfwiTotal"
        Me.lblfwiTotal.Size = New System.Drawing.Size(47, 13)
        Me.lblfwiTotal.TabIndex = 9
        Me.lblfwiTotal.Tag = ""
        Me.lblfwiTotal.Text = "Total A"
        '
        'fwiFechaRemesa
        '
        Me.fwiFechaRemesa.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFechaRemesa.Enabled = False
        Me.fwiFechaRemesa.Location = New System.Drawing.Point(109, 5)
        Me.fwiFechaRemesa.Name = "fwiFechaRemesa"
        Me.fwiFechaRemesa.Size = New System.Drawing.Size(115, 21)
        Me.fwiFechaRemesa.TabIndex = 5
        Me.fwiFechaRemesa.TabStop = False
        '
        'fwiTotal
        '
        Me.fwiTotal.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTotal.Enabled = False
        Me.fwiTotal.Location = New System.Drawing.Point(109, 30)
        Me.fwiTotal.Name = "fwiTotal"
        Me.fwiTotal.Size = New System.Drawing.Size(115, 21)
        Me.fwiTotal.TabIndex = 7
        Me.fwiTotal.TabStop = False
        '
        'lblfwiTitulo
        '
        Me.lblfwiTitulo.Location = New System.Drawing.Point(163, 6)
        Me.lblfwiTitulo.Name = "lblfwiTitulo"
        Me.lblfwiTitulo.Size = New System.Drawing.Size(159, 13)
        Me.lblfwiTitulo.TabIndex = 12
        Me.lblfwiTitulo.Tag = ""
        Me.lblfwiTitulo.Text = "PAGOS DE LA REMESA Nº."
        '
        'fwiNRemesa
        '
        Me.fwiNRemesa.DisabledBackColor = System.Drawing.Color.White
        Me.fwiNRemesa.Enabled = False
        Me.fwiNRemesa.Location = New System.Drawing.Point(323, 6)
        Me.fwiNRemesa.Name = "fwiNRemesa"
        Me.fwiNRemesa.Size = New System.Drawing.Size(93, 21)
        Me.fwiNRemesa.TabIndex = 11
        Me.fwiNRemesa.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        '
        'frmVerRemesaPago
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(650, 295)
        Me.Controls.Add(Me.lblfwiTitulo)
        Me.Controls.Add(Me.fwiNRemesa)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Grid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVerRemesaPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Remesa"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.AllRecords
        End Get
    End Property

    Public Sub VerRemesa(ByVal intIdRemesa As Integer, ByVal dtmFechaRemesa As Date, ByVal OwnerForm As FormBase)
        With Grid
            .EntityName = "Pago"
            .ViewName = "vCtlCIPagoContConsultaRemesa"

            Dim f As New Filter
            f.Add(New NumberFilterItem("IDRemesa", intIdRemesa))
            .Filter = f

            fwiNRemesa.Text = intIdRemesa
            fwiFechaRemesa.Text = dtmFechaRemesa

            Me.ShowDialog(OwnerForm)
        End With
    End Sub

    Private Sub frmVerRemesaPago_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fwiTotal.Value = Grid.GetTotal(Grid.Columns("ImpVencimientoA"), Janus.Windows.GridEX.AggregateFunction.Sum)
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.Close()
    End Sub
End Class
