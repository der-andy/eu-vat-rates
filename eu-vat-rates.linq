<Query Kind="Program">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <Namespace>Newtonsoft.Json</Namespace>
  <Namespace>Newtonsoft.Json.Linq</Namespace>
</Query>

void Main()
{
	var rates = new Dictionary<string, List<VatRate>>();
	
	// Belgium
	rates.Add("be", new List<VatRate>());
	rates["be"].Add(new VatRate { StartDate = new DateTime(1971,  1,  1), Standard = 18, Reduced1 = 6, Increased1 = 25, Parking1 = 14 });
	rates["be"].Add(new VatRate { StartDate = new DateTime(1978,  1,  1), Standard = 16, Reduced1 = 6, Increased1 = 25 });
	rates["be"].Add(new VatRate { StartDate = new DateTime(1980, 12,  1), Standard = 16, Reduced1 = 6, Increased1 = 25, Increased2 = 30 });
	rates["be"].Add(new VatRate { StartDate = new DateTime(1981,  7,  1), Standard = 17, Reduced1 = 6, Increased1 = 25, Increased2 = 30 });
	rates["be"].Add(new VatRate { StartDate = new DateTime(1981,  9,  1), Standard = 17, Reduced1 = 6, Increased1 = 25, Increased2 = 33 });
	rates["be"].Add(new VatRate { StartDate = new DateTime(1982,  3,  1), Standard = 17, Reduced1 = 6, Reduced2 = 1, Increased1 = 25, Increased2 = 33 });
	rates["be"].Add(new VatRate { StartDate = new DateTime(1983,  1,  1), Standard = 19, Reduced1 = 6, Reduced2 = 1, Increased1 = 25, Increased2 = 33, Parking1 = 17 });
	rates["be"].Add(new VatRate { StartDate = new DateTime(1992,  4,  1), Standard = 19.5, Reduced1 = 12, Reduced2 = 6, Reduced3 = 1, Parking1 = 14 });
	rates["be"].Add(new VatRate { StartDate = new DateTime(1994,  1,  1), Standard = 20.5, Reduced1 = 12, Reduced2 = 6, Reduced3 = 1, Parking1 = 14 });
	rates["be"].Add(new VatRate { StartDate = new DateTime(1996,  1,  1), Standard = 21, Reduced1 = 12, Reduced2 = 6, Reduced3 = 1, Parking1 = 14 });
	rates["be"].Add(new VatRate { StartDate = new DateTime(2000,  1,  1), Standard = 21, Reduced1 = 12, Reduced2 = 6, Parking1 = 14 });
	
	// Bulgaria
	rates.Add("bg", new List<VatRate>());
	rates["bg"].Add(new VatRate { StartDate = new DateTime(1994,  4,  1), Standard = 18 });
	rates["bg"].Add(new VatRate { StartDate = new DateTime(1996,  7,  1), Standard = 22 });
	rates["bg"].Add(new VatRate { StartDate = new DateTime(1999,  1,  1), Standard = 20 });
	rates["bg"].Add(new VatRate { StartDate = new DateTime(2007,  1,  1), Standard = 20, Reduced1 = 7 });
	rates["bg"].Add(new VatRate { StartDate = new DateTime(2011,  4,  1), Standard = 20, Reduced2 = 9 });
	
	// Czech Republic
	rates.Add("cz", new List<VatRate>());
	rates["cz"].Add(new VatRate { StartDate = new DateTime(1993,  1,  1), Standard = 23, Reduced1 = 5 });
	rates["cz"].Add(new VatRate { StartDate = new DateTime(1995,  1,  1), Standard = 22, Reduced1 = 5 });
	rates["cz"].Add(new VatRate { StartDate = new DateTime(2004,  5,  1), Standard = 19, Reduced1 = 5 });
	rates["cz"].Add(new VatRate { StartDate = new DateTime(2008,  1,  1), Standard = 19, Reduced1 = 9 });
	rates["cz"].Add(new VatRate { StartDate = new DateTime(2010,  1,  1), Standard = 20, Reduced1 = 10 });
	rates["cz"].Add(new VatRate { StartDate = new DateTime(2012,  1,  1), Standard = 20, Reduced1 = 14 });
	rates["cz"].Add(new VatRate { StartDate = new DateTime(2013,  1,  1), Standard = 21, Reduced1 = 15 });
	rates["cz"].Add(new VatRate { StartDate = new DateTime(2015,  1,  1), Standard = 21, Reduced1 = 15, Reduced2 = 10 });

	// Denmark
	rates.Add("dk", new List<VatRate>());
	rates["dk"].Add(new VatRate { StartDate = new DateTime(1967,  7,  3), Standard = 10 });
	rates["dk"].Add(new VatRate { StartDate = new DateTime(1968,  4,  1), Standard = 12.5 });
	rates["dk"].Add(new VatRate { StartDate = new DateTime(1970,  6, 29), Standard = 15 });
	rates["dk"].Add(new VatRate { StartDate = new DateTime(1975,  9, 29), Standard = 15, Reduced1 = 9.25 });
	rates["dk"].Add(new VatRate { StartDate = new DateTime(1976,  3,  1), Standard = 15 });
	rates["dk"].Add(new VatRate { StartDate = new DateTime(1977, 10,  3), Standard = 18 });
	rates["dk"].Add(new VatRate { StartDate = new DateTime(1978, 10,  1), Standard = 20.25 });
	rates["dk"].Add(new VatRate { StartDate = new DateTime(1980,  6, 30), Standard = 22 });
	rates["dk"].Add(new VatRate { StartDate = new DateTime(1992,  1,  1), Standard = 25 });
	
	// Germany
	rates.Add("de", new List<VatRate>());
	rates["de"].Add(new VatRate { StartDate = new DateTime(1968,  1,  1), Standard = 10, Reduced1 = 5 });
	rates["de"].Add(new VatRate { StartDate = new DateTime(1968,  7,  1), Standard = 11, Reduced1 = 5 });
	rates["de"].Add(new VatRate { StartDate = new DateTime(1978,  1,  1), Standard = 12, Reduced1 = 6 });
	rates["de"].Add(new VatRate { StartDate = new DateTime(1979,  7,  1), Standard = 13, Reduced1 = 6.5 });
	rates["de"].Add(new VatRate { StartDate = new DateTime(1983,  7,  1), Standard = 14, Reduced1 = 7 });
	rates["de"].Add(new VatRate { StartDate = new DateTime(1993,  1,  1), Standard = 15, Reduced1 = 7 });
	rates["de"].Add(new VatRate { StartDate = new DateTime(1998,  4,  1), Standard = 16, Reduced1 = 7 });
	rates["de"].Add(new VatRate { StartDate = new DateTime(2007,  1,  1), Standard = 19, Reduced1 = 7 });
	
	// Estonia
	rates.Add("ee", new List<VatRate>());
	rates["ee"].Add(new VatRate { StartDate = new DateTime(1991,  1,  1), Standard = 10 });
	rates["ee"].Add(new VatRate { StartDate = new DateTime(1993,  1,  1), Standard = 18 });
	rates["ee"].Add(new VatRate { StartDate = new DateTime(2000,  1,  1), Standard = 18, Reduced1 = 5 });
	rates["ee"].Add(new VatRate { StartDate = new DateTime(2009,  1,  1), Standard = 18, Reduced1 = 9 });
	rates["ee"].Add(new VatRate { StartDate = new DateTime(2009,  7,  1), Standard = 20, Reduced1 = 9 });
	
	// Greece
	rates.Add("el", new List<VatRate>());
	rates["el"].Add(new VatRate { StartDate = new DateTime(1987,  1,  1), Standard = 18, Reduced1 = 6, Reduced2 = 3, Increased1 = 36 });
	rates["el"].Add(new VatRate { StartDate = new DateTime(1988,  1,  1), Standard = 16, Reduced1 = 6, Reduced2 = 3, Increased1 = 36 });
	rates["el"].Add(new VatRate { StartDate = new DateTime(1990,  4, 28), Standard = 18, Reduced1 = 8, Reduced2 = 4, Increased1 = 36 });
	rates["el"].Add(new VatRate { StartDate = new DateTime(1992,  8,  8), Standard = 18, Reduced1 = 8, Reduced2 = 4 });
	rates["el"].Add(new VatRate { StartDate = new DateTime(2005,  4,  1), Standard = 19, Reduced1 = 9, Reduced2 = 4.5 });
	rates["el"].Add(new VatRate { StartDate = new DateTime(2010,  3, 15), Standard = 21, Reduced1 = 10, Reduced2 = 5 });
	rates["el"].Add(new VatRate { StartDate = new DateTime(2010,  7,  1), Standard = 23, Reduced1 = 11, Reduced2 = 5.5 });
	rates["el"].Add(new VatRate { StartDate = new DateTime(2011,  1,  1), Standard = 23, Reduced1 = 13, Reduced2 = 6.5 });
	rates["el"].Add(new VatRate { StartDate = new DateTime(2015,  7, 20), Standard = 23, Reduced1 = 13, Reduced2 = 6 });
	rates["el"].Add(new VatRate { StartDate = new DateTime(2016,  6,  1), Standard = 24, Reduced1 = 13, Reduced2 = 6.5 });
	
	rates.Add("gr", rates["el"]);
	
	// Spain
	rates.Add("es", new List<VatRate>());
	rates["es"].Add(new VatRate { StartDate = new DateTime(1986,  1,  1), Standard = 12, Reduced1 = 6, Increased1 = 33 });
	rates["es"].Add(new VatRate { StartDate = new DateTime(1992,  1,  1), Standard = 13, Reduced1 = 6, Increased1 = 28 });
	rates["es"].Add(new VatRate { StartDate = new DateTime(1992,  8,  1), Standard = 15, Reduced1 = 6, Increased1 = 28 });
	rates["es"].Add(new VatRate { StartDate = new DateTime(1993,  1,  1), Standard = 15, Reduced1 = 6, Reduced2 = 3 });
	rates["es"].Add(new VatRate { StartDate = new DateTime(1995,  1,  1), Standard = 16, Reduced1 = 7, Reduced2 = 4 });
	rates["es"].Add(new VatRate { StartDate = new DateTime(2010,  7,  1), Standard = 18, Reduced1 = 8, Reduced2 = 4 });
	rates["es"].Add(new VatRate { StartDate = new DateTime(2012,  9,  1), Standard = 21, Reduced1 = 10, Reduced2 = 4 });
	
	// France
	rates.Add("fr", new List<VatRate>());
	rates["fr"].Add(new VatRate { StartDate = new DateTime(1970,  1,  1), Standard = 23, Reduced1 = 7.5, Increased1 = 33.33, Parking1 = 17.6 });
	rates["fr"].Add(new VatRate { StartDate = new DateTime(1973,  1,  1), Standard = 20, Reduced1 = 7, Increased1 = 33.33, Parking1 = 17.6 });
	rates["fr"].Add(new VatRate { StartDate = new DateTime(1977,  1,  1), Standard = 17.6, Reduced1 = 7, Increased1 = 33.33 });
	rates["fr"].Add(new VatRate { StartDate = new DateTime(1982,  7,  1), Standard = 18.6, Reduced1 = 7, Reduced2 = 5.5, Reduced3 = 4, Increased1 = 33.33 });
	rates["fr"].Add(new VatRate { StartDate = new DateTime(1986,  1,  1), Standard = 18.6, Reduced1 = 7, Reduced2 = 5.5, Reduced3 = 4, Increased1 = 33.33 });
	rates["fr"].Add(new VatRate { StartDate = new DateTime(1986,  7,  1), Standard = 18.6, Reduced1 = 13, Reduced2 = 7, Reduced3 = 5.5, Reduced4 = 4, Reduced5 = 2.1, Increased1 = 33.33 });
	rates["fr"].Add(new VatRate { StartDate = new DateTime(1987,  9, 17), Standard = 18.6, Reduced1 = 13, Reduced2 = 7, Reduced3 = 5.5, Reduced4 = 4, Reduced5 = 2.1, Increased1 = 33.33, Parking1 = 28 });
	rates["fr"].Add(new VatRate { StartDate = new DateTime(1988, 12,  1), Standard = 18.6, Reduced1 = 13, Reduced2 = 7, Reduced3 = 5.5, Reduced4 = 4, Reduced5 = 2.1, Increased1 = 28 });
	rates["fr"].Add(new VatRate { StartDate = new DateTime(1989,  1,  1), Standard = 18.6, Reduced1 = 13, Reduced2 = 5.5, Reduced3 = 2.1, Increased1 = 28 });
	rates["fr"].Add(new VatRate { StartDate = new DateTime(1989,  9,  8), Standard = 18.6, Reduced1 = 13, Reduced2 = 5.5, Reduced3 = 2.1, Increased1 = 25, Increased2 = 28 });
	rates["fr"].Add(new VatRate { StartDate = new DateTime(1990,  1,  1), Standard = 18.6, Reduced1 = 13, Reduced2 = 5.5, Reduced3 = 2.1, Increased1 = 25 });
	rates["fr"].Add(new VatRate { StartDate = new DateTime(1990,  9, 13), Standard = 18.6, Reduced1 = 13, Reduced2 = 5.5, Reduced3 = 2.1, Increased1 = 22 });
	rates["fr"].Add(new VatRate { StartDate = new DateTime(1991,  7, 29), Standard = 18.6, Reduced1 = 5.5, Reduced2 = 2.1, Increased1 = 22 });
	rates["fr"].Add(new VatRate { StartDate = new DateTime(1993,  1,  1), Standard = 18.6, Reduced1 = 5.5, Reduced2 = 2.1 });
	rates["fr"].Add(new VatRate { StartDate = new DateTime(1995,  8,  1), Standard = 20.6,Reduced1 = 5.5, Reduced2 = 2.1 });
	rates["fr"].Add(new VatRate { StartDate = new DateTime(2000,  4,  1), Standard = 19.6, Reduced1 = 5.5, Reduced2 = 2.1 });
	rates["fr"].Add(new VatRate { StartDate = new DateTime(2012,  1,  1), Standard = 19.6, Reduced1 = 7, Reduced2 = 5.5, Reduced3 = 2.1 });
	rates["fr"].Add(new VatRate { StartDate = new DateTime(2014,  1,  1), Standard = 20, Reduced1 = 10, Reduced2 = 5.5, Reduced3 = 2.1 });
	
	// Croatia
	rates.Add("hr", new List<VatRate>());
	rates["hr"].Add(new VatRate { StartDate = new DateTime(1998,  8,  1), Standard = 22 });
	rates["hr"].Add(new VatRate { StartDate = new DateTime(1999, 11,  1), Standard = 22, Reduced1 = 0 });
	rates["hr"].Add(new VatRate { StartDate = new DateTime(2006,  1,  1), Standard = 22, Reduced1 = 10, Reduced2 = 0 });
	rates["hr"].Add(new VatRate { StartDate = new DateTime(2009,  8,  1), Standard = 23, Reduced1 = 10, Reduced2 = 0 });
	rates["hr"].Add(new VatRate { StartDate = new DateTime(2012,  3,  1), Standard = 25, Reduced1 = 10, Reduced2 = 0 });
	rates["hr"].Add(new VatRate { StartDate = new DateTime(2013,  1,  1), Standard = 25, Reduced1 = 10, Reduced2 = 5 });
	rates["hr"].Add(new VatRate { StartDate = new DateTime(2014,  1,  1), Standard = 25, Reduced1 = 13, Reduced2 = 5 });
	
	// Ireland
	rates.Add("ie", new List<VatRate>());
	rates["ie"].Add(new VatRate { StartDate = new DateTime(1972, 11,  1), Standard = 16.37, Reduced1 = 5.26, Reduced2 = 1, Increased1 = 30.26, Parking1 = 11.11 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(1973,  9,  3), Standard = 19.5, Reduced1 = 6.75, Reduced2 = 1, Increased1 = 36.75, Parking1 = 11.11 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(1976,  3,  1), Standard = 20, Reduced1 = 10, Increased1 = 35, Increased2 = 40 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(1979,  3,  1), Standard = 20, Reduced1 = 10, Reduced2 = 1 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(1980,  5,  1), Standard = 25, Reduced1 = 10, Reduced2 = 1 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(1981,  9,  1), Standard = 25, Reduced1 = 15, Reduced2 = 1.5 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(1982,  5,  1), Standard = 30, Reduced1 = 18, Reduced2 = 1.8 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(1983,  3,  1), Standard = 35, Reduced1 = 23, Reduced2 = 2.3 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(1983,  5,  1), Standard = 35, StandardAlt = 23, Reduced1 = 18, Reduced2 = 5, Reduced3 = 2.3 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(1983,  7,  1), Standard = 35, StandardAlt = 23, Reduced1 = 18, Reduced2 = 5, Reduced3 = 2 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(1984,  5,  1), Standard = 35, StandardAlt = 23, Reduced1 = 18, Reduced2 = 8, Reduced3 = 5, Reduced4 = 2 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(1985,  3,  1), Standard = 23, Reduced1 = 10, Reduced2 = 2.2 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(1986,  3,  1), Standard = 25, Reduced1 = 10, Reduced2 = 2.4 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(1987,  5,  1), Standard = 25, Reduced1 = 10, Reduced2 = 1.7 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(1988,  3,  1), Standard = 25, Reduced1 = 10, Reduced2 = 5, Reduced3 = 1.4 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(1989,  3,  1), Standard = 25, Reduced1 = 10, Reduced2 = 5, Reduced3 = 2 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(1990,  3,  1), Standard = 23, Reduced1 = 10, Reduced2 = 2.3 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(1991,  3,  1), Standard = 21, Reduced1 = 12.5, Reduced2 = 10, Reduced3 = 2.3 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(1992,  3,  1), Standard = 21, Reduced1 = 12.5, Reduced2 = 10, Reduced3 = 2.7, Parking1 = 16 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(1993,  3,  1), Standard = 21, Reduced1 = 12.5, Reduced2 = 2.5, Parking1 = 12.5 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(1996,  1,  1), Standard = 21, Reduced1 = 12.5, Reduced2 = 2.8, Parking1 = 12.5 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(1997,  3,  1), Standard = 21, Reduced1 = 12.5, Reduced2 = 3.3, Parking1 = 12.5 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(1998,  3,  1), Standard = 21, Reduced1 = 12.5, Reduced2 = 3.6, Parking1 = 12.5 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(1999,  3,  1), Standard = 21, Reduced1 = 12.5, Reduced2 = 4, Parking1 = 12.5 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(2000,  3,  1), Standard = 21, Reduced1 = 12.5, Reduced2 = 4.2, Parking1 = 12.5 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(2001,  1,  1), Standard = 20, Reduced1 = 12.5, Reduced2 = 4.3, Parking1 = 12.5 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(2002,  3,  1), Standard = 21, Reduced1 = 12.5, Reduced2 = 4.3, Parking1 = 12.5 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(2003,  1,  1), Standard = 21, Reduced1 = 13.5, Reduced2 = 4.3, Parking1 = 13.5 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(2004,  1,  1), Standard = 21, Reduced1 = 13.5, Reduced2 = 4.4, Parking1 = 13.5 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(2005,  1,  1), Standard = 21, Reduced1 = 13.5, Reduced2 = 4.8, Parking1 = 13.5 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(2008, 12,  1), Standard = 21.5, Reduced1 = 13.5, Reduced2 = 4.8, Parking1 = 13.5 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(2010,  3,  1), Standard = 21, Reduced1 = 13.5, Reduced2 = 4.8, Parking1 = 13.5 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(2011,  7,  1), Standard = 21, Reduced1 = 13.5, Reduced2 = 9, Reduced3 = 4.8, Parking1 = 13.5 });
	rates["ie"].Add(new VatRate { StartDate = new DateTime(2012,  1,  1), Standard = 23, Reduced1 = 13.5, Reduced2 = 9, Reduced3 = 4.8, Parking1 = 13.5 });
	
	// Italy
	rates.Add("it", new List<VatRate>());
	rates["it"].Add(new VatRate { StartDate = new DateTime(1973,  1,  1), Standard = 12, Reduced1 = 6, Increased1 = 18 });
	rates["it"].Add(new VatRate { StartDate = new DateTime(1975,  1,  1), Standard = 12, Reduced1 = 6, Increased1 = 30, Parking1 = 18 });
	rates["it"].Add(new VatRate { StartDate = new DateTime(1976,  3, 18), Standard = 12, Reduced1 = 6, Increased1 = 30, Parking1 = 18 });
	rates["it"].Add(new VatRate { StartDate = new DateTime(1976,  6, 10), Standard = 12, Reduced1 = 9, Reduced2 = 6, Increased1 = 30, Parking1 = 18 });
	rates["it"].Add(new VatRate { StartDate = new DateTime(1976, 12, 23), Standard = 12, Reduced1 = 9, Reduced2 = 6, Reduced3 = 3, Reduced4 = 1, Increased1 = 30, Parking1 = 18 });
	rates["it"].Add(new VatRate { StartDate = new DateTime(1977,  2,  8), Standard = 14, Reduced1 = 12, Reduced2 = 9, Reduced3 = 6, Reduced4 = 3, Reduced5 = 1, Increased1 = 35, Parking1 = 18 });
	rates["it"].Add(new VatRate { StartDate = new DateTime(1980,  7,  3), Standard = 15, Reduced1 = 8, Reduced2 = 2, Increased1 = 35, Parking1 = 18 });
	rates["it"].Add(new VatRate { StartDate = new DateTime(1980, 11,  1), Standard = 14, Reduced1 = 12, Reduced2 = 9, Reduced3 = 6, Reduced4 = 3, Reduced5 = 2, Reduced6 = 1, Increased1 = 35, Parking1 = 15, Parking2 = 18 });
	rates["it"].Add(new VatRate { StartDate = new DateTime(1981,  1,  1), Standard = 15, Reduced1 = 8, Reduced2 = 2, Increased1 = 35, Parking1 = 18 });
	rates["it"].Add(new VatRate { StartDate = new DateTime(1982,  8,  5), Standard = 18, Reduced1 = 15, Reduced2 = 10, Reduced3 = 8, Reduced4 = 2, Increased1 = 38, Parking1 = 20 });
	rates["it"].Add(new VatRate { StartDate = new DateTime(1984,  4, 19), Standard = 18, Reduced1 = 15, Reduced2 = 10, Reduced3 = 8, Reduced4 = 2, Increased1 = 30, Increased2 = 38, Parking1 = 20 });
	rates["it"].Add(new VatRate { StartDate = new DateTime(1984, 12, 20), Standard = 18, Reduced1 = 9, Reduced2 = 2, Increased1 = 30 });
	rates["it"].Add(new VatRate { StartDate = new DateTime(1988,  8,  1), Standard = 19, Reduced1 = 9, Reduced2 = 2, Increased1 = 38 });
	rates["it"].Add(new VatRate { StartDate = new DateTime(1989,  1,  1), Standard = 19, Reduced1 = 9, Reduced2 = 4, Increased1 = 38 });
	rates["it"].Add(new VatRate { StartDate = new DateTime(1991,  5, 13), Standard = 19, Reduced1 = 12, Reduced2 = 9, Reduced3 = 4, Increased1 = 38 });
	rates["it"].Add(new VatRate { StartDate = new DateTime(1993,  1,  1), Standard = 19, Reduced1 = 9, Reduced2 = 4, Parking1 = 12 });
	rates["it"].Add(new VatRate { StartDate = new DateTime(1994,  1,  1), Standard = 19, Reduced1 = 9, Reduced2 = 4, Parking1 = 13 });
	rates["it"].Add(new VatRate { StartDate = new DateTime(1995,  2, 24), Standard = 19, Reduced1 = 10, Reduced2 = 4, Parking1 = 16 });
	rates["it"].Add(new VatRate { StartDate = new DateTime(1997, 10,  1), Standard = 20, Reduced1 = 10, Reduced2 = 4 });
	rates["it"].Add(new VatRate { StartDate = new DateTime(2011,  9, 17), Standard = 21, Reduced1 = 10, Reduced2 = 4 });
	rates["it"].Add(new VatRate { StartDate = new DateTime(2013, 10,  1), Standard = 22, Reduced1 = 10, Reduced2 = 4 });
	rates["it"].Add(new VatRate { StartDate = new DateTime(2016,  1,  1), Standard = 22, Reduced1 = 10, Reduced2 = 5, Reduced3 = 4 });
	
	// Cyprus
	rates.Add("cy", new List<VatRate>());
	rates["cy"].Add(new VatRate { StartDate = new DateTime(1992,  7,  1), Standard = 5 });
	rates["cy"].Add(new VatRate { StartDate = new DateTime(1993, 10,  1), Standard = 8 });
	rates["cy"].Add(new VatRate { StartDate = new DateTime(2000,  7,  1), Standard = 10, Reduced1 = 5 });
	rates["cy"].Add(new VatRate { StartDate = new DateTime(2002,  7,  1), Standard = 13, Reduced1 = 5 });
	rates["cy"].Add(new VatRate { StartDate = new DateTime(2003,  1,  1), Standard = 15, Reduced1 = 5 });
	rates["cy"].Add(new VatRate { StartDate = new DateTime(2005,  8,  1), Standard = 15, Reduced1 = 8, Reduced2 = 5 });
	rates["cy"].Add(new VatRate { StartDate = new DateTime(2012,  3,  1), Standard = 17, Reduced1 = 8, Reduced2 = 5 });
	rates["cy"].Add(new VatRate { StartDate = new DateTime(2013,  1, 14), Standard = 18, Reduced1 = 8, Reduced2 = 5 });
	rates["cy"].Add(new VatRate { StartDate = new DateTime(2014,  1, 13), Standard = 19, Reduced1 = 9, Reduced2 = 5 });
	
	// Latvia
	rates.Add("lv", new List<VatRate>());
	rates["lv"].Add(new VatRate { StartDate = new DateTime(1995,  5,  1), Standard = 18 });
	rates["lv"].Add(new VatRate { StartDate = new DateTime(2003,  1,  1), Standard = 18, Reduced1 = 9 });
	rates["lv"].Add(new VatRate { StartDate = new DateTime(2004,  5,  1), Standard = 18, Reduced1 = 5 });
	rates["lv"].Add(new VatRate { StartDate = new DateTime(2009,  1,  1), Standard = 21, Reduced1 = 10 });
	rates["lv"].Add(new VatRate { StartDate = new DateTime(2011,  1,  1), Standard = 22, Reduced1 = 12 });
	rates["lv"].Add(new VatRate { StartDate = new DateTime(2012,  7,  1), Standard = 21, Reduced1 = 12 });
	
	// Lithuania
	rates.Add("lt", new List<VatRate>());
	rates["lt"].Add(new VatRate { StartDate = new DateTime(1994,  5,  1), Standard = 18 });
	rates["lt"].Add(new VatRate { StartDate = new DateTime(1994,  8,  1), Standard = 18, Reduced1 = 9 });
	rates["lt"].Add(new VatRate { StartDate = new DateTime(1997,  1,  1), Standard = 18 });
	rates["lt"].Add(new VatRate { StartDate = new DateTime(2000,  5,  1), Standard = 18, Reduced1 = 5 });
	rates["lt"].Add(new VatRate { StartDate = new DateTime(2001,  1,  1), Standard = 18, Reduced1 = 9, Reduced2 = 5 });
	rates["lt"].Add(new VatRate { StartDate = new DateTime(2009,  1,  1), Standard = 19, Reduced1 = 9, Reduced2 = 5 });
	rates["lt"].Add(new VatRate { StartDate = new DateTime(2009,  9,  1), Standard = 21, Reduced1 = 9, Reduced2 = 5 });
	
	// Luxembourg
	rates.Add("lu", new List<VatRate>());
	rates["lu"].Add(new VatRate { StartDate = new DateTime(1970,  1,  1), Standard = 8, Reduced1 = 4 });
	rates["lu"].Add(new VatRate { StartDate = new DateTime(1971,  1,  1), Standard = 10, Reduced1 = 5, Reduced2 = 2 });
	rates["lu"].Add(new VatRate { StartDate = new DateTime(1983,  1,  1), Standard = 12, Reduced1 = 6, Reduced2 = 3 });
	rates["lu"].Add(new VatRate { StartDate = new DateTime(1992,  1,  1), Standard = 15, Reduced1 = 6, Reduced2 = 3 });
	rates["lu"].Add(new VatRate { StartDate = new DateTime(1993,  1,  1), Standard = 15, Reduced1 = 6, Reduced2 = 3, Parking1 = 12 });
	rates["lu"].Add(new VatRate { StartDate = new DateTime(2015,  1,  1), Standard = 17, Reduced1 = 8, Reduced2 = 3, Parking1 = 14 });
	
	// Hungary
	rates.Add("hu", new List<VatRate>());
	rates["hu"].Add(new VatRate { StartDate = new DateTime(1988,  1,  1), Standard = 25, Reduced1 = 15, Reduced2 = 0 });
	rates["hu"].Add(new VatRate { StartDate = new DateTime(1993,  1,  1), Standard = 25, Reduced1 = 6, Reduced2 = 0 });
	rates["hu"].Add(new VatRate { StartDate = new DateTime(1993,  8,  1), Standard = 25, Reduced1 = 10 });
	rates["hu"].Add(new VatRate { StartDate = new DateTime(1995,  1,  1), Standard = 25, Reduced1 = 12, Reduced2 = 0 });
	rates["hu"].Add(new VatRate { StartDate = new DateTime(2004,  1,  1), Standard = 25, Reduced1 = 15, Reduced2 = 5 });
	rates["hu"].Add(new VatRate { StartDate = new DateTime(2006,  1,  1), Standard = 20, Reduced1 = 15, Reduced2 = 5 });
	rates["hu"].Add(new VatRate { StartDate = new DateTime(2006,  9,  1), Standard = 20, Reduced1 = 5 });
	rates["hu"].Add(new VatRate { StartDate = new DateTime(2009,  7,  1), Standard = 25, Reduced1 = 18, Reduced2 = 5 });
	rates["hu"].Add(new VatRate { StartDate = new DateTime(2012,  1,  1), Standard = 27, Reduced1 = 18, Reduced2 = 5 });
	
	// Malta
	rates.Add("mt", new List<VatRate>());
	rates["mt"].Add(new VatRate { StartDate = new DateTime(1995,  1,  1), Standard = 15, Reduced1 = 5 });
	rates["mt"].Add(new VatRate { StartDate = new DateTime(1999,  1,  1), Standard = 15, Reduced1 = 5 });
	rates["mt"].Add(new VatRate { StartDate = new DateTime(2004,  1,  1), Standard = 18, Reduced1 = 5 });
	rates["mt"].Add(new VatRate { StartDate = new DateTime(2011,  1,  1), Standard = 18, Reduced1 = 7, Reduced2 = 5 });
	
	// Netherlands
	rates.Add("nl", new List<VatRate>());
	rates["nl"].Add(new VatRate { StartDate = new DateTime(1969,  1,  1), Standard = 12, Reduced1 = 4 });
	rates["nl"].Add(new VatRate { StartDate = new DateTime(1971,  1,  1), Standard = 14, Reduced1 = 4 });
	rates["nl"].Add(new VatRate { StartDate = new DateTime(1973,  1,  1), Standard = 16, Reduced1 = 4 });
	rates["nl"].Add(new VatRate { StartDate = new DateTime(1976,  1,  1), Standard = 18, Reduced1 = 4 });
	rates["nl"].Add(new VatRate { StartDate = new DateTime(1984,  1,  1), Standard = 19, Reduced1 = 5 });
	rates["nl"].Add(new VatRate { StartDate = new DateTime(1986,  1,  1), Standard = 20, Reduced1 = 6 });
	rates["nl"].Add(new VatRate { StartDate = new DateTime(1989,  1,  1), Standard = 18.5, Reduced1 = 6 });
	rates["nl"].Add(new VatRate { StartDate = new DateTime(1992,  1,  1), Standard = 17.5, Reduced1 = 6 });
	rates["nl"].Add(new VatRate { StartDate = new DateTime(2001,  1,  1), Standard = 19, Reduced1 = 6 });
	rates["nl"].Add(new VatRate { StartDate = new DateTime(2012,  1,  1), Standard = 21, Reduced1 = 6 });
	rates["nl"].Add(new VatRate { StartDate = new DateTime(2019,  1,  1), Standard = 21, Reduced1 = 9 });

	// Austria
	rates.Add("at", new List<VatRate>());
	rates["at"].Add(new VatRate { StartDate = new DateTime(1973,  1,  1), Standard = 16, Reduced1 = 8 });
	rates["at"].Add(new VatRate { StartDate = new DateTime(1976,  1,  1), Standard = 18, Reduced1 = 8 });
	rates["at"].Add(new VatRate { StartDate = new DateTime(1978,  1,  1), Standard = 18, Reduced1 = 8, Increased1 = 30, Parking1 = 30 });
	rates["at"].Add(new VatRate { StartDate = new DateTime(1981,  1,  1), Standard = 18, Reduced1 = 13, Reduced2 = 8, Increased1 = 30, Parking1 = 30 });
	rates["at"].Add(new VatRate { StartDate = new DateTime(1984,  1,  1), Standard = 20, Reduced1 = 10, Increased1 = 32, Parking1 = 32 });
	rates["at"].Add(new VatRate { StartDate = new DateTime(1992,  1,  1), Standard = 20, Reduced1 = 10 });
	rates["at"].Add(new VatRate { StartDate = new DateTime(1995,  1,  1), Standard = 20, Reduced1 = 10, Parking1 = 12 });
	rates["at"].Add(new VatRate { StartDate = new DateTime(2016,  1,  1), Standard = 20, Reduced1 = 13, Reduced2 = 10, Parking1 = 12 });

	// Poland
	rates.Add("pl", new List<VatRate>());
	rates["pl"].Add(new VatRate { StartDate = new DateTime(1993,  1,  8), Standard = 22, Reduced1 = 7 });
	rates["pl"].Add(new VatRate { StartDate = new DateTime(2000,  9,  4), Standard = 22, Reduced1 = 7, Reduced2 = 3 });
	rates["pl"].Add(new VatRate { StartDate = new DateTime(2011,  1,  1), Standard = 23, Reduced1 = 8, Reduced2 = 5 });
	
	// Portugal
	rates.Add("pt", new List<VatRate>());
	rates["pt"].Add(new VatRate { StartDate = new DateTime(1986,  1,  1), Standard = 16, Reduced1 = 8, Increased1 = 30 });
	rates["pt"].Add(new VatRate { StartDate = new DateTime(1988,  2,  1), Standard = 17, Reduced1 = 8, Increased1 = 30 });
	rates["pt"].Add(new VatRate { StartDate = new DateTime(1992,  3, 24), Standard = 16, Reduced1 = 5, Increased1 = 30 });
	rates["pt"].Add(new VatRate { StartDate = new DateTime(1995,  1,  1), Standard = 17, Reduced1 = 5 });
	rates["pt"].Add(new VatRate { StartDate = new DateTime(1996,  7,  1), Standard = 17, Reduced1 = 12, Reduced2 = 5 });
	rates["pt"].Add(new VatRate { StartDate = new DateTime(2002,  6,  5), Standard = 19, Reduced1 = 12, Reduced2 = 5, Parking1 = 12 });
	rates["pt"].Add(new VatRate { StartDate = new DateTime(2005,  7,  1), Standard = 21, Reduced1 = 12, Reduced2 = 5, Parking1 = 12 });
	rates["pt"].Add(new VatRate { StartDate = new DateTime(2008,  7,  1), Standard = 20, Reduced1 = 12, Reduced2 = 5, Parking1 = 12 });
	rates["pt"].Add(new VatRate { StartDate = new DateTime(2010,  7,  1), Standard = 21, Reduced1 = 13, Reduced2 = 6, Parking1 = 13 });
	rates["pt"].Add(new VatRate { StartDate = new DateTime(2011,  1,  1), Standard = 23, Reduced1 = 13, Reduced2 = 6, Parking1 = 13 });
	
	// Romania
	rates.Add("ro", new List<VatRate>());
	rates["ro"].Add(new VatRate { StartDate = new DateTime(1993,  7,  1), Standard = 18 });
	rates["ro"].Add(new VatRate { StartDate = new DateTime(1995,  1,  1), Standard = 18, Reduced1 = 9 });
	rates["ro"].Add(new VatRate { StartDate = new DateTime(1998,  2,  1), Standard = 22, Reduced1 = 11 });
	rates["ro"].Add(new VatRate { StartDate = new DateTime(2000,  1,  1), Standard = 19 });
	rates["ro"].Add(new VatRate { StartDate = new DateTime(2004,  1,  1), Standard = 19, Reduced1 = 9 });
	rates["ro"].Add(new VatRate { StartDate = new DateTime(2008, 12,  1), Standard = 19, Reduced1 = 9, Reduced2 = 5 });
	rates["ro"].Add(new VatRate { StartDate = new DateTime(2010,  7,  1), Standard = 24, Reduced1 = 9, Reduced2 = 5 });
	rates["ro"].Add(new VatRate { StartDate = new DateTime(2016,  1,  1), Standard = 20, Reduced1 = 9, Reduced2 = 5 });
	rates["ro"].Add(new VatRate { StartDate = new DateTime(2017,  1,  1), Standard = 19, Reduced1 = 9, Reduced2 = 5 });

	// Slovenia
	rates.Add("si", new List<VatRate>());
	rates["si"].Add(new VatRate { StartDate = new DateTime(1999,  7,  1), Standard = 19, Reduced1 = 8 });
	rates["si"].Add(new VatRate { StartDate = new DateTime(2002,  1,  1), Standard = 20, Reduced1 = 8.5 });
	rates["si"].Add(new VatRate { StartDate = new DateTime(2013,  7,  1), Standard = 22, Reduced1 = 9.5 });
	
	// Slovakia
	rates.Add("sk", new List<VatRate>());
	rates["sk"].Add(new VatRate { StartDate = new DateTime(1993,  1,  1), Standard = 23, Reduced1 = 5 });
	rates["sk"].Add(new VatRate { StartDate = new DateTime(1993,  8,  1), Standard = 25, Reduced1 = 6 });
	rates["sk"].Add(new VatRate { StartDate = new DateTime(1996,  1,  1), Standard = 23, Reduced1 = 6 });
	rates["sk"].Add(new VatRate { StartDate = new DateTime(1999,  7,  1), Standard = 23, Reduced1 = 10 });
	rates["sk"].Add(new VatRate { StartDate = new DateTime(2003,  1,  1), Standard = 20, Reduced1 = 14 });
	rates["sk"].Add(new VatRate { StartDate = new DateTime(2004,  1,  1), Standard = 19 });
	rates["sk"].Add(new VatRate { StartDate = new DateTime(2007,  1,  1), Standard = 19, Reduced1 = 10 });
	rates["sk"].Add(new VatRate { StartDate = new DateTime(2010,  5,  1), Standard = 19, Reduced1 = 10, Reduced2 = 6 });
	rates["sk"].Add(new VatRate { StartDate = new DateTime(2011,  1,  1), Standard = 20, Reduced1 = 10 });
	
	// Finland
	rates.Add("fi", new List<VatRate>());
	rates["fi"].Add(new VatRate { StartDate = new DateTime(1994,  6,  1), Standard = 22, Reduced1 = 12, Reduced2 = 5 });
	rates["fi"].Add(new VatRate { StartDate = new DateTime(1995,  1,  1), Standard = 22, Reduced1 = 17, Reduced2 = 12, Reduced3 = 6 });
	rates["fi"].Add(new VatRate { StartDate = new DateTime(1998,  1,  1), Standard = 22, Reduced1 = 17, Reduced2 = 8 });
	rates["fi"].Add(new VatRate { StartDate = new DateTime(2009, 10,  1), Standard = 22, Reduced1 = 12, Reduced2 = 8 });
	rates["fi"].Add(new VatRate { StartDate = new DateTime(2010,  7,  1), Standard = 23, Reduced1 = 13, Reduced2 = 9 });
	rates["fi"].Add(new VatRate { StartDate = new DateTime(2013,  1,  1), Standard = 24, Reduced1 = 14, Reduced2 = 10 });
	
	// Sweden
	rates.Add("se", new List<VatRate>());
	rates["se"].Add(new VatRate { StartDate = new DateTime(1969,  1,  1), Standard = 11.11, Reduced1 = 6.38, Reduced2 = 2.04 });
	rates["se"].Add(new VatRate { StartDate = new DateTime(1971,  1,  1), Standard = 17.65, Reduced1 = 9.89, Reduced2 = 3.09 });
	rates["se"].Add(new VatRate { StartDate = new DateTime(1977,  6,  1), Standard = 20.63, Reduced1 = 11.43, Reduced2 = 3.54 });
	rates["se"].Add(new VatRate { StartDate = new DateTime(1980,  9,  8), Standard = 23.46, Reduced1 = 12.87, Reduced2 = 3.95 });
	rates["se"].Add(new VatRate { StartDate = new DateTime(1981, 11, 16), Standard = 21.51, Reduced1 = 11.88, Reduced2 = 3.67 });
	rates["se"].Add(new VatRate { StartDate = new DateTime(1983,  1,  1), Standard = 23.46, Reduced1 = 12.87, Reduced2 = 3.95 });
	rates["se"].Add(new VatRate { StartDate = new DateTime(1990,  7,  1), Standard = 25, Reduced1 = 13.64, Reduced2 = 4.17 });
	rates["se"].Add(new VatRate { StartDate = new DateTime(1992,  1,  1), Standard = 25, Reduced1 = 18 });
	rates["se"].Add(new VatRate { StartDate = new DateTime(1993,  1,  1), Standard = 25, Reduced1 = 21 });
	rates["se"].Add(new VatRate { StartDate = new DateTime(1993,  7,  1), Standard = 25, Reduced1 = 21, Reduced2 = 12 });
	rates["se"].Add(new VatRate { StartDate = new DateTime(1996,  1,  1), Standard = 25, Reduced1 = 12, Reduced2 = 6 });
	
	// United Kingdom
	rates.Add("uk", new List<VatRate>());
	rates["uk"].Add(new VatRate { StartDate = new DateTime(1973,  4,  1), Standard = 10 });
	rates["uk"].Add(new VatRate { StartDate = new DateTime(1974,  7, 29), Standard = 8 });
	rates["uk"].Add(new VatRate { StartDate = new DateTime(1974, 11, 18), Standard = 8, Increased1 = 25 });
	rates["uk"].Add(new VatRate { StartDate = new DateTime(1976,  4, 12), Standard = 8, Increased1 = 12.5 });
	rates["uk"].Add(new VatRate { StartDate = new DateTime(1979,  6, 18), Standard = 15 });
	rates["uk"].Add(new VatRate { StartDate = new DateTime(1991,  4,  1), Standard = 17.5 });
	rates["uk"].Add(new VatRate { StartDate = new DateTime(1994,  4,  1), Standard = 17.5, Parking1 = 8 });
	rates["uk"].Add(new VatRate { StartDate = new DateTime(1995,  1,  1), Standard = 17.5, Reduced1 = 8 });
	rates["uk"].Add(new VatRate { StartDate = new DateTime(1997,  9,  1), Standard = 17.5, Reduced1 = 5 });
	rates["uk"].Add(new VatRate { StartDate = new DateTime(2008, 12,  1), Standard = 15, Reduced1 = 5 });
	rates["uk"].Add(new VatRate { StartDate = new DateTime(2010,  1,  1), Standard = 17.5, Reduced1 = 5 });
	rates["uk"].Add(new VatRate { StartDate = new DateTime(2011,  1,  4), Standard = 20, Reduced1 = 5 });
	
	rates.Add("gb", rates["uk"]);

	// -----

	// save JSON file to desktop
	var settings = new JsonSerializerSettings {
		Converters = { new Newtonsoft.Json.Converters.IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd" } },
		NullValueHandling = NullValueHandling.Ignore
	};
	
	string json = JsonConvert.SerializeObject(rates, Newtonsoft.Json.Formatting.Indented, settings);
	File.WriteAllText(Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop), "eu-vat-rates.json"), json);
	
	json = JsonConvert.SerializeObject(rates, Newtonsoft.Json.Formatting.None, settings);
	File.WriteAllText(Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop), "eu-vat-rates-min.json"), json);
}

class VatRate
{
	public DateTime StartDate { get; set; }
	
	public double Standard { get; set; }
	public double? StandardAlt { get; set; }
	
	public double? Reduced1 { get; set; }
	public double? Reduced2 { get; set; }
	public double? Reduced3 { get; set; }
	public double? Reduced4 { get; set; }
	public double? Reduced5 { get; set; }
	public double? Reduced6 { get; set; }
	
	public double? Increased1 { get; set; }
	public double? Increased2 { get; set; }
	
	public double? Parking1 { get; set; }
	public double? Parking2 { get; set; }
}