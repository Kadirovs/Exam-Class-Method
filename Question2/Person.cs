using System.Text;

public class Person
{

	public string name;
	public int age;

	public string introduce(){
		var stringBuilder = new StringBuilder();
		stringBuilder
		.Append("Salom,nomi man ")
		.Append(name)
		.Append(" ast va man ")
		.Append(age)
		.Append(" solaam.");
		return stringBuilder.ToString();
	}

}