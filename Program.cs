using GoodsReceipt.Data;
using GoodsReceipt.Forms;

namespace GoodsReceipt;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        // Initialize SQLite database
        DatabaseInitializer.Initialize();

        Application.Run(new MainForm());
    }
}