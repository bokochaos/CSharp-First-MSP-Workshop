using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculator
{
    
    class Grade
    {

        /// <summary>
        /// Create an assignment with its:
        /// name
        /// type (attendance, participation, quiz, homework, etc)
        /// score
        /// max score
        /// </summary>
        private String assignment; //refactor
        private String assignmentType;
        private int score;
        private int maxPoints;


        public Grade(String assignment, String assignmentType, int points, int maxPoints)
        {
            
        }

        public String getAssignmentName()
        {
            
        }

        public String getAssignmentType() { }

        public int getScore() {  }

        public int getOutOfMaxPoints() {  }

        public double scorePercentage() {  }

        public String getLetterGrade()
        {
            
        }

        public void changeAssignmentName(String newName) {  }

        public void changeAssignmentType(String newType) {  }

        public void changeAssignmentScore(int newScore) {  }

        public void changeAssignmentMaxPoints(int newMax) {  }

        public override string ToString() //Overrides the object.ToString() method
        {
           
        }
    }
}
