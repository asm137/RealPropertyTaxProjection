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


Public Class frmLogin

    Public realPropertyTaxProjectionManage As IRealPropertyTaxProjectionService

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        Dim request As LoginRequest = Nothing
        Dim response As LoginResponse = Nothing


        request = New LoginRequest()
        With request
            .UserName = Me.userName.Text
            .Password = Me.password.Text
        End With


        Try
            realPropertyTaxProjectionManage = BusinessDelegateFactory.GetInstance().GetRealPropertyTaxProjectionService()

            response = New LoginResponse()
            response = realPropertyTaxProjectionManage.Login(request)
            If response.IsLoginValid Then
                Me.DialogResult = DialogResult.OK
            End If

        Catch ex As RealPropertyTaxProjectionException
            FormUtils.FormHelper.MessageShow(ex.Message)
            Me.userName.Focus()

        Catch ex As Exception
            FormUtils.FormHelper.MessageShow(ex.Message)
            Me.userName.Focus()

        Finally
            realPropertyTaxProjectionManage = Nothing
            response = Nothing
            request = Nothing
        End Try
    End Sub

End Class

