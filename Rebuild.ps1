Param(
   [string] $Server = "(localdb)\MSSQLLocalDb",
   [string] $Database = "SchoolDatabase"
)

# This script requires the SQL Server module for PowerShell.
# The below commands may be required.

# Get-Module -ListAvailable -Name SqlServer;

# Install-Module -Name SqlServer -Scope CurrentUser

$CurrentDrive = (Get-Location).Drive.Name + ":"

Write-Host ""
Write-Host "Rebuilding database $Database on $Server..."

<#
   If on your local machine, you can drop and re-create the database.
#>
& ".\Scripts\Drop.ps1" -Database $Database
& ".\Scripts\Create.ps1" -Database $Database

<#
   If on the department's server, you don't have permissions to drop or create databases.
   In this case, maintain a script to drop all tables.
#>

Write-Host "Dropping tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Tables\DropTables.sql"

Write-Host "Creating schema..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Schemas\School.sql"

Write-Host "Creating tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Tables\School.Person.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Tables\School.Student.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Tables\School.Teacher.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Tables\School.Semester.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Tables\School.Course.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Tables\School.Enrollment.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Tables\School.AssignmentCategories.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Tables\School.Assignments.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Tables\School.SubmittedAssignment.sql"

Write-Host "Stored procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\CreateObjects\AssignmentCategories.CreateAssignmentCategories.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\CreateObjects\Assignments.CreateAssignment.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\CreateObjects\Course.CreateCourse.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\CreateObjects\Enrollment.CreateEnrollment.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\CreateObjects\SubmittedAssignments.CreateSubmittedAssignment.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\StudentInfo\Student.FetchCourseCount.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\StudentInfo\Student.FetchGradeAvg.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\StudentInfo\Student.FetchID.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\StudentInfo\Student.FetchStudentName.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\StudentInfo\CourseInfo\Assignments.FetchAssignmentsDue.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\StudentInfo\CourseInfo\Course.FetchCourseName.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\StudentInfo\CourseInfo\Course.RetrieveStudentCourses.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\StudentInfo\CourseInfo\Course.RetrieveUnenrolledInCourses.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\StudentInfo\CourseInfo\SubmittedAssignments.FetchCourseGrade.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\StudentInfo\CourseInfo\SubmittedAssignments.FetchSubmittedAssignments.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\TeacherInfo\Teacher.FetchTeacherCourseCount.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\TeacherInfo\Teacher.FetchTeacherName.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\TeacherInfo\Teacher.RetrieveTeacherCourses.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\TeacherInfo\CourseInfo\Course.FetchCourseStudentCount.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\TeacherInfo\CourseInfo\Course.RetrieveStudents.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\TeacherInfo\CourseInfo\AssignmentInfo\AssignmentCategories.RetrieveCategories.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\TeacherInfo\CourseInfo\AssignmentInfo\Assignments.FetchAssignment.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\TeacherInfo\CourseInfo\AssignmentInfo\Assignments.RetrieveAssignments.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\TeacherInfo\CourseInfo\AssignmentInfo\Assignments.RetrieveAssignmentsForCategory.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\TeacherInfo\CourseInfo\SemesterInfo\Semester.FetchSemesterEndDate.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\TeacherInfo\CourseInfo\SemesterInfo\Semester.FetchSemesterStartDate.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\TeacherInfo\CourseInfo\Reports\Assignments.FetchAvgGrade.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\TeacherInfo\CourseInfo\Reports\Assignments.MonthlyScores.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\TeacherInfo\CourseInfo\Reports\Student.BestStudentsForCourse.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\TeacherInfo\CourseInfo\Reports\Student.FetchBestWorstStudent.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\Semester.GetCurrentSemester.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DatabaseAccessLibrary\Procedures\School.FetchIDFromName.sql"



Write-Host "Inserting data..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Data\Sql\Data\InitData.sql"

Write-Host "Rebuild completed."
Write-Host ""

#Set-Location $CurrentDrive
