@echo off
REM '*******************************************************************************
REM '*VERSION:2.0                                                                  *
REM '*CREADO POR: SERGIO CHANCAY                                                   *
REM '*FECHA: 30/01/2014                                                            *
REM '*******************************************************************************

REM RUTA DEL PUBLICADO
set SOLUTION_ADMIN_VB="..\Solution\COBISCorp.tCOBIS.BVI.sln"
set SOLUTION_ADMIN_VB_UTIL="..\Solution\COBISCorp.tCOBIS.Utils\COBISCorp.tCOBIS.Utils.sln"

REM *******************************************************************************
REM SELECCION DEL COMPILADOR VS
REM *******************************************************************************
if %PROCESSOR_ARCHITECTURE%==X86 goto x86_Verify
if %PROCESSOR_ARCHITECTURE%==AMD64 goto x64_Verify

:x86_Verify
    SET DEV_VS_EXECUTABLE="%PROGRAMFILES%\Microsoft Visual Studio 10.0\Common7\IDE\devenv"

:x64_Verify
    SET DEV_VS_EXECUTABLE="%PROGRAMFILES%\Microsoft Visual Studio 10.0\Common7\IDE\devenv"
REM *******************************************************************************

echo *******************************************************************************
echo LIMPIEZA Y COMPILACION DE LOS PROYECTOS UTILITARIOS DEL ADMINISTRADOR
echo *******************************************************************************

%DEV_VS_EXECUTABLE% %SOLUTION_ADMIN_VB_UTIL% /rebuild 
if errorlevel 1 goto BuildFailed
if errorlevel 0 goto COMPILADO_PROYECTO_ADMINISTRADOR

:COMPILADO_PROYECTO_ADMINISTRADOR
cls
echo *******************************************************************************
echo LIMPIEZA Y COMPILACION DE LOS PROYECTOS DEL ADMINISTRADOR
echo *******************************************************************************
rem %DEV_VS_EXECUTABLE% %SOLUTION_ADMIN_VB% /rebuild 
rem if errorlevel 1 goto BuildFailed
goto UPDATING_REFERENCES_PUBLISH


:UPDATING_REFERENCES_PUBLISH
CD /D %source_path%
echo *******************************************************************************
REM ACTULIZACION DE DLL DE TODOS LOS PROYECTOS
echo *******************************************************************************
echo COPIANDO CLICONCE Clients
echo *******************************************************************************
set var_path="COBISCorp.tCOBIS.BVI.Client.Installer\BVI"
xcopy "C:\COBIS\COBISExplorer\AdminBV\COBISCorp.tCOBIS.BVI.Clients.dll" "%var_path%" /Y/A/I
xcopy "C:\COBIS\COBISExplorer\AdminBV\cobcrypt.dll" "%var_path%" /Y/A/I

echo *******************************************************************************
echo COPIANDO CLICONCE GeneralInfo
echo *******************************************************************************
set var_path="COBISCorp.tCOBIS.BVI.GeneralInfo.Installer\BVI"
xcopy "C:\COBIS\COBISExplorer\AdminBV\COBISCorp.tCOBIS.BVI.GeneralInfo.dll" "%var_path%" /Y/A/I

echo *******************************************************************************
echo COPIANDO CLICONCE InternetBanking
echo *******************************************************************************
set var_path="COBISCorp.tCOBIS.BVI.InternetBanking.Installer\BVI"
xcopy "C:\COBIS\COBISExplorer\AdminBV\COBISCorp.tCOBIS.BVI.InternetBanking.dll" "%var_path%" /Y/A/I

echo *******************************************************************************
echo COPIANDO CLICONCE Kiosco
echo *******************************************************************************
set var_path="COBISCorp.tCOBIS.BVI.Kiosco.Installer\BVI"
xcopy "C:\COBIS\COBISExplorer\AdminBV\COBISCorp.tCOBIS.BVI.Kiosco.dll" "%var_path%" /Y/A/I

echo *******************************************************************************
echo COPIANDO CLICONCE Management
echo *******************************************************************************
set var_path="COBISCorp.tCOBIS.BVI.Management.Installer\BVI"
xcopy "C:\COBIS\COBISExplorer\AdminBV\COBISCorp.tCOBIS.BVI.Management.dll" "%var_path%" /Y/A/I

echo *******************************************************************************
echo COPIANDO CLICONCE MassivePayments
echo *******************************************************************************
set var_path="COBISCorp.tCOBIS.BVI.MassivePayments.Installer\BVI"
xcopy "C:\COBIS\COBISExplorer\AdminBV\COBISCorp.tCOBIS.BVI.MassivePayments.dll" "%var_path%" /Y/A/I

echo *******************************************************************************
echo COPIANDO CLICONCE Query
echo *******************************************************************************
set var_path="COBISCorp.tCOBIS.BVI.Query.Installer\BVI"
xcopy "C:\COBIS\COBISExplorer\AdminBV\COBISCorp.tCOBIS.BVI.Query.dll" "%var_path%" /Y/A/I

