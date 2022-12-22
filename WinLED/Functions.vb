Public Class Functions
	Public Structure RGB
		Private _r As Byte
		Private _g As Byte
		Private _b As Byte

		Public Sub New(r As Byte, g As Byte, b As Byte)
			Me._r = r
			Me._g = g
			Me._b = b
		End Sub

		Public Property R() As Byte
			Get
				Return Me._r
			End Get
			Set(value As Byte)
				Me._r = value
			End Set
		End Property

		Public Property G() As Byte
			Get
				Return Me._g
			End Get
			Set(value As Byte)
				Me._g = value
			End Set
		End Property

		Public Property B() As Byte
			Get
				Return Me._b
			End Get
			Set(value As Byte)
				Me._b = value
			End Set
		End Property

		Public Overloads Function Equals(rgb As RGB) As Boolean
			Return (Me.R = rgb.R) AndAlso (Me.G = rgb.G) AndAlso (Me.B = rgb.B)
		End Function
	End Structure

	Public Structure HSL
		Private _h As Integer
		Private _s As Single
		Private _l As Single

		Public Sub New(h As Integer, s As Single, l As Single)
			Me._h = h
			Me._s = s
			Me._l = l
		End Sub

		Public Property H() As Integer
			Get
				Return Me._h
			End Get
			Set(value As Integer)
				Me._h = value
			End Set
		End Property

		Public Property S() As Single
			Get
				Return Me._s
			End Get
			Set(value As Single)
				Me._s = value
			End Set
		End Property

		Public Property L() As Single
			Get
				Return Me._l
			End Get
			Set(value As Single)
				Me._l = value
			End Set
		End Property

		Public Overloads Function Equals(hsl As HSL) As Boolean
			Return (Me.H = hsl.H) AndAlso (Me.S = hsl.S) AndAlso (Me.L = hsl.L)
		End Function
	End Structure

	Public Shared Function HSLToRGB(hsl As HSL) As RGB
		Dim r As Byte = 0
		Dim g As Byte = 0
		Dim b As Byte = 0

		If hsl.S = 0 Then
			r = CByte(Math.Truncate(hsl.L * 255))
			g = CByte(Math.Truncate(hsl.L * 255))
			b = CByte(Math.Truncate(hsl.L * 255))
		Else
			Dim v1 As Single, v2 As Single
			Dim hue As Single = CSng(hsl.H) / 360

			v2 = If((hsl.L < 0.5), (hsl.L * (1 + hsl.S)), ((hsl.L + hsl.S) - (hsl.L * hsl.S)))
			v1 = 2 * hsl.L - v2

			r = CByte(Math.Truncate(255 * HueToRGB(v1, v2, hue + (1.0F / 3))))
			g = CByte(Math.Truncate(255 * HueToRGB(v1, v2, hue)))
			b = CByte(Math.Truncate(255 * HueToRGB(v1, v2, hue - (1.0F / 3))))
		End If

		Return New RGB(r, g, b)
	End Function

	Private Shared Function HueToRGB(v1 As Single, v2 As Single, vH As Single) As Single
		If vH < 0 Then
			vH += 1
		End If

		If vH > 1 Then
			vH -= 1
		End If

		If (6 * vH) < 1 Then
			Return (v1 + (v2 - v1) * 6 * vH)
		End If

		If (2 * vH) < 1 Then
			Return v2
		End If

		If (3 * vH) < 2 Then
			Return (v1 + (v2 - v1) * ((2.0F / 3) - vH) * 6)
		End If

		Return v1
	End Function
End Class