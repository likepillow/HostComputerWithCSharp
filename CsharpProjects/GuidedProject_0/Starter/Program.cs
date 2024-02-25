// initialize variables - graded assignments 
int examAssignments = 5;
int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
int[] andrewScores = [92, 89, 81, 96, 90, 89];
int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
int[] loganScores = [90, 95, 87, 88, 96, 96];

// Student names
string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor"];

int[] studentScores = new int[10];
string currentStudentLetterGrade = "";

//write the report header to the console
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");
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

    else
        continue;

    //initialize/reset the sum of scored assignments

    int sumExamScores = 0;

    int sumExtraScores = 0;

    //initialize/reset the calculated average of exam + extra credit scores
    decimal currentOverallGrade = 0;

    decimal currentExamScores = 0;

    decimal currentExtraGrade = 0;

    decimal extraInfluence = 0;

    //initialize/reset a counter for the number of assignment
    int gradedAssignments = 0;

    int extraGradeAssignments = 0;

    //loop through the scores array and complete caculations for currentStudent
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;
        if (gradedAssignments <= examAssignments)
            //add the exam score to the sum
            sumExamScores += score;

        else if (score > 0)
        {
            extraGradeAssignments += 1;
            //add the extra credit points to the sum - bonus point equals to 10% of an exam score
            sumExtraScores += score;
        }
    }

    extraInfluence = (decimal)sumExtraScores / examAssignments / 10;
    currentExamScores = (decimal)sumExamScores / examAssignments;
    currentOverallGrade = currentExamScores + extraInfluence;
    if (extraGradeAssignments > 0)
        currentExtraGrade = (decimal)sumExtraScores / extraGradeAssignments;

    if (currentOverallGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentOverallGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentOverallGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentOverallGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentOverallGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentOverallGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentOverallGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentOverallGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentOverallGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentOverallGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentOverallGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentOverallGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{currentExamScores}\t\t{currentOverallGrade}\t{currentStudentLetterGrade}\t{currentExtraGrade} ({extraInfluence} pts) ");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();