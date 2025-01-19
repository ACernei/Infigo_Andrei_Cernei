/opt/mssql/bin/sqlservr &

/opt/mssql-tools18/bin/sqlcmd -C -S db -U sa -P "yourStrong(!)Password" -d master -i docker-entrypoint-initdb.d/init.sql;
