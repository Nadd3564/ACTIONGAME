﻿using System;
using System.IO;

using Cradle;

namespace Cradle.Resource{
public class TextReadWriteManager {

	public void WriteTextFile(string pathAndName, string stringData) { 
		// remove file (if exists)
		FileInfo textFile = new FileInfo(  pathAndName ); 
		if( textFile.Exists ) 
			textFile.Delete(); 
		
		// create new empty file
		StreamWriter writer; 
		writer = textFile.CreateText(); 
		
		// write text to file
		System.DateTime now = System.DateTime.Now;
		writer.Write(now + stringData); 
		
		// close file
		writer.Close(); 
	} 
	
	public string ReadTextFile(string pathAndName) { 
		string dataAsString = "";
		
		try {
			// open text file
			StreamReader textReader = File.OpenText( pathAndName ); 
		
			// read contents
			dataAsString = textReader.ReadToEnd(); 
			
			// close file
			textReader.Close(); 
			
		}	
		catch (Exception e) {
		}
		
		// return contents
		return dataAsString; 
	} 

}
}