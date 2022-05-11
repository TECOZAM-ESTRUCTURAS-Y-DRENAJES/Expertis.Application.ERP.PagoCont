Imports Janus.Windows.GridEX
Imports Solmicro.Expertis.Engine.DAL
Imports Solmicro.Expertis.Business.Negocio
Imports System.Data.OleDb
Imports System.IO
Imports System.Xml
Imports Solmicro.Expertis.Business.ClasesTecozam

Public Class frmPagoTransferenciaExcelXML
    Inherits FormBase

    Dim Banco As String
    Dim RutaFic As String

#Region "DATOS AL CARGAR"
    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.Grid1.RelationMode = RelationMode.NoRelation
    End Sub
#End Region

#Region "MUESTRA DATOS VENTANA ANTERIOR"
    Public Sub cargaDatos(ByVal strBanco As String, ByVal ruta As String, ByVal dt As DataTable)
        Me.Show()
        Banco = strBanco
        'TextBox1.Text = strBanco
        RutaFic = ruta
        TextBox3.Text = obtenNombreEmpresa()
        TextBox4.Text = DateTime.Now.ToString("dd-MM-yyyy // HH:mm")
        Grid1.SetDataBinding(dt, "")
        Grid1.RetrieveStructure()
    End Sub
#End Region

#Region "GENERA XML "
    'Boton que Genera el fichero XML
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        generaXML()

        Dim result As DialogResult = MessageBox.Show("¿Desea cerrar la ventana actual?", "Aviso", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
        ElseIf result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub generaXML()
        Try

            'Creo el documento
            Dim xmlDoc As New XmlDocument

            'Primera linea. Version y encoding
            Dim xmlNodoDecla As XmlDeclaration = xmlDoc.CreateNode(Xml.XmlNodeType.XmlDeclaration, "1.0", Nothing, Nothing)
            xmlNodoDecla.Encoding = "UTF-8"
            'Añado la primera linea
            xmlDoc.AppendChild(xmlNodoDecla)

            'Añado la segunda linea(Document) e incluye el cierre
            Dim document As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "Document", String.Empty)
            'Lo añado a la raiz con sus atributos
            xmlDoc.AppendChild(document)
            xmlDoc.DocumentElement.SetAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance")
            xmlDoc.DocumentElement.SetAttribute("xmlns", "urn:iso:std:iso:20022:tech:xsd:pain.001.001.03")

            'Añado la tercera etiqueta(CstmrCdtTrfInitn)
            Dim raiz As Xml.XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "CstmrCdtTrfInitn", String.Empty)

            document.AppendChild(raiz)


            'Añado la cuarta etiqueta y texto dentro de esta etiqueta
            Dim raiz2 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "GrpHdr", String.Empty)
            Dim raiz3 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "MsgId", String.Empty)
            Dim raiz4 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "CreDtTm", String.Empty)
            Dim raiz5 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "NbOfTxs", String.Empty)
            Dim raiz6 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "CtrlSum", String.Empty)
            Dim raiz7 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "InitgPty", String.Empty)
            Dim raiz8 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "Nm", String.Empty)
            Dim raiz9 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "Id", String.Empty)
            Dim raiz10 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "OrgId", String.Empty)
            Dim raiz11 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "Othr", String.Empty)
            Dim raiz12 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "Id", String.Empty)
            Dim raiz13 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "PmtInf", String.Empty)
            Dim raiz14 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "PmtInfId", String.Empty)
            Dim raiz15 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "PmtMtd", String.Empty)
            Dim raiz16 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "NbOfTxs", String.Empty)
            Dim raiz16_2 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "CtrlSum", String.Empty)
            Dim raiz17 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "PmtTpInf", String.Empty)
            Dim raiz18 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "SvcLvl", String.Empty)
            Dim raiz19 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "Cd", String.Empty)
            Dim raiz20 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "ReqdExctnDt", String.Empty)
            Dim raiz21 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "Dbtr", String.Empty)
            Dim raiz22 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "Nm", String.Empty)
            Dim raiz23 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "PstlAdr", String.Empty)
            Dim raiz24 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "Ctry", String.Empty)
            Dim raiz25 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "AdrLine", String.Empty)
            Dim raiz26 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "Id", String.Empty)
            Dim raiz27 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "OrgId", String.Empty)
            Dim raiz28 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "Othr", String.Empty)
            Dim raiz29 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "Id", String.Empty)
            Dim raiz30 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "DbtrAcct", String.Empty)
            Dim raiz31 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "Id", String.Empty)
            Dim raiz32 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "IBAN", String.Empty)
            Dim raiz33 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "DbtrAgt", String.Empty)
            Dim raiz34 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "FinInstnId", String.Empty)
            Dim raiz35 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "BIC", String.Empty)

            'Cuento el numero de filas que tiene el excel/grid para sacar el numero de registros que hay y la suma total de las transferencias

            Dim dt1 As New DataTable
            dt1 = Grid1.DataSource
            Dim cont1 As Integer
            cont1 = 0
            Dim importeTotal As Double
            importeTotal = 0.0

            For Each Fila As DataRow In dt1.Rows
                'MessageBox.Show(CDbl(dt1(cont1)("Importe")))
                importeTotal += CDbl(dt1(cont1)("Importe"))
                cont1 += 1

            Next

            Dim importeTotalString As String
            importeTotalString = importeTotal
            Dim importe As String
            importe = importeTotalString.Replace(",", ".")
            'MessageBox.Show(importe)


            'Obtencion del nombre de ordenante(mediante bbdd) Tecozam Estructuras y ferrallas y CIF

            Dim filtro As New Filter
            filtro.Add("ID", FilterOperator.Equal, 1)
            Dim clase As New BE.DataEngine
            Dim dtEmpresa As DataTable
            dtEmpresa = clase.Filter("tbDatosEmpresa", filtro)
            Dim nombreEmpresa As String
            nombreEmpresa = dtEmpresa(0)("DescEmpresa").ToString()
            'MessageBox.Show(dtEmpresa(0)("DescEmpresa").ToString())

            Dim CIF As String
            CIF = dtEmpresa(0)("Cif").ToString()

            'PAIS DE LA EMPRESA
            Dim idPaisEmpresa As String
            idPaisEmpresa = dtEmpresa(0)("IDPais").ToString()

            Dim filtro3 As New Filter
            filtro3.Add("IDPais", FilterOperator.Equal, idPaisEmpresa)
            Dim clase3 As New BE.DataEngine
            Dim dtPais As DataTable
            dtPais = clase.Filter("[tbMaestroPais]", filtro3)
            Dim paisISO As String
            paisISO = dtPais(0)("CodigoISO").ToString()

            'MessageBox.Show(paisISO)

            'Codigo Identificacion del fichero-----
            Dim codIdent As String
            codIdent = ""
            codIdent += "PRE"
            codIdent += DateTime.Now.ToString("yyyyMMddHHmmssfffff")
            codIdent += CIF
            'QUIZAS ESTE MAL Y FALTEN CARACTERES(APUNTADO CUADERNO David Velasco)
            'MessageBox.Show(codIdent)

            'Direccion
            Dim direccion As String
            direccion = dtEmpresa(0)("Direccion").ToString()

            'ID
            Dim CIF000 As String
            CIF000 = CIF + "000"

            'IBAN DEL BANCO
            Dim filtro2 As New Filter
            filtro2.Add("IDBancoPropio", FilterOperator.Equal, Banco)
            Dim clase2 As New BE.DataEngine
            Dim dtBanco As DataTable
            dtBanco = clase2.Filter("tbMaestroBancoPropio", filtro2)
            Dim IBANBanco As String
            IBANBanco = dtBanco(0)("CodigoIBAN").ToString()
            'MessageBox.Show(IBANBanco)

            'SWIFT DEL BANCO
            Dim SWIFTBanco As String
            SWIFTBanco = dtBanco(0)("Swift").ToString()
            'MessageBox.Show(SWIFTBanco)

            Dim txtRaiz3 As XmlText = xmlDoc.CreateTextNode(codIdent) 'YA ESTA
            Dim txtRaiz4 As XmlText = xmlDoc.CreateTextNode(DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss")) 'YA ESTA
            Dim txtRaiz5 As XmlText = xmlDoc.CreateTextNode(cont1) 'YA ESTA
            Dim txtRaiz6 As XmlText = xmlDoc.CreateTextNode(importe) 'YA ESTA
            Dim txtraiz8 As XmlText = xmlDoc.CreateTextNode(nombreEmpresa) 'YA ESTA
            Dim txtraiz12 As XmlText = xmlDoc.CreateTextNode(CIF000) 'YA ESTA
            Dim txtraiz14 As XmlText = xmlDoc.CreateTextNode("PmtInfId" & DateTime.Now.ToString("yyyyMMdd")) 'YA ESTA
            Dim txtraiz15 As XmlText = xmlDoc.CreateTextNode("TRF") 'YA ESTA
            Dim txtraiz16 As XmlText = xmlDoc.CreateTextNode(cont1) 'YA ESTA
            Dim txtraiz16_2 As XmlText = xmlDoc.CreateTextNode(importe) 'YA ESTA
            Dim txtraiz19 As XmlText = xmlDoc.CreateTextNode("SEPA") 'YA ESTA
            Dim txtraiz20 As XmlText = xmlDoc.CreateTextNode(Format(Now, "yyyy-MM-dd")) 'YA ESTA
            Dim txtraiz22 As XmlText = xmlDoc.CreateTextNode(nombreEmpresa) 'YA ESTA
            Dim txtraiz24 As XmlText = xmlDoc.CreateTextNode(paisISO) 'YA ESTA
            Dim txtraiz25 As XmlText = xmlDoc.CreateTextNode(direccion) 'YA ESTA
            Dim txtraiz29 As XmlText = xmlDoc.CreateTextNode(CIF000) 'YA ESTA
            Dim txtraiz32 As XmlText = xmlDoc.CreateTextNode(IBANBanco) 'YA ESTA
            Dim txtraiz35 As XmlText = xmlDoc.CreateTextNode(SWIFTBanco) ' YA ESTA

            'Dim txtraiz38 As Xml.XmlText = xmlDoc.CreateTextNode("12477071")

            raiz.AppendChild(raiz2)
            'raiz.LastChild.AppendChild(txtRaiz)

            raiz2.AppendChild(raiz3)
            raiz2.LastChild.AppendChild(txtRaiz3)

            raiz2.AppendChild(raiz4)
            raiz2.LastChild.AppendChild(txtRaiz4)

            raiz2.AppendChild(raiz5)
            raiz2.LastChild.AppendChild(txtRaiz5)

            raiz2.AppendChild(raiz6)
            raiz2.LastChild.AppendChild(txtRaiz6)

            raiz2.AppendChild(raiz7)

            raiz7.AppendChild(raiz8)
            raiz7.LastChild.AppendChild(txtraiz8)

            raiz7.AppendChild(raiz9)
            raiz9.AppendChild(raiz10)
            raiz10.AppendChild(raiz11)
            raiz11.AppendChild(raiz12)
            raiz11.LastChild.AppendChild(txtraiz12)

            'Empiezo a realizar PmtInf
            raiz.AppendChild(raiz13)
            raiz13.AppendChild(raiz14)
            raiz13.LastChild.AppendChild(txtraiz14)

            raiz13.AppendChild(raiz15)
            raiz13.LastChild.AppendChild(txtraiz15)

            raiz13.AppendChild(raiz16)
            raiz13.LastChild.AppendChild(txtraiz16)

            raiz13.AppendChild(raiz16_2)
            raiz13.LastChild.AppendChild(txtraiz16_2)

            raiz13.AppendChild(raiz17)

            raiz17.AppendChild(raiz18)
            raiz18.AppendChild(raiz19)
            raiz18.LastChild.AppendChild(txtraiz19)

            raiz13.AppendChild(raiz20)
            raiz13.LastChild.AppendChild(txtraiz20)

            raiz13.AppendChild(raiz21)
            raiz21.AppendChild(raiz22)
            raiz22.AppendChild(txtraiz22)

            raiz21.AppendChild(raiz23)
            raiz23.AppendChild(raiz24)
            raiz24.AppendChild(txtraiz24)
            raiz23.AppendChild(raiz25)
            raiz25.AppendChild(txtraiz25)

            raiz21.AppendChild(raiz26)
            raiz26.AppendChild(raiz27)
            raiz27.AppendChild(raiz28)
            raiz28.AppendChild(raiz29)
            raiz28.LastChild.AppendChild(txtraiz29)

            'FIN dbtr, INICIO DbtrAcct
            raiz13.AppendChild(raiz30)
            raiz30.AppendChild(raiz31)
            raiz31.AppendChild(raiz32)
            raiz31.LastChild.AppendChild(txtraiz32)

            raiz13.AppendChild(raiz33)
            raiz33.AppendChild(raiz34)
            raiz34.AppendChild(raiz35)
            raiz34.LastChild.AppendChild(txtraiz35)

            'Creacion de las transferencias, recorrido de la tabla
            Dim dt As New DataTable
            dt = Grid1.DataSource
            Dim cont As Integer
            cont = 0

            If dt.Rows.Count > 0 Then
                For Each Fila As DataRow In dt.Rows
                    If Not Fila Is Nothing Then
                        'MessageBox.Show(dt(cont)("Concepto"))
                        generaTransferencia(Fila, xmlDoc, raiz13, cont, dt)
                    End If
                    cont += 1
                Next
                MessageBox.Show("FICHERO CREADO CORRECTAMENTE")
                xmlDoc.Save(RutaFic)
            Else
                MessageBox.Show("NO SE HA ENCONTRADO NINGUNA TRANSFERENCIA.")
            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub


#End Region

    'Volver ventana anterior
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim frm As New frmPagoTransferenciaExcel()
        frm.Show()
    End Sub

    Public Sub generaTransferencia(ByVal Fila As DataRow, ByRef xmlDoc As XmlDocument, ByRef raiz13 As XmlNode, ByVal cont As String, ByVal dt As DataTable)
        'Primer bloque transferencia
        Dim raiz36 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "CdtTrfTxInf", String.Empty)
        Dim raiz37 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "PmtId", String.Empty)
        Dim raiz38 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "EndToEndId", String.Empty)
        Dim raiz39 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "Amt", String.Empty)
        Dim raiz40 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "InstdAmt", String.Empty)
        Dim raiz41 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "CdtrAgt", String.Empty)
        Dim raiz42 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "FinInstnId", String.Empty)
        Dim raiz43 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "BIC", String.Empty)

        Dim raiz44 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "Cdtr", String.Empty)
        Dim raiz45 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "Nm", String.Empty)
        Dim raiz46 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "PstlAdr", String.Empty)
        Dim raiz47 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "Ctry", String.Empty)
        Dim raiz48 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "AdrLine", String.Empty)

        Dim raiz49 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "CdtrAcct", String.Empty)
        Dim raiz50 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "Id", String.Empty)
        Dim raiz51 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "IBAN", String.Empty)

        Dim raiz52 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "RmtInf", String.Empty)
        Dim raiz53 As XmlNode = xmlDoc.CreateNode(System.Xml.XmlNodeType.Element, "Ustrd", String.Empty)

        'Asigna un atributo a la etiqueta InstdAmt
        Dim attr = xmlDoc.CreateAttribute("Ccy")
        attr.Value = "EUR"
        raiz40.Attributes.SetNamedItem(attr)

        'raiz38.Value = "Ccy=EUR"

        'Dim txtraiz38 As XmlText = xmlDoc.CreateTextNode(dt(cont)("FacturaNumero"))

        Dim importe As String
        importe = dt(cont)("Importe")
        Dim importeString As String
        importeString = importe.Replace(",", ".")

        Dim numAlea As String
        numAlea = CInt((100000000) * Rnd() + 1)

        Dim txtraiz38 As XmlText = xmlDoc.CreateTextNode(numAlea)
        Dim txtraiz40 As XmlText = xmlDoc.CreateTextNode(importeString)
        Dim txtraiz43 As XmlText = xmlDoc.CreateTextNode(dt(cont)("BIC"))
        Dim txtraiz45 As XmlText = xmlDoc.CreateTextNode(dt(cont)("TitularCuenta"))
        Dim txtraiz47 As XmlText = xmlDoc.CreateTextNode(dt(cont)("Pais"))
        Dim txtraiz48 As XmlText = xmlDoc.CreateTextNode(dt(cont)("Direccion"))
        Dim txtraiz51 As XmlText = xmlDoc.CreateTextNode(dt(cont)("IBAN"))
        Dim txtraiz53 As XmlText = xmlDoc.CreateTextNode(dt(cont)("Concepto"))


        raiz13.AppendChild(raiz36)
        raiz36.AppendChild(raiz37)
        raiz37.AppendChild(raiz38)

        raiz37.LastChild.AppendChild(txtraiz38)

        'Segundo bloque transferencia
        raiz36.AppendChild(raiz39)
        raiz39.AppendChild(raiz40)
        raiz39.LastChild.AppendChild(txtraiz40)

        'Tercer bloque transferencia
        raiz36.AppendChild(raiz41)
        raiz41.AppendChild(raiz42)
        raiz42.AppendChild(raiz43)
        raiz43.AppendChild(txtraiz43)

        'Cuarto bloque transferencia
        raiz36.AppendChild(raiz44)
        raiz44.AppendChild(raiz45)
        raiz44.LastChild.AppendChild(txtraiz45)

        raiz44.AppendChild(raiz46)
        raiz46.AppendChild(raiz47)
        raiz46.LastChild.AppendChild(txtraiz47)
        raiz46.AppendChild(raiz48)
        raiz46.LastChild.AppendChild(txtraiz48)

        'Quinto bloque transferencia
        raiz36.AppendChild(raiz49)
        raiz49.AppendChild(raiz50)
        raiz50.AppendChild(raiz51)
        raiz50.LastChild.AppendChild(txtraiz51)

        'Sexto y ultimo bloque de transferencia
        raiz36.AppendChild(raiz52)
        raiz52.AppendChild(raiz53)
        raiz53.AppendChild(txtraiz53)
    End Sub

    Public Function obtenNombreEmpresa() As String
        Dim filtro As New Filter
        filtro.Add("ID", FilterOperator.Equal, 1)
        Dim clase As New BE.DataEngine
        Dim dtEmpresa As DataTable
        dtEmpresa = clase.Filter("tbDatosEmpresa", filtro)
        Dim nombreEmpresa As String
        nombreEmpresa = dtEmpresa(0)("DescEmpresa").ToString()
        Return nombreEmpresa
    End Function

    Private Sub generaInforme()
        Dim rp As New Report("RPTRANSEXC")
        Dim filtro As New Filter
        filtro.Add("ID", FilterOperator.Equal, 1)
        rp.DataSource = New BE.DataEngine().Filter("vRptTransferenciasExcel", filtro)
        'rp.DataSource = Grid1.DataSource
        ExpertisApp.OpenReport(rp)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim claseTransf As New Solmicro.Expertis.Business.ClasesTecozam.TransferenciaPago
            claseTransf.ActualizarTabla()
            'MessageBox.Show("Se ha borrado el contenido de la tabla tbPagoTransferencia")

            'INSERTA EL CONTENIDO DEL GRID EN LA TABLA
            Dim contador As Integer 'Asigna el valor a IDTransferencia
            contador = 1
            Dim dt As DataTable
            dt = Grid1.DataSource

            For Each dr As DataRow In dt.Rows

                If IsDBNull(dr(0)) Then

                Else
                    claseTransf.realizaInsercciones(contador, dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6))
                    contador += 1
                End If
            Next

            Dim result As DialogResult = MessageBox.Show("¿Desea obtener el informe de las transferencias realizadas? La ventana actual se cerrará.", "Aviso", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
            ElseIf result = DialogResult.No Then
            ElseIf result = DialogResult.Yes Then
                Cursor.Current = Cursors.WaitCursor
                generaInforme()
                Cursor.Current = Cursors.Default
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class
