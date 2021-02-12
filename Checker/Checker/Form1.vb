Imports System.Net
Imports System.Text.RegularExpressions
Imports System.IO



'=========================CODED BY #Remax ===============================
'=Twitter : >> https://www.Twitter.com/iR3max/                          |
'=INSTAGRAM : >> https://www.instagram.com/Rmm7                         |
'========================================================================



Public Class Form1

    Dim web As WebClient = New WebClient
    Dim html As String
    Dim region As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Search(ByVal Email As String)




        web = New WebClient
        On Error Resume Next

        ListBox1.Items.Add("---------------#" & region & "---------------")
        For Each Lone As String In File.ReadLines(List)
            html = web.DownloadString("https://lolnames.gg/en/" & region & "/" & Lone)

            If html.Contains("days.") = True Then
                ListBox1.Items.Add(Lone & " is " & "Unavailable!")
            Else
                ListBox1.Items.Add(Lone & " is " & "Available!")
            End If
        Next



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        region = "euw"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        region = "eune"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        region = "tr"
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        region = "br"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Search(TextBox2.Text)
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        region = "jp"
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        region = "kr"
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        region = "na"
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        region = "ru"
    End Sub

    Public List As String
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim B As New OpenFileDialog
        B.Filter = "All Files (*.*)|*.*"
        B.Title = "Open Text File"
        If B.ShowDialog = DialogResult.OK Then
            List = B.FileName
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim userlol As String

        userlol = TextBox2.Text

        html = web.DownloadString("https://lolnames.gg/en/" & region & "/" & userlol)
        If html.Contains("days.") = True Then
            MsgBox("notAvailbe!")
        Else
            MsgBox("Avalibe!")
        End If

    End Sub
End Class
