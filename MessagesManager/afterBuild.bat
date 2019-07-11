set x86Path=%2\x64
set x64Path=%2\x86

:: if not exist %x86Path% mkdir %x86Path%
:: if not exist %x64Path% mkdir %x64Path%

:copy
if defined ProgramFiles(x86) (
	C:\Windows\System32\xcopy %1Libs\x64\SQLite.Interop.dll %2 /y
    @echo 64-bit OS
) else (
    C:\Windows\System32\xcopy %1Libs\x86\SQLite.Interop.dll %2 /y
    @echo 32-bit OS
)

:: C:\Windows\System32\xcopy %1Libs\x86\SQLite.Interop.dll %x86Path% /y
:: C:\Windows\System32\xcopy %1Libs\x64\SQLite.Interop.dll %x64Path% /y

:end
echo Gotowe