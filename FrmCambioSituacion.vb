Imports Janus.Windows.GridEX
Imports Solmicro.Expertis.Business.General
Imports Solmicro.Expertis.Business.Negocio

Public Class FrmCambioSituacion
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
    Friend WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents lblFwIFPagoNew As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaPago As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaPago As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents CbxNuevaSituacion As Solmicro.Expertis.Engine.UI.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim CbxNuevaSituacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCambioSituacion))
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cbxFechaPago = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.CbxNuevaSituacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblFwIFPagoNew = New Solmicro.Expertis.Engine.UI.Label
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel1.suspendlayout()
        CType(Me.CbxNuevaSituacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbxFechaPago)
        Me.Panel1.Controls.Add(Me.lblFechaPago)
        Me.Panel1.Controls.Add(Me.CbxNuevaSituacion)
        Me.Panel1.Controls.Add(Me.lblFwIFPagoNew)
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 249)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(699, 40)
        Me.Panel1.TabIndex = 4
        '
        'cbxFechaPago
        '
        Me.cbxFechaPago.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaPago.Location = New System.Drawing.Point(371, 11)
        Me.cbxFechaPago.Name = "cbxFechaPago"
        Me.cbxFechaPago.Size = New System.Drawing.Size(104, 21)
        Me.cbxFechaPago.TabIndex = 31
        '
        'lblFechaPago
        '
        Me.lblFechaPago.Location = New System.Drawing.Point(290, 11)
        Me.lblFechaPago.Name = "lblFechaPago"
        Me.lblFechaPago.Size = New System.Drawing.Size(72, 13)
        Me.lblFechaPago.TabIndex = 30
        Me.lblFechaPago.Text = "Fecha Pago"
        '
        'CbxNuevaSituacion
        '
        CbxNuevaSituacion_DesignTimeLayout.LayoutString = resources.GetString("CbxNuevaSituacion_DesignTimeLayout.LayoutString")
        Me.CbxNuevaSituacion.DesignTimeLayout = CbxNuevaSituacion_DesignTimeLayout
        Me.CbxNuevaSituacion.DisabledBackColor = System.Drawing.Color.White
        Me.CbxNuevaSituacion.Location = New System.Drawing.Point(137, 11)
        Me.CbxNuevaSituacion.Name = "CbxNuevaSituacion"
        Me.CbxNuevaSituacion.SelectedIndex = -1
        Me.CbxNuevaSituacion.SelectedItem = Nothing
        Me.CbxNuevaSituacion.Size = New System.Drawing.Size(104, 21)
        Me.CbxNuevaSituacion.TabIndex = 29
        '
        'lblFwIFPagoNew
        '
        Me.lblFwIFPagoNew.Location = New System.Drawing.Point(6, 11)
        Me.lblFwIFPagoNew.Name = "lblFwIFPagoNew"
        Me.lblFwIFPagoNew.Size = New System.Drawing.Size(131, 13)
        Me.lblFwIFPagoNew.TabIndex = 28
        Me.lblFwIFPagoNew.Text = "Nueva Situación Pago"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Location = New System.Drawing.Point(600, 6)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(90, 28)
        Me.cmbCancelar.TabIndex = 8
        Me.cmbCancelar.Text = "Cancelar"
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(504, 6)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(90, 28)
        Me.cmbAceptar.TabIndex = 7
        Me.cmbAceptar.Text = "Aceptar"
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
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.SecondaryDataFields = Nothing
        Me.Grid.Size = New System.Drawing.Size(699, 249)
        Me.Grid.TabIndex = 5
        Me.Grid.Tag = ""
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = Nothing
        '
        'FrmCambioSituacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(699, 289)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmCambioSituacion"
        Me.Text = "Cambio Situación Pagos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CbxNuevaSituacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mblnContabilizar As Boolean
    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.AllRecords
        End Get
    End Property
    Public ReadOnly Property BlnContabilizar() As Boolean
        Get
            Return mblnContabilizar
        End Get
    End Property

    Public Sub AbrirCambioSituacion(ByVal dtPagos As DataTable, ByVal OwnerForm As FormBase)

        With Grid
            .EntityName = "Pago"
            .ViewName = "tbPago"

            Dim c As New EstadoPago

            Dim f As New Filter
            'f.Add(New NumberFilterItem("IDEstado", FilterOperator.NotEqual, enumPagoSituacion.Pagado))
            f.Add(New NumberFilterItem("IDEstado", FilterOperator.NotEqual, enumPagoSituacion.GeneradoCobro))

            Dim dt As DataTable = c.Filter(f, "Abreviatura")

            .Columns("AbrvSituacion").DropDown.SetDataBinding(dt, String.Empty)

            CbxNuevaSituacion.DataSource = dt

            f.Clear()
            f.UnionOperator = FilterUnionOperator.Or
            For Each dr As DataRowView In dtPagos.DefaultView
                f.Add(New NumberFilterItem("IDPago", FilterOperator.Equal, dr("IDPago")))
            Next
            If f.Count = 0 Then f.Add(New NoRowsFilterItem)
            .Filter = f

            Me.ShowDialog(OwnerForm)
        End With
    End Sub

    Private Sub FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        If e.Row.RowType = RowType.Record Then
            If e.Row.Cells("Contabilizado").Value Then
                e.Row.Cells("Contabilizado").ImageIndex = IconIndex.Contabilizado
            Else
                e.Row.Cells("Contabilizado").ImageIndex = IconIndex.NoContabilizado
            End If
        End If
    End Sub

    Private Sub CmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Dim datosCambio As New Pago.DataCambioSituacionManual
        datosCambio.Pagos = Grid.DataSource
        If Length(CbxNuevaSituacion.Text) > 0 Then datosCambio.NuevaSituacion = CInt(CbxNuevaSituacion.Value)
        If Length(cbxFechaPago.Value) > 0 Then datosCambio.NuevaFechaPago = cbxFechaPago.Value
        Dim Errores As ClassErrors() = ExpertisApp.ExecuteTask(Of Pago.DataCambioSituacionManual, ClassErrors())(AddressOf Pago.CambioSituacionManual, datosCambio)
        If Not Errores Is Nothing Then
            Dim strExisteCNC As String
            For i As Integer = 0 To Errores.Length - 1
                If Errores(i).MessageError = CStr(enumResultadoCambioPagos.PagadoNoContabilizado) Then
                    If Len(strExisteCNC) > 0 Then strExisteCNC = strExisteCNC & ","
                    Dim DrEr() As DataRow = datosCambio.Pagos.Select("IDPago = " & CInt(Errores(i).Elements))
                    If DrEr.Length > 0 Then
                        If Len(strExisteCNC) > 0 Then strExisteCNC = strExisteCNC & ","
                        strExisteCNC = strExisteCNC & DrEr(0)("NFactura")
                    End If
                End If
            Next
            If New Parametro().Contabilidad Then
                If Len(strExisteCNC) > 0 Then
                    If ExpertisApp.GenerateMessage("Los Pagos de las Facturas:{0} están No Contabilizados.{1} ¿Desea contabilizarlos?", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, Quoted(strExisteCNC), vbNewLine) = DialogResult.Yes Then
                        mblnContabilizar = True
                    Else
                        mblnContabilizar = False
                    End If
                Else
                    mblnContabilizar = False
                End If
            End If
        End If
        If mblnContabilizar Then
            Me.DialogResult = DialogResult.OK
        Else : Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub cmbCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.Close()
    End Sub

    Private Sub CbxNuevaSituacion_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxNuevaSituacion.Validated
        If Length(Me.CbxNuevaSituacion.Value) > 0 AndAlso Me.CbxNuevaSituacion.Value = enumPagoSituacion.Pagado Then
            Me.lblFechaPago.Visible = True
            Me.cbxFechaPago.Visible = True
        Else
            Me.lblFechaPago.Visible = False
            Me.cbxFechaPago.Visible = False
        End If
    End Sub

    Private Sub FrmCambioSituacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CbxNuevaSituacion_Validated(Nothing, Nothing)
    End Sub
End Class
