

# RollCallCounter Project 
Repository containing the source codes of the project that allows university students to easily track their absences.
<br>
[trReadmeHere](https://github.com/fatihemregit/RollCallCounter/blob/master/README_TR.md)

## Purpose Of The Project
Purpose of the project is "University class absences easly recorded".
## Transactions Made in This Commit
+ Readme Update
## Used 
### Language
+ C#(net8.0)
### Database
+ Postgresql
### Frameworks
+ EfCore(8.0.2)

## Screenshots
137,138,139,140

## Project Diary
(this section translated by chatgbt)
### Day 1 (18.01.2024)
+ The project was created using Visual Studio.
+ A public GitHub repository was set up to store the code on cloud systems.
+ Created README.md and .gitignore files.
+ Designed a simple console menu.
+ Created the course model class.
+ Created the operation class (for clean code purposes) for attendance operations.
### Day 2 (19.01.2024)
+ Using the `islemyap` class, a system for selecting courses for attendance addition was created.
+ A system for adding courses was developed
+ The course model class was split into two separate model classes: attendance and course (modified for functionality).
### Day 3 (20.01.2024)
+ A system for selecting attendance addition dates was implemented.
+ The system for selecting attendance addition dates was developed using the `TryParse` method.
+ The code in `program.cs` (course selection, date selection) was assigned to separate functions.
### Day 4 (25.01.2024)
+ In the course addition system, invalid data entry by the user (leading spaces, trailing spaces, not entering a value) was prevented.
### Day 5 (28.01.2024)
+ In date selection, prevention of invalid data entry by the user (leading spaces, spaces in between, trailing spaces, empty data) was implemented.
+ The attendance addition system was completed with minor code fixes.
### Day 6 (31.01.2024)
+ Implemented a system for viewing attendance based on courses.

### Day 7 (2.02.2024)
+ Implemented a system for viewing attendance based on dates.

### Day 8 (3.03.2024)
+ Upgraded the project's .NET version (from .NET 6.0 to .NET 8.0).
+ Adapted the project for database operations (converted `IslemYap.cs` to an interface system).
+ Created DTO models for database operations.
+ Installed necessary libraries for database operations (EF Core, EF Core Tools, PostgreSQL).
+ General code corrections (class property corrections in `ders.cs`, `Dersdevamsizlik.cs`).
+ Shortened functions `dersBazindaDevamsizlikGetir` and `tarihBazindaDevamsizlikGetir` in the `IslemYapInMemory` class (previously `IslemYap.cs`) using LINQ where method.

## Day 9 (3.03.2024)
+ Developed the database operations of the project (completed the `IslemYapInDatabase` class). It was challenging because I had to redesign the database architecture.
## Day 10 (20.06.2024)
+ Changed the project architecture.
+ Separated the business rules in the `IslemYapInMemory` file.
+ Coded the `IIslemYapManager` file.
+ Adapted the project's database operations to the new architecture.





