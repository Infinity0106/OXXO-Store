Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Dataset1.Copia_de_OXXO_BASE_DE_DATOS' Puede moverla o quitarla según sea necesario.
        Me.Copia_de_OXXO_BASE_DE_DATOSTableAdapter.Fill(Me.Dataset1.Copia_de_OXXO_BASE_DE_DATOS)
        Button3.Enabled = False
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Add(ComboBox2.Text)
        ListBox2.Items.Add(ComboBox3.Text)

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
        ListBox2.Items.Remove(ListBox2.SelectedItem)
    End Sub
    'chechar
    Public Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

        Dim a As Integer ' sub total
        For Each Str As String In ListBox2.Items
            a = a + CInt(Str)
        Next
        Label6.Text = "$" & a
    End Sub

    Public Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim b As Integer 'total
        Dim c As Integer
        b = CInt(Label6.Text) * 0.16
        c = b + CInt(Label6.Text)
        Label8.Text = "$" & c
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim D As Integer
        Dim C As Integer

        D = CInt(TextBox1.Text)
        C = D - CInt(Label8.Text)
        Label9.Text = "$" & C

    End Sub
    Private Sub textbox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Add(Convert.ToString(TextBox4.Text))
        ListBox2.Items.Add(TextBox3.Text)
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "" And TextBox3.Text = "" Then
            Button3.Enabled = False
        ElseIf TextBox4.Text = "" And Not (TextBox3.Text = "") Then
            Button3.Enabled = False
        ElseIf Not (TextBox4.Text = "") And TextBox3.Text = "" Then
            Button3.Enabled = False
        Else
            Button3.Enabled = True

        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

        If TextBox4.Text = "" And TextBox3.Text = "" Then
            Button3.Enabled = False
        ElseIf TextBox4.Text = "" And Not (TextBox3.Text = "") Then
            Button3.Enabled = False
        ElseIf Not (TextBox4.Text = "") And TextBox3.Text = "" Then
            Button3.Enabled = False
        Else
            Button3.Enabled = True
        End If

    End Sub

    Private Sub ComboBox2_keyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            ListBox1.Items.Add(ComboBox2.Text)
            ListBox2.Items.Add(ComboBox3.Text)
        End If
    End Sub

    Private Sub ComboBox3_keypress(sender As Object, e As KeyPressEventArgs) Handles ComboBox3.KeyPress
        If e.KeyChar = Chr(13) Then
            ListBox2.Items.Add(ComboBox3.Text)
            ListBox1.Items.Add(ComboBox2.Text)
        End If
    End Sub

    Private Sub TextBox1_keypress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If e.KeyChar = Chr(13) Then
            Dim D As Integer
            Dim C As Integer

            D = CInt(TextBox1.Text)
            C = D - CInt(Label8.Text)
            Label9.Text = "$" & C
        End If
    End Sub

End Class