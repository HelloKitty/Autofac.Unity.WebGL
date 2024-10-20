using System.Globalization;

namespace Autofac
{
    /// <summary>
    /// Stubbed resource manager.
    /// </summary>
    public static class StubbedResourceManager
    {
        /// <summary>
        /// Stubs the ResourceManager's GetString function to avoid WebGL compatibility issues.
        /// </summary>
        /// <param name="name">Resource string name.</param>
        /// <param name="culture">Culture.</param>
        /// <returns>The name of the resource.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA1801:Review unused parameters", Justification = "<Pending>")]
        public static string GetString(string name, CultureInfo culture)
        {
            return name;
        }
    }
}
