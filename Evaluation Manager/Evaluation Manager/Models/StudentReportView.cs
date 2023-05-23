using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager.Models
{
    public class StudentReportView
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string E1 { get; set; }
        public string E2 { get; set; }
        public string A1 { get; set; }
        public string A2 { get; set; }
        public string A3 { get; set; }
        public string HasSignature { get; set; }
        public string HasGrade { get; set; }
        public int TotalPoints { get; set; }
        public int Grade { get; set; }
        public StudentReportView(Student student)
        {
            FirstName = student.FirstName;
            LastName = student.LastName;
            HasSignature = student.HasSignature() == true ? "Oui" : "Non";
            HasGrade = student.HasGrade() == true ? "Oui" : "Non";
            TotalPoints = student.CalculateTotalPoints();
            Grade = student.CalculateGrade();
            var evaluations = student.GetEvaluations();
            var kolokvij1 = evaluations.FirstOrDefault(e => e.Activity.Name == "Kolokvij 1"); //Evaluation 1
            var kolokvij2 = evaluations.FirstOrDefault(e => e.Activity.Name == "Kolokvij 2");
            var zadaca1 = evaluations.FirstOrDefault(e => e.Activity.Name == "Zadaca 1"); //Assagnment 1
            var zadaca2 = evaluations.FirstOrDefault(e => e.Activity.Name == "Zadaca 2");
            var zadaca3 = evaluations.FirstOrDefault(e => e.Activity.Name == "Zadaca 3");
            E1 = kolokvij1 == null ? "-" : kolokvij1.Points.ToString();
            E2 = kolokvij2 == null ? "-" : kolokvij2.Points.ToString();
            A1 = zadaca1 == null ? "-" : zadaca1.Points.ToString();
            A2 = zadaca2 == null ? "-" : zadaca2.Points.ToString();
            A3 = zadaca3 == null ? "-" : zadaca3.Points.ToString();
        }
    }
}
