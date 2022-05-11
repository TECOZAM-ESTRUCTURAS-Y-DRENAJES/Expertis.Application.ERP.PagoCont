Imports Solmicro.Expertis.Business.Negocio

Public Class frmSinElementosAmort
    Inherits Solmicro.Expertis.Engine.UI.FormBase

#Region "Propiedades"
    Private obPagos As Object
    Public WriteOnly Property Pagos() As Object
        Set(ByVal Value As Object)
            obPagos = Value
        End Set
    End Property

#End Region
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
    Friend WithEvents Grid1 As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents Button1 As Solmicro.Expertis.Engine.UI.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Grid1 = New Solmicro.Expertis.Engine.UI.Grid
        Me.Button1 = New Solmicro.Expertis.Engine.UI.Button
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid1
        '
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""Id""><Caption" & _
        ">Id Pago Periódico</Caption><DataMember>Id</DataMember><Key>Id</Key><Position>0<" & _
        "/Position><Width>150</Width></Column0><Column1 ID=""DescPago""><Caption>Desc.Pago " & _
        "Periódico</Caption><DataMember>DescPago</DataMember><Key>DescPago</Key><Position" & _
        ">1</Position><Width>150</Width></Column1><Column2 ID=""FechaInicio""><Caption>Fech" & _
        "aInicio</Caption><DataMember>FechaInicio</DataMember><DefaultGroupFormatString>d" & _
        "</DefaultGroupFormatString><EditType>CalendarCombo</EditType><Key>FechaInicio</K" & _
        "ey><Position>2</Position><Visible>False</Visible></Column2><Column3 ID=""FechaFin" & _
        """><Caption>FechaFin</Caption><DataMember>FechaFin</DataMember><DefaultGroupForma" & _
        "tString>d</DefaultGroupFormatString><EditType>CalendarCombo</EditType><Key>Fecha" & _
        "Fin</Key><Position>3</Position><Visible>False</Visible></Column3><Column4 ID=""Un" & _
        "idad""><Caption>Unidad</Caption><DataMember>Unidad</DataMember><Key>Unidad</Key><" & _
        "Position>4</Position><Visible>False</Visible></Column4><Column5 ID=""Periodo""><Ca" & _
        "ption>Periodo</Caption><DataMember>Periodo</DataMember><Key>Periodo</Key><Positi" & _
        "on>5</Position><Visible>False</Visible></Column5><Column6 ID=""IdCContable""><Capt" & _
        "ion>IdCContable</Caption><DataMember>IdCContable</DataMember><Key>IdCContable</K" & _
        "ey><Position>6</Position><Visible>False</Visible></Column6><Column7 ID=""IDProvee" & _
        "dor""><Caption>IDProveedor</Caption><DataMember>IDProveedor</DataMember><Key>IDPr" & _
        "oveedor</Key><Position>7</Position><Visible>False</Visible></Column7><Column8 ID" & _
        "=""IdTipoPago""><Caption>IdTipoPago</Caption><DataMember>IdTipoPago</DataMember><K" & _
        "ey>IdTipoPago</Key><Position>8</Position><Visible>False</Visible></Column8><Colu" & _
        "mn9 ID=""IdFormaPago""><Caption>IdFormaPago</Caption><DataMember>IdFormaPago</Data" & _
        "Member><Key>IdFormaPago</Key><Position>9</Position><Visible>False</Visible></Col" & _
        "umn9><Column10 ID=""IdBancoPropio""><Caption>IdBancoPropio</Caption><DataMember>Id" & _
        "BancoPropio</DataMember><Key>IdBancoPropio</Key><Position>10</Position><Visible>" & _
        "False</Visible></Column10><Column11 ID=""IdMoneda""><Caption>IdMoneda</Caption><Da" & _
        "taMember>IdMoneda</DataMember><Key>IdMoneda</Key><Position>11</Position><Visible" & _
        ">False</Visible></Column11><Column12 ID=""Importe""><Caption>Importe</Caption><Dat" & _
        "aMember>Importe</DataMember><Key>Importe</Key><Position>12</Position><TextAlignm" & _
        "ent>Far</TextAlignment><Visible>False</Visible></Column12><Column13 ID=""FechaUlt" & _
        "imaActualizacion""><Caption>FechaUltimaActualizacion</Caption><DataMember>FechaUl" & _
        "timaActualizacion</DataMember><DefaultGroupFormatString>d</DefaultGroupFormatStr" & _
        "ing><EditType>CalendarCombo</EditType><Key>FechaUltimaActualizacion</Key><Positi" & _
        "on>13</Position><Visible>False</Visible></Column13><Column14 ID=""IDArticulo""><Ca" & _
        "ption>IDArticulo</Caption><DataMember>IDArticulo</DataMember><Key>IDArticulo</Ke" & _
        "y><Position>14</Position><Visible>False</Visible></Column14><Column15 ID=""IDTipo" & _
        "IVA""><Caption>IDTipoIVA</Caption><DataMember>IDTipoIVA</DataMember><Key>IDTipoIV" & _
        "A</Key><Position>15</Position><Visible>False</Visible></Column15><Column16 ID=""I" & _
        "mpRecuperacionCoste""><Caption>ImpRecuperacionCoste</Caption><DataMember>ImpRecup" & _
        "eracionCoste</DataMember><Key>ImpRecuperacionCoste</Key><Position>16</Position><" & _
        "TextAlignment>Far</TextAlignment><Visible>False</Visible></Column16><Column17 ID" & _
        "=""CCNominal""><Caption>CCNominal</Caption><DataMember>CCNominal</DataMember><Key>" & _
        "CCNominal</Key><Position>17</Position><Visible>False</Visible></Column17><Column" & _
        "18 ID=""ImpInteresesTotal""><Caption>ImpInteresesTotal</Caption><DataMember>ImpInt" & _
        "eresesTotal</DataMember><Key>ImpInteresesTotal</Key><Position>18</Position><Text" & _
        "Alignment>Far</TextAlignment><Visible>False</Visible></Column18><Column19 ID=""CC" & _
        "Intereses""><Caption>CCIntereses</Caption><DataMember>CCIntereses</DataMember><Ke" & _
        "y>CCIntereses</Key><Position>19</Position><Visible>False</Visible></Column19><Co" & _
        "lumn20 ID=""ImpIVAOperacion""><Caption>ImpIVAOperacion</Caption><DataMember>ImpIVA" & _
        "Operacion</DataMember><Key>ImpIVAOperacion</Key><Position>20</Position><TextAlig" & _
        "nment>Far</TextAlignment><Visible>False</Visible></Column20><Column21 ID=""ImpCor" & _
        "toPlazoDeuda""><Caption>ImpCortoPlazoDeuda</Caption><DataMember>ImpCortoPlazoDeud" & _
        "a</DataMember><Key>ImpCortoPlazoDeuda</Key><Position>21</Position><TextAlignment" & _
        ">Far</TextAlignment><Visible>False</Visible></Column21><Column22 ID=""ImpRecupera" & _
        "cionCostePeriodo""><Caption>ImpRecuperacionCostePeriodo</Caption><DataMember>ImpR" & _
        "ecuperacionCostePeriodo</DataMember><Key>ImpRecuperacionCostePeriodo</Key><Posit" & _
        "ion>22</Position><TextAlignment>Far</TextAlignment><Visible>False</Visible></Col" & _
        "umn22><Column23 ID=""ImpInteresPeriodo""><Caption>ImpInteresPeriodo</Caption><Data" & _
        "Member>ImpInteresPeriodo</DataMember><Key>ImpInteresPeriodo</Key><Position>23</P" & _
        "osition><TextAlignment>Far</TextAlignment><Visible>False</Visible></Column23><Co" & _
        "lumn24 ID=""CCGastoInteres""><Caption>CCGastoInteres</Caption><DataMember>CCGastoI" & _
        "nteres</DataMember><Key>CCGastoInteres</Key><Position>24</Position><Visible>Fals" & _
        "e</Visible></Column24><Column25 ID=""IDInmovilizado""><Caption>Inmovilizado</Capti" & _
        "on><DataMember>IDInmovilizado</DataMember><Key>IDInmovilizado</Key><Position>25<" & _
        "/Position><Width>150</Width></Column25><Column26 ID=""Contabilizado""><Caption>Con" & _
        "tabilizado</Caption><ColumnType>CheckBox</ColumnType><DataMember>Contabilizado</" & _
        "DataMember><EditType>CheckBox</EditType><Key>Contabilizado</Key><Position>26</Po" & _
        "sition><Visible>False</Visible></Column26><Column27 ID=""ImpCuotaPeriodo""><Captio" & _
        "n>ImpCuotaPeriodo</Caption><DataMember>ImpCuotaPeriodo</DataMember><Key>ImpCuota" & _
        "Periodo</Key><Position>27</Position><TextAlignment>Far</TextAlignment><Visible>F" & _
        "alse</Visible></Column27><Column28 ID=""FechaUltimaRevision""><Caption>FechaUltima" & _
        "Revision</Caption><DataMember>FechaUltimaRevision</DataMember><DefaultGroupForma" & _
        "tString>d</DefaultGroupFormatString><EditType>CalendarCombo</EditType><Key>Fecha" & _
        "UltimaRevision</Key><Position>28</Position><Visible>False</Visible></Column28><C" & _
        "olumn29 ID=""NOperacion""><Caption>NOperacion</Caption><DataMember>NOperacion</Dat" & _
        "aMember><Key>NOperacion</Key><Position>29</Position><Visible>False</Visible></Co" & _
        "lumn29><Column30 ID=""CuotaFija""><Caption>CuotaFija</Caption><ColumnType>CheckBox" & _
        "</ColumnType><DataMember>CuotaFija</DataMember><EditType>CheckBox</EditType><Key" & _
        ">CuotaFija</Key><Position>30</Position><Visible>False</Visible></Column30><Colum" & _
        "n31 ID=""RecuperacionFija""><Caption>RecuperacionFija</Caption><ColumnType>CheckBo" & _
        "x</ColumnType><DataMember>RecuperacionFija</DataMember><EditType>CheckBox</EditT" & _
        "ype><Key>RecuperacionFija</Key><Position>31</Position><Visible>False</Visible></" & _
        "Column31><Column32 ID=""FechaContrato""><Caption>FechaContrato</Caption><DataMembe" & _
        "r>FechaContrato</DataMember><DefaultGroupFormatString>d</DefaultGroupFormatStrin" & _
        "g><EditType>CalendarCombo</EditType><Key>FechaContrato</Key><Position>32</Positi" & _
        "on><Visible>False</Visible></Column32><Column33 ID=""OpcionCompra""><Caption>Opcio" & _
        "nCompra</Caption><DataMember>OpcionCompra</DataMember><Key>OpcionCompra</Key><Po" & _
        "sition>33</Position><TextAlignment>Far</TextAlignment><Visible>False</Visible></" & _
        "Column33><Column34 ID=""CCInmovilizadoLargoPlazo""><Caption>CCInmovilizadoLargoPla" & _
        "zo</Caption><DataMember>CCInmovilizadoLargoPlazo</DataMember><Key>CCInmovilizado" & _
        "LargoPlazo</Key><Position>34</Position><Visible>False</Visible></Column34><Colum" & _
        "n35 ID=""CCInmovilizadoCortoPlazo""><Caption>CCInmovilizadoCortoPlazo</Caption><Da" & _
        "taMember>CCInmovilizadoCortoPlazo</DataMember><Key>CCInmovilizadoCortoPlazo</Key" & _
        "><Position>35</Position><Visible>False</Visible></Column35><Column36 ID=""IDFactu" & _
        "ra""><Caption>IDFactura</Caption><DataMember>IDFactura</DataMember><Key>IDFactura" & _
        "</Key><Position>36</Position><Visible>False</Visible></Column36><Column37 ID=""Fe" & _
        "chaCreacionAudi""><Caption>FechaCreacionAudi</Caption><DataMember>FechaCreacionAu" & _
        "di</DataMember><DefaultGroupFormatString>d</DefaultGroupFormatString><EditType>C" & _
        "alendarCombo</EditType><Key>FechaCreacionAudi</Key><Position>37</Position><Visib" & _
        "le>False</Visible></Column37><Column38 ID=""FechaModificacionAudi""><Caption>Fecha" & _
        "ModificacionAudi</Caption><DataMember>FechaModificacionAudi</DataMember><Default" & _
        "GroupFormatString>d</DefaultGroupFormatString><EditType>CalendarCombo</EditType>" & _
        "<Key>FechaModificacionAudi</Key><Position>38</Position><Visible>False</Visible><" & _
        "/Column38><Column39 ID=""UsuarioAudi""><Caption>UsuarioAudi</Caption><DataMember>U" & _
        "suarioAudi</DataMember><Key>UsuarioAudi</Key><Position>39</Position><Visible>Fal" & _
        "se</Visible></Column39><Column40 ID=""NoCalcularImpuesto""><Caption>NoCalcularImpu" & _
        "esto</Caption><ColumnType>CheckBox</ColumnType><DataMember>NoCalcularImpuesto</D" & _
        "ataMember><EditType>CheckBox</EditType><Key>NoCalcularImpuesto</Key><Position>40" & _
        "</Position><Visible>False</Visible></Column40><Column41 ID=""CodProveedor""><Capti" & _
        "on>CodProveedor</Caption><DataMember>CodProveedor</DataMember><Key>CodProveedor<" & _
        "/Key><Position>41</Position><Visible>False</Visible></Column41><Column42 ID=""Imp" & _
        "NetoNominal""><Caption>ImpNetoNominal</Caption><DataMember>ImpNetoNominal</DataMe" & _
        "mber><Key>ImpNetoNominal</Key><Position>42</Position><TextAlignment>Far</TextAli" & _
        "gnment><Visible>False</Visible></Column42><Column43 ID=""ImpAmortizacionPeriodo"">" & _
        "<Caption>ImpAmortizacionPeriodo</Caption><DataMember>ImpAmortizacionPeriodo</Dat" & _
        "aMember><Key>ImpAmortizacionPeriodo</Key><Position>43</Position><TextAlignment>F" & _
        "ar</TextAlignment><Visible>False</Visible></Column43><Column44 ID=""CCInteresesTo" & _
        "tal""><Caption>CCInteresesTotal</Caption><DataMember>CCInteresesTotal</DataMember" & _
        "><Key>CCInteresesTotal</Key><Position>44</Position><Visible>False</Visible></Col" & _
        "umn44><Column45 ID=""ValorResidual""><Caption>ValorResidual</Caption><DataMember>V" & _
        "alorResidual</DataMember><Key>ValorResidual</Key><Position>45</Position><TextAli" & _
        "gnment>Far</TextAlignment><Visible>False</Visible></Column45><Column46 ID=""Valor" & _
        "ResidualA""><Caption>ValorResidualA</Caption><DataMember>ValorResidualA</DataMemb" & _
        "er><Key>ValorResidualA</Key><Position>46</Position><TextAlignment>Far</TextAlign" & _
        "ment><Visible>False</Visible></Column46><Column47 ID=""ValorResidualB""><Caption>V" & _
        "alorResidualB</Caption><DataMember>ValorResidualB</DataMember><Key>ValorResidual" & _
        "B</Key><Position>47</Position><TextAlignment>Far</TextAlignment><Visible>False</" & _
        "Visible></Column47><Column48 ID=""BaseCalculo""><Caption>BaseCalculo</Caption><Dat" & _
        "aMember>BaseCalculo</DataMember><Key>BaseCalculo</Key><Position>48</Position><Vi" & _
        "sible>False</Visible></Column48><Column49 ID=""TipoInteres""><Caption>TipoInteres<" & _
        "/Caption><DataMember>TipoInteres</DataMember><Key>TipoInteres</Key><Position>49<" & _
        "/Position><TextAlignment>Far</TextAlignment><Visible>False</Visible></Column49><" & _
        "Column50 ID=""TipoInteresAplicado""><Caption>TipoInteresAplicado</Caption><DataMem" & _
        "ber>TipoInteresAplicado</DataMember><Key>TipoInteresAplicado</Key><Position>50</" & _
        "Position><TextAlignment>Far</TextAlignment><Visible>False</Visible></Column50><C" & _
        "olumn51 ID=""ValorResidualIgualCuota""><Caption>ValorResidualIgualCuota</Caption><" & _
        "ColumnType>CheckBox</ColumnType><DataMember>ValorResidualIgualCuota</DataMember>" & _
        "<EditType>CheckBox</EditType><Key>ValorResidualIgualCuota</Key><Position>51</Pos" & _
        "ition><Visible>False</Visible></Column51><Column52 ID=""NTotalCuotas""><Caption>NT" & _
        "otalCuotas</Caption><DataMember>NTotalCuotas</DataMember><Key>NTotalCuotas</Key>" & _
        "<Position>52</Position><TextAlignment>Far</TextAlignment><Visible>False</Visible" & _
        "></Column52><Column53 ID=""NCuotasCarencia""><Caption>NCuotasCarencia</Caption><Da" & _
        "taMember>NCuotasCarencia</DataMember><Key>NCuotasCarencia</Key><Position>53</Pos" & _
        "ition><TextAlignment>Far</TextAlignment><Visible>False</Visible></Column53><Colu" & _
        "mn54 ID=""NPagosAlAño""><Caption>NPagosAlAño</Caption><DataMember>NPagosAlAño</Dat" & _
        "aMember><Key>NPagosAlAño</Key><Position>54</Position><TextAlignment>Far</TextAli" & _
        "gnment><Visible>False</Visible></Column54><Column55 ID=""CuotasAutomatica""><Capti" & _
        "on>CuotasAutomatica</Caption><ColumnType>CheckBox</ColumnType><DataMember>Cuotas" & _
        "Automatica</DataMember><EditType>CheckBox</EditType><Key>CuotasAutomatica</Key><" & _
        "Position>55</Position><Visible>False</Visible></Column55><Column56 ID=""PagoInter" & _
        "eses""><Caption>PagoIntereses</Caption><ColumnType>CheckBox</ColumnType><DataMemb" & _
        "er>PagoIntereses</DataMember><EditType>CheckBox</EditType><Key>PagoIntereses</Ke" & _
        "y><Position>56</Position><Visible>False</Visible></Column56><Column57 ID=""Aporta" & _
        "cionInicial""><Caption>AportacionInicial</Caption><DataMember>AportacionInicial</" & _
        "DataMember><Key>AportacionInicial</Key><Position>57</Position><TextAlignment>Far" & _
        "</TextAlignment><Visible>False</Visible></Column57><Column58 ID=""FechaRecalculoC" & _
        "P""><Caption>FechaRecalculoCP</Caption><DataMember>FechaRecalculoCP</DataMember><" & _
        "DefaultGroupFormatString>d</DefaultGroupFormatString><EditType>CalendarCombo</Ed" & _
        "itType><Key>FechaRecalculoCP</Key><Position>58</Position><Visible>False</Visible" & _
        "></Column58><Column59 ID=""CarenciaConIntereses""><Caption>CarenciaConIntereses</C" & _
        "aption><ColumnType>CheckBox</ColumnType><DataMember>CarenciaConIntereses</DataMe" & _
        "mber><EditType>CheckBox</EditType><Key>CarenciaConIntereses</Key><Position>59</P" & _
        "osition><Visible>False</Visible></Column59></Columns><GroupCondition ID="""" /></R" & _
        "ootTable></GridEXLayoutData>"
        Me.Grid1.DesignTimeLayout = GridEXLayout1
        Me.Grid1.EntityName = "PagoPeriodico"
        Me.Grid1.Location = New System.Drawing.Point(0, 8)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.PrimaryDataFields = Nothing
        Me.Grid1.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.Grid1.SecondaryDataFields = Nothing
        Me.Grid1.Size = New System.Drawing.Size(480, 192)
        Me.Grid1.TabIndex = 0
        Me.Grid1.ViewName = "tbPagoPeriodico"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(336, 208)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Salir"
        '
        'frmSinElementosAmort
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(488, 253)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Grid1)
        Me.Name = "frmSinElementosAmort"
        Me.Text = "Leasings con inmovilizado sin elementos amortizables"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Eventos"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmSinElementosAmort_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim FwnPagoPeriodico As New PagoPeriodico
        Dim filtro As New Filter

        'If length(StrListPagosPer) > 0 Then
        If obPagos.Length > 0 Then
            Dim FilPagosPer As New Filter
            FilPagosPer.Add(New InListFilterItem("ID", obPagos, FilterType.Numeric))
            Dim dtPagoPeriodico As DataTable = FwnPagoPeriodico.Filter(FilPagosPer)
            If Not IsNothing(dtPagoPeriodico) AndAlso dtPagoPeriodico.Rows.Count > 0 Then
                Grid1.DataSource = dtPagoPeriodico
                Grid1.Refresh()
            End If
        End If
    End Sub
#End Region
End Class
