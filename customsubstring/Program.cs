

string name = "MuhammadMustafa";

Console.WriteLine(CustomSubstring(name,2,10));


string CustomSubstring(string data,int startindex,int endindex)
{
	string emptystring = string.Empty;
	if (startindex<0 || startindex>=data.Length)
	{
		return "start index duzgun teyin edilmemisdir";
	}
	else if (endindex<0 || endindex > data.Length)
	{
		return "end index duzgun daxil edilmemisdir";
    }
	else
	{
		for (int i = 0; i < data.Length; i++)
		{
			if (i>=startindex && i<endindex)
			{
				emptystring=emptystring + data[i];
			
			}
		}
		return emptystring;

	}

}