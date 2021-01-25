Public Class Form1
    Dim intTotal As Integer = 0
    'Global variable
    'Its "scope" is the entire program
    'scope = area in which it exists

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        '1) Variables
        Dim intShovels As Integer
        'Dim intTotal As Integer = 0

        '2) Set Values
        intShovels = Val(txtShovels.Text)

        '3) Calculate
        intTotal = intShovels + intTotal


        '4) Display
        lblTotal.Text = "Total Shovels: " & intTotal

    End Sub ' Destroys all local Variables

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        intTotal = 0
        lblTotal.Text = "Total Shovels: " & intTotal
        txtShovels.Text = "" 'Blank Text
    End Sub
End Class ' Destroys all other global variables
' If the variables are not destroyed: memory leak
