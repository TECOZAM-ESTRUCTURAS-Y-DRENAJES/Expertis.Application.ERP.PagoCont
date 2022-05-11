
Public Class frmConsultaAsientoRemesa
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
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents fwiTodosAsientos As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblfwiAsiento As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiAsiento As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents jngDiario As Solmicro.Expertis.Engine.UI.Grid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim jngDiario_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaAsientoRemesa))
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.fwiTodosAsientos = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblfwiAsiento = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiAsiento = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.jngDiario = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel1.suspendlayout()
        CType(Me.jngDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdAceptar)
        Me.Panel1.Controls.Add(Me.cmdCancelar)
        Me.Panel1.Controls.Add(Me.fwiTodosAsientos)
        Me.Panel1.Controls.Add(Me.lblfwiAsiento)
        Me.Panel1.Controls.Add(Me.fwiAsiento)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 358)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(707, 48)
        Me.Panel1.TabIndex = 7
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAceptar.Location = New System.Drawing.Point(495, 9)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(96, 30)
        Me.cmdAceptar.TabIndex = 8
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.Location = New System.Drawing.Point(599, 9)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(96, 30)
        Me.cmdCancelar.TabIndex = 7
        Me.cmdCancelar.Text = "Cancelar"
        '
        'fwiTodosAsientos
        '
        Me.fwiTodosAsientos.Location = New System.Drawing.Point(136, 12)
        Me.fwiTodosAsientos.Name = "fwiTodosAsientos"
        Me.fwiTodosAsientos.Size = New System.Drawing.Size(136, 32)
        Me.fwiTodosAsientos.TabIndex = 10
        Me.fwiTodosAsientos.Text = "Todos los Asientos"
        Me.fwiTodosAsientos.Visible = False
        '
        'lblfwiAsiento
        '
        Me.lblfwiAsiento.Location = New System.Drawing.Point(8, 21)
        Me.lblfwiAsiento.Name = "lblfwiAsiento"
        Me.lblfwiAsiento.Size = New System.Drawing.Size(49, 13)
        Me.lblfwiAsiento.TabIndex = 11
        Me.lblfwiAsiento.Text = "Asiento"
        Me.lblfwiAsiento.Visible = False
        '
        'fwiAsiento
        '
        Me.fwiAsiento.DisabledBackColor = System.Drawing.Color.White
        Me.fwiAsiento.Location = New System.Drawing.Point(57, 16)
        Me.fwiAsiento.Name = "fwiAsiento"
        Me.fwiAsiento.Size = New System.Drawing.Size(58, 23)
        Me.fwiAsiento.TabIndex = 9
        Me.fwiAsiento.Visible = False
        '
        'jngDiario
        '
        Me.jngDiario.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngDiario.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngDiario.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        jngDiario_DesignTimeLayout.LayoutString = resources.GetString("jngDiario_DesignTimeLayout.LayoutString")
        Me.jngDiario.DesignTimeLayout = jngDiario_DesignTimeLayout
        Me.jngDiario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngDiario.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngDiario.EntityName = ""
        Me.jngDiario.FrozenColumns = 2
        Me.jngDiario.Location = New System.Drawing.Point(0, 0)
        Me.jngDiario.Name = "jngDiario"
        Me.jngDiario.PrimaryDataFields = Nothing
        Me.jngDiario.RequeryManually = True
        Me.jngDiario.SecondaryDataFields = Nothing
        Me.jngDiario.Size = New System.Drawing.Size(707, 358)
        Me.jngDiario.TabIndex = 8
        Me.jngDiario.Tag = "IdRec=4595:4734:4596:4735:4736:4737:4738:4739:;"
        Me.jngDiario.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngDiario.ViewName = ""
        '
        'frmConsultaAsientoRemesa
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(707, 406)
        Me.Controls.Add(Me.jngDiario)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsultaAsientoRemesa"
        Me.Text = "Asiento"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.jngDiario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Propiedades "

    Private mintIdRemesa As Integer
    Public WriteOnly Property IDRemesa() As Integer
        Set(ByVal Value As Integer)
            mintIdRemesa = Value
        End Set
    End Property

    Private mTipoAsiento As enumDiarioTipoApunte
    Public WriteOnly Property TipoAsiento() As enumDiarioTipoApunte
        Set(ByVal Value As enumDiarioTipoApunte)
            mTipoAsiento = Value
        End Set
    End Property

    Private mlngAccion As enumTipoAccion
    Public WriteOnly Property Accion() As enumTipoAccion
        Set(ByVal Value As enumTipoAccion)
            mlngAccion = Value
        End Set
    End Property

    Private mdtAsientos As DataTable
    Public Property Asientos() As DataTable
        Get
            Return mdtAsientos
        End Get
        Set(ByVal Value As DataTable)
            mdtAsientos = Value
        End Set
    End Property

    Private mdtNAsientos As DataTable
    Public Property NAsientos() As DataTable
        Get
            Return mdtNAsientos
        End Get
        Set(ByVal Value As DataTable)
            mdtNAsientos = Value
        End Set
    End Property

