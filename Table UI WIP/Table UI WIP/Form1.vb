Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(GunaPanel5, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
        Dim names As String() = {"Bayam", "Indomie", "Kapal Api", "Ale Ale", "Kangkung", "Sedap Soto", "Nutrisari", "Teh Gelas"}
        Dim types As String() = {"Sayur", "Mie", "Kopi", "Minuman", "Sayur", "Mie", "Minuman", "Minuman"}
        Dim r As New Random
        For i As Integer = 0 To 7
            Dim c As UserControl1 = New UserControl1
            c.Dock = DockStyle.Top
            c.lb_name.Text = names(i)
            c.lb_type.Text = types(i)
            c.lb_asset.Text = r.Next(10000, 50000)
            c.lb_company.Text = "Lokal"
            c.lb_location.Text = "Indonesia"
            pn_list.Controls.Add(c)
        Next
    End Sub
End Class
