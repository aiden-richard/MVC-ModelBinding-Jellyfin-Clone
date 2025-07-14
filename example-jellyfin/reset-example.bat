@echo off
:: Delete contents of Folder 1
del /q ".\config\*.*"
for /d %%i in (".\config\*") do rd /s /q "%%i"

:: Delete contents of Folder 2
del /q ".\cache\*.*"
for /d %%i in (".\cache\*") do rd /s /q "%%i"