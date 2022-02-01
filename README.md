# http400log
When run this Program.cs on IIS (with Launch profile "IIS Express"), then the exception is logged twice with the Category Microsoft.AspNetCore.Server.IIS.Core.IISHttpServer. First with Severity=INFO, second as ERROR.

My question is: Why it's logged as INFO?

When starting the same programm on Kestrel, (with Launch profile "WebApplication1") There it works correctly: Only 1 Log entry with Category: Microsoft.AspNetCore.Server.Kestrel and Severity=ERROR... No INFO Logentry.
