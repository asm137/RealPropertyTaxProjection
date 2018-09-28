Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace Intangic.Utils

    Public Class FormHelper

        Public Shared Sub MessageShow(ByVal message As String)
            MessageBox.Show(message)
        End Sub

        Public Shared Function MessageConfirmDelete(ByVal message As String, Optional title As String = "Delete") As DialogResult
            Return MessageBox.Show(message, title, MessageBoxButtons.YesNo)
        End Function

    End Class

End Namespace

