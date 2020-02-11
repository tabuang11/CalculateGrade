namespace Code2Data
{
    public class Code2
    {
        public string dataGrade;
        public Code2(int score)
        {
            if (score <= 100 && score > 0)
            {
                switch (score)
                {

                    case 100:
                    case 99:
                    case 98:
                    case 97:
                    case 96:
                    case 95:
                    case 94:
                    case 93:
                    case 92:
                    case 91:
                    case 90:
                    case 89:
                    case 88:
                    case 87:
                    case 86:
                    case 85:
                    case 84:
                    case 83:
                    case 82:
                    case 81:
                    case 80:
                        dataGrade = "A";
                        break;
                    
                    case 79:
                    case 78:
                    case 77:
                    case 76:
                    case 75:
                        dataGrade = "B+";
                        break;
                    
                    case 74:
                    case 73:
                    case 72:
                    case 71:
                    case 70:
                        dataGrade = "B";
                        break;
                    
                    case 69:
                    case 68:
                    case 67:
                    case 66:
                    case 65:
                        dataGrade = "C+";
                        break;
                    
                    case 64:
                    case 63:
                    case 62:
                    case 61:
                    case 60:
                        dataGrade = "C";
                        break;
                                        
                    case 59:
                    case 58:
                    case 57:
                    case 56:
                    case 55:
                        dataGrade = "D+";
                        break;
                    
                    case 54:
                    case 53:
                    case 52:
                    case 51:
                    case 50:
                        dataGrade = "D";
                        break;
                    
                    default:
                        dataGrade = "F";
                        break;
                }
            }
            else
            {
                dataGrade = "Score must below 100 OR more 0";
            }
        }
    }
}