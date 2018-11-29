using System.Collections.Generic;

namespace CdOrganizer.Models
{
  public class Artist
  {
    private static List<Artist> _instances = new List<Artist> {};
    private string _name;
    private int _id;
    private List<Album> _albums;

    public Artist(string artistName)
    {
      _name = artistName;
      _instances.Add(this);
      _id = _instances.Count;
      _albums = new List<Album>{};
    }

    public string GetName()
    {
      return _name;
    }

    public int GetId()
    {
      return _id;
    }

    public static void ClearAll()
    {
        _instances.Clear();
    }

    public static List<Artist> GetAll()
    {
      return _instances;
    }

    public static Artist Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public static Artist Search(string searchName)
    {
      string temp = "";
      Artist tempArtist = new Artist(temp);
      foreach(Artist artist in _instances)
      {
        if(searchName == artist.GetName())
        {
          tempArtist= artist;
        
        }
      }
      return tempArtist;
      
    }

    public List<Album> GetAlbums()
    {
        return _albums;
    }

    public void AddAlbum(Album album)
    {
        _albums.Add(album);
    }
  }
}