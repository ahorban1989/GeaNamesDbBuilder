namespace GeaNamesDbBuilder.Data;

using System;

public class GeoNameDto
{

	public int Id { get; set; }
	public string Name { get; set; }
	public string NameAscii { get; set; }
	public string AlternateNames { get; set; }
	public double Latitude { get; set; }
	public double Longitude { get; set; }
	public string FeatureClass { get; set; }
	public string FeatureCode { get; set; }
	public string CountryCode { get; set; }
	public string AlternateCountryCodes { get; set; }
	public string AdminCode1 { get; set; }
	public string AdminCode2 { get; set; }
	public string? AdminCode3 { get; set; }
	public string? AdminCode4 { get; set; }
	public long Population { get; set; }
	public int? Elevation { get; set; }
	public int? Dem { get; set; }
	public string TimeZone { get; set; }
	public DateTime ModificationDate { get; set; }


}