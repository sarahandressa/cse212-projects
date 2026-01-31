public class FeatureCollection
{
    // This matches the top-level "features" array in the JSON
    public List<Feature> Features { get; set; }
}

public class Feature
{
    // This matches the "properties" object inside each feature
    public EarthquakeProperties Properties { get; set; }
}

public class EarthquakeProperties
{
    // This matches the "mag" (magnitude) field
    public double? Mag { get; set; }

    // This matches the "place" (location) field
    public string Place { get; set; }
}