Public Class frmSeleccionBanco
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
    Friend WithEvents fwiBancoPropio As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblfwiBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblcfwiBancoPropio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.fwiBancoPropio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblfwiBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiBancoPropio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.SuspendLayout()
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Location = New System.Drawing.Point(155, 41)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(89, 25)
        Me.cmbCancelar.TabIndex = 1
        Me.cmbCancelar.Text = "Cancelar"
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(59, 41)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(89, 25)
        Me.cmbAceptar.TabIndex = 0
        Me.cmbAceptar.Text = "Aceptar"
        '
        'fwiBancoPropio
        '
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition ID="""" /></RootTable><RowWithErrorsFo" & _
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
        Me.fwiBancoPropio.DesignTimeLayout = GridEXLayout1
        Me.fwiBancoPropio.EntityName = "BancoPropio"
        Me.fwiBancoPropio.Location = New System.Drawing.Point(85, 8)
        Me.fwiBancoPropio.Name = "fwiBancoPropio"
        Me.fwiBancoPropio.SecondaryDataFields = "IDBancoPropio"
        Me.fwiBancoPropio.SelectedIndex = -1
        Me.fwiBancoPropio.SelectedItem = Nothing
        Me.fwiBancoPropio.Size = New System.Drawing.Size(64, 21)
        Me.fwiBancoPropio.TabIndex = 2
        Me.fwiBancoPropio.Value = Nothing
        '
        'lblfwiBancoPropio
        '
        Me.lblfwiBancoPropio.Location = New System.Drawing.Point(6, 8)
        Me.lblfwiBancoPropio.Name = "lblfwiBancoPropio"
        Me.lblfwiBancoPropio.Size = New System.Drawing.Size(78, 17)
        Me.lblfwiBancoPropio.TabIndex = 2
        Me.lblfwiBancoPropio.Tag = "IdRec=4613;"
        Me.lblfwiBancoPropio.Text = "Banco Propio"
        '
        'lblcfwiBancoPropio
        '
        Me.TryDataBinding(lblcfwiBancoPropio, New System.Windows.Forms.Binding("Text", Me.fwiBancoPropio, "DescBancoPropio"))
        Me.lblcfwiBancoPropio.Location = New System.Drawing.Point(152, 8)
        Me.lblcfwiBancoPropio.Name = "lblcfwiBancoPropio"
        Me.lblcfwiBancoPropio.Size = New System.Drawing.Size(142, 21)
        Me.lblcfwiBancoPropio.TabIndex = 3
        '
        'frmSeleccionBanco
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(304, 77)
        Me.Controls.Add(Me.cmbCancelar)
        Me.Controls.Add(Me.cmbAceptar)
        Me.Controls.Add(Me.lblfwiBancoPropio)
        Me.Controls.Add(Me.lblcfwiBancoPropio)
        Me.Controls.Add(Me.fwiBancoPropio)
        Me.Name = "frmSeleccionBanco"
        Me.Text = "Seleccion Banco"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public strBancoPropio As String

    Private Sub cmbCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        strBancoPropio = String.Empty
        Me.Close()
    End Sub

    Private Sub cmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        If length(fwiBancoPropio.Value) = 0 Then
            ExpertisApp.GenerateMessage("El Banco Propio es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            fwiBancoPropio.Focus()
        Else
            strBancoPropio = fwiBancoPropio.Value
            Me.Close()
        End If
    End Sub

End Class
