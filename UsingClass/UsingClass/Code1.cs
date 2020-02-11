namespace Code1Data
{
    public class Code1
    {
        public string dataGrade;
        public Code1(int score)
        {
            string grade;
            if (score >= 80)
            {
                grade = "A";
            }
            else if (score >= 75)
            {
                grade = "B+";
            }
            else if (score >= 70)
            {
                grade = "B";
            }
            else if (score >= 65)
            {
                grade = "C+";
            }
            else if (score >= 60)
            {
                grade = "C";
            }
            else if (score >= 55)
            {
                grade = "D+";
            }
            else if (score >= 50)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }

            dataGrade = grade;
        }
    }
}