#End Region

#Region " Enumerado (Tipo) "

    Public Enum enumTipoAccion
        Consulta = 0
        Eliminacion = 1
        Descontablizacion = 2
    End Enum

#End Region

#Region " Carga del formulario "

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '// Cambiar el título dependiendo de la acción que se vaya a realizar.
        If mTipoAsiento = enumDiarioTipoApunte.Remesa Then
            If mlngAccion = enumTipoAccion.Eliminacion Then
                Me.Text = "Eliminación de Asiento de Remesa"
            ElseIf mlngAccion = enumTipoAccion.Descontablizacion Then
                Me.Text = "Descontabilización de Asiento de Remesa"
            Else
                Me.Text = "Consulta de Asiento de Remesa"
            End If
        Else
            If mlngAccion = enumTipoAccion.Eliminacion Then
                Me.Text = "Eliminación de Asiento de Liquidación de Remesa"
            Else
                Me.Text = "Consulta de Asiento de Liquidación de Remesa"
            End If
        End If

        If mlngAccion <> enumTipoAccion.Consulta Then
            lblfwiAsiento.Visible = False
            fwiAsiento.Visible = False
            fwiTodosAsientos.Visible = False
        Else
            fwiTodosAsientos.Checked = False
            If Not IsNothing(mdtNAsientos) AndAlso mdtNAsientos.Rows.Count = 1 Then
                fwiAsiento.Text = mdtNAsientos.Rows(0)("NAsiento")
            End If
        End If

        jngDiario.DataSource = mdtAsientos
    End Sub

#End Region

#Region " Aceptar/Cancelar "

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Not IsNothing(mdtNAsientos) AndAlso mdtNAsientos.Rows.Count > 0 Then
            Dim diagResul As DialogResult
            If mTipoAsiento = enumDiarioTipoApunte.RemesaPago Then
                If mlngAccion = enumTipoAccion.Eliminacion Then
                    diagResul = ExpertisApp.GenerateMessage("Se eliminará el asiento de la Remesa.|¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, vbNewLine)
                ElseIf mlngAccion = enumTipoAccion.Descontablizacion Then
                    diagResul = ExpertisApp.GenerateMessage("Va a descontabilizar la remesa.|¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, vbNewLine)
                End If
            Else
                diagResul = ExpertisApp.GenerateMessage("se eliminará el asiento de la liquidación de la Remesa.|¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, vbNewLine)
            End If
            If mlngAccion <> enumTipoAccion.Consulta Then

                If diagResul = vbYes Then
                    If Not IsNothing(mdtNAsientos) AndAlso mdtNAsientos.Rows.Count > 0 Then
                        If mTipoAsiento = enumDiarioTipoApunte.RemesaPago Then
                            Dim descRemesa As New ContabilizacionEfectos.DataDescontabilizarRemesa
                            descRemesa.IDRemesa = mintIdRemesa
                            descRemesa.TodosAsientos = False
                            For Each row As DataRow In mdtNAsientos.Rows
                                descRemesa.NAsiento = row("NAsiento")
                                descRemesa.IDEjercicio = row("IDEjercicio")
                                ExpertisApp.ExecuteTask(Of ContabilizacionEfectos.DataDescontabilizarRemesa, Boolean)(AddressOf ContabilizacionEfectos.DescontabilizarRemesa, descRemesa)
                            Next row
                        End If
                    End If
                End If
            End If
        End If
        Me.Close()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

#End Region

End Class
