Imports System.IO
Imports System.Reflection.Metadata.Ecma335

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        Dim spodni As Double = Val(TextBox2.Text)
        Dim horni As Double = Val(TextBox3.Text)
        Dim iterace As Integer = Val(TextBox4.Text)
        Dim d As Double = (horni - spodni) / iterace
        Dim x As Double = spodni
        Dim sum As Double = 0
        Dim decimalPlaces As Integer
        If Integer.TryParse(TextBox1.Text, decimalPlaces) = False OrElse decimalPlaces < 0 Then
            TextBox1.Text = "Error"
        End If
        Dim formatStr As String = "F" & decimalPlaces.ToString()
        For i = 0 To iterace
            Dim f_x As Double = x ^ 2
            If i = 0 Or i = iterace Then
                f_x *= 0.5
            End If
            sum += f_x
            ListBox1.Items.Add("x = " & x.ToString(formatStr) & "; f(x) = " & f_x.ToString(formatStr))
            x += d
        Next
        TextBox5.Text = (d * sum).ToString(formatStr)
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        CheckInputs()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        CheckInputs()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ListBox1.Items.Clear()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
    Private Sub CheckInputs()
        Dim decimalPlaces As Integer
        Dim isValidDecimalPlaces As Boolean = Integer.TryParse(TextBox1.Text, decimalPlaces)
        Dim iterace As Integer
        Dim isIteraceCountValid As Boolean = Integer.TryParse(TextBox4.Text, iterace)

        If TextBox1.Text <> "" AndAlso TextBox2.Text <> "" AndAlso TextBox3.Text <> "" AndAlso TextBox4.Text <> "" AndAlso
       Val(TextBox3.Text) > Val(TextBox2.Text) AndAlso Val(TextBox4.Text) > 0 AndAlso isIteraceCountValid AndAlso isValidDecimalPlaces AndAlso decimalPlaces >= 0 Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        CheckInputs()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        saveFileDialog.Title = "Save Results"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Using writer As New StreamWriter(saveFileDialog.FileName)
                    For Each item In ListBox1.Items
                        writer.WriteLine(item.ToString())
                    Next
                    writer.WriteLine("Vysledek: " & TextBox5.Text)
                End Using
                MessageBox.Show("Results saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error saving file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
