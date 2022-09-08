Declare @PersonStaging table
(
	PersonId INT not null identity(1, 1) Primary Key,
	FirstName NVARCHAR(20) not null,
	LastName NVARCHAR(20) not null,
	PasswordHash NVARCHAR(50) not null
)

-- Create all the people:

Insert @PersonStaging(FirstName, LastName, PasswordHash)
values
	(N'Taylor', N'Hebert', N'password'),	(N'Desirae', N'Barry', N'password'),	(N'Thaddeus', N'Boone', N'password'),	(N'Rashad', N'Morrison', N'password'),
	(N'Chelsea', N'Beck', N'password'),		(N'Orlando', N'Burton', N'password'),	(N'Philip', N'Chan', N'password'),		(N'Justina', N'Finley', N'password'),
	(N'Raymond', N'Head', N'password'),		(N'Jackson', N'Newman', N'password'),	(N'Dane', N'Howe', N'password'),		(N'William', N'Hinton', N'password'),
	(N'Grady', N'Holt', N'password'),		(N'Ivory', N'Morrison', N'password'),	(N'Hadassah', N'Porter', N'password'),	(N'Keane', N'Hays', N'password'),
	(N'Daphne', N'Boyer', N'password'),		(N'Kyla', N'Fields', N'password'),		(N'Devin', N'Mcmahon', N'password'),	(N'Darryl', N'Conway', N'password'),
	(N'Chaim', N'Norris', N'password'),		(N'Ria', N'Vazquez', N'password'),		(N'Oscar', N'Howe', N'password'),		(N'Ishmael', N'Blair', N'password'),
	(N'Slade', N'Morrow', N'password'),		(N'Isaac', N'Bell', N'password'),		(N'Genevieve', N'Farmer', N'password'), (N'Yuri', N'Welch', N'password'),
	(N'Lael', N'Fields', N'password'),		(N'Paula', N'Giles', N'password'),		(N'Ora', N'Reilly', N'password'),		(N'Marny', N'Kelley', N'password'),
	(N'Halla', N'Benton', N'password'),		(N'Cullen', N'Davenport', N'password'), (N'Tiger', N'Mcintosh', N'password'),	(N'Hamilton', N'Mullen', N'password'),
	(N'Gage', N'Morrow', N'password'),		(N'Hedy', N'Herring', N'password'),		(N'Karina', N'Haley', N'password'),		(N'Phoebe', N'Moss', N'password'),
	(N'Clarke', N'Rowland', N'password'),	(N'Andrew', N'Nielsen', N'password'),	(N'Hilda', N'Franks', N'password'),		(N'Todd', N'Green', N'password'),
	(N'Libby', N'Bass', N'password'),		(N'Madonna', N'Tanner', N'password'),	(N'Brett', N'Goff', N'password'),		(N'Russell', N'Hickman', N'password'),
	(N'Selma', N'Marquez', N'password'),	(N'Bevis', N'Woods', N'password'),		(N'Kylie', N'Briggs', N'password'),		(N'Meghan', N'Alford', N'password'),
	(N'Sopoline', N'Bradshaw', N'password'),(N'Robert', N'Gregory', N'password'),	(N'Elaine', N'Nieves', N'password'),	(N'Chava', N'Hensley', N'password'),
	(N'Sonya', N'Dudley', N'password'),		(N'Tatum', N'Grant', N'password'),		(N'Cade', N'Valenzuela', N'password'),	(N'Kim', N'Mooney', N'password'),
	(N'Kameko', N'Hartman', N'password'),	(N'Illana', N'Morrison', N'password'),	(N'Kasimir', N'Duncan', N'password'),	(N'Rachel', N'Jennings', N'password'),
	(N'Keiko', N'Rojas', N'password'),		(N'Jelani', N'Farley', N'password'),	(N'Uma', N'Collier', N'password'),		(N'Athena', N'Cruz', N'password'),
	(N'Cairo', N'Hopper', N'password'),		(N'Chloe', N'Ross', N'password'),		(N'Ignatius', N'Mcleod', N'password'),	(N'Mercedes', N'Hammond', N'password'),
	(N'Sylvia', N'Cobb', N'password'),		(N'Hashim', N'Vang', N'password'),		(N'Stacey', N'Erickson', N'password'),	(N'Sean', N'Fowler', N'password'),
	(N'Aaron', N'Snow', N'password'),		(N'Chadwick', N'Booker', N'password'),	(N'Rahim', N'Chen', N'password'),		(N'Hiroko', N'Hess', N'password'),
	(N'Clio', N'Barry', N'password'),		(N'Eliana', N'Richardson', N'password'),(N'Berk', N'Wooten', N'password'),		(N'Gannon', N'Gaines', N'password'),
	(N'Charlotte', N'Black', N'password'),	(N'Barclay', N'Rhodes', N'password'),	(N'Zephr', N'West', N'password'),		(N'Amanda', N'Owen', N'password'),
	(N'Dennis', N'Cannon', N'password'),	(N'Guy', N'Herman', N'password'),		(N'Lyle', N'Gamble', N'password'),		(N'Solomon', N'Franks', N'password'),
	(N'William', N'Sherman', N'password'),	(N'Aspen', N'Yang', N'password'),		(N'Jayme', N'Lindsey', N'password'),	(N'Dahlia', N'Leonard', N'password'),
	(N'Amery', N'Meadows', N'password'),	(N'Venus', N'Torres', N'password'),		(N'Hyacinth', N'Marsh', N'password'),	(N'Catherine', N'Foundling', N'password');

Merge School.Person P
Using @PersonStaging S on S.PersonId = P.PersonId
When not matched then
   Insert(FirstName, LastName, PasswordHash)
   Values(S.FirstName, S.LastName, S.PasswordHash);

Insert School.Student(PersonId)
Select P.PersonId
From School.Person P
Where P.PersonId < 91

Insert School.Teacher(PersonId)
Select P.PersonId
From School.Person P
Where P.PersonId >= 91

-- Semesters:

Insert School.Semester([Name], StartDate, EndDate)
Values (N'Spring 2021', '01-04-2021', '5-28-2021'), (N'Fall 2021', '08-16-2021', '12-16-2021')


	