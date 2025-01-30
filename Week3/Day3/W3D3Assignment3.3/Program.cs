namespace W3D3Assignment3._3 {
    /*
    Windows form assignments
    Use different controls on windows forms and change their properties (do not submit this assignment)
    Create a class: Student with fields like studid, firstname, lastname, address,monthofadmission,grade to hold character.
    Create a list of students and perform following operations in windows application:
    add new records,
    delete record and
    display them in grid.
    Monthofadmission should be enum.
    */
    internal static class Program {
        [STAThread]
        static void Main() {
            ApplicationConfiguration.Initialize();
            Application.Run(new StudentRecords());
        }
    }
}