Public Class frmBuildingTypeSettings

    Private _IsAddRecord As Boolean
    Public Property IsAddRecord As Boolean
        Get
            Return _IsAddRecord
        End Get
        Private Set(value As Boolean)
            _IsAddRecord = value
        End Set
    End Property


    Private Sub ClearFields()
        Me.txtBuildingType.Text = String.Empty
        Me.txtUnitValueFrom.Text = String.Empty
        Me.txtUnitValueTo.Text = String.Empty
        Me.txtBuildingType.Focus()
    End Sub

    Private Sub EnableEditButtons(Optional ByVal isEnable As Boolean = True)
        Me.btnSave.Enabled = isEnable
        Me.btnClear.Enabled = isEnable

    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.ClearFields()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.IsAddRecord = True
        Me.ClearFields()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If True Then
            'delete the record in the data source

            'load the data source
        End If
    End Sub

    Private Sub frmBuildingTypeSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load the data source

        '

        Me.EnableEditButtons(False)
        Me.IsAddRecord = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.EnableEditButtons(False)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.EnableEditButtons(False)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Me.IsAddRecord = False
    End Sub
End Class