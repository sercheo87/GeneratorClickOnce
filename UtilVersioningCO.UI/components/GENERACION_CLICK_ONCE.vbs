'*******************************************************************************
'*VERSION:2.0                                                                  *
'*CREADO POR: SERGIO CHANCAY                                                   *
'*FECHA: 30/01/2014                                                            *
'*******************************************************************************
'*DESCRIPCION:                                                                 *
'*               SCRIPT PARA LA GENERACION AUTOMATICA DE CLICK ONCE INDICANDO  *
'*               EL FOLDER DONDE SE ENCUENTRAN LOS FUENTES Y EL PATH DE DESTINO*
'*INFORMACION REQUERIDA:                                                       *
'*                       * PATH DE LA SOLUCION                                 *
'*                       * PATH DE DESTINO                                     *
'*FUNCIONES AUTOMATICAS:                                                       *
'*                       * AUMENTO DE LA VERSION DEL CLICK ONCE 1.0.0.(*)      *
'*                       * COPIA ACUMULATIVA DE LAS PUBLICACIONES GENERADAS EN *
'*                         EL PATH DE DESTINO                                  *
'*                       * BUSQUEDA RECURSIVA DE TODOS LOS PROJECTOS DESDE EL  *
'*                         PATH ESPECIFICADO                                   *
'*******************************************************************************
Option explicit
 Dim fso, f, fc, PROJECT_SOLUTION, f1, listPROJECT_SOLUTION, fitxerpersonal
 Dim objFile,i,objParametros,PATH_DESTINATION, VERSION, VERSION_REVISION'VARIABLES GENERALES
 Dim PROJECT_ERROR

 Set objParametros = WScript.Arguments
 If (objParametros.Count>0)Then
    PROJECT_SOLUTION=Trim(objParametros.Item(0)) REM D:\TEST_CO_2\ClickOnce\COBISCorp.tCOBIS.BVI.Clients.Installer\COBISCorp.tCOBIS.BVI.Clients.Installer.csproj
    PATH_DESTINATION=Trim(objParametros.Item(1)) REM D:\TEST_CO_2\build
    VERSION=Trim(objParametros.Item(2))          REM 1.0.0.%2a
    VERSION_REVISION=Trim(objParametros.Item(3)) REM 100
 Else
     PROJECT_SOLUTION=inputbox("Carpeta donde se aloja los fuentes del proyecto..." + vbCrlf +"Ejm: C:\PROYECTOS\SOLUTION")
     PATH_DESTINATION=inputbox("Carpeta a donde deseas publicar los fuentes" + vbCrlf +"Ejm: C:\PROYECTOS\CLICK_ONCE")
 End If

 If (PROJECT_SOLUTION = "" )then
     MsgBox ("No ha ingresado path de la solucion de los projectos")
     WScript.Quit
 End If

  If (PATH_DESTINATION = "" )then
     MsgBox ("No ha ingresado path de destino")
     WScript.Quit
 End If

 If(mid(PROJECT_SOLUTION,len(PROJECT_SOLUTION),1)="\") Then
    PROJECT_SOLUTION=mid(PROJECT_SOLUTION,1,len(PROJECT_SOLUTION)-1)
 End If

  If(mid(PATH_DESTINATION,len(PATH_DESTINATION),1)="\") Then
    PATH_DESTINATION=mid(PATH_DESTINATION,1,len(PATH_DESTINATION)-1)
 End If


 Set fso = CreateObject("Scripting.FileSystemObject")
 If (Not(fso.FileExists(PROJECT_SOLUTION)))then
     MsgBox ("No existe Archivo especificada...." + vbCrlf + "PATH INGRESADO ["+PROJECT_SOLUTION+"]")
     WScript.Quit
 End If

  If (Not(fso.FolderExists(PATH_DESTINATION)))then
        fso.CreateFolder(PATH_DESTINATION)
 End If
 Fitxer 'INICIO DE PROCESO

REM *****************************************************************************
REM PRECESOS DE EJECUCION
REM *****************************************************************************
Sub Fitxer()

    Set fso = CreateObject("Scripting.FileSystemObject")

    REM recursive_Fitxer(f) 'INICIA BUSQUEDA

    Set fitxerpersonal=fso.CreateTextFile("../logs/Bitacora_Generacion.txt", True) 'ARCHIVO DE LOG

    fitxerpersonal.WriteLine ("PROJECT "+PROJECT_SOLUTION+vbCrLf)

    If(PROJECT_SOLUTION<>"") Then
        fitxerpersonal.WriteLine ("FILE:"+PROJECT_SOLUTION)

        UPDATE_VERSION(PROJECT_SOLUTION)
        PROJECT_ERROR=(GENERATE_PUBLISH(PROJECT_SOLUTION))

        If (PROJECT_ERROR=1)Then
            MsgBox("SE HA ENCONTRADO ERRORES EN LA PUBLICACION DE PROYECTOS")
             WScript.Quit(1)
        End If
        COPY_PUBLISHED(fso.GetParentFolderName(PROJECT_SOLUTION))
    End If


    fitxerpersonal.close
    'LLAMADAS SHELL
    REM Dim objShell
    REM Set objShell = CreateObject("WScript.Shell")
    REM objShell.Run("notepad " & "lista.txt")
    'MsgBox "Dejo guardado tu fichero en: "  & PROJECT_SOLUTION & "\lista.txt"
    WScript.Quit 0
End sub

REM *****************************************************************************
REM INCREMENTO DE LA REVISION DE APLICACION DEL CLICONCE
REM *****************************************************************************
Function UPDATE_VERSION(oFile)
    dim msxml,node
    fitxerpersonal.WriteLine(vbTab+">>>>ACTUALIZANDO REGISTRO DE VERSION")

    Set msxml = CreateObject("MSXML.DOMDocument")' load the .csproj.user file
    msxml.async = False
    msxml.load(oFile)

    ' retrieve the current revision and increment
    Set node = msxml.selectSingleNode("/Project/PropertyGroup/ApplicationRevision")
    node.Text = VERSION_REVISION

    Set node = msxml.selectSingleNode("/Project/PropertyGroup/ApplicationVersion")
    node.Text =VERSION
    
    msxml.save oFile' save the changes
    fitxerpersonal.WriteLine(vbTab+">>>>PROYECTO ACTUALIZADO A LA VERSION..."+CStr(node.Text))
End Function

REM *****************************************************************************
REM PUBLICACION DEL CLICONCE
REM *****************************************************************************
Function GENERATE_PUBLISH(oFile)
    dim WshShell,WshSysEnv,PATH_EXEC,RESPONSE,objFSO
    Set WshShell = WScript.CreateObject("WScript.Shell")
    Set WshSysEnv = WshShell.Environment("Process")
    Set objFSO = CreateObject("Scripting.FileSystemObject")
    Set objFile = objFSO.GetFile(oFile)
    
    fitxerpersonal.WriteLine(vbTab+vbTab+">>>>PUBLICANDO PROYECTO ESPERE.....")
    PATH_EXEC=WshSysEnv("WINPROJECT_SOLUTION")+"C:\Windows\Microsoft.net\Framework\v4.0.30319\msbuild.exe "+ oFile +" /l:FileLogger,Microsoft.Build.Engine;logfile=..\logs\"+ objFSO.GetBaseName(objFile)+".log /t:Clean;Rebuild;Publish /property:BootstrapperEnabled=false /property:PublishVersion='$(Proj.AssemblyVersion)'"

    RESPONSE=WshShell.Run (PATH_EXEC,1, true)

    if (RESPONSE <> 0 OR err.number <> 0) then
        RESPONSE=1
        fitxerpersonal.WriteLine(vbTab+vbTab+":::::: ERROR PUBLICACION :::::::")
    Else
        fitxerpersonal.WriteLine ("----------------------------------------------------------")
        fitxerpersonal.WriteLine (PATH_EXEC)
        fitxerpersonal.WriteLine ("----------------------------------------------------------")
        fitxerpersonal.WriteLine(vbTab+vbTab+">>>>PUBLICACION TERMINADA")
    End If

    GENERATE_PUBLISH=RESPONSE
    Set objFSO = Nothing
    Set WshShell = Nothing
    Set WshSysEnv =Nothing
End Function


REM *****************************************************************************
REM COPIAR AL PUBLICADO
REM *****************************************************************************
Function COPY_PUBLISHED(sParentFolder)
    Dim objFSO,f,fc,nameProyect,nameDestinationCopy,nameDestinationFile
    Set objFSO = CreateObject("Scripting.FileSystemObject")
    fitxerpersonal.WriteLine(vbTab+vbTab+">>>>COPIANDO ARCHIVOS DE ["+sParentFolder+"\bin\Debug\app.publish\*.*"+"] A ["+PATH_DESTINATION+"] ESPERE.....")
    fitxerpersonal.WriteLine(vbTab+vbTab+">>>>LISTANDO CARPETA..."+sParentFolder+"\bin\Debug\app.publish\")

    'OBTENIENDO FOLDER DE PROYECTO
    If (fso.FolderExists(sParentFolder+"\bin\Debug\app.publish")) Then
        Set f = objFSO.GetFolder(sParentFolder+"\bin\Debug\app.publish")
        Set fc = f.Files

        For Each f1 in fc
            If LCase(objFSO.GetExtensionName(f1.Path)) = "application" Then
                nameProyect=objFSO.GetFileName(f1)
                Exit For
            End If
        Next

        nameDestinationCopy=PATH_DESTINATION+"\"+nameProyect+"\"

        If Not objFSO.FolderExists(nameDestinationCopy) Then
            fitxerpersonal.WriteLine(vbTab+vbTab+">>>>CREANDO CARPETA..."+nameDestinationCopy)
            objFSO.CreateFolder(nameDestinationCopy)
        End If

        objFSO.CopyFolder sParentFolder+"\bin\Debug\app.publish\*.*", nameDestinationCopy, True

        For Each f1 in fc
            nameDestinationFile=nameDestinationCopy + "\"+f1.Name

            If objFSO.FileExists(nameDestinationFile) Then
                fitxerpersonal.WriteLine(vbTab+vbTab+vbTab+">>>>BORRANDO ARCHIVO...."+nameDestinationFile)
                objFSO.DeleteFile  nameDestinationFile
            End If

            fitxerpersonal.WriteLine(vbTab+vbTab+vbTab+">>>>COPIANDO ARCHIVO A...."+nameDestinationFile)
            objFSO.CopyFile f1.Path , nameDestinationCopy
        Next
    Else
        fitxerpersonal.WriteLine(vbTab+vbTab+">>>>ERROR: NO SE ENCONTRO CARPETA >> "+ CStr(sParentFolder)+"\bin\Debug\app.publish")
    End If

    Set objFSO =Nothing
    Set f =Nothing
    Set fc =Nothing
End Function