using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculator
{
    class Program
    {
        /// <summary>
        /// Create a system where you:
        /// - Create a Grade Book to hold all course grades
        /// - Create a text UI to record/change grades
        /// - Create a command to print the user's current grade
        /// </summary>
        /// <param name="args"></param>

        //protected static GradeBook grades; //Allows child classes to access contents.

        private static Dictionary<String, double> gradeWeights;  //To calculate the percentages for assignments by their type.
        private static Dictionary<String, List<Grade>> assignmentsByCategory; //Collects all assignments by their category.

        static void Main(string[] args)
        {

            gradeWeights = new Dictionary<string, double>();
            assignmentsByCategory = new Dictionary<string, List<Grade>>();
            String input = "";
            do
            {
                Console.Write("Do you want to: \nADD GRADE a grade \nADD SCALE to add a scale" +
                    "\nCHANGE a grade \nCOMPUTE your grade so far \nVIEW your assignments in detail \nQUIT?: ");
                input = Console.ReadLine().ToUpper();
                switch (input)
                {
                    
                }
            } while (!input.Equals("quit", StringComparison.InvariantCultureIgnoreCase));
        }

        private static void addGrade()
        {
            String assignment, assignmentType;
            int score, maxScore;
           
        }

        private static void addScale()
        {
            String assignmentType;
            double weight;
            
        }

        private static void printAssignments()
        {
            List<Grade> assignments = getAllAssignments();
            
        }

        public static void addGradeWeight(String assignmentType, double weight)
        {
            
        }

        public static void addAssignment(String assignment, String assignmentType, int score, int maxScore)
        {
            
        }

        public static List<Grade> getAssignmentByType(String assignmentType)
        {
            
        }

        public static List<Grade> getAllAssignments()
        {
            
        }

        public static void changeAssignment(int index, String assignmentType, Grade newAssignment)
        {
            
        }

        public static String getLetterGrade()
        {
            
        }

        public static double getPercentageScore()
        {
            
        }
    }
}
