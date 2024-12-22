using System.Text;

public class Car 
{
	public string make;
	public string model;
	public int year;
	public string displayDetails(){
		var stringBuilder = new StringBuilder();
		stringBuilder
		.Append(make)
		.Append(" ")
		.Append(model)
		.Append(", ")
		.Append(year);

		return stringBuilder.ToString();
	}
	
}