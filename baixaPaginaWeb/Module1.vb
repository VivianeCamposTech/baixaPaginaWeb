Imports System.Net
Imports System.IO


Module Module1

    Sub Main()

        Dim data As String = Now.ToString("dd-MM-yyyy HHmmss")
        Dim WebClient As New Net.WebClient
        Dim Pagina As String
        Pagina = WebClient.DownloadString("https://www.google.com/")

        baixaInfo(Pagina, data)

    End Sub

    Public Sub baixaInfo(ByVal pagina As String, ByVal data As String)

        Dim diretorio As String = "C:\baixaPaginaWeb\Google\"
        Dim nomeDiretorio As String = "HTML\"

        diretorio = diretorio & nomeDiretorio

        If Not Directory.Exists(diretorio) Then
            Directory.CreateDirectory(diretorio)
        End If

        Dim fileName As String = data & "-Pagina.html"

        diretorio = diretorio & fileName

        Using sw As New StreamWriter(diretorio, FileMode.CreateNew)
            sw.Write(pagina)
        End Using

    End Sub

End Module
