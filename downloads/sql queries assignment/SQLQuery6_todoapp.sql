create table dbo.notes(
id bigint identity(1,1),
[description] nvarchar(max))

select * from dbo.notes;

insert into dbo.notes values('do laundry')
insert into dbo.notes values('buy fruits')