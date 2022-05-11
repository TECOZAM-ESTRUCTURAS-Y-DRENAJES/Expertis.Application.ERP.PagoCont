Imports Solmicro.Expertis.Business.Negocio

Public Class CIGestionLeasing
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
    Friend WithEvents LblFechaUltRev As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblFechaUltPago As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblFechaUltRevHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ClbFechaUltRevDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents ClbFechaUltPagoDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents LblFechaUltPagoHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ClbFechaUltRevHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents ClbFechaUltPagoHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents LblTipoPago As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblPago As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents CmbTipoPago As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents AdvPago As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents PnlCabecera As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents LblFechaAccion As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents ClbFechaAccion As Solmicro.Expertis.Engine.UI.CalendarBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.LblFechaUltRev = New Solmicro.Expertis.Engine.UI.Label
        Me.LblFechaUltPago = New Solmicro.Expertis.Engine.UI.Label
        Me.LblFechaUltRevHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.ClbFechaUltRevDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.ClbFechaUltPagoDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.LblFechaUltPagoHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.ClbFechaUltRevHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.ClbFechaUltPagoHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.LblTipoPago = New Solmicro.Expertis.Engine.UI.Label
        Me.LblPago = New Solmicro.Expertis.Engine.UI.Label
        Me.CmbTipoPago = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.AdvPago = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.PnlCabecera = New Solmicro.Expertis.Engine.UI.Panel
        Me.ClbFechaAccion = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.LblFechaAccion = New Solmicro.Expertis.Engine.UI.Label
        Me.CIMntoGridPanel.suspendlayout()
        Me.FilterPanel.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlCabecera.suspendlayout()
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.PnlCabecera)
        Me.CIMntoGridPanel.Name = "CIMntoGridPanel"
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(704, 305)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.PnlCabecera, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.AdvPago)
        Me.FilterPanel.Controls.Add(Me.CmbTipoPago)
        Me.FilterPanel.Controls.Add(Me.LblPago)
        Me.FilterPanel.Controls.Add(Me.LblTipoPago)
        Me.FilterPanel.Controls.Add(Me.LblFechaUltPagoHasta)
        Me.FilterPanel.Controls.Add(Me.LblFechaUltRevHasta)
        Me.FilterPanel.Controls.Add(Me.LblFechaUltPago)
        Me.FilterPanel.Controls.Add(Me.LblFechaUltRev)
        Me.FilterPanel.Controls.Add(Me.ClbFechaUltPagoHasta)
        Me.FilterPanel.Controls.Add(Me.ClbFechaUltRevHasta)
        Me.FilterPanel.Controls.Add(Me.ClbFechaUltPagoDesde)
        Me.FilterPanel.Controls.Add(Me.ClbFechaUltRevDesde)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 305)
        Me.FilterPanel.Name = "FilterPanel"
        Me.FilterPanel.Size = New System.Drawing.Size(704, 80)
        Me.FilterPanel.TabIndex = 2
        '
        'Grid
        '
        Me.Grid.CheckFields = New Solmicro.Expertis.Engine.UI.CheckFields(New Solmicro.Expertis.Engine.UI.CheckField() {New Solmicro.Expertis.Engine.UI.CheckField("CantidadMarca1", "Nueva Cuota", 0, "")})
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""Id""><Caption" & _
        ">Id</Caption><DataMember>Id</DataMember><Key>Id</Key><Position>0</Position><Visi" & _
        "ble>False</Visible></Column0><Column1 ID=""DescPago""><Caption>Leasing</Caption><D" & _
        "ataMember>DescPago</DataMember><Key>DescPago</Key><Position>1</Position><Width>2" & _
        "50</Width></Column1><Column2 ID=""IdTipoPago""><Caption>IdTipoPago</Caption><DataM" & _
        "ember>IdTipoPago</DataMember><Key>IdTipoPago</Key><Position>2</Position><Visible" & _
        ">False</Visible></Column2><Column3 ID=""LeasingSN""><Caption>LeasingSN</Caption><C" & _
        "olumnType>CheckBox</ColumnType><DataMember>LeasingSN</DataMember><EditType>Check" & _
        "Box</EditType><Key>LeasingSN</Key><Position>3</Position><Visible>False</Visible>" & _
        "</Column3><Column4 ID=""CuotaFija""><Caption>CuotaFija</Caption><ColumnType>CheckB" & _
        "ox</ColumnType><DataMember>CuotaFija</DataMember><EditType>CheckBox</EditType><K" & _
        "ey>CuotaFija</Key><Position>4</Position><Visible>False</Visible></Column4><Colum" & _
        "n5 ID=""RecuperacionFija""><Caption>RecuperacionFija</Caption><ColumnType>CheckBox" & _
        "</ColumnType><DataMember>RecuperacionFija</DataMember><EditType>CheckBox</EditTy" & _
        "pe><Key>RecuperacionFija</Key><Position>5</Position><Visible>False</Visible></Co" & _
        "lumn5><Column6 ID=""UltimoPago""><Caption>Fecha Último Pago</Caption><DataMember>U" & _
        "ltimoPago</DataMember><DefaultGroupFormatString>d</DefaultGroupFormatString><Edi" & _
        "tType>CalendarCombo</EditType><Key>UltimoPago</Key><Position>6</Position></Colum" & _
        "n6><Column7 ID=""FechaUltimaRevision""><Caption>Fecha Última Revisión</Caption><Da" & _
        "taMember>FechaUltimaRevision</DataMember><DefaultGroupFormatString>d</DefaultGro" & _
        "upFormatString><EditType>CalendarDropDown</EditType><Key>FechaUltimaRevision</Ke" & _
        "y><Position>7</Position></Column7><Column8 ID=""ImpRecuperacionCostePeriodo""><Cap" & _
        "tion>Imp.Recuperación Coste Periodo</Caption><DataMember>ImpRecuperacionCostePer" & _
        "iodo</DataMember><Key>ImpRecuperacionCostePeriodo</Key><Position>8</Position><Te" & _
        "xtAlignment>Far</TextAlignment></Column8><Column9 ID=""ImpInteresPeriodo""><Captio" & _
        "n>Imp.Interés Periodo</Caption><DataMember>ImpInteresPeriodo</DataMember><Key>Im" & _
        "pInteresPeriodo</Key><Position>9</Position><TextAlignment>Far</TextAlignment></C" & _
        "olumn9><Column10 ID=""ImpCuotaPeriodo""><Caption>Imp.Cuota Periodo</Caption><DataM" & _
        "ember>ImpCuotaPeriodo</DataMember><Key>ImpCuotaPeriodo</Key><Position>10</Positi" & _
        "on><TextAlignment>Far</TextAlignment></Column10><Column11 ID=""FechaInmovilizado""" & _
        "><Caption>Fecha Inmovilizado</Caption><DataMember>FechaInmovilizado</DataMember>" & _
        "<DefaultGroupFormatString>d</DefaultGroupFormatString><EditType>CalendarCombo</E" & _
        "ditType><Key>FechaInmovilizado</Key><Position>11</Position></Column11><Column12 " & _
        "ID=""AñoContrato""><Caption>Año Contrato</Caption><DataMember>AñoContrato</DataMem" & _
        "ber><Key>AñoContrato</Key><Position>12</Position></Column12><Column13 ID=""MesCon" & _
        "trato""><Caption>Mes Contrato</Caption><DataMember>MesContrato</DataMember><Key>M" & _
        "esContrato</Key><Position>13</Position></Column13><Column14 ID=""ImpRecuperacionC" & _
        "oste""><Caption>Imp.Recuperación Coste</Caption><DataMember>ImpRecuperacionCoste<" & _
        "/DataMember><Key>ImpRecuperacionCoste</Key><Position>14</Position><TextAlignment" & _
        ">Far</TextAlignment></Column14><Column15 ID=""RecupCosteDesdePago""><Caption>Recup" & _
        ". Coste desde Pago</Caption><DataMember>RecupCosteDesdePago</DataMember><Key>Rec" & _
        "upCosteDesdePago</Key><Position>15</Position><TextAlignment>Far</TextAlignment><" & _
        "/Column15><Column16 ID=""DifCostePagoConta""><Caption>Dif. Coste Pago Conta.</Capt" & _
        "ion><DataMember>DifCostePagoConta</DataMember><Key>DifCostePagoConta</Key><Posit" & _
        "ion>16</Position><TextAlignment>Far</TextAlignment></Column16><Column17 ID=""NoCa" & _
        "lcularImpuesto""><Caption>No Calcular Impuesto</Caption><ColumnType>CheckBox</Col" & _
        "umnType><DataMember>NoCalcularImpuesto</DataMember><EditType>CheckBox</EditType>" & _
        "<Key>NoCalcularImpuesto</Key><Position>17</Position></Column17><Column18 ID=""Inm" & _
        "ovilizado""><Caption>Inmovilizado</Caption><DataMember>Inmovilizado</DataMember><" & _
        "Key>Inmovilizado</Key><Position>18</Position></Column18><Column19 ID=""OpcionComp" & _
        "ra""><Caption>Opción Compra</Caption><DataMember>OpcionCompra</DataMember><Key>Op" & _
        "cionCompra</Key><Position>19</Position><TextAlignment>Far</TextAlignment></Colum" & _
        "n19></Columns><GroupCondition ID="""" /></RootTable></GridEXLayoutData>"
        Me.Grid.DesignTimeLayout = GridEXLayout1
        Me.Grid.EntityName = "PagoPeriodico"
        Me.Grid.KeyField = "ID"
        Me.Grid.Location = New System.Drawing.Point(0, 48)
        Me.Grid.Name = "Grid"
        Me.Grid.SecondaryDataFields = "Id"
        Me.Grid.Size = New System.Drawing.Size(704, 257)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "vCtlCILeasingGestion"
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Visible = Janus.Windows.UI.InheritableBoolean.True
        '
        'Menubar
        '
        Me.Menubar.Name = "Menubar"
        '
        'UncheckAll
        '
        Me.UncheckAll.Visible = Janus.Windows.UI.InheritableBoolean.True
        '
        'MainPanel
        '
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(704, 385)
        '
        'CheckAll
        '
        Me.CheckAll.Visible = Janus.Windows.UI.InheritableBoolean.True
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Name = "MainPanelCIMntoContainer"
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(704, 385)
        '
        'Toolbar
        '
        Me.Toolbar.Name = "Toolbar"
        Me.Toolbar.Size = New System.Drawing.Size(318, 26)
        '
        'LblFechaUltRev
        '
        Me.LblFechaUltRev.Location = New System.Drawing.Point(8, 24)
        Me.LblFechaUltRev.Name = "LblFechaUltRev"
        Me.LblFechaUltRev.Size = New System.Drawing.Size(90, 17)
        Me.LblFechaUltRev.TabIndex = 0
        Me.LblFechaUltRev.Text = "F. Ult. Revisión"
        Me.LblFechaUltRev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblFechaUltPago
        '
        Me.LblFechaUltPago.Location = New System.Drawing.Point(8, 48)
        Me.LblFechaUltPago.Name = "LblFechaUltPago"
        Me.LblFechaUltPago.Size = New System.Drawing.Size(70, 17)
        Me.LblFechaUltPago.TabIndex = 1
        Me.LblFechaUltPago.Text = "F. Ult. Pago"
        Me.LblFechaUltPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblFechaUltRevHasta
        '
        Me.LblFechaUltRevHasta.Location = New System.Drawing.Point(224, 24)
        Me.LblFechaUltRevHasta.Name = "LblFechaUltRevHasta"
        Me.LblFechaUltRevHasta.Size = New System.Drawing.Size(9, 17)
        Me.LblFechaUltRevHasta.TabIndex = 2
        Me.LblFechaUltRevHasta.Text = "-"
        Me.LblFechaUltRevHasta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ClbFechaUltRevDesde
        '
        Me.ClbFechaUltRevDesde.Location = New System.Drawing.Point(112, 24)
        Me.ClbFechaUltRevDesde.Name = "ClbFechaUltRevDesde"
        Me.ClbFechaUltRevDesde.Size = New System.Drawing.Size(104, 21)
        Me.ClbFechaUltRevDesde.TabIndex = 2
        '
        'ClbFechaUltPagoDesde
        '
        Me.ClbFechaUltPagoDesde.Location = New System.Drawing.Point(112, 48)
        Me.ClbFechaUltPagoDesde.Name = "ClbFechaUltPagoDesde"
        Me.ClbFechaUltPagoDesde.Size = New System.Drawing.Size(104, 21)
        Me.ClbFechaUltPagoDesde.TabIndex = 4
        '
        'LblFechaUltPagoHasta
        '
        Me.LblFechaUltPagoHasta.Location = New System.Drawing.Point(224, 48)
        Me.LblFechaUltPagoHasta.Name = "LblFechaUltPagoHasta"
        Me.LblFechaUltPagoHasta.Size = New System.Drawing.Size(9, 17)
        Me.LblFechaUltPagoHasta.TabIndex = 5
        Me.LblFechaUltPagoHasta.Text = "-"
        Me.LblFechaUltPagoHasta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ClbFechaUltRevHasta
        '
        Me.ClbFechaUltRevHasta.Location = New System.Drawing.Point(240, 24)
        Me.ClbFechaUltRevHasta.Name = "ClbFechaUltRevHasta"
        Me.ClbFechaUltRevHasta.Size = New System.Drawing.Size(104, 21)
        Me.ClbFechaUltRevHasta.TabIndex = 3
        '
        'ClbFechaUltPagoHasta
        '
        Me.ClbFechaUltPagoHasta.Location = New System.Drawing.Point(240, 48)
        Me.ClbFechaUltPagoHasta.Name = "ClbFechaUltPagoHasta"
        Me.ClbFechaUltPagoHasta.Size = New System.Drawing.Size(104, 21)
        Me.ClbFechaUltPagoHasta.TabIndex = 5
        '
        'LblTipoPago
        '
        Me.LblTipoPago.Location = New System.Drawing.Point(520, 24)
        Me.LblTipoPago.Name = "LblTipoPago"
        Me.LblTipoPago.Size = New System.Drawing.Size(60, 17)
        Me.LblTipoPago.TabIndex = 8
        Me.LblTipoPago.Text = "Tipo Pago"
        Me.LblTipoPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblPago
        '
        Me.LblPago.Location = New System.Drawing.Point(520, 48)
        Me.LblPago.Name = "LblPago"
        Me.LblPago.Size = New System.Drawing.Size(32, 17)
        Me.LblPago.TabIndex = 9
        Me.LblPago.Text = "Pago"
        Me.LblPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbTipoPago
        '
        GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IdTipoPago"">" & _
        "<Caption>IdTipoPago</Caption><DataMember>IdTipoPago</DataMember><Key>IdTipoPago<" & _
        "/Key><Position>0</Position></Column0><Column1 ID=""DescTipo""><Caption>Desc. Tipo<" & _
        "/Caption><DataMember>DescTipo</DataMember><Key>DescTipo</Key><Position>1</Positi" & _
        "on></Column1><Column2 ID=""Abreviatura""><Caption>Abreviatura</Caption><DataMember" & _
        ">Abreviatura</DataMember><Key>Abreviatura</Key><Position>2</Position></Column2><" & _
        "/Columns><GroupCondition ID="""" /></RootTable><RowWithErrorsFormatStyle><Predefin" & _
        "edStyle>RowWithErrorsFormatStyle</PredefinedStyle></RowWithErrorsFormatStyle><Li" & _
        "nkFormatStyle><PredefinedStyle>LinkFormatStyle</PredefinedStyle></LinkFormatStyl" & _
        "e><CardCaptionFormatStyle><PredefinedStyle>CardCaptionFormatStyle</PredefinedSty" & _
        "le></CardCaptionFormatStyle><GroupByBoxInfoFormatStyle><PredefinedStyle>GroupByB" & _
        "oxInfoFormatStyle</PredefinedStyle></GroupByBoxInfoFormatStyle><GroupRowFormatSt" & _
        "yle><PredefinedStyle>GroupRowFormatStyle</PredefinedStyle></GroupRowFormatStyle>" & _
        "<HeaderFormatStyle><PredefinedStyle>HeaderFormatStyle</PredefinedStyle></HeaderF" & _
        "ormatStyle><PreviewRowFormatStyle><PredefinedStyle>PreviewRowFormatStyle</Predef" & _
        "inedStyle></PreviewRowFormatStyle><RowFormatStyle><PredefinedStyle>RowFormatStyl" & _
        "e</PredefinedStyle></RowFormatStyle><SelectedFormatStyle><PredefinedStyle>Select" & _
        "edFormatStyle</PredefinedStyle></SelectedFormatStyle><SelectedInactiveFormatStyl" & _
        "e><PredefinedStyle>SelectedInactiveFormatStyle</PredefinedStyle></SelectedInacti" & _
        "veFormatStyle><WatermarkImage /><BorderStyle>Flat</BorderStyle><FlatBorderColor>" & _
        "125, 159, 190</FlatBorderColor><ControlStyle><ButtonAppearance>Flat</ButtonAppea" & _
        "rance></ControlStyle><VisualStyle>Standard</VisualStyle><AllowEdit>False</AllowE" & _
        "dit><ExpandableGroups>False</ExpandableGroups><GroupByBoxVisible>False</GroupByB" & _
        "oxVisible><HideSelection>Highlight</HideSelection></GridEXLayoutData>"
        Me.CmbTipoPago.DesignTimeLayout = GridEXLayout2
        Me.CmbTipoPago.EntityName = "TipoPago"
        Me.CmbTipoPago.Location = New System.Drawing.Point(592, 24)
        Me.CmbTipoPago.Name = "CmbTipoPago"
        Me.CmbTipoPago.SecondaryDataFields = "IdTipoPago"
        Me.CmbTipoPago.SelectedIndex = -1
        Me.CmbTipoPago.SelectedItem = Nothing
        Me.CmbTipoPago.Size = New System.Drawing.Size(104, 21)
        Me.CmbTipoPago.TabIndex = 6
        Me.CmbTipoPago.Value = Nothing
        Me.CmbTipoPago.ViewName = "tbMaestroTipoPago"
        '
        'AdvPago
        '
        Me.AdvPago.DisplayField = "Id"
        Me.AdvPago.EntityName = "PagoPeriodico"
        Me.AdvPago.Location = New System.Drawing.Point(592, 48)
        Me.AdvPago.Name = "AdvPago"
        Me.AdvPago.SecondaryDataFields = "Id"
        Me.AdvPago.Size = New System.Drawing.Size(104, 21)
        Me.AdvPago.TabIndex = 7
        Me.AdvPago.ViewName = "vCTLCILeasingGestionPagosPer"
        '
        'PnlCabecera
        '
        Me.PnlCabecera.Controls.Add(Me.ClbFechaAccion)
        Me.PnlCabecera.Controls.Add(Me.LblFechaAccion)
        Me.PnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PnlCabecera.Name = "PnlCabecera"
        Me.PnlCabecera.Size = New System.Drawing.Size(704, 48)
        Me.PnlCabecera.TabIndex = 0
        '
        'ClbFechaAccion
        '
        Me.ClbFechaAccion.Location = New System.Drawing.Point(592, 16)
        Me.ClbFechaAccion.Name = "ClbFechaAccion"
        Me.ClbFechaAccion.Size = New System.Drawing.Size(104, 21)
        Me.ClbFechaAccion.TabIndex = 1
        '
        'LblFechaAccion
        '
        Me.LblFechaAccion.Location = New System.Drawing.Point(456, 16)
        Me.LblFechaAccion.Name = "LblFechaAccion"
        Me.LblFechaAccion.Size = New System.Drawing.Size(121, 17)
        Me.LblFechaAccion.TabIndex = 2
        Me.LblFechaAccion.Text = "Fecha para la Acción"
        Me.LblFechaAccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CIGestionLeasing
        '
        Me.AllowUpdate = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CheckFields = New Solmicro.Expertis.Engine.UI.CheckFields(New Solmicro.Expertis.Engine.UI.CheckField() {New Solmicro.Expertis.Engine.UI.CheckField("CantidadMarca1", "Nueva Cuota", 0, "")})
        Me.ClientSize = New System.Drawing.Size(712, 469)
        Me.EntityName = "PagoPeriodico"
        Me.KeyField = "ID"
        Me.Name = "CIGestionLeasing"
        Me.UseCheck = True
        Me.ViewName = "vCtlCILeasingGestion"
        Me.CIMntoGridPanel.ResumeLayout(False)
        Me.FilterPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlCabecera.ResumeLayout(False)

    End Sub

