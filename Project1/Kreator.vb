Imports System.Windows.Forms

Public Class Kreator
    Private Prenos_Kontrole, Prevlacenje_Kontrole As Boolean


    Private Sub gbTabela_DragDrop(sender As Object, e As DragEventArgs) Handles gbTabela.DragDrop
        Dim Kontrola, Nova_Kontrola As Control

        Kontrola = CType(sender, Control)
        Select Case Kontrola.Tag
            Case "Textbox", "Memo"
                Nova_Kontrola = New TextBox
                Nova_Kontrola = Kontrola
                gbTabela.Controls.Add(Nova_Kontrola)

            Case "Datum/Vreme", "Datum", "Vreme"
                Nova_Kontrola = New DateTimePicker
                Nova_Kontrola = Kontrola
                gbTabela.Controls.Add(Nova_Kontrola)

            Case "Numerik"
                Nova_Kontrola = New NumericUpDown
                Nova_Kontrola = Kontrola
                gbTabela.Controls.Add(Nova_Kontrola)

            Case "Datum/Vreme"
                Nova_Kontrola = New DateTimePicker
                Nova_Kontrola = Kontrola
                gbTabela.Controls.Add(Nova_Kontrola)
        End Select


    End Sub

    Private Sub gbKontrole_DragLeave(sender As Object, e As EventArgs) Handles gbKontrole.DragLeave
        Prevlacenje_Kontrole = True
    End Sub

    Private Sub gbKontrole_DragOver(sender As Object, e As DragEventArgs) Handles gbKontrole.DragOver
        Prevlacenje_Kontrole = True
    End Sub

    Private Sub gbKontrole_MouseDown(sender As Object, e As MouseEventArgs) Handles _
            txtSource_Tekst.MouseDown, txtSource_Memo.MouseDown, txtSource_Numerik.MouseDown, txtSource_Datum_Vreme.MouseDown,
            txtSource_Sifarnik.MouseDown
        If Not sender Is Nothing Then
            DoDragDrop(sender.tag, DragDropEffects.Copy)
        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles panTabela.Paint

    End Sub

    Private Sub txtSource_Tekst_MouseDown(sender As Object, e As MouseEventArgs) Handles txtSource_Tekst.MouseDown


    End Sub

    'Private Sub panTabela_DragLeave(sender As Object, e As EventArgs) Handles panTabela.DragLeave
    '    Dim Kontrola, Nova_Kontrola As Control
    '    Console.WriteLine(sender.tag)
    '    Kontrola = CType(sender, Control)
    '    Select Case Kontrola.Tag
    '        Case "Textbox", "Memo"
    '            Nova_Kontrola = New TextBox
    '            Nova_Kontrola = Kontrola
    '            gbTabela.Controls.Add(Nova_Kontrola)

    '        Case "Datum/Vreme", "Datum", "Vreme"
    '            Nova_Kontrola = New DateTimePicker
    '            Nova_Kontrola = Kontrola
    '            gbTabela.Controls.Add(Nova_Kontrola)

    '        Case "Numerik"
    '            Nova_Kontrola = New NumericUpDown
    '            Nova_Kontrola = Kontrola
    '            gbTabela.Controls.Add(Nova_Kontrola)

    '        Case "Datum/Vreme"
    '            Nova_Kontrola = New DateTimePicker
    '            Nova_Kontrola = Kontrola
    '            gbTabela.Controls.Add(Nova_Kontrola)
    '    End Select
    'End Sub

    Private Function Get_Next_Location(ByRef Kontejner As Control, Min_Sirina As Int32) As Drawing.Point
        Dim tTacka As Drawing.Point,
            maxY As Int16 = 0


        Dim kontrola As Control
        'For Each kontrola In Kontejner.Controls
        '    If kontrola.Location.Y > maxY Then
        '        maxY = kontrola.Location.Y

        '    End If

        'Next
        kontrola = Kontejner.Controls(Kontejner.Controls.Count - 1)

        'If Kontejner.Width - kontrola.Location.X - kontrola.Width > Min_Sirina Then
        '    tTacka.X = kontrola.Location.X + kontrola.Width + Min_Sirina
        '    tTacka.Y = kontrola.Location.Y
        'Else
        tTacka.X = 5
            tTacka.Y = kontrola.Location.Y + 25
        'End If


        Return tTacka

    End Function

    Private Sub Kreiraj_Kontrolu(ByRef Kontejner As Control, Tip_Kontrole As String, Lokacija As Drawing.Point, Labela As String, Optional ByVal Max_Duzina As Int16 = 50)
        Dim Kontrola, Nova_Kontrola As Control,
               tLAbela As Label

        'priprema labele za kontrolu
        tLAbela = New Label
        tLAbela.Text = Labela
        Kontejner.Controls.Add(tLAbela)
        tLAbela.Location = Lokacija
        Lokacija.X += 100


        'keriramo kontrolu

        Select Case Tip_Kontrole

            Case "TextBox"
                Nova_Kontrola = New TextBox

                Kontejner.Controls.Add(Nova_Kontrola)

            Case "Memo"
                Nova_Kontrola = New TextBox
                Nova_Kontrola.Location = Lokacija
                CType(Nova_Kontrola, TextBox).Multiline = True
                CType(Nova_Kontrola, TextBox).MaxLength = Max_Duzina
                Kontejner.Controls.Add(Nova_Kontrola)


            Case "Datum/Vreme", "Datum", "Vreme"
                Nova_Kontrola = New DateTimePicker
                Nova_Kontrola.Location = Lokacija
                Kontejner.Controls.Add(Nova_Kontrola)

            Case "Numerik"
                Nova_Kontrola = New NumericUpDown
                Nova_Kontrola.Location = Lokacija
                Kontejner.Controls.Add(Nova_Kontrola)

            Case "Datum/Vreme"
                Nova_Kontrola = New DateTimePicker
                Nova_Kontrola.Location = Lokacija
                Kontejner.Controls.Add(Nova_Kontrola)
            Case "Sifarnik"
                Nova_Kontrola = New ComboBox
                Nova_Kontrola.Location = Lokacija
                Kontejner.Controls.Add(Nova_Kontrola)
            Case Else
                Nova_Kontrola = New TextBox
                Nova_Kontrola.Location = Lokacija

                gbTabela.Controls.Add(Nova_Kontrola)
                Kontejner.Visible = True

        End Select
    End Sub

    Private Sub panTabela_DragDrop(sender As Object, e As DragEventArgs) Handles panTabela.DragDrop,
            txtSource_Tekst.DragDrop, txtSource_Memo.DragDrop, txtSource_Numerik.DragDrop, txtSource_Datum_Vreme.DragDrop,
            txtSource_Sifarnik.DragDrop
        Dim Kontrola, Nova_Kontrola As Control,
                tTarget As String,
                tLokacija As Drawing.Point



        Console.WriteLine(sender.tag)

        Kontrola = DirectCast(e.Data.GetData(GetType(TextBox)), TextBox)

        tTarget = e.Data.GetData(DataFormats.Text).ToString
        tLokacija = Get_Next_Location(panTabela, 200)
        Kreiraj_Kontrolu(panTabela, tTarget, tLokacija, tTarget)


    End Sub

    Private Sub panTabela_MouseUp(sender As Object, e As MouseEventArgs) Handles panTabela.MouseUp
        Dim Kontrola, Nova_Kontrola As Control
        Console.WriteLine(sender.tag)
        Kontrola = CType(sender, Control)
        Select Case Kontrola.Tag
            Case "Textbox", "Memo"
                Nova_Kontrola = New TextBox
                Nova_Kontrola = Kontrola
                gbTabela.Controls.Add(Nova_Kontrola)

            Case "Datum/Vreme", "Datum", "Vreme"
                Nova_Kontrola = New DateTimePicker
                Nova_Kontrola = Kontrola
                gbTabela.Controls.Add(Nova_Kontrola)

            Case "Numerik"
                Nova_Kontrola = New NumericUpDown
                Nova_Kontrola = Kontrola
                gbTabela.Controls.Add(Nova_Kontrola)

            Case "Datum/Vreme"
                Nova_Kontrola = New DateTimePicker
                Nova_Kontrola = Kontrola
                gbTabela.Controls.Add(Nova_Kontrola)

            Case Else
                Nova_Kontrola = New TextBox

                gbTabela.Controls.Add(Nova_Kontrola)
        End Select
    End Sub

    Private Sub panTabela_DragEnter(sender As Object, e As DragEventArgs) Handles panTabela.DragEnter
        e.Effect = DragDropEffects.Copy

        ' Highlight the control.
        panTabela.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub gbTabela_DragEnter(sender As Object, e As DragEventArgs) Handles gbTabela.DragEnter
        e.Effect = DragDropEffects.Copy

        ' Highlight the control.
        panTabela.BorderStyle = BorderStyle.FixedSingle
    End Sub
End Class