Public Class MntoTipoPago
    Inherits Solmicro.Expertis.Engine.UI.GridMnto

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        '
        'Toolbar
        '
        Me.Toolbar.Name = "Toolbar"
        Me.Toolbar.Size = New System.Drawing.Size(408, 26)
        '
        'Grid
        '
        Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDAgrupacion", "Agrupacion", "IDAgrupacion")})
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IdTipoPago"">" & _
        "<Caption>Tipo Pago</Caption><DataMember>IdTipoPago</DataMember><Key>IdTipoPago</" & _
        "Key><Position>0</Position><TextAlignment>Far</TextAlignment><Width>82</Width></C" & _
        "olumn0><Column1 ID=""DescTipo""><Caption>Desc. Tipo</Caption><DataMember>DescTipo<" & _
        "/DataMember><Key>DescTipo</Key><Position>1</Position><TextAlignment>Near</TextAl" & _
        "ignment><Width>265</Width></Column1><Column2 ID=""Abreviatura""><Caption>Abreviatu" & _
        "ra</Caption><DataMember>Abreviatura</DataMember><Key>Abreviatura</Key><Position>" & _
        "2</Position><TextAlignment>Near</TextAlignment><Width>104</Width></Column2><Colu" & _
        "mn3 ID=""Sistema""><Caption>Sistema</Caption><DataMember>Sistema</DataMember><Key>" & _
        "Sistema</Key><Position>3</Position><TextAlignment>Near</TextAlignment><Visible>F" & _
        "alse</Visible><DefaultValue>False</DefaultValue></Column3><Column4 ID=""IDAgrupac" & _
        "ion""><Caption>Agrupación</Caption><DataMember>IDAgrupacion</DataMember><Key>IDAg" & _
        "rupacion</Key><Position>4</Position><TextAlignment>Near</TextAlignment><Width>94" & _
        "</Width></Column4><Column5 ID=""Especial""><Caption>Especial</Caption><ColumnType>" & _
        "CheckBox</ColumnType><DataMember>Especial</DataMember><EditType>CheckBox</EditTy" & _
        "pe><HeaderAlignment>Center</HeaderAlignment><Key>Especial</Key><Position>5</Posi" & _
        "tion><Width>62</Width><DefaultValue>False</DefaultValue></Column5><Column6 ID=""L" & _
        "easingSN""><Caption>Leasing</Caption><ColumnType>CheckBox</ColumnType><DataMember" & _
        ">LeasingSN</DataMember><EditType>CheckBox</EditType><HeaderAlignment>Center</Hea" & _
        "derAlignment><Key>LeasingSN</Key><Position>6</Position><TextAlignment>Center</Te" & _
        "xtAlignment><Width>61</Width><DefaultValue>False</DefaultValue></Column6></Colum" & _
        "ns><GroupCondition ID="""" /></RootTable></GridEXLayoutData>"
        Me.Grid.DesignTimeLayout = GridEXLayout1
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EntityName = "TipoPago"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(688, 425)
        Me.Grid.ViewName = "vfrmMntoTipoPago"
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 26)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(696, 24)
        '
        'MainPanel
        '
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(688, 425)
        '
        'MntoTipoPago
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(696, 509)
        Me.EntityName = "TipoPago"
        Me.Name = "MntoTipoPago"
        Me.ViewName = "vfrmMntoTipoPago"
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Grid_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        With Grid
            If .Value("Sistema") Then
                e.Cancel = True
                .Columns(e.Column.Key).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
            ElseIf .Row = Grid.newTopRowPosition Or e.Column.Index = .Columns("IDAgrupacion").Index Then
                .Columns("IDAgrupacion").ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image
            ElseIf e.Column.Index = .Columns("IdTipoPago").Index Then
                e.Cancel = True
            End If
        End With
    End Sub
End Class
