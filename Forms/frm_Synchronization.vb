Imports System.Data.SqlClient

Public Class frm_Synchronization
    Implements IForm

    Dim obj As New CommonClass
    Dim outlet_id As Integer
    Dim GlobalTables As DataSet
    Dim con As SqlConnection
    Dim cmd As SqlCommand

    Dim _rights As Form_Rights
    Public Sub New(ByVal rights As Form_Rights)
        _rights = rights
        InitializeComponent()
    End Sub

    Public Sub CloseClick(ByVal sender As Object, ByVal e As System.EventArgs) Implements IForm.CloseClick

    End Sub

    Public Sub DeleteClick(ByVal sender As Object, ByVal e As System.EventArgs) Implements IForm.DeleteClick

    End Sub

    Public Sub NewClick(ByVal sender As Object, ByVal e As System.EventArgs) Implements IForm.NewClick

    End Sub

    Public Sub RefreshClick(ByVal sender As Object, ByVal e As System.EventArgs) Implements IForm.RefreshClick

    End Sub

    Public Sub SaveClick(ByVal sender As Object, ByVal e As System.EventArgs) Implements IForm.SaveClick

    End Sub

    Public Sub ViewClick(ByVal sender As Object, ByVal e As System.EventArgs) Implements IForm.ViewClick

    End Sub

    Private Sub btnSynchronize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSynchronize.Click

        Application.DoEvents()
        Timer1.Enabled = True
        lblProgressDetail.Text = ""
        CollectData(v_the_current_division_id, False, lblProgressDetail, PbarDataTransfer)
        Timer1.Enabled = False
    End Sub

    Private Sub frm_Synchronization_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        outlet_id = Convert.ToInt32(obj.ExecuteScalar("select DIV_ID from DIVISION_SETTINGS"))
    End Sub
    
    Private Sub TmrForProgressBar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrForProgressBar.Tick

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'lblProgressDetail.Text = gblSyncronizeMsg
        Me.Refresh()
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()

    End Sub
End Class
