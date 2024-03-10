Imports System.Windows.Forms.DataVisualization.Charting


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvTable.Rows.Add("Sequential", "Low", "Medium", "Low", "High")
        dgvTable.Rows.Add("Direct", "Medium", "Low", "Medium", "Low")
        dgvTable.Rows.Add("Indexed", "High", "High", "High", "Medium")

    End Sub



    Private Sub GraficarOrganizacion(cg As Chart, row As DataRow, colors As Color())
        ' Crear una nueva tabla para obtener el nombre de las columnas
        Dim dataTable As DataTable = row.Table

        Dim organizacion As String = row.Field(Of String)("File Organization")

        ' Verificar si hay al menos una serie en el gráfico
        If cg.Series.Count > 0 Then
            ' Limpiar la serie existente si la hay
            cg.Series.Clear()
        End If

        ' Crear una serie para la organización actual
        Dim serie As New Series(organizacion)
        serie.ChartType = SeriesChartType.Radar

        ' Agregar los puntos al gráfico (estadísticas y sus valores)
        For i As Integer = 1 To row.ItemArray.Length - 1
            Dim estadistica As String = dataTable.Columns(i).ColumnName ' Obtener el nombre de la columna
            Dim valor As String = row.Field(Of String)(estadistica)
            Dim valorNumerico As Integer = Me.ValorNumerico(valor) ' Convertir la etiqueta a un valor numérico
            Dim point As DataPoint = serie.Points.Add(valorNumerico)
            point.AxisLabel = estadistica
            point.Color = colors(i - 1)
        Next

        ' Agregar la serie al gráfico
        cg.Series.Add(serie)
    End Sub

    ' Método para convertir etiquetas "Low", "Medium", "High" a valores numéricos
    Private Function ValorNumerico(etiqueta As String) As Integer
        Select Case etiqueta
            Case "Low"
                Return 1
            Case "Medium"
                Return 2
            Case "High"
                Return 3
            Case Else
                Return 0
        End Select
    End Function

    Private Sub btnUpdate_Click_1(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Limpiar los gráficos antes de agregar nuevos datos
        chDirect.Series.Clear()
        chSequential.Series.Clear()
        Chart3.Series.Clear()

        ' Obtener los datos del DataGridView
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("File Organization", GetType(String))
        dataTable.Columns.Add("Initial Cost", GetType(String))
        dataTable.Columns.Add("Operating Cost", GetType(String))
        dataTable.Columns.Add("Security Level", GetType(String))
        dataTable.Columns.Add("Ease of Access", GetType(String))

        ' Agregar datos de ejemplo
        dataTable.Rows.Add("Sequential", "Low", "Medium", "Low", "High")
        dataTable.Rows.Add("Direct", "Medium", "Low", "Medium", "Low")
        dataTable.Rows.Add("Indexed", "High", "High", "High", "Medium")

        ' Definir los colores para cada estadística
        Dim colors() As Color = {Color.Blue, Color.Red, Color.Green, Color.Orange}

        ' Graficar cada organización en su respectivo chart
        GraficarOrganizacion(chSequential, dataTable.Rows(0), colors)
        GraficarOrganizacion(chDirect, dataTable.Rows(1), colors)
        GraficarOrganizacion(Chart3, dataTable.Rows(2), colors)
    End Sub
End Class
