Imports System
Imports System.Runtime.InteropServices

Module Program
    Sub Main(args As String())
        Dim comObj As Object = Nothing
        Dim selectedProgId As String = Nothing
        Dim lastError As Exception = Nothing

        Try
            Dim candidateProgIds As String() = {
                "BatchRemote.RemoteSupport",
                "BatchRemote.RemoteSupport.1",
                "BatchControl.BatchServer",
                "BatchControl.BatchServer.1"
            }

            For Each progId In candidateProgIds
                Dim t = Type.GetTypeFromProgID(progId, throwOnError:=False)
                If t Is Nothing Then
                    Continue For
                End If

                Try
                    comObj = Activator.CreateInstance(t)
                    selectedProgId = progId
                    Exit For
                Catch ex As Exception
                    lastError = ex
                End Try
            Next

            If comObj Is Nothing Then
                Console.WriteLine("No supported FactoryTalk Batch ProgID found. Verify Batch Server components are installed and registered.")
                If lastError IsNot Nothing Then
                    Console.WriteLine($"Last activation error: {lastError.Message}")
                End If
                Return
            End If

            Console.WriteLine($"Created COM object via ProgID: {selectedProgId}")
        Catch ex As Exception
            Console.WriteLine($"Failed to create BatchRemote: {ex.Message}")
        Finally
            If comObj IsNot Nothing AndAlso Marshal.IsComObject(comObj) Then
                Marshal.ReleaseComObject(comObj)
            End If
        End Try
    End Sub
End Module
