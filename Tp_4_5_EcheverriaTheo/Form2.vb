Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Windows.Win32.System

Public Class Form2
    Private Sub BFoto_Click(sender As Object, e As EventArgs) Handles BFoto.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PBFoto.Image = Image.FromFile(OpenFileDialog1.FileName)
            TBFoto.Text = OpenFileDialog1.FileName
        End If
        PBFoto.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub


    Private Sub TBNombre_TextChanged(sender As Object, e As EventArgs) Handles TBNombre.TextChanged
        If TBNombre.Text.Length > 0 Then

            Dim firstChar As String = TBNombre.Text.Substring(0, 1).ToUpper()
            Dim restOfText As String = TBNombre.Text.Substring(1).ToLower()
            TBNombre.Text = firstChar & restOfText

            TBNombre.SelectionStart = TBNombre.Text.Length
        End If
    End Sub

    Private Sub TBApellido_TextChanged(sender As Object, e As EventArgs) Handles TBApellido.TextChanged
        If TBApellido.Text.Length > 0 Then

            Dim firstChar As String = TBApellido.Text.Substring(0, 1).ToUpper()
            Dim restOfText As String = TBApellido.Text.Substring(1).ToLower()
            TBApellido.Text = firstChar & restOfText

            TBApellido.SelectionStart = TBApellido.Text.Length
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click

        Dim nombre As String = TBNombre.Text
        Dim apellido As String = TBApellido.Text
        Dim fechaNac As String = DTPFechaNac.Text

        Dim sexo As String

        If RBHombre.Checked Then
            sexo = "Hombre"
        Else
            sexo = "Mujer"
        End If

        Dim numero As Decimal
        Dim saldo As Decimal

        Dim ruta As String = TBFoto.Text
        Dim imagen As Image = PBFoto.Image
        Dim imagenRedimensionada As Image = ResizeImage(imagen, 100, 100)



        If String.IsNullOrWhiteSpace(nombre) Or String.IsNullOrWhiteSpace(apellido) Or String.IsNullOrWhiteSpace(sexo) Or String.IsNullOrWhiteSpace(saldo) Or String.IsNullOrWhiteSpace(ruta) Or PBFoto.Image Is Nothing Then
            MessageBox.Show("Debe completar todos los campos.", "Falta de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If



        If Not Decimal.TryParse(TBSaldo.Text, numero) Then

            MessageBox.Show("Por favor, ingrese un número válido para el saldo.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        saldo = TBSaldo.Text



        DataGrid.ForeColor = Color.Black
        DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells



        Dim rowIndex As Integer = DataGrid.Rows.Add(nombre, apellido, fechaNac, sexo, "Eliminar", saldo.ToString(), imagenRedimensionada, ruta)

        If saldo < 50 Then
            DataGrid.Rows(rowIndex).DefaultCellStyle.BackColor = Color.Red
        End If

        DataGrid.Columns("DGVNombre").DefaultCellStyle.Font = New Font("Arial", 12, FontStyle.Bold)
        DataGrid.Columns("DGVApellido").DefaultCellStyle.Font = New Font("Verdana", 10, FontStyle.Italic)

        TBNombre.Clear()
            TBApellido.Clear()
            DTPFechaNac.Value = DateTime.Now
            RBHombre.Checked = True
            TBSaldo.Clear()
            TBFoto.Clear()
            PBFoto.Image = Nothing


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim colNombre, colApellido, colFecha, colSexo, colSaldo, colRuta As New DataGridViewTextBoxColumn()
        Dim colImagen As New DataGridViewImageColumn()
        Dim colEliminar As New DataGridViewButtonColumn()

        colNombre.HeaderText = "Nombre"
        colNombre.Name = "DGVNombre"

        colApellido.HeaderText = "Apellido"
        colApellido.Name = "DGVApellido"

        colFecha.HeaderText = "Fecha"
        colFecha.Name = "DGVFecha"

        colSexo.HeaderText = "Sexo"
        colSexo.Name = "DGVSexo"


        colEliminar.HeaderText = "Eliminar"
        colEliminar.Name = "DGVEliminar"
        colEliminar.Text = "Eliminar"
        colEliminar.UseColumnTextForButtonValue = True

        colSaldo.HeaderText = "Saldo"
        colSaldo.Name = "DGVSaldo"

        colImagen.HeaderText = "Imagen"
        colImagen.Name = "DGVImagen"



        colRuta.HeaderText = "Ruta"
        colRuta.Name = "DGVRuta"

        DataGrid.RowTemplate.Height = 100


        DataGrid.Columns.Add(colNombre)
        DataGrid.Columns.Add(colApellido)
        DataGrid.Columns.Add(colFecha)
        DataGrid.Columns.Add(colSexo)
        DataGrid.Columns.Add(colEliminar)
        DataGrid.Columns.Add(colSaldo)
        DataGrid.Columns.Add(colImagen)
        DataGrid.Columns.Add(colRuta)




    End Sub

    Private Function ResizeImage(ByVal image As Image, ByVal width As Integer, ByVal height As Integer) As Image
        If image Is Nothing Then Return Nothing


        Dim resizedImage As New Bitmap(width, height)
        Using g As Graphics = Graphics.FromImage(resizedImage)
            g.DrawImage(image, 0, 0, width, height)
        End Using
        Return resizedImage
    End Function

    Private Sub DataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellClick

        If e.RowIndex >= 0 AndAlso e.ColumnIndex = DataGrid.Columns("DGVEliminar").Index Then

            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar esta fila?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then

                DataGrid.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub

End Class