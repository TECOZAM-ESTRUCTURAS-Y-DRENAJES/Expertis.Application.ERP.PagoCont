Imports Solmicro.Expertis.Business.Negocio

Public Class FrmActualizacion
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
    Friend WithEvents FrmActualizLeasing As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents LblFechaUltPagoCont As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ClbFechaUltPagoCont As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents LblTipoInteresAplAnt As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblBaseCalculo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblTipoInteresAnt As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents CmbBaseCalculo As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents NtbTipoIntAplAnt As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents NtbTipoInteresAnt As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents LblTipoIntAplAct As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblTipoInteresAct As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblFechaActua As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ChkInteresPostPagable As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents ClbFechaActua As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents NtbTipoIntAplAct As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents NtbTipoIntAct As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents BtnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnCancelar As Solmicro.Expertis.Engine.UI.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.FrmActualizLeasing = New Solmicro.Expertis.Engine.UI.Frame
        Me.LblTipoIntAplAct = New Solmicro.Expertis.Engine.UI.Label
        Me.LblTipoInteresAct = New Solmicro.Expertis.Engine.UI.Label
        Me.LblFechaActua = New Solmicro.Expertis.Engine.UI.Label
        Me.LblTipoInteresAplAnt = New Solmicro.Expertis.Engine.UI.Label
        Me.LblBaseCalculo = New Solmicro.Expertis.Engine.UI.Label
        Me.LblTipoInteresAnt = New Solmicro.Expertis.Engine.UI.Label
        Me.LblFechaUltPagoCont = New Solmicro.Expertis.Engine.UI.Label
        Me.CmbBaseCalculo = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.ChkInteresPostPagable = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.ClbFechaActua = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.ClbFechaUltPagoCont = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.NtbTipoIntAplAct = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbTipoIntAct = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbTipoIntAplAnt = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbTipoInteresAnt = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.BtnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.FrmActualizLeasing.SuspendLayout()
        Me.SuspendLayout()
        '
        'FrmActualizLeasing
        '
        Me.FrmActualizLeasing.Controls.Add(Me.LblTipoIntAplAct)
        Me.FrmActualizLeasing.Controls.Add(Me.LblTipoInteresAct)
        Me.FrmActualizLeasing.Controls.Add(Me.LblFechaActua)
        Me.FrmActualizLeasing.Controls.Add(Me.LblTipoInteresAplAnt)
        Me.FrmActualizLeasing.Controls.Add(Me.LblBaseCalculo)
        Me.FrmActualizLeasing.Controls.Add(Me.LblTipoInteresAnt)
        Me.FrmActualizLeasing.Controls.Add(Me.LblFechaUltPagoCont)
        Me.FrmActualizLeasing.Controls.Add(Me.CmbBaseCalculo)
        Me.FrmActualizLeasing.Controls.Add(Me.ChkInteresPostPagable)
        Me.FrmActualizLeasing.Controls.Add(Me.ClbFechaActua)
        Me.FrmActualizLeasing.Controls.Add(Me.ClbFechaUltPagoCont)
        Me.FrmActualizLeasing.Controls.Add(Me.NtbTipoIntAplAct)
        Me.FrmActualizLeasing.Controls.Add(Me.NtbTipoIntAct)
        Me.FrmActualizLeasing.Controls.Add(Me.NtbTipoIntAplAnt)
        Me.FrmActualizLeasing.Controls.Add(Me.NtbTipoInteresAnt)
        Me.FrmActualizLeasing.Location = New System.Drawing.Point(8, 8)
        Me.FrmActualizLeasing.Name = "FrmActualizLeasing"
        Me.FrmActualizLeasing.Size = New System.Drawing.Size(568, 176)
        Me.FrmActualizLeasing.TabIndex = 0
        Me.FrmActualizLeasing.TabStop = False
        Me.FrmActualizLeasing.Text = "Actualización de los Leasing"
        '
        'LblTipoIntAplAct
        '
        Me.LblTipoIntAplAct.Location = New System.Drawing.Point(288, 144)
        Me.LblTipoIntAplAct.Name = "LblTipoIntAplAct"
        Me.LblTipoIntAplAct.Size = New System.Drawing.Size(151, 17)
        Me.LblTipoIntAplAct.TabIndex = 14
        Me.LblTipoIntAplAct.Text = "Tipo Interés Aplicado Act."
        Me.LblTipoIntAplAct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTipoInteresAct
        '
        Me.LblTipoInteresAct.Location = New System.Drawing.Point(288, 64)
        Me.LblTipoInteresAct.Name = "LblTipoInteresAct"
        Me.LblTipoInteresAct.Size = New System.Drawing.Size(99, 17)
        Me.LblTipoInteresAct.TabIndex = 13
        Me.LblTipoInteresAct.Text = "Tipo Interés Act."
        Me.LblTipoInteresAct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblFechaActua
        '
        Me.LblFechaActua.Location = New System.Drawing.Point(288, 24)
        Me.LblFechaActua.Name = "LblFechaActua"
        Me.LblFechaActua.Size = New System.Drawing.Size(115, 17)
        Me.LblFechaActua.TabIndex = 12
        Me.LblFechaActua.Text = "Fecha Actualización"
        Me.LblFechaActua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTipoInteresAplAnt
        '
        Me.LblTipoInteresAplAnt.Location = New System.Drawing.Point(8, 144)
        Me.LblTipoInteresAplAnt.Name = "LblTipoInteresAplAnt"
        Me.LblTipoInteresAplAnt.Size = New System.Drawing.Size(152, 17)
        Me.LblTipoInteresAplAnt.TabIndex = 11
        Me.LblTipoInteresAplAnt.Text = "Tipo Interés Aplicado Ant."
        Me.LblTipoInteresAplAnt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblBaseCalculo
        '
        Me.LblBaseCalculo.Location = New System.Drawing.Point(8, 104)
        Me.LblBaseCalculo.Name = "LblBaseCalculo"
        Me.LblBaseCalculo.Size = New System.Drawing.Size(94, 17)
        Me.LblBaseCalculo.TabIndex = 10
        Me.LblBaseCalculo.Text = "Base de Cálculo"
        Me.LblBaseCalculo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTipoInteresAnt
        '
        Me.LblTipoInteresAnt.Location = New System.Drawing.Point(8, 64)
        Me.LblTipoInteresAnt.Name = "LblTipoInteresAnt"
        Me.LblTipoInteresAnt.TabIndex = 9
        Me.LblTipoInteresAnt.Text = "Tipo Interés Ant."
        Me.LblTipoInteresAnt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblFechaUltPagoCont
        '
        Me.LblFechaUltPagoCont.Location = New System.Drawing.Point(8, 24)
        Me.LblFechaUltPagoCont.Name = "LblFechaUltPagoCont"
        Me.LblFechaUltPagoCont.Size = New System.Drawing.Size(127, 17)
        Me.LblFechaUltPagoCont.TabIndex = 8
        Me.LblFechaUltPagoCont.Text = "Fecha Ult. Pago Cont."
        Me.LblFechaUltPagoCont.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbBaseCalculo
        '
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition ID="""" /></RootTable><RowWithErrorsFo" & _
        "rmatStyle><PredefinedStyle>RowWithErrorsFormatStyle</PredefinedStyle></RowWithEr" & _
        "rorsFormatStyle><LinkFormatStyle><PredefinedStyle>LinkFormatStyle</PredefinedSty" & _
        "le></LinkFormatStyle><CardCaptionFormatStyle><PredefinedStyle>CardCaptionFormatS" & _
        "tyle</PredefinedStyle></CardCaptionFormatStyle><GroupByBoxInfoFormatStyle><Prede" & _
        "finedStyle>GroupByBoxInfoFormatStyle</PredefinedStyle></GroupByBoxInfoFormatStyl" & _
        "e><GroupRowFormatStyle><PredefinedStyle>GroupRowFormatStyle</PredefinedStyle></G" & _
        "roupRowFormatStyle><HeaderFormatStyle><PredefinedStyle>HeaderFormatStyle</Predef" & _
        "inedStyle></HeaderFormatStyle><PreviewRowFormatStyle><PredefinedStyle>PreviewRow" & _
        "FormatStyle</PredefinedStyle></PreviewRowFormatStyle><RowFormatStyle><Predefined" & _
        "Style>RowFormatStyle</PredefinedStyle></RowFormatStyle><SelectedFormatStyle><Pre" & _
        "definedStyle>SelectedFormatStyle</PredefinedStyle></SelectedFormatStyle><Selecte" & _
        "dInactiveFormatStyle><PredefinedStyle>SelectedInactiveFormatStyle</PredefinedSty" & _
        "le></SelectedInactiveFormatStyle><WatermarkImage /><BorderStyle>Flat</BorderStyl" & _
        "e><FlatBorderColor>125, 159, 190</FlatBorderColor><ControlStyle><ButtonAppearanc" & _
        "e>Flat</ButtonAppearance></ControlStyle><VisualStyle>Standard</VisualStyle><Allo" & _
        "wEdit>False</AllowEdit><ExpandableGroups>False</ExpandableGroups><GroupByBoxVisi" & _
        "ble>False</GroupByBoxVisible><HideSelection>Highlight</HideSelection></GridEXLay" & _
        "outData>"
        Me.CmbBaseCalculo.DesignTimeLayout = GridEXLayout1
        Me.CmbBaseCalculo.Enabled = False
        Me.CmbBaseCalculo.Location = New System.Drawing.Point(168, 104)
        Me.CmbBaseCalculo.Name = "CmbBaseCalculo"
        Me.CmbBaseCalculo.SelectedIndex = -1
        Me.CmbBaseCalculo.SelectedItem = Nothing
        Me.CmbBaseCalculo.Size = New System.Drawing.Size(104, 21)
        Me.CmbBaseCalculo.TabIndex = 7
        Me.CmbBaseCalculo.TabStop = False
        Me.CmbBaseCalculo.Value = Nothing
        '
        'ChkInteresPostPagable
        '
        Me.ChkInteresPostPagable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkInteresPostPagable.Location = New System.Drawing.Point(288, 104)
        Me.ChkInteresPostPagable.Name = "ChkInteresPostPagable"
        Me.ChkInteresPostPagable.Size = New System.Drawing.Size(176, 23)
        Me.ChkInteresPostPagable.TabIndex = 2
        Me.ChkInteresPostPagable.Text = "Intereses PostPagables"
        '
        'ClbFechaActua
        '
        Me.ClbFechaActua.Location = New System.Drawing.Point(448, 24)
        Me.ClbFechaActua.Name = "ClbFechaActua"
        Me.ClbFechaActua.Size = New System.Drawing.Size(104, 21)
        Me.ClbFechaActua.TabIndex = 0
        '
        'ClbFechaUltPagoCont
        '
        Me.ClbFechaUltPagoCont.Enabled = False
        Me.ClbFechaUltPagoCont.Location = New System.Drawing.Point(168, 24)
        Me.ClbFechaUltPagoCont.Name = "ClbFechaUltPagoCont"
        Me.ClbFechaUltPagoCont.Size = New System.Drawing.Size(104, 21)
        Me.ClbFechaUltPagoCont.TabIndex = 4
        Me.ClbFechaUltPagoCont.TabStop = False
        '
        'NtbTipoIntAplAct
        '
        Me.NtbTipoIntAplAct.Enabled = False
        Me.NtbTipoIntAplAct.Location = New System.Drawing.Point(448, 144)
        Me.NtbTipoIntAplAct.Name = "NtbTipoIntAplAct"
        Me.NtbTipoIntAplAct.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.NtbTipoIntAplAct.Size = New System.Drawing.Size(104, 21)
        Me.NtbTipoIntAplAct.TabIndex = 3
        '
        'NtbTipoIntAct
        '
        Me.NtbTipoIntAct.Location = New System.Drawing.Point(448, 64)
        Me.NtbTipoIntAct.Name = "NtbTipoIntAct"
        Me.NtbTipoIntAct.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.NtbTipoIntAct.Size = New System.Drawing.Size(104, 21)
        Me.NtbTipoIntAct.TabIndex = 1
        '
        'NtbTipoIntAplAnt
        '
        Me.NtbTipoIntAplAnt.Enabled = False
        Me.NtbTipoIntAplAnt.Location = New System.Drawing.Point(168, 144)
        Me.NtbTipoIntAplAnt.Name = "NtbTipoIntAplAnt"
        Me.NtbTipoIntAplAnt.Size = New System.Drawing.Size(104, 21)
        Me.NtbTipoIntAplAnt.TabIndex = 1
        Me.NtbTipoIntAplAnt.TabStop = False
        '
        'NtbTipoInteresAnt
        '
        Me.NtbTipoInteresAnt.Enabled = False
        Me.NtbTipoInteresAnt.Location = New System.Drawing.Point(168, 64)
        Me.NtbTipoInteresAnt.Name = "NtbTipoInteresAnt"
        Me.NtbTipoInteresAnt.Size = New System.Drawing.Size(104, 21)
        Me.NtbTipoInteresAnt.TabIndex = 0
        Me.NtbTipoInteresAnt.TabStop = False
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(384, 192)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(88, 32)
        Me.BtnAceptar.TabIndex = 4
        Me.BtnAceptar.Text = "&Aceptar"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(480, 192)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(88, 32)
        Me.BtnCancelar.TabIndex = 5
        Me.BtnCancelar.Text = "&Cancelar"
        '
        'FrmActualizacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(586, 231)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.FrmActualizLeasing)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmActualizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmActualizacion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.FrmActualizLeasing.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Variables / Propiedades Públicas"

    Private LngID, LngBaseCalc As Long
    Private DblTipoInt, DblTipoIntApl, DblTipoIntAct, DblTipoIntAplAct As Double
    Private StrBancoPropio As String
    Private BlnPrePagable As Boolean
    Private DTEFecha As Date

    Public Property ID() As Long
        Get
            Return LngID
        End Get
        Set(ByVal Value As Long)
            LngID = Value
        End Set
    End Property

    Public Property BaseCalculo() As Long
        Get
            Return LngBaseCalc
        End Get
        Set(ByVal Value As Long)
            LngBaseCalc = Value
        End Set
    End Property

    Public Property TipoInteres() As Double
        Get
            Return DblTipoInt
        End Get
        Set(ByVal Value As Double)
            DblTipoInt = Value
        End Set
    End Property

    Public Property TipoInteresAplicado() As Double
        Get
            Return DblTipoIntApl
        End Get
        Set(ByVal Value As Double)
            DblTipoIntApl = Value
        End Set
    End Property

    Public Property BancoPropio() As String
        Get
            Return StrBancoPropio
        End Get
        Set(ByVal Value As String)
            StrBancoPropio = Value
        End Set
    End Property

    Public Property PrePagable() As Boolean
        Get
            Return BlnPrePagable
        End Get
        Set(ByVal Value As Boolean)
            BlnPrePagable = Value
        End Set
    End Property

    Public Property Fecha() As Date
        Get
            Return DTEFecha
        End Get
        Set(ByVal Value As Date)
            DTEFecha = Value
        End Set
    End Property

    Public Property TipoIntAct() As Double
        Get
            Return DblTipoIntAct
        End Get
        Set(ByVal Value As Double)
            DblTipoIntAct = Value
        End Set
    End Property

    Public Property TipoIntAplAct() As Double
        Get
            Return DblTipoIntAplAct
        End Get
        Set(ByVal Value As Double)
            DblTipoIntAplAct = Value
        End Set
    End Property

#End Region

#Region "Eventos FrmActualizacion"

#Region "Eventos Formulario"

    Private Sub FrmActualizacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CmbBaseCalculo.DataSource = New EnumData("enumpaBaseCalculoLeasing")
        NtbTipoInteresAnt.Value = DblTipoInt
        NtbTipoIntAplAnt.Value = DblTipoIntApl
        CmbBaseCalculo.Value = LngBaseCalc
        ChkInteresPostPagable.Checked = BlnPrePagable
        Dim ClsPago As New Pago
        Dim f As New Filter
        f.Add(New NumberFilterItem("IdPagoPeriodo", LngID))
        f.Add(New NumberFilterItem("Contabilizado", FilterOperator.NotEqual, 1))
        Dim DtPago As DataTable = ClsPago.Filter(f, "FechaVencimiento", "FechaVencimiento")
        If Not DtPago Is Nothing AndAlso DtPago.Rows.Count > 0 Then
            If Length(DtPago.Rows(0)("FechaVencimiento") & String.Empty) > 0 Then ClbFechaUltPagoCont.Value = DtPago.Rows(0)("FechaVencimiento")
        End If
        ClbFechaActua.Value = ClbFechaUltPagoCont.Value
    End Sub

#End Region

#Region "Eventos NumericTextBox"

    Private Sub NtbTipoIntAct_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles NtbTipoIntAct.Validated
        Dim ClsBPFF As New BancoPropioFormFinanc
        Dim DtBPFF As New DataTable
        Dim DblIntApl As Double
        DtBPFF = ClsBPFF.Filter(New StringFilterItem("IDBancoPropio", StrBancoPropio), "", "fCalculoInteresAplicado")
        If Not DtBPFF Is Nothing AndAlso DtBPFF.Rows.Count > 0 Then
            If Length(DtBPFF.Rows(0)("fCalculoInteresAplicado") & String.Empty) > 0 Then
                DblIntApl = CallByName(ClsBPFF, DtBPFF.Rows(0)("fCalculoInteresAplicado"), vbMethod, CmbBaseCalculo.Value, NtbTipoIntAct.Value)
                NtbTipoIntAplAct.Value = DblIntApl
            End If
        Else
            ExpertisApp.GenerateMessage("No está establecida la fórmula del cálculo de interés aplicado para ese banco.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            NtbTipoIntAplAct.Value = NtbTipoIntAct.Value
        End If
    End Sub

#End Region

#Region "Eventos Botones"

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If (Length(ClbFechaActua.Value) = 0 OrElse Length(NtbTipoIntAct.Value) = 0) Then
            ExpertisApp.GenerateMessage("Debe indicar la fecha de actualización y el Tipo de Actulización.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.DialogResult = DialogResult.Cancel
            Exit Sub
        Else
            DTEFecha = ClbFechaActua.Value
            DblTipoIntAct = NtbTipoIntAct.Value
            DblTipoIntAplAct = NtbTipoIntAplAct.Value
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

#End Region

#End Region

End Class