#End Region


#Region "Variables Privadas"

    Private mintAño As Integer
    Private mintAñoDesde As Integer
    Private mintAñoHasta As Integer
    Private mdtFechaInforme As Date

#End Region

#Region "Funciones / Procesos Privados"

#Region "Procesos de Acciones"

    Private Sub LoadActions()
        Grid.Actions.Add("Modificar Leasing", AddressOf AccionModificacionLeasing)
        Me.FormActions.Add("Revision de Condiciones", AddressOf AccionRevisionCondiciones)
        Me.FormActions.Add("Recálculo de Importes a Corto Plazo", AddressOf AccionRecalcularImportesCortoPlazo)
        'Me.FormActions.Add("Calculo de Impuestos", AddressOf AccionCalcularImpuestos)
    End Sub

    Private Sub AccionModificacionLeasing()
        'Declaración de constantes, variables u objetos locales
        Dim FrmModLeas As New frmModificarLeasing
        If Grid.RowCount > 0 Then
            FrmModLeas.IDPagoPeriodico = Grid.GetValue("ID")
            FrmModLeas.MainFunction()
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
        If FrmModLeas.DialogResult = DialogResult.OK Then
            Grid.UnCheckAllRecords()
            Me.ExecuteQuery.InvokeOnClick()
        End If

    End Sub

    Private Sub AccionRecalcularImportesCortoPlazo()
        If Length(ClbFechaAccion.Value) > 0 Then
            Dim IDEjercicio As String = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, ClbFechaAccion.Value)
            mIDProcess = Grid.SaveServerChecks()

            Dim SimInfo As New DataSimulacionContableInfo(enumTipoContabilizacion.tcRecalculoCortoPlazo)
            SimInfo.IDEjercicio = IDEjercicio
            SimInfo.GuidSimulacion = mIDProcess
            SimInfo.FechaApunte = ClbFechaAccion.Value

            Dim oFrm As Form = ExpertisApp.OpenForm("CISIMUCONT", , SimInfo, Me)
            AddHandler oFrm.Closed, AddressOf FrmActionClosed
        Else
            ExpertisApp.GenerateMessage("Introduzca la Fecha.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub FrmActionClosed(ByVal sender As Object, ByVal e As System.EventArgs)
        RemoveHandler CType(sender, Form).Closed, AddressOf FrmActionClosed

        Me.UnCheckAllRecords()
        Me.DeleteServerChecks()
        Me.Execute()
    End Sub


    Private Sub AccionRevisionCondiciones()
        Dim DtPagoPer As New DataTable
        Dim ClsPagoPer As New PagoPeriodico
        Dim DtGrid As DataTable = Grid.CheckedRecords
        If Not DtGrid Is Nothing AndAlso DtGrid.Rows.Count > 0 Then
            If ExpertisApp.GenerateMessage("Se va a proceder a la revisión de las condiciones. Recuerde que  el cambio afectará a todos los pagos pendientes de pagar . ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If DtGrid Is Nothing OrElse DtGrid.Rows.Count = 0 Then
                    ExpertisApp.GenerateMessage("No hay lineas seleccionadas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    DtPagoPer.Columns.Add("IDPagoPeriodico", GetType(Integer))
                    DtPagoPer.Columns.Add("CuotaFija", GetType(Double))
                    DtPagoPer.Columns.Add("RecuperacionCosteFija", GetType(Double))
                    For Each Dr As DataRow In DtGrid.Select
                        If Length(Dr("CantidadMarca1") & String.Empty) > 0 Then
                            Dim DrNew As DataRow = DtPagoPer.NewRow()
                            DrNew("IDPagoPeriodico") = Dr("ID")
                            DrNew("CuotaFija") = Dr("CantidadMarca1")
                            DtPagoPer.Rows.Add(DrNew)
                        End If
                    Next
                    ClsPagoPer.RevisarCondiciones(DtPagoPer)
                    ExpertisApp.GenerateMessage("Proceso finalizado correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Protected Overridable Sub AccionCalcularImpuestos()
        Dim ClsPagoPer As New PagoPeriodico
        Dim ClsBE As New BE.DataEngine
        Dim DtPagoPer, DtSinAmort As DataTable
        Dim BlnSalir As Boolean
        'Dim FrmSin As New frmSinElementosAmort
        Dim DtGrid As DataTable = Grid.CheckedRecords

        Try
            If Not DtGrid Is Nothing AndAlso DtGrid.Rows.Count > 0 Then
                BlnSalir = False
                'rs = jsGrid.ADORecordset.Clone
                DtSinAmort = ClsBE.Filter("vfrmLeasingSinElementosAmortizables", "Id", "")
                Dim Values(-1) As Object
                If Not DtSinAmort Is Nothing AndAlso DtSinAmort.Rows.Count > 0 Then
                    For Each Dr As DataRow In DtSinAmort.Select
                        Dim DrDatos() As DataRow = DtGrid.Select("Id = '" & Dr("ID") & "'")
                        If DrDatos.Length > 0 Then
                            BlnSalir = True
                            'If length(StrID) > 0 Then StrID &= ","
                            'StrID &= Dr("ID")
                            ReDim Preserve Values(UBound(Values) + 1)
                            Values(UBound(Values)) = Dr("ID")
                        End If
                    Next
                End If
                If BlnSalir = True Then
                    ExpertisApp.GenerateMessage("Hay leasings con inmovilizado sin elemento amortizable,no se puede lanzar el proceso.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Dim Frm As New frmSinElementosAmort
                    Frm.Pagos = Values
                    Frm.ShowDialog()
                    Exit Sub
                End If

                DtGrid = Grid.CheckedRecords

                If DtGrid Is Nothing OrElse DtGrid.Rows.Count = 0 Then
                    ExpertisApp.GenerateMessage("No hay lineas seleccionadas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    If ExpertisApp.GenerateMessage("El proceso puede tardar varios minutos. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Me.Cursor = Cursors.WaitCursor
                        For Each Dr As DataRow In DtGrid.Select
                            If Not Dr("NoCalcularImpuesto") Then
                                DtPagoPer = ClsPagoPer.CargarAnticipadoDiferido(Dr("ID"))
                            End If
                        Next
                        Me.Cursor = Cursors.Default
                        ExpertisApp.GenerateMessage("Proceso finalizado correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Else
                ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Procesos Filtros"

    Private Sub AplicarFiltros(ByRef e As Engine.UI.QueryExecutingEventArgs)
        e.Filter.Add("FechaUltimaRevision", FilterOperator.GreaterThanOrEqual, ClbFechaUltRevDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaUltimaRevision", FilterOperator.LessThanOrEqual, ClbFechaUltRevHasta.Value, FilterType.DateTime)
        e.Filter.Add("UltimoPago", FilterOperator.GreaterThanOrEqual, ClbFechaUltPagoDesde.Value, FilterType.DateTime)
        e.Filter.Add("UltimoPago", FilterOperator.LessThanOrEqual, ClbFechaUltPagoHasta.Value, FilterType.DateTime)
        e.Filter.Add("IDTipoPago", FilterOperator.Equal, CmbTipoPago.Value, FilterType.String)
        e.Filter.Add("ID", FilterOperator.Equal, AdvPago.Value, FilterType.Numeric)
    End Sub

    Private Sub LimpiarFiltros()
        ClbFechaAccion.Value = Nothing
        ClbFechaUltRevDesde.Value = Nothing
        ClbFechaUltRevDesde.TextBox.Clear()
        ClbFechaUltRevHasta.Value = Nothing
        ClbFechaUltRevHasta.TextBox.Clear()
        ClbFechaUltPagoDesde.Value = Nothing
        ClbFechaUltPagoDesde.TextBox.Clear()
        ClbFechaUltPagoHasta.Value = Nothing
        ClbFechaUltPagoHasta.TextBox.Clear()
        CmbTipoPago.Value = Nothing
        AdvPago.Value = Nothing
    End Sub

#End Region

#Region "Funciones de Datos"

    Private Function DtLeasingUltimaAño(ByVal pStrClausulaWhere As String) As DataTable
        Dim ClsBE As New BE.DataEngine
        Return ClsBE.Filter("vrptLeasingUltimaAño", "*", pStrClausulaWhere)
    End Function

    Private Function DtLeasingPenultimaAño(ByVal pStrClausulaWhere As String) As DataTable
        Dim ClsBE As New BE.DataEngine
        Return ClsBE.Filter("vrptLeasingPenultimaAño", "*", pStrClausulaWhere)
    End Function

#End Region

#End Region

#Region "Eventos Formulario"

    Private Sub CIGestionLeasing_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadActions()
        ClbFechaAccion.Value = Nothing
    End Sub

    Private Sub CIGestionLeasing_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        AplicarFiltros(e)
    End Sub

    Private Sub CIGestionLeasing_FilterClearing(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterClearing
        LimpiarFiltros()
    End Sub

    Private Sub CIGestionLeasing_SetReportDataSource(ByVal sender As Object, ByVal e As Engine.UI.ReportDataSourceEventArgs) Handles MyBase.SetReportDataSource
        Dim strWhere As String
        Dim FwnPagoPeriodico As New PagoPeriodico
        Select Case e.Alias
            Case "LEPOBA"
                strWhere = "YEAR(tbPago.FechaVencimiento) = " & mintAño
                e.DataSource = FwnPagoPeriodico.DtLeasingPorBanco(strWhere)

            Case "LEULCU"
                strWhere = "YEAR(tbPago.FechaVencimiento) = " & mintAño
                e.DataSource = FwnPagoPeriodico.DtLeasingOpcionCompra(strWhere)

            Case "LEPECU"
                strWhere = "YEAR(tbPago.FechaVencimiento) = " & mintAño
                e.DataSource = FwnPagoPeriodico.DtLeasingUltimaCuota(strWhere)

            Case "LEULAN"
                strWhere = "Año >= " & mintAñoDesde & " AND Año <= " & mintAñoHasta
                e.DataSource = DtLeasingUltimaAño(strWhere)

            Case "LEPEAN"
                strWhere = "Año >= " & mintAñoDesde & " AND Año <= " & mintAñoHasta
                e.DataSource = DtLeasingPenultimaAño(strWhere)

        End Select
    End Sub

    Private Sub CIGestionLeasing_SetReportSelectionCriteria(ByVal sender As Object, ByVal e As Engine.UI.ReportSelectionCriteriaEventArgs) Handles MyBase.SetReportSelectionCriteria

        Select Case e.Alias
            Case "LEASDEUMES", "LEASMESIRC", "LEASAÑOIRC", "LEASDEUAÑO"
                Dim FrmAñoDHInfor As New frmAnoDesdeHastaFC
                Dim IntAñoDesde, IntAñoHasta As Long

                If FrmAñoDHInfor.ShowDialog = DialogResult.OK Then
                    IntAñoDesde = FrmAñoDHInfor.AñoDesde
                    IntAñoHasta = FrmAñoDHInfor.AñoHasta
                    mdtFechaInforme = FrmAñoDHInfor.FechaInforme
                Else : e.Cancel = True
                End If

                Dim Filtro As New Filter(FilterUnionOperator.Or)
                e.Filter.Add("AñoVencimiento", FilterOperator.GreaterThanOrEqual, IntAñoDesde, FilterType.Numeric)
                e.Filter.Add("AñoVencimiento", FilterOperator.LessThanOrEqual, IntAñoHasta, FilterType.Numeric)
                Filtro.Add("FechaContabilizacion", FilterOperator.GreaterThanOrEqual, mdtFechaInforme, FilterType.DateTime)
                Filtro.Add(New IsNullFilterItem("FechaContabilizacion"))
                e.Filter.Add(Filtro)
                Dim strD As String = e.Filter.Compose(New AdoFilterComposer)
                'strfiltro = "(" & strfiltro & ") AND (" & strFiltroFecha & " OR FechaContabilizacion IS NULL)"
                ''FORMULA

                'objReport.Formulas("FechaInforme").Value = dtFechaInforme


        End Select
    End Sub

    Private Sub CIGestionLeasing_SetReportDesignObjects(ByVal sender As Object, ByVal e As Engine.UI.ReportDesignObjectsEventArgs) Handles MyBase.SetReportDesignObjects
        Select Case e.Alias
            Case "LEPOBA", "LEULCU", "LEPECU"
                Dim FrmAñoInforme As New FrmAno
                If FrmAñoInforme.LoadFunction() = DialogResult.OK Then
                    mintAño = FrmAñoInforme.Año
                    e.Formulas("Año").Text = mintAño
                Else : e.Cancel = True
                End If

            Case "LEULAN", "LEPEAN"
                Dim FrmAñoDHInfor As New frmAnoDesdeHasta
                If FrmAñoDHInfor.ShowDialog = DialogResult.OK Then
                    mintAñoDesde = FrmAñoDHInfor.AñoDesde
                    mintAñoHasta = FrmAñoDHInfor.AñoHasta
                    e.Formulas("AñoDesde").Text = mintAñoDesde
                    e.Formulas("AñoHasta").Text = mintAñoHasta
                Else : e.Cancel = True
                End If
            Case "LEASDEUMES", "LEASMESIRC", "LEASAÑOIRC", "LEASDEUAÑO"
                'e.Formulas("FechaInforme").Text = mdtFechaInforme
        End Select
    End Sub

#End Region

End Class
