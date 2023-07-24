namespace FisSst.BlazorMaps
{
    /// <summary>
    /// Represents a rectangular geographical area on a map.
    /// </summary>
    public class LatLngBounds
    {
        public LatLngBounds()
        {
        }

        public LatLng _southWest { get; set; }
        public LatLng _northEast { get; set; }
    }
}
