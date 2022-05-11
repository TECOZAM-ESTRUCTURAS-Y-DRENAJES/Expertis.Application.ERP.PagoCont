Imports Solmicro.Expertis.Business.General

Public Class frmDescontabilizarEnviados
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
    Friend WithEvents lblccboSituacion As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents cmdCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents GridCobrosPagos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents cboSituacion As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents GridDiario As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents pnlBottom As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents FraCobrosPagosDescont As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents FraAptesDescont As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblSituacion As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridCobrosPagos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cboSituacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDescontabilizarEnviados))
        Dim GridDiario_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.lblccboSituacion = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.cmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.GridCobrosPagos = New Solmicro.Expertis.Engine.UI.Grid
        Me.cboSituacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.GridDiario = New Solmicro.Expertis.Engine.UI.Grid
        Me.lblSituacion = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlBottom = New Solmicro.Expertis.Engine.UI.Panel
        Me.FraCobrosPagosDescont = New Solmicro.Expertis.Engine.UI.Frame
        Me.FraAptesDescont = New Solmicro.Expertis.Engine.UI.Frame
        CType(Me.GridCobrosPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSituacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottom.suspendlayout()
        Me.FraCobrosPagosDescont.SuspendLayout()
        Me.FraAptesDescont.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblccboSituacion
        '
        Me.TryDataBinding(lblccboSituacion, New System.Windows.Forms.Binding("Text", Me.cboSituacion, "DescEstado", True))
        Me.lblccboSituacion.Location = New System.Drawing.Point(203, 16)
        Me.lblccboSituacion.Name = "lblccboSituacion"
        Me.lblccboSituacion.Size = New System.Drawing.Size(247, 24)
        Me.lblccboSituacion.TabIndex = 21
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.Location = New System.Drawing.Point(580, 18)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(94, 28)
        Me.cmdCancelar.TabIndex = 19
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAceptar.Enabled = False
        Me.cmdAceptar.Location = New System.Drawing.Point(474, 18)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(95, 28)
        Me.cmdAceptar.TabIndex = 18
        Me.cmdAceptar.Text = "Aceptar"
        '
        'GridCobrosPagos
        '
        Me.GridCobrosPagos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridCobrosPagos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridCobrosPagos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridCobrosPagos_DesignTimeLayout.LayoutString = resources.GetString("GridCobrosPagos_DesignTimeLayout.LayoutString")
        Me.GridCobrosPagos.DesignTimeLayout = GridCobrosPagos_DesignTimeLayout
        Me.GridCobrosPagos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCobrosPagos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridCobrosPagos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridCobrosPagos.EntityName = "Pago"
        Me.GridCobrosPagos.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridCobrosPagos.FrozenColumns = 5
        Me.GridCobrosPagos.Location = New System.Drawing.Point(3, 17)
        Me.GridCobrosPagos.Name = "GridCobrosPagos"
        Me.GridCobrosPagos.PrimaryDataFields = Nothing
        Me.GridCobrosPagos.RequeryManually = True
        Me.GridCobrosPagos.SecondaryDataFields = Nothing
        Me.GridCobrosPagos.Size = New System.Drawing.Size(692, 116)
        Me.GridCobrosPagos.TabIndex = 15
        Me.GridCobrosPagos.Tag = "IdRec=4732:4361:4362:4710:4719:4629:4733:4713:4715:;"
        Me.GridCobrosPagos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridCobrosPagos.ViewName = "vfrmPagoDescontEnviados"
        '
        'cboSituacion
        '
        cboSituacion_DesignTimeLayout.LayoutString = resources.GetString("cboSituacion_DesignTimeLayout.LayoutString")
        Me.cboSituacion.DesignTimeLayout = cboSituacion_DesignTimeLayout
        Me.cboSituacion.DisabledBackColor = System.Drawing.Color.White
        Me.cboSituacion.EntityName = "EstadoPago"
        Me.cboSituacion.Location = New System.Drawing.Point(101, 18)
        Me.cboSituacion.Name = "cboSituacion"
        Me.cboSituacion.PrimaryDataFields = "IDEstado"
        Me.cboSituacion.SecondaryDataFields = "IDEstado"
        Me.cboSituacion.SelectedIndex = -1
        Me.cboSituacion.SelectedItem = Nothing
        Me.cboSituacion.Size = New System.Drawing.Size(99, 21)
        Me.cboSituacion.TabIndex = 20
        Me.cboSituacion.ViewName = "cmbEstadoPago"
        '
        'GridDiario
        '
        Me.GridDiario.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridDiario.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
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
        Me.GridDiario.Size = New System.Drawing.Size(692, 219)
        Me.GridDiario.TabIndex = 16
        Me.GridDiario.Tag = "IdRec=4595:4734:4596:4735:4736:4737:4738:4739:;"
        Me.GridDiario.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridDiario.ViewName = "tbDiarioContable"
        '
        'lblSituacion
        '
        Me.lblSituacion.Location = New System.Drawing.Point(12, 22)
        Me.lblSituacion.Name = "lblSituacion"
        Me.lblSituacion.Size = New System.Drawing.Size(79, 13)
        Me.lblSituacion.TabIndex = 22
        Me.lblSituacion.Tag = "IdRec=5097;"
        Me.lblSituacion.Text = "Cambiar a..."
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.lblSituacion)
        Me.pnlBottom.Controls.Add(Me.cboSituacion)
        Me.pnlBottom.Controls.Add(Me.lblccboSituacion)
        Me.pnlBottom.Controls.Add(Me.cmdAceptar)
        Me.pnlBottom.Controls.Add(Me.cmdCancelar)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 375)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(698, 58)
        Me.pnlBottom.TabIndex = 23
        '
        'FraCobrosPagosDescont
        '
        Me.FraCobrosPagosDescont.Controls.Add(Me.GridCobrosPagos)
        Me.FraCobrosPagosDescont.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraCobrosPagosDescont.Location = New System.Drawing.Point(0, 0)
        Me.FraCobrosPagosDescont.Name = "FraCobrosPagosDescont"
        Me.FraCobrosPagosDescont.Size = New System.Drawing.Size(698, 136)
        Me.FraCobrosPagosDescont.TabIndex = 24
        Me.FraCobrosPagosDescont.TabStop = False
        Me.FraCobrosPagosDescont.Text = "Cobros y Pagos a Descontabilizar"
        '
        'FraAptesDescont
        '
        Me.FraAptesDescont.Controls.Add(Me.GridDiario)
        Me.FraAptesDescont.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FraAptesDescont.Location = New System.Drawing.Point(0, 136)
        Me.FraAptesDescont.Name = "FraAptesDescont"
        Me.FraAptesDescont.Size = New System.Drawing.Size(698, 239)
        Me.FraAptesDescont.TabIndex = 25
        Me.FraAptesDescont.TabStop = False
        Me.FraAptesDescont.Text = "Apuntes a Descontabilizar"
        '
        'frmDescontabilizarEnviados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(698, 433)
        Me.Controls.Add(Me.FraAptesDescont)
        Me.Controls.Add(Me.FraCobrosPagosDescont)
        Me.Controls.Add(Me.pnlBottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmDescontabilizarEnviados"
        Me.Text = "Descontabilización de Pagarés Enviados"
        CType(Me.GridCobrosPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSituacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDiario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlBottom.PerformLayout()
        Me.FraCobrosPagosDescont.ResumeLayout(False)
        Me.FraAptesDescont.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mstrValor As String

    Public Function AbrirFormulario(ByVal strValor As String) As DialogResult
        mstrValor = strValor

        Me.ShowDialog()

        Return Me.DialogResult
    End Function

    Private Sub frmDescontabilizar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim p As New Parametro
        cboSituacion.Value = p.PagoDescontSituacion

        'Inicializar Grid de Pagos
        Dim clsFilter As New Filter
        clsFilter.Add(New StringFilterItem("IdProcess", FilterOperator.Equal, mIDProcess.ToString))
        clsFilter.Add(New StringFilterItem("Situacion", FilterOperator.Equal, mstrValor))
        clsFilter.Add(New BooleanFilterItem("Contabilizado", False))

        GridCobrosPagos.Filter = clsFilter
        GridCobrosPagos.ReQuery()

        FiltrarGridDiario()
    End Sub

    Private Sub FiltrarGridDiario()

        Dim dtPagos As DataTable = GridCobrosPagos.DataSource
        If Not dtPagos Is Nothing AndAlso dtPagos.Rows.Count > 0 Then
            Dim oFilterOR As New Filter
            oFilterOR.UnionOperator = FilterUnionOperator.Or

            For Each dr As DataRow In dtPagos.Select
                Dim oFilter As New Filter
                oFilter.Add("IDDocumento", FilterOperator.Equal, dr("IdCobroPago"))
                oFilter.Add("IDTipoApunte", FilterOperator.Equal, enumDiarioTipoApunte.Talon)

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
        objFilter.Clear()
        objFilter.Add(New IsNullFilterItem("MesCierre", False))
        Dim dvApuntesPago As DataView = New DataView(GridDiario.DataSource, objFilter.Compose(New AdoFilterComposer), Nothing, DataViewRowState.CurrentRows)
        If Not IsNothing(dvApuntesPago) AndAlso dvApuntesPago.Count > 0 Then
            ExpertisApp.GenerateMessage("Algun pago está contabilizado en un periodo cerrado. Debe deshacer el cierre de ese periodo para descontabilizar el pago.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        objFilter = Nothing

        'Comprobamos si algun pago de los que se va a descontabilizar esta agrupado por banco
        'con otro que no se va a descontabilizar. En ese caso habra un descuadre en el grid y no
        'se dejara descontabilizar el pago

        Me.DialogResult = DialogResult.OK
        If ComprobarDescuadreAsiento() Then
            Dim intNuevaSituacion As Integer = -1
            If Length(cboSituacion.Value) > 0 Then intNuevaSituacion = cboSituacion.Value

            Dim datDescont As New DataDescontabilizacion(mIDProcess, intNuevaSituacion)
            ExpertisApp.ExecuteTask(Of DataDescontabilizacion)(AddressOf ContabilizacionTalon.DescontabilizarEnviados, datDescont)
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
        Dim intAsientoAnt As Integer : Dim IDEjercicioAnt As String
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
        If Length(strAsientosDescuadrados) > 0 Then
            'No se pueden borrar de forma automática algunos asientos porque se crearian asientos descuadrados. 'Debe modificar manualmente los siguientes asientos: ....
            If ExpertisApp.GenerateMessage("No se pueden borrar de forma automática algunos asientos porque se crearían asientos descuadrados. Después de terminar este proceso se deben modificar manualmente los siguientes asientos: |", MessageBoxButtons.YesNo, MessageBoxIcon.Information, strAsientosDescuadrados) = DialogResult.No Then
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
