Public Class Form1

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles LListaNumeros.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BGenerarLista.Click
        Dim desde, hasta As Integer
        Dim numeroDesdeValido, numeroHastaValido As Boolean


        Dim textoDesde As String = TBDesde.Text
        Dim textoHasta As String = TBHasta.Text

        If String.IsNullOrWhiteSpace(textoDesde) Or String.IsNullOrWhiteSpace(textoHasta) Then
            MessageBox.Show("Debe completar todos los campos.", "Falta de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        numeroDesdeValido = Integer.TryParse(textoDesde, desde)
        numeroHastaValido = Integer.TryParse(textoHasta, hasta)


        If Not numeroDesdeValido Or Not numeroHastaValido Then

            MessageBox.Show("Solo se aceptan números.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            LBListaNumeros.Items.Clear()
            Chart1.Series("Datos").Points.Clear()

            For contador As Integer = desde To hasta
                LBListaNumeros.Items.Add(contador)
                Chart1.Series("Datos").Points.AddXY(contador, contador)
            Next
        End If
    End Sub


    Private Sub BNumerosPares_Click(sender As Object, e As EventArgs) Handles BNumerosPares.Click
        Dim desde, hasta As Integer
        Dim numeroDesdeValido, numeroHastaValido As Boolean


        Dim textoDesde As String = TBDesde.Text
        Dim textoHasta As String = TBHasta.Text

        If String.IsNullOrWhiteSpace(textoDesde) Or String.IsNullOrWhiteSpace(textoHasta) Then
            MessageBox.Show("Debe completar todos los campos.", "Falta de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        numeroDesdeValido = Integer.TryParse(textoDesde, desde)
        numeroHastaValido = Integer.TryParse(textoHasta, hasta)


        If Not numeroDesdeValido Or Not numeroHastaValido Then

            MessageBox.Show("Solo se aceptan números.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            LBListaNumeros.Items.Clear()
            Chart1.Series("Datos").Points.Clear()


            For contador = desde To hasta
                If (contador Mod 2 = 0) Then
                    LBListaNumeros.Items.Add(contador)
                    Chart1.Series("Datos").Points.AddXY(contador, contador)
                End If
            Next contador

        End If
    End Sub

    Private Sub BNumerosImpares_Click(sender As Object, e As EventArgs) Handles BNumerosImpares.Click
        Dim desde, hasta As Integer
        Dim numeroDesdeValido, numeroHastaValido As Boolean


        Dim textoDesde As String = TBDesde.Text
        Dim textoHasta As String = TBHasta.Text

        If String.IsNullOrWhiteSpace(textoDesde) Or String.IsNullOrWhiteSpace(textoHasta) Then
            MessageBox.Show("Debe completar todos los campos.", "Falta de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        numeroDesdeValido = Integer.TryParse(textoDesde, desde)
        numeroHastaValido = Integer.TryParse(textoHasta, hasta)


        If Not numeroDesdeValido Or Not numeroHastaValido Then

            MessageBox.Show("Solo se aceptan números.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            LBListaNumeros.Items.Clear()
            Chart1.Series("Datos").Points.Clear()

            For contador = desde To hasta
                If (contador Mod 2 <> 0) Then
                    LBListaNumeros.Items.Add(contador)
                    Chart1.Series("Datos").Points.AddXY(contador, contador)
                End If
            Next contador

        End If
    End Sub

    Private Sub BNumerosPrimos_Click(sender As Object, e As EventArgs) Handles BNumerosPrimos.Click
        Dim desde, hasta As Integer
        Dim numeroDesdeValido, numeroHastaValido As Boolean


        Dim textoDesde As String = TBDesde.Text
        Dim textoHasta As String = TBHasta.Text

        If String.IsNullOrWhiteSpace(textoDesde) Or String.IsNullOrWhiteSpace(textoHasta) Then
            MessageBox.Show("Debe completar todos los campos.", "Falta de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        numeroDesdeValido = Integer.TryParse(textoDesde, desde)
        numeroHastaValido = Integer.TryParse(textoHasta, hasta)


        If Not numeroDesdeValido Or Not numeroHastaValido Then

            MessageBox.Show("Solo se aceptan números.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            LBListaNumeros.Items.Clear()
            Chart1.Series("Datos").Points.Clear()

            For contador As Integer = desde To hasta
                If EsPrimo(contador) Then
                    LBListaNumeros.Items.Add(contador)
                    Chart1.Series("Datos").Points.AddXY(contador, contador)
                End If
            Next contador

        End If
    End Sub

    Function EsPrimo(n As Integer) As Boolean
        If n <= 1 Then Return False
        If n <= 3 Then Return True
        If n Mod 2 = 0 Or n Mod 3 = 0 Then Return False

        Dim i As Integer = 5
        While i * i <= n
            If n Mod i = 0 Or n Mod (i + 2) = 0 Then Return False
            i += 6
        End While

        Return True
    End Function


    Private WithEvents Chart1 As New DataVisualization.Charting.Chart()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Chart1 = New DataVisualization.Charting.Chart()
        Chart1.ChartAreas.Add(New DataVisualization.Charting.ChartArea())


        Chart1.Size = New Size(400, 300)
        Chart1.Location = New Point(500, 60)

        Me.Controls.Add(Chart1)

        Dim series As New DataVisualization.Charting.Series("Datos")
        series.ChartType = DataVisualization.Charting.SeriesChartType.Column
        Chart1.Series.Add(series)





    End Sub
End Class
