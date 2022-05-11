Imports Solmicro.Expertis.Business.Negocio

Public Class FrmCartaProveedor
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
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents jngGrid As Solmicro.Expertis.Engine.UI.Grid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.jngGrid = New Solmicro.Expertis.Engine.UI.Grid
        CType(Me.jngGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(504, 190)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(90, 28)
        Me.cmbCancelar.TabIndex = 2
        Me.cmbCancelar.Text = "Cancelar"
        '
        'cmbAceptar
        '
        Me.cmbAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmbAceptar.Location = New System.Drawing.Point(400, 190)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(90, 28)
        Me.cmbAceptar.TabIndex = 1
        Me.cmbAceptar.Text = "Aceptar"
        '
        'jngGrid
        '
        Me.jngGrid.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False
        Me.jngGrid.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IdProveedor""" & _
        "><Caption>IdProveedor</Caption><DataMember>IdProveedor</DataMember><Key>IdProvee" & _
        "dor</Key><Position>0</Position><Visible>False</Visible></Column0><Column1 ID=""Ti" & _
        "tulo""><Caption>Proveedor</Caption><DataMember>Titulo</DataMember><Key>Titulo</Ke" & _
        "y><Position>1</Position><Selectable>False</Selectable><Width>175</Width></Column" & _
        "1><Column2 ID=""IDBancoPropio""><Caption>IDBancoPropio</Caption><DataMember>IDBanc" & _
        "oPropio</DataMember><Key>IDBancoPropio</Key><Position>2</Position><Visible>False" & _
        "</Visible></Column2><Column3 ID=""DescBancoPropio""><Caption>Banco Propio</Caption" & _
        "><DataMember>DescBancoPropio</DataMember><Key>DescBancoPropio</Key><Position>3</" & _
        "Position><Selectable>False</Selectable><Width>175</Width></Column3><Column4 ID=""" & _
        "Direccion""><Caption>Dirección</Caption><DataMember>Direccion</DataMember><Key>Di" & _
        "reccion</Key><Position>4</Position><Visible>False</Visible></Column4><Column5 ID" & _
        "=""CodPostal""><Caption>CodPostal</Caption><DataMember>CodPostal</DataMember><Key>" & _
        "CodPostal</Key><Position>5</Position><Visible>False</Visible></Column5><Column6 " & _
        "ID=""Poblacion""><Caption>Poblacion</Caption><DataMember>Poblacion</DataMember><Ke" & _
        "y>Poblacion</Key><Position>6</Position><Visible>False</Visible></Column6><Column" & _
        "7 ID=""Provincia""><Caption>Provincia</Caption><DataMember>Provincia</DataMember><" & _
        "Key>Provincia</Key><Position>7</Position><Visible>False</Visible></Column7><Colu" & _
        "mn8 ID=""DescEmpresa""><Caption>DescEmpresa</Caption><DataMember>DescEmpresa</Data" & _
        "Member><Key>DescEmpresa</Key><Position>8</Position><Visible>False</Visible></Col" & _
        "umn8><Column9 ID=""CIFEmpresa""><Caption>CIFEmpresa</Caption><DataMember>CIFEmpres" & _
        "a</DataMember><Key>CIFEmpresa</Key><Position>9</Position><Visible>False</Visible" & _
        "></Column9><Column10 ID=""DirEmpresa""><Caption>DirEmpresa</Caption><DataMember>Di" & _
        "rEmpresa</DataMember><Key>DirEmpresa</Key><Position>10</Position><Visible>False<" & _
        "/Visible></Column10><Column11 ID=""PoblEmpresa""><Caption>PoblEmpresa</Caption><Da" & _
        "taMember>PoblEmpresa</DataMember><Key>PoblEmpresa</Key><Position>11</Position><V" & _
        "isible>False</Visible></Column11><Column12 ID=""ProvEmpresa""><Caption>ProvEmpresa" & _
        "</Caption><DataMember>ProvEmpresa</DataMember><Key>ProvEmpresa</Key><Position>12" & _
        "</Position><Visible>False</Visible></Column12><Column13 ID=""CPEmpresa""><Caption>" & _
        "CPEmpresa</Caption><DataMember>CPEmpresa</DataMember><Key>CPEmpresa</Key><Positi" & _
        "on>13</Position><Visible>False</Visible></Column13><Column14 ID=""TelfEmpresa""><C" & _
        "aption>TelfEmpresa</Caption><DataMember>TelfEmpresa</DataMember><Key>TelfEmpresa" & _
        "</Key><Position>14</Position><Visible>False</Visible></Column14><Column15 ID=""Fa" & _
        "xEmpresa""><Caption>FaxEmpresa</Caption><DataMember>FaxEmpresa</DataMember><Key>F" & _
        "axEmpresa</Key><Position>15</Position><Visible>False</Visible></Column15><Column" & _
        "16 ID=""EmailEmpresa""><Caption>EmailEmpresa</Caption><DataMember>EmailEmpresa</Da" & _
        "taMember><Key>EmailEmpresa</Key><Position>16</Position><Visible>False</Visible><" & _
        "/Column16><Column17 ID=""ImporteTotalA""><Caption>Importe Total A</Caption><DataMe" & _
        "mber>ImporteTotalA</DataMember><Key>ImporteTotalA</Key><Position>17</Position><S" & _
        "electable>False</Selectable></Column17><Column18 ID=""NCheque""><Caption>Nº Cheque" & _
        "</Caption><DataMember>NCheque</DataMember><Key>NCheque</Key><Position>18</Positi" & _
        "on></Column18></Columns><GroupCondition ID="""" /></RootTable></GridEXLayoutData>"
        Me.jngGrid.DesignTimeLayout = GridEXLayout1
        Me.jngGrid.EntityName = Nothing
        Me.jngGrid.Location = New System.Drawing.Point(6, 5)
        Me.jngGrid.Name = "jngGrid"
        Me.jngGrid.PrimaryDataFields = Nothing
        Me.jngGrid.SecondaryDataFields = Nothing
        Me.jngGrid.Size = New System.Drawing.Size(589, 175)
        Me.jngGrid.TabIndex = 0
        Me.jngGrid.Tag = "IdRec=0:0:;"
        Me.jngGrid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngGrid.ViewName = Nothing
        '
        'FrmCartaProveedor
        '
        Me.AcceptButton = Me.cmbAceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.cmbCancelar
        Me.ClientSize = New System.Drawing.Size(600, 221)
        Me.Controls.Add(Me.cmbCancelar)
        Me.Controls.Add(Me.cmbAceptar)
        Me.Controls.Add(Me.jngGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmCartaProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carta a Proveedores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        CType(Me.jngGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Propiedades "

    Private mdtCartaProveedor As DataTable
    Public ReadOnly Property CartaProveedor() As DataTable
        Get
            Return mdtCartaProveedor
        End Get
    End Property

    Private mdtPagos As DataTable
    Public WriteOnly Property Pagos() As DataTable
        Set(ByVal Value As DataTable)
            mdtPagos = Value
        End Set
    End Property

#End Region

#Region " Carga del formulario "

    Private Sub FrmCartaProveedor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            CargarGrid(mdtPagos)
        End If
    End Sub

    Private Sub CargarGrid(ByVal dtPagos As DataTable)
        Dim IDPagos(-1) As Object
        For Each drPago As DataRow In dtPagos.Rows
            ReDim Preserve IDPagos(IDPagos.Length)
            IDPagos(IDPagos.Length - 1) = drPago("IDPago")
        Next
        jngGrid.DataSource = ExpertisApp.ExecuteTask(Of Object(), DataTable)(AddressOf Pago.CartasProveedores, IDPagos)
    End Sub

#End Region

#Region " Aceptar/Cancelar "

    Private Sub cmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        mdtCartaProveedor = jngGrid.DataSource
        Me.Close()
    End Sub

    Private Sub cmbCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        mdtCartaProveedor = Nothing
        Me.Close()
    End Sub

#End Region

End Class
