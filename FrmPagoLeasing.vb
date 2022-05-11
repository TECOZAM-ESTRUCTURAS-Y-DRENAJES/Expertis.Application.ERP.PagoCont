Imports Solmicro.Expertis.Business.General
Imports Solmicro.Expertis.Business.Negocio

Public Class FrmPagoLeasing
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
    Friend WithEvents cmbCancel As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbOK As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPagoLeasing))
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancel = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbOK = New Solmicro.Expertis.Engine.UI.Button
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel1.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbCancel)
        Me.Panel1.Controls.Add(Me.cmbOK)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 333)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(836, 48)
        Me.Panel1.TabIndex = 5
        '
        'cmbCancel
        '
        Me.cmbCancel.Location = New System.Drawing.Point(424, 7)
        Me.cmbCancel.Name = "cmbCancel"
        Me.cmbCancel.Size = New System.Drawing.Size(119, 34)
        Me.cmbCancel.TabIndex = 6
        Me.cmbCancel.Text = "Cancelar"
        '
        'cmbOK
        '
        Me.cmbOK.Location = New System.Drawing.Point(293, 7)
        Me.cmbOK.Name = "cmbOK"
        Me.cmbOK.Size = New System.Drawing.Size(119, 34)
        Me.cmbOK.TabIndex = 5
        Me.cmbOK.Text = "Aceptar"
        '
        'Grid
        '
        Me.Grid.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid.EntityName = Nothing
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.FrozenColumns = 3
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.SecondaryDataFields = Nothing
        Me.Grid.Size = New System.Drawing.Size(836, 333)
        Me.Grid.TabIndex = 6
        Me.Grid.ViewName = Nothing
        '
        'FrmPagoLeasing
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(836, 381)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmPagoLeasing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos Provisionales de Facturación"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mblnFechaFacturaProveedor As Boolean

#Region " Load "

    Public Function MainFunction(ByRef DtFacturas As DataTable) As DialogResult
        If Not DtFacturas Is Nothing AndAlso DtFacturas.Rows.Count > 0 Then
            cmbOK.Enabled = True
        Else
            cmbOK.Enabled = False
        End If
        Grid.DataSource = DtFacturas
        Dim MBlnFechaFactProv As Boolean = New Parametro().ControlarFechaFCProveedor
        If MBlnFechaFactProv Then Grid.Columns("FechaFactura").EditType = Janus.Windows.GridEX.EditType.NoEdit

        Return Me.ShowDialog()
    End Function

#End Region

#Region " Grid "

    Private Sub Grid_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles Grid.UpdatingCell
        With Grid
            Select Case e.Column.Key
                Case "SuFechaFactura", "FechaFactura"
                    If Not IsDate(.GetValue(e.Column.Key)) Then
                        ExpertisApp.GenerateMessage("La Fecha no es válida.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        e.Cancel = True
                    Else
                        If e.Column.Key = "FechaFactura" AndAlso length(.GetValue("FechaFactura")) > 0 Then
                            .SetValue("FechaParaDeclaracion", e.Value)

                            If New NegocioGeneral().ContadorB(.GetValue("IDContador")) Then
                                .SetValue("IDEjercicio", ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.PredeterminadoB, e.Value))
                            Else
                                .SetValue("IDEjercicio", ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, e.Value))
                            End If
                        End If
                        If e.Column.Key = "SuFechaFactura" AndAlso length(.GetValue("SuFechaFactura")) > 0 AndAlso mblnFechaFacturaProveedor Then
                            .SetValue("FechaFactura", e.Value)
                        End If
                    End If
            End Select
        End With
    End Sub

#End Region

    Private Sub cmbOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbOK.Click
        If Grid.DataChanged Then Grid.Update()
        If Not Grid.DataSource Is Nothing Then
            Dim Dt As DataTable = Grid.DataSource
            If Dt.Rows.Count > 0 Then
                For Each Dr As DataRow In Dt.Select
                    If Length(Dr("SuFactura")) = 0 OrElse Length(Dr("SuFechaFactura")) = 0 Then
                        ExpertisApp.GenerateMessage("Debe completar todos los datos nº factura proveedor y fecha.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    Else
                        If New NegocioGeneral().ContadorB(Dr("IDContador")) Then
                            If Length(ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.PredeterminadoB, Dr("FechaFactura"))) = 0 Then
                                ExpertisApp.GenerateMessage("No está configurado correctamente el Ejercicio de la fecha:| .|Por favor, revise los datos del ejercicio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Dr("FechaFactura"), vbNewLine)
                                Exit Sub
                            End If
                        Else
                            If Length(ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, Dr("FechaFactura"))) = 0 Then
                                ExpertisApp.GenerateMessage("No está configurado correctamente el Ejercicio de la fecha:| .|Por favor, revise los datos del ejercicio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Dr("FechaFactura"), vbNewLine)
                                Exit Sub
                            End If
                        End If
                    End If
                Next
            End If
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub cmbCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

End Class
