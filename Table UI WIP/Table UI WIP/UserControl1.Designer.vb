<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl1))
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.lb_location = New Guna.UI.WinForms.GunaLabel()
        Me.lb_company = New Guna.UI.WinForms.GunaLabel()
        Me.lb_asset = New Guna.UI.WinForms.GunaLabel()
        Me.lb_type = New Guna.UI.WinForms.GunaLabel()
        Me.lb_name = New Guna.UI.WinForms.GunaLabel()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaLinePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.Controls.Add(Me.GunaCircleButton1)
        Me.GunaLinePanel1.Controls.Add(Me.lb_location)
        Me.GunaLinePanel1.Controls.Add(Me.lb_company)
        Me.GunaLinePanel1.Controls.Add(Me.lb_asset)
        Me.GunaLinePanel1.Controls.Add(Me.lb_type)
        Me.GunaLinePanel1.Controls.Add(Me.lb_name)
        Me.GunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaLinePanel1.LineBottom = 1
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(667, 50)
        Me.GunaLinePanel1.TabIndex = 1
        '
        'lb_location
        '
        Me.lb_location.AutoSize = True
        Me.lb_location.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!)
        Me.lb_location.ForeColor = System.Drawing.Color.Gray
        Me.lb_location.Location = New System.Drawing.Point(491, 18)
        Me.lb_location.Name = "lb_location"
        Me.lb_location.Size = New System.Drawing.Size(58, 13)
        Me.lb_location.TabIndex = 4
        Me.lb_location.Text = "LOCATION"
        '
        'lb_company
        '
        Me.lb_company.AutoSize = True
        Me.lb_company.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!)
        Me.lb_company.ForeColor = System.Drawing.Color.Gray
        Me.lb_company.Location = New System.Drawing.Point(359, 18)
        Me.lb_company.Name = "lb_company"
        Me.lb_company.Size = New System.Drawing.Size(58, 13)
        Me.lb_company.TabIndex = 3
        Me.lb_company.Text = "COMPANY"
        '
        'lb_asset
        '
        Me.lb_asset.AutoSize = True
        Me.lb_asset.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!)
        Me.lb_asset.ForeColor = System.Drawing.Color.Gray
        Me.lb_asset.Location = New System.Drawing.Point(248, 18)
        Me.lb_asset.Name = "lb_asset"
        Me.lb_asset.Size = New System.Drawing.Size(38, 13)
        Me.lb_asset.TabIndex = 2
        Me.lb_asset.Text = "ASSET"
        '
        'lb_type
        '
        Me.lb_type.AutoSize = True
        Me.lb_type.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!)
        Me.lb_type.ForeColor = System.Drawing.Color.Gray
        Me.lb_type.Location = New System.Drawing.Point(138, 18)
        Me.lb_type.Name = "lb_type"
        Me.lb_type.Size = New System.Drawing.Size(31, 13)
        Me.lb_type.TabIndex = 1
        Me.lb_type.Text = "TYPE"
        '
        'lb_name
        '
        Me.lb_name.AutoSize = True
        Me.lb_name.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!)
        Me.lb_name.ForeColor = System.Drawing.Color.Gray
        Me.lb_name.Location = New System.Drawing.Point(25, 18)
        Me.lb_name.Name = "lb_name"
        Me.lb_name.Size = New System.Drawing.Size(38, 13)
        Me.lb_name.TabIndex = 0
        Me.lb_name.Text = "NAME"
        '
        'GunaCircleButton1
        '
        Me.GunaCircleButton1.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton1.AnimationSpeed = 0.03!
        Me.GunaCircleButton1.BaseColor = System.Drawing.Color.White
        Me.GunaCircleButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton1.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.Image = CType(resources.GetObject("GunaCircleButton1.Image"), System.Drawing.Image)
        Me.GunaCircleButton1.ImageSize = New System.Drawing.Size(16, 16)
        Me.GunaCircleButton1.Location = New System.Drawing.Point(623, 10)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.OnHoverImage = CType(resources.GetObject("GunaCircleButton1.OnHoverImage"), System.Drawing.Image)
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.Size = New System.Drawing.Size(30, 30)
        Me.GunaCircleButton1.TabIndex = 5
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.GunaLinePanel1)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(667, 50)
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.GunaLinePanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents lb_location As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lb_company As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lb_asset As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lb_type As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lb_name As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
End Class
