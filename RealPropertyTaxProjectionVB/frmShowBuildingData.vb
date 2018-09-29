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
'Imports Intangic.Utils

Imports FormUtils = RealPropertyTaxProjectionVB.Intangic.Utils


Public Class frmShowBuildingData

    'Private DataSource As List(Of BuildingDataAssessor) = Nothing

    'Public Property CurrentBinding As BindingSource
    Private CurrentBinding As BindingSource

    Private _DataSource As DataSet
    Public Property DataSource As DataSet
        Get
            Return _DataSource
        End Get
        Set(value As DataSet)
            _DataSource = value

            Me.CurrentBinding = New BindingSource
            Me.CurrentBinding.DataSource = _DataSource
            Me.CurrentBinding.DataMember = _DataSource.Tables(0).TableName

            Me.dtgBuildingData.DataSource = _DataSource
        End Set
    End Property


    Private Sub LoadData(ByVal sourceFilePath As String)
        Dim request As LoadBuildingDataAssessorFileRequest = Nothing
        Dim response As LoadBuildingDataAssessorFileResponse = Nothing

        request = New LoadBuildingDataAssessorFileRequest
        With request
            .SourceFilePath = FormUtils.ConfigurationHelper.GetString("DATA_TEMP_SOURCE")
        End With

        Program.realPropertyTaxProjectionManager = BusinessDelegateFactory.GetInstance().GetRealPropertyTaxProjectionService()
        response = Program.realPropertyTaxProjectionManager.LoadBuildingDataAssessorFile(request)

        If response.Result.IsSuccess.Equals(True) Then
            'load data from database
            Me.DataSource = response.DataSource
            'Me.dtgBuildingData.DataSource = Me.CurrentBinding 'response.DataSource

            'display status "Data loaded at yyyyMMdd"
            Me.lblStatus.Text = String.Format("{0} {1}", "Data loaded at", Now)
        End If
    End Sub


    Private Sub btnImportData_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImportData.Click
        Dim request As LoadBuildingDataAssessorFileRequest = Nothing
        Dim response As LoadBuildingDataAssessorFileResponse = Nothing

        Try
            If frmImportFile.ShowDialog().Equals(DialogResult.OK) Then
                Me.LoadData(frmImportFile.SourceFilePath)
            End If

        Catch ex As RealPropertyTaxProjectionException
            If Not ex.Message.Equals(Program.SKIP_KEYWORD) Then
                FormUtils.FormHelper.MessageShow(ex.Message)
            End If

        Catch ex As Exception
            If Not ex.Message.Equals(Program.SKIP_KEYWORD) Then
                FormUtils.FormHelper.MessageShow(ex.Message)
            End If

        Finally
            Program.realPropertyTaxProjectionManager = Nothing
        End Try
    End Sub


    Private Sub frmShowBuildingData_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Me.LoadData(frmImportFile.SourceFilePath)
        txtTaxRatePercent.Text = FormUtils.ConfigurationHelper.GetString("PARAM_TAX_RATE_PERCENT")
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
                'TODO: go back here...
                '.BuildingDataAssessors = Me.DataSource
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

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        End
    End Sub

    Private Sub btnApplyFilter_Click(sender As Object, e As EventArgs) Handles btnApplyFilter.Click
        'apply filter
    End Sub

    Private Sub btnResetFilter_Click(sender As Object, e As EventArgs) Handles btnResetFilter.Click
        Me.txtSearchText.Text = String.Empty

        'apply filter
    End Sub

    Private Sub frmShowBuildingData_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub btnBuildingTypeSettings_Click(sender As Object, e As EventArgs) Handles btnBuildingTypeSettings.Click
        frmBuildingTypeSettings.ShowDialog()
    End Sub

    Private Sub btnAssessmentLevelSettings_Click(sender As Object, e As EventArgs) Handles btnAssessmentLevelSettings.Click
        frmAssessmentLevelSettings.ShowDialog()
    End Sub
End Class