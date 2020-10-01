@echo off
powershell -Command "New-Item result_bar.txt -Value 'Hello there!' -Force"
exit /b %ErrorLevel%