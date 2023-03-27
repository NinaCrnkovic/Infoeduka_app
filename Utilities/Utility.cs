namespace Utilities
{
    public class Utility
    {
        //poziv za otvarenje linka algebre
        public static void VisitLink(string url)
        {
            //This will make it behave more like just typing it in the 'Run' window:

            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}