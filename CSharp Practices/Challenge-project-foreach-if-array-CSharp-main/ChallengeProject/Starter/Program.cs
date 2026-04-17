/* This C# console application is designed to:
- Use arrays to store student names and assignment scores.
- Use a foreach statement to iterate through the student names.
- Calculate Exam Scores and Extra Credit separately.
- Report grades in the updated teacher format.
*/

int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// 1. Updated header row to match requirements
Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tLetter Grade\tExtra Credit\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;

    // 2. Variables for the new calculations
    int sumExamScores = 0;
    int sumExtraCreditScores = 0;
    int gradedAssignments = 0;

    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            // Sum the first 5 as exams
            sumExamScores += score;
        else
            // Sum the rest as extra credit
            sumExtraCreditScores += score;
    }

    // 3. New Math according to specification
    decimal examAverage = (decimal)sumExamScores / examAssignments;
    decimal overallGrade = (decimal)(sumExamScores + ((decimal)sumExtraCreditScores / 10)) / examAssignments;
    
    // Calculate the averages for the extra credit column
    decimal extraCreditAverage = (decimal)sumExtraCreditScores / (gradedAssignments - examAssignments);
    decimal extraCreditPoints = ((decimal)sumExtraCreditScores / 10) / examAssignments;

    // 4. Letter Grade Logic (Your original logic remains intact)
    if (overallGrade >= 97)
        currentStudentLetterGrade = "A+";
    else if (overallGrade >= 93)
        currentStudentLetterGrade = "A";
    else if (overallGrade >= 90)
        currentStudentLetterGrade = "A-";
    else if (overallGrade >= 87)
        currentStudentLetterGrade = "B+";
    else if (overallGrade >= 83)
        currentStudentLetterGrade = "B";
    else if (overallGrade >= 80)
        currentStudentLetterGrade = "B-";
    else if (overallGrade >= 77)
        currentStudentLetterGrade = "C+";
    else if (overallGrade >= 73)
        currentStudentLetterGrade = "C";
    else if (overallGrade >= 70)
        currentStudentLetterGrade = "C-";
    else if (overallGrade >= 67)
        currentStudentLetterGrade = "D+";
    else if (overallGrade >= 63)
        currentStudentLetterGrade = "D";
    else if (overallGrade >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";

    // 5. Updated Console output format
    Console.WriteLine($"{currentStudent}\t\t{examAverage}\t\t{overallGrade}\t\t{currentStudentLetterGrade}\t\t{extraCreditAverage} ({extraCreditPoints} pts)");
}

Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();