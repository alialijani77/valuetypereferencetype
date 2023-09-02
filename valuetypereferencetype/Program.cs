//value type
int x = 2;
int y = x;
Console.WriteLine(x);
Console.WriteLine(y);
y = 4;
Console.WriteLine(x);
Console.WriteLine(y);
//refrence type arrray
int[] a = { 2 };
int[] b = a;
Console.WriteLine(a[0]);
Console.WriteLine(b[0]);
b[0] = 10;
Console.WriteLine(a[0]);
Console.WriteLine(b[0]);
//refrence type class
user user1 = new user();
user user2 = user1;
Console.WriteLine(user1.age);
Console.WriteLine(user2.age);
user2.age = 1;
ChangeAge(ref user1);
//value type struct
var employe = new employe();
var employe2 = employe;
Console.WriteLine(employe.age);
Console.WriteLine(employe2.age);
ChangeAge2(ref employe2);

void ChangeAge(ref user u)
{
	Console.WriteLine(user1.age);
	Console.WriteLine(user2.age);
	u.age = 2;
    Console.WriteLine(user1.age);
    Console.WriteLine(user2.age);
}

void ChangeAge2(ref employe e2)
{
	e2.age = 2;
	Console.WriteLine(employe.age);
	Console.WriteLine(employe2.age);
}
public class user
{
	public int age = 25;
}

struct employe
{
	public int age = 33;

    public employe()
    {
    }
}


