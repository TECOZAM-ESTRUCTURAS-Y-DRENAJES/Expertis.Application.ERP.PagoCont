Imports Solmicro.Expertis.Business.General

Public Class frmDescontabilizarEfectos
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
    Friend WithEvents lblApuntes As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblCobrosPagos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblccboSituacion As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents cmdCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents lblcboSituacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cboSituacion As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents GridDiario As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents GridCobrosPagos As Solmicro.Expertis.Engine.UI.Grid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridCobrosPagos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDescontabilizarEfectos))
        Dim GridDiario_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cboSituacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.GridCobrosPagos = New Solmicro.Expertis.Engine.UI.Grid
        Me.GridDiario = New Solmicro.Expertis.Engine.UI.Grid
        Me.lblApuntes = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCobrosPagos = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblccboSituacion = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.cmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.lblcboSituacion = New Solmicro.Expertis.Engine.UI.Label
        Me.cboSituacion = New Solmicro.Expertis.Engine.UI.ComboBox
        CType(Me.GridCobrosPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.suspendlayout()
        CType(Me.cboSituacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridCobrosPagos
        '
        Me.GridCobrosPagos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridCobrosPagos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridCobrosPagos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridCobrosPagos_DesignTimeLayout.LayoutString = resources.GetString("GridCobrosPagos_DesignTimeLayout.LayoutString")
        Me.GridCobrosPagos.DesignTimeLayout = GridCobrosPagos_DesignTimeLayout
        Me.GridCobrosPagos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridCobrosPagos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridCobrosPagos.EntityName = "Pago"
        Me.GridCobrosPagos.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridCobrosPagos.FrozenColumns = 5
        Me.GridCobrosPagos.Location = New System.Drawing.Point(5, 29)
        Me.GridCobrosPagos.Name = "GridCobrosPagos"
        Me.GridCobrosPagos.PrimaryDataFields = Nothing
        Me.GridCobrosPagos.RequeryManually = True
        Me.GridCobrosPagos.SecondaryDataFields = Nothing
        Me.GridCobrosPagos.Size = New System.Drawing.Size(555, 133)
        Me.GridCobrosPagos.TabIndex = 3
        Me.GridCobrosPagos.Tag = "IdRec=4732:4361:4362:4710:4719:4629:4733:4713:4715:;"
        Me.GridCobrosPagos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridCobrosPagos.ViewName = "frmPagoRemesaDescont"
        '
        'GridDiario
        '
        Me.GridDiario.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridDiario.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridDiario_DesignTimeLayout.LayoutString = resources.GetString("GridDiario_DesignTimeLayout.LayoutString")
        Me.GridDiario.DesignTimeLayout = GridDiario_DesignTimeLayout
        Me.GridDiario.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridDiario.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridDiario.EntityName = "DiarioContable"
        Me.GridDiario.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridDiario.FrozenColumns = 2
        Me.GridDiario.Location = New System.Drawing.Point(5, 192)
        Me.GridDiario.Name = "GridDiario"
        Me.GridDiario.PrimaryDataFields = Nothing
        Me.GridDiario.RequeryManually = True
        Me.GridDiario.SecondaryDataFields = Nothing
        Me.GridDiario.Size = New System.Drawing.Size(555, 133)
        Me.GridDiario.TabIndex = 4
        Me.GridDiario.Tag = "IdRec=4595:4734:4596:4735:4736:4737:4738:4739:;"
        Me.GridDiario.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridDiario.ViewName = "tbDiarioContable"
        '
        'lblApuntes
        '
        Me.lblApuntes.Location = New System.Drawing.Point(7, 171)
        Me.lblApuntes.Name = "lblApuntes"
        Me.lblApuntes.Size = New System.Drawing.Size(160, 13)
        Me.lblApuntes.TabIndex = 5
        Me.lblApuntes.Tag = "IdRec=4741;"
        Me.lblApuntes.Text = "Apuntes a Descontabilizar:"
        '
        'lblCobrosPagos
        '
        Me.lblCobrosPagos.Location = New System.Drawing.Point(6, 6)
        Me.lblCobrosPagos.Name = "lblCobrosPagos"
        Me.lblCobrosPagos.Size = New System.Drawing.Size(211, 13)
        Me.lblCobrosPagos.TabIndex = 7
        Me.lblCobrosPagos.Tag = "IdRec=4740;"
        Me.lblCobrosPagos.Text = "Efectos de Pagos a Descontabilizar:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblccboSituacion)
        Me.Panel1.Controls.Add(Me.cmdCancelar)
        Me.Panel1.Controls.Add(Me.cmdAceptar)
        Me.Panel1.Controls.Add(Me.lblcboSituacion)
        Me.Panel1.Controls.Add(Me.cboSituacion)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 333)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(560, 40)
        Me.Panel1.TabIndex = 10
        '
        'lblccboSituacion
        '
        Me.TryDataBinding(lblccboSituacion, New System.Windows.Forms.Binding("Text", Me.cboSituacion, "DescEstado", True))
        Me.lblccboSituacion.Location = New System.Drawing.Point(168, 8)
        Me.lblccboSituacion.Name = "lblccboSituacion"
        Me.lblccboSituacion.Size = New System.Drawing.Size(206, 22)
        Me.lblccboSituacion.TabIndex = 14
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(472, 8)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(79, 26)
        Me.cmdCancelar.TabIndex = 11
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Enabled = False
        Me.cmdAceptar.Location = New System.Drawing.Point(384, 8)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(79, 26)
        Me.cmdAceptar.TabIndex = 10
        Me.cmdAceptar.Text = "Aceptar"
        '
        'lblcboSituacion
        '
        Me.lblcboSituacion.Location = New System.Drawing.Point(2, 12)
        Me.lblcboSituacion.Name = "lblcboSituacion"
        Me.lblcboSituacion.Size = New System.Drawing.Size(79, 13)
        Me.lblcboSituacion.TabIndex = 13
        Me.lblcboSituacion.Tag = "IdRec=5097;"
        Me.lblcboSituacion.Text = "Cambiar a..."
        '
        'cboSituacion
        '
        cboSituacion_DesignTimeLayout.LayoutString = resources.GetString("cboSituacion_DesignTimeLayout.LayoutString")
        Me.cboSituacion.DesignTimeLayout = cboSituacion_DesignTimeLayout
        Me.cboSituacion.DisabledBackColor = System.Drawing.Color.White
        Me.cboSituacion.EntityName = "EstadoPago"
        Me.cboSituacion.Location = New System.Drawing.Point(82, 8)
        Me.cboSituacion.Name = "cboSituacion"
        Me.cboSituacion.PrimaryDataFields = "IDEstado"
        Me.cboSituacion.SecondaryDataFields = "IDEstado"
        Me.cboSituacion.SelectedIndex = -1
        Me.cboSituacion.SelectedItem = Nothing
        Me.cboSituacion.Size = New System.Drawing.Size(83, 21)
        Me.cboSituacion.TabIndex = 12
        Me.cboSituacion.ViewName = "cmbEstadoPago"
        '
        'frmDescontabilizarEfectos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(560, 373)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GridCobrosPagos)
        Me.Controls.Add(Me.GridDiario)
        Me.Controls.Add(Me.lblApuntes)
        Me.Controls.Add(Me.lblCobrosPagos)
        Me.Name = "frmDescontabilizarEfectos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Descontabilización Efectos"
        CType(Me.GridCobrosPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDiario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cboSituacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private mblnLeassing As Boolean
    Private mContabilidadMultiple As Boolean

    Public Function AbrirFormulario(Optional ByVal blnLeassing As Boolean = False) As DialogResult
        mblnLeassing = blnLeassing

        Me.ShowDialog()

        Return Me.DialogResult
    End Function

    Private Sub frmDescontabilizar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadERPData()
            FiltrarGridCobrosPagos()
            FiltrarGridDiario()
        End If
    End Sub

    Private Sub LoadERPData()
        Dim p As New Parametro
        cboSituacion.Value = p.PagoDescontSituacion
        mContabilidadMultiple = p.ContabilidadMultiple
        If mContabilidadMultiple Then
            GridCobrosPagos.ViewName = "frmPagoRemesaDescontContMultiple"
        End If
    End Sub

    Private Sub FiltrarGridCobrosPagos()
        ''Inicializar Grid de Pagos
        Dim f As New Filter
        f.Add(New GuidFilterItem("IDProcess", mIDProcess))

        GridCobrosPagos.Filter = f
        GridCobrosPagos.ReQuery()
    End Sub

    Private Sub FiltrarGridDiario()
        Dim dtPagos As DataTable = GridCobrosPagos.DataSource
        If Not dtPagos Is Nothing AndAlso dtPagos.Rows.Count > 0 Then
            Dim oFilterOR As New Filter(FilterUnionOperator.Or)
            For Each dr As DataRow In dtPagos.Select
                Dim oFilter As New Filter
                oFilter.Add("IDDocumento", FilterOperator.Equal, dr("IdCobroPago"))
                'oFilter.Add("IDEjercicio", FilterOperator.Equal, dr("IDEjercicio"))
                Dim fEjercicio As New Filter(FilterUnionOperator.Or)
                fEjercicio.Add(New StringFilterItem("IDEjercicio", FilterOperator.Equal, dr("IDEjercicio")))
                If mContabilidadMultiple Then
                    If dr.Table.Columns.Contains("IDEjercicioTributario") AndAlso Length(dr("IDEjercicioTributario")) > 0 Then fEjercicio.Add(New StringFilterItem("IDEjercicio", FilterOperator.Equal, dr("IDEjercicioTributario")))
                End If

                oFilter.Add(fEjercicio)
                oFilter.Add("IDTipoApunte", FilterOperator.Equal, enumDiarioTipoApunte.RemesaPago)

                oFilterOR.Add(oFilter)
            Next
            GridDiario.Filter = oFilterOR
            GridDiario.ReQuery()

            If GridDiario.RecordCount > 0 Then cmdAceptar.Enabled = True
        End If

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

        'Comprobamos si algun pago de los que se va a descontabilizar esta agrupado por banco
        'con otro que no se va a descontabilizar. En ese caso habra un descuadre en el grid y no
        'se dejara descontabilizar el pago
        Me.DialogResult = DialogResult.OK
        If ComprobarDescuadreAsiento() Then
            Dim intNuevaSituacion As Integer = -1
            If length(cboSituacion.Value) > 0 Then intNuevaSituacion = cboSituacion.Value

            Dim datDescont As New DataDescontabilizacion(mIDProcess, intNuevaSituacion)
            ExpertisApp.ExecuteTask(Of DataDescontabilizacion)(AddressOf ContabilizacionEfectos.Descontabilizar, datDescont)

        Else
            Me.DialogResult = DialogResult.Cancel
        End If

        Me.Close()
    End Sub

    Private Function ComprobarDescuadreAsiento() As Boolean
        'Comprueba que todos los apuntes del grid pertenecientes a un mismo asiento estan cuadrados.
        'Tendremos asientos descuadrados en el grid cuando no se van a descontabilizar todos los cobros
        'que se han contabilizado agrupados por banco

        Dim dblDebeAsiento, dblHaberAsiento As Double
        Dim strAsientosDescuadrados As String = String.Empty
        Dim intNAsientosNoDescuadrados As Integer = 0
        Dim intAsientoAnt As Integer : Dim IdEjercicioAnt As String
        Dim dtGrid As DataTable = GridDiario.DataSource

        For Each drApunte As DataRow In dtGrid.Select(Nothing, "IDEjercicio ASC, NAsiento ASC")
            If drApunte("IDEjercicio") <> IDEjercicioAnt OrElse drApunte("NAsiento") <> intAsientoAnt Then

                'If drApunte("NAsiento") <> intAsientoAnt Then
                If dblHaberAsiento <> dblDebeAsiento Then
                    strAsientosDescuadrados = strAsientosDescuadrados & intAsientoAnt & ", "
                End If
                'dblDebeAsiento = CDec(drApunte("ImpDebeA"))
                'dblHaberAsiento = CDec(drApunte("ImpHaberA"))
                'End If

                dblDebeAsiento = 0 : dblHaberAsiento = 0
                intAsientoAnt = drApunte("NAsiento")
                IDEjercicioAnt = drApunte("IDEjercicio")
            End If
            dblDebeAsiento = dblDebeAsiento + CDec(drApunte("ImpDebeA"))
            dblHaberAsiento = dblHaberAsiento + CDec(drApunte("ImpHaberA"))
        Next

        If dblHaberAsiento <> dblDebeAsiento Then
            strAsientosDescuadrados = strAsientosDescuadrados & intAsientoAnt & ", "
        Else
            intNAsientosNoDescuadrados = intNAsientosNoDescuadrados + 1
        End If
        If Len(strAsientosDescuadrados) > 0 Then
            strAsientosDescuadrados = Microsoft.VisualBasic.Left(strAsientosDescuadrados, Len(strAsientosDescuadrados) - Len(", "))
        End If

        Dim blnContinuar As Boolean = True
        If Len(strAsientosDescuadrados) > 0 Then
            'No se pueden borrar de forma automática algunos asientos porque se crearian asientos descuadrados. 'Debe modificar manualmente los siguientes asientos: ....
            If ExpertisApp.GenerateMessage("No se pueden borrar de forma automática algunos asientos, porque se crearían asientos descuadrados. Después de terminar este proceso se deben modificar manualmente los siguientes asientos: {0}", MessageBoxButtons.YesNo, MessageBoxIcon.Information, strAsientosDescuadrados) = DialogResult.No Then
                blnContinuar = False
            End If
        End If

        If blnContinuar And intNAsientosNoDescuadrados > 0 Then   'Si hay asientos no descuadrados
            'Se eliminarán todos los apuntes contables de los pagos contabilizados seleccionados.
            If ExpertisApp.GenerateMessage("Se eliminarán todos los apuntes contables de los pagos contabilizados seleccionados.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                blnContinuar = False
            End If
        End If

        Return blnContinuar
    End Function

End Class
