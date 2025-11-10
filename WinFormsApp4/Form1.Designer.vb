<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        two = New PictureBox()
        One = New PictureBox()
        Three = New PictureBox()
        Four = New PictureBox()
        Five = New PictureBox()
        Six = New PictureBox()
        Button1 = New Button()
        CType(two, ComponentModel.ISupportInitialize).BeginInit()
        CType(One, ComponentModel.ISupportInitialize).BeginInit()
        CType(Three, ComponentModel.ISupportInitialize).BeginInit()
        CType(Four, ComponentModel.ISupportInitialize).BeginInit()
        CType(Five, ComponentModel.ISupportInitialize).BeginInit()
        CType(Six, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' two
        ' 
        two.BackColor = Color.Transparent
        two.Image = My.Resources.Resources.pngtree_six_sides_of_a_dice_dices_gamble_bet_photo_png_image_198196603
        two.InitialImage = My.Resources.Resources.pngtree_six_sides_of_a_dice_dices_gamble_bet_photo_png_image_198196603
        two.Location = New Point(22, 12)
        two.Name = "two"
        two.Size = New Size(221, 196)
        two.SizeMode = PictureBoxSizeMode.Zoom
        two.TabIndex = 0
        two.TabStop = False
        two.Visible = False
        ' 
        ' One
        ' 
        One.BackColor = Color.Transparent
        One.Image = My.Resources.Resources.pngtree_six_sides_of_a_dice_dices_gamble_bet_photo_png_image_19819603
        One.InitialImage = My.Resources.Resources.pngtree_six_sides_of_a_dice_dices_gamble_bet_photo_png_image_198196603
        One.Location = New Point(22, 12)
        One.Name = "One"
        One.Size = New Size(221, 196)
        One.SizeMode = PictureBoxSizeMode.Zoom
        One.TabIndex = 1
        One.TabStop = False
        One.Visible = False
        ' 
        ' Three
        ' 
        Three.BackColor = Color.Transparent
        Three.Image = My.Resources.Resources.pngtree_six_sides_of_a_dice_dices_gamble_bet_photo_png_image_19819603_1_
        Three.InitialImage = My.Resources.Resources.pngtree_six_sides_of_a_dice_dices_gamble_bet_photo_png_image_198196603
        Three.Location = New Point(22, 12)
        Three.Name = "Three"
        Three.Size = New Size(221, 196)
        Three.SizeMode = PictureBoxSizeMode.Zoom
        Three.TabIndex = 2
        Three.TabStop = False
        Three.Visible = False
        ' 
        ' Four
        ' 
        Four.BackColor = Color.Transparent
        Four.Image = My.Resources.Resources.image__1_
        Four.InitialImage = My.Resources.Resources.pngtree_six_sides_of_a_dice_dices_gamble_bet_photo_png_image_198196603
        Four.Location = New Point(22, 12)
        Four.Name = "Four"
        Four.Size = New Size(221, 196)
        Four.SizeMode = PictureBoxSizeMode.Zoom
        Four.TabIndex = 3
        Four.TabStop = False
        Four.Visible = False
        ' 
        ' Five
        ' 
        Five.BackColor = Color.Transparent
        Five.Image = My.Resources.Resources.image__2_
        Five.InitialImage = My.Resources.Resources.pngtree_six_sides_of_a_dice_dices_gamble_bet_photo_png_image_198196603
        Five.Location = New Point(22, 12)
        Five.Name = "Five"
        Five.Size = New Size(221, 196)
        Five.SizeMode = PictureBoxSizeMode.Zoom
        Five.TabIndex = 4
        Five.TabStop = False
        Five.Visible = False
        ' 
        ' Six
        ' 
        Six.BackColor = Color.Transparent
        Six.Image = My.Resources.Resources.image__3_
        Six.InitialImage = My.Resources.Resources.pngtree_six_sides_of_a_dice_dices_gamble_bet_photo_png_image_198196603
        Six.Location = New Point(22, 12)
        Six.Name = "Six"
        Six.Size = New Size(221, 196)
        Six.SizeMode = PictureBoxSizeMode.Zoom
        Six.TabIndex = 5
        Six.TabStop = False
        Six.Visible = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Maroon
        Button1.FlatAppearance.BorderColor = Color.Maroon
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Comic Sans MS", 35.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(22, 214)
        Button1.Name = "Button1"
        Button1.Size = New Size(221, 70)
        Button1.TabIndex = 6
        Button1.Text = "Roll!"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.istockphoto_1344749939_612x612
        ClientSize = New Size(266, 296)
        Controls.Add(Button1)
        Controls.Add(Six)
        Controls.Add(Five)
        Controls.Add(Four)
        Controls.Add(Three)
        Controls.Add(One)
        Controls.Add(two)
        Name = "Form1"
        Text = "Form1"
        CType(two, ComponentModel.ISupportInitialize).EndInit()
        CType(One, ComponentModel.ISupportInitialize).EndInit()
        CType(Three, ComponentModel.ISupportInitialize).EndInit()
        CType(Four, ComponentModel.ISupportInitialize).EndInit()
        CType(Five, ComponentModel.ISupportInitialize).EndInit()
        CType(Six, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents two As PictureBox
    Friend WithEvents One As PictureBox
    Friend WithEvents Three As PictureBox
    Friend WithEvents Four As PictureBox
    Friend WithEvents Five As PictureBox
    Friend WithEvents Six As PictureBox
    Friend WithEvents Button1 As Button

End Class
