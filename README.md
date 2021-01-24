docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=yourpassword' -e 'MSSQL_PID=Express' -p 1445:1433 --name=productdb microsoft/mssql-server-linux
