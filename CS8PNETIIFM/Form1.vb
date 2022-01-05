Imports System.IO
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
            MessageBox.Show("Carga de XML: " + cargaArchivoDialog.FileName + " correcta")
            actividadesTXT.Enabled = True
            actividadesXML.Enabled = True

        End If

    End Sub

    Private Sub actividadesTXT_Click(sender As Object, e As EventArgs) Handles actividadesTXT.Click
        Dim escritorTxt As TextWriter = New StreamWriter("C:\Control8\actividades_felipe_mancilla.txt", True, System.Text.Encoding.UTF8)

        For Each row As DataGridViewRow In actividadesGD.Rows
            escritorTxt.WriteLine("id_actividad: " + row.Cells("id_actividad").Value)
            escritorTxt.WriteLine("codsala: " + row.Cells("codsala").Value)
            escritorTxt.WriteLine("nomactividad: " + row.Cells("nomactividad").Value)
            ' escritorTxt.WriteLine("url: " + row.Cells("url").Value)
            escritorTxt.WriteLine("descripcion: " + row.Cells("descripcion").Value)


            escritorTxt.WriteLine("------")
        Next

        escritorTxt.Close()
        MessageBox.Show("Archivo TXT: C:\Control8\actividades_felipe_mancilla.txt creado de forma correcta")
    End Sub


    Private Sub actividadesXML_Click(sender As Object, e As EventArgs) Handles actividadesXML.Click

        Dim escritorXml As XmlWriter = XmlWriter.Create("C:\Control8\actividades_felipe_mancilla.xml")
        escritorXml.WriteStartDocument()
        escritorXml.WriteStartElement("Actividades")

        Dim valorEntrada As Integer

        For row As Integer = 0 To actividadesGD.Rows.Count - 1

            valorEntrada = numAleatorioEntre(1000, 5000)

            If actividadesGD.Rows.Item(row).Cells(0).Value <> "" Then
                escritorXml.WriteStartElement("Actividad")
                escritorXml.WriteElementString("id_actividad", actividadesGD.Rows.Item(row).Cells(0).Value)
                escritorXml.WriteElementString("url", actividadesGD.Rows.Item(row).Cells(2).Value)
                escritorXml.WriteElementString("nomactividad", actividadesGD.Rows.Item(row).Cells(1).Value)
                escritorXml.WriteElementString("descripcion", actividadesGD.Rows.Item(row).Cells(3).Value)
                escritorXml.WriteElementString("valor_entrada", valorEntrada)

                escritorXml.WriteEndElement()
            End If
        Next

        escritorXml.WriteEndElement()
        escritorXml.WriteEndDocument()
        escritorXml.Close()
        MessageBox.Show("Archivo XML: C:\Control8\actividades_felipe_mancilla.xml creado de forma correcta")


    End Sub

    Function numAleatorioEntre(ByVal minimo As Integer, ByVal maximo As Integer) As Integer
        Randomize()
        Return CLng((minimo - maximo) * Rnd() + maximo)
    End Function
End Class
