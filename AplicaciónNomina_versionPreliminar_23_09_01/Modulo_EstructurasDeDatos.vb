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
		<VBFixedString(5), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=5)> Public ultimaOperacionReg As String
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
	Structure fol_io
		<VBFixedString(36), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=36)> Public fol As String
	End Structure
	Structure nominaQuincenal
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
	Structure nuevaNominaCompleta
		<VBFixedString(50), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=50)> Public ArchImp As String
		Public PSubDi As Long
		Public subapl As Long
		Public subNap As Long
		Public Cretot As Long
		Public CredNe As Long
		Public ImpTOt As Long
	End Structure

	Structure nominaAnterior
		Public inggrav As Long
		Public imptoret As Long
		Public credcal As Long
		Public subapl As Long
		Public subtotal As Long
		Public subnoapl As Long
	End Structure

	Structure ob
		Public O_1 As Integer
		Public por_1 As Integer
		Public im_1 As Long
		Public O_2 As Integer
		Public por_2 As Integer
		Public im_2 As Long
		Public O_3 As Integer
		Public por_3 As Integer
		Public im_3 As Long
		Public O_4 As Integer
		Public por_4 As Integer
		Public im_4 As Long
		Public O_5 As Integer
		Public por_5 As Integer
		Public im_5 As Long
		Public O_6 As Integer
		Public por_6 As Integer
		Public im_6 As Long
		Public O_7 As Integer
		Public por_7 As Integer
		Public im_7 As Long
		Public O_8 As Integer
		Public por_8 As Integer
		Public im_8 As Long
		Public O_9 As Long
		Public por_9 As Integer
		Public im_9 As Long
		Public O_10 As Integer
		Public por_10 As Integer
		Public im_10 As Long
		Public O_11 As Integer
		Public por_11 As Integer
		Public im_11 As Long
		Public O_12 As Integer
		Public por_12 As Integer
		Public im_12 As Long
		Public O_13 As Integer
		Public por_13 As Integer
		Public im_13 As Long
		Public O_14 As Integer
		Public por_14 As Integer
		Public im_14 As Long
		Public O_15 As Integer
		Public por_15 As Integer
		Public im_15 As Long
		Public O_16 As Integer
		Public por_16 As Integer
		Public im_16 As Long
		Public O_17 As Integer
		Public por_17 As Integer
		Public im_17 As Long
		Public O_18 As Integer
		Public por_18 As Integer
		Public im_18 As Long
		Public O_19 As Integer
		Public por_19 As Integer
		Public im_19 As Long
		Public O_20 As Integer
		Public por_20 As Integer
		Public im_20 As Long
	End Structure
	Structure cheques
		Public num As Integer
		Public beneficiario As String
		Public importe As Long
		Public clave As String
		Public numreal As Integer
		Public refer As Integer
		Public conta As Integer
	End Structure
	Structure Mvtos
		Public Inc As Long
		Public Ene As Long
		Public Feb As Long
		Public Mar As Long
		Public Abr As Long
		Public May As Long
		Public Jun As Long
		Public Jul As Long
		Public Ago As Long
		Public Sep As Long
		Public Oct As Long
		Public Nov As Long
		Public Dic As Long
	End Structure

	Structure ultitmaOperacion
		Public numeroOperacion As Long
		Public ubicacionOperacion As Integer
		Public renglonOperacion As Long
		Public textoOperacion As String
		Public poliza As Integer
		Public impresionOperacion As Integer
		Public tipoOperacion As Integer
		Public redaccionOperacion As String
	End Structure
	Structure fis_cal
		<VBFixedString(36), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=36)> Public folio As String
		Public estado As Boolean

	End Structure
	Structure ContCat
		<VBFixedString(5), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=5)> Public g1 As String
		<VBFixedString(5), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=5)> Public g2 As String
		<VBFixedString(6), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=6)> Public g3 As String
	End Structure
	Structure ult
		Public num As Long
		Public Ubi As Integer
		Public renglon As Long
		Public texto As String
		Public poliza As Integer
		Public Impresion As Integer
		Public TipoCap As Integer
		Public redaccion As String
	End Structure

	Structure tra_cta
		Public num As Integer
		<VBFixedString(32), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=32)> Public nombre As String
		Public donde As Integer
		Public incia As Integer
		Public termina As Integer
		<VBFixedString(1), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=1)> Public clave As String
	End Structure

	Structure tra_Scta
		Public num As Integer
		<VBFixedString(32), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=32)> Public nombre As String
		Public donde As Integer
		Public refer As Integer
		<VBFixedString(1), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=1)> Public clave As String
	End Structure

	Structure sc
		<VBFixedString(64), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=64)> Public guarda As String
	End Structure

	Structure Al
		Public Cos As Integer
		Public Rda As String
		Public Imt As Long
		Public Gto As Integer
		Public Dep As Integer
		Public Clt As Integer
		Public Otr As Integer
	End Structure
	Structure Su
		Public Parcial As Long
		Public Debe As Long
		Public Haber As Long
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
	Structure nomco
		<VBFixedString(50), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=50)> Public ArchImp As String
		Public PSubDi As Long
		Public subdio As Long
		Public subapl As Long
		Public subNap As Long
		Public CreTot As Long
		Public CredNe As Long
		Public ImpTot As Long
	End Structure

	Structure empresa
		<VBFixedString(60), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=60)> Public name As String
		Public añoEmpresa As Integer
		Public sm As Long
		Public psub As Long
		<VBFixedString(14), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=14)> Public fecha As String
	End Structure

	REM DECLARACION DE VARIABLES DE TIPO ESTRUCTURAS
	Public archivoNominaQuincenal As nominaQuincenal
	Public CATAUX As CAT_AX
	Public CATMAY As CAT_MA
	Public Ctos As ope
	Public cuentas As Ct
	Public cuentasDeBanco As Clabnx
	Public DATOS As DAT_OS
	Public datosEmpresa As empresa
	Public maestro As ob
	Public nominaCompleta As nuevaNominaCompleta
	Public OPER As oper_aciones
	Public otros As otr
	Public otrosCampos As OtrasCh
	Public personal As per
	Public renglon As Rg
	Public ultimaOperacion As ultitmaOperacion
	Public fiscal As fis_cal
	Public Alarma As Al
	Public Su_ma As Su, Ruta_Acceso, Ruta_Acceso_Contr, Arch_Oper As String
	Public Dir_Costos As String
	Public MvDebe As Mvtos, MvHaber As Mvtos, Sub_dir As String
	Public MvDebeS As Mvtos, MvHaberS As Mvtos
	Public ContrCatal As ContCat, Arc_FinaL As Integer
	Public CONS_ULTA As Integer, final As Integer
	Public ultimo As ult, ultimo1 As ult, BALANZON As Integer
	Public trcta As tra_cta
	Public trscta As tra_Scta
	Public cheque As cheques
	Public folio As fol_io
	Public Rango_Inic As Long, Rango_Final As Long
	Public Arch_act, z1 As String
	Public z2 As String, valcelant, fin_oper As Long, Mes_Act As Integer, month As String, anio As String
	Public cm As Integer, Dm As Integer, EM As Integer, qm As Integer, Mes As Integer
	Public MesCheque(15) As String, dd(15) As Integer, mespoliza As Integer, dia As Integer
	Public dir1 As String
	Public archivos1() As String
	Public archivos1Pdf() As String
	Public rutArchi
	Public rutArchi1
	Public rutArchi2
	Public routes(100) As String
	Public routesPdf(100) As String
	Public change As Boolean
	Public polizaiden As String
	Public nombreArchivo As String
	Public validateXMLArchives As String
	Public validatePdfArchives As String
	<VBFixedString(64), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=64)> Public SCont As sc


	REM Ubicacion del ejecutable 
	Public rutaDelEjecutable As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location)

	REM largos de los random
	Public largoDeBancos As Integer
	Public largoPersonal As Integer
	Public largoOtrosCammpos As Integer
	Public largoCatalogoAuxiliar As Integer
	Public largoCatalogoMayor As Integer
	Public largoMaestro As Integer
	Public largoNominaQuincenal As Integer
	Public largoNominaCompleta As Integer
	Public largoGconta As Integer
	Public largoEmpresa As Integer
	Public largoDatos As Integer

	REM numeros asigando a los random
	Public numeroMayor As Integer = 1
	Public numeroAuxiliar As Integer = 2
	Public numeroPersonal As Integer = 3
	Public numeroBancos As Integer = 4
	Public numeroOtros As Integer = 5
	Public numeroMaestro As Integer = 6
	Public numeroNominaQuincenal As Integer = 7
	Public numeronominaCompleta As Integer = 8
	Public numeroGConta As Integer = 9
	Public numeroEmprsa As Integer = 10
	Public numeroDatos As Integer = 11

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

		FileOpen(numeroMaestro, rutaDelEjecutable + "\maestro.dno", OpenMode.Random,,, Len(maestro))
		largoMaestro = LOF(numeroMaestro) \ Len(maestro)

		FileOpen(numeroEmprsa, rutaDelEjecutable + "\EMPRESA.dno", OpenMode.Random,,, Len(datosEmpresa))
		largoEmpresa = LOF(numeroEmprsa) \ Len(datosEmpresa)

		FileOpen(numeroGConta, "C:\GconTA\Gcont.Arr", OpenMode.Random,,, Len(SCont))
		largoGconta = LOF(numeroGConta) \ Len(SCont)

		FileOpen(numeroDatos, rutaDelEjecutable + "\DATOS", OpenMode.Random,,, Len(DATOS))
		largoDatos = LOF(numeroDatos) \ Len(DATOS)

	End Sub

	Public Sub imprimirEmpleados(grillaDat As DataGridView, largoDelRandom As Integer)

		' Establece la cantidad de columnas que la grid necesita
		grillaDat.ColumnCount = 12

		' For que recorre los random e imprime los datos en la grid
		For i As Integer = 1 To largoDelRandom
			FileGet(numeroBancos, cuentasDeBanco, i)
			FileGet(numeroPersonal, personal, i)
			FileGet(numeroOtros, otrosCampos, i)

			' Agrega la fila a la grid
			grillaDat.Rows.Add(i, personal.nom.Trim() & " " & personal.ape1.Trim() & " " & personal.ape2.Trim(), personal.RFC, otrosCampos.CURP, personal.imss, personal.fal, personal.fab, personal.ingr / 10000, personal.viat, personal.otras, personal.integrado / 10000, cuentasDeBanco.Q1)

		Next i

		' Establece el foco en la grid
		grillaDat.Focus()

	End Sub


	Public Sub imprimirPersonal(grillaDat As DataGridView, largoDelRandom As Integer)

		grillaDat.ColumnCount = 12

		For i As Integer = 1 To largoDelRandom
			FileGet(numeroPersonal, personal, i)
			grillaDat.Rows.Add(personal.nom, personal.ape1, personal.ape2, personal.RFC, personal.imss, personal.fal, personal.fab, personal.ingr / 10000, personal.viat, personal.otras, personal.integrado)
		Next i

		grillaDat.Focus()

	End Sub

	Public Sub imprimirAuxiliar(grillaDat As DataGridView, largoDelRandom As Integer)

		grillaDat.ColumnCount = 5

		For i As Integer = 1 To largoDelRandom
			FileGet(numeroAuxiliar, CATAUX, i)
			grillaDat.Rows.Add(CATAUX.C1, CATAUX.C2, CATAUX.C3, CATAUX.C4, CATAUX.C5)
		Next i

		grillaDat.Focus()

	End Sub

	Public Sub imprimirMayor(grillaDat As DataGridView, largoDelRandom As Integer)

		grillaDat.ColumnCount = 5

		For i As Integer = 1 To largoDelRandom
			'abrirRandomNominaCaptura()
			FileGet(numeroMayor, CATMAY, i)
			grillaDat.Rows.Add(CATMAY.B1, CATMAY.B2, CATMAY.B3, CATMAY.B4, CATMAY.B5)
		Next i

		grillaDat.Focus()

	End Sub


	Public Sub imprimirOtrasCh(grillaDat As DataGridView, largoDelRandom As Integer)

		grillaDat.ColumnCount = 4

		For i As Integer = 1 To largoDelRandom
			FileGet(numeroOtros, otrosCampos, i)
			grillaDat.Rows.Add(otrosCampos.CURP, otrosCampos.otra, otrosCampos.yporsi, otrosCampos.yotra)
		Next i

		grillaDat.Focus()

	End Sub

End Module
