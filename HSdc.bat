REM Made by Arumba07
REM This script is intended to be used with Windows 10.
REM Instructions for use:
REM Step 1) Open Windows Defender Firewall
REM Step 2) Open Advanced Settings
REM Step 3) Goto "Outbound Rules"
REM Step 4) Click "New Rule"
REM Step 5) Click "Custom" and then "Next".
REM Step 6) Change the Program Path to "C:\Program Files (x86)\Hearthstone\Hearthstone.exe" and click "Next".
REM Step 7) Click Next on "Protocol and Ports", "Scope", "Action", "Profile".
REM Step 8) Name the exception "HearthstoneReconnect"
REM Step 9) This script is now set up to automatically toggle the newly created exception using an elevated command line.  Run the script (double click from desktop) to automatically toggle the exception for one second.  

set "params=%*"
cd /d "%~dp0" && ( if exist "%temp%\getadmin.vbs" del "%temp%\getadmin.vbs" ) && fsutil dirty query %systemdrive% 1>nul 2>nul || (  echo Set UAC = CreateObject^("Shell.Application"^) : UAC.ShellExecute "cmd.exe", "/k cd ""%~sdp0"" && %~s0 %params%", "", "runas", 1 >> "%temp%\getadmin.vbs" && "%temp%\getadmin.vbs" && exit /B )

netsh advfirewall firewall set rule name="HearthstoneReconnect" new enable=yes
timeout /t 5
netsh advfirewall firewall set rule name="HearthstoneReconnect" new enable=no