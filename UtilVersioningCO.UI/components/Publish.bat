@echo off
REM '*******************************************************************************
REM '*VERSION:2.0                                                                  *
REM '*CREADO POR: SERGIO CHANCAY                                                   *
REM '*FECHA: 30/01/2014                                                            *
REM '*******************************************************************************

GENERACION_CLICK_ONCE.vbs "%1" "%2" "%3" "%4"
IF ERRORLEVEL 0 SET /a ERRORLEV=0
IF ERRORLEVEL 1 SET /a ERRORLEV=1
IF ERRORLEVEL 2 SET /a ERRORLEV=2

if %ERRORLEV% EQU 0 (
    CLS
    EXIT /B 0
)
if %ERRORLEV% EQU 1 (
    CLS
    echo *******************************************************************************
    echo :: SE HAN ENCONTRADO ERRORES SE DETUVO LA GENERACION DE PLUBICACION ::
    echo *******************************************************************************
    EXIT /B 1
)
if %ERRORLEV% EQU 2 (
    CLS
    echo *******************************************************************************
    echo :: SE HAN ENCONTRADO ERRORES SE DETUVO LA GENERACION DE PLUBICACION ::
    echo *******************************************************************************
    EXIT /B 1
)