echo *******************************************************************************
echo COPIANDO CLICONCE SharedLibrary
echo *******************************************************************************
set var_path="COBISCorp.tCOBIS.BVI.SharedLibrary.Installer\BVI"
xcopy "C:\COBIS\COBISExplorer\AdminBV\COBISCorp.tCOBIS.BVI.SharedLibrary.dll" "%var_path%" /Y/A/I

echo *******************************************************************************
echo COPIANDO CLICONCE Resources
echo *******************************************************************************
set var_path="COBISCorp.tCOBIS.BVI.Resources.Installer\BVI"
xcopy "C:\COBIS\COBISExplorer\AdminBV\COBISCorp.tCOBIS.BVI.Resources.dll" "%var_path%" /Y/A/I
xcopy "C:\COBIS\COBISExplorer\AdminBV\Resources\logo.bmp" "%var_path%" /Y/A/I
xcopy "C:\COBIS\COBISExplorer\AdminBV\Resources\APERTURA.mdb" "%var_path%" /Y/A/I
xcopy "C:\COBIS\COBISExplorer\AdminBV\Resources\ANXNCT.rpt" "%var_path%" /Y/A/I
xcopy "C:\COBIS\COBISExplorer\AdminBV\Resources\AXICNT.rpt" "%var_path%" /Y/A/I
xcopy "C:\COBIS\COBISExplorer\AdminBV\Resources\instrucciones_canal1.txt" "%var_path%" /Y/A/I
xcopy "C:\COBIS\COBISExplorer\AdminBV\Resources\instrucciones_canal2.txt" "%var_path%" /Y/A/I
xcopy "C:\COBIS\COBISExplorer\AdminBV\Resources\instrucciones_canal6.txt" "%var_path%" /Y/A/I
xcopy "C:\COBIS\COBISExplorer\AdminBV\Resources\login.txt" "%var_path%" /Y/A/I

echo *******************************************************************************
echo COPIANDO CLICONCE COBISCorp.tCOBIS.Utils.GroupEconomic.Installer
echo *******************************************************************************
set var_path="COBISCorp.tCOBIS.Utils.EconomicGroupSearch.Installer\BVI"
xcopy "C:\COBIS\COBISExplorer\AdminBV\COBISCorp.tCOBIS.Utils.EconomicGroupSearch.dll" "%var_path%" /Y/A/I

echo *******************************************************************************
echo COPIANDO CLICONCE COBISCorp.tCOBIS.Utils.KeyGenerator.Installer
echo *******************************************************************************
set var_path="COBISCorp.tCOBIS.Utils.KeyGenerator.Installer\BVI"
xcopy "C:\COBIS\COBISExplorer\AdminBV\COBISCorp.tCOBIS.Utils.KeyGenerator.dll" "%var_path%" /Y/A/I

echo *******************************************************************************
echo COPIANDO CLICONCE COBISCorp.tCOBIS.Utils.Official.Installer
echo *******************************************************************************
set var_path="COBISCorp.tCOBIS.Utils.Official.Installer\BVI"
xcopy "C:\COBIS\COBISExplorer\AdminBV\COBISCorp.tCOBIS.Utils.OfficialSearch.dll" "%var_path%" /Y/A/I

echo *******************************************************************************
echo COPIANDO CLICONCE COBISCorp.tCOBIS.Utils.PrintLogin.Installer
echo *******************************************************************************
set var_path="COBISCorp.tCOBIS.Utils.PrintLogin.Installer\BVI"
xcopy "C:\COBIS\COBISExplorer\AdminBV\COBISCorp.tCOBIS.Utils.PrintLogin.dll" "%var_path%" /Y/A/I

echo *******************************************************************************
echo COPIANDO CLICONCE COBISCorp.tCOBIS.Utils.ProductSearch.Installer
echo *******************************************************************************
set var_path="COBISCorp.tCOBIS.Utils.ProductSearch.Installer\BVI"
xcopy "C:\COBIS\COBISExplorer\AdminBV\COBISCorp.tCOBIS.Utils.ProductSearch.dll" "%var_path%" /Y/A/I

echo *******************************************************************************
echo CLEAR AND CREATE FOLDER BUILD
echo *******************************************************************************
@echo on

REM LIMPIEZA DEL DIRECTORIO DE SALIDA PARAMETRO DE ENTRADA EL PATH OUT DE LOS CLICK ONCE
rmdir %1 /s /q
rmdir "../logs" /s /q
REM CARPETA DE LOGS
mkdir "../logs"

goto GENERATE_CO

:BuildFailed
echo ********* SE HAN ENCONTRADO ERRORES EN LA COMPILACION DE LOS PROYECTOS!! *********
EXIT /B 1
@echo
echo *******************************************************************************


:GENERATE_CO
EXIT /B 0