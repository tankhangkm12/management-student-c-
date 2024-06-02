using System;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace Management_student
{

    class Student
    {
        public char StudentID { get; set;  }
        public string StudentName { get; set; }
        public bool Gender { get; set; }
        public int Year { get; set; }
        public char ClassId { get; set; }

        public void StudentDetails()
        {
 
        }

        public void PayFees()
        {

        }

        public void isPresent()
        {

        }
    }


    class Classroom
    {
        public char ClassID { get; set; }
        public char DepartmentID { get; set; }


        public void ClassroomDetails()
        {

        }

        public void isOccupied()
        {

        }

    }

    class Auditorium
    {
        public string AuditoriumName { get; set; }
        public List<string> EventsList { get; set; }
        public DateOnly Date { get; set; }
        public DateTime Time { get; set; }

        public int TotalSeats { get; set; }
        public char DeparmentID { get; set; }

        public void BookEvents()
        {

        }
    }



    class UGSttudent: Student
    {

    }

    class PGstudent : Student
    {

    }


    class Canteen
    {
        public char InchargeID { get; set; }
        public List<string> ItemsList { get; set; }
        public List<string> AvailableList { get; set; }
        public void ShowItems()
        {

        }

        public void Buy()
        {

        }
    }
    class Library
    {
        public char LibraryID { get; set; }
        public string LibrarianName { get; set; }
        public string BookSection { get; set; }
        public int TotalBooks { get; set; }


        public void LibraryDetails()
        {

        }

        public void SearchBooks()
        {

        }

        public void LendBooks()
        {

        }

        public void ReturnBooks()
        {
            
        }

        public void PayFine()
        {

        }
    }

    class CollegeManagement
    {
        public string CollegeName { get; set; }
        public string City { get; set; }
        public string ContactNumber { get; set; }


        public void Open()
        {

        }

        public void collegeDetails()
        {

        }
    }


    class Parking
    {
        public char SlotID { get; set; }
        public int VehicleNumber { get; set; }
        public string VehicleOwnerName { get; set; }
        public void ParkVehicle()
        {

        }

    }


    class Department
    {
        public char DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string HODName { get; set; }
        public int TotalStaffs { get; set; }
        public int TotalStudents { get; set; }
        

        public void DepartmentDetails()
        {

        }

        public void ShowEvents()
        {

        }
    }




    class Hostel
    {
        public int StudentID { get; set; }
        public int BlockNumber {get;set;}

        public int RoomNumber { get; set; }


        public void HostelDetails()
        {

        }

        public void CheckIn()
        {

        }

        public void CheckOut()
        {

        }

    }
    class BoysHostel : Hostel
    {

    }

    class GirlsHostel : Hostel
    {

    }


    class Staff
    {
        public char StaffID { get; set; }
        public string StaffName { get; set; }
        public char DepartmentID { get; set; }
        public string Salary { get; set; }

        public void StaffDetails()
        {

        }
    }

    class TeachingStaff : Staff
    {

    }

    class NonTeachingStaff : Staff
    {

    }


    class Bus
    {
        public char BusID { get; set; }
        public int BusNumber { get; set; }
        public string DriverName { get; set; }
        public string Destination { get; set; }

        public int TotalSeats { get; set; }


        public void BusDetails()
        {

        }

        public void SeatsAvailability()
        {

        }
    }
        

    class Program
    {
        public static void Main(String[] agrs)
        {
           
        }
    }
}
