Imports System.Globalization

Module Modulo_EstructurasDeDatos
	Structure CAT_MA
		<VBFixedString(6), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=6)> Public B1 As String
		<VBFixedString(32), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=32)> Public B2 As String
		<VBFixedString(16), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=16)> Public B3 As String
		<VBFixedString(5), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=5)> Public B4 As String
		<VBFixedString(5), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=5)> Public B5 As String
	End Structure

	Structure ope
		<VBFixedString(6), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=6)> Public CTA As String
		<VBFixedString(30), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=30)> Public reda As String
		<VBFixedString(2), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=2)> Public fecha As String
		<VBFixedString(16), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=16)> Public impo As String
		<VBFixedString(1), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=1)> Public clav As String
		<VBFixedString(9), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=9)> Public real As String
	End Structure
	Structure otr
		<VBFixedString(6), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=6)> Public CTA As String
		<VBFixedString(30), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=30)> Public reda As String
		<VBFixedString(2), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=2)> Public fecha As String
		<VBFixedString(16), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=16)> Public impo As String
		<VBFixedString(1), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=1)> Public clav As String
		<VBFixedString(9), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=9)> Public real As String
	End Structure
	Structure Rg
		Public De As Integer
		Public A As Integer
		Public Ubic As Integer
	End Structure
	Structure Ct
		Public Num As Integer
		Public Num1 As Integer
		Public Num2 As Integer
		<VBFixedString(32), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=32)> Public Nom1 As String
		<VBFixedString(32), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=32)> Public Nom2 As String
		<VBFixedString(32), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=32)> Public Nom3 As String
		Public Sdo As Double
		Public Sdo1 As Double
		Public Sdo2 As Double
	End Structure
	Structure DAT_OS
		<VBFixedString(64), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=65)> Public D1 As String
		<VBFixedString(60), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=60)> Public D2 As String
		<VBFixedString(45), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=45)> Public D3 As String
		<VBFixedString(15), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=15)> Public No_arch As String
		<VBFixedString(5), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=5)> Public a_o As String
		<VBFixedString(25), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=25)> Public others1 As String
		<VBFixedString(5), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=5)> Public ultimaPol1 As String
		<VBFixedString(5), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=5)> Public ultimoReg As String
		<VBFixedString(12), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=12)> Public others As String
	End Structure
	Structure oper_aciones
		<VBFixedString(6), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=6)> Public CTA As String
		<VBFixedString(30), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=30)> Public descr As String
		<VBFixedString(2), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=2)> Public fe As String
		<VBFixedString(16), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=16)> Public impte As String
		<VBFixedString(1), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=1)> Public indenti As String
		<VBFixedString(9), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=9)> Public real As String
	End Structure

	Structure CAT_AX
		<VBFixedString(6), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=6)> Public C1 As String
		<VBFixedString(32), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=32)> Public C2 As String
		<VBFixedString(16), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=16)> Public C3 As String
		<VBFixedString(5), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=5)> Public C4 As String
		<VBFixedString(5), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=5)> Public C5 As String
	End Structure
	Structure per
		<VBFixedString(20), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=20)> Public nom As String
		<VBFixedString(20), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=20)> Public ape1 As String
		<VBFixedString(20), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=20)> Public ape2 As String
		<VBFixedString(18), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=18)> Public RFC As String
		<VBFixedString(18), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=18)> Public imss As String
		<VBFixedString(12), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=12)> Public fal As String
		<VBFixedString(12), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=12)> Public fab As String
		Public ingr As Long
		Public viat As Long
		Public otras As Long
		Public integrado As Long
	End Structure
	Structure basini
		Public datoArch As String
	End Structure
	Structure nom
		Public dias As Decimal
		Public hsnor As Decimal
		Public hs_no As Decimal
		Public hsdbl As Decimal
		Public hs_db As Decimal
		Public hstri As Decimal
		Public hs_tr As Decimal
		Public ispt As Decimal
		Public crdsal As Decimal
		Public imss As Decimal
		Public sueldo As Decimal
		Public hs_nor As Decimal
		Public hs_dbl As Decimal
		Public hs_tri As Decimal
		Public viaticos As Decimal
		Public pvac As Decimal
		Public otras As Decimal
		Public aguin As Decimal
		Public ptu As Decimal
		Public exentos As Decimal
		Public prestamos As Decimal
		Public fonacot As Decimal
		Public telefono As Decimal
		Public otraded As Decimal
	End Structure

	Structure Clabnx
		<VBFixedString(16), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=16)> Public Q1 As String
	End Structure

	Structure OtrasCh
		<VBFixedString(30), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=30)> Public CURP As String
		<VBFixedString(30), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=30)> Public otra As String
		<VBFixedString(30), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=30)> Public yotra As String
		<VBFixedString(30), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=30)> Public yporsi As String
	End Structure

	REM DECLARACION DE VARIABLES DE TIPO ESTRUCTURAS
	Public CATAUX As CAT_AX
	Public CATMAY As CAT_MA
	Public Ctos As ope
	Public otros As otr
	Public renglon As Rg
	Public cuentas As Ct
	Public DATOS As DAT_OS
	Public OPER As oper_aciones

	Public personal As per
	Public cuentasDeBanco As Clabnx
	Public otrosCampos As OtrasCh


	Public Sub imprimirPersonal(grillaDat As DataGridView)
		Dim largoDelRandom As Integer
		Dim rutaDelEjecutable As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location)

		FileOpen(1, rutaDelEjecutable + "\personal.dno", OpenMode.Random,,, Len(personal))
		largoDelRandom = LOF(1) \ Len(personal)

		grillaDat.ColumnCount = 12

		For i As Integer = 1 To largoDelRandom
			FileGet(1, personal, i)
			grillaDat.Rows.Add(personal.nom, personal.ape1, personal.ape2, personal.RFC, personal.imss, personal.fal, personal.fab, personal.ingr / 10000, personal.viat, personal.otras, personal.integrado)
		Next i

		grillaDat.Focus()
		FileClose(1)

	End Sub

	Public Sub imprimirAuxiliar(grillaDat As DataGridView)
		Dim largoDelRandom As Integer
		Dim rutaDelEjecutable As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location)

		FileOpen(2, rutaDelEjecutable + "\CATAUX", OpenMode.Random,,, Len(CATAUX))
		largoDelRandom = LOF(2) \ Len(CATAUX)


		grillaDat.ColumnCount = 12

		For i As Integer = 1 To largoDelRandom
			FileGet(3, CATAUX, i)
			grillaDat.Rows.Add(CATAUX.C1, CATAUX.C2, CATAUX.C3, CATAUX.C4, CATAUX.C5)
		Next i

		grillaDat.Focus()
		FileClose(2)

	End Sub

	Public Sub imprimirMayor(grillaDat As DataGridView)
		Dim largoDelRandom As Integer
		Dim rutaDelEjecutable As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location)

		FileOpen(3, rutaDelEjecutable + "\CATMAY", OpenMode.Random,,, Len(CATMAY))
		largoDelRandom = LOF(3) \ Len(CATMAY)


		grillaDat.ColumnCount = 12

		For i As Integer = 1 To largoDelRandom
			FileGet(3, CATMAY, i)
			grillaDat.Rows.Add(CATMAY.B1, CATMAY.B2, CATMAY.B3, CATMAY.B4, CATMAY.B5)
		Next i

		grillaDat.Focus()
		FileClose(3)

	End Sub

	Public Sub ImprimirCtasBanco(grillaDat As DataGridView)

		Dim largoDelRandom As Integer
		Dim rutaDelEjecutable As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location)

		FileOpen(4, rutaDelEjecutable + "\Bnxcla.dno", OpenMode.Random,,, Len(cuentasDeBanco))
		largoDelRandom = LOF(4) \ Len(cuentasDeBanco)

		FileOpen(5, rutaDelEjecutable + "\personal.dno", OpenMode.Random,,, Len(personal))
		largoDelRandom = LOF(5) \ Len(personal)

		FileOpen(6, rutaDelEjecutable + "\PerOtre.dno", OpenMode.Random,,, Len(otrosCampos))
		largoDelRandom = LOF(6) \ Len(otrosCampos)

		grillaDat.ColumnCount = 12

		For i As Integer = 1 To largoDelRandom
			FileGet(4, cuentasDeBanco, i)
			FileGet(5, personal, i)
			FileGet(6, otrosCampos, i)

			'If personal.fab = "" Then ' Verificar si no hay fecha de baja
			grillaDat.Rows.Add(i, personal.nom & personal.ape1 & personal.ape2, personal.RFC, otrosCampos.CURP, personal.imss, personal.fal, personal.fab, personal.ingr / 10000, personal.viat, personal.otras, personal.integrado / 10000, cuentasDeBanco.Q1)
			'End If
		Next i

		grillaDat.Focus()
		FileClose(4)
		FileClose(5)
		FileClose(6)

	End Sub

	Public Sub imprimirOtrasCh(grillaDat As DataGridView)
		Dim largoDelRandom As Integer
		Dim rutaDelEjecutable As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location)

		FileOpen(5, rutaDelEjecutable + "\PerOtre", OpenMode.Random,,, Len(otrosCampos))
		largoDelRandom = LOF(5) \ Len(otrosCampos)


		grillaDat.ColumnCount = 4

		For i As Integer = 1 To largoDelRandom
			FileGet(5, otrosCampos, i)
			grillaDat.Rows.Add(otrosCampos.CURP, otrosCampos.otra, otrosCampos.yporsi, otrosCampos.yotra)
		Next i

		grillaDat.Focus()
		FileClose(5)

	End Sub


End Module
