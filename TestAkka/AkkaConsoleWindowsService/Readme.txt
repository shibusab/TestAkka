1) Install-Package Akka
2) Install-Package Topshelf -Version 3.3.1


Run Command Prompt as an Administrator and navigate to the folder of Console Application.
> WindowsServiceWithTopshelf.exe install

To uninstall windows service run this command.
> WindowsServiceWithTopshelf.exe uninstall 


Bad
"C:\Windows\Microsoft.NET\Framework\v4.0.30319\installutil.exe" TestAkka.exe
"C:\Windows\Microsoft.NET\Framework\v4.0.30319\installutil.exe" -u TestAkka.exe

https://www.c-sharpcorner.com/article/creating-windows-service-in-net-with-topshelf/
https://github.com/Horusiath/Akka.Persistence.Reminders
https://github.com/EdwinVW/akka.net-warehouse-sample

https://www.c-sharpcorner.com/UploadFile/b1df45/Asp-Net-web-api-self-hosting/