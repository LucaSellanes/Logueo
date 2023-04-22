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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Label11 = New Label()
        Button5 = New Button()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        Label6 = New Label()
        ProgressBar1 = New ProgressBar()
        Label4 = New Label()
        Label1 = New Label()
        CheckBox1 = New CheckBox()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        TabPage2 = New TabPage()
        PictureBox2 = New PictureBox()
        Button6 = New Button()
        Label5 = New Label()
        Label12 = New Label()
        Button2 = New Button()
        Label3 = New Label()
        TextBox3 = New TextBox()
        TabPage3 = New TabPage()
        PictureBox3 = New PictureBox()
        Label8 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label13 = New Label()
        Button7 = New Button()
        TextBox6 = New TextBox()
        Button4 = New Button()
        CheckBox2 = New CheckBox()
        Button3 = New Button()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Timer1 = New Timer(components)
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(736, 393)
        TabControl1.TabIndex = 7
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.FromArgb(CByte(237), CByte(233), CByte(157))
        TabPage1.Controls.Add(Label11)
        TabPage1.Controls.Add(Button5)
        TabPage1.Controls.Add(PictureBox1)
        TabPage1.Controls.Add(Label7)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(ProgressBar1)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(CheckBox1)
        TabPage1.Controls.Add(Button1)
        TabPage1.Controls.Add(TextBox1)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(TextBox2)
        TabPage1.Location = New Point(4, 30)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(728, 359)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Inicio"' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(491, 336)
        Label11.Name = "Label11"
        Label11.Size = New Size(87, 21)
        Label11.TabIndex = 21
        Label11.Text = "Establecida"' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(196), CByte(77), CByte(86))
        Button5.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.Location = New Point(542, 196)
        Button5.Name = "Button5"
        Button5.Size = New Size(101, 42)
        Button5.TabIndex = 20
        Button5.Text = "Salir"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(19, 20)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(278, 316)
        PictureBox1.TabIndex = 19
        PictureBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(495, 315)
        Label7.Name = "Label7"
        Label7.Size = New Size(93, 21)
        Label7.TabIndex = 18
        Label7.Text = "Conectando"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(318, 315)
        Label6.Name = "Label6"
        Label6.Size = New Size(36, 21)
        Label6.TabIndex = 17
        Label6.Text = "0 %"' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(318, 279)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(395, 23)
        ProgressBar1.TabIndex = 16
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cooper Black", 21F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(37), CByte(41), CByte(88))
        Label4.Location = New Point(401, 20)
        Label4.Name = "Label4"
        Label4.Size = New Size(282, 32)
        Label4.TabIndex = 15
        Label4.Text = "INICIO DE SESION"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(303, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 25)
        Label1.TabIndex = 12
        Label1.Text = "Usuario"' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox1.Location = New Point(645, 127)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(77, 23)
        CheckBox1.TabIndex = 14
        CheckBox1.Text = "Mostrar"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        Button1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(413, 196)
        Button1.Name = "Button1"
        Button1.Size = New Size(101, 42)
        Button1.TabIndex = 9
        Button1.Text = "Ingresar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(413, 79)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(230, 29)
        TextBox1.TabIndex = 10
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(303, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 25)
        Label2.TabIndex = 13
        Label2.Text = "Contraseña"' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(413, 121)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(230, 29)
        TextBox2.TabIndex = 11
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        TabPage2.Controls.Add(PictureBox2)
        TabPage2.Controls.Add(Button6)
        TabPage2.Controls.Add(Label5)
        TabPage2.Controls.Add(Label12)
        TabPage2.Controls.Add(Button2)
        TabPage2.Controls.Add(Label3)
        TabPage2.Controls.Add(TextBox3)
        TabPage2.ForeColor = SystemColors.ControlDarkDark
        TabPage2.Location = New Point(4, 30)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(728, 359)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Recuperar Contraseña"' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(437, 13)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(283, 329)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 22
        PictureBox2.TabStop = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(CByte(196), CByte(77), CByte(86))
        Button6.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.ForeColor = SystemColors.ControlText
        Button6.Location = New Point(233, 251)
        Button6.Name = "Button6"
        Button6.Size = New Size(101, 42)
        Button6.TabIndex = 21
        Button6.Text = "Salir"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(37), CByte(41), CByte(88))
        Label5.Location = New Point(82, 127)
        Label5.Name = "Label5"
        Label5.Size = New Size(269, 25)
        Label5.TabIndex = 18
        Label5.Text = "enviará  la nueva contraseña:"' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Cooper Black", 21F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.ForeColor = Color.FromArgb(CByte(37), CByte(41), CByte(88))
        Label12.Location = New Point(8, 30)
        Label12.Name = "Label12"
        Label12.Size = New Size(423, 32)
        Label12.TabIndex = 17
        Label12.Text = "RECUPERAR CONTRASEÑA"' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        Button2.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ControlText
        Button2.Location = New Point(89, 251)
        Button2.Name = "Button2"
        Button2.Size = New Size(101, 42)
        Button2.TabIndex = 14
        Button2.Text = "Enviar"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(37), CByte(41), CByte(88))
        Label3.Location = New Point(89, 102)
        Label3.Name = "Label3"
        Label3.Size = New Size(253, 25)
        Label3.TabIndex = 13
        Label3.Text = "Ingrese el correo donde se "' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(60, 176)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(300, 29)
        TextBox3.TabIndex = 1
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.FromArgb(CByte(137), CByte(196), CByte(244))
        TabPage3.Controls.Add(PictureBox3)
        TabPage3.Controls.Add(Label8)
        TabPage3.Controls.Add(Label14)
        TabPage3.Controls.Add(Label15)
        TabPage3.Controls.Add(Label13)
        TabPage3.Controls.Add(Button7)
        TabPage3.Controls.Add(TextBox6)
        TabPage3.Controls.Add(Button4)
        TabPage3.Controls.Add(CheckBox2)
        TabPage3.Controls.Add(Button3)
        TabPage3.Controls.Add(TextBox4)
        TabPage3.Controls.Add(TextBox5)
        TabPage3.Location = New Point(4, 30)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(728, 359)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Ingresar como Invitado"' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(454, 21)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(266, 313)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 29
        PictureBox3.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(24, 78)
        Label8.Name = "Label8"
        Label8.Size = New Size(107, 25)
        Label8.TabIndex = 28
        Label8.Text = "ID Invitado"' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(24, 124)
        Label14.Name = "Label14"
        Label14.Size = New Size(77, 25)
        Label14.TabIndex = 26
        Label14.Text = "Usuario"' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(24, 163)
        Label15.Name = "Label15"
        Label15.Size = New Size(108, 25)
        Label15.TabIndex = 27
        Label15.Text = "Contraseña"' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Cooper Black", 21F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.ForeColor = Color.FromArgb(CByte(37), CByte(41), CByte(88))
        Label13.Location = New Point(14, 21)
        Label13.Name = "Label13"
        Label13.Size = New Size(434, 32)
        Label13.TabIndex = 25
        Label13.Text = "INGRESAR COMO INVITADO"' 
        ' Button7
        ' 
        Button7.BackColor = Color.FromArgb(CByte(196), CByte(77), CByte(86))
        Button7.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Button7.ForeColor = SystemColors.ControlText
        Button7.Location = New Point(248, 292)
        Button7.Name = "Button7"
        Button7.Size = New Size(101, 42)
        Button7.TabIndex = 24
        Button7.Text = "Salir"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' TextBox6
        ' 
        TextBox6.Enabled = False
        TextBox6.Location = New Point(136, 81)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(209, 29)
        TextBox6.TabIndex = 22
        TextBox6.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(237), CByte(233), CByte(157))
        Button4.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = Color.Black
        Button4.Location = New Point(126, 227)
        Button4.Name = "Button4"
        Button4.Size = New Size(223, 42)
        Button4.TabIndex = 21
        Button4.Text = "Alta Invitado"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox2.Location = New Point(351, 170)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(77, 23)
        CheckBox2.TabIndex = 20
        CheckBox2.Text = "Mostrar"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        Button3.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.Black
        Button3.Location = New Point(126, 292)
        Button3.Name = "Button3"
        Button3.Size = New Size(101, 42)
        Button3.TabIndex = 15
        Button3.Text = "Ingresar"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(136, 124)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(209, 29)
        TextBox4.TabIndex = 16
        TextBox4.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(136, 166)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(209, 29)
        TextBox5.TabIndex = 17
        TextBox5.TextAlign = HorizontalAlignment.Center
        ' 
        ' Timer1
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(736, 393)
        Controls.Add(TabControl1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Inicio de Sesión"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
