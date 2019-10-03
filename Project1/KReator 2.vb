Imports System.Windows.Forms

Public Class KReator_2
    Private Sub KReator_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub lblLabelSource1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblLabelSource1.MouseDown
        ' Start a drag.
        lblLabelSource1.DoDragDrop(lblLabelSource1, DragDropEffects.Copy)
    End Sub

    Private Sub lblTextSource1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
        Handles lblTextSource1.MouseDown
        ' Start a drag.
        lblTextSource1.DoDragDrop(lblTextSource1.Text, DragDropEffects.Copy)
    End Sub


    ' Display the copy effect.
    Private Sub lblLabelTarget_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lblLabelTarget.DragEnter
        ' See if the data includes a Label.
        If e.Data.GetDataPresent(GetType(Label)) Or e.Data.GetDataPresent(DataFormats.Text) Then
            ' There is Label data. Allow copy.
            e.Effect = DragDropEffects.Copy

            ' Highlight the control.
            lblLabelTarget.BorderStyle = BorderStyle.FixedSingle
        Else
            ' There is no Label. Prohibit drop.
            e.Effect = DragDropEffects.None
        End If
    End Sub

    ' Display the copy effect.
    Private Sub lblTextTarget_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lblTextTarget.DragEnter
        ' See if the data includes text.
        If e.Data.GetDataPresent(GetType(Label)) Or e.Data.GetDataPresent(DataFormats.Text) Then
            ' There is text. Allow copy.
            e.Effect = DragDropEffects.Copy
        Else
            ' There is no text. Prohibit drop.
            e.Effect = DragDropEffects.None
        End If
    End Sub

    ' Unhighlight the control.
    Private Sub lblLabelTarget_DragLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLabelTarget.DragLeave
        lblLabelTarget.BorderStyle = BorderStyle.Fixed3D
    End Sub



    ' Perform the drop.
    Private Sub lblLabelTarget_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lblLabelTarget.DragDrop
        Dim lbl As Label = DirectCast(
            e.Data.GetData(GetType(Label)), Label)
        lblLabelTarget.Text = lbl.Text
        lblLabelTarget.BackColor = lbl.BackColor
        lblLabelTarget.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub lblTextTarget_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lblTextTarget.DragDrop
        lblTextTarget.Text = e.Data.GetData(DataFormats.Text).ToString
    End Sub
End Class