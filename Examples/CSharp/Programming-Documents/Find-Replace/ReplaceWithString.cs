﻿using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
using Aspose.Words;
using Aspose.Words.Fields;
using System;

namespace Aspose.Words.Examples.CSharp.Programming_Documents.Find_and_Replace
{
    class ReplaceWithString
    {
        public static void Run()
        {
            //ExStart:ReplaceWithString
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_FindAndReplace();
            string fileName = "Document.doc";

            Document doc = new Document(dataDir + fileName);
            doc.Range.Replace("sad", "bad", false, true);

            dataDir = dataDir + "ReplaceWithString_out_.doc";
            doc.Save(dataDir);
            //ExEnd:ReplaceWithString
            Console.WriteLine("\nText replaced with string successfully.\nFile saved at " + dataDir);
        }
    }

    
}
