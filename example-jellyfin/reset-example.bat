@echo off
:: Delete contents of Folder config
del /q ".\config\*.*"
for /d %%i in (".\config\*") do rd /s /q "%%i"

:: Delete contents of Folder cache
del /q ".\cache\*.*"
for /d %%i in (".\cache\*") do rd /s /q "%%i"
