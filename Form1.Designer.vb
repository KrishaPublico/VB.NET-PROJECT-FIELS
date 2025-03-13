<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStripFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripTransaction = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripProgTask1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgTask11ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgTask12ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripProgTask2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripProgTask3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripHelpAndSupport = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripActivities = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripActivity1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripActivity2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripActivity3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Activity22ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Navy
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripFile, Me.MenuStripTransaction, Me.MenuStripReports, Me.MenuStripHelpAndSupport, Me.MenuStripActivities, Me.MenuStripLogout})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(849, 36)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStripFile
        '
        Me.MenuStripFile.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStripFile.ForeColor = System.Drawing.Color.AliceBlue
        Me.MenuStripFile.Name = "MenuStripFile"
        Me.MenuStripFile.Size = New System.Drawing.Size(57, 32)
        Me.MenuStripFile.Text = "&File"
        '
        'MenuStripTransaction
        '
        Me.MenuStripTransaction.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripProgTask1, Me.ProgTask11ToolStripMenuItem, Me.ProgTask12ToolStripMenuItem, Me.MenuStripProgTask2, Me.MenuStripProgTask3})
        Me.MenuStripTransaction.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStripTransaction.ForeColor = System.Drawing.Color.White
        Me.MenuStripTransaction.Name = "MenuStripTransaction"
        Me.MenuStripTransaction.Size = New System.Drawing.Size(128, 32)
        Me.MenuStripTransaction.Text = "&Transaction"
        '
        'MenuStripProgTask1
        '
        Me.MenuStripProgTask1.BackColor = System.Drawing.Color.RoyalBlue
        Me.MenuStripProgTask1.ForeColor = System.Drawing.Color.White
        Me.MenuStripProgTask1.Name = "MenuStripProgTask1"
        Me.MenuStripProgTask1.Size = New System.Drawing.Size(224, 32)
        Me.MenuStripProgTask1.Text = "ProgTask1"
        '
        'ProgTask11ToolStripMenuItem
        '
        Me.ProgTask11ToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.ProgTask11ToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ProgTask11ToolStripMenuItem.Name = "ProgTask11ToolStripMenuItem"
        Me.ProgTask11ToolStripMenuItem.Size = New System.Drawing.Size(224, 32)
        Me.ProgTask11ToolStripMenuItem.Text = "ProgTask1.2"
        '
        'ProgTask12ToolStripMenuItem
        '
        Me.ProgTask12ToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.ProgTask12ToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ProgTask12ToolStripMenuItem.Name = "ProgTask12ToolStripMenuItem"
        Me.ProgTask12ToolStripMenuItem.Size = New System.Drawing.Size(224, 32)
        Me.ProgTask12ToolStripMenuItem.Text = "ProgTask1.3"
        '
        'MenuStripProgTask2
        '
        Me.MenuStripProgTask2.BackColor = System.Drawing.Color.RoyalBlue
        Me.MenuStripProgTask2.ForeColor = System.Drawing.Color.White
        Me.MenuStripProgTask2.Name = "MenuStripProgTask2"
        Me.MenuStripProgTask2.Size = New System.Drawing.Size(224, 32)
        Me.MenuStripProgTask2.Text = "ProgTask2"
        '
        'MenuStripProgTask3
        '
        Me.MenuStripProgTask3.BackColor = System.Drawing.Color.RoyalBlue
        Me.MenuStripProgTask3.ForeColor = System.Drawing.Color.White
        Me.MenuStripProgTask3.Name = "MenuStripProgTask3"
        Me.MenuStripProgTask3.Size = New System.Drawing.Size(224, 32)
        Me.MenuStripProgTask3.Text = "ProgTask3"
        '
        'MenuStripReports
        '
        Me.MenuStripReports.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStripReports.ForeColor = System.Drawing.Color.White
        Me.MenuStripReports.Name = "MenuStripReports"
        Me.MenuStripReports.Size = New System.Drawing.Size(96, 32)
        Me.MenuStripReports.Text = "&Reports"
        '
        'MenuStripHelpAndSupport
        '
        Me.MenuStripHelpAndSupport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripAbout})
        Me.MenuStripHelpAndSupport.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStripHelpAndSupport.ForeColor = System.Drawing.Color.White
        Me.MenuStripHelpAndSupport.Name = "MenuStripHelpAndSupport"
        Me.MenuStripHelpAndSupport.Size = New System.Drawing.Size(189, 32)
        Me.MenuStripHelpAndSupport.Text = "&Help and Support"
        '
        'MenuStripAbout
        '
        Me.MenuStripAbout.BackColor = System.Drawing.Color.RoyalBlue
        Me.MenuStripAbout.ForeColor = System.Drawing.Color.White
        Me.MenuStripAbout.Name = "MenuStripAbout"
        Me.MenuStripAbout.Size = New System.Drawing.Size(154, 32)
        Me.MenuStripAbout.Text = "About"
        '
        'MenuStripActivities
        '
        Me.MenuStripActivities.BackColor = System.Drawing.Color.Transparent
        Me.MenuStripActivities.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripActivity1, Me.MenuStripActivity2, Me.Activity22ToolStripMenuItem, Me.MenuStripActivity3})
        Me.MenuStripActivities.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStripActivities.ForeColor = System.Drawing.Color.White
        Me.MenuStripActivities.Name = "MenuStripActivities"
        Me.MenuStripActivities.Size = New System.Drawing.Size(147, 32)
        Me.MenuStripActivities.Text = "&Our Activities"
        '
        'MenuStripActivity1
        '
        Me.MenuStripActivity1.BackColor = System.Drawing.Color.RoyalBlue
        Me.MenuStripActivity1.ForeColor = System.Drawing.Color.White
        Me.MenuStripActivity1.Name = "MenuStripActivity1"
        Me.MenuStripActivity1.Size = New System.Drawing.Size(224, 32)
        Me.MenuStripActivity1.Text = "Activity 1"
        '
        'MenuStripActivity2
        '
        Me.MenuStripActivity2.BackColor = System.Drawing.Color.RoyalBlue
        Me.MenuStripActivity2.ForeColor = System.Drawing.Color.White
        Me.MenuStripActivity2.Name = "MenuStripActivity2"
        Me.MenuStripActivity2.Size = New System.Drawing.Size(224, 32)
        Me.MenuStripActivity2.Text = "Activity 2"
        '
        'MenuStripActivity3
        '
        Me.MenuStripActivity3.BackColor = System.Drawing.Color.RoyalBlue
        Me.MenuStripActivity3.ForeColor = System.Drawing.Color.White
        Me.MenuStripActivity3.Name = "MenuStripActivity3"
        Me.MenuStripActivity3.Size = New System.Drawing.Size(224, 32)
        Me.MenuStripActivity3.Text = "Activity 3"
        '
        'Activity22ToolStripMenuItem
        '
        Me.Activity22ToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.Activity22ToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.Activity22ToolStripMenuItem.Name = "Activity22ToolStripMenuItem"
        Me.Activity22ToolStripMenuItem.Size = New System.Drawing.Size(224, 32)
        Me.Activity22ToolStripMenuItem.Text = "Activity2.2"
        '
        'MenuStripLogout
        '
        Me.MenuStripLogout.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStripLogout.ForeColor = System.Drawing.Color.White
        Me.MenuStripLogout.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MenuStripLogout.Name = "MenuStripLogout"
        Me.MenuStripLogout.Size = New System.Drawing.Size(91, 32)
        Me.MenuStripLogout.Text = "&Logout"
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.BackColor = System.Drawing.Color.Transparent
        Me.lblDateTime.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.Location = New System.Drawing.Point(12, 396)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(54, 23)
        Me.lblDateTime.TabIndex = 1
        Me.lblDateTime.Text = "Time"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bauhaus 93", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(7, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(414, 91)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "WELCOME " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bauhaus 93", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(88, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(333, 49)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hi I'm KR!SHA :>"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(376, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(454, 509)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(849, 477)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuStripFile As ToolStripMenuItem
    Friend WithEvents MenuStripTransaction As ToolStripMenuItem
    Friend WithEvents MenuStripReports As ToolStripMenuItem
    Friend WithEvents MenuStripHelpAndSupport As ToolStripMenuItem
    Friend WithEvents MenuStripActivities As ToolStripMenuItem
    Friend WithEvents MenuStripActivity1 As ToolStripMenuItem
    Friend WithEvents MenuStripActivity2 As ToolStripMenuItem
    Friend WithEvents MenuStripLogout As ToolStripMenuItem
    Friend WithEvents lblDateTime As Label
    Friend WithEvents MenuStripActivity3 As ToolStripMenuItem
    Friend WithEvents MenuStripAbout As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MenuStripProgTask1 As ToolStripMenuItem
    Friend WithEvents MenuStripProgTask2 As ToolStripMenuItem
    Friend WithEvents MenuStripProgTask3 As ToolStripMenuItem
    Friend WithEvents ProgTask11ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgTask12ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Activity22ToolStripMenuItem As ToolStripMenuItem
End Class
