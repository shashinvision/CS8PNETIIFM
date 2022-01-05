Imports System.Xml
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cargaArchivoDialog.ShowDialog()

        If cargaArchivoDialog.FileName <> "" Then
            ' MessageBox.Show(cargaArchivoDialog.FileName)
            Dim actividadXML As XmlReader
            actividadXML = XmlReader.Create("C:\iacc\actividad.xml", New XmlReaderSettings())
            Dim dataSet As New DataSet

            dataSet.ReadXml(actividadXML)
            actividadesGD.DataSource = dataSet.Tables(0)

        End If

    End Sub
End Class
