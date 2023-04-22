<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambioPass
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button2 = New Button()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox2 = New TextBox()
        CheckBox1 = New CheckBox()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(196), CByte(77), CByte(86))
        Button2.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ControlText
        Button2.Location = New Point(247, 204)
        Button2.Name = "Button2"
        Button2.Size = New Size(101, 42)
        Button2.TabIndex = 24
        Button2.Text = "Cancelar"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        Button1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ControlText
        Button1.Location = New Point(87, 204)
        Button1.Name = "Button1"
        Button1.Size = New Size(101, 42)
        Button1.TabIndex = 23
        Button1.Text = "Aceptar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(61, 56)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(300, 23)
        TextBox1.TabIndex = 22
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(37), CByte(41), CByte(88))
        Label1.Location = New Point(82, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(266, 25)
        Label1.TabIndex = 25
        Label1.Text = "Escriba su nueva contraseña:"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(37), CByte(41), CByte(88))
        Label2.Location = New Point(98, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(228, 25)
        Label2.TabIndex = 27
        Label2.Text = "Confirme su contraseña:"' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(61, 145)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(300, 23)
        TextBox2.TabIndex = 26
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(360, 105)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(67, 19)
        CheckBox1.TabIndex = 28
        CheckBox1.Text = "Mostrar"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CambioPass
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        ClientSize = New Size(439, 276)
        Controls.Add(CheckBox1)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Name = "CambioPass"
        Text = "Cambio de Contraseña"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
