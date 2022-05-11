Imports Solmicro.Expertis.Business.General

Public Class MntoPagoPeriodico
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
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 26)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(696, 24)
        '
        'Toolbar
        '
        Me.Toolbar.Name = "Toolbar"
        Me.Toolbar.Size = New System.Drawing.Size(408, 26)
        '
        'MainPanel
        '
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(688, 425)
        '
        'Grid
        '
        Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDProveedor", "Proveedor", "IDProveedor", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("CCProveedor", "IdCContable")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCContable", "PlanContable", "IDCContable"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDFormaPago", "FormaPago", "IDFormaPago"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDBancoPropio", "BancoPropio", "IDBancoPropio"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDTipoPago", "TipoPago", "IDTipoPago"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDMoneda", "Moneda", "IDMoneda")})
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""Id""><Caption" & _
        ">Id</Caption><DataMember>Id</DataMember><Key>Id</Key><Position>0</Position><Text" & _
        "Alignment>Far</TextAlignment><Visible>False</Visible></Column0><Column1 ID=""Desc" & _
        "Pago""><Caption>Pago</Caption><DataMember>DescPago</DataMember><Key>DescPago</Key" & _
        "><Position>1</Position><TextAlignment>Near</TextAlignment><Width>113</Width></Co" & _
        "lumn1><Column2 ID=""FechaInicio""><Caption>Fecha Inicio</Caption><DataMember>Fecha" & _
        "Inicio</DataMember><EditType>CalendarCombo</EditType><Key>FechaInicio</Key><Posi" & _
        "tion>2</Position><TextAlignment>Near</TextAlignment><Width>80</Width></Column2><" & _
        "Column3 ID=""FechaFin""><Caption>Fecha Fin</Caption><DataMember>FechaFin</DataMemb" & _
        "er><EditType>CalendarCombo</EditType><Key>FechaFin</Key><Position>3</Position><T" & _
        "extAlignment>Near</TextAlignment><Width>80</Width></Column3><Column4 ID=""Unidad""" & _
        "><Caption>Unidad</Caption><DataMember>Unidad</DataMember><EditType>DropDownList<" & _
        "/EditType><Key>Unidad</Key><Position>4</Position><TextAlignment>Near</TextAlignm" & _
        "ent><Width>53</Width></Column4><Column5 ID=""Periodo""><Caption>Periodo</Caption><" & _
        "DataMember>Periodo</DataMember><Key>Periodo</Key><Position>5</Position><TextAlig" & _
        "nment>Far</TextAlignment><Width>53</Width></Column5><Column6 ID=""IDProveedor""><C" & _
        "aption>Proveedor</Caption><DataMember>IDProveedor</DataMember><Key>IDProveedor</" & _
        "Key><Position>6</Position><TextAlignment>Near</TextAlignment><Width>80</Width></" & _
        "Column6><Column7 ID=""IdCContable""><Caption>C. Contable</Caption><DataMember>IdCC" & _
        "ontable</DataMember><Key>IdCContable</Key><Position>7</Position><TextAlignment>N" & _
        "ear</TextAlignment><Width>80</Width></Column7><Column8 ID=""IdFormaPago""><Caption" & _
        ">F. Pago</Caption><DataMember>IdFormaPago</DataMember><Key>IdFormaPago</Key><Pos" & _
        "ition>8</Position><TextAlignment>Near</TextAlignment><Width>60</Width></Column8>" & _
        "<Column9 ID=""IdBancoPropio""><Caption>Banco Propio</Caption><DataMember>IdBancoPr" & _
        "opio</DataMember><Key>IdBancoPropio</Key><Position>9</Position><TextAlignment>Ne" & _
        "ar</TextAlignment><Width>60</Width></Column9><Column10 ID=""IdTipoPago""><Caption>" & _
        "Tipo Pago</Caption><DataMember>IdTipoPago</DataMember><Key>IdTipoPago</Key><Posi" & _
        "tion>10</Position><TextAlignment>Far</TextAlignment><Width>53</Width></Column10>" & _
        "<Column11 ID=""IdMoneda""><Caption>Moneda</Caption><DataMember>IdMoneda</DataMembe" & _
        "r><Key>IdMoneda</Key><Position>11</Position><TextAlignment>Near</TextAlignment><" & _
        "Width>53</Width></Column11><Column12 ID=""Importe""><Caption>Importe</Caption><Dat" & _
        "aMember>Importe</DataMember><Key>Importe</Key><Position>12</Position><TextAlignm" & _
        "ent>Far</TextAlignment><Width>67</Width></Column12><Column13 ID=""FechaUltimaActu" & _
        "alizacion""><Caption>Fecha Ultima Actualización</Caption><DataMember>FechaUltimaA" & _
        "ctualizacion</DataMember><EditType>CalendarCombo</EditType><Key>FechaUltimaActua" & _
        "lizacion</Key><Position>13</Position><TextAlignment>Near</TextAlignment><Width>8" & _
        "0</Width></Column13></Columns><GroupCondition ID="""" /></RootTable></GridEXLayout" & _
        "Data>"
        Me.Grid.DesignTimeLayout = GridEXLayout1
        Me.Grid.EntityName = "PagoPeriodico"
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(688, 425)
        Me.Grid.ViewName = "vfrmMntoPagoPeriodico"
        '
        'MntoPagoPeriodico
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(696, 509)
        Me.EntityName = "PagoPeriodico"
        Me.Name = "MntoPagoPeriodico"
        Me.ViewName = "vfrmMntoPagoPeriodico"
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Private mblnContabilidad As Boolean
    Private mintDigitosAuxiliar As Integer
    Private mstrEjercicioActual As String

#Region " Load "

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadERPData()
            LoadERPSettings()
            LoadEnums()
            SettingContabilidad()
        End If
    End Sub
    Private Sub LoadERPData()
        mblnContabilidad = New Parametro().Contabilidad
    End Sub

    Private Sub LoadERPSettings()
        If mblnContabilidad Then
            mstrEjercicioActual = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, Today)
            If Length(mstrEjercicioActual) > 0 Then
                Dim dtEjercicio As DataTable = New EjercicioContable().SelOnPrimaryKey(mstrEjercicioActual)
                If Not dtEjercicio Is Nothing AndAlso dtEjercicio.Rows.Count > 0 Then
                    mintDigitosAuxiliar = Nz(dtEjercicio.Rows(0)("DigitosAuxiliar"), 0)
                End If
            End If
        End If
    End Sub

    Private Sub LoadEnums()
        EnumData.PopulateValueList("enumcpPeriodo", Grid.Columns("Unidad"))
    End Sub

    Private Sub SettingContabilidad()
        Grid.Columns("IDCContable").Visible = mblnContabilidad
    End Sub

#End Region

    Private Sub Grid_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles Grid.UpdatingCell
        If e.Column.Key = "IdCContable" Then
            'NOTA: Esta conversión se debe hacer aquí, el valor con el que llega al BusinessCalling es que retorna después.
            If length(e.Value) > 0 Then
                e.Value = PuntoPorCero(e.Value, mintDigitosAuxiliar, mstrEjercicioActual)
            End If
        End If
    End Sub

    Private Sub Grid_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles Grid.AdvSearchSetPredefinedFilter
        With Grid
            Select Case e.Key
                Case "IdCContable"
                    e.Filter.Add(New StringFilterItem("IdEjercicio", mstrEjercicioActual))
            End Select
        End With
    End Sub

End Class
