using JsonVisualizer.Services;
using JsonVisualizer.Utils;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("▶ JsonVisualizer (SkiaSharp version)");

        var api = new ApiService();
        var entries = await api.FetchTimeEntriesAsync();

        Console.WriteLine($"▶ Retrieved {entries.Count} entries");

        if (entries.Count == 0)
        {
            Console.WriteLine("⚠ No data fetched ‑ exiting.");
            return;
        }

        HtmlRenderer.GenerateHtml(entries);
        PieChartGenerator.GeneratePieChart(entries);

        Console.WriteLine("✅ Done. Check Output/ folder.");
    }
}