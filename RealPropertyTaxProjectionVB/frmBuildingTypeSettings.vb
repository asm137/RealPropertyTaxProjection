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


Public Class frmBuildingTypeSettings


    Public Property IsAddRecord As Boolean
    Public Property IsDeleteRecord As Boolean
    Public Property SelectedRowIndex As Integer



    Private Sub ClearFields()
        Me.txtBuildingType.Text = String.Empty
        Me.txtUnitValueFrom.Text = String.Empty
        Me.txtUnitValueTo.Text = String.Empty
        Me.txtBuildingType.Focus()
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
        Dim request As LoadBuildingTypeSettingRequest = Nothing
        Dim response As LoadBuildingTypeSettingResponse = Nothing

        request = New LoadBuildingTypeSettingRequest
        With request
            .SourceFilePath = FormUtils.ConfigurationHelper.GetString("DATA_BUILDING_ASSESSOR_SETTING_SOURCE")
        End With

        Program.realPropertyTaxProjectionManager = BusinessDelegateFactory.GetInstance().GetRealPropertyTaxProjectionService()
        response = Program.realPropertyTaxProjectionManager.LoadBuildingTypeSetting(request)

        If response.Result.IsSuccess.Equals(True) Then
            'load data from database
            Dim bs As New BindingSource()
            bs.DataSource = response.DataSource
            Me.dtgBuildingTypeSettings.DataSource = bs
            Me.dtgBuildingTypeSettings.DataMember = bs.DataSource.Tables(0).TableName
            Me.dtgBuildingTypeSettings.RefreshEdit()
            'Dim ds As New DataSet
            'Dim dt As New DataTable
            'dt.Columns.Add("a", GetType(System.String))
            'dt.AcceptChanges()
            'ds.Tables.Add(dt)
            'ds.AcceptChanges()
            'Me.dtgBuildingTypeSettings.DataSource = ds
        End If
    End Sub

    Private Sub SaveData()
        Dim request As SaveBuildingTypeSettingRequest = Nothing
        Dim response As SaveBuildingTypeSettingResponse = Nothing

        Try
            request = New SaveBuildingTypeSettingRequest
            With request
                .BuildingAssessorTypeSetting = New BuildingAssessorTypeSetting
                With .BuildingAssessorTypeSetting
                    .BuildingType = Me.txtBuildingType.Text
                    .UnitValueFrom = Me.txtUnitValueFrom.Text
                    .UnitValueTo = Me.txtUnitValueTo.Text
                End With
                .DataSource = CType(Me.dtgBuildingTypeSettings.DataSource, BindingSource).DataSource 'CType(Me.dtgBuildingTypeSettings.DataSource, BindingSource).DataSource
                .DataFilePath = FormUtils.ConfigurationHelper.GetString("DATA_BUILDING_ASSESSOR_SETTING_SOURCE")

                .IsAddRecord = Me.IsAddRecord
                .IsDeleteRecord = Me.IsDeleteRecord

                If .IsAddRecord Then
                    .RowIndex = 0
                Else
                    .RowIndex = Me.SelectedRowIndex
                End If
            End With

            Program.realPropertyTaxProjectionManager = BusinessDelegateFactory.GetInstance().GetRealPropertyTaxProjectionService()
            response = Program.realPropertyTaxProjectionManager.SaveBuildingTypeSetting(request)
            If response.Result.IsSuccess.Equals(True) Then
                FormUtils.FormHelper.MessageShow(response.Result.Message)
                Me.ClearFields()
                'Me.dtgBuildingTypeSettings.DataSource = response.DataSource
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
        Return Not Me.dtgBuildingTypeSettings.DataSource Is Nothing AndAlso
                Me.dtgBuildingTypeSettings.Rows.Count > 0
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
        'Me.SelectedRowIndex = ctype(Me.dtgBuildingTypeSettings.DataSource, Dataset).Tables(0).
        'Me.SelectedRowIndex = dtgBuildingTypeSettings.SelectedRows(0)
        Me.SelectedRowIndex = Me.dtgBuildingTypeSettings.SelectedRows(0).Index 'CType(Me.dtgBuildingTypeSettings.DataSource, BindingSource).Position
        Me.GetValues()

        If MessageBox.Show("Do you want to delete the record?", "Delete", buttons:=MessageBoxButtons.YesNo) = DialogResult.Yes Then
            'delete the record in the data source
            Me.SaveData()

            'load the data source
            Me.LoadData()
        End If
    End Sub

    Private Sub frmBuildingTypeSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Me.SelectedRowIndex = Me.dtgBuildingTypeSettings.SelectedRows(0).Index 'CType(Me.dtgBuildingTypeSettings.DataSource, BindingSource).Position

        Me.GetValues()
        Me.EnableEditButtons()
    End Sub

    Private Sub GetValues()
        Dim ds As DataSet = CType(Me.dtgBuildingTypeSettings.DataSource, BindingSource).DataSource
        Me.txtBuildingType.Text = ds.Tables(0).Rows(Me.SelectedRowIndex).Item(0)
        Me.txtUnitValueFrom.Text = ds.Tables(0).Rows(Me.SelectedRowIndex).Item(1)
        Me.txtUnitValueTo.Text = ds.Tables(0).Rows(Me.SelectedRowIndex).Item(2)
    End Sub

    Private Sub frmBuildingTypeSettings_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.dtgBuildingTypeSettings.DataSource = Nothing
    End Sub
End Class