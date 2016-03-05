<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GioiThieu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GioiThieu))
        Me.ptbgioithieu = New System.Windows.Forms.PictureBox()
        Me.ptbthongtin = New System.Windows.Forms.PictureBox()
        CType(Me.ptbgioithieu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbthongtin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ptbgioithieu
        '
        Me.ptbgioithieu.BackgroundImage = CType(resources.GetObject("ptbgioithieu.BackgroundImage"), System.Drawing.Image)
        Me.ptbgioithieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ptbgioithieu.Location = New System.Drawing.Point(2, 3)
        Me.ptbgioithieu.Name = "ptbgioithieu"
        Me.ptbgioithieu.Size = New System.Drawing.Size(659, 318)
        Me.ptbgioithieu.TabIndex = 1
        Me.ptbgioithieu.TabStop = False
        '
        'ptbthongtin
        '
        Me.ptbthongtin.BackgroundImage = CType(resources.GetObject("ptbthongtin.BackgroundImage"), System.Drawing.Image)
        Me.ptbthongtin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbthongtin.Location = New System.Drawing.Point(2, 327)
        Me.ptbthongtin.Name = "ptbthongtin"
        Me.ptbthongtin.Size = New System.Drawing.Size(659, 105)
        Me.ptbthongtin.TabIndex = 2
        Me.ptbthongtin.TabStop = False
        '
        'GioiThieu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 444)
        Me.Controls.Add(Me.ptbthongtin)
        Me.Controls.Add(Me.ptbgioithieu)
        Me.Name = "GioiThieu"
        Me.Text = "GioiThieu"
        CType(Me.ptbgioithieu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbthongtin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ptbgioithieu As System.Windows.Forms.PictureBox
    Friend WithEvents ptbthongtin As System.Windows.Forms.PictureBox
End Class
