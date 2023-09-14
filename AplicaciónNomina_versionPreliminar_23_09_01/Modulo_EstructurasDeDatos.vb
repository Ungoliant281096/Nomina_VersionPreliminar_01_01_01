Imports System.Globalization
Imports System.Security.Cryptography.X509Certificates

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
		<VBFixedString(255), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=255)> Public datoArch As String
	End Structure
	Structure nom
		Public dias As Long
		Public hsnor As Long
		Public hs_no As Long
		Public hsdbl As Long
		Public hs_db As Long
		Public hstri As Long
		Public hs_tr As Long
		Public ispt As Long
		Public crdsal As Long
		Public imss As Long
		Public sueldo As Long
		Public hs_nor As Long
		Public hs_dbl As Long
		Public hs_tri As Long
		Public viaticos As Long
		Public pvac As Long
		Public otras As Long
		Public aguin As Long
		Public ptu As Long
		Public exentos As Long
		Public prestamos As Long
		Public fonacot As Long
		Public telefono As Long
		Public otraded As Long
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
	Public archivoNomina As nom

	Public personal As per
	Public cuentasDeBanco As Clabnx
	Public otrosCampos As OtrasCh

	Public rutaDelEjecutable As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location)
	Public largoDeBancos As Integer
	Public largoPersonal As Integer
	Public largoOtrosCammpos As Integer
	Public largoCatalogoAuxiliar As Integer
	Public largoCatalogoMayor As Integer
	Public largoMaestro As Integer
	Public largoNomina As Integer
	Public largoNomCom As Integer

	Public numeroMayor As Integer = 1
	Public numeroAuxiliar As Integer = 2
	Public numeroPersonal As Integer = 3
	Public numeroBancos As Integer = 4
	Public numeroOtros As Integer = 5
	Public numeroNomina As Integer = 6
	Public Sub abrirRandomNominaCaptura()


		FileOpen(numeroMayor, rutaDelEjecutable + "\CATMAY", OpenMode.Random,,, Len(CATMAY))
		largoCatalogoMayor = LOF(numeroMayor) \ Len(CATMAY)

		FileOpen(numeroAuxiliar, rutaDelEjecutable + "\CATAUX", OpenMode.Random,,, Len(CATAUX))
		largoCatalogoAuxiliar = LOF(numeroAuxiliar) \ Len(CATAUX)

		FileOpen(numeroPersonal, rutaDelEjecutable + "\personal.dno", OpenMode.Random,,, Len(personal))
		largoPersonal = LOF(numeroPersonal) \ Len(personal)

		FileOpen(numeroBancos, rutaDelEjecutable + "\Bnxcla.dno", OpenMode.Random,,, Len(cuentasDeBanco))
		largoDeBancos = LOF(numeroBancos) \ Len(cuentasDeBanco)

		FileOpen(numeroOtros, rutaDelEjecutable + "\PerOtre.dno", OpenMode.Random,,, Len(otrosCampos))
		largoOtrosCammpos = LOF(numeroOtros) \ Len(otrosCampos)

		'FileOpen(numeroNomina, rutaDelEjecutable + "", OpenMode.Random,,, Len(archivoNomina))
		'largoNomina = LOF(numeroNomina) \ Len(archivoNomina)


	End Sub


	Public Sub imprimirPersonal(grillaDat As DataGridView)
		Dim largoDelRandom As Integer

		grillaDat.ColumnCount = 12

		For i As Integer = 1 To largoDelRandom
			FileGet(numeroPersonal, personal, i)
			grillaDat.Rows.Add(personal.nom, personal.ape1, personal.ape2, personal.RFC, personal.imss, personal.fal, personal.fab, personal.ingr / 10000, personal.viat, personal.otras, personal.integrado)
		Next i

		grillaDat.Focus()
		FileClose(1)

	End Sub

	Public Sub imprimirAuxiliar(grillaDat As DataGridView)
		Dim largoDelRandom As Integer

		grillaDat.ColumnCount = 12

		For i As Integer = 1 To largoDelRandom
			FileGet(numeroAuxiliar, CATAUX, i)
			grillaDat.Rows.Add(CATAUX.C1, CATAUX.C2, CATAUX.C3, CATAUX.C4, CATAUX.C5)
		Next i

		grillaDat.Focus()
		FileClose(2)

	End Sub

	Public Sub imprimirMayor(grillaDat As DataGridView)
		Dim largoDelRandom As Integer

		grillaDat.ColumnCount = 12

		For i As Integer = 1 To largoDelRandom
			FileGet(numeroMayor, CATMAY, i)
			grillaDat.Rows.Add(CATMAY.B1, CATMAY.B2, CATMAY.B3, CATMAY.B4, CATMAY.B5)
		Next i

		grillaDat.Focus()
		FileClose(3)

	End Sub

	Public Sub ImprimirCtasBanco(grillaDat As DataGridView, largoDelRandom As Integer)

		grillaDat.ColumnCount = 12

		For i As Integer = 1 To largoDelRandom
			FileGet(numeroBancos, cuentasDeBanco, i)
			FileGet(numeroPersonal, personal, i)
			FileGet(numeroOtros, otrosCampos, i)


			'If valor = 0 Then ' Verificar si no hay fecha de baja
			grillaDat.Rows.Add(i, personal.nom & personal.ape1 & personal.ape2, personal.RFC, otrosCampos.CURP, personal.imss, personal.fal, personal.fab, personal.ingr / 10000, personal.viat, personal.otras, personal.integrado / 10000, cuentasDeBanco.Q1)
			'End If
		Next i

		grillaDat.Focus()

	End Sub

	Public Sub imprimirOtrasCh(grillaDat As DataGridView)
		Dim largoDelRandom As Integer

		grillaDat.ColumnCount = 4

		For i As Integer = 1 To largoDelRandom
			FileGet(numeroOtros, otrosCampos, i)
			grillaDat.Rows.Add(otrosCampos.CURP, otrosCampos.otra, otrosCampos.yporsi, otrosCampos.yotra)
		Next i

		grillaDat.Focus()

	End Sub

End Module
