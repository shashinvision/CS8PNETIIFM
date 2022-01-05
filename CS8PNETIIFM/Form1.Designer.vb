<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cargaArchivoDialog = New System.Windows.Forms.OpenFileDialog()
        Me.actividadesGD = New System.Windows.Forms.DataGridView()
        Me.actividadesTXT = New System.Windows.Forms.Button()
        Me.actividadesXML = New System.Windows.Forms.Button()
        CType(Me.actividadesGD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(58, 42)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Cargar XML"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'actividadesGD
        '
        Me.actividadesGD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.actividadesGD.Location = New System.Drawing.Point(58, 101)
        Me.actividadesGD.Name = "actividadesGD"
        Me.actividadesGD.RowHeadersWidth = 51
        Me.actividadesGD.RowTemplate.Height = 29
        Me.actividadesGD.Size = New System.Drawing.Size(829, 247)
        Me.actividadesGD.TabIndex = 1
        '
        'actividadesTXT
        '
        Me.actividadesTXT.Enabled = False
        Me.actividadesTXT.Location = New System.Drawing.Point(247, 42)
        Me.actividadesTXT.Margin = New System.Windows.Forms.Padding(2)
        Me.actividadesTXT.Name = "actividadesTXT"
        Me.actividadesTXT.Size = New System.Drawing.Size(230, 27)
        Me.actividadesTXT.TabIndex = 2
        Me.actividadesTXT.Text = "Crear TXT Actividades"
        Me.actividadesTXT.UseVisualStyleBackColor = True
        '
        'actividadesXML
        '
        Me.actividadesXML.Enabled = False
        Me.actividadesXML.Location = New System.Drawing.Point(503, 42)
        Me.actividadesXML.Margin = New System.Windows.Forms.Padding(2)
        Me.actividadesXML.Name = "actividadesXML"
        Me.actividadesXML.Size = New System.Drawing.Size(230, 27)
        Me.actividadesXML.TabIndex = 3
        Me.actividadesXML.Text = "Crear XML Actividades"
        Me.actividadesXML.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 428)
        Me.Controls.Add(Me.actividadesXML)
        Me.Controls.Add(Me.actividadesTXT)
        Me.Controls.Add(Me.actividadesGD)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Actividades - Felipe Mancilla"
        CType(Me.actividadesGD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents cargaArchivoDialog As OpenFileDialog
    Friend WithEvents actividadesGD As DataGridView
    Friend WithEvents actividadesTXT As Button
    Friend WithEvents actividadesXML As Button
End Class
