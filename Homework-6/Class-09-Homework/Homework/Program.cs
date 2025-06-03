using System;
using System.IO;

       

        string folderPath = @"..\..\..\Files";
        string namesFile = folderPath + "/names.txt";

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }

        if (!File.Exists(namesFile))
        {
            File.Create(namesFile).Close();
        }

      

        Console.WriteLine("Enter names one by one. Type 'done' to finish:");

        while (true)
        {
            string name = Console.ReadLine();

            if (name.ToLower() == "done")
            {
                break;
            }

            File.AppendAllText(namesFile, name + "\n");
        }

       

        string[] allNames = File.ReadAllLines(namesFile);

        for (char letter = 'A'; letter <= 'Z'; letter++)
        {
            string letterFile = folderPath + "/namesStartingWith_" + letter + ".txt";

            foreach (string name in allNames)
            {
                if (name == "") continue;

                string upperName = name.ToUpper();

                if (upperName.StartsWith(letter.ToString()))
                {
                    bool nameAlreadyExists = false;

                    if (File.Exists(letterFile))
                    {
                        string[] existingNames = File.ReadAllLines(letterFile);

                        foreach (string existingName in existingNames)
                        {
                            if (existingName == name)
                            {
                                nameAlreadyExists = true;
                                break;
                            }
                        }
                    }

                    if (!nameAlreadyExists)
                    {
                        File.AppendAllText(letterFile, name + "\n");
                    }
                }
            }
        }

        Console.WriteLine("All names have been saved and sorted.");