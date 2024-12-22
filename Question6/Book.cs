using System.Text;
public class Book
{
	public string title;
	public string author;

	public int price;

	public string showInfo(){
		var stringBuilder = new StringBuilder();
		stringBuilder
		.Append("Kitob: ")
		.Append(title)
		.Append("\n")
		.Append("Muallif: ")
		.Append(author)
		.Append("\n")
		.Append("Narx: ")
		.Append(price);
		return stringBuilder.ToString();
	}
}