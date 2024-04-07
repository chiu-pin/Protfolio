Public Class Form1


    Private Sub 新增產品ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 新增產品ToolStripMenuItem.Click
        '開啟新增原物料的視窗
        With Formaddproduct
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub 產品清單ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 產品清單ToolStripMenuItem.Click
        '開啟原物料產品清單的視窗
        With Formproductlist
            .Show()
            .Focus()
        End With
    End Sub
    Private Sub 庫存清單ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 庫存清單ToolStripMenuItem.Click
        '開啟各公司庫存清單的視窗
        With Forminventorylist
            .Show()
            .Focus()
        End With
    End Sub
    Private Sub logouttoolmenu_Click(sender As Object, e As EventArgs) Handles logouttoolmenu.Click
        '開啟登入視窗，並把先前的登入資料清除
        With LoginForm1
            .UsernameTextBox.Text = ""
            .PasswordTextBox.Text = ""
            .Show()
            .Focus()
        End With
        Me.Close()

    End Sub

    Private Sub endmenutool_Click(sender As Object, e As EventArgs) Handles endmenutool.Click
        '關閉程式
        With LoginForm1
            .Close()
        End With
        Me.Close()
    End Sub
    Private Sub 管理ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 管理ToolStripMenuItem.Click
        '開啟管理視窗
        With frmUser
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub 新增進貨ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 新增進貨ToolStripMenuItem.Click
        With Formnewstockin
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub 新增公司經銷商ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 新增公司經銷商ToolStripMenuItem.Click
        With insertcompany
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        With Formsum
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
