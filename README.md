# PersonalFinanceAdvisor.TransactionService

### IIS Setup
- Make required changes from "Turn Windows Features On or Off"
- Install the Hosting bundle from the link
- Create an app pool with `No Managed Code` to run the app
- Cross-check runtime `dotnet --list-runtimes`
- Publish the project from Visual Studio to a specific location
- Create a new application inside the `Default Web Site` 
- Use the published folder and newly created app pool, and give a name to your app
- You are good to go

### Error with IIS Setup
- I faced some challenges related to "StaticWebAssetsEnabled" which I fixed by adding `<StaticWebAssetsEnabled>true</StaticWebAssetsEnabled>`
- My project solution was inside another folder with a kebab case naming convention, which was throwing an error, so I changed it from `personal-finance-advisor` to `PersonalFinanceAdvisor` 

