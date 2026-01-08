using System;
using System.Collections.Generic;

using System;

public class Song
{
    public string SongName { get; }
    public string Artist { get; }

    public Song(string songName, string artist)
    {
        SongName = songName;
        Artist = artist;
    }

    public override string ToString()
    {
        return $"{SongName} - {Artist}";
    }
}


public class PlayListQueue
{
    private LinkedList<Song> songs = new LinkedList<Song>();

    public void AddSong(Song song)
    {
        songs.AddLast(song);
    }

    public Song PlayNext()   
    {
        if (songs.Count == 0)
            return null;

        Song current = songs.First.Value;
        songs.RemoveFirst();
        return current;
    }

    public int Count => songs.Count;   
}
public abstract class MediaPlayer
{
    public abstract void PlayNext();
    public abstract void AddMedia(string title, string creator);
}


public class MusicPlayer : MediaPlayer
{
    private PlayListQueue playlist = new PlayListQueue();

    public override void AddMedia(string title, string artist)
    {
        playlist.AddSong(new Song(title, artist));
    }

    public override void PlayNext()
    {
        Song song = playlist.PlayNext();

        if (song == null)
            Console.WriteLine("Playlist is empty");
        else
            Console.WriteLine($"Now Playing: {song}");
    }
}

