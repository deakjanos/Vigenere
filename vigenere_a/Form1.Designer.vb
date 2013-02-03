<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.csupanagybetuButton = New System.Windows.Forms.Button
        Me.csupanagybetuTextBox = New System.Windows.Forms.TextBox
        Me.szokozesekezetnelkulButton = New System.Windows.Forms.Button
        Me.szokozesekezetnelkulTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.originalTextBox = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.kulcsTextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.kulcsszovegButton = New System.Windows.Forms.Button
        Me.kulcsszovegTextBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tabla123 = New System.Windows.Forms.TextBox
        Me.pos = New System.Windows.Forms.TextBox
        Me.kodoltTextBox1 = New System.Windows.Forms.TextBox
        Me.kodolButton = New System.Windows.Forms.Button
        Me.kodoltTextBox2 = New System.Windows.Forms.TextBox
        Me.kodoltszovegTextBox = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(733, 501)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.kodoltszovegTextBox)
        Me.TabPage1.Controls.Add(Me.kodoltTextBox2)
        Me.TabPage1.Controls.Add(Me.kodolButton)
        Me.TabPage1.Controls.Add(Me.kodoltTextBox1)
        Me.TabPage1.Controls.Add(Me.pos)
        Me.TabPage1.Controls.Add(Me.tabla123)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.kulcsszovegTextBox)
        Me.TabPage1.Controls.Add(Me.kulcsszovegButton)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.kulcsTextBox)
        Me.TabPage1.Controls.Add(Me.csupanagybetuButton)
        Me.TabPage1.Controls.Add(Me.csupanagybetuTextBox)
        Me.TabPage1.Controls.Add(Me.szokozesekezetnelkulButton)
        Me.TabPage1.Controls.Add(Me.szokozesekezetnelkulTextBox)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.originalTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(725, 475)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Kódolás"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'csupanagybetuButton
        '
        Me.csupanagybetuButton.Location = New System.Drawing.Point(7, 101)
        Me.csupanagybetuButton.Name = "csupanagybetuButton"
        Me.csupanagybetuButton.Size = New System.Drawing.Size(443, 23)
        Me.csupanagybetuButton.TabIndex = 5
        Me.csupanagybetuButton.Text = "Csupa nagy betű"
        Me.csupanagybetuButton.UseVisualStyleBackColor = True
        '
        'csupanagybetuTextBox
        '
        Me.csupanagybetuTextBox.Location = New System.Drawing.Point(6, 130)
        Me.csupanagybetuTextBox.Name = "csupanagybetuTextBox"
        Me.csupanagybetuTextBox.Size = New System.Drawing.Size(444, 20)
        Me.csupanagybetuTextBox.TabIndex = 4
        '
        'szokozesekezetnelkulButton
        '
        Me.szokozesekezetnelkulButton.Location = New System.Drawing.Point(6, 57)
        Me.szokozesekezetnelkulButton.Name = "szokozesekezetnelkulButton"
        Me.szokozesekezetnelkulButton.Size = New System.Drawing.Size(444, 23)
        Me.szokozesekezetnelkulButton.TabIndex = 3
        Me.szokozesekezetnelkulButton.Text = "Szóköz és ékezet nélkül"
        Me.szokozesekezetnelkulButton.UseVisualStyleBackColor = True
        '
        'szokozesekezetnelkulTextBox
        '
        Me.szokozesekezetnelkulTextBox.Location = New System.Drawing.Point(6, 82)
        Me.szokozesekezetnelkulTextBox.Name = "szokozesekezetnelkulTextBox"
        Me.szokozesekezetnelkulTextBox.Size = New System.Drawing.Size(444, 20)
        Me.szokozesekezetnelkulTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "eredeti szöveg:"
        '
        'originalTextBox
        '
        Me.originalTextBox.Location = New System.Drawing.Point(6, 30)
        Me.originalTextBox.Name = "originalTextBox"
        Me.originalTextBox.Size = New System.Drawing.Size(444, 20)
        Me.originalTextBox.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.RichTextBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(725, 475)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tábla"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.Yellow
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Maroon
        Me.RichTextBox1.Location = New System.Drawing.Point(7, 7)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(509, 462)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'kulcsTextBox
        '
        Me.kulcsTextBox.Location = New System.Drawing.Point(51, 177)
        Me.kulcsTextBox.Name = "kulcsTextBox"
        Me.kulcsTextBox.Size = New System.Drawing.Size(128, 20)
        Me.kulcsTextBox.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "kulcs:"
        '
        'kulcsszovegButton
        '
        Me.kulcsszovegButton.Location = New System.Drawing.Point(186, 173)
        Me.kulcsszovegButton.Name = "kulcsszovegButton"
        Me.kulcsszovegButton.Size = New System.Drawing.Size(264, 23)
        Me.kulcsszovegButton.TabIndex = 8
        Me.kulcsszovegButton.Text = "Kulcsszöveg készítés"
        Me.kulcsszovegButton.UseVisualStyleBackColor = True
        '
        'kulcsszovegTextBox
        '
        Me.kulcsszovegTextBox.Location = New System.Drawing.Point(10, 233)
        Me.kulcsszovegTextBox.Name = "kulcsszovegTextBox"
        Me.kulcsszovegTextBox.Size = New System.Drawing.Size(440, 20)
        Me.kulcsszovegTextBox.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Kulcsszöveg:"
        '
        'tabla123
        '
        Me.tabla123.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tabla123.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.tabla123.Location = New System.Drawing.Point(456, 30)
        Me.tabla123.Multiline = True
        Me.tabla123.Name = "tabla123"
        Me.tabla123.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tabla123.Size = New System.Drawing.Size(263, 390)
        Me.tabla123.TabIndex = 11
        '
        'pos
        '
        Me.pos.Location = New System.Drawing.Point(619, 449)
        Me.pos.Name = "pos"
        Me.pos.Size = New System.Drawing.Size(100, 20)
        Me.pos.TabIndex = 12
        '
        'kodoltTextBox1
        '
        Me.kodoltTextBox1.Location = New System.Drawing.Point(7, 355)
        Me.kodoltTextBox1.Name = "kodoltTextBox1"
        Me.kodoltTextBox1.Size = New System.Drawing.Size(443, 20)
        Me.kodoltTextBox1.TabIndex = 13
        '
        'kodolButton
        '
        Me.kodolButton.Location = New System.Drawing.Point(7, 304)
        Me.kodolButton.Name = "kodolButton"
        Me.kodolButton.Size = New System.Drawing.Size(443, 23)
        Me.kodolButton.TabIndex = 14
        Me.kodolButton.Text = "Kódolás"
        Me.kodolButton.UseVisualStyleBackColor = True
        '
        'kodoltTextBox2
        '
        Me.kodoltTextBox2.Location = New System.Drawing.Point(6, 400)
        Me.kodoltTextBox2.Name = "kodoltTextBox2"
        Me.kodoltTextBox2.Size = New System.Drawing.Size(444, 20)
        Me.kodoltTextBox2.TabIndex = 15
        '
        'kodoltszovegTextBox
        '
        Me.kodoltszovegTextBox.Location = New System.Drawing.Point(7, 449)
        Me.kodoltszovegTextBox.Name = "kodoltszovegTextBox"
        Me.kodoltszovegTextBox.Size = New System.Drawing.Size(443, 20)
        Me.kodoltszovegTextBox.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 433)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Kódolt szöveg:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 339)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Sorok száma a nyílt szövegből:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 381)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(172, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Oszlopok száma a kulcsszövegből:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(470, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Vigenere"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 526)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents originalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents szokozesekezetnelkulButton As System.Windows.Forms.Button
    Friend WithEvents szokozesekezetnelkulTextBox As System.Windows.Forms.TextBox
    Friend WithEvents csupanagybetuButton As System.Windows.Forms.Button
    Friend WithEvents csupanagybetuTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents kulcsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents kulcsszovegButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents kulcsszovegTextBox As System.Windows.Forms.TextBox
    Friend WithEvents tabla123 As System.Windows.Forms.TextBox
    Friend WithEvents pos As System.Windows.Forms.TextBox
    Friend WithEvents kodolButton As System.Windows.Forms.Button
    Friend WithEvents kodoltTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents kodoltTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents kodoltszovegTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
