@echo off
powershell -Command "New-Item result_foo.txt -Value 'Hi there!' -Force"
exit /b %ErrorLevel%