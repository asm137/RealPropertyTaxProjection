Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Imports Intangic.RPTP.Business.Exceptions
Imports Intangic.RPTP.Business.Impl
Imports Intangic.RPTP.Business.Interfaces
Imports Intangic.RPTP.Domain
Imports Intangic.RPTP.Factory
Imports Intangic.Utils

Imports FormUtils = RealPropertyTaxProjectionVB.Intangic.Utils


Public Class frmShowBuildingData

    Private DataSource As List(Of BuildingDataAssessor) = Nothing

    Private Sub btnImportData_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImportData.Click
        frmImportFile.ShowDialog()
    End Sub


    Private Sub frmShowBuildingData_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Private Sub btnExportData_Click(sender As Object, e As EventArgs) Handles btnExportData.Click
        Dim request As ExportBuildingDataAssessorFileRequest = Nothing
        Dim response As ExportBuildingDataAssessorFileResponse = Nothing



        Try
            If Not sfdExportData.ShowDialog().Equals(DialogResult.OK) Then
                Throw New RealPropertyTaxProjectionException(Program.SKIP_KEYWORD)
            End If



            request = New ExportBuildingDataAssessorFileRequest()
            With request
                .SourceFilePath = Me.sfdExportData.FileName
                .BuildingDataAssessors = Me.DataSource
            End With


            Program.realPropertyTaxProjectionManager = BusinessDelegateFactory.GetInstance().GetRealPropertyTaxProjectionService()
            response = Program.realPropertyTaxProjectionManager.ExportBuildingDataAssessorFile(request)
            If response.Result.IsSuccess.Equals(True) Then
                FormUtils.FormHelper.MessageShow(response.Result.Message)
            End If

        Catch ex As RealPropertyTaxProjectionException
            If Not ex.Message.Equals(Program.SKIP_KEYWORD) Then
                FormUtils.FormHelper.MessageShow(ex.Message)
            End If

        Finally
            Program.realPropertyTaxProjectionManager = Nothing
        End Try
    End Sub

End Class