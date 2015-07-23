use BarCodeApplication

select * from dbo.Imports;
select * from dbo.Jobs;
select * from dbo.__MigrationHistory;

delete from dbo.Jobs;

drop table dbo.Imports;
drop table dbo.Jobs;
drop table dbo.__MigrationHistory;

use master;

