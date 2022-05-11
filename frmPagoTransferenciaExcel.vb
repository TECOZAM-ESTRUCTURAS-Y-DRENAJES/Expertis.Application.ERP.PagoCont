Imports Janus.Windows.GridEX
Imports Solmicro.Expertis.Engine
Imports Solmicro.Expertis.Engine.UI
Imports Solmicro.Expertis.Engine.DAL
Imports Solmicro.Expertis.Business.Negocio
Imports System.Data.OleDb
Imports System.IO
Imports Solmicro.Expertis.Business.ClasesTecozam



Public Class frmPagoTransferenciaExcel
    Inherits Solmicro.Expertis.Engine.UI.FormBase

    'Public rutaExcel As String = "C:\Users\lgonzalez\Desktop\DavidVelascoH\EXCEL\PlantillapruebaTRANSEXCEL.xlsm"
    Private hojaExcel As String = "Hoja1"
    Private rangoExcel1 As String = "A1:G101"

#Region "DATOS AL CARGAR"
    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.Grid1.RelationMode = RelationMode.NoRelation
    End Sub

    Private Sub frmPagoTransferenciaExcel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Grid1.HideColumn("IDTransferencia")
        Grid1.HideColumn("FacturaNumero")
        Button1.Enabled = False
    End Sub
#End Region

#Region "IMPORTAR DATOS EXCEL"

    'Metodo importar excel al grid
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            Dim dt As DataTable = ObtenerDatosExcel2(TextBox2.Text, hojaExcel, rangoExcel1)
            'MessageBox.Show("El excel tiene " & dt.Rows.Count & " lineas")

            'codigo para limpiar la tabla
            Dim dt2 As New DataTable
            Dim cont As Integer = 0

            dt2.Columns.Add("Concepto")
            dt2.Columns.Add("Importe")
            dt2.Columns.Add("BIC")
            dt2.Columns.Add("TitularCuenta")
            dt2.Columns.Add("Pais")
            dt2.Columns.Add("Direccion")
            dt2.Columns.Add("IBAN")
            'dt2.Columns.Add("FacturaNumero")

            Dim dr2 As DataRow
            Grid1.SetDataBinding(dt2, "")
            Grid1.RetrieveStructure()

            For Each dr As DataRow In dt.Rows

                If IsDBNull(dr(0)) Or IsDBNull(dr(1)) Or IsDBNull(dr(2)) Or IsDBNull(dr(3)) Or IsDBNull(dr(4)) Or IsDBNull(dr(5)) Or IsDBNull(dr(6)) Then
                Else

                    Grid1.RetrieveStructure()
                    dr2 = dt2.NewRow
                    dr2("Concepto") = dr(0)
                    dr2("Importe") = dr(1)
                    dr2("BIC") = dr(2)
                    dr2("TitularCuenta") = dr(3)
                    dr2("Pais") = dr(4)
                    dr2("Direccion") = dr(5)
                    dr2("IBAN") = dr(6)
                    'dr2("FacturaNumero") = dr(7)
                    dt2.Rows.Add(dr2)
                    'ExpertisApp.GenerateMessage("El valor de la columna Concepto vale " & dt(cont)("Concepto") & " " & cont)
                    cont += 1
                End If
            Next
            Grid1.DataSource = dt2

            ExpertisApp.GenerateMessage("Se han insertado " & cont & " lineas correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Public Function ObtenerDatosExcel(ByVal ruta As String, ByVal hoja As String, ByVal rango As String) As DataTable
        ' Cadena de conexión con el libro de Excel indicado.   '4.0 // Proyecto, propiedades, x86
        Dim cadenaConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Extended Properties='Excel 8.0;HDR=NO';" & "Data Source=" & ruta

        ' Declarar una objeto OleDbConnection
        Using cnn As New OleDbConnection(cadenaConexion)

            ' Crear el comando que vamos a ejecutar
            Dim cmd As OleDbCommand = cnn.CreateCommand()

            ' Indicar la consulta SQL de selección que vamos a ejecutar.
            cmd.CommandText = String.Format("SELECT * FROM [{0}${1}]", hoja, rango)

            ' Crear el adaptador de datos al que le pasaremos el comando.
            Dim da As New OleDbDataAdapter(cmd)

            ' Creamos un objeto DataTable temporal.
            Dim dtTemp As New DataTable("TestTable")

            ' Rellenamos el objeto DataTable temporal con todas las
            ' filas existentes en el rango de Excel especificado,
            ' estén o no en blanco.
            '
            da.Fill(dtTemp)

            ' Clonamos el objeto DataTable.
            Dim dt As DataTable = dtTemp.Clone()



            ' Seleccionamos todas las filas existentes en el objeto DataTable,
            ' se traten de filas en blanco o no.
            '
            Dim rows As DataRow() = dtTemp.Select()

            For index As Integer = 0 To rows.Count - 1

                ' Referenciar la fila
                Dim row As DataRow = rows(index)

                If (row.Item(0) Is DBNull.Value) Then
                    ' Si el valor del primero campo (F1) es NULL, se tratará
                    ' de la primera fila en blanco existente, por lo que
                    ' abandonamos el bucle.
                    Exit For
                End If

                ' Importar la filas válidas al objeto DataTable clonado.
                dt.ImportRow(row)
            Next

            ' Devolvemos el objeto DataTable clonado.

            Return dt

        End Using
    End Function

    'Boton que seleccion el Excel
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim openFD As New OpenFileDialog()

        openFD.Filter = "Excel .xlsx| *.xlsx|Excel .xls|*xls|Excel .xlsm |*xlsm"

        If openFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox2.Text = openFD.FileName
        End If

        If TextBox2.Text <> "" Then
            Button1.Enabled = True
        End If
    End Sub


    Public Function ObtenerDatosExcel2(ByVal ruta As String, ByVal hoja As String, ByVal rango As String) As DataTable
        Dim MyConnection As System.Data.OleDb.OleDbConnection
        Dim DtSet As System.Data.DataSet
        Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
        MyConnection = New System.Data.OleDb.OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & ruta & "';Extended Properties=Excel 8.0;")
        MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [" & hoja & "$" & rango & "]", MyConnection)
        'MyCommand.TableMappings.Add("Table", "Net-informations.com")
        DtSet = New System.Data.DataSet
        MyCommand.Fill(DtSet)
        Dim dt As DataTable = DtSet.Tables(0)
        MyConnection.Close()
        Return dt

    End Function
