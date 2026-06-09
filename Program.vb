Imports System
Imports System.Runtime.InteropServices
Imports batchsvr.Interop

Module Program
    Sub Main(args As String())
        Dim svr As BatchServer = Nothing

        Try
            Dim strItem As String
            Dim strReturn As String

            svr = New BatchServerClass()

            strItem = "TIME"
            strReturn = svr.GetItem(strItem)
            Console.WriteLine($"BatchServer.GetItem('{strItem}') returned: {strReturn}")

            strItem = "SERVERNAME"
            strReturn = svr.GetItem(strItem)
            Console.WriteLine($"BatchServer.GetItem('{strItem}') returned: {strReturn}")

            strItem = "VERSION"
            strReturn = svr.GetItem(strItem)
            Console.WriteLine($"BatchServer.GetItem('{strItem}') returned: {strReturn}")

        Catch ex As Exception
            Console.WriteLine($"Failed to create BatchServer: {ex.Message}")
        Finally
            If svr IsNot Nothing AndAlso Marshal.IsComObject(svr) Then
                Marshal.ReleaseComObject(svr)
            End If
        End Try
    End Sub
End Module
