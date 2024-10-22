select * from students
UPDATE students set Position='Researcher';
UPDATE students set scholarship=30000.00;
exec sp_rename 'students.salary','stipen';
BEGIN TRANSACTION t1;
SAVE TRANSACTION before_delete;
DELETE FROM students WHERE StudentId = 79;
SELECT * FROM students;
ROLLBACK TO before_delete;
COMMIT TRANSACTION t1;
exec sp_columns students;