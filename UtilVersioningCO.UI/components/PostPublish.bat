@echo off
REM '*******************************************************************************
REM '*VERSION:2.0                                                                  *
REM '*CREADO POR: SERGIO CHANCAY                                                   *
REM '*FECHA: 30/01/2014                                                            *
REM '*******************************************************************************

set file_zip=%1
set apply_zip=%2

if %apply_zip% EQU  1 goto COMPRIME
if %apply_zip% EQU  0 goto FIN


:COMPRIME
DEL /F /S /Q /A %file_zip%
"..\tools\7zip\7za.exe" a -tzip %file_zip% -aoa %3\*.*
goto FIN

:FIN
REM COPIAR TODOS LOS CLIKC ONCES A LA CARPETA DE PUBLICADO
XCopy %3 X:\ /s/y

explorer %3
EXIT /B 0