# framework-api-leads-manager

WebAPI interface de gerenciamento de leads

* Abra a solução no VS
* Compile
* Execute os migrations no projeto para gerar o banco de dados [Framework.LeadsManager.Infrastructure.Data]
  no package manager console execute
* cd Framework.LeadsManager.Infrastructure.Data
  
  em seguida execute:
* dotnet ef --startup-project ../Framework.LeadsManager.Api/ database update
  
* Execute a aplicação no iisExpress
  