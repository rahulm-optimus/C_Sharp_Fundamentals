
// Directory.CreateDirectory(@".\folder");

// Directory.Delete(@".\folder", true);
string pathName2 = @"C:\Users\rahul.mehra\OneDrive - Optimus Information Inc\Desktop\directory";

string[] files = Directory.GetFiles(pathName2, "*.png", SearchOption.TopDirectoryOnly);
foreach (string file in files)
{
    Console.WriteLine(file);
}
