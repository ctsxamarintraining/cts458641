using System;
using System.IO;

namespace File2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Directory.CreateDirectory ("SourceDir");//main directory

			string file1 = Path.Combine ("SourceDir", "file1.txt");
			Console.WriteLine ("file1--->", file);

			File.Create (file1);

			//level 1
			string subDir1 = Path.Combine ("SourceDir", "subDir1");
			Directory.CreateDirectory (subDir1);

			string subDir1file1 = Path.Combine (subDir1, "file1.txt");
			File.Create (subDir1file1);

			string subDir1file2 = Path.Combine (subDir1, "file2.txt");
			File.Create (subDir1file2);

			string subDir1file3 = Path.Combine (subDir1, "file3.txt");
			File.Create (subDir1file3);

			string subDir2 = Path.Combine ("SourceDir", "subDir2");
			Directory.CreateDirectory (subDir2);

			//3 files
			string subDir2file1 = Path.Combine (subDir2, "file1.txt");
			File.Create (subDir2file1);

			string subDir2file2 = Path.Combine (subDir2, "file2.txt");
			File.Create (subDir2file2);

			string subDir2file3 = Path.Combine (subDir2, "file3.txt");
			File.Create (subDir2file3);

			//level 2
			string subDir1_1 = Path.Combine (subDir1, "subDir1_1");
			Directory.CreateDirectory (subDir1_1);

			string subDir1_1file1 = Path.Combine (subDir1_1, "file1.txt");
			File.Create (subDir1_1file1);

			string subDir1_1file2 = Path.Combine (subDir1_1, "file2.txt");
			File.Create (subDir1_1file2);


			//level 3
			string subDir1_1_1 = Path.Combine (subDir1_1, "subDir1_1_1");
			Directory.CreateDirectory (subDir1_1_1);

			string subDir1_1_1file1 = Path.Combine (subDir1_1_1, "file1.txt");
			File.Create (subDir1_1_1file1);

			string subDir1_1_1file2 = Path.Combine (subDir1_1_1, "file2.txt");
			File.Create (subDir1_1_1file2);

			DirectoryCopy ("SourceDir", "DestinationDir", true);
			Console.WriteLine ("Copied successfully");
		}
		private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
		{
			// Get the subdirectories for the specified directory.
			DirectoryInfo dir = new DirectoryInfo(sourceDirName);

			if (!dir.Exists)
			{
				throw new DirectoryNotFoundException(
					"Source directory does not exist or could not be found: "
					+ sourceDirName);
			}

			DirectoryInfo[] dirs = dir.GetDirectories();
			// If the destination directory doesn't exist, create it.
			if (!Directory.Exists(destDirName))
			{
				Directory.CreateDirectory(destDirName);
			}

			// Get the files in the directory and copy them to the new location.
			FileInfo[] files = dir.GetFiles();//fileinfo for copying moving files
			foreach (FileInfo file in files)
			{
				string temppath = Path.Combine(destDirName, file.Name);

				file.CopyTo(temppath, false);
			}

			// If copying subdirectories, copy them and their contents to new location.
			if (copySubDirs)
			{
				foreach (DirectoryInfo subdir in dirs)
				{
					string temppath = Path.Combine(destDirName, subdir.Name);
					DirectoryCopy(subdir.FullName, temppath, copySubDirs);
				}
			}
		}

	}
}