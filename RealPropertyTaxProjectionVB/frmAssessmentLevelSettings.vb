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

Imports FormUtils = RealPropertyTaxProjectionVB.Intangic.Utils


Public Class frmAssessmentLevelSettings


    Public Property IsAddRecord As Boolean
    Public Property IsDeleteRecord As Boolean
    Public Property SelectedRowIndex As Integer



    Private Sub ClearFields()
        Me.txtAssessmentLevel.Text = String.Empty
        Me.txtMarketValueFrom.Text = String.Empty
        Me.txtMarketValueTo.Text = String.Empty
        Me.txtAssessmentLevel.Focus()
    End Sub

    Private Sub ResetEditRecordMode()
        Me.IsAddRecord = False
        Me.IsDeleteRecord = False
    End Sub

    Private Sub EnableEditButtons(Optional ByVal isEnable As Boolean = True)
        Me.btnSave.Enabled = isEnable
        Me.btnClear.Enabled = isEnable
        Me.btnCancel.Enabled = isEnable

        Me.btnAdd.Enabled = Not isEnable
        Me.btnEdit.Enabled = Not isEnable
        Me.btnDelete.Enabled = Not isEnable
    End Sub


    Private Sub LoadData()
        Dim request As LoadAssessmentLevelSettingRequest = Nothing
        Dim response As LoadAssessmentLevelSettingResponse = Nothing

        request = New LoadAssessmentLevelSettingRequest
        With request
            .SourceFilePath = FormUtils.ConfigurationHelper.GetString("DATA_ASSESSMENT_LEVEL_SETTING_SOURCE")
        End With

        Program.realPropertyTaxProjectionManager = BusinessDelegateFactory.GetInstance().GetRealPropertyTaxProjectionService()
        response = Program.realPropertyTaxProjectionManager.LoadAssessmentLevelSetting(request)

        If response.Result.IsSuccess.Equals(True) Then
            'load data from database
            Dim bs As New BindingSource()
            bs.DataSource = response.DataSource
            Me.dtgAssessmentLevelSettings.DataSource = bs
            Me.dtgAssessmentLevelSettings.DataMember = bs.DataSource.Tables(0).TableName
            Me.dtgAssessmentLevelSettings.RefreshEdit()
            'Dim ds As New DataSet
            'Dim dt As New DataTable
            'dt.Columns.Add("a", GetType(System.String))
            'dt.AcceptChanges()
            'ds.Tables.Add(dt)
            'ds.AcceptChanges()
            'Me.dtgAssessmentLevelSettings.DataSource = ds
        End If
    End Sub

    Private Sub SaveData()
        Dim request As SaveAssessmentLevelSettingRequest = Nothing
        Dim response As SaveAssessmentLevelSettingResponse = Nothing

        Try
            request = New SaveAssessmentLevelSettingRequest
            With request
                .AssessmentLevelSetting = New AssessmentLevelSetting
                With .AssessmentLevelSetting
                    .AssessmentLevel = Me.txtAssessmentLevel.Text
                    .MarketValueFrom = Me.txtMarketValueFrom.Text
                    .MarketValueTo = Me.txtMarketValueTo.Text
                End With
                .DataSource = CType(Me.dtgAssessmentLevelSettings.DataSource, BindingSource).DataSource 'CType(Me.dtgAssessmentLevelSettings.DataSource, BindingSource).DataSource
                .DataFilePath = FormUtils.ConfigurationHelper.GetString("DATA_ASSESSMENT_LEVEL_SETTING_SOURCE")

                .IsAddRecord = Me.IsAddRecord
                .IsDeleteRecord = Me.IsDeleteRecord

                If .IsAddRecord Then
                    .RowIndex = 0
                Else
                    .RowIndex = Me.SelectedRowIndex
                End If
            End With

            Program.realPropertyTaxProjectionManager = BusinessDelegateFactory.GetInstance().GetRealPropertyTaxProjectionService()
            response = Program.realPropertyTaxProjectionManager.SaveAssessmentLevelSetting(request)
            If response.Result.IsSuccess.Equals(True) Then
                FormUtils.FormHelper.MessageShow(response.Result.Message)
                Me.ClearFields()
                'Me.dtgAssessmentLevelSettings.DataSource = response.DataSource
                Me.LoadData()

                Me.ResetEditRecordMode()
                Me.EnableEditButtons(False)
            End If

        Catch ex As RealPropertyTaxProjectionException
            If Not ex.Message.Equals(Program.SKIP_KEYWORD) Then
                FormUtils.FormHelper.MessageShow(ex.Message)
            End If

        Catch ex As Exception
            FormUtils.FormHelper.MessageShow(ex.Message)

        Finally
            Program.realPropertyTaxProjectionManager = Nothing
        End Try
    End Sub

    Private Function HasData() As Boolean
        Return Not Me.dtgAssessmentLevelSettings.DataSource Is Nothing AndAlso
                Me.dtgAssessmentLevelSettings.Rows.Count > 0
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.ClearFields()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.IsAddRecord = True
        Me.IsDeleteRecord = False
        Me.ClearFields()
        Me.EnableEditButtons()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Not Me.HasData() Then Exit Sub

        Me.IsAddRecord = False
        Me.IsDeleteRecord = True
        'Me.SelectedRowIndex = ctype(Me.dtgAssessmentLevelSettings.DataSource, Dataset).Tables(0).
        'Me.SelectedRowIndex = dtgAssessmentLevelSettings.SelectedRows(0)
        Me.SelectedRowIndex = Me.dtgAssessmentLevelSettings.SelectedRows(0).Index 'CType(Me.dtgAssessmentLevelSettings.DataSource, BindingSource).Position
        Me.GetValues()

        If FormUtils.FormHelper.MessageConfirmDelete("Do you want to delete the record?") = DialogResult.Yes Then
            'delete the record in the data source
            Me.SaveData()

            'load the data source
            Me.LoadData()
        End If
    End Sub

    Private Sub frmAssessmentLevelSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load the data source
        Me.LoadData()

        Me.ResetEditRecordMode()
        Me.EnableEditButtons(False)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.ResetEditRecordMode()
        Me.EnableEditButtons(False)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.SaveData()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Not Me.HasData() Then Exit Sub

        Me.IsAddRecord = False
        Me.IsDeleteRecord = False
        Me.SelectedRowIndex = Me.dtgAssessmentLevelSettings.SelectedRows(0).Index 'CType(Me.dtgAssessmentLevelSettings.DataSource, BindingSource).Position

        Me.GetValues()
        Me.EnableEditButtons()
    End Sub

    Private Sub GetValues()
        Dim ds As DataSet = CType(Me.dtgAssessmentLevelSettings.DataSource, BindingSource).DataSource
        Me.txtAssessmentLevel.Text = ds.Tables(0).Rows(Me.SelectedRowIndex).Item(0)
        Me.txtMarketValueFrom.Text = ds.Tables(0).Rows(Me.SelectedRowIndex).Item(1)
        Me.txtMarketValueTo.Text = ds.Tables(0).Rows(Me.SelectedRowIndex).Item(2)
    End Sub

    Private Sub frmAssessmentLevelSettings_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.dtgAssessmentLevelSettings.DataSource = Nothing
    End Sub
End Class