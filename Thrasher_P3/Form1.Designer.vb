<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        LabelCatering = New Label()
        LabelMarket = New Label()
        PicturePlatter = New PictureBox()
        RadioGourmet = New RadioButton()
        GroupBox1 = New GroupBox()
        RadioFruit = New RadioButton()
        RadioSausage = New RadioButton()
        RadioVeggie = New RadioButton()
        RadioWraps = New RadioButton()
        LabelLoyalty = New Label()
        TextPointsBox = New TextBox()
        GroupBox2 = New GroupBox()
        RadioPickupPay = New RadioButton()
        RadioPrePay = New RadioButton()
        LabelPlease = New Label()
        ButtonCalculate = New Button()
        ButtonClear = New Button()
        TextBoxOutput = New TextBox()
        CType(PicturePlatter, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' LabelCatering
        ' 
        LabelCatering.AutoSize = True
        LabelCatering.Font = New Font("Lucida Bright", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelCatering.Location = New Point(98, 9)
        LabelCatering.Name = "LabelCatering"
        LabelCatering.Size = New Size(169, 41)
        LabelCatering.TabIndex = 0
        LabelCatering.Text = "Catering"
        ' 
        ' LabelMarket
        ' 
        LabelMarket.AutoSize = True
        LabelMarket.Font = New Font("Lucida Bright", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelMarket.Location = New Point(94, 61)
        LabelMarket.Name = "LabelMarket"
        LabelMarket.Size = New Size(176, 31)
        LabelMarket.TabIndex = 1
        LabelMarket.Text = "Star Market"
        ' 
        ' PicturePlatter
        ' 
        PicturePlatter.BackgroundImage = CType(resources.GetObject("PicturePlatter.BackgroundImage"), Image)
        PicturePlatter.BackgroundImageLayout = ImageLayout.Stretch
        PicturePlatter.Location = New Point(512, 12)
        PicturePlatter.Name = "PicturePlatter"
        PicturePlatter.Size = New Size(426, 256)
        PicturePlatter.TabIndex = 2
        PicturePlatter.TabStop = False
        ' 
        ' RadioGourmet
        ' 
        RadioGourmet.AutoSize = True
        RadioGourmet.Font = New Font("Lucida Bright", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioGourmet.Location = New Point(6, 14)
        RadioGourmet.Name = "RadioGourmet"
        RadioGourmet.Size = New Size(270, 27)
        RadioGourmet.TabIndex = 3
        RadioGourmet.TabStop = True
        RadioGourmet.Text = "Gourmet Cheese $49.99"
        RadioGourmet.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FloralWhite
        GroupBox1.BackgroundImageLayout = ImageLayout.None
        GroupBox1.Controls.Add(RadioFruit)
        GroupBox1.Controls.Add(RadioSausage)
        GroupBox1.Controls.Add(RadioVeggie)
        GroupBox1.Controls.Add(RadioWraps)
        GroupBox1.Controls.Add(RadioGourmet)
        GroupBox1.Location = New Point(15, 118)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(407, 189)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        ' 
        ' RadioFruit
        ' 
        RadioFruit.AutoSize = True
        RadioFruit.Font = New Font("Lucida Bright", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioFruit.Location = New Point(6, 146)
        RadioFruit.Name = "RadioFruit"
        RadioFruit.Size = New Size(153, 27)
        RadioFruit.TabIndex = 5
        RadioFruit.TabStop = True
        RadioFruit.Text = "Fruit $29.99"
        RadioFruit.UseVisualStyleBackColor = True
        ' 
        ' RadioSausage
        ' 
        RadioSausage.AutoSize = True
        RadioSausage.Font = New Font("Lucida Bright", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioSausage.Location = New Point(6, 113)
        RadioSausage.Name = "RadioSausage"
        RadioSausage.Size = New Size(303, 27)
        RadioSausage.TabIndex = 5
        RadioSausage.TabStop = True
        RadioSausage.Text = "Sausage and Cheese $49.99"
        RadioSausage.UseVisualStyleBackColor = True
        ' 
        ' RadioVeggie
        ' 
        RadioVeggie.AutoSize = True
        RadioVeggie.Font = New Font("Lucida Bright", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioVeggie.Location = New Point(6, 80)
        RadioVeggie.Name = "RadioVeggie"
        RadioVeggie.Size = New Size(170, 27)
        RadioVeggie.TabIndex = 5
        RadioVeggie.TabStop = True
        RadioVeggie.Text = "Veggie $29.99"
        RadioVeggie.UseVisualStyleBackColor = True
        ' 
        ' RadioWraps
        ' 
        RadioWraps.AutoSize = True
        RadioWraps.Font = New Font("Lucida Bright", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioWraps.Location = New Point(6, 47)
        RadioWraps.Name = "RadioWraps"
        RadioWraps.Size = New Size(262, 27)
        RadioWraps.TabIndex = 4
        RadioWraps.TabStop = True
        RadioWraps.Text = "Pinwheel Wraps $59.99"
        RadioWraps.UseVisualStyleBackColor = True
        ' 
        ' LabelLoyalty
        ' 
        LabelLoyalty.AutoSize = True
        LabelLoyalty.Font = New Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelLoyalty.Location = New Point(541, 282)
        LabelLoyalty.Name = "LabelLoyalty"
        LabelLoyalty.Size = New Size(184, 27)
        LabelLoyalty.TabIndex = 5
        LabelLoyalty.Text = "Loyalty Points"
        ' 
        ' TextPointsBox
        ' 
        TextPointsBox.BorderStyle = BorderStyle.FixedSingle
        TextPointsBox.Cursor = Cursors.IBeam
        TextPointsBox.Font = New Font("Lucida Bright", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextPointsBox.Location = New Point(790, 280)
        TextPointsBox.Name = "TextPointsBox"
        TextPointsBox.Size = New Size(79, 31)
        TextPointsBox.TabIndex = 7
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.OldLace
        GroupBox2.Controls.Add(RadioPickupPay)
        GroupBox2.Controls.Add(RadioPrePay)
        GroupBox2.Location = New Point(98, 313)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(324, 90)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        ' 
        ' RadioPickupPay
        ' 
        RadioPickupPay.AutoSize = True
        RadioPickupPay.Font = New Font("Lucida Bright", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioPickupPay.Location = New Point(6, 57)
        RadioPickupPay.Name = "RadioPickupPay"
        RadioPickupPay.Size = New Size(198, 27)
        RadioPickupPay.TabIndex = 7
        RadioPickupPay.TabStop = True
        RadioPickupPay.Text = "Pay upon Pickup"
        RadioPickupPay.UseVisualStyleBackColor = True
        ' 
        ' RadioPrePay
        ' 
        RadioPrePay.AutoSize = True
        RadioPrePay.Font = New Font("Lucida Bright", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadioPrePay.Location = New Point(6, 24)
        RadioPrePay.Name = "RadioPrePay"
        RadioPrePay.Size = New Size(108, 27)
        RadioPrePay.TabIndex = 6
        RadioPrePay.TabStop = True
        RadioPrePay.Text = "Pre-Pay"
        RadioPrePay.UseVisualStyleBackColor = True
        ' 
        ' LabelPlease
        ' 
        LabelPlease.AutoSize = True
        LabelPlease.Font = New Font("Lucida Bright", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelPlease.Location = New Point(98, 435)
        LabelPlease.Name = "LabelPlease"
        LabelPlease.Size = New Size(121, 23)
        LabelPlease.TabIndex = 9
        LabelPlease.Text = "Please Pay:"
        ' 
        ' ButtonCalculate
        ' 
        ButtonCalculate.BackColor = Color.PeachPuff
        ButtonCalculate.Font = New Font("Lucida Bright", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonCalculate.Location = New Point(572, 365)
        ButtonCalculate.Name = "ButtonCalculate"
        ButtonCalculate.Size = New Size(122, 37)
        ButtonCalculate.TabIndex = 10
        ButtonCalculate.Text = "Calculate"
        ButtonCalculate.UseVisualStyleBackColor = False
        ' 
        ' ButtonClear
        ' 
        ButtonClear.BackColor = Color.PeachPuff
        ButtonClear.Font = New Font("Lucida Bright", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonClear.Location = New Point(768, 365)
        ButtonClear.Name = "ButtonClear"
        ButtonClear.Size = New Size(122, 37)
        ButtonClear.TabIndex = 11
        ButtonClear.Text = "Clear"
        ButtonClear.UseVisualStyleBackColor = False
        ' 
        ' TextBoxOutput
        ' 
        TextBoxOutput.BackColor = Color.PeachPuff
        TextBoxOutput.BorderStyle = BorderStyle.None
        TextBoxOutput.Font = New Font("Lucida Bright", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxOutput.Location = New Point(225, 426)
        TextBoxOutput.Multiline = True
        TextBoxOutput.Name = "TextBoxOutput"
        TextBoxOutput.Size = New Size(674, 55)
        TextBoxOutput.TabIndex = 12
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PeachPuff
        ClientSize = New Size(950, 502)
        Controls.Add(TextBoxOutput)
        Controls.Add(ButtonClear)
        Controls.Add(ButtonCalculate)
        Controls.Add(LabelPlease)
        Controls.Add(GroupBox2)
        Controls.Add(TextPointsBox)
        Controls.Add(LabelLoyalty)
        Controls.Add(GroupBox1)
        Controls.Add(PicturePlatter)
        Controls.Add(LabelMarket)
        Controls.Add(LabelCatering)
        Name = "Form1"
        Text = "Catering"
        CType(PicturePlatter, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelCatering As Label
    Friend WithEvents LabelMarket As Label
    Friend WithEvents PicturePlatter As PictureBox
    Friend WithEvents RadioGourmet As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioWraps As RadioButton
    Friend WithEvents RadioFruit As RadioButton
    Friend WithEvents RadioSausage As RadioButton
    Friend WithEvents RadioVeggie As RadioButton
    Friend WithEvents LabelLoyalty As Label
    Friend WithEvents TextPointsBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioPickupPay As RadioButton
    Friend WithEvents RadioPrePay As RadioButton
    Friend WithEvents LabelPlease As Label
    Friend WithEvents ButtonCalculate As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents TextBoxOutput As TextBox

End Class
