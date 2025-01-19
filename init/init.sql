IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'CMSPlus')
BEGIN
    CREATE DATABASE CMSPlus;
    PRINT 'Database CMSPlus created successfully';
END