#End Region

#Region "GENERACION FICHERO XML"
    'Ruta donde se va a guardar el fichero generado (XML)
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim openFD As New SaveFileDialog()
        With openFD
            .Title = "Seleccionar Ruta ..."
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            .Filter = "XML files(.xml)|*.xml|all Files(*.*)|*.*"
            .FileName = "TransferenciasSepa.xml"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                TextBox1.Text = openFD.FileName
            End If
        End With
    End Sub


    'Boton aceptar
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim banco As String = ""
        Dim ruta As String = TextBox1.Text 'Donde se guarda el fichero que se genera
        Dim dt As DataTable = Me.Grid1.DataSource 'Tabla de los pagos que se van a realizar
        Dim frm As New frmPagoTransferenciaExcelXML()


        banco = AdvSearch1.Text

        If banco.Equals("") Then
            MessageBox.Show("Introduzca un banco para realizar la transferencia.")
        Else
            If ruta = "" Then
                MessageBox.Show("Introduzca una ruta para guardar el fichero")
            Else
                Me.Close()
                frm.cargaDatos(banco, ruta, dt)
            End If
        End If


    End Sub
    'Boton Cancelar
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim result As DialogResult = MessageBox.Show("¿Desea cancelar la Transferencia? La ventana se cerrará.", "Cierre de Ventana", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
#End Region

End Class
