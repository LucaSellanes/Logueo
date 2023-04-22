<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        Label10 = New Label()
        Button3 = New Button()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        TextBox3 = New TextBox()
        Button5 = New Button()
        Label5 = New Label()
        Label4 = New Label()
        DataGridView1 = New DataGridView()
        TextBox1 = New TextBox()
        TextBox4 = New TextBox()
        TextBox2 = New TextBox()
        Button4 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        TextBox5 = New TextBox()
        TabPage2 = New TabPage()
        Button8 = New Button()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Label6 = New Label()
        Label2 = New Label()
        TextBox8 = New TextBox()
        Button7 = New Button()
        Button6 = New Button()
        DataGridView2 = New DataGridView()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TabControl1.Location = New Point(2, 2)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(959, 673)
        TabControl1.TabIndex = 46
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.FromArgb(CByte(237), CByte(233), CByte(157))
        TabPage1.Controls.Add(ComboBox1)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(Label10)
        TabPage1.Controls.Add(Button3)
        TabPage1.Controls.Add(Label13)
        TabPage1.Controls.Add(Label12)
        TabPage1.Controls.Add(Label11)
        TabPage1.Controls.Add(TextBox3)
        TabPage1.Controls.Add(Button5)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(DataGridView1)
        TabPage1.Controls.Add(TextBox1)
        TabPage1.Controls.Add(TextBox4)
        TabPage1.Controls.Add(TextBox2)
        TabPage1.Controls.Add(Button4)
        TabPage1.Controls.Add(Button2)
        TabPage1.Controls.Add(Button1)
        TabPage1.Controls.Add(TextBox5)
        TabPage1.Location = New Point(4, 30)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(951, 639)
        TabPage1.TabIndex = 0
        TabPage1.Text = "ABM - Usuarios"' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Administrador", "Invitado", "Usuario"})
        ComboBox1.Location = New Point(212, 112)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(225, 29)
        ComboBox1.TabIndex = 52
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(85, 153)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 25)
        Label1.TabIndex = 51
        Label1.Text = "Usuario"' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(85, 112)
        Label10.Name = "Label10"
        Label10.Size = New Size(56, 25)
        Label10.TabIndex = 46
        Label10.Text = "Nivel"' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(103), CByte(242), CByte(209))
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(212, 247)
        Button3.Name = "Button3"
        Button3.Size = New Size(101, 41)
        Button3.TabIndex = 30
        Button3.Text = "Modificar"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(85, 67)
        Label13.Name = "Label13"
        Label13.Size = New Size(68, 25)
        Label13.TabIndex = 50
        Label13.Text = "Legajo"' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(85, 193)
        Label12.Name = "Label12"
        Label12.Size = New Size(108, 25)
        Label12.TabIndex = 49
        Label12.Text = "Contraseña"' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(85, 29)
        Label11.Name = "Label11"
        Label11.Size = New Size(31, 25)
        Label11.TabIndex = 48
        Label11.Text = "ID"' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(212, 196)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(225, 29)
        TextBox3.TabIndex = 34
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(196), CByte(77), CByte(86))
        Button5.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.Location = New Point(336, 556)
        Button5.Name = "Button5"
        Button5.Size = New Size(101, 66)
        Button5.TabIndex = 40
        Button5.Text = "Cerrar Sesión"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(74, 312)
        Label5.Name = "Label5"
        Label5.Size = New Size(171, 21)
        Label5.TabIndex = 41
        Label5.Text = "Busqueda por legajo:"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(74, 389)
        Label4.Name = "Label4"
        Label4.Size = New Size(199, 21)
        Label4.TabIndex = 39
        Label4.Text = "Informacion de usuarios:"' 
        ' DataGridView1
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(6, 422)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopCenter
        DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(482, 128)
        DataGridView1.TabIndex = 27
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(212, 70)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(225, 29)
        TextBox1.TabIndex = 32
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(74, 340)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(225, 29)
        TextBox4.TabIndex = 38
        TextBox4.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(212, 156)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(225, 29)
        TextBox2.TabIndex = 33
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(178), CByte(222), CByte(39))
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(323, 323)
        Button4.Name = "Button4"
        Button4.Size = New Size(114, 60)
        Button4.TabIndex = 31
        Button4.Text = "Mostrar Todos"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(239), CByte(207), CByte(227))
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(336, 247)
        Button2.Name = "Button2"
        Button2.Size = New Size(101, 41)
        Button2.TabIndex = 29
        Button2.Text = "Baja"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(166), CByte(145), CByte(92))
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(85, 247)
        Button1.Name = "Button1"
        Button1.Size = New Size(101, 41)
        Button1.TabIndex = 28
        Button1.Text = "Alta"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(212, 32)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(225, 29)
        TextBox5.TabIndex = 42
        TextBox5.TextAlign = HorizontalAlignment.Center
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.FromArgb(CByte(237), CByte(233), CByte(157))
        TabPage2.Controls.Add(Button8)
        TabPage2.Controls.Add(PictureBox1)
        TabPage2.Controls.Add(Label3)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(Label2)
        TabPage2.Controls.Add(TextBox8)
        TabPage2.Controls.Add(Button7)
        TabPage2.Controls.Add(Button6)
        TabPage2.Controls.Add(DataGridView2)
        TabPage2.Location = New Point(4, 30)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(951, 639)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Listado Usuarios"' 
        ' Button8
        ' 
        Button8.BackColor = Color.FromArgb(CByte(103), CByte(242), CByte(209))
        Button8.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Button8.ForeColor = Color.Black
        Button8.Location = New Point(140, 241)
        Button8.Name = "Button8"
        Button8.Size = New Size(223, 42)
        Button8.TabIndex = 56
        Button8.Text = "Cambiar Contraseña"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(54, 68)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(400, 152)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 55
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cooper Black", 21F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(37), CByte(41), CByte(88))
        Label3.Location = New Point(83, 16)
        Label3.Name = "Label3"
        Label3.Size = New Size(319, 32)
        Label3.TabIndex = 54
        Label3.Text = "USUARIOS ACTIVOS"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(54, 401)
        Label6.Name = "Label6"
        Label6.Size = New Size(225, 25)
        Label6.TabIndex = 53
        Label6.Text = "Información de Usuarios:"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(54, 298)
        Label2.Name = "Label2"
        Label2.Size = New Size(196, 25)
        Label2.TabIndex = 51
        Label2.Text = "Busqueda por Legajo:"' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(54, 339)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(258, 29)
        TextBox8.TabIndex = 44
        TextBox8.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.FromArgb(CByte(178), CByte(222), CByte(39))
        Button7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button7.Location = New Point(340, 322)
        Button7.Name = "Button7"
        Button7.Size = New Size(114, 60)
        Button7.TabIndex = 43
        Button7.Text = "Mostrar Todos"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(CByte(196), CByte(77), CByte(86))
        Button6.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.Location = New Point(353, 571)
        Button6.Name = "Button6"
        Button6.Size = New Size(101, 58)
        Button6.TabIndex = 42
        Button6.Text = "Cerrar Sesión"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(54, 436)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowTemplate.Height = 25
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.Size = New Size(400, 128)
        DataGridView2.TabIndex = 40
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(506, 675)
        Controls.Add(TabControl1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form2"
        Text = "Usuarios"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
