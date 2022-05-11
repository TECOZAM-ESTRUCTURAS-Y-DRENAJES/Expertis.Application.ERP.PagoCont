Imports Solmicro.Expertis.Business.Negocio

Public Class CIPagosMasivos
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
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents txtDescripcion As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblDescripcion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtPeriodo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblPeriodo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxUnidad As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblUnidad As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTipoPago As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaFinDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaFinDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaFinHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaFinHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaIniDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaIniDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaIniHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaIniHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblImpHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblImpDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaUltimaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaUltimaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaUltimaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaUltimaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxTipoPago As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblFechaFinal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaFinal As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents txtImpDesde As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtImpHasta As Solmicro.Expertis.Engine.UI.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CIPagosMasivos))
        Dim GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout3 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.txtDescripcion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblDescripcion = New Solmicro.Expertis.Engine.UI.Label
        Me.txtPeriodo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblPeriodo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxUnidad = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblUnidad = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTipoPago = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaFinDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaFinDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaFinHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaFinHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaIniDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaIniDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaIniHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaIniHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.lblImpHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.lblImpDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaUltimaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaUltimaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaUltimaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaUltimaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxTipoPago = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cbxFechaFinal = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaFinal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpDesde = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtImpHasta = New Solmicro.Expertis.Engine.UI.TextBox
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        Me.MainPanel.SuspendLayout()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.suspendlayout()
        '
        'Grid
        '
        Me.Grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True
        GridEXLayout1.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream", CType(resources.GetObject("resource"), System.Windows.Forms.ImageListStreamer))})
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""Id""><Caption" & _
        ">Id</Caption><DataMember>Id</DataMember><EditType>NoEdit</EditType><Key>Id</Key>" & _
        "<Position>0</Position><TextAlignment>Far</TextAlignment><Visible>False</Visible>" & _
        "</Column0><Column1 ID=""Contabilizado""><AllowSize>False</AllowSize><ColumnType>Im" & _
        "age</ColumnType><DataMember>Contabilizado</DataMember><EditType>NoEdit</EditType" & _
        "><Key>Contabilizado</Key><Position>1</Position><TextAlignment>Near</TextAlignmen" & _
        "t><Width>20</Width></Column1><Column2 ID=""Leasing""><Caption>Leasing</Caption><Co" & _
        "lumnType>CheckBox</ColumnType><DataMember>LeasingSN</DataMember><EditType>NoEdit" & _
        "</EditType><Key>Leasing</Key><Position>2</Position><TextAlignment>Near</TextAlig" & _
        "nment><Width>57</Width></Column2><Column3 ID=""DescPago""><Caption>Pago</Caption><" & _
        "DataMember>DescPago</DataMember><EditType>NoEdit</EditType><Key>DescPago</Key><P" & _
        "osition>3</Position><TextAlignment>Near</TextAlignment></Column3><Column4 ID=""Id" & _
        "TipoPago""><Caption>Tipo Pago</Caption><DataMember>IdTipoPago</DataMember><EditTy" & _
        "pe>NoEdit</EditType><Key>IdTipoPago</Key><Position>4</Position><TextAlignment>Ne" & _
        "ar</TextAlignment><Width>71</Width></Column4><Column5 ID=""Importe""><Caption>Impo" & _
        "rte</Caption><DataMember>Importe</DataMember><EditType>NoEdit</EditType><HeaderA" & _
        "lignment>Far</HeaderAlignment><Key>Importe</Key><Position>5</Position><TextAlign" & _
        "ment>Far</TextAlignment><Width>67</Width></Column5><Column6 ID=""ImpRecuperacionC" & _
        "ostePeriodo""><Caption>Recuperación coste</Caption><DataMember>ImpRecuperacionCos" & _
        "tePeriodo</DataMember><EditType>NoEdit</EditType><HeaderAlignment>Far</HeaderAli" & _
        "gnment><Key>ImpRecuperacionCostePeriodo</Key><Position>6</Position><TextAlignmen" & _
        "t>Far</TextAlignment></Column6><Column7 ID=""ImpInteresPeriodo""><Caption>Interés<" & _
        "/Caption><DataMember>ImpInteresPeriodo</DataMember><HeaderAlignment>Far</HeaderA" & _
        "lignment><Key>ImpInteresPeriodo</Key><Position>7</Position><TextAlignment>Far</T" & _
        "extAlignment><Width>69</Width></Column7><Column8 ID=""FechaInicio""><Caption>Fecha" & _
        " Inicio</Caption><DataMember>FechaInicio</DataMember><EditType>NoEdit</EditType>" & _
        "<Key>FechaInicio</Key><Position>8</Position><TextAlignment>Near</TextAlignment><" & _
        "Width>81</Width></Column8><Column9 ID=""FechaFin""><Caption>Fecha Fin</Caption><Da" & _
        "taMember>FechaFin</DataMember><EditType>NoEdit</EditType><Key>FechaFin</Key><Pos" & _
        "ition>9</Position><TextAlignment>Near</TextAlignment><Width>81</Width></Column9>" & _
        "<Column10 ID=""FechaUltimaActualizacion""><Caption>Fecha Ultima Actualización</Cap" & _
        "tion><DataMember>FechaUltimaActualizacion</DataMember><EditType>NoEdit</EditType" & _
        "><Key>FechaUltimaActualizacion</Key><Position>10</Position><TextAlignment>Near</" & _
        "TextAlignment><Width>81</Width></Column10><Column11 ID=""Unidad""><Caption>Unidad<" & _
        "/Caption><DataMember>Unidad</DataMember><EditType>NoEdit</EditType><Key>Unidad</" & _
        "Key><Position>11</Position><TextAlignment>Near</TextAlignment><Width>54</Width><" & _
        "/Column11><Column12 ID=""Periodo""><Caption>Periodo</Caption><DataMember>Periodo</" & _
        "DataMember><EditType>NoEdit</EditType><Key>Periodo</Key><Position>12</Position><" & _
        "TextAlignment>Far</TextAlignment><Width>61</Width></Column12><Column13 ID=""IdCCo" & _
        "ntable""><Caption>C. Contable</Caption><DataMember>IdCContable</DataMember><EditT" & _
        "ype>NoEdit</EditType><Key>IdCContable</Key><Position>13</Position><TextAlignment" & _
        ">Near</TextAlignment><Width>86</Width></Column13><Column14 ID=""IdMoneda""><Captio" & _
        "n>Moneda</Caption><DataMember>IdMoneda</DataMember><EditType>NoEdit</EditType><K" & _
        "ey>IdMoneda</Key><Position>14</Position><TextAlignment>Near</TextAlignment><Widt" & _
        "h>53</Width></Column14><Column15 ID=""IDTipoIVA""><Caption>IDTipoIVA</Caption><Dat" & _
        "aMember>IDTipoIVA</DataMember><EditType>NoEdit</EditType><Key>IDTipoIVA</Key><Po" & _
        "sition>15</Position><TextAlignment>Near</TextAlignment><Visible>False</Visible><" & _
        "/Column15></Columns><GroupCondition ID="""" /></RootTable><ImageList.ColorDepth>De" & _
        "pth8Bit</ImageList.ColorDepth><ImageList.ImageSize>16, 16</ImageList.ImageSize><" & _
        "ImageList.ImageStream Reference=""GridEXLayoutData.ImageList.ImageStream"" /><Imag" & _
        "eList.TransparentColor>Transparent</ImageList.TransparentColor></GridEXLayoutDat" & _
        "a>"
        Me.Grid.DesignTimeLayout = GridEXLayout1
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EntityName = "PagoPeriodico"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.ImageSource = Janus.Windows.GridEX.ImageSource.InternalImageList
        Me.Grid.KeyField = "Id"
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(688, 279)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "frmPagosMasivos"
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.txtImpHasta)
        Me.FilterPanel.Controls.Add(Me.txtImpDesde)
        Me.FilterPanel.Controls.Add(Me.cbxTipoPago)
        Me.FilterPanel.Controls.Add(Me.lblDescripcion)
        Me.FilterPanel.Controls.Add(Me.lblPeriodo)
        Me.FilterPanel.Controls.Add(Me.lblUnidad)
        Me.FilterPanel.Controls.Add(Me.lblTipoPago)
        Me.FilterPanel.Controls.Add(Me.lblFechaFinDesde)
        Me.FilterPanel.Controls.Add(Me.lblFechaFinHasta)
        Me.FilterPanel.Controls.Add(Me.lblFechaIniDesde)
        Me.FilterPanel.Controls.Add(Me.lblFechaIniHasta)
        Me.FilterPanel.Controls.Add(Me.lblImpHasta)
        Me.FilterPanel.Controls.Add(Me.lblImpDesde)
        Me.FilterPanel.Controls.Add(Me.lblFechaUltimaDesde)
        Me.FilterPanel.Controls.Add(Me.lblFechaUltimaHasta)
        Me.FilterPanel.Controls.Add(Me.txtDescripcion)
        Me.FilterPanel.Controls.Add(Me.txtPeriodo)
        Me.FilterPanel.Controls.Add(Me.cbxUnidad)
        Me.FilterPanel.Controls.Add(Me.cbxFechaFinDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFechaFinHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaIniDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFechaIniHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaUltimaDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFechaUltimaHasta)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 311)
        Me.FilterPanel.Name = "FilterPanel"
        Me.FilterPanel.Size = New System.Drawing.Size(688, 112)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Location = New System.Drawing.Point(0, 32)
        Me.CIMntoGridPanel.Name = "CIMntoGridPanel"
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(688, 279)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.False
        '
        'CheckAll
        '
        Me.CheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.False
        Me.CheckAll.Visible = Janus.Windows.UI.InheritableBoolean.True
        '
        'UncheckAll
        '
        Me.UncheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.False
        Me.UncheckAll.Visible = Janus.Windows.UI.InheritableBoolean.True
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.Panel1)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(688, 423)
        Me.MainPanel.Controls.SetChildIndex(Me.Panel1, 0)
        Me.MainPanel.Controls.SetChildIndex(Me.FilterPanel, 0)
        Me.MainPanel.Controls.SetChildIndex(Me.CIMntoGridPanel, 0)
        '
        'Export
        '
        Me.Export.Enabled = Janus.Windows.UI.InheritableBoolean.False
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Enabled = Janus.Windows.UI.InheritableBoolean.False
        Me.ShowAllCheckedItems.Visible = Janus.Windows.UI.InheritableBoolean.True
        '
        'ClearFilter
        '
        Me.ClearFilter.Enabled = Janus.Windows.UI.InheritableBoolean.False
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Name = "MainPanelCIMntoContainer"
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(688, 423)
        '
        'Toolbar
        '
        Me.Toolbar.Name = "Toolbar"
        Me.Toolbar.Size = New System.Drawing.Size(318, 26)
        '
        'Menubar
        '
        Me.Menubar.Name = "Menubar"
        Me.Menubar.Size = New System.Drawing.Size(81, 26)
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(440, 84)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(240, 21)
        Me.txtDescripcion.TabIndex = 12
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(368, 84)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(70, 17)
        Me.lblDescripcion.TabIndex = 13
        Me.lblDescripcion.Text = "Descripción"
        '
        'txtPeriodo
        '
        Me.txtPeriodo.Location = New System.Drawing.Point(440, 62)
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.Size = New System.Drawing.Size(120, 21)
        Me.txtPeriodo.TabIndex = 11
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(368, 62)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(47, 17)
        Me.lblPeriodo.TabIndex = 14
        Me.lblPeriodo.Text = "Periodo"
        '
        'cbxUnidad
        '
        GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition ID="""" /></RootTable><RowWithErrorsFo" & _
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
        Me.cbxUnidad.DesignTimeLayout = GridEXLayout2
        Me.cbxUnidad.Location = New System.Drawing.Point(440, 40)
        Me.cbxUnidad.Name = "cbxUnidad"
        Me.cbxUnidad.SelectedIndex = -1
        Me.cbxUnidad.SelectedItem = Nothing
        Me.cbxUnidad.Size = New System.Drawing.Size(120, 21)
        Me.cbxUnidad.TabIndex = 10
        Me.cbxUnidad.Value = Nothing
        '
        'lblUnidad
        '
        Me.lblUnidad.Location = New System.Drawing.Point(368, 40)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(44, 17)
        Me.lblUnidad.TabIndex = 15
        Me.lblUnidad.Text = "Unidad"
        '
        'lblTipoPago
        '
        Me.lblTipoPago.Location = New System.Drawing.Point(368, 18)
        Me.lblTipoPago.Name = "lblTipoPago"
        Me.lblTipoPago.Size = New System.Drawing.Size(60, 17)
        Me.lblTipoPago.TabIndex = 16
        Me.lblTipoPago.Text = "Tipo Pago"
        '
        'cbxFechaFinDesde
        '
        Me.cbxFechaFinDesde.Location = New System.Drawing.Point(272, 62)
        Me.cbxFechaFinDesde.Name = "cbxFechaFinDesde"
        Me.cbxFechaFinDesde.Size = New System.Drawing.Size(88, 21)
        Me.cbxFechaFinDesde.TabIndex = 7
        '
        'lblFechaFinDesde
        '
        Me.lblFechaFinDesde.Location = New System.Drawing.Point(192, 62)
        Me.lblFechaFinDesde.Name = "lblFechaFinDesde"
        Me.lblFechaFinDesde.Size = New System.Drawing.Size(58, 17)
        Me.lblFechaFinDesde.TabIndex = 18
        Me.lblFechaFinDesde.Text = "F. Fin >="
        '
        'cbxFechaFinHasta
        '
        Me.cbxFechaFinHasta.Location = New System.Drawing.Point(272, 84)
        Me.cbxFechaFinHasta.Name = "cbxFechaFinHasta"
        Me.cbxFechaFinHasta.Size = New System.Drawing.Size(88, 21)
        Me.cbxFechaFinHasta.TabIndex = 8
        '
        'lblFechaFinHasta
        '
        Me.lblFechaFinHasta.Location = New System.Drawing.Point(192, 84)
        Me.lblFechaFinHasta.Name = "lblFechaFinHasta"
        Me.lblFechaFinHasta.Size = New System.Drawing.Size(58, 17)
        Me.lblFechaFinHasta.TabIndex = 19
        Me.lblFechaFinHasta.Text = "F. Fin <="
        '
        'cbxFechaIniDesde
        '
        Me.cbxFechaIniDesde.Location = New System.Drawing.Point(272, 18)
        Me.cbxFechaIniDesde.Name = "cbxFechaIniDesde"
        Me.cbxFechaIniDesde.Size = New System.Drawing.Size(88, 21)
        Me.cbxFechaIniDesde.TabIndex = 5
        '
        'lblFechaIniDesde
        '
        Me.lblFechaIniDesde.Location = New System.Drawing.Point(192, 18)
        Me.lblFechaIniDesde.Name = "lblFechaIniDesde"
        Me.lblFechaIniDesde.Size = New System.Drawing.Size(72, 17)
        Me.lblFechaIniDesde.TabIndex = 20
        Me.lblFechaIniDesde.Text = "F. Inicio >="
        '
        'cbxFechaIniHasta
        '
        Me.cbxFechaIniHasta.Location = New System.Drawing.Point(272, 40)
        Me.cbxFechaIniHasta.Name = "cbxFechaIniHasta"
        Me.cbxFechaIniHasta.Size = New System.Drawing.Size(88, 21)
        Me.cbxFechaIniHasta.TabIndex = 6
        '
        'lblFechaIniHasta
        '
        Me.lblFechaIniHasta.Location = New System.Drawing.Point(192, 40)
        Me.lblFechaIniHasta.Name = "lblFechaIniHasta"
        Me.lblFechaIniHasta.Size = New System.Drawing.Size(72, 17)
        Me.lblFechaIniHasta.TabIndex = 21
        Me.lblFechaIniHasta.Text = "F. Inicio <="
        '
        'lblImpHasta
        '
        Me.lblImpHasta.Location = New System.Drawing.Point(4, 84)
        Me.lblImpHasta.Name = "lblImpHasta"
        Me.lblImpHasta.Size = New System.Drawing.Size(72, 17)
        Me.lblImpHasta.TabIndex = 22
        Me.lblImpHasta.Text = "Importe <="
        '
        'lblImpDesde
        '
        Me.lblImpDesde.Location = New System.Drawing.Point(4, 62)
        Me.lblImpDesde.Name = "lblImpDesde"
        Me.lblImpDesde.Size = New System.Drawing.Size(72, 17)
        Me.lblImpDesde.TabIndex = 23
        Me.lblImpDesde.Text = "Importe >="
        '
        'cbxFechaUltimaDesde
        '
        Me.cbxFechaUltimaDesde.Location = New System.Drawing.Point(96, 18)
        Me.cbxFechaUltimaDesde.Name = "cbxFechaUltimaDesde"
        Me.cbxFechaUltimaDesde.Size = New System.Drawing.Size(88, 21)
        Me.cbxFechaUltimaDesde.TabIndex = 1
        '
        'lblFechaUltimaDesde
        '
        Me.lblFechaUltimaDesde.Location = New System.Drawing.Point(4, 18)
        Me.lblFechaUltimaDesde.Name = "lblFechaUltimaDesde"
        Me.lblFechaUltimaDesde.Size = New System.Drawing.Size(88, 17)
        Me.lblFechaUltimaDesde.TabIndex = 24
        Me.lblFechaUltimaDesde.Text = "F. Ult. Act. >="
        '
        'cbxFechaUltimaHasta
        '
        Me.cbxFechaUltimaHasta.Location = New System.Drawing.Point(96, 40)
        Me.cbxFechaUltimaHasta.Name = "cbxFechaUltimaHasta"
        Me.cbxFechaUltimaHasta.Size = New System.Drawing.Size(88, 21)
        Me.cbxFechaUltimaHasta.TabIndex = 2
        '
        'lblFechaUltimaHasta
        '
        Me.lblFechaUltimaHasta.Location = New System.Drawing.Point(4, 40)
        Me.lblFechaUltimaHasta.Name = "lblFechaUltimaHasta"
        Me.lblFechaUltimaHasta.Size = New System.Drawing.Size(88, 17)
        Me.lblFechaUltimaHasta.TabIndex = 25
        Me.lblFechaUltimaHasta.Text = "F. Ult. Act. <="
        '
        'cbxTipoPago
        '
        GridEXLayout3.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IdTipoPago"">" & _
        "<Caption>Tipo Pago</Caption><DataMember>IdTipoPago</DataMember><Key>IdTipoPago</" & _
        "Key><Position>0</Position></Column0><Column1 ID=""DescTipo""><Caption>Descripción<" & _
        "/Caption><DataMember>DescTipo</DataMember><Key>DescTipo</Key><Position>1</Positi" & _
        "on></Column1></Columns><GroupCondition ID="""" /></RootTable><RowWithErrorsFormatS" & _
        "tyle><PredefinedStyle>RowWithErrorsFormatStyle</PredefinedStyle></RowWithErrorsF" & _
        "ormatStyle><LinkFormatStyle><PredefinedStyle>LinkFormatStyle</PredefinedStyle></" & _
        "LinkFormatStyle><CardCaptionFormatStyle><PredefinedStyle>CardCaptionFormatStyle<" & _
        "/PredefinedStyle></CardCaptionFormatStyle><GroupByBoxInfoFormatStyle><Predefined" & _
        "Style>GroupByBoxInfoFormatStyle</PredefinedStyle></GroupByBoxInfoFormatStyle><Gr" & _
        "oupRowFormatStyle><PredefinedStyle>GroupRowFormatStyle</PredefinedStyle></GroupR" & _
        "owFormatStyle><HeaderFormatStyle><PredefinedStyle>HeaderFormatStyle</PredefinedS" & _
        "tyle></HeaderFormatStyle><PreviewRowFormatStyle><PredefinedStyle>PreviewRowForma" & _
        "tStyle</PredefinedStyle></PreviewRowFormatStyle><RowFormatStyle><PredefinedStyle" & _
        ">RowFormatStyle</PredefinedStyle></RowFormatStyle><SelectedFormatStyle><Predefin" & _
        "edStyle>SelectedFormatStyle</PredefinedStyle></SelectedFormatStyle><SelectedInac" & _
        "tiveFormatStyle><PredefinedStyle>SelectedInactiveFormatStyle</PredefinedStyle></" & _
        "SelectedInactiveFormatStyle><WatermarkImage /><BorderStyle>Flat</BorderStyle><Fl" & _
        "atBorderColor>125, 159, 190</FlatBorderColor><ControlStyle><ButtonAppearance>Fla" & _
        "t</ButtonAppearance></ControlStyle><VisualStyle>Standard</VisualStyle><AllowEdit" & _
        ">False</AllowEdit><ExpandableGroups>False</ExpandableGroups><GroupByBoxVisible>F" & _
        "alse</GroupByBoxVisible><HideSelection>Highlight</HideSelection><DisplayMember>D" & _
        "escTipo</DisplayMember><ValueMember>IdTipoPago</ValueMember></GridEXLayoutData>"
        Me.cbxTipoPago.DesignTimeLayout = GridEXLayout3
        Me.cbxTipoPago.DisplayMember = "DescTipo"
        Me.cbxTipoPago.EntityName = "TipoPago"
        Me.cbxTipoPago.Location = New System.Drawing.Point(440, 18)
        Me.cbxTipoPago.Name = "cbxTipoPago"
        Me.cbxTipoPago.PrimaryDataFields = "IdTipoPago"
        Me.cbxTipoPago.SecondaryDataFields = "IdTipoPago"
        Me.cbxTipoPago.SelectedIndex = -1
        Me.cbxTipoPago.SelectedItem = Nothing
        Me.cbxTipoPago.Size = New System.Drawing.Size(120, 21)
        Me.cbxTipoPago.TabIndex = 9
        Me.cbxTipoPago.Value = Nothing
        Me.cbxTipoPago.ValueMember = "IdTipoPago"
        Me.cbxTipoPago.ViewName = "tbMaestroTipoPago"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbxFechaFinal)
        Me.Panel1.Controls.Add(Me.lblFechaFinal)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(688, 32)
        Me.Panel1.TabIndex = 1
        '
        'cbxFechaFinal
        '
        Me.cbxFechaFinal.Location = New System.Drawing.Point(94, 6)
        Me.cbxFechaFinal.Name = "cbxFechaFinal"
        Me.cbxFechaFinal.Size = New System.Drawing.Size(104, 21)
        Me.cbxFechaFinal.TabIndex = 0
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Location = New System.Drawing.Point(14, 7)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(68, 17)
        Me.lblFechaFinal.TabIndex = 1
        Me.lblFechaFinal.Text = "Fecha Final"
        '
        'txtImpDesde
        '
        Me.txtImpDesde.Location = New System.Drawing.Point(96, 62)
        Me.txtImpDesde.Name = "txtImpDesde"
        Me.txtImpDesde.Size = New System.Drawing.Size(88, 21)
        Me.txtImpDesde.TabIndex = 3
        Me.txtImpDesde.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        '
        'txtImpHasta
        '
        Me.txtImpHasta.Location = New System.Drawing.Point(96, 84)
        Me.txtImpHasta.Name = "txtImpHasta"
        Me.txtImpHasta.Size = New System.Drawing.Size(88, 21)
        Me.txtImpHasta.TabIndex = 4
        Me.txtImpHasta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        '
        'CIPagosMasivos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(696, 509)
        Me.EntityName = "PagoPeriodico"
        Me.KeyField = "Id"
        Me.Name = "CIPagosMasivos"
        Me.UseCheck = True
        Me.ViewName = "frmPagosMasivos"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FilterPanel.ResumeLayout(False)
        Me.CIMntoGridPanel.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)

    End Sub

#End Region

#Region " Load "

    Private Sub CIPagosMasivos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEnums()
        LoadToolbarActions()
        LoadGridActions()
    End Sub

    Private Sub LoadEnums()
        cbxUnidad.DataSource = New EnumData("enumcpPeriodo")
        EnumData.PopulateValueList("enumcpPeriodo", Grid.Columns("Unidad"))
    End Sub

    Private Sub LoadToolbarActions()
        'Me.FormActions.Add("-", AddressOf "-")
        Me.FormActions.Add("Pagos masivos", AddressOf AccionPagosMasivos)
    End Sub

    Private Sub LoadGridActions()
        With Grid
            '.Actions.Add("-", Nothing)
            '.Actions.Add("Abrir Pago Leasing", AddressOf AccionAbrirLeasing)
        End With
    End Sub

    Private Sub AccionAbrirLeasing()
        If Grid.Value("Leasing") Then
            If ExpertisApp.IsFormOpen("MntoPagoPe") Then ExpertisApp.CloseForm("MntoPagoPe")
            ExpertisApp.OpenForm("MntoPagoPe", New NumberFilterItem("Id", FilterOperator.Equal, Grid.Value("ID")))
        End If
    End Sub

#End Region

    Private Sub AccionPagosMasivos()
        If Grid.CheckedRecordsCount > 0 Then
            If Length(cbxFechaFinal.Value) > 0 Then
                Dim dtMarcados As DataTable = Me.CheckedRecords
                If Not IsNothing(dtMarcados) AndAlso dtMarcados.Rows.Count > 0 Then
                    If ExpertisApp.GenerateMessage("Se generarán Pagos de forma Masiva a partir de las líneas seleccionadas. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then 'Se generarán Pagos de forma Masiva a partir de las líneas seleccionadas. ¿Desea continuar?.
                        Me.Cursor = Cursors.WaitCursor
                        Dim addPagoPer As New Pago.DataAddPagoPeriodico(dtMarcados, cbxFechaFinal.Value)
                        ExpertisApp.ExecuteTask(Of Pago.DataAddPagoPeriodico, DataTable)(AddressOf Pago.AddPagoPeriodico, addPagoPer)
                        Me.UnCheckAllRecords()
                        Me.Execute()
                        Me.Cursor = Cursors.Default
                    End If
                End If
            Else
                ExpertisApp.GenerateMessage("La Fecha final es obligatoria.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#Region " Grid "
    Private Sub Grid_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        Select Case e.Column.Key
            Case "ImpInteresPeriodo"
                Grid.Columns("ImpInteresPeriodo").EditType = Janus.Windows.GridEX.EditType.TextBox
        End Select
    End Sub

    Private Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        If e.Row.RowType = Janus.Windows.GridEX.RowType.Record Then
            If e.Row.Cells("Contabilizado").Value = CBool(enumPagoContabilizado.PagoContabilizado) Then
                e.Row.Cells("Contabilizado").ImageIndex = IconIndex.Contabilizado
            Else
                e.Row.Cells("Contabilizado").ImageIndex = IconIndex.NoContabilizado
            End If
        End If
    End Sub
#End Region

    Private Sub CIPagosMasivos_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("FechaUltimaActualizacion", FilterOperator.GreaterThanOrEqual, cbxFechaUltimaDesde.Text, FilterType.DateTime)
        e.Filter.Add("FechaUltimaActualizacion", FilterOperator.LessThanOrEqual, cbxFechaUltimaHasta.Text, FilterType.DateTime)
        e.Filter.Add("FechaInicio", FilterOperator.GreaterThanOrEqual, cbxFechaIniDesde.Text, FilterType.DateTime)
        e.Filter.Add("FechaInicio", FilterOperator.LessThanOrEqual, cbxFechaIniHasta.Text, FilterType.DateTime)
        e.Filter.Add("FechaFin", FilterOperator.GreaterThanOrEqual, cbxFechaFinDesde.Text, FilterType.DateTime)
        e.Filter.Add("FechaFin", FilterOperator.LessThanOrEqual, cbxFechaFinHasta.Text, FilterType.DateTime)
        e.Filter.Add("Importe", FilterOperator.GreaterThanOrEqual, txtImpDesde.Text, FilterType.Numeric)
        e.Filter.Add("Importe", FilterOperator.LessThanOrEqual, txtImpHasta.Text, FilterType.Numeric)
        e.Filter.Add("IdTipoPago", FilterOperator.Equal, cbxTipoPago.Value, FilterType.String)
        e.Filter.Add("Unidad", FilterOperator.Equal, cbxUnidad.Value, FilterType.String)
        e.Filter.Add("Periodo", FilterOperator.Equal, txtPeriodo.Text, FilterType.Numeric)
        e.Filter.Add("DescPago", FilterOperator.Equal, txtDescripcion.Text, FilterType.String)
    End Sub

End Class
