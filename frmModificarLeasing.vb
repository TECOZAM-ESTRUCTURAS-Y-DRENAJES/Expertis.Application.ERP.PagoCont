Imports Solmicro.Expertis.Business.General

Public Class frmModificarLeasing
    Inherits Solmicro.Expertis.Engine.UI.FormBase
#Region "Variables"

    Private mlngNDecimalesA As Long
    Private mlngNDecimalesB As Long

#End Region


#Region "Propiedades"
    Private mlngIdPagoPeriodico As Long
    Public WriteOnly Property IDPagoPeriodico() As Long
        Set(ByVal Value As Long)
            mlngIdPagoPeriodico = Value
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
    Friend WithEvents jngPagos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents cmbCancel As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbOK As Solmicro.Expertis.Engine.UI.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmModificarLeasing))
        Me.jngPagos = New Solmicro.Expertis.Engine.UI.Grid
        Me.cmbCancel = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbOK = New Solmicro.Expertis.Engine.UI.Button
        CType(Me.jngPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'jngPagos
        '
        Me.jngPagos.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDMoneda", "Moneda", "IDMoneda")})
        Me.jngPagos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False
        Me.jngPagos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""Titulo""><Cap" & _
        "tion>Titulo</Caption><DataMember>Titulo</DataMember><Key>Titulo</Key><Position>0" & _
        "</Position><TextAlignment>Near</TextAlignment><Width>133</Width></Column0><Colum" & _
        "n1 ID=""IDPago""><Caption>IDPago</Caption><DataMember>IDPago</DataMember><Key>IDPa" & _
        "go</Key><Position>1</Position><TextAlignment>Far</TextAlignment><Visible>False</" & _
        "Visible></Column1><Column2 ID=""IDFormaPago""><Caption>F. Pago</Caption><DataMembe" & _
        "r>IDFormaPago</DataMember><Key>IDFormaPago</Key><Position>2</Position><TextAlign" & _
        "ment>Near</TextAlignment><Visible>False</Visible><Width>53</Width></Column2><Col" & _
        "umn3 ID=""FechaVencimiento""><Caption>Fecha Vto.</Caption><DataMember>FechaVencimi" & _
        "ento</DataMember><EditType>CalendarDropDown</EditType><Key>FechaVencimiento</Key" & _
        "><Position>3</Position><TextAlignment>Near</TextAlignment><Width>80</Width></Col" & _
        "umn3><Column4 ID=""ImpRecuperacionCoste""><Caption>Recuperación Coste</Caption><Da" & _
        "taMember>ImpRecuperacionCoste</DataMember><EditType>NoEdit</EditType><Key>ImpRec" & _
        "uperacionCoste</Key><Position>4</Position><TextAlignment>Far</TextAlignment></Co" & _
        "lumn4><Column5 ID=""CContable""><Caption>C. Contable</Caption><DataMember>CContabl" & _
        "e</DataMember><Key>CContable</Key><Position>5</Position><TextAlignment>Near</Tex" & _
        "tAlignment><Visible>False</Visible></Column5><Column6 ID=""IDMoneda""><Caption>Mon" & _
        "eda</Caption><DataMember>IDMoneda</DataMember><Key>IDMoneda</Key><Position>6</Po" & _
        "sition><TextAlignment>Near</TextAlignment><Width>53</Width></Column6><Column7 ID" & _
        "=""ImpIntereses""><Caption>Intereses</Caption><DataMember>ImpIntereses</DataMember" & _
        "><Key>ImpIntereses</Key><Position>7</Position><TextAlignment>Far</TextAlignment>" & _
        "</Column7><Column8 ID=""ImpCuota""><Caption>Cuota</Caption><DataMember>ImpCuota</D" & _
        "ataMember><EditType>NoEdit</EditType><Key>ImpCuota</Key><Position>8</Position><T" & _
        "extAlignment>Far</TextAlignment></Column8><Column9 ID=""IDProveedorBanco""><Captio" & _
        "n>Proveedor Banco</Caption><DataMember>IDProveedorBanco</DataMember><Key>IDProve" & _
        "edorBanco</Key><Position>9</Position><TextAlignment>Near</TextAlignment><Visible" & _
        ">False</Visible><Width>53</Width></Column9><Column10 ID=""IDBancoPropio""><Caption" & _
        ">Banco Propio</Caption><DataMember>IDBancoPropio</DataMember><Key>IDBancoPropio<" & _
        "/Key><Position>10</Position><TextAlignment>Near</TextAlignment><Visible>False</V" & _
        "isible><Width>53</Width></Column10><Column11 ID=""Texto""><Caption>Texto</Caption>" & _
        "<DataMember>Texto</DataMember><Key>Texto</Key><Position>11</Position><TextAlignm" & _
        "ent>Near</TextAlignment><Visible>False</Visible><Width>167</Width></Column11><Co" & _
        "lumn12 ID=""NFactura""><Caption>Factura</Caption><DataMember>NFactura</DataMember>" & _
        "<Key>NFactura</Key><Position>12</Position><TextAlignment>Far</TextAlignment><Vis" & _
        "ible>False</Visible><Width>67</Width></Column12><Column13 ID=""IdPrograma""><Capti" & _
        "on>IdPrograma</Caption><DataMember>IdPrograma</DataMember><Key>IdPrograma</Key><" & _
        "Position>13</Position><TextAlignment>Near</TextAlignment><Visible>False</Visible" & _
        "></Column13><Column14 ID=""IdUsuario""><Caption>IdUsuario</Caption><DataMember>IdU" & _
        "suario</DataMember><Key>IdUsuario</Key><Position>14</Position><TextAlignment>Nea" & _
        "r</TextAlignment><Visible>False</Visible></Column14><Column15 ID=""CambioA""><Capt" & _
        "ion>Cambio A</Caption><DataMember>CambioA</DataMember><Key>CambioA</Key><Positio" & _
        "n>15</Position><TextAlignment>Far</TextAlignment><Visible>False</Visible><Width>" & _
        "67</Width></Column15><Column16 ID=""CambioB""><Caption>Cambio B</Caption><DataMemb" & _
        "er>CambioB</DataMember><Key>CambioB</Key><Position>16</Position><TextAlignment>F" & _
        "ar</TextAlignment><Visible>False</Visible><Width>67</Width></Column16><Column17 " & _
        "ID=""IdProveedor""><Caption>IdProveedor</Caption><DataMember>IdProveedor</DataMemb" & _
        "er><Key>IdProveedor</Key><Position>17</Position><TextAlignment>Near</TextAlignme" & _
        "nt><Visible>False</Visible></Column17><Column18 ID=""FechaVencimientoFactura""><Ca" & _
        "ption>Vencimiento Inicial</Caption><DataMember>FechaVencimientoFactura</DataMemb" & _
        "er><Key>FechaVencimientoFactura</Key><Position>18</Position><TextAlignment>Near<" & _
        "/TextAlignment><Visible>False</Visible></Column18><Column19 ID=""Contabilizado""><" & _
        "Caption>Contabilizado</Caption><DataMember>Contabilizado</DataMember><Key>Contab" & _
        "ilizado</Key><Position>19</Position><TextAlignment>Near</TextAlignment><Visible>" & _
        "False</Visible></Column19><Column20 ID=""GeneradoAsientoTalon""><Caption>Asiento T" & _
        "alón Generado</Caption><DataMember>GeneradoAsientoTalon</DataMember><Key>Generad" & _
        "oAsientoTalon</Key><Position>20</Position><TextAlignment>Near</TextAlignment><Vi" & _
        "sible>False</Visible></Column20><Column21 ID=""ImpInteresesA""><Caption>Imp.Intere" & _
        "ses A</Caption><DataMember>ImpIntereses</DataMember><Key>ImpInteresesA</Key><Pos" & _
        "ition>21</Position><TextAlignment>Near</TextAlignment><Visible>False</Visible></" & _
        "Column21><Column22 ID=""ImpInteresesB""><Caption>Imp.InteresesB</Caption><DataMemb" & _
        "er>ImpInteresesB</DataMember><Key>ImpInteresesB</Key><Position>22</Position><Tex" & _
        "tAlignment>Near</TextAlignment><Visible>False</Visible></Column22><Column23 ID=""" & _
        "ImpAmortizacionA""><Caption>ImpAmortizacionA</Caption><DataMember>ImpAmortizacion" & _
        "A</DataMember><Key>ImpAmortizacionA</Key><Position>23</Position><TextAlignment>N" & _
        "ear</TextAlignment><Visible>False</Visible></Column23><Column24 ID=""ImpAmortizac" & _
        "ionB""><Caption>ImpAmortizacionB</Caption><DataMember>ImpAmortizacionB</DataMembe" & _
        "r><Key>ImpAmortizacionB</Key><Position>24</Position><TextAlignment>Near</TextAli" & _
        "gnment><Visible>False</Visible></Column24><Column25 ID=""ImpBaseImponibleA""><Capt" & _
        "ion>ImpBaseImponibleA</Caption><DataMember>ImpBaseImponibleA</DataMember><Key>Im" & _
        "pBaseImponibleA</Key><Position>25</Position><TextAlignment>Near</TextAlignment><" & _
        "Visible>False</Visible></Column25><Column26 ID=""ImpBaseImponibleB""><Caption>ImpB" & _
        "aseImponibleB</Caption><DataMember>ImpBaseImponibleB</DataMember><Key>ImpBaseImp" & _
        "onibleB</Key><Position>26</Position><TextAlignment>Near</TextAlignment><Visible>" & _
        "False</Visible></Column26><Column27 ID=""IDTipoIVA""><Caption>IDTipoIVA</Caption><" & _
        "DataMember>IDTipoIVA</DataMember><Key>IDTipoIVA</Key><Position>27</Position><Tex" & _
        "tAlignment>Near</TextAlignment><Visible>False</Visible></Column27><Column28 ID=""" & _
        "ImpVencimiento""><Caption>ImpVencimiento</Caption><DataMember>ImpVencimiento</Dat" & _
        "aMember><Key>ImpVencimiento</Key><Position>28</Position><TextAlignment>Near</Tex" & _
        "tAlignment><Visible>False</Visible></Column28><Column29 ID=""ImpVencimientoA""><Ca" & _
        "ption>ImpVencimientoA</Caption><DataMember>ImpVencimientoA</DataMember><Key>ImpV" & _
        "encimientoA</Key><Position>29</Position><TextAlignment>Near</TextAlignment><Visi" & _
        "ble>False</Visible></Column29><Column30 ID=""ImpVencimientoB""><Caption>ImpVencimi" & _
        "entoB</Caption><DataMember>ImpVencimientoB</DataMember><Key>ImpVencimientoB</Key" & _
        "><Position>30</Position><TextAlignment>Near</TextAlignment><Visible>False</Visib" & _
        "le></Column30></Columns><GroupCondition ID="""" /><SortKeys Collection=""true""><Sor" & _
        "tKey0 ID=""SortKey0""><ColIndex>8</ColIndex></SortKey0></SortKeys></RootTable></Gr" & _
        "idEXLayoutData>"
        Me.jngPagos.DesignTimeLayout = GridEXLayout1
        Me.jngPagos.EntityName = ""
        Me.jngPagos.Location = New System.Drawing.Point(0, 0)
        Me.jngPagos.Name = "jngPagos"
        Me.jngPagos.PrimaryDataFields = Nothing
        Me.jngPagos.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.jngPagos.SecondaryDataFields = Nothing
        Me.jngPagos.Size = New System.Drawing.Size(607, 169)
        Me.jngPagos.TabIndex = 0
        Me.jngPagos.Tag = "IdRec=5029:4394:4712:4713:4429:4715:4756:5071:4602:5257:4719:4711:4361:4362:5433:" & _
        "4399:4357:4725:10533:;"
        Me.jngPagos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngPagos.ViewName = ""
        '
        'cmbCancel
        '
        Me.cmbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancel.Image = CType(resources.GetObject("cmbCancel.Image"), System.Drawing.Image)
        Me.cmbCancel.Location = New System.Drawing.Point(448, 176)
        Me.cmbCancel.Name = "cmbCancel"
        Me.cmbCancel.Size = New System.Drawing.Size(45, 45)
        Me.cmbCancel.TabIndex = 6
        '
        'cmbOK
        '
        Me.cmbOK.Image = CType(resources.GetObject("cmbOK.Image"), System.Drawing.Image)
        Me.cmbOK.Location = New System.Drawing.Point(384, 176)
        Me.cmbOK.Name = "cmbOK"
        Me.cmbOK.Size = New System.Drawing.Size(45, 45)
        Me.cmbOK.TabIndex = 5
        '
        'frmModificarLeasing
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(608, 229)
        Me.Controls.Add(Me.cmbCancel)
        Me.Controls.Add(Me.cmbOK)
        Me.Controls.Add(Me.jngPagos)
        Me.Name = "frmModificarLeasing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Intereses de Leasisng"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        CType(Me.jngPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Eventos y Funciones del Formulario"
    Public Sub MainFunction()
        With jngPagos
            .EntityName = "Pago"
            .ViewName = "vCtlCIPagoContModifPagos"

            Dim f As New Filter
            f.Add(New NumberFilterItem("IDPagoPeriodo", FilterOperator.Equal, mlngIdPagoPeriodico))
            .Filter = f

            Me.ShowDialog()
        End With
    End Sub

    Private Sub frmModificarLeasing_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim FwnMoneda As New Moneda
        Dim dtMonedaA As DataTable = ExpertisApp.ExecuteTask(Of Object, DataTable)(AddressOf Moneda.ObtenerMonedaA, New Object)
        Dim dtMonedaB As DataTable = ExpertisApp.ExecuteTask(Of Object, DataTable)(AddressOf Moneda.ObtenerMonedaB, New Object)
        If Not IsNothing(dtMonedaA) AndAlso dtMonedaA.Rows.Count > 0 Then mlngNDecimalesA = dtMonedaA.Rows(0)("NDecimalesImp")
        If Not IsNothing(dtMonedaB) AndAlso dtMonedaB.Rows.Count > 0 Then mlngNDecimalesB = dtMonedaB.Rows(0)("NDecimalesImp")

    End Sub

    Private Sub frmModificarLeasing_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles MyBase.BusinessCalling
        e.Data.Context.Clear()
        Select Case e.EntityName
            Case jngPagos.EntityName
                e.Data.Context("ModificarLeasing") = True
        End Select
    End Sub

#End Region

#Region "Eventos del Grid"

    Private Sub jngPagos_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles jngPagos.UpdatingCell
        With jngPagos
            Select Case e.Column.Index
                Case .Columns("ImpIntereses").Index
                    If length(.Value(.Columns("IDMoneda").Index) & String.Empty) > 0 Then
                        Dim FwnMoneda As New Moneda
                        Dim DtMoneda As DataTable = FwnMoneda.Filter(New FilterItem("IDMoneda", FilterOperator.Equal, .GetValue("IDMoneda")))
                        If Not DtMoneda Is Nothing AndAlso DtMoneda.Rows.Count > 0 Then
                            e.Value = xRound(e.Value, DtMoneda.Rows(0)("NDecimalesImp"))
                        End If
                    End If
            End Select
        End With
    End Sub
#End Region

    Private Sub cmbOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOK.Click

        Me.UpdateData()
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub cmbCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class


