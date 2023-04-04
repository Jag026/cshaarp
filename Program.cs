int employeeLevel = 300;
string employeeName = "Bilbo";

string title = "";

switch (employeeLevel) {
    case 100:
        title = "mail room";
        break;
    case 200:
        title = "manager";
        break;
    case 300:
        title = "CEO";
        break;
}

Console.WriteLine($"{employeeName}, {title}");