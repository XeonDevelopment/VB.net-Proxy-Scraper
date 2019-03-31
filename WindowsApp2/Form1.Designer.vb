<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.XylosTabControl1 = New WindowsApp2.XylosTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ChkUnchecked = New WindowsApp2.XylosCheckBox()
        Me.ChkChecked = New WindowsApp2.XylosCheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChkHttp = New WindowsApp2.XylosCheckBox()
        Me.ChkSocks5 = New WindowsApp2.XylosCheckBox()
        Me.ChkSocks4 = New WindowsApp2.XylosCheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTimeout = New WindowsApp2.XylosTextBox()
        Me.ChkAnonElite = New WindowsApp2.XylosCheckBox()
        Me.ChkAnonTrans = New WindowsApp2.XylosCheckBox()
        Me.ChkAnonAnon = New WindowsApp2.XylosCheckBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.XylosTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'XylosTabControl1
        '
        Me.XylosTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.XylosTabControl1.Controls.Add(Me.TabPage1)
        Me.XylosTabControl1.Controls.Add(Me.TabPage3)
        Me.XylosTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XylosTabControl1.FirstHeaderBorder = False
        Me.XylosTabControl1.ItemSize = New System.Drawing.Size(40, 180)
        Me.XylosTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XylosTabControl1.Multiline = True
        Me.XylosTabControl1.Name = "XylosTabControl1"
        Me.XylosTabControl1.SelectedIndex = 0
        Me.XylosTabControl1.Size = New System.Drawing.Size(812, 447)
        Me.XylosTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.XylosTabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.ChkUnchecked)
        Me.TabPage1.Controls.Add(Me.ChkChecked)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.ChkHttp)
        Me.TabPage1.Controls.Add(Me.ChkSocks5)
        Me.TabPage1.Controls.Add(Me.ChkSocks4)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtTimeout)
        Me.TabPage1.Controls.Add(Me.ChkAnonElite)
        Me.TabPage1.Controls.Add(Me.ChkAnonTrans)
        Me.TabPage1.Controls.Add(Me.ChkAnonAnon)
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.TabPage1.Location = New System.Drawing.Point(184, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(624, 439)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Proxy Scraper"
        '
        'ChkUnchecked
        '
        Me.ChkUnchecked.Checked = False
        Me.ChkUnchecked.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkUnchecked.EnabledCalc = True
        Me.ChkUnchecked.Location = New System.Drawing.Point(282, 86)
        Me.ChkUnchecked.Name = "ChkUnchecked"
        Me.ChkUnchecked.Size = New System.Drawing.Size(336, 18)
        Me.ChkUnchecked.TabIndex = 17
        Me.ChkUnchecked.Text = "Unchecked (Mixed HTTP/Socks Will ignore other options)"
        '
        'ChkChecked
        '
        Me.ChkChecked.Checked = False
        Me.ChkChecked.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkChecked.EnabledCalc = True
        Me.ChkChecked.Location = New System.Drawing.Point(328, 62)
        Me.ChkChecked.Name = "ChkChecked"
        Me.ChkChecked.Size = New System.Drawing.Size(254, 18)
        Me.ChkChecked.TabIndex = 16
        Me.ChkChecked.Text = "Checked (List updates every 15 Minutes)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(425, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Proxy Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(412, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Only For HTTP"
        '
        'ChkHttp
        '
        Me.ChkHttp.Checked = False
        Me.ChkHttp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkHttp.EnabledCalc = True
        Me.ChkHttp.Location = New System.Drawing.Point(342, 147)
        Me.ChkHttp.Name = "ChkHttp"
        Me.ChkHttp.Size = New System.Drawing.Size(75, 18)
        Me.ChkHttp.TabIndex = 13
        Me.ChkHttp.Text = "HTTP"
        '
        'ChkSocks5
        '
        Me.ChkSocks5.Checked = False
        Me.ChkSocks5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkSocks5.EnabledCalc = True
        Me.ChkSocks5.Location = New System.Drawing.Point(504, 147)
        Me.ChkSocks5.Name = "ChkSocks5"
        Me.ChkSocks5.Size = New System.Drawing.Size(75, 18)
        Me.ChkSocks5.TabIndex = 12
        Me.ChkSocks5.Text = "Socks5"
        '
        'ChkSocks4
        '
        Me.ChkSocks4.Checked = False
        Me.ChkSocks4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkSocks4.EnabledCalc = True
        Me.ChkSocks4.Location = New System.Drawing.Point(423, 147)
        Me.ChkSocks4.Name = "ChkSocks4"
        Me.ChkSocks4.Size = New System.Drawing.Size(75, 18)
        Me.ChkSocks4.TabIndex = 11
        Me.ChkSocks4.Text = "Socks4"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(414, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "TimeOut (MS)"
        '
        'txtTimeout
        '
        Me.txtTimeout.EnabledCalc = True
        Me.txtTimeout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTimeout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtTimeout.Location = New System.Drawing.Point(402, 210)
        Me.txtTimeout.MaxLength = 32767
        Me.txtTimeout.MultiLine = False
        Me.txtTimeout.Name = "txtTimeout"
        Me.txtTimeout.ReadOnly = False
        Me.txtTimeout.Size = New System.Drawing.Size(130, 29)
        Me.txtTimeout.TabIndex = 9
        Me.txtTimeout.Text = "10000"
        Me.txtTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtTimeout.UseSystemPasswordChar = False
        '
        'ChkAnonElite
        '
        Me.ChkAnonElite.Checked = False
        Me.ChkAnonElite.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkAnonElite.EnabledCalc = True
        Me.ChkAnonElite.Location = New System.Drawing.Point(514, 280)
        Me.ChkAnonElite.Name = "ChkAnonElite"
        Me.ChkAnonElite.Size = New System.Drawing.Size(76, 18)
        Me.ChkAnonElite.TabIndex = 8
        Me.ChkAnonElite.Text = "Elite"
        '
        'ChkAnonTrans
        '
        Me.ChkAnonTrans.Checked = False
        Me.ChkAnonTrans.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkAnonTrans.EnabledCalc = True
        Me.ChkAnonTrans.Location = New System.Drawing.Point(418, 280)
        Me.ChkAnonTrans.Name = "ChkAnonTrans"
        Me.ChkAnonTrans.Size = New System.Drawing.Size(101, 18)
        Me.ChkAnonTrans.TabIndex = 7
        Me.ChkAnonTrans.Text = "Transparent"
        '
        'ChkAnonAnon
        '
        Me.ChkAnonAnon.Checked = False
        Me.ChkAnonAnon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkAnonAnon.EnabledCalc = True
        Me.ChkAnonAnon.Location = New System.Drawing.Point(353, 280)
        Me.ChkAnonAnon.Name = "ChkAnonAnon"
        Me.ChkAnonAnon.Size = New System.Drawing.Size(75, 18)
        Me.ChkAnonAnon.TabIndex = 6
        Me.ChkAnonAnon.Text = "Anon"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(6, 8)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(271, 424)
        Me.ListBox1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(348, 374)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(231, 27)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "CLEAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(348, 304)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(231, 30)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "GET"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(348, 340)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(231, 28)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.TabPage3.Location = New System.Drawing.Point(184, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(852, 449)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Checker"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(365, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Select Proxy Scraper Type"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 447)
        Me.Controls.Add(Me.XylosTabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.XylosTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents XylosTabControl1 As XylosTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ChkAnonAnon As XylosCheckBox
    Friend WithEvents ChkAnonElite As XylosCheckBox
    Friend WithEvents ChkAnonTrans As XylosCheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTimeout As XylosTextBox
    Friend WithEvents ChkHttp As XylosCheckBox
    Friend WithEvents ChkSocks5 As XylosCheckBox
    Friend WithEvents ChkSocks4 As XylosCheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ChkUnchecked As XylosCheckBox
    Friend WithEvents ChkChecked As XylosCheckBox
    Friend WithEvents Label4 As Label
End Class
