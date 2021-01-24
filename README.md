docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Spokie@500' -e 'MSSQL_PID=Express' -p 1445:1433 --name=productdb microsoft/mssql-server-linux
