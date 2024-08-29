<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        BAgregar = New Button()
        Panel1 = New Panel()
        RBMujer = New RadioButton()
        RBHombre = New RadioButton()
        TBFoto = New TextBox()
        BFoto = New Button()
        TBSaldo = New TextBox()
        LSaldo = New Label()
        LSexo = New Label()
        TBApellido = New TextBox()
        TBNombre = New TextBox()
        LFechaNac = New Label()
        LApellido = New Label()
        LNombre = New Label()
        DTPFechaNac = New DateTimePicker()
        PBFoto = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        DataGrid = New DataGridView()
        Panel1.SuspendLayout()
        CType(PBFoto, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BAgregar
        ' 
        BAgregar.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        BAgregar.Image = My.Resources.Resources.disquette_icon_icons_com_58507
        BAgregar.ImageAlign = ContentAlignment.MiddleLeft
        BAgregar.Location = New Point(187, 425)
        BAgregar.Name = "BAgregar"
        BAgregar.Size = New Size(144, 73)
        BAgregar.TabIndex = 0
        BAgregar.Text = "Agregar"
        BAgregar.TextAlign = ContentAlignment.MiddleRight
        BAgregar.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BackgroundImage = My.Resources.Resources.fondo2
        Panel1.Controls.Add(RBMujer)
        Panel1.Controls.Add(RBHombre)
        Panel1.Controls.Add(TBFoto)
        Panel1.Controls.Add(BFoto)
        Panel1.Controls.Add(TBSaldo)
        Panel1.Controls.Add(LSaldo)
        Panel1.Controls.Add(LSexo)
        Panel1.Controls.Add(TBApellido)
        Panel1.Controls.Add(TBNombre)
        Panel1.Controls.Add(LFechaNac)
        Panel1.Controls.Add(LApellido)
        Panel1.Controls.Add(LNombre)
        Panel1.Controls.Add(DTPFechaNac)
        Panel1.Controls.Add(BAgregar)
        Panel1.Location = New Point(113, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(529, 520)
        Panel1.TabIndex = 1
        ' 
        ' RBMujer
        ' 
        RBMujer.AutoSize = True
        RBMujer.Location = New Point(239, 221)
        RBMujer.Name = "RBMujer"
        RBMujer.Size = New Size(88, 37)
        RBMujer.TabIndex = 15
        RBMujer.Text = "Mujer"
        RBMujer.UseVisualStyleBackColor = True
        ' 
        ' RBHombre
        ' 
        RBHombre.AutoSize = True
        RBHombre.Checked = True
        RBHombre.Location = New Point(117, 221)
        RBHombre.Name = "RBHombre"
        RBHombre.Size = New Size(107, 37)
        RBHombre.TabIndex = 14
        RBHombre.TabStop = True
        RBHombre.Text = "Hombre"
        RBHombre.UseVisualStyleBackColor = True
        ' 
        ' TBFoto
        ' 
        TBFoto.Location = New Point(127, 354)
        TBFoto.Name = "TBFoto"
        TBFoto.Size = New Size(321, 41)
        TBFoto.TabIndex = 13
        ' 
        ' BFoto
        ' 
        BFoto.ForeColor = Color.Black
        BFoto.Location = New Point(20, 359)
        BFoto.Name = "BFoto"
        BFoto.Size = New Size(79, 36)
        BFoto.TabIndex = 12
        BFoto.Text = "Foto"
        BFoto.UseVisualStyleBackColor = True
        ' 
        ' TBSaldo
        ' 
        TBSaldo.Location = New Point(127, 275)
        TBSaldo.Name = "TBSaldo"
        TBSaldo.Size = New Size(321, 41)
        TBSaldo.TabIndex = 11
        ' 
        ' LSaldo
        ' 
        LSaldo.AutoSize = True
        LSaldo.BackColor = Color.Transparent
        LSaldo.Font = New Font("Papyrus", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LSaldo.Location = New Point(20, 283)
        LSaldo.Name = "LSaldo"
        LSaldo.Size = New Size(79, 33)
        LSaldo.TabIndex = 10
        LSaldo.Text = "Saldo"
        ' 
        ' LSexo
        ' 
        LSexo.AutoSize = True
        LSexo.BackColor = Color.Transparent
        LSexo.Font = New Font("Papyrus", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LSexo.Location = New Point(20, 225)
        LSexo.Name = "LSexo"
        LSexo.Size = New Size(70, 33)
        LSexo.TabIndex = 7
        LSexo.Text = "Sexo"
        ' 
        ' TBApellido
        ' 
        TBApellido.Location = New Point(171, 82)
        TBApellido.Name = "TBApellido"
        TBApellido.Size = New Size(277, 41)
        TBApellido.TabIndex = 6
        ' 
        ' TBNombre
        ' 
        TBNombre.Location = New Point(171, 24)
        TBNombre.Name = "TBNombre"
        TBNombre.Size = New Size(277, 41)
        TBNombre.TabIndex = 5
        ' 
        ' LFechaNac
        ' 
        LFechaNac.AutoSize = True
        LFechaNac.BackColor = Color.Transparent
        LFechaNac.Font = New Font("Papyrus", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LFechaNac.Location = New Point(20, 153)
        LFechaNac.Name = "LFechaNac"
        LFechaNac.Size = New Size(225, 33)
        LFechaNac.TabIndex = 4
        LFechaNac.Text = "Fecha de Nacimiento"
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.BackColor = Color.Transparent
        LApellido.Font = New Font("Papyrus", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LApellido.Location = New Point(20, 90)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(102, 33)
        LApellido.TabIndex = 3
        LApellido.Text = "Apellido"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.BackColor = Color.Transparent
        LNombre.Font = New Font("Papyrus", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LNombre.Location = New Point(20, 32)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(94, 33)
        LNombre.TabIndex = 2
        LNombre.Text = "Nombre"
        ' 
        ' DTPFechaNac
        ' 
        DTPFechaNac.Format = DateTimePickerFormat.Short
        DTPFechaNac.Location = New Point(251, 145)
        DTPFechaNac.Name = "DTPFechaNac"
        DTPFechaNac.Size = New Size(160, 41)
        DTPFechaNac.TabIndex = 1
        ' 
        ' PBFoto
        ' 
        PBFoto.BackgroundImage = My.Resources.Resources.batman_90804__1_
        PBFoto.BackgroundImageLayout = ImageLayout.Center
        PBFoto.Location = New Point(660, 12)
        PBFoto.Name = "PBFoto"
        PBFoto.Size = New Size(254, 258)
        PBFoto.TabIndex = 2
        PBFoto.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' DataGrid
        ' 
        DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGrid.Location = New Point(27, 551)
        DataGrid.Name = "DataGrid"
        DataGrid.Size = New Size(1098, 200)
        DataGrid.TabIndex = 3
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(14F, 33F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.cuadrados_negros
        ClientSize = New Size(1137, 763)
        Controls.Add(DataGrid)
        Controls.Add(PBFoto)
        Controls.Add(Panel1)
        Font = New Font("Papyrus", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.White
        Margin = New Padding(6, 7, 6, 7)
        Name = "Form2"
        Text = "Formulario con Grid"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PBFoto, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BAgregar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PBFoto As PictureBox
    Friend WithEvents DTPFechaNac As DateTimePicker
    Friend WithEvents LApellido As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LSexo As Label
    Friend WithEvents TBApellido As TextBox
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents LFechaNac As Label
    Friend WithEvents TBFoto As TextBox
    Friend WithEvents BFoto As Button
    Friend WithEvents TBSaldo As TextBox
    Friend WithEvents LSaldo As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents RBMujer As RadioButton
    Friend WithEvents RBHombre As RadioButton
    Friend WithEvents DataGrid As DataGridView
End Class
