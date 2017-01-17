using UnityEngine;
using System.Collections;
using System;

public class SoundFileInfo {

    public int soundFile_ID;

    private int instrument_id;
    private int octave;
    private string note;
    private int tension_value;

    private string fileName;

    // The fileName needs to be in the following format instID_Octave_Note_TensionValue
    public SoundFileInfo(int soundFile_ID, string fileName)
    {
        this.soundFile_ID = soundFile_ID;

        string[] folder_split = fileName.Split('\\');

        string[] dot_split = folder_split[folder_split.Length - 1].Split('.');
        this.fileName = dot_split[0];

        string[] name_split = dot_split[0].Split('_');
        this.instrument_id = Convert.ToInt32(name_split[0]);
        this.octave = Convert.ToInt32(name_split[1]);
        this.note = name_split[2];
        this.tension_value = Convert.ToInt32(name_split[3]);
    }

    public int getSoundFileID()
    {
        return soundFile_ID;
    }

    public int getInstrumentID(){
        return instrument_id;
    }

    public int getOctave()
    {
        return octave;
    }

    public string getNote()
    {
        return note;
    }

    public int getTensionValue()
    {
        return tension_value;
    }

    public string getFileName()
    {
        return fileName;
    }
}
