Imports System.Windows.Forms

Imports Intangic.RPTP.Business.Exceptions
Imports Intangic.RPTP.Business.Impl
Imports Intangic.RPTP.Business.Interfaces
Imports Intangic.RPTP.Domain
Imports Intangic.RPTP.Factory
Imports Intangic.Utils

Imports FormUtils = RealPropertyTaxProjectionVB.Intangic.Utils


Public Class frmImportFile

    Public realPropertyTaxProjectionManager As IRealPropertyTaxProjectionService

    Private Sub btnSelectImportFile_Click(sender As Object, e As EventArgs) Handles btnSelectImportFile.Click
        'openFileDialog1
        If openFileDialog1.ShowDialog().Equals(DialogResult.OK) Then
            Me.txtSourceFilePath.Text = openFileDialog1.FileName
        End If
    End Sub

    Private Sub btnImportFile_Click(sender As Object, e As EventArgs) Handles btnImportFile.Click
        Dim request As ImportBuildingDataFileRequest = Nothing
        Dim response As ImportBuildingDataFileResponse = Nothing

        request = New ImportBuildingDataFileRequest()
        request.SourceFilePath = Me.txtSourceFilePath.Text

        Try
            realPropertyTaxProjectionManager = BusinessDelegateFactory.GetInstance().GetRealPropertyTaxProjectionService()
            response = realPropertyTaxProjectionManager.ImportBuildingDataFile(request)

            If response.Result.IsSuccess.Equals(True) Then
                Me.DialogResult = DialogResult.OK
            Else
                Me.DialogResult = DialogResult.Cancel
            End If

        Catch ex As Exception
            FormUtils.FormHelper.MessageShow(ex.Message)

        Finally
            response = Nothing
            request = Nothing
        End Try
    End Sub
End Class