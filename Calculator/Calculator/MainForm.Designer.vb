﻿'
' Created by SharpDevelop.
' User: Dan
' Date: 12/08/2014
' Time: 12:44
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.txtDisplayBox = New System.Windows.Forms.Label()
		Me.btn0 = New System.Windows.Forms.Button()
		Me.btn1 = New System.Windows.Forms.Button()
		Me.btn2 = New System.Windows.Forms.Button()
		Me.btn3 = New System.Windows.Forms.Button()
		Me.btn4 = New System.Windows.Forms.Button()
		Me.btn5 = New System.Windows.Forms.Button()
		Me.btn6 = New System.Windows.Forms.Button()
		Me.btn7 = New System.Windows.Forms.Button()
		Me.btn8 = New System.Windows.Forms.Button()
		Me.btn9 = New System.Windows.Forms.Button()
		Me.btnEquals = New System.Windows.Forms.Button()
		Me.btnPlus = New System.Windows.Forms.Button()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnMultiply = New System.Windows.Forms.Button()
		Me.buttonDivide = New System.Windows.Forms.Button()
		Me.btnSubtract = New System.Windows.Forms.Button()
		Me.btnDecimal = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'txtDisplayBox
		'
		Me.txtDisplayBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.txtDisplayBox.Location = New System.Drawing.Point(52, 62)
		Me.txtDisplayBox.Name = "txtDisplayBox"
		Me.txtDisplayBox.Size = New System.Drawing.Size(169, 20)
		Me.txtDisplayBox.TabIndex = 1
		'
		'btn0
		'
		Me.btn0.Location = New System.Drawing.Point(59, 202)
		Me.btn0.Name = "btn0"
		Me.btn0.Size = New System.Drawing.Size(37, 23)
		Me.btn0.TabIndex = 2
		Me.btn0.Text = "0"
		Me.btn0.UseVisualStyleBackColor = true
		AddHandler Me.btn0.Click, AddressOf Me.Btn0Click
		'
		'btn1
		'
		Me.btn1.Location = New System.Drawing.Point(59, 173)
		Me.btn1.Name = "btn1"
		Me.btn1.Size = New System.Drawing.Size(37, 23)
		Me.btn1.TabIndex = 3
		Me.btn1.Text = "1"
		Me.btn1.UseVisualStyleBackColor = true
		AddHandler Me.btn1.Click, AddressOf Me.Btn1Click
		'
		'btn2
		'
		Me.btn2.Location = New System.Drawing.Point(115, 173)
		Me.btn2.Name = "btn2"
		Me.btn2.Size = New System.Drawing.Size(37, 23)
		Me.btn2.TabIndex = 4
		Me.btn2.Text = "2"
		Me.btn2.UseVisualStyleBackColor = true
		AddHandler Me.btn2.Click, AddressOf Me.Btn2Click
		'
		'btn3
		'
		Me.btn3.Location = New System.Drawing.Point(170, 173)
		Me.btn3.Name = "btn3"
		Me.btn3.Size = New System.Drawing.Size(36, 23)
		Me.btn3.TabIndex = 5
		Me.btn3.Text = "3"
		Me.btn3.UseVisualStyleBackColor = true
		AddHandler Me.btn3.Click, AddressOf Me.Btn3Click
		'
		'btn4
		'
		Me.btn4.Location = New System.Drawing.Point(59, 144)
		Me.btn4.Name = "btn4"
		Me.btn4.Size = New System.Drawing.Size(37, 23)
		Me.btn4.TabIndex = 6
		Me.btn4.Text = "4"
		Me.btn4.UseVisualStyleBackColor = true
		AddHandler Me.btn4.Click, AddressOf Me.Btn4Click
		'
		'btn5
		'
		Me.btn5.Location = New System.Drawing.Point(115, 144)
		Me.btn5.Name = "btn5"
		Me.btn5.Size = New System.Drawing.Size(37, 23)
		Me.btn5.TabIndex = 7
		Me.btn5.Text = "5"
		Me.btn5.UseVisualStyleBackColor = true
		AddHandler Me.btn5.Click, AddressOf Me.Btn5Click
		'
		'btn6
		'
		Me.btn6.Location = New System.Drawing.Point(170, 144)
		Me.btn6.Name = "btn6"
		Me.btn6.Size = New System.Drawing.Size(36, 23)
		Me.btn6.TabIndex = 8
		Me.btn6.Text = "6"
		Me.btn6.UseVisualStyleBackColor = true
		AddHandler Me.btn6.Click, AddressOf Me.Btn6Click
		'
		'btn7
		'
		Me.btn7.Location = New System.Drawing.Point(59, 115)
		Me.btn7.Name = "btn7"
		Me.btn7.Size = New System.Drawing.Size(37, 23)
		Me.btn7.TabIndex = 9
		Me.btn7.Text = "7"
		Me.btn7.UseVisualStyleBackColor = true
		AddHandler Me.btn7.Click, AddressOf Me.Btn7Click
		'
		'btn8
		'
		Me.btn8.Location = New System.Drawing.Point(115, 115)
		Me.btn8.Name = "btn8"
		Me.btn8.Size = New System.Drawing.Size(37, 23)
		Me.btn8.TabIndex = 10
		Me.btn8.Text = "8"
		Me.btn8.UseVisualStyleBackColor = true
		AddHandler Me.btn8.Click, AddressOf Me.Btn8Click
		'
		'btn9
		'
		Me.btn9.Location = New System.Drawing.Point(170, 114)
		Me.btn9.Name = "btn9"
		Me.btn9.Size = New System.Drawing.Size(36, 23)
		Me.btn9.TabIndex = 11
		Me.btn9.Text = "9"
		Me.btn9.UseVisualStyleBackColor = true
		AddHandler Me.btn9.Click, AddressOf Me.Btn9Click
		'
		'btnEquals
		'
		Me.btnEquals.Location = New System.Drawing.Point(170, 202)
		Me.btnEquals.Name = "btnEquals"
		Me.btnEquals.Size = New System.Drawing.Size(36, 23)
		Me.btnEquals.TabIndex = 12
		Me.btnEquals.Text = "="
		Me.btnEquals.UseVisualStyleBackColor = true
		AddHandler Me.btnEquals.Click, AddressOf Me.BtnEqualsClick
		'
		'btnPlus
		'
		Me.btnPlus.Location = New System.Drawing.Point(223, 114)
		Me.btnPlus.Name = "btnPlus"
		Me.btnPlus.Size = New System.Drawing.Size(34, 23)
		Me.btnPlus.TabIndex = 13
		Me.btnPlus.Text = "+"
		Me.btnPlus.UseVisualStyleBackColor = true
		AddHandler Me.btnPlus.Click, AddressOf Me.BtnPlusClick
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(246, 59)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(44, 23)
		Me.btnClear.TabIndex = 14
		Me.btnClear.Text = "Clear"
		Me.btnClear.UseVisualStyleBackColor = true
		AddHandler Me.btnClear.Click, AddressOf Me.BtnClearClick
		'
		'btnMultiply
		'
		Me.btnMultiply.Location = New System.Drawing.Point(223, 173)
		Me.btnMultiply.Name = "btnMultiply"
		Me.btnMultiply.Size = New System.Drawing.Size(34, 23)
		Me.btnMultiply.TabIndex = 16
		Me.btnMultiply.Text = "X"
		Me.btnMultiply.UseVisualStyleBackColor = true
		AddHandler Me.btnMultiply.Click, AddressOf Me.BtnMultiplyClick
		'
		'buttonDivide
		'
		Me.buttonDivide.Location = New System.Drawing.Point(223, 203)
		Me.buttonDivide.Name = "buttonDivide"
		Me.buttonDivide.Size = New System.Drawing.Size(34, 23)
		Me.buttonDivide.TabIndex = 17
		Me.buttonDivide.Text = "/"
		Me.buttonDivide.UseVisualStyleBackColor = true
		AddHandler Me.buttonDivide.Click, AddressOf Me.ButtonDivideClick
		'
		'btnSubtract
		'
		Me.btnSubtract.Location = New System.Drawing.Point(223, 144)
		Me.btnSubtract.Name = "btnSubtract"
		Me.btnSubtract.Size = New System.Drawing.Size(34, 23)
		Me.btnSubtract.TabIndex = 19
		Me.btnSubtract.Text = "-"
		Me.btnSubtract.UseVisualStyleBackColor = true
		AddHandler Me.btnSubtract.Click, AddressOf Me.BtnSubtractClick
		'
		'btnDecimal
		'
		Me.btnDecimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnDecimal.Location = New System.Drawing.Point(115, 202)
		Me.btnDecimal.Name = "btnDecimal"
		Me.btnDecimal.Size = New System.Drawing.Size(37, 23)
		Me.btnDecimal.TabIndex = 20
		Me.btnDecimal.Text = "."
		Me.btnDecimal.UseVisualStyleBackColor = true
		AddHandler Me.btnDecimal.Click, AddressOf Me.BtnDecimalClick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(315, 268)
		Me.Controls.Add(Me.btnDecimal)
		Me.Controls.Add(Me.btnSubtract)
		Me.Controls.Add(Me.buttonDivide)
		Me.Controls.Add(Me.btnMultiply)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnPlus)
		Me.Controls.Add(Me.btnEquals)
		Me.Controls.Add(Me.btn9)
		Me.Controls.Add(Me.btn8)
		Me.Controls.Add(Me.btn7)
		Me.Controls.Add(Me.btn6)
		Me.Controls.Add(Me.btn5)
		Me.Controls.Add(Me.btn4)
		Me.Controls.Add(Me.btn3)
		Me.Controls.Add(Me.btn2)
		Me.Controls.Add(Me.btn1)
		Me.Controls.Add(Me.btn0)
		Me.Controls.Add(Me.txtDisplayBox)
		Me.Name = "MainForm"
		Me.Text = "Calculator"
		Me.ResumeLayout(false)
	End Sub
	Private btnDecimal As System.Windows.Forms.Button
	Private btnSubtract As System.Windows.Forms.Button
	Private buttonDivide As System.Windows.Forms.Button
	Private btnMultiply As System.Windows.Forms.Button
	Private btnClear As System.Windows.Forms.Button
	Private btnPlus As System.Windows.Forms.Button
	Private btnEquals As System.Windows.Forms.Button
	Private btn9 As System.Windows.Forms.Button
	Private btn8 As System.Windows.Forms.Button
	Private btn7 As System.Windows.Forms.Button
	Private btn6 As System.Windows.Forms.Button
	Private btn5 As System.Windows.Forms.Button
	Private btn4 As System.Windows.Forms.Button
	Private btn3 As System.Windows.Forms.Button
	Private btn2 As System.Windows.Forms.Button
	Private btn1 As System.Windows.Forms.Button
	Private txtDisplayBox As System.Windows.Forms.Label
	Private btn0 As System.Windows.Forms.Button
	
	Dim firstNum As Double
	Dim secondNum As Double
	Dim mathmaticalOperator As String
	Dim inputFlag As Boolean
	Dim calculateFlag As Boolean
	
	Sub Btn0Click(sender As Object, e As EventArgs)
		If txtDisplayBox.Text.Length >= 1 Then
			If inputFlag Then
				txtDisplayBox.Text += btn0.Text
			Else
				txtDisplayBox.Text = btn0.Text
				inputFlag = True
			End If
			calculateFlag = True
		End If
	End Sub
	
	Sub Btn1Click(sender As Object, e As EventArgs)
		If inputFlag Then
			txtDisplayBox.Text += btn1.Text
			calculateFlag = True
		Else
			txtDisplayBox.Text = btn1.Text
			inputFlag = True
			calculateFlag = True
		End If
	End Sub
	
	Sub Btn2Click(sender As Object, e As EventArgs)
		If inputFlag Then
			txtDisplayBox.Text += btn2.Text
			calculateFlag = True
		Else
			txtDisplayBox.Text = btn2.Text
			inputFlag = True
			calculateFlag = True
		End If
	End Sub
	
	Sub Btn3Click(sender As Object, e As EventArgs)
		If inputFlag Then
			txtDisplayBox.Text += btn3.Text
			calculateFlag = True
		Else
			txtDisplayBox.Text = btn3.Text
			inputFlag = True
			calculateFlag = True
		End If
	End Sub
	
	Sub Btn4Click(sender As Object, e As EventArgs)
		If inputFlag Then
			txtDisplayBox.Text += btn4.Text
			calculateFlag = True
		Else
			txtDisplayBox.Text = btn4.Text
			inputFlag = True
			calculateFlag = True
		End If
	End Sub
	
	Sub Btn5Click(sender As Object, e As EventArgs)
		If inputFlag Then
			txtDisplayBox.Text += btn5.Text
		Else
			txtDisplayBox.Text = btn5.Text
			inputFlag = True
		End If
	End Sub
	
	Sub Btn6Click(sender As Object, e As EventArgs)
		If inputFlag Then
			txtDisplayBox.Text += btn6.Text
			calculateFlag = True
		Else
			txtDisplayBox.Text = btn6.Text
			inputFlag = True
			calculateFlag = True
		End If
	End Sub
	
	Sub Btn7Click(sender As Object, e As EventArgs)
		If inputFlag Then
			txtDisplayBox.Text += btn7.Text
			calculateFlag = True
		Else
			txtDisplayBox.Text = btn7.Text
			inputFlag = True
			calculateFlag = True
		End If
	End Sub
	
	Sub Btn8Click(sender As Object, e As EventArgs)
		If inputFlag Then
			txtDisplayBox.Text += btn8.Text
			calculateFlag = True
		Else
			txtDisplayBox.Text = btn8.Text
			inputFlag = True
			calculateFlag = True
		End If
	End Sub
	
	Sub Btn9Click(sender As Object, e As EventArgs)
		If inputFlag Then
			txtDisplayBox.Text += btn9.Text
			calculateFlag = True
		Else
			txtDisplayBox.Text = btn9.Text
			inputFlag = True
			calculateFlag = True
		End If
	End Sub
	
	Sub BtnClearClick(sender As Object, e As EventArgs)
		txtDisplayBox.Text = ""
		mathmaticalOperator = ""
		firstNum = 0
		secondNum = 0		
	End Sub
	
	Sub BtnPlusClick(sender As Object, e As EventArgs)
		If mathmaticalOperator = String.Empty Then
			firstNum = Val(txtDisplayBox.Text)
			txtDisplayBox.Text = ""
		Else
			CalculateNums()
		End If
		mathmaticalOperator = "+"
	End Sub
	
	Sub BtnEqualsClick(sender As Object, e As EventArgs)
		CalculateNums()
	End Sub
	
	Sub BtnMultiplyClick(sender As Object, e As EventArgs)
		If mathmaticalOperator = String.Empty Then
			firstNum = Val(txtDisplayBox.Text)
			txtDisplayBox.Text = ""
		Else
			CalculateNums()
		End If
		mathmaticalOperator = "*"
	End Sub
	
	Sub ButtonDivideClick(sender As Object, e As EventArgs)
		If mathmaticalOperator = String.Empty Then
			firstNum = Val(txtDisplayBox.Text)
			txtDisplayBox.Text = ""
		Else
			CalculateNums()
		End If
		mathmaticalOperator = "/"
	End Sub
	
	Sub BtnSubtractClick(sender As Object, e As EventArgs)
		If mathmaticalOperator = String.Empty Then
			firstNum = Val(txtDisplayBox.Text)
			txtDisplayBox.Text = ""
		Else
			CalculateNums()
		End If
		mathmaticalOperator = "-"
	End Sub
	
	Private Sub CalculateNums()
		If calculateFlag Then
   			secondNum = Val(txtDisplayBox.Text)
   			Select Case mathmaticalOperator
	    		Case "+"
		   			firstNum = firstNum + secondNum
	   			Case "-"
	   				firstNum = firstNum - secondNum
	   			Case "*"
		   			firstNum = firstNum * secondNum
	   			Case "/"
		   			firstNum = firstNum / secondNum
   		End Select
   		txtDisplayBox.Text = CType(firstNum, String)
   		inputFlag = False
   		calculateFlag = False
   		End If
	End Sub
	
	Sub BtnDecimalClick(sender As Object, e As EventArgs)
		If Not txtDisplayBox.Text.Contains(".") Then
			If txtDisplayBox.Text.Length = 0 Then
				inputFlag = True
				txtDisplayBox.Text = "0" + btnDecimal.Text
			Else
				txtDisplayBox.Text += btnDecimal.Text
			End If			
		End If
	End Sub
End Class