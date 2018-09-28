<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssessmentLevelSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMarketValueFrom = New System.Windows.Forms.TextBox()
        Me.txtMarketValueTo = New System.Windows.Forms.TextBox()
        Me.txtAssessmentLevel = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dtgAssessmentLevelSettings = New System.Windows.Forms.DataGridView()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.AssessmentLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarketValueFrom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarketValueTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtgAssessmentLevelSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(294, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Assessment level"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Market value from"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Market value to"
        '
        'txtMarketValueFrom
        '
        Me.txtMarketValueFrom.Location = New System.Drawing.Point(151, 95)
        Me.txtMarketValueFrom.Name = "txtMarketValueFrom"
        Me.txtMarketValueFrom.Size = New System.Drawing.Size(100, 20)
        Me.txtMarketValueFrom.TabIndex = 4
        '
        'txtMarketValueTo
        '
        Me.txtMarketValueTo.Location = New System.Drawing.Point(151, 121)
        Me.txtMarketValueTo.Name = "txtMarketValueTo"
        Me.txtMarketValueTo.Size = New System.Drawing.Size(100, 20)
        Me.txtMarketValueTo.TabIndex = 5
        '
        'txtAssessmentLevel
        '
        Me.txtAssessmentLevel.Location = New System.Drawing.Point(151, 52)
        Me.txtAssessmentLevel.Name = "txtAssessmentLevel"
        Me.txtAssessmentLevel.Size = New System.Drawing.Size(100, 20)
        Me.txtAssessmentLevel.TabIndex = 6
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(12, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(551, 12)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(106, 23)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete / Remove"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'dtgAssessmentLevelSettings
        '
        Me.dtgAssessmentLevelSettings.AllowUserToAddRows = False
        Me.dtgAssessmentLevelSettings.AllowUserToDeleteRows = False
        Me.dtgAssessmentLevelSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgAssessmentLevelSettings.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AssessmentLevel, Me.MarketValueFrom, Me.MarketValueTo})
        Me.dtgAssessmentLevelSettings.Location = New System.Drawing.Point(294, 42)
        Me.dtgAssessmentLevelSettings.Name = "dtgAssessmentLevelSettings"
        Me.dtgAssessmentLevelSettings.RowHeadersVisible = False
        Me.dtgAssessmentLevelSettings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgAssessmentLevelSettings.Size = New System.Drawing.Size(363, 197)
        Me.dtgAssessmentLevelSettings.TabIndex = 9
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(176, 12)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(375, 12)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(93, 12)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'AssessmentLevel
        '
        Me.AssessmentLevel.DataPropertyName = "AssessmentLevel"
        Me.AssessmentLevel.HeaderText = "AssessmentLevel"
        Me.AssessmentLevel.Name = "AssessmentLevel"
        '
        'MarketValueFrom
        '
        Me.MarketValueFrom.DataPropertyName = "MarketValueFrom"
        Me.MarketValueFrom.HeaderText = "MarketValueFrom"
        Me.MarketValueFrom.Name = "MarketValueFrom"
        '
        'MarketValueTo
        '
        Me.MarketValueTo.DataPropertyName = "MarketValueTo"
        Me.MarketValueTo.HeaderText = "MarketValueTo"
        Me.MarketValueTo.Name = "MarketValueTo"
        '
        'frmAssessmentLevelSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 251)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.dtgAssessmentLevelSettings)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtAssessmentLevel)
        Me.Controls.Add(Me.txtMarketValueTo)
        Me.Controls.Add(Me.txtMarketValueFrom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "frmAssessmentLevelSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAssessmentLevelSettings"
        CType(Me.dtgAssessmentLevelSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMarketValueFrom As TextBox
    Friend WithEvents txtMarketValueTo As TextBox
    Friend WithEvents txtAssessmentLevel As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dtgAssessmentLevelSettings As DataGridView
    Friend WithEvents btnClear As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents AssessmentLevel As DataGridViewTextBoxColumn
    Friend WithEvents MarketValueFrom As DataGridViewTextBoxColumn
    Friend WithEvents MarketValueTo As DataGridViewTextBoxColumn
End Class
