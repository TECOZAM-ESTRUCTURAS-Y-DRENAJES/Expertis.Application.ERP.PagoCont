Imports Solmicro.Expertis.Business.General
Imports Solmicro.Expertis.Business.Negocio

Public Class MntoPagoPer
    Inherits Solmicro.Expertis.Engine.UI.SimpleMnto

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
    Friend WithEvents TabLineas As Solmicro.Expertis.Engine.UI.Tab
    Friend WithEvents TbCuentasTotales As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents TbPago As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents TbInmovilizado As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents TbAnticipadoDiferido As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents TbADElemento As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents TbActualizaciones As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents FrmPeriodo1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents FrmPeriodo2 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents ChkCuotaFija As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents ChkRecCosteFija As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents ChkPostPagable As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents ChkCarenInteres As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents LblBaseCalculo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblTipoInteres As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblTipoInteresAplicado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblImpNetoFinanciar As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblAportacionFinal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblValorResidual As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ChkVResidualCuota As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents CmbBaseCalculo As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents NtbImpNetoFinanciar As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents NtbAportInicial As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents NtbValorResidual As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents NtbPeriodo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents LblPeriodo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents NtbPagosAño As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents LblUnidad As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblFechaInicioContrato As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents CmbUnidad As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents ClbFechaIniCont As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents NtbNumTotalCuotas As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents LblFechaFin As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblNumTotalCuotas As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ClbFechaFin As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents NtbCuotasCarencia As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents LblNumCuotasCarencia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblFechaContrato As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblFechaUltAct As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblFechaUltRevision As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblNumPagosAño As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblIVA As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblRecupCostePeriodo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblInteresPeriodo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblCuotasconIVA As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents NtbCuotaPeriodo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents NtbRecupCostePeriodo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents NtbInteresPeriodo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents NtbCuotasconIVA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents FrmFiltros As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents GridPagos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents FrmTotalesPagos As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents PnlGridPagos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents PnlTotalesFiltrosPagos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents LblRecupCostePagoTotal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents NtbRecupCosteTotal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents LblInteresPagoTotal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents NtbInteresPagoTotal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents LblCuotaPagoTotal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents NtbCuotaPagoTotal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents LblImpVtoPagoTotal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents NtbImpVtoPagoTotal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents LblVencHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ClbVencHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents LblVencDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ClbVencDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents LblFilContabilizado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents CmbFilContabilizado As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents LblSituacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents CmbSituacion As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents PnlInmovGrid As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents LblTotalValorAmortElemA As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents NtbTotalValorAmortElemA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents LblTotalValorTotalElemA As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents NtbTotalValorTotalElemA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents LblValorNetoContElemA As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents NtbValorNetoContElemA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents FrmInmovTotal As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents NtbGastoFiscalTeorico As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents NtbGastoContable As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents PnlAntDifGrid As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents FrmAntDifTotal As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents LblImpuesto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents NtbImpuesto As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents NtbGastoFiscal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents LblGastoContable As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblGastoFiscalTeorico As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblLimiteAmort As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblGastoFiscal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents PnlActuaGrid As System.Windows.Forms.Panel
    Friend WithEvents GridActualizaciones As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents GridAntDifElemento As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents FrmCuentasLeasing As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents FrmTotales As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents LblGastosporIntereses As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblCuotaPeriodo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblFechaUltRecal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents ULblDescArticulo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ULblGastosInteres As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ULblDeudaLeasCorto As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ULblCosteBien As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ULblDeudaLeasLargo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents LblImpIntereses As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblImpIVA As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblImpCorto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblOpcionCompra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblRecupCoste As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents NtbRecupCoste As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents NtbImpIntereses As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents NtbImpIVA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents NtbImpCorto As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents NtbOpcionCompra As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents ClbFechaUltRecal As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents ClbFechaUltRev As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents ClbFechaUltAct As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents ClbFechaContrato As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents NtbTotalImpCorto As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents NtbTotalImpIVA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents NtbTotalImpInteres As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents NtbTotalRecupCoste As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents LblDeudaLeasLargo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblCosteBien As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblDeudaLeasCorto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents NtbLimiteAmortizacion As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents TbPeriodicidad As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents FilterExec As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents FilterDel As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents FilterExec1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents FilterDel1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Separator8 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents NtbCuotasIVA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents NtbTipoInteresAplicado As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents NtbTipoInteres As Solmicro.Expertis.Engine.UI.TextBox
    Protected WithEvents AdvDeudaLeasLargo As Solmicro.Expertis.Engine.UI.AdvSearch
    Protected WithEvents AdvDeudaLeasCorto As Solmicro.Expertis.Engine.UI.AdvSearch
    Protected WithEvents AdvGastosporIntereses As Solmicro.Expertis.Engine.UI.AdvSearch
    Protected WithEvents AdvCosteBien As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents PnlCabecera As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents TxtDescPago As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents AdvMoneda As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents LblMoneda As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ULblMoneda As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents AdvBancoPropio As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents LblBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ULblBancoPropio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents AdvTipoPago As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents LblTipoPago As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents LblProveedor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ULblDescProveedor As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ChkNoCalcular As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents AdvInmovilizado As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents LblInmovilizado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ULblInmovilizado As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents AdvTipoIVA As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents LblTipoIVA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ULblTipoIVA As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents AdvFormaPago As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents LblFormaPago As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ULblFormaPago As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ULblTipoPago As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Protected WithEvents GridElementos As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents LblSelloContabilizado As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents GridAnticipadoDiferido As Solmicro.Expertis.Engine.UI.Grid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoPagoPer))
        Dim CmbUnidad_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim CmbBaseCalculo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridPagos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridPagos_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim CmbFilContabilizado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim CmbSituacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridActualizaciones_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridElementos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridAnticipadoDiferido_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridAntDifElemento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ChkNoCalcular = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.AdvInmovilizado = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ULblInmovilizado = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.LblInmovilizado = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvTipoIVA = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ULblTipoIVA = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.LblTipoIVA = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvMoneda = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ULblMoneda = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.LblMoneda = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvFormaPago = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ULblFormaPago = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.LblFormaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvBancoPropio = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ULblBancoPropio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.LblBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvTipoPago = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ULblTipoPago = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.LblTipoPago = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ULblDescProveedor = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.LblProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.TxtDescPago = New Solmicro.Expertis.Engine.UI.TextBox
        Me.TabLineas = New Solmicro.Expertis.Engine.UI.Tab
        Me.TbPeriodicidad = New Janus.Windows.UI.Tab.UITabPage
        Me.FrmPeriodo2 = New Solmicro.Expertis.Engine.UI.Frame
        Me.NtbCuotasIVA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.LblIVA = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbInteresPeriodo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbRecupCostePeriodo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbCuotaPeriodo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.LblCuotasconIVA = New Solmicro.Expertis.Engine.UI.Label
        Me.LblInteresPeriodo = New Solmicro.Expertis.Engine.UI.Label
        Me.LblRecupCostePeriodo = New Solmicro.Expertis.Engine.UI.Label
        Me.LblCuotaPeriodo = New Solmicro.Expertis.Engine.UI.Label
        Me.FrmPeriodo1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.NtbTipoInteresAplicado = New Solmicro.Expertis.Engine.UI.TextBox
        Me.NtbTipoInteres = New Solmicro.Expertis.Engine.UI.TextBox
        Me.ClbFechaUltRecal = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.ClbFechaUltRev = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.ClbFechaUltAct = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.ClbFechaContrato = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.ClbFechaFin = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.ClbFechaIniCont = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.CmbUnidad = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.LblFechaUltRecal = New Solmicro.Expertis.Engine.UI.Label
        Me.LblFechaUltRevision = New Solmicro.Expertis.Engine.UI.Label
        Me.LblFechaUltAct = New Solmicro.Expertis.Engine.UI.Label
        Me.LblFechaContrato = New Solmicro.Expertis.Engine.UI.Label
        Me.LblNumCuotasCarencia = New Solmicro.Expertis.Engine.UI.Label
        Me.LblNumTotalCuotas = New Solmicro.Expertis.Engine.UI.Label
        Me.LblFechaFin = New Solmicro.Expertis.Engine.UI.Label
        Me.LblFechaInicioContrato = New Solmicro.Expertis.Engine.UI.Label
        Me.LblNumPagosAño = New Solmicro.Expertis.Engine.UI.Label
        Me.LblUnidad = New Solmicro.Expertis.Engine.UI.Label
        Me.LblPeriodo = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbNumTotalCuotas = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbPagosAño = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbCuotasCarencia = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbPeriodo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbValorResidual = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbAportInicial = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbImpNetoFinanciar = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.CmbBaseCalculo = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.ChkVResidualCuota = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.LblValorResidual = New Solmicro.Expertis.Engine.UI.Label
        Me.LblAportacionFinal = New Solmicro.Expertis.Engine.UI.Label
        Me.LblImpNetoFinanciar = New Solmicro.Expertis.Engine.UI.Label
        Me.LblTipoInteresAplicado = New Solmicro.Expertis.Engine.UI.Label
        Me.LblTipoInteres = New Solmicro.Expertis.Engine.UI.Label
        Me.LblBaseCalculo = New Solmicro.Expertis.Engine.UI.Label
        Me.ChkCarenInteres = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.ChkPostPagable = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.ChkRecCosteFija = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.ChkCuotaFija = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.TbPago = New Janus.Windows.UI.Tab.UITabPage
        Me.PnlGridPagos = New Solmicro.Expertis.Engine.UI.Panel
        Me.GridPagos = New Solmicro.Expertis.Engine.UI.Grid
        Me.PnlTotalesFiltrosPagos = New Solmicro.Expertis.Engine.UI.Panel
        Me.FrmFiltros = New Solmicro.Expertis.Engine.UI.Frame
        Me.CmbFilContabilizado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.CmbSituacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.ClbVencHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.ClbVencDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.LblVencDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.LblVencHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.LblSituacion = New Solmicro.Expertis.Engine.UI.Label
        Me.LblFilContabilizado = New Solmicro.Expertis.Engine.UI.Label
        Me.FrmTotalesPagos = New Solmicro.Expertis.Engine.UI.Frame
        Me.NtbRecupCosteTotal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbInteresPagoTotal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbCuotaPagoTotal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbImpVtoPagoTotal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.LblRecupCostePagoTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.LblInteresPagoTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.LblCuotaPagoTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.LblImpVtoPagoTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.TbActualizaciones = New Janus.Windows.UI.Tab.UITabPage
        Me.PnlActuaGrid = New System.Windows.Forms.Panel
        Me.GridActualizaciones = New Solmicro.Expertis.Engine.UI.Grid
        Me.TbInmovilizado = New Janus.Windows.UI.Tab.UITabPage
        Me.PnlInmovGrid = New Solmicro.Expertis.Engine.UI.Panel
        Me.GridElementos = New Solmicro.Expertis.Engine.UI.Grid
        Me.FrmInmovTotal = New Solmicro.Expertis.Engine.UI.Frame
        Me.LblTotalValorAmortElemA = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbTotalValorAmortElemA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.LblTotalValorTotalElemA = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbTotalValorTotalElemA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.LblValorNetoContElemA = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbValorNetoContElemA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.TbAnticipadoDiferido = New Janus.Windows.UI.Tab.UITabPage
        Me.PnlAntDifGrid = New Solmicro.Expertis.Engine.UI.Panel
        Me.GridAnticipadoDiferido = New Solmicro.Expertis.Engine.UI.Grid
        Me.FrmAntDifTotal = New Solmicro.Expertis.Engine.UI.Frame
        Me.LblGastoFiscal = New Solmicro.Expertis.Engine.UI.Label
        Me.LblLimiteAmort = New Solmicro.Expertis.Engine.UI.Label
        Me.LblGastoFiscalTeorico = New Solmicro.Expertis.Engine.UI.Label
        Me.LblGastoContable = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbImpuesto = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbGastoFiscal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbLimiteAmortizacion = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbGastoFiscalTeorico = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbGastoContable = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.LblImpuesto = New Solmicro.Expertis.Engine.UI.Label
        Me.TbADElemento = New Janus.Windows.UI.Tab.UITabPage
        Me.GridAntDifElemento = New Solmicro.Expertis.Engine.UI.Grid
        Me.TbCuentasTotales = New Janus.Windows.UI.Tab.UITabPage
        Me.FrmTotales = New Solmicro.Expertis.Engine.UI.Frame
        Me.NtbTotalImpCorto = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbTotalImpIVA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbTotalImpInteres = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbTotalRecupCoste = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbOpcionCompra = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbImpCorto = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbImpIVA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbImpIntereses = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbRecupCoste = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.LblRecupCoste = New Solmicro.Expertis.Engine.UI.Label
        Me.LblOpcionCompra = New Solmicro.Expertis.Engine.UI.Label
        Me.LblImpCorto = New Solmicro.Expertis.Engine.UI.Label
        Me.LblImpIVA = New Solmicro.Expertis.Engine.UI.Label
        Me.LblImpIntereses = New Solmicro.Expertis.Engine.UI.Label
        Me.FrmCuentasLeasing = New Solmicro.Expertis.Engine.UI.Frame
        Me.ULblDeudaLeasLargo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ULblCosteBien = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ULblDeudaLeasCorto = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ULblGastosInteres = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ULblDescArticulo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvDeudaLeasLargo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvCosteBien = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvDeudaLeasCorto = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvGastosporIntereses = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblDeudaLeasLargo = New Solmicro.Expertis.Engine.UI.Label
        Me.LblCosteBien = New Solmicro.Expertis.Engine.UI.Label
        Me.LblDeudaLeasCorto = New Solmicro.Expertis.Engine.UI.Label
        Me.LblGastosporIntereses = New Solmicro.Expertis.Engine.UI.Label
        Me.LblArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.PnlCabecera = New Solmicro.Expertis.Engine.UI.Panel
        Me.LblSelloContabilizado = New Solmicro.Expertis.Engine.UI.Label
        Me.FilterExec = New Janus.Windows.UI.CommandBars.UICommand("FilterExec")
        Me.FilterDel = New Janus.Windows.UI.CommandBars.UICommand("FilterDel")
        Me.FilterExec1 = New Janus.Windows.UI.CommandBars.UICommand("FilterExec")
        Me.FilterDel1 = New Janus.Windows.UI.CommandBars.UICommand("FilterDel")
        Me.Separator8 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        CType(Me.TabLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabLineas.SuspendLayout()
        Me.TbPeriodicidad.SuspendLayout()
        Me.FrmPeriodo2.SuspendLayout()
        Me.FrmPeriodo1.SuspendLayout()
        CType(Me.CmbUnidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbBaseCalculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbPago.SuspendLayout()
        Me.PnlGridPagos.suspendlayout()
        CType(Me.GridPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTotalesFiltrosPagos.suspendlayout()
        Me.FrmFiltros.SuspendLayout()
        CType(Me.CmbFilContabilizado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbSituacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrmTotalesPagos.SuspendLayout()
        Me.TbActualizaciones.SuspendLayout()
        Me.PnlActuaGrid.SuspendLayout()
        CType(Me.GridActualizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbInmovilizado.SuspendLayout()
        Me.PnlInmovGrid.suspendlayout()
        CType(Me.GridElementos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrmInmovTotal.SuspendLayout()
        Me.TbAnticipadoDiferido.SuspendLayout()
        Me.PnlAntDifGrid.suspendlayout()
        CType(Me.GridAnticipadoDiferido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrmAntDifTotal.SuspendLayout()
        Me.TbADElemento.SuspendLayout()
        CType(Me.GridAntDifElemento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbCuentasTotales.SuspendLayout()
        Me.FrmTotales.SuspendLayout()
        Me.FrmCuentasLeasing.SuspendLayout()
        Me.PnlCabecera.suspendlayout()
        Me.SuspendLayout()
        '
        'Duplicate
        '
        Me.Duplicate.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        Me.Duplicate.Icon = CType(resources.GetObject("Duplicate.Icon"), System.Drawing.Icon)
        '
        'ToolBar
        '
        Me.ToolBar.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Separator8, Me.FilterExec1, Me.FilterDel1})
        Me.ToolBar.Size = New System.Drawing.Size(720, 39)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 42)
        Me.MenuBar.Size = New System.Drawing.Size(504, 26)
        '
        'UiCommandManager1
        '
        Me.UiCommandManager1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.FilterExec, Me.FilterDel})
        '
        'GoFirst
        '
        Me.GoFirst.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        Me.GoFirst.Icon = CType(resources.GetObject("GoFirst.Icon"), System.Drawing.Icon)
        '
        'GoPrevious
        '
        Me.GoPrevious.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        Me.GoPrevious.Icon = CType(resources.GetObject("GoPrevious.Icon"), System.Drawing.Icon)
        '
        'GoNext
        '
        Me.GoNext.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        Me.GoNext.Icon = CType(resources.GetObject("GoNext.Icon"), System.Drawing.Icon)
        '
        'Delete
        '
        Me.Delete.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        Me.Delete.Icon = CType(resources.GetObject("Delete.Icon"), System.Drawing.Icon)
        Me.Delete.Text = ""
        '
        'Ok
        '
        Me.Ok.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.Ok.Icon = CType(resources.GetObject("Ok.Icon"), System.Drawing.Icon)
        Me.Ok.Text = ""
        '
        'Cancel
        '
        Me.Cancel.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.Cancel.Icon = CType(resources.GetObject("Cancel.Icon"), System.Drawing.Icon)
        Me.Cancel.Text = ""
        '
        'Print
        '
        Me.Print.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        Me.Print.Icon = CType(resources.GetObject("Print.Icon"), System.Drawing.Icon)
        Me.Print.Text = ""
        '
        'Search
        '
        Me.Search.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        Me.Search.Icon = CType(resources.GetObject("Search.Icon"), System.Drawing.Icon)
        Me.Search.Text = ""
        '
        'GoLast
        '
        Me.GoLast.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        Me.GoLast.Icon = CType(resources.GetObject("GoLast.Icon"), System.Drawing.Icon)
        '
        'FindText
        '
        Me.FindText.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'Find
        '
        Me.Find.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        Me.Find.Icon = CType(resources.GetObject("Find.Icon"), System.Drawing.Icon)
        Me.Find.Text = ""
        '
        'NewRow
        '
        Me.NewRow.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        Me.NewRow.Icon = CType(resources.GetObject("NewRow.Icon"), System.Drawing.Icon)
        Me.NewRow.Text = ""
        '
        'Requery
        '
        Me.Requery.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        Me.Requery.Icon = CType(resources.GetObject("Requery.Icon"), System.Drawing.Icon)
        Me.Requery.Text = ""
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        Me.ExecuteActions.Icon = CType(resources.GetObject("ExecuteActions.Icon"), System.Drawing.Icon)
        Me.ExecuteActions.Text = ""
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.TabLineas)
        Me.MainPanel.Controls.Add(Me.PnlCabecera)
        Me.MainPanel.Size = New System.Drawing.Size(712, 476)
        '
        'ChkNoCalcular
        '
        Me.ChkNoCalcular.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TryDataBinding(ChkNoCalcular, New System.Windows.Forms.Binding("BindableValue", Me, "NoCalcularImpuesto", True))
        Me.ChkNoCalcular.Location = New System.Drawing.Point(360, 32)
        Me.ChkNoCalcular.Name = "ChkNoCalcular"
        Me.ChkNoCalcular.Size = New System.Drawing.Size(192, 19)
        Me.ChkNoCalcular.TabIndex = 6
        Me.ChkNoCalcular.Text = "No Calcular Impuestos"
        '
        'AdvInmovilizado
        '
        Me.AdvInmovilizado.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescInmovilizado", ULblInmovilizado)})
        Me.TryDataBinding(AdvInmovilizado, New System.Windows.Forms.Binding("Text", Me, "IDInmovilizado", True))
        Me.AdvInmovilizado.DisabledBackColor = System.Drawing.Color.White
        Me.AdvInmovilizado.DisplayField = "IDInmovilizado"
        Me.AdvInmovilizado.EntityName = "Inmovilizado"
        Me.AdvInmovilizado.Location = New System.Drawing.Point(448, 56)
        Me.AdvInmovilizado.Name = "AdvInmovilizado"
        Me.AdvInmovilizado.PrimaryDataFields = "IDInmovilizado"
        Me.AdvInmovilizado.SecondaryDataFields = "IDInmovilizado"
        Me.AdvInmovilizado.Size = New System.Drawing.Size(80, 23)
        Me.AdvInmovilizado.TabIndex = 7
        Me.AdvInmovilizado.ViewName = "tbMaestroInmovilizado"
        '
        'ULblInmovilizado
        '
        Me.TryDataBinding(ULblInmovilizado, New System.Windows.Forms.Binding("Text", Me.AdvInmovilizado, "DescInmovilizado", True))
        Me.ULblInmovilizado.Location = New System.Drawing.Point(536, 56)
        Me.ULblInmovilizado.Name = "ULblInmovilizado"
        Me.ULblInmovilizado.Size = New System.Drawing.Size(168, 21)
        Me.ULblInmovilizado.TabIndex = 74
        '
        'LblInmovilizado
        '
        Me.LblInmovilizado.Location = New System.Drawing.Point(360, 56)
        Me.LblInmovilizado.Name = "LblInmovilizado"
        Me.LblInmovilizado.Size = New System.Drawing.Size(80, 13)
        Me.LblInmovilizado.TabIndex = 73
        Me.LblInmovilizado.Text = "Inmovilizado"
        Me.LblInmovilizado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvTipoIVA
        '
        Me.AdvTipoIVA.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescTipoIVA", ULblTipoIVA)})
        Me.TryDataBinding(AdvTipoIVA, New System.Windows.Forms.Binding("Text", Me, "IDTipoIVA", True))
        Me.AdvTipoIVA.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTipoIVA.DisplayField = "IDTipoIVA"
        Me.AdvTipoIVA.EntityName = "TipoIva"
        Me.AdvTipoIVA.Location = New System.Drawing.Point(448, 104)
        Me.AdvTipoIVA.Name = "AdvTipoIVA"
        Me.AdvTipoIVA.PrimaryDataFields = "IDTipoIVA"
        Me.AdvTipoIVA.SecondaryDataFields = "IDTipoIva"
        Me.AdvTipoIVA.Size = New System.Drawing.Size(80, 23)
        Me.AdvTipoIVA.TabIndex = 9
        Me.AdvTipoIVA.ViewName = "tbMaestroTipoIva"
        '
        'ULblTipoIVA
        '
        Me.TryDataBinding(ULblTipoIVA, New System.Windows.Forms.Binding("Text", Me.AdvTipoIVA, "DescTipoIVA", True))
        Me.ULblTipoIVA.Location = New System.Drawing.Point(536, 104)
        Me.ULblTipoIVA.Name = "ULblTipoIVA"
        Me.ULblTipoIVA.Size = New System.Drawing.Size(168, 21)
        Me.ULblTipoIVA.TabIndex = 76
        '
        'LblTipoIVA
        '
        Me.LblTipoIVA.Location = New System.Drawing.Point(360, 104)
        Me.LblTipoIVA.Name = "LblTipoIVA"
        Me.LblTipoIVA.Size = New System.Drawing.Size(56, 13)
        Me.LblTipoIVA.TabIndex = 75
        Me.LblTipoIVA.Text = "Tipo IVA"
        Me.LblTipoIVA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvMoneda
        '
        Me.AdvMoneda.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescMoneda", ULblMoneda)})
        Me.TryDataBinding(AdvMoneda, New System.Windows.Forms.Binding("Text", Me, "IdMoneda", True))
        Me.AdvMoneda.DisabledBackColor = System.Drawing.Color.White
        Me.AdvMoneda.DisplayField = "IDMoneda"
        Me.AdvMoneda.EntityName = "Moneda"
        Me.AdvMoneda.Location = New System.Drawing.Point(96, 104)
        Me.AdvMoneda.Name = "AdvMoneda"
        Me.AdvMoneda.PrimaryDataFields = "IdMoneda"
        Me.AdvMoneda.SecondaryDataFields = "IDMoneda"
        Me.AdvMoneda.Size = New System.Drawing.Size(80, 23)
        Me.AdvMoneda.TabIndex = 5
        Me.AdvMoneda.ViewName = "tbMaestroMoneda"
        '
        'ULblMoneda
        '
        Me.TryDataBinding(ULblMoneda, New System.Windows.Forms.Binding("Text", Me.AdvMoneda, "DescMoneda", True))
        Me.ULblMoneda.Location = New System.Drawing.Point(184, 104)
        Me.ULblMoneda.Name = "ULblMoneda"
        Me.ULblMoneda.Size = New System.Drawing.Size(168, 24)
        Me.ULblMoneda.TabIndex = 78
        '
        'LblMoneda
        '
        Me.LblMoneda.Location = New System.Drawing.Point(8, 104)
        Me.LblMoneda.Name = "LblMoneda"
        Me.LblMoneda.Size = New System.Drawing.Size(51, 13)
        Me.LblMoneda.TabIndex = 77
        Me.LblMoneda.Text = "Moneda"
        Me.LblMoneda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvFormaPago
        '
        Me.AdvFormaPago.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescFormaPago", ULblFormaPago)})
        Me.TryDataBinding(AdvFormaPago, New System.Windows.Forms.Binding("Text", Me, "IdFormaPago", True))
        Me.AdvFormaPago.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFormaPago.DisplayField = "IDFormaPago"
        Me.AdvFormaPago.EntityName = "FormaPago"
        Me.AdvFormaPago.Location = New System.Drawing.Point(448, 80)
        Me.AdvFormaPago.Name = "AdvFormaPago"
        Me.AdvFormaPago.PrimaryDataFields = "IdFormaPago"
        Me.AdvFormaPago.SecondaryDataFields = "IDFormaPago"
        Me.AdvFormaPago.Size = New System.Drawing.Size(80, 23)
        Me.AdvFormaPago.TabIndex = 8
        Me.AdvFormaPago.ViewName = "tbMaestroFormaPago"
        '
        'ULblFormaPago
        '
        Me.TryDataBinding(ULblFormaPago, New System.Windows.Forms.Binding("Text", Me.AdvFormaPago, "DescFormaPago", True))
        Me.ULblFormaPago.Location = New System.Drawing.Point(536, 80)
        Me.ULblFormaPago.Name = "ULblFormaPago"
        Me.ULblFormaPago.Size = New System.Drawing.Size(168, 21)
        Me.ULblFormaPago.TabIndex = 80
        '
        'LblFormaPago
        '
        Me.LblFormaPago.Location = New System.Drawing.Point(360, 80)
        Me.LblFormaPago.Name = "LblFormaPago"
        Me.LblFormaPago.Size = New System.Drawing.Size(75, 13)
        Me.LblFormaPago.TabIndex = 79
        Me.LblFormaPago.Text = "Forma Pago"
        Me.LblFormaPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvBancoPropio
        '
        Me.AdvBancoPropio.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescBancoPropio", ULblBancoPropio)})
        Me.TryDataBinding(AdvBancoPropio, New System.Windows.Forms.Binding("Text", Me, "IdBancoPropio", True))
        Me.AdvBancoPropio.DisabledBackColor = System.Drawing.Color.White
        Me.AdvBancoPropio.DisplayField = "IDBancoPropio"
        Me.AdvBancoPropio.EntityName = "BancoPropio"
        Me.AdvBancoPropio.Location = New System.Drawing.Point(96, 80)
        Me.AdvBancoPropio.Name = "AdvBancoPropio"
        Me.AdvBancoPropio.PrimaryDataFields = "IdBancoPropio"
        Me.AdvBancoPropio.SecondaryDataFields = "IDBancoPropio"
        Me.AdvBancoPropio.Size = New System.Drawing.Size(80, 23)
        Me.AdvBancoPropio.TabIndex = 4
        Me.AdvBancoPropio.ViewName = "tbMaestroBancoPropio"
        '
        'ULblBancoPropio
        '
        Me.TryDataBinding(ULblBancoPropio, New System.Windows.Forms.Binding("Text", Me.AdvBancoPropio, "DescBancoPropio", True))
        Me.ULblBancoPropio.Location = New System.Drawing.Point(184, 80)
        Me.ULblBancoPropio.Name = "ULblBancoPropio"
        Me.ULblBancoPropio.Size = New System.Drawing.Size(168, 24)
        Me.ULblBancoPropio.TabIndex = 82
        '
        'LblBancoPropio
        '
        Me.LblBancoPropio.Location = New System.Drawing.Point(8, 80)
        Me.LblBancoPropio.Name = "LblBancoPropio"
        Me.LblBancoPropio.Size = New System.Drawing.Size(82, 13)
        Me.LblBancoPropio.TabIndex = 81
        Me.LblBancoPropio.Text = "Banco Propio"
        Me.LblBancoPropio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvTipoPago
        '
        Me.AdvTipoPago.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescTipo", ULblTipoPago)})
        Me.TryDataBinding(AdvTipoPago, New System.Windows.Forms.Binding("Text", Me, "IdTipoPago", True))
        Me.AdvTipoPago.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTipoPago.DisplayField = "IdTipoPago"
        Me.AdvTipoPago.EntityName = "TipoPago"
        Me.AdvTipoPago.Location = New System.Drawing.Point(96, 32)
        Me.AdvTipoPago.Name = "AdvTipoPago"
        Me.AdvTipoPago.PrimaryDataFields = "IdTipoPago"
        Me.AdvTipoPago.SecondaryDataFields = "IdTipoPago"
        Me.AdvTipoPago.Size = New System.Drawing.Size(80, 23)
        Me.AdvTipoPago.TabIndex = 2
        Me.AdvTipoPago.ViewName = "tbMaestroTipoPago"
        '
        'ULblTipoPago
        '
        Me.TryDataBinding(ULblTipoPago, New System.Windows.Forms.Binding("Text", Me.AdvTipoPago, "DescTipo", True))
        Me.ULblTipoPago.Location = New System.Drawing.Point(184, 32)
        Me.ULblTipoPago.Name = "ULblTipoPago"
        Me.ULblTipoPago.Size = New System.Drawing.Size(168, 21)
        Me.ULblTipoPago.TabIndex = 84
        '
        'LblTipoPago
        '
        Me.LblTipoPago.Location = New System.Drawing.Point(8, 32)
        Me.LblTipoPago.Name = "LblTipoPago"
        Me.LblTipoPago.Size = New System.Drawing.Size(63, 13)
        Me.LblTipoPago.TabIndex = 83
        Me.LblTipoPago.Text = "Tipo Pago"
        Me.LblTipoPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvProveedor
        '
        Me.AdvProveedor.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescProveedor", ULblDescProveedor)})
        Me.TryDataBinding(AdvProveedor, New System.Windows.Forms.Binding("Text", Me, "IDProveedor", True))
        Me.AdvProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.AdvProveedor.DisplayField = "IDProveedor"
        Me.AdvProveedor.EntityName = "Proveedor"
        Me.AdvProveedor.Location = New System.Drawing.Point(96, 56)
        Me.AdvProveedor.Name = "AdvProveedor"
        Me.AdvProveedor.PrimaryDataFields = "IDProveedor"
        Me.AdvProveedor.SecondaryDataFields = "IDProveedor"
        Me.AdvProveedor.Size = New System.Drawing.Size(80, 23)
        Me.AdvProveedor.TabIndex = 3
        Me.AdvProveedor.ViewName = "tbMaestroProveedor"
        '
        'ULblDescProveedor
        '
        Me.TryDataBinding(ULblDescProveedor, New System.Windows.Forms.Binding("Text", Me.AdvProveedor, "DescProveedor", True))
        Me.ULblDescProveedor.Location = New System.Drawing.Point(184, 56)
        Me.ULblDescProveedor.Name = "ULblDescProveedor"
        Me.ULblDescProveedor.Size = New System.Drawing.Size(168, 24)
        Me.ULblDescProveedor.TabIndex = 86
        '
        'LblProveedor
        '
        Me.LblProveedor.Location = New System.Drawing.Point(8, 56)
        Me.LblProveedor.Name = "LblProveedor"
        Me.LblProveedor.Size = New System.Drawing.Size(66, 13)
        Me.LblProveedor.TabIndex = 85
        Me.LblProveedor.Text = "Proveedor"
        Me.LblProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtDescPago
        '
        Me.TryDataBinding(TxtDescPago, New System.Windows.Forms.Binding("Text", Me, "DescPago", True))
        Me.TxtDescPago.DisabledBackColor = System.Drawing.Color.White
        Me.TxtDescPago.Location = New System.Drawing.Point(8, 8)
        Me.TxtDescPago.Name = "TxtDescPago"
        Me.TxtDescPago.Size = New System.Drawing.Size(576, 21)
        Me.TxtDescPago.TabIndex = 0
        '
        'TabLineas
        '
        Me.TabLineas.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TabLineas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabLineas.Location = New System.Drawing.Point(0, 136)
        Me.TabLineas.Name = "TabLineas"
        Me.TabLineas.Size = New System.Drawing.Size(712, 340)
        Me.TabLineas.TabIndex = 10
        Me.TabLineas.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.TbPeriodicidad, Me.TbPago, Me.TbActualizaciones, Me.TbInmovilizado, Me.TbAnticipadoDiferido, Me.TbADElemento, Me.TbCuentasTotales})
        Me.TabLineas.Text = "Totales"
        Me.TabLineas.UseThemes = True
        '
        'TbPeriodicidad
        '
        Me.TbPeriodicidad.Controls.Add(Me.FrmPeriodo2)
        Me.TbPeriodicidad.Controls.Add(Me.FrmPeriodo1)
        Me.TbPeriodicidad.Location = New System.Drawing.Point(1, 21)
        Me.TbPeriodicidad.Name = "TbPeriodicidad"
        Me.TbPeriodicidad.Size = New System.Drawing.Size(710, 318)
        Me.TbPeriodicidad.TabStop = True
        Me.TbPeriodicidad.Text = "Periodicidad"
        '
        'FrmPeriodo2
        '
        Me.FrmPeriodo2.Controls.Add(Me.NtbCuotasIVA)
        Me.FrmPeriodo2.Controls.Add(Me.LblIVA)
        Me.FrmPeriodo2.Controls.Add(Me.NtbInteresPeriodo)
        Me.FrmPeriodo2.Controls.Add(Me.NtbRecupCostePeriodo)
        Me.FrmPeriodo2.Controls.Add(Me.NtbCuotaPeriodo)
        Me.FrmPeriodo2.Controls.Add(Me.LblCuotasconIVA)
        Me.FrmPeriodo2.Controls.Add(Me.LblInteresPeriodo)
        Me.FrmPeriodo2.Controls.Add(Me.LblRecupCostePeriodo)
        Me.FrmPeriodo2.Controls.Add(Me.LblCuotaPeriodo)
        Me.FrmPeriodo2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmPeriodo2.Location = New System.Drawing.Point(472, 0)
        Me.FrmPeriodo2.Name = "FrmPeriodo2"
        Me.FrmPeriodo2.Size = New System.Drawing.Size(238, 318)
        Me.FrmPeriodo2.TabIndex = 22
        Me.FrmPeriodo2.TabStop = False
        Me.FrmPeriodo2.Text = "Totales"
        '
        'NtbCuotasIVA
        '
        Me.TryDataBinding(NtbCuotasIVA, New System.Windows.Forms.Binding("Value", Me, "Importe", True))
        Me.NtbCuotasIVA.DisabledBackColor = System.Drawing.Color.White
        Me.NtbCuotasIVA.Enabled = False
        Me.NtbCuotasIVA.Location = New System.Drawing.Point(144, 208)
        Me.NtbCuotasIVA.Name = "NtbCuotasIVA"
        Me.NtbCuotasIVA.Size = New System.Drawing.Size(80, 21)
        Me.NtbCuotasIVA.TabIndex = 25
        '
        'LblIVA
        '
        Me.LblIVA.Location = New System.Drawing.Point(152, 182)
        Me.LblIVA.Name = "LblIVA"
        Me.LblIVA.Size = New System.Drawing.Size(65, 13)
        Me.LblIVA.TabIndex = 8
        Me.LblIVA.Text = "0 % I.V.A."
        Me.LblIVA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NtbInteresPeriodo
        '
        Me.TryDataBinding(NtbInteresPeriodo, New System.Windows.Forms.Binding("Value", Me, "ImpInteresPeriodo", True))
        Me.NtbInteresPeriodo.DisabledBackColor = System.Drawing.Color.White
        Me.NtbInteresPeriodo.Location = New System.Drawing.Point(144, 152)
        Me.NtbInteresPeriodo.Name = "NtbInteresPeriodo"
        Me.NtbInteresPeriodo.Size = New System.Drawing.Size(80, 21)
        Me.NtbInteresPeriodo.TabIndex = 24
        '
        'NtbRecupCostePeriodo
        '
        Me.TryDataBinding(NtbRecupCostePeriodo, New System.Windows.Forms.Binding("Value", Me, "ImpRecuperacionCostePeriodo", True))
        Me.NtbRecupCostePeriodo.DisabledBackColor = System.Drawing.Color.White
        Me.NtbRecupCostePeriodo.Location = New System.Drawing.Point(144, 102)
        Me.NtbRecupCostePeriodo.Name = "NtbRecupCostePeriodo"
        Me.NtbRecupCostePeriodo.Size = New System.Drawing.Size(80, 21)
        Me.NtbRecupCostePeriodo.TabIndex = 23
        '
        'NtbCuotaPeriodo
        '
        Me.TryDataBinding(NtbCuotaPeriodo, New System.Windows.Forms.Binding("Value", Me, "ImpCuotaPeriodo", True))
        Me.NtbCuotaPeriodo.DisabledBackColor = System.Drawing.Color.White
        Me.NtbCuotaPeriodo.Location = New System.Drawing.Point(144, 54)
        Me.NtbCuotaPeriodo.Name = "NtbCuotaPeriodo"
        Me.NtbCuotaPeriodo.Size = New System.Drawing.Size(80, 21)
        Me.NtbCuotaPeriodo.TabIndex = 22
        '
        'LblCuotasconIVA
        '
        Me.LblCuotasconIVA.Location = New System.Drawing.Point(8, 214)
        Me.LblCuotasconIVA.Name = "LblCuotasconIVA"
        Me.LblCuotasconIVA.Size = New System.Drawing.Size(96, 13)
        Me.LblCuotasconIVA.TabIndex = 3
        Me.LblCuotasconIVA.Text = "Cuotas con IVA"
        Me.LblCuotasconIVA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblInteresPeriodo
        '
        Me.LblInteresPeriodo.Location = New System.Drawing.Point(8, 152)
        Me.LblInteresPeriodo.Name = "LblInteresPeriodo"
        Me.LblInteresPeriodo.Size = New System.Drawing.Size(95, 13)
        Me.LblInteresPeriodo.TabIndex = 2
        Me.LblInteresPeriodo.Text = "Interés Período"
        Me.LblInteresPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblRecupCostePeriodo
        '
        Me.LblRecupCostePeriodo.Location = New System.Drawing.Point(8, 104)
        Me.LblRecupCostePeriodo.Name = "LblRecupCostePeriodo"
        Me.LblRecupCostePeriodo.Size = New System.Drawing.Size(118, 13)
        Me.LblRecupCostePeriodo.TabIndex = 1
        Me.LblRecupCostePeriodo.Text = "Recuper. Coste Per."
        Me.LblRecupCostePeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblCuotaPeriodo
        '
        Me.LblCuotaPeriodo.Location = New System.Drawing.Point(8, 54)
        Me.LblCuotaPeriodo.Name = "LblCuotaPeriodo"
        Me.LblCuotaPeriodo.Size = New System.Drawing.Size(88, 13)
        Me.LblCuotaPeriodo.TabIndex = 0
        Me.LblCuotaPeriodo.Text = "Cuota Periodo"
        Me.LblCuotaPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmPeriodo1
        '
        Me.FrmPeriodo1.Controls.Add(Me.NtbTipoInteresAplicado)
        Me.FrmPeriodo1.Controls.Add(Me.NtbTipoInteres)
        Me.FrmPeriodo1.Controls.Add(Me.ClbFechaUltRecal)
        Me.FrmPeriodo1.Controls.Add(Me.ClbFechaUltRev)
        Me.FrmPeriodo1.Controls.Add(Me.ClbFechaUltAct)
        Me.FrmPeriodo1.Controls.Add(Me.ClbFechaContrato)
        Me.FrmPeriodo1.Controls.Add(Me.ClbFechaFin)
        Me.FrmPeriodo1.Controls.Add(Me.ClbFechaIniCont)
        Me.FrmPeriodo1.Controls.Add(Me.CmbUnidad)
        Me.FrmPeriodo1.Controls.Add(Me.LblFechaUltRecal)
        Me.FrmPeriodo1.Controls.Add(Me.LblFechaUltRevision)
        Me.FrmPeriodo1.Controls.Add(Me.LblFechaUltAct)
        Me.FrmPeriodo1.Controls.Add(Me.LblFechaContrato)
        Me.FrmPeriodo1.Controls.Add(Me.LblNumCuotasCarencia)
        Me.FrmPeriodo1.Controls.Add(Me.LblNumTotalCuotas)
        Me.FrmPeriodo1.Controls.Add(Me.LblFechaFin)
        Me.FrmPeriodo1.Controls.Add(Me.LblFechaInicioContrato)
        Me.FrmPeriodo1.Controls.Add(Me.LblNumPagosAño)
        Me.FrmPeriodo1.Controls.Add(Me.LblUnidad)
        Me.FrmPeriodo1.Controls.Add(Me.LblPeriodo)
        Me.FrmPeriodo1.Controls.Add(Me.NtbNumTotalCuotas)
        Me.FrmPeriodo1.Controls.Add(Me.NtbPagosAño)
        Me.FrmPeriodo1.Controls.Add(Me.NtbCuotasCarencia)
        Me.FrmPeriodo1.Controls.Add(Me.NtbPeriodo)
        Me.FrmPeriodo1.Controls.Add(Me.NtbValorResidual)
        Me.FrmPeriodo1.Controls.Add(Me.NtbAportInicial)
        Me.FrmPeriodo1.Controls.Add(Me.NtbImpNetoFinanciar)
        Me.FrmPeriodo1.Controls.Add(Me.CmbBaseCalculo)
        Me.FrmPeriodo1.Controls.Add(Me.ChkVResidualCuota)
        Me.FrmPeriodo1.Controls.Add(Me.LblValorResidual)
        Me.FrmPeriodo1.Controls.Add(Me.LblAportacionFinal)
        Me.FrmPeriodo1.Controls.Add(Me.LblImpNetoFinanciar)
        Me.FrmPeriodo1.Controls.Add(Me.LblTipoInteresAplicado)
        Me.FrmPeriodo1.Controls.Add(Me.LblTipoInteres)
        Me.FrmPeriodo1.Controls.Add(Me.LblBaseCalculo)
        Me.FrmPeriodo1.Controls.Add(Me.ChkCarenInteres)
        Me.FrmPeriodo1.Controls.Add(Me.ChkPostPagable)
        Me.FrmPeriodo1.Controls.Add(Me.ChkRecCosteFija)
        Me.FrmPeriodo1.Controls.Add(Me.ChkCuotaFija)
        Me.FrmPeriodo1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FrmPeriodo1.Location = New System.Drawing.Point(0, 0)
        Me.FrmPeriodo1.Name = "FrmPeriodo1"
        Me.FrmPeriodo1.Size = New System.Drawing.Size(472, 318)
        Me.FrmPeriodo1.TabIndex = 0
        Me.FrmPeriodo1.TabStop = False
        Me.FrmPeriodo1.Text = "Periodos"
        '
        'NtbTipoInteresAplicado
        '
        Me.TryDataBinding(NtbTipoInteresAplicado, New System.Windows.Forms.Binding("Text", Me, "TipoInteresAplicado", True))
        Me.NtbTipoInteresAplicado.DisabledBackColor = System.Drawing.Color.White
        Me.NtbTipoInteresAplicado.Enabled = False
        Me.NtbTipoInteresAplicado.Location = New System.Drawing.Point(152, 160)
        Me.NtbTipoInteresAplicado.Name = "NtbTipoInteresAplicado"
        Me.NtbTipoInteresAplicado.Size = New System.Drawing.Size(80, 21)
        Me.NtbTipoInteresAplicado.TabIndex = 33
        Me.NtbTipoInteresAplicado.Visible = False
        '
        'NtbTipoInteres
        '
        Me.TryDataBinding(NtbTipoInteres, New System.Windows.Forms.Binding("Text", Me, "TipoInteres", True))
        Me.NtbTipoInteres.DisabledBackColor = System.Drawing.Color.White
        Me.NtbTipoInteres.Location = New System.Drawing.Point(152, 136)
        Me.NtbTipoInteres.Name = "NtbTipoInteres"
        Me.NtbTipoInteres.Size = New System.Drawing.Size(80, 21)
        Me.NtbTipoInteres.TabIndex = 32
        '
        'ClbFechaUltRecal
        '
        Me.TryDataBinding(ClbFechaUltRecal, New System.Windows.Forms.Binding("BindableValue", Me, "FechaRecalculoCP", True))
        Me.ClbFechaUltRecal.DisabledBackColor = System.Drawing.Color.White
        Me.ClbFechaUltRecal.Enabled = False
        Me.ClbFechaUltRecal.Location = New System.Drawing.Point(376, 256)
        Me.ClbFechaUltRecal.Name = "ClbFechaUltRecal"
        Me.ClbFechaUltRecal.ShowDropDown = False
        Me.ClbFechaUltRecal.Size = New System.Drawing.Size(88, 21)
        Me.ClbFechaUltRecal.TabIndex = 21
        '
        'ClbFechaUltRev
        '
        Me.TryDataBinding(ClbFechaUltRev, New System.Windows.Forms.Binding("Text", Me, "FechaUltimaRevision", True))
        Me.ClbFechaUltRev.DisabledBackColor = System.Drawing.Color.White
        Me.ClbFechaUltRev.Enabled = False
        Me.ClbFechaUltRev.Location = New System.Drawing.Point(376, 232)
        Me.ClbFechaUltRev.Name = "ClbFechaUltRev"
        Me.ClbFechaUltRev.ShowDropDown = False
        Me.ClbFechaUltRev.Size = New System.Drawing.Size(88, 21)
        Me.ClbFechaUltRev.TabIndex = 20
        '
        'ClbFechaUltAct
        '
        Me.TryDataBinding(ClbFechaUltAct, New System.Windows.Forms.Binding("Text", Me, "FechaUltimaActualizacion", True))
        Me.ClbFechaUltAct.DisabledBackColor = System.Drawing.Color.White
        Me.ClbFechaUltAct.Location = New System.Drawing.Point(376, 208)
        Me.ClbFechaUltAct.Name = "ClbFechaUltAct"
        Me.ClbFechaUltAct.ShowDropDown = False
        Me.ClbFechaUltAct.Size = New System.Drawing.Size(88, 21)
        Me.ClbFechaUltAct.TabIndex = 19
        '
        'ClbFechaContrato
        '
        Me.TryDataBinding(ClbFechaContrato, New System.Windows.Forms.Binding("BindableValue", Me, "FechaContrato", True))
        Me.ClbFechaContrato.DisabledBackColor = System.Drawing.Color.White
        Me.ClbFechaContrato.Enabled = False
        Me.ClbFechaContrato.Location = New System.Drawing.Point(376, 184)
        Me.ClbFechaContrato.Name = "ClbFechaContrato"
        Me.ClbFechaContrato.ShowDropDown = False
        Me.ClbFechaContrato.Size = New System.Drawing.Size(88, 21)
        Me.ClbFechaContrato.TabIndex = 18
        '
        'ClbFechaFin
        '
        Me.TryDataBinding(ClbFechaFin, New System.Windows.Forms.Binding("Text", Me, "FechaFin", True))
        Me.ClbFechaFin.DisabledBackColor = System.Drawing.Color.White
        Me.ClbFechaFin.Location = New System.Drawing.Point(376, 112)
        Me.ClbFechaFin.Name = "ClbFechaFin"
        Me.ClbFechaFin.Size = New System.Drawing.Size(88, 21)
        Me.ClbFechaFin.TabIndex = 15
        '
        'ClbFechaIniCont
        '
        Me.TryDataBinding(ClbFechaIniCont, New System.Windows.Forms.Binding("Text", Me, "FechaInicio", True))
        Me.ClbFechaIniCont.DisabledBackColor = System.Drawing.Color.White
        Me.ClbFechaIniCont.Location = New System.Drawing.Point(376, 88)
        Me.ClbFechaIniCont.Name = "ClbFechaIniCont"
        Me.ClbFechaIniCont.Size = New System.Drawing.Size(88, 21)
        Me.ClbFechaIniCont.TabIndex = 14
        '
        'CmbUnidad
        '
        Me.TryDataBinding(CmbUnidad, New System.Windows.Forms.Binding("Value", Me, "Unidad", True))
        CmbUnidad_DesignTimeLayout.LayoutString = resources.GetString("CmbUnidad_DesignTimeLayout.LayoutString")
        Me.CmbUnidad.DesignTimeLayout = CmbUnidad_DesignTimeLayout
        Me.CmbUnidad.DisabledBackColor = System.Drawing.Color.White
        Me.CmbUnidad.DisplayMember = "Text"
        Me.CmbUnidad.Location = New System.Drawing.Point(376, 40)
        Me.CmbUnidad.Name = "CmbUnidad"
        Me.CmbUnidad.SelectedIndex = -1
        Me.CmbUnidad.SelectedItem = Nothing
        Me.CmbUnidad.Size = New System.Drawing.Size(88, 21)
        Me.CmbUnidad.TabIndex = 12
        Me.CmbUnidad.ValueMember = "Value"
        '
        'LblFechaUltRecal
        '
        Me.LblFechaUltRecal.Location = New System.Drawing.Point(240, 256)
        Me.LblFechaUltRecal.Name = "LblFechaUltRecal"
        Me.LblFechaUltRecal.Size = New System.Drawing.Size(117, 13)
        Me.LblFechaUltRecal.TabIndex = 31
        Me.LblFechaUltRecal.Text = "Fª Ult. Recal. C-L/P"
        Me.LblFechaUltRecal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblFechaUltRevision
        '
        Me.LblFechaUltRevision.Location = New System.Drawing.Point(240, 232)
        Me.LblFechaUltRevision.Name = "LblFechaUltRevision"
        Me.LblFechaUltRevision.Size = New System.Drawing.Size(115, 13)
        Me.LblFechaUltRevision.TabIndex = 30
        Me.LblFechaUltRevision.Text = "Fecha Ult. Revision"
        Me.LblFechaUltRevision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblFechaUltAct
        '
        Me.LblFechaUltAct.Location = New System.Drawing.Point(240, 208)
        Me.LblFechaUltAct.Name = "LblFechaUltAct"
        Me.LblFechaUltAct.Size = New System.Drawing.Size(89, 13)
        Me.LblFechaUltAct.TabIndex = 29
        Me.LblFechaUltAct.Text = "Fecha Ult. Act."
        Me.LblFechaUltAct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblFechaContrato
        '
        Me.LblFechaContrato.Location = New System.Drawing.Point(240, 184)
        Me.LblFechaContrato.Name = "LblFechaContrato"
        Me.LblFechaContrato.Size = New System.Drawing.Size(94, 13)
        Me.LblFechaContrato.TabIndex = 28
        Me.LblFechaContrato.Text = "Fecha Contrato"
        Me.LblFechaContrato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblNumCuotasCarencia
        '
        Me.LblNumCuotasCarencia.Location = New System.Drawing.Point(240, 160)
        Me.LblNumCuotasCarencia.Name = "LblNumCuotasCarencia"
        Me.LblNumCuotasCarencia.Size = New System.Drawing.Size(136, 13)
        Me.LblNumCuotasCarencia.TabIndex = 27
        Me.LblNumCuotasCarencia.Text = "Num. Cuotas Carencia"
        Me.LblNumCuotasCarencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblNumTotalCuotas
        '
        Me.LblNumTotalCuotas.Location = New System.Drawing.Point(240, 136)
        Me.LblNumTotalCuotas.Name = "LblNumTotalCuotas"
        Me.LblNumTotalCuotas.Size = New System.Drawing.Size(112, 13)
        Me.LblNumTotalCuotas.TabIndex = 26
        Me.LblNumTotalCuotas.Text = "Num. Total Cuotas"
        Me.LblNumTotalCuotas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblFechaFin
        '
        Me.LblFechaFin.Location = New System.Drawing.Point(240, 112)
        Me.LblFechaFin.Name = "LblFechaFin"
        Me.LblFechaFin.Size = New System.Drawing.Size(60, 13)
        Me.LblFechaFin.TabIndex = 25
        Me.LblFechaFin.Text = "Fecha Fin"
        Me.LblFechaFin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblFechaInicioContrato
        '
        Me.LblFechaInicioContrato.Location = New System.Drawing.Point(240, 88)
        Me.LblFechaInicioContrato.Name = "LblFechaInicioContrato"
        Me.LblFechaInicioContrato.Size = New System.Drawing.Size(129, 13)
        Me.LblFechaInicioContrato.TabIndex = 24
        Me.LblFechaInicioContrato.Text = "Fecha Inicio Contrato"
        Me.LblFechaInicioContrato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblNumPagosAño
        '
        Me.LblNumPagosAño.Location = New System.Drawing.Point(240, 64)
        Me.LblNumPagosAño.Name = "LblNumPagosAño"
        Me.LblNumPagosAño.Size = New System.Drawing.Size(99, 13)
        Me.LblNumPagosAño.TabIndex = 23
        Me.LblNumPagosAño.Text = "Nº Pagos al Año"
        Me.LblNumPagosAño.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblUnidad
        '
        Me.LblUnidad.Location = New System.Drawing.Point(240, 40)
        Me.LblUnidad.Name = "LblUnidad"
        Me.LblUnidad.Size = New System.Drawing.Size(46, 13)
        Me.LblUnidad.TabIndex = 22
        Me.LblUnidad.Text = "Unidad"
        Me.LblUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblPeriodo
        '
        Me.LblPeriodo.Location = New System.Drawing.Point(240, 16)
        Me.LblPeriodo.Name = "LblPeriodo"
        Me.LblPeriodo.Size = New System.Drawing.Size(50, 13)
        Me.LblPeriodo.TabIndex = 21
        Me.LblPeriodo.Text = "Periodo"
        Me.LblPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NtbNumTotalCuotas
        '
        Me.TryDataBinding(NtbNumTotalCuotas, New System.Windows.Forms.Binding("Value", Me, "NTotalCuotas", True))
        Me.TryDataBinding(NtbNumTotalCuotas, New System.Windows.Forms.Binding("Text", Me, "NTotalCuotas", True))
        Me.NtbNumTotalCuotas.DisabledBackColor = System.Drawing.Color.White
        Me.NtbNumTotalCuotas.Location = New System.Drawing.Point(376, 136)
        Me.NtbNumTotalCuotas.Name = "NtbNumTotalCuotas"
        Me.NtbNumTotalCuotas.Size = New System.Drawing.Size(88, 21)
        Me.NtbNumTotalCuotas.TabIndex = 16
        '
        'NtbPagosAño
        '
        Me.TryDataBinding(NtbPagosAño, New System.Windows.Forms.Binding("Value", Me, "NPagosAlAño", True))
        Me.NtbPagosAño.DisabledBackColor = System.Drawing.Color.White
        Me.NtbPagosAño.Enabled = False
        Me.NtbPagosAño.Location = New System.Drawing.Point(376, 64)
        Me.NtbPagosAño.Name = "NtbPagosAño"
        Me.NtbPagosAño.Size = New System.Drawing.Size(88, 21)
        Me.NtbPagosAño.TabIndex = 13
        '
        'NtbCuotasCarencia
        '
        Me.TryDataBinding(NtbCuotasCarencia, New System.Windows.Forms.Binding("Value", Me, "NCuotasCarencia", True))
        Me.NtbCuotasCarencia.DisabledBackColor = System.Drawing.Color.White
        Me.NtbCuotasCarencia.Location = New System.Drawing.Point(376, 160)
        Me.NtbCuotasCarencia.Name = "NtbCuotasCarencia"
        Me.NtbCuotasCarencia.Size = New System.Drawing.Size(88, 21)
        Me.NtbCuotasCarencia.TabIndex = 17
        '
        'NtbPeriodo
        '
        Me.TryDataBinding(NtbPeriodo, New System.Windows.Forms.Binding("Value", Me, "Periodo", True))
        Me.NtbPeriodo.DisabledBackColor = System.Drawing.Color.White
        Me.NtbPeriodo.Location = New System.Drawing.Point(376, 16)
        Me.NtbPeriodo.Name = "NtbPeriodo"
        Me.NtbPeriodo.Size = New System.Drawing.Size(88, 21)
        Me.NtbPeriodo.TabIndex = 11
        '
        'NtbValorResidual
        '
        Me.TryDataBinding(NtbValorResidual, New System.Windows.Forms.Binding("Value", Me, "ValorResidual", True))
        Me.NtbValorResidual.DisabledBackColor = System.Drawing.Color.White
        Me.NtbValorResidual.Location = New System.Drawing.Point(152, 256)
        Me.NtbValorResidual.Name = "NtbValorResidual"
        Me.NtbValorResidual.Size = New System.Drawing.Size(80, 21)
        Me.NtbValorResidual.TabIndex = 10
        '
        'NtbAportInicial
        '
        Me.TryDataBinding(NtbAportInicial, New System.Windows.Forms.Binding("Value", Me, "AportacionInicial", True))
        Me.NtbAportInicial.DisabledBackColor = System.Drawing.Color.White
        Me.NtbAportInicial.Location = New System.Drawing.Point(152, 208)
        Me.NtbAportInicial.Name = "NtbAportInicial"
        Me.NtbAportInicial.Size = New System.Drawing.Size(80, 21)
        Me.NtbAportInicial.TabIndex = 8
        Me.NtbAportInicial.Visible = False
        '
        'NtbImpNetoFinanciar
        '
        Me.TryDataBinding(NtbImpNetoFinanciar, New System.Windows.Forms.Binding("Value", Me, "ImpRecuperacionCoste", True))
        Me.NtbImpNetoFinanciar.DisabledBackColor = System.Drawing.Color.White
        Me.NtbImpNetoFinanciar.Location = New System.Drawing.Point(152, 184)
        Me.NtbImpNetoFinanciar.Name = "NtbImpNetoFinanciar"
        Me.NtbImpNetoFinanciar.Size = New System.Drawing.Size(80, 21)
        Me.NtbImpNetoFinanciar.TabIndex = 7
        '
        'CmbBaseCalculo
        '
        Me.TryDataBinding(CmbBaseCalculo, New System.Windows.Forms.Binding("Value", Me, "BaseCalculo", True))
        CmbBaseCalculo_DesignTimeLayout.LayoutString = resources.GetString("CmbBaseCalculo_DesignTimeLayout.LayoutString")
        Me.CmbBaseCalculo.DesignTimeLayout = CmbBaseCalculo_DesignTimeLayout
        Me.CmbBaseCalculo.DisabledBackColor = System.Drawing.Color.White
        Me.CmbBaseCalculo.DisplayMember = "Text"
        Me.CmbBaseCalculo.Location = New System.Drawing.Point(152, 112)
        Me.CmbBaseCalculo.Name = "CmbBaseCalculo"
        Me.CmbBaseCalculo.SelectedIndex = -1
        Me.CmbBaseCalculo.SelectedItem = Nothing
        Me.CmbBaseCalculo.Size = New System.Drawing.Size(80, 21)
        Me.CmbBaseCalculo.TabIndex = 4
        Me.CmbBaseCalculo.ValueMember = "Value"
        Me.CmbBaseCalculo.Visible = False
        '
        'ChkVResidualCuota
        '
        Me.ChkVResidualCuota.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TryDataBinding(ChkVResidualCuota, New System.Windows.Forms.Binding("BindableValue", Me, "ValorResidualIgualCuota", True))
        Me.ChkVResidualCuota.Location = New System.Drawing.Point(8, 232)
        Me.ChkVResidualCuota.Name = "ChkVResidualCuota"
        Me.ChkVResidualCuota.Size = New System.Drawing.Size(176, 23)
        Me.ChkVResidualCuota.TabIndex = 9
        Me.ChkVResidualCuota.Text = "V.Residual = Cuota"
        '
        'LblValorResidual
        '
        Me.LblValorResidual.Location = New System.Drawing.Point(8, 256)
        Me.LblValorResidual.Name = "LblValorResidual"
        Me.LblValorResidual.Size = New System.Drawing.Size(88, 13)
        Me.LblValorResidual.TabIndex = 9
        Me.LblValorResidual.Text = "Valor Residual"
        Me.LblValorResidual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblAportacionFinal
        '
        Me.LblAportacionFinal.Location = New System.Drawing.Point(8, 208)
        Me.LblAportacionFinal.Name = "LblAportacionFinal"
        Me.LblAportacionFinal.Size = New System.Drawing.Size(106, 13)
        Me.LblAportacionFinal.TabIndex = 8
        Me.LblAportacionFinal.Text = "Aportación Inicial"
        Me.LblAportacionFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblAportacionFinal.Visible = False
        '
        'LblImpNetoFinanciar
        '
        Me.LblImpNetoFinanciar.Location = New System.Drawing.Point(8, 184)
        Me.LblImpNetoFinanciar.Name = "LblImpNetoFinanciar"
        Me.LblImpNetoFinanciar.Size = New System.Drawing.Size(130, 13)
        Me.LblImpNetoFinanciar.TabIndex = 7
        Me.LblImpNetoFinanciar.Text = "Imp. Neto a Financiar"
        Me.LblImpNetoFinanciar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTipoInteresAplicado
        '
        Me.LblTipoInteresAplicado.Location = New System.Drawing.Point(8, 160)
        Me.LblTipoInteresAplicado.Name = "LblTipoInteresAplicado"
        Me.LblTipoInteresAplicado.Size = New System.Drawing.Size(128, 13)
        Me.LblTipoInteresAplicado.TabIndex = 6
        Me.LblTipoInteresAplicado.Text = "Tipo Interés Aplicado"
        Me.LblTipoInteresAplicado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblTipoInteresAplicado.Visible = False
        '
        'LblTipoInteres
        '
        Me.LblTipoInteres.Location = New System.Drawing.Point(8, 136)
        Me.LblTipoInteres.Name = "LblTipoInteres"
        Me.LblTipoInteres.Size = New System.Drawing.Size(76, 13)
        Me.LblTipoInteres.TabIndex = 5
        Me.LblTipoInteres.Text = "Tipo Interés"
        Me.LblTipoInteres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblBaseCalculo
        '
        Me.LblBaseCalculo.Location = New System.Drawing.Point(8, 112)
        Me.LblBaseCalculo.Name = "LblBaseCalculo"
        Me.LblBaseCalculo.Size = New System.Drawing.Size(81, 13)
        Me.LblBaseCalculo.TabIndex = 4
        Me.LblBaseCalculo.Text = "Base Cálculo"
        Me.LblBaseCalculo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblBaseCalculo.Visible = False
        '
        'ChkCarenInteres
        '
        Me.ChkCarenInteres.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TryDataBinding(ChkCarenInteres, New System.Windows.Forms.Binding("BindableValue", Me, "CarenciaConIntereses", True))
        Me.ChkCarenInteres.Location = New System.Drawing.Point(8, 88)
        Me.ChkCarenInteres.Name = "ChkCarenInteres"
        Me.ChkCarenInteres.Size = New System.Drawing.Size(176, 16)
        Me.ChkCarenInteres.TabIndex = 3
        Me.ChkCarenInteres.Text = "Carencia Con Intereses"
        Me.ChkCarenInteres.Visible = False
        '
        'ChkPostPagable
        '
        Me.ChkPostPagable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TryDataBinding(ChkPostPagable, New System.Windows.Forms.Binding("BindableValue", Me, "PagoIntereses", True))
        Me.ChkPostPagable.Location = New System.Drawing.Point(8, 64)
        Me.ChkPostPagable.Name = "ChkPostPagable"
        Me.ChkPostPagable.Size = New System.Drawing.Size(176, 16)
        Me.ChkPostPagable.TabIndex = 2
        Me.ChkPostPagable.Text = "PostPagable"
        Me.ChkPostPagable.Visible = False
        '
        'ChkRecCosteFija
        '
        Me.ChkRecCosteFija.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TryDataBinding(ChkRecCosteFija, New System.Windows.Forms.Binding("BindableValue", Me, "RecuperacionFija", True))
        Me.ChkRecCosteFija.Location = New System.Drawing.Point(8, 40)
        Me.ChkRecCosteFija.Name = "ChkRecCosteFija"
        Me.ChkRecCosteFija.Size = New System.Drawing.Size(176, 16)
        Me.ChkRecCosteFija.TabIndex = 1
        Me.ChkRecCosteFija.Text = "Recuperación Coste Fija"
        '
        'ChkCuotaFija
        '
        Me.ChkCuotaFija.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TryDataBinding(ChkCuotaFija, New System.Windows.Forms.Binding("BindableValue", Me, "CuotaFija", True))
        Me.ChkCuotaFija.Location = New System.Drawing.Point(8, 16)
        Me.ChkCuotaFija.Name = "ChkCuotaFija"
        Me.ChkCuotaFija.Size = New System.Drawing.Size(176, 16)
        Me.ChkCuotaFija.TabIndex = 0
        Me.ChkCuotaFija.Text = "Cuota Fija"
        '
        'TbPago
        '
        Me.TbPago.Controls.Add(Me.PnlGridPagos)
        Me.TbPago.Controls.Add(Me.PnlTotalesFiltrosPagos)
        Me.TbPago.Location = New System.Drawing.Point(1, 21)
        Me.TbPago.Name = "TbPago"
        Me.TbPago.Size = New System.Drawing.Size(710, 318)
        Me.TbPago.TabStop = True
        Me.TbPago.Text = "Pago"
        '
        'PnlGridPagos
        '
        Me.PnlGridPagos.Controls.Add(Me.GridPagos)
        Me.PnlGridPagos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlGridPagos.Location = New System.Drawing.Point(0, 0)
        Me.PnlGridPagos.Name = "PnlGridPagos"
        Me.PnlGridPagos.Size = New System.Drawing.Size(710, 190)
        Me.PnlGridPagos.TabIndex = 67
        '
        'GridPagos
        '
        Me.GridPagos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridPagos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridPagos_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridPagos_DesignTimeLayout_Reference_0.Instance"), Object)
        GridPagos_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridPagos_DesignTimeLayout_Reference_0})
        GridPagos_DesignTimeLayout.LayoutString = resources.GetString("GridPagos_DesignTimeLayout.LayoutString")
        Me.GridPagos.DesignTimeLayout = GridPagos_DesignTimeLayout
        Me.GridPagos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPagos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridPagos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridPagos.EntityName = "Pago"
        Me.GridPagos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridPagos.FrozenColumns = 4
        Me.GridPagos.ImageSource = Janus.Windows.GridEX.ImageSource.InternalImageList
        Me.GridPagos.Location = New System.Drawing.Point(0, 0)
        Me.GridPagos.Name = "GridPagos"
        Me.GridPagos.PrimaryDataFields = "Id"
        Me.GridPagos.SecondaryDataFields = "IdPagoPeriodo"
        Me.GridPagos.Size = New System.Drawing.Size(710, 190)
        Me.GridPagos.TabIndex = 38
        Me.GridPagos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridPagos.ViewName = "vCtlCIPagoCont"
        '
        'PnlTotalesFiltrosPagos
        '
        Me.PnlTotalesFiltrosPagos.Controls.Add(Me.FrmFiltros)
        Me.PnlTotalesFiltrosPagos.Controls.Add(Me.FrmTotalesPagos)
        Me.PnlTotalesFiltrosPagos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlTotalesFiltrosPagos.Location = New System.Drawing.Point(0, 190)
        Me.PnlTotalesFiltrosPagos.Name = "PnlTotalesFiltrosPagos"
        Me.PnlTotalesFiltrosPagos.Size = New System.Drawing.Size(710, 128)
        Me.PnlTotalesFiltrosPagos.TabIndex = 68
        '
        'FrmFiltros
        '
        Me.FrmFiltros.Controls.Add(Me.CmbFilContabilizado)
        Me.FrmFiltros.Controls.Add(Me.CmbSituacion)
        Me.FrmFiltros.Controls.Add(Me.ClbVencHasta)
        Me.FrmFiltros.Controls.Add(Me.ClbVencDesde)
        Me.FrmFiltros.Controls.Add(Me.LblVencDesde)
        Me.FrmFiltros.Controls.Add(Me.LblVencHasta)
        Me.FrmFiltros.Controls.Add(Me.LblSituacion)
        Me.FrmFiltros.Controls.Add(Me.LblFilContabilizado)
        Me.FrmFiltros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmFiltros.Location = New System.Drawing.Point(0, 64)
        Me.FrmFiltros.Name = "FrmFiltros"
        Me.FrmFiltros.Size = New System.Drawing.Size(710, 64)
        Me.FrmFiltros.TabIndex = 23
        Me.FrmFiltros.TabStop = False
        Me.FrmFiltros.Text = "Criterios selección"
        '
        'CmbFilContabilizado
        '
        CmbFilContabilizado_DesignTimeLayout.LayoutString = resources.GetString("CmbFilContabilizado_DesignTimeLayout.LayoutString")
        Me.CmbFilContabilizado.DesignTimeLayout = CmbFilContabilizado_DesignTimeLayout
        Me.CmbFilContabilizado.DisabledBackColor = System.Drawing.Color.White
        Me.CmbFilContabilizado.DisplayMember = "Text"
        Me.CmbFilContabilizado.Location = New System.Drawing.Point(608, 32)
        Me.CmbFilContabilizado.Name = "CmbFilContabilizado"
        Me.CmbFilContabilizado.SelectedIndex = -1
        Me.CmbFilContabilizado.SelectedItem = Nothing
        Me.CmbFilContabilizado.Size = New System.Drawing.Size(96, 21)
        Me.CmbFilContabilizado.TabIndex = 27
        Me.CmbFilContabilizado.ValueMember = "Value"
        '
        'CmbSituacion
        '
        CmbSituacion_DesignTimeLayout.LayoutString = resources.GetString("CmbSituacion_DesignTimeLayout.LayoutString")
        Me.CmbSituacion.DesignTimeLayout = CmbSituacion_DesignTimeLayout
        Me.CmbSituacion.DisabledBackColor = System.Drawing.Color.White
        Me.CmbSituacion.DisplayMember = "IDEstado"
        Me.CmbSituacion.EntityName = "EstadoPago"
        Me.CmbSituacion.Location = New System.Drawing.Point(408, 32)
        Me.CmbSituacion.Name = "CmbSituacion"
        Me.CmbSituacion.SelectedIndex = -1
        Me.CmbSituacion.SelectedItem = Nothing
        Me.CmbSituacion.Size = New System.Drawing.Size(96, 21)
        Me.CmbSituacion.TabIndex = 26
        Me.CmbSituacion.ValueMember = "IDEstado"
        Me.CmbSituacion.ViewName = "TbMaestroEstadoPago"
        '
        'ClbVencHasta
        '
        Me.ClbVencHasta.DisabledBackColor = System.Drawing.Color.White
        Me.ClbVencHasta.Location = New System.Drawing.Point(144, 32)
        Me.ClbVencHasta.Name = "ClbVencHasta"
        Me.ClbVencHasta.Size = New System.Drawing.Size(96, 21)
        Me.ClbVencHasta.TabIndex = 25
        '
        'ClbVencDesde
        '
        Me.ClbVencDesde.DisabledBackColor = System.Drawing.Color.White
        Me.ClbVencDesde.Location = New System.Drawing.Point(8, 32)
        Me.ClbVencDesde.Name = "ClbVencDesde"
        Me.ClbVencDesde.Size = New System.Drawing.Size(96, 21)
        Me.ClbVencDesde.TabIndex = 24
        '
        'LblVencDesde
        '
        Me.LblVencDesde.Location = New System.Drawing.Point(8, 16)
        Me.LblVencDesde.Name = "LblVencDesde"
        Me.LblVencDesde.Size = New System.Drawing.Size(98, 13)
        Me.LblVencDesde.TabIndex = 45
        Me.LblVencDesde.Tag = "IdRec=4777;"
        Me.LblVencDesde.Text = "Vencimiento >="
        Me.LblVencDesde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblVencHasta
        '
        Me.LblVencHasta.Location = New System.Drawing.Point(144, 16)
        Me.LblVencHasta.Name = "LblVencHasta"
        Me.LblVencHasta.Size = New System.Drawing.Size(98, 13)
        Me.LblVencHasta.TabIndex = 44
        Me.LblVencHasta.Tag = "IdRec=4779;"
        Me.LblVencHasta.Text = "Vencimiento <="
        Me.LblVencHasta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblSituacion
        '
        Me.LblSituacion.Location = New System.Drawing.Point(408, 16)
        Me.LblSituacion.Name = "LblSituacion"
        Me.LblSituacion.Size = New System.Drawing.Size(59, 13)
        Me.LblSituacion.TabIndex = 43
        Me.LblSituacion.Tag = "IdRec=4781;"
        Me.LblSituacion.Text = "Situación"
        Me.LblSituacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblFilContabilizado
        '
        Me.LblFilContabilizado.Location = New System.Drawing.Point(608, 16)
        Me.LblFilContabilizado.Name = "LblFilContabilizado"
        Me.LblFilContabilizado.Size = New System.Drawing.Size(84, 13)
        Me.LblFilContabilizado.TabIndex = 42
        Me.LblFilContabilizado.Tag = "IdRec=4725;"
        Me.LblFilContabilizado.Text = "Contabilizado"
        Me.LblFilContabilizado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmTotalesPagos
        '
        Me.FrmTotalesPagos.Controls.Add(Me.NtbRecupCosteTotal)
        Me.FrmTotalesPagos.Controls.Add(Me.NtbInteresPagoTotal)
        Me.FrmTotalesPagos.Controls.Add(Me.NtbCuotaPagoTotal)
        Me.FrmTotalesPagos.Controls.Add(Me.NtbImpVtoPagoTotal)
        Me.FrmTotalesPagos.Controls.Add(Me.LblRecupCostePagoTotal)
        Me.FrmTotalesPagos.Controls.Add(Me.LblInteresPagoTotal)
        Me.FrmTotalesPagos.Controls.Add(Me.LblCuotaPagoTotal)
        Me.FrmTotalesPagos.Controls.Add(Me.LblImpVtoPagoTotal)
        Me.FrmTotalesPagos.Dock = System.Windows.Forms.DockStyle.Top
        Me.FrmTotalesPagos.Location = New System.Drawing.Point(0, 0)
        Me.FrmTotalesPagos.Name = "FrmTotalesPagos"
        Me.FrmTotalesPagos.Size = New System.Drawing.Size(710, 64)
        Me.FrmTotalesPagos.TabIndex = 66
        Me.FrmTotalesPagos.TabStop = False
        Me.FrmTotalesPagos.Text = "Totales"
        '
        'NtbRecupCosteTotal
        '
        Me.NtbRecupCosteTotal.DisabledBackColor = System.Drawing.Color.White
        Me.NtbRecupCosteTotal.Enabled = False
        Me.NtbRecupCosteTotal.Location = New System.Drawing.Point(8, 32)
        Me.NtbRecupCosteTotal.Name = "NtbRecupCosteTotal"
        Me.NtbRecupCosteTotal.Size = New System.Drawing.Size(96, 21)
        Me.NtbRecupCosteTotal.TabIndex = 62
        '
        'NtbInteresPagoTotal
        '
        Me.NtbInteresPagoTotal.DisabledBackColor = System.Drawing.Color.White
        Me.NtbInteresPagoTotal.Enabled = False
        Me.NtbInteresPagoTotal.Location = New System.Drawing.Point(208, 32)
        Me.NtbInteresPagoTotal.Name = "NtbInteresPagoTotal"
        Me.NtbInteresPagoTotal.Size = New System.Drawing.Size(96, 21)
        Me.NtbInteresPagoTotal.TabIndex = 61
        '
        'NtbCuotaPagoTotal
        '
        Me.NtbCuotaPagoTotal.DisabledBackColor = System.Drawing.Color.White
        Me.NtbCuotaPagoTotal.Enabled = False
        Me.NtbCuotaPagoTotal.Location = New System.Drawing.Point(408, 32)
        Me.NtbCuotaPagoTotal.Name = "NtbCuotaPagoTotal"
        Me.NtbCuotaPagoTotal.Size = New System.Drawing.Size(96, 21)
        Me.NtbCuotaPagoTotal.TabIndex = 60
        '
        'NtbImpVtoPagoTotal
        '
        Me.NtbImpVtoPagoTotal.DisabledBackColor = System.Drawing.Color.White
        Me.NtbImpVtoPagoTotal.Enabled = False
        Me.NtbImpVtoPagoTotal.Location = New System.Drawing.Point(600, 32)
        Me.NtbImpVtoPagoTotal.Name = "NtbImpVtoPagoTotal"
        Me.NtbImpVtoPagoTotal.Size = New System.Drawing.Size(96, 21)
        Me.NtbImpVtoPagoTotal.TabIndex = 58
        '
        'LblRecupCostePagoTotal
        '
        Me.LblRecupCostePagoTotal.Location = New System.Drawing.Point(8, 16)
        Me.LblRecupCostePagoTotal.Name = "LblRecupCostePagoTotal"
        Me.LblRecupCostePagoTotal.Size = New System.Drawing.Size(121, 13)
        Me.LblRecupCostePagoTotal.TabIndex = 39
        Me.LblRecupCostePagoTotal.Text = "Recuperación Coste"
        Me.LblRecupCostePagoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblInteresPagoTotal
        '
        Me.LblInteresPagoTotal.Location = New System.Drawing.Point(208, 16)
        Me.LblInteresPagoTotal.Name = "LblInteresPagoTotal"
        Me.LblInteresPagoTotal.Size = New System.Drawing.Size(61, 13)
        Me.LblInteresPagoTotal.TabIndex = 63
        Me.LblInteresPagoTotal.Text = "Intereses"
        Me.LblInteresPagoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblCuotaPagoTotal
        '
        Me.LblCuotaPagoTotal.Location = New System.Drawing.Point(408, 16)
        Me.LblCuotaPagoTotal.Name = "LblCuotaPagoTotal"
        Me.LblCuotaPagoTotal.Size = New System.Drawing.Size(41, 13)
        Me.LblCuotaPagoTotal.TabIndex = 64
        Me.LblCuotaPagoTotal.Text = "Cuota"
        Me.LblCuotaPagoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblImpVtoPagoTotal
        '
        Me.LblImpVtoPagoTotal.Location = New System.Drawing.Point(600, 16)
        Me.LblImpVtoPagoTotal.Name = "LblImpVtoPagoTotal"
        Me.LblImpVtoPagoTotal.Size = New System.Drawing.Size(80, 13)
        Me.LblImpVtoPagoTotal.TabIndex = 65
        Me.LblImpVtoPagoTotal.Text = "Importe Vto."
        Me.LblImpVtoPagoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TbActualizaciones
        '
        Me.TbActualizaciones.Controls.Add(Me.PnlActuaGrid)
        Me.TbActualizaciones.Location = New System.Drawing.Point(1, 21)
        Me.TbActualizaciones.Name = "TbActualizaciones"
        Me.TbActualizaciones.Size = New System.Drawing.Size(710, 318)
        Me.TbActualizaciones.TabStop = True
        Me.TbActualizaciones.Text = "Actualizaciones"
        '
        'PnlActuaGrid
        '
        Me.PnlActuaGrid.Controls.Add(Me.GridActualizaciones)
        Me.PnlActuaGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlActuaGrid.Location = New System.Drawing.Point(0, 0)
        Me.PnlActuaGrid.Name = "PnlActuaGrid"
        Me.PnlActuaGrid.Size = New System.Drawing.Size(710, 318)
        Me.PnlActuaGrid.TabIndex = 2
        '
        'GridActualizaciones
        '
        Me.GridActualizaciones.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridActualizaciones.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridActualizaciones_DesignTimeLayout.LayoutString = resources.GetString("GridActualizaciones_DesignTimeLayout.LayoutString")
        Me.GridActualizaciones.DesignTimeLayout = GridActualizaciones_DesignTimeLayout
        Me.GridActualizaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridActualizaciones.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridActualizaciones.EntityName = "PagoPerActualiz"
        Me.GridActualizaciones.Location = New System.Drawing.Point(0, 0)
        Me.GridActualizaciones.Name = "GridActualizaciones"
        Me.GridActualizaciones.PrimaryDataFields = "Id"
        Me.GridActualizaciones.SecondaryDataFields = "IdPago"
        Me.GridActualizaciones.Size = New System.Drawing.Size(710, 318)
        Me.GridActualizaciones.TabIndex = 0
        Me.GridActualizaciones.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridActualizaciones.ViewName = "TbPagoPerActualiz"
        '
        'TbInmovilizado
        '
        Me.TbInmovilizado.Controls.Add(Me.PnlInmovGrid)
        Me.TbInmovilizado.Controls.Add(Me.FrmInmovTotal)
        Me.TbInmovilizado.Location = New System.Drawing.Point(1, 21)
        Me.TbInmovilizado.Name = "TbInmovilizado"
        Me.TbInmovilizado.Size = New System.Drawing.Size(710, 318)
        Me.TbInmovilizado.TabStop = True
        Me.TbInmovilizado.Text = "Inmovilizado"
        '
        'PnlInmovGrid
        '
        Me.PnlInmovGrid.Controls.Add(Me.GridElementos)
        Me.PnlInmovGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlInmovGrid.Location = New System.Drawing.Point(0, 0)
        Me.PnlInmovGrid.Name = "PnlInmovGrid"
        Me.PnlInmovGrid.Size = New System.Drawing.Size(710, 268)
        Me.PnlInmovGrid.TabIndex = 48
        '
        'GridElementos
        '
        Me.GridElementos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridElementos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridElementos_DesignTimeLayout.LayoutString = resources.GetString("GridElementos_DesignTimeLayout.LayoutString")
        Me.GridElementos.DesignTimeLayout = GridElementos_DesignTimeLayout
        Me.GridElementos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridElementos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridElementos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridElementos.EntityName = "Inmovilizado"
        Me.GridElementos.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridElementos.FrozenColumns = 1
        Me.GridElementos.Location = New System.Drawing.Point(0, 0)
        Me.GridElementos.Name = "GridElementos"
        Me.GridElementos.PrimaryDataFields = "IDInmovilizado"
        Me.GridElementos.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.GridElementos.RequeryManually = True
        Me.GridElementos.SecondaryDataFields = "IDInmovilizado"
        Me.GridElementos.Size = New System.Drawing.Size(710, 268)
        Me.GridElementos.TabIndex = 43
        Me.GridElementos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridElementos.ViewName = "vfrmMntoInmovilizado"
        '
        'FrmInmovTotal
        '
        Me.FrmInmovTotal.Controls.Add(Me.LblTotalValorAmortElemA)
        Me.FrmInmovTotal.Controls.Add(Me.NtbTotalValorAmortElemA)
        Me.FrmInmovTotal.Controls.Add(Me.LblTotalValorTotalElemA)
        Me.FrmInmovTotal.Controls.Add(Me.NtbTotalValorTotalElemA)
        Me.FrmInmovTotal.Controls.Add(Me.LblValorNetoContElemA)
        Me.FrmInmovTotal.Controls.Add(Me.NtbValorNetoContElemA)
        Me.FrmInmovTotal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FrmInmovTotal.Location = New System.Drawing.Point(0, 268)
        Me.FrmInmovTotal.Name = "FrmInmovTotal"
        Me.FrmInmovTotal.Size = New System.Drawing.Size(710, 50)
        Me.FrmInmovTotal.TabIndex = 49
        Me.FrmInmovTotal.TabStop = False
        Me.FrmInmovTotal.Text = "Totales"
        '
        'LblTotalValorAmortElemA
        '
        Me.LblTotalValorAmortElemA.Location = New System.Drawing.Point(240, 16)
        Me.LblTotalValorAmortElemA.Name = "LblTotalValorAmortElemA"
        Me.LblTotalValorAmortElemA.Size = New System.Drawing.Size(105, 13)
        Me.LblTotalValorAmortElemA.TabIndex = 44
        Me.LblTotalValorAmortElemA.Text = "Valor Amortizado"
        Me.LblTotalValorAmortElemA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NtbTotalValorAmortElemA
        '
        Me.NtbTotalValorAmortElemA.DisabledBackColor = System.Drawing.Color.White
        Me.NtbTotalValorAmortElemA.Enabled = False
        Me.NtbTotalValorAmortElemA.Location = New System.Drawing.Point(352, 16)
        Me.NtbTotalValorAmortElemA.Name = "NtbTotalValorAmortElemA"
        Me.NtbTotalValorAmortElemA.Size = New System.Drawing.Size(88, 21)
        Me.NtbTotalValorAmortElemA.TabIndex = 45
        '
        'LblTotalValorTotalElemA
        '
        Me.LblTotalValorTotalElemA.Location = New System.Drawing.Point(8, 16)
        Me.LblTotalValorTotalElemA.Name = "LblTotalValorTotalElemA"
        Me.LblTotalValorTotalElemA.Size = New System.Drawing.Size(67, 13)
        Me.LblTotalValorTotalElemA.TabIndex = 46
        Me.LblTotalValorTotalElemA.Text = "Valor Total"
        Me.LblTotalValorTotalElemA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NtbTotalValorTotalElemA
        '
        Me.NtbTotalValorTotalElemA.DisabledBackColor = System.Drawing.Color.White
        Me.NtbTotalValorTotalElemA.Enabled = False
        Me.NtbTotalValorTotalElemA.Location = New System.Drawing.Point(88, 16)
        Me.NtbTotalValorTotalElemA.Name = "NtbTotalValorTotalElemA"
        Me.NtbTotalValorTotalElemA.Size = New System.Drawing.Size(88, 21)
        Me.NtbTotalValorTotalElemA.TabIndex = 44
        '
        'LblValorNetoContElemA
        '
        Me.LblValorNetoContElemA.Location = New System.Drawing.Point(485, 16)
        Me.LblValorNetoContElemA.Name = "LblValorNetoContElemA"
        Me.LblValorNetoContElemA.Size = New System.Drawing.Size(121, 13)
        Me.LblValorNetoContElemA.TabIndex = 47
        Me.LblValorNetoContElemA.Text = "Valor Neto Contable"
        Me.LblValorNetoContElemA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NtbValorNetoContElemA
        '
        Me.NtbValorNetoContElemA.DisabledBackColor = System.Drawing.Color.White
        Me.NtbValorNetoContElemA.Enabled = False
        Me.NtbValorNetoContElemA.Location = New System.Drawing.Point(613, 16)
        Me.NtbValorNetoContElemA.Name = "NtbValorNetoContElemA"
        Me.NtbValorNetoContElemA.Size = New System.Drawing.Size(88, 21)
        Me.NtbValorNetoContElemA.TabIndex = 46
        '
        'TbAnticipadoDiferido
        '
        Me.TbAnticipadoDiferido.Controls.Add(Me.PnlAntDifGrid)
        Me.TbAnticipadoDiferido.Controls.Add(Me.FrmAntDifTotal)
        Me.TbAnticipadoDiferido.Location = New System.Drawing.Point(1, 22)
        Me.TbAnticipadoDiferido.Name = "TbAnticipadoDiferido"
        Me.TbAnticipadoDiferido.Size = New System.Drawing.Size(686, 290)
        Me.TbAnticipadoDiferido.TabStop = True
        Me.TbAnticipadoDiferido.TabVisible = False
        Me.TbAnticipadoDiferido.Text = "Anticipado / Diferido"
        '
        'PnlAntDifGrid
        '
        Me.PnlAntDifGrid.Controls.Add(Me.GridAnticipadoDiferido)
        Me.PnlAntDifGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlAntDifGrid.Location = New System.Drawing.Point(0, 0)
        Me.PnlAntDifGrid.Name = "PnlAntDifGrid"
        Me.PnlAntDifGrid.Size = New System.Drawing.Size(686, 226)
        Me.PnlAntDifGrid.TabIndex = 73
        '
        'GridAnticipadoDiferido
        '
        Me.GridAnticipadoDiferido.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridAnticipadoDiferido.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridAnticipadoDiferido_DesignTimeLayout.LayoutString = resources.GetString("GridAnticipadoDiferido_DesignTimeLayout.LayoutString")
        Me.GridAnticipadoDiferido.DesignTimeLayout = GridAnticipadoDiferido_DesignTimeLayout
        Me.GridAnticipadoDiferido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridAnticipadoDiferido.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridAnticipadoDiferido.EntityName = "PagoPeriodicoImpuesto"
        Me.GridAnticipadoDiferido.Location = New System.Drawing.Point(0, 0)
        Me.GridAnticipadoDiferido.Name = "GridAnticipadoDiferido"
        Me.GridAnticipadoDiferido.PrimaryDataFields = "Id"
        Me.GridAnticipadoDiferido.SecondaryDataFields = "IDPagoPeriodico"
        Me.GridAnticipadoDiferido.Size = New System.Drawing.Size(686, 226)
        Me.GridAnticipadoDiferido.TabIndex = 56
        Me.GridAnticipadoDiferido.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridAnticipadoDiferido.ViewName = "vFrmPagoPeriodicoImpuesto"
        '
        'FrmAntDifTotal
        '
        Me.FrmAntDifTotal.Controls.Add(Me.LblGastoFiscal)
        Me.FrmAntDifTotal.Controls.Add(Me.LblLimiteAmort)
        Me.FrmAntDifTotal.Controls.Add(Me.LblGastoFiscalTeorico)
        Me.FrmAntDifTotal.Controls.Add(Me.LblGastoContable)
        Me.FrmAntDifTotal.Controls.Add(Me.NtbImpuesto)
        Me.FrmAntDifTotal.Controls.Add(Me.NtbGastoFiscal)
        Me.FrmAntDifTotal.Controls.Add(Me.NtbLimiteAmortizacion)
        Me.FrmAntDifTotal.Controls.Add(Me.NtbGastoFiscalTeorico)
        Me.FrmAntDifTotal.Controls.Add(Me.NtbGastoContable)
        Me.FrmAntDifTotal.Controls.Add(Me.LblImpuesto)
        Me.FrmAntDifTotal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FrmAntDifTotal.Location = New System.Drawing.Point(0, 226)
        Me.FrmAntDifTotal.Name = "FrmAntDifTotal"
        Me.FrmAntDifTotal.Size = New System.Drawing.Size(686, 64)
        Me.FrmAntDifTotal.TabIndex = 74
        Me.FrmAntDifTotal.TabStop = False
        Me.FrmAntDifTotal.Text = "Totales"
        '
        'LblGastoFiscal
        '
        Me.LblGastoFiscal.Location = New System.Drawing.Point(488, 16)
        Me.LblGastoFiscal.Name = "LblGastoFiscal"
        Me.LblGastoFiscal.Size = New System.Drawing.Size(75, 13)
        Me.LblGastoFiscal.TabIndex = 75
        Me.LblGastoFiscal.Text = "Gasto Fiscal"
        '
        'LblLimiteAmort
        '
        Me.LblLimiteAmort.Location = New System.Drawing.Point(320, 16)
        Me.LblLimiteAmort.Name = "LblLimiteAmort"
        Me.LblLimiteAmort.Size = New System.Drawing.Size(119, 13)
        Me.LblLimiteAmort.TabIndex = 74
        Me.LblLimiteAmort.Text = "Límite Amortización"
        '
        'LblGastoFiscalTeorico
        '
        Me.LblGastoFiscalTeorico.Location = New System.Drawing.Point(152, 16)
        Me.LblGastoFiscalTeorico.Name = "LblGastoFiscalTeorico"
        Me.LblGastoFiscalTeorico.Size = New System.Drawing.Size(120, 13)
        Me.LblGastoFiscalTeorico.TabIndex = 73
        Me.LblGastoFiscalTeorico.Text = "Gasto Fiscal Teórico"
        '
        'LblGastoContable
        '
        Me.LblGastoContable.Location = New System.Drawing.Point(8, 16)
        Me.LblGastoContable.Name = "LblGastoContable"
        Me.LblGastoContable.Size = New System.Drawing.Size(95, 13)
        Me.LblGastoContable.TabIndex = 72
        Me.LblGastoContable.Text = "Gasto Contable"
        Me.LblGastoContable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NtbImpuesto
        '
        Me.NtbImpuesto.DisabledBackColor = System.Drawing.Color.White
        Me.NtbImpuesto.Enabled = False
        Me.NtbImpuesto.Location = New System.Drawing.Point(616, 32)
        Me.NtbImpuesto.Name = "NtbImpuesto"
        Me.NtbImpuesto.Size = New System.Drawing.Size(84, 21)
        Me.NtbImpuesto.TabIndex = 68
        '
        'NtbGastoFiscal
        '
        Me.NtbGastoFiscal.DisabledBackColor = System.Drawing.Color.White
        Me.NtbGastoFiscal.Enabled = False
        Me.NtbGastoFiscal.Location = New System.Drawing.Point(488, 32)
        Me.NtbGastoFiscal.Name = "NtbGastoFiscal"
        Me.NtbGastoFiscal.Size = New System.Drawing.Size(79, 21)
        Me.NtbGastoFiscal.TabIndex = 67
        '
        'NtbLimiteAmortizacion
        '
        Me.NtbLimiteAmortizacion.DisabledBackColor = System.Drawing.Color.White
        Me.NtbLimiteAmortizacion.Enabled = False
        Me.NtbLimiteAmortizacion.Location = New System.Drawing.Point(320, 32)
        Me.NtbLimiteAmortizacion.Name = "NtbLimiteAmortizacion"
        Me.NtbLimiteAmortizacion.Size = New System.Drawing.Size(120, 21)
        Me.NtbLimiteAmortizacion.TabIndex = 66
        '
        'NtbGastoFiscalTeorico
        '
        Me.NtbGastoFiscalTeorico.DisabledBackColor = System.Drawing.Color.White
        Me.NtbGastoFiscalTeorico.Enabled = False
        Me.NtbGastoFiscalTeorico.Location = New System.Drawing.Point(152, 32)
        Me.NtbGastoFiscalTeorico.Name = "NtbGastoFiscalTeorico"
        Me.NtbGastoFiscalTeorico.Size = New System.Drawing.Size(120, 21)
        Me.NtbGastoFiscalTeorico.TabIndex = 65
        '
        'NtbGastoContable
        '
        Me.NtbGastoContable.DisabledBackColor = System.Drawing.Color.White
        Me.NtbGastoContable.Enabled = False
        Me.NtbGastoContable.Location = New System.Drawing.Point(8, 32)
        Me.NtbGastoContable.Name = "NtbGastoContable"
        Me.NtbGastoContable.Size = New System.Drawing.Size(96, 21)
        Me.NtbGastoContable.TabIndex = 64
        '
        'LblImpuesto
        '
        Me.LblImpuesto.Location = New System.Drawing.Point(616, 16)
        Me.LblImpuesto.Name = "LblImpuesto"
        Me.LblImpuesto.Size = New System.Drawing.Size(61, 13)
        Me.LblImpuesto.TabIndex = 57
        Me.LblImpuesto.Text = "Impuesto"
        Me.LblImpuesto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TbADElemento
        '
        Me.TbADElemento.Controls.Add(Me.GridAntDifElemento)
        Me.TbADElemento.Location = New System.Drawing.Point(1, 21)
        Me.TbADElemento.Name = "TbADElemento"
        Me.TbADElemento.Size = New System.Drawing.Size(710, 318)
        Me.TbADElemento.TabStop = True
        Me.TbADElemento.Text = "A/D por Elemento"
        '
        'GridAntDifElemento
        '
        Me.GridAntDifElemento.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridAntDifElemento_DesignTimeLayout.LayoutString = resources.GetString("GridAntDifElemento_DesignTimeLayout.LayoutString")
        Me.GridAntDifElemento.DesignTimeLayout = GridAntDifElemento_DesignTimeLayout
        Me.GridAntDifElemento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridAntDifElemento.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridAntDifElemento.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridAntDifElemento.EntityName = "PagoPeriodicoImpuesto"
        Me.GridAntDifElemento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridAntDifElemento.Location = New System.Drawing.Point(0, 0)
        Me.GridAntDifElemento.Name = "GridAntDifElemento"
        Me.GridAntDifElemento.PrimaryDataFields = "Id"
        Me.GridAntDifElemento.SecondaryDataFields = "IDPagoPeriodico"
        Me.GridAntDifElemento.Size = New System.Drawing.Size(710, 318)
        Me.GridAntDifElemento.TabIndex = 0
        Me.GridAntDifElemento.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridAntDifElemento.ViewName = "vFrmPagoPeriodicoImpuestoElemento"
        '
        'TbCuentasTotales
        '
        Me.TbCuentasTotales.Controls.Add(Me.FrmTotales)
        Me.TbCuentasTotales.Controls.Add(Me.FrmCuentasLeasing)
        Me.TbCuentasTotales.Location = New System.Drawing.Point(1, 21)
        Me.TbCuentasTotales.Name = "TbCuentasTotales"
        Me.TbCuentasTotales.Size = New System.Drawing.Size(710, 318)
        Me.TbCuentasTotales.TabStop = True
        Me.TbCuentasTotales.Text = "Cuentas / Totales"
        '
        'FrmTotales
        '
        Me.FrmTotales.Controls.Add(Me.NtbTotalImpCorto)
        Me.FrmTotales.Controls.Add(Me.NtbTotalImpIVA)
        Me.FrmTotales.Controls.Add(Me.NtbTotalImpInteres)
        Me.FrmTotales.Controls.Add(Me.NtbTotalRecupCoste)
        Me.FrmTotales.Controls.Add(Me.NtbOpcionCompra)
        Me.FrmTotales.Controls.Add(Me.NtbImpCorto)
        Me.FrmTotales.Controls.Add(Me.NtbImpIVA)
        Me.FrmTotales.Controls.Add(Me.NtbImpIntereses)
        Me.FrmTotales.Controls.Add(Me.NtbRecupCoste)
        Me.FrmTotales.Controls.Add(Me.LblRecupCoste)
        Me.FrmTotales.Controls.Add(Me.LblOpcionCompra)
        Me.FrmTotales.Controls.Add(Me.LblImpCorto)
        Me.FrmTotales.Controls.Add(Me.LblImpIVA)
        Me.FrmTotales.Controls.Add(Me.LblImpIntereses)
        Me.FrmTotales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmTotales.Location = New System.Drawing.Point(432, 0)
        Me.FrmTotales.Name = "FrmTotales"
        Me.FrmTotales.Size = New System.Drawing.Size(278, 318)
        Me.FrmTotales.TabIndex = 40
        Me.FrmTotales.TabStop = False
        Me.FrmTotales.Text = "Totales"
        '
        'NtbTotalImpCorto
        '
        Me.NtbTotalImpCorto.DisabledBackColor = System.Drawing.Color.White
        Me.NtbTotalImpCorto.Enabled = False
        Me.NtbTotalImpCorto.Location = New System.Drawing.Point(144, 200)
        Me.NtbTotalImpCorto.Name = "NtbTotalImpCorto"
        Me.NtbTotalImpCorto.Size = New System.Drawing.Size(120, 21)
        Me.NtbTotalImpCorto.TabIndex = 14
        '
        'NtbTotalImpIVA
        '
        Me.NtbTotalImpIVA.DisabledBackColor = System.Drawing.Color.White
        Me.NtbTotalImpIVA.Enabled = False
        Me.NtbTotalImpIVA.Location = New System.Drawing.Point(144, 152)
        Me.NtbTotalImpIVA.Name = "NtbTotalImpIVA"
        Me.NtbTotalImpIVA.Size = New System.Drawing.Size(120, 21)
        Me.NtbTotalImpIVA.TabIndex = 13
        '
        'NtbTotalImpInteres
        '
        Me.NtbTotalImpInteres.DisabledBackColor = System.Drawing.Color.White
        Me.NtbTotalImpInteres.Enabled = False
        Me.NtbTotalImpInteres.Location = New System.Drawing.Point(144, 96)
        Me.NtbTotalImpInteres.Name = "NtbTotalImpInteres"
        Me.NtbTotalImpInteres.Size = New System.Drawing.Size(120, 21)
        Me.NtbTotalImpInteres.TabIndex = 12
        '
        'NtbTotalRecupCoste
        '
        Me.NtbTotalRecupCoste.DisabledBackColor = System.Drawing.Color.White
        Me.NtbTotalRecupCoste.Enabled = False
        Me.NtbTotalRecupCoste.Location = New System.Drawing.Point(144, 48)
        Me.NtbTotalRecupCoste.Name = "NtbTotalRecupCoste"
        Me.NtbTotalRecupCoste.Size = New System.Drawing.Size(120, 21)
        Me.NtbTotalRecupCoste.TabIndex = 11
        '
        'NtbOpcionCompra
        '
        Me.TryDataBinding(NtbOpcionCompra, New System.Windows.Forms.Binding("Value", Me, "OpcionCompra", True))
        Me.NtbOpcionCompra.DisabledBackColor = System.Drawing.Color.White
        Me.NtbOpcionCompra.Location = New System.Drawing.Point(8, 240)
        Me.NtbOpcionCompra.Name = "NtbOpcionCompra"
        Me.NtbOpcionCompra.Size = New System.Drawing.Size(120, 21)
        Me.NtbOpcionCompra.TabIndex = 45
        Me.NtbOpcionCompra.Visible = False
        '
        'NtbImpCorto
        '
        Me.TryDataBinding(NtbImpCorto, New System.Windows.Forms.Binding("Value", Me, "ImpCortoPlazoDeuda", True))
        Me.NtbImpCorto.DisabledBackColor = System.Drawing.Color.White
        Me.NtbImpCorto.Location = New System.Drawing.Point(8, 200)
        Me.NtbImpCorto.Name = "NtbImpCorto"
        Me.NtbImpCorto.Size = New System.Drawing.Size(120, 21)
        Me.NtbImpCorto.TabIndex = 44
        '
        'NtbImpIVA
        '
        Me.TryDataBinding(NtbImpIVA, New System.Windows.Forms.Binding("Value", Me, "ImpIVAOperacion", True))
        Me.NtbImpIVA.DisabledBackColor = System.Drawing.Color.White
        Me.NtbImpIVA.Location = New System.Drawing.Point(8, 152)
        Me.NtbImpIVA.Name = "NtbImpIVA"
        Me.NtbImpIVA.Size = New System.Drawing.Size(120, 21)
        Me.NtbImpIVA.TabIndex = 43
        '
        'NtbImpIntereses
        '
        Me.TryDataBinding(NtbImpIntereses, New System.Windows.Forms.Binding("Value", Me, "ImpInteresesTotal", True))
        Me.NtbImpIntereses.DisabledBackColor = System.Drawing.Color.White
        Me.NtbImpIntereses.Location = New System.Drawing.Point(8, 104)
        Me.NtbImpIntereses.Name = "NtbImpIntereses"
        Me.NtbImpIntereses.Size = New System.Drawing.Size(120, 21)
        Me.NtbImpIntereses.TabIndex = 42
        '
        'NtbRecupCoste
        '
        Me.TryDataBinding(NtbRecupCoste, New System.Windows.Forms.Binding("Value", Me, "ImpRecuperacionCoste", True))
        Me.NtbRecupCoste.DisabledBackColor = System.Drawing.Color.White
        Me.NtbRecupCoste.Location = New System.Drawing.Point(8, 48)
        Me.NtbRecupCoste.Name = "NtbRecupCoste"
        Me.NtbRecupCoste.Size = New System.Drawing.Size(120, 21)
        Me.NtbRecupCoste.TabIndex = 41
        '
        'LblRecupCoste
        '
        Me.LblRecupCoste.Location = New System.Drawing.Point(8, 32)
        Me.LblRecupCoste.Name = "LblRecupCoste"
        Me.LblRecupCoste.Size = New System.Drawing.Size(121, 13)
        Me.LblRecupCoste.TabIndex = 5
        Me.LblRecupCoste.Text = "Recuperación Coste"
        Me.LblRecupCoste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblOpcionCompra
        '
        Me.LblOpcionCompra.Location = New System.Drawing.Point(8, 224)
        Me.LblOpcionCompra.Name = "LblOpcionCompra"
        Me.LblOpcionCompra.Size = New System.Drawing.Size(96, 13)
        Me.LblOpcionCompra.TabIndex = 3
        Me.LblOpcionCompra.Text = "Opción Compra"
        Me.LblOpcionCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblOpcionCompra.Visible = False
        '
        'LblImpCorto
        '
        Me.LblImpCorto.Location = New System.Drawing.Point(8, 184)
        Me.LblImpCorto.Name = "LblImpCorto"
        Me.LblImpCorto.Size = New System.Drawing.Size(89, 13)
        Me.LblImpCorto.TabIndex = 2
        Me.LblImpCorto.Text = "Importe Corto"
        Me.LblImpCorto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblImpIVA
        '
        Me.LblImpIVA.Location = New System.Drawing.Point(8, 136)
        Me.LblImpIVA.Name = "LblImpIVA"
        Me.LblImpIVA.Size = New System.Drawing.Size(102, 13)
        Me.LblImpIVA.TabIndex = 1
        Me.LblImpIVA.Text = "Importe con IVA"
        Me.LblImpIVA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblImpIntereses
        '
        Me.LblImpIntereses.Location = New System.Drawing.Point(8, 80)
        Me.LblImpIntereses.Name = "LblImpIntereses"
        Me.LblImpIntereses.Size = New System.Drawing.Size(111, 13)
        Me.LblImpIntereses.TabIndex = 0
        Me.LblImpIntereses.Text = "Importe Intereses"
        Me.LblImpIntereses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmCuentasLeasing
        '
        Me.FrmCuentasLeasing.Controls.Add(Me.ULblDeudaLeasLargo)
        Me.FrmCuentasLeasing.Controls.Add(Me.ULblCosteBien)
        Me.FrmCuentasLeasing.Controls.Add(Me.ULblDeudaLeasCorto)
        Me.FrmCuentasLeasing.Controls.Add(Me.ULblGastosInteres)
        Me.FrmCuentasLeasing.Controls.Add(Me.ULblDescArticulo)
        Me.FrmCuentasLeasing.Controls.Add(Me.AdvDeudaLeasLargo)
        Me.FrmCuentasLeasing.Controls.Add(Me.AdvCosteBien)
        Me.FrmCuentasLeasing.Controls.Add(Me.AdvDeudaLeasCorto)
        Me.FrmCuentasLeasing.Controls.Add(Me.AdvGastosporIntereses)
        Me.FrmCuentasLeasing.Controls.Add(Me.AdvArticulo)
        Me.FrmCuentasLeasing.Controls.Add(Me.LblDeudaLeasLargo)
        Me.FrmCuentasLeasing.Controls.Add(Me.LblCosteBien)
        Me.FrmCuentasLeasing.Controls.Add(Me.LblDeudaLeasCorto)
        Me.FrmCuentasLeasing.Controls.Add(Me.LblGastosporIntereses)
        Me.FrmCuentasLeasing.Controls.Add(Me.LblArticulo)
        Me.FrmCuentasLeasing.Dock = System.Windows.Forms.DockStyle.Left
        Me.FrmCuentasLeasing.Location = New System.Drawing.Point(0, 0)
        Me.FrmCuentasLeasing.Name = "FrmCuentasLeasing"
        Me.FrmCuentasLeasing.Size = New System.Drawing.Size(432, 318)
        Me.FrmCuentasLeasing.TabIndex = 33
        Me.FrmCuentasLeasing.TabStop = False
        Me.FrmCuentasLeasing.Text = "Cuentas Leasing"
        '
        'ULblDeudaLeasLargo
        '
        Me.TryDataBinding(ULblDeudaLeasLargo, New System.Windows.Forms.Binding("Text", Me.AdvDeudaLeasLargo, "DescCContable", True))
        Me.ULblDeudaLeasLargo.Location = New System.Drawing.Point(256, 216)
        Me.ULblDeudaLeasLargo.Name = "ULblDeudaLeasLargo"
        Me.ULblDeudaLeasLargo.Size = New System.Drawing.Size(168, 24)
        Me.ULblDeudaLeasLargo.TabIndex = 17
        '
        'ULblCosteBien
        '
        Me.TryDataBinding(ULblCosteBien, New System.Windows.Forms.Binding("Text", Me.AdvCosteBien, "DescCContable", True))
        Me.ULblCosteBien.Location = New System.Drawing.Point(256, 176)
        Me.ULblCosteBien.Name = "ULblCosteBien"
        Me.ULblCosteBien.Size = New System.Drawing.Size(168, 24)
        Me.ULblCosteBien.TabIndex = 15
        '
        'ULblDeudaLeasCorto
        '
        Me.TryDataBinding(ULblDeudaLeasCorto, New System.Windows.Forms.Binding("Text", Me.AdvDeudaLeasCorto, "DescCContable", True))
        Me.ULblDeudaLeasCorto.Location = New System.Drawing.Point(256, 136)
        Me.ULblDeudaLeasCorto.Name = "ULblDeudaLeasCorto"
        Me.ULblDeudaLeasCorto.Size = New System.Drawing.Size(168, 24)
        Me.ULblDeudaLeasCorto.TabIndex = 14
        '
        'ULblGastosInteres
        '
        Me.TryDataBinding(ULblGastosInteres, New System.Windows.Forms.Binding("Text", Me.AdvGastosporIntereses, "DescCContable", True))
        Me.ULblGastosInteres.Location = New System.Drawing.Point(256, 96)
        Me.ULblGastosInteres.Name = "ULblGastosInteres"
        Me.ULblGastosInteres.Size = New System.Drawing.Size(168, 24)
        Me.ULblGastosInteres.TabIndex = 13
        '
        'ULblDescArticulo
        '
        Me.TryDataBinding(ULblDescArticulo, New System.Windows.Forms.Binding("Text", Me.AdvArticulo, "DescArticulo", True))
        Me.ULblDescArticulo.Location = New System.Drawing.Point(256, 56)
        Me.ULblDescArticulo.Name = "ULblDescArticulo"
        Me.ULblDescArticulo.Size = New System.Drawing.Size(168, 24)
        Me.ULblDescArticulo.TabIndex = 12
        '
        'AdvDeudaLeasLargo
        '
        Me.AdvDeudaLeasLargo.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescCContable", ULblDeudaLeasLargo)})
        Me.TryDataBinding(AdvDeudaLeasLargo, New System.Windows.Forms.Binding("Text", Me, "CCInmovilizadoLargoPlazo", True))
        Me.AdvDeudaLeasLargo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvDeudaLeasLargo.DisplayField = "IDCContable"
        Me.AdvDeudaLeasLargo.EntityName = "PlanContable"
        Me.AdvDeudaLeasLargo.Location = New System.Drawing.Point(144, 216)
        Me.AdvDeudaLeasLargo.Name = "AdvDeudaLeasLargo"
        Me.AdvDeudaLeasLargo.PrimaryDataFields = "CCInmovilizadoLargoPlazo"
        Me.AdvDeudaLeasLargo.SecondaryDataFields = "IDCContable"
        Me.AdvDeudaLeasLargo.Size = New System.Drawing.Size(96, 23)
        Me.AdvDeudaLeasLargo.TabIndex = 39
        Me.AdvDeudaLeasLargo.ViewName = "tbPlanContable"
        '
        'AdvCosteBien
        '
        Me.AdvCosteBien.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescCContable", ULblCosteBien)})
        Me.TryDataBinding(AdvCosteBien, New System.Windows.Forms.Binding("Text", Me, "CCNominal", True))
        Me.AdvCosteBien.DisabledBackColor = System.Drawing.Color.White
        Me.AdvCosteBien.DisplayField = "IDCContable"
        Me.AdvCosteBien.EntityName = "PlanContable"
        Me.AdvCosteBien.Location = New System.Drawing.Point(144, 176)
        Me.AdvCosteBien.Name = "AdvCosteBien"
        Me.AdvCosteBien.PrimaryDataFields = "CCNominal"
        Me.AdvCosteBien.SecondaryDataFields = "IDCContable"
        Me.AdvCosteBien.Size = New System.Drawing.Size(96, 23)
        Me.AdvCosteBien.TabIndex = 37
        Me.AdvCosteBien.ViewName = "tbPlanContable"
        '
        'AdvDeudaLeasCorto
        '
        Me.AdvDeudaLeasCorto.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescCContable", ULblDeudaLeasCorto)})
        Me.TryDataBinding(AdvDeudaLeasCorto, New System.Windows.Forms.Binding("Text", Me, "IdCContable", True))
        Me.AdvDeudaLeasCorto.DisabledBackColor = System.Drawing.Color.White
        Me.AdvDeudaLeasCorto.DisplayField = "IDCContable"
        Me.AdvDeudaLeasCorto.EntityName = "PlanContable"
        Me.AdvDeudaLeasCorto.Location = New System.Drawing.Point(144, 136)
        Me.AdvDeudaLeasCorto.Name = "AdvDeudaLeasCorto"
        Me.AdvDeudaLeasCorto.PrimaryDataFields = "IDCContable"
        Me.AdvDeudaLeasCorto.SecondaryDataFields = "IDCContable"
        Me.AdvDeudaLeasCorto.Size = New System.Drawing.Size(96, 23)
        Me.AdvDeudaLeasCorto.TabIndex = 36
        Me.AdvDeudaLeasCorto.ViewName = "tbPlanContable"
        '
        'AdvGastosporIntereses
        '
        Me.AdvGastosporIntereses.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescCContable", ULblGastosInteres)})
        Me.TryDataBinding(AdvGastosporIntereses, New System.Windows.Forms.Binding("Text", Me, "CCGastoInteres", True))
        Me.AdvGastosporIntereses.DisabledBackColor = System.Drawing.Color.White
        Me.AdvGastosporIntereses.DisplayField = "IDCContable"
        Me.AdvGastosporIntereses.EntityName = "PlanContable"
        Me.AdvGastosporIntereses.Location = New System.Drawing.Point(144, 96)
        Me.AdvGastosporIntereses.Name = "AdvGastosporIntereses"
        Me.AdvGastosporIntereses.PrimaryDataFields = "CCGastoInteres"
        Me.AdvGastosporIntereses.SecondaryDataFields = "IDCContable"
        Me.AdvGastosporIntereses.Size = New System.Drawing.Size(96, 23)
        Me.AdvGastosporIntereses.TabIndex = 35
        Me.AdvGastosporIntereses.ViewName = "tbPlanContable"
        '
        'AdvArticulo
        '
        Me.AdvArticulo.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescArticulo", ULblDescArticulo)})
        Me.TryDataBinding(AdvArticulo, New System.Windows.Forms.Binding("Text", Me, "IDArticulo", True))
        Me.AdvArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvArticulo.DisplayField = "IDArticulo"
        Me.AdvArticulo.EntityName = "Articulo"
        Me.AdvArticulo.Location = New System.Drawing.Point(144, 56)
        Me.AdvArticulo.Name = "AdvArticulo"
        Me.AdvArticulo.PrimaryDataFields = "IDArticulo"
        Me.AdvArticulo.SecondaryDataFields = "IDArticulo"
        Me.AdvArticulo.Size = New System.Drawing.Size(96, 23)
        Me.AdvArticulo.TabIndex = 34
        Me.AdvArticulo.ViewName = "tbMaestroArticulo"
        '
        'LblDeudaLeasLargo
        '
        Me.LblDeudaLeasLargo.Location = New System.Drawing.Point(8, 216)
        Me.LblDeudaLeasLargo.Name = "LblDeudaLeasLargo"
        Me.LblDeudaLeasLargo.Size = New System.Drawing.Size(125, 13)
        Me.LblDeudaLeasLargo.TabIndex = 5
        Me.LblDeudaLeasLargo.Text = "Deuda Leas. a Largo"
        Me.LblDeudaLeasLargo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblCosteBien
        '
        Me.LblCosteBien.Location = New System.Drawing.Point(8, 176)
        Me.LblCosteBien.Name = "LblCosteBien"
        Me.LblCosteBien.Size = New System.Drawing.Size(90, 13)
        Me.LblCosteBien.TabIndex = 3
        Me.LblCosteBien.Text = "Coste del Bien"
        Me.LblCosteBien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblDeudaLeasCorto
        '
        Me.LblDeudaLeasCorto.Location = New System.Drawing.Point(8, 136)
        Me.LblDeudaLeasCorto.Name = "LblDeudaLeasCorto"
        Me.LblDeudaLeasCorto.Size = New System.Drawing.Size(125, 13)
        Me.LblDeudaLeasCorto.TabIndex = 2
        Me.LblDeudaLeasCorto.Text = "Deuda Leas. a Corto"
        Me.LblDeudaLeasCorto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblGastosporIntereses
        '
        Me.LblGastosporIntereses.Location = New System.Drawing.Point(8, 96)
        Me.LblGastosporIntereses.Name = "LblGastosporIntereses"
        Me.LblGastosporIntereses.Size = New System.Drawing.Size(127, 13)
        Me.LblGastosporIntereses.TabIndex = 1
        Me.LblGastosporIntereses.Text = "Gastos por Intereses"
        Me.LblGastosporIntereses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblArticulo
        '
        Me.LblArticulo.Location = New System.Drawing.Point(8, 56)
        Me.LblArticulo.Name = "LblArticulo"
        Me.LblArticulo.Size = New System.Drawing.Size(50, 13)
        Me.LblArticulo.TabIndex = 0
        Me.LblArticulo.Text = "Artículo"
        Me.LblArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnlCabecera
        '
        Me.PnlCabecera.Controls.Add(Me.LblSelloContabilizado)
        Me.PnlCabecera.Controls.Add(Me.ULblMoneda)
        Me.PnlCabecera.Controls.Add(Me.LblMoneda)
        Me.PnlCabecera.Controls.Add(Me.AdvTipoIVA)
        Me.PnlCabecera.Controls.Add(Me.LblTipoIVA)
        Me.PnlCabecera.Controls.Add(Me.AdvProveedor)
        Me.PnlCabecera.Controls.Add(Me.ULblTipoIVA)
        Me.PnlCabecera.Controls.Add(Me.AdvFormaPago)
        Me.PnlCabecera.Controls.Add(Me.LblFormaPago)
        Me.PnlCabecera.Controls.Add(Me.AdvMoneda)
        Me.PnlCabecera.Controls.Add(Me.AdvBancoPropio)
        Me.PnlCabecera.Controls.Add(Me.LblBancoPropio)
        Me.PnlCabecera.Controls.Add(Me.ULblBancoPropio)
        Me.PnlCabecera.Controls.Add(Me.LblProveedor)
        Me.PnlCabecera.Controls.Add(Me.ULblDescProveedor)
        Me.PnlCabecera.Controls.Add(Me.TxtDescPago)
        Me.PnlCabecera.Controls.Add(Me.AdvTipoPago)
        Me.PnlCabecera.Controls.Add(Me.LblTipoPago)
        Me.PnlCabecera.Controls.Add(Me.ChkNoCalcular)
        Me.PnlCabecera.Controls.Add(Me.ULblTipoPago)
        Me.PnlCabecera.Controls.Add(Me.ULblFormaPago)
        Me.PnlCabecera.Controls.Add(Me.AdvInmovilizado)
        Me.PnlCabecera.Controls.Add(Me.LblInmovilizado)
        Me.PnlCabecera.Controls.Add(Me.ULblInmovilizado)
        Me.PnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PnlCabecera.Name = "PnlCabecera"
        Me.PnlCabecera.Size = New System.Drawing.Size(712, 136)
        Me.PnlCabecera.TabIndex = 89
        '
        'LblSelloContabilizado
        '
        Me.LblSelloContabilizado.Location = New System.Drawing.Point(608, 12)
        Me.LblSelloContabilizado.Name = "LblSelloContabilizado"
        Me.LblSelloContabilizado.Size = New System.Drawing.Size(84, 13)
        Me.LblSelloContabilizado.TabIndex = 147
        Me.LblSelloContabilizado.Tag = ""
        Me.LblSelloContabilizado.Text = "Contabilizada"
        Me.LblSelloContabilizado.Visible = False
        '
        'FilterExec
        '
        Me.FilterExec.CommandStyle = Janus.Windows.UI.CommandBars.CommandStyle.TextImage
        Me.FilterExec.Icon = CType(resources.GetObject("FilterExec.Icon"), System.Drawing.Icon)
        Me.FilterExec.Key = "FilterExec"
        Me.FilterExec.Name = "FilterExec"
        Me.FilterExec.ToolTipText = "Ejecutar Consulta"
        Me.FilterExec.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'FilterDel
        '
        Me.FilterDel.Icon = CType(resources.GetObject("FilterDel.Icon"), System.Drawing.Icon)
        Me.FilterDel.Key = "FilterDel"
        Me.FilterDel.Name = "FilterDel"
        Me.FilterDel.ToolTipText = "Borrar Filtros"
        Me.FilterDel.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'FilterExec1
        '
        Me.FilterExec1.Key = "FilterExec"
        Me.FilterExec1.Name = "FilterExec1"
        '
        'FilterDel1
        '
        Me.FilterDel1.Key = "FilterDel"
        Me.FilterDel1.Name = "FilterDel1"
        '
        'Separator8
        '
        Me.Separator8.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator8.Key = "Separator"
        Me.Separator8.Name = "Separator8"
        '
        'MntoPagoPer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(720, 549)
        Me.EntityName = "PagoPeriodico"
        Me.Name = "MntoPagoPer"
        Me.NavigationFields = "Id"
        Me.ViewName = "tbPagoPeriodico"
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        CType(Me.TabLineas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabLineas.ResumeLayout(False)
        Me.TbPeriodicidad.ResumeLayout(False)
        Me.FrmPeriodo2.ResumeLayout(False)
        Me.FrmPeriodo2.PerformLayout()
        Me.FrmPeriodo1.ResumeLayout(False)
        Me.FrmPeriodo1.PerformLayout()
        CType(Me.CmbUnidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbBaseCalculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbPago.ResumeLayout(False)
        Me.PnlGridPagos.ResumeLayout(False)
        CType(Me.GridPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTotalesFiltrosPagos.ResumeLayout(False)
        Me.FrmFiltros.ResumeLayout(False)
        Me.FrmFiltros.PerformLayout()
        CType(Me.CmbFilContabilizado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbSituacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrmTotalesPagos.ResumeLayout(False)
        Me.FrmTotalesPagos.PerformLayout()
        Me.TbActualizaciones.ResumeLayout(False)
        Me.PnlActuaGrid.ResumeLayout(False)
        CType(Me.GridActualizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbInmovilizado.ResumeLayout(False)
        Me.PnlInmovGrid.ResumeLayout(False)
        CType(Me.GridElementos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrmInmovTotal.ResumeLayout(False)
        Me.FrmInmovTotal.PerformLayout()
        Me.TbAnticipadoDiferido.ResumeLayout(False)
        Me.PnlAntDifGrid.ResumeLayout(False)
        CType(Me.GridAnticipadoDiferido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrmAntDifTotal.ResumeLayout(False)
        Me.FrmAntDifTotal.PerformLayout()
        Me.TbADElemento.ResumeLayout(False)
        CType(Me.GridAntDifElemento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbCuentasTotales.ResumeLayout(False)
        Me.FrmTotales.ResumeLayout(False)
        Me.FrmTotales.PerformLayout()
        Me.FrmCuentasLeasing.ResumeLayout(False)
        Me.FrmCuentasLeasing.PerformLayout()
        Me.PnlCabecera.ResumeLayout(False)
        Me.PnlCabecera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Código Antiguo del Migrador "
    '    Private Structure Action
    '        Dim Name As String
    '        Dim ID As Long
    '    End Structure

    '    Private intDigitosAuxiliar As Integer
    '    Private blnUpdateCuenta As Boolean
    '    Private mlngActionsCount As Long
    '    Private strEjerAct As String
    '    Private mblnImpModif As Boolean
    '    Private mblnNoModif As Boolean
    '    Private mdblCambioA As Double
    '    Private mdblCambioB As Long
    '    Private mlngNDecimales As Long
    '    Private mlngNDecimalesA As Long
    '    Private mlngNDecimalesB As Long
    '    Private rcsTipoIva As Recordset
    '    Private mblnInicio As Boolean
    '    Private mblnCalculandoRegistro As Boolean
    '    Private mblnCambioRegistro As Boolean

    '    Private Sub ActualizarDescripcionFactorIVA()
    '        Dim dblFactor As Double
    '        On Error GoTo TratarError

    '        If IsNumeric(fwiFactorIVA.Text) Then dblFactor = CDbl(fwiFactorIVA.Text)
    '        lblFactorIVA.Text = Format(dblFactor, "#,0.00") & " % " & TraslateWord(5047)

    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub ActualizarImporteTotalConIVA()
    '        Dim dblImporte As Double
    '        Dim dblInteres As Double
    '        Dim dblFactor As Double
    '        Dim dblIVA As Double
    '        Dim dblAmortizacion As Double
    '        On Error GoTo TratarError

    '        If Me.RecordsState <> RecordsState.Saved And Not mblnCambioRegistro Then
    '            If IsNumeric(FwiImpRecuperacionCoste.Value) Then dblAmortizacion = CDbl(FwiImpRecuperacionCoste.Value)
    '            If IsNumeric(FwiImpInteresesTotal.Value) Then dblInteres = CDbl(FwiImpInteresesTotal.Value)
    '            If IsNumeric(fwiFactorIVA.Text) Then dblFactor = CDbl(fwiFactorIVA.Text)

    '            dblImporte = dblAmortizacion + dblInteres
    '            dblIVA = dblImporte * (dblFactor / 100)

    '            FwiImpIVAOperacion.Value = dblImporte + dblIVA

    '        End If
    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub ActualizarImporteConIVA()
    '        Dim dblImporte As Double
    '        Dim dblInteres As Double
    '        Dim dblFactor As Double
    '        Dim dblIVA As Double
    '        Dim dblAmortizacion As Double
    '        On Error GoTo TratarError

    '        If Me.RecordsState <> RecordsState.Saved And Not mblnCambioRegistro Then
    '            If IsNumeric(FwiRecCostePeriodo.Value) Then dblAmortizacion = CDbl(FwiRecCostePeriodo.Value)
    '            If IsNumeric(FwiInteresPeriodo.Value) Then dblInteres = CDbl(FwiInteresPeriodo.Value)
    '            If IsNumeric(fwiFactorIVA.Text) Then dblFactor = CDbl(fwiFactorIVA.Text)

    '            dblImporte = dblAmortizacion + dblInteres
    '            dblIVA = dblImporte * (dblFactor / 100)

    '            FwiCuotaIva.Value = dblImporte + dblIVA

    '        End If
    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub CargarDescripcion()
    '        Dim fwnPlanContable As PlanContable
    '        Dim rcsPlanContable As Recordset
    '        Dim strWhere As String
    '        Dim strDescCContable As String
    '        Dim strDescCCIntereses As String
    '        Dim strDescCCNominal As String
    '        Dim strDescCCCortoplazo As String
    '        Dim strDescCCLargoplazo As String
    '        Dim strDescCCInteresesTotal As String
    '        On Error GoTo TratarError

    '        strWhere = "IDEjercicio = '" & strEjerAct & "'" _
    '        & " AND IDCContable IN ('" & FwiCCIntereses.Text & "'" _
    '        & ",'" & FwiCCNominal.Text & "'" _
    '        & ",'" & FwiCCInteresesTotal.Text & "'" _
    '        & ",'" & FwICCCortoPlazo.Text & "'" _
    '        & ",'" & FwICCLargoPlazo.Text & "')"

    '        fwnPlanContable = New PlanContable
    '        rcsPlanContable = fwnPlanContable.Filter(, strWhere)
    '        fwnPlanContable = Nothing
    '        If Not rcsPlanContable Is Nothing Then
    '            Do Until rcsPlanContable.EOF
    '                If rcsPlanContable.Fields("IDCContable").Value = FwiCCIntereses.Text Then _
    '                strDescCCIntereses = rcsPlanContable.Fields("DescCContable").Value & vbNullString
    '                If rcsPlanContable.Fields("IDCContable").Value = FwiCCNominal.Text Then _
    '                strDescCCNominal = rcsPlanContable.Fields("DescCContable").Value & vbNullString
    '                If rcsPlanContable.Fields("IDCContable").Value = FwiCCInteresesTotal.Text Then _
    '                strDescCCInteresesTotal = rcsPlanContable.Fields("DescCContable").Value & vbNullString
    '                If rcsPlanContable.Fields("IDCContable").Value = FwICCCortoPlazo.Text Then _
    '                strDescCCCortoplazo = rcsPlanContable.Fields("DescCContable").Value & vbNullString
    '                If rcsPlanContable.Fields("IDCContable").Value = FwICCLargoPlazo.Text Then _
    '                strDescCCLargoplazo = rcsPlanContable.Fields("DescCContable").Value & vbNullString
    '                rcsPlanContable.MoveNext()
    '            Loop
    '            FwiCCIntereses.Text = strDescCCIntereses
    '            FwiCCNominal.Text = strDescCCNominal
    '            FwiCCInteresesTotal.Text = strDescCCInteresesTotal
    '            FwICCCortoPlazo.Text = strDescCCCortoplazo
    '            FwICCLargoPlazo.Text = strDescCCLargoplazo
    '        End If

    'Fin:
    '        On Error Resume Next
    '        fwnPlanContable = Nothing
    '        rcsPlanContable = Nothing
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '        Resume
    '    End Sub

    '    Private Sub FwiCCNominal_SetPredefinedFilter(ByVal rstPredefinedFilter As Recordset)
    '        On Error GoTo TratarError
    '        rstPredefinedFilter.Fields("IDEjercicio").Value = strEjerAct
    '        rstPredefinedFilter.Fields("Auxiliar").Value = 1
    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub FwiCCIntereses_SetPredefinedFilter(ByVal rstPredefinedFilter As Recordset)
    '        On Error GoTo TratarError
    '        rstPredefinedFilter.Fields("IDEjercicio").Value = strEjerAct
    '        rstPredefinedFilter.Fields("Auxiliar").Value = 1
    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub FwiCCInteresesTotal_SetPredefinedFilter(ByVal rstPredefinedFilter As Recordset)
    '        On Error GoTo TratarError
    '        rstPredefinedFilter.Fields("IDEjercicio").Value = strEjerAct
    '        rstPredefinedFilter.Fields("Auxiliar").Value = 1
    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub FwiCCNominal_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles FwiCCNominal.Validated
    '        On Error GoTo TratarError
    '        CargarDescripcion()
    '        If FwiCCNominal.Text <> vbNullString Then
    '            blnUpdateCuenta = True
    '            DarAltaCuenta()
    '        End If
    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub FwiCCIntereses_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles FwiCCIntereses.Validated
    '        On Error GoTo TratarError
    '        CargarDescripcion()
    '        If FwiCCIntereses.Text <> vbNullString Then
    '            blnUpdateCuenta = True
    '            DarAltaCuenta()
    '        End If

    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub FwiCCInteresesTotal_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles FwiCCInteresesTotal.Validated
    '        On Error GoTo TratarError
    '        CargarDescripcion()
    '        If FwiCCInteresesTotal.Text <> vbNullString Then
    '            blnUpdateCuenta = True
    '            DarAltaCuenta()
    '        End If

    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub DarAltaCuenta()
    '        Dim objPlanCont As New AltaPlanContable
    '        Dim strCContable As String
    '        Dim strCadena As String
    '        On Error GoTo TratarError

    '        If blnUpdateCuenta Then
    '            If FwICCCortoPlazo.Text <> vbNullString Then
    '                strCadena = strCadena & "CContable=" & FwICCCortoPlazo.Text & ";"
    '            End If
    '            If FwICCLargoPlazo.Text <> vbNullString Then
    '                strCadena = strCadena & "CContable=" & FwICCLargoPlazo.Text & ";"
    '            End If
    '            If FwiCCNominal.Text <> vbNullString Then
    '                strCadena = strCadena & "CContable=" & FwiCCNominal.Text & ";"
    '            End If
    '            If FwiCCIntereses.Text <> vbNullString Then
    '                strCadena = strCadena & "CContable=" & FwiCCIntereses.Text & ";"
    '            End If
    '            If FwiCCInteresesTotal.Text <> vbNullString Then
    '                strCadena = strCadena & "CContable=" & FwiCCInteresesTotal.Text & ";"
    '            End If
    '            Do While strCadena <> vbNullString
    '                strCContable = GetPropertyValue(strCadena, "CContable")
    '                strCadena = Mid(strCadena, InStr(strCadena, ";") + 1)
    '                'objPlanCont = CreateObject("FwPlanCont.AltaPlanContable")
    '                If objPlanCont.AltaCContableEnEjercicios(strEjerAct, strCContable) = False Then
    '                    If strCContable = FwICCCortoPlazo.Text Then
    '                        FwICCCortoPlazo.Text = String.Empty
    '                    ElseIf strCContable = FwICCLargoPlazo.Text Then
    '                        FwICCLargoPlazo.Text = String.Empty
    '                    ElseIf strCContable = FwiCCNominal.Text Then
    '                        FwiCCNominal.Text = String.Empty
    '                    ElseIf strCContable = FwiCCIntereses.Text Then
    '                        FwiCCIntereses.Text = String.Empty
    '                    ElseIf strCContable = FwiCCInteresesTotal.Text Then
    '                        FwiCCInteresesTotal.Text = String.Empty
    '                    End If
    '                End If
    '                objPlanCont = Nothing
    '            Loop
    '            blnUpdateCuenta = False
    '        End If

    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '        Resume
    '    End Sub

    '    'CRF    Protected Overrides Sub OnFilterClearing(ByVal e As System.EventArgs)
    '    '        MyBase.OnFilterClearing(e)
    '    '        On Error GoTo TratarError

    '    '        fwiVtoDesde.Value = System.DBNull.Value
    '    '        fwiVtoHasta.Value = System.DBNull.Value
    '    '        fwiEstado.Text = String.Empty
    '    '        fwiFiltroContabilizado.Value = enumBoolean.Todos
    '    '        fwiSituacion.Value = enumPagoSituacion.NoPagado
    '    'Fin:
    '    '        On Error Resume Next
    '    '        Exit Sub
    '    'TratarError:
    '    '        GenerateError(Err)
    '    '        Resume Fin
    '    '    End Sub

    '    Private Sub fwiVtoDesde_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiVtoDesde.Validated
    '        On Error GoTo TratarError
    '        fwiVtoHasta.Value = fwiVtoDesde.Value
    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub fwiFiltroContabilizado_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiFiltroContabilizado.Validated
    '        On Error GoTo TratarError
    '        If fwiFiltroContabilizado.Value = enumBoolean.Todos Then
    '            fwiEstado.Text = String.Empty
    '        ElseIf fwiFiltroContabilizado.Value & vbNullString = vbNullString Then
    '            fwiEstado.Text = String.Empty
    '            fwiFiltroContabilizado.Value = enumBoolean.Todos
    '        Else
    '            fwiEstado.Text = fwiFiltroContabilizado.Value
    '        End If
    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub jngPago_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles jngPago.KeyDown
    '        On Error GoTo TratarError

    '        With jngPago
    '            If (e.KeyCode = Keys.Tab And e.Shift = 0) Or e.KeyCode = Keys.Return Then
    '                Select Case .Col
    '                    Case .Columns("ImpCuota").Position
    '                        .Row = .Row + 1
    '                        '                    .Col = .Columns("ImpRecuperacionCoste").Position
    '                        .Col = .Columns("FechaVencimiento").Position
    '                End Select
    '            End If
    '            If e.KeyCode = Keys.F9 Then
    '                .Row = .Row + 1
    '                .Col = .Columns("ImpRecuperacionCoste").Position
    '                '.EnsureVisible .Row + 1, .Columns("ImpRecuperacionCoste").Position
    '            End If
    '        End With

    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub CargarTotales()
    '        Dim fwnApp As BE.DataEngine
    '        Dim rcsApp As Recordset
    '        On Error GoTo TratarError

    '        'Función que carga, a partir de vistas los labeles que están al lado de los importes
    '        If Not Me.CurrentData.Rows(0) Is Nothing Then
    '            If Not Me.CurrentData.Rows.Count Then
    '                fwnApp = New BE.DataEngine
    '                rcsApp = fwnApp.Filter("vFrmMntoPagoPeriodicoTotales", "*", "ID=" & FwiID.Text)
    '                If Not rcsApp.EOF Then
    '                    FwiRecuperacionCoste.Value = rcsApp.Fields("ImpRecuperacionCoste").Value
    '                    FwiIntereses.Value = rcsApp.Fields("ImpIntereses").Value
    '                    FwiIVA.Value = rcsApp.Fields("ImpIVA").Value

    '                    Dim oFilter As New Filter
    '                    oFilter.Add("ID", FilterOperator.Equal, FwiID.Text)
    '                    oFilter.Add("FechaVencimiento", FilterOperator.GreaterThanOrEqual, Date.Today)
    '                    rcsApp = fwnApp.Filter("vFrmMntoPagoPeriodicoImpCorto", oFilter, "TOP 12 ImpCuota")

    '                    'rcsApp = fwnApp.Filter("vFrmMntoPagoPeriodicoImpCorto", "TOP 12 ImpCuota", "ID=" & FwiID.Text & " AND FechaVencimiento>=" & Date.Today)
    '                    'El recordset viene ordenado por fecha
    '                    FwiCorto.Value = 0
    '                    Do While Not rcsApp.EOF
    '                        FwiCorto.Value = FwiCorto.Value + rcsApp.Fields("ImpCuota").Value
    '                        rcsApp.MoveNext()
    '                    Loop
    '                Else
    '                    FwiRecuperacionCoste.Value = 0
    '                    FwiIntereses.Value = 0
    '                    FwiIVA.Value = 0
    '                    FwiCorto.Value = 0
    '                End If
    '            End If
    '        End If
    'Fin:
    '        On Error Resume Next
    '        rcsApp = Nothing
    '        fwnApp = Nothing
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub CargarAnticipadoDiferido()
    '        Dim fwnPagoPer As PagoPeriodicoImpuesto
    '        On Error GoTo TratarError

    '        If FwiNoCalcular.Text Then Exit Sub
    '        If Not Me.CurrentData.Rows(0) Is Nothing Then
    '            If Not Me.CurrentData.Rows.Count Then
    '                Me.Cursor = Cursors.WaitCursor
    '                fwnPagoPer = New PagoPeriodicoImpuesto
    '                jngAnticipadoDiferido.HoldFields()
    '                jngAnticipadoDiferido.DataSource = fwnPagoPer.CargarAnticipadoDiferido(FwiID.Text)
    '                jngAnticipadoDiferido.Refresh()
    '                SumarTotalDiferidoAnticipado()
    '                fwnPagoPer = Nothing
    '                Me.Cursor = Cursors.Default
    '                mblnInicio = False
    '            End If
    '        End If
    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '        Resume
    '    End Sub

    '    Private Sub TotalesInmovilizado()
    '        Dim dblAcumTotal As Double
    '        Dim dblAcumAmort As Double
    '        Dim dblAcumNeto As Double
    '        Dim rcsElementos As Recordset
    '        On Error GoTo TratarError

    '        If Not jngElementos.DataSource Is Nothing Then
    '            rcsElementos = jngElementos.DataSource.Clone
    '            If rcsElementos.RecordCount > 0 Then
    '                Do Until rcsElementos.EOF
    '                    dblAcumTotal = dblAcumTotal + Nz(rcsElementos.Fields("ValorTotalElementoA").Value)
    '                    dblAcumAmort = dblAcumAmort + Nz(rcsElementos.Fields("ValorAmortizadoElementoA").Value)
    '                    dblAcumNeto = dblAcumNeto + Nz(rcsElementos.Fields("ValorNetoContableElementoA").Value)
    '                    rcsElementos.MoveNext()
    '                Loop
    '            End If
    '        End If
    '        fwiTotalValorTotalElemA.Value = dblAcumTotal
    '        fwiTotalValorAmortElemA.Value = dblAcumAmort
    '        fwiValorNetoContElemA.Value = dblAcumNeto
    'Fin:
    '        On Error Resume Next
    '        rcsElementos = Nothing
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub TotalesPagos()
    '        Dim dblRecuperacionCoste As Double
    '        Dim dblImpCuota As Double
    '        Dim dblIntereses As Double
    '        Dim dblImpVencimientoA As Double
    '        Dim rsPagos As Recordset
    '        On Error GoTo TratarError

    '        If Not jngPago.DataSource Is Nothing Then
    '            rsPagos = jngPago.DataSource.Clone
    '            If rsPagos.RecordCount > 0 Then
    '                Do While Not rsPagos.EOF
    '                    dblRecuperacionCoste = dblRecuperacionCoste + Nz(rsPagos.Fields("ImpRecuperacionCoste").Value)
    '                    dblImpCuota = dblImpCuota + Nz(rsPagos.Fields("ImpCuota").Value)
    '                    dblIntereses = dblIntereses + Nz(rsPagos.Fields("ImpIntereses").Value)
    '                    dblImpVencimientoA = dblImpVencimientoA + Nz(rsPagos.Fields("ImpVencimientoA").Value)
    '                    rsPagos.MoveNext()
    '                Loop
    '            End If
    '        End If
    '        FwiRecuperacionCostePago.Value = dblRecuperacionCoste
    '        FwiInteresesPago.Value = dblIntereses
    '        FwiCuotaPago.Value = dblImpCuota
    '        FwiImporteVtoPago.Value = dblImpVencimientoA

    'Fin:
    '        On Error Resume Next
    '        rsPagos = Nothing
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub RefreshElementosInmovilizado()
    '        Dim oFilter As New Filter
    '        On Error GoTo TratarError
    '        If Len(FwiIDInmovilizado.Text) > 0 Then
    '            'jngElementos.Filter = "IDInmovilizado='" & FwiIDInmovilizado.Text & "'"
    '            oFilter.Add("IDInmovilizado", FilterOperator.Equal, FwiIDInmovilizado.Text)
    '        Else
    '            'jngElementos.Filter = "1=2"
    '            oFilter.Add("1", FilterOperator.Equal, 2)
    '        End If
    '        jngElementos.Filter = oFilter
    '        jngElementos.Refresh()
    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub SumarTotalDiferidoAnticipado()
    '        Dim rs As Recordset
    '        Dim dblGastoContable As Double
    '        Dim dblGastoFiscalTeorico As Double
    '        Dim dblLimiteAmortizacion As Double
    '        Dim dblGastoFiscal As Double
    '        Dim dblImpuesto As Double
    '        Dim fwnApp As New BE.DataEngine

    '        On Error GoTo TratarError

    '        If Len(FwiID.Text) > 0 Then
    '            With jngAnticipadoDiferido
    '                rs = fwnApp.Filter("vNegCargarAnticipadoDiferidoAcumulado", "*", "IDPAgoPeriodico=" & FwiID.Text)
    '                If rs.RecordCount > 0 Then
    '                    rs.MoveFirst()
    '                    FwiGastoContable.Value = rs.Fields("AcumGAstoContable").Value
    '                    FwiGastoFiscalTeorico.Value = rs.Fields("AcumGastoFiscalTeorico").Value
    '                    FwLimiteAmortizacion.Value = rs.Fields("AcumLimiteAmortizacion").Value
    '                    FwiGastoFiscal.Value = rs.Fields("AcumGastoFiscal").Value
    '                    FwiImpuesto.Value = rs.Fields("AcumImpuesto").Value
    '                Else
    '                    FwiGastoContable.Value = 0
    '                    FwiGastoFiscalTeorico.Value = 0
    '                    FwLimiteAmortizacion.Value = 0
    '                    FwiGastoFiscal.Value = 0
    '                    FwiImpuesto.Value = 0
    '                End If
    '            End With
    '        End If

    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '        Resume
    '    End Sub

    '    Private Sub TspLineas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabLineas.Click
    '        Dim blnRefresh As Boolean
    '        On Error GoTo TratarError

    '        ActivaDesactivaPicture(TabPagePicPeriocidad, False)
    '        ActivaDesactivaPicture(TabPagePicPago, False)
    '        ActivaDesactivaPicture(TabPagePicInmovilizado, False)
    '        ActivaDesactivaPicture(TabPagePicAnticipadoDiferido, False)
    '        ActivaDesactivaPicture(TabPagePicTotales, False)

    '        If Len(FwiID.Text) > 0 Then blnRefresh = True

    '        ActivaDesactivaFiltros()

    '        'Select Case TspLineas.SelectedTab.Key
    '        '    Case "Periodicidad"
    '        '        ActivaDesactivaPicture(TabPagePicPeriocidad, True)
    '        '        CargarDescripcion()
    '        '    Case "Pago"
    '        '        ActivaDesactivaPicture(TabPagePicPago, True)
    '        '        If blnRefresh Then
    '        '            jngPago.Refresh()
    '        '            jngPago.Col = jngPago.Columns("ImpRecuperacionCoste").Position
    '        '            jngPago.Focus()
    '        '            TotalesPagos()
    '        '        End If
    '        '    Case "Inmovilizado"
    '        '        ActivaDesactivaPicture(TabPagePicInmovilizado, True)
    '        '        If blnRefresh Then
    '        '            RefreshElementosInmovilizado()
    '        '            TotalesInmovilizado()
    '        '        End If
    '        '    Case "AnticipadoDiferido"
    '        '        ActivaDesactivaPicture(TabPagePicAnticipadoDiferido, True)
    '        '        '  If blnRefresh And mblnInicio Then CargarAnticipadoDiferido
    '        '        SumarTotalDiferidoAnticipado()
    '        '        jngAnticipadoDiferido.Refresh()
    '        '    Case "Totales"
    '        '        ActivaDesactivaPicture(TabPagePicTotales, True)
    '        '        If blnRefresh Then
    '        '            CargarDescripcion()
    '        '            CargarTotales()
    '        '        End If
    '        'End Select

    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '        Resume
    '    End Sub

    '    Private Sub ActivaDesactivaPicture(ByVal objPic As Object, ByVal blnVisible As Boolean)
    '        objPic.Visible = blnVisible
    '        'objPic.Enabled = blnVisible
    '        'If blnVisible Then objPic.ZOrder(0)
    '    End Sub

    '    '    Private Sub mObjMntoDoc_OnAdd()
    '    '        On Error GoTo TratarError
    '    '        TspLineas.TabIndex = 0
    '    'Fin:
    '    '        On Error Resume Next
    '    '        Exit Sub
    '    'TratarError:
    '    '        GenerateError(Err)
    '    '        Resume Fin
    '    '    End Sub

    '    Public Sub FwEngine1_Navigated(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.NavigatedEventArgs) Handles MyBase.Navigated
    '        On Error GoTo TratarError

    '        If Not Me.CurrentData.Rows(0) Is Nothing Then

    '            mblnInicio = True
    '            '            mblnCambioRegistro = True
    '            'TspLineas_Click(TspLineas, New EventArgs)
    '            ActualizarDescripcionFactorIVA()
    '            FwiIdMoneda_Validated(FwiIdMoneda, New EventArgs)
    '            FwiIDTipoIVA_Validated(FwiIDTipoIVA, New EventArgs)
    '            mblnCambioRegistro = False
    '        End If


    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub FwEngine1_Navigating(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.NavigatingEventArgs) Handles MyBase.Navigating
    '        mblnCambioRegistro = True
    '    End Sub

    '    Private Sub AccionContConcesion()
    '        Dim fwnApp As BE.DataEngine
    '        Dim blnOK As Boolean
    '        Dim lngIDFactura As Long
    '        Dim strFacturas As String
    '        Dim strNFactura As String
    '        Dim rs As Recordset
    '        Dim dsPropuesta As DataSet
    '        Dim fwnFCC As FacturaCompraCabecera
    '        Dim frm As FrmPagoLeasing
    '        Dim fwnEjercicio As EjercicioContable
    '        Dim strParametros As String
    '        Dim frmContador As frmContadorFC
    '        Dim HT As New Hashtable
    '        On Error GoTo TratarError

    '        If Not Me.CurrentData.Rows(0) Is Nothing Then
    '            If Not Me.CurrentData.Rows.Count Then
    '                If Not Nz(fwiContabilizado.Text) Then
    '                    rs = New Recordset
    '                    rs.Fields.Append("IdPagoPer", DataTypeEnum.adInteger)
    '                    rs.Fields.Append("IdProveedor", DataTypeEnum.adVarChar, 10)
    '                    rs.Open()
    '                    rs.AddNew()
    '                    rs.Fields("IDPagoPer").Value = FwiID.Text
    '                    rs.Fields("IDProveedor").Value = FwiIDProveedor.Text
    '                    rs.Update()
    '                    frmContador = New frmContadorFC
    '                    frmContador.ShowDialog()
    '                    If Len(frmContador.strIDContador & vbNullString) > 0 Then
    '                        Me.Cursor = Cursors.WaitCursor
    '                        fwnFCC = New FacturaCompraCabecera
    '                        dsPropuesta = fwnFCC.PropuestaFacturaCompraConcesion(rs, frmContador.strIDContador)
    '                        Me.Cursor = Cursors.Default

    '                        frm = New FrmPagoLeasing
    '                        blnOK = frm.MainFunction(dsPropuesta.Tables(0))
    '                        frm = Nothing
    '                        If blnOK Then
    '                            If MsgBox(6254, vbInformation Or vbYesNo Or vbDefaultButton1, ExpertisApp.Title) = vbYes Then
    '                                Dim dtFacturas As DataTable
    '                                If Not dsPropuesta Is Nothing Then
    '                                    dtFacturas = fwnFCC.CrearFacturaCompra(dsPropuesta)
    '                                    If Not IsNothing(dtFacturas) AndAlso dtFacturas.Rows.Count > 0 Then

    '                                        For Each dr As DataRow In dtFacturas.Rows
    '                                            If Len(strFacturas) > 0 Then strFacturas = strFacturas & ","
    '                                            strFacturas = strFacturas & dr("NFactura")
    '                                        Next
    '                                    End If
    '                                    Me.Cursor = Cursors.Default
    '                                End If
    '                                If Len(strFacturas) > 0 Then
    '                                    lngIDFactura = GetPropertyValue(strFacturas, "IDFactura")
    '                                    strNFactura = GetPropertyValue(strFacturas, "NFactura")
    '                                    'MsgBox(12203, vbInformation, ExpertisApp.Title, strNFactura) 'Se ha generado la factura |.
    '                                    MsgBox(12203, vbInformation, ExpertisApp.Title) 'Se ha generado la factura |.
    '                                    'Comienzo de la contabilización
    '                                    'CRF                                    fwnApp = New BE.DataEngine
    '                                    'CRF                                    fwnApp.MarcarRegistroNum(EmbeddedControl.Name, FwiID.Text & "@", vbNullString, ExpertisApp.ComputerName)
    '                                    fwnEjercicio = New EjercicioContable
    '                                    HT.Add("IdProceso", enumTipoContabilizacion.tcPagoConcesion)
    '                                    HT.Add("ProgramIDParent", Me.Name)
    '                                    HT.Add("IDEjercicio", fwnEjercicio.Predeterminado(Date.Today))
    '                                    HT.Add("IDFactura", lngIDFactura)
    '                                    HT.Add("NFactura", strNFactura)
    '                                    fwnEjercicio = Nothing

    '                                    ExpertisApp.OpenForm("CISIMUContPagoPer", , HT, Me)
    '                                    'CRF                                    ExpertisApp.OpenForm("FwSimulacionCont.CISimulacionCont", "CISIMUContPagoPer", , strParametros, "Simulación Contable - PAGOS PERIODICOS-", "MntoPagoPer")
    '                                    'CRF                                    fwnApp.DesmarcarTodosRegistrosNum(EmbeddedControl.Name, ExpertisApp.ComputerName)
    '                                    fwnApp = Nothing
    '                                    'Variable que se utiliza para refrescar la cabecera en el onActivate
    '                                    '                                mblnContabilizar = True
    '                                End If
    '                            Else
    '                                MsgBox(6251, vbInformation, ExpertisApp.Title) 'Proceso cancelado
    '                            End If
    '                        End If
    '                        fwnFCC = Nothing
    '                    End If
    '                    frmContador = Nothing
    '                Else
    '                    MsgBox(12229, vbCritical, ExpertisApp.Title) 'El pago periodico esta contabilizado. No se realizará la acción
    '                End If
    '            End If
    '        End If
    'Fin:
    '        On Error Resume Next
    '        Me.Cursor = Cursors.Default
    '        rs = Nothing
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '        Resume
    '    End Sub

    '    Private Sub ActivaDesactivaAcciones()
    '        'CRF        'Dim tbButton As Button
    '        'Dim tbButtonMenu As ButtonMenu
    '        'Dim i As Long
    '        'On Error GoTo TratarError

    '        'tbButton = ExpertisApp.Toolbar.GetButton("eleExecuteProcess")

    '        'For i = 1 To mlngActionsCount
    '        '    On Error Resume Next
    '        '    tbButtonMenu = tbButton.ButtonMenus.Item(i)
    '        '    If Not tbButtonMenu Is Nothing Then
    '        '        '//Activación-Desactivación de las acciones relacioneadas con la Obra.
    '        '        If tbButtonMenu.Tag = enumAccion.ContConcesion Then
    '        '            If fwiContabilizado = True Then
    '        '                tbButtonMenu.Enabled = False
    '        '            Else
    '        '                tbButtonMenu.Enabled = True
    '        '            End If
    '        '        End If
    '        '        '//
    '        '    End If
    '        'Next i

    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '        Resume
    '    End Sub

    '    Private Sub mobjEmbeddedControl_ProcessToolBarEvents(ByVal intCmdTag As Integer, ByVal intToolBarEvent As Integer, ByVal lngButtonIndex As Long)
    '        On Error GoTo TratarError
    '        ActivaDesactivaAcciones()
    '        Select Case intCmdTag
    '            'Case enumAccion.ContConcesion
    '            '    AccionContConcesion()
    '            '    '''        Case enumAccion.ContProxPago
    '            '    '''            AccionConProxPago
    '            'Case enumAccion.GenPagos
    '            '    AccionGenPagos()
    '            'Case enumAccion.RecalcularAnticipadoDiferido
    '            '    CargarAnticipadoDiferido()
    '        End Select
    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub AccionGenPagos()
    '        Dim rsSimulacion As Recordset
    '        Dim fwnPago As Pago
    '        Dim frmFecha As New frmFechaPago

    '        If frmFecha.ShowDialog = DialogResult.OK Then
    '            'Lanzar proceso
    '            If Not Me.CurrentData.Rows(0) Is Nothing Then
    '                If Not Me.CurrentData.Rows.Count Then
    '                    '''''''''       Se generarán Pagos de forma Masiva a partir de las líneas seleccionadas. ¿Desea continuar?.
    '                    If MsgBox(8837, vbInformation + vbYesNo, ExpertisApp.Title) = vbYes Then
    '                        Me.Cursor = Cursors.WaitCursor
    '                        fwnPago = New Pago
    '                        'CRF                        rsSimulacion = fwnPago.InsertPagoPeriodico(Me.CurrentData.Rows(0), frmFecha.dtFecha, False)
    '                        'Hay que refrescar los datos de la cabecera
    '                        'CRF                        FwEngine1.RefreshPrimary()
    '                        Me.Cursor = Cursors.Default
    '                    Else
    '                        MsgBox(6251, vbInformation, ExpertisApp.Title)  'Proceso cancelado
    '                    End If
    '                Else
    '                    MsgBox(1079, vbCritical, ExpertisApp.Title) 'Error leyendo datos.
    '                End If
    '            Else
    '                MsgBox(1079, vbCritical, ExpertisApp.Title) 'Error leyendo datos.
    '            End If
    '            '    Else
    '            '        msgbox 8836, vbCritical, ExpertisApp.Title  'Falta por informar la Fecha Final
    '        End If
    '    End Sub


    '    ' Migration Private Sub ConsultaInteractiva()
    '    ' Migration Dim strFiltro As String                           'cadena de criterios del filtro
    '    ' Migration Dim FwCriterio As clsFilterCriteria
    '    ' Migration On Error GoTo TratarError
    '    ' Migration 
    '    ' Migration FwCriterio = New clsFilterCriteria
    '    ' Migration With FwCriterio
    '    ' Migration .WhereFormat = wfSQLServer
    '    ' Migration .ClearFilterCriterias
    '    ' Migration .AddFilterItem "FechaVencimiento", dtDateTime, opGreaterThanOrEqual, fwiVtoDesde.Value
    '    ' Migration .AddFilterItem "FechaVencimiento", dtDateTime, opLessThanOrEqual, fwiVtoHasta.Value
    '    ' Migration .AddFilterItem "Situacion", dtNumeric, opEqual, fwiSituacion.Value
    '    ' Migration .AddFilterItem "Contabilizado", dtNumeric, opEqual, fwiEstado.Value
    '    ' Migration strFiltro = .GenerateFilterCriterias
    '    ' Migration '        .FechaMayorIgual fwiVtoDesde.Value, "FechaVencimiento", strFiltro, intCuentaArg
    '    ' Migration '        .FechaMenorIgual fwiVtoHasta.Value, "FechaVencimiento", strFiltro, intCuentaArg
    '    ' Migration '        .NumericoIgual fwiSituacion.Value, "Situacion", strFiltro, intCuentaArg
    '    ' Migration '        .NumericoIgual fwiEstado.Value, "Contabilizado", strFiltro, intCuentaArg
    '    ' Migration End With
    '    ' Migration 
    '    ' Migration jngPago.Filter = strFiltro
    '    ' Migration jngPago.Refresh
    '    ' Migration 
    '    ' Migration Fin:
    '    ' Migration On Error Resume Next
    '    ' Migration FwCriterio = Nothing
    '    ' Migration Exit Sub
    '    ' Migration TratarError:
    '    ' Migration GenerateError(err)
    '    ' Migration Resume Fin
    '    ' Migration Resume
    '    ' Migration End Sub

    '    Private Sub FwiRecCostePeriodo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FwiRecCostePeriodo.TextChanged
    '        On Error GoTo TratarError
    '        If Me.RecordsState <> RecordsState.Saved And Not mblnCambioRegistro Then
    '            ActualizarImporteConIVA()
    '            FwICuotaPeriodo.Value = Nz(FwiRecCostePeriodo.Value) + Nz(FwiInteresPeriodo.Value)
    '        End If
    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub FwICuotaPeriodo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FwICuotaPeriodo.TextChanged
    '        On Error GoTo TratarError
    '        If Me.RecordsState <> RecordsState.Saved And Not mblnCambioRegistro Then
    '            ActualizarImporteConIVA()
    '        End If
    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub ActivaDesactivaFiltros()
    '        Dim blnVisible As Boolean
    '        'On Error GoTo TratarError
    '        On Error Resume Next
    '        'blnVisible = IIf(TspLineas.SelectedTab.Key = "Pago", True, False)

    '        With ToolBar
    '            .Commands("eleFilter").Visible = blnVisible
    '            .Commands("eleClearFilter").Visible = blnVisible
    '        End With

    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '        Resume
    '    End Sub

    '    Private Sub Me_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
    '        On Error GoTo TratarError

    '        '    If mblnContabilizar Then
    '        '        mblnContabilizar = False
    '        'CRF        FwEngine1.RefreshPrimary()
    '        'CRF        FwEngine1.RefreshComplementaries()
    '        '    End If
    '        ActivaDesactivaFiltros()

    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '        Resume
    '    End Sub

    '    Private Sub jngPago_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles jngPago.EditingCell
    '        On Error GoTo TratarError

    '        With jngPago
    '            If .Value(.Columns("Contabilizado").Index) Then
    '                .Columns(e.Column.Index).EditType = Janus.Windows.GridEX.EditType.NoEdit
    '                .Columns(e.Column.Index).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
    '            Else
    '                Select Case e.Column.Index
    '                    Case .Columns("ImpCuota").Index
    '                        If Not FwICuotaFija.Text And Not FwIRecuperacionFija.Text Then
    '                            .Columns(e.Column.Index).EditType = Janus.Windows.GridEX.EditType.TextBox
    '                            .Columns(e.Column.Index).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
    '                        Else
    '                            .Columns(e.Column.Index).EditType = Janus.Windows.GridEX.EditType.NoEdit
    '                            .Columns(e.Column.Index).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
    '                        End If
    '                    Case .Columns("ImpRecuperacionCoste").Index
    '                        If FwICuotaFija.Text Or (Not FwICuotaFija.Text And Not FwIRecuperacionFija.Text) Then
    '                            .Columns(e.Column.Index).EditType = Janus.Windows.GridEX.EditType.TextBox
    '                            .Columns(e.Column.Index).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
    '                        Else
    '                            .Columns(e.Column.Index).EditType = Janus.Windows.GridEX.EditType.NoEdit
    '                            .Columns(e.Column.Index).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
    '                        End If
    '                    Case .Columns("ImpIntereses").Index
    '                        If FwIRecuperacionFija.Text Or (Not FwICuotaFija.Text And Not FwIRecuperacionFija.Text) Then
    '                            .Columns(e.Column.Index).EditType = Janus.Windows.GridEX.EditType.TextBox
    '                            .Columns(e.Column.Index).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
    '                        Else
    '                            .Columns(e.Column.Index).EditType = Janus.Windows.GridEX.EditType.NoEdit
    '                            .Columns(e.Column.Index).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
    '                        End If
    '                    Case .Columns("FechaVencimiento").Index
    '                        .Columns(e.Column.Index).EditType = Janus.Windows.GridEX.EditType.DropDownList
    '                    Case Else
    '                        .Columns(e.Column.Index).EditType = Janus.Windows.GridEX.EditType.NoEdit
    '                End Select
    '            End If
    '        End With

    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '        Resume
    '    End Sub

    '    Private Sub jngPago_CellUpdated(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles jngPago.CellUpdated
    '        On Error GoTo TratarError

    '        If Not mblnCalculandoRegistro Then
    '            With jngPago
    '                Select Case e.Column.Index
    '                    Case .Columns("ImpIntereses").Index   'No permite valor nulo
    '                        mblnCalculandoRegistro = True
    '                        'Comprobamos que no tenga cadena vacia y que el valor sea numerico
    '                        If .Value(e.Column.Index) & vbNullString = vbNullString Then
    '                            MsgBox(1353, vbCritical, ExpertisApp.Title)
    '                        ElseIf Not IsNumeric(.Value(e.Column.Index)) Then
    '                            MsgBox(1068, vbCritical, ExpertisApp.Title)
    '                        End If

    '                        'Actualizamos ImpInteresesA y ImpInteresesB y las bases imponibles
    '                        If Not .Value(.Columns("Contabilizado").Index) Then
    '                            .Value(.Columns("ImpInteresesA").Index) = xRound(Nz(.Value(e.Column.Index)) * mdblCambioA, mlngNDecimalesA)
    '                            .Value(.Columns("ImpInteresesB").Index) = xRound(Nz(.Value(e.Column.Index)) * mdblCambioB, mlngNDecimalesB)
    '                            If FwIRecuperacionFija.Text Or (Not FwICuotaFija.Text And Not FwIRecuperacionFija.Text) Then
    '                                .Value(.Columns("ImpCuota").Index) = .Value(.Columns("ImpIntereses").Index) + .Value(.Columns("ImpRecuperacionCoste").Index)
    '                                .Value(.Columns("ImpCuotaA").Index) = .Value(.Columns("ImpInteresesA").Index) + .Value(.Columns("ImpRecuperacionCosteA").Index)
    '                                .Value(.Columns("ImpCuotaB").Index) = .Value(.Columns("ImpInteresesB").Index) + .Value(.Columns("ImpRecuperacionCosteB").Index)
    '                            End If
    '                            .Value(e.Column.Index) = xRound(Nz(.Value(e.Column.Index)), mlngNDecimales)
    '                            If Not rcsTipoIva Is Nothing Then
    '                                If Not rcsTipoIva.EOF Then
    '                                    If rcsTipoIva.Fields("Factor").Value <> 0 Then
    '                                        .Value(.Columns("ImpVencimiento").Index) = xRound(.Value(.Columns("ImpCuota").Index) + .Value(.Columns("ImpCuota").Index) * rcsTipoIva.Fields("Factor").Value / 100, mlngNDecimales)
    '                                        .Value(.Columns("ImpVencimientoA").Index) = xRound(.Value(.Columns("ImpCuotaA").Index) + .Value(.Columns("ImpCuotaA").Index) * rcsTipoIva.Fields("Factor").Value / 100, mlngNDecimalesA)
    '                                        .Value(.Columns("ImpVencimientoB").Index) = xRound(.Value(.Columns("ImpCuotaB").Index) + .Value(.Columns("ImpCuotaB").Index) * rcsTipoIva.Fields("Factor").Value / 100, mlngNDecimalesB)
    '                                    End If
    '                                End If
    '                            End If
    '                        ElseIf Not mblnNoModif Then
    '                            'No se puede modificar porque ya esta contabilizado
    '                            mblnNoModif = True
    '                            MsgBox(1587, vbCritical, ExpertisApp.Title)
    '                            .Value(.Columns("ImpIntereses").Index) = .DataSource.Fields("ImpIntereses")
    '                            mblnNoModif = False
    '                        End If
    '                        mblnCalculandoRegistro = False

    '                    Case .Columns("ImpCuota").Index   'No permite valor nulo
    '                        mblnCalculandoRegistro = True
    '                        'Comprobamos que no tenga cadena vacia y que el valor sea numerico
    '                        If .Value(e.Column.Index) & vbNullString = vbNullString Then
    '                            MsgBox(1353, vbCritical, ExpertisApp.Title)
    '                        ElseIf Not IsNumeric(.Value(e.Column.Index)) Then
    '                            MsgBox(1068, vbCritical, ExpertisApp.Title)
    '                        End If

    '                        'Actualizamos ImpInteresesA y ImpInteresesB y las bases imponibles
    '                        If Not .Value(.Columns("Contabilizado").Index) Then
    '                            mblnImpModif = True
    '                            .Value(.Columns("ImpCuotaA").Index) = xRound(Nz(.Value(e.Column.Index)) * mdblCambioA, mlngNDecimalesA)
    '                            .Value(.Columns("ImpCuotaB").Index) = xRound(Nz(.Value(e.Column.Index)) * mdblCambioB, mlngNDecimalesB)
    '                            If Not FwICuotaFija.Text And Not FwIRecuperacionFija.Text Then
    '                                .Value(.Columns("ImpIntereses").Index) = .Value(.Columns("ImpCuota").Index) - .Value(.Columns("ImpRecuperacionCoste").Index)
    '                                .Value(.Columns("ImpInteresesA").Index) = .Value(.Columns("ImpCuotaA").Index) - .Value(.Columns("ImpRecuperacionCosteA").Index)
    '                                .Value(.Columns("ImpInteresesB").Index) = .Value(.Columns("ImpCuotaB").Index) - .Value(.Columns("ImpRecuperacionCosteB").Index)
    '                            End If
    '                            .Value(e.Column.Index) = xRound(Nz(.Value(e.Column.Index)), mlngNDecimales)
    '                            If Not rcsTipoIva Is Nothing Then
    '                                If Not rcsTipoIva.EOF Then
    '                                    If rcsTipoIva.Fields("Factor").Value <> 0 Then
    '                                        .Value(.Columns("ImpVencimiento").Index) = xRound(.Value(.Columns("ImpCuota").Index) + .Value(.Columns("ImpCuota").Index) * rcsTipoIva.Fields("Factor").Value / 100, mlngNDecimales)
    '                                        .Value(.Columns("ImpVencimientoA").Index) = xRound(.Value(.Columns("ImpCuotaA").Index) + .Value(.Columns("ImpCuotaA").Index) * rcsTipoIva.Fields("Factor").Value / 100, mlngNDecimalesA)
    '                                        .Value(.Columns("ImpVencimientoB").Index) = xRound(.Value(.Columns("ImpCuotaB").Index) + .Value(.Columns("ImpCuotaB").Index) * rcsTipoIva.Fields("Factor").Value / 100, mlngNDecimalesB)
    '                                    End If
    '                                End If
    '                            End If
    '                        ElseIf Not mblnNoModif Then
    '                            'No se puede modificar porque ya esta contabilizado
    '                            mblnNoModif = True
    '                            MsgBox(1587, vbCritical, ExpertisApp.Title)
    '                            .Value(.Columns("ImpIntereses").Index) = .DataSource.Fields("ImpIntereses")
    '                            mblnNoModif = False
    '                        End If
    '                        mblnCalculandoRegistro = False
    '                    Case .Columns("ImpRecuperacionCoste").Index   'No permite valor nulo
    '                        mblnCalculandoRegistro = True
    '                        'Comprobamos que no tenga cadena vacia y que el valor sea numerico
    '                        If .Value(e.Column.Index) & vbNullString = vbNullString Then
    '                            MsgBox(1353, vbCritical, ExpertisApp.Title)
    '                        ElseIf Not IsNumeric(.Value(e.Column.Index)) Then
    '                            MsgBox(1068, vbCritical, ExpertisApp.Title)
    '                        End If

    '                        'Actualizamos ImpInteresesA y ImpInteresesB y las bases imponibles
    '                        If Not .Value(.Columns("Contabilizado").Index) Then
    '                            mblnImpModif = True
    '                            .Value(.Columns("ImpRecuperacionCosteA").Index) = xRound(Nz(.Value(e.Column.Index)) * mdblCambioA, mlngNDecimalesA)
    '                            .Value(.Columns("ImpRecuperacionCosteB").Index) = xRound(Nz(.Value(e.Column.Index)) * mdblCambioB, mlngNDecimalesB)
    '                            If FwIRecuperacionFija.Text Or (Not FwIRecuperacionFija.Text And Not FwICuotaFija.Text) Then
    '                                .Value(.Columns("ImpCuota").Index) = .Value(.Columns("ImpIntereses").Index) + .Value(.Columns("ImpRecuperacionCoste").Index)
    '                                .Value(.Columns("ImpCuotaA").Index) = .Value(.Columns("ImpInteresesA").Index) + .Value(.Columns("ImpRecuperacionCosteA").Index)
    '                                .Value(.Columns("ImpCuotaB").Index) = .Value(.Columns("ImpInteresesB").Index) + .Value(.Columns("ImpRecuperacionCosteB").Index)
    '                            ElseIf FwICuotaFija.Text Then
    '                                .Value(.Columns("ImpIntereses").Index) = .Value(.Columns("ImpCuota").Index) - .Value(.Columns("ImpRecuperacionCoste").Index)
    '                                .Value(.Columns("ImpInteresesA").Index) = .Value(.Columns("ImpCuotaA").Index) - .Value(.Columns("ImpRecuperacionCosteA").Index)
    '                                .Value(.Columns("ImpInteresesB").Index) = .Value(.Columns("ImpCuotaB").Index) - .Value(.Columns("ImpRecuperacionCosteB").Index)
    '                            End If
    '                            .Value(e.Column.Index) = xRound(Nz(.Value(e.Column.Index)), mlngNDecimales)
    '                            If Not rcsTipoIva Is Nothing Then
    '                                If Not rcsTipoIva.EOF Then
    '                                    If rcsTipoIva.Fields("Factor").Value <> 0 Then
    '                                        .Value(.Columns("ImpVencimiento").Index) = xRound(.Value(.Columns("ImpCuota").Index) + .Value(.Columns("ImpRecuperacionCoste").Index) * rcsTipoIva.Fields("Factor").Value / 100, mlngNDecimales)
    '                                        .Value(.Columns("ImpVencimientoA").Index) = xRound(.Value(.Columns("ImpCuotaA").Index) + .Value(.Columns("ImpRecuperacionCosteA").Index) * rcsTipoIva.Fields("Factor").Value / 100, mlngNDecimalesA)
    '                                        .Value(.Columns("ImpVencimientoB").Index) = xRound(.Value(.Columns("ImpCuotaB").Index) + .Value(.Columns("ImpRecuperacionCosteB").Index) * rcsTipoIva.Fields("Factor").Value / 100, mlngNDecimalesB)
    '                                    End If
    '                                End If
    '                            End If
    '                        ElseIf Not mblnNoModif Then
    '                            'No se puede modificar porque ya esta contabilizado
    '                            mblnNoModif = True
    '                            MsgBox(1587, vbCritical, ExpertisApp.Title)
    '                            .Value(.Columns("ImpIntereses").Index) = .DataSource.Fields("ImpIntereses")
    '                            mblnNoModif = False
    '                        End If
    '                        mblnCalculandoRegistro = False
    '                End Select
    '            End With
    '        End If

    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '        Resume
    '    End Sub

    '    Private Sub jngPago_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles jngPago.FormattingRow
    '        On Error GoTo TratarError

    '        'CRF        'If RowBuffer.Value(jngPago.Columns("Contabilizado").Index) = 0 Then
    '        '    RowBuffer.RowStyle = "NoContabilizado"
    '        '    RowBuffer.IconIndex(jngPago.Columns("Contabilizado").Index) = 2
    '        'Else
    '        '    RowBuffer.RowStyle = "Contabilizado"
    '        '    RowBuffer.IconIndex(jngPago.Columns("Contabilizado").Index) = 1
    '        'End If

    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub FwICuotaFija_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FwICuotaFija.CheckedChanged
    '        If FwICuotaFija.Text And Not mblnCambioRegistro Then FwIRecuperacionFija.Text = False
    '    End Sub

    '    Private Sub FwIRecuperacionFija_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FwIRecuperacionFija.CheckedChanged
    '        If FwIRecuperacionFija.Text And Not mblnCambioRegistro Then FwICuotaFija.Text = False
    '    End Sub

    '    Private Sub FwiNoCalcular_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles FwiNoCalcular.Validated
    '        Dim fwnPagoPeriodicoImpuesto As New BE.DataEngine

    '        On Error GoTo TratarError
    '        If FwiNoCalcular.Text Then
    '            'CRF            fwnPagoPeriodicoImpuesto.Ejecutar("delete from tbPagoPeriodicoImpuesto where idPagoPeriodico=" & FwiID)
    '            fwnPagoPeriodicoImpuesto = Nothing
    '        End If

    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '        Resume
    '    End Sub

    '    Private Sub FwiInteresPeriodo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FwiInteresPeriodo.TextChanged
    '        On Error GoTo TratarError
    '        If Me.RecordsState <> RecordsState.Saved And Not mblnCambioRegistro Then
    '            ActualizarImporteConIVA()
    '            FwICuotaPeriodo.Value = Nz(FwiRecCostePeriodo.Value) + Nz(FwiInteresPeriodo.Value)
    '        End If
    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub FwiImpRecuperacionCoste_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FwiImpRecuperacionCoste.TextChanged
    '        On Error GoTo TratarError
    '        If Me.RecordsState <> RecordsState.Saved And Not mblnCambioRegistro Then
    '            ActualizarImporteTotalConIVA()
    '        End If
    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin

    '    End Sub

    '    Private Sub FwiImpInteresesTotal_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FwiImpInteresesTotal.TextChanged
    '        On Error GoTo TratarError
    '        If Me.RecordsState <> RecordsState.Saved And Not mblnCambioRegistro Then
    '            ActualizarImporteTotalConIVA()
    '        End If
    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub FwiIDTipoIVA_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles FwiIDTipoIVA.Validated
    '        Dim fwnTipoIva As TipoIva
    '        On Error GoTo TratarError

    '        If Len(FwiIDTipoIVA.Text) > 0 Then
    '            fwnTipoIva = New TipoIva
    '            rcsTipoIva = fwnTipoIva.SelOnPrimaryKey(FwiIDTipoIVA.Text)
    '            fwnTipoIva = Nothing
    '        End If

    '        If Me.RecordsState <> RecordsState.Saved And Not mblnCambioRegistro Then
    '            ActualizarImporteConIVA()
    '            ActualizarDescripcionFactorIVA()
    '        End If
    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub FwiIDProveedor_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles FwiIDProveedor.Validated
    '        Dim FwnProveedor As Proveedor
    '        Dim rcsProveedor As Recordset
    '        On Error GoTo TratarError

    '        FwnProveedor = New Proveedor
    '        rcsProveedor = FwnProveedor.SelOnPrimaryKey(FwiIDProveedor.Text)
    '        FwnProveedor = Nothing

    '        If Not rcsProveedor Is Nothing Then
    '            If Not rcsProveedor.EOF Then
    '                FwiIdFormaPago.Text = rcsProveedor.Fields("IdFormaPago").Value
    '                FwiIdBancoPropio.Text = rcsProveedor.Fields("IDBancoPropio").Value
    '                FwiIdMoneda.Text = rcsProveedor.Fields("IDMoneda").Value
    '                FwiIDTipoIVA.Text = rcsProveedor.Fields("IDTipoIVA").Value
    '            End If
    '            rcsProveedor = Nothing
    '        End If

    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '        Resume
    '    End Sub

    '    Private Sub FwiIdMoneda_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles FwiIdMoneda.Validated
    '        Dim FwnMoneda As New Moneda
    '        Dim rcsMoneda As Recordset
    '        Dim rcsMonedaA As Recordset
    '        Dim rcsMonedaB As Recordset
    '        On Error GoTo TratarError

    '        If Len(FwiIdMoneda.Text) > 0 Then
    '            rcsMoneda = FwnMoneda.SelOnPrimaryKey(FwiIdMoneda.Text)
    '            rcsMonedaA = FwnMoneda.ObtenerMonedaA()
    '            rcsMonedaB = FwnMoneda.ObtenerMonedaB()
    '            FwnMoneda = Nothing
    '            If Not rcsMoneda Is Nothing Then
    '                If rcsMoneda.RecordCount > 0 Then
    '                    mdblCambioA = rcsMoneda.Fields("CambioA").Value
    '                    mdblCambioB = rcsMoneda.Fields("CambioB").Value
    '                    mlngNDecimales = rcsMoneda.Fields("NDecimalesImp").Value
    '                End If
    '            End If
    '            If Not rcsMonedaA Is Nothing Then
    '                If rcsMonedaA.RecordCount > 0 Then mlngNDecimalesA = rcsMonedaA.Fields("NDecimalesImp").Value
    '            End If
    '            If Not rcsMonedaB Is Nothing Then
    '                If rcsMonedaB.RecordCount > 0 Then mlngNDecimalesB = rcsMonedaB.Fields("NDecimalesImp").Value
    '            End If
    '        End If

    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub FwiIDInmovilizado_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles FwiIDInmovilizado.Validated
    '        Dim FwnInmob As New Inmovilizado
    '        Dim rs As Recordset
    '        On Error GoTo TratarError

    '        If Len(FwiIDInmovilizado.Text) > 0 Then
    '            rs = FwnInmob.SelOnPrimaryKey(FwiIDInmovilizado.Text)
    '            FwnInmob = Nothing
    '            If Not rs Is Nothing Then
    '                If rs.RecordCount > 0 Then FwiFechaContrato.Text = rs.Fields("FechaInmovilizado").Value
    '            End If
    '        End If

    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub FwICCLargoPlazo_SetPredefinedFilter(ByVal rstPredefinedFilter As Recordset)
    '        On Error GoTo TratarError
    '        rstPredefinedFilter.Fields("IDEjercicio").Value = strEjerAct
    '        rstPredefinedFilter.Fields("Auxiliar").Value = 1
    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub FwICCLargoPlazo_LostFocus()
    '        On Error GoTo TratarError
    '        CargarDescripcion()

    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub FwICCLargoPlazo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles FwICCLargoPlazo.Validated
    '        On Error GoTo TratarError

    '        If FwICCLargoPlazo.Text <> vbNullString Then
    '            blnUpdateCuenta = True
    '            DarAltaCuenta()
    '        End If
    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub FwiCCIntereses_LostFocus()
    '        On Error GoTo TratarError
    '        CargarDescripcion()
    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub FwICCCortoPlazo_SetPredefinedFilter(ByVal rstPredefinedFilter As Recordset)
    '        On Error GoTo TratarError
    '        rstPredefinedFilter.Fields("IDEjercicio").Value = strEjerAct
    '        rstPredefinedFilter.Fields("Auxiliar").Value = 1
    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub FwICCCortoPlazo_LostFocus()
    '        On Error GoTo TratarError
    '        CargarDescripcion()
    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub FwICCCortoPlazo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles FwICCCortoPlazo.Validated
    '        On Error GoTo TratarError
    '        CargarDescripcion()
    '        If FwICCCortoPlazo.Text <> vbNullString Then
    '            blnUpdateCuenta = True
    '            DarAltaCuenta()
    '        End If
    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    'CRF    'Private Sub FwEngine1_Cancel(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Cancel
    '    '    blnUpdateCuenta = False
    '    'End Sub

    '    Private Sub FwEngine1_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.RecordUpdated
    '        On Error GoTo TratarError
    '        DarAltaCuenta()
    '        '    If mblnInmovilizadoHaCambiado Then
    '        '        RefreshElementosInmovilizado
    '        '    End If
    '        '    FwEngine1.RefreshPrimary
    'Fin:
    '        On Error Resume Next
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '        '**********mobjEmbeddedControl_OnOpen**********
    '        Dim i As Integer
    '        Dim strID As String
    '        On Error GoTo TratarError

    '        TabPagePicPeriocidad.Visible = True
    '        TabPagePicPago.Visible = False
    '        TabPagePicTotales.Visible = False
    '        TabPagePicInmovilizado.Visible = False

    '        'CRF        'i = NuevaAccionExecuteProcess("Contabilizar la concesión", enumAccion.ContConcesion, i)
    '        'i = NuevaAccionExecuteProcess("Generar Pagos", enumAccion.GenPagos, i)
    '        'i = NuevaAccionExecuteProcess("Recalcular Anticipado Diferido", enumAccion.RecalcularAnticipadoDiferido, i)

    '        fwiFiltroContabilizado.DataSource = New EnumData("enumBoolean")
    '        FwiUnidad.DataSource = New EnumData("enumcpPeriodo")

    '        'CRF        'If Len(strCriteria) > 0 Then
    '        '    strID = GetPropertyValue(strCriteria, "Id")
    '        '    If IsNumeric(strID) Then
    '        '        mobjMntoDoc.MntoDoc.GoToRecord(5, strID)
    '        '    End If
    '        'End If
    '        mblnInicio = True

    '        lblFactorIVA.Text = vbNullString


    '        '**********UserControl_InitProperties**********
    '        Dim strComboFields As String
    '        Dim fwnEjercicio As EjercicioContable
    '        Dim rcsEjercicio As Recordset


    '        strComboFields = "IDBaseDatos,;DescEmpresa,"
    '        fwnEjercicio = New EjercicioContable
    '        strEjerAct = fwnEjercicio.Predeterminado

    '        If strEjerAct <> vbNullString Then
    '            fwnEjercicio = New EjercicioContable
    '            rcsEjercicio = fwnEjercicio.SelOnPrimaryKey(strEjerAct)
    '            fwnEjercicio = Nothing
    '            If rcsEjercicio.RecordCount <> 0 Then
    '                intDigitosAuxiliar = rcsEjercicio.Fields("DigitosAuxiliar").Value
    '                If intDigitosAuxiliar <> 0 Then
    '                    FwiCCIntereses.MaxLength = intDigitosAuxiliar
    '                    FwICCCortoPlazo.MaxLength = intDigitosAuxiliar
    '                    FwiCCNominal.MaxLength = intDigitosAuxiliar
    '                    FwiCCInteresesTotal.MaxLength = intDigitosAuxiliar
    '                    FwICCLargoPlazo.MaxLength = intDigitosAuxiliar
    '                End If
    '            End If
    '            rcsEjercicio = Nothing
    '        End If
    'Fin:
    '        On Error Resume Next
    '        fwnEjercicio = Nothing
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin

    '    End Sub
    '    'CRF Private Sub MntoPagoPer_QueryExecuting(ByVal sender As Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
    '    '    '        .FechaMayorIgual fwiVtoDesde.Value, "FechaVencimiento", strFiltro, intCuentaArg
    '    '    '        .FechaMenorIgual fwiVtoHasta.Value, "FechaVencimiento", strFiltro, intCuentaArg
    '    '    '        .NumericoIgual fwiSituacion.Value, "Situacion", strFiltro, intCuentaArg
    '    '    '        .NumericoIgual fwiEstado.Value, "Contabilizado", strFiltro, intCuentaArg
    '    'End Sub
#End Region


#Region "Variables Privadas"

    Protected StrEjerAct As String
    Private IntDigitosAuxiliar As Integer
    Private MDblValorResiA, MDblValorResiB As Double
    Private MDblCambioA, MDblCambioB As Double
    Private MLngNDecimales, MLngNDecimalesA, MLngNDecimalesB As Long
    Private DtTipoIva As New DataTable
    Private MDblFactorIVA As Double

    Private mblnNoGenPagos As Boolean
    Private mblnStop As Boolean
    Protected mblnInicio As Boolean
    Private mblnCancelarCuota As Boolean
    Private mintAño As Integer

#End Region

#Region "Funciones / Procesos Privados"

#Region "Eventos Carga Formulario"

    Private cnCONTABILIZAR_CONTRATO_LEASING As String = "Contabilización Contrato Leasing"
    Private cnDESCONTABILIZAR_CONTRATO_LEASING As String = "Descontabilización Contrato Leasing"
    Private cnGENERAR_PAGOS As String = "Generar Pagos"
    Private cnRECALCULAR_ANTICIPADO_DIFERIDO As String = "Recalcular Anticipado Diferido"
    Private cnCAMBIOS_ACTUALIZACIONES As String = "Cambios Actualizaciones"

    Private Sub LoadFormActions()
        Me.FormActions.Add(cnCONTABILIZAR_CONTRATO_LEASING, AddressOf AccionContConcesion)
        Me.FormActions.Add(cnDESCONTABILIZAR_CONTRATO_LEASING, AddressOf AccionDescontConcesion)
        '   Me.FormActions.Add("Cálculo de Cuota", AddressOf AccionCalculoCuota)
        Me.FormActions.Add(cnGENERAR_PAGOS, AddressOf AccionComprobacionPagos)
        Me.FormActions.Add(cnRECALCULAR_ANTICIPADO_DIFERIDO, AddressOf AccionCargarAnticipadoDiferido)
        Me.FormActions.Add(cnCAMBIOS_ACTUALIZACIONES, AddressOf AccionCambioActua)
    End Sub

    Private Sub LoadEnums()
        CmbFilContabilizado.DataSource = EnumData.EnumView("enumBoolean")
        CmbUnidad.DataSource = EnumData.EnumView("enumcpPeriodo")
        CmbBaseCalculo.DataSource = EnumData.EnumView("enumpaBaseCalculoLeasing")
    End Sub

    Private Sub LoadDatos()
        Dim ClsTipoPago As New TipoPago
        Dim DtTipoPago As DataTable = ClsTipoPago.Filter(New BooleanFilterItem("LeasingSN", True))
        If Not DtTipoPago Is Nothing AndAlso DtTipoPago.Rows.Count > 0 Then
            Dim ListTipos As Object
            ReDim ListTipos(DtTipoPago.Rows.Count - 1)
            Dim i As Integer = 0
            For Each Dr As DataRow In DtTipoPago.Select
                ListTipos(i) = Dr("IDTipoPago")
                i += 1
            Next
            Dim FilForm As New Filter
            FilForm.Add(New InListFilterItem("IDTipoPago", ListTipos, FilterType.Numeric))
            Me.FilterCriteria = FilForm
        End If
        StrEjerAct = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, Today)
        If Length(StrEjerAct) > 0 Then
            Dim DtEjercicio As DataTable = New EjercicioContable().SelOnPrimaryKey(StrEjerAct)
            If DtEjercicio.Rows.Count > 0 Then
                IntDigitosAuxiliar = DtEjercicio.Rows(0)("DigitosAuxiliar")
                If IntDigitosAuxiliar <> 0 Then
                    'Alex 21/5/2008
                    'AdvInteresDiferido.MaxLength = IntDigitosAuxiliar
                    AdvDeudaLeasCorto.MaxLength = IntDigitosAuxiliar
                    AdvCosteBien.MaxLength = IntDigitosAuxiliar
                    AdvGastosporIntereses.MaxLength = IntDigitosAuxiliar
                    AdvDeudaLeasLargo.MaxLength = IntDigitosAuxiliar
                End If
            End If
        End If
        TabLineas.SelectedIndex = TbPeriodicidad.Index
    End Sub

    Private Sub ClearControls()
        NtbImpNetoFinanciar.Value = 0
        NtbTotalRecupCoste.Value = 0
        NtbTotalImpInteres.Value = 0
        NtbTotalImpIVA.Value = 0
        NtbTotalImpCorto.Value = 0
        NtbImpNetoFinanciar.Value = 0
        ClbFechaUltAct.Value = Nothing
        ClbFechaContrato.Value = Nothing
        ClbFechaUltRev.Value = Nothing
        ClbFechaUltRecal.Value = Nothing
        ClbFechaIniCont.Value = Nothing
        ClbFechaFin.Value = Nothing
    End Sub

#End Region

#Region "Procesos Acciones"

    Private Sub ComprobarAcciones()
        If Not Me.CurrentRow Is Nothing Then
            For Each ExecAction As Janus.Windows.UI.CommandBars.UICommand In Me.ExecuteActions.Commands
                If ExecAction.Text = cnCONTABILIZAR_CONTRATO_LEASING Then
                    If Me.CurrentRow("Contabilizado") = enumContabilizado.Contabilizado Then
                        ExecAction.Enabled = Janus.Windows.UI.InheritableBoolean.False
                    Else
                        ExecAction.Enabled = Janus.Windows.UI.InheritableBoolean.True
                    End If
                ElseIf ExecAction.Text = cnDESCONTABILIZAR_CONTRATO_LEASING Then
                    If Me.CurrentRow("Contabilizado") <> enumContabilizado.NoContabilizado Then
                        ExecAction.Enabled = Janus.Windows.UI.InheritableBoolean.True
                    Else
                        ExecAction.Enabled = Janus.Windows.UI.InheritableBoolean.False
                    End If
                ElseIf ExecAction.Text = "Cálculo de Cuota" OrElse ExecAction.Text = cnGENERAR_PAGOS Then
                    Dim ClsPagoPerAct As New PagoPerActualiz
                    Dim DtPagoPerAct As DataTable = ClsPagoPerAct.Filter(New FilterItem("IDPago", FilterOperator.Equal, Me.CurrentRow("ID"), FilterType.Numeric))
                    If Not DtPagoPerAct Is Nothing Then
                        If DtPagoPerAct.Rows.Count > 0 Then
                            ExecAction.Enabled = Janus.Windows.UI.InheritableBoolean.False
                        Else
                            ExecAction.Enabled = Janus.Windows.UI.InheritableBoolean.True
                        End If
                    Else
                        ExecAction.Enabled = Janus.Windows.UI.InheritableBoolean.True
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub ActDesactAccionCambio()
        If Me.ExecuteActions.Commands.Count <> 0 Then
            If TabLineas.SelectedIndex = TbActualizaciones.Index Then
                Dim ClsPago As New Pago
                Dim DtPago As DataTable = ClsPago.Filter(New FilterItem("IdPagoPeriodo", FilterOperator.Equal, Me.CurrentRow("ID"), FilterType.Numeric))
                If Not DtPago Is Nothing AndAlso DtPago.Rows.Count > 0 Then
                    For Each Dr As DataRow In DtPago.Select
                        If Dr("Contabilizado") <> enumContabilizado.NoContabilizado Then
                            Me.ExecuteActions.Commands(cnCAMBIOS_ACTUALIZACIONES).Visible = Janus.Windows.UI.InheritableBoolean.True
                            Exit Sub
                        End If
                    Next
                End If
                Me.ExecuteActions.Commands(cnCAMBIOS_ACTUALIZACIONES).Visible = Janus.Windows.UI.InheritableBoolean.False
            Else
                Me.ExecuteActions.Commands(cnCAMBIOS_ACTUALIZACIONES).Visible = Janus.Windows.UI.InheritableBoolean.False
            End If
        End If
    End Sub

    Dim mGProcess As Guid
    Private Sub AccionContConcesion()
        If Not Me.CurrentRow Is Nothing Then
            If Me.CurrentRow("Contabilizado") <> enumContabilizado.Contabilizado Then
                'Comienzo de la contabilización
                mGProcess = MarcarRegistro(CurrentRow("ID"), FilterType.Numeric)
                Dim SimInfo As New DataSimulacionContableInfo(enumTipoContabilizacion.tcPagoConcesion)
                SimInfo.FechaApunte = Nz(Me.CurrentRow("FechaInicio"), Today)
                SimInfo.IDEjercicio = CalcularEjercicioPagoPeriodico(SimInfo.FechaApunte)
                SimInfo.GuidSimulacion = mGProcess
                SimInfo.Caption = ExpertisApp.Traslate("Simulación Contable - CONCESION DE LEASING")
                Dim oFrm As Form = ExpertisApp.OpenForm("CISIMUCONT", , SimInfo)
                AddHandler oFrm.Closed, AddressOf FrmActionClosed
            Else
                ExpertisApp.GenerateMessage("El pago periódico está contabilizado. No se realizará la acción.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If
    End Sub

    Private Sub FrmActionClosed(ByVal sender As Object, ByVal e As System.EventArgs)
        RemoveHandler CType(sender, Form).Closed, AddressOf FrmActionClosed
        DesmarcarRegistro(mGProcess, FilterType.Numeric)
        Me.GotoRecord(DataProviderActions.All, New NumberFilterItem("ID", Me.CurrentRow("ID")))
    End Sub


    Private Sub AccionDescontConcesion()
        'Comprueba si tiene algún pago asociado contabilizado. En caso afirmativo no se puede descontabilizar
        Dim fwnPagoPer As New PagoPeriodico
        If Not fwnPagoPer.TienePagosContabilizados(CurrentRow("Id")) Then
            Dim frmDescontabilizar As New frmDescontPagoPer
            frmDescontabilizar.PagoPeriodico = CurrentRow("Id")
            frmDescontabilizar.IDEjercicio = CalcularEjercicioPagoPeriodico(Nz(Me.CurrentRow("FechaInicio"), Today))
            frmDescontabilizar.ShowDialog()
            Me.RecordsState = RecordsState.Saved
            'Me.RefreshData(DataProviderActions.All)
            Me.Requery.InvokeOnClick()
        Else : ExpertisApp.GenerateMessage("Hay pagos asociados contabilizados. Proceso cancelado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub AccionCalculoCuota()
        CalculoCuota(False)
    End Sub

    Private Sub CalculoCuota(ByVal Act As Boolean, Optional ByVal DtmFechaAct As Date = cnMinDate, Optional ByVal DblIntAplicado As Double = 0)
        Dim ClsPagoPerAct As New PagoPerActualiz
        Dim DtPagoPerAct As DataTable = ClsPagoPerAct.Filter(New FilterItem("IDPago", FilterOperator.Equal, Me.CurrentRow("ID"), FilterType.Numeric))
        If DtPagoPerAct Is Nothing OrElse DtPagoPerAct.Rows.Count = 0 Then
            'Recibe FALSE desde la llamada a la acción personalizada desde la ToolBar
            Dim ClsBPFF As New BancoPropioFormFinanc
            Dim ClsPago As New Pago
            Dim ClsMoneda As New Moneda
            Dim ClsBE As New BE.DataEngine
            Dim DtBPFF, DtPagos, Dt, DtMonedaA, DtPago, DtBE As DataTable
            Dim DblBienTotal, DblPagos, DblNumCuotas, DblNumCuotasCarencia As Double
            Dim DblInteresAplicado, DblPagosAlAño, DblValorResidual As Double
            Dim DblCuotaPeriodo, DblRecCostePeriodo, DblInteresPeriodo As Double
            Dim DblImpInteresesTotal As Double
            Dim FCalculoCuota As String = String.Empty
            Dim FDesglosePrimCuota As String = String.Empty
            Dim LngNDecimalesImp As Long
            Dim BlnValorResidualIgualCuota As Boolean

            DtMonedaA = ExpertisApp.ExecuteTask(Of Object, DataTable)(AddressOf Moneda.ObtenerMonedaA, New Object)
            If Not DtMonedaA Is Nothing AndAlso DtMonedaA.Rows.Count > 0 Then
                LngNDecimalesImp = DtMonedaA.Rows(0)("NDecimalesImp")
            End If
            DtBE = ClsBE.Filter("vLeasingTotalInmovilizado", New StringFilterItem("IDInmovilizado", Me.CurrentRow("IDInmovilizado")))
            If Not DtBE Is Nothing AndAlso DtBE.Rows.Count > 0 Then
                DblBienTotal = Nz(DtBE.Rows(0)("TotalRevalorizadoA"))
                If Length(NtbAportInicial.Value & String.Empty) Then DblBienTotal -= NtbAportInicial.Value
            End If
            If Act Then
                Dim FilPago As New Filter
                FilPago.Add("IDPagoPeriodo", FilterOperator.Equal, CurrentRow("ID"), FilterType.Numeric)
                FilPago.Add(New DateFilterItem("FechaVencimiento", FilterOperator.LessThan, DtmFechaAct))
                DtPago = ClsPago.Filter(FilPago)
                If Not DtPago Is Nothing AndAlso DtPago.Rows.Count > 0 Then
                    For Each Dr As DataRow In DtPago.Select
                        DblPagos += Dr("ImpRecuperacionCoste")
                    Next
                    DblBienTotal -= DblPagos
                    DblNumCuotas = CDbl(NtbNumTotalCuotas.Value) - DtPago.Rows.Count
                    If DtPago.Rows.Count >= CDbl(NtbNumTotalCuotas.Value) Then
                        DblNumCuotasCarencia = 0
                    Else
                        DblNumCuotasCarencia = CDbl(NtbCuotasCarencia.Value) - DtPago.Rows.Count
                    End If
                End If
                DblInteresAplicado = DblIntAplicado
            Else
                DblNumCuotas = CDbl(NtbNumTotalCuotas.Value)
                DblNumCuotasCarencia = CDbl(NtbCuotasCarencia.Value)
                DblInteresAplicado = CDbl(NtbTipoInteres.Text)
            End If
            DblPagosAlAño = Nz(NtbPagosAño.Value)
            DblImpInteresesTotal = Nz(NtbImpIntereses.Value)
            DblValorResidual = Nz(NtbValorResidual.Value)
            BlnValorResidualIgualCuota = CBool(ChkVResidualCuota.Checked)
            DblCuotaPeriodo = Nz(NtbCuotaPeriodo.Value)
            DblRecCostePeriodo = Nz(NtbRecupCostePeriodo.Value)
            DblInteresPeriodo = Nz(NtbInteresPeriodo.Value)
            DtBPFF = ClsBPFF.Filter(New FilterItem("IDBancoPropio", FilterOperator.Equal, Nz(AdvBancoPropio.Value, String.Empty), FilterType.String))
            If Not DtBPFF Is Nothing AndAlso DtBPFF.Rows.Count > 0 Then
                If Length(DtBPFF.Rows(0)("fCalculoCuota") & String.Empty) > 0 Then FCalculoCuota = DtBPFF.Rows(0)("fCalculoCuota")
                If Length(DtBPFF.Rows(0)("fDesglosePrimeraCuota") & String.Empty) > 0 Then FDesglosePrimCuota = DtBPFF.Rows(0)("fDesglosePrimeraCuota")
                If Not Act Then
                    If NtbCuotaPeriodo.Value > 0 Then
                        If ExpertisApp.GenerateMessage("El Campo Cuota Periodo ya tiene Valor. ¿Desea Recalcularlo?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then '13254
                            Exit Sub
                        End If
                    End If
                End If
                DtPagos = ClsPago.Filter(New FilterItem("IDPagoPeriodo", FilterOperator.Equal, Me.CurrentRow("ID"), FilterType.Numeric))
                If Not DtPagos Is Nothing AndAlso DtPagos.Rows.Count > 0 Then
                    If GridPagos.RecordCount > 0 AndAlso Not Act Then
                        ExpertisApp.GenerateMessage("Ya hay pagos generados para este pago periódico. Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    Else
                        If Length(FCalculoCuota & String.Empty) > 0 And Length(FDesglosePrimCuota & String.Empty) > 0 Then
                            Dt = CallByName(ClsBPFF, FCalculoCuota, CallType.Method, DblNumCuotas, _
                            DblNumCuotasCarencia, DblInteresAplicado, DblPagosAlAño, _
                            DblBienTotal, DblImpInteresesTotal, DblValorResidual, BlnValorResidualIgualCuota, _
                            DblCuotaPeriodo, DblRecCostePeriodo, DblInteresPeriodo, FDesglosePrimCuota, LngNDecimalesImp)
                            If Not Dt Is Nothing AndAlso Dt.Rows.Count > 0 Then
                                Me.CurrentRow("CuotasAutomatica") = True
                                Me.CurrentRow("ImpCuotaPeriodo") = xRound(Dt.Rows(0)("Cuota"), LngNDecimalesImp)
                                Me.CurrentRow("ImpRecuperacionCostePeriodo") = Dt.Rows(0)("Recuperacion")
                                Me.CurrentRow("ImpInteresPeriodo") = xRound(Dt.Rows(0)("Intereses"), LngNDecimalesImp)
                                Me.CurrentRow("Importe") = xRound(Me.CurrentRow("ImpCuotaPeriodo") * (1 + (CDbl(MDblFactorIVA) / 100)), LngNDecimalesImp)
                                ExpertisApp.GenerateMessage("El cálculo de cuota finalizó correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Me.UpdateData()
                                Me.RetrieveData(DataProviderActions.Refresh)
                                Me.RecordsState = RecordsState.Saved
                            Else : mblnNoGenPagos = True
                            End If
                        Else
                            ExpertisApp.GenerateMessage("No están establecidos los métodos de cálculo para el banco propio. Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Else
                    If Length(FCalculoCuota & String.Empty) > 0 And Length(FDesglosePrimCuota & String.Empty) > 0 Then
                        Dt = CallByName(ClsBPFF, FCalculoCuota, vbMethod, DblNumCuotas, _
                        DblNumCuotasCarencia, DblInteresAplicado, DblPagosAlAño, _
                        DblBienTotal, DblImpInteresesTotal, DblValorResidual, BlnValorResidualIgualCuota, _
                        DblCuotaPeriodo, DblRecCostePeriodo, DblInteresPeriodo, FDesglosePrimCuota, LngNDecimalesImp)
                        If Not Dt Is Nothing AndAlso Dt.Rows.Count > 0 Then
                            Me.CurrentRow("CuotaAutomatica") = True
                            Me.CurrentRow("ImpCuotaPeriodo") = xRound(Dt.Rows(0)("Cuota"), LngNDecimalesImp)
                            Me.CurrentRow("ImpRecuperacionCostePeriodo") = Dt.Rows(0)("Recuperacion")
                            Me.CurrentRow("ImpInteresPeriodo") = xRound(Dt.Rows(0)("Intereses"), LngNDecimalesImp)
                            Me.CurrentRow("Importe") = xRound(Me.CurrentRow("ImpCuotaPeriodo") * (1 + (CDbl(MDblFactorIVA) / 100)), LngNDecimalesImp)
                            ExpertisApp.GenerateMessage("El cálculo de cuota finalizó correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.UpdateData()
                            Me.RetrieveData(DataProviderActions.Refresh)
                            Me.RecordsState = RecordsState.Saved
                        Else : mblnNoGenPagos = True
                        End If
                    Else
                        ExpertisApp.GenerateMessage("No están establecidos los métodos de cálculo para el banco propio. Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
        End If
        ActualizarImporteConIVA()
        'mblnNoGenPagos = False
    End Sub

    Private Sub AccionComprobacionPagos()
        Dim ClsPagoPerAct As New PagoPerActualiz
        Dim DtPagoPerAct As DataTable = ClsPagoPerAct.Filter(New FilterItem("IDPago", FilterOperator.Equal, Me.CurrentRow("ID"), FilterType.Numeric))
        If DtPagoPerAct Is Nothing OrElse DtPagoPerAct.Rows.Count = 0 Then
            If Not IsDBNull(Me.CurrentRow("IDBancoPropio")) Then
                Dim ClsBPFF As New BancoPropioFormFinanc
                Dim DtBPFF As DataTable = ClsBPFF.Filter(New FilterItem("IDBancoPropio", FilterOperator.Equal, AdvBancoPropio.Value, FilterType.String))
                If Not DtBPFF Is Nothing AndAlso DtBPFF.Rows.Count > 0 Then
                    If Length(DtBPFF.Rows(0)("fCalculoCuota") & String.Empty) > 0 AndAlso Length(DtBPFF.Rows(0)("fDesglosePrimeraCuota") & String.Empty) > 0 Then
                        CalculoCuota(False)
                        If mblnNoGenPagos = False Then
                            AccionGenPagos()
                        Else
                            mblnNoGenPagos = False
                        End If
                    Else
                        ExpertisApp.GenerateMessage("No están establecidos los métodos de cálculo para el banco propio. Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    AccionGenPagosSinBanco()
                End If
            Else
                AccionGenPagosSinBanco()
            End If
        End If
    End Sub

    Private Sub AccionGenPagos()
        Dim DtSimulacion, DtApp, DtPPer, DtImpCorto As DataTable
        Dim ClsBE As New BE.DataEngine
        Dim ClsPago As New Pago
        Dim ClsPPer As New PagoPeriodico
        Dim MFrmFechaP As New frmFechaPago
        Dim DblImpCorto As Double

        If Length(ClbFechaFin.Value) > 0 Then MFrmFechaP.fwiFecha.Value = ClbFechaFin.Value
        If MFrmFechaP.ShowDialog = DialogResult.OK Then
            If Not Me.CurrentRow Is Nothing Then
                Me.Cursor = Windows.Forms.Cursors.WaitCursor
                DtSimulacion = ClsPPer.InsertPagoPeriodicoCuota(Me.CurrentData, MFrmFechaP.dtFecha, False)
                DtApp = ClsBE.Filter("vLeasingTotalPagoPeriodo", New FilterItem("IDPagoPeriodo", FilterOperator.Equal, Me.CurrentRow("ID"), FilterType.Numeric))
                DtImpCorto = ClsPago.Filter(New FilterItem("IDPagoPeriodo", FilterOperator.Equal, Me.CurrentRow("ID"), FilterType.Numeric))
                DblImpCorto = 0
                If Not DtImpCorto Is Nothing AndAlso DtImpCorto.Rows.Count > 0 Then
                    Dim i As Integer = 0
                    For Each Dr As DataRow In DtImpCorto.Select
                        i += 1
                        DblImpCorto += Dr("ImpCuotaA")
                        If i >= 12 Then Exit For
                    Next
                End If
                If Not DtApp Is Nothing AndAlso DtApp.Rows.Count > 0 Then
                    DtPPer = ClsPPer.SelOnPrimaryKey(Me.CurrentRow("ID"))
                    If Not DtPPer Is Nothing AndAlso DtPPer.Rows.Count > 0 Then
                        DtPPer.Rows(0)("ImpRecuperacionCoste") = Nz(DtApp.Rows(0)("ImpTotalRecuperacionCosteA"))
                        DtPPer.Rows(0)("ImpInteresesTotal") = Nz(DtApp.Rows(0)("ImpTotalInteresesA"))
                        DtPPer.Rows(0)("ImpIVAOperacion") = Nz(DtApp.Rows(0)("ImpTotalIVAA"))
                        DtPPer.Rows(0)("ImpCortoPlazoDeuda") = Nz(DblImpCorto)
                        ClsPPer.Update(DtPPer)
                    End If
                End If
                Me.RecordsState = RecordsState.Saved
                Me.RetrieveData(DataProviderActions.Refresh)
                Me.Cursor = Windows.Forms.Cursors.Default
                HabilitacionControles(False)
                CargarTotalesPagos()
                CargarTotalesPagoPeriodico()
            Else
                ExpertisApp.GenerateMessage("Error leyendo datos.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If
    End Sub

    Private Sub AccionGenPagosSinBanco()
        Dim DtSimulacion, DtApp, DtPPer, DtImpCorto As DataTable
        Dim ClsPago As New Pago
        Dim ClsPPer As New PagoPeriodico
        Dim ClsBe As New BE.DataEngine
        Dim DblImpCorto As Double
        Dim MFrmFechaP As New frmFechaPago

        If Length(ClbFechaFin.Value) > 0 Then MFrmFechaP.fwiFecha.Value = ClbFechaFin.Value

        If MFrmFechaP.ShowDialog = DialogResult.OK Then
            If Not Me.CurrentRow Is Nothing Then
                If ExpertisApp.GenerateMessage("Se generarán Pagos de forma Masiva a partir de las líneas seleccionadas. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Me.Cursor = Windows.Forms.Cursors.WaitCursor
                    DtSimulacion = ClsPPer.InsertPagoPeriodico(Me.CurrentData, MFrmFechaP.dtFecha, False)
                    DtImpCorto = ClsPago.Filter(New FilterItem("IDPagoPeriodo", FilterOperator.Equal, Me.CurrentRow("ID"), FilterType.Numeric))
                    DblImpCorto = 0
                    If Not DtImpCorto Is Nothing AndAlso DtImpCorto.Rows.Count > 0 Then
                        Dim i As Integer = 0
                        For Each Dr As DataRow In DtImpCorto.Select
                            i += 1
                            DblImpCorto += Dr("ImpCuotaA")
                            If i > 12 Then Exit For
                        Next
                    End If
                    DtApp = ClsBe.Filter("vLeasingTotalPagoPeriodo", New FilterItem("IDPagoPeriodo", FilterOperator.Equal, Me.CurrentRow("ID"), FilterType.Numeric))
                    If Not DtApp Is Nothing AndAlso DtApp.Rows.Count > 0 Then
                        DtPPer = ClsPPer.SelOnPrimaryKey(Me.CurrentRow("ID"))
                        If Not DtPPer Is Nothing AndAlso DtPPer.Rows.Count > 0 Then
                            DtPPer.Rows(0)("ImpCortoPlazoDeuda") = Nz(DblImpCorto)
                            ClsPPer.Update(DtPPer)
                        End If
                    End If
                    Me.RecordsState = RecordsState.Saved
                    Me.RetrieveData(DataProviderActions.Refresh)
                    Me.Cursor = Windows.Forms.Cursors.Default
                Else
                    ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                HabilitacionControles(False)
                CargarTotalesPagos()
            Else
                ExpertisApp.GenerateMessage("Error leyendo datos.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If
    End Sub

    Protected Overridable Sub AccionCargarAnticipadoDiferido()
        Dim ClsPagoPerImp As New PagoPeriodico
        Dim ClsBE As New BE.DataEngine
        Dim DtSinAmort As New DataTable

        If ChkNoCalcular.Checked Then Exit Sub
        If Not Me.CurrentRow Is Nothing Then
            DtSinAmort = ClsBE.Filter("vfrmLeasingSinElementosAmortizables", New FilterItem("Id", FilterOperator.Equal, Me.CurrentRow("Id"), FilterType.Numeric))
            If Not DtSinAmort Is Nothing AndAlso DtSinAmort.Rows.Count > 0 Then
                ExpertisApp.GenerateMessage("No se encontraron Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If ExpertisApp.GenerateMessage("El proceso tardará unos minutos en función del número" & Chr(13) & "de elementos amortizables. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then     'El proceso tardará unos minutos en función del número de elementos amortizables. ¿Desea continuar?
                Me.Cursor = Windows.Forms.Cursors.WaitCursor
                GridAnticipadoDiferido.DataSource = ClsPagoPerImp.CargarAnticipadoDiferido(Me.CurrentRow("ID"))
                Me.RetrieveData(DataProviderActions.Refresh)
                Me.RecordsState = RecordsState.Saved
                CargarTotalDiferidoAnticipado()
                Me.Cursor = Windows.Forms.Cursors.Default
                mblnInicio = False
            Else
                ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub AccionCambioActua()
        Dim Dtgrid As New DataTable
        Dtgrid = GridActualizaciones.DataSource
        If Not Dtgrid Is Nothing AndAlso Dtgrid.Rows.Count > 0 Then
            Dim MFrmAct As New FrmActualizacion
            Dim MFrmCuotaAct As New FrmCuota
            Dim ClsBPFF As New BancoPropioFormFinanc
            Dim ClsPagoPer As New PagoPeriodico
            Dim ClsBE As New BE.DataEngine
            Dim ClsBE2 As New BE.DataEngine
            Dim DtBPFF, DtApp, DtPagoPer, DtApp2 As DataTable
            Dim DtCuota As New DataTable
            Dim LngResult, LngID As Long
            Dim StrActPagos As String = String.Empty
            Dim StrIDMoneda As String = String.Empty
            Dim StrCampos As String = String.Empty
            Dim DblCuotaAnt, DblTipoIntApl, DblTipoIntAplAct As Double
            Dim DblTipoInt, DblTipoIntAct, DblNPagosAño As Double
            Dim DblImpRecupCoste, DblImpIntTotal As Double
            Dim DteFecha As Date
            Dim BlnPrepagable As Boolean
            Dim IntUnidad As Integer
            Dim DiagResult As DialogResult

            DtBPFF = ClsBPFF.Filter(New FilterItem("IDBancoPropio", FilterOperator.Equal, AdvBancoPropio.Value, FilterType.String))
            If Not DtBPFF Is Nothing AndAlso DtBPFF.Rows.Count > 0 Then
                If Length(DtBPFF.Rows(0)("fActualizacionPagos") & String.Empty) > 0 Then
                    StrActPagos = DtBPFF.Rows(0)("fActualizacionPagos")
                Else
                    ExpertisApp.GenerateMessage("No se puede actualizar. El banco no tiene fórmula para la actualización de los pagos.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
            MFrmAct.ID = Me.CurrentRow("ID")
            MFrmAct.BaseCalculo = CmbBaseCalculo.Value
            MFrmAct.TipoInteres = NtbTipoInteres.Text
            MFrmAct.TipoInteresAplicado = NtbTipoInteresAplicado.Text
            MFrmAct.BancoPropio = AdvBancoPropio.Value
            MFrmAct.PrePagable = ChkPostPagable.Checked
            DiagResult = MFrmAct.ShowDialog
            DteFecha = MFrmAct.Fecha
            DblTipoIntApl = MFrmAct.TipoInteresAplicado
            DblTipoIntAplAct = MFrmAct.TipoIntAplAct
            DblTipoInt = MFrmAct.TipoInteres
            DblTipoIntAct = MFrmAct.TipoIntAct
            DtApp2 = ClsBE2.Filter("vLeasingTotalPagoPeriodo", New FilterItem("IDPagoPeriodo", FilterOperator.Equal, Me.CurrentRow("ID"), FilterType.Numeric))
            If Not DtApp2 Is Nothing AndAlso DtApp2.Rows.Count > 0 Then
                DblImpRecupCoste = DtApp2.Rows(0)("ImpTotalRecuperacionCoste")
            End If
            DblImpIntTotal = NtbImpIntereses.Value
            BlnPrepagable = Not CBool(MFrmAct.PrePagable)
            If Length(NtbCuotaPeriodo.Value & String.Empty) > 0 Then
                DblCuotaAnt = NtbCuotaPeriodo.Value
            Else
                StrCampos &= "Cuota Periodo"
            End If
            If Length(NtbPagosAño.Value & String.Empty) > 0 Then
                DblNPagosAño = NtbPagosAño.Value
            Else
                If Length(StrCampos) > 0 Then StrCampos &= ", "
                StrCampos &= "Pagos al Año"
            End If
            If Length(AdvMoneda.Value & String.Empty) > 0 Then
                StrIDMoneda = AdvMoneda.Value
            Else
                If Length(StrCampos) > 0 Then StrCampos &= ", "
                StrCampos &= "Moneda"
            End If
            If Length(CmbUnidad.Value & String.Empty) > 0 Then
                IntUnidad = CmbUnidad.Value
            Else
                If Length(StrCampos) > 0 Then StrCampos &= ", "
                StrCampos &= "Unidad"
            End If
            If Length(StrCampos) > 0 Then
                ExpertisApp.GenerateMessage("Los campos siguientes: | deberán estar rellenos para efectuar esta operación.", MessageBoxButtons.OK, MessageBoxIcon.Information, StrCampos)
            End If
            If DiagResult = DialogResult.OK Then
                ComprobacionContabilizados(DteFecha)
                If mblnStop = False Then
                    LngID = Me.CurrentRow("ID")
                    If mblnNoGenPagos = False Then
                        LngResult = CallByName(ClsBPFF, StrActPagos, CallType.Method, DteFecha, DblTipoIntAplAct, DblNPagosAño, LngID, DblImpRecupCoste, StrIDMoneda, BlnPrepagable, DblTipoIntAct, IntUnidad, True, DtCuota)
                        If LngResult = -1 Then
                            If Not DtCuota Is Nothing AndAlso DtCuota.Rows.Count > 0 Then
                                MFrmCuotaAct.Cuota = DtCuota.Rows(0)("Cuota")
                                If MFrmCuotaAct.LoadFunction = DialogResult.OK Then
                                    DtCuota.Rows(0)("Cuota") = MFrmCuotaAct.Cuota
                                    LngResult = CallByName(ClsBPFF, StrActPagos, CallType.Method, DteFecha, DblTipoIntAplAct, DblNPagosAño, LngID, DblImpRecupCoste, StrIDMoneda, BlnPrepagable, DblTipoIntAct, IntUnidad, False, DtCuota)
                                Else
                                    Exit Sub
                                End If
                            End If
                        End If
                    Else
                        mblnNoGenPagos = False
                    End If
                    If LngResult = -1 Then
                        Me.CurrentRow("TipoInteres") = MFrmAct.TipoIntAct
                        Me.CurrentRow("TipoInteresAplicado") = MFrmAct.TipoIntAplAct
                        Me.CurrentRow("FechaUltimaActualizacion") = DteFecha
                        Me.UpdateData()
                        DtApp = ClsBE.Filter("vLeasingTotalPagoPeriodo", New FilterItem("IDPagoPeriodo", FilterOperator.Equal, Me.CurrentRow("ID"), FilterType.Numeric))
                        Me.CurrentRow("ImpInteresesTotal") = 0
                        If Not DtApp Is Nothing AndAlso DtApp.Rows.Count > 0 Then
                            DtPagoPer = ClsPagoPer.SelOnPrimaryKey(Me.CurrentRow("ID"))
                            If Not DtPagoPer Is Nothing AndAlso DtPagoPer.Rows.Count > 0 Then
                                DtPagoPer.Rows(0)("ImpInteresesTotal") = Nz(DtApp.Rows(0)("ImpTotalInteresesA"))
                                ClsPagoPer.Update(DtPagoPer)
                            End If
                        End If
                        CargarTabla(DblTipoInt, DblTipoIntApl, DteFecha, DblCuotaAnt, BlnPrepagable)
                        Me.RecordsState = RecordsState.Saved
                        Me.RefreshData(DataProviderActions.Refresh)
                    End If
                Else
                    mblnStop = False
                End If
            End If
        End If
    End Sub

    Private Function CalcularEjercicioPagoPeriodico(ByVal strFecha As String) As String
        Return ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, CDate(Nz(strFecha, Today)))
    End Function

#End Region

#Region "Procesos Filtros"

    Private Sub FiltroCuentasLeasing(ByVal e As Engine.UI.AdvSearchFilterEventArgs)
        e.Filter.Add("IDEjercicio", FilterOperator.Equal, StrEjerAct, FilterType.String)
        e.Filter.Add(New BooleanFilterItem("Auxiliar", True))
    End Sub

    Private Sub ComprobarFiltros()
        Dim blnVisible As Janus.Windows.GridEX.InheritableBoolean
        blnVisible = IIf(TabLineas.SelectedTab.Index = TbPago.Index, Janus.Windows.GridEX.InheritableBoolean.True, Janus.Windows.GridEX.InheritableBoolean.False)
        Me.UiCommandManager1.Commands("FilterExec").Visible = blnVisible
        Me.UiCommandManager1.Commands("FilterDel").Visible = blnVisible
        Dim DtPagos As New DataTable
        DtPagos = GridPagos.DataSource
        If Not DtPagos Is Nothing AndAlso DtPagos.Rows.Count > 0 Then
            Me.UiCommandManager1.Commands("FilterExec").Enabled = Janus.Windows.UI.InheritableBoolean.True
            Me.UiCommandManager1.Commands("FilterDel").Enabled = Janus.Windows.UI.InheritableBoolean.True
        Else
            Me.UiCommandManager1.Commands("FilterExec").Enabled = Janus.Windows.UI.InheritableBoolean.False
            Me.UiCommandManager1.Commands("FilterDel").Enabled = Janus.Windows.UI.InheritableBoolean.False
        End If
    End Sub

    Private Sub ConsultaGridPagos(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles FilterExec1.Click
        Dim FilGrid As New Filter
        If Not IsDBNull(ClbVencDesde.Value) Then
            FilGrid.Add("FechaVencimiento", FilterOperator.GreaterThanOrEqual, ClbVencDesde.Value, FilterType.DateTime)
        End If
        If Not IsDBNull(ClbVencHasta.Value) Then
            FilGrid.Add("FechaVencimiento", FilterOperator.LessThanOrEqual, ClbVencHasta.Value, FilterType.DateTime)
        End If
        If Length(CmbSituacion.Value) > 0 Then
            FilGrid.Add("Situacion", FilterOperator.Equal, CmbSituacion.Value, FilterType.Numeric)
        End If
        If CmbFilContabilizado.Value <> enumBoolean.Todos AndAlso Length(CmbFilContabilizado.Value) > 0 Then
            FilGrid.Add("Contabilizado", FilterOperator.Equal, CmbFilContabilizado.Value, FilterType.Numeric)
        End If
        If Not FilGrid Is Nothing Then
            Dim DtDatos As DataTable = GridPagos.DataSource
            DtDatos.DefaultView.RowFilter = FilGrid.Compose(New AdoFilterComposer)
            GridPagos.DataSource = DtDatos
        End If
    End Sub

    Private Sub LimpiarFilGridPagos(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles FilterDel1.Click
        ClbVencDesde.Value = Nothing
        ClbVencDesde.TextBox.Clear()
        ClbVencHasta.Value = Nothing
        ClbVencHasta.TextBox.Clear()
        CmbFilContabilizado.Value = enumBoolean.Todos
        CmbSituacion.Value = enumPagoSituacion.NoPagado
    End Sub

#End Region

#Region "Calculo Totales Grids"

    Private Sub CargarTotalesForm()
        CargarTotalesPagos()
        CargarTotalesInmovilizado()
        CargarTotalDiferidoAnticipado()
        CargarTotalesPagoPeriodico()
    End Sub

    Private Sub CargarTotalesPagos()
        NtbRecupCosteTotal.Value = GridPagos.GetTotal(GridPagos.Columns("ImpRecuperacionCoste"), Janus.Windows.GridEX.AggregateFunction.Sum)
        NtbInteresPagoTotal.Value = GridPagos.GetTotal(GridPagos.Columns("ImpIntereses"), Janus.Windows.GridEX.AggregateFunction.Sum)
        NtbCuotaPagoTotal.Value = GridPagos.GetTotal(GridPagos.Columns("ImpCuota"), Janus.Windows.GridEX.AggregateFunction.Sum)
        NtbImpVtoPagoTotal.Value = GridPagos.GetTotal(GridPagos.Columns("ImpVencimiento"), Janus.Windows.GridEX.AggregateFunction.Sum)
    End Sub

    Private Sub CargarTotalesInmovilizado()
        NtbTotalValorTotalElemA.Value = GridElementos.GetTotal(GridElementos.Columns("ValorTotalRevalElementoA"), Janus.Windows.GridEX.AggregateFunction.Sum)
        NtbTotalValorAmortElemA.Value = GridElementos.GetTotal(GridElementos.Columns("ValorAmortizadoElementoA"), Janus.Windows.GridEX.AggregateFunction.Sum)
        NtbValorNetoContElemA.Value = GridElementos.GetTotal(GridElementos.Columns("ValorNetoContableElementoA"), Janus.Windows.GridEX.AggregateFunction.Sum)
        CalculoImpNetoFinanciar()
    End Sub

    Protected Sub CargarTotalDiferidoAnticipado()
        If Not Me.CurrentRow("ID") Is Nothing Then
            Dim ClsBE As New BE.DataEngine
            With GridAnticipadoDiferido
                Dim Dt As DataTable = ClsBE.Filter("vNegCargarAnticipadoDiferidoAcumulado", New FilterItem("IDPagoPeriodico", FilterOperator.Equal, Me.CurrentRow("ID"), FilterType.Numeric))
                If Not Dt Is Nothing AndAlso Dt.Rows.Count > 0 Then
                    Dim DblGastoCont, DblGastoFiscalTeo, DblLimiteAmort, DblGastoFiscal, _
                    DblImpuesto As Double
                    For Each Dr As DataRow In Dt.Select
                        DblGastoCont += Dr("AcumGastoContable")
                        DblGastoFiscalTeo += Dr("AcumGastoFiscalTeorico")
                        DblLimiteAmort += Dr("AcumLimiteAmortizacion")
                        DblImpuesto += Dr("AcumImpuesto")
                    Next
                    NtbGastoContable.Value = DblGastoCont
                    NtbGastoFiscalTeorico.Value = DblGastoFiscalTeo
                    NtbLimiteAmortizacion.Value = DblLimiteAmort
                    NtbGastoFiscal.Value = DblGastoFiscal
                    NtbImpuesto.Value = DblImpuesto
                Else
                    NtbGastoContable.Value = 0
                    NtbGastoFiscalTeorico.Value = 0
                    NtbLimiteAmortizacion.Value = 0
                    NtbGastoFiscal.Value = 0
                    NtbImpuesto.Value = 0
                End If
            End With
        End If
    End Sub

    Private Sub CargarTotalesPagoPeriodico()
        Dim ClsBE As New BE.DataEngine
        Dim DtApp As New DataTable

        If Not Me.CurrentRow Is Nothing Then
            DtApp = ClsBE.Filter("vFrmMntoPagoPeriodicoTotales", New FilterItem("ID", FilterOperator.Equal, Me.CurrentRow("ID"), FilterType.Numeric))
            If Not DtApp Is Nothing AndAlso DtApp.Rows.Count > 0 Then
                NtbTotalRecupCoste.Value = DtApp.Rows(0)("ImpRecuperacionCoste") & DBNull.Value
                NtbTotalImpInteres.Value = DtApp.Rows(0)("ImpIntereses") & DBNull.Value
                NtbTotalImpIVA.Value = DtApp.Rows(0)("ImpIVA") & DBNull.Value
                DtApp.Clear()
                Dim f As New Filter
                f.Add(New NumberFilterItem("ID", Me.CurrentRow("ID")))
                f.Add(New DateFilterItem("FechaVencimiento", FilterOperator.GreaterThanOrEqual, Today.Date))
                DtApp = ClsBE.Filter("vFrmMntoPagoPeriodicoImpCorto", f, "TOP 12 ImpCuota")
                NtbTotalImpCorto.Value = 0
                Dim DblImpCorto As Double
                For Each Dr As DataRow In DtApp.Select
                    DblImpCorto += Dr("ImpCuota")
                Next
                NtbTotalImpCorto.Value = DblImpCorto
            Else
                NtbTotalRecupCoste.Value = 0
                NtbTotalImpInteres.Value = 0
                NtbTotalImpIVA.Value = 0
                NtbTotalImpCorto.Value = 0
            End If
        End If
    End Sub

#End Region

#Region "Procesos de Datos"

    Private Sub RefreshElementosInmovilizado()
        'If TabLineas.SelectedIndex = TbInmovilizado.Index Then
        Dim FilGridElem As New Filter
        If Length(AdvInmovilizado.Value & String.Empty) > 0 Then
            FilGridElem.Add("IDInmovilizado", FilterOperator.Equal, AdvInmovilizado.Value, FilterType.String)
            GridElementos.ReQuery(FilGridElem)
        Else
            FilGridElem.Add("1", FilterOperator.Equal, "2")
            GridElementos.ReQuery(FilGridElem)
        End If
        GridElementos.Refresh()
        'End If
    End Sub

    Private Sub ActualizarImporteConIVA()
        Dim DblImporte, DblInteres, DblFactor As Double
        Dim DblIVA, DblAmortizacion As Double

        If Length(NtbRecupCostePeriodo.Value) > 0 Then DblAmortizacion = CDbl(NtbRecupCostePeriodo.Value)
        If Length(NtbInteresPeriodo.Value) > 0 Then DblInteres = CDbl(NtbInteresPeriodo.Value)
        If Length(MDblFactorIVA) Then DblFactor = CDbl(MDblFactorIVA)

        DblImporte = DblAmortizacion + DblInteres
        DblIVA = DblImporte * (DblFactor / 100)

        NtbCuotasIVA.Value = (DblImporte + DblIVA)
        Me.RecordsState = RecordsState.Saved
    End Sub

    Private Sub ActualizarImporteTotalConIVA()
        Dim dblImporte, dblInteres As Double
        Dim dblFactor, dblIVA, dblAmortizacion As Double
        If Me.RecordsState <> RecordsState.Saved Then
            If Length(NtbRecupCoste.Value) > 0 Then dblAmortizacion = CDbl(NtbRecupCoste.Value)
            If Length(NtbImpIntereses.Value) > 0 Then dblInteres = CDbl(NtbImpIntereses.Value)
            If Length(MDblFactorIVA) > 0 Then dblFactor = CDbl(MDblFactorIVA)
            dblImporte = dblAmortizacion + dblInteres
            dblIVA = dblImporte * (dblFactor / 100)
            NtbImpIVA.Value = dblImporte + dblIVA
        End If
    End Sub

    Private Sub ActualizarDescripcionFactorIVA()
        If Not AdvTipoIVA.SelectedRow Is Nothing Then
            MDblFactorIVA = Nz(AdvTipoIVA.SelectedRow.Item("Factor"), 0)
            LblIVA.Text = MDblFactorIVA & ",00 % I.V.A"
        Else
            LblIVA.Text = "0,00 % I.V.A."
        End If
    End Sub

    Protected Overridable Sub ComprobarCuenta(ByRef sender As Object)
        Dim ClsAltaContable As New AltaPlanContable
        If Not ClsAltaContable.ValidaCuentaContable(sender.text, StrEjerAct) Then
            sender.text = String.Empty
            sender.value = Nothing
        End If
    End Sub

    Private Sub HabilitacionControles(ByVal BlnEnable As Boolean)
        Select Case BlnEnable
            Case True
                NtbAportInicial.Enabled = True

            Case False
                Dim ClsPago As New Pago
                Dim DtPago As DataTable = ClsPago.Filter(New FilterItem("IDPagoPeriodo", FilterOperator.Equal, Me.CurrentRow("ID"), FilterType.Numeric))
                If Not DtPago Is Nothing AndAlso DtPago.Rows.Count > 0 Then
                    NtbAportInicial.Enabled = False
                End If
        End Select
    End Sub

    Private Sub ComprobacionContabilizados(ByVal DTEfecha As Date)
        Dim ClsPago As New Pago
        Dim FilPago As New Filter
        FilPago.Add("IDPagoPeriodo", FilterOperator.Equal, Me.CurrentRow("ID"), FilterType.Numeric)
        FilPago.Add("FechaVencimiento", FilterOperator.GreaterThanOrEqual, DTEfecha, FilterType.DateTime)
        Dim DtPago As DataTable = ClsPago.Filter(FilPago)
        If Not DtPago Is Nothing AndAlso DtPago.Rows.Count > 0 Then
            Dim DrDatos() As DataRow = DtPago.Select("Contabilizado<>" & enumContabilizado.NoContabilizado)
            If DrDatos.Length > 0 Then
                ExpertisApp.GenerateMessage("Hay pagos contabilizados posteriores a la fecha seleccionada. Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                mblnStop = True
            End If
        End If
    End Sub

    Private Sub CargarTabla(ByVal DblTipoInteresAnt As Double, _
    ByVal DblTipoInteresAplicadoAnt As Double, ByVal DTEfecha As Date, _
    ByVal DblCuotaAnt As Double, ByVal BlnPrepagable As Boolean)
        Dim ClsPagoPerAct As New PagoPerActualiz
        Dim ClsOperario As New Operario
        Dim DtPagoPerAct As DataTable

        DtPagoPerAct = ClsPagoPerAct.AddNew

        Dim DrNew As DataRow = DtPagoPerAct.NewRow()

        DrNew("CuotaSinIVAAnt") = DblCuotaAnt
        DrNew("TipoInteresAnt") = DblTipoInteresAnt
        DrNew("TipoInteresAplicadoAnt") = DblTipoInteresAplicadoAnt
        DrNew("CuotaSINIVAAct") = NtbCuotaPeriodo.Value
        DrNew("TipoInteresAct") = CDbl(NtbTipoInteres.Text)
        DrNew("TipoInteresAplicadoAct") = CDbl(NtbTipoInteresAplicado.Text)
        DrNew("Prepagable") = BlnPrepagable

        Dim StrOperario As String = ExpertisApp.ExecuteTask(Of Object, String)(AddressOf Operario.ObtenerIDOperarioUsuario, New Object)
        'DtOperario = ClsOperario.Filter(New FilterItem("IDUsuario", FilterOperator.Equal, ExpertisApp.UserName, FilterType.String))
        'If Not DtOperario Is Nothing AndAlso DtOperario.Rows.Count > 0 Then
        If Length(StrOperario) > 0 Then
            DrNew("IDOperario") = StrOperario
        End If
        'End If
        DrNew("IdPago") = Me.CurrentRow("ID")
        DrNew("FechaPagoDesde") = DTEfecha
        DtPagoPerAct.Rows.Add(DrNew)
        ClsPagoPerAct.Update(DtPagoPerAct)
        GridActualizaciones.Refresh()
    End Sub

    Private Function CalculoAcumulados(ByVal DtDataSource As DataTable) As DataTable
        Dim StrID, StrElemento As String
        Dim DblAcumulado As Double

        StrElemento = DtDataSource.Rows(0)("IDElemento")
        StrID = DtDataSource.Rows(0)("IdPagoPeriodico")
        For Each Dr As DataRow In DtDataSource.Select
            If Dr("IDPagoPeriodico") = StrID AndAlso Dr("IDElemento") = StrElemento Then
            Else : DblAcumulado = 0
            End If
            DblAcumulado += Dr("Impuesto")
            Dr("ImpuestoAcumulado") = DblAcumulado
            StrElemento = Dr("IDElemento")
            StrID = Dr("IdPagoPeriodico")
        Next
        Return DtDataSource
    End Function

    Private Sub CalculoImpNetoFinanciar()
        If Length(AdvInmovilizado.Value) > 0 Then
            Dim DblAcumTotal As Double
            Dim ClsElemAmort As New ElementoAmortizable
            Dim DtElemAmort As DataTable = ClsElemAmort.Filter(New FilterItem("IDInmovilizado", FilterOperator.Equal, AdvInmovilizado.Value, FilterType.String))
            If Not DtElemAmort Is Nothing AndAlso DtElemAmort.Rows.Count > 0 Then
                For Each Dr As DataRow In DtElemAmort.Select
                    DblAcumTotal += Nz(Dr("ValorTotalRevalElementoA"))
                Next
            End If
            NtbImpNetoFinanciar.Value = DblAcumTotal
        End If
    End Sub

    'Private Sub ActualizacionPagos(ByVal dtefecha As Date)
    '    Dim fwnBPFF As BancoPropioFormFinanc
    '    Dim rcsBPFF As Recordset
    '    Dim fwnPago As Pago
    '    Dim rsPago As Recordset
    '    Dim dblImpRecu As Double
    '    Dim dbiIntTot As Double
    '    Dim dblImpRecuperacionCoste As Double
    'On Error GoTo TratarError
    '
    '    Set fwnBPFF = New BancoPropioFormFinanc
    '    Set rcsBPFF = fwnBPFF.FwIMmto_Filter(, "IDBancoPropio = '" & FwiIdBancoPropio.Value & "'")
    '    If Not rcsBPFF Is Nothing Then
    '         If rcsBPFF.RecordCount > 0 Then
    '            If Len(rcsBPFF!fDesglosePrimeraCuota & vbNullString) > 0 Then
    '                AccionEliminarPagosDesde dtefecha
    '                Set fwnPago = New Pago
    '                Set rsPago = fwnPago.FwIMmto_Filter(, "IDPagoPeriodo = '" & FwEngine1.PrimaryRecordset!ID & "'", "FechaVencimiento DESC")
    '                If Not rsPago Is Nothing And rsPago.RecordCount > 0 Then
    '                    rsPago.MoveFirst
    '                    FwEngine1.PrimaryRecordset!FechaUltimaActualizacion = rsPago!FechaVencimiento
    '                    FwEngine1.UpdatePrimary
    '                End If
    '                Set rsPago = Nothing
    '                Set fwnPago = Nothing
    ''                 AccionGenPagosDesde dtefecha
    '                AccionGenPagos
    '
    ''                FwEngine1.PrimaryRecordset!ImpRecuperacionCoste = dblImpRecuperacionCoste
    ''                FwEngine1.PrimaryRecordset!ImpInteresesTotal = dblImpInteresesTotal
    ''                FwEngine1.UpdatePrimary
    '
    '            Else
    '                GenerateMessage 13271, vbInformation, ExpertisApp.Title
    '            End If
    '
    '         Else
    '              AccionEliminarPagosDesde dtefecha
    '
    '              Set fwnPago = New Pago
    '              Set rsPago = fwnPago.FwIMmto_Filter(, "IDPagoPeriodo = '" & FwEngine1.PrimaryRecordset!ID & "'", "FechaVencimiento DESC")
    '              If Not rsPago Is Nothing And rsPago.RecordCount > 0 Then
    '                    rsPago.MoveFirst
    '                    FwEngine1.PrimaryRecordset!FechaUltimaActualizacion = rsPago!FechaVencimiento
    '                    Do Until rsPago.EOF
    '                        dblImpRecu = dblImpRecu + rsPago!ImpRecuperacionCoste
    '                        dbiIntTot = dbiIntTot + rsPago!ImpIntereses
    '                        rsPago.MoveNext
    '                    Loop
    '                    FwEngine1.PrimaryRecordset!ImpRecuperacionCoste = dblImpRecuperacionCoste - dblImpRecu
    '                    FwEngine1.PrimaryRecordset!ImpInteresesTotal = dblImpInteresesTotal - dbiIntTot
    '                    FwEngine1.UpdatePrimary
    '               End If
    '              Set rsPago = Nothing
    '              Set fwnPago = Nothing
    '
    '              AccionGenPagosSinBanco
    '
    '          End If
    '
    '     Else
    '        AccionEliminarPagosDesde dtefecha
    '
    '        Set fwnPago = New Pago
    '        Set rsPago = fwnPago.FwIMmto_Filter(, "IDPagoPeriodo = '" & FwEngine1.PrimaryRecordset!ID & "'", "FechaVencimiento DESC")
    '        If Not rsPago Is Nothing And rsPago.RecordCount > 0 Then
    '           rsPago.MoveFirst
    '           FwEngine1.PrimaryRecordset!FechaUltimaActualizacion = rsPago!FechaVencimiento
    '           Do Until rsPago.EOF
    '               dblImpRecu = dblImpRecu + rsPago!ImpRecuperacionCoste
    '               dbiIntTot = dbiIntTot + rsPago!ImpIntereses
    '               rsPago.MoveNext
    '           Loop
    '           FwEngine1.PrimaryRecordset!ImpRecuperacionCoste = dblImpRecuperacionCoste - dblImpRecu
    '           FwEngine1.PrimaryRecordset!ImpInteresesTotal = dblImpInteresesTotal - dbiIntTot
    '           FwEngine1.UpdatePrimary
    '
    '        End If
    '        Set rsPago = Nothing
    '        Set fwnPago = Nothing
    '
    '        AccionGenPagosSinBanco
    '
    '    End If
    '    FwGridPago.Refresh
    '    Set fwnBPFF = Nothing
    '    Set rcsBPFF = Nothing
    'Fin:
    '    On Error Resume Next
    '
    '    Exit Sub
    'TratarError:
    '    GenerateError Err.Number, Err.Description, "ActualizacionPagos", ExpertisApp.Title
    'End Sub

    'Private Sub CalcularCuota()
    'Dim fwnPago As Pago
    'Dim fwnBPFF As BancoPropioFormFinanc
    'Dim rcsBPFF As Recordset
    'Dim rs As Recordset
    'Dim FwnMoneda  As Moneda
    'Dim rcsMonedaA As Recordset
    'Dim fwnApp As Aplicacion
    'Dim rsApp As Recordset
    'Dim dblBienTotal As Double
    '
    'On Error GoTo TratarError
    '    Set fwnApp = New Aplicacion
    '    Set rsApp = fwnApp.Filter("vLeasingTotalInmovilizado", "*", "IDInmovilizado = '" & FwEngine1.PrimaryRecordset!IDInmovilizado & "'")
    '    If Not rsApp Is Nothing Then
    '        If rsApp.RecordCount > 0 Then
    '            dblBienTotal = Nz(rsApp!TotalInmovilizadoA)
    '        End If
    '    End If
    '    Set fwnApp = Nothing
    '    Set fwnPago = New Pago
    '    Set fwnBPFF = New BancoPropioFormFinanc
    '    Set rcsBPFF = fwnBPFF.FwIMmto_Filter("fCalculoCuota , fDesglosePrimeraCuota", "IDBancoPropio = '" & FwiIdBancoPropio.Value & "'")
    '    If Not rcsBPFF Is Nothing Then
    '       If rcsBPFF.RecordCount > 0 Then
    '            If FwICuotaPeriodo.Value > 0 Then
    '                 If GenerateMessage(13254, vbInformation Or vbYesNo Or vbDefaultButton1, ExpertisApp.Title) = vbNo Then
    '                     Exit Sub
    '                 End If
    '            End If
    '            If Len(rcsBPFF!fCalculoCuota & vbNullString) > 0 And Len(rcsBPFF!fDesglosePrimeraCuota & vbNullString) > 0 Then
    '                Set rs = CallByName(fwnPago, rcsBPFF!fCalculoCuota, VbMethod, CDbl(FwiNTotalCuotas.Value), _
    '                        CDbl(FwiNcuotasCarencia.Value), CDbl(FwiTipoInteresAplicado.Value), CDbl(Nz(FwiPagosAlAño.Value)), _
    '                        CDbl(Nz(dblBienTotal)), CDbl(FwiImpInteresesTotal.Value), _
    '                        CDbl(FwiValorResidual.Value), FwiValorResidualIgualCuota.Value, _
    '                        CDbl(FwICuotaPeriodo.Value), CDbl(FwiRecCostePeriodo.Value), _
    '                        CDbl(FwiInteresPeriodo.Value), rcsBPFF!fDesglosePrimeraCuota)
    '
    '               If Not rs Is Nothing Then
    '                   If rs.RecordCount > 0 Then
    '                        FwEngine1.PrimaryRecordset!CuotaAutomatica = True
    '                        rs.MoveFirst
    '                        Set FwnMoneda = New Moneda
    '                        Set rcsMonedaA = FwnMoneda.ObtenerMonedaA
    '
    '                        FwEngine1.PrimaryRecordset!ImpCuotaPeriodo = xRound(rs!Cuota, rcsMonedaA!NDecimalesImp)
    '                        FwEngine1.PrimaryRecordset!ImpRecuperacionCostePeriodo = xRound(rs!Recuperacion, rcsMonedaA!NDecimalesImp)
    '                        FwEngine1.PrimaryRecordset!ImpInteresPeriodo = xRound(rs!Intereses, rcsMonedaA!NDecimalesImp)
    '                        FwEngine1.PrimaryRecordset!Importe = rs!Cuota * (1 + (CDbl(fwiFactorIVA.Value) / 100))
    '                        FwEngine1.UpdatePrimary
    '                        GenerateMessage 13256, vbInformation, ExpertisApp.Title
    '                  Else: mblnNoGenPagos = True
    '                  End If
    '               Else: mblnNoGenPagos = True
    '               End If
    '            Else
    '               GenerateMessage 13271, vbInformation, ExpertisApp.Title
    '            End If
    '       End If
    '  Else
    '  End If
    'Fin:
    '    On Error Resume Next
    '    Set fwnPago = Nothing
    '    Set rcsBPFF = Nothing
    '    Set fwnBPFF = Nothing
    '    Set rcsMonedaA = Nothing
    '    Set FwnMoneda = Nothing
    '    Set rs = Nothing
    '    Exit Sub
    'TratarError:
    '    GenerateError Err.Number, Err.Description, "CalcularCuota", ExpertisApp.Title
    'End Sub
    '

#End Region

#End Region

#Region "Eventos MntoPagoPer"

#Region "Eventos Formulario"

    Private Sub MntoPagoPer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadFormActions()
            LoadEnums()
            LoadDatos()
            ComprobarAcciones()
        End If
    End Sub

    Private Sub MntoPagoPer_Navigated(ByVal sender As Object, ByVal e As Engine.UI.NavigatedEventArgs) Handles MyBase.Navigated
        If Me.RecordsState = RecordsState.Saved Then
            SettingCambioEstado()
            ComprobarAcciones()
            ActDesactAccionCambio()
            CargarTotalesForm()
            mblnInicio = True
            ActualizarDescripcionFactorIVA()
            ActualizarImporteConIVA()
            HabilitacionControles(True)
        End If
    End Sub

    Private Sub SettingCambioEstado()
        LblSelloContabilizado.Text = RecuperarDescripcionEnumerado("enumContabilizado", Me.CurrentRow("Contabilizado"))
        LblSelloContabilizado.Visible = (Me.CurrentRow("Contabilizado") <> enumContabilizado.NoContabilizado)
    End Sub

    Private Sub MntoPagoPer_RecordAdding(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.RecordAdding
        TabLineas.SelectedIndex = 0
        ClearControls()
        TxtDescPago.Focus()
    End Sub

    Private Sub MntoPagoPer_RecordUpdating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.RecordUpdating
        If Length(Me.CurrentRow("IDInmovilizado")) = 0 Then
            ExpertisApp.GenerateMessage("El inmovilizado es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Cancel = True
            Exit Sub
        End If
        If Length(Me.CurrentRow("CCInmovilizadoLargoPlazo")) = 0 Then
            ExpertisApp.GenerateMessage("La Cuenta Contable de Inmov. a Largo Plazo es Obligatoria.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Cancel = True
            Exit Sub
        End If
        If Length(Me.CurrentRow("CCNominal")) = 0 Then
            ExpertisApp.GenerateMessage("La Cuenta Contable Nominal es Obligatoria.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Cancel = True
            Exit Sub
        End If
        If Length(Me.CurrentRow("CCGastoInteres")) = 0 Then
            ExpertisApp.GenerateMessage("La Cuenta Contable de Gastos de Intereses es Obligatoria.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Cancel = True
            Exit Sub
        End If
        If Length(Me.CurrentRow("IDCContable")) = 0 Then
            ExpertisApp.GenerateMessage("La Cuenta Contable es obligatoria.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Cancel = True
            Exit Sub
        End If
    End Sub

    Private Sub MntoPagoPer_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.RecordUpdated
        CargarTotalesForm()
    End Sub

    Private Sub MntoPagoPer_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles MyBase.BusinessCalling
        Select Case e.EntityName
            Case Me.EntityName
                e.Data.Context.Add("CambioA", MDblCambioA)
                e.Data.Context.Add("CambioB", MDblCambioB)
                e.Data.Context.Add("NDecimales", MLngNDecimales)
                e.Data.Context.Add("NDecimalesA", MLngNDecimalesA)
                e.Data.Context.Add("NDecimalesB", MLngNDecimalesB)
                e.Data.Context.Add("TipoIVA", DtTipoIva)
            Case Else
        End Select
    End Sub

    Private Sub MntoPagoPer_BusinessCalled(ByVal sender As Object, ByVal e As Engine.UI.BusinessCalledEventArgs) Handles MyBase.BusinessCalled
        MDblCambioA = e.Data("CambioA")
        MDblCambioB = e.Data("CambioB")
        MLngNDecimales = e.Data("NDecimales")
        MLngNDecimalesA = e.Data("NDecimalesA")
        MLngNDecimalesB = e.Data("NDecimalesB")
        DtTipoIva = e.Data("TipoIVA")
    End Sub

    'Private Sub MntoPagoPer_SetReportDataSource(ByVal sender As Object, ByVal e As Engine.UI.ReportDataSourceEventArgs) Handles MyBase.SetReportDataSource
    '    'Comprobar el Alias cuando se agregue el Nuevo Informe al Manager
    '    If e.Alias = "rptDiferidosMaquinaAño" Then
    '        Dim ClsBE As New BE.DataEngine
    '        Dim DtInfor As DataTable = ClsBE.Filter("vrptDiferidosMaquinaAño", "*", "1=1")
    '        If Not DtInfor Is Nothing AndAlso DtInfor.Rows.Count > 0 Then
    '            Dim DtFinal As DataTable = CalculoAcumulados(DtInfor)
    '            'ap = Nothing
    '            'rs.Filter = "AñoContabilizado =" & mintAño & " AND IdPagoPeriodico = '" & FwEngine1.PrimaryRecordset!ID & "'"
    '            'rcsReportDataSource = CloneRecordset(rs)
    '        Else : e.Cancel = True
    '        End If
    '    End If
    'End Sub

    Private Sub MntoPagoPer_SetReportDataSource(ByVal sender As Object, ByVal e As Engine.UI.ReportDataSourceEventArgs) Handles MyBase.SetReportDataSource
        If e.Alias = "DIMAAN" Then
            Dim ClsBE As New BE.DataEngine
            Dim DtInfor As DataTable = ClsBE.Filter("vrptDiferidosMaquinaAño", "*", "1=1")
            If Not DtInfor Is Nothing AndAlso DtInfor.Rows.Count > 0 Then
                Dim DtFinal As DataTable = CalculoAcumulados(DtInfor)
                Dim dvReport As DataView = DtFinal.DefaultView
                dvReport.RowFilter = "AñoContabilizado =" & mintAño & " AND IdPagoPeriodico = '" & Me.CurrentRow("ID") & "'"
                e.DataSource = dvReport
            Else : e.Cancel = True
            End If
        End If
    End Sub

    Private Sub MntoPagoPer_SetReportSelectionCriteria(ByVal sender As Object, ByVal e As Engine.UI.ReportSelectionCriteriaEventArgs) Handles MyBase.SetReportSelectionCriteria
        'Comprobar y actualizar el Alias del Informe cuando hayamos creado y registrado el nuevo
        'informe en el Manager
        If e.Alias = "INFLEAS" Then
            e.Filter.Add("FechaFin", FilterOperator.GreaterThan, ClbFechaFin.Value, FilterType.DateTime)
        End If
    End Sub

    Private Sub MntoPagoPer_SetReportDesignObjects(ByVal sender As Object, ByVal e As Engine.UI.ReportDesignObjectsEventArgs) Handles MyBase.SetReportDesignObjects
        Dim DTEHoy As Date
        Dim MFrmAñoInf As New FrmAno
        'Comprobar y actualizar el Alias del informe, cuando éste este creado y configurado en el Manager
        If e.Alias = "INFLEAS" Then
            DTEHoy = Today.Date
            e.Formulas("Fecha").Text = DTEHoy
        ElseIf e.Alias = "DIMAAN" Then
            If MFrmAñoInf.LoadFunction = DialogResult.OK Then
                mintAño = MFrmAñoInf.Año
                e.Formulas("Año").Text = MFrmAñoInf.Año
            Else
                e.Cancel = True
            End If
        End If
    End Sub

#End Region

#Region "Eventos DataGrid"

    Private Sub GridPagos_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridPagos.FormattingRow
        With GridPagos
            If e.Row.Cells("Contabilizado").Value = enumContabilizado.NoContabilizado Then
                e.Row.Cells("Contabilizado").ImageIndex = 0
            Else
                e.Row.Cells("Contabilizado").ImageIndex = 1
            End If
        End With
    End Sub

    Private Sub GridPagos_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridPagos.EditingCell
        With GridPagos
            If .GetValue("Contabilizado") <> enumContabilizado.NoContabilizado Then
                e.Cancel = True
            Else
                Select Case e.Column.Key
                    Case "ImpCuota"
                        If Not ChkCuotaFija.Checked AndAlso Not ChkRecCosteFija.Checked Then
                            .Columns(e.Column.Index).EditType = Janus.Windows.GridEX.EditType.TextBox
                            .Columns(e.Column.Index).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                        Else
                            e.Cancel = True
                        End If

                    Case "ImpRecuperacionCoste"
                        If Not ChkRecCosteFija.Checked Then
                            .Columns(e.Column.Index).EditType = Janus.Windows.GridEX.EditType.TextBox
                            .Columns(e.Column.Index).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                        Else
                            e.Cancel = True
                        End If

                    Case "ImpIntereses"
                        If Not ChkCuotaFija.Checked Then
                            .Columns(e.Column.Index).EditType = Janus.Windows.GridEX.EditType.TextBox
                            .Columns(e.Column.Index).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                        Else
                            e.Cancel = True
                        End If

                    Case "FechaVencimiento"
                        .Columns(e.Column.Index).EditType = Janus.Windows.GridEX.EditType.CalendarDropDown

                    Case Else
                        e.Cancel = True
                End Select
            End If
        End With
    End Sub

    Private Sub GridPagos_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles GridPagos.UpdatingCell
        Dim ClsMoneda As New Moneda
        Dim StDatos As New Moneda.DatosObtenerMoneda
        StDatos.IDMoneda = AdvMoneda.Value
        Dim Cambios As MonedaInfo = ExpertisApp.ExecuteTask(Of Moneda.DatosObtenerMoneda, MonedaInfo)(AddressOf Moneda.ObtenerMoneda, StDatos)
        MDblCambioA = Cambios.CambioA
        MLngNDecimalesA = Cambios.NDecimalesImporte : MLngNDecimales = Cambios.NDecimalesImporte
        With GridPagos
            Select Case e.Column.Key
                Case "ImpIntereses"
                    'Comprobamos que no tenga cadena vacia y que el valor sea numerico
                    If Not IsDBNull(e.Value) AndAlso Length(e.Value) > 0 Then
                        If .GetValue("Contabilizado") = enumContabilizado.NoContabilizado Then
                            .SetValue("ImpInteresesA", xRound(Nz(e.Value) * MDblCambioA, MLngNDecimalesA))
                            .SetValue("ImpInteresesB", xRound(Nz(e.Value) * MDblCambioB, MLngNDecimalesB))
                            If Me.ChkRecCosteFija.Checked OrElse (Not ChkCuotaFija.Checked AndAlso Not ChkRecCosteFija.Checked) Then
                                .SetValue("ImpCuota", xRound(e.Value + .GetValue("ImpRecuperacionCoste"), MLngNDecimales))
                                .SetValue("ImpCuotaA", xRound(Nz(.GetValue("ImpCuota") * MDblCambioA, MLngNDecimalesA)))
                                .SetValue("ImpCuotaB", xRound(Nz(.GetValue("ImpCuota") * MDblCambioB, MLngNDecimalesB)))
                            End If
                            e.Value = xRound(Nz(e.Value), MLngNDecimales)
                            If MDblFactorIVA <> 0 Then
                                .SetValue("ImpVencimiento", xRound(.GetValue("ImpCuota") + .GetValue("ImpCuota") * MDblFactorIVA / 100, MLngNDecimales))
                            Else
                                .SetValue("ImpVencimiento", xRound(.GetValue("ImpCuota"), MLngNDecimales))
                            End If
                            .SetValue("ImpVencimientoA", xRound(Nz(.GetValue("ImpVencimiento")) * MDblCambioA, MLngNDecimalesA))
                            .SetValue("ImpVencimientoB", xRound(Nz(.GetValue("ImpVencimiento")) * MDblCambioB, MLngNDecimalesB))
                        Else
                            'No se puede modificar porque ya esta contabilizado
                            ExpertisApp.GenerateMessage("No se puede modificar el importe ni la moneda porque ya está contabilizado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            e.Cancel = True
                        End If
                    Else
                        ExpertisApp.GenerateMessage("El campo es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Case "ImpCuota"
                    'Comprobamos que no tenga cadena vacia y que el valor sea numerico
                    If Not IsDBNull(e.Value) AndAlso Length(e.Value) > 0 Then
                        'Actualizamos ImpInteresesA y ImpInteresesB y las bases imponibles
                        If .GetValue("Contabilizado") = enumContabilizado.NoContabilizado Then
                            .SetValue("ImpCuotaA", xRound(Nz(e.Value * MDblCambioA, MLngNDecimalesA)))
                            .SetValue("ImpCuotaB", xRound(Nz(e.Value * MDblCambioB, MLngNDecimalesB)))
                            If Not ChkCuotaFija.Checked And Not ChkRecCosteFija.Checked Then
                                .SetValue("ImpIntereses", xRound(e.Value - .GetValue("ImpRecuperacionCoste"), MLngNDecimales))
                                .SetValue("ImpInteresesA", xRound(Nz(.GetValue("ImpIntereses")) * MDblCambioA, MLngNDecimalesA))
                                .SetValue("ImpInteresesB", xRound(Nz(.GetValue("ImpIntereses")) * MDblCambioB, MLngNDecimalesB))
                            End If
                            e.Value = xRound(Nz(e.Value), MLngNDecimales)
                            If MDblFactorIVA <> 0 Then
                                .SetValue("ImpVencimiento", xRound(e.Value + e.Value * MDblFactorIVA / 100, MLngNDecimales))
                            Else
                                .SetValue("ImpVencimiento", xRound(e.Value, MLngNDecimales))
                            End If
                            .SetValue("ImpVencimientoA", xRound(Nz(.GetValue("ImpVencimiento")) * MDblCambioA, MLngNDecimalesA))
                            .SetValue("ImpVencimientoB", xRound(Nz(.GetValue("ImpVencimiento")) * MDblCambioB, MLngNDecimalesB))
                        Else
                            'No se puede modificar porque ya esta contabilizado
                            ExpertisApp.GenerateMessage("No se puede modificar el importe ni la moneda porque ya está contabilizado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            e.Cancel = True
                        End If
                    Else
                        ExpertisApp.GenerateMessage("El campo es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If

                Case "ImpRecuperacionCoste"
                    'Comprobamos que no tenga cadena vacia y que el valor sea numerico
                    If Not IsDBNull(e.Value) AndAlso Length(e.Value) > 0 Then
                        'Actualizamos ImpInteresesA y ImpInteresesB y las bases imponibles
                        If .GetValue("Contabilizado") = enumContabilizado.NoContabilizado Then
                            .SetValue("ImpRecuperacionCosteA", xRound(Nz(e.Value) * MDblCambioA, MLngNDecimalesA))
                            .SetValue("ImpRecuperacionCosteB", xRound(Nz(e.Value) * MDblCambioB, MLngNDecimalesB))
                            If ChkRecCosteFija.Checked OrElse (Not ChkRecCosteFija.Checked AndAlso Not ChkCuotaFija.Checked) Then
                                .SetValue("ImpCuota", xRound(.GetValue("ImpIntereses") + e.Value, MLngNDecimales))
                                .SetValue("ImpCuotaA", xRound(Nz(.GetValue("ImpCuota")) * MDblCambioA, MLngNDecimalesA))
                                .SetValue("ImpCuotaB", xRound(Nz(.GetValue("ImpCuota")) * MDblCambioB, MLngNDecimalesB))
                            ElseIf ChkCuotaFija.Checked Then
                                .SetValue("ImpIntereses", xRound(.GetValue("ImpCuota") - e.Value, MLngNDecimales))
                                .SetValue("ImpInteresesA", xRound(Nz(.GetValue("ImpIntereses")) * MDblCambioA, MLngNDecimalesA))
                                .SetValue("ImpInteresesB", xRound(Nz(.GetValue("ImpIntereses")) * MDblCambioB, MLngNDecimalesB))
                            End If
                            e.Value = xRound(Nz(e.Value), MLngNDecimales)
                            If MDblFactorIVA <> 0 Then
                                .SetValue("ImpVencimiento", xRound(.GetValue("ImpCuota") + .GetValue("ImpCuota") * MDblFactorIVA / 100, MLngNDecimales))
                            Else
                                .SetValue("ImpVencimiento", xRound(.GetValue("ImpCuota"), MLngNDecimales))
                            End If
                            .SetValue("ImpVencimientoA", xRound(Nz(.GetValue("ImpVencimiento")) * MDblCambioA, MLngNDecimalesA))
                            .SetValue("ImpVencimientoB", xRound(Nz(.GetValue("ImpVencimiento")) * MDblCambioB, MLngNDecimalesB))
                        Else
                            'No se puede modificar porque ya esta contabilizado
                            ExpertisApp.GenerateMessage("No se puede modificar el importe ni la moneda porque ya está contabilizado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            e.Cancel = True
                        End If
                    Else
                        ExpertisApp.GenerateMessage("El campo es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
            End Select
        End With
    End Sub

    'Private Sub jngAnticipadoDiferido_RowFormat(ByVal RowBuffer As GridEX20.JSRowData)
    '    With jngAnticipadoDiferido
    '        '        If RowBuffer.Value(.Columns("Anticipado").Index) <> 0 Then
    '        '            RowBuffer.CellStyle(.Columns("Impuesto").Index) = "FwNegativo"
    '        '            RowBuffer.DisplayValue(.Columns("Impuesto").Index) = Format(Abs(RowBuffer.Value(.Columns("Impuesto").Index)), "Standard")
    '        '        Else
    '        '            RowBuffer.DisplayValue(.Columns("Impuesto").Index) = Format(RowBuffer.Value(.Columns("Impuesto").Index), "Standard")
    '        '        End If
    '    End With
    'End Sub

#End Region

#Region "Eventos AdvSearch"

    Private Sub AdvGastosporIntereses_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvDeudaLeasLargo.SetPredefinedFilter, AdvDeudaLeasCorto.SetPredefinedFilter, AdvCosteBien.SetPredefinedFilter, AdvGastosporIntereses.SetPredefinedFilter
        FiltroCuentasLeasing(e)
    End Sub

    Private Sub AdvInmovilizado_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvInmovilizado.Validated
        Dim DblValorResi, DblValorResiATemp, DblValorResiBTemp As Double
        If Length(AdvInmovilizado.Value & String.Empty) > 0 Then
            Dim ClsInmov As New Inmovilizado
            Dim DtInmov As DataTable = ClsInmov.SelOnPrimaryKey(AdvInmovilizado.Value)
            If Not DtInmov Is Nothing AndAlso DtInmov.Rows.Count > 0 Then
                ClbFechaContrato.Value = DtInmov.Rows(0)("FechaInmovilizado")
                If ExpertisApp.GenerateMessage("¿Desea continuar con el cálculo del Valor Residual?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Me.Cursor = Windows.Forms.Cursors.WaitCursor
                    Dim ClsElemAmort As New ElementoAmortizable
                    Dim DtElemAmort As DataTable = ClsElemAmort.Filter(New FilterItem("IDInmovilizado", FilterOperator.Equal, DtInmov.Rows(0)("IDInmovilizado"), FilterType.String))
                    If Not DtElemAmort Is Nothing AndAlso DtElemAmort.Rows.Count > 0 Then
                        For Each Dr As DataRow In DtElemAmort.Select
                            DblValorResiATemp += Dr("ValorResidualA")
                            DblValorResiBTemp += Dr("ValorResidualB")
                        Next
                        MDblValorResiA = DblValorResiATemp
                        MDblValorResiB = DblValorResiBTemp
                        If Length(AdvMoneda.Value & String.Empty) > 0 Then
                            Dim ClsMoneda As New Moneda
                            Dim DtMoneda As DataTable = ClsMoneda.SelOnPrimaryKey(AdvMoneda.Value)
                            If Not DtMoneda Is Nothing AndAlso DtMoneda.Rows.Count > 0 Then
                                DblValorResi = DtMoneda.Rows(0)("CambioA") * DblValorResiATemp
                                NtbValorResidual.Value = DblValorResi
                            End If
                        End If
                    End If
                    Me.Cursor = Windows.Forms.Cursors.Default
                End If
            End If
        End If
        RefreshElementosInmovilizado()
        CargarTotalesInmovilizado()
    End Sub

    Private Sub AdvTipoIVA_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvTipoIVA.Validated
        If Not AdvTipoIVA.SelectedRow Is Nothing Then
            MDblFactorIVA = AdvTipoIVA.SelectedRow("Factor")
        Else
            MDblFactorIVA = 0
        End If
        If Me.RecordsState <> RecordsState.Saved Then
            ActualizarImporteConIVA()
            ActualizarDescripcionFactorIVA()
        End If
    End Sub

    Private Sub AdvCosteBien_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvDeudaLeasLargo.Validated, AdvDeudaLeasCorto.Validated, AdvCosteBien.Validated, AdvGastosporIntereses.Validated
        If sender.text <> String.Empty Then ComprobarCuenta(sender)
    End Sub

    Private Sub AdvCosteBien_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvDeudaLeasLargo.Leave, AdvDeudaLeasCorto.Leave, AdvCosteBien.Leave, AdvGastosporIntereses.Leave
        sender.Text = PuntoPorCero(sender.Text, IntDigitosAuxiliar, StrEjerAct)
        AdvCosteBien_Validated(sender, e)
    End Sub

#End Region

#Region "Eventos NumericTextBox"

    Private Sub NtbAportInicial_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles NtbAportInicial.Validated
        If Length(NtbAportInicial.Value & String.Empty) > 0 Then
            If NtbAportInicial.Value > CDbl(NtbImpNetoFinanciar.Value) Then
                ExpertisApp.GenerateMessage("La Aportación Inicial no puede superar el Importe Neto a Financiar.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                NtbAportInicial.Value = 0
            End If
        End If
    End Sub

    Private Sub NtbValorResidual_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles NtbValorResidual.Validated
        If Length(NtbValorResidual.Value) > 0 AndAlso NtbValorResidual.Value <> 0 Then
            If Length(AdvMoneda.Value & String.Empty) > 0 Then
                Dim ClsMoneda As New Moneda
                Dim DtMoneda As DataTable = ClsMoneda.SelOnPrimaryKey(AdvMoneda.Value)
                If Not DtMoneda Is Nothing AndAlso DtMoneda.Rows.Count > 0 Then
                    MDblValorResiA = DtMoneda.Rows(0)("CambioA") * NtbValorResidual.Value
                    MDblValorResiB = DtMoneda.Rows(0)("CambioB") * NtbValorResidual.Value
                End If
            End If
        End If
    End Sub

    Private Sub NtbInteresPeriodo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles NtbInteresPeriodo.Validated
        Dim ClsMoneda As New Moneda
        Dim DtMonedaA As DataTable = ExpertisApp.ExecuteTask(Of Object, DataTable)(AddressOf Moneda.ObtenerMonedaA, New Object)
        If Length(NtbInteresPeriodo.Value) Then NtbInteresPeriodo.Value = xRound(NtbInteresPeriodo.Value, DtMonedaA.Rows(0)("NDecimalesImp"))
        If Me.RecordsState <> RecordsState.Saved Then
            ActualizarImporteConIVA()
            NtbCuotaPeriodo.Value = Nz(NtbRecupCostePeriodo.Value) + Nz(NtbInteresPeriodo.Value)
        End If
    End Sub

    Private Sub NtbRecupCostePeriodo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles NtbRecupCostePeriodo.Validated
        Dim ClsMoneda As New Moneda
        Dim DtMonedaA As DataTable = ExpertisApp.ExecuteTask(Of Object, DataTable)(AddressOf Moneda.ObtenerMonedaA, New Object)
        If Length(NtbRecupCostePeriodo.Value) Then NtbRecupCostePeriodo.Value = xRound(NtbRecupCostePeriodo.Value, DtMonedaA.Rows(0)("NDecimalesImp"))
        If Me.RecordsState <> RecordsState.Saved Then
            ActualizarImporteConIVA()
            NtbCuotaPeriodo.Value = Nz(NtbRecupCostePeriodo.Value) + Nz(NtbInteresPeriodo.Value)
        End If
    End Sub

    Private Sub NtbCuotaPeriodo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles NtbCuotaPeriodo.Validated
        If Me.RecordsState <> RecordsState.Saved Then
            ActualizarImporteConIVA()
        End If
        Dim ClsMoneda As New Moneda
        Dim DtMonedaA As DataTable = ExpertisApp.ExecuteTask(Of Object, DataTable)(AddressOf Moneda.ObtenerMonedaA, New Object)
        If Length(NtbCuotaPeriodo.Value) > 0 Then NtbCuotaPeriodo.Value = xRound(NtbCuotaPeriodo.Value, DtMonedaA.Rows(0)("NDecimalesImp"))
    End Sub

    Private Sub NtbRecupCoste_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles NtbRecupCoste.Validated
        If Me.RecordsState <> RecordsState.Saved Then ActualizarImporteTotalConIVA()
    End Sub

    Private Sub NtbImpIntereses_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles NtbImpIntereses.Validated
        If Me.RecordsState <> RecordsState.Saved Then ActualizarImporteTotalConIVA()
    End Sub

    Private Sub NtbTipoInteres_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles NtbTipoInteres.Validated
        If Not IsNumeric(NtbTipoInteres.Text) Then NtbTipoInteres.Text = 0
    End Sub

    Private Sub NtbTipoInteresAplicado_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles NtbTipoInteresAplicado.Validated
        If Not IsNumeric(NtbTipoInteresAplicado.Text) Then NtbTipoInteresAplicado.Text = 0
    End Sub

#End Region

#Region "Eventos ComboBox"

    Private Sub CmbFilContabilizado_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbFilContabilizado.Validated
        If CmbFilContabilizado.Value Is Nothing Then CmbFilContabilizado.Value = enumBoolean.Todos
    End Sub

#End Region

#Region "Eventos CalendarBox"

    Private Sub ClbVencHasta_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClbVencHasta.Validated
        If Not IsDBNull(ClbVencHasta.Value) AndAlso Not IsDBNull(ClbVencDesde.Value) Then
            If ClbVencHasta.Value < ClbVencDesde.Value Then ClbVencDesde.Value = ClbVencHasta.Value
        End If
    End Sub

    Private Sub ClbVencDesde_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClbVencDesde.Validated
        If Not IsDBNull(ClbVencDesde.Value) Then
            If IsDBNull(ClbVencHasta.Value) Then
                ClbVencHasta.Value = ClbVencDesde.Value
            ElseIf ClbVencDesde.Value > ClbVencHasta.Value Then
                ClbVencHasta.Value = ClbVencDesde.Value
            End If
        End If
    End Sub

#End Region

#Region "Eventos CheckBox"

    Private Sub ChkVResidualCuota_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkVResidualCuota.CheckedChanged
        If ChkVResidualCuota.Checked Then
            NtbValorResidual.Enabled = False
            NtbValorResidual.Value = 0
            MDblValorResiA = 0
            MDblValorResiB = 0
        Else
            NtbValorResidual.Enabled = True
        End If
        NtbValorResidual.Enabled = IIf(Not ChkVResidualCuota.Checked, True, False)
    End Sub

    Private Sub ChkCuotaFija_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkCuotaFija.CheckedChanged
        If ChkCuotaFija.Checked Then ChkRecCosteFija.Checked = False
    End Sub

    Private Sub ChkRecCosteFija_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkRecCosteFija.CheckedChanged
        If ChkRecCosteFija.Checked Then ChkCuotaFija.Checked = False
    End Sub

#End Region

#Region "Eventos TabControl"

    Private Sub TabLineas_SelectedTabChanged(ByVal sender As Object, ByVal e As Janus.Windows.UI.Tab.TabEventArgs) Handles TabLineas.SelectedTabChanged
        If Me.RecordsState = RecordsState.Saved Then
            RefreshElementosInmovilizado()
            ActDesactAccionCambio()
            ComprobarFiltros()
        End If
    End Sub

#End Region

#End Region


    Private Sub AdvTipoPago_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvTipoPago.SetPredefinedFilter
        e.Filter.Add(New BooleanFilterItem("LeasingSN", True))
    End Sub

End Class