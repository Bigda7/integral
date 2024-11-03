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
        Button1 = New Button()
        Label2 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Label5 = New Label()
        ListBox1 = New ListBox()
        Button2 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(333, 217)
        Button1.Name = "Button1"
        Button1.Size = New Size(111, 44)
        Button1.TabIndex = 0
        Button1.Text = "Calculate"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(28, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(174, 15)
        Label2.TabIndex = 3
        Label2.Text = "zadejte spodní hranici integrace"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(70, 99)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(279, 99)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(248, 63)
        Label3.Name = "Label3"
        Label3.Size = New Size(166, 15)
        Label3.TabIndex = 6
        Label3.Text = "zadejte horní hranici integrace"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(488, 63)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 15)
        Label4.TabIndex = 8
        Label4.Text = "cislo iterace"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(488, 99)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 7
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(344, 342)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(346, 23)
        TextBox5.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(488, 310)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 15)
        Label5.TabIndex = 10
        Label5.Text = "Vysledek"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(20, 184)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(291, 184)
        ListBox1.TabIndex = 11
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(646, 198)
        Button2.Name = "Button2"
        Button2.Size = New Size(108, 83)
        Button2.TabIndex = 12
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(658, 385)
        Button3.Name = "Button3"
        Button3.Size = New Size(96, 37)
        Button3.TabIndex = 13
        Button3.Text = "Exit"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(630, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 15)
        Label1.TabIndex = 14
        Label1.Text = "počet desetinných míst"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(646, 99)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 15
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(488, 217)
        Button4.Name = "Button4"
        Button4.Size = New Size(111, 44)
        Button4.TabIndex = 16
        Button4.Text = "Save Result"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button4)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(ListBox1)
        Controls.Add(Label5)
        Controls.Add(TextBox5)
        Controls.Add(Label4)
        Controls.Add(TextBox4)
        Controls.Add(Label3)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button4 As Button

End Class
