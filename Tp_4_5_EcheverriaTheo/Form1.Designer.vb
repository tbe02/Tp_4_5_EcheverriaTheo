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
        LDesde = New Label()
        LHasta = New Label()
        BGenerarLista = New Button()
        TBDesde = New TextBox()
        TBHasta = New TextBox()
        LBListaNumeros = New ListBox()
        LListaNumeros = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        BNumerosPares = New Button()
        BNumerosImpares = New Button()
        BNumerosPrimos = New Button()
        SqlCommand1 = New Microsoft.Data.SqlClient.SqlCommand()
        SuspendLayout()
        ' 
        ' LDesde
        ' 
        LDesde.AutoSize = True
        LDesde.Location = New Point(83, 109)
        LDesde.Name = "LDesde"
        LDesde.Size = New Size(39, 15)
        LDesde.TabIndex = 0
        LDesde.Text = "Desde"
        ' 
        ' LHasta
        ' 
        LHasta.AutoSize = True
        LHasta.Location = New Point(85, 147)
        LHasta.Name = "LHasta"
        LHasta.Size = New Size(37, 15)
        LHasta.TabIndex = 1
        LHasta.Text = "Hasta"
        ' 
        ' BGenerarLista
        ' 
        BGenerarLista.Location = New Point(85, 178)
        BGenerarLista.Name = "BGenerarLista"
        BGenerarLista.Size = New Size(115, 40)
        BGenerarLista.TabIndex = 2
        BGenerarLista.Text = "Generar lista"
        BGenerarLista.UseVisualStyleBackColor = True
        ' 
        ' TBDesde
        ' 
        TBDesde.Location = New Point(144, 101)
        TBDesde.Name = "TBDesde"
        TBDesde.Size = New Size(100, 23)
        TBDesde.TabIndex = 3
        ' 
        ' TBHasta
        ' 
        TBHasta.Location = New Point(144, 139)
        TBHasta.Name = "TBHasta"
        TBHasta.Size = New Size(100, 23)
        TBHasta.TabIndex = 4
        ' 
        ' LBListaNumeros
        ' 
        LBListaNumeros.FormattingEnabled = True
        LBListaNumeros.ItemHeight = 15
        LBListaNumeros.Location = New Point(259, 101)
        LBListaNumeros.Name = "LBListaNumeros"
        LBListaNumeros.Size = New Size(227, 259)
        LBListaNumeros.TabIndex = 5
        ' 
        ' LListaNumeros
        ' 
        LListaNumeros.AutoSize = True
        LListaNumeros.Location = New Point(317, 83)
        LListaNumeros.Name = "LListaNumeros"
        LListaNumeros.Size = New Size(97, 15)
        LListaNumeros.TabIndex = 6
        LListaNumeros.Text = "Lista de numeros"
        ' 
        ' BNumerosPares
        ' 
        BNumerosPares.Location = New Point(85, 224)
        BNumerosPares.Name = "BNumerosPares"
        BNumerosPares.Size = New Size(115, 40)
        BNumerosPares.TabIndex = 7
        BNumerosPares.Text = "Numeros pares"
        BNumerosPares.UseVisualStyleBackColor = True
        ' 
        ' BNumerosImpares
        ' 
        BNumerosImpares.Location = New Point(85, 275)
        BNumerosImpares.Name = "BNumerosImpares"
        BNumerosImpares.Size = New Size(115, 40)
        BNumerosImpares.TabIndex = 8
        BNumerosImpares.Text = "Numeros impares"
        BNumerosImpares.UseVisualStyleBackColor = True
        ' 
        ' BNumerosPrimos
        ' 
        BNumerosPrimos.Location = New Point(85, 321)
        BNumerosPrimos.Name = "BNumerosPrimos"
        BNumerosPrimos.Size = New Size(115, 40)
        BNumerosPrimos.TabIndex = 9
        BNumerosPrimos.Text = "Numeros primos"
        BNumerosPrimos.UseVisualStyleBackColor = True
        ' 
        ' SqlCommand1
        ' 
        SqlCommand1.CommandTimeout = 30
        SqlCommand1.Connection = Nothing
        SqlCommand1.Notification = Nothing
        SqlCommand1.Transaction = Nothing
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(966, 450)
        Controls.Add(BNumerosPrimos)
        Controls.Add(BNumerosImpares)
        Controls.Add(BNumerosPares)
        Controls.Add(LListaNumeros)
        Controls.Add(LBListaNumeros)
        Controls.Add(TBHasta)
        Controls.Add(TBDesde)
        Controls.Add(BGenerarLista)
        Controls.Add(LHasta)
        Controls.Add(LDesde)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LDesde As Label
    Friend WithEvents LHasta As Label
    Friend WithEvents BGenerarLista As Button
    Friend WithEvents TBDesde As TextBox
    Friend WithEvents TBHasta As TextBox
    Friend WithEvents LBListaNumeros As ListBox
    Friend WithEvents LListaNumeros As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BNumerosPares As Button
    Friend WithEvents BNumerosImpares As Button
    Friend WithEvents BNumerosPrimos As Button
    Friend WithEvents SqlCommand1 As Microsoft.Data.SqlClient.SqlCommand

End Class
