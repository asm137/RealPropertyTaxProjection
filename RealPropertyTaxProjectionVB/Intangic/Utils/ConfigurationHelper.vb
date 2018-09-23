Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Imports System.Configuration


Namespace Intangic.Utils

    Public Class ConfigurationHelper

        Public Shared Function GetString(ByVal key As String) As String
            Dim value As String = Nothing
            Try
                'value = ConfigurationManager.AppSettings(key)
                value = My.Settings.Item(key)
            Catch ex As Exception
                'do nothing
            End Try

            Return value
        End Function

    End Class

End Namespace
