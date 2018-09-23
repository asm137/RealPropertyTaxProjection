Imports System.Configuration


Namespace Intagic.Utils

    Public Class ConfigurationHelper

        Public Shared Function GetString() As String
            Dim value As String = Nothing
            Try
                value = ConfigurationManager.AppSettings(key)
            Catch ex As Exception
                value = My.Settings.Item(key)
            End Try

            Return value
        End Function

    End Class

End Namespace
