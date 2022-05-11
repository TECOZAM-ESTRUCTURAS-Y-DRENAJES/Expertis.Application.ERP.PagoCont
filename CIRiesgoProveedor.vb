Public Class CIRiesgoProveedor
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

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
    Friend WithEvents fwiIdProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblfwiIdProveedor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblcfwiIdProveedor As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents fwiSituacion As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblfwiSituacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblcfwiSituacion As Solmicro.Expertis.Engine.UI.UnderLineLabel
Friend WithEvents FraTotalRiesgo As Solmicro.Expertis.Engine.UI.Frame
Friend WithEvents fwiTotalRiesgo As Solmicro.Expertis.Engine.UI.NumericTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.fwiIdProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiIdProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiIdProveedor = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiSituacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblfwiSituacion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiSituacion = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.FraTotalRiesgo = New Solmicro.Expertis.Engine.UI.Frame
        Me.fwiTotalRiesgo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraTotalRiesgo.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.FraTotalRiesgo)
        Me.FilterPanel.Controls.Add(Me.lblfwiIdProveedor)
        Me.FilterPanel.Controls.Add(Me.lblfwiSituacion)
        Me.FilterPanel.Controls.Add(Me.lblcfwiIdProveedor)
        Me.FilterPanel.Controls.Add(Me.fwiIdProveedor)
        Me.FilterPanel.Controls.Add(Me.lblcfwiSituacion)
        Me.FilterPanel.Controls.Add(Me.fwiSituacion)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 353)
        Me.FilterPanel.Name = "FilterPanel"
        Me.FilterPanel.Size = New System.Drawing.Size(688, 72)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Name = "CIMntoGridPanel"
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(688, 353)
        '
        'Grid
        '
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""DescProveedo" & _
        "r""><Caption>Proveedor</Caption><DataMember>DescProveedor</DataMember><EditType>N" & _
        "oEdit</EditType><Key>DescProveedor</Key><Position>0</Position><TextAlignment>Nea" & _
        "r</TextAlignment><Width>147</Width></Column0><Column1 ID=""NFactura""><Caption>Nº." & _
        " Factura</Caption><DataMember>NFactura</DataMember><EditType>NoEdit</EditType><K" & _
        "ey>NFactura</Key><Position>1</Position><TextAlignment>Far</TextAlignment><Width>" & _
        "53</Width></Column1><Column2 ID=""FechaFactura""><Caption>Fecha Factura</Caption><" & _
        "DataMember>FechaFactura</DataMember><EditType>NoEdit</EditType><Key>FechaFactura" & _
        "</Key><Position>2</Position><TextAlignment>Near</TextAlignment><Width>80</Width>" & _
        "</Column2><Column3 ID=""ImpRiesgo""><Caption>Importe Riesgo</Caption><DataMember>I" & _
        "mpRiesgo</DataMember><EditType>NoEdit</EditType><HeaderAlignment>Far</HeaderAlig" & _
        "nment><Key>ImpRiesgo</Key><Position>3</Position><TextAlignment>Far</TextAlignmen" & _
        "t><Width>87</Width></Column3><Column4 ID=""Abreviatura""><Caption>Abreviatura</Cap" & _
        "tion><DataMember>Abreviatura</DataMember><EditType>NoEdit</EditType><Key>Abrevia" & _
        "tura</Key><Position>4</Position><TextAlignment>Near</TextAlignment><Width>27</Wi" & _
        "dth></Column4><Column5 ID=""ImpRiesgoA""><AggregateFunction>Sum</AggregateFunction" & _
        "><Caption>Importe Riesgo A</Caption><DataMember>ImpRiesgoA</DataMember><EditType" & _
        ">NoEdit</EditType><HeaderAlignment>Far</HeaderAlignment><Key>ImpRiesgoA</Key><Po" & _
        "sition>5</Position><TextAlignment>Far</TextAlignment><Width>87</Width></Column5>" & _
        "<Column6 ID=""FechaVencimiento""><Caption>Fecha  Vto.</Caption><DataMember>FechaVe" & _
        "ncimiento</DataMember><EditType>NoEdit</EditType><Key>FechaVencimiento</Key><Pos" & _
        "ition>6</Position><TextAlignment>Near</TextAlignment><Width>80</Width></Column6>" & _
        "<Column7 ID=""DescSituacion""><Caption>Situación</Caption><DataMember>DescSituacio" & _
        "n</DataMember><EditType>NoEdit</EditType><Key>DescSituacion</Key><Position>7</Po" & _
        "sition><TextAlignment>Near</TextAlignment><Width>87</Width></Column7><Column8 ID" & _
        "=""Situacion""><Caption>Situacion</Caption><DataMember>Situacion</DataMember><Edit" & _
        "Type>NoEdit</EditType><Key>Situacion</Key><Position>8</Position><TextAlignment>F" & _
        "ar</TextAlignment><Visible>False</Visible><Width>80</Width></Column8><Column9 ID" & _
        "=""IDProveedor""><Caption>IDProveedor</Caption><DataMember>IDProveedor</DataMember" & _
        "><EditType>NoEdit</EditType><Key>IDProveedor</Key><Position>9</Position><TextAli" & _
        "gnment>Near</TextAlignment><Visible>False</Visible></Column9></Columns><GroupCon" & _
        "dition ID="""" /><SortKeys Collection=""true""><SortKey0 ID=""SortKey0""><ColIndex>9</" & _
        "ColIndex></SortKey0></SortKeys></RootTable></GridEXLayoutData>"
        Me.Grid.DesignTimeLayout = GridEXLayout1
        Me.Grid.EntityName = "Pago"
        Me.Grid.KeyField = "IDPago"
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(688, 353)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "vctlCIPagoContRiesgoProveedor"
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.False
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Name = "MainPanelCIMntoContainer"
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(688, 425)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 26)
        Me.Menubar.Name = "Menubar"
        '
        'CheckAll
        '
        Me.CheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.False
        '
        'Toolbar
        '
        Me.Toolbar.Name = "Toolbar"
        Me.Toolbar.Size = New System.Drawing.Size(184, 26)
        '
        'UncheckAll
        '
        Me.UncheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.False
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Enabled = Janus.Windows.UI.InheritableBoolean.False
        '
        'ClearFilter
        '
        Me.ClearFilter.Enabled = Janus.Windows.UI.InheritableBoolean.False
        '
        'Export
        '
        Me.Export.Enabled = Janus.Windows.UI.InheritableBoolean.False
        '
        'MainPanel
        '
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(688, 425)
        '
        'fwiIdProveedor
        '
        Me.fwiIdProveedor.EntityName = "Proveedor"
        Me.fwiIdProveedor.Location = New System.Drawing.Point(80, 22)
        Me.fwiIdProveedor.Name = "fwiIdProveedor"
        Me.fwiIdProveedor.PrimaryDataFields = "IDProveedor"
        Me.fwiIdProveedor.SecondaryDataFields = "IDProveedor"
        Me.fwiIdProveedor.Size = New System.Drawing.Size(112, 23)
        Me.fwiIdProveedor.TabIndex = 0
        Me.fwiIdProveedor.ViewName = "tbMaestroProveedor"
        '
        'lblfwiIdProveedor
        '
        Me.lblfwiIdProveedor.Location = New System.Drawing.Point(13, 22)
        Me.lblfwiIdProveedor.Name = "lblfwiIdProveedor"
        Me.lblfwiIdProveedor.Size = New System.Drawing.Size(62, 17)
        Me.lblfwiIdProveedor.TabIndex = 0
        Me.lblfwiIdProveedor.Text = "Proveedor"
        '
        'lblcfwiIdProveedor
        '
        Me.TryDataBinding(lblcfwiIdProveedor, New System.Windows.Forms.Binding("Text", Me.fwiIdProveedor, "DescProveedor"))
        Me.lblcfwiIdProveedor.Location = New System.Drawing.Point(200, 22)
        Me.lblcfwiIdProveedor.Name = "lblcfwiIdProveedor"
        Me.lblcfwiIdProveedor.Size = New System.Drawing.Size(320, 21)
        Me.lblcfwiIdProveedor.TabIndex = 1
        '
        'fwiSituacion
        '
        GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition ID="""" /></RootTable><RowWithErrorsFo" & _
        "rmatStyle><PredefinedStyle>RowWithErrorsFormatStyle</PredefinedStyle></RowWithEr" & _
        "rorsFormatStyle><LinkFormatStyle><PredefinedStyle>LinkFormatStyle</PredefinedSty" & _
        "le></LinkFormatStyle><CardCaptionFormatStyle><PredefinedStyle>CardCaptionFormatS" & _
        "tyle</PredefinedStyle></CardCaptionFormatStyle><GroupByBoxFormatStyle><Predefine" & _
        "dStyle>GroupByBoxFormatStyle</PredefinedStyle></GroupByBoxFormatStyle><GroupByBo" & _
        "xInfoFormatStyle><PredefinedStyle>GroupByBoxInfoFormatStyle</PredefinedStyle></G" & _
        "roupByBoxInfoFormatStyle><GroupRowFormatStyle><PredefinedStyle>GroupRowFormatSty" & _
        "le</PredefinedStyle></GroupRowFormatStyle><HeaderFormatStyle><PredefinedStyle>He" & _
        "aderFormatStyle</PredefinedStyle></HeaderFormatStyle><PreviewRowFormatStyle><Pre" & _
        "definedStyle>PreviewRowFormatStyle</PredefinedStyle></PreviewRowFormatStyle><Row" & _
        "FormatStyle><PredefinedStyle>RowFormatStyle</PredefinedStyle></RowFormatStyle><S" & _
        "electedFormatStyle><PredefinedStyle>SelectedFormatStyle</PredefinedStyle></Selec" & _
        "tedFormatStyle><SelectedInactiveFormatStyle><PredefinedStyle>SelectedInactiveFor" & _
        "matStyle</PredefinedStyle></SelectedInactiveFormatStyle><WatermarkImage /><Borde" & _
        "rStyle>Flat</BorderStyle><FlatBorderColor>125, 159, 190</FlatBorderColor><Contro" & _
        "lStyle><ButtonAppearance>Flat</ButtonAppearance></ControlStyle><VisualStyle>Stan" & _
        "dard</VisualStyle><AllowEdit>False</AllowEdit><ExpandableGroups>False</Expandabl" & _
        "eGroups><GroupByBoxVisible>False</GroupByBoxVisible><HideSelection>Highlight</Hi" & _
        "deSelection></GridEXLayoutData>"
        Me.fwiSituacion.DesignTimeLayout = GridEXLayout2
        Me.fwiSituacion.EntityName = "EstadoPago"
        Me.fwiSituacion.Location = New System.Drawing.Point(80, 46)
        Me.fwiSituacion.Name = "fwiSituacion"
        Me.fwiSituacion.PrimaryDataFields = "IDEstado"
        Me.fwiSituacion.SecondaryDataFields = "IDEstado"
        Me.fwiSituacion.SelectedIndex = -1
        Me.fwiSituacion.SelectedItem = Nothing
        Me.fwiSituacion.Size = New System.Drawing.Size(88, 21)
        Me.fwiSituacion.TabIndex = 1
        Me.fwiSituacion.Value = Nothing
        Me.fwiSituacion.ViewName = "tbMaestroEstadoPago"
        '
        'lblfwiSituacion
        '
        Me.lblfwiSituacion.Location = New System.Drawing.Point(13, 46)
        Me.lblfwiSituacion.Name = "lblfwiSituacion"
        Me.lblfwiSituacion.Size = New System.Drawing.Size(57, 17)
        Me.lblfwiSituacion.TabIndex = 2
        Me.lblfwiSituacion.Text = "Situación"
        '
        'lblcfwiSituacion
        '
        Me.TryDataBinding(lblcfwiSituacion, New System.Windows.Forms.Binding("Text", Me.fwiSituacion, "Abreviatura"))
        Me.lblcfwiSituacion.Location = New System.Drawing.Point(175, 46)
        Me.lblcfwiSituacion.Name = "lblcfwiSituacion"
        Me.lblcfwiSituacion.Size = New System.Drawing.Size(207, 21)
        Me.lblcfwiSituacion.TabIndex = 3
        '
        'FraTotalRiesgo
        '
        Me.FraTotalRiesgo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FraTotalRiesgo.Controls.Add(Me.fwiTotalRiesgo)
        Me.FraTotalRiesgo.Location = New System.Drawing.Point(536, 0)
        Me.FraTotalRiesgo.Name = "FraTotalRiesgo"
        Me.FraTotalRiesgo.Size = New System.Drawing.Size(152, 72)
        Me.FraTotalRiesgo.TabIndex = 6
        Me.FraTotalRiesgo.TabStop = False
        Me.FraTotalRiesgo.Text = "Total Riesgo"
        '
        'fwiTotalRiesgo
        '
        Me.fwiTotalRiesgo.Enabled = False
        Me.fwiTotalRiesgo.Location = New System.Drawing.Point(8, 32)
        Me.fwiTotalRiesgo.Name = "fwiTotalRiesgo"
        Me.fwiTotalRiesgo.Size = New System.Drawing.Size(136, 21)
        Me.fwiTotalRiesgo.TabIndex = 6
        '
        'CIRiesgoProveedor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(696, 509)
        Me.EntityName = "Pago"
        Me.KeyField = "IDPago"
        Me.Name = "CIRiesgoProveedor"
        Me.ViewName = "vctlCIPagoContRiesgoProveedor"
        Me.FilterPanel.ResumeLayout(False)
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraTotalRiesgo.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CIRiesgoProveedor_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IdProveedor", FilterOperator.Equal, fwiIdProveedor.Text, FilterType.String)
        e.Filter.Add("Situacion", FilterOperator.Equal, fwiSituacion.Value, FilterType.Numeric)
    End Sub

    Private Sub CIPagoCont_QueryExecuted(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutedEventArgs) Handles MyBase.QueryExecuted
        fwiTotalRiesgo.Text = Grid.GetTotal(Grid.Columns("ImpRiesgoA"), Janus.Windows.GridEX.AggregateFunction.Sum)
    End Sub

    Private Sub CIRiesgoProveedor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadGridActions()
    End Sub

    Private Sub LoadGridActions()
        Me.Grid.Actions.Add("Abrir Proveedor", AddressOf AccionAbrirProveedor)
    End Sub

    Private Sub AccionAbrirProveedor()
        If ExpertisApp.IsFormOpen("MPROV") Then ExpertisApp.CloseForm("MPROV")
        ExpertisApp.OpenForm("MPROV", New FilterItem("IDProveedor", FilterOperator.Equal, Me.Grid.GetValue("IDProveedor")))
    End Sub

End Class