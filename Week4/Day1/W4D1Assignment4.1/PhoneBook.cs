namespace W4D1Assignment4._1 {
    internal class PhoneBook {
        public static Dictionary<string, Person> People = new Dictionary<string, Person>();

        public static void GeneratePeople() {
            People.Clear();
            new Person("John", "Doe", 1234567890, 1234569899, "1234 Elm St.");
            new Person("Jane", "Doe", 1234567891, 1234569898, "1235 Elm St.");
            new Person("Jim", "Doe", 1234567892, 1234569897, "1236 Elm St.");
            new Person("Jill", "Doe", 1234567893, 1234569896, "1237 Elm St.");
            new Person("Ted", "Barry", 1234567894, 1234569895, "1238 Elm St.");
            new Person("Tina", "Barry", 1234567895, 1234569894, "1239 Elm St.");
            new Person("Tom", "Barry", 1234567896, 1234569893, "1240 Elm St.");
            new Person("Tara", "Barry", 1234567897, 1234569892, "1241 Elm St.");
            new Person("Tim", "Barry", 1234567898, 1234569891, "1242 Elm St.");
            new Person("Tanya", "Barry", 1234567899, 1234569890, "1243 Elm St.");
            new Person("Alice", "Smith", 1111111111, 2222222222, "100 Main St.");
            new Person("Bob", "Smith", 3333333333, 4444444444, "101 Main St.");
            new Person("Charlie", "Johnson", 5555555555, 6666666666, "102 Main St.");
            new Person("David", "Johnson", 7777777777, 8888888888, "103 Main St.");
            new Person("Eve", "Williams", 9999999999, 1010101010, "104 Main St.");
            new Person("Frank", "Williams", 1212121212, 1313131313, "105 Main St.");
            new Person("Grace", "Brown", 1414141414, 1515151515, "106 Main St.");
            new Person("Hank", "Brown", 1616161616, 1717171717, "107 Main St.");
            new Person("Ivy", "Davis", 1818181818, 1919191919, "108 Main St.");
            new Person("Jack", "Davis", 2020202020, 2121212121, "109 Main St.");
            new Person("Karen", "Miller", 2222222222, 2323232323, "110 Main St.");
            new Person("Leo", "Miller", 2424242424, 2525252525, "111 Main St.");
            new Person("Mia", "Wilson", 2626262626, 2727272727, "112 Main St.");
            new Person("Noah", "Wilson", 2828282828, 2929292929, "113 Main St.");
            new Person("Olivia", "Moore", 3030303030, 3131313131, "114 Main St.");
            new Person("Paul", "Moore", 3232323232, 3333333333, "115 Main St.");
            new Person("Quinn", "Taylor", 3434343434, 3535353535, "116 Main St.");
            new Person("Ryan", "Taylor", 3636363636, 3737373737, "117 Main St.");
            new Person("Sophia", "Anderson", 3838383838, 3939393939, "118 Main St.");
            new Person("Tom", "Anderson", 4040404040, 4141414141, "119 Main St.");
            new Person("Uma", "Thomas", 4242424242, 4343434343, "120 Main St.");
            new Person("Victor", "Thomas", 4444444444, 4545454545, "121 Main St.");
            new Person("Wendy", "Jackson", 4646464646, 4747474747, "122 Main St.");
            new Person("Xander", "Jackson", 4848484848, 4949494949, "123 Main St.");
            new Person("Yasmine", "White", 5050505050, 5151515151, "124 Main St.");
            new Person("Zack", "White", 5252525252, 5353535353, "125 Main St.");
        }
    }
}
