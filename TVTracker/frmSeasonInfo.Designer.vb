<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeasonInfo
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
        Me.lblSubHeading = New System.Windows.Forms.Label()
        Me.lblMainHeading = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.txtSeasonNum = New System.Windows.Forms.TextBox()
        Me.lblSeasonNum = New System.Windows.Forms.Label()
        Me.txtEpisodeCount = New System.Windows.Forms.TextBox()
        Me.lblEpisodeCount = New System.Windows.Forms.Label()
        Me.btnAddInfo = New System.Windows.Forms.Button()
        Me.lblShowName = New System.Windows.Forms.Label()
        Me.btnReturntoAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSubHeading
        '
        Me.lblSubHeading.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblSubHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubHeading.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubHeading.Location = New System.Drawing.Point(73, 73)
        Me.lblSubHeading.Name = "lblSubHeading"
        Me.lblSubHeading.Size = New System.Drawing.Size(315, 30)
        Me.lblSubHeading.TabIndex = 33
        Me.lblSubHeading.Text = "Add Season Information"
        Me.lblSubHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMainHeading
        '
        Me.lblMainHeading.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblMainHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMainHeading.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainHeading.Location = New System.Drawing.Point(56, 9)
        Me.lblMainHeading.Name = "lblMainHeading"
        Me.lblMainHeading.Size = New System.Drawing.Size(370, 53)
        Me.lblMainHeading.TabIndex = 32
        Me.lblMainHeading.Text = "TVTracker"
        Me.lblMainHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMessage
        '
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(54, 135)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(368, 59)
        Me.lblMessage.TabIndex = 34
        Me.lblMessage.Text = "Please add all available season information"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSeasonNum
        '
        Me.txtSeasonNum.Location = New System.Drawing.Point(307, 219)
        Me.txtSeasonNum.MaxLength = 40
        Me.txtSeasonNum.Name = "txtSeasonNum"
        Me.txtSeasonNum.Size = New System.Drawing.Size(119, 20)
        Me.txtSeasonNum.TabIndex = 35
        '
        'lblSeasonNum
        '
        Me.lblSeasonNum.BackColor = System.Drawing.SystemColors.Control
        Me.lblSeasonNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSeasonNum.Location = New System.Drawing.Point(57, 219)
        Me.lblSeasonNum.Name = "lblSeasonNum"
        Me.lblSeasonNum.Size = New System.Drawing.Size(222, 20)
        Me.lblSeasonNum.TabIndex = 36
        Me.lblSeasonNum.Text = "Season Number:"
        Me.lblSeasonNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEpisodeCount
        '
        Me.txtEpisodeCount.Location = New System.Drawing.Point(307, 267)
        Me.txtEpisodeCount.MaxLength = 40
        Me.txtEpisodeCount.Name = "txtEpisodeCount"
        Me.txtEpisodeCount.Size = New System.Drawing.Size(119, 20)
        Me.txtEpisodeCount.TabIndex = 37
        '
        'lblEpisodeCount
        '
        Me.lblEpisodeCount.BackColor = System.Drawing.SystemColors.Control
        Me.lblEpisodeCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEpisodeCount.Location = New System.Drawing.Point(57, 267)
        Me.lblEpisodeCount.Name = "lblEpisodeCount"
        Me.lblEpisodeCount.Size = New System.Drawing.Size(222, 20)
        Me.lblEpisodeCount.TabIndex = 38
        Me.lblEpisodeCount.Text = "Number of Episodes in Season:"
        Me.lblEpisodeCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAddInfo
        '
        Me.btnAddInfo.BackColor = System.Drawing.Color.LightGreen
        Me.btnAddInfo.Location = New System.Drawing.Point(307, 318)
        Me.btnAddInfo.Name = "btnAddInfo"
        Me.btnAddInfo.Size = New System.Drawing.Size(119, 29)
        Me.btnAddInfo.TabIndex = 39
        Me.btnAddInfo.Text = "Add Season"
        Me.btnAddInfo.UseVisualStyleBackColor = False
        '
        'lblShowName
        '
        Me.lblShowName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowName.Location = New System.Drawing.Point(54, 112)
        Me.lblShowName.Name = "lblShowName"
        Me.lblShowName.Size = New System.Drawing.Size(368, 23)
        Me.lblShowName.TabIndex = 40
        Me.lblShowName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReturntoAdd
        '
        Me.btnReturntoAdd.BackColor = System.Drawing.Color.LightCoral
        Me.btnReturntoAdd.Location = New System.Drawing.Point(307, 366)
        Me.btnReturntoAdd.Name = "btnReturntoAdd"
        Me.btnReturntoAdd.Size = New System.Drawing.Size(119, 29)
        Me.btnReturntoAdd.TabIndex = 41
        Me.btnReturntoAdd.Text = "Return"
        Me.btnReturntoAdd.UseVisualStyleBackColor = False
        '
        'frmSeasonInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 420)
        Me.Controls.Add(Me.btnReturntoAdd)
        Me.Controls.Add(Me.lblShowName)
        Me.Controls.Add(Me.btnAddInfo)
        Me.Controls.Add(Me.txtEpisodeCount)
        Me.Controls.Add(Me.lblEpisodeCount)
        Me.Controls.Add(Me.txtSeasonNum)
        Me.Controls.Add(Me.lblSeasonNum)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblSubHeading)
        Me.Controls.Add(Me.lblMainHeading)
        Me.Name = "frmSeasonInfo"
        Me.Text = "Add Season Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSubHeading As Label
    Friend WithEvents lblMainHeading As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents txtSeasonNum As TextBox
    Friend WithEvents lblSeasonNum As Label
    Friend WithEvents txtEpisodeCount As TextBox
    Friend WithEvents lblEpisodeCount As Label
    Friend WithEvents btnAddInfo As Button
    Friend WithEvents lblShowName As Label
    Friend WithEvents btnReturntoAdd As Button
End Class
