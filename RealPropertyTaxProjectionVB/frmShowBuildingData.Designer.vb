﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmShowBuildingData
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.sfdExportData = New System.Windows.Forms.SaveFileDialog()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtSearchText = New System.Windows.Forms.TextBox()
        Me.btnResetFilter = New System.Windows.Forms.Button()
        Me.btnApplyFilter = New System.Windows.Forms.Button()
        Me.btnBuildingTypeSettings = New System.Windows.Forms.Button()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label14 = New System.Windows.Forms.Label()
        Me.textBox13 = New System.Windows.Forms.TextBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.textBox11 = New System.Windows.Forms.TextBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.textBox12 = New System.Windows.Forms.TextBox()
        Me.textBox10 = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.textBox9 = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.ComputeSelected = New System.Windows.Forms.Button()
        Me.label7 = New System.Windows.Forms.Label()
        Me.btnComputeAll = New System.Windows.Forms.Button()
        Me.textBox7 = New System.Windows.Forms.TextBox()
        Me.txtTaxRatePercent = New System.Windows.Forms.TextBox()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnImportData = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.dtgBuildingData = New System.Windows.Forms.DataGridView()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.btnExportData = New System.Windows.Forms.Button()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.textBox6 = New System.Windows.Forms.TextBox()
        Me.textBox5 = New System.Windows.Forms.TextBox()
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnAssessmentLevelSettings = New System.Windows.Forms.Button()
        Me.groupBox3.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.dtgBuildingData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.Location = New System.Drawing.Point(903, 357)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(79, 24)
        Me.btnLogout.TabIndex = 10
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.txtSearchText)
        Me.groupBox3.Controls.Add(Me.btnResetFilter)
        Me.groupBox3.Controls.Add(Me.btnApplyFilter)
        Me.groupBox3.Location = New System.Drawing.Point(496, 3)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(400, 126)
        Me.groupBox3.TabIndex = 14
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Search"
        '
        'txtSearchText
        '
        Me.txtSearchText.Location = New System.Drawing.Point(7, 19)
        Me.txtSearchText.Multiline = True
        Me.txtSearchText.Name = "txtSearchText"
        Me.txtSearchText.Size = New System.Drawing.Size(387, 72)
        Me.txtSearchText.TabIndex = 12
        '
        'btnResetFilter
        '
        Me.btnResetFilter.Location = New System.Drawing.Point(315, 95)
        Me.btnResetFilter.Name = "btnResetFilter"
        Me.btnResetFilter.Size = New System.Drawing.Size(79, 23)
        Me.btnResetFilter.TabIndex = 11
        Me.btnResetFilter.Text = "Reset Filter"
        Me.btnResetFilter.UseVisualStyleBackColor = True
        '
        'btnApplyFilter
        '
        Me.btnApplyFilter.Location = New System.Drawing.Point(230, 95)
        Me.btnApplyFilter.Name = "btnApplyFilter"
        Me.btnApplyFilter.Size = New System.Drawing.Size(79, 23)
        Me.btnApplyFilter.TabIndex = 10
        Me.btnApplyFilter.Text = "Apply Filter"
        Me.btnApplyFilter.UseVisualStyleBackColor = True
        '
        'btnBuildingTypeSettings
        '
        Me.btnBuildingTypeSettings.Location = New System.Drawing.Point(903, 106)
        Me.btnBuildingTypeSettings.Name = "btnBuildingTypeSettings"
        Me.btnBuildingTypeSettings.Size = New System.Drawing.Size(79, 53)
        Me.btnBuildingTypeSettings.TabIndex = 9
        Me.btnBuildingTypeSettings.Text = "Building Type Settings"
        Me.btnBuildingTypeSettings.UseVisualStyleBackColor = True
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.label14)
        Me.groupBox2.Controls.Add(Me.textBox13)
        Me.groupBox2.Controls.Add(Me.label12)
        Me.groupBox2.Controls.Add(Me.textBox11)
        Me.groupBox2.Controls.Add(Me.label13)
        Me.groupBox2.Controls.Add(Me.label11)
        Me.groupBox2.Controls.Add(Me.textBox12)
        Me.groupBox2.Controls.Add(Me.textBox10)
        Me.groupBox2.Controls.Add(Me.label10)
        Me.groupBox2.Controls.Add(Me.label9)
        Me.groupBox2.Controls.Add(Me.textBox9)
        Me.groupBox2.Controls.Add(Me.label8)
        Me.groupBox2.Controls.Add(Me.ComputeSelected)
        Me.groupBox2.Controls.Add(Me.label7)
        Me.groupBox2.Controls.Add(Me.btnComputeAll)
        Me.groupBox2.Controls.Add(Me.textBox7)
        Me.groupBox2.Controls.Add(Me.txtTaxRatePercent)
        Me.groupBox2.Controls.Add(Me.comboBox1)
        Me.groupBox2.Location = New System.Drawing.Point(12, 135)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(883, 101)
        Me.groupBox2.TabIndex = 13
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Selected Building Data - Assessor Evaluation"
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Location = New System.Drawing.Point(239, 74)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(78, 13)
        Me.label14.TabIndex = 22
        Me.label14.Text = "Equivalent Tax"
        '
        'textBox13
        '
        Me.textBox13.Location = New System.Drawing.Point(363, 71)
        Me.textBox13.Name = "textBox13"
        Me.textBox13.Size = New System.Drawing.Size(100, 20)
        Me.textBox13.TabIndex = 21
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(239, 48)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(104, 13)
        Me.label12.TabIndex = 20
        Me.label12.Text = "Assessment % Value"
        '
        'textBox11
        '
        Me.textBox11.Location = New System.Drawing.Point(363, 45)
        Me.textBox11.Name = "textBox11"
        Me.textBox11.Size = New System.Drawing.Size(100, 20)
        Me.textBox11.TabIndex = 19
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(239, 22)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(70, 13)
        Me.label13.TabIndex = 18
        Me.label13.Text = "Market Value"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(475, 48)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(111, 13)
        Me.label11.TabIndex = 8
        Me.label11.Text = "Scructure Unit Value :"
        '
        'textBox12
        '
        Me.textBox12.Location = New System.Drawing.Point(133, 45)
        Me.textBox12.Name = "textBox12"
        Me.textBox12.Size = New System.Drawing.Size(100, 20)
        Me.textBox12.TabIndex = 17
        '
        'textBox10
        '
        Me.textBox10.BackColor = System.Drawing.Color.White
        Me.textBox10.Location = New System.Drawing.Point(621, 45)
        Me.textBox10.Name = "textBox10"
        Me.textBox10.ReadOnly = True
        Me.textBox10.Size = New System.Drawing.Size(143, 20)
        Me.textBox10.TabIndex = 7
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(9, 48)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(56, 13)
        Me.label10.TabIndex = 16
        Me.label10.Text = "Unit Value"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(475, 74)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(108, 13)
        Me.label9.TabIndex = 6
        Me.label9.Text = "Tax Rate % Defined :"
        '
        'textBox9
        '
        Me.textBox9.Location = New System.Drawing.Point(363, 19)
        Me.textBox9.Name = "textBox9"
        Me.textBox9.Size = New System.Drawing.Size(100, 20)
        Me.textBox9.TabIndex = 15
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(475, 22)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(137, 13)
        Me.label8.TabIndex = 5
        Me.label8.Text = "Scructure Type - Assessor :"
        '
        'ComputeSelected
        '
        Me.ComputeSelected.Location = New System.Drawing.Point(770, 43)
        Me.ComputeSelected.Name = "ComputeSelected"
        Me.ComputeSelected.Size = New System.Drawing.Size(102, 23)
        Me.ComputeSelected.TabIndex = 4
        Me.ComputeSelected.Text = "Compute Selected"
        Me.ComputeSelected.UseVisualStyleBackColor = True
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(9, 22)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(71, 13)
        Me.label7.TabIndex = 14
        Me.label7.Text = "Building Type"
        '
        'btnComputeAll
        '
        Me.btnComputeAll.Location = New System.Drawing.Point(770, 17)
        Me.btnComputeAll.Name = "btnComputeAll"
        Me.btnComputeAll.Size = New System.Drawing.Size(102, 23)
        Me.btnComputeAll.TabIndex = 3
        Me.btnComputeAll.Text = "Compute All"
        Me.btnComputeAll.UseVisualStyleBackColor = True
        '
        'textBox7
        '
        Me.textBox7.Location = New System.Drawing.Point(133, 19)
        Me.textBox7.Name = "textBox7"
        Me.textBox7.Size = New System.Drawing.Size(100, 20)
        Me.textBox7.TabIndex = 13
        '
        'txtTaxRatePercent
        '
        Me.txtTaxRatePercent.BackColor = System.Drawing.Color.White
        Me.txtTaxRatePercent.Location = New System.Drawing.Point(621, 71)
        Me.txtTaxRatePercent.Name = "txtTaxRatePercent"
        Me.txtTaxRatePercent.ReadOnly = True
        Me.txtTaxRatePercent.Size = New System.Drawing.Size(143, 20)
        Me.txtTaxRatePercent.TabIndex = 2
        '
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(621, 19)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(143, 21)
        Me.comboBox1.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(6, 22)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(38, 13)
        Me.label1.TabIndex = 9
        Me.label1.Text = "Owner"
        '
        'btnImportData
        '
        Me.btnImportData.Location = New System.Drawing.Point(903, 12)
        Me.btnImportData.Name = "btnImportData"
        Me.btnImportData.Size = New System.Drawing.Size(79, 23)
        Me.btnImportData.TabIndex = 11
        Me.btnImportData.Text = "Import Data"
        Me.btnImportData.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(6, 48)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(88, 13)
        Me.label2.TabIndex = 10
        Me.label2.Text = "Building Location"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(6, 74)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(29, 13)
        Me.label3.TabIndex = 11
        Me.label3.Text = "Area"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(239, 74)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(71, 13)
        Me.label4.TabIndex = 12
        Me.label4.Text = "Building Type"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(6, 100)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(68, 13)
        Me.label5.TabIndex = 13
        Me.label5.Text = "Building Cost"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(239, 100)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(90, 13)
        Me.label6.TabIndex = 14
        Me.label6.Text = "Date Constructed"
        '
        'dtgBuildingData
        '
        Me.dtgBuildingData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgBuildingData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgBuildingData.Location = New System.Drawing.Point(12, 242)
        Me.dtgBuildingData.Name = "dtgBuildingData"
        Me.dtgBuildingData.Size = New System.Drawing.Size(884, 139)
        Me.dtgBuildingData.TabIndex = 11
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(100, 19)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(363, 20)
        Me.textBox1.TabIndex = 2
        '
        'btnExportData
        '
        Me.btnExportData.Location = New System.Drawing.Point(903, 38)
        Me.btnExportData.Name = "btnExportData"
        Me.btnExportData.Size = New System.Drawing.Size(79, 23)
        Me.btnExportData.TabIndex = 12
        Me.btnExportData.Text = "Export Data"
        Me.btnExportData.UseVisualStyleBackColor = True
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(133, 71)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(100, 20)
        Me.textBox2.TabIndex = 3
        '
        'textBox6
        '
        Me.textBox6.Location = New System.Drawing.Point(363, 97)
        Me.textBox6.Name = "textBox6"
        Me.textBox6.Size = New System.Drawing.Size(100, 20)
        Me.textBox6.TabIndex = 7
        '
        'textBox5
        '
        Me.textBox5.Location = New System.Drawing.Point(363, 71)
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Size = New System.Drawing.Size(100, 20)
        Me.textBox5.TabIndex = 6
        '
        'textBox4
        '
        Me.textBox4.Location = New System.Drawing.Point(100, 45)
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(363, 20)
        Me.textBox4.TabIndex = 5
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.textBox1)
        Me.groupBox1.Controls.Add(Me.textBox6)
        Me.groupBox1.Controls.Add(Me.textBox4)
        Me.groupBox1.Controls.Add(Me.textBox3)
        Me.groupBox1.Controls.Add(Me.textBox5)
        Me.groupBox1.Controls.Add(Me.textBox2)
        Me.groupBox1.Location = New System.Drawing.Point(12, 3)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(477, 126)
        Me.groupBox1.TabIndex = 12
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Selected Building Data"
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(133, 97)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(100, 20)
        Me.textBox3.TabIndex = 4
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(9, 390)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(45, 13)
        Me.lblStatus.TabIndex = 15
        Me.lblStatus.Text = "Label15"
        '
        'btnAssessmentLevelSettings
        '
        Me.btnAssessmentLevelSettings.Location = New System.Drawing.Point(903, 165)
        Me.btnAssessmentLevelSettings.Name = "btnAssessmentLevelSettings"
        Me.btnAssessmentLevelSettings.Size = New System.Drawing.Size(79, 53)
        Me.btnAssessmentLevelSettings.TabIndex = 16
        Me.btnAssessmentLevelSettings.Text = "Assessment Level Settings"
        Me.btnAssessmentLevelSettings.UseVisualStyleBackColor = True
        '
        'frmShowBuildingData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 412)
        Me.Controls.Add(Me.btnAssessmentLevelSettings)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnBuildingTypeSettings)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnExportData)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.dtgBuildingData)
        Me.Controls.Add(Me.btnImportData)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "frmShowBuildingData"
        Me.Text = "frmShowBuildingData"
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.dtgBuildingData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents sfdExportData As SaveFileDialog
    Private WithEvents btnLogout As Button
    Private WithEvents groupBox3 As GroupBox
    Private WithEvents btnBuildingTypeSettings As Button
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents label14 As Label
    Private WithEvents textBox13 As TextBox
    Private WithEvents label12 As Label
    Private WithEvents textBox11 As TextBox
    Private WithEvents label13 As Label
    Private WithEvents label11 As Label
    Private WithEvents textBox12 As TextBox
    Private WithEvents textBox10 As TextBox
    Private WithEvents label10 As Label
    Private WithEvents label9 As Label
    Private WithEvents textBox9 As TextBox
    Private WithEvents label8 As Label
    Private WithEvents ComputeSelected As Button
    Private WithEvents label7 As Label
    Private WithEvents btnComputeAll As Button
    Private WithEvents textBox7 As TextBox
    Private WithEvents txtTaxRatePercent As TextBox
    Private WithEvents comboBox1 As ComboBox
    Private WithEvents label1 As Label
    Private WithEvents btnImportData As Button
    Private WithEvents label2 As Label
    Private WithEvents label3 As Label
    Private WithEvents label4 As Label
    Private WithEvents label5 As Label
    Private WithEvents label6 As Label
    Private WithEvents dtgBuildingData As DataGridView
    Private WithEvents btnApplyFilter As Button
    Private WithEvents textBox1 As TextBox
    Private WithEvents btnResetFilter As Button
    Private WithEvents btnExportData As Button
    Private WithEvents textBox2 As TextBox
    Private WithEvents textBox6 As TextBox
    Private WithEvents textBox5 As TextBox
    Private WithEvents textBox4 As TextBox
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents textBox3 As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents txtSearchText As TextBox
    Private WithEvents btnAssessmentLevelSettings As Button
End Class
