Imports Solmicro.Expertis.Business.General

Public Class frmDescontabilizar
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
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblcfwiSituacion As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents cmdCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents lblfwiSituacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiSituacion As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents GridDiario As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents FraCobrosPagosDescontabilizar As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents FraAptesDescont As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents GridCobrosPagos As Solmicro.Expertis.Engine.UI.Grid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridCobrosPagos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDescontabilizar))
        Dim GridDiario_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim fwiSituacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.GridCobrosPagos = New Solmicro.Expertis.Engine.UI.Grid
        Me.GridDiario = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblcfwiSituacion = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.cmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.lblfwiSituacion = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiSituacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.FraCobrosPagosDescontabilizar = New Solmicro.Expertis.Engine.UI.Frame
        Me.FraAptesDescont = New Solmicro.Expertis.Engine.UI.Frame
        CType(Me.GridCobrosPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.suspendlayout()
        CType(Me.fwiSituacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraCobrosPagosDescontabilizar.SuspendLayout()
        Me.FraAptesDescont.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GridCobrosPagos.Size = New System.Drawing.Size(675, 148)
        Me.GridCobrosPagos.TabIndex = 3
        Me.GridCobrosPagos.Tag = "IdRec=4732:4361:4362:4710:4719:4629:4733:4713:4715:;"
        Me.GridCobrosPagos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridCobrosPagos.ViewName = "frmPagoDescont"
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
        Me.GridDiario.Size = New System.Drawing.Size(675, 271)
        Me.GridDiario.TabIndex = 4
        Me.GridDiario.Tag = "IdRec=4595:4734:4596:4735:4736:4737:4738:4739:;"
        Me.GridDiario.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridDiario.ViewName = "tbDiarioContable"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblcfwiSituacion)
        Me.Panel1.Controls.Add(Me.cmdCancelar)
        Me.Panel1.Controls.Add(Me.cmdAceptar)
        Me.Panel1.Controls.Add(Me.lblfwiSituacion)
        Me.Panel1.Controls.Add(Me.fwiSituacion)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 459)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(681, 40)
        Me.Panel1.TabIndex = 10
        '
        'lblcfwiSituacion
        '
        Me.TryDataBinding(lblcfwiSituacion, New System.Windows.Forms.Binding("Text", Me.fwiSituacion, "DescEstado", True))
        Me.lblcfwiSituacion.Location = New System.Drawing.Point(168, 8)
        Me.lblcfwiSituacion.Name = "lblcfwiSituacion"
        Me.lblcfwiSituacion.Size = New System.Drawing.Size(206, 22)
        Me.lblcfwiSituacion.TabIndex = 14
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.Location = New System.Drawing.Point(590, 8)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(79, 26)
        Me.cmdCancelar.TabIndex = 11
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAceptar.Enabled = False
        Me.cmdAceptar.Location = New System.Drawing.Point(502, 8)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(79, 26)
        Me.cmdAceptar.TabIndex = 10
        Me.cmdAceptar.Text = "Aceptar"
        '
        'lblfwiSituacion
        '
        Me.lblfwiSituacion.Location = New System.Drawing.Point(2, 8)
        Me.lblfwiSituacion.Name = "lblfwiSituacion"
        Me.lblfwiSituacion.Size = New System.Drawing.Size(79, 13)
        Me.lblfwiSituacion.TabIndex = 13
        Me.lblfwiSituacion.Tag = "IdRec=5097;"
        Me.lblfwiSituacion.Text = "Cambiar a..."
        '
        'fwiSituacion
        '
        fwiSituacion_DesignTimeLayout.LayoutString = resources.GetString("fwiSituacion_DesignTimeLayout.LayoutString")
        Me.fwiSituacion.DesignTimeLayout = fwiSituacion_DesignTimeLayout
        Me.fwiSituacion.DisabledBackColor = System.Drawing.Color.White
        Me.fwiSituacion.EntityName = "EstadoPago"
        Me.fwiSituacion.Location = New System.Drawing.Point(82, 8)
        Me.fwiSituacion.Name = "fwiSituacion"
        Me.fwiSituacion.PrimaryDataFields = "IDEstado"
        Me.fwiSituacion.SecondaryDataFields = "IDEstado"
        Me.fwiSituacion.SelectedIndex = -1
        Me.fwiSituacion.SelectedItem = Nothing
        Me.fwiSituacion.Size = New System.Drawing.Size(83, 21)
        Me.fwiSituacion.TabIndex = 12
        Me.fwiSituacion.ViewName = "cmbEstadoPago"
        '
        'FraCobrosPagosDescontabilizar
        '
        Me.FraCobrosPagosDescontabilizar.Controls.Add(Me.GridCobrosPagos)
        Me.FraCobrosPagosDescontabilizar.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraCobrosPagosDescontabilizar.Location = New System.Drawing.Point(0, 0)
        Me.FraCobrosPagosDescontabilizar.Name = "FraCobrosPagosDescontabilizar"
        Me.FraCobrosPagosDescontabilizar.Size = New System.Drawing.Size(681, 168)
        Me.FraCobrosPagosDescontabilizar.TabIndex = 11
        Me.FraCobrosPagosDescontabilizar.TabStop = False
        Me.FraCobrosPagosDescontabilizar.Text = "Cobros y Pagos a Descontabilizar"
        '
        'FraAptesDescont
        '
        Me.FraAptesDescont.Controls.Add(Me.GridDiario)
        Me.FraAptesDescont.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FraAptesDescont.Location = New System.Drawing.Point(0, 168)
        Me.FraAptesDescont.Name = "FraAptesDescont"
        Me.FraAptesDescont.Size = New System.Drawing.Size(681, 291)
        Me.FraAptesDescont.TabIndex = 12
        Me.FraAptesDescont.TabStop = False
        Me.FraAptesDescont.Text = "Apuntes a Descontabilizar"
        '
        'frmDescontabilizar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(681, 499)
        Me.Controls.Add(Me.FraAptesDescont)
        Me.Controls.Add(Me.FraCobrosPagosDescontabilizar)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmDescontabilizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Descontabilización"
        CType(Me.GridCobrosPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDiario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.fwiSituacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraCobrosPagosDescontabilizar.ResumeLayout(False)
        Me.FraAptesDescont.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private mblnLeassing As Boolean
    Public Structure tarray
        Public tam As Long
        Public LNAsiento() As String
    End Structure

    Public ListaIdDocumento() As Long
    Public ListaNAsiento() As tarray
    Private mContabilidadMultiple As Boolean
    Public Function AbrirFormulario(Optional ByVal blnLeassing As Boolean = False) As DialogResult
        mblnLeassing = blnLeassing

        Me.ShowDialog()

        Return Me.DialogResult
    End Function

    Private Sub frmDescontabilizar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadERPData()
            RefrescarGrids()
        End If
    End Sub

    Private Sub LoadERPData()
        Dim p As New Parametro
        fwiSituacion.Value = p.PagoDescontSituacion
        mContabilidadMultiple = p.ContabilidadMultiple
    End Sub

    Private Sub RefrescarGrids()
        'Inicializar Grid de Pagos
        Dim clsFilter As New Filter
        clsFilter.Add(New StringFilterItem("IdProcess", FilterOperator.Equal, mIDProcess.ToString))

        GridCobrosPagos.Filter = clsFilter
        GridCobrosPagos.ReQuery()

        FiltrarGridDiario()
    End Sub

    Private Sub FiltrarGridDiario()

        Dim dtPagos As DataTable = GridCobrosPagos.DataSource
        If Not dtPagos Is Nothing AndAlso dtPagos.Rows.Count > 0 Then
            Dim oFilterOR As New Filter
            oFilterOR.UnionOperator = FilterUnionOperator.Or

            Dim oFilterTipoApunteOR As New Filter
            oFilterTipoApunteOR.UnionOperator = FilterUnionOperator.Or

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

                oFilterTipoApunteOR.Clear()
                oFilterTipoApunteOR.Add("IDTipoApunte", FilterOperator.Equal, enumDiarioTipoApunte.Pago)
                oFilterTipoApunteOR.Add("IDTipoApunte", FilterOperator.Equal, enumDiarioTipoApunte.Compensacion)
                oFilterTipoApunteOR.Add("IDTipoApunte", FilterOperator.Equal, enumDiarioTipoApunte.Leasing)
                oFilter.Add(oFilterTipoApunteOR)

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
            If length(fwiSituacion.Value) > 0 Then intNuevaSituacion = fwiSituacion.Value
            If mblnLeassing Then
                Dim datDescont As New DataDescontabilizarLeasing(mIDProcess, intNuevaSituacion)
                ExpertisApp.ExecuteTask(Of DataDescontabilizarLeasing)(AddressOf ContabilizacionLeasing.Descontabilizar, datDescont)
            Else
                Dim datDescont As New DataDescontabilizacion(mIDProcess, intNuevaSituacion)
                ExpertisApp.ExecuteTask(Of DataDescontabilizacion)(AddressOf ContabilizacionPago.Descontabilizar, datDescont)
            End If
        Else
            Me.DialogResult = DialogResult.Cancel
        End If

        Me.Close()
    End Sub

    Private Function ComprobarDescuadreAsiento() As Boolean
        'Comprueba que todos los apuntes del grid pertenecientes a un mismo asiento estan cuadrados.
        'Tendremos asientos descuadrados en el grid cuando no se van a descontabilizar todos los cobros
        'que se han contabilizado agrupados por banco

        Dim dblDebeAsiento, dblHaberAsiento As Decimal
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

        Dim blnContinuar As Boolean
        If Length(strAsientosDescuadrados) > 0 Then
            'Si hay asientos descuadrados
            ExpertisApp.GenerateMessage("No se pueden borrar de forma automática algunos asientos porque se crearían asientos descuadrados. Debe descontabilizar de manera conjunta todos los pagos agrupados en los asientos: " & strAsientosDescuadrados & vbCrLf, MessageBoxButtons.OK, MessageBoxIcon.Information)
            blnContinuar = False
            'If ExpertisApp.GenerateMessage("No se pueden borrar de forma automática algunos asientos porque se crearian asientos descuadrados. Después de terminar este proceso se deben modificar manualmente los siguientes asientos: " & strAsientosDescuadrados & vbCrLf & "¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            '    blnContinuar = True
            '    blnBorrable = AsientosBorrables()
            'Else
            '    '//En este caso no se descontabilizaran los pagos
            '    blnContinuar = False
            'End If
        Else
            '//No hay asientos descuadrados
            blnContinuar = True
        End If


        If blnContinuar Then
            'Dim strMensaje As String
            'If blnBorrable Then    '// SI hay asientos descuadrados.
            '    strMensaje = "Se eliminarán todos los apuntes contables que no provocan descuadres. ¿Desea continuar?"
            'Else                    '// NO hay asientos descuadrados o sí los hay pero no se pueden borrar.
            '    If length(strAsientosDescuadrados) > 0 Then
            '        strMensaje = "Se eliminarán todos los apuntes contables que no provocan descuadres. ¿Desea continuar?"
            '    Else
            '        strMensaje = "Se eliminarán todos los apuntes contables de los pagos contabilizados seleccionados."
            '    End If
            'End If
            If ExpertisApp.GenerateMessage("Se eliminarán todos los apuntes contables que no provocan descuadres. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                blnContinuar = False
            Else
                blnContinuar = True
                'If Length(strAsientosDescuadrados) > 0 Then
                '    '// En el caso q haya un descuadre, se ponen a 'No Contabilizado' los pagos que
                '    '// se quieren descontabilizar.
                '    PagosDescuadradosPasarNoContabilizados()
                'End If
            End If
        End If

        ComprobarDescuadreAsiento = blnContinuar
    End Function

    Private Function AsientosBorrables() As Boolean
        AsientosBorrables = False
        Dim intIDDocumento As Integer = 0
        Dim intNDocumentos As Integer '//Contador de IDDocumento

        If Not IsNothing(GridDiario.DataSource) Then
            '//Guardamos los IDDocumento en un array
            For Each drApunte As DataRow In CType(GridDiario.DataSource, DataTable).Select(Nothing, "IDDocumento ASC")
                If intIDDocumento <> drApunte("IDDocumento") Then
                    intIDDocumento = drApunte("IDDocumento")
                    intNDocumentos = intNDocumentos + 1
                    ReDim Preserve ListaIdDocumento(intNDocumentos - 1)
                    ListaIdDocumento(intNDocumentos - 1) = intIDDocumento
                End If
            Next

            Dim intNAsiento As Integer
            '//Guardamos los NAsiento en un array
            ReDim ListaNAsiento(intNDocumentos - 1)
            For i As Integer = 0 To intNDocumentos - 1
                Dim objFilter As New Filter
                objFilter.Add(New NumberFilterItem("IDDocumento", ListaIdDocumento(i)))
                intNAsiento = 0
                For Each drApunte As DataRow In CType(GridDiario.DataSource, DataTable).Select(objFilter.Compose(New AdoFilterComposer), "NAsiento ASC")
                    If intNAsiento <> drApunte("NAsiento") Then
                        intNAsiento = drApunte("NAsiento")
                        ListaNAsiento(i).tam = ListaNAsiento(i).tam + 1
                        ReDim Preserve ListaNAsiento(i).LNAsiento(ListaNAsiento(i).tam - 1)
                        ListaNAsiento(i).LNAsiento(ListaNAsiento(i).tam - 1) = intNAsiento
                    End If
                Next
            Next i

            '//Comprobamos si podemos borrar cada uno de los asientos, si se borran completos.
            Dim dblDebeAsiento, dblHaberAsiento As Double
            For i As Integer = 0 To ListaIdDocumento.Length - 1
                For j As Integer = 0 To ListaNAsiento(i).tam - 1
                    Dim objFilter As New Filter
                    objFilter.Add(New NumberFilterItem("NAsiento", ListaNAsiento(i).LNAsiento(j)))
                    dblDebeAsiento = 0 : dblHaberAsiento = 0
                    For Each drApunte As DataRow In CType(GridDiario.DataSource, DataTable).Select(objFilter.Compose(New AdoFilterComposer), "NAsiento ASC")
                        dblDebeAsiento = dblDebeAsiento + drApunte("ImpDebeA")
                        dblHaberAsiento = dblHaberAsiento + drApunte("ImpHaberA")
                    Next
                    If dblDebeAsiento <> dblHaberAsiento Then
                        Exit For
                    Else
                        If j = ListaNAsiento(i).tam Then AsientosBorrables = True
                    End If
                Next j
            Next i
        End If
    End Function

    'Private Sub PagosDescuadradosPasarNoContabilizados()
    '    If Not IsNothing(GridCobrosPagos.DataSource) Then
    '        Dim oFilter As New Filter
    '        Dim oFilterOR As New Filter(FilterUnionOperator.Or)
    '        For Each drCobro As DataRow In CType(GridCobrosPagos.DataSource, DataTable).Rows
    '            oFilter.Clear()
    '            oFilter.Add("IDPago", FilterOperator.Equal, drCobro("IDCobroPago"))
    '            oFilter.Add("IDEjercicio", FilterOperator.Equal, drCobro("IDEjercicio"))
    '            oFilterOR.Add(oFilter)
    '        Next

    '        Dim objNegPago As New Pago
    '        Dim dtPagosDesCont As DataTable = objNegPago.Filter(oFilterOR)
    '        For Each drPago As DataRow In dtPagosDesCont.Select
    '            drPago("Contabilizado") = enumPagoContabilizado.PagoNoContabilizado
    '            drPago("IDEjercicio") = Nothing
    '        Next
    '        objNegPago.Update(dtPagosDesCont)
    '    End If
    'End Sub
End Class
